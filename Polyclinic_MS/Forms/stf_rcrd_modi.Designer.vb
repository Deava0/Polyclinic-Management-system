<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class stf_rcrd_modi
    Inherits System.Windows.Forms.Form

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(stf_rcrd_modi))
        Me.stf_rcrd_grid = New System.Windows.Forms.DataGridView()
        Me.drp_btn = New System.Windows.Forms.Button()
        Me.update_btn = New System.Windows.Forms.Button()
        Me.id_txtbx = New System.Windows.Forms.TextBox()
        Me.id_lbl = New System.Windows.Forms.Label()
        Me.stf_rcrd_modi_grbbx = New System.Windows.Forms.GroupBox()
        Me.jb_cbx = New System.Windows.Forms.ComboBox()
        Me.jb_lbl = New System.Windows.Forms.Label()
        Me.prfx_cbx = New System.Windows.Forms.ComboBox()
        Me.gndr_cbx = New System.Windows.Forms.ComboBox()
        Me.crd_grbbx = New System.Windows.Forms.GroupBox()
        Me.repw_txtbx = New System.Windows.Forms.TextBox()
        Me.un_lbl = New System.Windows.Forms.Label()
        Me.un_txtbx = New System.Windows.Forms.TextBox()
        Me.pw_lbl = New System.Windows.Forms.Label()
        Me.pw_txtbx = New System.Windows.Forms.TextBox()
        Me.repw_lbl = New System.Windows.Forms.Label()
        Me.dob_pkr = New System.Windows.Forms.DateTimePicker()
        Me.eml_txtbx = New System.Windows.Forms.TextBox()
        Me.eml_lbl = New System.Windows.Forms.Label()
        Me.nation_txtbx = New System.Windows.Forms.TextBox()
        Me.nation_lbl = New System.Windows.Forms.Label()
        Me.trib_nm_txtbx = New System.Windows.Forms.TextBox()
        Me.adrs_txtbx = New System.Windows.Forms.TextBox()
        Me.cvl_id_lbl = New System.Windows.Forms.Label()
        Me.adrs_lbl = New System.Windows.Forms.Label()
        Me.cvl_id_txtbx = New System.Windows.Forms.TextBox()
        Me.phn_no_txtbx = New System.Windows.Forms.TextBox()
        Me.trib_nm_lbl = New System.Windows.Forms.Label()
        Me.phn_no_lbl = New System.Windows.Forms.Label()
        Me.prfx_lbl = New System.Windows.Forms.Label()
        Me.frst_nm_lbl = New System.Windows.Forms.Label()
        Me.gndr_lbl = New System.Windows.Forms.Label()
        Me.frth_nm_txtbx = New System.Windows.Forms.TextBox()
        Me.dob_lbl = New System.Windows.Forms.Label()
        Me.frst_nm_txtbx = New System.Windows.Forms.TextBox()
        Me.scnd_nm_lbl = New System.Windows.Forms.Label()
        Me.frth_nm_lbl = New System.Windows.Forms.Label()
        Me.scnd_nm_txtbx = New System.Windows.Forms.TextBox()
        Me.thrd_nm_lbl = New System.Windows.Forms.Label()
        Me.thrd_nm_txtbx = New System.Windows.Forms.TextBox()
        Me.srch_grbbx = New System.Windows.Forms.GroupBox()
        Me.srch_txtbx = New System.Windows.Forms.TextBox()
        Me.rst_tbl_btn = New System.Windows.Forms.Button()
        Me.stf_pno_rbtn = New System.Windows.Forms.RadioButton()
        Me.stf_nm_rbtn = New System.Windows.Forms.RadioButton()
        Me.stf_cvl_id_rbtn = New System.Windows.Forms.RadioButton()
        Me.stf_id_rbtn = New System.Windows.Forms.RadioButton()
        CType(Me.stf_rcrd_grid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.stf_rcrd_modi_grbbx.SuspendLayout()
        Me.crd_grbbx.SuspendLayout()
        Me.srch_grbbx.SuspendLayout()
        Me.SuspendLayout()
        '
        'stf_rcrd_grid
        '
        Me.stf_rcrd_grid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.stf_rcrd_grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.stf_rcrd_grid.Location = New System.Drawing.Point(12, 96)
        Me.stf_rcrd_grid.Name = "stf_rcrd_grid"
        Me.stf_rcrd_grid.Size = New System.Drawing.Size(599, 485)
        Me.stf_rcrd_grid.TabIndex = 5
        '
        'drp_btn
        '
        Me.drp_btn.Location = New System.Drawing.Point(6, 538)
        Me.drp_btn.Name = "drp_btn"
        Me.drp_btn.Size = New System.Drawing.Size(75, 23)
        Me.drp_btn.TabIndex = 53
        Me.drp_btn.Text = "Drop"
        Me.drp_btn.UseVisualStyleBackColor = True
        '
        'update_btn
        '
        Me.update_btn.Location = New System.Drawing.Point(162, 538)
        Me.update_btn.Name = "update_btn"
        Me.update_btn.Size = New System.Drawing.Size(75, 23)
        Me.update_btn.TabIndex = 53
        Me.update_btn.Text = "Modify"
        Me.update_btn.UseVisualStyleBackColor = True
        '
        'id_txtbx
        '
        Me.id_txtbx.Location = New System.Drawing.Point(97, 18)
        Me.id_txtbx.Name = "id_txtbx"
        Me.id_txtbx.ReadOnly = True
        Me.id_txtbx.Size = New System.Drawing.Size(100, 20)
        Me.id_txtbx.TabIndex = 40
        '
        'id_lbl
        '
        Me.id_lbl.AutoSize = True
        Me.id_lbl.Location = New System.Drawing.Point(14, 22)
        Me.id_lbl.Name = "id_lbl"
        Me.id_lbl.Size = New System.Drawing.Size(49, 13)
        Me.id_lbl.TabIndex = 52
        Me.id_lbl.Text = "Staff ID :"
        '
        'stf_rcrd_modi_grbbx
        '
        Me.stf_rcrd_modi_grbbx.Controls.Add(Me.jb_cbx)
        Me.stf_rcrd_modi_grbbx.Controls.Add(Me.jb_lbl)
        Me.stf_rcrd_modi_grbbx.Controls.Add(Me.prfx_cbx)
        Me.stf_rcrd_modi_grbbx.Controls.Add(Me.gndr_cbx)
        Me.stf_rcrd_modi_grbbx.Controls.Add(Me.crd_grbbx)
        Me.stf_rcrd_modi_grbbx.Controls.Add(Me.dob_pkr)
        Me.stf_rcrd_modi_grbbx.Controls.Add(Me.drp_btn)
        Me.stf_rcrd_modi_grbbx.Controls.Add(Me.eml_txtbx)
        Me.stf_rcrd_modi_grbbx.Controls.Add(Me.update_btn)
        Me.stf_rcrd_modi_grbbx.Controls.Add(Me.eml_lbl)
        Me.stf_rcrd_modi_grbbx.Controls.Add(Me.id_txtbx)
        Me.stf_rcrd_modi_grbbx.Controls.Add(Me.nation_txtbx)
        Me.stf_rcrd_modi_grbbx.Controls.Add(Me.id_lbl)
        Me.stf_rcrd_modi_grbbx.Controls.Add(Me.nation_lbl)
        Me.stf_rcrd_modi_grbbx.Controls.Add(Me.trib_nm_txtbx)
        Me.stf_rcrd_modi_grbbx.Controls.Add(Me.adrs_txtbx)
        Me.stf_rcrd_modi_grbbx.Controls.Add(Me.cvl_id_lbl)
        Me.stf_rcrd_modi_grbbx.Controls.Add(Me.adrs_lbl)
        Me.stf_rcrd_modi_grbbx.Controls.Add(Me.cvl_id_txtbx)
        Me.stf_rcrd_modi_grbbx.Controls.Add(Me.phn_no_txtbx)
        Me.stf_rcrd_modi_grbbx.Controls.Add(Me.trib_nm_lbl)
        Me.stf_rcrd_modi_grbbx.Controls.Add(Me.phn_no_lbl)
        Me.stf_rcrd_modi_grbbx.Controls.Add(Me.prfx_lbl)
        Me.stf_rcrd_modi_grbbx.Controls.Add(Me.frst_nm_lbl)
        Me.stf_rcrd_modi_grbbx.Controls.Add(Me.gndr_lbl)
        Me.stf_rcrd_modi_grbbx.Controls.Add(Me.frth_nm_txtbx)
        Me.stf_rcrd_modi_grbbx.Controls.Add(Me.dob_lbl)
        Me.stf_rcrd_modi_grbbx.Controls.Add(Me.frst_nm_txtbx)
        Me.stf_rcrd_modi_grbbx.Controls.Add(Me.scnd_nm_lbl)
        Me.stf_rcrd_modi_grbbx.Controls.Add(Me.frth_nm_lbl)
        Me.stf_rcrd_modi_grbbx.Controls.Add(Me.scnd_nm_txtbx)
        Me.stf_rcrd_modi_grbbx.Controls.Add(Me.thrd_nm_lbl)
        Me.stf_rcrd_modi_grbbx.Controls.Add(Me.thrd_nm_txtbx)
        Me.stf_rcrd_modi_grbbx.Location = New System.Drawing.Point(617, 12)
        Me.stf_rcrd_modi_grbbx.Name = "stf_rcrd_modi_grbbx"
        Me.stf_rcrd_modi_grbbx.Size = New System.Drawing.Size(243, 572)
        Me.stf_rcrd_modi_grbbx.TabIndex = 4
        Me.stf_rcrd_modi_grbbx.TabStop = False
        Me.stf_rcrd_modi_grbbx.Text = "Modify Staff Record"
        '
        'jb_cbx
        '
        Me.jb_cbx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.jb_cbx.FormattingEnabled = True
        Me.jb_cbx.Items.AddRange(New Object() {"Doctor", "Nurse", "Receptionist", "Manager", "Accountant"})
        Me.jb_cbx.Location = New System.Drawing.Point(97, 384)
        Me.jb_cbx.Name = "jb_cbx"
        Me.jb_cbx.Size = New System.Drawing.Size(100, 21)
        Me.jb_cbx.TabIndex = 58
        Me.jb_cbx.Tag = "ImpoFields"
        '
        'jb_lbl
        '
        Me.jb_lbl.AutoSize = True
        Me.jb_lbl.ForeColor = System.Drawing.Color.Maroon
        Me.jb_lbl.Location = New System.Drawing.Point(17, 387)
        Me.jb_lbl.Name = "jb_lbl"
        Me.jb_lbl.Size = New System.Drawing.Size(30, 13)
        Me.jb_lbl.TabIndex = 72
        Me.jb_lbl.Text = "Job :"
        '
        'prfx_cbx
        '
        Me.prfx_cbx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.prfx_cbx.FormattingEnabled = True
        Me.prfx_cbx.Items.AddRange(New Object() {"Mr", "Mrs", "Ms", "Dr"})
        Me.prfx_cbx.Location = New System.Drawing.Point(97, 69)
        Me.prfx_cbx.Name = "prfx_cbx"
        Me.prfx_cbx.Size = New System.Drawing.Size(100, 21)
        Me.prfx_cbx.TabIndex = 57
        Me.prfx_cbx.Tag = "ImpoFields"
        '
        'gndr_cbx
        '
        Me.gndr_cbx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.gndr_cbx.FormattingEnabled = True
        Me.gndr_cbx.Items.AddRange(New Object() {"Male", "Female", "Other"})
        Me.gndr_cbx.Location = New System.Drawing.Point(97, 253)
        Me.gndr_cbx.Name = "gndr_cbx"
        Me.gndr_cbx.Size = New System.Drawing.Size(100, 21)
        Me.gndr_cbx.TabIndex = 59
        Me.gndr_cbx.Tag = "ImpoFields"
        '
        'crd_grbbx
        '
        Me.crd_grbbx.Controls.Add(Me.repw_txtbx)
        Me.crd_grbbx.Controls.Add(Me.un_lbl)
        Me.crd_grbbx.Controls.Add(Me.un_txtbx)
        Me.crd_grbbx.Controls.Add(Me.pw_lbl)
        Me.crd_grbbx.Controls.Add(Me.pw_txtbx)
        Me.crd_grbbx.Controls.Add(Me.repw_lbl)
        Me.crd_grbbx.Location = New System.Drawing.Point(20, 411)
        Me.crd_grbbx.Name = "crd_grbbx"
        Me.crd_grbbx.Size = New System.Drawing.Size(210, 121)
        Me.crd_grbbx.TabIndex = 78
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
        Me.repw_txtbx.Tag = "ImpoFields"
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
        Me.un_txtbx.Tag = "ImpoFields"
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
        Me.pw_txtbx.Tag = "ImpoFields"
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
        'dob_pkr
        '
        Me.dob_pkr.CustomFormat = "yyyy/MM/dd"
        Me.dob_pkr.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dob_pkr.Location = New System.Drawing.Point(97, 228)
        Me.dob_pkr.Name = "dob_pkr"
        Me.dob_pkr.Size = New System.Drawing.Size(100, 20)
        Me.dob_pkr.TabIndex = 56
        Me.dob_pkr.Tag = "ImpoFields"
        '
        'eml_txtbx
        '
        Me.eml_txtbx.Location = New System.Drawing.Point(97, 358)
        Me.eml_txtbx.Name = "eml_txtbx"
        Me.eml_txtbx.Size = New System.Drawing.Size(100, 20)
        Me.eml_txtbx.TabIndex = 63
        Me.eml_txtbx.Tag = "ImpoFields"
        '
        'eml_lbl
        '
        Me.eml_lbl.AutoSize = True
        Me.eml_lbl.ForeColor = System.Drawing.Color.Maroon
        Me.eml_lbl.Location = New System.Drawing.Point(17, 361)
        Me.eml_lbl.Name = "eml_lbl"
        Me.eml_lbl.Size = New System.Drawing.Size(42, 13)
        Me.eml_lbl.TabIndex = 77
        Me.eml_lbl.Text = "E-Mail :"
        '
        'nation_txtbx
        '
        Me.nation_txtbx.Location = New System.Drawing.Point(97, 332)
        Me.nation_txtbx.Name = "nation_txtbx"
        Me.nation_txtbx.Size = New System.Drawing.Size(100, 20)
        Me.nation_txtbx.TabIndex = 62
        Me.nation_txtbx.Tag = "ImpoFields"
        '
        'nation_lbl
        '
        Me.nation_lbl.AutoSize = True
        Me.nation_lbl.ForeColor = System.Drawing.Color.Maroon
        Me.nation_lbl.Location = New System.Drawing.Point(17, 335)
        Me.nation_lbl.Name = "nation_lbl"
        Me.nation_lbl.Size = New System.Drawing.Size(62, 13)
        Me.nation_lbl.TabIndex = 76
        Me.nation_lbl.Text = "Nationality :"
        '
        'trib_nm_txtbx
        '
        Me.trib_nm_txtbx.Location = New System.Drawing.Point(97, 200)
        Me.trib_nm_txtbx.Name = "trib_nm_txtbx"
        Me.trib_nm_txtbx.Size = New System.Drawing.Size(100, 20)
        Me.trib_nm_txtbx.TabIndex = 55
        Me.trib_nm_txtbx.Tag = "ImpoFields"
        '
        'adrs_txtbx
        '
        Me.adrs_txtbx.Location = New System.Drawing.Point(97, 306)
        Me.adrs_txtbx.Name = "adrs_txtbx"
        Me.adrs_txtbx.Size = New System.Drawing.Size(100, 20)
        Me.adrs_txtbx.TabIndex = 61
        Me.adrs_txtbx.Tag = "ImpoFields"
        '
        'cvl_id_lbl
        '
        Me.cvl_id_lbl.AutoSize = True
        Me.cvl_id_lbl.ForeColor = System.Drawing.Color.Maroon
        Me.cvl_id_lbl.Location = New System.Drawing.Point(17, 47)
        Me.cvl_id_lbl.Name = "cvl_id_lbl"
        Me.cvl_id_lbl.Size = New System.Drawing.Size(46, 13)
        Me.cvl_id_lbl.TabIndex = 65
        Me.cvl_id_lbl.Text = "Civil ID :"
        '
        'adrs_lbl
        '
        Me.adrs_lbl.AutoSize = True
        Me.adrs_lbl.ForeColor = System.Drawing.Color.Maroon
        Me.adrs_lbl.Location = New System.Drawing.Point(17, 309)
        Me.adrs_lbl.Name = "adrs_lbl"
        Me.adrs_lbl.Size = New System.Drawing.Size(51, 13)
        Me.adrs_lbl.TabIndex = 75
        Me.adrs_lbl.Text = "Address :"
        '
        'cvl_id_txtbx
        '
        Me.cvl_id_txtbx.Location = New System.Drawing.Point(97, 44)
        Me.cvl_id_txtbx.Name = "cvl_id_txtbx"
        Me.cvl_id_txtbx.Size = New System.Drawing.Size(100, 20)
        Me.cvl_id_txtbx.TabIndex = 50
        Me.cvl_id_txtbx.Tag = "ImpoFields"
        '
        'phn_no_txtbx
        '
        Me.phn_no_txtbx.Location = New System.Drawing.Point(97, 280)
        Me.phn_no_txtbx.Name = "phn_no_txtbx"
        Me.phn_no_txtbx.Size = New System.Drawing.Size(100, 20)
        Me.phn_no_txtbx.TabIndex = 60
        Me.phn_no_txtbx.Tag = "ImpoFields"
        '
        'trib_nm_lbl
        '
        Me.trib_nm_lbl.AutoSize = True
        Me.trib_nm_lbl.ForeColor = System.Drawing.Color.Maroon
        Me.trib_nm_lbl.Location = New System.Drawing.Point(17, 203)
        Me.trib_nm_lbl.Name = "trib_nm_lbl"
        Me.trib_nm_lbl.Size = New System.Drawing.Size(68, 13)
        Me.trib_nm_lbl.TabIndex = 70
        Me.trib_nm_lbl.Text = "Tribe Name :"
        '
        'phn_no_lbl
        '
        Me.phn_no_lbl.AutoSize = True
        Me.phn_no_lbl.ForeColor = System.Drawing.Color.Maroon
        Me.phn_no_lbl.Location = New System.Drawing.Point(17, 283)
        Me.phn_no_lbl.Name = "phn_no_lbl"
        Me.phn_no_lbl.Size = New System.Drawing.Size(63, 13)
        Me.phn_no_lbl.TabIndex = 74
        Me.phn_no_lbl.Text = "Phone NO :"
        '
        'prfx_lbl
        '
        Me.prfx_lbl.AutoSize = True
        Me.prfx_lbl.ForeColor = System.Drawing.Color.Maroon
        Me.prfx_lbl.Location = New System.Drawing.Point(17, 73)
        Me.prfx_lbl.Name = "prfx_lbl"
        Me.prfx_lbl.Size = New System.Drawing.Size(39, 13)
        Me.prfx_lbl.TabIndex = 64
        Me.prfx_lbl.Text = "Prefix :"
        '
        'frst_nm_lbl
        '
        Me.frst_nm_lbl.AutoSize = True
        Me.frst_nm_lbl.ForeColor = System.Drawing.Color.Maroon
        Me.frst_nm_lbl.Location = New System.Drawing.Point(17, 99)
        Me.frst_nm_lbl.Name = "frst_nm_lbl"
        Me.frst_nm_lbl.Size = New System.Drawing.Size(63, 13)
        Me.frst_nm_lbl.TabIndex = 66
        Me.frst_nm_lbl.Text = "First Name :"
        '
        'gndr_lbl
        '
        Me.gndr_lbl.AutoSize = True
        Me.gndr_lbl.ForeColor = System.Drawing.Color.Maroon
        Me.gndr_lbl.Location = New System.Drawing.Point(17, 257)
        Me.gndr_lbl.Name = "gndr_lbl"
        Me.gndr_lbl.Size = New System.Drawing.Size(48, 13)
        Me.gndr_lbl.TabIndex = 73
        Me.gndr_lbl.Text = "Gender :"
        '
        'frth_nm_txtbx
        '
        Me.frth_nm_txtbx.Location = New System.Drawing.Point(97, 174)
        Me.frth_nm_txtbx.Name = "frth_nm_txtbx"
        Me.frth_nm_txtbx.Size = New System.Drawing.Size(100, 20)
        Me.frth_nm_txtbx.TabIndex = 54
        '
        'dob_lbl
        '
        Me.dob_lbl.AutoSize = True
        Me.dob_lbl.ForeColor = System.Drawing.Color.Maroon
        Me.dob_lbl.Location = New System.Drawing.Point(17, 231)
        Me.dob_lbl.Name = "dob_lbl"
        Me.dob_lbl.Size = New System.Drawing.Size(74, 13)
        Me.dob_lbl.TabIndex = 71
        Me.dob_lbl.Text = "Date Of Birth :"
        '
        'frst_nm_txtbx
        '
        Me.frst_nm_txtbx.Location = New System.Drawing.Point(97, 96)
        Me.frst_nm_txtbx.Name = "frst_nm_txtbx"
        Me.frst_nm_txtbx.Size = New System.Drawing.Size(100, 20)
        Me.frst_nm_txtbx.TabIndex = 51
        Me.frst_nm_txtbx.Tag = "ImpoFields"
        '
        'scnd_nm_lbl
        '
        Me.scnd_nm_lbl.AutoSize = True
        Me.scnd_nm_lbl.ForeColor = System.Drawing.Color.Maroon
        Me.scnd_nm_lbl.Location = New System.Drawing.Point(16, 125)
        Me.scnd_nm_lbl.Name = "scnd_nm_lbl"
        Me.scnd_nm_lbl.Size = New System.Drawing.Size(81, 13)
        Me.scnd_nm_lbl.TabIndex = 67
        Me.scnd_nm_lbl.Text = "Second Name :"
        '
        'frth_nm_lbl
        '
        Me.frth_nm_lbl.AutoSize = True
        Me.frth_nm_lbl.Location = New System.Drawing.Point(17, 177)
        Me.frth_nm_lbl.Name = "frth_nm_lbl"
        Me.frth_nm_lbl.Size = New System.Drawing.Size(74, 13)
        Me.frth_nm_lbl.TabIndex = 69
        Me.frth_nm_lbl.Text = "Fourth Name :"
        '
        'scnd_nm_txtbx
        '
        Me.scnd_nm_txtbx.Location = New System.Drawing.Point(97, 122)
        Me.scnd_nm_txtbx.Name = "scnd_nm_txtbx"
        Me.scnd_nm_txtbx.Size = New System.Drawing.Size(100, 20)
        Me.scnd_nm_txtbx.TabIndex = 52
        Me.scnd_nm_txtbx.Tag = "ImpoFields"
        '
        'thrd_nm_lbl
        '
        Me.thrd_nm_lbl.AutoSize = True
        Me.thrd_nm_lbl.Location = New System.Drawing.Point(17, 151)
        Me.thrd_nm_lbl.Name = "thrd_nm_lbl"
        Me.thrd_nm_lbl.Size = New System.Drawing.Size(68, 13)
        Me.thrd_nm_lbl.TabIndex = 68
        Me.thrd_nm_lbl.Text = "Third Name :"
        '
        'thrd_nm_txtbx
        '
        Me.thrd_nm_txtbx.Location = New System.Drawing.Point(97, 148)
        Me.thrd_nm_txtbx.Name = "thrd_nm_txtbx"
        Me.thrd_nm_txtbx.Size = New System.Drawing.Size(100, 20)
        Me.thrd_nm_txtbx.TabIndex = 53
        '
        'srch_grbbx
        '
        Me.srch_grbbx.Controls.Add(Me.srch_txtbx)
        Me.srch_grbbx.Controls.Add(Me.rst_tbl_btn)
        Me.srch_grbbx.Controls.Add(Me.stf_pno_rbtn)
        Me.srch_grbbx.Controls.Add(Me.stf_nm_rbtn)
        Me.srch_grbbx.Controls.Add(Me.stf_cvl_id_rbtn)
        Me.srch_grbbx.Controls.Add(Me.stf_id_rbtn)
        Me.srch_grbbx.Location = New System.Drawing.Point(12, 12)
        Me.srch_grbbx.Name = "srch_grbbx"
        Me.srch_grbbx.Size = New System.Drawing.Size(293, 78)
        Me.srch_grbbx.TabIndex = 3
        Me.srch_grbbx.TabStop = False
        Me.srch_grbbx.Text = "Search"
        '
        'srch_txtbx
        '
        Me.srch_txtbx.Location = New System.Drawing.Point(6, 44)
        Me.srch_txtbx.Name = "srch_txtbx"
        Me.srch_txtbx.Size = New System.Drawing.Size(191, 20)
        Me.srch_txtbx.TabIndex = 2
        '
        'rst_tbl_btn
        '
        Me.rst_tbl_btn.Location = New System.Drawing.Point(212, 42)
        Me.rst_tbl_btn.Name = "rst_tbl_btn"
        Me.rst_tbl_btn.Size = New System.Drawing.Size(75, 23)
        Me.rst_tbl_btn.TabIndex = 1
        Me.rst_tbl_btn.Text = "Reset Table"
        Me.rst_tbl_btn.UseVisualStyleBackColor = True
        '
        'stf_pno_rbtn
        '
        Me.stf_pno_rbtn.AutoSize = True
        Me.stf_pno_rbtn.Location = New System.Drawing.Point(171, 19)
        Me.stf_pno_rbtn.Name = "stf_pno_rbtn"
        Me.stf_pno_rbtn.Size = New System.Drawing.Size(78, 17)
        Me.stf_pno_rbtn.TabIndex = 0
        Me.stf_pno_rbtn.TabStop = True
        Me.stf_pno_rbtn.Text = "Phone NO."
        Me.stf_pno_rbtn.UseVisualStyleBackColor = True
        '
        'stf_nm_rbtn
        '
        Me.stf_nm_rbtn.AutoSize = True
        Me.stf_nm_rbtn.Location = New System.Drawing.Point(112, 19)
        Me.stf_nm_rbtn.Name = "stf_nm_rbtn"
        Me.stf_nm_rbtn.Size = New System.Drawing.Size(53, 17)
        Me.stf_nm_rbtn.TabIndex = 0
        Me.stf_nm_rbtn.TabStop = True
        Me.stf_nm_rbtn.Text = "Name"
        Me.stf_nm_rbtn.UseVisualStyleBackColor = True
        '
        'stf_cvl_id_rbtn
        '
        Me.stf_cvl_id_rbtn.AutoSize = True
        Me.stf_cvl_id_rbtn.Location = New System.Drawing.Point(48, 19)
        Me.stf_cvl_id_rbtn.Name = "stf_cvl_id_rbtn"
        Me.stf_cvl_id_rbtn.Size = New System.Drawing.Size(58, 17)
        Me.stf_cvl_id_rbtn.TabIndex = 0
        Me.stf_cvl_id_rbtn.TabStop = True
        Me.stf_cvl_id_rbtn.Text = "Civil ID"
        Me.stf_cvl_id_rbtn.UseVisualStyleBackColor = True
        '
        'stf_id_rbtn
        '
        Me.stf_id_rbtn.AutoSize = True
        Me.stf_id_rbtn.Location = New System.Drawing.Point(6, 19)
        Me.stf_id_rbtn.Name = "stf_id_rbtn"
        Me.stf_id_rbtn.Size = New System.Drawing.Size(36, 17)
        Me.stf_id_rbtn.TabIndex = 0
        Me.stf_id_rbtn.TabStop = True
        Me.stf_id_rbtn.Text = "ID"
        Me.stf_id_rbtn.UseVisualStyleBackColor = True
        '
        'stf_rcrd_modi
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(879, 591)
        Me.Controls.Add(Me.stf_rcrd_grid)
        Me.Controls.Add(Me.stf_rcrd_modi_grbbx)
        Me.Controls.Add(Me.srch_grbbx)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "stf_rcrd_modi"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Staff Record Modification"
        CType(Me.stf_rcrd_grid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.stf_rcrd_modi_grbbx.ResumeLayout(False)
        Me.stf_rcrd_modi_grbbx.PerformLayout()
        Me.crd_grbbx.ResumeLayout(False)
        Me.crd_grbbx.PerformLayout()
        Me.srch_grbbx.ResumeLayout(False)
        Me.srch_grbbx.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents stf_rcrd_grid As DataGridView
    Friend WithEvents drp_btn As Button
    Friend WithEvents update_btn As Button
    Friend WithEvents id_txtbx As TextBox
    Friend WithEvents id_lbl As Label
    Friend WithEvents stf_rcrd_modi_grbbx As GroupBox
    Friend WithEvents srch_grbbx As GroupBox
    Friend WithEvents srch_txtbx As TextBox
    Friend WithEvents rst_tbl_btn As Button
    Friend WithEvents stf_pno_rbtn As RadioButton
    Friend WithEvents stf_nm_rbtn As RadioButton
    Friend WithEvents stf_cvl_id_rbtn As RadioButton
    Friend WithEvents stf_id_rbtn As RadioButton
    Friend WithEvents jb_cbx As ComboBox
    Friend WithEvents jb_lbl As Label
    Friend WithEvents prfx_cbx As ComboBox
    Friend WithEvents gndr_cbx As ComboBox
    Friend WithEvents crd_grbbx As GroupBox
    Friend WithEvents repw_txtbx As TextBox
    Friend WithEvents un_lbl As Label
    Friend WithEvents un_txtbx As TextBox
    Friend WithEvents pw_lbl As Label
    Friend WithEvents pw_txtbx As TextBox
    Friend WithEvents repw_lbl As Label
    Friend WithEvents dob_pkr As DateTimePicker
    Friend WithEvents eml_txtbx As TextBox
    Friend WithEvents eml_lbl As Label
    Friend WithEvents nation_txtbx As TextBox
    Friend WithEvents nation_lbl As Label
    Friend WithEvents trib_nm_txtbx As TextBox
    Friend WithEvents adrs_txtbx As TextBox
    Friend WithEvents cvl_id_lbl As Label
    Friend WithEvents adrs_lbl As Label
    Friend WithEvents cvl_id_txtbx As TextBox
    Friend WithEvents phn_no_txtbx As TextBox
    Friend WithEvents trib_nm_lbl As Label
    Friend WithEvents phn_no_lbl As Label
    Friend WithEvents prfx_lbl As Label
    Friend WithEvents frst_nm_lbl As Label
    Friend WithEvents gndr_lbl As Label
    Friend WithEvents frth_nm_txtbx As TextBox
    Friend WithEvents dob_lbl As Label
    Friend WithEvents frst_nm_txtbx As TextBox
    Friend WithEvents scnd_nm_lbl As Label
    Friend WithEvents frth_nm_lbl As Label
    Friend WithEvents scnd_nm_txtbx As TextBox
    Friend WithEvents thrd_nm_lbl As Label
    Friend WithEvents thrd_nm_txtbx As TextBox
End Class
