<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        displayDgv = New DataGridView()
        cboCourse = New ComboBox()
        displayBtn = New Button()
        btnBack = New Button()
        CType(displayDgv, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' displayDgv
        ' 
        displayDgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        displayDgv.Location = New Point(80, 123)
        displayDgv.Name = "displayDgv"
        displayDgv.RowTemplate.Height = 25
        displayDgv.Size = New Size(435, 426)
        displayDgv.TabIndex = 0
        ' 
        ' cboCourse
        ' 
        cboCourse.FormattingEnabled = True
        cboCourse.Location = New Point(80, 84)
        cboCourse.Name = "cboCourse"
        cboCourse.Size = New Size(214, 23)
        cboCourse.TabIndex = 1
        ' 
        ' displayBtn
        ' 
        displayBtn.Location = New Point(440, 83)
        displayBtn.Name = "displayBtn"
        displayBtn.Size = New Size(75, 23)
        displayBtn.TabIndex = 2
        displayBtn.Text = "Display"
        displayBtn.UseVisualStyleBackColor = True
        ' 
        ' btnBack
        ' 
        btnBack.Location = New Point(267, 587)
        btnBack.Name = "btnBack"
        btnBack.Size = New Size(75, 23)
        btnBack.TabIndex = 3
        btnBack.Text = "Home"
        btnBack.UseVisualStyleBackColor = True
        ' 
        ' Form2
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(584, 661)
        Controls.Add(btnBack)
        Controls.Add(displayBtn)
        Controls.Add(cboCourse)
        Controls.Add(displayDgv)
        Name = "Form2"
        Text = "Form2"
        CType(displayDgv, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents displayDgv As DataGridView
    Friend WithEvents cboCourse As ComboBox
    Friend WithEvents displayBtn As Button
    Friend WithEvents btnBack As Button
End Class
