Imports MySql.Data.MySqlClient
Public Class pt_vst_rcrd_mod
    Dim mysqlconn As MySqlConnection
    Dim DB_tablePT As New DataTable

    Dim fltr As String

    Public Sub ResetGridPT()
        mysqlconn = New MySqlConnection
        mysqlconn.ConnectionString = GetConnString()

        DB_tablePT.Clear()

        Dim MySqlDtAd As New MySqlDataAdapter
        Dim BinSouc As New BindingSource

        Try
            mysqlconn.Open()
            Dim Qu As String = "SELECT a.id AS ActvVstID 
                                     , a.pt_id AS PtID, CONCAT(patient.first_name,' ', patient.second_name,' ', patient.third_name,' ', patient.fourth_name,' ', patient.tribe_name) AS PtName
                                     , a.rec_id AS RecID, CONCAT(s.first_name,' ', s.second_name,' ', s.third_name,' ', s.fourth_name,' ', s.tribe_name) AS RecName
                                     , a.nurse_id AS NurseID, CONCAT(s2.first_name,' ', s2.second_name,' ', s2.third_name,' ', s2.fourth_name,' ', s2.tribe_name) AS NurseName
                                     , a.doct_id AS DoctID, CONCAT(s3.first_name,' ', s3.second_name,' ', s3.third_name,' ', s3.fourth_name,' ', s3.tribe_name) AS DoctName
                                     , a.phrm_id AS PharmID, CONCAT(s4.first_name,' ', s4.second_name,' ', s4.third_name,' ', s4.fourth_name,' ', s4.tribe_name) AS PharmName
                                     , a.diag AS Diagnosis, a.pres AS Prescription, a.remedy_state AS RemedyStatus, a.height, a.weight
                                     , a.blood_pres AS BloodPressure, a.from_tm AS VstStartTime, a.diag_end_tm AS DiagEndTime, a.to_tm AS VstEndTime
                                    FROM mcms.patient, mcms.active_visit a left join mcms.staff s
                                    on a.rec_id = s.id left join mcms.staff s2
                                    ON  a.nurse_id = s2.id  left join mcms.staff s3
                                    on a.doct_id = s3.id left join mcms.staff s4
                                    on a.phrm_id = s4.id  
                                     WHERE a.pt_id = patient.id "
            Dim cmd As New MySqlCommand(Qu, mysqlconn)
            MySqlDtAd.SelectCommand = cmd
            MySqlDtAd.Fill(DB_tablePT)
            BinSouc.DataSource = DB_tablePT
            pt_grid.DataSource = BinSouc
            MySqlDtAd.Update(DB_tablePT)
            mysqlconn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            mysqlconn.Dispose()
        End Try
    End Sub

    Private Sub pt_dia_mod_srch_btn_Click(sender As Object, e As EventArgs) Handles pt_dia_mod_srch_btn.Click
        mysqlconn = New MySqlConnection
        mysqlconn.ConnectionString = GetConnString()

        If doct_id_chkbx.Checked = False AndAlso pt_id_chkbx.Checked = False Then

            DB_tablePT.Clear()

            Dim MySqlDtAd As New MySqlDataAdapter
            Dim BinSouc As New BindingSource

            Try
                mysqlconn.Open()
                Dim Qu As String = "SELECT a.id AS ActvVstID 
                                     , a.pt_id AS PtID, CONCAT(patient.first_name,' ', patient.second_name,' ', patient.third_name,' ', patient.fourth_name,' ', patient.tribe_name) AS PtName
                                     , a.rec_id AS RecID, CONCAT(s.first_name,' ', s.second_name,' ', s.third_name,' ', s.fourth_name,' ', s.tribe_name) AS RecName
                                     , a.nurse_id AS NurseID, CONCAT(s2.first_name,' ', s2.second_name,' ', s2.third_name,' ', s2.fourth_name,' ', s2.tribe_name) AS NurseName
                                     , a.doct_id AS DoctID, CONCAT(s3.first_name,' ', s3.second_name,' ', s3.third_name,' ', s3.fourth_name,' ', s3.tribe_name) AS DoctName
                                     , a.phrm_id AS PharmID, CONCAT(s4.first_name,' ', s4.second_name,' ', s4.third_name,' ', s4.fourth_name,' ', s4.tribe_name) AS PharmName
                                     , a.diag AS Diagnosis, a.pres AS Prescription, a.remedy_state AS RemedyStatus, a.height, a.weight
                                     , a.blood_pres AS BloodPressure, a.from_tm AS VstStartTime, a.diag_end_tm AS DiagEndTime, a.to_tm AS VstEndTime
                                    FROM mcms.patient, mcms.active_visit a left join mcms.staff s
                                    on a.rec_id = s.id left join mcms.staff s2
                                    ON  a.nurse_id = s2.id  left join mcms.staff s3
                                    on a.doct_id = s3.id left join mcms.staff s4
                                    on a.phrm_id = s4.id  
                                     WHERE a.pt_id = patient.id 
                                 AND a.from_tm BETWEEN '" & pt_dia_mod_frm_pkr.Text & "' AND '" & pt_dia_mod_to_pkr.Text & "' "
                Dim cmd As New MySqlCommand(Qu, mysqlconn)
                MySqlDtAd.SelectCommand = cmd
                MySqlDtAd.Fill(DB_tablePT)
                BinSouc.DataSource = DB_tablePT
                pt_grid.DataSource = BinSouc
                MySqlDtAd.Update(DB_tablePT)
                mysqlconn.Close()
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            Finally
                mysqlconn.Dispose()
            End Try
        ElseIf doct_id_chkbx.Checked = True AndAlso pt_id_chkbx.Checked = True Then


            DB_tablePT.Clear()

            Dim MySqlDtAd As New MySqlDataAdapter
            Dim BinSouc As New BindingSource

            Try
                mysqlconn.Open()
                Dim Qu As String = "SELECT a.id AS ActvVstID 
                                     , a.pt_id AS PtID, CONCAT(patient.first_name,' ', patient.second_name,' ', patient.third_name,' ', patient.fourth_name,' ', patient.tribe_name) AS PtName
                                     , a.rec_id AS RecID, CONCAT(s.first_name,' ', s.second_name,' ', s.third_name,' ', s.fourth_name,' ', s.tribe_name) AS RecName
                                     , a.nurse_id AS NurseID, CONCAT(s2.first_name,' ', s2.second_name,' ', s2.third_name,' ', s2.fourth_name,' ', s2.tribe_name) AS NurseName
                                     , a.doct_id AS DoctID, CONCAT(s3.first_name,' ', s3.second_name,' ', s3.third_name,' ', s3.fourth_name,' ', s3.tribe_name) AS DoctName
                                     , a.phrm_id AS PharmID, CONCAT(s4.first_name,' ', s4.second_name,' ', s4.third_name,' ', s4.fourth_name,' ', s4.tribe_name) AS PharmName
                                     , a.diag AS Diagnosis, a.pres AS Prescription, a.remedy_state AS RemedyStatus, a.height, a.weight
                                     , a.blood_pres AS BloodPressure, a.from_tm AS VstStartTime, a.diag_end_tm AS DiagEndTime, a.to_tm AS VstEndTime
                                    FROM mcms.patient, mcms.active_visit a left join mcms.staff s
                                    on a.rec_id = s.id left join mcms.staff s2
                                    ON  a.nurse_id = s2.id  left join mcms.staff s3
                                    on a.doct_id = s3.id left join mcms.staff s4
                                    on a.phrm_id = s4.id  
                                     WHERE a.pt_id = patient.id 
                                 AND a.from_tm BETWEEN '" & pt_dia_mod_frm_pkr.Text & "' AND '" & pt_dia_mod_to_pkr.Text & "' 
                                 AND a.pt_id = '" & fltr_pt_id_txtbx.Text & "' 
                                 AND a.doct_id = '" & fltr_doct_id_txtbx.Text & "' "
                Dim cmd As New MySqlCommand(Qu, mysqlconn)
                MySqlDtAd.SelectCommand = cmd
                MySqlDtAd.Fill(DB_tablePT)
                BinSouc.DataSource = DB_tablePT
                pt_grid.DataSource = BinSouc
                MySqlDtAd.Update(DB_tablePT)
                mysqlconn.Close()
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            Finally
                mysqlconn.Dispose()
            End Try
        ElseIf doct_id_chkbx.Checked = True Then


            DB_tablePT.Clear()

            Dim MySqlDtAd As New MySqlDataAdapter
            Dim BinSouc As New BindingSource

            Try
                mysqlconn.Open()
                Dim Qu As String = "SELECT a.id AS ActvVstID 
                                     , a.pt_id AS PtID, CONCAT(patient.first_name,' ', patient.second_name,' ', patient.third_name,' ', patient.fourth_name,' ', patient.tribe_name) AS PtName
                                     , a.rec_id AS RecID, CONCAT(s.first_name,' ', s.second_name,' ', s.third_name,' ', s.fourth_name,' ', s.tribe_name) AS RecName
                                     , a.nurse_id AS NurseID, CONCAT(s2.first_name,' ', s2.second_name,' ', s2.third_name,' ', s2.fourth_name,' ', s2.tribe_name) AS NurseName
                                     , a.doct_id AS DoctID, CONCAT(s3.first_name,' ', s3.second_name,' ', s3.third_name,' ', s3.fourth_name,' ', s3.tribe_name) AS DoctName
                                     , a.phrm_id AS PharmID, CONCAT(s4.first_name,' ', s4.second_name,' ', s4.third_name,' ', s4.fourth_name,' ', s4.tribe_name) AS PharmName
                                     , a.diag AS Diagnosis, a.pres AS Prescription, a.remedy_state AS RemedyStatus, a.height, a.weight
                                     , a.blood_pres AS BloodPressure, a.from_tm AS VstStartTime, a.diag_end_tm AS DiagEndTime, a.to_tm AS VstEndTime
                                    FROM mcms.patient, mcms.active_visit a left join mcms.staff s
                                    on a.rec_id = s.id left join mcms.staff s2
                                    ON  a.nurse_id = s2.id  left join mcms.staff s3
                                    on a.doct_id = s3.id left join mcms.staff s4
                                    on a.phrm_id = s4.id  
                                     WHERE a.pt_id = patient.id 
                                 AND a.from_tm BETWEEN '" & pt_dia_mod_frm_pkr.Text & "' AND '" & pt_dia_mod_to_pkr.Text & "' 
                                 AND a.doct_id = '" & fltr_doct_id_txtbx.Text & "' "
                Dim cmd As New MySqlCommand(Qu, mysqlconn)
                MySqlDtAd.SelectCommand = cmd
                MySqlDtAd.Fill(DB_tablePT)
                BinSouc.DataSource = DB_tablePT
                pt_grid.DataSource = BinSouc
                MySqlDtAd.Update(DB_tablePT)
                mysqlconn.Close()
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            Finally
                mysqlconn.Dispose()
            End Try
        ElseIf pt_id_chkbx.Checked = True Then


            DB_tablePT.Clear()

            Dim MySqlDtAd As New MySqlDataAdapter
            Dim BinSouc As New BindingSource

            Try
                mysqlconn.Open()
                Dim Qu As String = "SELECT a.id AS ActvVstID 
                                     , a.pt_id AS PtID, CONCAT(patient.first_name,' ', patient.second_name,' ', patient.third_name,' ', patient.fourth_name,' ', patient.tribe_name) AS PtName
                                     , a.rec_id AS RecID, CONCAT(s.first_name,' ', s.second_name,' ', s.third_name,' ', s.fourth_name,' ', s.tribe_name) AS RecName
                                     , a.nurse_id AS NurseID, CONCAT(s2.first_name,' ', s2.second_name,' ', s2.third_name,' ', s2.fourth_name,' ', s2.tribe_name) AS NurseName
                                     , a.doct_id AS DoctID, CONCAT(s3.first_name,' ', s3.second_name,' ', s3.third_name,' ', s3.fourth_name,' ', s3.tribe_name) AS DoctName
                                     , a.phrm_id AS PharmID, CONCAT(s4.first_name,' ', s4.second_name,' ', s4.third_name,' ', s4.fourth_name,' ', s4.tribe_name) AS PharmName
                                     , a.diag AS Diagnosis, a.pres AS Prescription, a.remedy_state AS RemedyStatus, a.height, a.weight
                                     , a.blood_pres AS BloodPressure, a.from_tm AS VstStartTime, a.diag_end_tm AS DiagEndTime, a.to_tm AS VstEndTime
                                    FROM mcms.patient, mcms.active_visit a left join mcms.staff s
                                    on a.rec_id = s.id left join mcms.staff s2
                                    ON  a.nurse_id = s2.id  left join mcms.staff s3
                                    on a.doct_id = s3.id left join mcms.staff s4
                                    on a.phrm_id = s4.id  
                                     WHERE a.pt_id = patient.id 
                                 AND a.from_tm BETWEEN '" & pt_dia_mod_frm_pkr.Text & "' AND '" & pt_dia_mod_to_pkr.Text & "' 
                                 AND a.pt_id = '" & fltr_pt_id_txtbx.Text & "' "
                Dim cmd As New MySqlCommand(Qu, mysqlconn)
                MySqlDtAd.SelectCommand = cmd
                MySqlDtAd.Fill(DB_tablePT)
                BinSouc.DataSource = DB_tablePT
                pt_grid.DataSource = BinSouc
                MySqlDtAd.Update(DB_tablePT)
                mysqlconn.Close()
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            Finally
                mysqlconn.Dispose()
            End Try
        End If

    End Sub

    Private Sub pt_vst_rcrd_mod_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        fltr_pt_id_txtbx.Enabled = False
        fltr_doct_id_txtbx.Enabled = False
    End Sub

    Private Sub pt_id_chkbx_CheckedChanged(sender As Object, e As EventArgs) Handles pt_id_chkbx.CheckedChanged
        If pt_id_chkbx.Checked = True Then
            fltr_pt_id_txtbx.Enabled = True
        Else
            fltr_pt_id_txtbx.Enabled = False
        End If
    End Sub

    Private Sub doct_id_chkbx_CheckedChanged(sender As Object, e As EventArgs) Handles doct_id_chkbx.CheckedChanged
        If doct_id_chkbx.Checked = True Then
            fltr_doct_id_txtbx.Enabled = True
        Else
            fltr_doct_id_txtbx.Enabled = False
        End If
    End Sub

    Private Sub pt_dia_mod_all_btn_Click(sender As Object, e As EventArgs) Handles pt_dia_mod_all_btn.Click
        ResetGridPT()
    End Sub

    Private Sub pt_dia_mod_rst_today_btn_Click(sender As Object, e As EventArgs) Handles pt_dia_mod_rst_today_btn.Click
        Dim from_am As String
        from_am = (Date.Today + " 00:00:00")
        pt_dia_mod_frm_pkr.Text = from_am

        Dim from_pm As String
        from_pm = (Date.Today + " 23:59:59")
        pt_dia_mod_to_pkr.Text = from_pm
    End Sub

    Private Sub updt_btn_Click(sender As Object, e As EventArgs) Handles updt_btn.Click
        mysqlconn = New MySqlConnection
        mysqlconn.ConnectionString = GetConnString()

        Dim rslt As Integer = MessageBox.Show("Are you sure that you want to modify VST" & vst_id_txtbx.Text & " of " & pt_nm_txtbx.Text & " with PtID : " & pt_id_txtbx.Text & " ?", "Confirmation!", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)
        If rslt = DialogResult.Yes Then
            'Update
            Try
                mysqlconn.Open()
                Dim Qu As String = "UPDATE mcms.active_visit SET diag='" & pt_dia_rchtxtbx.Text & "', pres='" & pres_rchtxtbx.Text & "'
                                                    WHERE id='" & vst_id_txtbx.Text & "'"
                Dim cmd As New MySqlCommand(Qu, mysqlconn)
                Dim rdr As MySqlDataReader = cmd.ExecuteReader
                ResetGridPT()
                mysqlconn.Close()
                'SendToLogs
                mysqlconn.Open()
                Dim Qu2 As String = "INSERT INTO mcms.logs (who, when_tm, what, where_nm, where_ip) 
                                                    VALUES ('" & M_id & "', now(), 'VST" & vst_id_txtbx.Text & " RCRD MODI ', '" & M_pc_nm & "', '" & M_pc_ip & "');"
                Dim cmd2 = New MySqlCommand(Qu2, mysqlconn)
                Dim rdr2 As MySqlDataReader = cmd2.ExecuteReader
                mysqlconn.Close()

                Dim ctrl As Control
                For Each ctrl In pt_vst_rcrd_mod_grbbx.Controls
                    If TypeOf ctrl Is TextBox Or TypeOf ctrl Is RichTextBox Then
                        ctrl.Text = Nothing
                    End If
                Next
                Dim ctrl2 As Control
                For Each ctrl2 In pt_dia_mod_srch_grbbx.Controls
                    If TypeOf ctrl2 Is TextBox Then
                        ctrl2.Text = Nothing
                    End If
                Next
                pt_dia_mod_frm_pkr.Text = Today.Date
                pt_dia_mod_to_pkr.Text = Today.Date

            Catch ex As MySqlException
                MessageBox.Show(ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub

    Private Sub drp_btn_Click(sender As Object, e As EventArgs) Handles drp_btn.Click
        If M_job = "Admin" Then
            Dim rslt As Integer = MessageBox.Show("Are you sure that you want to delete the VST" & vst_id_txtbx.Text & " of " & pt_nm_txtbx.Text & " with PtID : " & pt_id_txtbx.Text & "  ?", "Confirmation!", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)
            If rslt = DialogResult.Yes Then
                Dim rslt2 As Integer = MessageBox.Show("Are you ABSOLUTELY sure that you want to delete the VST" & vst_id_txtbx.Text & " of " & pt_nm_txtbx.Text & " with PtID : " & pt_id_txtbx.Text & " ?", "Confirmation!", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)
                If rslt2 = DialogResult.Yes Then
                    'Update
                    Try
                        mysqlconn.Open()
                        Dim Qu As String = "DELETE FROM mcms.active_visit WHERE id='" & vst_id_txtbx.Text & "'"
                        Dim cmd As New MySqlCommand(Qu, mysqlconn)
                        Dim rdr As MySqlDataReader = cmd.ExecuteReader
                        ResetGridPT()
                        mysqlconn.Close()
                        'SendToLogs
                        mysqlconn.Open()
                        Dim Qu2 As String = "INSERT INTO mcms.logs (who, when_tm, what, where_nm, where_ip) 
                                                    VALUES ('" & M_id & "', now(), 'VST" & vst_id_txtbx.Text & " RCRD DELETED ', '" & M_pc_nm & "', '" & M_pc_ip & "');"
                        Dim cmd2 = New MySqlCommand(Qu2, mysqlconn)
                        Dim rdr2 As MySqlDataReader = cmd2.ExecuteReader
                        mysqlconn.Close()

                        Dim ctrl As Control
                        For Each ctrl In pt_vst_rcrd_mod_grbbx.Controls
                            If TypeOf ctrl Is TextBox Or TypeOf ctrl Is RichTextBox Then
                                ctrl.Text = Nothing
                            End If
                        Next
                        Dim ctrl2 As Control
                        For Each ctrl2 In pt_dia_mod_srch_grbbx.Controls
                            If TypeOf ctrl2 Is TextBox Then
                                ctrl2.Text = Nothing
                            End If
                        Next
                        pt_dia_mod_frm_pkr.Text = Today.Date
                        pt_dia_mod_to_pkr.Text = Today.Date
                    Catch ex As MySqlException
                        MessageBox.Show(ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End Try
                End If

            End If
        Else
            MessageBox.Show("Only Admins can delete visit records!", "Privilege Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub pt_grid_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles pt_grid.CellClick
        Try
            If e.RowIndex >= 0 Then
                Dim row As DataGridViewRow
                row = Me.pt_grid.Rows(e.RowIndex)
                vst_id_txtbx.Text = row.Cells("ActvVstID").Value
                pt_id_txtbx.Text = row.Cells("PtID").Value
                pt_nm_txtbx.Text = row.Cells("PtName").Value.ToString
                dr_id_txtbx.Text = row.Cells("DoctID").Value
                dr_nm_txtbx.Text = row.Cells("DoctName").Value.ToString
                pt_dia_rchtxtbx.Text = row.Cells("Diagnosis").Value.ToString
                pres_rchtxtbx.Text = row.Cells("Prescription").Value.ToString
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class