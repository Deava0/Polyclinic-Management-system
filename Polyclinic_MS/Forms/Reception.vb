Imports MySql.Data.MySqlClient
Public Class Reception
    Dim MySqlConn As MySqlConnection
    Dim DB_table As New DataTable
    Dim DB_table2 As New DataTable

    Dim pt_id As Integer
    Dim pt_prfx As String
    Dim pt_nm As String

    Dim prfDoc_id As String
    Dim prfDoc_prfx As String
    Dim prfDoc_nm As String

    Public Sub ResetGridWO()
        MySqlConn = New MySqlConnection
        MySqlConn.ConnectionString = GetConnString()

        DB_table.Clear()

        Dim MySqlDtAd As New MySqlDataAdapter
        Dim BinSouc As New BindingSource

        Try
            MySqlConn.Open()
            Dim Qu As String = "SELECT id AS ID, civil_id AS CivilID, prefix as Prefix, CONCAT(first_name,' ', second_name,' ', third_name,' ', fourth_name,' ', tribe_name) AS Name
                            , phone_no AS PhoneNO, dob AS DoB, gender AS Gender, address AS Address, nationality AS Nationality, email AS Email
                            FROM mcms.patient WHERE file_state='Inactive'"
            Dim cmd As New MySqlCommand(Qu, MySqlConn)
            MySqlDtAd.SelectCommand = cmd
            MySqlDtAd.Fill(DB_table)
            BinSouc.DataSource = DB_table
            ac_vst_wo_grid.DataSource = BinSouc
            MySqlDtAd.Update(DB_table)
            MySqlConn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            MySqlConn.Dispose()
        End Try
    End Sub
    Private Sub rst_tbl_btn_Click(sender As Object, e As EventArgs) Handles rst_tbl_btn.Click
        ResetGridWO()
    End Sub

    Private Sub without_actv_btn_Click(sender As Object, e As EventArgs) Handles without_actv_btn.Click
        Dim actVstID As Integer
        MySqlConn = New MySqlConnection
        MySqlConn.ConnectionString = GetConnString()
        Dim rslt As Integer = MessageBox.Show("Are you sure that you want to activate this patient's file :
" & pt_prfx & "." & pt_nm & " with ID : " & pt_id & " ?", "Confirmation!", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)
        If rslt = DialogResult.Yes Then
            'Update
            Try
                MySqlConn.Open()
                Dim Qu As String = "UPDATE mcms.patient SET file_state='Active' WHERE id='" & without_actv_txtbx.Text & "'"
                Dim cmd As New MySqlCommand(Qu, MySqlConn)
                Dim rdr As MySqlDataReader = cmd.ExecuteReader
                ResetGridWO()
                MySqlConn.Close()
                'SendToLogs
                MySqlConn.Open()
                Dim Qu2 As String = "INSERT INTO mcms.logs (who, when_tm, what, where_nm, where_ip) 
                                                    VALUES ('" & M_id & "', now(), 'PT" & without_actv_txtbx.Text & " FILE ACTV ', '" & M_pc_nm & "', '" & M_pc_ip & "');"
                Dim cmd2 = New MySqlCommand(Qu2, MySqlConn)
                Dim rdr2 As MySqlDataReader = cmd2.ExecuteReader
                MySqlConn.Close()
                'Startup the active visit
                MySqlConn.Open()
                Dim Qu3 As String = "INSERT INTO mcms.active_visit (pt_id, rec_id, from_tm) VALUES ('" & without_actv_txtbx.Text & "','" & M_id & "', now());"
                Dim cmd3 = New MySqlCommand(Qu3, MySqlConn)
                Dim rdr3 As MySqlDataReader = cmd3.ExecuteReader
                MySqlConn.Close()
                'Get actVstID
                MySqlConn.Open()
                Dim Qu4 As String = "SELECT * FROM mcms.active_visit WHERE pt_id='" & without_actv_txtbx.Text & "' AND from_tm > DATE_SUB(now(), INTERVAL 1 MINUTE)"
                Dim cmd4 = New MySqlCommand(Qu4, MySqlConn)
                Dim rdr4 As MySqlDataReader = cmd4.ExecuteReader
                While rdr4.Read
                    actVstID = rdr4.GetInt32("id")
                End While
                MySqlConn.Close()
                ' Threading.Thread.Sleep(500)
                'SendToQ
                MySqlConn.Open()
                Dim Qu5 As String = "INSERT INTO mcms.pt_queue (pt_id, apt_state, q_state, ariv_time, actv_vst_id)
                                                            VALUES ('" & without_actv_txtbx.Text & "', 'Without', 'Waiting', now(), '" & actVstID & "');"
                Dim cmd5 = New MySqlCommand(Qu5, MySqlConn)
                Dim rdr5 As MySqlDataReader = cmd5.ExecuteReader
                MySqlConn.Close()
                'payment
                MySqlConn.Open()
                Dim Qu6 As String = "INSERT INTO mcms.payment (by_whom, for_whom, fee_type, fee, com_time) 
                                                               VALUES ('" & M_id & "', '" & without_actv_txtbx.Text & "', 'FILE ACTV FEE', '" & file_actv_fee & "', now());"
                Dim cmd6 As New MySqlCommand(Qu6, MySqlConn)
                Dim rdr6 As MySqlDataReader = cmd6.ExecuteReader
                MySqlConn.Close()
            Catch ex As MySqlException
                MessageBox.Show(ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        Else
            without_actv_grbbx.Hide()
            ResetGridWO()
        End If

    End Sub

    Private Sub Reception_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            without_actv_grbbx.Hide()
            with_actv_grbbx.Hide()

            pt_pno_rbtn.Checked = True

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub srch_txtbx_TextChanged(sender As Object, e As EventArgs) Handles srch_txtbx.TextChanged
        MySqlConn = New MySqlConnection
        MySqlConn.ConnectionString = GetConnString()



        Dim MySqlDtAd As New MySqlDataAdapter
        Dim BinSouc As New BindingSource
        DB_table.Clear()

        Try
            If pt_id_rbtn.Checked = True Then
                MySqlConn.Open()
                Dim Qu As String = "SELECT id AS ID, civil_id AS CivilID, prefix as Prefix, CONCAT(first_name,' ', second_name,' ', third_name,' ', fourth_name,' ', tribe_name) AS Name
                            , phone_no AS PhoneNO, dob AS DoB, gender AS Gender, address AS Address, nationality AS Nationality, email AS Email
                            FROM mcms.patient
                            WHERE id = '" & srch_txtbx.Text & "%'"
                Dim cmd As New MySqlCommand(Qu, MySqlConn)
                MySqlDtAd.SelectCommand = cmd
                MySqlDtAd.Fill(DB_table)
                BinSouc.DataSource = DB_table
                ac_vst_wo_grid.DataSource = BinSouc
                MySqlDtAd.Update(DB_table)
                MySqlConn.Close()
            End If
            If pt_cvl_id_rbtn.Checked = True Then
                MySqlConn.Open()
                Dim Qu As String = "SELECT id AS ID, civil_id AS CivilID, prefix as Prefix, CONCAT(first_name,' ', second_name,' ', third_name,' ', fourth_name,' ', tribe_name) AS Name
                            , phone_no AS PhoneNO, dob AS DoB, gender AS Gender, address AS Address, nationality AS Nationality, email AS Email
                            FROM mcms.patient
                            WHERE civil_id LIKE '" & srch_txtbx.Text & "%'"
                Dim cmd As New MySqlCommand(Qu, MySqlConn)
                MySqlDtAd.SelectCommand = cmd
                MySqlDtAd.Fill(DB_table)
                BinSouc.DataSource = DB_table
                ac_vst_wo_grid.DataSource = BinSouc
                MySqlDtAd.Update(DB_table)
                MySqlConn.Close()
            End If
            If pt_nm_rbtn.Checked = True Then
                MySqlConn.Open()
                Dim Qu As String = "SELECT id AS ID, civil_id AS CivilID, prefix as Prefix, CONCAT(first_name,' ', second_name,' ', third_name,' ', fourth_name,' ', tribe_name) AS Name
                            , phone_no AS PhoneNO, dob AS DoB, gender AS Gender, address AS Address, nationality AS Nationality, email AS Email
                            FROM mcms.patient
                            WHERE first_name LIKE '" & srch_txtbx.Text & "%'
                              OR second_name LIKE '" & srch_txtbx.Text & "%'
                              OR third_name LIKE '" & srch_txtbx.Text & "%'
                              OR tribe_name LIKE '" & srch_txtbx.Text & "%'"
                Dim cmd As New MySqlCommand(Qu, MySqlConn)
                MySqlDtAd.SelectCommand = cmd
                MySqlDtAd.Fill(DB_table)
                BinSouc.DataSource = DB_table
                ac_vst_wo_grid.DataSource = BinSouc
                MySqlDtAd.Update(DB_table)
                MySqlConn.Close()
            End If
            If pt_pno_rbtn.Checked = True Then
                MySqlConn.Open()
                Dim Qu As String = "SELECT id AS ID, civil_id AS CivilID, prefix as Prefix, CONCAT(first_name,' ', second_name,' ', third_name,' ', fourth_name,' ', tribe_name) AS Name
                            , phone_no AS PhoneNO, dob AS DoB, gender AS Gender, address AS Address, nationality AS Nationality, email AS Email
                            FROM mcms.patient
                            WHERE phone_no LIKE '" & srch_txtbx.Text & "%'"
                Dim cmd As New MySqlCommand(Qu, MySqlConn)
                MySqlDtAd.SelectCommand = cmd
                MySqlDtAd.Fill(DB_table)
                BinSouc.DataSource = DB_table
                ac_vst_wo_grid.DataSource = BinSouc
                MySqlDtAd.Update(DB_table)
                MySqlConn.Close()
            End If
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            MySqlConn.Dispose()
        End Try

    End Sub
    Private Sub ac_vst_wo_grid_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles ac_vst_wo_grid.CellClick
        without_actv_grbbx.Show()
        Try
            If e.RowIndex >= 0 Then
                Dim row As DataGridViewRow
                row = Me.ac_vst_wo_grid.Rows(e.RowIndex)
                without_actv_txtbx.Text = row.Cells("ID").Value
                pt_id = row.Cells("ID").Value
                pt_prfx = row.Cells("Prefix").Value.ToString
                pt_nm = row.Cells("Name").Value.ToString
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Public Sub ResetGridW()
        MySqlConn = New MySqlConnection
        MySqlConn.ConnectionString = GetConnString()

        DB_table2.Clear()

        Dim MySqlDtAd As New MySqlDataAdapter
        Dim BinSouc As New BindingSource

        Try
            MySqlConn.Open()
            Dim Qu As String = "SELECT appointment.id AS AptID,appointment.pt_id AS PtID, patient.civil_id AS CivilID
                            , patient.prefix as PatientPrefix, CONCAT(patient.first_name,' ', patient.second_name,' ', patient.tribe_name) AS PatientName                            
                            , patient.phone_no AS PhoneNO, patient.dob AS DoB, patient.gender AS Gender, patient.address AS Address, patient.nationality AS Nationality, patient.email AS Email
                            , appointment.doct_id AS DoctorID
                            , staff.prefix as DoctorPrefix, CONCAT(staff.first_name,' ', staff.second_name,' ', staff.tribe_name) AS DoctorName
                            , appointment.reason AS Reason , appointment.apt_time AS Appointment
                            FROM mcms.patient , mcms.appointment , mcms.staff
                            WHERE appointment.pt_id = patient.id 
                              AND appointment.doct_id = staff.id
                              AND appointment.apt_status = 'OnHold'
                            GROUP BY appointment.id
                            ORDER BY appointment.id"
            Dim cmd As New MySqlCommand(Qu, MySqlConn)
            MySqlDtAd.SelectCommand = cmd
            MySqlDtAd.Fill(DB_table2)
            BinSouc.DataSource = DB_table2
            ac_vst_w_grid.DataSource = BinSouc
            MySqlDtAd.Update(DB_table2)
            MySqlConn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            MySqlConn.Dispose()
        End Try
    End Sub
    Private Sub all_btn_Click(sender As Object, e As EventArgs) Handles all_btn.Click
        ResetGridW()
    End Sub

    Private Sub rst_today_btn_Click(sender As Object, e As EventArgs) Handles rst_today_btn.Click
        Dim from_am As String
        from_am = (Date.Today + " 00:00:00")
        frm_pkr.Text = from_am

        Dim from_pm As String
        from_pm = (Date.Today + " 23:59:59")
        to_pkr.Text = from_pm
    End Sub

    Private Sub srch_btn_Click(sender As Object, e As EventArgs) Handles srch_btn.Click
        MySqlConn = New MySqlConnection
        MySqlConn.ConnectionString = GetConnString()

        DB_table2.Clear()

        If apt_id_chkbx.Checked = False Then
            Dim MySqlDtAd As New MySqlDataAdapter
            Dim BinSouc As New BindingSource

            Try
                MySqlConn.Open()
                Dim Qu As String = "SELECT appointment.id AS AptID,appointment.pt_id AS PtID, patient.civil_id AS CivilID
                            , patient.prefix as PatientPrefix, CONCAT(patient.first_name,' ', patient.second_name,' ', patient.tribe_name) AS PatientName                            
                            , patient.phone_no AS PhoneNO, patient.dob AS DoB, patient.gender AS Gender, patient.address AS Address, patient.nationality AS Nationality, patient.email AS Email
                            , appointment.doct_id AS DoctorID
                            , staff.prefix as DoctorPrefix, CONCAT(staff.first_name,' ', staff.second_name,' ', staff.tribe_name) AS DoctorName
                            , appointment.reason AS Reason , appointment.apt_time AS Appointment
                            FROM mcms.patient , mcms.appointment , mcms.staff
                            WHERE appointment.pt_id = patient.id 
                              AND appointment.doct_id = staff.id
                              AND appointment.apt_status = 'OnHold'
                              AND appointment.apt_time BETWEEN '" & frm_pkr.Text & "%' AND '" & to_pkr.Text & "%'
                            GROUP BY appointment.id
                            ORDER BY appointment.id"
                Dim cmd As New MySqlCommand(Qu, MySqlConn)
                MySqlDtAd.SelectCommand = cmd
                MySqlDtAd.Fill(DB_table2)
                BinSouc.DataSource = DB_table2
                ac_vst_w_grid.DataSource = BinSouc
                MySqlDtAd.Update(DB_table2)
                MySqlConn.Close()
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            Finally
                MySqlConn.Dispose()
            End Try


        ElseIf apt_id_chkbx.Checked = True AndAlso String.IsNullOrWhiteSpace(apt_id_txtbx.Text) = False Then
            Dim MySqlDtAd As New MySqlDataAdapter
            Dim BinSouc As New BindingSource

            Try
                MySqlConn.Open()
                Dim Qu As String = "SELECT appointment.id AS AptID,appointment.pt_id AS PtID, patient.civil_id AS CivilID
                            , patient.prefix as PatientPrefix, CONCAT(patient.first_name,' ', patient.second_name,' ', patient.tribe_name) AS PatientName                            
                            , patient.phone_no AS PhoneNO, patient.dob AS DoB, patient.gender AS Gender, patient.address AS Address, patient.nationality AS Nationality, patient.email AS Email
                            , appointment.doct_id AS DoctorID
                            , staff.prefix as DoctorPrefix, CONCAT(staff.first_name,' ', staff.second_name,' ', staff.tribe_name) AS DoctorName
                            , appointment.reason AS Reason , appointment.apt_time AS Appointment
                            FROM mcms.patient , mcms.appointment , mcms.staff
                            WHERE appointment.pt_id = patient.id 
                              AND appointment.doct_id = staff.id
                              AND appointment.apt_status = 'OnHold'
                              AND appointment.id = '" & apt_id_txtbx.Text & "%'
                              AND appointment.apt_time BETWEEN '" & frm_pkr.Text & "%' AND '" & to_pkr.Text & "%'
                            GROUP BY appointment.id
                            ORDER BY appointment.id"
                Dim cmd As New MySqlCommand(Qu, MySqlConn)
                MySqlDtAd.SelectCommand = cmd
                MySqlDtAd.Fill(DB_table2)
                BinSouc.DataSource = DB_table2
                ac_vst_w_grid.DataSource = BinSouc
                MySqlDtAd.Update(DB_table2)
                MySqlConn.Close()
            Catch ex As MySqlException
                MessageBox.Show(ex.Message)
            Finally
                MySqlConn.Dispose()
            End Try
        End If

        If apt_id_chkbx.Checked = True AndAlso String.IsNullOrWhiteSpace(apt_id_txtbx.Text) = True Then
            MessageBox.Show("You have to fill the field with 'Apt ID' label, because the Check box is checked, please try again.", "Filling Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub
    Dim apt_id As Integer
    Private Sub ac_vst_w_grid_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles ac_vst_w_grid.CellClick
        with_actv_grbbx.Show()
        Try
            If e.RowIndex >= 0 Then
                Dim row As DataGridViewRow
                row = Me.ac_vst_w_grid.Rows(e.RowIndex)
                with_actv_txtbx.Text = row.Cells("PtID").Value
                pt_id = row.Cells("PtID").Value
                pt_prfx = row.Cells("PatientPrefix").Value.ToString
                pt_nm = row.Cells("PatientName").Value.ToString

                apt_id = row.Cells("AptID").Value

                prfDoc_id = row.Cells("DoctorID").Value.ToString
                prfDoc_prfx = row.Cells("DoctorPrefix").Value.ToString
                prfDoc_nm = row.Cells("DoctorName").Value.ToString
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub with_actv_btn_Click(sender As Object, e As EventArgs) Handles with_actv_btn.Click
        Dim actVstID As Integer
        MySqlConn = New MySqlConnection
        MySqlConn.ConnectionString = GetConnString()

        Dim rslt As Integer = MessageBox.Show("Are you sure that you want to activate this patient's file :
" & pt_prfx & "." & pt_nm & " with ID : " & pt_id & "
With " & prfDoc_prfx & "." & prfDoc_nm & "?", "Confirmation!", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)
        If rslt = DialogResult.Yes Then
            'Update
            Try
                MySqlConn.Open()
                Dim Qu As String = "UPDATE mcms.patient SET file_state='Active' WHERE id='" & with_actv_txtbx.Text & "'"
                Dim cmd As New MySqlCommand(Qu, MySqlConn)
                Dim rdr As MySqlDataReader = cmd.ExecuteReader
                ResetGridWO()
                MySqlConn.Close()
                'SendToLogs
                MySqlConn.Open()
                Dim Qu2 As String = "INSERT INTO mcms.logs (who, when_tm, what, where_nm, where_ip) 
                                                    VALUES ('" & M_id & "', now(), 'PT" & with_actv_txtbx.Text & " APT ACTV WITH DCT" & prfDoc_id & "', '" & M_pc_nm & "', '" & M_pc_ip & "');"
                Dim cmd2 = New MySqlCommand(Qu2, MySqlConn)
                Dim rdr2 As MySqlDataReader = cmd2.ExecuteReader
                MySqlConn.Close()
                'Startup the active visit
                MySqlConn.Open()
                Dim Qu3 As String = "INSERT INTO mcms.active_visit (pt_id, rec_id, doct_id, from_tm) VALUES ('" & with_actv_txtbx.Text & "', '" & prfDoc_id & "', '" & M_id & "', now());"
                Dim cmd3 = New MySqlCommand(Qu3, MySqlConn)
                Dim rdr3 As MySqlDataReader = cmd3.ExecuteReader
                MySqlConn.Close()
                with_actv_grbbx.Hide()
                ResetGridW()
                'Get actVstID
                MySqlConn.Open()
                Dim Qu4 As String = "SELECT * FROM mcms.active_visit WHERE pt_id='" & with_actv_txtbx.Text & "' AND from_tm > DATE_SUB(now(), INTERVAL 1 MINUTE)"
                Dim cmd4 = New MySqlCommand(Qu4, MySqlConn)
                Dim rdr4 As MySqlDataReader = cmd4.ExecuteReader
                While rdr4.Read
                    actVstID = rdr4.GetInt32("id")
                End While
                MySqlConn.Close()
                'SendToQ
                MySqlConn.Open()
                Dim Qu5 As String = "INSERT INTO mcms.pt_queue (pt_id, apt_state, q_state, remedy_state, ariv_time, actv_vst_id, apt_id)
                                                            VALUES ('" & with_actv_txtbx.Text & "', 'With', 'Waiting', 'Not Recived', now(), '" & actVstID & "', '" & apt_id & "');"
                Dim cmd5 = New MySqlCommand(Qu5, MySqlConn)
                Dim rdr5 As MySqlDataReader = cmd5.ExecuteReader
                MySqlConn.Close()
                'Update Apt Status
                MySqlConn.Open()
                Dim Qu6 As String = "UPDATE mcms.appointment SET apt_status='Active' "
                Dim cmd6 = New MySqlCommand(Qu6, MySqlConn)
                Dim rdr6 As MySqlDataReader = cmd6.ExecuteReader
                MySqlConn.Close()
            Catch ex As MySqlException
                MessageBox.Show(ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        Else
            with_actv_grbbx.Hide()
            ResetGridW()
        End If
    End Sub
End Class