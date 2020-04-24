Imports System.Data.OleDb


Public Class Employees
    Dim CON As New OleDbConnection
    Private Sub Employees_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'Me.RegistrationTableAdapter.Fill(Me.SaleDataSet.Registration)
        CON.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + "D:\Payroll Finals\Payroll Garena.accdb"
    End Sub
    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs) Handles Button3.Click
        Me.Hide()
        FrmMain.Show()
        TextBox1.Clear()
    End Sub
    Private Sub Employees_FormClosing(sender As System.Object, e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        Me.Hide()
        FrmMain.Show()
    End Sub
    Private Sub Timer1_Tick(sender As System.Object, e As System.EventArgs) Handles Timer1.Tick
        ToolStripStatusLabel4.Text = Date.Now.ToString("mm/dd/yyyy [hh:mm:ss]")
    End Sub
    Private Sub Button4_Click(sender As System.Object, e As System.EventArgs) Handles Button4.Click
        If Len(Trim(TextBox1.Text)) = 0 Then
            MsgBox("Please input employee ID!", MsgBoxStyle.OkOnly + MsgBoxStyle.Exclamation, "Admin")
            TextBox1.Focus()
            Exit Sub
        End If


        CON.Open()

        Dim DT As New DataTable
        Dim DS As New DataSet
        DS.Tables.Add(DT)
        Dim DA As New OleDbDataAdapter


        DA = New OleDbDataAdapter("Select * From [Employee] where ID like'%" & TextBox1.Text & "%'", CON)
        DA.Fill(DT)
        DataGridView1.DataSource = DT.DefaultView

        CON.Close()
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        CON.Open()

        Dim DT As New DataTable
        Dim DS As New DataSet
        DS.Tables.Add(DT)
        Dim DA As New OleDbDataAdapter


        DA = New OleDbDataAdapter("Select * From [Employee] ", CON)
        DA.Fill(DT)
        DataGridView1.DataSource = DT.DefaultView

        CON.Close()

    End Sub
End Class