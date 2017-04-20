Imports MySql.Data.MySqlClient

Public Class LoginForm
    Dim MySqlConn As MySqlConnection

    Sub SendToLOGS()
        Try
            MySqlConn = New MySqlConnection
            MySqlConn.ConnectionString = GetConnString()

            MySqlConn.Open()
            Dim Qu2 As String = "INSERT INTO mcms.logs (who, when_tm, what, where_nm, where_ip) 
                                                    VALUES ('" & M_id & "', now(), 'LOG IN', '" & M_pc_nm & "', '" & M_pc_ip & "');"
            Dim cmd2 = New MySqlCommand(Qu2, MySqlConn)
            Dim rdr2 As MySqlDataReader = cmd2.ExecuteReader
            MySqlConn.Close()

            MySqlConn = New MySqlConnection
            MySqlConn.ConnectionString = GetConnString()

            MySqlConn.Open()
            Dim Qu3 As String = "UPDATE mcms.staff 
                                    SET login_state='Online' 
                                  WHERE  id = '" & M_id & "' ;"
            Dim cmd3 = New MySqlCommand(Qu3, MySqlConn)
            Dim rdr3 As MySqlDataReader = cmd3.ExecuteReader
            MySqlConn.Close()

            If M_job = "Doctor" Or M_job = "Admin" Then
                MySqlConn.Open()
                Dim Qu4 As String = "INSERT INTO mcms.doct_work_q (doct_id, work_state, time) 
                                                    VALUES ('" & M_id & "', 'Waiting', now());"
                Dim cmd4 = New MySqlCommand(Qu4, MySqlConn)
                Dim rdr4 As MySqlDataReader = cmd4.ExecuteReader
                MySqlConn.Close()
            End If
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            MySqlConn.Dispose()
        End Try
    End Sub
    Sub errorsub()
        Dim rslt2 As Integer = MessageBox.Show("You've entered an uncorrect Username or Password", "Error!", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error)
        If rslt2 = DialogResult.Retry Then
            UsernameTextBox.Text = Nothing
            PasswordTextBox.Text = Nothing

        Else
            Application.Exit()
        End If
    End Sub


    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click
        MySqlConn = New MySqlConnection
        MySqlConn.ConnectionString = GetConnString()
        Try
            MySqlConn.Open()
            Dim Qu As String
            Qu = "SELECT * FROM mcms.staff WHERE username='" & UsernameTextBox.Text & "' AND password='" & PasswordTextBox.Text & "'"
            Dim cmd = New MySqlCommand(Qu, MySqlConn)
            Dim rdr As MySqlDataReader = cmd.ExecuteReader
            Dim count As Integer = 0
            While rdr.Read
                count += 1
            End While
            Dim acnt_status As String = rdr.GetString("login_state") 'USE LATER
            M_id = rdr.GetInt32("id")
            M_prefix = rdr.GetString("prefix")
            M_first_nm = rdr.GetString("first_name")
            M_job = rdr.GetString("job")
            If count = 1 Then
                'found it
                Dim rslt As Integer = MessageBox.Show("You've Entered the correct username & password, 
                                    you now have access to the system", "Welcome " & M_prefix & ". " & M_first_nm & "(" & M_job & ")@" & M_pc_nm & "_" & M_pc_ip, MessageBoxButtons.OK)
                If rslt = DialogResult.OK Then
                    SendToLOGS()
                    Dim nav_frm = New MainForm()
                    nav_frm.Show()
                    Hide()
                Else
                    UsernameTextBox.Text = Nothing
                    PasswordTextBox.Text = Nothing
                End If
            Else
                'error
                errorsub()
            End If
            MySqlConn.Close()



        Catch ex As MySqlException
            If ex.Message = "Invalid attempt to access a field before calling Read()" Then
                errorsub()
            End If
        Finally
            MySqlConn.Dispose()

        End Try
    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        Close()
    End Sub

    Private Sub LoginForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        M_pc_nm = GetCompName()
        M_pc_ip = GetCompIP()
        StatusStrip_LF.ShowItemToolTips = True
        MySqlConn = New MySqlConnection
        MySqlConn.ConnectionString = GetConnString()
        Try
            MySqlConn.Open()
            DB_Conn_SSLbl.ForeColor = Color.Green
            DB_Conn_SSLbl.Text = "Connection Status : Connected"
            DB_Conn_SSLbl.ToolTipText = "No Connection Error Detected"
            MySqlConn.Close()
        Catch ex As MySqlException
            UsernameTextBox.Enabled = False
            PasswordTextBox.Enabled = False
            OK.Enabled = False
            DB_Conn_SSLbl.ForeColor = Color.Red
            DB_Conn_SSLbl.Text = "Connection Status : Disconnected"
            DB_Conn_SSLbl.ToolTipText = ex.Message
        End Try
    End Sub

    Private Sub DB_Conn_SSLbl_Click(sender As Object, e As EventArgs) Handles DB_Conn_SSLbl.Click

    End Sub
End Class
