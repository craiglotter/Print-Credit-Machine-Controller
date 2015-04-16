Imports Microsoft.Win32

Public Class Config
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
    Friend WithEvents FolderBrowserDialog1 As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents GroupBox6 As System.Windows.Forms.GroupBox
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox7 As System.Windows.Forms.GroupBox
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox8 As System.Windows.Forms.GroupBox
    Friend WithEvents TextBox4 As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox9 As System.Windows.Forms.GroupBox
    Friend WithEvents TextBox5 As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents GroupBox15 As System.Windows.Forms.GroupBox
    Friend WithEvents TextBox10 As System.Windows.Forms.TextBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(Config))
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog
        Me.Button3 = New System.Windows.Forms.Button
        Me.Button4 = New System.Windows.Forms.Button
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.Button5 = New System.Windows.Forms.Button
        Me.Label3 = New System.Windows.Forms.Label
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.Button2 = New System.Windows.Forms.Button
        Me.Label2 = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Button1 = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.GroupBox9 = New System.Windows.Forms.GroupBox
        Me.TextBox5 = New System.Windows.Forms.TextBox
        Me.GroupBox8 = New System.Windows.Forms.GroupBox
        Me.TextBox4 = New System.Windows.Forms.TextBox
        Me.GroupBox7 = New System.Windows.Forms.GroupBox
        Me.TextBox3 = New System.Windows.Forms.TextBox
        Me.GroupBox6 = New System.Windows.Forms.GroupBox
        Me.TextBox2 = New System.Windows.Forms.TextBox
        Me.GroupBox5 = New System.Windows.Forms.GroupBox
        Me.ComboBox1 = New System.Windows.Forms.ComboBox
        Me.Panel3 = New System.Windows.Forms.Panel
        Me.GroupBox4 = New System.Windows.Forms.GroupBox
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.PictureBox3 = New System.Windows.Forms.PictureBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Panel4 = New System.Windows.Forms.Panel
        Me.GroupBox15 = New System.Windows.Forms.GroupBox
        Me.TextBox10 = New System.Windows.Forms.TextBox
        Me.PictureBox2 = New System.Windows.Forms.PictureBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.Panel1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.GroupBox9.SuspendLayout()
        Me.GroupBox8.SuspendLayout()
        Me.GroupBox7.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.GroupBox15.SuspendLayout()
        Me.SuspendLayout()
        '
        'FolderBrowserDialog1
        '
        Me.FolderBrowserDialog1.Description = "Select the required folder from below"
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.Gainsboro
        Me.Button3.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Location = New System.Drawing.Point(312, 296)
        Me.Button3.Name = "Button3"
        Me.Button3.TabIndex = 4
        Me.Button3.Text = "OK"
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.Gainsboro
        Me.Button4.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.Location = New System.Drawing.Point(392, 296)
        Me.Button4.Name = "Button4"
        Me.Button4.TabIndex = 5
        Me.Button4.Text = "Cancel"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.GroupBox3)
        Me.Panel1.Controls.Add(Me.GroupBox2)
        Me.Panel1.Controls.Add(Me.GroupBox1)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Location = New System.Drawing.Point(4, 32)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(472, 256)
        Me.Panel1.TabIndex = 9
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.WhiteSmoke
        Me.GroupBox3.Controls.Add(Me.Button5)
        Me.GroupBox3.Controls.Add(Me.Label3)
        Me.GroupBox3.Location = New System.Drawing.Point(4, 160)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(464, 64)
        Me.GroupBox3.TabIndex = 14
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Log File Directory"
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.Color.Gainsboro
        Me.Button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button5.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.Location = New System.Drawing.Point(410, 34)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(48, 24)
        Me.Button5.TabIndex = 5
        Me.Button5.Text = "Browse"
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(64, Byte), CType(64, Byte), CType(64, Byte))
        Me.Label3.Location = New System.Drawing.Point(8, 15)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(440, 40)
        Me.Label3.TabIndex = 4
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.WhiteSmoke
        Me.GroupBox2.Controls.Add(Me.Button2)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Location = New System.Drawing.Point(4, 88)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(464, 64)
        Me.GroupBox2.TabIndex = 13
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Broker Submission Directory"
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Gainsboro
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(410, 34)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(48, 24)
        Me.Button2.TabIndex = 5
        Me.Button2.Text = "Browse"
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(64, Byte), CType(64, Byte), CType(64, Byte))
        Me.Label2.Location = New System.Drawing.Point(8, 15)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(440, 40)
        Me.Label2.TabIndex = 4
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(4, 16)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(464, 64)
        Me.GroupBox1.TabIndex = 12
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Monitoring Directory"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Gainsboro
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(410, 34)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(48, 24)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "Browse"
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(64, Byte), CType(64, Byte), CType(64, Byte))
        Me.Label1.Location = New System.Drawing.Point(8, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(440, 40)
        Me.Label1.TabIndex = 2
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(144, 176)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(328, 112)
        Me.PictureBox1.TabIndex = 19
        Me.PictureBox1.TabStop = False
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.Gainsboro
        Me.Label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label4.ForeColor = System.Drawing.Color.Firebrick
        Me.Label4.Location = New System.Drawing.Point(4, 9)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(112, 24)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Working Directories"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Transparent
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.GroupBox9)
        Me.Panel2.Controls.Add(Me.GroupBox8)
        Me.Panel2.Controls.Add(Me.GroupBox7)
        Me.Panel2.Controls.Add(Me.GroupBox6)
        Me.Panel2.Controls.Add(Me.GroupBox5)
        Me.Panel2.Controls.Add(Me.GroupBox4)
        Me.Panel2.Controls.Add(Me.PictureBox3)
        Me.Panel2.Location = New System.Drawing.Point(4, 32)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(472, 256)
        Me.Panel2.TabIndex = 11
        Me.Panel2.Visible = False
        '
        'GroupBox9
        '
        Me.GroupBox9.BackColor = System.Drawing.Color.WhiteSmoke
        Me.GroupBox9.Controls.Add(Me.TextBox5)
        Me.GroupBox9.Location = New System.Drawing.Point(10, 160)
        Me.GroupBox9.Name = "GroupBox9"
        Me.GroupBox9.Size = New System.Drawing.Size(452, 64)
        Me.GroupBox9.TabIndex = 21
        Me.GroupBox9.TabStop = False
        Me.GroupBox9.Text = "Submission Format"
        '
        'TextBox5
        '
        Me.TextBox5.BackColor = System.Drawing.Color.White
        Me.TextBox5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox5.ForeColor = System.Drawing.Color.FromArgb(CType(64, Byte), CType(64, Byte), CType(64, Byte))
        Me.TextBox5.Location = New System.Drawing.Point(12, 26)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(428, 20)
        Me.TextBox5.TabIndex = 4
        Me.TextBox5.Text = ""
        '
        'GroupBox8
        '
        Me.GroupBox8.BackColor = System.Drawing.Color.WhiteSmoke
        Me.GroupBox8.Controls.Add(Me.TextBox4)
        Me.GroupBox8.Location = New System.Drawing.Point(314, 16)
        Me.GroupBox8.Name = "GroupBox8"
        Me.GroupBox8.Size = New System.Drawing.Size(148, 64)
        Me.GroupBox8.TabIndex = 20
        Me.GroupBox8.TabStop = False
        Me.GroupBox8.Text = "Status Filename"
        '
        'TextBox4
        '
        Me.TextBox4.BackColor = System.Drawing.Color.White
        Me.TextBox4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox4.ForeColor = System.Drawing.Color.FromArgb(CType(64, Byte), CType(64, Byte), CType(64, Byte))
        Me.TextBox4.Location = New System.Drawing.Point(12, 26)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(124, 20)
        Me.TextBox4.TabIndex = 4
        Me.TextBox4.Text = ""
        '
        'GroupBox7
        '
        Me.GroupBox7.BackColor = System.Drawing.Color.WhiteSmoke
        Me.GroupBox7.Controls.Add(Me.TextBox3)
        Me.GroupBox7.Location = New System.Drawing.Point(162, 16)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Size = New System.Drawing.Size(148, 64)
        Me.GroupBox7.TabIndex = 19
        Me.GroupBox7.TabStop = False
        Me.GroupBox7.Text = "Shift Filename"
        '
        'TextBox3
        '
        Me.TextBox3.BackColor = System.Drawing.Color.White
        Me.TextBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox3.ForeColor = System.Drawing.Color.FromArgb(CType(64, Byte), CType(64, Byte), CType(64, Byte))
        Me.TextBox3.Location = New System.Drawing.Point(12, 26)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(124, 20)
        Me.TextBox3.TabIndex = 4
        Me.TextBox3.Text = ""
        '
        'GroupBox6
        '
        Me.GroupBox6.BackColor = System.Drawing.Color.WhiteSmoke
        Me.GroupBox6.Controls.Add(Me.TextBox2)
        Me.GroupBox6.Location = New System.Drawing.Point(10, 88)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(148, 64)
        Me.GroupBox6.TabIndex = 18
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "Machine Descriptor"
        '
        'TextBox2
        '
        Me.TextBox2.BackColor = System.Drawing.Color.White
        Me.TextBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox2.ForeColor = System.Drawing.Color.FromArgb(CType(64, Byte), CType(64, Byte), CType(64, Byte))
        Me.TextBox2.Location = New System.Drawing.Point(12, 26)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(124, 20)
        Me.TextBox2.TabIndex = 4
        Me.TextBox2.Text = ""
        '
        'GroupBox5
        '
        Me.GroupBox5.BackColor = System.Drawing.Color.WhiteSmoke
        Me.GroupBox5.Controls.Add(Me.ComboBox1)
        Me.GroupBox5.Controls.Add(Me.Panel3)
        Me.GroupBox5.Location = New System.Drawing.Point(162, 88)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(148, 64)
        Me.GroupBox5.TabIndex = 17
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Delete Invalid Files"
        '
        'ComboBox1
        '
        Me.ComboBox1.BackColor = System.Drawing.Color.White
        Me.ComboBox1.ForeColor = System.Drawing.Color.FromArgb(CType(64, Byte), CType(64, Byte), CType(64, Byte))
        Me.ComboBox1.Items.AddRange(New Object() {"True", "False"})
        Me.ComboBox1.Location = New System.Drawing.Point(16, 24)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox1.TabIndex = 0
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.White
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Location = New System.Drawing.Point(15, 23)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(123, 23)
        Me.Panel3.TabIndex = 1
        '
        'GroupBox4
        '
        Me.GroupBox4.BackColor = System.Drawing.Color.WhiteSmoke
        Me.GroupBox4.Controls.Add(Me.TextBox1)
        Me.GroupBox4.Location = New System.Drawing.Point(10, 16)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(148, 64)
        Me.GroupBox4.TabIndex = 16
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Transaction Filename"
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.Color.White
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox1.ForeColor = System.Drawing.Color.FromArgb(CType(64, Byte), CType(64, Byte), CType(64, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(12, 26)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(124, 20)
        Me.TextBox1.TabIndex = 4
        Me.TextBox1.Text = ""
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(144, 176)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(328, 112)
        Me.PictureBox3.TabIndex = 15
        Me.PictureBox3.TabStop = False
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.Color.Gainsboro
        Me.Label8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label8.ForeColor = System.Drawing.Color.Firebrick
        Me.Label8.Location = New System.Drawing.Point(120, 9)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(112, 24)
        Me.Label8.TabIndex = 12
        Me.Label8.Text = "Monitoring Settings"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, CType((System.Drawing.FontStyle.Italic Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(8, 296)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(104, 16)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "Default Values"
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.Transparent
        Me.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel4.Controls.Add(Me.GroupBox15)
        Me.Panel4.Controls.Add(Me.PictureBox2)
        Me.Panel4.Location = New System.Drawing.Point(4, 32)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(472, 256)
        Me.Panel4.TabIndex = 14
        Me.Panel4.Visible = False
        '
        'GroupBox15
        '
        Me.GroupBox15.BackColor = System.Drawing.Color.WhiteSmoke
        Me.GroupBox15.Controls.Add(Me.TextBox10)
        Me.GroupBox15.Location = New System.Drawing.Point(10, 16)
        Me.GroupBox15.Name = "GroupBox15"
        Me.GroupBox15.Size = New System.Drawing.Size(220, 64)
        Me.GroupBox15.TabIndex = 16
        Me.GroupBox15.TabStop = False
        Me.GroupBox15.Text = "Email Alert Recipient"
        '
        'TextBox10
        '
        Me.TextBox10.BackColor = System.Drawing.Color.White
        Me.TextBox10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox10.ForeColor = System.Drawing.Color.FromArgb(CType(64, Byte), CType(64, Byte), CType(64, Byte))
        Me.TextBox10.Location = New System.Drawing.Point(12, 26)
        Me.TextBox10.Name = "TextBox10"
        Me.TextBox10.Size = New System.Drawing.Size(196, 20)
        Me.TextBox10.TabIndex = 4
        Me.TextBox10.Text = ""
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(144, 176)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(328, 112)
        Me.PictureBox2.TabIndex = 15
        Me.PictureBox2.TabStop = False
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.Gainsboro
        Me.Label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label6.ForeColor = System.Drawing.Color.Firebrick
        Me.Label6.Location = New System.Drawing.Point(236, 9)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(112, 24)
        Me.Label6.TabIndex = 15
        Me.Label6.Text = "Error Handling"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Config
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(480, 328)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Panel2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(486, 360)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(486, 360)
        Me.Name = "Config"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Configuration Options"
        Me.Panel1.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.GroupBox9.ResumeLayout(False)
        Me.GroupBox8.ResumeLayout(False)
        Me.GroupBox7.ResumeLayout(False)
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.GroupBox15.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private submit_directory As String
    Private monitor_directory As String
    Private log_directory As String
    Private transaction_filename As String
    Private shift_filename As String
    Private status_filename As String
    Private submission_format As String
    Private machine_descriptor As String
    Private email_address As String
    Private delete_monitor_file As Boolean

    Public Event ConfigUpdate()

    Private Sub Error_Handler(ByVal message As String)
        Try
            Dim Display_Message1 As New Display_Message(message)
            Display_Message1.ShowDialog()
        Catch ex As Exception
            MsgBox("An error occurred in Print Credit Machine Controller 1.1's error handling routine. The application will try to recover from this serious error.", MsgBoxStyle.Critical, "Critical Error Encountered")
        End Try
    End Sub

    Private Sub Load_Registry_Values()
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
                Dim cform As New Config
                Dim result As DialogResult
                result = cform.ShowDialog()
                If result = DialogResult.OK Then
                    Load_Registry_Values()
                End If
                cform.Dispose()
            End If

            oKey.Close()
            oReg.Close()
            Label1.Text = monitor_directory
            Label2.Text = submit_directory
            Label3.Text = log_directory
            TextBox1.Text = transaction_filename
            TextBox2.Text = machine_descriptor
            TextBox3.Text = shift_filename
            TextBox4.Text = status_filename
            TextBox5.Text = submission_format
            TextBox10.Text = email_address
            If delete_monitor_file = True Then
                ComboBox1.SelectedIndex = 0
            Else
                ComboBox1.SelectedIndex = 1
            End If


        Catch ex As Exception
            Error_Handler("An """ & ex.Message & """ error occurred while loading required registry values. The program will attempt to recover shortly.")
        End Try
    End Sub

    Private Sub default_values()
        monitor_directory = Application.StartupPath & "\Monitor"
        submit_directory = Application.StartupPath & "\Submit"
        log_directory = Application.StartupPath & "\Logs"
        transaction_filename = "transaction.rec"
        shift_filename = "currentshift.rec"
        status_filename = "currentstatus.dat"
        machine_descriptor = "PrintCredit1"
        email_address = "kroberts@commerce.uct.ac.za"
        submission_format = "ACCTBALANCE STUDENT #CARDNUMBER#, #AMOUNT#,PCREDIT,NONE,#MACHINEDESCRIPTOR#"
        delete_monitor_file = True

        Label1.Text = monitor_directory
        Label2.Text = submit_directory
        Label3.Text = log_directory
        TextBox1.Text = transaction_filename
        TextBox2.Text = machine_descriptor
        TextBox3.Text = shift_filename
        TextBox4.Text = status_filename
        TextBox5.Text = submission_format
        TextBox10.Text = email_address
        If delete_monitor_file = True Then
            ComboBox1.SelectedIndex = 0
        Else
            ComboBox1.SelectedIndex = 1
        End If
    End Sub

    Private Sub Save_Registry_Values()
        Try


            Dim oReg As RegistryKey = Registry.LocalMachine
            Dim oKey As RegistryKey = oReg.OpenSubKey("Software\Print Credit Machine Controller", True)
            oKey.SetValue("monitor_directory", Label1.Text)
            oKey.SetValue("submit_directory", Label2.Text)
            oKey.SetValue("log_directory", Label3.Text)
            oKey.SetValue("transaction_filename", TextBox1.Text)
            oKey.SetValue("shift_filename", TextBox3.Text)
            oKey.SetValue("status_filename", TextBox4.Text)
            oKey.SetValue("machine_descriptor", TextBox2.Text)
            oKey.SetValue("submission_format", TextBox5.Text)
            oKey.SetValue("email_address", TextBox10.Text)
            If ComboBox1.SelectedIndex = 0 Then
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


    Private Sub Config_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Load_Registry_Values()
            Panel1.Show()
            Panel2.Hide()
            Panel4.Hide()
            Label4.BackColor = Color.Silver
            Label8.BackColor = Color.Gainsboro
            Label6.BackColor = Color.Gainsboro

        Catch ex As Exception
            Error_Handler("An """ & ex.Message & """ error occurred while opening the config screen. The program will attempt to recover shortly.")
        End Try
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Try


            Dim result As DialogResult
            result = FolderBrowserDialog1.ShowDialog()
            If result = DialogResult.OK Then
                Label1.Text = FolderBrowserDialog1.SelectedPath
                If Label1.Text.EndsWith("\") Then
                    Label1.Text.Remove(Label1.Text.Length - 1, 1)
                End If
                monitor_directory = Label1.Text
            End If
        Catch ex As Exception
            Error_Handler("An """ & ex.Message & """ error occurred while setting the config variable. The program will attempt to recover shortly.")
        End Try
    End Sub

    Private Sub Label4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label4.Click
        Try
            Panel4.Hide()
            Panel2.Hide()
            Panel1.Show()
            Label4.BackColor = Color.Silver
            Label8.BackColor = Color.Gainsboro
            Label6.BackColor = Color.Gainsboro

        Catch ex As Exception
            Error_Handler("An """ & ex.Message & """ error occurred while switching between panels. The program will attempt to recover shortly.")
        End Try

    End Sub

    Private Sub Label8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label8.Click
        Try
            Panel4.Hide()
            Panel1.Hide()
            Panel2.Show()
            Label8.BackColor = Color.Silver
            Label4.BackColor = Color.Gainsboro
            Label6.BackColor = Color.Gainsboro

        Catch ex As Exception
            Error_Handler("An """ & ex.Message & """ error occurred while switching between panels. The program will attempt to recover shortly.")
        End Try
    End Sub

    Private Sub Label6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label6.Click
        Try
            Panel2.Hide()
            Panel1.Hide()
            Panel4.Show()
            Label6.BackColor = Color.Silver
            Label4.BackColor = Color.Gainsboro
            Label8.BackColor = Color.Gainsboro

        Catch ex As Exception
            Error_Handler("An """ & ex.Message & """ error occurred while switching between panels. The program will attempt to recover shortly.")
        End Try
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Try


            Dim result As DialogResult
            result = FolderBrowserDialog1.ShowDialog()
            If result = DialogResult.OK Then
                Label2.Text = FolderBrowserDialog1.SelectedPath

                If Label2.Text.EndsWith("\") Then
                    Label2.Text.Remove(Label2.Text.Length - 1, 1)
                End If
                submit_directory = Label2.Text
            End If
        Catch ex As Exception
            Error_Handler("An """ & ex.Message & """ error occurred while setting the config variable. The program will attempt to recover shortly.")
        End Try
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Try


            Dim result As DialogResult
            result = FolderBrowserDialog1.ShowDialog()
            If result = DialogResult.OK Then
                Label3.Text = FolderBrowserDialog1.SelectedPath

                If Label3.Text.EndsWith("\") Then
                    Label3.Text.Remove(Label3.Text.Length - 1, 1)
                End If
                monitor_directory = Label3.Text
            End If

        Catch ex As Exception
            Error_Handler("An """ & ex.Message & """ error occurred while setting the config variable. The program will attempt to recover shortly.")
        End Try
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Try
            Save_Registry_Values()
            RaiseEvent ConfigUpdate()
        Catch ex As Exception
            Error_Handler("An """ & ex.Message & """ error occurred while closing the config screen. The program will attempt to recover shortly.")
        End Try
    End Sub

    Private Sub Label5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label5.Click
        Try
            default_values()
        Catch ex As Exception
            Error_Handler("An """ & ex.Message & """ error occurred while setting up the default configuration. The program will attempt to recover shortly.")
        End Try
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click

    End Sub


End Class
