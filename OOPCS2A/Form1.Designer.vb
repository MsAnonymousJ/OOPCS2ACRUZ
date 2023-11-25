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
        Label8 = New Label()
        GroupBox2 = New GroupBox()
        Label5 = New Label()
        Label6 = New Label()
        txtCourseSearch = New TextBox()
        txtLnameSearch = New TextBox()
        Label7 = New Label()
        txtFnameSearch = New TextBox()
        Label4 = New Label()
        btnSearch = New Button()
        txtUserID = New TextBox()
        displayBtn = New Button()
        btnDelete = New Button()
        btnUpdate = New Button()
        GroupBox1.SuspendLayout()
        Panel1.SuspendLayout()
        GroupBox2.SuspendLayout()
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
        btnInsert.Location = New Point(125, 193)
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
        GroupBox1.Location = New Point(28, 133)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(352, 250)
        GroupBox1.TabIndex = 7
        GroupBox1.TabStop = False
        GroupBox1.Text = "Save Record"
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.LightSteelBlue
        Panel1.Controls.Add(Label8)
        Panel1.Location = New Point(12, 11)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(781, 116)
        Panel1.TabIndex = 8
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Segoe UI Black", 20.25F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point)
        Label8.ForeColor = Color.AliceBlue
        Label8.Location = New Point(279, 37)
        Label8.Name = "Label8"
        Label8.Size = New Size(218, 37)
        Label8.TabIndex = 0
        Label8.Text = "Student Record"
        ' 
        ' GroupBox2
        ' 
        GroupBox2.Controls.Add(Label5)
        GroupBox2.Controls.Add(Label6)
        GroupBox2.Controls.Add(txtCourseSearch)
        GroupBox2.Controls.Add(txtLnameSearch)
        GroupBox2.Controls.Add(Label7)
        GroupBox2.Controls.Add(txtFnameSearch)
        GroupBox2.Controls.Add(Label4)
        GroupBox2.Controls.Add(btnSearch)
        GroupBox2.Controls.Add(txtUserID)
        GroupBox2.Font = New Font("Segoe UI", 12F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point)
        GroupBox2.Location = New Point(396, 133)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Size = New Size(379, 250)
        GroupBox2.TabIndex = 9
        GroupBox2.TabStop = False
        GroupBox2.Text = "Search Record"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label5.Location = New Point(51, 72)
        Label5.Name = "Label5"
        Label5.Size = New Size(88, 21)
        Label5.TabIndex = 7
        Label5.Text = "First Name"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label6.Location = New Point(51, 106)
        Label6.Name = "Label6"
        Label6.Size = New Size(86, 21)
        Label6.TabIndex = 8
        Label6.Text = "Last Name"
        ' 
        ' txtCourseSearch
        ' 
        txtCourseSearch.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point)
        txtCourseSearch.Location = New Point(188, 139)
        txtCourseSearch.Name = "txtCourseSearch"
        txtCourseSearch.ReadOnly = True
        txtCourseSearch.Size = New Size(134, 29)
        txtCourseSearch.TabIndex = 11
        ' 
        ' txtLnameSearch
        ' 
        txtLnameSearch.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point)
        txtLnameSearch.Location = New Point(188, 103)
        txtLnameSearch.Name = "txtLnameSearch"
        txtLnameSearch.ReadOnly = True
        txtLnameSearch.Size = New Size(134, 29)
        txtLnameSearch.TabIndex = 12
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label7.Location = New Point(51, 142)
        Label7.Name = "Label7"
        Label7.Size = New Size(61, 21)
        Label7.TabIndex = 9
        Label7.Text = "Course"
        ' 
        ' txtFnameSearch
        ' 
        txtFnameSearch.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point)
        txtFnameSearch.Location = New Point(188, 69)
        txtFnameSearch.Name = "txtFnameSearch"
        txtFnameSearch.ReadOnly = True
        txtFnameSearch.Size = New Size(134, 29)
        txtFnameSearch.TabIndex = 10
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label4.Location = New Point(51, 35)
        Label4.Name = "Label4"
        Label4.Size = New Size(63, 21)
        Label4.TabIndex = 0
        Label4.Text = "User ID"
        ' 
        ' btnSearch
        ' 
        btnSearch.AutoSize = True
        btnSearch.BackColor = Color.LightSteelBlue
        btnSearch.FlatStyle = FlatStyle.Popup
        btnSearch.Font = New Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point)
        btnSearch.ForeColor = Color.AliceBlue
        btnSearch.Location = New Point(125, 193)
        btnSearch.Name = "btnSearch"
        btnSearch.Size = New Size(140, 37)
        btnSearch.TabIndex = 6
        btnSearch.Text = "Search Record"
        btnSearch.UseVisualStyleBackColor = False
        ' 
        ' txtUserID
        ' 
        txtUserID.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point)
        txtUserID.Location = New Point(188, 32)
        txtUserID.Name = "txtUserID"
        txtUserID.Size = New Size(134, 29)
        txtUserID.TabIndex = 3
        ' 
        ' displayBtn
        ' 
        displayBtn.AutoSize = True
        displayBtn.BackColor = Color.LightSteelBlue
        displayBtn.FlatStyle = FlatStyle.Popup
        displayBtn.Font = New Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point)
        displayBtn.ForeColor = Color.AliceBlue
        displayBtn.Location = New Point(322, 414)
        displayBtn.Name = "displayBtn"
        displayBtn.Size = New Size(172, 54)
        displayBtn.TabIndex = 7
        displayBtn.Text = "Display by Course"
        displayBtn.UseVisualStyleBackColor = False
        ' 
        ' btnDelete
        ' 
        btnDelete.AutoSize = True
        btnDelete.BackColor = Color.LightSteelBlue
        btnDelete.FlatStyle = FlatStyle.Popup
        btnDelete.Font = New Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point)
        btnDelete.ForeColor = Color.AliceBlue
        btnDelete.Location = New Point(84, 414)
        btnDelete.Name = "btnDelete"
        btnDelete.Size = New Size(172, 54)
        btnDelete.TabIndex = 10
        btnDelete.Text = "Delete"
        btnDelete.UseVisualStyleBackColor = False
        ' 
        ' btnUpdate
        ' 
        btnUpdate.AutoSize = True
        btnUpdate.BackColor = Color.LightSteelBlue
        btnUpdate.FlatStyle = FlatStyle.Popup
        btnUpdate.Font = New Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point)
        btnUpdate.ForeColor = Color.AliceBlue
        btnUpdate.Location = New Point(556, 414)
        btnUpdate.Name = "btnUpdate"
        btnUpdate.Size = New Size(172, 54)
        btnUpdate.TabIndex = 11
        btnUpdate.Text = "Update"
        btnUpdate.UseVisualStyleBackColor = False
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.AliceBlue
        ClientSize = New Size(800, 535)
        Controls.Add(btnUpdate)
        Controls.Add(btnDelete)
        Controls.Add(displayBtn)
        Controls.Add(GroupBox2)
        Controls.Add(Panel1)
        Controls.Add(GroupBox1)
        Name = "Form1"
        Text = "Student Record"
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        GroupBox2.ResumeLayout(False)
        GroupBox2.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
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
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label4 As Label
    Friend WithEvents btnSearch As Button
    Friend WithEvents txtUserID As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txtCourseSearch As TextBox
    Friend WithEvents txtLnameSearch As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txtFnameSearch As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents displayBtn As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnUpdate As Button
End Class
