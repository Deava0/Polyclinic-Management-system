<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class pt_q
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(pt_q))
        Me.pt_q_grid = New System.Windows.Forms.DataGridView()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.RefreshQueueTableToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RefreshDoctorTableToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.bsk_pt_inf_grbbx = New System.Windows.Forms.GroupBox()
        Me.bld_type_txtbx = New System.Windows.Forms.ComboBox()
        Me.apt_chkbx = New System.Windows.Forms.CheckBox()
        Me.pt_nm_lbl = New System.Windows.Forms.Label()
        Me.weight_lbl = New System.Windows.Forms.Label()
        Me.bld_pres_lbl = New System.Windows.Forms.Label()
        Me.bld_type_lbl = New System.Windows.Forms.Label()
        Me.height_lbl = New System.Windows.Forms.Label()
        Me.pt_id_lbl = New System.Windows.Forms.Label()
        Me.pt_nm_txtbx = New System.Windows.Forms.TextBox()
        Me.weight_txtbx = New System.Windows.Forms.TextBox()
        Me.height_txtbx = New System.Windows.Forms.TextBox()
        Me.bld_pres_txtbx = New System.Windows.Forms.TextBox()
        Me.pt_id_txtbx = New System.Windows.Forms.TextBox()
        Me.snd_in_btn = New System.Windows.Forms.Button()
        Me.doct_wrk_q_grid = New System.Windows.Forms.DataGridView()
        Me.bsk_doct_inf_grbbx = New System.Windows.Forms.GroupBox()
        Me.doct_nm_lbl = New System.Windows.Forms.Label()
        Me.doct_wrk_sts = New System.Windows.Forms.Label()
        Me.doct_id_lbl = New System.Windows.Forms.Label()
        Me.doct_nm_txtbx = New System.Windows.Forms.TextBox()
        Me.doct_id_txtbx = New System.Windows.Forms.TextBox()
        CType(Me.pt_q_grid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.bsk_pt_inf_grbbx.SuspendLayout()
        CType(Me.doct_wrk_q_grid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.bsk_doct_inf_grbbx.SuspendLayout()
        Me.SuspendLayout()
        '
        'pt_q_grid
        '
        Me.pt_q_grid.AllowUserToAddRows = False
        Me.pt_q_grid.AllowUserToDeleteRows = False
        Me.pt_q_grid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.pt_q_grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.pt_q_grid.Dock = System.Windows.Forms.DockStyle.Left
        Me.pt_q_grid.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.pt_q_grid.Location = New System.Drawing.Point(0, 24)
        Me.pt_q_grid.Name = "pt_q_grid"
        Me.pt_q_grid.Size = New System.Drawing.Size(515, 554)
        Me.pt_q_grid.TabIndex = 8
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RefreshQueueTableToolStripMenuItem, Me.RefreshDoctorTableToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1198, 24)
        Me.MenuStrip1.TabIndex = 9
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'RefreshQueueTableToolStripMenuItem
        '
        Me.RefreshQueueTableToolStripMenuItem.Name = "RefreshQueueTableToolStripMenuItem"
        Me.RefreshQueueTableToolStripMenuItem.Size = New System.Drawing.Size(127, 20)
        Me.RefreshQueueTableToolStripMenuItem.Text = "Refresh Queue Table"
        '
        'RefreshDoctorTableToolStripMenuItem
        '
        Me.RefreshDoctorTableToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.RefreshDoctorTableToolStripMenuItem.Name = "RefreshDoctorTableToolStripMenuItem"
        Me.RefreshDoctorTableToolStripMenuItem.Size = New System.Drawing.Size(128, 20)
        Me.RefreshDoctorTableToolStripMenuItem.Text = "Refresh Doctor Table"
        '
        'bsk_pt_inf_grbbx
        '
        Me.bsk_pt_inf_grbbx.Controls.Add(Me.bld_type_txtbx)
        Me.bsk_pt_inf_grbbx.Controls.Add(Me.apt_chkbx)
        Me.bsk_pt_inf_grbbx.Controls.Add(Me.pt_nm_lbl)
        Me.bsk_pt_inf_grbbx.Controls.Add(Me.weight_lbl)
        Me.bsk_pt_inf_grbbx.Controls.Add(Me.bld_pres_lbl)
        Me.bsk_pt_inf_grbbx.Controls.Add(Me.bld_type_lbl)
        Me.bsk_pt_inf_grbbx.Controls.Add(Me.height_lbl)
        Me.bsk_pt_inf_grbbx.Controls.Add(Me.pt_id_lbl)
        Me.bsk_pt_inf_grbbx.Controls.Add(Me.pt_nm_txtbx)
        Me.bsk_pt_inf_grbbx.Controls.Add(Me.weight_txtbx)
        Me.bsk_pt_inf_grbbx.Controls.Add(Me.height_txtbx)
        Me.bsk_pt_inf_grbbx.Controls.Add(Me.bld_pres_txtbx)
        Me.bsk_pt_inf_grbbx.Controls.Add(Me.pt_id_txtbx)
        Me.bsk_pt_inf_grbbx.Location = New System.Drawing.Point(524, 373)
        Me.bsk_pt_inf_grbbx.Name = "bsk_pt_inf_grbbx"
        Me.bsk_pt_inf_grbbx.Size = New System.Drawing.Size(299, 205)
        Me.bsk_pt_inf_grbbx.TabIndex = 10
        Me.bsk_pt_inf_grbbx.TabStop = False
        Me.bsk_pt_inf_grbbx.Text = "Basic Patient Info :"
        '
        'bld_type_txtbx
        '
        Me.bld_type_txtbx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.bld_type_txtbx.FormattingEnabled = True
        Me.bld_type_txtbx.Items.AddRange(New Object() {"O-positive", "O-negative", "A-positive", "A-negative", "B-positive", "B-negative", "AB-positive", "AB-negative", "UNKNOWN"})
        Me.bld_type_txtbx.Location = New System.Drawing.Point(86, 98)
        Me.bld_type_txtbx.Name = "bld_type_txtbx"
        Me.bld_type_txtbx.Size = New System.Drawing.Size(102, 21)
        Me.bld_type_txtbx.TabIndex = 3
        '
        'apt_chkbx
        '
        Me.apt_chkbx.AutoSize = True
        Me.apt_chkbx.Location = New System.Drawing.Point(88, 78)
        Me.apt_chkbx.Name = "apt_chkbx"
        Me.apt_chkbx.Size = New System.Drawing.Size(85, 17)
        Me.apt_chkbx.TabIndex = 2
        Me.apt_chkbx.Text = "Appointment"
        Me.apt_chkbx.UseVisualStyleBackColor = True
        '
        'pt_nm_lbl
        '
        Me.pt_nm_lbl.AutoSize = True
        Me.pt_nm_lbl.Location = New System.Drawing.Point(6, 57)
        Me.pt_nm_lbl.Name = "pt_nm_lbl"
        Me.pt_nm_lbl.Size = New System.Drawing.Size(71, 13)
        Me.pt_nm_lbl.TabIndex = 1
        Me.pt_nm_lbl.Text = "Patient Name"
        '
        'weight_lbl
        '
        Me.weight_lbl.AutoSize = True
        Me.weight_lbl.Location = New System.Drawing.Point(6, 179)
        Me.weight_lbl.Name = "weight_lbl"
        Me.weight_lbl.Size = New System.Drawing.Size(41, 13)
        Me.weight_lbl.TabIndex = 1
        Me.weight_lbl.Text = "Weight"
        '
        'bld_pres_lbl
        '
        Me.bld_pres_lbl.AutoSize = True
        Me.bld_pres_lbl.Location = New System.Drawing.Point(6, 127)
        Me.bld_pres_lbl.Name = "bld_pres_lbl"
        Me.bld_pres_lbl.Size = New System.Drawing.Size(78, 13)
        Me.bld_pres_lbl.TabIndex = 1
        Me.bld_pres_lbl.Text = "Blood Pressure"
        '
        'bld_type_lbl
        '
        Me.bld_type_lbl.AutoSize = True
        Me.bld_type_lbl.Location = New System.Drawing.Point(6, 101)
        Me.bld_type_lbl.Name = "bld_type_lbl"
        Me.bld_type_lbl.Size = New System.Drawing.Size(61, 13)
        Me.bld_type_lbl.TabIndex = 1
        Me.bld_type_lbl.Text = "Blood Type"
        '
        'height_lbl
        '
        Me.height_lbl.AutoSize = True
        Me.height_lbl.Location = New System.Drawing.Point(6, 153)
        Me.height_lbl.Name = "height_lbl"
        Me.height_lbl.Size = New System.Drawing.Size(38, 13)
        Me.height_lbl.TabIndex = 1
        Me.height_lbl.Text = "Height"
        '
        'pt_id_lbl
        '
        Me.pt_id_lbl.AutoSize = True
        Me.pt_id_lbl.Location = New System.Drawing.Point(6, 31)
        Me.pt_id_lbl.Name = "pt_id_lbl"
        Me.pt_id_lbl.Size = New System.Drawing.Size(54, 13)
        Me.pt_id_lbl.TabIndex = 1
        Me.pt_id_lbl.Text = "Patient ID"
        '
        'pt_nm_txtbx
        '
        Me.pt_nm_txtbx.Location = New System.Drawing.Point(83, 54)
        Me.pt_nm_txtbx.Name = "pt_nm_txtbx"
        Me.pt_nm_txtbx.Size = New System.Drawing.Size(193, 20)
        Me.pt_nm_txtbx.TabIndex = 0
        '
        'weight_txtbx
        '
        Me.weight_txtbx.Location = New System.Drawing.Point(88, 176)
        Me.weight_txtbx.Name = "weight_txtbx"
        Me.weight_txtbx.Size = New System.Drawing.Size(100, 20)
        Me.weight_txtbx.TabIndex = 0
        Me.weight_txtbx.Tag = "pt_inf"
        '
        'height_txtbx
        '
        Me.height_txtbx.Location = New System.Drawing.Point(88, 150)
        Me.height_txtbx.Name = "height_txtbx"
        Me.height_txtbx.Size = New System.Drawing.Size(100, 20)
        Me.height_txtbx.TabIndex = 0
        Me.height_txtbx.Tag = "pt_inf"
        '
        'bld_pres_txtbx
        '
        Me.bld_pres_txtbx.Location = New System.Drawing.Point(88, 124)
        Me.bld_pres_txtbx.Name = "bld_pres_txtbx"
        Me.bld_pres_txtbx.Size = New System.Drawing.Size(100, 20)
        Me.bld_pres_txtbx.TabIndex = 0
        Me.bld_pres_txtbx.Tag = "pt_inf"
        '
        'pt_id_txtbx
        '
        Me.pt_id_txtbx.Location = New System.Drawing.Point(66, 28)
        Me.pt_id_txtbx.Name = "pt_id_txtbx"
        Me.pt_id_txtbx.Size = New System.Drawing.Size(100, 20)
        Me.pt_id_txtbx.TabIndex = 0
        '
        'snd_in_btn
        '
        Me.snd_in_btn.Location = New System.Drawing.Point(218, 117)
        Me.snd_in_btn.Name = "snd_in_btn"
        Me.snd_in_btn.Size = New System.Drawing.Size(75, 23)
        Me.snd_in_btn.TabIndex = 3
        Me.snd_in_btn.Text = "Send In"
        Me.snd_in_btn.UseVisualStyleBackColor = True
        '
        'doct_wrk_q_grid
        '
        Me.doct_wrk_q_grid.AllowUserToAddRows = False
        Me.doct_wrk_q_grid.AllowUserToDeleteRows = False
        Me.doct_wrk_q_grid.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.doct_wrk_q_grid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.doct_wrk_q_grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.doct_wrk_q_grid.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.doct_wrk_q_grid.Location = New System.Drawing.Point(524, 24)
        Me.doct_wrk_q_grid.Name = "doct_wrk_q_grid"
        Me.doct_wrk_q_grid.Size = New System.Drawing.Size(674, 340)
        Me.doct_wrk_q_grid.TabIndex = 11
        '
        'bsk_doct_inf_grbbx
        '
        Me.bsk_doct_inf_grbbx.Controls.Add(Me.doct_nm_lbl)
        Me.bsk_doct_inf_grbbx.Controls.Add(Me.doct_wrk_sts)
        Me.bsk_doct_inf_grbbx.Controls.Add(Me.snd_in_btn)
        Me.bsk_doct_inf_grbbx.Controls.Add(Me.doct_id_lbl)
        Me.bsk_doct_inf_grbbx.Controls.Add(Me.doct_nm_txtbx)
        Me.bsk_doct_inf_grbbx.Controls.Add(Me.doct_id_txtbx)
        Me.bsk_doct_inf_grbbx.Location = New System.Drawing.Point(829, 373)
        Me.bsk_doct_inf_grbbx.Name = "bsk_doct_inf_grbbx"
        Me.bsk_doct_inf_grbbx.Size = New System.Drawing.Size(299, 148)
        Me.bsk_doct_inf_grbbx.TabIndex = 12
        Me.bsk_doct_inf_grbbx.TabStop = False
        Me.bsk_doct_inf_grbbx.Text = "Basic Doctor Info :"
        '
        'doct_nm_lbl
        '
        Me.doct_nm_lbl.AutoSize = True
        Me.doct_nm_lbl.Location = New System.Drawing.Point(11, 79)
        Me.doct_nm_lbl.Name = "doct_nm_lbl"
        Me.doct_nm_lbl.Size = New System.Drawing.Size(61, 13)
        Me.doct_nm_lbl.TabIndex = 1
        Me.doct_nm_lbl.Text = "Doct Name"
        '
        'doct_wrk_sts
        '
        Me.doct_wrk_sts.AutoSize = True
        Me.doct_wrk_sts.Location = New System.Drawing.Point(105, 28)
        Me.doct_wrk_sts.Name = "doct_wrk_sts"
        Me.doct_wrk_sts.Size = New System.Drawing.Size(66, 13)
        Me.doct_wrk_sts.TabIndex = 1
        Me.doct_wrk_sts.Text = "Work Status"
        '
        'doct_id_lbl
        '
        Me.doct_id_lbl.AutoSize = True
        Me.doct_id_lbl.Location = New System.Drawing.Point(11, 53)
        Me.doct_id_lbl.Name = "doct_id_lbl"
        Me.doct_id_lbl.Size = New System.Drawing.Size(53, 13)
        Me.doct_id_lbl.TabIndex = 1
        Me.doct_id_lbl.Text = "Doctor ID"
        '
        'doct_nm_txtbx
        '
        Me.doct_nm_txtbx.Location = New System.Drawing.Point(88, 76)
        Me.doct_nm_txtbx.Name = "doct_nm_txtbx"
        Me.doct_nm_txtbx.Size = New System.Drawing.Size(193, 20)
        Me.doct_nm_txtbx.TabIndex = 0
        '
        'doct_id_txtbx
        '
        Me.doct_id_txtbx.Location = New System.Drawing.Point(71, 50)
        Me.doct_id_txtbx.Name = "doct_id_txtbx"
        Me.doct_id_txtbx.Size = New System.Drawing.Size(100, 20)
        Me.doct_id_txtbx.TabIndex = 0
        '
        'pt_q
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(1198, 578)
        Me.Controls.Add(Me.bsk_doct_inf_grbbx)
        Me.Controls.Add(Me.doct_wrk_q_grid)
        Me.Controls.Add(Me.bsk_pt_inf_grbbx)
        Me.Controls.Add(Me.pt_q_grid)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "pt_q"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Doctor Consultation Queue"
        CType(Me.pt_q_grid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.bsk_pt_inf_grbbx.ResumeLayout(False)
        Me.bsk_pt_inf_grbbx.PerformLayout()
        CType(Me.doct_wrk_q_grid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.bsk_doct_inf_grbbx.ResumeLayout(False)
        Me.bsk_doct_inf_grbbx.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents pt_q_grid As DataGridView
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents RefreshQueueTableToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents bsk_pt_inf_grbbx As GroupBox
    Friend WithEvents apt_chkbx As CheckBox
    Friend WithEvents pt_nm_lbl As Label
    Friend WithEvents weight_lbl As Label
    Friend WithEvents bld_pres_lbl As Label
    Friend WithEvents bld_type_lbl As Label
    Friend WithEvents height_lbl As Label
    Friend WithEvents pt_id_lbl As Label
    Friend WithEvents pt_nm_txtbx As TextBox
    Friend WithEvents weight_txtbx As TextBox
    Friend WithEvents height_txtbx As TextBox
    Friend WithEvents bld_pres_txtbx As TextBox
    Friend WithEvents pt_id_txtbx As TextBox
    Friend WithEvents snd_in_btn As Button
    Friend WithEvents RefreshDoctorTableToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents doct_wrk_q_grid As DataGridView
    Friend WithEvents bsk_doct_inf_grbbx As GroupBox
    Friend WithEvents doct_nm_lbl As Label
    Friend WithEvents doct_wrk_sts As Label
    Friend WithEvents doct_id_lbl As Label
    Friend WithEvents doct_nm_txtbx As TextBox
    Friend WithEvents doct_id_txtbx As TextBox
    Friend WithEvents bld_type_txtbx As ComboBox
End Class
