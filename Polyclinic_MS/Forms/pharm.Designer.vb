<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class pharm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(pharm))
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.addnew_mdcn_grbbx = New System.Windows.Forms.GroupBox()
        Me.sbmt_btn = New System.Windows.Forms.Button()
        Me.new_mdcn_expdate_picker = New System.Windows.Forms.DateTimePicker()
        Me.new_mdcn_manudate_picker = New System.Windows.Forms.DateTimePicker()
        Me.new_mdcn_type_cmbobx = New System.Windows.Forms.ComboBox()
        Me.new_price_txtbx = New System.Windows.Forms.TextBox()
        Me.new_mdcn_qt_txtbx = New System.Windows.Forms.TextBox()
        Me.new_mdcn_nm_txtbx = New System.Windows.Forms.TextBox()
        Me.new_mdcn_expdate_lbl = New System.Windows.Forms.Label()
        Me.new_price_lbl = New System.Windows.Forms.Label()
        Me.new_mdcn_manudate_lbl = New System.Windows.Forms.Label()
        Me.new_mdcn_qt_lbl = New System.Windows.Forms.Label()
        Me.new_mdcn_type_lbl = New System.Windows.Forms.Label()
        Me.new_mdcn_nm_lbl = New System.Windows.Forms.Label()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.mdcn_grid = New System.Windows.Forms.DataGridView()
        Me.mod_mdcn_grbbx = New System.Windows.Forms.GroupBox()
        Me.mod_price_txtbx = New System.Windows.Forms.TextBox()
        Me.mod_price_lbl = New System.Windows.Forms.Label()
        Me.mod_drp_btn = New System.Windows.Forms.Button()
        Me.mod_update_btn = New System.Windows.Forms.Button()
        Me.mod_exp_dt_pkr = New System.Windows.Forms.DateTimePicker()
        Me.mod_manu_dt_pkr = New System.Windows.Forms.DateTimePicker()
        Me.mod_mdcn_type_cmbobx = New System.Windows.Forms.ComboBox()
        Me.mod_mdcn_qt_txtbx = New System.Windows.Forms.TextBox()
        Me.mod_mdcn_id_txtbx = New System.Windows.Forms.TextBox()
        Me.mod_mdcn_nm_txtbx = New System.Windows.Forms.TextBox()
        Me.mod_grbx_exp_dt_lbl = New System.Windows.Forms.Label()
        Me.mod_grbx_manu_dt_lbl = New System.Windows.Forms.Label()
        Me.mod_mdcn_qt_lbl = New System.Windows.Forms.Label()
        Me.mod_mdcn_type_lbl = New System.Windows.Forms.Label()
        Me.mod_mdcn_id_lbl = New System.Windows.Forms.Label()
        Me.mod_mdcn_nm_lbl = New System.Windows.Forms.Label()
        Me.pt_dia_mod_srch_grbbx = New System.Windows.Forms.GroupBox()
        Me.mod_exp_dt_lbl = New System.Windows.Forms.Label()
        Me.mod_manu_dt_lbl = New System.Windows.Forms.Label()
        Me.mod_manu_frm_pkr = New System.Windows.Forms.DateTimePicker()
        Me.mod_manu_to_pkr = New System.Windows.Forms.DateTimePicker()
        Me.mod_exp_frm_pkr = New System.Windows.Forms.DateTimePicker()
        Me.mod_exp_to_pkr = New System.Windows.Forms.DateTimePicker()
        Me.mdcn_nm_txtbx = New System.Windows.Forms.TextBox()
        Me.fltr_by_dt_chkbx = New System.Windows.Forms.CheckBox()
        Me.mdcn_nm_chkbx = New System.Windows.Forms.CheckBox()
        Me.mod_manu_to_lbl = New System.Windows.Forms.Label()
        Me.fltr_btn = New System.Windows.Forms.Button()
        Me.mod_manu_frm_lbl = New System.Windows.Forms.Label()
        Me.mod_exp_to_lbl = New System.Windows.Forms.Label()
        Me.mod_exp_frm_lbl = New System.Windows.Forms.Label()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.addnew_mdcn_grbbx.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        CType(Me.mdcn_grid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.mod_mdcn_grbbx.SuspendLayout()
        Me.pt_dia_mod_srch_grbbx.SuspendLayout()
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
        Me.TabControl1.Size = New System.Drawing.Size(904, 497)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.addnew_mdcn_grbbx)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(896, 471)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Add new Medicine"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'addnew_mdcn_grbbx
        '
        Me.addnew_mdcn_grbbx.Controls.Add(Me.sbmt_btn)
        Me.addnew_mdcn_grbbx.Controls.Add(Me.new_mdcn_expdate_picker)
        Me.addnew_mdcn_grbbx.Controls.Add(Me.new_mdcn_manudate_picker)
        Me.addnew_mdcn_grbbx.Controls.Add(Me.new_mdcn_type_cmbobx)
        Me.addnew_mdcn_grbbx.Controls.Add(Me.new_price_txtbx)
        Me.addnew_mdcn_grbbx.Controls.Add(Me.new_mdcn_qt_txtbx)
        Me.addnew_mdcn_grbbx.Controls.Add(Me.new_mdcn_nm_txtbx)
        Me.addnew_mdcn_grbbx.Controls.Add(Me.new_mdcn_expdate_lbl)
        Me.addnew_mdcn_grbbx.Controls.Add(Me.new_price_lbl)
        Me.addnew_mdcn_grbbx.Controls.Add(Me.new_mdcn_manudate_lbl)
        Me.addnew_mdcn_grbbx.Controls.Add(Me.new_mdcn_qt_lbl)
        Me.addnew_mdcn_grbbx.Controls.Add(Me.new_mdcn_type_lbl)
        Me.addnew_mdcn_grbbx.Controls.Add(Me.new_mdcn_nm_lbl)
        Me.addnew_mdcn_grbbx.Location = New System.Drawing.Point(8, 6)
        Me.addnew_mdcn_grbbx.Name = "addnew_mdcn_grbbx"
        Me.addnew_mdcn_grbbx.Size = New System.Drawing.Size(490, 165)
        Me.addnew_mdcn_grbbx.TabIndex = 0
        Me.addnew_mdcn_grbbx.TabStop = False
        Me.addnew_mdcn_grbbx.Text = "Add New Medicine"
        '
        'sbmt_btn
        '
        Me.sbmt_btn.Location = New System.Drawing.Point(390, 136)
        Me.sbmt_btn.Name = "sbmt_btn"
        Me.sbmt_btn.Size = New System.Drawing.Size(75, 23)
        Me.sbmt_btn.TabIndex = 19
        Me.sbmt_btn.Text = "Submit"
        Me.sbmt_btn.UseVisualStyleBackColor = True
        '
        'new_mdcn_expdate_picker
        '
        Me.new_mdcn_expdate_picker.CustomFormat = "yyyy/MM/dd"
        Me.new_mdcn_expdate_picker.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.new_mdcn_expdate_picker.Location = New System.Drawing.Point(344, 80)
        Me.new_mdcn_expdate_picker.Name = "new_mdcn_expdate_picker"
        Me.new_mdcn_expdate_picker.Size = New System.Drawing.Size(121, 20)
        Me.new_mdcn_expdate_picker.TabIndex = 8
        '
        'new_mdcn_manudate_picker
        '
        Me.new_mdcn_manudate_picker.CustomFormat = "yyyy/MM/dd"
        Me.new_mdcn_manudate_picker.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.new_mdcn_manudate_picker.Location = New System.Drawing.Point(344, 47)
        Me.new_mdcn_manudate_picker.Name = "new_mdcn_manudate_picker"
        Me.new_mdcn_manudate_picker.Size = New System.Drawing.Size(121, 20)
        Me.new_mdcn_manudate_picker.TabIndex = 8
        '
        'new_mdcn_type_cmbobx
        '
        Me.new_mdcn_type_cmbobx.FormattingEnabled = True
        Me.new_mdcn_type_cmbobx.Items.AddRange(New Object() {"Pill", "Supplement", "Liquid", "Capsule"})
        Me.new_mdcn_type_cmbobx.Location = New System.Drawing.Point(100, 56)
        Me.new_mdcn_type_cmbobx.Name = "new_mdcn_type_cmbobx"
        Me.new_mdcn_type_cmbobx.Size = New System.Drawing.Size(121, 21)
        Me.new_mdcn_type_cmbobx.TabIndex = 7
        Me.new_mdcn_type_cmbobx.Tag = "Impo"
        '
        'new_price_txtbx
        '
        Me.new_price_txtbx.Location = New System.Drawing.Point(100, 109)
        Me.new_price_txtbx.Name = "new_price_txtbx"
        Me.new_price_txtbx.Size = New System.Drawing.Size(121, 20)
        Me.new_price_txtbx.TabIndex = 6
        Me.new_price_txtbx.Tag = "Impo"
        '
        'new_mdcn_qt_txtbx
        '
        Me.new_mdcn_qt_txtbx.Location = New System.Drawing.Point(100, 83)
        Me.new_mdcn_qt_txtbx.Name = "new_mdcn_qt_txtbx"
        Me.new_mdcn_qt_txtbx.Size = New System.Drawing.Size(121, 20)
        Me.new_mdcn_qt_txtbx.TabIndex = 6
        Me.new_mdcn_qt_txtbx.Tag = "Impo"
        '
        'new_mdcn_nm_txtbx
        '
        Me.new_mdcn_nm_txtbx.Location = New System.Drawing.Point(100, 30)
        Me.new_mdcn_nm_txtbx.Name = "new_mdcn_nm_txtbx"
        Me.new_mdcn_nm_txtbx.Size = New System.Drawing.Size(121, 20)
        Me.new_mdcn_nm_txtbx.TabIndex = 6
        Me.new_mdcn_nm_txtbx.Tag = "Impo"
        '
        'new_mdcn_expdate_lbl
        '
        Me.new_mdcn_expdate_lbl.AutoSize = True
        Me.new_mdcn_expdate_lbl.ForeColor = System.Drawing.Color.Maroon
        Me.new_mdcn_expdate_lbl.Location = New System.Drawing.Point(239, 83)
        Me.new_mdcn_expdate_lbl.Name = "new_mdcn_expdate_lbl"
        Me.new_mdcn_expdate_lbl.Size = New System.Drawing.Size(85, 13)
        Me.new_mdcn_expdate_lbl.TabIndex = 5
        Me.new_mdcn_expdate_lbl.Text = "Expiration Date :"
        '
        'new_price_lbl
        '
        Me.new_price_lbl.AutoSize = True
        Me.new_price_lbl.ForeColor = System.Drawing.Color.Maroon
        Me.new_price_lbl.Location = New System.Drawing.Point(56, 112)
        Me.new_price_lbl.Name = "new_price_lbl"
        Me.new_price_lbl.Size = New System.Drawing.Size(37, 13)
        Me.new_price_lbl.TabIndex = 3
        Me.new_price_lbl.Text = "Price :"
        '
        'new_mdcn_manudate_lbl
        '
        Me.new_mdcn_manudate_lbl.AutoSize = True
        Me.new_mdcn_manudate_lbl.ForeColor = System.Drawing.Color.Maroon
        Me.new_mdcn_manudate_lbl.Location = New System.Drawing.Point(239, 50)
        Me.new_mdcn_manudate_lbl.Name = "new_mdcn_manudate_lbl"
        Me.new_mdcn_manudate_lbl.Size = New System.Drawing.Size(99, 13)
        Me.new_mdcn_manudate_lbl.TabIndex = 4
        Me.new_mdcn_manudate_lbl.Text = "Manufacture Date :"
        '
        'new_mdcn_qt_lbl
        '
        Me.new_mdcn_qt_lbl.AutoSize = True
        Me.new_mdcn_qt_lbl.ForeColor = System.Drawing.Color.Maroon
        Me.new_mdcn_qt_lbl.Location = New System.Drawing.Point(41, 86)
        Me.new_mdcn_qt_lbl.Name = "new_mdcn_qt_lbl"
        Me.new_mdcn_qt_lbl.Size = New System.Drawing.Size(52, 13)
        Me.new_mdcn_qt_lbl.TabIndex = 3
        Me.new_mdcn_qt_lbl.Text = "Quantity :"
        '
        'new_mdcn_type_lbl
        '
        Me.new_mdcn_type_lbl.AutoSize = True
        Me.new_mdcn_type_lbl.ForeColor = System.Drawing.Color.Maroon
        Me.new_mdcn_type_lbl.Location = New System.Drawing.Point(57, 64)
        Me.new_mdcn_type_lbl.Name = "new_mdcn_type_lbl"
        Me.new_mdcn_type_lbl.Size = New System.Drawing.Size(37, 13)
        Me.new_mdcn_type_lbl.TabIndex = 2
        Me.new_mdcn_type_lbl.Text = "Type :"
        '
        'new_mdcn_nm_lbl
        '
        Me.new_mdcn_nm_lbl.AutoSize = True
        Me.new_mdcn_nm_lbl.ForeColor = System.Drawing.Color.Maroon
        Me.new_mdcn_nm_lbl.Location = New System.Drawing.Point(6, 33)
        Me.new_mdcn_nm_lbl.Name = "new_mdcn_nm_lbl"
        Me.new_mdcn_nm_lbl.Size = New System.Drawing.Size(87, 13)
        Me.new_mdcn_nm_lbl.TabIndex = 0
        Me.new_mdcn_nm_lbl.Text = "Medicine Name :"
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.mdcn_grid)
        Me.TabPage2.Controls.Add(Me.mod_mdcn_grbbx)
        Me.TabPage2.Controls.Add(Me.pt_dia_mod_srch_grbbx)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(896, 471)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Drop or Modify Medicine Record"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'mdcn_grid
        '
        Me.mdcn_grid.AllowUserToAddRows = False
        Me.mdcn_grid.AllowUserToDeleteRows = False
        Me.mdcn_grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.mdcn_grid.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.mdcn_grid.Location = New System.Drawing.Point(8, 130)
        Me.mdcn_grid.Name = "mdcn_grid"
        Me.mdcn_grid.ReadOnly = True
        Me.mdcn_grid.Size = New System.Drawing.Size(582, 341)
        Me.mdcn_grid.TabIndex = 20
        '
        'mod_mdcn_grbbx
        '
        Me.mod_mdcn_grbbx.Controls.Add(Me.mod_price_txtbx)
        Me.mod_mdcn_grbbx.Controls.Add(Me.mod_price_lbl)
        Me.mod_mdcn_grbbx.Controls.Add(Me.mod_drp_btn)
        Me.mod_mdcn_grbbx.Controls.Add(Me.mod_update_btn)
        Me.mod_mdcn_grbbx.Controls.Add(Me.mod_exp_dt_pkr)
        Me.mod_mdcn_grbbx.Controls.Add(Me.mod_manu_dt_pkr)
        Me.mod_mdcn_grbbx.Controls.Add(Me.mod_mdcn_type_cmbobx)
        Me.mod_mdcn_grbbx.Controls.Add(Me.mod_mdcn_qt_txtbx)
        Me.mod_mdcn_grbbx.Controls.Add(Me.mod_mdcn_id_txtbx)
        Me.mod_mdcn_grbbx.Controls.Add(Me.mod_mdcn_nm_txtbx)
        Me.mod_mdcn_grbbx.Controls.Add(Me.mod_grbx_exp_dt_lbl)
        Me.mod_mdcn_grbbx.Controls.Add(Me.mod_grbx_manu_dt_lbl)
        Me.mod_mdcn_grbbx.Controls.Add(Me.mod_mdcn_qt_lbl)
        Me.mod_mdcn_grbbx.Controls.Add(Me.mod_mdcn_type_lbl)
        Me.mod_mdcn_grbbx.Controls.Add(Me.mod_mdcn_id_lbl)
        Me.mod_mdcn_grbbx.Controls.Add(Me.mod_mdcn_nm_lbl)
        Me.mod_mdcn_grbbx.Location = New System.Drawing.Point(604, 96)
        Me.mod_mdcn_grbbx.Name = "mod_mdcn_grbbx"
        Me.mod_mdcn_grbbx.Size = New System.Drawing.Size(268, 282)
        Me.mod_mdcn_grbbx.TabIndex = 19
        Me.mod_mdcn_grbbx.TabStop = False
        Me.mod_mdcn_grbbx.Text = "Modify Or Drop Medicine Record"
        '
        'mod_price_txtbx
        '
        Me.mod_price_txtbx.Location = New System.Drawing.Point(117, 212)
        Me.mod_price_txtbx.Name = "mod_price_txtbx"
        Me.mod_price_txtbx.Size = New System.Drawing.Size(121, 20)
        Me.mod_price_txtbx.TabIndex = 12
        Me.mod_price_txtbx.Tag = "Impo"
        '
        'mod_price_lbl
        '
        Me.mod_price_lbl.AutoSize = True
        Me.mod_price_lbl.Location = New System.Drawing.Point(72, 215)
        Me.mod_price_lbl.Name = "mod_price_lbl"
        Me.mod_price_lbl.Size = New System.Drawing.Size(37, 13)
        Me.mod_price_lbl.TabIndex = 11
        Me.mod_price_lbl.Text = "Price :"
        '
        'mod_drp_btn
        '
        Me.mod_drp_btn.Location = New System.Drawing.Point(106, 253)
        Me.mod_drp_btn.Name = "mod_drp_btn"
        Me.mod_drp_btn.Size = New System.Drawing.Size(75, 23)
        Me.mod_drp_btn.TabIndex = 9
        Me.mod_drp_btn.Text = "Drop"
        Me.mod_drp_btn.UseVisualStyleBackColor = True
        '
        'mod_update_btn
        '
        Me.mod_update_btn.Location = New System.Drawing.Point(187, 253)
        Me.mod_update_btn.Name = "mod_update_btn"
        Me.mod_update_btn.Size = New System.Drawing.Size(75, 23)
        Me.mod_update_btn.TabIndex = 10
        Me.mod_update_btn.Text = "Update"
        Me.mod_update_btn.UseVisualStyleBackColor = True
        '
        'mod_exp_dt_pkr
        '
        Me.mod_exp_dt_pkr.CustomFormat = "yyyy/MM/dd"
        Me.mod_exp_dt_pkr.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.mod_exp_dt_pkr.Location = New System.Drawing.Point(117, 186)
        Me.mod_exp_dt_pkr.Name = "mod_exp_dt_pkr"
        Me.mod_exp_dt_pkr.Size = New System.Drawing.Size(121, 20)
        Me.mod_exp_dt_pkr.TabIndex = 8
        '
        'mod_manu_dt_pkr
        '
        Me.mod_manu_dt_pkr.CustomFormat = "yyyy/MM/dd"
        Me.mod_manu_dt_pkr.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.mod_manu_dt_pkr.Location = New System.Drawing.Point(117, 160)
        Me.mod_manu_dt_pkr.Name = "mod_manu_dt_pkr"
        Me.mod_manu_dt_pkr.Size = New System.Drawing.Size(121, 20)
        Me.mod_manu_dt_pkr.TabIndex = 8
        '
        'mod_mdcn_type_cmbobx
        '
        Me.mod_mdcn_type_cmbobx.FormattingEnabled = True
        Me.mod_mdcn_type_cmbobx.Items.AddRange(New Object() {"Pill", "Supplement", "Liquid", "Capsule"})
        Me.mod_mdcn_type_cmbobx.Location = New System.Drawing.Point(117, 107)
        Me.mod_mdcn_type_cmbobx.Name = "mod_mdcn_type_cmbobx"
        Me.mod_mdcn_type_cmbobx.Size = New System.Drawing.Size(121, 21)
        Me.mod_mdcn_type_cmbobx.TabIndex = 7
        Me.mod_mdcn_type_cmbobx.Tag = "Impo"
        '
        'mod_mdcn_qt_txtbx
        '
        Me.mod_mdcn_qt_txtbx.Location = New System.Drawing.Point(117, 134)
        Me.mod_mdcn_qt_txtbx.Name = "mod_mdcn_qt_txtbx"
        Me.mod_mdcn_qt_txtbx.Size = New System.Drawing.Size(121, 20)
        Me.mod_mdcn_qt_txtbx.TabIndex = 6
        Me.mod_mdcn_qt_txtbx.Tag = "Impo"
        '
        'mod_mdcn_id_txtbx
        '
        Me.mod_mdcn_id_txtbx.Location = New System.Drawing.Point(117, 53)
        Me.mod_mdcn_id_txtbx.Name = "mod_mdcn_id_txtbx"
        Me.mod_mdcn_id_txtbx.ReadOnly = True
        Me.mod_mdcn_id_txtbx.Size = New System.Drawing.Size(121, 20)
        Me.mod_mdcn_id_txtbx.TabIndex = 6
        Me.mod_mdcn_id_txtbx.Tag = "Impo"
        '
        'mod_mdcn_nm_txtbx
        '
        Me.mod_mdcn_nm_txtbx.Location = New System.Drawing.Point(117, 81)
        Me.mod_mdcn_nm_txtbx.Name = "mod_mdcn_nm_txtbx"
        Me.mod_mdcn_nm_txtbx.Size = New System.Drawing.Size(121, 20)
        Me.mod_mdcn_nm_txtbx.TabIndex = 6
        Me.mod_mdcn_nm_txtbx.Tag = "Impo"
        '
        'mod_grbx_exp_dt_lbl
        '
        Me.mod_grbx_exp_dt_lbl.AutoSize = True
        Me.mod_grbx_exp_dt_lbl.Location = New System.Drawing.Point(24, 192)
        Me.mod_grbx_exp_dt_lbl.Name = "mod_grbx_exp_dt_lbl"
        Me.mod_grbx_exp_dt_lbl.Size = New System.Drawing.Size(85, 13)
        Me.mod_grbx_exp_dt_lbl.TabIndex = 5
        Me.mod_grbx_exp_dt_lbl.Text = "Expiration Date :"
        '
        'mod_grbx_manu_dt_lbl
        '
        Me.mod_grbx_manu_dt_lbl.AutoSize = True
        Me.mod_grbx_manu_dt_lbl.Location = New System.Drawing.Point(12, 166)
        Me.mod_grbx_manu_dt_lbl.Name = "mod_grbx_manu_dt_lbl"
        Me.mod_grbx_manu_dt_lbl.Size = New System.Drawing.Size(99, 13)
        Me.mod_grbx_manu_dt_lbl.TabIndex = 4
        Me.mod_grbx_manu_dt_lbl.Text = "Manufacture Date :"
        '
        'mod_mdcn_qt_lbl
        '
        Me.mod_mdcn_qt_lbl.AutoSize = True
        Me.mod_mdcn_qt_lbl.Location = New System.Drawing.Point(57, 141)
        Me.mod_mdcn_qt_lbl.Name = "mod_mdcn_qt_lbl"
        Me.mod_mdcn_qt_lbl.Size = New System.Drawing.Size(52, 13)
        Me.mod_mdcn_qt_lbl.TabIndex = 3
        Me.mod_mdcn_qt_lbl.Text = "Quantity :"
        '
        'mod_mdcn_type_lbl
        '
        Me.mod_mdcn_type_lbl.AutoSize = True
        Me.mod_mdcn_type_lbl.Location = New System.Drawing.Point(72, 110)
        Me.mod_mdcn_type_lbl.Name = "mod_mdcn_type_lbl"
        Me.mod_mdcn_type_lbl.Size = New System.Drawing.Size(37, 13)
        Me.mod_mdcn_type_lbl.TabIndex = 2
        Me.mod_mdcn_type_lbl.Text = "Type :"
        '
        'mod_mdcn_id_lbl
        '
        Me.mod_mdcn_id_lbl.AutoSize = True
        Me.mod_mdcn_id_lbl.Location = New System.Drawing.Point(39, 56)
        Me.mod_mdcn_id_lbl.Name = "mod_mdcn_id_lbl"
        Me.mod_mdcn_id_lbl.Size = New System.Drawing.Size(70, 13)
        Me.mod_mdcn_id_lbl.TabIndex = 0
        Me.mod_mdcn_id_lbl.Text = "Medicine ID :"
        '
        'mod_mdcn_nm_lbl
        '
        Me.mod_mdcn_nm_lbl.AutoSize = True
        Me.mod_mdcn_nm_lbl.Location = New System.Drawing.Point(22, 84)
        Me.mod_mdcn_nm_lbl.Name = "mod_mdcn_nm_lbl"
        Me.mod_mdcn_nm_lbl.Size = New System.Drawing.Size(87, 13)
        Me.mod_mdcn_nm_lbl.TabIndex = 0
        Me.mod_mdcn_nm_lbl.Text = "Medicine Name :"
        '
        'pt_dia_mod_srch_grbbx
        '
        Me.pt_dia_mod_srch_grbbx.Controls.Add(Me.mod_exp_dt_lbl)
        Me.pt_dia_mod_srch_grbbx.Controls.Add(Me.mod_manu_dt_lbl)
        Me.pt_dia_mod_srch_grbbx.Controls.Add(Me.mod_manu_frm_pkr)
        Me.pt_dia_mod_srch_grbbx.Controls.Add(Me.mod_manu_to_pkr)
        Me.pt_dia_mod_srch_grbbx.Controls.Add(Me.mod_exp_frm_pkr)
        Me.pt_dia_mod_srch_grbbx.Controls.Add(Me.mod_exp_to_pkr)
        Me.pt_dia_mod_srch_grbbx.Controls.Add(Me.mdcn_nm_txtbx)
        Me.pt_dia_mod_srch_grbbx.Controls.Add(Me.fltr_by_dt_chkbx)
        Me.pt_dia_mod_srch_grbbx.Controls.Add(Me.mdcn_nm_chkbx)
        Me.pt_dia_mod_srch_grbbx.Controls.Add(Me.mod_manu_to_lbl)
        Me.pt_dia_mod_srch_grbbx.Controls.Add(Me.fltr_btn)
        Me.pt_dia_mod_srch_grbbx.Controls.Add(Me.mod_manu_frm_lbl)
        Me.pt_dia_mod_srch_grbbx.Controls.Add(Me.mod_exp_to_lbl)
        Me.pt_dia_mod_srch_grbbx.Controls.Add(Me.mod_exp_frm_lbl)
        Me.pt_dia_mod_srch_grbbx.Location = New System.Drawing.Point(8, 5)
        Me.pt_dia_mod_srch_grbbx.Name = "pt_dia_mod_srch_grbbx"
        Me.pt_dia_mod_srch_grbbx.Size = New System.Drawing.Size(590, 119)
        Me.pt_dia_mod_srch_grbbx.TabIndex = 18
        Me.pt_dia_mod_srch_grbbx.TabStop = False
        Me.pt_dia_mod_srch_grbbx.Text = "Filtre :"
        '
        'mod_exp_dt_lbl
        '
        Me.mod_exp_dt_lbl.AutoSize = True
        Me.mod_exp_dt_lbl.Location = New System.Drawing.Point(341, 36)
        Me.mod_exp_dt_lbl.Name = "mod_exp_dt_lbl"
        Me.mod_exp_dt_lbl.Size = New System.Drawing.Size(89, 13)
        Me.mod_exp_dt_lbl.TabIndex = 9
        Me.mod_exp_dt_lbl.Text = "Experation Date :"
        '
        'mod_manu_dt_lbl
        '
        Me.mod_manu_dt_lbl.AutoSize = True
        Me.mod_manu_dt_lbl.Location = New System.Drawing.Point(49, 36)
        Me.mod_manu_dt_lbl.Name = "mod_manu_dt_lbl"
        Me.mod_manu_dt_lbl.Size = New System.Drawing.Size(102, 13)
        Me.mod_manu_dt_lbl.TabIndex = 9
        Me.mod_manu_dt_lbl.Text = "Manufacturer Date :"
        '
        'mod_manu_frm_pkr
        '
        Me.mod_manu_frm_pkr.CustomFormat = "yyyy/MM/dd"
        Me.mod_manu_frm_pkr.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.mod_manu_frm_pkr.Location = New System.Drawing.Point(49, 55)
        Me.mod_manu_frm_pkr.Name = "mod_manu_frm_pkr"
        Me.mod_manu_frm_pkr.Size = New System.Drawing.Size(100, 20)
        Me.mod_manu_frm_pkr.TabIndex = 8
        '
        'mod_manu_to_pkr
        '
        Me.mod_manu_to_pkr.CustomFormat = "yyyy/MM/dd"
        Me.mod_manu_to_pkr.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.mod_manu_to_pkr.Location = New System.Drawing.Point(187, 55)
        Me.mod_manu_to_pkr.Name = "mod_manu_to_pkr"
        Me.mod_manu_to_pkr.Size = New System.Drawing.Size(100, 20)
        Me.mod_manu_to_pkr.TabIndex = 7
        '
        'mod_exp_frm_pkr
        '
        Me.mod_exp_frm_pkr.CustomFormat = "yyyy/MM/dd"
        Me.mod_exp_frm_pkr.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.mod_exp_frm_pkr.Location = New System.Drawing.Point(344, 55)
        Me.mod_exp_frm_pkr.Name = "mod_exp_frm_pkr"
        Me.mod_exp_frm_pkr.Size = New System.Drawing.Size(100, 20)
        Me.mod_exp_frm_pkr.TabIndex = 8
        '
        'mod_exp_to_pkr
        '
        Me.mod_exp_to_pkr.CustomFormat = "yyyy/MM/dd"
        Me.mod_exp_to_pkr.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.mod_exp_to_pkr.Location = New System.Drawing.Point(482, 55)
        Me.mod_exp_to_pkr.Name = "mod_exp_to_pkr"
        Me.mod_exp_to_pkr.Size = New System.Drawing.Size(100, 20)
        Me.mod_exp_to_pkr.TabIndex = 7
        '
        'mdcn_nm_txtbx
        '
        Me.mdcn_nm_txtbx.Location = New System.Drawing.Point(122, 88)
        Me.mdcn_nm_txtbx.Name = "mdcn_nm_txtbx"
        Me.mdcn_nm_txtbx.Size = New System.Drawing.Size(129, 20)
        Me.mdcn_nm_txtbx.TabIndex = 4
        '
        'fltr_by_dt_chkbx
        '
        Me.fltr_by_dt_chkbx.AutoSize = True
        Me.fltr_by_dt_chkbx.Location = New System.Drawing.Point(6, 19)
        Me.fltr_by_dt_chkbx.Name = "fltr_by_dt_chkbx"
        Me.fltr_by_dt_chkbx.Size = New System.Drawing.Size(88, 17)
        Me.fltr_by_dt_chkbx.TabIndex = 3
        Me.fltr_by_dt_chkbx.Text = "Filter by Date"
        Me.fltr_by_dt_chkbx.UseVisualStyleBackColor = True
        '
        'mdcn_nm_chkbx
        '
        Me.mdcn_nm_chkbx.AutoSize = True
        Me.mdcn_nm_chkbx.Location = New System.Drawing.Point(10, 91)
        Me.mdcn_nm_chkbx.Name = "mdcn_nm_chkbx"
        Me.mdcn_nm_chkbx.Size = New System.Drawing.Size(106, 17)
        Me.mdcn_nm_chkbx.TabIndex = 3
        Me.mdcn_nm_chkbx.Text = "Medicine Name :"
        Me.mdcn_nm_chkbx.UseVisualStyleBackColor = True
        '
        'mod_manu_to_lbl
        '
        Me.mod_manu_to_lbl.AutoSize = True
        Me.mod_manu_to_lbl.Location = New System.Drawing.Point(155, 61)
        Me.mod_manu_to_lbl.Name = "mod_manu_to_lbl"
        Me.mod_manu_to_lbl.Size = New System.Drawing.Size(26, 13)
        Me.mod_manu_to_lbl.TabIndex = 1
        Me.mod_manu_to_lbl.Text = "To :"
        '
        'fltr_btn
        '
        Me.fltr_btn.Location = New System.Drawing.Point(344, 87)
        Me.fltr_btn.Name = "fltr_btn"
        Me.fltr_btn.Size = New System.Drawing.Size(75, 23)
        Me.fltr_btn.TabIndex = 2
        Me.fltr_btn.Text = "Filter"
        Me.fltr_btn.UseVisualStyleBackColor = True
        '
        'mod_manu_frm_lbl
        '
        Me.mod_manu_frm_lbl.AutoSize = True
        Me.mod_manu_frm_lbl.Location = New System.Drawing.Point(7, 61)
        Me.mod_manu_frm_lbl.Name = "mod_manu_frm_lbl"
        Me.mod_manu_frm_lbl.Size = New System.Drawing.Size(36, 13)
        Me.mod_manu_frm_lbl.TabIndex = 1
        Me.mod_manu_frm_lbl.Text = "From :"
        '
        'mod_exp_to_lbl
        '
        Me.mod_exp_to_lbl.AutoSize = True
        Me.mod_exp_to_lbl.Location = New System.Drawing.Point(450, 61)
        Me.mod_exp_to_lbl.Name = "mod_exp_to_lbl"
        Me.mod_exp_to_lbl.Size = New System.Drawing.Size(26, 13)
        Me.mod_exp_to_lbl.TabIndex = 1
        Me.mod_exp_to_lbl.Text = "To :"
        '
        'mod_exp_frm_lbl
        '
        Me.mod_exp_frm_lbl.AutoSize = True
        Me.mod_exp_frm_lbl.Location = New System.Drawing.Point(302, 61)
        Me.mod_exp_frm_lbl.Name = "mod_exp_frm_lbl"
        Me.mod_exp_frm_lbl.Size = New System.Drawing.Size(36, 13)
        Me.mod_exp_frm_lbl.TabIndex = 1
        Me.mod_exp_frm_lbl.Text = "From :"
        '
        'pharm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(904, 497)
        Me.Controls.Add(Me.TabControl1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "pharm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Pharmaceuticals(Incomplete)"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.addnew_mdcn_grbbx.ResumeLayout(False)
        Me.addnew_mdcn_grbbx.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        CType(Me.mdcn_grid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.mod_mdcn_grbbx.ResumeLayout(False)
        Me.mod_mdcn_grbbx.PerformLayout()
        Me.pt_dia_mod_srch_grbbx.ResumeLayout(False)
        Me.pt_dia_mod_srch_grbbx.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents addnew_mdcn_grbbx As GroupBox
    Friend WithEvents new_mdcn_type_cmbobx As ComboBox
    Friend WithEvents new_mdcn_qt_txtbx As TextBox
    Friend WithEvents new_mdcn_nm_txtbx As TextBox
    Friend WithEvents new_mdcn_expdate_lbl As Label
    Friend WithEvents new_mdcn_manudate_lbl As Label
    Friend WithEvents new_mdcn_qt_lbl As Label
    Friend WithEvents new_mdcn_type_lbl As Label
    Friend WithEvents new_mdcn_nm_lbl As Label
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents new_mdcn_expdate_picker As DateTimePicker
    Friend WithEvents new_mdcn_manudate_picker As DateTimePicker
    Friend WithEvents sbmt_btn As Button
    Friend WithEvents pt_dia_mod_srch_grbbx As GroupBox
    Friend WithEvents mdcn_nm_txtbx As TextBox
    Friend WithEvents mdcn_nm_chkbx As CheckBox
    Friend WithEvents fltr_btn As Button
    Friend WithEvents mod_exp_to_lbl As Label
    Friend WithEvents mod_exp_frm_lbl As Label
    Friend WithEvents mod_exp_dt_lbl As Label
    Friend WithEvents mod_manu_dt_lbl As Label
    Friend WithEvents mod_manu_frm_pkr As DateTimePicker
    Friend WithEvents mod_manu_to_pkr As DateTimePicker
    Friend WithEvents mod_exp_frm_pkr As DateTimePicker
    Friend WithEvents mod_exp_to_pkr As DateTimePicker
    Friend WithEvents fltr_by_dt_chkbx As CheckBox
    Friend WithEvents mod_manu_to_lbl As Label
    Friend WithEvents mod_manu_frm_lbl As Label
    Friend WithEvents mod_mdcn_grbbx As GroupBox
    Friend WithEvents mod_exp_dt_pkr As DateTimePicker
    Friend WithEvents mod_manu_dt_pkr As DateTimePicker
    Friend WithEvents mod_mdcn_type_cmbobx As ComboBox
    Friend WithEvents mod_mdcn_qt_txtbx As TextBox
    Friend WithEvents mod_mdcn_id_txtbx As TextBox
    Friend WithEvents mod_mdcn_nm_txtbx As TextBox
    Friend WithEvents mod_grbx_exp_dt_lbl As Label
    Friend WithEvents mod_grbx_manu_dt_lbl As Label
    Friend WithEvents mod_mdcn_qt_lbl As Label
    Friend WithEvents mod_mdcn_type_lbl As Label
    Friend WithEvents mod_mdcn_id_lbl As Label
    Friend WithEvents mod_mdcn_nm_lbl As Label
    Friend WithEvents mod_drp_btn As Button
    Friend WithEvents mod_update_btn As Button
    Friend WithEvents new_price_txtbx As TextBox
    Friend WithEvents new_price_lbl As Label
    Friend WithEvents mod_price_txtbx As TextBox
    Friend WithEvents mod_price_lbl As Label
    Friend WithEvents mdcn_grid As DataGridView
End Class
