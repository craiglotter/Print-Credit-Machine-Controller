Imports System.Net.Sockets
Imports System.Net
Imports System
Imports System.Runtime.InteropServices

Namespace ICMP_Packet

    ' Define the structure of an ICMP packet.
    ' This structure contains packet information.
    Structure IcmpPacket
#Region "PUBLIC MEMBER VARIABLES"
        Dim type_message As Byte                ' type of message
        Dim subCode_type As Byte                ' type of sub-code
        Dim complement_checkSum As UInt16       ' one's complement checksum for the structure
        Dim identifier As UInt16                ' identifier
        Dim sequenceNumber As UInt16            ' sequence number
        Dim data() As Byte                      ' data
#End Region


#Region "PUBLIC MEMBER METHODS"
        Public Sub Initialize(ByVal type As Byte, ByVal subCode As Byte, ByVal payload() As Byte)
            Dim index As Integer
            Dim buffer_icmpPacket() As Byte
            Dim cksumBuffer() As UInt16
            Dim icmpHeaderBufferIndex As Int32 = 0
            Me.type_message = type
            Me.subCode_type = subCode
            complement_checkSum = UInt16.Parse("0")
            identifier = UInt16.Parse("45")
            sequenceNumber = UInt16.Parse("0")
            Data = payload

            ' Declare a variable to store the total packet size.
            ' Call the Serialize method to count the total number of bytes in the packet.
            buffer_icmpPacket = Serialize()

            ' Resize a UInt16 array to half the size of the packet.
            ReDim cksumBuffer((buffer_icmpPacket.Length() \ 2) - 1)

            ' Initialize the UInt16 array.
            For index = 0 To (cksumBuffer.Length() - 1)
                cksumBuffer(index) = BitConverter.ToUInt16(buffer_icmpPacket, icmpHeaderBufferIndex)
                icmpHeaderBufferIndex += 2
            Next index

            'Call a method that returns a checksum.
            complement_checkSum = MCheckSum.Calculate(cksumBuffer, cksumBuffer.Length())
        End Sub

        Public Function Size() As Integer
            Return (8 + Data.Length())
        End Function

        ' The Serialize method converts the packet to a byte array to calculate the total size.
        Public Function Serialize() As Byte()
            Dim b_seq() As Byte = BitConverter.GetBytes(sequenceNumber)
            Dim b_cksum() As Byte = BitConverter.GetBytes(complement_checkSum)
            Dim b_id() As Byte = BitConverter.GetBytes(identifier)
            Dim index As Int32 = 0
            Dim buffer() As Byte
            ReDim buffer(Size() - 1)

            ' Serialize the structure into the array.
            buffer(0) = type_message
            buffer(1) = subCode_type
            index += 2
            Array.Copy(b_cksum, 0, buffer, index, 2)
            index += 2
            Array.Copy(b_id, 0, buffer, index, 2)
            index += 2
            Array.Copy(b_seq, 0, buffer, index, 2)
            index += 2

            ' Copy the data.
            If (Data.Length() > 0) Then
                Array.Copy(Data, 0, buffer, index, Data.Length())
            End If
            Return buffer
        End Function
#End Region
    End Structure

    ' The CPing class.
    Public Class CPing
#Region "MEMBER CONSTANTS"
        Private Const DEFAULT_TIMEOUT As Integer = 1000
        Private Const SOCKET_ERROR As Integer = -1
        Private Const PING_ERROR As Integer = -1
        Private Const ICMP_ECHO As Integer = 8
        Private Const DATA_SIZE As Integer = 32
        Private Const RECV_SIZE As Integer = 128
#End Region

#Region "MEMBER VARIABLES"
        Private _open As Boolean = False
        Private _initialized As Boolean
        Private _recvBuffer() As Byte
        Private _packet As IcmpPacket
        Private _hostName As String
        Private _server As EndPoint
        Private _local As EndPoint
        Private _socket As Socket

#End Region

#Region "CONSTRUCTORS & FINALIZER"
        Public Sub New(ByVal hostName As String)
            Me.HostName() = hostName
            ReDim _recvBuffer(RECV_SIZE - 1)
        End Sub

        Public Sub New()
            ' Set the default host name to the local host.
            Me.HostName() = Dns.GetHostName()
            ReDim _recvBuffer(RECV_SIZE - 1)
        End Sub

        Private Overloads Sub finalize()
            ' Ensure that you close the socket.
            Me.Close()
            Erase _recvBuffer
        End Sub
#End Region

