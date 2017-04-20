<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class pt_vst_rcrd_mod
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(pt_vst_rcrd_mod))
        Me.pt_vst_rcrd_mod_grbbx = New System.Windows.Forms.GroupBox()
        Me.updt_btn = New System.Windows.Forms.Button()
        Me.drp_btn = New System.Windows.Forms.Button()
        Me.pres_rchtxtbx = New System.Windows.Forms.RichTextBox()
        Me.pt_dia_rchtxtbx = New System.Windows.Forms.RichTextBox()
        Me.pres_lbl = New System.Windows.Forms.Label()
        Me.pt_dia_lbl = New System.Windows.Forms.Label()
        Me.vst_id_lbl = New System.Windows.Forms.Label()
        Me.dr_nm_lbl = New System.Windows.Forms.Label()
        Me.dr_id_lbl = New System.Windows.Forms.Label()
        Me.pt_nm_lbl = New System.Windows.Forms.Label()
        Me.pt_id_lbl = New System.Windows.Forms.Label()
        Me.dr_nm_txtbx = New System.Windows.Forms.TextBox()
        Me.vst_id_txtbx = New System.Windows.Forms.TextBox()
        Me.dr_id_txtbx = New System.Windows.Forms.TextBox()
        Me.pt_nm_txtbx = New System.Windows.Forms.TextBox()
        Me.pt_id_txtbx = New System.Windows.Forms.TextBox()
        Me.pt_dia_mod_srch_grbbx = New System.Windows.Forms.GroupBox()
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
        Me.pt_grid = New System.Windows.Forms.DataGridView()
        Me.pt_vst_rcrd_mod_grbbx.SuspendLayout()
        Me.pt_dia_mod_srch_grbbx.SuspendLayout()
        CType(Me.pt_grid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pt_vst_rcrd_mod_grbbx
        '
        Me.pt_vst_rcrd_mod_grbbx.Controls.Add(Me.updt_btn)
        Me.pt_vst_rcrd_mod_grbbx.Controls.Add(Me.drp_btn)
        Me.pt_vst_rcrd_mod_grbbx.Controls.Add(Me.pres_rchtxtbx)
        Me.pt_vst_rcrd_mod_grbbx.Controls.Add(Me.pt_dia_rchtxtbx)
        Me.pt_vst_rcrd_mod_grbbx.Controls.Add(Me.pres_lbl)
        Me.pt_vst_rcrd_mod_grbbx.Controls.Add(Me.pt_dia_lbl)
        Me.pt_vst_rcrd_mod_grbbx.Controls.Add(Me.vst_id_lbl)
        Me.pt_vst_rcrd_mod_grbbx.Controls.Add(Me.dr_nm_lbl)
        Me.pt_vst_rcrd_mod_grbbx.Controls.Add(Me.dr_id_lbl)
        Me.pt_vst_rcrd_mod_grbbx.Controls.Add(Me.pt_nm_lbl)
        Me.pt_vst_rcrd_mod_grbbx.Controls.Add(Me.pt_id_lbl)
        Me.pt_vst_rcrd_mod_grbbx.Controls.Add(Me.dr_nm_txtbx)
        Me.pt_vst_rcrd_mod_grbbx.Controls.Add(Me.vst_id_txtbx)
        Me.pt_vst_rcrd_mod_grbbx.Controls.Add(Me.dr_id_txtbx)
        Me.pt_vst_rcrd_mod_grbbx.Controls.Add(Me.pt_nm_txtbx)
        Me.pt_vst_rcrd_mod_grbbx.Controls.Add(Me.pt_id_txtbx)
        Me.pt_vst_rcrd_mod_grbbx.Location = New System.Drawing.Point(535, 12)
        Me.pt_vst_rcrd_mod_grbbx.Name = "pt_vst_rcrd_mod_grbbx"
        Me.pt_vst_rcrd_mod_grbbx.Size = New System.Drawing.Size(450, 526)
        Me.pt_vst_rcrd_mod_grbbx.TabIndex = 17
        Me.pt_vst_rcrd_mod_grbbx.TabStop = False
        Me.pt_vst_rcrd_mod_grbbx.Text = "Modify Patients' Visit record :"
        '
        'updt_btn
        '
        Me.updt_btn.Location = New System.Drawing.Point(285, 490)
        Me.updt_btn.Name = "updt_btn"
        Me.updt_btn.Size = New System.Drawing.Size(75, 23)
        Me.updt_btn.TabIndex = 3
        Me.updt_btn.Text = "Update"
        Me.updt_btn.UseVisualStyleBackColor = True
        '
        'drp_btn
        '
        Me.drp_btn.Location = New System.Drawing.Point(366, 490)
        Me.drp_btn.Name = "drp_btn"
        Me.drp_btn.Size = New System.Drawing.Size(75, 23)
        Me.drp_btn.TabIndex = 3
        Me.drp_btn.Text = "Drop"
        Me.drp_btn.UseVisualStyleBackColor = True
        '
        'pres_rchtxtbx
        '
        Me.pres_rchtxtbx.Location = New System.Drawing.Point(6, 317)
        Me.pres_rchtxtbx.Name = "pres_rchtxtbx"
        Me.pres_rchtxtbx.Size = New System.Drawing.Size(435, 167)
        Me.pres_rchtxtbx.TabIndex = 2
        Me.pres_rchtxtbx.Text = ""
        '
        'pt_dia_rchtxtbx
        '
        Me.pt_dia_rchtxtbx.Location = New System.Drawing.Point(6, 131)
        Me.pt_dia_rchtxtbx.Name = "pt_dia_rchtxtbx"
        Me.pt_dia_rchtxtbx.Size = New System.Drawing.Size(435, 167)
        Me.pt_dia_rchtxtbx.TabIndex = 2
        Me.pt_dia_rchtxtbx.Text = ""
        '
        'pres_lbl
        '
        Me.pres_lbl.AutoSize = True
        Me.pres_lbl.Location = New System.Drawing.Point(6, 301)
        Me.pres_lbl.Name = "pres_lbl"
        Me.pres_lbl.Size = New System.Drawing.Size(68, 13)
        Me.pres_lbl.TabIndex = 1
        Me.pres_lbl.Text = "Prescription :"
        '
        'pt_dia_lbl
        '
        Me.pt_dia_lbl.AutoSize = True
        Me.pt_dia_lbl.Location = New System.Drawing.Point(6, 115)
        Me.pt_dia_lbl.Name = "pt_dia_lbl"
        Me.pt_dia_lbl.Size = New System.Drawing.Size(95, 13)
        Me.pt_dia_lbl.TabIndex = 1
        Me.pt_dia_lbl.Text = "Patient Diagnosis :"
        '
        'vst_id_lbl
        '
        Me.vst_id_lbl.AutoSize = True
        Me.vst_id_lbl.Location = New System.Drawing.Point(6, 21)
        Me.vst_id_lbl.Name = "vst_id_lbl"
        Me.vst_id_lbl.Size = New System.Drawing.Size(46, 13)
        Me.vst_id_lbl.TabIndex = 1
        Me.vst_id_lbl.Text = "Visit ID :"
        '
        'dr_nm_lbl
        '
        Me.dr_nm_lbl.AutoSize = True
        Me.dr_nm_lbl.Location = New System.Drawing.Point(173, 74)
        Me.dr_nm_lbl.Name = "dr_nm_lbl"
        Me.dr_nm_lbl.Size = New System.Drawing.Size(41, 26)
        Me.dr_nm_lbl.TabIndex = 1
        Me.dr_nm_lbl.Text = "Doctor" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Name :"
        '
        'dr_id_lbl
        '
        Me.dr_id_lbl.AutoSize = True
        Me.dr_id_lbl.Location = New System.Drawing.Point(6, 77)
        Me.dr_id_lbl.Name = "dr_id_lbl"
        Me.dr_id_lbl.Size = New System.Drawing.Size(59, 13)
        Me.dr_id_lbl.TabIndex = 1
        Me.dr_id_lbl.Text = "Doctor ID :"
        '
        'pt_nm_lbl
        '
        Me.pt_nm_lbl.AutoSize = True
        Me.pt_nm_lbl.Location = New System.Drawing.Point(147, 47)
        Me.pt_nm_lbl.Name = "pt_nm_lbl"
        Me.pt_nm_lbl.Size = New System.Drawing.Size(77, 13)
        Me.pt_nm_lbl.TabIndex = 1
        Me.pt_nm_lbl.Text = "Patient Name :"
        '
        'pt_id_lbl
        '
        Me.pt_id_lbl.AutoSize = True
        Me.pt_id_lbl.Location = New System.Drawing.Point(164, 21)
        Me.pt_id_lbl.Name = "pt_id_lbl"
        Me.pt_id_lbl.Size = New System.Drawing.Size(60, 13)
        Me.pt_id_lbl.TabIndex = 1
        Me.pt_id_lbl.Text = "Patient ID :"
        '
        'dr_nm_txtbx
        '
        Me.dr_nm_txtbx.Location = New System.Drawing.Point(230, 77)
        Me.dr_nm_txtbx.Name = "dr_nm_txtbx"
        Me.dr_nm_txtbx.ReadOnly = True
        Me.dr_nm_txtbx.Size = New System.Drawing.Size(214, 20)
        Me.dr_nm_txtbx.TabIndex = 0
        '
        'vst_id_txtbx
        '
        Me.vst_id_txtbx.Location = New System.Drawing.Point(58, 18)
        Me.vst_id_txtbx.Name = "vst_id_txtbx"
        Me.vst_id_txtbx.ReadOnly = True
        Me.vst_id_txtbx.Size = New System.Drawing.Size(100, 20)
        Me.vst_id_txtbx.TabIndex = 0
        '
        'dr_id_txtbx
        '
        Me.dr_id_txtbx.Location = New System.Drawing.Point(72, 74)
        Me.dr_id_txtbx.Name = "dr_id_txtbx"
        Me.dr_id_txtbx.ReadOnly = True
        Me.dr_id_txtbx.Size = New System.Drawing.Size(86, 20)
        Me.dr_id_txtbx.TabIndex = 0
        '
        'pt_nm_txtbx
        '
        Me.pt_nm_txtbx.Location = New System.Drawing.Point(230, 44)
        Me.pt_nm_txtbx.Name = "pt_nm_txtbx"
        Me.pt_nm_txtbx.ReadOnly = True
        Me.pt_nm_txtbx.Size = New System.Drawing.Size(214, 20)
        Me.pt_nm_txtbx.TabIndex = 0
        '
        'pt_id_txtbx
        '
        Me.pt_id_txtbx.Location = New System.Drawing.Point(230, 18)
        Me.pt_id_txtbx.Name = "pt_id_txtbx"
        Me.pt_id_txtbx.ReadOnly = True
        Me.pt_id_txtbx.Size = New System.Drawing.Size(100, 20)
        Me.pt_id_txtbx.TabIndex = 0
        '
        'pt_dia_mod_srch_grbbx
        '
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
        Me.pt_dia_mod_srch_grbbx.Location = New System.Drawing.Point(5, 12)
        Me.pt_dia_mod_srch_grbbx.Name = "pt_dia_mod_srch_grbbx"
        Me.pt_dia_mod_srch_grbbx.Size = New System.Drawing.Size(524, 109)
        Me.pt_dia_mod_srch_grbbx.TabIndex = 16
        Me.pt_dia_mod_srch_grbbx.TabStop = False
        Me.pt_dia_mod_srch_grbbx.Text = "Filtre :"
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
        Me.pt_dia_mod_all_btn.Location = New System.Drawing.Point(284, 80)
        Me.pt_dia_mod_all_btn.Name = "pt_dia_mod_all_btn"
        Me.pt_dia_mod_all_btn.Size = New System.Drawing.Size(207, 23)
        Me.pt_dia_mod_all_btn.TabIndex = 2
        Me.pt_dia_mod_all_btn.Text = "View All"
        Me.pt_dia_mod_all_btn.UseVisualStyleBackColor = True
        '
        'pt_dia_mod_srch_btn
        '
        Me.pt_dia_mod_srch_btn.Location = New System.Drawing.Point(62, 80)
        Me.pt_dia_mod_srch_btn.Name = "pt_dia_mod_srch_btn"
        Me.pt_dia_mod_srch_btn.Size = New System.Drawing.Size(208, 23)
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
        Me.pt_dia_mod_to_pkr.CustomFormat = "yyyy/MM/dd HH:mm:ss"
        Me.pt_dia_mod_to_pkr.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.pt_dia_mod_to_pkr.Location = New System.Drawing.Point(211, 19)
        Me.pt_dia_mod_to_pkr.Name = "pt_dia_mod_to_pkr"
        Me.pt_dia_mod_to_pkr.Size = New System.Drawing.Size(126, 20)
        Me.pt_dia_mod_to_pkr.TabIndex = 0
        '
        'pt_dia_mod_frm_pkr
        '
        Me.pt_dia_mod_frm_pkr.CustomFormat = "yyyy/MM/dd HH:mm:ss"
        Me.pt_dia_mod_frm_pkr.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.pt_dia_mod_frm_pkr.Location = New System.Drawing.Point(48, 19)
        Me.pt_dia_mod_frm_pkr.Name = "pt_dia_mod_frm_pkr"
        Me.pt_dia_mod_frm_pkr.Size = New System.Drawing.Size(125, 20)
        Me.pt_dia_mod_frm_pkr.TabIndex = 0
        '
        'pt_grid
        '
        Me.pt_grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.pt_grid.Location = New System.Drawing.Point(5, 143)
        Me.pt_grid.Name = "pt_grid"
        Me.pt_grid.Size = New System.Drawing.Size(518, 395)
        Me.pt_grid.TabIndex = 21
        '
        'pt_vst_rcrd_mod
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(993, 547)
        Me.Controls.Add(Me.pt_grid)
        Me.Controls.Add(Me.pt_vst_rcrd_mod_grbbx)
        Me.Controls.Add(Me.pt_dia_mod_srch_grbbx)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "pt_vst_rcrd_mod"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Patient Visit Record Modification"
        Me.pt_vst_rcrd_mod_grbbx.ResumeLayout(False)
        Me.pt_vst_rcrd_mod_grbbx.PerformLayout()
        Me.pt_dia_mod_srch_grbbx.ResumeLayout(False)
        Me.pt_dia_mod_srch_grbbx.PerformLayout()
        CType(Me.pt_grid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pt_vst_rcrd_mod_grbbx As GroupBox
    Friend WithEvents pt_dia_mod_srch_grbbx As GroupBox
    Friend WithEvents fltr_pt_id_txtbx As TextBox
    Friend WithEvents pt_dia_mod_all_btn As Button
    Friend WithEvents pt_dia_mod_srch_btn As Button
    Friend WithEvents pt_dia_mod_rst_today_btn As Button
    Friend WithEvents pt_dia_mod_to_lbl As Label
    Friend WithEvents pt_dia_mod_fltrby_lbl As Label
    Friend WithEvents pt_dia_mod_frm_lbl As Label
    Friend WithEvents pt_dia_mod_to_pkr As DateTimePicker
    Friend WithEvents pt_dia_mod_frm_pkr As DateTimePicker
    Friend WithEvents drp_btn As Button
    Friend WithEvents pt_dia_rchtxtbx As RichTextBox
    Friend WithEvents pt_id_lbl As Label
    Friend WithEvents pt_id_txtbx As TextBox
    Friend WithEvents pt_dia_lbl As Label
    Friend WithEvents vst_id_lbl As Label
    Friend WithEvents vst_id_txtbx As TextBox
    Friend WithEvents dr_nm_lbl As Label
    Friend WithEvents dr_id_lbl As Label
    Friend WithEvents pt_nm_lbl As Label
    Friend WithEvents dr_nm_txtbx As TextBox
    Friend WithEvents dr_id_txtbx As TextBox
    Friend WithEvents pt_nm_txtbx As TextBox
    Friend WithEvents pres_rchtxtbx As RichTextBox
    Friend WithEvents pres_lbl As Label
    Friend WithEvents updt_btn As Button
    Friend WithEvents pt_grid As DataGridView
    Friend WithEvents fltr_doct_id_txtbx As TextBox
    Friend WithEvents doct_id_chkbx As CheckBox
    Friend WithEvents pt_id_chkbx As CheckBox
End Class
