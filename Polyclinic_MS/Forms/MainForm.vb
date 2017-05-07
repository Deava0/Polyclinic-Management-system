Imports MySql.Data.MySqlClient
Public Class MainForm
    Dim MySqlConn As MySqlConnection

    Sub DeleteDoctFromQ()
        MySqlConn = New MySqlConnection
        MySqlConn.ConnectionString = GetConnString()

        If M_job = "Doctor" Or M_job = "Admin" Then
            MySqlConn.Open()
            Dim Qu As String = "DELETE FROM mcms.doct_work_q WHERE doct_id='" & M_id & "' "
            Dim cmd = New MySqlCommand(Qu, MySqlConn)
            Dim rdr As MySqlDataReader = cmd.ExecuteReader
            MySqlConn.Close()
        End If

    End Sub
    Sub SendToLOGS()
        Try
            MySqlConn = New MySqlConnection
            MySqlConn.ConnectionString = GetConnString()

            MySqlConn.Open()
            Dim Qu As String = "INSERT INTO mcms.logs (who, when_tm, what, where_nm, where_ip) 
                                                    VALUES ('" & M_id & "', now(), 'LOG OUT', '" & M_pc_nm & "', '" & M_pc_ip & "');"
            Dim cmd = New MySqlCommand(Qu, MySqlConn)
            Dim rdr As MySqlDataReader = cmd.ExecuteReader
            MySqlConn.Close()

            MySqlConn = New MySqlConnection
            MySqlConn.ConnectionString = GetConnString()

            MySqlConn.Open()
            Dim Qu2 As String = "UPDATE mcms.staff SET login_state='Offline' WHERE  id = '" & M_id & "' ;"
            Dim cmd2 = New MySqlCommand(Qu2, MySqlConn)
            Dim rdr2 As MySqlDataReader = cmd2.ExecuteReader
            MySqlConn.Close()
            DeleteDoctFromQ()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)

        Finally
            MySqlConn.Dispose()
        End Try
    End Sub

    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = "Welcome " & M_prefix & ". " & M_first_nm & "(" & M_job & ")@" & M_pc_nm & "_" & M_pc_ip & ""


        Dim DoctNodes As TreeNode = (nav_tree.Nodes.Item(0))
        Dim PharmNodes As TreeNode = (nav_tree.Nodes.Item(1))
        Dim RecNodes As TreeNode = (nav_tree.Nodes.Item(2))
        Dim NurseNodes As TreeNode = (nav_tree.Nodes.Item(3))
        Dim AccNodes As TreeNode = (nav_tree.Nodes.Item(4))
        Dim MngrNodes As TreeNode = (nav_tree.Nodes.Item(5))
        Dim AdmnNodes As TreeNode = (nav_tree.Nodes.Item(6))

        If M_job = "Doctor" Then
            nav_tree.Nodes.Remove(PharmNodes)
            nav_tree.Nodes.Remove(RecNodes)
            nav_tree.Nodes.Remove(NurseNodes)
            nav_tree.Nodes.Remove(AccNodes)
            nav_tree.Nodes.Remove(MngrNodes)
            nav_tree.Nodes.Remove(AdmnNodes)
        ElseIf M_job = "Pharmacist" Then
            nav_tree.Nodes.Remove(DoctNodes)
            nav_tree.Nodes.Remove(RecNodes)
            nav_tree.Nodes.Remove(NurseNodes)
            nav_tree.Nodes.Remove(AccNodes)
            nav_tree.Nodes.Remove(MngrNodes)
            nav_tree.Nodes.Remove(AdmnNodes)
        ElseIf M_job = "Receptionist" Then
            nav_tree.Nodes.Remove(DoctNodes)
            nav_tree.Nodes.Remove(PharmNodes)
            nav_tree.Nodes.Remove(NurseNodes)
            nav_tree.Nodes.Remove(AccNodes)
            nav_tree.Nodes.Remove(MngrNodes)
            nav_tree.Nodes.Remove(AdmnNodes)
        ElseIf M_job = "Nurse" Then
            nav_tree.Nodes.Remove(DoctNodes)
            nav_tree.Nodes.Remove(PharmNodes)
            nav_tree.Nodes.Remove(RecNodes)
            nav_tree.Nodes.Remove(AccNodes)
            nav_tree.Nodes.Remove(MngrNodes)
            nav_tree.Nodes.Remove(AdmnNodes)
        ElseIf M_job = "Accountant" Then
            nav_tree.Nodes.Remove(DoctNodes)
            nav_tree.Nodes.Remove(PharmNodes)
            nav_tree.Nodes.Remove(RecNodes)
            nav_tree.Nodes.Remove(NurseNodes)
            nav_tree.Nodes.Remove(MngrNodes)
            nav_tree.Nodes.Remove(AdmnNodes)
        ElseIf M_job = "Manager" Then
            nav_tree.Nodes.Remove(DoctNodes)
            nav_tree.Nodes.Remove(PharmNodes)
            nav_tree.Nodes.Remove(RecNodes)
            nav_tree.Nodes.Remove(NurseNodes)
            nav_tree.Nodes.Remove(AccNodes)
            nav_tree.Nodes.Remove(AdmnNodes)
        ElseIf M_job = "Admin" Then
            'show all, add something later
        End If

        MySqlConn = New MySqlConnection
        MySqlConn.ConnectionString = GetConnString()

        StatusStrip_LF.ShowItemToolTips = True
        MySqlConn = New MySqlConnection
        MySqlConn.ConnectionString = GetConnString()
        Try
            MySqlConn.Open()
            DB_Conn_SSLbl.ForeColor = Color.Green
            DB_Conn_SSLbl.Text = "Connection Status : Connected"
            DB_Conn_SSLbl.ToolTipText = "No Connection Error Detected"
            MySqlConn.Close()
        Catch ex As MySqlException
            DB_Conn_SSLbl.ForeColor = Color.Red
            DB_Conn_SSLbl.Text = "Connection Status : Disconnected"
            DB_Conn_SSLbl.ToolTipText = ex.Message
        End Try

    End Sub

    Private Sub MainForm_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Dim rslt As Integer = MessageBox.Show("Are you sure you want to quit ?", "Conform", MessageBoxButtons.YesNo)
        If rslt = DialogResult.Yes Then
            SendToLOGS()
            Application.Exit()
            DeleteDoctFromQ()
        Else
        End If
    End Sub

    Private Sub nav_tree_DoubleClick(sender As Object, e As EventArgs) Handles nav_tree.DoubleClick
        If nav_tree.SelectedNode.Name = "diag" Then
            Dim diag = New DiagnosisForm()
            diag.Show()
        ElseIf nav_tree.SelectedNode.Name = "pres" Then
            Dim pres = New prs_handling()
            pres.Show()
        ElseIf nav_tree.SelectedNode.Name = "phrma" Then
            Dim phrma = New pharm()
            phrma.Show()
        ElseIf nav_tree.SelectedNode.Name = "rec_frm" Then
            Dim rec_frm = New Reception()
            rec_frm.Show()
        ElseIf nav_tree.SelectedNode.Name = "pt_modi" Then
            Dim pt_modi = New pt_rcrd_modi()
            pt_modi.Show()
        ElseIf nav_tree.SelectedNode.Name = "pt_reg" Then
            Dim pt_reg = New pt_reg()
            pt_reg.Show()
        ElseIf nav_tree.SelectedNode.Name = "queue" Then
            Dim queue = New pt_q()
            queue.Show()
        ElseIf nav_tree.SelectedNode.Name = "fina" Then
            Dim fina = New Finance()
            fina.Show()
        ElseIf nav_tree.SelectedNode.Name = "stf_modi" Then
            Dim stf_modi = New stf_rcrd_modi()
            stf_modi.Show()
        ElseIf nav_tree.SelectedNode.Name = "vst_modi" Then
            Dim vst_modi = New pt_vst_rcrd_mod()
            vst_modi.Show()
        ElseIf nav_tree.SelectedNode.Name = "stf_reg" Then
            Dim stf_reg = New stf_reg()
            stf_reg.Show()
        ElseIf nav_tree.SelectedNode.Name = "logs" Then
            ' Dim logs  = logs()
            'logs.Show()
            MessageBox.Show("Logs are not available at the moment, please wait for the next version of the management system", "Unavailable")
        End If
    End Sub

    Private Sub LogOutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LogOutToolStripMenuItem.Click
        SendToLOGS()
        Me.Hide()
        Dim loginFrm = New LoginForm()
        loginFrm.Show()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        SendToLOGS()
        Application.Exit()
    End Sub

    Private Sub AboutToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem1.Click
        Dim abtFrm As New AboutBox()
        abtFrm.Show()
    End Sub

    Private Sub ContactUsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ContactUsToolStripMenuItem.Click
        MessageBox.Show("Dev Name : Asad Al-Badi
Dev Email : Astral.Hive@gmail.com", "Contact Us", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub
End Class