#Region "MEMBER METHODS"
        ' Get and set the current host name.
        Public Property HostName() As String
            Get
                Return _hostName
            End Get
            Set(ByVal Value As String)
                _hostName = Value
                ' If the CPing object is already open, close it and then reopen it by using a new host name.
                If (_open) Then
                    Me.Close()
                    Me.Open()
                End If
            End Set
        End Property

        ' Get the state (open or closed).
        Public ReadOnly Property IsOpen() As Boolean
            Get
                Return _open
            End Get
        End Property

        ' Create a socket to host remote end points and local end points.
        Public Function Open() As Boolean
            Dim payload() As Byte

            If (Not _open) Then
                Try
                    ' Initialize the packet.
                    ReDim payload(DATA_SIZE)
                    _packet.Initialize(ICMP_ECHO, 0, payload)

                    ' Initialize an ICMP socket.
                    _socket = New Socket(AddressFamily.InterNetwork, SocketType.Raw, ProtocolType.Icmp)

                    ' Set the server end point.
                    _server = New IPEndPoint(Dns.GetHostByName(_hostName).AddressList(0), 0)

                    ' Set the receiving end point as your client computer.
                    _local = New IPEndPoint(Dns.GetHostByName(Dns.GetHostName()).AddressList(0), 0)
                    _open = True
                Catch
                    Return False
                End Try
            End If
            Return True
        End Function

        ' Destroy the socket and end points (if necessary).
        Public Function Close() As Boolean
            If (_open) Then
                _socket.Close()
                _socket = Nothing
                _server = Nothing
                _local = Nothing
                _open = False
            End If
            Return True
        End Function

        ' Perform a PING operation.
        Public Overloads Function Ping() As Integer
            Return Ping(DEFAULT_TIMEOUT)
        End Function

        ' The Ping method performs a PING operation.
        Public Overloads Function Ping(ByVal timeOutMilliSeconds As Integer) As Integer

            ' Initialize the time-out value.
            Dim timeOut As Integer = timeOutMilliSeconds + Environment.TickCount()

            ' Send the packet.
            If (SOCKET_ERROR = _socket.SendTo(_packet.Serialize(), _packet.Size(), 0, _server)) Then
                Return PING_ERROR
            End If

            ' Use the following loop to check the response time until you receive a time-out.
            Do
                ' Poll the read buffer every millisecond.
                ' If data exists, read the data and return the round-trip time.
                If (_socket.Poll(1000, SelectMode.SelectRead)) Then
                    _socket.ReceiveFrom(_recvBuffer, RECV_SIZE, 0, _local)
                    Return (timeOutMilliSeconds - (timeOut - Environment.TickCount()))
                ElseIf (Environment.TickCount() >= timeOut) Then
                    Return PING_ERROR
                End If
            Loop While (True)
        End Function
#End Region
    End Class

    ' The MCheckSum module contains the static Calculate method.
    Module MCheckSum
#Region "MEMBER METHODS"
        <StructLayout(LayoutKind.Explicit)> _
                   Structure UNION_INT16
            <FieldOffset(0)> Dim lsb As Byte      ' Least significant byte
            <FieldOffset(1)> Dim msb As Byte      ' Most significant byte
            <FieldOffset(0)> Dim w16 As Short
        End Structure

        <StructLayout(LayoutKind.Explicit)> _
        Structure UNION_INT32
            <FieldOffset(0)> Dim lsw As UNION_INT16     ' Most significant word
            <FieldOffset(2)> Dim msw As UNION_INT16     ' Least significant word
            <FieldOffset(0)> Dim w32 As Integer
        End Structure

        ' The Calculate method calculates the checksum value.
        Public Function Calculate(ByRef buffer() As UInt16, ByVal size As Int32) As UInt16
            Dim counter As Int32 = 0
            Dim cksum32 As UNION_INT32
            Do While (size > 0)
                cksum32.w32 += Convert.ToInt32(buffer(counter))
                counter += 1
                size -= 1
            Loop

            cksum32.w32 = cksum32.msw.w16 + cksum32.lsw.w16 + cksum32.msw.w16
            Return Convert.ToUInt16(cksum32.lsw.w16 Xor &HFFFF)
        End Function
#End Region

        'Sub Main()
        '    Dim Packet As New ICMP_Packet.CPing
        '    Dim retValue

        '    Console.WriteLine("Enter the IP address or the host name to ping: ")

        '    ' Accept a host name or an IP address.
        '    Packet.HostName = Trim(Console.ReadLine())

        '    ' Determine whether the user has typed only spaces instead of a host name or an IP address.
        '    If Packet.HostName = "" Then
        '        Console.WriteLine("Please enter an IP address (in the N.N.N.N format) or a host name")
        '    Else
        '        ' Determine whether you can establish a socket connection to the IP address.
        '        If Packet.Open Then
        '            ' Establish a socket connection, and then send a packet by using ICMP.
        '            retValue = Packet.Ping
        '            If retValue <> -1 Then
        '                ' Display the response time in milliseconds.
        '                Console.WriteLine("Approximate response time : " & retValue)
        '            Else
        '                Console.WriteLine("Host Unreachable")
        '            End If
        '        Else
        '            Console.WriteLine("No host found")
        '        End If

        '        Packet.Close()

        '    End If

        '    Console.WriteLine("Press ENTER to quit.")
        '    Console.ReadLine()

        'End Sub
    End Module

End Namespace