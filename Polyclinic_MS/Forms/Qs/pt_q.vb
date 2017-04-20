Imports MySql.Data.MySqlClient
Public Class pt_q
    Dim MySqlConn As MySqlConnection
    Dim DB_table As New DataTable
    Dim DB_table2 As New DataTable

    Dim actv_vst_id As Integer
    Dim Q_id As Integer
    Public Sub restPtQ()

        MySqlConn = New MySqlConnection
        MySqlConn.ConnectionString = GetConnString()

        DB_table.Clear()

        Dim MySqlDtAd As New MySqlDataAdapter
        Dim BinSouc As New BindingSource

        Try
            MySqlConn.Open()
            Dim Qu As String = "SELECT *
                                    FROM
                                    (
                                    SELECT 1 AS Rank
	                                     , pt_queue.id AS QID
                                         , pt_queue.pt_id AS PtID, CONCAT(patient.first_name,' ', patient.second_name,' ', patient.third_name,' ', patient.tribe_name) AS PatientName
                                         , patient.blood_type AS BloodType
	                                     , pt_queue.apt_state AS AptStatus
                                         , pt_queue.apt_id AS AptID
                                         , pt_queue.doct_id AS DoctID, CONCAT(staff.first_name,' ', staff.second_name,' ', staff.third_name,' ', staff.tribe_name) AS DoctorName  
                                         , pt_queue.actv_vst_id AS ActVstID, active_visit.remedy_state AS RemedyStatus
                                         , active_visit.height AS Height, active_visit.weight AS Weight, active_visit.blood_pres AS BloodPres
                                         , pt_queue.q_state AS QSTATUS, pt_queue.ariv_time AS ArivalTime

                                    FROM mcms.pt_queue, mcms.patient, mcms.staff, mcms.appointment, mcms.active_visit
                                    WHERE pt_queue.pt_id = patient.id
                                    AND   pt_queue.doct_id = staff.id
                                    AND   pt_queue.pt_id = patient.id AND pt_queue.apt_state = 'with'
                                    AND   pt_queue.actv_vst_id =  active_visit.id
                                    GROUP BY pt_queue.id 

                                    UNION ALL

                                    SELECT 2 as rank
                                         , pt_queue.id
                                         , pt_queue.pt_id AS PtID, CONCAT(patient.first_name,' ', patient.second_name,' ', patient.third_name,' ', patient.tribe_name) AS PatientName
	                                     , patient.blood_type AS BloodType
	                                     , pt_queue.apt_state AS AptStatus
                                         , null AS AptID
                                         , null AS DoctID, null AS DoctorName 
                                         , pt_queue.actv_vst_id AS ActVstID, active_visit.remedy_state AS RemedyStatus
                                         , active_visit.height AS Height, active_visit.weight AS Weight, active_visit.blood_pres AS BloodPres
                                         , pt_queue.q_state AS QSTATUS, pt_queue.ariv_time AS ArivalTime
                                    FROM mcms.pt_queue, mcms.patient, mcms.staff,  mcms.active_visit
                                    WHERE pt_queue.pt_id = patient.id AND pt_queue.apt_state = 'without'
                                    AND   pt_queue.actv_vst_id =  active_visit.id
                                    GROUP BY pt_queue.id
                                    ) a
                                    ORDER by rank, ArivalTime "
            Dim cmd As New MySqlCommand(Qu, MySqlConn)
            MySqlDtAd.SelectCommand = cmd
            MySqlDtAd.Fill(DB_table)
            BinSouc.DataSource = DB_table
            pt_q_grid.DataSource = BinSouc
            MySqlDtAd.Update(DB_table)
            MySqlConn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            MySqlConn.Dispose()
        End Try
    End Sub
    Private Sub RefreshQueueTableToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RefreshQueueTableToolStripMenuItem.Click
        restPtQ()
    End Sub
    Private Sub pt_q_grid_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles pt_q_grid.CellClick
        bsk_pt_inf_grbbx.Show()
        Try
            If e.RowIndex >= 0 Then
                Dim row As DataGridViewRow
                row = Me.pt_q_grid.Rows(e.RowIndex)

                pt_id_txtbx.Text = row.Cells("PtID").Value
                pt_nm_txtbx.Text = row.Cells("PatientName").Value.ToString
                actv_vst_id = row.Cells("ActVstID").Value
                Q_id = row.Cells("QID").Value
                If row.Cells("AptStatus").Value.ToString = "With" Then
                    apt_chkbx.Checked = True
                Else
                    apt_chkbx.Checked = False
                End If
                bld_type_txtbx.Text = row.Cells("BloodType").Value.ToString
                bld_pres_txtbx.Text = row.Cells("BloodPres").Value.ToString
                height_txtbx.Text = row.Cells("Height").Value.ToString
                weight_txtbx.Text = row.Cells("Weight").Value.ToString
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub pt_q_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        bsk_pt_inf_grbbx.Hide()
        bsk_doct_inf_grbbx.Hide()

        apt_chkbx.Enabled = False
        pt_id_txtbx.ReadOnly = True
        pt_nm_txtbx.ReadOnly = True
    End Sub

    Private Sub snd_in_btn_Click(sender As Object, e As EventArgs) Handles snd_in_btn.Click
        MySqlConn = New MySqlConnection
        MySqlConn.ConnectionString = GetConnString()
        Dim notBusy As Boolean
        If doct_wrk_sts.Text = "Waiting" Or doct_wrk_sts.Text = "Finished" Then
            notBusy = True
        Else
            notBusy = False
        End If

        If notBusy = True AndAlso Not bld_type_txtbx.Text = "UNKNOWN" AndAlso AreEmptyCtrls(bsk_pt_inf_grbbx, "pt_inf") = False Then
            Dim rslt As Integer = MessageBox.Show("Are you sure that you want to send
" & pt_nm_txtbx.Text & " with ID : " & pt_id_txtbx.Text & " to Dr." & doct_nm_txtbx.Text & " with ID :" & doct_id_txtbx.Text & "?", "Confirmation!", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)
            If rslt = DialogResult.Yes Then
                Try
                    'Update active_visit
                    MySqlConn.Open()
                    Dim Qu As String = "UPDATE mcms.active_visit 
                                    SET nurse_id='" & M_id & "', doct_id='" & doct_id_txtbx.Text & "', height = '" & height_txtbx.Text & "', weight = '" & weight_txtbx.Text & "', blood_pres = '" & bld_pres_txtbx.Text & "'
                                    WHERE id='" & actv_vst_id & "'"
                    Dim cmd = New MySqlCommand(Qu, MySqlConn)
                    Dim rdr As MySqlDataReader = cmd.ExecuteReader
                    MySqlConn.Close()
                    'Insert BloodType
                    MySqlConn.Open()
                    Dim Qu2 As String = "UPDATE mcms.patient 
                                    SET blood_type ='" & bld_type_txtbx.Text & "'
                                    WHERE id='" & pt_id_txtbx.Text & "'"
                    Dim cmd2 = New MySqlCommand(Qu2, MySqlConn)
                    Dim rdr2 As MySqlDataReader = cmd2.ExecuteReader
                    MySqlConn.Close()
                    'SendToLogs
                    MySqlConn.Open()
                    Dim Qu3 As String = "INSERT INTO mcms.logs (who, when_tm, what, where_nm, where_ip) 
                                                    VALUES ('" & M_id & "', now(), 'PT" & pt_id_txtbx.Text & " SENT IN TO DCT" & doct_id_txtbx.Text & " ', '" & M_pc_nm & "', '" & M_pc_ip & "');"
                    Dim cmd3 = New MySqlCommand(Qu3, MySqlConn)
                    Dim rdr3 As MySqlDataReader = cmd3.ExecuteReader
                    MySqlConn.Close()
                    'Update Pt q status pt_queue
                    MySqlConn.Open()
                    Dim Qu4 As String = "Update mcms.pt_queue SET q_state='Processing' WHERE id = '" & Q_id & "'"
                    Dim cmd4 = New MySqlCommand(Qu4, MySqlConn)
                    Dim rdr4 As MySqlDataReader = cmd4.ExecuteReader
                    MySqlConn.Close()
                    'Change Doctor status to 'Processing'
                    MySqlConn.Open()
                    Dim Qu5 As String = "UPDATE mcms.doct_work_q 
                                    SET work_state = 'Processing', crnt_pt='" & pt_id_txtbx.Text & "', actv_vst_id='" & actv_vst_id & "'
                                    WHERE doct_id='" & doct_id_txtbx.Text & "'"
                    Dim cmd5 = New MySqlCommand(Qu5, MySqlConn)
                    Dim rdr5 As MySqlDataReader = cmd5.ExecuteReader
                    MySqlConn.Close()
                Catch ex As MySqlException
                    MessageBox.Show(ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Finally
                    MySqlConn.Dispose()
                End Try
                'CLEAR
                Dim ctrl As Control
                For Each ctrl In bsk_pt_inf_grbbx.Controls
                    If TypeOf ctrl Is TextBox Then
                        ctrl.Text = Nothing
                    End If
                Next
                Dim ctrl2 As Control
                For Each ctrl2 In bsk_doct_inf_grbbx.Controls
                    If TypeOf ctrl2 Is TextBox Or TypeOf ctrl2 Is Label Then
                        ctrl2.Text = Nothing
                    End If
                Next
                bsk_pt_inf_grbbx.Hide()
                bsk_doct_inf_grbbx.Hide()
            End If
        End If
        If bld_type_txtbx.Text = "UNKNOWN" Then
                MessageBox.Show("You have to blood-test the patient before sending him/her to meet the doctor", "Blood Type Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        If notBusy = False Then
            MessageBox.Show("Dr." & doct_nm_txtbx.Text & " with ID :" & doct_id_txtbx.Text & " is busy at the moment, try again later, or choose another doctor.", "Busy Doctor Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
        If AreEmptyCtrls(bsk_pt_inf_grbbx, "pt_inf") = False Then
            MessageBox.Show("You have to check the height, weight and blood pressure before sending the patient to meet the doctor", "Patient Info Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

    End Sub
    Public Sub restDoctQ()
        Dim todayDate As DateTime = DateTime.Now
        Dim StrtOfDay As DateTime = todayDate.Date + New TimeSpan(0, 0, 0)
        Dim EndOfDay As DateTime = todayDate.Date + New TimeSpan(23, 59, 59)

        MySqlConn = New MySqlConnection
        MySqlConn.ConnectionString = GetConnString()

        DB_table2.Clear()

        Dim MySqlDtAd As New MySqlDataAdapter
        Dim BinSouc As New BindingSource

        Try
            MySqlConn.Open()
            Dim Qu1 As String = "SELECT doct_work_q.id AS QID
                                , doct_work_q.doct_id AS DoctID, CONCAT(staff.first_name,' ', staff.second_name,' ', staff.third_name,' ', staff.tribe_name) AS DoctorName
                                , doct_work_q.work_state AS WorkStatus, doct_work_q.crnt_pt AS CurrentPatient, doct_work_q.actv_vst_id AS CurrentActVstID
                                FROM mcms.doct_work_q, mcms.patient, mcms.staff, mcms.active_visit
                                WHERE doct_work_q.crnt_pt = patient.id
                                  AND doct_work_q.doct_id = staff.id
                                  AND doct_work_q.actv_vst_id = active_visit.id
                                  AND doct_work_q.work_state = 'Waiting'
                                  AND doct_work_q.time BETWEEN '@" & StrtOfDay & "' AND '@" & EndOfDay & "'
                                GROUP BY doct_work_q.id
                                ORDER BY doct_work_q.id"

            Dim Qu As String = "SELECT doct_work_q.id AS QID
                                     , doct_work_q.doct_id AS DoctID, CONCAT(staff.first_name,' ', staff.second_name,' ', staff.third_name,' ', staff.tribe_name) AS DoctorName
                                     , doct_work_q.work_state AS WorkStatus, doct_work_q.actv_vst_id AS CurrentActVstID
                                     , doct_work_q.crnt_pt AS CurrentPatient, CONCAT(patient.first_name,' ', patient.second_name,' ', patient.third_name,' ', patient.tribe_name) AS PatientName
                                     , doct_work_q.time AS Time
                                  FROM mcms.doct_work_q, mcms.staff, mcms.patient, mcms.active_visit
                                  WHERE doct_work_q.doct_id = staff.id
                               GROUP BY doct_work_q.id
                               ORDER BY doct_work_q.time"
            Dim cmd As New MySqlCommand(Qu, MySqlConn)
            MySqlDtAd.SelectCommand = cmd
            MySqlDtAd.Fill(DB_table2)
            BinSouc.DataSource = DB_table2
            doct_wrk_q_grid.DataSource = BinSouc
            MySqlDtAd.Update(DB_table2)
            MySqlConn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            MySqlConn.Dispose()
        End Try
    End Sub
    Private Sub RefreshDoctorTableToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RefreshDoctorTableToolStripMenuItem.Click
        restDoctQ()
    End Sub

    Private Sub doct_wrk_q_grid_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles doct_wrk_q_grid.CellClick
        bsk_doct_inf_grbbx.Show()
        Try
            If e.RowIndex >= 0 Then
                Dim row As DataGridViewRow
                row = Me.doct_wrk_q_grid.Rows(e.RowIndex)
                doct_id_txtbx.Text = row.Cells("DoctID").Value
                doct_nm_txtbx.Text = row.Cells("DoctorName").Value.ToString
                doct_wrk_sts.Text = row.Cells("WorkStatus").Value.ToString
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class