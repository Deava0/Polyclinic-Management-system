<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class stf_reg
    Inherits System.Windows.Forms.Form
	'Inherits BaseForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(stf_reg))
        Me.sbmt_btn = New System.Windows.Forms.Button()
        Me.gndr_cbx = New System.Windows.Forms.ComboBox()
        Me.dob_pkr = New System.Windows.Forms.DateTimePicker()
        Me.eml_txtbx = New System.Windows.Forms.TextBox()
        Me.trib_nm_txtbx = New System.Windows.Forms.TextBox()
        Me.eml_lbl = New System.Windows.Forms.Label()
        Me.trib_nm_lbl = New System.Windows.Forms.Label()
        Me.nation_txtbx = New System.Windows.Forms.TextBox()
        Me.frth_nm_txtbx = New System.Windows.Forms.TextBox()
        Me.nation_lbl = New System.Windows.Forms.Label()
        Me.frth_nm_lbl = New System.Windows.Forms.Label()
        Me.adrs_txtbx = New System.Windows.Forms.TextBox()
        Me.thrd_nm_txtbx = New System.Windows.Forms.TextBox()
        Me.adrs_lbl = New System.Windows.Forms.Label()
        Me.thrd_nm_lbl = New System.Windows.Forms.Label()
        Me.phn_no_txtbx = New System.Windows.Forms.TextBox()
        Me.scnd_nm_txtbx = New System.Windows.Forms.TextBox()
        Me.phn_no_lbl = New System.Windows.Forms.Label()
        Me.scnd_nm_lbl = New System.Windows.Forms.Label()
        Me.frst_nm_txtbx = New System.Windows.Forms.TextBox()
        Me.gndr_lbl = New System.Windows.Forms.Label()
        Me.frst_nm_lbl = New System.Windows.Forms.Label()
        Me.dob_lbl = New System.Windows.Forms.Label()
        Me.cvl_id_txtbx = New System.Windows.Forms.TextBox()
        Me.cvl_id_lbl = New System.Windows.Forms.Label()
        Me.jb_lbl = New System.Windows.Forms.Label()
        Me.jb_cbx = New System.Windows.Forms.ComboBox()
        Me.prfx_lbl = New System.Windows.Forms.Label()
        Me.prfx_cbx = New System.Windows.Forms.ComboBox()
        Me.crd_grbbx = New System.Windows.Forms.GroupBox()
        Me.repw_txtbx = New System.Windows.Forms.TextBox()
        Me.un_lbl = New System.Windows.Forms.Label()
        Me.un_txtbx = New System.Windows.Forms.TextBox()
        Me.pw_lbl = New System.Windows.Forms.Label()
        Me.pw_txtbx = New System.Windows.Forms.TextBox()
        Me.repw_lbl = New System.Windows.Forms.Label()
        Me.crd_grbbx.SuspendLayout()
        Me.SuspendLayout()
        '
        'sbmt_btn
        '
        Me.sbmt_btn.Location = New System.Drawing.Point(469, 171)
        Me.sbmt_btn.Name = "sbmt_btn"
        Me.sbmt_btn.Size = New System.Drawing.Size(75, 23)
        Me.sbmt_btn.TabIndex = 36
        Me.sbmt_btn.Text = "Submit"
        Me.sbmt_btn.UseVisualStyleBackColor = True
        '
        'gndr_cbx
        '
        Me.gndr_cbx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.gndr_cbx.FormattingEnabled = True
        Me.gndr_cbx.Items.AddRange(New Object() {"Male", "Female", "Other"})
        Me.gndr_cbx.Location = New System.Drawing.Point(290, 37)
        Me.gndr_cbx.Name = "gndr_cbx"
        Me.gndr_cbx.Size = New System.Drawing.Size(100, 21)
        Me.gndr_cbx.TabIndex = 31
        Me.gndr_cbx.Tag = "ImpoFields"
        '
        'dob_pkr
        '
        Me.dob_pkr.CustomFormat = "yyyy/MM/dd"
        Me.dob_pkr.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dob_pkr.Location = New System.Drawing.Point(290, 12)
        Me.dob_pkr.Name = "dob_pkr"
        Me.dob_pkr.Size = New System.Drawing.Size(100, 20)
        Me.dob_pkr.TabIndex = 30
        Me.dob_pkr.Tag = ""
        '
        'eml_txtbx
        '
        Me.eml_txtbx.Location = New System.Drawing.Point(290, 142)
        Me.eml_txtbx.Name = "eml_txtbx"
        Me.eml_txtbx.Size = New System.Drawing.Size(100, 20)
        Me.eml_txtbx.TabIndex = 35
        Me.eml_txtbx.Tag = "ImpoFields"
        '
        'trib_nm_txtbx
        '
        Me.trib_nm_txtbx.Location = New System.Drawing.Point(87, 168)
        Me.trib_nm_txtbx.Name = "trib_nm_txtbx"
        Me.trib_nm_txtbx.Size = New System.Drawing.Size(100, 20)
        Me.trib_nm_txtbx.TabIndex = 29
        Me.trib_nm_txtbx.Tag = "ImpoFields"
        '
        'eml_lbl
        '
        Me.eml_lbl.AutoSize = True
        Me.eml_lbl.ForeColor = System.Drawing.Color.Maroon
        Me.eml_lbl.Location = New System.Drawing.Point(210, 145)
        Me.eml_lbl.Name = "eml_lbl"
        Me.eml_lbl.Size = New System.Drawing.Size(42, 13)
        Me.eml_lbl.TabIndex = 48
        Me.eml_lbl.Text = "E-Mail :"
        '
        'trib_nm_lbl
        '
        Me.trib_nm_lbl.AutoSize = True
        Me.trib_nm_lbl.ForeColor = System.Drawing.Color.Maroon
        Me.trib_nm_lbl.Location = New System.Drawing.Point(7, 171)
        Me.trib_nm_lbl.Name = "trib_nm_lbl"
        Me.trib_nm_lbl.Size = New System.Drawing.Size(68, 13)
        Me.trib_nm_lbl.TabIndex = 42
        Me.trib_nm_lbl.Text = "Tribe Name :"
        '
        'nation_txtbx
        '
        Me.nation_txtbx.Location = New System.Drawing.Point(290, 116)
        Me.nation_txtbx.Name = "nation_txtbx"
        Me.nation_txtbx.Size = New System.Drawing.Size(100, 20)
        Me.nation_txtbx.TabIndex = 34
        Me.nation_txtbx.Tag = "ImpoFields"
        '
        'frth_nm_txtbx
        '
        Me.frth_nm_txtbx.Location = New System.Drawing.Point(87, 142)
        Me.frth_nm_txtbx.Name = "frth_nm_txtbx"
        Me.frth_nm_txtbx.Size = New System.Drawing.Size(100, 20)
        Me.frth_nm_txtbx.TabIndex = 28
        '
        'nation_lbl
        '
        Me.nation_lbl.AutoSize = True
        Me.nation_lbl.ForeColor = System.Drawing.Color.Maroon
        Me.nation_lbl.Location = New System.Drawing.Point(210, 119)
        Me.nation_lbl.Name = "nation_lbl"
        Me.nation_lbl.Size = New System.Drawing.Size(62, 13)
        Me.nation_lbl.TabIndex = 47
        Me.nation_lbl.Text = "Nationality :"
        '
        'frth_nm_lbl
        '
        Me.frth_nm_lbl.AutoSize = True
        Me.frth_nm_lbl.Location = New System.Drawing.Point(7, 145)
        Me.frth_nm_lbl.Name = "frth_nm_lbl"
        Me.frth_nm_lbl.Size = New System.Drawing.Size(74, 13)
        Me.frth_nm_lbl.TabIndex = 41
        Me.frth_nm_lbl.Text = "Fourth Name :"
        '
        'adrs_txtbx
        '
        Me.adrs_txtbx.Location = New System.Drawing.Point(290, 90)
        Me.adrs_txtbx.Name = "adrs_txtbx"
        Me.adrs_txtbx.Size = New System.Drawing.Size(100, 20)
        Me.adrs_txtbx.TabIndex = 33
        Me.adrs_txtbx.Tag = "ImpoFields"
        '
        'thrd_nm_txtbx
        '
        Me.thrd_nm_txtbx.Location = New System.Drawing.Point(87, 116)
        Me.thrd_nm_txtbx.Name = "thrd_nm_txtbx"
        Me.thrd_nm_txtbx.Size = New System.Drawing.Size(100, 20)
        Me.thrd_nm_txtbx.TabIndex = 27
        '
        'adrs_lbl
        '
        Me.adrs_lbl.AutoSize = True
        Me.adrs_lbl.ForeColor = System.Drawing.Color.Maroon
        Me.adrs_lbl.Location = New System.Drawing.Point(210, 93)
        Me.adrs_lbl.Name = "adrs_lbl"
        Me.adrs_lbl.Size = New System.Drawing.Size(51, 13)
        Me.adrs_lbl.TabIndex = 46
        Me.adrs_lbl.Text = "Address :"
        '
        'thrd_nm_lbl
        '
        Me.thrd_nm_lbl.AutoSize = True
        Me.thrd_nm_lbl.Location = New System.Drawing.Point(7, 119)
        Me.thrd_nm_lbl.Name = "thrd_nm_lbl"
        Me.thrd_nm_lbl.Size = New System.Drawing.Size(68, 13)
        Me.thrd_nm_lbl.TabIndex = 40
        Me.thrd_nm_lbl.Text = "Third Name :"
        '
        'phn_no_txtbx
        '
        Me.phn_no_txtbx.Location = New System.Drawing.Point(290, 64)
        Me.phn_no_txtbx.Name = "phn_no_txtbx"
        Me.phn_no_txtbx.Size = New System.Drawing.Size(100, 20)
        Me.phn_no_txtbx.TabIndex = 32
        Me.phn_no_txtbx.Tag = "ImpoFields"
        '
        'scnd_nm_txtbx
        '
        Me.scnd_nm_txtbx.Location = New System.Drawing.Point(87, 90)
        Me.scnd_nm_txtbx.Name = "scnd_nm_txtbx"
        Me.scnd_nm_txtbx.Size = New System.Drawing.Size(100, 20)
        Me.scnd_nm_txtbx.TabIndex = 26
        Me.scnd_nm_txtbx.Tag = "ImpoFields"
        '
        'phn_no_lbl
        '
        Me.phn_no_lbl.AutoSize = True
        Me.phn_no_lbl.ForeColor = System.Drawing.Color.Maroon
        Me.phn_no_lbl.Location = New System.Drawing.Point(210, 67)
        Me.phn_no_lbl.Name = "phn_no_lbl"
        Me.phn_no_lbl.Size = New System.Drawing.Size(63, 13)
        Me.phn_no_lbl.TabIndex = 45
        Me.phn_no_lbl.Text = "Phone NO :"
        '
        'scnd_nm_lbl
        '
        Me.scnd_nm_lbl.AutoSize = True
        Me.scnd_nm_lbl.ForeColor = System.Drawing.Color.Maroon
        Me.scnd_nm_lbl.Location = New System.Drawing.Point(7, 93)
        Me.scnd_nm_lbl.Name = "scnd_nm_lbl"
        Me.scnd_nm_lbl.Size = New System.Drawing.Size(81, 13)
        Me.scnd_nm_lbl.TabIndex = 39
        Me.scnd_nm_lbl.Text = "Second Name :"
        '
        'frst_nm_txtbx
        '
        Me.frst_nm_txtbx.Location = New System.Drawing.Point(87, 64)
        Me.frst_nm_txtbx.Name = "frst_nm_txtbx"
        Me.frst_nm_txtbx.Size = New System.Drawing.Size(100, 20)
        Me.frst_nm_txtbx.TabIndex = 25
        Me.frst_nm_txtbx.Tag = "ImpoFields"
        '
        'gndr_lbl
        '
        Me.gndr_lbl.AutoSize = True
        Me.gndr_lbl.ForeColor = System.Drawing.Color.Maroon
        Me.gndr_lbl.Location = New System.Drawing.Point(210, 41)
        Me.gndr_lbl.Name = "gndr_lbl"
        Me.gndr_lbl.Size = New System.Drawing.Size(48, 13)
        Me.gndr_lbl.TabIndex = 44
        Me.gndr_lbl.Text = "Gender :"
        '
        'frst_nm_lbl
        '
        Me.frst_nm_lbl.AutoSize = True
        Me.frst_nm_lbl.ForeColor = System.Drawing.Color.Maroon
        Me.frst_nm_lbl.Location = New System.Drawing.Point(7, 67)
        Me.frst_nm_lbl.Name = "frst_nm_lbl"
        Me.frst_nm_lbl.Size = New System.Drawing.Size(63, 13)
        Me.frst_nm_lbl.TabIndex = 38
        Me.frst_nm_lbl.Text = "First Name :"
        '
        'dob_lbl
        '
        Me.dob_lbl.AutoSize = True
        Me.dob_lbl.ForeColor = System.Drawing.Color.Maroon
        Me.dob_lbl.Location = New System.Drawing.Point(210, 15)
        Me.dob_lbl.Name = "dob_lbl"
        Me.dob_lbl.Size = New System.Drawing.Size(74, 13)
        Me.dob_lbl.TabIndex = 43
        Me.dob_lbl.Text = "Date Of Birth :"
        '
        'cvl_id_txtbx
        '
        Me.cvl_id_txtbx.Location = New System.Drawing.Point(87, 12)
        Me.cvl_id_txtbx.Name = "cvl_id_txtbx"
        Me.cvl_id_txtbx.Size = New System.Drawing.Size(100, 20)
        Me.cvl_id_txtbx.TabIndex = 24
        Me.cvl_id_txtbx.Tag = "ImpoFields"
        '
        'cvl_id_lbl
        '
        Me.cvl_id_lbl.AutoSize = True
        Me.cvl_id_lbl.ForeColor = System.Drawing.Color.Maroon
        Me.cvl_id_lbl.Location = New System.Drawing.Point(7, 15)
        Me.cvl_id_lbl.Name = "cvl_id_lbl"
        Me.cvl_id_lbl.Size = New System.Drawing.Size(46, 13)
        Me.cvl_id_lbl.TabIndex = 37
        Me.cvl_id_lbl.Text = "Civil ID :"
        '
        'jb_lbl
        '
        Me.jb_lbl.AutoSize = True
        Me.jb_lbl.ForeColor = System.Drawing.Color.Maroon
        Me.jb_lbl.Location = New System.Drawing.Point(408, 16)
        Me.jb_lbl.Name = "jb_lbl"
        Me.jb_lbl.Size = New System.Drawing.Size(30, 13)
        Me.jb_lbl.TabIndex = 44
        Me.jb_lbl.Text = "Job :"
        '
        'jb_cbx
        '
        Me.jb_cbx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.jb_cbx.FormattingEnabled = True
        Me.jb_cbx.Items.AddRange(New Object() {"Doctor", "Nurse", "Receptionist", "Manager", "Accountant"})
        Me.jb_cbx.Location = New System.Drawing.Point(444, 11)
        Me.jb_cbx.Name = "jb_cbx"
        Me.jb_cbx.Size = New System.Drawing.Size(100, 21)
        Me.jb_cbx.TabIndex = 31
        Me.jb_cbx.Tag = "ImpoFields"
        '
        'prfx_lbl
        '
        Me.prfx_lbl.AutoSize = True
        Me.prfx_lbl.ForeColor = System.Drawing.Color.Maroon
        Me.prfx_lbl.Location = New System.Drawing.Point(7, 41)
        Me.prfx_lbl.Name = "prfx_lbl"
        Me.prfx_lbl.Size = New System.Drawing.Size(39, 13)
        Me.prfx_lbl.TabIndex = 37
        Me.prfx_lbl.Text = "Prefix :"
        '
        'prfx_cbx
        '
        Me.prfx_cbx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.prfx_cbx.FormattingEnabled = True
        Me.prfx_cbx.Items.AddRange(New Object() {"Mr", "Mrs", "Ms", "Dr"})
        Me.prfx_cbx.Location = New System.Drawing.Point(87, 37)
        Me.prfx_cbx.Name = "prfx_cbx"
        Me.prfx_cbx.Size = New System.Drawing.Size(100, 21)
        Me.prfx_cbx.TabIndex = 31
        Me.prfx_cbx.Tag = "ImpoFields"
        '
        'crd_grbbx
        '
        Me.crd_grbbx.Controls.Add(Me.repw_txtbx)
        Me.crd_grbbx.Controls.Add(Me.un_lbl)
        Me.crd_grbbx.Controls.Add(Me.un_txtbx)
        Me.crd_grbbx.Controls.Add(Me.pw_lbl)
        Me.crd_grbbx.Controls.Add(Me.pw_txtbx)
        Me.crd_grbbx.Controls.Add(Me.repw_lbl)
        Me.crd_grbbx.Location = New System.Drawing.Point(411, 41)
        Me.crd_grbbx.Name = "crd_grbbx"
        Me.crd_grbbx.Size = New System.Drawing.Size(210, 121)
        Me.crd_grbbx.TabIndex = 49
        Me.crd_grbbx.TabStop = False
        Me.crd_grbbx.Text = "User Credentials :"
        '
        'repw_txtbx
        '
        Me.repw_txtbx.Location = New System.Drawing.Point(89, 84)
        Me.repw_txtbx.Name = "repw_txtbx"
        Me.repw_txtbx.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.repw_txtbx.Size = New System.Drawing.Size(100, 20)
        Me.repw_txtbx.TabIndex = 27
        Me.repw_txtbx.Tag = ""
        '
        'un_lbl
        '
        Me.un_lbl.AutoSize = True
        Me.un_lbl.ForeColor = System.Drawing.Color.Maroon
        Me.un_lbl.Location = New System.Drawing.Point(9, 29)
        Me.un_lbl.Name = "un_lbl"
        Me.un_lbl.Size = New System.Drawing.Size(61, 13)
        Me.un_lbl.TabIndex = 38
        Me.un_lbl.Text = "Username :"
        '
        'un_txtbx
        '
        Me.un_txtbx.Location = New System.Drawing.Point(89, 26)
        Me.un_txtbx.Name = "un_txtbx"
        Me.un_txtbx.Size = New System.Drawing.Size(100, 20)
        Me.un_txtbx.TabIndex = 25
        Me.un_txtbx.Tag = ""
        '
        'pw_lbl
        '
        Me.pw_lbl.AutoSize = True
        Me.pw_lbl.ForeColor = System.Drawing.Color.Maroon
        Me.pw_lbl.Location = New System.Drawing.Point(9, 55)
        Me.pw_lbl.Name = "pw_lbl"
        Me.pw_lbl.Size = New System.Drawing.Size(59, 13)
        Me.pw_lbl.TabIndex = 39
        Me.pw_lbl.Text = "Password :"
        '
        'pw_txtbx
        '
        Me.pw_txtbx.Location = New System.Drawing.Point(89, 52)
        Me.pw_txtbx.Name = "pw_txtbx"
        Me.pw_txtbx.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.pw_txtbx.Size = New System.Drawing.Size(100, 20)
        Me.pw_txtbx.TabIndex = 26
        Me.pw_txtbx.Tag = ""
        '
        'repw_lbl
        '
        Me.repw_lbl.AutoSize = True
        Me.repw_lbl.ForeColor = System.Drawing.Color.Maroon
        Me.repw_lbl.Location = New System.Drawing.Point(9, 81)
        Me.repw_lbl.Name = "repw_lbl"
        Me.repw_lbl.Size = New System.Drawing.Size(59, 26)
        Me.repw_lbl.TabIndex = 40
        Me.repw_lbl.Text = "Reenter" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Passowrd :"
        '
        'stf_reg
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(641, 202)
        Me.Controls.Add(Me.crd_grbbx)
        Me.Controls.Add(Me.sbmt_btn)
        Me.Controls.Add(Me.prfx_cbx)
        Me.Controls.Add(Me.jb_cbx)
        Me.Controls.Add(Me.gndr_cbx)
        Me.Controls.Add(Me.dob_pkr)
        Me.Controls.Add(Me.eml_txtbx)
        Me.Controls.Add(Me.trib_nm_txtbx)
        Me.Controls.Add(Me.eml_lbl)
        Me.Controls.Add(Me.trib_nm_lbl)
        Me.Controls.Add(Me.nation_txtbx)
        Me.Controls.Add(Me.frth_nm_txtbx)
        Me.Controls.Add(Me.nation_lbl)
        Me.Controls.Add(Me.frth_nm_lbl)
        Me.Controls.Add(Me.adrs_txtbx)
        Me.Controls.Add(Me.thrd_nm_txtbx)
        Me.Controls.Add(Me.adrs_lbl)
        Me.Controls.Add(Me.thrd_nm_lbl)
        Me.Controls.Add(Me.phn_no_txtbx)
        Me.Controls.Add(Me.scnd_nm_txtbx)
        Me.Controls.Add(Me.phn_no_lbl)
        Me.Controls.Add(Me.scnd_nm_lbl)
        Me.Controls.Add(Me.jb_lbl)
        Me.Controls.Add(Me.frst_nm_txtbx)
        Me.Controls.Add(Me.gndr_lbl)
        Me.Controls.Add(Me.frst_nm_lbl)
        Me.Controls.Add(Me.dob_lbl)
        Me.Controls.Add(Me.prfx_lbl)
        Me.Controls.Add(Me.cvl_id_txtbx)
        Me.Controls.Add(Me.cvl_id_lbl)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(657, 241)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(657, 241)
        Me.Name = "stf_reg"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Staff Registraion"
        Me.crd_grbbx.ResumeLayout(False)
        Me.crd_grbbx.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents sbmt_btn As Button
    Friend WithEvents gndr_cbx As ComboBox
    Friend WithEvents dob_pkr As DateTimePicker
    Friend WithEvents eml_txtbx As TextBox
    Friend WithEvents trib_nm_txtbx As TextBox
    Friend WithEvents eml_lbl As Label
    Friend WithEvents trib_nm_lbl As Label
    Friend WithEvents nation_txtbx As TextBox
    Friend WithEvents frth_nm_txtbx As TextBox
    Friend WithEvents nation_lbl As Label
    Friend WithEvents frth_nm_lbl As Label
    Friend WithEvents adrs_txtbx As TextBox
    Friend WithEvents thrd_nm_txtbx As TextBox
    Friend WithEvents adrs_lbl As Label
    Friend WithEvents thrd_nm_lbl As Label
    Friend WithEvents phn_no_txtbx As TextBox
    Friend WithEvents scnd_nm_txtbx As TextBox
    Friend WithEvents phn_no_lbl As Label
    Friend WithEvents scnd_nm_lbl As Label
    Friend WithEvents frst_nm_txtbx As TextBox
    Friend WithEvents gndr_lbl As Label
    Friend WithEvents frst_nm_lbl As Label
    Friend WithEvents dob_lbl As Label
    Friend WithEvents cvl_id_txtbx As TextBox
    Friend WithEvents cvl_id_lbl As Label
    Friend WithEvents jb_lbl As Label
    Friend WithEvents jb_cbx As ComboBox
    Friend WithEvents prfx_lbl As Label
    Friend WithEvents prfx_cbx As ComboBox
    Friend WithEvents crd_grbbx As GroupBox
    Friend WithEvents repw_txtbx As TextBox
    Friend WithEvents un_lbl As Label
    Friend WithEvents un_txtbx As TextBox
    Friend WithEvents pw_lbl As Label
    Friend WithEvents pw_txtbx As TextBox
    Friend WithEvents repw_lbl As Label
End Class
