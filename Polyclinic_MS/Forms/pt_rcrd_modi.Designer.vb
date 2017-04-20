<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class pt_rcrd_modi
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(pt_rcrd_modi))
        Me.srch_grbbx = New System.Windows.Forms.GroupBox()
        Me.srch_txtbx = New System.Windows.Forms.TextBox()
        Me.rst_tbl_btn = New System.Windows.Forms.Button()
        Me.pt_pno_rbtn = New System.Windows.Forms.RadioButton()
        Me.pt_nm_rbtn = New System.Windows.Forms.RadioButton()
        Me.pt_cvl_id_rbtn = New System.Windows.Forms.RadioButton()
        Me.pt_id_rbtn = New System.Windows.Forms.RadioButton()
        Me.pt_rcrd_modi_grbbx = New System.Windows.Forms.GroupBox()
        Me.bld_typ_txtbx = New System.Windows.Forms.ComboBox()
        Me.bld_typ_lbl = New System.Windows.Forms.Label()
        Me.drp_btn = New System.Windows.Forms.Button()
        Me.update_btn = New System.Windows.Forms.Button()
        Me.prfx_cbx = New System.Windows.Forms.ComboBox()
        Me.gndr_cbx = New System.Windows.Forms.ComboBox()
        Me.id_txtbx = New System.Windows.Forms.TextBox()
        Me.cvl_id_txtbx = New System.Windows.Forms.TextBox()
        Me.dob_pkr = New System.Windows.Forms.DateTimePicker()
        Me.eml_txtbx = New System.Windows.Forms.TextBox()
        Me.prfx_lbl = New System.Windows.Forms.Label()
        Me.id_lbl = New System.Windows.Forms.Label()
        Me.eml_lbl = New System.Windows.Forms.Label()
        Me.cvl_id_lbl = New System.Windows.Forms.Label()
        Me.nation_txtbx = New System.Windows.Forms.TextBox()
        Me.frst_nm_lbl = New System.Windows.Forms.Label()
        Me.nation_lbl = New System.Windows.Forms.Label()
        Me.frst_nm_txtbx = New System.Windows.Forms.TextBox()
        Me.adrs_txtbx = New System.Windows.Forms.TextBox()
        Me.scnd_nm_lbl = New System.Windows.Forms.Label()
        Me.adrs_lbl = New System.Windows.Forms.Label()
        Me.scnd_nm_txtbx = New System.Windows.Forms.TextBox()
        Me.phn_no_txtbx = New System.Windows.Forms.TextBox()
        Me.trib_nm_txtbx = New System.Windows.Forms.TextBox()
        Me.phn_no_lbl = New System.Windows.Forms.Label()
        Me.thrd_nm_lbl = New System.Windows.Forms.Label()
        Me.gndr_lbl = New System.Windows.Forms.Label()
        Me.thrd_nm_txtbx = New System.Windows.Forms.TextBox()
        Me.dob_lbl = New System.Windows.Forms.Label()
        Me.trib_nm_lbl = New System.Windows.Forms.Label()
        Me.frth_nm_lbl = New System.Windows.Forms.Label()
        Me.frth_nm_txtbx = New System.Windows.Forms.TextBox()
        Me.pt_grid = New System.Windows.Forms.DataGridView()
        Me.srch_grbbx.SuspendLayout()
        Me.pt_rcrd_modi_grbbx.SuspendLayout()
        CType(Me.pt_grid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'srch_grbbx
        '
        Me.srch_grbbx.Controls.Add(Me.srch_txtbx)
        Me.srch_grbbx.Controls.Add(Me.rst_tbl_btn)
        Me.srch_grbbx.Controls.Add(Me.pt_pno_rbtn)
        Me.srch_grbbx.Controls.Add(Me.pt_nm_rbtn)
        Me.srch_grbbx.Controls.Add(Me.pt_cvl_id_rbtn)
        Me.srch_grbbx.Controls.Add(Me.pt_id_rbtn)
        Me.srch_grbbx.Location = New System.Drawing.Point(12, 12)
        Me.srch_grbbx.Name = "srch_grbbx"
        Me.srch_grbbx.Size = New System.Drawing.Size(293, 78)
        Me.srch_grbbx.TabIndex = 0
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
        'pt_pno_rbtn
        '
        Me.pt_pno_rbtn.AutoSize = True
        Me.pt_pno_rbtn.Location = New System.Drawing.Point(171, 19)
        Me.pt_pno_rbtn.Name = "pt_pno_rbtn"
        Me.pt_pno_rbtn.Size = New System.Drawing.Size(78, 17)
        Me.pt_pno_rbtn.TabIndex = 0
        Me.pt_pno_rbtn.TabStop = True
        Me.pt_pno_rbtn.Text = "Phone NO."
        Me.pt_pno_rbtn.UseVisualStyleBackColor = True
        '
        'pt_nm_rbtn
        '
        Me.pt_nm_rbtn.AutoSize = True
        Me.pt_nm_rbtn.Location = New System.Drawing.Point(112, 19)
        Me.pt_nm_rbtn.Name = "pt_nm_rbtn"
        Me.pt_nm_rbtn.Size = New System.Drawing.Size(53, 17)
        Me.pt_nm_rbtn.TabIndex = 0
        Me.pt_nm_rbtn.TabStop = True
        Me.pt_nm_rbtn.Text = "Name"
        Me.pt_nm_rbtn.UseVisualStyleBackColor = True
        '
        'pt_cvl_id_rbtn
        '
        Me.pt_cvl_id_rbtn.AutoSize = True
        Me.pt_cvl_id_rbtn.Location = New System.Drawing.Point(48, 19)
        Me.pt_cvl_id_rbtn.Name = "pt_cvl_id_rbtn"
        Me.pt_cvl_id_rbtn.Size = New System.Drawing.Size(58, 17)
        Me.pt_cvl_id_rbtn.TabIndex = 0
        Me.pt_cvl_id_rbtn.TabStop = True
        Me.pt_cvl_id_rbtn.Text = "Civil ID"
        Me.pt_cvl_id_rbtn.UseVisualStyleBackColor = True
        '
        'pt_id_rbtn
        '
        Me.pt_id_rbtn.AutoSize = True
        Me.pt_id_rbtn.Location = New System.Drawing.Point(6, 19)
        Me.pt_id_rbtn.Name = "pt_id_rbtn"
        Me.pt_id_rbtn.Size = New System.Drawing.Size(36, 17)
        Me.pt_id_rbtn.TabIndex = 0
        Me.pt_id_rbtn.TabStop = True
        Me.pt_id_rbtn.Text = "ID"
        Me.pt_id_rbtn.UseVisualStyleBackColor = True
        '
        'pt_rcrd_modi_grbbx
        '
        Me.pt_rcrd_modi_grbbx.Controls.Add(Me.bld_typ_txtbx)
        Me.pt_rcrd_modi_grbbx.Controls.Add(Me.bld_typ_lbl)
        Me.pt_rcrd_modi_grbbx.Controls.Add(Me.drp_btn)
        Me.pt_rcrd_modi_grbbx.Controls.Add(Me.update_btn)
        Me.pt_rcrd_modi_grbbx.Controls.Add(Me.prfx_cbx)
        Me.pt_rcrd_modi_grbbx.Controls.Add(Me.gndr_cbx)
        Me.pt_rcrd_modi_grbbx.Controls.Add(Me.id_txtbx)
        Me.pt_rcrd_modi_grbbx.Controls.Add(Me.cvl_id_txtbx)
        Me.pt_rcrd_modi_grbbx.Controls.Add(Me.dob_pkr)
        Me.pt_rcrd_modi_grbbx.Controls.Add(Me.eml_txtbx)
        Me.pt_rcrd_modi_grbbx.Controls.Add(Me.prfx_lbl)
        Me.pt_rcrd_modi_grbbx.Controls.Add(Me.id_lbl)
        Me.pt_rcrd_modi_grbbx.Controls.Add(Me.eml_lbl)
        Me.pt_rcrd_modi_grbbx.Controls.Add(Me.cvl_id_lbl)
        Me.pt_rcrd_modi_grbbx.Controls.Add(Me.nation_txtbx)
        Me.pt_rcrd_modi_grbbx.Controls.Add(Me.frst_nm_lbl)
        Me.pt_rcrd_modi_grbbx.Controls.Add(Me.nation_lbl)
        Me.pt_rcrd_modi_grbbx.Controls.Add(Me.frst_nm_txtbx)
        Me.pt_rcrd_modi_grbbx.Controls.Add(Me.adrs_txtbx)
        Me.pt_rcrd_modi_grbbx.Controls.Add(Me.scnd_nm_lbl)
        Me.pt_rcrd_modi_grbbx.Controls.Add(Me.adrs_lbl)
        Me.pt_rcrd_modi_grbbx.Controls.Add(Me.scnd_nm_txtbx)
        Me.pt_rcrd_modi_grbbx.Controls.Add(Me.phn_no_txtbx)
        Me.pt_rcrd_modi_grbbx.Controls.Add(Me.trib_nm_txtbx)
        Me.pt_rcrd_modi_grbbx.Controls.Add(Me.phn_no_lbl)
        Me.pt_rcrd_modi_grbbx.Controls.Add(Me.thrd_nm_lbl)
        Me.pt_rcrd_modi_grbbx.Controls.Add(Me.gndr_lbl)
        Me.pt_rcrd_modi_grbbx.Controls.Add(Me.thrd_nm_txtbx)
        Me.pt_rcrd_modi_grbbx.Controls.Add(Me.dob_lbl)
        Me.pt_rcrd_modi_grbbx.Controls.Add(Me.trib_nm_lbl)
        Me.pt_rcrd_modi_grbbx.Controls.Add(Me.frth_nm_lbl)
        Me.pt_rcrd_modi_grbbx.Controls.Add(Me.frth_nm_txtbx)
        Me.pt_rcrd_modi_grbbx.Location = New System.Drawing.Point(617, 12)
        Me.pt_rcrd_modi_grbbx.Name = "pt_rcrd_modi_grbbx"
        Me.pt_rcrd_modi_grbbx.Size = New System.Drawing.Size(200, 461)
        Me.pt_rcrd_modi_grbbx.TabIndex = 1
        Me.pt_rcrd_modi_grbbx.TabStop = False
        Me.pt_rcrd_modi_grbbx.Text = "Modify Patient Record"
        '
        'bld_typ_txtbx
        '
        Me.bld_typ_txtbx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.bld_typ_txtbx.FormattingEnabled = True
        Me.bld_typ_txtbx.Items.AddRange(New Object() {"O-positive", "O-negative", "A-positive", "A-negative", "B-positive", "B-negative", "AB-positive", "AB-negative"})
        Me.bld_typ_txtbx.Location = New System.Drawing.Point(94, 380)
        Me.bld_typ_txtbx.Name = "bld_typ_txtbx"
        Me.bld_typ_txtbx.Size = New System.Drawing.Size(102, 21)
        Me.bld_typ_txtbx.TabIndex = 69
        '
        'bld_typ_lbl
        '
        Me.bld_typ_lbl.AutoSize = True
        Me.bld_typ_lbl.Location = New System.Drawing.Point(14, 383)
        Me.bld_typ_lbl.Name = "bld_typ_lbl"
        Me.bld_typ_lbl.Size = New System.Drawing.Size(67, 13)
        Me.bld_typ_lbl.TabIndex = 68
        Me.bld_typ_lbl.Text = "Blood Type :"
        '
        'drp_btn
        '
        Me.drp_btn.Location = New System.Drawing.Point(6, 422)
        Me.drp_btn.Name = "drp_btn"
        Me.drp_btn.Size = New System.Drawing.Size(75, 23)
        Me.drp_btn.TabIndex = 53
        Me.drp_btn.Text = "Drop"
        Me.drp_btn.UseVisualStyleBackColor = True
        '
        'update_btn
        '
        Me.update_btn.Location = New System.Drawing.Point(119, 422)
        Me.update_btn.Name = "update_btn"
        Me.update_btn.Size = New System.Drawing.Size(75, 23)
        Me.update_btn.TabIndex = 53
        Me.update_btn.Text = "Modify"
        Me.update_btn.UseVisualStyleBackColor = True
        '
        'prfx_cbx
        '
        Me.prfx_cbx.FormattingEnabled = True
        Me.prfx_cbx.Items.AddRange(New Object() {"Mr", "Mrs", "Ms", "Dr"})
        Me.prfx_cbx.Location = New System.Drawing.Point(94, 68)
        Me.prfx_cbx.Name = "prfx_cbx"
        Me.prfx_cbx.Size = New System.Drawing.Size(100, 21)
        Me.prfx_cbx.TabIndex = 65
        Me.prfx_cbx.Tag = "ImpoFields"
        '
        'gndr_cbx
        '
        Me.gndr_cbx.FormattingEnabled = True
        Me.gndr_cbx.Items.AddRange(New Object() {"Male", "Female", "Other"})
        Me.gndr_cbx.Location = New System.Drawing.Point(94, 249)
        Me.gndr_cbx.Name = "gndr_cbx"
        Me.gndr_cbx.Size = New System.Drawing.Size(100, 21)
        Me.gndr_cbx.TabIndex = 47
        Me.gndr_cbx.Tag = "ImpoFields"
        '
        'id_txtbx
        '
        Me.id_txtbx.Location = New System.Drawing.Point(94, 19)
        Me.id_txtbx.Name = "id_txtbx"
        Me.id_txtbx.ReadOnly = True
        Me.id_txtbx.Size = New System.Drawing.Size(100, 20)
        Me.id_txtbx.TabIndex = 40
        Me.id_txtbx.Tag = "ImpoFields"
        '
        'cvl_id_txtbx
        '
        Me.cvl_id_txtbx.Location = New System.Drawing.Point(94, 42)
        Me.cvl_id_txtbx.Name = "cvl_id_txtbx"
        Me.cvl_id_txtbx.Size = New System.Drawing.Size(100, 20)
        Me.cvl_id_txtbx.TabIndex = 40
        Me.cvl_id_txtbx.Tag = "ImpoFields"
        '
        'dob_pkr
        '
        Me.dob_pkr.CustomFormat = "yyyy/MM/dd"
        Me.dob_pkr.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dob_pkr.Location = New System.Drawing.Point(94, 224)
        Me.dob_pkr.Name = "dob_pkr"
        Me.dob_pkr.Size = New System.Drawing.Size(100, 20)
        Me.dob_pkr.TabIndex = 46
        '
        'eml_txtbx
        '
        Me.eml_txtbx.Location = New System.Drawing.Point(94, 354)
        Me.eml_txtbx.Name = "eml_txtbx"
        Me.eml_txtbx.Size = New System.Drawing.Size(100, 20)
        Me.eml_txtbx.TabIndex = 51
        '
        'prfx_lbl
        '
        Me.prfx_lbl.AutoSize = True
        Me.prfx_lbl.ForeColor = System.Drawing.Color.Maroon
        Me.prfx_lbl.Location = New System.Drawing.Point(14, 72)
        Me.prfx_lbl.Name = "prfx_lbl"
        Me.prfx_lbl.Size = New System.Drawing.Size(39, 13)
        Me.prfx_lbl.TabIndex = 66
        Me.prfx_lbl.Text = "Prefix :"
        '
        'id_lbl
        '
        Me.id_lbl.AutoSize = True
        Me.id_lbl.ForeColor = System.Drawing.Color.Maroon
        Me.id_lbl.Location = New System.Drawing.Point(14, 22)
        Me.id_lbl.Name = "id_lbl"
        Me.id_lbl.Size = New System.Drawing.Size(60, 13)
        Me.id_lbl.TabIndex = 52
        Me.id_lbl.Text = "Patient ID :"
        '
        'eml_lbl
        '
        Me.eml_lbl.AutoSize = True
        Me.eml_lbl.Location = New System.Drawing.Point(14, 357)
        Me.eml_lbl.Name = "eml_lbl"
        Me.eml_lbl.Size = New System.Drawing.Size(42, 13)
        Me.eml_lbl.TabIndex = 64
        Me.eml_lbl.Text = "E-Mail :"
        '
        'cvl_id_lbl
        '
        Me.cvl_id_lbl.AutoSize = True
        Me.cvl_id_lbl.ForeColor = System.Drawing.Color.Maroon
        Me.cvl_id_lbl.Location = New System.Drawing.Point(14, 45)
        Me.cvl_id_lbl.Name = "cvl_id_lbl"
        Me.cvl_id_lbl.Size = New System.Drawing.Size(46, 13)
        Me.cvl_id_lbl.TabIndex = 52
        Me.cvl_id_lbl.Text = "Civil ID :"
        '
        'nation_txtbx
        '
        Me.nation_txtbx.Location = New System.Drawing.Point(94, 328)
        Me.nation_txtbx.Name = "nation_txtbx"
        Me.nation_txtbx.Size = New System.Drawing.Size(100, 20)
        Me.nation_txtbx.TabIndex = 50
        Me.nation_txtbx.Tag = "ImpoFields"
        '
        'frst_nm_lbl
        '
        Me.frst_nm_lbl.AutoSize = True
        Me.frst_nm_lbl.ForeColor = System.Drawing.Color.Maroon
        Me.frst_nm_lbl.Location = New System.Drawing.Point(14, 97)
        Me.frst_nm_lbl.Name = "frst_nm_lbl"
        Me.frst_nm_lbl.Size = New System.Drawing.Size(63, 13)
        Me.frst_nm_lbl.TabIndex = 54
        Me.frst_nm_lbl.Text = "First Name :"
        '
        'nation_lbl
        '
        Me.nation_lbl.AutoSize = True
        Me.nation_lbl.ForeColor = System.Drawing.Color.Maroon
        Me.nation_lbl.Location = New System.Drawing.Point(14, 331)
        Me.nation_lbl.Name = "nation_lbl"
        Me.nation_lbl.Size = New System.Drawing.Size(62, 13)
        Me.nation_lbl.TabIndex = 63
        Me.nation_lbl.Text = "Nationality :"
        '
        'frst_nm_txtbx
        '
        Me.frst_nm_txtbx.Location = New System.Drawing.Point(94, 94)
        Me.frst_nm_txtbx.Name = "frst_nm_txtbx"
        Me.frst_nm_txtbx.Size = New System.Drawing.Size(100, 20)
        Me.frst_nm_txtbx.TabIndex = 41
        Me.frst_nm_txtbx.Tag = "ImpoFields"
        '
        'adrs_txtbx
        '
        Me.adrs_txtbx.Location = New System.Drawing.Point(94, 302)
        Me.adrs_txtbx.Name = "adrs_txtbx"
        Me.adrs_txtbx.Size = New System.Drawing.Size(100, 20)
        Me.adrs_txtbx.TabIndex = 49
        Me.adrs_txtbx.Tag = "ImpoFields"
        '
        'scnd_nm_lbl
        '
        Me.scnd_nm_lbl.AutoSize = True
        Me.scnd_nm_lbl.ForeColor = System.Drawing.Color.Maroon
        Me.scnd_nm_lbl.Location = New System.Drawing.Point(13, 123)
        Me.scnd_nm_lbl.Name = "scnd_nm_lbl"
        Me.scnd_nm_lbl.Size = New System.Drawing.Size(81, 13)
        Me.scnd_nm_lbl.TabIndex = 55
        Me.scnd_nm_lbl.Text = "Second Name :"
        '
        'adrs_lbl
        '
        Me.adrs_lbl.AutoSize = True
        Me.adrs_lbl.ForeColor = System.Drawing.Color.Maroon
        Me.adrs_lbl.Location = New System.Drawing.Point(14, 305)
        Me.adrs_lbl.Name = "adrs_lbl"
        Me.adrs_lbl.Size = New System.Drawing.Size(51, 13)
        Me.adrs_lbl.TabIndex = 62
        Me.adrs_lbl.Text = "Address :"
        '
        'scnd_nm_txtbx
        '
        Me.scnd_nm_txtbx.Location = New System.Drawing.Point(94, 120)
        Me.scnd_nm_txtbx.Name = "scnd_nm_txtbx"
        Me.scnd_nm_txtbx.Size = New System.Drawing.Size(100, 20)
        Me.scnd_nm_txtbx.TabIndex = 42
        Me.scnd_nm_txtbx.Tag = "ImpoFields"
        '
        'phn_no_txtbx
        '
        Me.phn_no_txtbx.Location = New System.Drawing.Point(94, 276)
        Me.phn_no_txtbx.Name = "phn_no_txtbx"
        Me.phn_no_txtbx.Size = New System.Drawing.Size(100, 20)
        Me.phn_no_txtbx.TabIndex = 48
        Me.phn_no_txtbx.Tag = "ImpoFields"
        '
        'trib_nm_txtbx
        '
        Me.trib_nm_txtbx.Location = New System.Drawing.Point(94, 198)
        Me.trib_nm_txtbx.Name = "trib_nm_txtbx"
        Me.trib_nm_txtbx.Size = New System.Drawing.Size(100, 20)
        Me.trib_nm_txtbx.TabIndex = 45
        Me.trib_nm_txtbx.Tag = "ImpoFields"
        '
        'phn_no_lbl
        '
        Me.phn_no_lbl.AutoSize = True
        Me.phn_no_lbl.ForeColor = System.Drawing.Color.Maroon
        Me.phn_no_lbl.Location = New System.Drawing.Point(14, 279)
        Me.phn_no_lbl.Name = "phn_no_lbl"
        Me.phn_no_lbl.Size = New System.Drawing.Size(63, 13)
        Me.phn_no_lbl.TabIndex = 61
        Me.phn_no_lbl.Text = "Phone NO :"
        '
        'thrd_nm_lbl
        '
        Me.thrd_nm_lbl.AutoSize = True
        Me.thrd_nm_lbl.Location = New System.Drawing.Point(14, 149)
        Me.thrd_nm_lbl.Name = "thrd_nm_lbl"
        Me.thrd_nm_lbl.Size = New System.Drawing.Size(68, 13)
        Me.thrd_nm_lbl.TabIndex = 56
        Me.thrd_nm_lbl.Text = "Third Name :"
        '
        'gndr_lbl
        '
        Me.gndr_lbl.AutoSize = True
        Me.gndr_lbl.ForeColor = System.Drawing.Color.Maroon
        Me.gndr_lbl.Location = New System.Drawing.Point(14, 253)
        Me.gndr_lbl.Name = "gndr_lbl"
        Me.gndr_lbl.Size = New System.Drawing.Size(48, 13)
        Me.gndr_lbl.TabIndex = 60
        Me.gndr_lbl.Text = "Gender :"
        '
        'thrd_nm_txtbx
        '
        Me.thrd_nm_txtbx.Location = New System.Drawing.Point(94, 146)
        Me.thrd_nm_txtbx.Name = "thrd_nm_txtbx"
        Me.thrd_nm_txtbx.Size = New System.Drawing.Size(100, 20)
        Me.thrd_nm_txtbx.TabIndex = 43
        '
        'dob_lbl
        '
        Me.dob_lbl.AutoSize = True
        Me.dob_lbl.ForeColor = System.Drawing.Color.Maroon
        Me.dob_lbl.Location = New System.Drawing.Point(14, 227)
        Me.dob_lbl.Name = "dob_lbl"
        Me.dob_lbl.Size = New System.Drawing.Size(74, 13)
        Me.dob_lbl.TabIndex = 59
        Me.dob_lbl.Text = "Date Of Birth :"
        '
        'trib_nm_lbl
        '
        Me.trib_nm_lbl.AutoSize = True
        Me.trib_nm_lbl.ForeColor = System.Drawing.Color.Maroon
        Me.trib_nm_lbl.Location = New System.Drawing.Point(14, 201)
        Me.trib_nm_lbl.Name = "trib_nm_lbl"
        Me.trib_nm_lbl.Size = New System.Drawing.Size(68, 13)
        Me.trib_nm_lbl.TabIndex = 58
        Me.trib_nm_lbl.Text = "Tribe Name :"
        '
        'frth_nm_lbl
        '
        Me.frth_nm_lbl.AutoSize = True
        Me.frth_nm_lbl.Location = New System.Drawing.Point(14, 175)
        Me.frth_nm_lbl.Name = "frth_nm_lbl"
        Me.frth_nm_lbl.Size = New System.Drawing.Size(74, 13)
        Me.frth_nm_lbl.TabIndex = 57
        Me.frth_nm_lbl.Text = "Fourth Name :"
        '
        'frth_nm_txtbx
        '
        Me.frth_nm_txtbx.Location = New System.Drawing.Point(94, 172)
        Me.frth_nm_txtbx.Name = "frth_nm_txtbx"
        Me.frth_nm_txtbx.Size = New System.Drawing.Size(100, 20)
        Me.frth_nm_txtbx.TabIndex = 44
        '
        'pt_grid
        '
        Me.pt_grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.pt_grid.Location = New System.Drawing.Point(12, 96)
        Me.pt_grid.Name = "pt_grid"
        Me.pt_grid.Size = New System.Drawing.Size(599, 377)
        Me.pt_grid.TabIndex = 21
        '
        'pt_rcrd_modi
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(829, 485)
        Me.Controls.Add(Me.pt_grid)
        Me.Controls.Add(Me.pt_rcrd_modi_grbbx)
        Me.Controls.Add(Me.srch_grbbx)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "pt_rcrd_modi"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Patient Record Modification"
        Me.srch_grbbx.ResumeLayout(False)
        Me.srch_grbbx.PerformLayout()
        Me.pt_rcrd_modi_grbbx.ResumeLayout(False)
        Me.pt_rcrd_modi_grbbx.PerformLayout()
        CType(Me.pt_grid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents srch_grbbx As GroupBox
    Friend WithEvents srch_txtbx As TextBox
    Friend WithEvents rst_tbl_btn As Button
    Friend WithEvents pt_pno_rbtn As RadioButton
    Friend WithEvents pt_nm_rbtn As RadioButton
    Friend WithEvents pt_cvl_id_rbtn As RadioButton
    Friend WithEvents pt_id_rbtn As RadioButton
    Friend WithEvents pt_rcrd_modi_grbbx As GroupBox
    Friend WithEvents prfx_cbx As ComboBox
    Friend WithEvents prfx_lbl As Label
    Friend WithEvents update_btn As Button
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
    Friend WithEvents id_txtbx As TextBox
    Friend WithEvents id_lbl As Label
    Friend WithEvents drp_btn As Button
    Friend WithEvents bld_typ_lbl As Label
    Friend WithEvents pt_grid As DataGridView
    Friend WithEvents bld_typ_txtbx As ComboBox
End Class
