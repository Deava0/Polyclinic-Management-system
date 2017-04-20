Imports MySql.Data.MySqlClient
Public Class stf_rcrd_modi
    Dim MySqlConn As MySqlConnection
    Dim DB_table As New DataTable

    Public Sub ResetGrid()
        MySqlConn = New MySqlConnection
        MySqlConn.ConnectionString = GetConnString()

        DB_table.Clear()

        Dim MySqlDtAd As New MySqlDataAdapter
        Dim BinSouc As New BindingSource

        Try
            MySqlConn.Open()
            Dim Qu As String = "SELECT id AS ID, civil_id AS CivilID, prefix as Prefix, first_name AS FirstName, second_name AS SecondName, third_name AS ThirdName,fourth_name AS FourthName, tribe_name AS TribeName
                            , phone_no AS PhoneNO, dob AS DoB, gender AS Gender, address AS Address, nationality AS Nationality
                            , email AS Email, job AS Job, username AS Username, password AS Password
                            FROM mcms.staff"
            Dim cmd As New MySqlCommand(Qu, MySqlConn)
            MySqlDtAd.SelectCommand = cmd
            MySqlDtAd.Fill(DB_table)
            BinSouc.DataSource = DB_table
            stf_rcrd_grid.DataSource = BinSouc
            MySqlDtAd.Update(DB_table)
            MySqlConn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            MySqlConn.Dispose()
        End Try
    End Sub
    Private Sub srch_txtbx_TextChanged(sender As Object, e As EventArgs) Handles srch_txtbx.TextChanged
        MySqlConn = New MySqlConnection
        MySqlConn.ConnectionString = GetConnString()



        Dim MySqlDtAd As New MySqlDataAdapter
        Dim BinSouc As New BindingSource
        DB_table.Clear()

        Try
        If stf_id_rbtn.Checked = True Then
                MySqlConn.Open()
                Dim Qu As String = "SELECT id AS ID, civil_id AS CivilID, prefix as Prefix, first_name AS FirstName, second_name AS SecondName, third_name AS ThirdName,fourth_name AS FourthName, tribe_name AS TribeName
                            , phone_no AS PhoneNO, dob AS DoB, gender AS Gender, address AS Address, nationality AS Nationality
                            , email AS Email, job AS Job, username AS Username, password AS Password
                            FROM mcms.staff 
                            WHERE id LIKE '" & srch_txtbx.Text & "%'"
                Dim cmd As New MySqlCommand(Qu, MySqlConn)
                MySqlDtAd.SelectCommand = cmd
                MySqlDtAd.Fill(DB_table)
                BinSouc.DataSource = DB_table
                stf_rcrd_grid.DataSource = BinSouc
                MySqlDtAd.Update(DB_table)
                MySqlConn.Close()
            End If
            If stf_cvl_id_rbtn.Checked = True Then
                MySqlConn.Open()
                Dim Qu As String = "SELECT id AS ID, civil_id AS CivilID, prefix as Prefix, first_name AS FirstName, second_name AS SecondName, third_name AS ThirdName,fourth_name AS FourthName, tribe_name AS TribeName
                            , phone_no AS PhoneNO, dob AS DoB, gender AS Gender, address AS Address, nationality AS Nationality
                            , email AS Email, job AS Job, username AS Username, password AS Password
                            FROM mcms.staff 
                            WHERE civil_id LIKE '" & srch_txtbx.Text & "%'"
                Dim cmd As New MySqlCommand(Qu, MySqlConn)
                MySqlDtAd.SelectCommand = cmd
                MySqlDtAd.Fill(DB_table)
                BinSouc.DataSource = DB_table
                stf_rcrd_grid.DataSource = BinSouc
                MySqlDtAd.Update(DB_table)
                MySqlConn.Close()
            End If
            If stf_nm_rbtn.Checked = True Then
                MySqlConn.Open()
                Dim Qu As String = "SELECT id AS ID, civil_id AS CivilID, prefix as Prefix, first_name AS FirstName, second_name AS SecondName, third_name AS ThirdName,fourth_name AS FourthName, tribe_name AS TribeName
                            , phone_no AS PhoneNO, dob AS DoB, gender AS Gender, address AS Address, nationality AS Nationality
                            , email AS Email, job AS Job, username AS Username, password AS Password
                            FROM mcms.staff 
                            WHERE first_name LIKE '" & srch_txtbx.Text & "%'
                              OR second_name LIKE '" & srch_txtbx.Text & "%'
                              OR third_name LIKE '" & srch_txtbx.Text & "%'
                              OR tribe_name LIKE '" & srch_txtbx.Text & "%'"
                Dim cmd As New MySqlCommand(Qu, MySqlConn)
                MySqlDtAd.SelectCommand = cmd
                MySqlDtAd.Fill(DB_table)
                BinSouc.DataSource = DB_table
                stf_rcrd_grid.DataSource = BinSouc
                MySqlDtAd.Update(DB_table)
                MySqlConn.Close()
            End If
            If stf_pno_rbtn.Checked = True Then
                MySqlConn.Open()
                Dim Qu As String = "SELECT id AS ID, civil_id AS CivilID, prefix as Prefix, first_name AS FirstName, second_name AS SecondName, third_name AS ThirdName,fourth_name AS FourthName, tribe_name AS TribeName
                            , phone_no AS PhoneNO, dob AS DoB, gender AS Gender, address AS Address, nationality AS Nationality
                            , email AS Email, job AS Job, username AS Username, password AS Password
                            FROM mcms.staff 
                            WHERE phone_no LIKE '" & srch_txtbx.Text & "%'"
                Dim cmd As New MySqlCommand(Qu, MySqlConn)
                MySqlDtAd.SelectCommand = cmd
                MySqlDtAd.Fill(DB_table)
                BinSouc.DataSource = DB_table
                stf_rcrd_grid.DataSource = BinSouc
                MySqlDtAd.Update(DB_table)
                MySqlConn.Close()
            End If
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            MySqlConn.Dispose()
        End Try

    End Sub

    Private Sub rst_tbl_btn_Click(sender As Object, e As EventArgs) Handles rst_tbl_btn.Click
        ResetGrid()
    End Sub

    Private Sub stf_rcrd_grid_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles stf_rcrd_grid.CellClick
        Try
            If e.RowIndex >= 0 Then
                Dim row As DataGridViewRow
                row = Me.stf_rcrd_grid.Rows(e.RowIndex)
                id_txtbx.Text = row.Cells("ID").Value
                id_txtbx.Text = id_txtbx.Text.PadLeft(4, "0")
                cvl_id_txtbx.Text = row.Cells("CivilID").Value
                frst_nm_txtbx.Text = row.Cells("FirstName").Value.ToString
                prfx_cbx.Text = row.Cells("Prefix").Value.ToString
                scnd_nm_txtbx.Text = row.Cells("SecondName").Value.ToString
                thrd_nm_txtbx.Text = row.Cells("ThirdName").Value.ToString
                frth_nm_txtbx.Text = row.Cells("FourthName").Value.ToString
                trib_nm_txtbx.Text = row.Cells("TribeName").Value.ToString
                phn_no_txtbx.Text = row.Cells("PhoneNO").Value.ToString
                dob_pkr.Text = row.Cells("DoB").Value.ToString
                gndr_cbx.Text = row.Cells("Gender").Value.ToString
                adrs_txtbx.Text = row.Cells("Address").Value.ToString
                nation_txtbx.Text = row.Cells("Nationality").Value.ToString
                eml_txtbx.Text = row.Cells("Email").Value.ToString
                jb_cbx.Text = row.Cells("Job").Value.ToString
                un_txtbx.Text = row.Cells("Username").Value.ToString
                pw_txtbx.Text = row.Cells("Password").Value.ToString
                repw_txtbx.Text = row.Cells("Password").Value.ToString
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub drp_btn_Click(sender As Object, e As EventArgs) Handles drp_btn.Click
        MySqlConn = New MySqlConnection
        MySqlConn.ConnectionString = GetConnString()


        Dim rslt As Integer = MessageBox.Show("Are you sure that you want to delete the record of " & prfx_cbx.Text & "." & frst_nm_txtbx.Text & " " & trib_nm_txtbx.Text & " with ID : " & id_txtbx.Text & " ?", "Confirmation!", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)
        If rslt = DialogResult.Yes Then
            Dim rslt2 As Integer = MessageBox.Show("Are you ABSOLUTELY sure that you want to delete the record of " & prfx_cbx.Text & "." & frst_nm_txtbx.Text & " " & trib_nm_txtbx.Text & " with ID : " & id_txtbx.Text & " ?", "Confirmation!", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)
            If rslt2 = DialogResult.Yes Then
                'Update
                Try
                    MySqlConn.Open()
                    Dim Qu As String = "DELETE FROM mcms.staff WHERE id='" & id_txtbx.Text & "'"
                    Dim cmd As New MySqlCommand(Qu, MySqlConn)
                    Dim rdr As MySqlDataReader = cmd.ExecuteReader
                    ResetGrid()
                    MySqlConn.Close()
                    'SendToLogs
                    MySqlConn.Open()
                    Dim Qu2 As String = "INSERT INTO mcms.logs (who, when_tm, what, where_nm, where_ip) 
                                                    VALUES ('" & M_id & "', now(), 'STF" & id_txtbx.Text & " RCRD DELETED ', '" & M_pc_nm & "', '" & M_pc_ip & "');"
                    Dim cmd2 = New MySqlCommand(Qu2, MySqlConn)
                    Dim rdr2 As MySqlDataReader = cmd2.ExecuteReader
                    MySqlConn.Close()

                    Dim ctrl As Control
                    For Each ctrl In stf_rcrd_modi_grbbx.Controls
                        If TypeOf ctrl Is TextBox Or TypeOf ctrl Is ComboBox Then
                            ctrl.Text = Nothing
                        End If
                    Next
                    Dim ctrl2 As Control
                    For Each ctrl2 In crd_grbbx.Controls
                        If TypeOf ctrl2 Is TextBox Or TypeOf ctrl2 Is ComboBox Then
                            ctrl2.Text = Nothing
                        End If
                    Next
                    dob_pkr.Text = Today.Date
                Catch ex As MySqlException
                    MessageBox.Show(ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            End If

        End If
    End Sub

    Private Sub update_btn_Click(sender As Object, e As EventArgs) Handles update_btn.Click
        Dim pw1 As String = pw_txtbx.Text
        Dim pw2 As String = repw_txtbx.Text
        Dim id As Integer = id_txtbx.Text
        MySqlConn = New MySqlConnection
        MySqlConn.ConnectionString = GetConnString()

        If IsUnderAge(dob_pkr.Text) = True Then
            MessageBox.Show("You have entered a staff member's Date of Birth incorrectly, he/she has to have been born before " & Today.Year - minAge & ".
meaning he/she has to be at least " & minAge & "years old.", "Under Age Problem!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

        If AreEmptyCtrls(Me, "ImpoFields") = True Then
            MessageBox.Show("You have to fill the fields with red label, please try again.", "Filling Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

        If TxtBxIsNotInt(cvl_id_txtbx) = True Then
            MessageBox.Show("The Civil ID has to be a serise of digits, a numeric value, And nothing else, please try again ", "Civil ID datatype Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

        If pw1.Equals(pw2) AndAlso String.IsNullOrWhiteSpace(pw1) = False AndAlso String.IsNullOrWhiteSpace(pw2) = False AndAlso AreEmptyCtrls(Me, "ImpoFields") = False AndAlso IsUnderAge(dob_pkr.Text) = False AndAlso TxtBxIsNotInt(cvl_id_txtbx) = False Then

            Dim rslt As Integer = MessageBox.Show("Are you sure that you want to modify the record of " & prfx_cbx.Text & "." & frst_nm_txtbx.Text & " " & trib_nm_txtbx.Text & " with ID : " & id & " ?", "Confirmation!", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)
            If rslt = DialogResult.Yes Then
                'Update
                Try
                    MySqlConn.Open()
                    Dim Qu As String = "UPDATE mcms.staff SET civil_id='" & cvl_id_txtbx.Text & "', prefix='" & prfx_cbx.Text & "', first_name='" & frst_nm_txtbx.Text & "', second_name='" & scnd_nm_txtbx.Text & "'
                                                           , third_name='" & thrd_nm_txtbx.Text & "', fourth_name='" & frth_nm_txtbx.Text & "', tribe_name='" & trib_nm_txtbx.Text & "'
                                                           , dob='" & dob_pkr.Text & "', gender='" & gndr_cbx.Text & "', phone_no='" & phn_no_txtbx.Text & "', address='" & adrs_txtbx.Text & "', nationality='" & nation_txtbx.Text & "'
                                                           , email='" & eml_txtbx.Text & "', username='" & un_txtbx.Text & "', password='" & pw_txtbx.Text & "', job='" & jb_cbx.Text & "'
                                                             WHERE id='" & id & "'"
                    Dim cmd As New MySqlCommand(Qu, MySqlConn)
                    Dim rdr As MySqlDataReader = cmd.ExecuteReader
                    ResetGrid()
                    MySqlConn.Close()
                    'SendToLogs
                    MySqlConn.Open()
                    Dim Qu2 As String = "INSERT INTO mcms.logs (who, when_tm, what, where_nm, where_ip) 
                                                    VALUES ('" & M_id & "', now(), 'STF" & id & " RCRD MODI ', '" & M_pc_nm & "', '" & M_pc_ip & "');"
                    Dim cmd2 = New MySqlCommand(Qu2, MySqlConn)
                    Dim rdr2 As MySqlDataReader = cmd2.ExecuteReader
                    MySqlConn.Close()
                Catch ex As MySqlException
                    MessageBox.Show(ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            End If

        End If
    End Sub

    Private Sub stf_rcrd_modi_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class