Imports MySql.Data.MySqlClient

Module Module1
    Dim con As New MySqlConnection
    Dim reader As MySqlDataReader
    Dim mysqlcmd As New MySqlCommand

    Dim host, uname, pwd, dbname As String
    Dim sqlquery As String

    Public Sub ConnectDbase()
        host = "127.0.0.1"
        dbname = "cs2a_oop"
        uname = "root"
        pwd = "password"

        If Not con Is Nothing Then
            con.Close()
            con.ConnectionString = "server =" & host & "; user id=" & uname & "; password=" & pwd & "; database=" & dbname & ""

            Try
                con.Open()
                MessageBox.Show("Connected!")
            Catch ex As Exception

            End Try
        End If
    End Sub

    Public Sub SaveRecord()
        sqlquery = "INSERT INTO students (studFName, studLName, Course) VALUES (@fname, @lname, @course)"
        mysqlcmd = New MySqlCommand(sqlquery, con)

        Dim fname = Form1.txtFname.Text
        Dim lname = Form1.txtLname.Text
        Dim course = Form1.txtCourse.Text

        mysqlcmd.Parameters.AddWithValue("@fname", fname)
        mysqlcmd.Parameters.AddWithValue("@lname", lname)
        mysqlcmd.Parameters.AddWithValue("@course", course)

        Try
            mysqlcmd.ExecuteNonQuery()
            MsgBox("Record Saved Successfully!")
        Catch ex As Exception
            MessageBox.Show("Error " & ex.Message)
        Finally
            Form1.txtFname.Clear()
            Form1.txtLname.Clear()
            Form1.txtCourse.Clear()
        End Try
    End Sub

    Public Sub SearchData()
        sqlquery = "SELECT * FROM students WHERE studID = @uid"
        mysqlcmd = New MySqlCommand(sqlquery, con)

        Dim uid As String
        uid = Form1.txtUserID.text

        mysqlcmd.Parameters.AddWithValue("@uid", uid)

        Try
            reader = mysqlcmd.ExecuteReader()
            If reader.Read Then
                Form1.txtFnameSearch.Text = reader("StudFName").ToString
                Form1.txtLnameSearch.Text = reader("StudLName").ToString
                Form1.txtCourseSearch.Text = reader("Course").ToString
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            reader.Close()
        End Try

    End Sub
End Module
