<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Reception
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Reception))
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.apt_srch_grbbx = New System.Windows.Forms.GroupBox()
        Me.apt_id_chkbx = New System.Windows.Forms.CheckBox()
        Me.apt_id_txtbx = New System.Windows.Forms.TextBox()
        Me.all_btn = New System.Windows.Forms.Button()
        Me.srch_btn = New System.Windows.Forms.Button()
        Me.rst_today_btn = New System.Windows.Forms.Button()
        Me.to_lbl = New System.Windows.Forms.Label()
        Me.frm_lbl = New System.Windows.Forms.Label()
        Me.to_pkr = New System.Windows.Forms.DateTimePicker()
        Me.frm_pkr = New System.Windows.Forms.DateTimePicker()
        Me.with_actv_grbbx = New System.Windows.Forms.GroupBox()
        Me.with_actv_lbl = New System.Windows.Forms.Label()
        Me.with_actv_txtbx = New System.Windows.Forms.TextBox()
        Me.with_actv_btn = New System.Windows.Forms.Button()
        Me.ac_vst_w_grid = New System.Windows.Forms.DataGridView()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.srch_grbbx = New System.Windows.Forms.GroupBox()
        Me.srch_txtbx = New System.Windows.Forms.TextBox()
        Me.rst_tbl_btn = New System.Windows.Forms.Button()
        Me.pt_pno_rbtn = New System.Windows.Forms.RadioButton()
        Me.pt_nm_rbtn = New System.Windows.Forms.RadioButton()
        Me.pt_cvl_id_rbtn = New System.Windows.Forms.RadioButton()
        Me.pt_id_rbtn = New System.Windows.Forms.RadioButton()
        Me.without_actv_grbbx = New System.Windows.Forms.GroupBox()
        Me.without_actv_lbl = New System.Windows.Forms.Label()
        Me.without_actv_txtbx = New System.Windows.Forms.TextBox()
        Me.without_actv_btn = New System.Windows.Forms.Button()
        Me.ac_vst_wo_grid = New System.Windows.Forms.DataGridView()
        Me.rec_tabs = New System.Windows.Forms.TabControl()
        Me.TabPage2.SuspendLayout()
        Me.apt_srch_grbbx.SuspendLayout()
        Me.with_actv_grbbx.SuspendLayout()
        CType(Me.ac_vst_w_grid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage1.SuspendLayout()
        Me.srch_grbbx.SuspendLayout()
        Me.without_actv_grbbx.SuspendLayout()
        CType(Me.ac_vst_wo_grid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.rec_tabs.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.apt_srch_grbbx)
        Me.TabPage2.Controls.Add(Me.with_actv_grbbx)
        Me.TabPage2.Controls.Add(Me.ac_vst_w_grid)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(931, 463)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Activate File(With Appointment)"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'apt_srch_grbbx
        '
        Me.apt_srch_grbbx.Controls.Add(Me.apt_id_chkbx)
        Me.apt_srch_grbbx.Controls.Add(Me.apt_id_txtbx)
        Me.apt_srch_grbbx.Controls.Add(Me.all_btn)
        Me.apt_srch_grbbx.Controls.Add(Me.srch_btn)
        Me.apt_srch_grbbx.Controls.Add(Me.rst_today_btn)
        Me.apt_srch_grbbx.Controls.Add(Me.to_lbl)
        Me.apt_srch_grbbx.Controls.Add(Me.frm_lbl)
        Me.apt_srch_grbbx.Controls.Add(Me.to_pkr)
        Me.apt_srch_grbbx.Controls.Add(Me.frm_pkr)
        Me.apt_srch_grbbx.Location = New System.Drawing.Point(8, 6)
        Me.apt_srch_grbbx.Name = "apt_srch_grbbx"
        Me.apt_srch_grbbx.Size = New System.Drawing.Size(447, 78)
        Me.apt_srch_grbbx.TabIndex = 11
        Me.apt_srch_grbbx.TabStop = False
        Me.apt_srch_grbbx.Text = "Seatch for Patients with appointments"
        '
        'apt_id_chkbx
        '
        Me.apt_id_chkbx.AutoSize = True
        Me.apt_id_chkbx.Location = New System.Drawing.Point(4, 49)
        Me.apt_id_chkbx.Name = "apt_id_chkbx"
        Me.apt_id_chkbx.Size = New System.Drawing.Size(62, 17)
        Me.apt_id_chkbx.TabIndex = 4
        Me.apt_id_chkbx.Text = "Apt ID :"
        Me.apt_id_chkbx.UseVisualStyleBackColor = True
        '
        'apt_id_txtbx
        '
        Me.apt_id_txtbx.Location = New System.Drawing.Point(72, 47)
        Me.apt_id_txtbx.Name = "apt_id_txtbx"
        Me.apt_id_txtbx.Size = New System.Drawing.Size(100, 20)
        Me.apt_id_txtbx.TabIndex = 3
        '
        'all_btn
        '
        Me.all_btn.Location = New System.Drawing.Point(355, 45)
        Me.all_btn.Name = "all_btn"
        Me.all_btn.Size = New System.Drawing.Size(75, 23)
        Me.all_btn.TabIndex = 2
        Me.all_btn.Text = "View All"
        Me.all_btn.UseVisualStyleBackColor = True
        '
        'srch_btn
        '
        Me.srch_btn.Location = New System.Drawing.Point(274, 45)
        Me.srch_btn.Name = "srch_btn"
        Me.srch_btn.Size = New System.Drawing.Size(75, 23)
        Me.srch_btn.TabIndex = 2
        Me.srch_btn.Text = "Search"
        Me.srch_btn.UseVisualStyleBackColor = True
        '
        'rst_today_btn
        '
        Me.rst_today_btn.Location = New System.Drawing.Point(193, 45)
        Me.rst_today_btn.Name = "rst_today_btn"
        Me.rst_today_btn.Size = New System.Drawing.Size(75, 23)
        Me.rst_today_btn.TabIndex = 2
        Me.rst_today_btn.Text = "Today"
        Me.rst_today_btn.UseVisualStyleBackColor = True
        '
        'to_lbl
        '
        Me.to_lbl.AutoSize = True
        Me.to_lbl.Location = New System.Drawing.Point(226, 25)
        Me.to_lbl.Name = "to_lbl"
        Me.to_lbl.Size = New System.Drawing.Size(26, 13)
        Me.to_lbl.TabIndex = 1
        Me.to_lbl.Text = "To :"
        '
        'frm_lbl
        '
        Me.frm_lbl.AutoSize = True
        Me.frm_lbl.Location = New System.Drawing.Point(6, 25)
        Me.frm_lbl.Name = "frm_lbl"
        Me.frm_lbl.Size = New System.Drawing.Size(36, 13)
        Me.frm_lbl.TabIndex = 1
        Me.frm_lbl.Text = "From :"
        '
        'to_pkr
        '
        Me.to_pkr.CustomFormat = "yyyy-MM-dd HH:mm:ss"
        Me.to_pkr.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.to_pkr.Location = New System.Drawing.Point(268, 19)
        Me.to_pkr.Name = "to_pkr"
        Me.to_pkr.Size = New System.Drawing.Size(162, 20)
        Me.to_pkr.TabIndex = 0
        '
        'frm_pkr
        '
        Me.frm_pkr.CustomFormat = "yyyy-MM-dd HH:mm:ss"
        Me.frm_pkr.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.frm_pkr.Location = New System.Drawing.Point(48, 19)
        Me.frm_pkr.Name = "frm_pkr"
        Me.frm_pkr.Size = New System.Drawing.Size(162, 20)
        Me.frm_pkr.TabIndex = 0
        '
        'with_actv_grbbx
        '
        Me.with_actv_grbbx.Controls.Add(Me.with_actv_lbl)
        Me.with_actv_grbbx.Controls.Add(Me.with_actv_txtbx)
        Me.with_actv_grbbx.Controls.Add(Me.with_actv_btn)
        Me.with_actv_grbbx.Location = New System.Drawing.Point(461, 6)
        Me.with_actv_grbbx.Name = "with_actv_grbbx"
        Me.with_actv_grbbx.Size = New System.Drawing.Size(297, 78)
        Me.with_actv_grbbx.TabIndex = 10
        Me.with_actv_grbbx.TabStop = False
        Me.with_actv_grbbx.Text = "Activate File"
        '
        'with_actv_lbl
        '
        Me.with_actv_lbl.AutoSize = True
        Me.with_actv_lbl.Location = New System.Drawing.Point(6, 25)
        Me.with_actv_lbl.Name = "with_actv_lbl"
        Me.with_actv_lbl.Size = New System.Drawing.Size(60, 13)
        Me.with_actv_lbl.TabIndex = 3
        Me.with_actv_lbl.Text = "Patient ID :"
        '
        'with_actv_txtbx
        '
        Me.with_actv_txtbx.Location = New System.Drawing.Point(6, 44)
        Me.with_actv_txtbx.Name = "with_actv_txtbx"
        Me.with_actv_txtbx.ReadOnly = True
        Me.with_actv_txtbx.Size = New System.Drawing.Size(191, 20)
        Me.with_actv_txtbx.TabIndex = 2
        '
        'with_actv_btn
        '
        Me.with_actv_btn.Location = New System.Drawing.Point(212, 42)
        Me.with_actv_btn.Name = "with_actv_btn"
        Me.with_actv_btn.Size = New System.Drawing.Size(75, 23)
        Me.with_actv_btn.TabIndex = 1
        Me.with_actv_btn.Text = "Activate"
        Me.with_actv_btn.UseVisualStyleBackColor = True
        '
        'ac_vst_w_grid
        '
        Me.ac_vst_w_grid.AllowUserToAddRows = False
        Me.ac_vst_w_grid.AllowUserToDeleteRows = False
        Me.ac_vst_w_grid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.ac_vst_w_grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ac_vst_w_grid.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.ac_vst_w_grid.Location = New System.Drawing.Point(7, 90)
        Me.ac_vst_w_grid.Name = "ac_vst_w_grid"
        Me.ac_vst_w_grid.ReadOnly = True
        Me.ac_vst_w_grid.Size = New System.Drawing.Size(917, 367)
        Me.ac_vst_w_grid.TabIndex = 9
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.srch_grbbx)
        Me.TabPage1.Controls.Add(Me.without_actv_grbbx)
        Me.TabPage1.Controls.Add(Me.ac_vst_wo_grid)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(931, 463)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Activate File(Without Appointment)"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'srch_grbbx
        '
        Me.srch_grbbx.Controls.Add(Me.srch_txtbx)
        Me.srch_grbbx.Controls.Add(Me.rst_tbl_btn)
        Me.srch_grbbx.Controls.Add(Me.pt_pno_rbtn)
        Me.srch_grbbx.Controls.Add(Me.pt_nm_rbtn)
        Me.srch_grbbx.Controls.Add(Me.pt_cvl_id_rbtn)
        Me.srch_grbbx.Controls.Add(Me.pt_id_rbtn)
        Me.srch_grbbx.Location = New System.Drawing.Point(8, 6)
        Me.srch_grbbx.Name = "srch_grbbx"
        Me.srch_grbbx.Size = New System.Drawing.Size(293, 78)
        Me.srch_grbbx.TabIndex = 4
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
        'without_actv_grbbx
        '
        Me.without_actv_grbbx.Controls.Add(Me.without_actv_lbl)
        Me.without_actv_grbbx.Controls.Add(Me.without_actv_txtbx)
        Me.without_actv_grbbx.Controls.Add(Me.without_actv_btn)
        Me.without_actv_grbbx.Location = New System.Drawing.Point(307, 6)
        Me.without_actv_grbbx.Name = "without_actv_grbbx"
        Me.without_actv_grbbx.Size = New System.Drawing.Size(297, 78)
        Me.without_actv_grbbx.TabIndex = 8
        Me.without_actv_grbbx.TabStop = False
        Me.without_actv_grbbx.Text = "Activate File"
        '
        'without_actv_lbl
        '
        Me.without_actv_lbl.AutoSize = True
        Me.without_actv_lbl.Location = New System.Drawing.Point(6, 25)
        Me.without_actv_lbl.Name = "without_actv_lbl"
        Me.without_actv_lbl.Size = New System.Drawing.Size(60, 13)
        Me.without_actv_lbl.TabIndex = 3
        Me.without_actv_lbl.Text = "Patient ID :"
        '
        'without_actv_txtbx
        '
        Me.without_actv_txtbx.Location = New System.Drawing.Point(6, 44)
        Me.without_actv_txtbx.Name = "without_actv_txtbx"
        Me.without_actv_txtbx.ReadOnly = True
        Me.without_actv_txtbx.Size = New System.Drawing.Size(191, 20)
        Me.without_actv_txtbx.TabIndex = 2
        '
        'without_actv_btn
        '
        Me.without_actv_btn.Location = New System.Drawing.Point(212, 42)
        Me.without_actv_btn.Name = "without_actv_btn"
        Me.without_actv_btn.Size = New System.Drawing.Size(75, 23)
        Me.without_actv_btn.TabIndex = 1
        Me.without_actv_btn.Text = "Activate"
        Me.without_actv_btn.UseVisualStyleBackColor = True
        '
        'ac_vst_wo_grid
        '
        Me.ac_vst_wo_grid.AllowUserToAddRows = False
        Me.ac_vst_wo_grid.AllowUserToDeleteRows = False
        Me.ac_vst_wo_grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ac_vst_wo_grid.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.ac_vst_wo_grid.Location = New System.Drawing.Point(6, 90)
        Me.ac_vst_wo_grid.Name = "ac_vst_wo_grid"
        Me.ac_vst_wo_grid.ReadOnly = True
        Me.ac_vst_wo_grid.Size = New System.Drawing.Size(917, 367)
        Me.ac_vst_wo_grid.TabIndex = 7
        '
        'rec_tabs
        '
        Me.rec_tabs.Controls.Add(Me.TabPage1)
        Me.rec_tabs.Controls.Add(Me.TabPage2)
        Me.rec_tabs.Dock = System.Windows.Forms.DockStyle.Fill
        Me.rec_tabs.Location = New System.Drawing.Point(0, 0)
        Me.rec_tabs.Name = "rec_tabs"
        Me.rec_tabs.SelectedIndex = 0
        Me.rec_tabs.Size = New System.Drawing.Size(939, 489)
        Me.rec_tabs.TabIndex = 0
        '
        'Reception
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(939, 489)
        Me.Controls.Add(Me.rec_tabs)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Reception"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Reception"
        Me.TabPage2.ResumeLayout(False)
        Me.apt_srch_grbbx.ResumeLayout(False)
        Me.apt_srch_grbbx.PerformLayout()
        Me.with_actv_grbbx.ResumeLayout(False)
        Me.with_actv_grbbx.PerformLayout()
        CType(Me.ac_vst_w_grid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage1.ResumeLayout(False)
        Me.srch_grbbx.ResumeLayout(False)
        Me.srch_grbbx.PerformLayout()
        Me.without_actv_grbbx.ResumeLayout(False)
        Me.without_actv_grbbx.PerformLayout()
        CType(Me.ac_vst_wo_grid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.rec_tabs.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents apt_srch_grbbx As GroupBox
    Friend WithEvents all_btn As Button
    Friend WithEvents srch_btn As Button
    Friend WithEvents rst_today_btn As Button
    Friend WithEvents to_lbl As Label
    Friend WithEvents frm_lbl As Label
    Friend WithEvents to_pkr As DateTimePicker
    Friend WithEvents frm_pkr As DateTimePicker
    Friend WithEvents with_actv_grbbx As GroupBox
    Friend WithEvents with_actv_lbl As Label
    Friend WithEvents with_actv_txtbx As TextBox
    Friend WithEvents with_actv_btn As Button
    Friend WithEvents ac_vst_w_grid As DataGridView
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents srch_grbbx As GroupBox
    Friend WithEvents srch_txtbx As TextBox
    Friend WithEvents rst_tbl_btn As Button
    Friend WithEvents pt_pno_rbtn As RadioButton
    Friend WithEvents pt_nm_rbtn As RadioButton
    Friend WithEvents pt_cvl_id_rbtn As RadioButton
    Friend WithEvents pt_id_rbtn As RadioButton
    Friend WithEvents without_actv_grbbx As GroupBox
    Friend WithEvents without_actv_lbl As Label
    Friend WithEvents without_actv_txtbx As TextBox
    Friend WithEvents without_actv_btn As Button
    Friend WithEvents ac_vst_wo_grid As DataGridView
    Friend WithEvents rec_tabs As TabControl
    Friend WithEvents apt_id_chkbx As CheckBox
    Friend WithEvents apt_id_txtbx As TextBox
End Class
