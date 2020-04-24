Imports System.Data
Imports System.Data.OleDb

Public Class Form1

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        If Len(Trim(Username.Text)) = 0 Then
            MessageBox.Show("Input UserName!", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Username.Focus()
            Exit Sub
        End If
        If Len(Trim(Password.Text)) = 0 Then
            MessageBox.Show("Input Password!", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Password.Focus()
            Exit Sub
        End If

        Try
            Dim Myconnection As OleDbConnection
            Myconnection = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + "D:\Payroll Finals\Payroll Garena.accdb;")
            Dim Mycommand As OleDbCommand
            Mycommand = New OleDbCommand("SELECT Username, Password FROM [Admin] WHERE Username = @UserName AND Password = @Password", Myconnection)
            Dim uName As New OleDbParameter("@UserName", SqlDbType.VarChar)
            Dim uPass As New OleDbParameter("@Password", SqlDbType.VarChar)

            uName.Value = Username.Text
            uPass.Value = Password.Text
            Mycommand.Parameters.Add(uName)
            Mycommand.Parameters.Add(uPass)
            Mycommand.Connection.Open()
            Dim Myreader As OleDbDataReader = Mycommand.ExecuteReader(CommandBehavior.CloseConnection)
            Dim Login As Object = 0
            If Myreader.HasRows Then
                Myreader.Read()
                Login = Myreader(Login)
            End If
            If Login = Nothing Then
                MsgBox("Login failed!... Try Again!", MsgBoxStyle.Critical, "Login Denied")
            Else
                FrmMain.ToolStripStatusLabel2.Text = Username.Text
                ProgressBar1.Maximum = 500
                ProgressBar1.Minimum = 0
                Timer1.Start()
                ProgressBar1.Increment(40)
                If ProgressBar1.Value = 500 Then
                    Me.Hide()
                    FrmMain.Show()
                    Timer1.Stop()
                    ProgressBar1.Value = 0
                    Username.Text = ""
                    Password.Text = ""
                End If
            End If
            Mycommand.Dispose()
            Myconnection.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        If MsgBox("Do you want to exit?", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "Admin") = Windows.Forms.DialogResult.Yes Then
            Close()
        End If
    End Sub

    Private Sub Timer1_Tick(sender As System.Object, e As System.EventArgs) Handles Timer1.Tick
        Button1.PerformClick()
    End Sub
End Class
