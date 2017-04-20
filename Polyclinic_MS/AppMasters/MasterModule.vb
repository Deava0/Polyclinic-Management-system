Module MasterModule
    Dim srvr As String
    Dim db As String
    Dim un As String
    Dim pw As String

    Public Const minAge As Integer = 18
    'Fees
    Public Const regst_fee As Double = 2.0 'OR
    Public Const file_actv_fee As Double = 0.5 'OR ... iff without apt
    Public Const cnslt_fee As Double = 25.0 'OR ... if cnslt price is fixed -and for the time being , it is-
    'remove these after testing
    Public M_id As Integer
    Public M_prefix As String
    Public M_first_nm As String
    Public M_job As String

    Public M_pc_ip As String
    Public M_pc_nm As String

    Public StrtOfDay As String = (Date.Today + " 00:00:00")
    Public EndOfDay As String = (Date.Today + " 23:59:59")

    Public Function TxtBxIsNotInt(txtbx As TextBox) As Boolean
        Dim CvlID_DaTy As Integer
        Dim IsInt As Boolean = Integer.TryParse(txtbx.Text, CvlID_DaTy)
        If IsInt Then
            txtbx.BackColor = Color.Green
            TxtBxIsNotInt = False
        Else
            txtbx.BackColor = Color.Maroon
            TxtBxIsNotInt = True
        End If
    End Function
    Public Function AreEmptyCtrls(container As GroupBox, CtrlTag As String) As Boolean
        Dim ctrl As Control
        For Each ctrl In container.Controls
            If (ctrl.Tag() = CtrlTag) Then
                If String.IsNullOrWhiteSpace(ctrl.Text) = True Then
                    AreEmptyCtrls = True
                    Exit For
                End If
            End If
        Next
    End Function

    Public Function AreEmptyCtrls(container As ContainerControl, CtrlTag As String) As Boolean
        Dim ctrl As Control
        For Each ctrl In container.Controls
            If (ctrl.Tag() = CtrlTag) Then
                If String.IsNullOrWhiteSpace(ctrl.Text) = True Then
                    AreEmptyCtrls = True
                    Exit For
                End If
            End If
        Next
    End Function

    Public Function IsUnderAge(dob As Date) As Boolean

        If dob.Year >= (Today.Year - minAge) Then
            IsUnderAge = True
        Else
            IsUnderAge = False
        End If

    End Function

    Public Function GetConnString() As String
        srvr = "localhost"
        db = "mcms"
        un = "root"
        pw = "root"

        Dim ConnString As String = "SERVER=" + srvr + ";DATABASE=" + db + ";UID=" + un + ";PASSWORD=" + pw + ";"

        Return ConnString
    End Function

    Public Function GetAge(dob As Date)
        Dim age As Integer
        age = Today.Year - dob.Year
        If dob > Today.AddYears(-age) Then
            age = -1
        End If
        Return age
    End Function

    Public Function GetCompName() As String
        Dim CompName As String = Net.Dns.GetHostName()
        Return CompName
    End Function

    Public Function GetCompIP()
        Dim CompIP As String = Net.Dns.GetHostEntry(GetCompName()).AddressList(0).ToString()
        Return CompIP
    End Function
End Module
