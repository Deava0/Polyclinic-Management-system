Imports MySql.Data.MySqlClient
Public Class stf_reg

    Dim MySqlConn As MySqlConnection

    Private Sub sbmt_btn_Click(sender As Object, e As EventArgs) Handles sbmt_btn.Click
        Dim pw1 As String = pw_txtbx.Text
        Dim pw2 As String = repw_txtbx.Text

        Dim MySqlConn As New MySqlConnection
        MySqlConn.ConnectionString = GetConnString()

        Try
            If IsUnderAge(dob_pkr.Text) = True Then
                MessageBox.Show("This new staff member's age is less than the required age for employment, he/she has to have been born before " & Today.Year - minAge & ".
meaning he/she has to be at least " & minAge & "years old.", "Under Age Problem!", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If

            If AreEmptyCtrls(Me, "ImpoFields") = True Then
                MessageBox.Show("You have to fill the fields with red label, please try again.", "Filling Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If

            If TxtBxIsNotInt(cvl_id_txtbx) = True Then
                MessageBox.Show("The Civil ID has to be a serise of digits, a numeric value, And nothing else, please try again ", "Civil ID datatype Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If

            If pw1.Equals(pw2) AndAlso String.IsNullOrWhiteSpace(pw1) = False AndAlso String.IsNullOrWhiteSpace(pw2) = False AndAlso AreEmptyCtrls(Me, "ImpoFields") = False AndAlso IsUnderAge(dob_pkr.Text) = False AndAlso TxtBxIsNotInt(cvl_id_txtbx) = False Then

                Dim rslt As Integer = MessageBox.Show("Are you sure that you want to add " & prfx_cbx.Text & "." & frst_nm_txtbx.Text & " " & trib_nm_txtbx.Text & " with Civil ID : " & cvl_id_txtbx.Text & " to the staff records ?", "Confirmation!", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)
                If rslt = DialogResult.Yes Then


                    MySqlConn.Open()
                    Dim Qu As String = "INSERT INTO `mcms`.`staff` (civil_id, prefix, first_name, second_name, third_name, fourth_name, tribe_name, dob, gender, phone_no, address, nationality, email,
                                                        username, password, job, reg_time) 
                                                VALUES ('" & cvl_id_txtbx.Text & "', '" & prfx_cbx.Text & "', '" & frst_nm_txtbx.Text & "','" & scnd_nm_txtbx.Text & "'
                                                      , '" & thrd_nm_txtbx.Text & "','" & frth_nm_txtbx.Text & "', '" & trib_nm_txtbx.Text & "', '" & dob_pkr.Text & "'
                                                      , '" & gndr_cbx.Text & "', '" & phn_no_txtbx.Text & "', '" & adrs_txtbx.Text & "', '" & nation_txtbx.Text & "'
                                                      , '" & eml_txtbx.Text & "', '" & un_txtbx.Text & "', '" & pw1 & "', '" & jb_cbx.Text & "', now());"
                    Dim cmd As New MySqlCommand(Qu, MySqlConn)
                    Dim rdr As MySqlDataReader = cmd.ExecuteReader
                    MySqlConn.Close()

                    'SendToLogs
                    MySqlConn.Open()
                    Dim Qu1 As String = "INSERT INTO mcms.logs (who, when_tm, what, where_nm, where_ip) 
                                                    VALUES('" & M_id & "', now(), 'STF REG', '" & M_pc_nm & "', '" & M_pc_ip & "');"
                    Dim cmd1 As New MySqlCommand(Qu1, MySqlConn)
                    Dim rdr1 As MySqlDataReader = cmd1.ExecuteReader
                    MySqlConn.Close()
                Else
                    'nothing, for the time being ^,^ add something later
                End If

            ElseIf String.IsNullOrWhiteSpace(pw1) = True Or String.IsNullOrWhiteSpace(pw2) = True Or String.IsNullOrWhiteSpace(un_txtbx.Text) = True Then
                MessageBox.Show("You have to enter a username and a passoword, please try again.", "Credential Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)
            ElseIf pw1.Equals(pw2) = False Then
                MessageBox.Show("Passowrds don't match, please try again.", "Unatching Passwords Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If

        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            MySqlConn.Dispose()
        End Try

    End Sub


    Private Sub stf_reg_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.MaximizeBox = False
        Me.MinimizeBox = False
    End Sub
End Class