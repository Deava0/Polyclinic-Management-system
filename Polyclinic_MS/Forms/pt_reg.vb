Imports MySql.Data.MySqlClient
Public Class pt_reg
    Dim MySqlConn As MySqlConnection

    Private Sub pt_reg_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub sbmt_btn_Click(sender As Object, e As EventArgs) Handles sbmt_btn.Click
        Dim MySqlConn As New MySqlConnection
        MySqlConn.ConnectionString = GetConnString()
        Try
            If AreEmptyCtrls(Me, "ImpoFields") = True Then
                MessageBox.Show("You have to fill the fields with red label, please try again.", "Filling Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
            If TxtBxIsNotInt(cvl_id_txtbx) = True Then
                MessageBox.Show("The Civil ID has to be a serise of digits, a numeric value, And nothing else, please try again", "Civil ID datatype Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If

            If AreEmptyCtrls(Me, "ImpoFields") = False AndAlso TxtBxIsNotInt(cvl_id_txtbx) = False Then
                Dim rslt As Integer = MessageBox.Show("Are you sure that you want to add " & prfx_cbx.Text & "." & frst_nm_txtbx.Text & " " & trib_nm_txtbx.Text & " with Civil ID : " & cvl_id_txtbx.Text & " to the patient records ?", "Confirmation!", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)
                If rslt = DialogResult.Yes Then
                    'regst
                    MySqlConn.Open()
                    Dim Qu As String = "INSERT INTO mcms.patient (civil_id, prefix, first_name, second_name, third_name, fourth_name, tribe_name, dob, gender, phone_no, address
                                                        , nationality, email, blood_type, reg_time) 
                                                  VALUES ('" & cvl_id_txtbx.Text & "', '" & prfx_cbx.Text & "', '" & frst_nm_txtbx.Text & "', '" & scnd_nm_txtbx.Text & "', '" & thrd_nm_txtbx.Text & "'
                                                        , '" & frth_nm_txtbx.Text & "', '" & trib_nm_txtbx.Text & "', '" & dob_pkr.Text & "', '" & gndr_cbx.Text & "', '" & phn_no_txtbx.Text & "'
                                                        , '" & adrs_txtbx.Text & "', '" & nation_txtbx.Text & "', '" & eml_txtbx.Text & "', '" & bld_typ_txtbx.Text & "', now() )"
                    Dim cmd As New MySqlCommand(Qu, MySqlConn)
                    Dim rdr As MySqlDataReader = cmd.ExecuteReader
                    MySqlConn.Close()
                    'get id
                    MySqlConn.Open()
                    Dim Qu1 As String = "SELECT * FROM mcms.patient WHERE civil_id='" & cvl_id_txtbx.Text & "' "
                    Dim cmd1 As New MySqlCommand(Qu1, MySqlConn)
                    Dim rdr1 As MySqlDataReader = cmd1.ExecuteReader
                    Dim pt_id As Integer
                    While rdr1.Read()
                        pt_id = rdr1.GetInt32("id")
                    End While
                    MySqlConn.Close()
                    'payment
                    MySqlConn.Open()
                    Dim Qu2 As String = "INSERT INTO mcms.payment (by_whom, for_whom, fee_type, fee, com_time) 
                                                               VALUES ('" & M_id & "', '" & pt_id & "', 'REG FEE', '" & regst_fee & "', now())"
                    Dim cmd2 As New MySqlCommand(Qu2, MySqlConn)
                    Dim rdr2 As MySqlDataReader = cmd2.ExecuteReader
                    MySqlConn.Close()
                    'SendToLogs
                    MySqlConn.Open()
                    Dim Qu3 As String = "INSERT INTO mcms.logs (who, when_tm, what, where_nm, where_ip) 
                                                    VALUES('" & M_id & "', now(), 'PT REG', '" & M_pc_nm & "', '" & M_pc_ip & "')"
                    Dim cmd3 As New MySqlCommand(Qu3, MySqlConn)
                    Dim rdr3 As MySqlDataReader = cmd3.ExecuteReader
                    MySqlConn.Close()
                End If
            End If

        Catch ex As MySqlException
            MessageBox.Show(ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)

        Finally
            MySqlConn.Dispose()
        End Try
    End Sub
End Class