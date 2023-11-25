Imports MySql.Data.MySqlClient

Module Module1
    Dim con As New MySqlConnection
    Dim reader As MySqlDataReader
    Dim mysqlcmd As New MySqlCommand

    Dim host, uname, pwd, dbname As String
    Dim sqlquery As String

    Dim dbTable As New DataTable
    Dim adapter As New MySqlDataAdapter

    Public Sub ConnectDbase()
        host = "127.0.0.1"
        dbname = "cs2aoop"
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

    Public Sub LoadAllData()
        sqlquery = "SELECT * FROM students"
        adapter = New MySqlDataAdapter(sqlquery, con)


        Try


            'display the record in your datagridview
            dbTable = New DataTable
            adapter.Fill(dbTable)

            With Form2.displayDgv
                .DataSource = dbTable
                .AutoResizeColumns()

            End With


        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            con.Close()

        End Try
    End Sub

    Public Sub LoadCourse()
        sqlquery = "SELECT course FROM students"

        Try
            mysqlcmd = New MySqlCommand(sqlquery, con)
            reader = mysqlcmd.ExecuteReader

            While reader.Read
                Form2.cboCourse.Items.Add(reader("course").ToString)
            End While

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            con.Close()

        End Try
    End Sub

    Public Sub DisplayData(kurso As String)
        sqlquery = "SELECT * FROM students WHERE course = @kurso"
        adapter = New MySqlDataAdapter(sqlquery, con)
        adapter.SelectCommand.Parameters.AddWithValue("@kurso", kurso)

        Try
            'display the record in your datagridview
            dbTable = New DataTable
            adapter.Fill(dbTable)

            With Form2.displayDgv
                .DataSource = dbTable
                .AutoResizeColumns()

            End With


        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            con.Close()

        End Try
    End Sub

    Public Sub UpdateRecord(studid As String, fname As String, lname As String, course As String)

        sqlquery = "UPDATE students set studFname = @fname, studLname = @lname, course = @course WHERE studid = @studid"

        Try
            Using cmd As New MySqlCommand(sqlquery, con)
                cmd.Parameters.AddWithValue("@fname", fname)
                cmd.Parameters.AddWithValue("@lname", lname)
                cmd.Parameters.AddWithValue("@course", course)
                cmd.Parameters.AddWithValue("@studid", studid)

                cmd.ExecuteNonQuery()

            End Using

            MsgBox("Update Successful", vbInformation, "Update Message")

        Catch ex As Exception
            MsgBox("Error: " & ex.Message, vbInformation, "Error Message")
        Finally
            Form1.txtFnameSearch.Clear()
            Form1.txtLnameSearch.Clear()
            Form1.txtCourseSearch.Clear()
            Form1.txtUserID.Clear()

        End Try
    End Sub

    Public Sub DeleteRecord(studid As String)

        sqlquery = "DELETE FROM students WHERE studid = @studid"

        Try
            Using cmd As New MySqlCommand(sqlquery, con)
                cmd.Parameters.AddWithValue("@studid", studid)
                cmd.ExecuteNonQuery()

            End Using

            MsgBox("Deletion Successful", vbInformation, "Delete Message")

        Catch ex As Exception
            MsgBox("Error: " & ex.Message, vbInformation, "Error Message")
        Finally
            Form1.txtUserID.Clear()

        End Try

    End Sub
End Module
