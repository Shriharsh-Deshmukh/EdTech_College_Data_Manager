<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Panel1 = New Panel()
        Label2 = New Label()
        Label1 = New Label()
        btnLogin = New Button()
        Panel3 = New Panel()
        txtPassword = New TextBox()
        Panel2 = New Panel()
        textIDNumber = New TextBox()
        PictureBox1 = New PictureBox()
        Label3 = New Label()
        Label5 = New Label()
        TextBox1 = New TextBox()
        Button2 = New Button()
        Panel1.SuspendLayout()
        Panel3.SuspendLayout()
        Panel2.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(161), CByte(0), CByte(0))
        Panel1.Controls.Add(Label2)
        Panel1.Controls.Add(Label1)
        Panel1.Controls.Add(btnLogin)
        Panel1.Controls.Add(Panel3)
        Panel1.Controls.Add(Panel2)
        Panel1.Dock = DockStyle.Right
        Panel1.Location = New Point(411, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(341, 486)
        Panel1.TabIndex = 0
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.White
        Label2.Location = New Point(50, 136)
        Label2.Name = "Label2"
        Label2.Size = New Size(195, 20)
        Label2.TabIndex = 5
        Label2.Text = "Or login with your account"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.White
        Label1.Location = New Point(185, 270)
        Label1.Name = "Label1"
        Label1.Size = New Size(113, 17)
        Label1.TabIndex = 4
        Label1.Text = "Forget password?"
        ' 
        ' btnLogin
        ' 
        btnLogin.BackColor = Color.White
        btnLogin.FlatAppearance.BorderSize = 0
        btnLogin.FlatStyle = FlatStyle.Flat
        btnLogin.Font = New Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnLogin.ForeColor = Color.FromArgb(CByte(161), CByte(0), CByte(0))
        btnLogin.Location = New Point(52, 264)
        btnLogin.Name = "btnLogin"
        btnLogin.Size = New Size(75, 29)
        btnLogin.TabIndex = 2
        btnLogin.Text = "LOGIN"
        btnLogin.UseVisualStyleBackColor = False
        ' 
        ' Panel3
        ' 
        Panel3.BackColor = Color.White
        Panel3.Controls.Add(txtPassword)
        Panel3.Location = New Point(50, 212)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(248, 31)
        Panel3.TabIndex = 3
        ' 
        ' txtPassword
        ' 
        txtPassword.BorderStyle = BorderStyle.None
        txtPassword.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        txtPassword.Location = New Point(10, 5)
        txtPassword.Name = "txtPassword"
        txtPassword.Size = New Size(230, 22)
        txtPassword.TabIndex = 2
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.White
        Panel2.Controls.Add(textIDNumber)
        Panel2.Location = New Point(50, 168)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(248, 31)
        Panel2.TabIndex = 2
        ' 
        ' textIDNumber
        ' 
        textIDNumber.BorderStyle = BorderStyle.None
        textIDNumber.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        textIDNumber.Location = New Point(10, 5)
        textIDNumber.Name = "textIDNumber"
        textIDNumber.Size = New Size(230, 22)
        textIDNumber.TabIndex = 2
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), Image)
        PictureBox1.BackgroundImageLayout = ImageLayout.None
        PictureBox1.Location = New Point(-19, 48)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(233, 55)
        PictureBox1.TabIndex = 1
        PictureBox1.TabStop = False
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = Color.White
        Label3.Location = New Point(24, 126)
        Label3.Name = "Label3"
        Label3.Size = New Size(109, 30)
        Label3.TabIndex = 6
        Label3.Text = "Welcome "
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI Semibold", 11F, FontStyle.Bold)
        Label5.ForeColor = Color.Gray
        Label5.Location = New Point(24, 160)
        Label5.Name = "Label5"
        Label5.Size = New Size(236, 20)
        Label5.TabIndex = 7
        Label5.Text = "Register for new EdTech Account."
        ' 
        ' TextBox1
        ' 
        TextBox1.BackColor = Color.FromArgb(CByte(54), CByte(60), CByte(72))
        TextBox1.BorderStyle = BorderStyle.None
        TextBox1.Font = New Font("Segoe UI Semibold", 11F, FontStyle.Bold)
        TextBox1.ForeColor = Color.Gray
        TextBox1.Location = New Point(24, 194)
        TextBox1.Multiline = True
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(381, 138)
        TextBox1.TabIndex = 8
        TextBox1.Text = "Designed to simplify and secure data management, " & vbCrLf & "EdTech Database Manager empowers you to handle " & vbCrLf & "all aspects of data. Register now to streamline your " & vbCrLf & "database management."
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.FromArgb(CByte(161), CByte(0), CByte(0))
        Button2.FlatAppearance.BorderSize = 0
        Button2.FlatStyle = FlatStyle.Flat
        Button2.Font = New Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button2.ForeColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        Button2.Location = New Point(24, 300)
        Button2.Name = "Button2"
        Button2.Size = New Size(134, 32)
        Button2.TabIndex = 10
        Button2.Text = "REGISTER HERE"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(54), CByte(60), CByte(72))
        ClientSize = New Size(752, 486)
        Controls.Add(Button2)
        Controls.Add(TextBox1)
        Controls.Add(Label5)
        Controls.Add(Label3)
        Controls.Add(PictureBox1)
        Controls.Add(Panel1)
        FormBorderStyle = FormBorderStyle.None
        Name = "Form1"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Form1"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        Panel3.ResumeLayout(False)
        Panel3.PerformLayout()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents textIDNumber As TextBox
    Friend WithEvents Panel3 As Panel
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents btnLogin As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Button2 As Button

End Class
