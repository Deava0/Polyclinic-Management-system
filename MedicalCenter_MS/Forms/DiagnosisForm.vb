Imports MySql.Data.MySqlClient
Public Class DiagnosisForm
    Dim MySqlConn As MySqlConnection
    Dim DB_tableApt As DataTable
    'TextBoxes
    Dim pt_id As Integer
    Dim pt_cvl_id As Integer
    Dim pt_name As String
    Dim pt_gender As String
    Dim pt_dob As Date
    Dim pt_bld_typ As String
    Dim pt_h As Double
    Dim pt_w As Double
    Dim pt_bld_pres As Double

    Dim actv_vst_id As Integer

    Dim remedy_status As String

    Dim Apt_new_pt_fltr As String

    Dim apt_new_cvl As Integer
    Dim apt_new_id As Integer

    Public Sub GetPtInf()
        Dim MySqlConn As New MySqlConnection
        MySqlConn.ConnectionString = GetConnString()

        Try '  AND doct_work_q.crnt_pt = '" & add_avtv_pt_id_txtbx.Text & "'
            MySqlConn.Open()
            Dim Qu As String = "SELECT doct_work_q.doct_id, doct_work_q.crnt_pt, doct_work_q.actv_vst_id, doct_work_q.work_state, doct_work_q.time
                                             , patient.id, patient.civil_id, CONCAT(patient.first_name, patient.second_name, patient.third_name, patient.tribe_name) AS Name, patient.gender, patient.dob, patient.blood_type
                                             , active_visit.id, active_visit.height, active_visit.weight, active_visit.blood_pres
                                        FROM mcms.doct_work_q, mcms.patient, mcms.active_visit, mcms.staff
                                        WHERE doct_work_q.doct_id = staff.id
                                          AND doct_work_q.crnt_pt = patient.id
                                          AND doct_work_q.actv_vst_id = active_visit.id
                                          AND doct_work_q.work_state = 'Processing'
                                          AND doct_work_q.doct_id = '" & M_id & "' "
            Dim cmd As New MySqlCommand(Qu, MySqlConn)
            Dim rdr As MySqlDataReader = cmd.ExecuteReader
            Dim count As Integer = 0
            While rdr.Read
                count += 1
            End While
            If count = 1 Then
                'fill info
                actv_vst_id = rdr.GetInt32("actv_vst_id")

                pt_id = rdr.GetInt32("crnt_pt")
                pt_cvl_id = rdr.GetInt32("civil_id")
                pt_name = rdr.GetString("Name")
                pt_gender = rdr.GetString("gender")
                pt_dob = rdr.GetDateTime("dob")
                pt_bld_typ = rdr.GetString("blood_type")
                pt_h = rdr.GetString("height")
                pt_w = rdr.GetString("weight")
                pt_bld_pres = rdr.GetString("blood_pres")
                'fill Textboxs
                add_avtv_pt_id_txtbx.Text = pt_id
                add_avtv_pt_cvl_id_txtbx.Text = pt_cvl_id
                add_avtv_pt_nm_txtbx.Text = pt_name
                add_avtv_pt_gndr_txtbx.Text = pt_gender
                add_avtv_pt_age_txtbx.Text = GetAge(pt_dob)
                bld_type_txtbx.Text = pt_bld_typ
                height_txtbx.Text = pt_h
                weight_txtbx.Text = pt_w
                bld_pres_txtbx.Text = pt_bld_pres

            ElseIf count > 1 Then
                MessageBox.Show("There're duplicate records at the moment, please try again, or contact the IT department.", "Duplication Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)
                add_avtv_pt_id_txtbx.Text = Nothing
            Else
                MessageBox.Show("There's no record in Active Visits Or your work queue with the PtID you specified, please try again, or contact the IT department.", "No Record Found Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)
                add_avtv_pt_id_txtbx.Text = Nothing
            End If
            MySqlConn.Close()

        Catch ex As MySqlException
            MessageBox.Show(ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            MySqlConn.Dispose()
        End Try
    End Sub

    Private Sub add_avtv_pt_id_txtbx_KeyDown(sender As Object, e As KeyEventArgs) Handles add_avtv_pt_id_txtbx.KeyDown
        If e.KeyCode = Keys.Enter Then

        End If
    End Sub

    Private Sub dia_sbmt_btn_Click(sender As Object, e As EventArgs) Handles dia_sbmt_btn.Click
        Dim MySqlConn As New MySqlConnection
        MySqlConn.ConnectionString = GetConnString()

        If AreEmptyCtrls(Me, "Impo") = True Then
            MessageBox.Show("You have to fill the fields with red label, please try again.", "Filling Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If


        If internal_rdbx.Checked = True Or external_rdbx.Checked = True Then
            If AreEmptyCtrls(Me, "Impo") = False Then
                Dim rslt As Integer = MessageBox.Show("Are you sure that you want to submit the diagnosis and prescription to " & pt_name & " with ID:" & pt_id & " ?", "Confirmation!", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)
                If rslt = DialogResult.Yes Then
                    Try
                        MySqlConn.Open()
                        Dim Qu As String = "UPDATE mcms.active_visit
                                   SET diag='" & add_dia_rtxtbx.Text & "'
                                     , pres='" & add_prsc_rtxtbx.Text & "'
                                     , remedy_state='" & remedy_status & "'
                                     , diag_end_tm=now()
                                   WHERE id = '" & actv_vst_id & "' "
                        Dim cmd = New MySqlCommand(Qu, MySqlConn)
                        Dim rdr As MySqlDataReader = cmd.ExecuteReader
                        MySqlConn.Close()
                        'SendToLogs
                        MySqlConn.Open()
                        Dim Qu3 As String = "INSERT INTO mcms.logs (who, when_tm, what, where_nm, where_ip) 
                                                    VALUES ('" & M_id & "', now(), 'PT" & pt_id & " DIAG ENDED', '" & M_pc_nm & "', '" & M_pc_ip & "');"
                        Dim cmd3 = New MySqlCommand(Qu3, MySqlConn)
                        Dim rdr3 As MySqlDataReader = cmd3.ExecuteReader
                        MySqlConn.Close()
                        If remedy_status = "External" Then
                            'print Prescription   
                            MySqlConn.Open()
                            Dim Qu2 As String = "UPDATE mcms.active_visit
                                   SET to_tm = now()
                                   WHERE id = '" & actv_vst_id & "' "
                            Dim cmd2 = New MySqlCommand(Qu2, MySqlConn)
                            Dim rdr2 As MySqlDataReader = cmd2.ExecuteReader
                            MySqlConn.Close()
                            'SendToLogs
                            MySqlConn.Open()
                            Dim Qu4 As String = "INSERT INTO mcms.logs (who, when_tm, what, where_nm, where_ip) 
                                                    VALUES ('" & M_id & "', now(), 'PT" & pt_id & " VST ENDED(EXTERNAL)', '" & M_pc_nm & "', '" & M_pc_ip & "');"
                            Dim cmd4 = New MySqlCommand(Qu4, MySqlConn)
                            Dim rdr4 As MySqlDataReader = cmd4.ExecuteReader
                            MySqlConn.Close()
                            'CloseDownPtFile
                            MySqlConn.Open()
                            Dim Qu6 As String = "UPDATE mcms.patient SET file_state = 'Inactive'
                                                  WHERE id = '" & pt_id & "'"
                            Dim cmd6 As New MySqlCommand(Qu6, MySqlConn)
                            MySqlConn.Close()
                            'Delete Position in Q
                            MySqlConn.Open()
                            Dim Qu8 As String = "DELETE FROM mcms.pt_queue WHERE actv_vst_id='" & actv_vst_id & "' "
                            Dim cmd8 = New MySqlCommand(Qu8, MySqlConn)
                            Dim rdr8 As MySqlDataReader = cmd8.ExecuteReader
                            MySqlConn.Close()
                        End If
                        'payment
                        MySqlConn.Open()
                        Dim Qu5 As String = "INSERT INTO mcms.payment (by_whom, for_whom, fee_type, fee, com_time) 
                                                               VALUES ('" & M_id & "', '" & pt_id & "', 'CNSLT FEE', '" & cnslt_fee & "', now());"
                        Dim cmd5 As New MySqlCommand(Qu5, MySqlConn)
                        Dim rdr5 As MySqlDataReader = cmd5.ExecuteReader
                        MySqlConn.Close()

                    Catch ex As MySqlException
                        MessageBox.Show(ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Catch ex As Exception
                        MessageBox.Show(ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Finally
                        MySqlConn.Dispose()
                    End Try

                    Dim ctrl As Control
                    For Each ctrl In Me.Controls
                        If TypeOf ctrl Is TextBox Then
                            ctrl.Text = Nothing
                        End If
                    Next
                    internal_rdbx.Checked = False
                    external_rdbx.Checked = False
                End If
            End If
        Else
            MessageBox.Show("You must choose a one of the two Pharmacy options", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

    End Sub

    Private Sub rfrsh_btn_Click(sender As Object, e As EventArgs) Handles rfrsh_btn.Click
        GetPtInf()
    End Sub

    Private Sub internal_rdbx_CheckedChanged(sender As Object, e As EventArgs) Handles internal_rdbx.CheckedChanged
        remedy_status = "Internal"
    End Sub

    Private Sub external_rdbx_CheckedChanged(sender As Object, e As EventArgs) Handles external_rdbx.CheckedChanged
        remedy_status = "External"
    End Sub

    Private Sub apt_new_sbmt_btn_Click(sender As Object, e As EventArgs) Handles apt_new_sbmt_btn.Click
        If AreEmptyCtrls(new_apt_grbbx, "Impo") = True Then
            MessageBox.Show("You have to fill the fields with red label, please try again.", "Filling Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
        If AreEmptyCtrls(new_apt_grbbx, "Impo") = False Then
            Dim rslt As Integer = MessageBox.Show("Are you sure that you want to submit this new appointment for patient " & apt_new_pt_nm_txtbx.Text & " with " & Apt_new_pt_fltr & " on the " & apt_new_apt_tm_pick.Value.Date.ToLongTimeString & "?", "Confirmation!", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)
            If rslt = DialogResult.Yes Then
                Try
                    Dim MySqlConn As New MySqlConnection
                    MySqlConn.ConnectionString = GetConnString()
                    MySqlConn.Open()
                    Dim apt_new_time As Date = apt_new_apt_tm_pick.Value.Date
                    Dim Qu As String = "INSERT INTO mcms.appointment (pt_id, doct_id, reason, apt_time) 
                                                          VALUES ('" & apt_new_id & "', '" & M_id & "', '" & apt_new_rsn_rchtxtbx.Text & "', '" & apt_new_time & "');"
                    Dim cmd As New MySqlCommand(Qu, MySqlConn)
                    MySqlConn.Close()
                Catch ex As MySqlException
                    MessageBox.Show(ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            End If
        End If
    End Sub

    Private Sub apt_new_pt_id_txtbx_KeyDown(sender As Object, e As KeyEventArgs)
        Try
            Dim MySqlConn As New MySqlConnection
            MySqlConn.ConnectionString = GetConnString()
            If e.KeyCode = Keys.Enter Then
                MySqlConn.Open()
                Dim Qu As String = "SELECT id, civil_id, CONCAT(patient.first_name,' ', patient.second_name,' ', patient.third_name,' ', patient.fourth_name,' ', patient.tribe_name) AS Name
                               FROM mcms.patient
                                WHERE " & Apt_new_pt_fltr & " "
                Dim cmd As New MySqlCommand(Qu, MySqlConn)
                Dim rdr As MySqlDataReader = cmd.ExecuteReader
                Dim count As Integer = 0
                While rdr.Read
                    count = +1
                End While
                If count = 1 Then
                    apt_new_pt_nm_txtbx.Text = rdr.GetString("Name")
                    apt_new_cvl = rdr.GetInt32("civil_id")
                    apt_new_id = rdr.GetInt32("id")
                Else
                    MessageBox.Show("File was not found", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
                MySqlConn.Close()
            End If
        Catch ex As MySqlException
            MessageBox.Show(ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub apt_new_pt_id_rdiobtn_CheckedChanged(sender As Object, e As EventArgs) Handles apt_new_pt_id_rdiobtn.CheckedChanged
        Apt_new_pt_fltr = "id='" & apt_new_pt_cvl_id_txtbx.Text & "' "
    End Sub

    Private Sub apt_new_pt_cvl_id_rdiobtn_CheckedChanged(sender As Object, e As EventArgs) Handles apt_new_pt_cvl_id_rdiobtn.CheckedChanged
        Apt_new_pt_fltr = "civil_id='" & apt_new_pt_cvl_id_txtbx.Text & "' "
    End Sub

    Private Sub TabPage4_Click(sender As Object, e As EventArgs) Handles TabPage4.Click
        apt_new_pt_cvl_id_rdiobtn.Checked = True
        Apt_new_pt_fltr = "civil_id='" & apt_new_pt_cvl_id_txtbx.Text & "' "
    End Sub

    Private Sub pt_dia_mod_rst_today_btn_Click(sender As Object, e As EventArgs) Handles pt_dia_mod_rst_today_btn.Click
        Dim from_am As String
        from_am = (Date.Today + " 00:00:00")
        pt_dia_mod_frm_pkr.Text = from_am

        Dim from_pm As String
        from_pm = (Date.Today + " 23:59:59")
        pt_dia_mod_to_pkr.Text = from_pm
    End Sub

    Public Sub ResetGridApt()
        MySqlConn = New MySqlConnection
        MySqlConn.ConnectionString = GetConnString()

        DB_tableApt.Clear()

        Dim MySqlDtAd As New MySqlDataAdapter
        Dim BinSouc As New BindingSource

        Try
            MySqlConn.Open()
            Dim Qu As String = "SELECT appointment.id AS AptID
                                     , appointment.pt_id AS PtID, CONCAT(patient.first_name,' ', patient.second_name,' ', patient.third_name,' ', patient.fourth_name,' ', patient.tribe_name) AS PtName
                                     , appointment.doct_id AS DoctID, CONCAT(staff.first_name,' ', staff.second_name,' ', staff.third_name,' ', staff.fourth_name,' ', staff.tribe_name) AS DoctorName
                                     , appointment.reason AS Reason, appointment.apt_time AS AptTime, appointment.apt_status AS AptStatus
                                  From mcms.appointment, mcms.patinet, mcms.staff
                                 WHERE appointment.pt_id = patient.id
                                   AND appointment.doct_id = staff.id"
            Dim cmd As New MySqlCommand(Qu, MySqlConn)
            MySqlDtAd.SelectCommand = cmd
            MySqlDtAd.Fill(DB_tableApt)
            BinSouc.DataSource = DB_tableApt
            pt_grid.DataSource = BinSouc
            MySqlDtAd.Update(DB_tableApt)
            MySqlConn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            MySqlConn.Dispose()
        End Try
    End Sub

    Private Sub pt_dia_mod_all_btn_Click(sender As Object, e As EventArgs) Handles pt_dia_mod_all_btn.Click
        ResetGridApt()
    End Sub

    Private Sub TabPage5_Click(sender As Object, e As EventArgs) Handles TabPage5.Click
        apt_status_cmbobx.Text = "OnHold"
        fltr_doct_id_txtbx.Text = M_id
    End Sub

    Private Sub pt_dia_mod_srch_btn_Click(sender As Object, e As EventArgs) Handles pt_dia_mod_srch_btn.Click
        MySqlConn = New MySqlConnection
        MySqlConn.ConnectionString = GetConnString()

        If doct_id_chkbx.Checked = False AndAlso pt_id_chkbx.Checked = False Then

            DB_tableApt.Clear()

            Dim MySqlDtAd As New MySqlDataAdapter
            Dim BinSouc As New BindingSource

            Try
                MySqlConn.Open()
                Dim Qu As String = "SELECT appointment.id AS AptID
                                     , appointment.pt_id AS PtID, CONCAT(patient.first_name,' ', patient.second_name,' ', patient.third_name,' ', patient.fourth_name,' ', patient.tribe_name) AS PtName
                                     , appointment.doct_id AS DoctID, CONCAT(staff.first_name,' ', staff.second_name,' ', staff.third_name,' ', staff.fourth_name,' ', staff.tribe_name) AS DoctorName
                                     , appointment.reason AS Reason, appointment.apt_time AS AptTime, appointment.apt_status AS AptStatus
                                  From mcms.appointment, mcms.patinet, mcms.staff
                                 WHERE appointment.pt_id = patient.id
                                   AND appointment.doct_id = staff.id
                                   AND appointment.apt_time BETWEEN '" & pt_dia_mod_frm_pkr.Text & "' AND '" & pt_dia_mod_to_pkr.Text & "' "
                Dim cmd As New MySqlCommand(Qu, MySqlConn)
                MySqlDtAd.SelectCommand = cmd
                MySqlDtAd.Fill(DB_tableApt)
                BinSouc.DataSource = DB_tableApt
                pt_grid.DataSource = BinSouc
                MySqlDtAd.Update(DB_tableApt)
                MySqlConn.Close()
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            Finally
                MySqlConn.Dispose()
            End Try
        ElseIf doct_id_chkbx.Checked = True AndAlso pt_id_chkbx.Checked = True Then


            DB_tableApt.Clear()

            Dim MySqlDtAd As New MySqlDataAdapter
            Dim BinSouc As New BindingSource

            Try
                MySqlConn.Open()
                Dim Qu As String = "SELECT appointment.id AS AptID
                                     , appointment.pt_id AS PtID, CONCAT(patient.first_name,' ', patient.second_name,' ', patient.third_name,' ', patient.fourth_name,' ', patient.tribe_name) AS PtName
                                     , appointment.doct_id AS DoctID, CONCAT(staff.first_name,' ', staff.second_name,' ', staff.third_name,' ', staff.fourth_name,' ', staff.tribe_name) AS DoctorName
                                     , appointment.reason AS Reason, appointment.apt_time AS AptTime, appointment.apt_status AS AptStatus
                                  From mcms.appointment, mcms.patinet, mcms.staff
                                 WHERE appointment.pt_id = patient.id
                                   AND appointment.doct_id = staff.id
                                   AND appointment.apt_time BETWEEN '" & pt_dia_mod_frm_pkr.Text & "' AND '" & pt_dia_mod_to_pkr.Text & "' 
                                   AND appointment.pt_id = '" & fltr_pt_id_txtbx.Text & "' 
                                   AND appointment.doct_id = '" & fltr_doct_id_txtbx.Text & "' "
                Dim cmd As New MySqlCommand(Qu, MySqlConn)
                MySqlDtAd.SelectCommand = cmd
                MySqlDtAd.Fill(DB_tableApt)
                BinSouc.DataSource = DB_tableApt
                pt_grid.DataSource = BinSouc
                MySqlDtAd.Update(DB_tableApt)
                MySqlConn.Close()
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            Finally
                MySqlConn.Dispose()
            End Try
        ElseIf doct_id_chkbx.Checked = True Then


            DB_tableApt.Clear()

            Dim MySqlDtAd As New MySqlDataAdapter
            Dim BinSouc As New BindingSource

            Try
                MySqlConn.Open()
                Dim Qu As String = "SELECT appointment.id AS AptID
                                     , appointment.pt_id AS PtID, CONCAT(patient.first_name,' ', patient.second_name,' ', patient.third_name,' ', patient.fourth_name,' ', patient.tribe_name) AS PtName
                                     , appointment.doct_id AS DoctID, CONCAT(staff.first_name,' ', staff.second_name,' ', staff.third_name,' ', staff.fourth_name,' ', staff.tribe_name) AS DoctorName
                                     , appointment.reason AS Reason, appointment.apt_time AS AptTime, appointment.apt_status AS AptStatus
                                  From mcms.appointment, mcms.patinet, mcms.staff
                                 WHERE appointment.pt_id = patient.id
                                   AND appointment.doct_id = staff.id
                                   AND appointment.apt_time BETWEEN '" & pt_dia_mod_frm_pkr.Text & "' AND '" & pt_dia_mod_to_pkr.Text & "' 
                                   AND appointment.doct_id = '" & fltr_doct_id_txtbx.Text & "' "
                Dim cmd As New MySqlCommand(Qu, MySqlConn)
                MySqlDtAd.SelectCommand = cmd
                MySqlDtAd.Fill(DB_tableApt)
                BinSouc.DataSource = DB_tableApt
                pt_grid.DataSource = BinSouc
                MySqlDtAd.Update(DB_tableApt)
                MySqlConn.Close()
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            Finally
                MySqlConn.Dispose()
            End Try
        ElseIf pt_id_chkbx.Checked = True Then


            DB_tableApt.Clear()

            Dim MySqlDtAd As New MySqlDataAdapter
            Dim BinSouc As New BindingSource

            Try
                MySqlConn.Open()
                Dim Qu As String = "SELECT appointment.id AS AptID
                                     , appointment.pt_id AS PtID, CONCAT(patient.first_name,' ', patient.second_name,' ', patient.third_name,' ', patient.fourth_name,' ', patient.tribe_name) AS PtName
                                     , appointment.doct_id AS DoctID, CONCAT(staff.first_name,' ', staff.second_name,' ', staff.third_name,' ', staff.fourth_name,' ', staff.tribe_name) AS DoctorName
                                     , appointment.reason AS Reason, appointment.apt_time AS AptTime, appointment.apt_status AS AptStatus
                                  From mcms.appointment, mcms.patinet, mcms.staff
                                 WHERE appointment.pt_id = patient.id
                                   AND appointment.doct_id = staff.id
                                   AND appointment.apt_time BETWEEN '" & pt_dia_mod_frm_pkr.Text & "' AND '" & pt_dia_mod_to_pkr.Text & "' 
                                   AND appointment.pt_id = '" & fltr_pt_id_txtbx.Text & "' "
                Dim cmd As New MySqlCommand(Qu, MySqlConn)
                MySqlDtAd.SelectCommand = cmd
                MySqlDtAd.Fill(DB_tableApt)
                BinSouc.DataSource = DB_tableApt
                pt_grid.DataSource = BinSouc
                MySqlDtAd.Update(DB_tableApt)
                MySqlConn.Close()
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            Finally
                MySqlConn.Dispose()
            End Try
        End If
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

    Private Sub pt_grid_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles pt_grid.CellClick
        Try
            If e.RowIndex >= 0 Then
                Dim row As DataGridViewRow
                row = Me.pt_grid.Rows(e.RowIndex)
                apt_mod_apt_id_txtbx.Text = row.Cells("AptID").Value
                apt_mod_apt_rsn_rchtxtbx.Text = row.Cells("Reason").Value.ToString
                apt_mod_apt_tm_picker.Text = row.Cells("AptTime").Value.ToString
                apt_mod_pt_id_txtbx.Text = row.Cells("PtID").Value
                apt_mod_pt_nm_txtbx.Text = row.Cells("PtName").Value.ToString
                apt_mod_doct_id_txtbx.Text = row.Cells("DoctID").Value
                apt_mod_doct_name_txtbx.Text = row.Cells("DoctName").Value.ToString
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub apt_mod_update_btn_Click(sender As Object, e As EventArgs) Handles apt_mod_update_btn.Click
        MySqlConn = New MySqlConnection
        MySqlConn.ConnectionString = GetConnString()
        If apt_mod_doct_id_txtbx.Text = M_id Or M_job = "Admin" Then
            Dim rslt As Integer = MessageBox.Show("Are you sure that you want to modify APT" & apt_mod_apt_id_txtbx.Text & " for " & apt_mod_pt_nm_txtbx.Text & " with PtID : " & apt_mod_pt_id_txtbx.Text & " ?", "Confirmation!", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)
            If rslt = DialogResult.Yes Then
                'Update
                Try
                    MySqlConn.Open()
                    Dim Qu As String = "UPDATE mcms.appointment SET reason='" & apt_mod_apt_rsn_rchtxtbx.Text & "', apt_time='" & apt_mod_apt_tm_picker.Text & "'
                                                    WHERE id='" & apt_mod_apt_id_txtbx.Text & "'"
                    Dim cmd As New MySqlCommand(Qu, MySqlConn)
                    ResetGridApt()
                    MySqlConn.Close()
                    'SendToLogs
                    MySqlConn.Open()
                    Dim Qu2 As String = "INSERT INTO mcms.logs (who, when_tm, what, where_nm, where_ip) 
                                                    VALUES ('" & M_id & "', now(), 'APT" & apt_mod_apt_id_txtbx.Text & " RCRD MODI ', '" & M_pc_nm & "', '" & M_pc_ip & "');"
                    Dim cmd2 = New MySqlCommand(Qu2, MySqlConn)
                    MySqlConn.Close()

                    For Each ctrl In apt_mod_grbbx.Controls
                        If TypeOf ctrl Is TextBox Or TypeOf ctrl Is RichTextBox Then
                            ctrl.Text = Nothing
                        End If
                    Next
                    apt_mod_apt_tm_picker.Text = Today.Date

                Catch ex As MySqlException
                    MessageBox.Show(ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            End If
        Else
            MessageBox.Show("You are neither an Admin nor the doctor assigned to this appointment, as a result you CANNOT modify this record!", "Privilege Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)
            For Each ctrl In apt_mod_grbbx.Controls
                If TypeOf ctrl Is TextBox Or TypeOf ctrl Is RichTextBox Then
                    ctrl.Text = Nothing
                End If
            Next
            apt_mod_apt_tm_picker.Text = Today.Date
        End If

    End Sub

    Private Sub apt_mod_drp_btn_Click(sender As Object, e As EventArgs) Handles apt_mod_drp_btn.Click
        If M_job = "Admin" Or apt_mod_doct_id_txtbx.Text = M_id Then
            Dim rslt As Integer = MessageBox.Show("Are you sure that you want to delete the APT" & apt_mod_apt_id_txtbx.Text & " for " & apt_mod_pt_nm_txtbx.Text & " with PtID : " & apt_mod_pt_id_txtbx.Text & " ?", "Confirmation!", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)
            If rslt = DialogResult.Yes Then
                Dim rslt2 As Integer = MessageBox.Show("Are you ABSOLUTELY sure that you want to delete the APT" & apt_mod_apt_id_txtbx.Text & " for " & apt_mod_pt_nm_txtbx.Text & " with PtID : " & apt_mod_pt_id_txtbx.Text & " ?", "Confirmation!", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)
                If rslt2 = DialogResult.Yes Then
                    'Update
                    Try
                        MySqlConn.Open()
                        Dim Qu As String = "DELETE FROM mcms.appointment WHERE id='" & apt_mod_apt_id_txtbx.Text & "'"
                        Dim cmd As New MySqlCommand(Qu, MySqlConn)
                        Dim rdr As MySqlDataReader = cmd.ExecuteReader
                        ResetGridApt()
                        MySqlConn.Close()
                        'SendToLogs
                        MySqlConn.Open()
                        Dim Qu2 As String = "INSERT INTO mcms.logs (who, when_tm, what, where_nm, where_ip) 
                                                    VALUES ('" & M_id & "', now(), 'APT" & apt_mod_apt_id_txtbx.Text & " RCRD DELETED ', '" & M_pc_nm & "', '" & M_pc_ip & "');"
                        Dim cmd2 = New MySqlCommand(Qu2, MySqlConn)
                        Dim rdr2 As MySqlDataReader = cmd2.ExecuteReader
                        MySqlConn.Close()

                        Dim ctrl As Control
                        For Each ctrl In apt_mod_grbbx.Controls
                            If TypeOf ctrl Is TextBox Or TypeOf ctrl Is RichTextBox Then
                                ctrl.Text = Nothing
                            End If
                        Next
                        apt_mod_apt_tm_picker.Text = Today.Date
                    Catch ex As MySqlException
                        MessageBox.Show(ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End Try
                End If

            End If
        Else
            MessageBox.Show("Only Admins can delete visit records!", "Privilege Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub
End Class