Imports System.IO
Imports System.Xml
Imports Microsoft.Win32
Imports System.Web.Mail

Public Class Monitor_Program
    Inherits System.Windows.Forms.Form

#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call

    End Sub

    'Form overrides dispose to clean up the component list.
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents NotifyIcon1 As System.Windows.Forms.NotifyIcon
    Friend WithEvents ContextMenu1 As System.Windows.Forms.ContextMenu
    Friend WithEvents MenuItem1 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem2 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem3 As System.Windows.Forms.MenuItem
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox4 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox5 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox6 As System.Windows.Forms.PictureBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Last_Action As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents Label30 As System.Windows.Forms.Label
    Friend WithEvents Label31 As System.Windows.Forms.Label
    Friend WithEvents Label32 As System.Windows.Forms.Label
    Friend WithEvents Label33 As System.Windows.Forms.Label
    Friend WithEvents Machine_Status_Timer As System.Windows.Forms.Timer
    Friend WithEvents Transaction_Monitor_Timer As System.Windows.Forms.Timer
    Friend WithEvents Directory_Status_Timer As System.Windows.Forms.Timer
    Friend WithEvents Label34 As System.Windows.Forms.Label
    Friend WithEvents Label35 As System.Windows.Forms.Label
    Friend WithEvents Label29 As System.Windows.Forms.Label
    Friend WithEvents Label28 As System.Windows.Forms.Label
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents Label36 As System.Windows.Forms.Label
    Friend WithEvents Current_Time As System.Windows.Forms.Timer
    Friend WithEvents Label37 As System.Windows.Forms.Label
    Friend WithEvents ListBox1 As System.Windows.Forms.ListBox
    Friend WithEvents Label38 As System.Windows.Forms.Label
    Friend WithEvents Transaction_File_Mover As System.Windows.Forms.Timer
    Friend WithEvents Label39 As System.Windows.Forms.Label
    Friend WithEvents Label40 As System.Windows.Forms.Label
    Friend WithEvents Label41 As System.Windows.Forms.Label
    Friend WithEvents Label42 As System.Windows.Forms.Label
    Friend WithEvents Label43 As System.Windows.Forms.Label
    Friend WithEvents LaunchTimeLabel As System.Windows.Forms.Label
    Friend WithEvents transactioncountlabel As System.Windows.Forms.Label
    Friend WithEvents Label44 As System.Windows.Forms.Label
    Friend WithEvents ForceMachineStatus As System.Windows.Forms.Label
    Friend WithEvents MachineStatusLightPicBox As System.Windows.Forms.PictureBox
    Friend WithEvents DirectoryStatusLightPicBox As System.Windows.Forms.PictureBox
    Friend WithEvents ForceDirectoryStatus As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(Monitor_Program))
        Me.Transaction_Monitor_Timer = New System.Windows.Forms.Timer(Me.components)
        Me.Label7 = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.transactioncountlabel = New System.Windows.Forms.Label
        Me.Label44 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.PictureBox6 = New System.Windows.Forms.PictureBox
        Me.PictureBox5 = New System.Windows.Forms.PictureBox
        Me.PictureBox4 = New System.Windows.Forms.PictureBox
        Me.PictureBox3 = New System.Windows.Forms.PictureBox
        Me.PictureBox2 = New System.Windows.Forms.PictureBox
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.ListBox1 = New System.Windows.Forms.ListBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.Last_Action = New System.Windows.Forms.Label
        Me.Label38 = New System.Windows.Forms.Label
        Me.NotifyIcon1 = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.ContextMenu1 = New System.Windows.Forms.ContextMenu
        Me.MenuItem1 = New System.Windows.Forms.MenuItem
        Me.MenuItem3 = New System.Windows.Forms.MenuItem
        Me.MenuItem2 = New System.Windows.Forms.MenuItem
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Label25 = New System.Windows.Forms.Label
        Me.Label37 = New System.Windows.Forms.Label
        Me.Label34 = New System.Windows.Forms.Label
        Me.Label33 = New System.Windows.Forms.Label
        Me.Label32 = New System.Windows.Forms.Label
        Me.Label31 = New System.Windows.Forms.Label
        Me.Label30 = New System.Windows.Forms.Label
        Me.Label35 = New System.Windows.Forms.Label
        Me.Label36 = New System.Windows.Forms.Label
        Me.Label39 = New System.Windows.Forms.Label
        Me.Label40 = New System.Windows.Forms.Label
        Me.Label41 = New System.Windows.Forms.Label
        Me.Label42 = New System.Windows.Forms.Label
        Me.Label43 = New System.Windows.Forms.Label
        Me.LaunchTimeLabel = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.Label29 = New System.Windows.Forms.Label
        Me.Label28 = New System.Windows.Forms.Label
        Me.Label27 = New System.Windows.Forms.Label
        Me.Label24 = New System.Windows.Forms.Label
        Me.Label23 = New System.Windows.Forms.Label
        Me.Label22 = New System.Windows.Forms.Label
        Me.Label21 = New System.Windows.Forms.Label
        Me.Label20 = New System.Windows.Forms.Label
        Me.Label19 = New System.Windows.Forms.Label
        Me.Label18 = New System.Windows.Forms.Label
        Me.Label17 = New System.Windows.Forms.Label
        Me.Label16 = New System.Windows.Forms.Label
        Me.Label15 = New System.Windows.Forms.Label
        Me.Label14 = New System.Windows.Forms.Label
        Me.Label13 = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Machine_Status_Timer = New System.Windows.Forms.Timer(Me.components)
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.Label26 = New System.Windows.Forms.Label
        Me.Directory_Status_Timer = New System.Windows.Forms.Timer(Me.components)
        Me.Current_Time = New System.Windows.Forms.Timer(Me.components)
        Me.Transaction_File_Mover = New System.Windows.Forms.Timer(Me.components)
        Me.ForceMachineStatus = New System.Windows.Forms.Label
        Me.MachineStatusLightPicBox = New System.Windows.Forms.PictureBox
        Me.DirectoryStatusLightPicBox = New System.Windows.Forms.PictureBox
        Me.ForceDirectoryStatus = New System.Windows.Forms.Label
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Transaction_Monitor_Timer
        '
        Me.Transaction_Monitor_Timer.Interval = 1050
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.Gainsboro
        Me.Label7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label7.ForeColor = System.Drawing.Color.Firebrick
        Me.Label7.Location = New System.Drawing.Point(496, 8)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(112, 24)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "Configuration"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.ToolTip1.SetToolTip(Me.Label7, "Configuration Options")
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.transactioncountlabel)
        Me.GroupBox1.Controls.Add(Me.Label44)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.PictureBox6)
        Me.GroupBox1.Controls.Add(Me.PictureBox5)
        Me.GroupBox1.Controls.Add(Me.PictureBox4)
        Me.GroupBox1.Controls.Add(Me.PictureBox3)
        Me.GroupBox1.Controls.Add(Me.PictureBox2)
        Me.GroupBox1.Controls.Add(Me.PictureBox1)
        Me.GroupBox1.Controls.Add(Me.ListBox1)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Last_Action)
        Me.GroupBox1.Controls.Add(Me.Label38)
        Me.GroupBox1.Location = New System.Drawing.Point(8, 40)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(600, 240)
        Me.GroupBox1.TabIndex = 15
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Transaction Monitor"
        '
        'transactioncountlabel
        '
        Me.transactioncountlabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.transactioncountlabel.ForeColor = System.Drawing.Color.Gray
        Me.transactioncountlabel.Location = New System.Drawing.Point(152, 216)
        Me.transactioncountlabel.Name = "transactioncountlabel"
        Me.transactioncountlabel.Size = New System.Drawing.Size(96, 16)
        Me.transactioncountlabel.TabIndex = 37
        Me.transactioncountlabel.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.ToolTip1.SetToolTip(Me.transactioncountlabel, "Last Update")
        '
        'Label44
        '
        Me.Label44.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label44.ForeColor = System.Drawing.Color.Gray
        Me.Label44.Location = New System.Drawing.Point(8, 216)
        Me.Label44.Name = "Label44"
        Me.Label44.Size = New System.Drawing.Size(152, 16)
        Me.Label44.TabIndex = 38
        Me.Label44.Text = "Valid Transactions Processed:"
        Me.Label44.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.ToolTip1.SetToolTip(Me.Label44, "Last Update")
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.LimeGreen
        Me.Label3.Location = New System.Drawing.Point(360, 24)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(72, 16)
        Me.Label3.TabIndex = 23
        Me.Label3.Text = "Monitoring"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.ToolTip1.SetToolTip(Me.Label3, "Application status")
        '
        'PictureBox6
        '
        Me.PictureBox6.BackgroundImage = CType(resources.GetObject("PictureBox6.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox6.Location = New System.Drawing.Point(536, 24)
        Me.PictureBox6.Name = "PictureBox6"
        Me.PictureBox6.Size = New System.Drawing.Size(16, 16)
        Me.PictureBox6.TabIndex = 22
        Me.PictureBox6.TabStop = False
        '
        'PictureBox5
        '
        Me.PictureBox5.BackgroundImage = CType(resources.GetObject("PictureBox5.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox5.Location = New System.Drawing.Point(512, 24)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(16, 16)
        Me.PictureBox5.TabIndex = 21
        Me.PictureBox5.TabStop = False
        '
        'PictureBox4
        '
        Me.PictureBox4.BackgroundImage = CType(resources.GetObject("PictureBox4.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox4.Location = New System.Drawing.Point(496, 24)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(16, 16)
        Me.PictureBox4.TabIndex = 20
        Me.PictureBox4.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.BackgroundImage = CType(resources.GetObject("PictureBox3.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(480, 24)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(16, 16)
        Me.PictureBox3.TabIndex = 19
        Me.PictureBox3.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackgroundImage = CType(resources.GetObject("PictureBox2.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(464, 24)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(16, 16)
        Me.PictureBox2.TabIndex = 18
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(448, 24)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(16, 16)
        Me.PictureBox1.TabIndex = 17
        Me.PictureBox1.TabStop = False
        '
        'ListBox1
        '
        Me.ListBox1.BackColor = System.Drawing.Color.White
        Me.ListBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.ListBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListBox1.ForeColor = System.Drawing.Color.FromArgb(CType(64, Byte), CType(64, Byte), CType(64, Byte))
        Me.ListBox1.Location = New System.Drawing.Point(16, 64)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(576, 143)
        Me.ListBox1.TabIndex = 29
        Me.ToolTip1.SetToolTip(Me.ListBox1, "List of latest transactions acquired and processed.")
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Firebrick
        Me.Label4.Location = New System.Drawing.Point(560, 24)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(32, 16)
        Me.Label4.TabIndex = 27
        Me.Label4.Text = "Stop"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ToolTip1.SetToolTip(Me.Label4, "Stop the monitoring process")
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Firebrick
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(16, 24)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(72, 16)
        Me.Label2.TabIndex = 16
        Me.Label2.Text = "Status"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, CType((System.Drawing.FontStyle.Italic Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(560, 48)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(32, 16)
        Me.Label1.TabIndex = 30
        Me.Label1.Text = "Clear"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopRight
        Me.ToolTip1.SetToolTip(Me.Label1, "Clear the transaction listing.")
        '
        'Last_Action
        '
        Me.Last_Action.Location = New System.Drawing.Point(16, 48)
        Me.Last_Action.Name = "Last_Action"
        Me.Last_Action.Size = New System.Drawing.Size(96, 16)
        Me.Last_Action.TabIndex = 25
        Me.Last_Action.Text = "Last Actions:"
        '
        'Label38
        '
        Me.Label38.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label38.ForeColor = System.Drawing.Color.Firebrick
        Me.Label38.Location = New System.Drawing.Point(376, 216)
        Me.Label38.Name = "Label38"
        Me.Label38.Size = New System.Drawing.Size(216, 16)
        Me.Label38.TabIndex = 36
        Me.Label38.TextAlign = System.Drawing.ContentAlignment.BottomRight
        Me.ToolTip1.SetToolTip(Me.Label38, "Last Update")
        '
        'NotifyIcon1
        '
        Me.NotifyIcon1.ContextMenu = Me.ContextMenu1
        Me.NotifyIcon1.Icon = CType(resources.GetObject("NotifyIcon1.Icon"), System.Drawing.Icon)
        Me.NotifyIcon1.Text = "Print Credit Machine 1.0"
        '
        'ContextMenu1
        '
        Me.ContextMenu1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem1, Me.MenuItem3, Me.MenuItem2})
        '
        'MenuItem1
        '
        Me.MenuItem1.Index = 0
        Me.MenuItem1.Text = "Display Monitor Program"
        '
        'MenuItem3
        '
        Me.MenuItem3.Index = 1
        Me.MenuItem3.Text = "-"
        '
        'MenuItem2
        '
        Me.MenuItem2.Index = 2
        Me.MenuItem2.Text = "Exit"
        '
        'ImageList1
        '
        Me.ImageList1.ImageSize = New System.Drawing.Size(16, 16)
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        '
        'Label25
        '
        Me.Label25.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.ForeColor = System.Drawing.Color.Firebrick
        Me.Label25.Location = New System.Drawing.Point(336, 192)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(256, 16)
        Me.Label25.TabIndex = 35
        Me.Label25.TextAlign = System.Drawing.ContentAlignment.BottomRight
        Me.ToolTip1.SetToolTip(Me.Label25, "Last Update")
        '
        'Label37
        '
        Me.Label37.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label37.ForeColor = System.Drawing.Color.DarkOrange
        Me.Label37.Location = New System.Drawing.Point(376, 80)
        Me.Label37.Name = "Label37"
        Me.Label37.Size = New System.Drawing.Size(216, 16)
        Me.Label37.TabIndex = 38
        Me.Label37.TextAlign = System.Drawing.ContentAlignment.BottomRight
        Me.ToolTip1.SetToolTip(Me.Label37, "Last Minor Directory Status Check")
        '
        'Label34
        '
        Me.Label34.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label34.ForeColor = System.Drawing.Color.FromArgb(CType(64, Byte), CType(64, Byte), CType(64, Byte))
        Me.Label34.Location = New System.Drawing.Point(320, 16)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(272, 16)
        Me.Label34.TabIndex = 36
        Me.Label34.TextAlign = System.Drawing.ContentAlignment.TopRight
        Me.ToolTip1.SetToolTip(Me.Label34, "Next Update")
        '
        'Label33
        '
        Me.Label33.Location = New System.Drawing.Point(16, 48)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(312, 16)
        Me.Label33.TabIndex = 25
        Me.ToolTip1.SetToolTip(Me.Label33, "The number of unprocessed transactions due to Directory Status errors. These tran" & _
        "sactions will be processed once the Directory Status errors are cleared.")
        '
        'Label32
        '
        Me.Label32.Location = New System.Drawing.Point(16, 96)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(312, 16)
        Me.Label32.TabIndex = 24
        Me.ToolTip1.SetToolTip(Me.Label32, "Logs Directory Status. This is the directory in which Print Credit Machine Contro" & _
        "ller publishes its audit logs.")
        '
        'Label31
        '
        Me.Label31.Location = New System.Drawing.Point(16, 80)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(312, 16)
        Me.Label31.TabIndex = 23
        Me.ToolTip1.SetToolTip(Me.Label31, "Submit Directory Status. This is the directory in which Broker updates are placed" & _
        " once the transaction has been processed.")
        '
        'Label30
        '
        Me.Label30.Location = New System.Drawing.Point(16, 64)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(312, 16)
        Me.Label30.TabIndex = 22
        Me.ToolTip1.SetToolTip(Me.Label30, "Monitor Directory Status. This the directory from where transactions are picked u" & _
        "p.")
        '
        'Label35
        '
        Me.Label35.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label35.ForeColor = System.Drawing.Color.FromArgb(CType(64, Byte), CType(64, Byte), CType(64, Byte))
        Me.Label35.Location = New System.Drawing.Point(376, 16)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(216, 16)
        Me.Label35.TabIndex = 37
        Me.Label35.TextAlign = System.Drawing.ContentAlignment.TopRight
        Me.ToolTip1.SetToolTip(Me.Label35, "Next Update")
        '
        'Label36
        '
        Me.Label36.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label36.ForeColor = System.Drawing.Color.Green
        Me.Label36.Location = New System.Drawing.Point(328, 656)
        Me.Label36.Name = "Label36"
        Me.Label36.Size = New System.Drawing.Size(280, 16)
        Me.Label36.TabIndex = 37
        Me.Label36.TextAlign = System.Drawing.ContentAlignment.TopRight
        Me.ToolTip1.SetToolTip(Me.Label36, "Current System Time")
        '
        'Label39
        '
        Me.Label39.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label39.ForeColor = System.Drawing.Color.Firebrick
        Me.Label39.Location = New System.Drawing.Point(376, 96)
        Me.Label39.Name = "Label39"
        Me.Label39.Size = New System.Drawing.Size(216, 16)
        Me.Label39.TabIndex = 39
        Me.Label39.TextAlign = System.Drawing.ContentAlignment.BottomRight
        Me.ToolTip1.SetToolTip(Me.Label39, "Last Update")
        '
        'Label40
        '
        Me.Label40.ForeColor = System.Drawing.Color.Gainsboro
        Me.Label40.Location = New System.Drawing.Point(8, 640)
        Me.Label40.Name = "Label40"
        Me.Label40.Size = New System.Drawing.Size(72, 16)
        Me.Label40.TabIndex = 38
        Me.Label40.Text = "Label40"
        Me.ToolTip1.SetToolTip(Me.Label40, "Transation Monitor Timer Interval (Status Panel)")
        '
        'Label41
        '
        Me.Label41.ForeColor = System.Drawing.Color.Gainsboro
        Me.Label41.Location = New System.Drawing.Point(88, 640)
        Me.Label41.Name = "Label41"
        Me.Label41.Size = New System.Drawing.Size(72, 16)
        Me.Label41.TabIndex = 39
        Me.Label41.Text = "Label41"
        Me.ToolTip1.SetToolTip(Me.Label41, "Machine Status Timer Interval (Print Credit Machine Status Panel)")
        '
        'Label42
        '
        Me.Label42.ForeColor = System.Drawing.Color.Gainsboro
        Me.Label42.Location = New System.Drawing.Point(168, 640)
        Me.Label42.Name = "Label42"
        Me.Label42.Size = New System.Drawing.Size(72, 16)
        Me.Label42.TabIndex = 40
        Me.Label42.Text = "Label42"
        Me.ToolTip1.SetToolTip(Me.Label42, "Directory Status Timer Interval (Error Monitor Panel)")
        '
        'Label43
        '
        Me.Label43.ForeColor = System.Drawing.Color.Gainsboro
        Me.Label43.Location = New System.Drawing.Point(248, 640)
        Me.Label43.Name = "Label43"
        Me.Label43.Size = New System.Drawing.Size(80, 16)
        Me.Label43.TabIndex = 41
        Me.Label43.Text = "Label43"
        Me.ToolTip1.SetToolTip(Me.Label43, "Transaction File Mover Timer Interval (Hidden File Mover)")
        '
        'LaunchTimeLabel
        '
        Me.LaunchTimeLabel.BackColor = System.Drawing.Color.Transparent
        Me.LaunchTimeLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LaunchTimeLabel.ForeColor = System.Drawing.Color.Black
        Me.LaunchTimeLabel.Location = New System.Drawing.Point(328, 640)
        Me.LaunchTimeLabel.Name = "LaunchTimeLabel"
        Me.LaunchTimeLabel.Size = New System.Drawing.Size(280, 16)
        Me.LaunchTimeLabel.TabIndex = 43
        Me.LaunchTimeLabel.TextAlign = System.Drawing.ContentAlignment.TopRight
        Me.ToolTip1.SetToolTip(Me.LaunchTimeLabel, "Current System Time")
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Arial", 14.0!)
        Me.Label5.ForeColor = System.Drawing.Color.Firebrick
        Me.Label5.Image = CType(resources.GetObject("Label5.Image"), System.Drawing.Image)
        Me.Label5.Location = New System.Drawing.Point(8, 8)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(464, 32)
        Me.Label5.TabIndex = 16
        Me.Label5.Text = "Print Credit Machine Controller 1.1"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.MachineStatusLightPicBox)
        Me.GroupBox2.Controls.Add(Me.ForceMachineStatus)
        Me.GroupBox2.Controls.Add(Me.Label29)
        Me.GroupBox2.Controls.Add(Me.Label28)
        Me.GroupBox2.Controls.Add(Me.Label27)
        Me.GroupBox2.Controls.Add(Me.Label25)
        Me.GroupBox2.Controls.Add(Me.Label24)
        Me.GroupBox2.Controls.Add(Me.Label23)
        Me.GroupBox2.Controls.Add(Me.Label22)
        Me.GroupBox2.Controls.Add(Me.Label21)
        Me.GroupBox2.Controls.Add(Me.Label20)
        Me.GroupBox2.Controls.Add(Me.Label19)
        Me.GroupBox2.Controls.Add(Me.Label18)
        Me.GroupBox2.Controls.Add(Me.Label17)
        Me.GroupBox2.Controls.Add(Me.Label16)
        Me.GroupBox2.Controls.Add(Me.Label15)
        Me.GroupBox2.Controls.Add(Me.Label14)
        Me.GroupBox2.Controls.Add(Me.Label13)
        Me.GroupBox2.Controls.Add(Me.Label12)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.Label34)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(8, 288)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(600, 216)
        Me.GroupBox2.TabIndex = 17
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Print Credit Machine Status"
        '
        'Label29
        '
        Me.Label29.Location = New System.Drawing.Point(272, 144)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(320, 16)
        Me.Label29.TabIndex = 39
        '
        'Label28
        '
        Me.Label28.Location = New System.Drawing.Point(272, 128)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(320, 16)
        Me.Label28.TabIndex = 38
        '
        'Label27
        '
        Me.Label27.BackColor = System.Drawing.Color.Firebrick
        Me.Label27.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label27.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label27.ForeColor = System.Drawing.Color.White
        Me.Label27.Location = New System.Drawing.Point(272, 104)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(88, 16)
        Me.Label27.TabIndex = 37
        Me.Label27.Text = "System"
        Me.Label27.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label24
        '
        Me.Label24.Location = New System.Drawing.Point(272, 80)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(184, 16)
        Me.Label24.TabIndex = 34
        '
        'Label23
        '
        Me.Label23.Location = New System.Drawing.Point(272, 64)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(184, 16)
        Me.Label23.TabIndex = 33
        '
        'Label22
        '
        Me.Label22.Location = New System.Drawing.Point(272, 48)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(184, 16)
        Me.Label22.TabIndex = 32
        '
        'Label21
        '
        Me.Label21.BackColor = System.Drawing.Color.Firebrick
        Me.Label21.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label21.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.ForeColor = System.Drawing.Color.White
        Me.Label21.Location = New System.Drawing.Point(272, 24)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(72, 16)
        Me.Label21.TabIndex = 31
        Me.Label21.Text = "Totals"
        Me.Label21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label20
        '
        Me.Label20.Location = New System.Drawing.Point(16, 192)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(184, 16)
        Me.Label20.TabIndex = 30
        '
        'Label19
        '
        Me.Label19.Location = New System.Drawing.Point(16, 176)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(184, 16)
        Me.Label19.TabIndex = 29
        '
        'Label18
        '
        Me.Label18.BackColor = System.Drawing.Color.Firebrick
        Me.Label18.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.Color.White
        Me.Label18.Location = New System.Drawing.Point(16, 152)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(72, 16)
        Me.Label18.TabIndex = 28
        Me.Label18.Text = "Shift"
        Me.Label18.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label17
        '
        Me.Label17.Location = New System.Drawing.Point(16, 128)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(240, 16)
        Me.Label17.TabIndex = 27
        '
        'Label16
        '
        Me.Label16.Location = New System.Drawing.Point(120, 96)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(136, 16)
        Me.Label16.TabIndex = 26
        '
        'Label15
        '
        Me.Label15.Location = New System.Drawing.Point(120, 80)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(136, 16)
        Me.Label15.TabIndex = 25
        '
        'Label14
        '
        Me.Label14.Location = New System.Drawing.Point(120, 64)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(136, 16)
        Me.Label14.TabIndex = 24
        '
        'Label13
        '
        Me.Label13.Location = New System.Drawing.Point(120, 48)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(136, 16)
        Me.Label13.TabIndex = 23
        '
        'Label12
        '
        Me.Label12.Location = New System.Drawing.Point(16, 112)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(104, 16)
        Me.Label12.TabIndex = 22
        '
        'Label11
        '
        Me.Label11.Location = New System.Drawing.Point(16, 96)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(104, 16)
        Me.Label11.TabIndex = 21
        '
        'Label10
        '
        Me.Label10.Location = New System.Drawing.Point(16, 80)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(104, 16)
        Me.Label10.TabIndex = 20
        '
        'Label9
        '
        Me.Label9.Location = New System.Drawing.Point(16, 64)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(104, 16)
        Me.Label9.TabIndex = 19
        '
        'Label8
        '
        Me.Label8.Location = New System.Drawing.Point(16, 48)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(104, 16)
        Me.Label8.TabIndex = 18
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.Firebrick
        Me.Label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(16, 24)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(72, 16)
        Me.Label6.TabIndex = 17
        Me.Label6.Text = "Status"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Machine_Status_Timer
        '
        Me.Machine_Status_Timer.Interval = 60000
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.DirectoryStatusLightPicBox)
        Me.GroupBox3.Controls.Add(Me.ForceDirectoryStatus)
        Me.GroupBox3.Controls.Add(Me.Label39)
        Me.GroupBox3.Controls.Add(Me.Label37)
        Me.GroupBox3.Controls.Add(Me.Label33)
        Me.GroupBox3.Controls.Add(Me.Label32)
        Me.GroupBox3.Controls.Add(Me.Label31)
        Me.GroupBox3.Controls.Add(Me.Label30)
        Me.GroupBox3.Controls.Add(Me.Label26)
        Me.GroupBox3.Controls.Add(Me.Label35)
        Me.GroupBox3.Location = New System.Drawing.Point(8, 512)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(600, 120)
        Me.GroupBox3.TabIndex = 18
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Error Monitor"
        '
        'Label26
        '
        Me.Label26.BackColor = System.Drawing.Color.Firebrick
        Me.Label26.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label26.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.ForeColor = System.Drawing.Color.White
        Me.Label26.Location = New System.Drawing.Point(16, 24)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(128, 16)
        Me.Label26.TabIndex = 18
        Me.Label26.Text = "Application Errors"
        Me.Label26.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Directory_Status_Timer
        '
        Me.Directory_Status_Timer.Interval = 300000
        '
        'Current_Time
        '
        Me.Current_Time.Enabled = True
        Me.Current_Time.Interval = 1000
        '
        'Transaction_File_Mover
        '
        Me.Transaction_File_Mover.Enabled = True
        Me.Transaction_File_Mover.Interval = 1500
        '
        'ForceMachineStatus
        '
        Me.ForceMachineStatus.ForeColor = System.Drawing.Color.Silver
        Me.ForceMachineStatus.Location = New System.Drawing.Point(112, 24)
        Me.ForceMachineStatus.Name = "ForceMachineStatus"
        Me.ForceMachineStatus.Size = New System.Drawing.Size(40, 16)
        Me.ForceMachineStatus.TabIndex = 40
        Me.ForceMachineStatus.Text = "[Force]"
        Me.ForceMachineStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ToolTip1.SetToolTip(Me.ForceMachineStatus, "Transation Monitor Timer Interval (Status Panel)")
        '
        'MachineStatusLightPicBox
        '
        Me.MachineStatusLightPicBox.BackgroundImage = CType(resources.GetObject("MachineStatusLightPicBox.BackgroundImage"), System.Drawing.Image)
        Me.MachineStatusLightPicBox.Location = New System.Drawing.Point(96, 24)
        Me.MachineStatusLightPicBox.Name = "MachineStatusLightPicBox"
        Me.MachineStatusLightPicBox.Size = New System.Drawing.Size(16, 16)
        Me.MachineStatusLightPicBox.TabIndex = 41
        Me.MachineStatusLightPicBox.TabStop = False
        '
        'DirectoryStatusLightPicBox
        '
        Me.DirectoryStatusLightPicBox.BackgroundImage = CType(resources.GetObject("DirectoryStatusLightPicBox.BackgroundImage"), System.Drawing.Image)
        Me.DirectoryStatusLightPicBox.Location = New System.Drawing.Point(152, 24)
        Me.DirectoryStatusLightPicBox.Name = "DirectoryStatusLightPicBox"
        Me.DirectoryStatusLightPicBox.Size = New System.Drawing.Size(16, 16)
        Me.DirectoryStatusLightPicBox.TabIndex = 43
        Me.DirectoryStatusLightPicBox.TabStop = False
        '
        'ForceDirectoryStatus
        '
        Me.ForceDirectoryStatus.ForeColor = System.Drawing.Color.Silver
        Me.ForceDirectoryStatus.Location = New System.Drawing.Point(168, 24)
        Me.ForceDirectoryStatus.Name = "ForceDirectoryStatus"
        Me.ForceDirectoryStatus.Size = New System.Drawing.Size(40, 16)
        Me.ForceDirectoryStatus.TabIndex = 42
        Me.ForceDirectoryStatus.Text = "[Force]"
        Me.ForceDirectoryStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ToolTip1.SetToolTip(Me.ForceDirectoryStatus, "Transation Monitor Timer Interval (Status Panel)")
        '
        'Monitor_Program
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(616, 680)
        Me.Controls.Add(Me.LaunchTimeLabel)
        Me.Controls.Add(Me.Label43)
        Me.Controls.Add(Me.Label42)
        Me.Controls.Add(Me.Label41)
        Me.Controls.Add(Me.Label40)
        Me.Controls.Add(Me.Label36)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label5)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(622, 712)
        Me.MinimumSize = New System.Drawing.Size(622, 712)
        Me.Name = "Monitor_Program"
        Me.ShowInTaskbar = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Print Credit Machine Controller 1.1 (Build 20050525.3)"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private submit_directory As String
    Private monitor_directory As String
    Private log_directory As String
    Private transaction_filename As String
    Private shift_filename As String
    Private status_filename As String
    Private machine_descriptor As String
    Private submission_format As String
    Private process_directory As String = Application.StartupPath & "\Processing"
    Private error_directory As String = Application.StartupPath & "\Errors"
    Private delete_monitor_file As Boolean
    Private email_address As String

    Private current_light As Integer
    Private system_error_count As Integer = 0
    Private mdirectory_error_reported As Boolean = False
    Private sdirectory_error_reported As Boolean = False
    Private ldirectory_error_reported As Boolean = False

    Private WithEvents cform As Config

    Private transaction_monitor_timer_interval As Long = 1000
    Private transaction_monitor_timer_busy As Boolean = False
    Private machine_status_timer_interval As Long = 1000
    Private machine_status_timer_busy As Boolean = False
    Private directory_status_timer_interval As Long = 1000
    Private directory_status_timer_busy As Boolean = False
    Private transaction_file_mover_interval As Long = 1000
    Private transaction_file_mover_busy As Boolean = False



    Private Sub Error_Handler(ByVal message As String)
        Try
            Dim Display_Message1 As New Display_Message(message)
            Display_Message1.ShowDialog()
        Catch ex As Exception
            MsgBox("An error occurred in Print Credit Machine Controller 1.1's error handling routine. The application will try to recover from this serious error.", MsgBoxStyle.Critical, "Critical Error Encountered")
        End Try
    End Sub

    Private Sub mConfigUpdate() Handles cform.ConfigUpdate
        Try
            Load_Registry_Values()
            read_machine_status()
            read_directory_status()
        Catch ex As Exception
            Error_Handler("An """ & ex.Message & """ error occurred while implementing Configuration changes. The program will attempt to recover shortly.")
        End Try
    End Sub
    Private Sub directory_error(ByVal directorytype As String, ByVal directoryname As String, ByVal directorystatus As Boolean)
        Try
            If directorystatus = False Then


            Dim emailsend As Boolean = False
            If directorytype = "l" Then

                If ldirectory_error_reported = False Then
                    emailsend = True
                    ldirectory_error_reported = True
                End If
            End If
            If directorytype = "m" Then
                If mdirectory_error_reported = False Then
                    emailsend = True
                    mdirectory_error_reported = True
                End If
            End If
            If directorytype = "s" Then
                If sdirectory_error_reported = False Then
                    emailsend = True
                    sdirectory_error_reported = True
                End If
            End If
            If emailsend = True Then
                Dim email_string As String
                    email_string = machine_descriptor & " has reported a serious system error as of " & Format(Now(), "dd/MM/yyyy hh:mm:ss tt") & "."
                    email_string = email_string & vbCrLf & vbCrLf & "The following working directory has become inaccessible:"
                    Select Case directorytype
                        Case "s" : directorytype = "Submit: "
                        Case "l" : directorytype = "Logs: "
                        Case "m" : directorytype = "Monitor: "
                    End Select
                    email_string = email_string & vbCrLf & directorytype & directoryname

                    email_string = email_string & vbCrLf & vbCrLf & "Please dispatch maintenance personnel as soon as possible so that normal service may be resumed."
                    email_string = email_string & vbCrLf & vbCrLf & "This is an auto-generated email alert created by Print Credit Machine Controller 1.1"
                    TextMail(email_address, "Print Credit Machine Error Detected", email_string)
                End If
            Else
                Select Case directorytype
                    Case "s" : sdirectory_error_reported = False
                    Case "l" : ldirectory_error_reported = False
                    Case "m" : mdirectory_error_reported = False
                End Select
            End If

            If mdirectory_error_reported = False Then
                Label30.Text = "Monitor Directory: OK"
                Label30.Refresh()
            Else
                Label30.Text = "Monitor Directory: Error Reported"
                Label30.Refresh()
            End If
            If sdirectory_error_reported = False Then
                Label31.Text = "Submit Directory: OK"
                Label31.Refresh()
            Else
                Label31.Text = "Submit Directory: Error Reported"
                Label31.Refresh()
            End If
            If ldirectory_error_reported = False Then
                Label32.Text = "Logs Directory: OK"
                Label32.Refresh()
            Else
                Label32.Text = "Logs Directory: Error Reported"
                Label32.Refresh()
            End If


        Catch ex As Exception
            Error_Handler("An """ & ex.Message & """ error occurred while reading the Print Credit Machine status file. The program will attempt to recover shortly.")
        End Try

    End Sub

    Private Sub tickevent(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Transaction_Monitor_Timer.Tick
        If (transaction_monitor_timer_busy = False) And (machine_status_timer_busy = False) And (directory_status_timer_busy = False) And (transaction_file_mover_busy = False) Then
            transaction_monitor_timer_busy = True
            Transaction_Monitor_Timer.Interval = transaction_monitor_timer_interval



            Transaction_Monitor_Timer.Stop()
            Label38.Text = "Working"
            Label38.Refresh()
            Try
                If sdirectory_error_reported = False Then
                    read_directory_status("s")

                End If
                If mdirectory_error_reported = False Then
                    read_directory_status("m")

                End If
                If ldirectory_error_reported = False Then
                    read_directory_status("l")

                End If

                If mdirectory_error_reported = False Then
                    Dim dinfo As DirectoryInfo = New DirectoryInfo(process_directory)


                    Dim finfo As FileInfo
                    If dinfo.GetFiles.Length > 0 Then


                        For Each finfo In dinfo.GetFiles

                            If finfo.Name.ToLower.EndsWith(transaction_filename.ToLower) = True Then
                                run_orange_light()

                                ListBox1.Items.Add(Format(Now(), "dd/MM/yyyy hh:mm:ss tt") & ": Valid Transaction File Located: " & finfo.Name)
                                ListBox1.Refresh()
                                Dim ProcID As Integer

                                ProcID = Shell("""" & Application.StartupPath & "\Transaction XML Generator.exe"" """ & finfo.FullName & """ """ & process_directory & "\processtransaction.xml""", AppWinStyle.Hide, True, -1)


                                Dim xread As XmlTextReader = New XmlTextReader(process_directory & "\processtransaction.xml")
                                Try

                                    xread.WhitespaceHandling = WhitespaceHandling.None


                                    xread.Read()
                                    xread.Read()
                                    xread.Read()

                                    Dim tShiftNumber, tAmount, tCardNumber, tDateTime, tTransactionDataAvailable, tTransactionNumber As String
                                    tShiftNumber = xread.ReadElementString("ShiftNumber")
                                    tAmount = xread.ReadElementString("Amount")
                                    tCardNumber = xread.ReadElementString("CardNumber")

                                    tDateTime = xread.ReadElementString("DateTime")
                                    tTransactionDataAvailable = xread.ReadElementString("TransactionDataAvailable")
                                    tTransactionNumber = xread.ReadElementString("TransactionNumber")

                                    Dim SQL As String


                                    If sdirectory_error_reported = False Then
                                        If tCardNumber.Length = 9 And tAmount.Length > 0 Then
                                            transactioncountlabel.Text = (CLng(transactioncountlabel.Text) + 1).ToString
                                            transactioncountlabel.Refresh()
                                            Dim balancefile As StreamWriter = New StreamWriter(submit_directory & "\" & Now.Ticks & machine_descriptor.Substring(0, 1) & machine_descriptor.Substring(machine_descriptor.Length - 1, 1) & ".prn", False)
                                            Dim tempsub_format As String
                                            tempsub_format = submission_format


                                            tempsub_format = tempsub_format.Replace("#CARDNUMBER#", tCardNumber)
                                            tempsub_format = tempsub_format.Replace("#AMOUNT#", tAmount)
                                            tempsub_format = tempsub_format.Replace("#MACHINEDESCRIPTOR#", machine_descriptor)

                                            balancefile.WriteLine(tempsub_format)

                                            ListBox1.Items.Add(Format(Now(), "dd/MM/yyyy hh:mm:ss tt") & ": Adjusted " & tCardNumber & " Account by " & tAmount & " cents")
                                            ListBox1.Refresh()
                                            balancefile.Close()
                                            finfo.Delete()
                                            SQL = "INSERT INTO Transaction_Log (tDate_Inputted, tCard_Number, tAmount, tTransaction_Number, tShift_Number, tTransaction_Data_Available, tError_Count, tDate_Submitted, tMachine_Descriptor) VALUES ('" & Format(Now(), "dd/MM/yyyy hh:mm:ss tt") & "', '" & tCardNumber & "', '" & tAmount & "', '" & tTransactionNumber & "', '" & tShiftNumber & "', '" & tTransactionDataAvailable & "', '0', '" & Format(Now(), "dd/MM/yyyy hh:mm:ss tt") & "', '" & machine_descriptor & "')"
                                        Else
                                            ListBox1.Items.Add(Format(Now(), "dd/MM/yyyy hh:mm:ss tt") & ": Invalid Transaction Ignored (" & tCardNumber & ", " & tAmount & " cents)")
                                            ListBox1.Refresh()
                                            SQL = "INSERT INTO Transaction_Log (tDate_Inputted, tCard_Number, tAmount, tTransaction_Number, tShift_Number, tTransaction_Data_Available, tError_Count, tDate_Submitted, tMachine_Descriptor) VALUES ('" & Format(Now(), "dd/MM/yyyy hh:mm:ss tt") & "', '" & tCardNumber & "', '" & tAmount & "', '" & tTransactionNumber & "', '" & tShiftNumber & "', '" & tTransactionDataAvailable & "', '', '', '" & machine_descriptor & "')"
                                            finfo.Delete()
                                        End If
                                        If ldirectory_error_reported = False Then
                                            Dim database As FileInfo = New FileInfo(log_directory & "\" & Date.Now.Year & ".mdb")
                                            If database.Exists = False Then
                                                File.Copy(Application.StartupPath & "\Log_Template.mdb", log_directory & "\" & Date.Now.Year & ".mdb")
                                            End If

                                            Dim Conn As Data.OleDb.OleDbConnection
                                            Conn = New Data.OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & database.FullName & ";")
                                            Conn.Open()

                                            Dim recset As Data.OleDb.OleDbCommand = New Data.OleDb.OleDbCommand(SQL, Conn)
                                            Dim result As Integer
                                            result = (recset.ExecuteNonQuery())

                                            recset.Dispose()
                                            Conn.Close()
                                            Conn.Dispose()
                                            database = Nothing
                                        Else
                                            Dim errorlog As StreamWriter = New StreamWriter(error_directory & "\Logs\Error_log.txt", True)
                                            errorlog.WriteLine(SQL)
                                            errorlog.Close()
                                        End If
                                    Else
                                        finfo.MoveTo(error_directory & "\Monitor\" & DateTime.Now.Ticks & ".rec")
                                        ListBox1.Items.Add(Format(Now(), "dd/MM/yyyy hh:mm:ss tt") & ": Error encountered. Transaction file moved to Error Directory")
                                        ListBox1.Refresh()
                                        Try
                                            Dim strarray() As String
                                            strarray = Directory.GetFiles(error_directory & "\Monitor")
                                            Label33.Text = "Transaction Error Count: " & strarray.Length & " (unprocessed transactions)"
                                            Label33.Refresh()
                                            strarray.Clear(strarray, 0, strarray.Length)
                                        Catch ex As Exception
                                            Error_Handler("An """ & ex.Message & """ error occurred while performing Transaction Error Count. The program will attempt to recover shortly.")
                                        End Try
                                    End If
                                    finfo = Nothing

                                Catch ex As Exception
                                    finfo.MoveTo(error_directory & "\Monitor\" & DateTime.Now.Ticks & ".rec")
                                    ListBox1.Items.Add(Format(Now(), "dd/MM/yyyy hh:mm:ss tt") & ": Error encountered. Transaction file moved to Error Directory")
                                    ListBox1.Refresh()
                                    Try
                                        Dim strarray() As String
                                        strarray = Directory.GetFiles(error_directory & "\Monitor")
                                        Label33.Text = "Transaction Error Count: " & strarray.Length & " (unprocessed transactions)"
                                        Label33.Refresh()
                                        strarray.Clear(strarray, 0, strarray.Length)
                                    Catch ex1 As Exception
                                        Error_Handler("An """ & ex1.Message & """ error occurred while performing Transaction Error Count. The program will attempt to recover shortly.")
                                    End Try
                                End Try
                                xread.Close()
                                Dim fil As FileInfo = New FileInfo(process_directory & "\processtransaction.xml")
                                If fil.Exists = True Then
                                    fil.Delete()
                                End If
                                fil = Nothing



                                stop_orange_light()

                            Else
                                If delete_monitor_file = True Then
                                    If Not finfo.Name.ToLower = transaction_filename.ToLower And Not finfo.Name.ToLower = shift_filename.ToLower And Not finfo.Name.ToLower = status_filename.ToLower Then
                                        ListBox1.Items.Add(Format(Now(), "dd/MM/yyyy hh:mm:ss tt") & ": Deleting Invalid File: " & finfo.Name)
                                        ListBox1.Refresh()
                                        finfo.Delete()
                                        ListBox1.Items.RemoveAt(ListBox1.Items.Count - 1)
                                        ListBox1.Items.Add(Format(Now(), "dd/MM/yyyy hh:mm:ss tt") & ": Deleted Invalid File: " & finfo.Name)
                                        ListBox1.Refresh()
                                    End If
                                End If
                            End If

                        Next

                    End If
                    While ListBox1.Items.Count > 50
                        ListBox1.Items.RemoveAt(0)
                        ListBox1.Refresh()
                    End While
                    If ListBox1.Items.Count > 0 Then
                        ListBox1.SelectedIndex = ListBox1.Items.Count - 1
                        ListBox1.ClearSelected()
                        ListBox1.Refresh()
                    End If

                    dinfo = Nothing
                    finfo = Nothing

                End If

            Catch ex As Exception
                Error_Handler("An """ & ex.Message & """ error occurred in the folder monitoring controller. The program will attempt to recover shortly.")
            End Try
            Label38.Text = "Last Update: " & Format(Now(), "dd/MM/yyyy hh:mm:ss tt")
            Label38.Refresh()
            transaction_monitor_timer_busy = False
            Transaction_Monitor_Timer.Start()

        Else
            transaction_monitor_timer_busy = False
            Transaction_Monitor_Timer.Interval = 1000
        End If
        Label40.Text = Transaction_Monitor_Timer.Interval
        Label40.Refresh()
    End Sub

    Private Sub run_orange_light()
        Try
            PictureBox6.Image = ImageList1.Images(1)
        Catch ex As Exception
            Error_Handler("An """ & ex.Message & """ error occurred while loading the status light strip. The program will attempt to recover shortly.")
        End Try
    End Sub

    Private Sub stop_orange_light()
        Try
            PictureBox6.Image = Nothing
        Catch ex As Exception
            Error_Handler("An """ & ex.Message & """ error occurred while loading the status light strip. The program will attempt to recover shortly.")
        End Try
    End Sub

    Private Sub run_red_light()
        Try
            PictureBox1.Image = ImageList1.Images(3)
            PictureBox2.Image = ImageList1.Images(3)
            PictureBox3.Image = ImageList1.Images(3)
            PictureBox4.Image = ImageList1.Images(3)
            PictureBox5.Image = ImageList1.Images(3)
            PictureBox6.Image = ImageList1.Images(2)
        Catch ex As Exception
            Error_Handler("An """ & ex.Message & """ error occurred while loading the status light strip. The program will attempt to recover shortly.")
        End Try
    End Sub

    Private Sub stop_red_light()
        Try
            PictureBox1.Image = Nothing
            PictureBox2.Image = Nothing
            PictureBox3.Image = Nothing
            PictureBox4.Image = Nothing
            PictureBox5.Image = Nothing
            PictureBox6.Image = Nothing
        Catch ex As Exception
            Error_Handler("An """ & ex.Message & """ error occurred while loading the status light strip. The program will attempt to recover shortly.")
        End Try
    End Sub

    Private Sub run_green_lights()
        Try
            Select Case current_light
                Case 0
                    PictureBox5.Image = Nothing
                    PictureBox1.Image = ImageList1.Images(0)
                Case 1
                    PictureBox1.Image = Nothing
                    PictureBox2.Image = ImageList1.Images(0)
                Case 2
                    PictureBox2.Image = Nothing
                    PictureBox3.Image = ImageList1.Images(0)
                Case 3
                    PictureBox3.Image = Nothing
                    PictureBox4.Image = ImageList1.Images(0)
                Case 4
                    PictureBox4.Image = Nothing
                    PictureBox5.Image = ImageList1.Images(0)
                Case 5
                    PictureBox5.Image = Nothing
                    PictureBox1.Image = ImageList1.Images(0)
            End Select

            current_light = current_light + 1
            If current_light > 5 Then
                current_light = 1
            End If
        Catch ex As Exception
            Error_Handler("An """ & ex.Message & """ error occurred while loading the status light strip. The program will attempt to recover shortly.")
        End Try
    End Sub

    Private Sub Monitor_Program_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            transactioncountlabel.Text = "0"
            transactioncountlabel.Refresh()

            transaction_monitor_timer_interval = Transaction_Monitor_Timer.Interval
            transaction_monitor_timer_busy = False
            machine_status_timer_interval = Machine_Status_Timer.Interval
            machine_status_timer_busy = False
            directory_status_timer_interval = Directory_Status_Timer.Interval
            directory_status_timer_busy = False
            transaction_file_mover_interval = Transaction_File_Mover.Interval
            transaction_file_mover_busy = False

            Transaction_Monitor_Timer.Interval = 100
            Machine_Status_Timer.Interval = 200
            Directory_Status_Timer.Interval = 300
            Transaction_File_Mover.Interval = 400
            Label40.Text = Transaction_Monitor_Timer.Interval
            Label40.Refresh()
            Label41.Text = Machine_Status_Timer.Interval
            Label41.Refresh()
            Label42.Text = Directory_Status_Timer.Interval
            Label42.Refresh()
            Label43.Text = Transaction_File_Mover.Interval
            Label43.Refresh()


            current_light = 0
            run_green_lights()
            Load_Registry_Values()
            Label34.Text = "Working..."
            Label34.Refresh()
            Label35.Text = "Working..."
            Label35.Refresh()
            read_directory_status()
            read_machine_status()
            NotifyIcon1.Visible = True
            Me.Visible = True
            Transaction_Monitor_Timer.Start()
            Label34.Text = "Next Update: " & Format(Now.AddMilliseconds(Machine_Status_Timer.Interval), "dd/MM/yyyy hh:mm:ss tt")
            Label34.Refresh()
            Machine_Status_Timer.Start()
            Label35.Text = "Next Update: " & Format(Now.AddMilliseconds(Directory_Status_Timer.Interval), "dd/MM/yyyy hh:mm:ss tt")
            Label35.Refresh()
            Directory_Status_Timer.Start()
            Label5.Focus()

            LaunchTimeLabel.Text = "Program launched: " & Format(Now(), "dd/MM/yyyy hh:mm:ss tt")
            LaunchTimeLabel.Refresh()
        Catch ex As Exception
            Error_Handler("An """ & ex.Message & """ error occurred while loading the Monitoring screen. The program will attempt to recover shortly.")
        End Try
    End Sub

    Private Sub monitor_program_resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Resize
        Try

            If Me.WindowState = FormWindowState.Minimized Then
                NotifyIcon1.Visible = True
                Me.Opacity = 0
            End If
        Catch ex As Exception
            Error_Handler("An """ & ex.Message & """ error occurred while trying to display the main screen. The program will attempt to recover shortly.")
        End Try
    End Sub

    Private Sub monitor_program_closed(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Closed
        Try
            NotifyIcon1.Dispose()
            Application.Exit()
        Catch ex As Exception
            Error_Handler("An """ & ex.Message & """ error occurred while closing the Monitoring screen. The program will attempt to recover shortly.")
        End Try
    End Sub

    Private Sub monitor_program_closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        Try
            NotifyIcon1.Dispose()
            Application.Exit()
        Catch ex As Exception
            Error_Handler("An """ & ex.Message & """ error occurred while closing the Monitoring screen. The program will attempt to recover shortly.")
        End Try
    End Sub

    Public Sub Load_Registry_Values()
        Try
            Dim configflag As Boolean
            configflag = False
            Dim str As String
            Dim keyflag1 As Boolean = False
            Dim oReg As RegistryKey = Registry.LocalMachine
            Dim keys() As String = oReg.GetSubKeyNames()
            System.Array.Sort(keys)

            For Each str In keys
                If str.Equals("Software\Print Credit Machine Controller") = True Then
                    keyflag1 = True
                    Exit For
                End If
            Next str

            If keyflag1 = False Then
                oReg.CreateSubKey("Software\Print Credit Machine Controller")
            End If

            keyflag1 = False

            Dim oKey As RegistryKey = oReg.OpenSubKey("Software\Print Credit Machine Controller", True)

            str = oKey.GetValue("monitor_directory")
            If Not IsNothing(str) And Not (str = "") Then
                monitor_directory = str
            Else
                configflag = True
                oKey.SetValue("monitor_directory", Application.StartupPath & "\Monitor")
                monitor_directory = Application.StartupPath & "\Monitor"
            End If

            str = oKey.GetValue("submit_directory")
            If Not IsNothing(str) And Not (str = "") Then
                submit_directory = str
            Else
                configflag = True
                oKey.SetValue("submit_directory", Application.StartupPath & "\Submit")
                submit_directory = Application.StartupPath & "\Submit"
            End If

            str = oKey.GetValue("log_directory")
            If Not IsNothing(str) And Not (str = "") Then
                log_directory = str
            Else
                configflag = True
                oKey.SetValue("log_directory", Application.StartupPath & "\Logs")
                log_directory = Application.StartupPath & "\Logs"
            End If

            str = oKey.GetValue("transaction_filename")
            If Not IsNothing(str) And Not (str = "") Then
                transaction_filename = str
            Else
                configflag = True
                oKey.SetValue("transaction_filename", "transaction.rec")
                transaction_filename = "transaction.rec"
            End If

            str = oKey.GetValue("shift_filename")
            If Not IsNothing(str) And Not (str = "") Then
                shift_filename = str
            Else
                configflag = True
                oKey.SetValue("shift_filename", "currentshift.rec")
                shift_filename = "currentshift.rec"
            End If

            str = oKey.GetValue("status_filename")
            If Not IsNothing(str) And Not (str = "") Then
                status_filename = str
            Else
                configflag = True
                oKey.SetValue("status_filename", "currentstatus.dat")
                status_filename = "currentstatus.dat"
            End If

            str = oKey.GetValue("machine_descriptor")
            If Not IsNothing(str) And Not (str = "") Then
                machine_descriptor = str
            Else
                configflag = True
                oKey.SetValue("machine_descriptor", "PrintCredit1")
                machine_descriptor = "PrintCredit1"
            End If

            str = oKey.GetValue("email_address")
            If Not IsNothing(str) And Not (str = "") Then
                email_address = str
            Else
                configflag = True
                oKey.SetValue("email_address", "kroberts@commerce.uct.ac.za")
                email_address = "kroberts@commerce.uct.ac.za"
            End If

            str = oKey.GetValue("submission_format")
            If Not IsNothing(str) And Not (str = "") Then
                submission_format = str
            Else
                configflag = True
                oKey.SetValue("submission_format", "ACCTBALANCE STUDENT #CARDNUMBER#, #AMOUNT#,PCREDIT,NONE,#MACHINEDESCRIPTOR#")
                submission_format = "ACCTBALANCE STUDENT #CARDNUMBER#, #AMOUNT#,PCREDIT,NONE,#MACHINEDESCRIPTOR#"
            End If

            str = oKey.GetValue("delete_monitor_file")
            If Not IsNothing(str) And Not (str = "") Then
                If str = "True" Then
                    delete_monitor_file = True
                Else
                    delete_monitor_file = False
                End If
            Else
                configflag = True
                oKey.SetValue("delete_monitor_file", "True")
                delete_monitor_file = True
            End If

            If configflag = True Then

                Dim result As DialogResult
                cform = New Config
                result = cform.ShowDialog()
                If result = DialogResult.OK Then
                    Load_Registry_Values()
                End If
                result = Nothing
                cform.Dispose()
            End If

            oKey.Close()
            oReg.Close()
        Catch ex As Exception
            Error_Handler("An """ & ex.Message & """ error occurred while loading required registry values. The program will attempt to recover shortly.")
        End Try
    End Sub

    Public Sub Save_Registry_Values()
        Try
            Dim oReg As RegistryKey = Registry.LocalMachine
            Dim oKey As RegistryKey = oReg.OpenSubKey("Software\Print Credit Machine Controller", True)

            oKey.SetValue("monitor_directory", monitor_directory)
            oKey.SetValue("submit_directory", submit_directory)
            oKey.SetValue("log_directory", log_directory)
            oKey.SetValue("transaction_filename", transaction_filename)
            oKey.SetValue("shift_filename", shift_filename)
            oKey.SetValue("status_filename", status_filename)
            oKey.SetValue("submission_format", submission_format)
            oKey.SetValue("machine_descriptor", machine_descriptor)
            oKey.SetValue("email_address", email_address)
            If delete_monitor_file = True Then
                oKey.SetValue("delete_monitor_file", "True")
            Else
                oKey.SetValue("delete_monitor_file", "False")
            End If

            oKey.Close()
            oReg.Close()
        Catch ex As Exception
            Error_Handler("An """ & ex.Message & """ error occurred while saving required registry values. The program will attempt to recover shortly.")
        End Try
    End Sub



    Private Sub Label8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label7.Click
        Try
            Dim result As DialogResult
            cform = New Config
            result = cform.ShowDialog()
            If result = DialogResult.OK Then
                Load_Registry_Values()
            End If
            result = Nothing
            cform.Dispose()
        Catch ex As Exception
            Error_Handler("An """ & ex.Message & """ error occurred while executing menu script. The program will attempt to recover shortly.")
        End Try
    End Sub

    Private Sub show_application()
        Try
            Me.Opacity = 1

            Me.BringToFront()
            Me.Refresh()
            Me.WindowState = FormWindowState.Normal

        Catch ex As Exception
            Error_Handler("An """ & ex.Message & """ error occurred while trying to display the main screen. The program will attempt to recover shortly.")
        End Try
    End Sub

    Private Sub NotifyIcon1_snglclick(ByVal sender As Object, ByVal e As System.EventArgs) Handles NotifyIcon1.Click
        show_application()
    End Sub

    Private Sub MenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem1.Click
        show_application()
    End Sub

    Private Sub MenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem2.Click
        Try
            NotifyIcon1.Dispose()
            Application.Exit()
        Catch ex As Exception
            Error_Handler("An """ & ex.Message & """ error occurred while closing Print Credit Machine Controller 1.1. The program will attempt to recover shortly.")
        End Try
    End Sub

    Private Sub Label4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label4.Click
        Try
            If Label4.Text = "Stop" Then
                Transaction_Monitor_Timer.Stop()
                Directory_Status_Timer.Stop()
                Machine_Status_Timer.Stop()
                run_red_light()
                Label3.ForeColor = Color.Firebrick
                Label3.Text = "Stopped"
                Label3.Refresh()
                Label4.ForeColor = Color.LimeGreen
                Label4.Text = "Go"
                Label4.Refresh()
                ToolTip1.SetToolTip(Label4, "Start the monitoring process")
            Else
                Transaction_Monitor_Timer.Start()
                Directory_Status_Timer.Start()
                Machine_Status_Timer.Start()
                stop_red_light()
                current_light = 0
                Label3.ForeColor = Color.LimeGreen
                Label3.Text = "Monitoring"
                Label3.Refresh()
                Label4.ForeColor = Color.Firebrick
                Label4.Text = "Stop"
                Label4.Refresh()
                ToolTip1.SetToolTip(Label4, "Start the monitoring process")
            End If

        Catch ex As Exception
            Error_Handler("An """ & ex.Message & """ error occurred while stopping the Monitoring Process. The program will attempt to recover shortly.")
        End Try
    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click
        Try
            ListBox1.Items.Clear()
            ListBox1.Refresh()
            ListBox1.Refresh()
        Catch ex As Exception
            Error_Handler("An """ & ex.Message & """ error occurred while clearing the Last Action list. The program will attempt to recover shortly.")
        End Try
    End Sub

    Private Sub read_machine_status()
        Machine_Status_Timer.Stop()
        Label25.Text = "Working..."
        Label25.Refresh()
        run_orange_light()

        Try
            If mdirectory_error_reported = False Then
                read_directory_status("m")
            End If

            If mdirectory_error_reported = False Then

                If File.Exists(monitor_directory & "\" & status_filename) Then
                    If Not File.GetAttributes(monitor_directory & "\" & status_filename) = FileAttributes.ReadOnly Then
                        If File.Exists(process_directory & "\" & status_filename) = True Then
                            File.Delete(process_directory & "\" & status_filename)
                        End If

                        File.Move(monitor_directory & "\" & status_filename, process_directory & "\" & status_filename)
                        Dim new_error_count = 0
                        Dim error_string As String = ""
                        Dim reader As StreamReader = New StreamReader(process_directory & "\" & status_filename)
                        Dim readstring As String = ""
                        Dim checkstring As String = ""
                        Do While reader.Peek() >= 0
                            readstring = reader.ReadLine()
                            If readstring.IndexOf("=") < 0 Then
                                checkstring = "Unimportant"
                            Else
                                checkstring = readstring.Substring(0, (readstring.IndexOf("=")))
                            End If

                            Select Case checkstring
                                Case "NRError"
                                    Label8.Text = readstring
                                    Label8.Refresh()
                                    If readstring.EndsWith("=1") Then
                                        new_error_count = new_error_count + 1
                                        error_string = error_string & vbCrLf & Label8.Text
                                    End If
                                Case "NRUnplugged"
                                    Label9.Text = readstring
                                    Label9.Refresh()
                                    If readstring.EndsWith("=1") Then
                                        new_error_count = new_error_count + 1
                                        error_string = error_string & vbCrLf & Label9.Text
                                    End If
                                Case "VUError"
                                    Label10.Text = readstring
                                    Label10.Refresh()
                                    If readstring.EndsWith("=1") Then
                                        new_error_count = new_error_count + 1
                                        error_string = error_string & vbCrLf & Label10.Text
                                    End If
                                Case "VUUnplugged"
                                    Label11.Text = readstring
                                    Label11.Refresh()
                                    If readstring.EndsWith("=1") Then
                                        new_error_count = new_error_count + 1
                                        error_string = error_string & vbCrLf & Label11.Text
                                    End If
                                Case "VUOffline"
                                    Label12.Text = readstring
                                    Label12.Refresh()
                                    If readstring.EndsWith("=1") Then
                                        new_error_count = new_error_count + 1
                                        error_string = error_string & vbCrLf & Label12.Text
                                    End If
                                Case "NoteBoxIn"
                                    Label13.Text = readstring
                                    Label13.Refresh()
                                    If readstring.EndsWith("=0") Then
                                        new_error_count = new_error_count + 1
                                        error_string = error_string & vbCrLf & Label13.Text
                                    End If
                                Case "NoteBoxFull"
                                    Label14.Text = readstring
                                    Label14.Refresh()
                                    If readstring.EndsWith("=1") Then
                                        new_error_count = new_error_count + 1
                                        error_string = error_string & vbCrLf & Label14.Text
                                    End If
                                Case "CashBoxCalcFull"
                                    Label15.Text = readstring
                                    Label15.Refresh()
                                    If readstring.EndsWith("=1") Then
                                        new_error_count = new_error_count + 1
                                        error_string = error_string & vbCrLf & Label15.Text
                                    End If
                                Case "Message"
                                    Label17.Text = readstring
                                    Label17.Refresh()
                                Case "StartShift"
                                    Label19.Text = readstring
                                    Label19.Refresh()
                                Case "ShiftNumber"
                                    Label20.Text = readstring
                                    Label20.Refresh()
                                Case "ValueInCashBox"
                                    Label22.Text = readstring
                                    Label22.Refresh()
                                Case "NumberOfNotesInCashBox"
                                    Label23.Text = readstring
                                    Label23.Refresh()
                                Case "CashBoxLevel"
                                    Label24.Text = readstring
                                    Label24.Refresh()
                            End Select
                        Loop

                        reader.Close()
                        'File.Delete(process_directory & "\" & status_filename)

                        Try

                            Dim emailsend As Boolean = False
                            Dim emailstatus As Boolean
                            If Not new_error_count = system_error_count Then
                                If Not new_error_count = 0 Then
                                    Dim email_string As String
                                    email_string = machine_descriptor & " has reported a serious system error as of " & Format(Now(), "dd/MM/yyyy hh:mm:ss tt") & "."
                                    If new_error_count > system_error_count Then
                                        If system_error_count > 1 Then
                                            email_string = email_string & vbCrLf & vbCrLf & "The number of error codes located has increased since the system's last error communication."
                                        End If
                                    Else
                                        email_string = email_string & vbCrLf & vbCrLf & "The number of error codes located has decreased since the system's last error communication, but the system is still in need of maintenance."
                                    End If

                                    email_string = email_string & vbCrLf & vbCrLf & "The following error codes were picked up from the system status log:"
                                    email_string = email_string & vbCrLf & error_string
                                    email_string = email_string & vbCrLf & vbCrLf & "Note: CR - Card Reader; NR - Note Reader; VU - Vending Unit; NoteBox - Cash Box."
                                    email_string = email_string & vbCrLf & "Please dispatch maintenance personnel as soon as possible so that normal service may be resumed."
                                    email_string = email_string & vbCrLf & vbCrLf & "This is an auto-generated email alert created by Print Credit Machine Controller 1.1"

                                    emailstatus = TextMail(email_address, "Print Credit Machine Error Detected", email_string)
                                    emailsend = True
                                End If
                                system_error_count = new_error_count
                            End If


                            Label28.Text = "System Error Count: " & system_error_count
                            Label28.Refresh()
                            If system_error_count = 0 Then
                                Label29.Text = "Action: No Maintenance Required"
                                Label29.Refresh()
                            Else
                                If emailsend = True Then
                                    Label29.Text = "Action: Error Notice Email Generated " & Format(Now(), "dd/MM/yyyy hh:mm:ss tt")
                                    Label29.Refresh()
                                End If
                            End If
                        Catch ex As Exception
                            Error_Handler("An """ & ex.Message & """ error occurred while reading the Print Credit Machine status file. The program will attempt to recover shortly.")
                        End Try
                    Else
                        Label28.Text = "System Status file is currently in use."
                        Label28.Refresh()
                    End If
                Else
                    Label28.Text = "Unable to locate System Status file."
                    Label28.Refresh()
                End If

            End If


        Catch ex As Exception
            Error_Handler("An """ & ex.Message & """ error occurred while reading the Print Credit Machine status file. The program will attempt to recover shortly.")
        End Try
        stop_orange_light()

        Label25.Text = "Last Update: " & Format(Now(), "dd/MM/yyyy hh:mm:ss tt")
        Label25.Refresh()
        Machine_Status_Timer.Start()

    End Sub


    Private Sub Machine_Status_Timer_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Machine_Status_Timer.Tick
        MachineStatusCode()
    End Sub

    Private Sub read_directory_status(Optional ByVal directorytocheck As String = "all")
        'Transaction_Monitor_Timer.Stop()
        'Machine_Status_Timer.Stop()
        'Directory_Status_Timer.Stop()
        run_orange_light()
        Label37.Text = "Working..."
        Label37.Refresh()
        If directorytocheck = "all" Or directorytocheck = "s" Then
            Try

                File.Copy(Application.StartupPath & "\pathtest.txt", submit_directory & "\" & machine_descriptor.Replace(" ", "") & "pathtest.txt", True)
                directory_error("s", submit_directory, True)
                File.Delete(submit_directory & "\" & machine_descriptor.Replace(" ", "") & "pathtest.txt")
            Catch ex As Exception

                directory_error("s", submit_directory, False)
            End Try
        End If


        If directorytocheck = "all" Or directorytocheck = "m" Then
            Try
                File.Copy(Application.StartupPath & "\pathtest.txt", monitor_directory & "\" & machine_descriptor.Replace(" ", "") & "pathtest.txt", True)
                directory_error("m", monitor_directory, True)
                File.Delete(monitor_directory & "\" & machine_descriptor.Replace(" ", "") & "pathtest.txt")
            Catch ex As Exception
                directory_error("m", monitor_directory, False)
            End Try
        End If
        If directorytocheck = "all" Or directorytocheck = "l" Then
            Try
                File.Copy(Application.StartupPath & "\pathtest.txt", log_directory & "\" & machine_descriptor.Replace(" ", "") & "pathtest.txt", True)
                directory_error("l", log_directory, True)
                File.Delete(log_directory & "\" & machine_descriptor.Replace(" ", "") & "pathtest.txt")
            Catch ex As Exception
                directory_error("l", log_directory, False)
            End Try
        End If
        Try
            Dim strarray() As String
            strarray = Directory.GetFiles(error_directory & "\Monitor")
            Label33.Text = "Transaction Error Count: " & strarray.Length & " (unprocessed transactions)"
            Label33.Refresh()
            strarray.Clear(strarray, 0, strarray.Length)
        Catch ex As Exception
            Error_Handler("An """ & ex.Message & """ error occurred while performing Transaction Error Count. The program will attempt to recover shortly.")
        End Try
        Label37.Text = "Minor Check: " & Format(Now(), "dd/MM/yyyy hh:mm:ss tt")
        Label37.Refresh()
        stop_orange_light()

        'Transaction_Monitor_Timer.Start()
        'Machine_Status_Timer.Start()
        'Directory_Status_Timer.Start()
    End Sub


    Public Function TextMail(ByVal strTo As String, ByVal strSubj As String, ByVal strBody As String, Optional ByRef strErrMsg As String = "") As Boolean
        Dim objMail As MailMessage

        Try
            Dim emailaddys As String()
            emailaddys = strTo.Split(";")

            Dim counter As Integer = 0
            For counter = 0 To emailaddys.Length - 1
                objMail = New MailMessage
                objMail.BodyFormat = MailFormat.Text
                objMail.From = "webserver@commerce.uct.ac.za"
                objMail.To = emailaddys(counter).Trim
                objMail.Subject = strSubj
                objMail.Body = strBody

                SmtpMail.SmtpServer = "mail.uct.ac.za"
                SmtpMail.Send(objMail)
            Next
            TextMail = True

        Catch ex As Exception
            TextMail = False
            Error_Handler("An """ & ex.Message & """ error occurred while sending the Error Alert email. The program will attempt to recover shortly.")
        End Try
    End Function

    Public Function TextMail(ByVal SmtpServer As String, ByVal strFrom As String, ByVal strTo As String, ByVal strSubj As String, ByVal strBody As String, Optional ByRef strErrMsg As String = "") As Boolean
        Dim objMail As MailMessage

        Try
            Dim emailaddys As String()
            emailaddys = strTo.Split(";")

            Dim counter As Integer = 0
            For counter = 0 To emailaddys.Length - 1


                objMail = New MailMessage
                objMail.BodyFormat = MailFormat.Text
                objMail.From = strFrom
                objMail.To = emailaddys(counter).Trim
                objMail.Subject = strSubj
                objMail.Body = strBody

                SmtpMail.SmtpServer = SmtpServer
                SmtpMail.Send(objMail)
            Next
            TextMail = True

        Catch ex As Exception
            TextMail = False
            Error_Handler("An """ & ex.Message & """ error occurred while sending the Error Alert email. The program will attempt to recover shortly.")
        End Try
    End Function



    Private Sub handle_errors_logfile_handler()

        ' Transaction_Monitor_Timer.Stop()
        run_orange_light()

        Try
            If File.Exists(error_directory & "\Logs\Error_log.txt") = True Then


                If ldirectory_error_reported = False Then
                    read_directory_status()
                End If

                If ldirectory_error_reported = False Then

                    Dim database As FileInfo = New FileInfo(log_directory & "\" & Date.Now.Year & ".mdb")
                    If database.Exists = False Then
                        File.Copy(Application.StartupPath & "\Log_Template.mdb", log_directory & "\" & Date.Now.Year & ".mdb")
                    End If

                    Dim Conn As Data.OleDb.OleDbConnection
                    Conn = New Data.OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & database.FullName & ";")
                    Conn.Open()

                    Dim str As String
                    Dim errorlog As StreamReader = New StreamReader(error_directory & "\Logs\Error_log.txt", True)
                    str = errorlog.ReadLine()

                    While (Not str = "") And (Not str = Nothing)
                        Try


                            Dim recset As Data.OleDb.OleDbCommand = New Data.OleDb.OleDbCommand(str, Conn)
                            Dim result As Integer
                            result = (recset.ExecuteNonQuery())
                            recset.Dispose()
                        Catch ex As Exception
                            Dim werrorlog As StreamWriter = New StreamWriter(error_directory & "\Logs\Unpostable_Error_log.txt", True)
                            werrorlog.WriteLine(str)
                            werrorlog.Close()
                        End Try
                        str = errorlog.ReadLine()

                    End While

                    errorlog.Close()
                    File.Delete(error_directory & "\Logs\Error_log.txt")

                    Conn.Close()
                    Conn.Dispose()
                    database = Nothing
                End If
            End If

        Catch ex As Exception
            Error_Handler("An """ & ex.Message & """ error occurred in the error log handler. The program will attempt to recover shortly.")
        End Try

        stop_orange_light()

        'Transaction_Monitor_Timer.Start()
    End Sub

    Private Sub handle_errors_transaction_handler()
        Try

            If sdirectory_error_reported = False Then
                read_directory_status("s")

            End If
            If ldirectory_error_reported = False Then
                read_directory_status("l")

            End If


            Dim dinfo As DirectoryInfo = New DirectoryInfo(error_directory & "\Monitor")


            Dim finfo As FileInfo
            If dinfo.GetFiles.Length > 0 Then


                For Each finfo In dinfo.GetFiles

                    If finfo.Name.ToLower.EndsWith(".rec") Then
                        run_orange_light()

                        ListBox1.Items.Add(Format(Now, "dd/MM/yyyy hh:mm:ss tt") & ": Valid Error Transaction File Located: " & finfo.Name)
                        ListBox1.Refresh()
                        Dim ProcID As Integer

                        ProcID = Shell("""" & Application.StartupPath & "\Transaction XML Generator.exe"" """ & finfo.FullName & """ """ & process_directory & "\errorprocesstransaction.xml""", AppWinStyle.Hide, True, -1)


                        Dim xread As XmlTextReader = New XmlTextReader(process_directory & "\errorprocesstransaction.xml")
                        Try

                            xread.WhitespaceHandling = WhitespaceHandling.None


                            xread.Read()
                            xread.Read()
                            xread.Read()

                            Dim tShiftNumber, tAmount, tCardNumber, tDateTime, tTransactionDataAvailable, tTransactionNumber As String
                            tShiftNumber = xread.ReadElementString("ShiftNumber")
                            tAmount = xread.ReadElementString("Amount")
                            tCardNumber = xread.ReadElementString("CardNumber")
                            tDateTime = xread.ReadElementString("DateTime")
                            tTransactionDataAvailable = xread.ReadElementString("TransactionDataAvailable")
                            tTransactionNumber = xread.ReadElementString("TransactionNumber")

                            Dim SQL As String


                            If sdirectory_error_reported = False Then
                                If tCardNumber.Length = 9 And tAmount.Length > 0 Then

                                    Dim balancefile As StreamWriter = New StreamWriter(submit_directory & "\" & DateTime.Now.Ticks & machine_descriptor.Substring(0, 1) & machine_descriptor.Substring(machine_descriptor.Length - 1, 1) & ".prn", False)
                                    Dim tempsub_format
                                    tempsub_format = submission_format


                                    tempsub_format = tempsub_format.Replace("#CARDNUMBER#", tCardNumber)
                                    tempsub_format = tempsub_format.Replace("#AMOUNT#", tAmount)
                                    tempsub_format = tempsub_format.Replace("#MACHINEDESCRIPTOR#", machine_descriptor)
                                    balancefile.WriteLine(tempsub_format)
                                    ListBox1.Items.Add(Format(Now, "dd/MM/yyyy hh:mm:ss tt") & ": Adjusted " & tCardNumber & " Account by " & tAmount & " cents")
                                    ListBox1.Refresh()
                                    balancefile.Close()

                                    Dim d As Date
                                    Try
                                        d = New Date(Long.Parse(finfo.Name.Replace(".rec", "")))
                                    Catch ex As Exception
                                        d = New Date
                                        d = Now
                                    End Try

                                    finfo.Delete()

                                    SQL = "INSERT INTO Transaction_Log (tDate_Inputted, tCard_Number, tAmount, tTransaction_Number, tShift_Number, tTransaction_Data_Available, tError_Count, tDate_Submitted, tMachine_Descriptor) VALUES ('" & d.ToString & "', '" & tCardNumber & "', '" & tAmount & "', '" & tTransactionNumber & "', '" & tShiftNumber & "', '" & tTransactionDataAvailable & "', '1', '" & Format(Now(), "dd/MM/yyyy hh:mm:ss tt") & "', '" & machine_descriptor & "')"
                                Else
                                    Dim d As Date
                                    Try
                                        d = New Date(Long.Parse(finfo.Name.Replace(".rec", "")))
                                    Catch ex As Exception
                                        d = New Date
                                        d = Now
                                    End Try
                                    ListBox1.Items.Add(Format(Now, "dd/MM/yyyy hh:mm:ss tt") & ": Invalid Transaction Ignored (" & tCardNumber & ", " & tAmount & " cents)")
                                    ListBox1.Refresh()
                                    SQL = "INSERT INTO Transaction_Log (tDate_Inputted, tCard_Number, tAmount, tTransaction_Number, tShift_Number, tTransaction_Data_Available, tError_Count, tDate_Submitted, tMachine_Descriptor) VALUES ('" & d.ToString & "', '" & tCardNumber & "', '" & tAmount & "', '" & tTransactionNumber & "', '" & tShiftNumber & "', '" & tTransactionDataAvailable & "', '-1', '', '" & machine_descriptor & "')"
                                    finfo.Delete()
                                End If
                                If ldirectory_error_reported = False Then
                                    Dim database As FileInfo = New FileInfo(log_directory & "\" & Date.Now.Year & ".mdb")
                                    If database.Exists = False Then
                                        File.Copy(Application.StartupPath & "\Log_Template.mdb", log_directory & "\" & Date.Now.Year & ".mdb")
                                    End If

                                    Dim Conn As Data.OleDb.OleDbConnection
                                    Conn = New Data.OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & database.FullName & ";")
                                    Conn.Open()

                                    Dim recset As Data.OleDb.OleDbCommand = New Data.OleDb.OleDbCommand(SQL, Conn)
                                    Dim result As Integer
                                    result = (recset.ExecuteNonQuery())

                                    recset.Dispose()
                                    Conn.Close()
                                    Conn.Dispose()
                                    database = Nothing
                                Else
                                    Dim errorlog As StreamWriter = New StreamWriter(error_directory & "\Logs\Error_log.txt", True)
                                    errorlog.WriteLine(SQL)
                                    errorlog.Close()
                                End If
                            Else
                                finfo.MoveTo(error_directory & "\Monitor\" & DateTime.Now.Ticks & ".rec")
                                ListBox1.Items.Add(Format(Now, "dd/MM/yyyy hh:mm:ss tt") & ": Error encountered. Transaction file moved to Error Directory")
                                ListBox1.Refresh()
                                Try
                                    Dim strarray() As String
                                    strarray = Directory.GetFiles(error_directory & "\Monitor")
                                    Label33.Text = "Transaction Error Count: " & strarray.Length & " (unprocessed transactions)"
                                    Label33.Refresh()
                                    strarray.Clear(strarray, 0, strarray.Length)
                                Catch ex As Exception
                                    Error_Handler("An """ & ex.Message & """ error occurred while performing Transaction Error Count. The program will attempt to recover shortly.")
                                End Try
                            End If
                            finfo = Nothing

                        Catch ex As Exception

                            finfo.MoveTo(error_directory & "\Monitor\" & DateTime.Now.Ticks & ".rec")
                            ListBox1.Items.Add(Format(Now, "dd/MM/yyyy hh:mm:ss tt") & ": Error encountered. Transaction file moved to Error Directory")
                            ListBox1.Refresh()
                            Try
                                Dim strarray() As String
                                strarray = Directory.GetFiles(error_directory & "\Monitor")
                                Label33.Text = "Transaction Error Count: " & strarray.Length & " (unprocessed transactions)"
                                Label33.Refresh()
                                strarray.Clear(strarray, 0, strarray.Length)
                            Catch ex1 As Exception
                                Error_Handler("An """ & ex1.Message & """ error occurred while performing Transaction Error Count. The program will attempt to recover shortly.")
                            End Try
                        End Try
                        xread.Close()
                        Dim fil As FileInfo = New FileInfo(process_directory & "\errorprocesstransaction.xml")
                        If fil.Exists = True Then
                            fil.Delete()
                        End If
                        fil = Nothing



                        stop_orange_light()

                    Else
                        If delete_monitor_file = True Then
                            If Not finfo.Name.ToLower.EndsWith(".rec") Then
                                ListBox1.Items.Add(Format(Now, "dd/MM/yyyy hh:mm:ss tt") & ": Deleting Invalid Error File: " & finfo.Name)
                                ListBox1.Refresh()
                                finfo.Delete()
                                ListBox1.Items.RemoveAt(ListBox1.Items.Count - 1)
                                ListBox1.Items.Add(Format(Now, "dd/MM/yyyy hh:mm:ss tt") & ": Deleted Invalid Error File: " & finfo.Name)
                                ListBox1.Refresh()
                            End If
                        End If
                    End If

                Next

            End If
            While ListBox1.Items.Count > 50
                ListBox1.Items.RemoveAt(0)
                ListBox1.Refresh()
            End While
            If ListBox1.Items.Count > 0 Then
                ListBox1.SelectedIndex = ListBox1.Items.Count - 1
                ListBox1.ClearSelected()
                ListBox1.Refresh()
            End If

            dinfo = Nothing
            finfo = Nothing



        Catch ex As Exception
            Error_Handler("An """ & ex.Message & """ error occurred in the error folder monitoring controller. The program will attempt to recover shortly.")
        End Try

    End Sub


    Private Sub Directory_Status_Timer_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Directory_Status_Timer.Tick
        directorystatuscode()
    End Sub


    Private Sub Current_Time_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Current_Time.Tick
        If Not Label3.Text = "Stopped" Then
            run_green_lights()
        End If
        Label36.Text = "System Time: " & Format(Now, "dd/MM/yyyy hh:mm:ss tt")
        Label36.Refresh()
    End Sub

    Private Sub Transaction_File_Mover_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Transaction_File_Mover.Tick
        If (transaction_monitor_timer_busy = False) And (machine_status_timer_busy = False) And (directory_status_timer_busy = False) And (transaction_file_mover_busy = False) Then
            transaction_file_mover_busy = True
            Transaction_File_Mover.Interval = transaction_file_mover_interval

            Try
                If mdirectory_error_reported = False Then
                    read_directory_status("m")
                End If

                If mdirectory_error_reported = False Then
                    Dim dinfo As DirectoryInfo = New DirectoryInfo(monitor_directory)
                    Dim finfo As FileInfo
                    If dinfo.GetFiles.Length > 0 Then
                        For Each finfo In dinfo.GetFiles
                            Try
                                If finfo.Name.ToLower = transaction_filename.ToLower Then
                                    finfo.MoveTo(process_directory & "\" & Date.Now().Ticks & transaction_filename.ToLower)
                                End If
                            Catch ex As Exception

                            End Try
                        Next
                    End If

                    dinfo = Nothing
                    finfo = Nothing

                End If
            Catch ex As Exception

            End Try
            transaction_file_mover_busy = False
        Else
            transaction_file_mover_busy = False
            Transaction_File_Mover.Interval = 1000
        End If

        Label43.Text = Transaction_File_Mover.Interval
        Label43.Refresh()
    End Sub

    Private Sub ForceMachineStatus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ForceMachineStatus.Click
        MachineStatusCode()
    End Sub

    Private Sub MachineStatusCode()
        If (transaction_monitor_timer_busy = False) And (machine_status_timer_busy = False) And (directory_status_timer_busy = False) And (transaction_file_mover_busy = False) Then
            machine_status_timer_busy = True
            Machine_Status_Timer.Interval = machine_status_timer_interval

            Try
                Me.Refresh()
            Catch ex As Exception
                Error_Handler("An """ & ex.Message & """ error occurred while redrawing the application screen. The program will attempt to recover shortly.")
            End Try

            Machine_Status_Timer.Stop()
            Label34.Text = "Working..."
            Label34.Refresh()
            MachineStatusLightPicBox.Image = ImageList1.Images(1)
            MachineStatusLightPicBox.Refresh()


            Try
                read_machine_status()
            Catch ex As Exception
                Error_Handler("An """ & ex.Message & """ error occurred while reading the Print Credit Machine status file. The program will attempt to recover shortly.")
            End Try
            machine_status_timer_busy = False

            Machine_Status_Timer.Start()
            Label34.Text = "Next Update: " & Format(Now.AddMilliseconds(Machine_Status_Timer.Interval), "dd/MM/yyyy hh:mm:ss tt")
            Label34.Refresh()
            MachineStatusLightPicBox.Image = ImageList1.Images(4)
            MachineStatusLightPicBox.Refresh()
        Else
            machine_status_timer_busy = False
            Machine_Status_Timer.Interval = 1000
            Label34.Text = "Next Update: " & Format(Now.AddMilliseconds(Machine_Status_Timer.Interval), "dd/MM/yyyy hh:mm:ss tt")
            Label34.Refresh()
        End If


        Label41.Text = Machine_Status_Timer.Interval
        Label41.Refresh()
    End Sub

    Private Sub DirectoryStatusCode()
        If (transaction_monitor_timer_busy = False) And (machine_status_timer_busy = False) And (directory_status_timer_busy = False) And (transaction_file_mover_busy = False) Then
            directory_status_timer_busy = True
            Directory_Status_Timer.Interval = directory_status_timer_interval

            Directory_Status_Timer.Stop()
            Label35.Text = "Working..."
            Label35.Refresh()
            Label39.Text = "Working..."
            Label39.Refresh()
            DirectoryStatusLightPicBox.Image = ImageList1.Images(1)
            DirectoryStatusLightPicBox.Refresh()
            Try
                read_directory_status()
                handle_errors_logfile_handler()
                handle_errors_transaction_handler()

            Catch ex As Exception
                Error_Handler("An """ & ex.Message & """ error occurred while checking the working directories' status. The program will attempt to recover shortly.")
            End Try
            directory_status_timer_busy = False
            Directory_Status_Timer.Start()
            Label39.Text = "Last Update: " & Format(Now(), "dd/MM/yyyy hh:mm:ss tt")
            Label39.Refresh()
            Label35.Text = "Next Update: " & Format(Now.AddMilliseconds(Directory_Status_Timer.Interval), "dd/MM/yyyy hh:mm:ss tt")
            Label35.Refresh()
            DirectoryStatusLightPicBox.Image = ImageList1.Images(4)
            DirectoryStatusLightPicBox.Refresh()
        Else
            directory_status_timer_busy = False
            Directory_Status_Timer.Interval = 1000
            Label35.Text = "Next Update: " & Format(Now.AddMilliseconds(Directory_Status_Timer.Interval), "dd/MM/yyyy hh:mm:ss tt")
            Label35.Refresh()
        End If

        Label42.Text = Directory_Status_Timer.Interval
        Label42.Refresh()
    End Sub

    Private Sub ForceDirectoryStatus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ForceDirectoryStatus.Click
        DirectoryStatusCode()
    End Sub
End Class
