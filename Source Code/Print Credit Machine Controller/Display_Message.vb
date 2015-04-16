Public Class Display_Message
    Inherits System.Windows.Forms.Form

#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call

    End Sub

    Public Sub New(ByVal display As String)
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call
        Label1.Text = display
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
    Friend WithEvents Transaction_Monitor_Timer As System.Windows.Forms.Timer
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(Display_Message))
        Me.Transaction_Monitor_Timer = New System.Windows.Forms.Timer(Me.components)
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'Transaction_Monitor_Timer
        '
        Me.Transaction_Monitor_Timer.Interval = 1000
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(6, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(303, 88)
        Me.Label1.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(6, 96)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(303, 24)
        Me.Label2.TabIndex = 1
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Display_Message
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(314, 120)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(320, 152)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(320, 152)
        Me.Name = "Display_Message"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Print Credit Machine Controller 1.1"
        Me.ResumeLayout(False)

    End Sub

#End Region
    Private elapsed As Integer

    Private Sub Display_Message_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        elapsed = 0
        Label2.Text = "Closing in " & (10 - elapsed).ToString & " secs"
        Transaction_Monitor_Timer.Start()
    End Sub

    Private Sub TickHandler(ByVal sender As Object, ByVal e As System.EventArgs) Handles Transaction_Monitor_Timer.Tick
        elapsed = elapsed + 1
        Label2.Text = "Closing in " & (10 - elapsed).ToString & " secs"
        If elapsed = 10 Then
            Transaction_Monitor_Timer.Stop()
            Me.Close()
        End If
    End Sub
End Class
