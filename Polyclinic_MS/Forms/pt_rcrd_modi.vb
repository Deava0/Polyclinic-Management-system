Imports MySql.Data.MySqlClient
Public Class pt_rcrd_modi
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
            Dim Qu As String = "SELECT id AS ID, civil_id AS CivilID, prefix as Prefix, first_name AS FirstName, second_name AS SecondName, third_name AS ThirdName,fourth_name AS FourthName, tribe_name AS TribeName
                            , phone_no AS PhoneNO, dob AS DoB, gender AS Gender, address AS Address, nationality AS Nationality
                            , email AS Email, blood_type AS BloodType
                            FROM mcms.patient"
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

    Private Sub rst_tbl_btn_Click(sender As Object, e As EventArgs) Handles rst_tbl_btn.Click
        ResetGridPT()
    End Sub

    Private Sub srch_txtbx_TextChanged(sender As Object, e As EventArgs) Handles srch_txtbx.TextChanged
        mysqlconn = New MySqlConnection
        mysqlconn.ConnectionString = GetConnString()

        Dim MySqlDtAd As New MySqlDataAdapter
        Dim BinSouc As New BindingSource
        Try
            mysqlconn.Open()
            Dim Qu As String = "SELECT id AS ID, civil_id AS CivilID, prefix as Prefix, first_name AS FirstName, second_name AS SecondName, third_name AS ThirdName,fourth_name AS FourthName, tribe_name AS TribeName
                            , phone_no AS PhoneNO, dob AS DoB, gender AS Gender, address AS Address, nationality AS Nationality
                            , email AS Email, blood_type AS BloodType
                            FROM mcms.patient
                            WHERE " & fltr & " "
            Dim cmd As New MySqlCommand(Qu, mysqlconn)
            MySqlDtAd.SelectCommand = cmd
            MySqlDtAd.Fill(DB_tablePT)
            BinSouc.DataSource = DB_tablePT
            pt_grid.DataSource = BinSouc
            MySqlDtAd.Update(DB_tablePT)
            mysqlconn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            mysqlconn.Dispose()
        End Try
    End Sub

    Private Sub pt_pno_rbtn_CheckedChanged(sender As Object, e As EventArgs) Handles pt_pno_rbtn.CheckedChanged
        fltr = "phone_no LIKE '" & srch_txtbx.Text & "' "
    End Sub

    Private Sub pt_cvl_id_rbtn_CheckedChanged(sender As Object, e As EventArgs) Handles pt_cvl_id_rbtn.CheckedChanged
        fltr = "civil_id LIKE '" & srch_txtbx.Text & "' "
    End Sub

    Private Sub pt_id_rbtn_CheckedChanged(sender As Object, e As EventArgs) Handles pt_id_rbtn.CheckedChanged
        fltr = "id = '" & srch_txtbx.Text & "' "
    End Sub

    Private Sub pt_nm_rbtn_CheckedChanged(sender As Object, e As EventArgs) Handles pt_nm_rbtn.CheckedChanged
        fltr = "first_name LIKE '" & srch_txtbx.Text & "%'
             OR second_name LIKE '" & srch_txtbx.Text & "%'
             OR third_name LIKE '" & srch_txtbx.Text & "%'
             OR tribe_name LIKE '" & srch_txtbx.Text & "%' "
    End Sub

    Private Sub update_btn_Click(sender As Object, e As EventArgs) Handles update_btn.Click
        mysqlconn = New MySqlConnection
        mysqlconn.ConnectionString = GetConnString()

        If AreEmptyCtrls(Me, "ImpoFields") = True Then
            MessageBox.Show("You have to fill the fields with red label, please try again.", "Filling Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

        If TxtBxIsNotInt(cvl_id_txtbx) = True Then
            MessageBox.Show("The Civil ID has to be a serise of digits, a numeric value, And nothing else, please try again ", "Civil ID datatype Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

        If AreEmptyCtrls(Me, "ImpoFields") = False AndAlso TxtBxIsNotInt(cvl_id_txtbx) = False Then
            Dim rslt As Integer = MessageBox.Show("Are you sure that you want to modify the record of " & prfx_cbx.Text & "." & frst_nm_txtbx.Text & " " & trib_nm_txtbx.Text & " with ID : " & id_txtbx.Text & " ?", "Confirmation!", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)
            If rslt = DialogResult.Yes Then
                'Update
                Try
                    mysqlconn.Open()
                    Dim Qu As String = "UPDATE mcms.patient SET civil_id='" & cvl_id_txtbx.Text & "', prefix='" & prfx_cbx.Text & "', first_name='" & frst_nm_txtbx.Text & "', second_name='" & scnd_nm_txtbx.Text & "'
                                                           , third_name='" & thrd_nm_txtbx.Text & "', fourth_name='" & frth_nm_txtbx.Text & "', tribe_name='" & trib_nm_txtbx.Text & "'
                                                           , dob='" & dob_pkr.Text & "', gender='" & gndr_cbx.Text & "', phone_no='" & phn_no_txtbx.Text & "', address='" & adrs_txtbx.Text & "', nationality='" & nation_txtbx.Text & "'
                                                           , email='" & eml_txtbx.Text & "', blood_type='" & bld_typ_txtbx.Text & "'
                                                             WHERE id='" & id_txtbx.Text & "'"
                    Dim cmd As New MySqlCommand(Qu, mysqlconn)
                    ResetGridPT()
                    mysqlconn.Close()
                    'SendToLogs
                    mysqlconn.Open()
                    Dim Qu2 As String = "INSERT INTO mcms.logs (who, when_tm, what, where_nm, where_ip) 
                                                    VALUES ('" & M_id & "', now(), 'PT" & id_txtbx.Text & " RCRD MODI ', '" & M_pc_nm & "', '" & M_pc_ip & "');"
                    Dim cmd2 = New MySqlCommand(Qu2, mysqlconn)
                    mysqlconn.Close()
                Catch ex As MySqlException
                    MessageBox.Show(ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            End If
        End If
    End Sub

    Private Sub drp_btn_Click(sender As Object, e As EventArgs) Handles drp_btn.Click
        mysqlconn = New MySqlConnection
        mysqlconn.ConnectionString = GetConnString()

        Dim rslt As Integer = MessageBox.Show("Are you sure that you want to delete the record of " & prfx_cbx.Text & "." & frst_nm_txtbx.Text & " " & trib_nm_txtbx.Text & " with ID : " & id_txtbx.Text & " ?", "Confirmation!", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)
        If rslt = DialogResult.Yes Then
            Dim rslt2 As Integer = MessageBox.Show("Are you ABSOLUTELY sure that you want to delete the record of " & prfx_cbx.Text & "." & frst_nm_txtbx.Text & " " & trib_nm_txtbx.Text & " with ID : " & id_txtbx.Text & " ?", "Confirmation!", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)
            If rslt2 = DialogResult.Yes Then
                'Update
                Try
                    mysqlconn.Open()
                    Dim Qu As String = "DELETE FROM mcms.patient WHERE id='" & id_txtbx.Text & "'"
                    Dim cmd As New MySqlCommand(Qu, mysqlconn)
                    Dim rdr As MySqlDataReader = cmd.ExecuteReader
                    ResetGridPT()
                    mysqlconn.Close()
                    'SendToLogs
                    mysqlconn.Open()
                    Dim Qu2 As String = "INSERT INTO mcms.logs (who, when_tm, what, where_nm, where_ip) 
                                                    VALUES ('" & M_id & "', now(), 'PT" & id_txtbx.Text & " RCRD DELETED ', '" & M_pc_nm & "', '" & M_pc_ip & "');"
                    Dim cmd2 = New MySqlCommand(Qu2, mysqlconn)
                    Dim rdr2 As MySqlDataReader = cmd2.ExecuteReader
                    mysqlconn.Close()
                    Dim ctrl As Control
                    For Each ctrl In pt_rcrd_modi_grbbx.Controls
                        If TypeOf ctrl Is TextBox Or TypeOf ctrl Is ComboBox Then
                            ctrl.Text = Nothing
                        End If
                    Next
                    dob_pkr.Text = Today.Date
                Catch ex As MySqlException
                    MessageBox.Show(ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            End If

        End If
    End Sub
End Class