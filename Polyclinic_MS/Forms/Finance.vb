Imports MySql.Data.MySqlClient
Public Class Finance
    Dim mysqlconn As MySqlConnection
    Dim DB_tablePT As New DataTable

    Dim fltr As String

    Dim for_whom As Integer
    Dim for_whom_nm As String
    Public Sub ResetGridPT()
        mysqlconn = New MySqlConnection
        mysqlconn.ConnectionString = GetConnString()

        DB_tablePT.Clear()

        Dim MySqlDtAd As New MySqlDataAdapter
        Dim BinSouc As New BindingSource

        Try
            mysqlconn.Open()
            Dim Qu As String = "SELECT payment.id AS ID
                                     , payment.by_whom AS StaffID, CONCAT(staff.first_name,' ', staff.second_name,' ', staff.third_name,' ', staff.fourth_name,' ', staff.tribe_name) AS StaffName
                                     , payment.for_whom AS PtID, patient.civil_id AS PtCivilID, CONCAT(patient.first_name,' ', patient.second_name,' ', patient.third_name,' ', patient.fourth_name,' ', patient.tribe_name) AS PatientName
                                     , patient.phone_no AS PtPhoneNO, payment.fee_type AS FeeType, payment.fee AS Fee, payment.com_time AS CommitTime, payment.pay_time AS PayTime, payment.pay_status AS Status
                                  FROM mcms.payment, mcms.staff, mcms.patient
                                 WHERE  payment.by_whom = staff.id
                                    AND payment.for_whom = patient.id 
                                    GROUP BY payment.id
                                    ORDER BY payment.com_time"
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

    Private Sub srch_txtbx_TextChanged(sender As Object, e As EventArgs) Handles srch_txtbx.TextChanged
        mysqlconn = New MySqlConnection
        mysqlconn.ConnectionString = GetConnString()
        DB_tablePT.Clear()
        Dim MySqlDtAd As New MySqlDataAdapter
        Dim BinSouc As New BindingSource
        Try
            If pt_nm_rbtn.Checked = False Then
                mysqlconn.Open()
                Dim Qu As String = "SELECT payment.id AS ID
                                     , payment.by_whom AS StaffID, CONCAT(staff.first_name,' ', staff.second_name,' ', staff.third_name,' ', staff.fourth_name,' ', staff.tribe_name) AS StaffName
                                     , payment.for_whom AS PtID, patient.civil_id AS PtCivilID, CONCAT(patient.first_name,' ', patient.second_name,' ', patient.third_name,' ', patient.fourth_name,' ', patient.tribe_name) AS PatientName
                                     , patient.phone_no AS PtPhoneNO, payment.fee_type AS FeeType, payment.fee AS Fee, payment.com_time AS CommitTime, payment.pay_time AS PayTime, payment.pay_status AS Status
                                  FROM mcms.payment, mcms.staff, mcms.patient
                                 WHERE  payment.by_whom = staff.id
                                    AND payment.for_whom = patient.id 
                                    AND payment.pay_status = '" & status_combbx.Text & "'
                                    AND " & fltr & "'" & srch_txtbx.Text & "'
                                    GROUP BY payment.id
                                    ORDER BY payment.com_time"
                Dim cmd As New MySqlCommand(Qu, mysqlconn)
                MySqlDtAd.SelectCommand = cmd
                MySqlDtAd.Fill(DB_tablePT)
                BinSouc.DataSource = DB_tablePT
                pt_grid.DataSource = BinSouc
                MySqlDtAd.Update(DB_tablePT)
                mysqlconn.Close()
            ElseIf pt_nm_rbtn.Checked = True Then
                mysqlconn.Open()
                Dim Qu As String = "SELECT payment.id AS ID
                                     , payment.by_whom AS StaffID, CONCAT(staff.first_name,' ', staff.second_name,' ', staff.third_name,' ', staff.fourth_name,' ', staff.tribe_name) AS StaffName
                                     , payment.for_whom AS PtID, patient.civil_id AS PtCivilID, CONCAT(patient.first_name,' ', patient.second_name,' ', patient.third_name,' ', patient.fourth_name,' ', patient.tribe_name) AS PatientName
                                     , patient.phone_no AS PtPhoneNO, payment.fee_type AS FeeType, payment.fee AS Fee, payment.com_time AS CommitTime, payment.pay_time AS PayTime, payment.pay_status AS Status
                                  FROM mcms.payment, mcms.staff, mcms.patient
                                 WHERE  payment.by_whom = staff.id
                                    AND payment.for_whom = patient.id 
                                    AND payment.pay_status = '" & status_combbx.Text & "'
                                    AND patient.first_name LIKE '" & srch_txtbx.Text & "%'
                                   OR patient.second_name LIKE '" & srch_txtbx.Text & "%'
                                   OR patient.third_name LIKE '" & srch_txtbx.Text & "%'
                                   OR patient.tribe_name LIKE '" & srch_txtbx.Text & "%'
                                    GROUP BY payment.id
                                    ORDER BY payment.com_time"

                Dim cmd As New MySqlCommand(Qu, mysqlconn)
                MySqlDtAd.SelectCommand = cmd
                MySqlDtAd.Fill(DB_tablePT)
                BinSouc.DataSource = DB_tablePT
                pt_grid.DataSource = BinSouc
                MySqlDtAd.Update(DB_tablePT)
                mysqlconn.Close()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            mysqlconn.Dispose()
        End Try
    End Sub

    Private Sub pt_id_rbtn_CheckedChanged(sender As Object, e As EventArgs) Handles pt_id_rbtn.CheckedChanged
        fltr = "patient.id ="
    End Sub

    Private Sub pt_cvl_id_rbtn_CheckedChanged(sender As Object, e As EventArgs) Handles pt_cvl_id_rbtn.CheckedChanged
        fltr = "patient.civil_id LIKE"
    End Sub

    Private Sub pt_pno_rbtn_CheckedChanged(sender As Object, e As EventArgs) Handles pt_pno_rbtn.CheckedChanged
        fltr = "patient.phone_no LIKE"
    End Sub

    Private Sub Finance_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        status_combbx.Text = "Unpayed"
        pt_pno_rbtn.Checked = True
        curncy_combobox.Text = "OR."
    End Sub

    Private Sub curncy_combobox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles curncy_combobox.SelectedIndexChanged
        Try
            If String.IsNullOrWhiteSpace(total_txtbx.Text) = False Then
                If curncy_combobox.Text = "AED" Then
                    total_txtbx.Text = total_txtbx.Text * 9.5
                Else
                    total_txtbx.Text = total_txtbx.Text / 9.5
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub rst_tbl_btn_Click(sender As Object, e As EventArgs) Handles rst_tbl_btn.Click
        ResetGridPT()
    End Sub

    Private Sub pt_grid_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles pt_grid.CellClick
        mysqlconn = New MySqlConnection
        mysqlconn.ConnectionString = GetConnString()
        Try
            If e.RowIndex >= 0 Then
                Dim row As DataGridViewRow
                row = Me.pt_grid.Rows(e.RowIndex)
                If fees_lstbx.Items.Contains(row.Cells("ID").Value.ToString) Then
                    MessageBox.Show("You can't a payment to the list more then ones, please try again", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Else
                    fees_lstbx.Items.Add(row.Cells("ID").Value.ToString)
                End If
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            mysqlconn.Dispose()
        End Try
    End Sub

    Private Sub fees_lstbx_SelectedIndexChanged(sender As Object, e As EventArgs) Handles fees_lstbx.SelectedIndexChanged
        mysqlconn = New MySqlConnection
        mysqlconn.ConnectionString = GetConnString()

        Try
            mysqlconn.Open()
            Dim Qu As String = "SELECT payment.*, CONCAT(staff.first_name,' ', staff.second_name,' ', staff.third_name,' ', staff.fourth_name,' ', staff.tribe_name) AS StaffName
                                                , CONCAT(patient.first_name,' ', patient.second_name,' ', patient.third_name,' ', patient.fourth_name,' ', patient.tribe_name) AS PatientName
                                FROM mcms.payment, mcms.staff, mcms.patient
                                WHERE payment.id = '" & fees_lstbx.Text & "'
                                  AND payment.for_whom = patient.id
                                  AND  payment.by_whom = staff.id"
            Dim cmd As New MySqlCommand(Qu, mysqlconn)
            Dim rdr As MySqlDataReader = cmd.ExecuteReader
            While rdr.Read
                py_id_txtbx.Text = rdr.GetInt32("id")

                usr_id_txtbx.Text = rdr.GetInt32("by_whom")
                usr_name_txtbx.Text = rdr.GetString("StaffName")

                payee_id_txtbx.Text = rdr.GetInt32("for_whom")
                for_whom = rdr.GetInt32("for_whom")
                payee_name_txtbx.Text = rdr.GetString("PatientName")
                for_whom_nm = rdr.GetString("PatientName")

                fee_type_txtbx.Text = rdr.GetString("fee_type")
                fee_txtbx.Text = rdr.GetDouble("fee")
                com_time_txtbx.Text = rdr.GetString("com_time")

                pay_status_txtbx.Text = rdr.GetString("pay_status")
                If pay_status_txtbx.Text = "Payed" Then
                    pay_time_txtbx.Text = rdr.GetDateTime("pay_time")
                End If
            End While
            mysqlconn.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            mysqlconn.Dispose()
        End Try
    End Sub

    Private Sub exe_py_btn_Click(sender As Object, e As EventArgs) Handles exe_py_btn.Click
        mysqlconn = New MySqlConnection
        mysqlconn.ConnectionString = GetConnString()

        Dim rcrdCount As Integer
        Dim fee As Double
        Dim totalFee As Double

        Try
            For lstIndx As Integer = 0 To fees_lstbx.Items.Count - 1
                mysqlconn.Open()
                Dim Qu2 As String = "SELECT *
                                       FROM mcms.payment
                                       where id = '" & fees_lstbx.Items(lstIndx) & "' "

                Dim cmd2 As New MySqlCommand(Qu2, mysqlconn)
                Dim rdr2 As MySqlDataReader = cmd2.ExecuteReader
                While rdr2.Read
                    fee = rdr2.GetDouble("fee")
                End While
                mysqlconn.Close()

                rcrdCount = rcrdCount + 1
                totalFee = totalFee + fee
            Next
            pay_count_txtbx.Text = rcrdCount
            total_txtbx.Text = totalFee
        Catch ex As MySqlException
            MessageBox.Show(ex.Message, "1 Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "2 Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            mysqlconn.Dispose()


        End Try
    End Sub

    Private Sub rmv_frm_lst_btn_Click(sender As Object, e As EventArgs) Handles rmv_frm_lst_btn.Click
        fees_lstbx.Items.Remove(fees_lstbx.SelectedItem)
    End Sub

    Private Sub clr_lst_btn_Click(sender As Object, e As EventArgs) Handles clr_lst_btn.Click
        fees_lstbx.Items.Clear()
    End Sub

    Private Sub pay_btn_Click(sender As Object, e As EventArgs) Handles pay_btn.Click
        mysqlconn = New MySqlConnection
        mysqlconn.ConnectionString = GetConnString()

        Dim rslt As Integer = MessageBox.Show("Are you sure that you want to execute the payment of " & total_txtbx.Text & " " & curncy_combobox.Text & " for PT" & for_whom & " : " & for_whom_nm & " ?", "Confirmation!", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)
        If rslt = DialogResult.Yes Then
            For lstIndx As Integer = 0 To fees_lstbx.Items.Count - 1
                'SendToLogs
                mysqlconn.Open()
                Dim Qu2 As String = "INSERT INTO mcms.logs (who, when_tm, what, where_nm, where_ip) 
                                                    VALUES ('" & M_id & "', now(), 'PYMNT" & fees_lstbx.Items(lstIndx) & " CMPLTD ', '" & M_pc_nm & "', '" & M_pc_ip & "');"
                Dim cmd2 = New MySqlCommand(Qu2, mysqlconn)
                Dim rdr2 As MySqlDataReader = cmd2.ExecuteReader
                mysqlconn.Close()
                'Pay
                mysqlconn.Open()
                Dim Qu5 As String = "UPDATE mcms.payment SET pay_status='Payed', pay_time=now() WHERE id='" & fees_lstbx.Items(lstIndx) & "' "
                Dim cmd5 As New MySqlCommand(Qu5, mysqlconn)
                Dim rdr5 As MySqlDataReader = cmd5.ExecuteReader
                mysqlconn.Close()
            Next

            Dim ctrl As Control
            For Each ctrl In pymnt_inf_grbbx.Controls
                If TypeOf ctrl Is TextBox Then
                    ctrl.Text = Nothing
                End If
            Next
            fees_lstbx.Items.Clear()
            Dim ctrl2 As Control
            For Each ctrl2 In fee_inf_grbbx.Controls
                If TypeOf ctrl2 Is TextBox Then
                    ctrl2.Text = Nothing
                End If
            Next
            ResetGridPT()
        End If
    End Sub
End Class