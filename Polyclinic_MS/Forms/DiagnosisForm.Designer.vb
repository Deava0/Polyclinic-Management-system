<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DiagnosisForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DiagnosisForm))
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.rfrsh_btn = New System.Windows.Forms.Button()
        Me.weight_lbl = New System.Windows.Forms.Label()
        Me.bld_pres_lbl = New System.Windows.Forms.Label()
        Me.bld_type_lbl = New System.Windows.Forms.Label()
        Me.height_lbl = New System.Windows.Forms.Label()
        Me.weight_txtbx = New System.Windows.Forms.TextBox()
        Me.height_txtbx = New System.Windows.Forms.TextBox()
        Me.bld_type_txtbx = New System.Windows.Forms.TextBox()
        Me.bld_pres_txtbx = New System.Windows.Forms.TextBox()
        Me.dia_sbmt_btn = New System.Windows.Forms.Button()
        Me.mdcn_grbbx = New System.Windows.Forms.GroupBox()
        Me.external_rdbx = New System.Windows.Forms.RadioButton()
        Me.internal_rdbx = New System.Windows.Forms.RadioButton()
        Me.add_prsc_rtxtbx = New System.Windows.Forms.RichTextBox()
        Me.add_dia_rtxtbx = New System.Windows.Forms.RichTextBox()
        Me.add_avtv_pt_nm_txtbx = New System.Windows.Forms.TextBox()
        Me.add_avtv_pt_age_txtbx = New System.Windows.Forms.TextBox()
        Me.add_avtv_pt_gndr_txtbx = New System.Windows.Forms.TextBox()
        Me.add_avtv_pt_cvl_id_txtbx = New System.Windows.Forms.TextBox()
        Me.add_avtv_pt_id_txtbx = New System.Windows.Forms.TextBox()
        Me.add_avtv_pt_nm_lbl = New System.Windows.Forms.Label()
        Me.add_avtv_pt_age_lbl = New System.Windows.Forms.Label()
        Me.add_avtv_pt_gndr_lbl = New System.Windows.Forms.Label()
        Me.add_avtv_pt_cvl_id_lbl = New System.Windows.Forms.Label()
        Me.add_prsc_lbl = New System.Windows.Forms.Label()
        Me.add_dia_lbl = New System.Windows.Forms.Label()
        Me.add_avtv_pt_id_lbl = New System.Windows.Forms.Label()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.TabControl2 = New System.Windows.Forms.TabControl()
        Me.TabPage4 = New System.Windows.Forms.TabPage()
        Me.new_apt_grbbx = New System.Windows.Forms.GroupBox()
        Me.apt_new_pt_cvl_id_rdiobtn = New System.Windows.Forms.RadioButton()
        Me.apt_new_pt_id_rdiobtn = New System.Windows.Forms.RadioButton()
        Me.apt_new_apt_tm_pick = New System.Windows.Forms.DateTimePicker()
        Me.apt_new_rsn_rchtxtbx = New System.Windows.Forms.RichTextBox()
        Me.apt_new_pt_nm_txtbx = New System.Windows.Forms.TextBox()
        Me.apt_new_pt_cvl_id_txtbx = New System.Windows.Forms.TextBox()
        Me.apt_new_sbmt_btn = New System.Windows.Forms.Button()
        Me.apt_new_rsn_lbl = New System.Windows.Forms.Label()
        Me.apt_new_pt_nm_lbl = New System.Windows.Forms.Label()
        Me.apt_new_apt_tm_lbl = New System.Windows.Forms.Label()
        Me.TabPage5 = New System.Windows.Forms.TabPage()
        Me.pt_grid = New System.Windows.Forms.DataGridView()
        Me.pt_dia_mod_srch_grbbx = New System.Windows.Forms.GroupBox()
        Me.apt_status_cmbobx = New System.Windows.Forms.ComboBox()
        Me.fltr_doct_id_txtbx = New System.Windows.Forms.TextBox()
        Me.fltr_pt_id_txtbx = New System.Windows.Forms.TextBox()
        Me.doct_id_chkbx = New System.Windows.Forms.CheckBox()
        Me.pt_id_chkbx = New System.Windows.Forms.CheckBox()
        Me.pt_dia_mod_all_btn = New System.Windows.Forms.Button()
        Me.pt_dia_mod_srch_btn = New System.Windows.Forms.Button()
        Me.pt_dia_mod_rst_today_btn = New System.Windows.Forms.Button()
        Me.pt_dia_mod_to_lbl = New System.Windows.Forms.Label()
        Me.pt_dia_mod_fltrby_lbl = New System.Windows.Forms.Label()
        Me.pt_dia_mod_frm_lbl = New System.Windows.Forms.Label()
        Me.pt_dia_mod_to_pkr = New System.Windows.Forms.DateTimePicker()
        Me.pt_dia_mod_frm_pkr = New System.Windows.Forms.DateTimePicker()
        Me.apt_mod_grbbx = New System.Windows.Forms.GroupBox()
        Me.apt_mod_apt_tm_picker = New System.Windows.Forms.DateTimePicker()
        Me.apt_mod_apt_rsn_rchtxtbx = New System.Windows.Forms.RichTextBox()
        Me.apt_mod_doct_name_txtbx = New System.Windows.Forms.TextBox()
        Me.apt_mod_pt_nm_txtbx = New System.Windows.Forms.TextBox()
        Me.apt_mod_doct_id_txtbx = New System.Windows.Forms.TextBox()
        Me.apt_mod_apt_id_txtbx = New System.Windows.Forms.TextBox()
        Me.apt_mod_pt_id_txtbx = New System.Windows.Forms.TextBox()
        Me.apt_mod_drp_btn = New System.Windows.Forms.Button()
        Me.apt_mod_update_btn = New System.Windows.Forms.Button()
        Me.apt_mod_doct_name_lbl = New System.Windows.Forms.Label()
        Me.apt_mod_apt_rsn_lbl = New System.Windows.Forms.Label()
        Me.apt_mod_pt_nm_lbl = New System.Windows.Forms.Label()
        Me.apt_mod_apt_id_lbl = New System.Windows.Forms.Label()
        Me.apt_mod_doct_id_lbl = New System.Windows.Forms.Label()
        Me.apt_mod_apt_tm_lbl = New System.Windows.Forms.Label()
        Me.apt_mod_pt_id_lbl = New System.Windows.Forms.Label()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.mdcn_grbbx.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.TabControl2.SuspendLayout()
        Me.TabPage4.SuspendLayout()
        Me.new_apt_grbbx.SuspendLayout()
        Me.TabPage5.SuspendLayout()
        CType(Me.pt_grid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pt_dia_mod_srch_grbbx.SuspendLayout()
        Me.apt_mod_grbbx.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1090, 507)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.rfrsh_btn)
        Me.TabPage1.Controls.Add(Me.weight_lbl)
        Me.TabPage1.Controls.Add(Me.bld_pres_lbl)
        Me.TabPage1.Controls.Add(Me.bld_type_lbl)
        Me.TabPage1.Controls.Add(Me.height_lbl)
        Me.TabPage1.Controls.Add(Me.weight_txtbx)
        Me.TabPage1.Controls.Add(Me.height_txtbx)
        Me.TabPage1.Controls.Add(Me.bld_type_txtbx)
        Me.TabPage1.Controls.Add(Me.bld_pres_txtbx)
        Me.TabPage1.Controls.Add(Me.dia_sbmt_btn)
        Me.TabPage1.Controls.Add(Me.mdcn_grbbx)
        Me.TabPage1.Controls.Add(Me.add_prsc_rtxtbx)
        Me.TabPage1.Controls.Add(Me.add_dia_rtxtbx)
        Me.TabPage1.Controls.Add(Me.add_avtv_pt_nm_txtbx)
        Me.TabPage1.Controls.Add(Me.add_avtv_pt_age_txtbx)
        Me.TabPage1.Controls.Add(Me.add_avtv_pt_gndr_txtbx)
        Me.TabPage1.Controls.Add(Me.add_avtv_pt_cvl_id_txtbx)
        Me.TabPage1.Controls.Add(Me.add_avtv_pt_id_txtbx)
        Me.TabPage1.Controls.Add(Me.add_avtv_pt_nm_lbl)
        Me.TabPage1.Controls.Add(Me.add_avtv_pt_age_lbl)
        Me.TabPage1.Controls.Add(Me.add_avtv_pt_gndr_lbl)
        Me.TabPage1.Controls.Add(Me.add_avtv_pt_cvl_id_lbl)
        Me.TabPage1.Controls.Add(Me.add_prsc_lbl)
        Me.TabPage1.Controls.Add(Me.add_dia_lbl)
        Me.TabPage1.Controls.Add(Me.add_avtv_pt_id_lbl)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(1082, 481)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Patient Diagnosis"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'rfrsh_btn
        '
        Me.rfrsh_btn.BackgroundImage = CType(resources.GetObject("rfrsh_btn.BackgroundImage"), System.Drawing.Image)
        Me.rfrsh_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.rfrsh_btn.Location = New System.Drawing.Point(1019, 14)
        Me.rfrsh_btn.Name = "rfrsh_btn"
        Me.rfrsh_btn.Size = New System.Drawing.Size(46, 47)
        Me.rfrsh_btn.TabIndex = 27
        Me.rfrsh_btn.UseVisualStyleBackColor = True
        '
        'weight_lbl
        '
        Me.weight_lbl.AutoSize = True
        Me.weight_lbl.Location = New System.Drawing.Point(841, 40)
        Me.weight_lbl.Name = "weight_lbl"
        Me.weight_lbl.Size = New System.Drawing.Size(47, 13)
        Me.weight_lbl.TabIndex = 23
        Me.weight_lbl.Text = "Weight :"
        '
        'bld_pres_lbl
        '
        Me.bld_pres_lbl.AutoSize = True
        Me.bld_pres_lbl.Location = New System.Drawing.Point(489, 40)
        Me.bld_pres_lbl.Name = "bld_pres_lbl"
        Me.bld_pres_lbl.Size = New System.Drawing.Size(84, 13)
        Me.bld_pres_lbl.TabIndex = 24
        Me.bld_pres_lbl.Text = "Blood Pressure :"
        '
        'bld_type_lbl
        '
        Me.bld_type_lbl.AutoSize = True
        Me.bld_type_lbl.Location = New System.Drawing.Point(310, 40)
        Me.bld_type_lbl.Name = "bld_type_lbl"
        Me.bld_type_lbl.Size = New System.Drawing.Size(67, 13)
        Me.bld_type_lbl.TabIndex = 25
        Me.bld_type_lbl.Text = "Blood Type :"
        '
        'height_lbl
        '
        Me.height_lbl.AutoSize = True
        Me.height_lbl.Location = New System.Drawing.Point(685, 40)
        Me.height_lbl.Name = "height_lbl"
        Me.height_lbl.Size = New System.Drawing.Size(44, 13)
        Me.height_lbl.TabIndex = 26
        Me.height_lbl.Text = "Height :"
        '
        'weight_txtbx
        '
        Me.weight_txtbx.Location = New System.Drawing.Point(894, 37)
        Me.weight_txtbx.Name = "weight_txtbx"
        Me.weight_txtbx.ReadOnly = True
        Me.weight_txtbx.Size = New System.Drawing.Size(100, 20)
        Me.weight_txtbx.TabIndex = 19
        '
        'height_txtbx
        '
        Me.height_txtbx.Location = New System.Drawing.Point(735, 37)
        Me.height_txtbx.Name = "height_txtbx"
        Me.height_txtbx.ReadOnly = True
        Me.height_txtbx.Size = New System.Drawing.Size(100, 20)
        Me.height_txtbx.TabIndex = 20
        '
        'bld_type_txtbx
        '
        Me.bld_type_txtbx.Location = New System.Drawing.Point(383, 37)
        Me.bld_type_txtbx.Name = "bld_type_txtbx"
        Me.bld_type_txtbx.ReadOnly = True
        Me.bld_type_txtbx.Size = New System.Drawing.Size(100, 20)
        Me.bld_type_txtbx.TabIndex = 21
        '
        'bld_pres_txtbx
        '
        Me.bld_pres_txtbx.Location = New System.Drawing.Point(579, 37)
        Me.bld_pres_txtbx.Name = "bld_pres_txtbx"
        Me.bld_pres_txtbx.ReadOnly = True
        Me.bld_pres_txtbx.Size = New System.Drawing.Size(100, 20)
        Me.bld_pres_txtbx.TabIndex = 21
        '
        'dia_sbmt_btn
        '
        Me.dia_sbmt_btn.Location = New System.Drawing.Point(990, 149)
        Me.dia_sbmt_btn.Name = "dia_sbmt_btn"
        Me.dia_sbmt_btn.Size = New System.Drawing.Size(75, 23)
        Me.dia_sbmt_btn.TabIndex = 18
        Me.dia_sbmt_btn.Text = "Submit"
        Me.dia_sbmt_btn.UseVisualStyleBackColor = True
        '
        'mdcn_grbbx
        '
        Me.mdcn_grbbx.Controls.Add(Me.external_rdbx)
        Me.mdcn_grbbx.Controls.Add(Me.internal_rdbx)
        Me.mdcn_grbbx.ForeColor = System.Drawing.Color.Maroon
        Me.mdcn_grbbx.Location = New System.Drawing.Point(846, 67)
        Me.mdcn_grbbx.Name = "mdcn_grbbx"
        Me.mdcn_grbbx.Size = New System.Drawing.Size(173, 76)
        Me.mdcn_grbbx.TabIndex = 17
        Me.mdcn_grbbx.TabStop = False
        Me.mdcn_grbbx.Text = "Medicine :"
        '
        'external_rdbx
        '
        Me.external_rdbx.AutoSize = True
        Me.external_rdbx.Location = New System.Drawing.Point(7, 44)
        Me.external_rdbx.Name = "external_rdbx"
        Me.external_rdbx.Size = New System.Drawing.Size(113, 17)
        Me.external_rdbx.TabIndex = 1
        Me.external_rdbx.TabStop = True
        Me.external_rdbx.Text = "External Pharmacy"
        Me.external_rdbx.UseVisualStyleBackColor = True
        '
        'internal_rdbx
        '
        Me.internal_rdbx.AutoSize = True
        Me.internal_rdbx.Location = New System.Drawing.Point(7, 20)
        Me.internal_rdbx.Name = "internal_rdbx"
        Me.internal_rdbx.Size = New System.Drawing.Size(159, 17)
        Me.internal_rdbx.TabIndex = 0
        Me.internal_rdbx.TabStop = True
        Me.internal_rdbx.Text = "Internal(In-House) Pharmacy"
        Me.internal_rdbx.UseVisualStyleBackColor = True
        '
        'add_prsc_rtxtbx
        '
        Me.add_prsc_rtxtbx.Location = New System.Drawing.Point(493, 67)
        Me.add_prsc_rtxtbx.Name = "add_prsc_rtxtbx"
        Me.add_prsc_rtxtbx.Size = New System.Drawing.Size(347, 330)
        Me.add_prsc_rtxtbx.TabIndex = 15
        Me.add_prsc_rtxtbx.Tag = "Impo"
        Me.add_prsc_rtxtbx.Text = ""
        '
        'add_dia_rtxtbx
        '
        Me.add_dia_rtxtbx.Location = New System.Drawing.Point(74, 67)
        Me.add_dia_rtxtbx.Name = "add_dia_rtxtbx"
        Me.add_dia_rtxtbx.Size = New System.Drawing.Size(347, 330)
        Me.add_dia_rtxtbx.TabIndex = 16
        Me.add_dia_rtxtbx.Tag = "Impo"
        Me.add_dia_rtxtbx.Text = ""
        '
        'add_avtv_pt_nm_txtbx
        '
        Me.add_avtv_pt_nm_txtbx.Location = New System.Drawing.Point(452, 11)
        Me.add_avtv_pt_nm_txtbx.Name = "add_avtv_pt_nm_txtbx"
        Me.add_avtv_pt_nm_txtbx.ReadOnly = True
        Me.add_avtv_pt_nm_txtbx.Size = New System.Drawing.Size(227, 20)
        Me.add_avtv_pt_nm_txtbx.TabIndex = 10
        '
        'add_avtv_pt_age_txtbx
        '
        Me.add_avtv_pt_age_txtbx.Location = New System.Drawing.Point(208, 37)
        Me.add_avtv_pt_age_txtbx.Name = "add_avtv_pt_age_txtbx"
        Me.add_avtv_pt_age_txtbx.ReadOnly = True
        Me.add_avtv_pt_age_txtbx.Size = New System.Drawing.Size(100, 20)
        Me.add_avtv_pt_age_txtbx.TabIndex = 11
        '
        'add_avtv_pt_gndr_txtbx
        '
        Me.add_avtv_pt_gndr_txtbx.Location = New System.Drawing.Point(61, 37)
        Me.add_avtv_pt_gndr_txtbx.Name = "add_avtv_pt_gndr_txtbx"
        Me.add_avtv_pt_gndr_txtbx.ReadOnly = True
        Me.add_avtv_pt_gndr_txtbx.Size = New System.Drawing.Size(100, 20)
        Me.add_avtv_pt_gndr_txtbx.TabIndex = 12
        '
        'add_avtv_pt_cvl_id_txtbx
        '
        Me.add_avtv_pt_cvl_id_txtbx.Location = New System.Drawing.Point(263, 11)
        Me.add_avtv_pt_cvl_id_txtbx.Name = "add_avtv_pt_cvl_id_txtbx"
        Me.add_avtv_pt_cvl_id_txtbx.ReadOnly = True
        Me.add_avtv_pt_cvl_id_txtbx.Size = New System.Drawing.Size(100, 20)
        Me.add_avtv_pt_cvl_id_txtbx.TabIndex = 13
        '
        'add_avtv_pt_id_txtbx
        '
        Me.add_avtv_pt_id_txtbx.Location = New System.Drawing.Point(69, 11)
        Me.add_avtv_pt_id_txtbx.Name = "add_avtv_pt_id_txtbx"
        Me.add_avtv_pt_id_txtbx.ReadOnly = True
        Me.add_avtv_pt_id_txtbx.Size = New System.Drawing.Size(92, 20)
        Me.add_avtv_pt_id_txtbx.TabIndex = 14
        '
        'add_avtv_pt_nm_lbl
        '
        Me.add_avtv_pt_nm_lbl.AutoSize = True
        Me.add_avtv_pt_nm_lbl.Location = New System.Drawing.Point(369, 14)
        Me.add_avtv_pt_nm_lbl.Name = "add_avtv_pt_nm_lbl"
        Me.add_avtv_pt_nm_lbl.Size = New System.Drawing.Size(77, 13)
        Me.add_avtv_pt_nm_lbl.TabIndex = 3
        Me.add_avtv_pt_nm_lbl.Text = "Patient Name :"
        '
        'add_avtv_pt_age_lbl
        '
        Me.add_avtv_pt_age_lbl.AutoSize = True
        Me.add_avtv_pt_age_lbl.Location = New System.Drawing.Point(167, 40)
        Me.add_avtv_pt_age_lbl.Name = "add_avtv_pt_age_lbl"
        Me.add_avtv_pt_age_lbl.Size = New System.Drawing.Size(35, 13)
        Me.add_avtv_pt_age_lbl.TabIndex = 4
        Me.add_avtv_pt_age_lbl.Text = "Age  :"
        '
        'add_avtv_pt_gndr_lbl
        '
        Me.add_avtv_pt_gndr_lbl.AutoSize = True
        Me.add_avtv_pt_gndr_lbl.Location = New System.Drawing.Point(4, 40)
        Me.add_avtv_pt_gndr_lbl.Name = "add_avtv_pt_gndr_lbl"
        Me.add_avtv_pt_gndr_lbl.Size = New System.Drawing.Size(51, 13)
        Me.add_avtv_pt_gndr_lbl.TabIndex = 5
        Me.add_avtv_pt_gndr_lbl.Text = "Gender  :"
        '
        'add_avtv_pt_cvl_id_lbl
        '
        Me.add_avtv_pt_cvl_id_lbl.AutoSize = True
        Me.add_avtv_pt_cvl_id_lbl.Location = New System.Drawing.Point(175, 14)
        Me.add_avtv_pt_cvl_id_lbl.Name = "add_avtv_pt_cvl_id_lbl"
        Me.add_avtv_pt_cvl_id_lbl.Size = New System.Drawing.Size(82, 13)
        Me.add_avtv_pt_cvl_id_lbl.TabIndex = 6
        Me.add_avtv_pt_cvl_id_lbl.Text = "Patient Civil ID :"
        '
        'add_prsc_lbl
        '
        Me.add_prsc_lbl.AutoSize = True
        Me.add_prsc_lbl.ForeColor = System.Drawing.Color.Maroon
        Me.add_prsc_lbl.Location = New System.Drawing.Point(422, 67)
        Me.add_prsc_lbl.Name = "add_prsc_lbl"
        Me.add_prsc_lbl.Size = New System.Drawing.Size(71, 13)
        Me.add_prsc_lbl.TabIndex = 7
        Me.add_prsc_lbl.Text = "Prescription  :"
        '
        'add_dia_lbl
        '
        Me.add_dia_lbl.AutoSize = True
        Me.add_dia_lbl.ForeColor = System.Drawing.Color.Maroon
        Me.add_dia_lbl.Location = New System.Drawing.Point(8, 67)
        Me.add_dia_lbl.Name = "add_dia_lbl"
        Me.add_dia_lbl.Size = New System.Drawing.Size(62, 13)
        Me.add_dia_lbl.TabIndex = 8
        Me.add_dia_lbl.Text = "Diagnosis  :"
        '
        'add_avtv_pt_id_lbl
        '
        Me.add_avtv_pt_id_lbl.AutoSize = True
        Me.add_avtv_pt_id_lbl.Location = New System.Drawing.Point(3, 14)
        Me.add_avtv_pt_id_lbl.Name = "add_avtv_pt_id_lbl"
        Me.add_avtv_pt_id_lbl.Size = New System.Drawing.Size(60, 13)
        Me.add_avtv_pt_id_lbl.TabIndex = 9
        Me.add_avtv_pt_id_lbl.Text = "Patient ID :"
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.TabControl2)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(1082, 481)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Appointments"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'TabControl2
        '
        Me.TabControl2.Controls.Add(Me.TabPage4)
        Me.TabControl2.Controls.Add(Me.TabPage5)
        Me.TabControl2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl2.Location = New System.Drawing.Point(3, 3)
        Me.TabControl2.Name = "TabControl2"
        Me.TabControl2.SelectedIndex = 0
        Me.TabControl2.Size = New System.Drawing.Size(1076, 475)
        Me.TabControl2.TabIndex = 0
        '
        'TabPage4
        '
        Me.TabPage4.Controls.Add(Me.new_apt_grbbx)
        Me.TabPage4.Location = New System.Drawing.Point(4, 22)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage4.Size = New System.Drawing.Size(1068, 449)
        Me.TabPage4.TabIndex = 0
        Me.TabPage4.Text = "New Appointment"
        Me.TabPage4.UseVisualStyleBackColor = True
        '
        'new_apt_grbbx
        '
        Me.new_apt_grbbx.Controls.Add(Me.apt_new_pt_cvl_id_rdiobtn)
        Me.new_apt_grbbx.Controls.Add(Me.apt_new_pt_id_rdiobtn)
        Me.new_apt_grbbx.Controls.Add(Me.apt_new_apt_tm_pick)
        Me.new_apt_grbbx.Controls.Add(Me.apt_new_rsn_rchtxtbx)
        Me.new_apt_grbbx.Controls.Add(Me.apt_new_pt_nm_txtbx)
        Me.new_apt_grbbx.Controls.Add(Me.apt_new_pt_cvl_id_txtbx)
        Me.new_apt_grbbx.Controls.Add(Me.apt_new_sbmt_btn)
        Me.new_apt_grbbx.Controls.Add(Me.apt_new_rsn_lbl)
        Me.new_apt_grbbx.Controls.Add(Me.apt_new_pt_nm_lbl)
        Me.new_apt_grbbx.Controls.Add(Me.apt_new_apt_tm_lbl)
        Me.new_apt_grbbx.Location = New System.Drawing.Point(6, 6)
        Me.new_apt_grbbx.Name = "new_apt_grbbx"
        Me.new_apt_grbbx.Size = New System.Drawing.Size(456, 274)
        Me.new_apt_grbbx.TabIndex = 0
        Me.new_apt_grbbx.TabStop = False
        Me.new_apt_grbbx.Text = "Add New Appointment"
        '
        'apt_new_pt_cvl_id_rdiobtn
        '
        Me.apt_new_pt_cvl_id_rdiobtn.AutoSize = True
        Me.apt_new_pt_cvl_id_rdiobtn.Location = New System.Drawing.Point(9, 19)
        Me.apt_new_pt_cvl_id_rdiobtn.Name = "apt_new_pt_cvl_id_rdiobtn"
        Me.apt_new_pt_cvl_id_rdiobtn.Size = New System.Drawing.Size(100, 17)
        Me.apt_new_pt_cvl_id_rdiobtn.TabIndex = 7
        Me.apt_new_pt_cvl_id_rdiobtn.TabStop = True
        Me.apt_new_pt_cvl_id_rdiobtn.Text = "Patient Civil ID :"
        Me.apt_new_pt_cvl_id_rdiobtn.UseVisualStyleBackColor = True
        '
        'apt_new_pt_id_rdiobtn
        '
        Me.apt_new_pt_id_rdiobtn.AutoSize = True
        Me.apt_new_pt_id_rdiobtn.Location = New System.Drawing.Point(115, 19)
        Me.apt_new_pt_id_rdiobtn.Name = "apt_new_pt_id_rdiobtn"
        Me.apt_new_pt_id_rdiobtn.Size = New System.Drawing.Size(78, 17)
        Me.apt_new_pt_id_rdiobtn.TabIndex = 7
        Me.apt_new_pt_id_rdiobtn.TabStop = True
        Me.apt_new_pt_id_rdiobtn.Text = "Patient ID :"
        Me.apt_new_pt_id_rdiobtn.UseVisualStyleBackColor = True
        '
        'apt_new_apt_tm_pick
        '
        Me.apt_new_apt_tm_pick.CustomFormat = "yyyy/MM/dd hh:mm:ss"
        Me.apt_new_apt_tm_pick.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.apt_new_apt_tm_pick.Location = New System.Drawing.Point(103, 238)
        Me.apt_new_apt_tm_pick.Name = "apt_new_apt_tm_pick"
        Me.apt_new_apt_tm_pick.Size = New System.Drawing.Size(162, 20)
        Me.apt_new_apt_tm_pick.TabIndex = 6
        '
        'apt_new_rsn_rchtxtbx
        '
        Me.apt_new_rsn_rchtxtbx.Location = New System.Drawing.Point(65, 96)
        Me.apt_new_rsn_rchtxtbx.Name = "apt_new_rsn_rchtxtbx"
        Me.apt_new_rsn_rchtxtbx.Size = New System.Drawing.Size(372, 138)
        Me.apt_new_rsn_rchtxtbx.TabIndex = 5
        Me.apt_new_rsn_rchtxtbx.Tag = "Impo"
        Me.apt_new_rsn_rchtxtbx.Text = ""
        '
        'apt_new_pt_nm_txtbx
        '
        Me.apt_new_pt_nm_txtbx.Location = New System.Drawing.Point(82, 70)
        Me.apt_new_pt_nm_txtbx.Name = "apt_new_pt_nm_txtbx"
        Me.apt_new_pt_nm_txtbx.ReadOnly = True
        Me.apt_new_pt_nm_txtbx.Size = New System.Drawing.Size(355, 20)
        Me.apt_new_pt_nm_txtbx.TabIndex = 4
        Me.apt_new_pt_nm_txtbx.Tag = "Impo"
        '
        'apt_new_pt_cvl_id_txtbx
        '
        Me.apt_new_pt_cvl_id_txtbx.Location = New System.Drawing.Point(9, 42)
        Me.apt_new_pt_cvl_id_txtbx.Name = "apt_new_pt_cvl_id_txtbx"
        Me.apt_new_pt_cvl_id_txtbx.Size = New System.Drawing.Size(176, 20)
        Me.apt_new_pt_cvl_id_txtbx.TabIndex = 4
        Me.apt_new_pt_cvl_id_txtbx.Tag = "Impo"
        '
        'apt_new_sbmt_btn
        '
        Me.apt_new_sbmt_btn.Location = New System.Drawing.Point(362, 240)
        Me.apt_new_sbmt_btn.Name = "apt_new_sbmt_btn"
        Me.apt_new_sbmt_btn.Size = New System.Drawing.Size(75, 23)
        Me.apt_new_sbmt_btn.TabIndex = 3
        Me.apt_new_sbmt_btn.Text = "Submit"
        Me.apt_new_sbmt_btn.UseVisualStyleBackColor = True
        '
        'apt_new_rsn_lbl
        '
        Me.apt_new_rsn_lbl.AutoSize = True
        Me.apt_new_rsn_lbl.Location = New System.Drawing.Point(-1, 96)
        Me.apt_new_rsn_lbl.Name = "apt_new_rsn_lbl"
        Me.apt_new_rsn_lbl.Size = New System.Drawing.Size(50, 13)
        Me.apt_new_rsn_lbl.TabIndex = 2
        Me.apt_new_rsn_lbl.Text = "Reason :"
        '
        'apt_new_pt_nm_lbl
        '
        Me.apt_new_pt_nm_lbl.AutoSize = True
        Me.apt_new_pt_nm_lbl.Location = New System.Drawing.Point(-1, 73)
        Me.apt_new_pt_nm_lbl.Name = "apt_new_pt_nm_lbl"
        Me.apt_new_pt_nm_lbl.Size = New System.Drawing.Size(77, 13)
        Me.apt_new_pt_nm_lbl.TabIndex = 0
        Me.apt_new_pt_nm_lbl.Text = "Patient Name :"
        '
        'apt_new_apt_tm_lbl
        '
        Me.apt_new_apt_tm_lbl.AutoSize = True
        Me.apt_new_apt_tm_lbl.Location = New System.Drawing.Point(-1, 245)
        Me.apt_new_apt_tm_lbl.Name = "apt_new_apt_tm_lbl"
        Me.apt_new_apt_tm_lbl.Size = New System.Drawing.Size(98, 13)
        Me.apt_new_apt_tm_lbl.TabIndex = 1
        Me.apt_new_apt_tm_lbl.Text = "Appointment Time :"
        '
        'TabPage5
        '
        Me.TabPage5.Controls.Add(Me.pt_grid)
        Me.TabPage5.Controls.Add(Me.pt_dia_mod_srch_grbbx)
        Me.TabPage5.Controls.Add(Me.apt_mod_grbbx)
        Me.TabPage5.Location = New System.Drawing.Point(4, 22)
        Me.TabPage5.Name = "TabPage5"
        Me.TabPage5.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage5.Size = New System.Drawing.Size(1068, 449)
        Me.TabPage5.TabIndex = 1
        Me.TabPage5.Text = "Preview or Modify Appointments"
        Me.TabPage5.UseVisualStyleBackColor = True
        '
        'pt_grid
        '
        Me.pt_grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.pt_grid.Location = New System.Drawing.Point(3, 121)
        Me.pt_grid.Name = "pt_grid"
        Me.pt_grid.Size = New System.Drawing.Size(527, 322)
        Me.pt_grid.TabIndex = 23
        '
        'pt_dia_mod_srch_grbbx
        '
        Me.pt_dia_mod_srch_grbbx.Controls.Add(Me.apt_status_cmbobx)
        Me.pt_dia_mod_srch_grbbx.Controls.Add(Me.fltr_doct_id_txtbx)
        Me.pt_dia_mod_srch_grbbx.Controls.Add(Me.fltr_pt_id_txtbx)
        Me.pt_dia_mod_srch_grbbx.Controls.Add(Me.doct_id_chkbx)
        Me.pt_dia_mod_srch_grbbx.Controls.Add(Me.pt_id_chkbx)
        Me.pt_dia_mod_srch_grbbx.Controls.Add(Me.pt_dia_mod_all_btn)
        Me.pt_dia_mod_srch_grbbx.Controls.Add(Me.pt_dia_mod_srch_btn)
        Me.pt_dia_mod_srch_grbbx.Controls.Add(Me.pt_dia_mod_rst_today_btn)
        Me.pt_dia_mod_srch_grbbx.Controls.Add(Me.pt_dia_mod_to_lbl)
        Me.pt_dia_mod_srch_grbbx.Controls.Add(Me.pt_dia_mod_fltrby_lbl)
        Me.pt_dia_mod_srch_grbbx.Controls.Add(Me.pt_dia_mod_frm_lbl)
        Me.pt_dia_mod_srch_grbbx.Controls.Add(Me.pt_dia_mod_to_pkr)
        Me.pt_dia_mod_srch_grbbx.Controls.Add(Me.pt_dia_mod_frm_pkr)
        Me.pt_dia_mod_srch_grbbx.Location = New System.Drawing.Point(6, 6)
        Me.pt_dia_mod_srch_grbbx.Name = "pt_dia_mod_srch_grbbx"
        Me.pt_dia_mod_srch_grbbx.Size = New System.Drawing.Size(524, 109)
        Me.pt_dia_mod_srch_grbbx.TabIndex = 22
        Me.pt_dia_mod_srch_grbbx.TabStop = False
        Me.pt_dia_mod_srch_grbbx.Text = "Filtre :"
        '
        'apt_status_cmbobx
        '
        Me.apt_status_cmbobx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.apt_status_cmbobx.FormattingEnabled = True
        Me.apt_status_cmbobx.Items.AddRange(New Object() {"OnHold", "Concluded", "ALL"})
        Me.apt_status_cmbobx.Location = New System.Drawing.Point(9, 78)
        Me.apt_status_cmbobx.Name = "apt_status_cmbobx"
        Me.apt_status_cmbobx.Size = New System.Drawing.Size(121, 21)
        Me.apt_status_cmbobx.TabIndex = 5
        '
        'fltr_doct_id_txtbx
        '
        Me.fltr_doct_id_txtbx.Location = New System.Drawing.Point(362, 51)
        Me.fltr_doct_id_txtbx.Name = "fltr_doct_id_txtbx"
        Me.fltr_doct_id_txtbx.Size = New System.Drawing.Size(129, 20)
        Me.fltr_doct_id_txtbx.TabIndex = 4
        '
        'fltr_pt_id_txtbx
        '
        Me.fltr_pt_id_txtbx.Location = New System.Drawing.Point(141, 51)
        Me.fltr_pt_id_txtbx.Name = "fltr_pt_id_txtbx"
        Me.fltr_pt_id_txtbx.Size = New System.Drawing.Size(129, 20)
        Me.fltr_pt_id_txtbx.TabIndex = 4
        '
        'doct_id_chkbx
        '
        Me.doct_id_chkbx.AutoSize = True
        Me.doct_id_chkbx.Location = New System.Drawing.Point(284, 53)
        Me.doct_id_chkbx.Name = "doct_id_chkbx"
        Me.doct_id_chkbx.Size = New System.Drawing.Size(72, 17)
        Me.doct_id_chkbx.TabIndex = 3
        Me.doct_id_chkbx.Text = "Doctor ID"
        Me.doct_id_chkbx.UseVisualStyleBackColor = True
        '
        'pt_id_chkbx
        '
        Me.pt_id_chkbx.AutoSize = True
        Me.pt_id_chkbx.Location = New System.Drawing.Point(62, 53)
        Me.pt_id_chkbx.Name = "pt_id_chkbx"
        Me.pt_id_chkbx.Size = New System.Drawing.Size(73, 17)
        Me.pt_id_chkbx.TabIndex = 3
        Me.pt_id_chkbx.Text = "Patient ID"
        Me.pt_id_chkbx.UseVisualStyleBackColor = True
        '
        'pt_dia_mod_all_btn
        '
        Me.pt_dia_mod_all_btn.Location = New System.Drawing.Point(362, 77)
        Me.pt_dia_mod_all_btn.Name = "pt_dia_mod_all_btn"
        Me.pt_dia_mod_all_btn.Size = New System.Drawing.Size(129, 23)
        Me.pt_dia_mod_all_btn.TabIndex = 2
        Me.pt_dia_mod_all_btn.Text = "View All"
        Me.pt_dia_mod_all_btn.UseVisualStyleBackColor = True
        '
        'pt_dia_mod_srch_btn
        '
        Me.pt_dia_mod_srch_btn.Location = New System.Drawing.Point(141, 77)
        Me.pt_dia_mod_srch_btn.Name = "pt_dia_mod_srch_btn"
        Me.pt_dia_mod_srch_btn.Size = New System.Drawing.Size(129, 23)
        Me.pt_dia_mod_srch_btn.TabIndex = 2
        Me.pt_dia_mod_srch_btn.Text = "Search"
        Me.pt_dia_mod_srch_btn.UseVisualStyleBackColor = True
        '
        'pt_dia_mod_rst_today_btn
        '
        Me.pt_dia_mod_rst_today_btn.Location = New System.Drawing.Point(343, 18)
        Me.pt_dia_mod_rst_today_btn.Name = "pt_dia_mod_rst_today_btn"
        Me.pt_dia_mod_rst_today_btn.Size = New System.Drawing.Size(148, 23)
        Me.pt_dia_mod_rst_today_btn.TabIndex = 2
        Me.pt_dia_mod_rst_today_btn.Text = "Today"
        Me.pt_dia_mod_rst_today_btn.UseVisualStyleBackColor = True
        '
        'pt_dia_mod_to_lbl
        '
        Me.pt_dia_mod_to_lbl.AutoSize = True
        Me.pt_dia_mod_to_lbl.Location = New System.Drawing.Point(179, 25)
        Me.pt_dia_mod_to_lbl.Name = "pt_dia_mod_to_lbl"
        Me.pt_dia_mod_to_lbl.Size = New System.Drawing.Size(26, 13)
        Me.pt_dia_mod_to_lbl.TabIndex = 1
        Me.pt_dia_mod_to_lbl.Text = "To :"
        '
        'pt_dia_mod_fltrby_lbl
        '
        Me.pt_dia_mod_fltrby_lbl.AutoSize = True
        Me.pt_dia_mod_fltrby_lbl.Location = New System.Drawing.Point(6, 55)
        Me.pt_dia_mod_fltrby_lbl.Name = "pt_dia_mod_fltrby_lbl"
        Me.pt_dia_mod_fltrby_lbl.Size = New System.Drawing.Size(50, 13)
        Me.pt_dia_mod_fltrby_lbl.TabIndex = 1
        Me.pt_dia_mod_fltrby_lbl.Text = "Filter By :"
        '
        'pt_dia_mod_frm_lbl
        '
        Me.pt_dia_mod_frm_lbl.AutoSize = True
        Me.pt_dia_mod_frm_lbl.Location = New System.Drawing.Point(6, 25)
        Me.pt_dia_mod_frm_lbl.Name = "pt_dia_mod_frm_lbl"
        Me.pt_dia_mod_frm_lbl.Size = New System.Drawing.Size(36, 13)
        Me.pt_dia_mod_frm_lbl.TabIndex = 1
        Me.pt_dia_mod_frm_lbl.Text = "From :"
        '
        'pt_dia_mod_to_pkr
        '
        Me.pt_dia_mod_to_pkr.CustomFormat = "yyyy/MM/dd hh:mm:ss"
        Me.pt_dia_mod_to_pkr.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.pt_dia_mod_to_pkr.Location = New System.Drawing.Point(211, 19)
        Me.pt_dia_mod_to_pkr.Name = "pt_dia_mod_to_pkr"
        Me.pt_dia_mod_to_pkr.Size = New System.Drawing.Size(126, 20)
        Me.pt_dia_mod_to_pkr.TabIndex = 0
        '
        'pt_dia_mod_frm_pkr
        '
        Me.pt_dia_mod_frm_pkr.CustomFormat = "yyyy/MM/dd hh:mm:ss"
        Me.pt_dia_mod_frm_pkr.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.pt_dia_mod_frm_pkr.Location = New System.Drawing.Point(48, 19)
        Me.pt_dia_mod_frm_pkr.Name = "pt_dia_mod_frm_pkr"
        Me.pt_dia_mod_frm_pkr.Size = New System.Drawing.Size(125, 20)
        Me.pt_dia_mod_frm_pkr.TabIndex = 0
        '
        'apt_mod_grbbx
        '
        Me.apt_mod_grbbx.Controls.Add(Me.apt_mod_apt_tm_picker)
        Me.apt_mod_grbbx.Controls.Add(Me.apt_mod_apt_rsn_rchtxtbx)
        Me.apt_mod_grbbx.Controls.Add(Me.apt_mod_doct_name_txtbx)
        Me.apt_mod_grbbx.Controls.Add(Me.apt_mod_pt_nm_txtbx)
        Me.apt_mod_grbbx.Controls.Add(Me.apt_mod_doct_id_txtbx)
        Me.apt_mod_grbbx.Controls.Add(Me.apt_mod_apt_id_txtbx)
        Me.apt_mod_grbbx.Controls.Add(Me.apt_mod_pt_id_txtbx)
        Me.apt_mod_grbbx.Controls.Add(Me.apt_mod_drp_btn)
        Me.apt_mod_grbbx.Controls.Add(Me.apt_mod_update_btn)
        Me.apt_mod_grbbx.Controls.Add(Me.apt_mod_doct_name_lbl)
        Me.apt_mod_grbbx.Controls.Add(Me.apt_mod_apt_rsn_lbl)
        Me.apt_mod_grbbx.Controls.Add(Me.apt_mod_pt_nm_lbl)
        Me.apt_mod_grbbx.Controls.Add(Me.apt_mod_apt_id_lbl)
        Me.apt_mod_grbbx.Controls.Add(Me.apt_mod_doct_id_lbl)
        Me.apt_mod_grbbx.Controls.Add(Me.apt_mod_apt_tm_lbl)
        Me.apt_mod_grbbx.Controls.Add(Me.apt_mod_pt_id_lbl)
        Me.apt_mod_grbbx.Location = New System.Drawing.Point(552, 61)
        Me.apt_mod_grbbx.Name = "apt_mod_grbbx"
        Me.apt_mod_grbbx.Size = New System.Drawing.Size(456, 329)
        Me.apt_mod_grbbx.TabIndex = 19
        Me.apt_mod_grbbx.TabStop = False
        Me.apt_mod_grbbx.Text = "Modify an Appointment"
        '
        'apt_mod_apt_tm_picker
        '
        Me.apt_mod_apt_tm_picker.CustomFormat = "yyyy/MM/dd hh:mm:ss"
        Me.apt_mod_apt_tm_picker.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.apt_mod_apt_tm_picker.Location = New System.Drawing.Point(217, 128)
        Me.apt_mod_apt_tm_picker.Name = "apt_mod_apt_tm_picker"
        Me.apt_mod_apt_tm_picker.Size = New System.Drawing.Size(162, 20)
        Me.apt_mod_apt_tm_picker.TabIndex = 6
        '
        'apt_mod_apt_rsn_rchtxtbx
        '
        Me.apt_mod_apt_rsn_rchtxtbx.Location = New System.Drawing.Point(74, 154)
        Me.apt_mod_apt_rsn_rchtxtbx.Name = "apt_mod_apt_rsn_rchtxtbx"
        Me.apt_mod_apt_rsn_rchtxtbx.Size = New System.Drawing.Size(372, 138)
        Me.apt_mod_apt_rsn_rchtxtbx.TabIndex = 5
        Me.apt_mod_apt_rsn_rchtxtbx.Text = ""
        '
        'apt_mod_doct_name_txtbx
        '
        Me.apt_mod_doct_name_txtbx.Location = New System.Drawing.Point(269, 97)
        Me.apt_mod_doct_name_txtbx.Name = "apt_mod_doct_name_txtbx"
        Me.apt_mod_doct_name_txtbx.ReadOnly = True
        Me.apt_mod_doct_name_txtbx.Size = New System.Drawing.Size(177, 20)
        Me.apt_mod_doct_name_txtbx.TabIndex = 4
        '
        'apt_mod_pt_nm_txtbx
        '
        Me.apt_mod_pt_nm_txtbx.Location = New System.Drawing.Point(91, 71)
        Me.apt_mod_pt_nm_txtbx.Name = "apt_mod_pt_nm_txtbx"
        Me.apt_mod_pt_nm_txtbx.ReadOnly = True
        Me.apt_mod_pt_nm_txtbx.Size = New System.Drawing.Size(179, 20)
        Me.apt_mod_pt_nm_txtbx.TabIndex = 4
        '
        'apt_mod_doct_id_txtbx
        '
        Me.apt_mod_doct_id_txtbx.Location = New System.Drawing.Point(74, 97)
        Me.apt_mod_doct_id_txtbx.Name = "apt_mod_doct_id_txtbx"
        Me.apt_mod_doct_id_txtbx.ReadOnly = True
        Me.apt_mod_doct_id_txtbx.Size = New System.Drawing.Size(100, 20)
        Me.apt_mod_doct_id_txtbx.TabIndex = 4
        '
        'apt_mod_apt_id_txtbx
        '
        Me.apt_mod_apt_id_txtbx.Location = New System.Drawing.Point(100, 19)
        Me.apt_mod_apt_id_txtbx.Name = "apt_mod_apt_id_txtbx"
        Me.apt_mod_apt_id_txtbx.ReadOnly = True
        Me.apt_mod_apt_id_txtbx.Size = New System.Drawing.Size(100, 20)
        Me.apt_mod_apt_id_txtbx.TabIndex = 4
        '
        'apt_mod_pt_id_txtbx
        '
        Me.apt_mod_pt_id_txtbx.Location = New System.Drawing.Point(74, 44)
        Me.apt_mod_pt_id_txtbx.Name = "apt_mod_pt_id_txtbx"
        Me.apt_mod_pt_id_txtbx.ReadOnly = True
        Me.apt_mod_pt_id_txtbx.Size = New System.Drawing.Size(126, 20)
        Me.apt_mod_pt_id_txtbx.TabIndex = 4
        '
        'apt_mod_drp_btn
        '
        Me.apt_mod_drp_btn.Location = New System.Drawing.Point(290, 298)
        Me.apt_mod_drp_btn.Name = "apt_mod_drp_btn"
        Me.apt_mod_drp_btn.Size = New System.Drawing.Size(75, 23)
        Me.apt_mod_drp_btn.TabIndex = 3
        Me.apt_mod_drp_btn.Text = "Drop"
        Me.apt_mod_drp_btn.UseVisualStyleBackColor = True
        '
        'apt_mod_update_btn
        '
        Me.apt_mod_update_btn.Location = New System.Drawing.Point(371, 298)
        Me.apt_mod_update_btn.Name = "apt_mod_update_btn"
        Me.apt_mod_update_btn.Size = New System.Drawing.Size(75, 23)
        Me.apt_mod_update_btn.TabIndex = 3
        Me.apt_mod_update_btn.Text = "Update"
        Me.apt_mod_update_btn.UseVisualStyleBackColor = True
        '
        'apt_mod_doct_name_lbl
        '
        Me.apt_mod_doct_name_lbl.AutoSize = True
        Me.apt_mod_doct_name_lbl.Location = New System.Drawing.Point(186, 100)
        Me.apt_mod_doct_name_lbl.Name = "apt_mod_doct_name_lbl"
        Me.apt_mod_doct_name_lbl.Size = New System.Drawing.Size(76, 13)
        Me.apt_mod_doct_name_lbl.TabIndex = 0
        Me.apt_mod_doct_name_lbl.Text = "Doctor Name :"
        '
        'apt_mod_apt_rsn_lbl
        '
        Me.apt_mod_apt_rsn_lbl.AutoSize = True
        Me.apt_mod_apt_rsn_lbl.Location = New System.Drawing.Point(8, 154)
        Me.apt_mod_apt_rsn_lbl.Name = "apt_mod_apt_rsn_lbl"
        Me.apt_mod_apt_rsn_lbl.Size = New System.Drawing.Size(50, 13)
        Me.apt_mod_apt_rsn_lbl.TabIndex = 2
        Me.apt_mod_apt_rsn_lbl.Text = "Reason :"
        '
        'apt_mod_pt_nm_lbl
        '
        Me.apt_mod_pt_nm_lbl.AutoSize = True
        Me.apt_mod_pt_nm_lbl.Location = New System.Drawing.Point(8, 74)
        Me.apt_mod_pt_nm_lbl.Name = "apt_mod_pt_nm_lbl"
        Me.apt_mod_pt_nm_lbl.Size = New System.Drawing.Size(77, 13)
        Me.apt_mod_pt_nm_lbl.TabIndex = 0
        Me.apt_mod_pt_nm_lbl.Text = "Patient Name :"
        '
        'apt_mod_apt_id_lbl
        '
        Me.apt_mod_apt_id_lbl.AutoSize = True
        Me.apt_mod_apt_id_lbl.Location = New System.Drawing.Point(8, 22)
        Me.apt_mod_apt_id_lbl.Name = "apt_mod_apt_id_lbl"
        Me.apt_mod_apt_id_lbl.Size = New System.Drawing.Size(86, 13)
        Me.apt_mod_apt_id_lbl.TabIndex = 0
        Me.apt_mod_apt_id_lbl.Text = "Appointment ID :"
        '
        'apt_mod_doct_id_lbl
        '
        Me.apt_mod_doct_id_lbl.AutoSize = True
        Me.apt_mod_doct_id_lbl.Location = New System.Drawing.Point(8, 101)
        Me.apt_mod_doct_id_lbl.Name = "apt_mod_doct_id_lbl"
        Me.apt_mod_doct_id_lbl.Size = New System.Drawing.Size(59, 13)
        Me.apt_mod_doct_id_lbl.TabIndex = 0
        Me.apt_mod_doct_id_lbl.Text = "Doctor ID :"
        '
        'apt_mod_apt_tm_lbl
        '
        Me.apt_mod_apt_tm_lbl.AutoSize = True
        Me.apt_mod_apt_tm_lbl.Location = New System.Drawing.Point(113, 132)
        Me.apt_mod_apt_tm_lbl.Name = "apt_mod_apt_tm_lbl"
        Me.apt_mod_apt_tm_lbl.Size = New System.Drawing.Size(98, 13)
        Me.apt_mod_apt_tm_lbl.TabIndex = 1
        Me.apt_mod_apt_tm_lbl.Text = "Appointment Time :"
        '
        'apt_mod_pt_id_lbl
        '
        Me.apt_mod_pt_id_lbl.AutoSize = True
        Me.apt_mod_pt_id_lbl.Location = New System.Drawing.Point(8, 48)
        Me.apt_mod_pt_id_lbl.Name = "apt_mod_pt_id_lbl"
        Me.apt_mod_pt_id_lbl.Size = New System.Drawing.Size(60, 13)
        Me.apt_mod_pt_id_lbl.TabIndex = 0
        Me.apt_mod_pt_id_lbl.Text = "Patient ID :"
        '
        'DiagnosisForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(1090, 507)
        Me.Controls.Add(Me.TabControl1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "DiagnosisForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Diagnosis Form"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.mdcn_grbbx.ResumeLayout(False)
        Me.mdcn_grbbx.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabControl2.ResumeLayout(False)
        Me.TabPage4.ResumeLayout(False)
        Me.new_apt_grbbx.ResumeLayout(False)
        Me.new_apt_grbbx.PerformLayout()
        Me.TabPage5.ResumeLayout(False)
        CType(Me.pt_grid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pt_dia_mod_srch_grbbx.ResumeLayout(False)
        Me.pt_dia_mod_srch_grbbx.PerformLayout()
        Me.apt_mod_grbbx.ResumeLayout(False)
        Me.apt_mod_grbbx.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents add_prsc_rtxtbx As RichTextBox
    Friend WithEvents add_dia_rtxtbx As RichTextBox
    Friend WithEvents add_avtv_pt_nm_txtbx As TextBox
    Friend WithEvents add_avtv_pt_age_txtbx As TextBox
    Friend WithEvents add_avtv_pt_gndr_txtbx As TextBox
    Friend WithEvents add_avtv_pt_cvl_id_txtbx As TextBox
    Friend WithEvents add_avtv_pt_id_txtbx As TextBox
    Friend WithEvents add_avtv_pt_nm_lbl As Label
    Friend WithEvents add_avtv_pt_age_lbl As Label
    Friend WithEvents add_avtv_pt_gndr_lbl As Label
    Friend WithEvents add_avtv_pt_cvl_id_lbl As Label
    Friend WithEvents add_prsc_lbl As Label
    Friend WithEvents add_dia_lbl As Label
    Friend WithEvents add_avtv_pt_id_lbl As Label
    Friend WithEvents TabControl2 As TabControl
    Friend WithEvents TabPage5 As TabPage
    Friend WithEvents apt_mod_grbbx As GroupBox
    Friend WithEvents apt_mod_apt_tm_picker As DateTimePicker
    Friend WithEvents apt_mod_apt_rsn_rchtxtbx As RichTextBox
    Friend WithEvents apt_mod_pt_id_txtbx As TextBox
    Friend WithEvents apt_mod_update_btn As Button
    Friend WithEvents apt_mod_apt_rsn_lbl As Label
    Friend WithEvents apt_mod_apt_tm_lbl As Label
    Friend WithEvents apt_mod_pt_id_lbl As Label
    Friend WithEvents apt_mod_pt_nm_txtbx As TextBox
    Friend WithEvents apt_mod_pt_nm_lbl As Label
    Friend WithEvents dia_sbmt_btn As Button
    Friend WithEvents mdcn_grbbx As GroupBox
    Friend WithEvents external_rdbx As RadioButton
    Friend WithEvents internal_rdbx As RadioButton
    Friend WithEvents apt_mod_drp_btn As Button
    Friend WithEvents weight_lbl As Label
    Friend WithEvents bld_pres_lbl As Label
    Friend WithEvents bld_type_lbl As Label
    Friend WithEvents height_lbl As Label
    Friend WithEvents weight_txtbx As TextBox
    Friend WithEvents height_txtbx As TextBox
    Friend WithEvents rfrsh_btn As Button
    Friend WithEvents TabPage4 As TabPage
    Friend WithEvents new_apt_grbbx As GroupBox
    Friend WithEvents apt_new_apt_tm_pick As DateTimePicker
    Friend WithEvents apt_new_rsn_rchtxtbx As RichTextBox
    Friend WithEvents apt_new_pt_nm_txtbx As TextBox
    Friend WithEvents apt_new_pt_cvl_id_txtbx As TextBox
    Friend WithEvents apt_new_sbmt_btn As Button
    Friend WithEvents apt_new_rsn_lbl As Label
    Friend WithEvents apt_new_pt_nm_lbl As Label
    Friend WithEvents apt_new_apt_tm_lbl As Label
    Friend WithEvents apt_new_pt_cvl_id_rdiobtn As RadioButton
    Friend WithEvents apt_new_pt_id_rdiobtn As RadioButton
    Friend WithEvents pt_grid As DataGridView
    Friend WithEvents pt_dia_mod_srch_grbbx As GroupBox
    Friend WithEvents fltr_doct_id_txtbx As TextBox
    Friend WithEvents fltr_pt_id_txtbx As TextBox
    Friend WithEvents doct_id_chkbx As CheckBox
    Friend WithEvents pt_id_chkbx As CheckBox
    Friend WithEvents pt_dia_mod_all_btn As Button
    Friend WithEvents pt_dia_mod_srch_btn As Button
    Friend WithEvents pt_dia_mod_rst_today_btn As Button
    Friend WithEvents pt_dia_mod_to_lbl As Label
    Friend WithEvents pt_dia_mod_fltrby_lbl As Label
    Friend WithEvents pt_dia_mod_frm_lbl As Label
    Friend WithEvents pt_dia_mod_to_pkr As DateTimePicker
    Friend WithEvents pt_dia_mod_frm_pkr As DateTimePicker
    Friend WithEvents apt_status_cmbobx As ComboBox
    Friend WithEvents apt_mod_apt_id_txtbx As TextBox
    Friend WithEvents apt_mod_apt_id_lbl As Label
    Friend WithEvents apt_mod_doct_name_txtbx As TextBox
    Friend WithEvents apt_mod_doct_id_txtbx As TextBox
    Friend WithEvents apt_mod_doct_name_lbl As Label
    Friend WithEvents apt_mod_doct_id_lbl As Label
    Friend WithEvents bld_pres_txtbx As TextBox
    Friend WithEvents bld_type_txtbx As TextBox
End Class
