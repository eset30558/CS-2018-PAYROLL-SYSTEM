Imports System.Data.OleDb
Imports System.Data
Public Class PayrollCompute


    Dim rdr As OleDbDataReader = Nothing
    Dim dtable As DataTable
    Dim con As OleDbConnection = Nothing
    Dim adp As OleDbDataAdapter
    Dim ds As DataSet
    Dim cmd As OleDbCommand = Nothing
    Dim dt As New DataTable
    Dim cs As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + "D:\Payroll Finals\Payroll Garena.accdb;"
    Dim D As String


    Private Sub PayrollCompute_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        fillcombo()
        SSS.Text = 0
        Phil_Health.Text = 0
        Pag_Ibig.Text = 0
        Tax.Text = 0
        

    End Sub
    Sub fillcombo()
        Try
            Dim CN As New OleDbConnection(cs)

            CN.Open()
            adp = New OleDbDataAdapter()
            adp.SelectCommand = New OleDbCommand("SELECT distinct  (ID) From [Employee]", CN)
            ds = New DataSet("ds")

            adp.Fill(ds)
            dtable = ds.Tables(0)
            ID.Items.Clear()

            For Each drow As DataRow In dtable.Rows
                ID.Items.Add(drow(0).ToString())
            Next


        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles ID.SelectedIndexChanged
        Try

            con = New OleDbConnection(cs)

            con.Open()


            Dim ct As String = "select * from [Employee] where ID=@find"


            cmd = New OleDbCommand(ct)
            cmd.Connection = con
            cmd.Parameters.Add(New OleDbParameter("@find", System.Data.OleDb.OleDbType.VarChar, 30, "ID"))
            cmd.Parameters("@find").Value = Trim(ID.Text)
            rdr = cmd.ExecuteReader()


            If rdr.Read Then
                F_name.Text = Trim(rdr.GetString(1))
                L_name.Text = Trim(rdr.GetString(3))
            End If


            If con.State = ConnectionState.Open Then
                con.Close()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub
    Private Sub Button6_Click(sender As System.Object, e As System.EventArgs) Handles Button6.Click
        Me.Hide()
        FrmMain.Show()

        Enter_Rate.Clear()
        Work_Hours.Clear()
        Work_Days.Clear()
        OT_Rate.Clear()
        OT_Hours.Clear()
        SSS.Clear()
        Phil_Health.Clear()
        Pag_Ibig.Clear()
        Tax.Clear()
    End Sub
    Private Sub PayrollCompute_FormClosing(sender As System.Object, e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        Me.Hide()
        FrmMain.Show()
    End Sub

    Private Sub Timer1_Tick(sender As System.Object, e As System.EventArgs) Handles Timer1.Tick
        ToolStripStatusLabel4.Text = Date.Now.ToString("dd/mm/yyyy [hh:mm:ss]")
    End Sub
    Private Sub Button8_Click(sender As System.Object, e As System.EventArgs) Handles Button8.Click
        Me.Hide()
        Salaries.Show()

        Enter_Rate.Clear()
        Work_Hours.Clear()
        Work_Days.Clear()
        OT_Rate.Clear()
        OT_Hours.Clear()
        SSS.Clear()
        Phil_Health.Clear()
        Pag_Ibig.Clear()
        Tax.Clear()
    End Sub
    Private Sub Button7_Click(sender As System.Object, e As System.EventArgs) Handles Button7.Click
        If Len(Trim(Enter_Rate.Text)) = 0 Then
            MsgBox("Please input Monthly Rate!", MsgBoxStyle.OkOnly + MsgBoxStyle.Exclamation, "Admin")
            Enter_Rate.Focus()
            Exit Sub
        End If
        If Len(Trim(Work_Hours.Text)) = 0 Then
            MsgBox("Please input Work(Hrs)!", MsgBoxStyle.OkOnly + MsgBoxStyle.Exclamation, "Admin")
            Work_Hours.Focus()
            Exit Sub
        End If
        If Len(Trim(Work_Days.Text)) = 0 Then
            MsgBox("Please input Work(Days)!", MsgBoxStyle.OkOnly + MsgBoxStyle.Exclamation, "Admin")
            Work_Days.Focus()
            Exit Sub
        End If
        If Len(Trim(OT_Rate.Text)) = 0 Then
            MsgBox("Please input OT Rate!", MsgBoxStyle.OkOnly + MsgBoxStyle.Exclamation, "Admin")
            OT_Rate.Focus()
            Exit Sub
        End If
        If Len(Trim(OT_Hours.Text)) = 0 Then
            MsgBox("Please input OT Hours!", MsgBoxStyle.OkOnly + MsgBoxStyle.Exclamation, "Admin")
            OT_Hours.Focus()
            Exit Sub
        End If
        '---------------------------------------------------------------------------------------------
        If RadioButton1.Checked Then

            Dim Regular_Gross_Salary As Integer
            Dim Regular_SSS As Integer  '(11%)
            Dim Regular_Phil_Health As Integer '(2.75%)
            Dim Regular_Pag_Ibig As Integer      '(2%)
            Dim Regular_Tax As Integer          '(1.5%)
            Dim Regular_Deduction As Integer
            Dim Regular_Net_Salary As Integer
            D = "REGULAR"

            Regular_Gross_Salary = ((Enter_Rate.Text * Work_Days.Text) + (OT_Hours.Text * OT_Rate.Text))
            Gross_Salary.Text = Regular_Gross_Salary

            '------------------------------------Regular_SSS------------------
            SSS.Text = Regular_Gross_Salary * 0.11
            Regular_SSS = SSS.Text
            '------------------------------------Regular_Phil_Health----------
            Phil_Health.Text = Regular_Gross_Salary * 0.0275
            Regular_Phil_Health = Phil_Health.Text
            '------------------------------------Regular_Pag_Ibig-------------
            Pag_Ibig.Text = Regular_Gross_Salary * 0.02
            Regular_Pag_Ibig = Pag_Ibig.Text
            '------------------------------------Regular_Tax------------------
            Tax.Text = Regular_Gross_Salary * 0.015
            Regular_Tax = Tax.Text

            '----------------------------------
            Regular_Deduction = (Regular_SSS + Regular_Phil_Health + Regular_Pag_Ibig + Regular_Tax)
            Regular_Net_Salary = (Regular_Gross_Salary - Regular_Deduction)
            Net_Salary.Text = Regular_Net_Salary

        ElseIf RadioButton2.Checked Then

            Dim Casual_Gross_Salary As Integer
            Dim Casual_SSS As Integer '(0.11(11%))
            Dim Casual_Phil_Health As Integer '( 0.0275(2.75))
            Dim Casual_Pag_Ibig As Integer '(0.02(2%))
            Dim Casual_Tax As Integer '(0.015(1.5%))
            Dim Casual_Deduction As Integer
            Dim Casual_Net_Salary As Integer
            D = "CASUAL"


            Casual_Gross_Salary = ((Enter_Rate.Text * Work_Hours.Text) + (OT_Hours.Text * OT_Rate.Text))
            Gross_Salary.Text = Casual_Gross_Salary

            '------------------------------------Casual_SSS-----------------------
            SSS.Text = Casual_Gross_Salary * 0.11
            Casual_SSS = SSS.Text
            '------------------------------------Casual_Phil_Health---------------
            Phil_Health.Text = Casual_Gross_Salary * 0.0275
            Casual_Phil_Health = Phil_Health.Text
            '------------------------------------Casual_Pag_Ibig------------------
            Pag_Ibig.Text = Casual_Gross_Salary * 0.02
            Casual_Pag_Ibig = Pag_Ibig.Text
            '------------------------------------Casual_Tax-----------------------
            Tax.Text = Casual_Gross_Salary * 0.015
            Casual_Tax = Tax.Text


            Casual_Deduction = (Casual_SSS + Casual_Phil_Health + Casual_Pag_Ibig + Casual_Tax)
            Casual_Net_Salary = (Casual_Gross_Salary - Casual_Deduction)
            Net_Salary.Text = Casual_Net_Salary

        End If
    End Sub
    Private Sub Button4_Click(sender As System.Object, e As System.EventArgs) Handles Button4.Click
        Dim connect As OleDbConnection = Nothing
        Dim command As OleDbCommand = Nothing

        Dim str As String = "Insert into [Payroll]([ID],[First_Name],[Last_Name],[Regular/Casual],[Enter_Rate],[Work_Hours],[Work_Days],[OT_Rate],[OT_Hours],[Gross_Salary],[SSS],[Phil_Health],[Pag-Ibig],[Tax],[Net_Salary]) Values (@d2,@d3,@d4,@d6,@d7,@d8,@9d,@10d,@11d,@12d,@13d,@14d,@15d,@16d,@17d)"
        Dim conn As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + "D:\Payroll Finals\Payroll Garena.accdb;"
        connect = New OleDbConnection(conn)
        connect.Open()

        command = New OleDbCommand(str)
        command.Connection = connect

        command.Parameters.Add(New OleDbParameter("@d2", System.Data.OleDb.OleDbType.VarChar, 30, "ID"))
        command.Parameters.Add(New OleDbParameter("@d3", System.Data.OleDb.OleDbType.VarChar, 30, "First_Name"))
        command.Parameters.Add(New OleDbParameter("@d4", System.Data.OleDb.OleDbType.VarChar, 30, "Last_Name"))
        command.Parameters.Add(New OleDbParameter("@d6", System.Data.OleDb.OleDbType.VarChar, 30, "Regular/Casual"))
        command.Parameters.Add(New OleDbParameter("@d7", System.Data.OleDb.OleDbType.VarChar, 30, "Enter_Rate"))
        command.Parameters.Add(New OleDbParameter("@d8", System.Data.OleDb.OleDbType.VarChar, 30, "Work_Hours"))
        command.Parameters.Add(New OleDbParameter("@d9", System.Data.OleDb.OleDbType.VarChar, 30, "Work_Days"))
        command.Parameters.Add(New OleDbParameter("@d10", System.Data.OleDb.OleDbType.VarChar, 30, "OT_Rate"))
        command.Parameters.Add(New OleDbParameter("@d11", System.Data.OleDb.OleDbType.VarChar, 30, "OT_Hours"))
        command.Parameters.Add(New OleDbParameter("@d12", System.Data.OleDb.OleDbType.VarChar, 30, "Gross_Salary"))
        command.Parameters.Add(New OleDbParameter("@d13", System.Data.OleDb.OleDbType.VarChar, 30, "SSS"))
        command.Parameters.Add(New OleDbParameter("@d14", System.Data.OleDb.OleDbType.VarChar, 30, "Phil_Health"))
        command.Parameters.Add(New OleDbParameter("@d15", System.Data.OleDb.OleDbType.VarChar, 30, "Pag-Ibig"))
        command.Parameters.Add(New OleDbParameter("@d16", System.Data.OleDb.OleDbType.VarChar, 30, "Tax"))
        command.Parameters.Add(New OleDbParameter("@d17", System.Data.OleDb.OleDbType.VarChar, 30, "Net_Salary"))

        command.Parameters("@d2").Value = Trim(ID.Text)
        command.Parameters("@d3").Value = Trim(F_name.Text)
        command.Parameters("@d4").Value = Trim(L_name.Text)
        command.Parameters("@d6").Value = Trim(D)
        command.Parameters("@d7").Value = Trim(Enter_Rate.Text)
        command.Parameters("@d8").Value = Trim(Work_Hours.Text)
        command.Parameters("@d9").Value = Trim(Work_Days.Text)
        command.Parameters("@d10").Value = Trim(OT_Rate.Text)
        command.Parameters("@d11").Value = Trim(OT_Hours.Text)
        command.Parameters("@d12").Value = Trim(Gross_Salary.Text)
        command.Parameters("@d13").Value = Trim(SSS.Text)
        command.Parameters("@d14").Value = Trim(Phil_Health.Text)
        command.Parameters("@d15").Value = Trim(Pag_Ibig.Text)
        command.Parameters("@d16").Value = Trim(Tax.Text)
        command.Parameters("@d17").Value = Trim(Net_Salary.Text)




        Try
            MsgBox("Successfully Registered!", MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Admin")
            command.ExecuteReader()
            F_name.Text = ""
            L_name.Text = ""
            Enter_Rate.Text = ""
            Work_Days.Text = 0
            Work_Hours.Text = 0
            OT_Hours.Text = 0
            OT_Rate.Text = 0
            SSS.Text = 0
            Phil_Health.Text = 0
            Pag_Ibig.Text = 0
            Tax.Text = 0

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub Button5_Click(sender As System.Object, e As System.EventArgs) Handles Button5.Click
        F_name.Text = ""
        L_name.Text = ""
        Enter_Rate.Text = ""
        Work_Days.Text = 0
        Work_Hours.Text = 0
        OT_Hours.Text = 0
        OT_Rate.Text = 0
        SSS.Text = 0
        Phil_Health.Text = 0
        Pag_Ibig.Text = 0
        Tax.Text = 0


    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles RadioButton1.CheckedChanged
        Work_Hours.Enabled = False
        Work_Days.Enabled = True
        SSS.Enabled = False
        Phil_Health.Enabled = False
        Pag_Ibig.Enabled = False
        Tax.Enabled = False
    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles RadioButton2.CheckedChanged
        Work_Days.Enabled = False
        Work_Hours.Enabled = True
        SSS.Enabled = False
        Phil_Health.Enabled = False
        Pag_Ibig.Enabled = False
        Tax.Enabled = False
    End Sub


End Class

'REMINDER: (TAX% Need to Compute!)
' if Gross Salary(Monthly) = 15,000 php Then Tax = 0 php 
' if Gross Salary(Monthly) = 20,000 php Then Tax = 0 php 
' if Gross Salary(Monthly) = 25,000 php Then Tax = 634.57 php 
' if Gross Salary(Monthly) = 30,000 php Then Tax = 1,624.57 php 
' if Gross Salary(Monthly) = 35,000 php Then Tax = 2,656.72 php 
' if Gross Salary(Monthly) = 35,000 php above Then Tax = 3,500.50 php 

'Tax(Textbox) Kailangang naka-Disable para hindi malagyan ng HR, naka-automatic ang Tax kapag pinindot ang "Compute Button".


