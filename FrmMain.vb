Public Class FrmMain
    Private Sub FrmMain_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Timer1.Start()
        If Button1.Enabled = True Then
            NewEmployee.ToolStripStatusLabel2.Text = Form1.Username.Text
            Exit Sub
        End If
    End Sub
    Private Sub Timer1_Tick(sender As System.Object, e As System.EventArgs) Handles Timer1.Tick
        ToolStripStatusLabel4.Text = Date.Now.ToString("dd/mm/yyyy [hh:mm:ss]")
    End Sub
    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Me.Hide()
        NewEmployee.Show()
    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        Me.Hide()
        Employees.Show()
        If Button2.Enabled = True Then
            Employees.ToolStripStatusLabel2.Text = NewEmployee.ToolStripStatusLabel2.Text
            Exit Sub
        End If
    End Sub
    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs) Handles Button3.Click
        Me.Hide()
        PayrollCompute.Show()
        If Button3.Enabled = True Then
            PayrollCompute.ToolStripStatusLabel2.Text = NewEmployee.ToolStripStatusLabel2.Text
        End If
    End Sub
    Private Sub Button4_Click(sender As System.Object, e As System.EventArgs) Handles Button4.Click
        Me.Hide()
        Salaries.Show()
        If Button4.Enabled = True Then
            Salaries.ToolStripStatusLabel2.Text = NewEmployee.ToolStripStatusLabel2.Text
        End If
    End Sub
    Private Sub Button5_Click(sender As System.Object, e As System.EventArgs) Handles Button5.Click
        If MsgBox("Do you want to Logout?", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "Admin") = Windows.Forms.DialogResult.Yes Then
            Me.Hide()
            Form1.Show()
        End If
    End Sub

    Private Sub AxWindowsMediaPlayer1_Enter(sender As System.Object, e As System.EventArgs)

    End Sub
End Class