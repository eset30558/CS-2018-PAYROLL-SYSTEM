Imports System.Data.OleDb
Imports System.Data

Public Class NewEmployee
    Dim provider As String
    Dim datafile As String
    Dim connString As String
    Dim myConnection As OleDbConnection = New OleDbConnection
    Dim ID_add As String

    Private Sub NewEmployee_FormClosing(sender As System.Object, e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        Me.Hide()
        FrmMain.Show()
    End Sub
    Private Sub NewEmployee_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Timer1.Start()
    End Sub
    Private Sub Timer1_Tick(sender As System.Object, e As System.EventArgs) Handles Timer1.Tick
        ToolStripStatusLabel4.Text = Date.Now.ToString("dd/mm/yyyy [hh:mm:ss]")
    End Sub
    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        If Len(Trim(F_NAME.Text)) = 0 Then
            MsgBox("Please input first name!", MsgBoxStyle.OkOnly + MsgBoxStyle.Exclamation, "Admin")
            F_NAME.Focus()
            Exit Sub
        End If
        If Len(Trim(M_NAME.Text)) = 0 Then
            MsgBox("Please input middle name!", MsgBoxStyle.OkOnly + MsgBoxStyle.Exclamation, "Admin")
            M_NAME.Focus()
            Exit Sub
        End If
        If Len(Trim(L_NAME.Text)) = 0 Then
            MsgBox("Please input last name!", MsgBoxStyle.OkOnly + MsgBoxStyle.Exclamation, "Admin")
            L_NAME.Focus()
            Exit Sub
        End If
        If Len(Trim(ADDRESS.Text)) = 0 Then
            MsgBox("Please input position!", MsgBoxStyle.OkOnly + MsgBoxStyle.Exclamation, "Admin")
            ADDRESS.Focus()
            Exit Sub
        End If
        If Len(Trim(POSITION.Text)) = 0 Then
            MsgBox("Please input Regular/Casual!", MsgBoxStyle.OkOnly + MsgBoxStyle.Exclamation, "Admin")
            POSITION.Focus()
            Exit Sub
        End If
        If Len(Trim(DOB.Text)) = 0 Then
            MsgBox("Please input last name!", MsgBoxStyle.OkOnly + MsgBoxStyle.Exclamation, "Admin")
            L_NAME.Focus()
            Exit Sub
        End If



        Dim connect As OleDbConnection = Nothing
        Dim command As OleDbCommand = Nothing

        Dim str As String = "Insert into [Employee]([FirstName],[MiddleName],[LastName],[Position],[Address],[Date of Birth]) Values (@d2,@d3,@d4,@d5,@d6,@d7)"
        Dim conn As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + "D:\Payroll Finals\Payroll Garena.accdb;"
        connect = New OleDbConnection(conn)
        connect.Open()

        command = New OleDbCommand(str)
        command.Connection = connect

        command.Parameters.Add(New OleDbParameter("@d2", System.Data.OleDb.OleDbType.VarChar, 30, "FirstName"))
        command.Parameters.Add(New OleDbParameter("@d3", System.Data.OleDb.OleDbType.VarChar, 30, "MiddleName"))
        command.Parameters.Add(New OleDbParameter("@d4", System.Data.OleDb.OleDbType.VarChar, 30, "LastName"))
        command.Parameters.Add(New OleDbParameter("@d5", System.Data.OleDb.OleDbType.VarChar, 30, "Position"))
        command.Parameters.Add(New OleDbParameter("@d6", System.Data.OleDb.OleDbType.VarChar, 30, "Addresss"))
        command.Parameters.Add(New OleDbParameter("@d7", System.Data.OleDb.OleDbType.VarChar, 30, "Date of Birth"))


        command.Parameters("@d2").Value = Trim(F_NAME.Text)
        command.Parameters("@d3").Value = Trim(M_NAME.Text)
        command.Parameters("@d4").Value = Trim(L_NAME.Text)
        command.Parameters("@d5").Value = Trim(POSITION.Text)
        command.Parameters("@d6").Value = Trim(ADDRESS.Text)
        command.Parameters("@d7").Value = Trim(DOB.Text)




        Try
            MsgBox("Successfully registered!", MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Admin")
            command.ExecuteReader()
            F_NAME.Clear()
            M_NAME.Clear()
            L_NAME.Clear()
            POSITION.Clear()
            ADDRESS.Clear()
            DOB.Clear()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub
    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        Me.Hide()
        Employees.Show()
        F_NAME.Clear()
        M_NAME.Clear()
        L_NAME.Clear()
        ADDRESS.Clear()
        POSITION.Clear()
    End Sub
    Private Sub Button3_Click_1(sender As System.Object, e As System.EventArgs) Handles Button3.Click
        Me.Hide()
        FrmMain.Show()
        F_NAME.Clear()
        M_NAME.Clear()
        L_NAME.Clear()
        ADDRESS.Clear()
        POSITION.Clear()
    End Sub
End Class