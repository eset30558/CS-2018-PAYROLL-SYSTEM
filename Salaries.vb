Imports System.Data.OleDb

Public Class Salaries
    Dim CON As New OleDbConnection
    Private Sub Salaries_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'Me.RegistrationTableAdapter.Fill(Me.SaleDataSet.Registration)
        CON.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + "D:\Payroll Finals\Payroll Garena.accdb"
    End Sub
    Private Sub Button5_Click(sender As System.Object, e As System.EventArgs) Handles Button5.Click
        Me.Hide()
        FrmMain.Show()
        TextBox2.Clear()
    End Sub
    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs)
        Me.Hide()
        Employees.Show()
    End Sub
    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs) Handles Button3.Click
        Me.Hide()
        PayrollCompute.Show()
        TextBox2.Clear()
    End Sub
    Private Sub Timer1_Tick(sender As System.Object, e As System.EventArgs) Handles Timer1.Tick
        ToolStripStatusLabel4.Text = Date.Now.ToString("dd/mm/yyyy [hh:mm:ss]")
    End Sub
    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        If Len(Trim(TextBox2.Text)) = 0 Then
            MsgBox("Please input SALARY ID!", MsgBoxStyle.OkOnly + MsgBoxStyle.Exclamation, "Admin")
            TextBox2.Focus()
            Exit Sub
        End If

        CON.Open()

        Dim DT As New DataTable
        Dim DS As New DataSet
        DS.Tables.Add(DT)
        Dim DA As New OleDbDataAdapter


        DA = New OleDbDataAdapter("Select * From [Payroll] where Salary_ID like'%" & TextBox2.Text & "%'", CON)
        DA.Fill(DT)
        DataGridView1.DataSource = DT.DefaultView

        CON.Close()
    End Sub
    Private Bitmap As Bitmap
    Private Sub Button4_Click(sender As System.Object, e As System.EventArgs) Handles Button4.Click
        Dim height As Integer = DataGridView1.Height
        DataGridView1.Height = DataGridView1.RowCount * DataGridView1.RowTemplate.Height
        Bitmap = New Bitmap(Me.DataGridView1.Width, Me.DataGridView1.Height)
        DataGridView1.DrawToBitmap(Bitmap, New Rectangle(0, 0, Me.DataGridView1.Width, Me.DataGridView1.Height))
        PrintPreviewDialog1.Document = PrintDocument1
        PrintPreviewDialog1.PrintPreviewControl.Zoom = 1
        PrintPreviewDialog1.ShowDialog()
        DataGridView1.Height = Width

    End Sub

    Private Sub PrintDocument1_PrintPage(sender As System.Object, e As System.Drawing.Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        e.Graphics.DrawImage(Bitmap, 0, 0)
        Dim rectPrint As RectangleF = e.PageSettings.PrintableArea
        'changed the height to width if printing in landscape mode
        If Me.DataGridView1.Width * rectPrint.Width > 0 Then e.HasMorePages = True
    End Sub

    Private Sub Button2_Click_1(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        CON.Open()

        Dim DT As New DataTable
        Dim DS As New DataSet
        DS.Tables.Add(DT)
        Dim DA As New OleDbDataAdapter


        DA = New OleDbDataAdapter("Select * From [Payroll] ", CON)
        DA.Fill(DT)
        DataGridView1.DataSource = DT.DefaultView

        CON.Close()
    End Sub
End Class