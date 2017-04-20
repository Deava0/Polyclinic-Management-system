Imports MySql.Data.MySqlClient
Public Class pharm
    Dim mysqlconn As MySqlConnection
    Dim DB_table As New DataTable

    Public Sub ResetGrid()
        mysqlconn = New MySqlConnection
        mysqlconn.ConnectionString = GetConnString()
        DB_table.Clear()
        Dim MySqlDtAd As New MySqlDataAdapter
        Dim BinSouc As New BindingSource

        Try
            mysqlconn.Open()
            Dim Qu As String = "SELECT id AS ID, name AS Name, Type AS Type, qt AS Qt, price AS Price, manu_date AS ManufacturerDate, exp_date AS ExperationDate
                                    FROM mcms.pharma"
            Dim cmd As New MySqlCommand(Qu, mysqlconn)
            MySqlDtAd.SelectCommand = cmd
            MySqlDtAd.Fill(DB_table)
            BinSouc.DataSource = DB_table
            mdcn_grid.DataSource = BinSouc
            MySqlDtAd.Update(DB_table)

            mysqlconn.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            mysqlconn.Dispose()
        End Try
    End Sub

    Private Sub sbmt_btn_Click(sender As Object, e As EventArgs) Handles sbmt_btn.Click
        Dim mysqlconn As New MySqlConnection
        mysqlconn.ConnectionString = GetConnString()

        If AreEmptyCtrls(addnew_mdcn_grbbx, "ImpoFields") = True Then
            MessageBox.Show("You have to fill the fields with red label, please try again.", "Filling Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

        If AreEmptyCtrls(addnew_mdcn_grbbx, "Impo") = False Then
            Try

                Dim rslt As Integer = MessageBox.Show("Are you sure that you want to add : Name=" & new_mdcn_nm_txtbx.Text & " Type=" & new_mdcn_type_cmbobx.Text & "
Qt=" & new_mdcn_qt_txtbx.Text & " Price=" & new_price_txtbx.Text & "RO. to the Pharmaceutical records ?", "Confirmation!", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)
                If rslt = DialogResult.Yes Then
                    mysqlconn.Open()
                    Dim Qu As String = "INSERT INTO mcms.pharma (name, Type, qt, manu_date, exp_date, price, reg_time)
                                                         VALUES ('" & new_mdcn_nm_txtbx.Text & "', '" & new_mdcn_type_cmbobx.Text & "', '" & new_mdcn_qt_txtbx.Text & "'
                                                                , '" & new_mdcn_manudate_picker.Text & "','" & new_mdcn_expdate_picker.Text & "', '" & new_price_txtbx.Text & "', now());"
                    Dim cmd As New MySqlCommand(Qu, mysqlconn)
                    Dim rdr As MySqlDataReader = cmd.ExecuteReader

                    mysqlconn.Close()
                End If
            Catch ex As MySqlException
                MessageBox.Show(ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
                mysqlconn.Dispose()
            End Try
        End If
    End Sub

    Private Sub fltr_btn_Click(sender As Object, e As EventArgs) Handles fltr_btn.Click
        mysqlconn = New MySqlConnection
        mysqlconn.ConnectionString = GetConnString()
        DB_table.Clear()

        Dim MySqlDtAd As New MySqlDataAdapter
        Dim BinSouc As New BindingSource

        If fltr_by_dt_chkbx.Checked = False AndAlso mdcn_nm_chkbx.Checked = False Then
            ResetGrid()
        End If

        If fltr_by_dt_chkbx.Checked = True AndAlso mdcn_nm_chkbx.Checked = True Then
            Try
                mysqlconn.Open()
                Dim Qu As String = "SELECT id AS ID, name AS Name, Type AS Type, qt AS Qt, price AS Price, manu_date AS ManufacturerDate, exp_date AS ExperationDate
                                    FROM mcms.pharma
                                    WHERE manu_date BETWEEN '" & mod_manu_frm_pkr.Text & "' AND '" & mod_manu_to_pkr.Text & "'
                                      AND exp_date BETWEEN '" & mod_exp_frm_pkr.Text & "' AND '" & mod_exp_to_pkr.Text & "'
                                      AND name LIKE '" & mdcn_nm_txtbx.Text & "%' "
                Dim cmd As New MySqlCommand(Qu, mysqlconn)
                MySqlDtAd.SelectCommand = cmd
                MySqlDtAd.Fill(DB_table)
                BinSouc.DataSource = DB_table
                mdcn_grid.DataSource = BinSouc
                MySqlDtAd.Update(DB_table)
                mysqlconn.Close()
            Catch ex As MySqlException
                MessageBox.Show(ex.Message, "DT&NM Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
                mysqlconn.Dispose()
            End Try

        ElseIf fltr_by_dt_chkbx.Checked = True Then
            Try
                mysqlconn.Open()
                Dim Qu As String = "SELECT id AS ID, name AS Name, Type AS Type, qt AS Qt, price AS Price, manu_date AS ManufacturerDate, exp_date AS ExperationDate
                                    FROM mcms.pharma
                                    WHERE manu_date BETWEEN '" & mod_manu_frm_pkr.Text & "' AND '" & mod_manu_to_pkr.Text & "'
                                      AND exp_date BETWEEN '" & mod_exp_frm_pkr.Text & "' AND '" & mod_exp_to_pkr.Text & "' "
                Dim cmd As New MySqlCommand(Qu, mysqlconn)
                MySqlDtAd.SelectCommand = cmd
                MySqlDtAd.Fill(DB_table)
                BinSouc.DataSource = DB_table
                mdcn_grid.DataSource = BinSouc
                MySqlDtAd.Update(DB_table)

                mysqlconn.Close()
            Catch ex As MySqlException
                MessageBox.Show(ex.Message, "DT Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
                mysqlconn.Dispose()
            End Try
        ElseIf mdcn_nm_chkbx.Checked = True Then
            Try
                mysqlconn.Open()
                Dim Qu As String = "SELECT id AS ID, name AS Name, Type AS Type, qt AS Qt, price AS Price, manu_date AS ManufacturerDate, exp_date AS ExperationDate
                                    FROM mcms.pharma
                                    WHERE name LIKE '" & mdcn_nm_txtbx.Text & "%' "
                Dim cmd As New MySqlCommand(Qu, mysqlconn)
                MySqlDtAd.SelectCommand = cmd
                MySqlDtAd.Fill(DB_table)
                BinSouc.DataSource = DB_table
                mdcn_grid.DataSource = BinSouc
                MySqlDtAd.Update(DB_table)

                mysqlconn.Close()
            Catch ex As MySqlException
                MessageBox.Show(ex.Message, "NM Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
                mysqlconn.Dispose()
            End Try
        End If

    End Sub

    Private Sub mdcn_grid_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles mdcn_grid.CellClick
        Try
            If e.RowIndex >= 0 Then
                Dim row As DataGridViewRow
                row = Me.mdcn_grid.Rows(e.RowIndex)
                mod_mdcn_id_txtbx.Text = row.Cells("ID").Value
                mod_mdcn_nm_txtbx.Text = row.Cells("Name").Value.ToString
                mod_mdcn_type_cmbobx.Text = row.Cells("Type").Value.ToString
                mod_mdcn_qt_txtbx.Text = row.Cells("Qt").Value.ToString
                mod_price_txtbx.Text = row.Cells("Price").Value.ToString
                mod_manu_dt_pkr.Text = row.Cells("ManufacturerDate").Value.ToString
                mod_exp_dt_pkr.Text = row.Cells("ExperationDate").Value.ToString
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub mod_drp_btn_Click(sender As Object, e As EventArgs) Handles mod_drp_btn.Click
        MySqlConn = New MySqlConnection
        MySqlConn.ConnectionString = GetConnString()

        Dim rslt As Integer = MessageBox.Show("Are you sure that you want to delete the entry of " & mod_mdcn_nm_txtbx.Text & " with ID : " & mod_mdcn_id_txtbx.Text & " ?", "Confirmation!", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)
        If rslt = DialogResult.Yes Then
            Dim rslt2 As Integer = MessageBox.Show("Are you sure that you want to delete the entry of " & mod_mdcn_nm_txtbx.Text & " with ID : " & mod_mdcn_id_txtbx.Text & " ??", "Confirmation!", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)
            If rslt2 = DialogResult.Yes Then
                'Update
                Try
                    MySqlConn.Open()
                    Dim Qu As String = "DELETE FROM mcms.pharma WHERE id='" & mod_mdcn_id_txtbx.Text & "'"
                    Dim cmd As New MySqlCommand(Qu, MySqlConn)
                    Dim rdr As MySqlDataReader = cmd.ExecuteReader
                    ResetGrid()
                    MySqlConn.Close()
                    'SendToLogs
                    MySqlConn.Open()
                    Dim Qu2 As String = "INSERT INTO mcms.logs (who, when_tm, what, where_nm, where_ip) 
                                                    VALUES ('" & M_id & "', now(), 'MDCN" & mod_mdcn_id_txtbx.Text & " ENTRY DELETED ', '" & M_pc_nm & "', '" & M_pc_ip & "');"
                    Dim cmd2 = New MySqlCommand(Qu2, MySqlConn)
                    Dim rdr2 As MySqlDataReader = cmd2.ExecuteReader
                    MySqlConn.Close()

                    Dim ctrl As Control
                    For Each ctrl In mod_mdcn_grbbx.Controls
                        If TypeOf ctrl Is TextBox Or TypeOf ctrl Is ComboBox Then
                            ctrl.Text = Nothing
                        End If
                    Next
                    mod_manu_dt_pkr.Text = Today.Date
                    mod_exp_dt_pkr.Text = Today.Date
                Catch ex As MySqlException
                    MessageBox.Show(ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            End If
            ResetGrid()
        End If
    End Sub

    Private Sub mod_update_btn_Click(sender As Object, e As EventArgs) Handles mod_update_btn.Click

        If AreEmptyCtrls(mod_mdcn_grbbx, "Impo") = False Then
            Dim rslt As Integer = MessageBox.Show("Are you sure that you want to modify the entry of " & mod_mdcn_nm_txtbx.Text & " with ID : " & mod_mdcn_id_txtbx.Text & " ?", "Confirmation!", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)
            If rslt = DialogResult.Yes Then
                'Update
                Try
                    mysqlconn.Open()
                    Dim Qu As String = "UPDATE mcms.pharma SET name = '" & mod_mdcn_nm_txtbx.Text & "', type = '" & mod_mdcn_type_cmbobx.Text & "', qt = '" & mod_mdcn_qt_txtbx.Text & "'
                                                            , price = '" & mod_price_txtbx.Text & "', manu_date = '" & mod_manu_dt_pkr.Text & "', exp_date = '" & mod_exp_dt_pkr.Text & "' "
                    Dim cmd As New MySqlCommand(Qu, mysqlconn)
                    Dim rdr As MySqlDataReader = cmd.ExecuteReader
                    ResetGrid()
                    Dim ctrl As Control
                    For Each ctrl In mod_mdcn_grbbx.Controls
                        If TypeOf ctrl Is TextBox Or TypeOf ctrl Is ComboBox Then
                            ctrl.Text = Nothing
                        End If
                    Next
                    mod_manu_dt_pkr.Text = Today.Date
                    mod_exp_dt_pkr.Text = Today.Date
                    mysqlconn.Close()
                    'SendToLogs
                    mysqlconn.Open()
                    Dim Qu2 As String = "INSERT INTO mcms.logs (who, when_tm, what, where_nm, where_ip) 
                                                    VALUES ('" & M_id & "', now(),  'MDCN" & mod_mdcn_id_txtbx.Text & " ENTRY MODI', '" & M_pc_nm & "', '" & M_pc_ip & "');"
                    Dim cmd2 = New MySqlCommand(Qu2, mysqlconn)
                    Dim rdr2 As MySqlDataReader = cmd2.ExecuteReader
                    mysqlconn.Close()
                    ResetGrid()
                Catch ex As MySqlException
                    MessageBox.Show(ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            End If
        End If
    End Sub
End Class