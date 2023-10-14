﻿Imports MySql.Data.MySqlClient

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
End Module
