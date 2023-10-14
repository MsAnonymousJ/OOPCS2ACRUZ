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
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        txtFname = New TextBox()
        txtCourse = New TextBox()
        txtLname = New TextBox()
        btnInsert = New Button()
        GroupBox1 = New GroupBox()
        Panel1 = New Panel()
        GroupBox1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.Location = New Point(56, 35)
        Label1.Name = "Label1"
        Label1.Size = New Size(88, 21)
        Label1.TabIndex = 0
        Label1.Text = "First Name"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label2.Location = New Point(56, 69)
        Label2.Name = "Label2"
        Label2.Size = New Size(86, 21)
        Label2.TabIndex = 1
        Label2.Text = "Last Name"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label3.Location = New Point(56, 105)
        Label3.Name = "Label3"
        Label3.Size = New Size(61, 21)
        Label3.TabIndex = 2
        Label3.Text = "Course"
        ' 
        ' txtFname
        ' 
        txtFname.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point)
        txtFname.Location = New Point(193, 32)
        txtFname.Name = "txtFname"
        txtFname.Size = New Size(134, 29)
        txtFname.TabIndex = 3
        ' 
        ' txtCourse
        ' 
        txtCourse.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point)
        txtCourse.Location = New Point(193, 102)
        txtCourse.Name = "txtCourse"
        txtCourse.Size = New Size(134, 29)
        txtCourse.TabIndex = 4
        ' 
        ' txtLname
        ' 
        txtLname.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point)
        txtLname.Location = New Point(193, 66)
        txtLname.Name = "txtLname"
        txtLname.Size = New Size(134, 29)
        txtLname.TabIndex = 5
        ' 
        ' btnInsert
        ' 
        btnInsert.AutoSize = True
        btnInsert.BackColor = Color.LightSteelBlue
        btnInsert.FlatStyle = FlatStyle.Popup
        btnInsert.Font = New Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point)
        btnInsert.ForeColor = Color.AliceBlue
        btnInsert.Location = New Point(106, 151)
        btnInsert.Name = "btnInsert"
        btnInsert.Size = New Size(140, 37)
        btnInsert.TabIndex = 6
        btnInsert.Text = "Insert Record"
        btnInsert.UseVisualStyleBackColor = False
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(Label1)
        GroupBox1.Controls.Add(btnInsert)
        GroupBox1.Controls.Add(Label2)
        GroupBox1.Controls.Add(txtCourse)
        GroupBox1.Controls.Add(txtLname)
        GroupBox1.Controls.Add(Label3)
        GroupBox1.Controls.Add(txtFname)
        GroupBox1.Font = New Font("Segoe UI", 12F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point)
        GroupBox1.Location = New Point(250, 143)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(379, 207)
        GroupBox1.TabIndex = 7
        GroupBox1.TabStop = False
        GroupBox1.Text = "Save Record"
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.LightSteelBlue
        Panel1.Location = New Point(12, 11)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(781, 116)
        Panel1.TabIndex = 8
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.AliceBlue
        ClientSize = New Size(800, 450)
        Controls.Add(Panel1)
        Controls.Add(GroupBox1)
        Name = "Form1"
        Text = "Student Record"
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtFname As TextBox
    Friend WithEvents txtCourse As TextBox
    Friend WithEvents txtLname As TextBox
    Friend WithEvents btnInsert As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Panel1 As Panel
End Class
