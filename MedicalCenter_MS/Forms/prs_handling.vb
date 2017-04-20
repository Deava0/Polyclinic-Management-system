Imports MySql.Data.MySqlClient
Public Class prs_handling
    Dim mysqlconn As MySqlConnection
    Dim DB_tableMDCN As New DataTable
    Dim DB_tablePT As New DataTable

    Dim ActVstID As Integer

    Public Sub ResetGridMDCN()
        mysqlconn = New MySqlConnection
        mysqlconn.ConnectionString = GetConnString()

        DB_tableMDCN.Clear()

        Dim MySqlDtAd As New MySqlDataAdapter
        Dim BinSouc As New BindingSource

        Try
            mysqlconn.Open()
            Dim Qu As String = "SELECT id AS ID, name AS Name, Type AS Type, qt AS Qt, price AS Price, manu_date AS ManufacturerDate, exp_date AS ExperationDate
                                    FROM mcms.pharma"
            Dim cmd As New MySqlCommand(Qu, mysqlconn)
            MySqlDtAd.SelectCommand = cmd
            MySqlDtAd.Fill(DB_tableMDCN)
            BinSouc.DataSource = DB_tableMDCN
            mdcn_grid.DataSource = BinSouc
            MySqlDtAd.Update(DB_tableMDCN)

            mysqlconn.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            mysqlconn.Dispose()
        End Try
    End Sub

    Public Sub ResetGridPT()
        mysqlconn = New MySqlConnection
        mysqlconn.ConnectionString = GetConnString()

        DB_tablePT.Clear()

        Dim MySqlDtAd As New MySqlDataAdapter
        Dim BinSouc As New BindingSource

        Try
            mysqlconn.Open()
            Dim Qu As String = "SELECT active_visit.id AS ActvID 
                                     , active_visit.pt_id AS PtID, patient.civil_id AS CivilID, CONCAT(patient.first_name,' ', patient.second_name,' ', patient.third_name,' ', patient.fourth_name,' ', patient.tribe_name) AS PtName
                                     , patient.phone_no AS PhoneNO
                                     , active_visit.doct_id AS DoctID, CONCAT(staff.first_name,' ', staff.second_name,' ', staff.third_name,' ', staff.fourth_name,' ', staff.tribe_name) AS DoctName
                                     , active_visit.pres AS Prescription, active_visit.remedy_state AS RemedyStatus, active_visit.diag_end_tm AS DiagnosisEndTime
                                FROM mcms.active_visit, mcms.patient, mcms.staff
                                WHERE  active_visit.pt_id = patient.id
                                  AND  active_visit.doct_id = staff.id
                                  AND  active_visit.remedy_state = 'Internal'
                                GROUP BY active_visit.id
                                ORDER BY active_visit.diag_end_tm"
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
    Private Sub fltr_btn_Click(sender As Object, e As EventArgs) Handles fltr_btn.Click
        mysqlconn = New MySqlConnection
        mysqlconn.ConnectionString = GetConnString()


        Dim MySqlDtAd As New MySqlDataAdapter
        Dim BinSouc As New BindingSource

        If fltr_by_dt_chkbx.Checked = False AndAlso mdcn_nm_chkbx.Checked = False Then
            ResetGridMDCN()
        End If

        If fltr_by_dt_chkbx.Checked = True Then
            Try
                mysqlconn.Open()
                Dim Qu As String = "SELECT id AS ID, name AS Name, Type AS Type, qt AS Qt, price AS Price, manu_date AS ManufacturerDate, exp_date AS Experation Date
                                    FROM mcms.pharma
                                    WHERE manu_date BETWEEN '" & mod_manu_frm_pkr.Text & "' AND '" & mod_manu_to_pkr.Text & "'
                                      AMD exp_date BETWEEN '" & mod_exp_frm_pkr.Text & "' AND '" & mod_exp_to_pkr.Text & "' "
                Dim cmd As New MySqlCommand(Qu, mysqlconn)
                MySqlDtAd.SelectCommand = cmd
                MySqlDtAd.Fill(DB_tableMDCN)
                BinSouc.DataSource = DB_tableMDCN
                mdcn_grid.DataSource = BinSouc
                MySqlDtAd.Update(DB_tableMDCN)

                mysqlconn.Close()
            Catch ex As MySqlException
                MessageBox.Show(ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
                mysqlconn.Dispose()
            End Try
        End If

        If mdcn_nm_chkbx.Checked = True Then
            Try
                mysqlconn.Open()
                Dim Qu As String = "SELECT id AS ID, name AS Name, Type AS Type, qt AS Qt, price AS Price, manu_date AS ManufacturerDate, exp_date AS ExperationDate
                                    FROM mcms.pharma
                                    WHERE name LIKE '" & mdcn_nm_txtbx.Text & "%' "
                Dim cmd As New MySqlCommand(Qu, mysqlconn)
                MySqlDtAd.SelectCommand = cmd
                MySqlDtAd.Fill(DB_tableMDCN)
                BinSouc.DataSource = DB_tableMDCN
                mdcn_grid.DataSource = BinSouc
                MySqlDtAd.Update(DB_tableMDCN)

                mysqlconn.Close()
            Catch ex As MySqlException
                MessageBox.Show(ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
                mysqlconn.Dispose()
            End Try
        End If
    End Sub

    Private Sub srch_txtbx_TextChanged(sender As Object, e As EventArgs) Handles srch_txtbx.TextChanged
        mysqlconn = New MySqlConnection
        mysqlconn.ConnectionString = GetConnString()

        Dim MySqlDtAd As New MySqlDataAdapter
        Dim BinSouc As New BindingSource
        DB_tablePT.Clear()

        Try
            If pt_id_rbtn.Checked = True Then
                mysqlconn.Open()
                Dim Qu As String = "SELECT active_visit.id AS ActvID 
                                     , active_visit.pt_id AS PtID, patient.civil_id AS CivilID, CONCAT(patient.first_name,' ', patient.second_name,' ', patient.third_name,' ', patient.fourth_name,' ', patient.tribe_name) AS PtName
                                     , patient.phone_no AS PhoneNO
                                     , active_visit.doct_id AS DoctID, CONCAT(staff.first_name,' ', staff.second_name,' ', staff.third_name,' ', staff.fourth_name,' ', staff.tribe_name) AS DoctName
                                     , active_visit.pres AS Prescription, active_visit.remedy_state AS RemedyStatus, active_visit.diag_end_tm AS DiagnosisEndTime
                                FROM mcms.active_visit, mcms.patient, mcms.staff
                                WHERE  active_visit.pt_id = patient.id
                                  AND  active_visit.doct_id = staff.id
                                  AND  active_visit.remedy_state = 'Internal'
                                  AND  active_visit.pt_id  = '" & srch_txtbx.Text & "%'
                                GROUP BY active_visit.id
                                ORDER BY active_visit.diag_end_tm"
                Dim cmd As New MySqlCommand(Qu, mysqlconn)
                MySqlDtAd.SelectCommand = cmd
                MySqlDtAd.Fill(DB_tablePT)
                BinSouc.DataSource = DB_tablePT
                pt_grid.DataSource = BinSouc
                MySqlDtAd.Update(DB_tablePT)
                mysqlconn.Close()
            End If
            If pt_cvl_id_rbtn.Checked = True Then
                mysqlconn.Open()
                Dim Qu As String = "SELECT active_visit.id AS ActvID 
                                     , active_visit.pt_id AS PtID, patient.civil_id AS CivilID, CONCAT(patient.first_name,' ', patient.second_name,' ', patient.third_name,' ', patient.fourth_name,' ', patient.tribe_name) AS PtName
                                     , patient.phone_no AS PhoneNO
                                     , active_visit.doct_id AS DoctID, CONCAT(staff.first_name,' ', staff.second_name,' ', staff.third_name,' ', staff.fourth_name,' ', staff.tribe_name) AS DoctName
                                     , active_visit.pres AS Prescription, active_visit.remedy_state AS RemedyStatus, active_visit.diag_end_tm AS DiagnosisEndTime
                                FROM mcms.active_visit, mcms.patient, mcms.staff
                                WHERE  active_visit.pt_id = patient.id
                                  AND  active_visit.doct_id = staff.id
                                  AND  active_visit.remedy_state = 'Internal'
                                  AND  patient.civil_id LIKE '" & srch_txtbx.Text & "%'
                                GROUP BY active_visit.id
                                ORDER BY active_visit.diag_end_tm"
                Dim cmd As New MySqlCommand(Qu, mysqlconn)
                MySqlDtAd.SelectCommand = cmd
                MySqlDtAd.Fill(DB_tablePT)
                BinSouc.DataSource = DB_tablePT
                pt_grid.DataSource = BinSouc
                MySqlDtAd.Update(DB_tablePT)
                mysqlconn.Close()
            End If
            If pt_nm_rbtn.Checked = True Then
                mysqlconn.Open()
                Dim Qu As String = "SELECT active_visit.id AS ActvID 
                                     , active_visit.pt_id AS PtID, patient.civil_id AS CivilID, CONCAT(patient.first_name,' ', patient.second_name,' ', patient.third_name,' ', patient.fourth_name,' ', patient.tribe_name) AS PtName
                                     , patient.phone_no AS PhoneNO
                                     , active_visit.doct_id AS DoctID, CONCAT(staff.first_name,' ', staff.second_name,' ', staff.third_name,' ', staff.fourth_name,' ', staff.tribe_name) AS DoctName
                                     , active_visit.pres AS Prescription, active_visit.remedy_state AS RemedyStatus, active_visit.diag_end_tm AS DiagnosisEndTime
                                FROM mcms.active_visit, mcms.patient, mcms.staff
                                WHERE  active_visit.pt_id = patient.id
                                  AND  active_visit.doct_id = staff.id
                                  AND  active_visit.remedy_state = 'Internal'
                                  AND patient.first_name LIKE '" & srch_txtbx.Text & "%'
                                   OR patient.second_name LIKE '" & srch_txtbx.Text & "%'
                                   OR patient.third_name LIKE '" & srch_txtbx.Text & "%'
                                   OR patient.tribe_name LIKE '" & srch_txtbx.Text & "%'
                                 GROUP BY active_visit.id
                                 ORDER BY active_visit.diag_end_tm"
                Dim cmd As New MySqlCommand(Qu, mysqlconn)
                MySqlDtAd.SelectCommand = cmd
                MySqlDtAd.Fill(DB_tablePT)
                BinSouc.DataSource = DB_tablePT
                pt_grid.DataSource = BinSouc
                MySqlDtAd.Update(DB_tablePT)
                mysqlconn.Close()
            End If
            If pt_pno_rbtn.Checked = True Then
                mysqlconn.Open()
                Dim Qu As String = "SELECT active_visit.id AS ActvID 
                                     , active_visit.pt_id AS PtID, patient.civil_id AS CivilID, CONCAT(patient.first_name,' ', patient.second_name,' ', patient.third_name,' ', patient.fourth_name,' ', patient.tribe_name) AS PtName
                                     , patient.phone_no AS PhoneNO
                                     , active_visit.doct_id AS DoctID, CONCAT(staff.first_name,' ', staff.second_name,' ', staff.third_name,' ', staff.fourth_name,' ', staff.tribe_name) AS DoctName
                                     , active_visit.pres AS Prescription, active_visit.remedy_state AS RemedyStatus, active_visit.diag_end_tm AS DiagnosisEndTime
                                FROM mcms.active_visit, mcms.patient, mcms.staff
                                WHERE  active_visit.pt_id = patient.id
                                  AND  active_visit.doct_id = staff.id
                                  AND  active_visit.remedy_state = 'Internal'
                                  AND patient.phone_no LIKE '" & srch_txtbx.Text & "%'
                                 GROUP BY active_visit.id
                                 ORDER BY active_visit.diag_end_tm"
                Dim cmd As New MySqlCommand(Qu, mysqlconn)
                MySqlDtAd.SelectCommand = cmd
                MySqlDtAd.Fill(DB_tablePT)
                BinSouc.DataSource = DB_tablePT
                pt_grid.DataSource = BinSouc
                MySqlDtAd.Update(DB_tablePT)
                mysqlconn.Close()
            End If
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            mysqlconn.Dispose()
        End Try
    End Sub

    Private Sub rst_tbl_btn_Click(sender As Object, e As EventArgs) Handles rst_tbl_btn.Click
        ResetGridPT()
    End Sub

    Private Sub pt_grid_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles pt_grid.CellClick
        Try
            If e.RowIndex >= 0 Then
                Dim row As DataGridViewRow
                row = Me.pt_grid.Rows(e.RowIndex)
                ActVstID = row.Cells("ActvID").Value
                add_avtv_pt_id_txtbx.Text = row.Cells("PtID").Value
                add_avtv_pt_cvl_id_txtbx.Text = row.Cells("CivilID").Value
                add_avtv_pt_nm_txtbx.Text = row.Cells("PtName").Value.ToString

                dr_id_txtbx.Text = row.Cells("DoctID").Value
                dr_nm_txtbx.Text = row.Cells("DoctName").Value.ToString
                add_prsc_rtxtbx.Text = row.Cells("Prescription").Value.ToString
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


    Private Sub mdcn_grid_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles mdcn_grid.CellClick
        Try
            If e.RowIndex >= 0 Then
                Dim row As DataGridViewRow
                row = Me.mdcn_grid.Rows(e.RowIndex)
                mdcn_lstbx.Items.Add(row.Cells("ID").Value.ToString)
                '  mdcn_lstbx.Items.Add("[" & ListCount & "] ID" & mdcn_id & " : " & mdcn_name)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub hnd_ovr_btn_Click(sender As Object, e As EventArgs) Handles hnd_ovr_btn.Click
        mysqlconn = New MySqlConnection
        mysqlconn.ConnectionString = GetConnString()

        Dim totalFees As Double
        Dim mdcnPrice As Double
        Dim mdcnQT As Integer

        Dim rslt As Integer = MessageBox.Show("Are you sure that you want to hand over the listed medicines to " & add_avtv_pt_nm_txtbx.Text & " with ID:" & add_avtv_pt_id_txtbx.Text & " ?", "Confirmation!", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)
        If rslt = DialogResult.Yes Then
            Try
                For lstIndx As Integer = 0 To mdcn_lstbx.Items.Count - 1

                    'SendToReleasedMECN
                    mysqlconn.Open()
                    Dim Qu As String = "INSERT INTO mcms.released_mdcn (actv_vst_id, pt_id, mdcn_id, pharm_id, rel_time) VALUES ('" & ActVstID & "', '" & add_avtv_pt_id_txtbx.Text & "', '" & mdcn_lstbx.Items(lstIndx) & "'
                                                                   , '" & M_id & "', now());"
                    Dim cmd As New MySqlCommand(Qu, mysqlconn)
                    Dim rdr As MySqlDataReader = cmd.ExecuteReader
                    mysqlconn.Close()
                    'SendToLogs
                    mysqlconn.Open()
                    Dim Qu2 As String = "INSERT INTO mcms.logs (who, when_tm, what, where_nm, where_ip) 
                                                    VALUES ('" & M_id & "', now(), 'PT" & add_avtv_pt_id_txtbx.Text & " VST ENDED(INTERNAL) ', '" & M_pc_nm & "', '" & M_pc_ip & "');"
                    Dim cmd2 = New MySqlCommand(Qu2, mysqlconn)
                    Dim rdr2 As MySqlDataReader = cmd2.ExecuteReader
                    mysqlconn.Close()
                    'Mark PT vst as finished/ mdcn recived
                    mysqlconn.Open()
                    Dim Qu3 As String = "Update mcms.active_visit SET remedy_state = 'Received', to_tm=now() WHERE id='" & add_avtv_pt_id_txtbx.Text & "' "
                    Dim cmd3 = New MySqlCommand(Qu3, mysqlconn)
                    Dim rdr3 As MySqlDataReader = cmd3.ExecuteReader
                    mysqlconn.Close()
                    'Get mdcn price and qt
                    mysqlconn.Open()
                    Dim Qu4 As String = "SELECT id, price, qt
                                         FROM mcms.pharma
                                         WHERE id = '" & mdcn_lstbx.Items(lstIndx) & "'"
                    Dim cmd4 As New MySqlCommand(Qu4, mysqlconn)
                    Dim rdr4 As MySqlDataReader = cmd4.ExecuteReader

                    While rdr4.Read
                        mdcnPrice = rdr4.GetDouble("price")
                        mdcnQT = rdr4.GetInt32("qt")
                    End While
                    mysqlconn.Close()
                    'payment
                    mysqlconn.Open()
                    Dim Qu5 As String = "INSERT INTO mcms.payment (by_whom, for_whom, fee_type, fee, com_time) 
                                                               VALUES ('" & M_id & "', '" & add_avtv_pt_id_txtbx.Text & "', 'MDCN" & mdcn_lstbx.Items(lstIndx) & " FEE', '" & mdcnPrice & "', now());"
                    Dim cmd5 As New MySqlCommand(Qu5, mysqlconn)
                    Dim rdr5 As MySqlDataReader = cmd5.ExecuteReader
                    mysqlconn.Close()
                    'Update MDCN Qt
                    mysqlconn.Open()
                    Dim Qu6 As String = "UPDATE mcms.pharma SET qt= '" & mdcnQT - 1 & "'
                                         WHERE id = '" & mdcn_lstbx.Items(lstIndx) & "'"
                    Dim cmd6 As New MySqlCommand(Qu6, mysqlconn)
                    Dim rdr6 As MySqlDataReader = cmd6.ExecuteReader
                    mysqlconn.Close()
                    'Delete Position in Q
                    mysqlconn.Open()
                    Dim Qu8 As String = "DELETE FROM mcms.pt_queue WHERE actv_vst_id='" & ActVstID & "' "
                    Dim cmd8 = New MySqlCommand(Qu8, mysqlconn)
                    Dim rdr8 As MySqlDataReader = cmd8.ExecuteReader
                    mysqlconn.Close()

                    totalFees = totalFees + mdcnPrice
                Next


                'CloseDownPtFile
                mysqlconn.Open()
                Dim Qu7 As String = "UPDATE mcms.patient SET file_state = 'Inactive'
                                                  WHERE id = '" & add_avtv_pt_id_txtbx.Text & "'"
                Dim cmd7 As New MySqlCommand(Qu7, mysqlconn)
                Dim rdr7 As MySqlDataReader = cmd7.ExecuteReader
                mysqlconn.Close()
                MessageBox.Show("Total fees for all received Medicine is " & totalFees & "OR?", "Confirmation!", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Catch ex As MySqlException
                MessageBox.Show(ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
                mysqlconn.Dispose()
            End Try
        End If
    End Sub

    Private Sub mdcn_lstbx_SelectedIndexChanged(sender As Object, e As EventArgs) Handles mdcn_lstbx.SelectedIndexChanged
        mysqlconn = New MySqlConnection
        mysqlconn.ConnectionString = GetConnString()

        Try
            mysqlconn.Open()
            Dim Qu As String = "SELECT *
                                FROM mcms.pharma
                                WHERE id = '" & mdcn_lstbx.Text & "' "
            Dim cmd As New MySqlCommand(Qu, mysqlconn)
            Dim rdr As MySqlDataReader = cmd.ExecuteReader
            While rdr.Read
                mod_mdcn_id_txtbx.Text = rdr.GetInt32("id")
                mod_mdcn_nm_txtbx.Text = rdr.GetString("name")
                mod_mdcn_type_txtbx.Text = rdr.GetString("type")
                mod_mdcn_qt_txtbx.Text = rdr.GetString("qt")
                mod_manu_dt_txtbx.Text = rdr.GetString("manu_date")
                mod_exp_dt_txtbx.Text = rdr.GetString("exp_date")
                mod_price_txtbx.Text = rdr.GetString("price")
            End While
            mysqlconn.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            mysqlconn.Dispose()
        End Try
    End Sub

    Private Sub rmv_frm_lst_btn_Click(sender As Object, e As EventArgs) Handles rmv_frm_lst_btn.Click
        mdcn_lstbx.Items.Remove(mdcn_lstbx.SelectedItem)
    End Sub

    Private Sub prs_handling_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class