<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class pt_reg
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(pt_reg))
        Me.cvl_id_lbl = New System.Windows.Forms.Label()
        Me.cvl_id_txtbx = New System.Windows.Forms.TextBox()
        Me.frst_nm_lbl = New System.Windows.Forms.Label()
        Me.frst_nm_txtbx = New System.Windows.Forms.TextBox()
        Me.scnd_nm_lbl = New System.Windows.Forms.Label()
        Me.scnd_nm_txtbx = New System.Windows.Forms.TextBox()
        Me.thrd_nm_lbl = New System.Windows.Forms.Label()
        Me.thrd_nm_txtbx = New System.Windows.Forms.TextBox()
        Me.frth_nm_lbl = New System.Windows.Forms.Label()
        Me.frth_nm_txtbx = New System.Windows.Forms.TextBox()
        Me.trib_nm_lbl = New System.Windows.Forms.Label()
        Me.trib_nm_txtbx = New System.Windows.Forms.TextBox()
        Me.dob_lbl = New System.Windows.Forms.Label()
        Me.gndr_lbl = New System.Windows.Forms.Label()
        Me.phn_no_lbl = New System.Windows.Forms.Label()
        Me.phn_no_txtbx = New System.Windows.Forms.TextBox()
        Me.adrs_lbl = New System.Windows.Forms.Label()
        Me.adrs_txtbx = New System.Windows.Forms.TextBox()
        Me.nation_lbl = New System.Windows.Forms.Label()
        Me.nation_txtbx = New System.Windows.Forms.TextBox()
        Me.eml_lbl = New System.Windows.Forms.Label()
        Me.eml_txtbx = New System.Windows.Forms.TextBox()
        Me.dob_pkr = New System.Windows.Forms.DateTimePicker()
        Me.gndr_cbx = New System.Windows.Forms.ComboBox()
        Me.sbmt_btn = New System.Windows.Forms.Button()
        Me.prfx_cbx = New System.Windows.Forms.ComboBox()
        Me.prfx_lbl = New System.Windows.Forms.Label()
        Me.bld_typ_lbl = New System.Windows.Forms.Label()
        Me.bld_typ_txtbx = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'cvl_id_lbl
        '
        Me.cvl_id_lbl.AutoSize = True
        Me.cvl_id_lbl.ForeColor = System.Drawing.Color.Maroon
        Me.cvl_id_lbl.Location = New System.Drawing.Point(13, 41)
        Me.cvl_id_lbl.Name = "cvl_id_lbl"
        Me.cvl_id_lbl.Size = New System.Drawing.Size(46, 13)
        Me.cvl_id_lbl.TabIndex = 12
        Me.cvl_id_lbl.Text = "Civil ID :"
        '
        'cvl_id_txtbx
        '
        Me.cvl_id_txtbx.Location = New System.Drawing.Point(93, 38)
        Me.cvl_id_txtbx.Name = "cvl_id_txtbx"
        Me.cvl_id_txtbx.Size = New System.Drawing.Size(100, 20)
        Me.cvl_id_txtbx.TabIndex = 0
        Me.cvl_id_txtbx.Tag = "ImpoFields"
        '
        'frst_nm_lbl
        '
        Me.frst_nm_lbl.AutoSize = True
        Me.frst_nm_lbl.ForeColor = System.Drawing.Color.Maroon
        Me.frst_nm_lbl.Location = New System.Drawing.Point(13, 93)
        Me.frst_nm_lbl.Name = "frst_nm_lbl"
        Me.frst_nm_lbl.Size = New System.Drawing.Size(63, 13)
        Me.frst_nm_lbl.TabIndex = 13
        Me.frst_nm_lbl.Text = "First Name :"
        '
        'frst_nm_txtbx
        '
        Me.frst_nm_txtbx.Location = New System.Drawing.Point(93, 90)
        Me.frst_nm_txtbx.Name = "frst_nm_txtbx"
        Me.frst_nm_txtbx.Size = New System.Drawing.Size(100, 20)
        Me.frst_nm_txtbx.TabIndex = 1
        Me.frst_nm_txtbx.Tag = "ImpoFields"
        '
        'scnd_nm_lbl
        '
        Me.scnd_nm_lbl.AutoSize = True
        Me.scnd_nm_lbl.ForeColor = System.Drawing.Color.Maroon
        Me.scnd_nm_lbl.Location = New System.Drawing.Point(13, 119)
        Me.scnd_nm_lbl.Name = "scnd_nm_lbl"
        Me.scnd_nm_lbl.Size = New System.Drawing.Size(81, 13)
        Me.scnd_nm_lbl.TabIndex = 14
        Me.scnd_nm_lbl.Text = "Second Name :"
        '
        'scnd_nm_txtbx
        '
        Me.scnd_nm_txtbx.Location = New System.Drawing.Point(93, 116)
        Me.scnd_nm_txtbx.Name = "scnd_nm_txtbx"
        Me.scnd_nm_txtbx.Size = New System.Drawing.Size(100, 20)
        Me.scnd_nm_txtbx.TabIndex = 2
        Me.scnd_nm_txtbx.Tag = "ImpoFields"
        '
        'thrd_nm_lbl
        '
        Me.thrd_nm_lbl.AutoSize = True
        Me.thrd_nm_lbl.Location = New System.Drawing.Point(13, 145)
        Me.thrd_nm_lbl.Name = "thrd_nm_lbl"
        Me.thrd_nm_lbl.Size = New System.Drawing.Size(68, 13)
        Me.thrd_nm_lbl.TabIndex = 15
        Me.thrd_nm_lbl.Text = "Third Name :"
        '
        'thrd_nm_txtbx
        '
        Me.thrd_nm_txtbx.Location = New System.Drawing.Point(93, 142)
        Me.thrd_nm_txtbx.Name = "thrd_nm_txtbx"
        Me.thrd_nm_txtbx.Size = New System.Drawing.Size(100, 20)
        Me.thrd_nm_txtbx.TabIndex = 3
        '
        'frth_nm_lbl
        '
        Me.frth_nm_lbl.AutoSize = True
        Me.frth_nm_lbl.Location = New System.Drawing.Point(13, 171)
        Me.frth_nm_lbl.Name = "frth_nm_lbl"
        Me.frth_nm_lbl.Size = New System.Drawing.Size(74, 13)
        Me.frth_nm_lbl.TabIndex = 16
        Me.frth_nm_lbl.Text = "Fourth Name :"
        '
        'frth_nm_txtbx
        '
        Me.frth_nm_txtbx.Location = New System.Drawing.Point(93, 168)
        Me.frth_nm_txtbx.Name = "frth_nm_txtbx"
        Me.frth_nm_txtbx.Size = New System.Drawing.Size(100, 20)
        Me.frth_nm_txtbx.TabIndex = 4
        '
        'trib_nm_lbl
        '
        Me.trib_nm_lbl.AutoSize = True
        Me.trib_nm_lbl.ForeColor = System.Drawing.Color.Maroon
        Me.trib_nm_lbl.Location = New System.Drawing.Point(13, 197)
        Me.trib_nm_lbl.Name = "trib_nm_lbl"
        Me.trib_nm_lbl.Size = New System.Drawing.Size(68, 13)
        Me.trib_nm_lbl.TabIndex = 17
        Me.trib_nm_lbl.Text = "Tribe Name :"
        '
        'trib_nm_txtbx
        '
        Me.trib_nm_txtbx.Location = New System.Drawing.Point(93, 194)
        Me.trib_nm_txtbx.Name = "trib_nm_txtbx"
        Me.trib_nm_txtbx.Size = New System.Drawing.Size(100, 20)
        Me.trib_nm_txtbx.TabIndex = 5
        Me.trib_nm_txtbx.Tag = "ImpoFields"
        '
        'dob_lbl
        '
        Me.dob_lbl.AutoSize = True
        Me.dob_lbl.ForeColor = System.Drawing.Color.Maroon
        Me.dob_lbl.Location = New System.Drawing.Point(216, 41)
        Me.dob_lbl.Name = "dob_lbl"
        Me.dob_lbl.Size = New System.Drawing.Size(74, 13)
        Me.dob_lbl.TabIndex = 18
        Me.dob_lbl.Text = "Date Of Birth :"
        '
        'gndr_lbl
        '
        Me.gndr_lbl.AutoSize = True
        Me.gndr_lbl.ForeColor = System.Drawing.Color.Maroon
        Me.gndr_lbl.Location = New System.Drawing.Point(216, 67)
        Me.gndr_lbl.Name = "gndr_lbl"
        Me.gndr_lbl.Size = New System.Drawing.Size(48, 13)
        Me.gndr_lbl.TabIndex = 19
        Me.gndr_lbl.Text = "Gender :"
        '
        'phn_no_lbl
        '
        Me.phn_no_lbl.AutoSize = True
        Me.phn_no_lbl.ForeColor = System.Drawing.Color.Maroon
        Me.phn_no_lbl.Location = New System.Drawing.Point(216, 93)
        Me.phn_no_lbl.Name = "phn_no_lbl"
        Me.phn_no_lbl.Size = New System.Drawing.Size(63, 13)
        Me.phn_no_lbl.TabIndex = 20
        Me.phn_no_lbl.Text = "Phone NO :"
        '
        'phn_no_txtbx
        '
        Me.phn_no_txtbx.Location = New System.Drawing.Point(296, 90)
        Me.phn_no_txtbx.Name = "phn_no_txtbx"
        Me.phn_no_txtbx.Size = New System.Drawing.Size(100, 20)
        Me.phn_no_txtbx.TabIndex = 8
        Me.phn_no_txtbx.Tag = "ImpoFields"
        '
        'adrs_lbl
        '
        Me.adrs_lbl.AutoSize = True
        Me.adrs_lbl.ForeColor = System.Drawing.Color.Maroon
        Me.adrs_lbl.Location = New System.Drawing.Point(216, 119)
        Me.adrs_lbl.Name = "adrs_lbl"
        Me.adrs_lbl.Size = New System.Drawing.Size(51, 13)
        Me.adrs_lbl.TabIndex = 21
        Me.adrs_lbl.Text = "Address :"
        '
        'adrs_txtbx
        '
        Me.adrs_txtbx.Location = New System.Drawing.Point(296, 116)
        Me.adrs_txtbx.Name = "adrs_txtbx"
        Me.adrs_txtbx.Size = New System.Drawing.Size(100, 20)
        Me.adrs_txtbx.TabIndex = 9
        Me.adrs_txtbx.Tag = "ImpoFields"
        '
        'nation_lbl
        '
        Me.nation_lbl.AutoSize = True
        Me.nation_lbl.ForeColor = System.Drawing.Color.Maroon
        Me.nation_lbl.Location = New System.Drawing.Point(216, 145)
        Me.nation_lbl.Name = "nation_lbl"
        Me.nation_lbl.Size = New System.Drawing.Size(62, 13)
        Me.nation_lbl.TabIndex = 22
        Me.nation_lbl.Text = "Nationality :"
        '
        'nation_txtbx
        '
        Me.nation_txtbx.Location = New System.Drawing.Point(296, 142)
        Me.nation_txtbx.Name = "nation_txtbx"
        Me.nation_txtbx.Size = New System.Drawing.Size(100, 20)
        Me.nation_txtbx.TabIndex = 10
        Me.nation_txtbx.Tag = "ImpoFields"
        '
        'eml_lbl
        '
        Me.eml_lbl.AutoSize = True
        Me.eml_lbl.Location = New System.Drawing.Point(216, 171)
        Me.eml_lbl.Name = "eml_lbl"
        Me.eml_lbl.Size = New System.Drawing.Size(42, 13)
        Me.eml_lbl.TabIndex = 23
        Me.eml_lbl.Text = "E-Mail :"
        '
        'eml_txtbx
        '
        Me.eml_txtbx.Location = New System.Drawing.Point(296, 168)
        Me.eml_txtbx.Name = "eml_txtbx"
        Me.eml_txtbx.Size = New System.Drawing.Size(100, 20)
        Me.eml_txtbx.TabIndex = 11
        Me.eml_txtbx.Tag = ""
        '
        'dob_pkr
        '
        Me.dob_pkr.CustomFormat = "yyyy/MM/dd"
        Me.dob_pkr.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dob_pkr.Location = New System.Drawing.Point(296, 38)
        Me.dob_pkr.Name = "dob_pkr"
        Me.dob_pkr.Size = New System.Drawing.Size(100, 20)
        Me.dob_pkr.TabIndex = 6
        Me.dob_pkr.Tag = "ImpoFields"
        '
        'gndr_cbx
        '
        Me.gndr_cbx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.gndr_cbx.FormattingEnabled = True
        Me.gndr_cbx.Items.AddRange(New Object() {"Male", "Female", "Other"})
        Me.gndr_cbx.Location = New System.Drawing.Point(296, 63)
        Me.gndr_cbx.Name = "gndr_cbx"
        Me.gndr_cbx.Size = New System.Drawing.Size(100, 21)
        Me.gndr_cbx.TabIndex = 7
        Me.gndr_cbx.Tag = "ImpoFields"
        '
        'sbmt_btn
        '
        Me.sbmt_btn.Location = New System.Drawing.Point(321, 241)
        Me.sbmt_btn.Name = "sbmt_btn"
        Me.sbmt_btn.Size = New System.Drawing.Size(75, 23)
        Me.sbmt_btn.TabIndex = 12
        Me.sbmt_btn.Text = "Submit"
        Me.sbmt_btn.UseVisualStyleBackColor = True
        '
        'prfx_cbx
        '
        Me.prfx_cbx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.prfx_cbx.FormattingEnabled = True
        Me.prfx_cbx.Items.AddRange(New Object() {"Mr", "Mrs", "Ms", "Dr"})
        Me.prfx_cbx.Location = New System.Drawing.Point(93, 64)
        Me.prfx_cbx.Name = "prfx_cbx"
        Me.prfx_cbx.Size = New System.Drawing.Size(100, 21)
        Me.prfx_cbx.TabIndex = 38
        Me.prfx_cbx.Tag = "ImpoFields"
        '
        'prfx_lbl
        '
        Me.prfx_lbl.AutoSize = True
        Me.prfx_lbl.ForeColor = System.Drawing.Color.Maroon
        Me.prfx_lbl.Location = New System.Drawing.Point(13, 68)
        Me.prfx_lbl.Name = "prfx_lbl"
        Me.prfx_lbl.Size = New System.Drawing.Size(39, 13)
        Me.prfx_lbl.TabIndex = 39
        Me.prfx_lbl.Text = "Prefix :"
        '
        'bld_typ_lbl
        '
        Me.bld_typ_lbl.AutoSize = True
        Me.bld_typ_lbl.Location = New System.Drawing.Point(216, 197)
        Me.bld_typ_lbl.Name = "bld_typ_lbl"
        Me.bld_typ_lbl.Size = New System.Drawing.Size(67, 13)
        Me.bld_typ_lbl.TabIndex = 23
        Me.bld_typ_lbl.Text = "Blood Type :"
        '
        'bld_typ_txtbx
        '
        Me.bld_typ_txtbx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.bld_typ_txtbx.FormattingEnabled = True
        Me.bld_typ_txtbx.Items.AddRange(New Object() {"O-positive", "O-negative", "A-positive", "A-negative", "B-positive", "B-negative", "AB-positive", "AB-negative"})
        Me.bld_typ_txtbx.Location = New System.Drawing.Point(296, 194)
        Me.bld_typ_txtbx.Name = "bld_typ_txtbx"
        Me.bld_typ_txtbx.Size = New System.Drawing.Size(102, 21)
        Me.bld_typ_txtbx.TabIndex = 70
        '
        'pt_reg
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(414, 287)
        Me.Controls.Add(Me.bld_typ_txtbx)
        Me.Controls.Add(Me.prfx_cbx)
        Me.Controls.Add(Me.prfx_lbl)
        Me.Controls.Add(Me.sbmt_btn)
        Me.Controls.Add(Me.gndr_cbx)
        Me.Controls.Add(Me.dob_pkr)
        Me.Controls.Add(Me.eml_txtbx)
        Me.Controls.Add(Me.bld_typ_lbl)
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
        Me.Controls.Add(Me.frst_nm_txtbx)
        Me.Controls.Add(Me.gndr_lbl)
        Me.Controls.Add(Me.frst_nm_lbl)
        Me.Controls.Add(Me.dob_lbl)
        Me.Controls.Add(Me.cvl_id_txtbx)
        Me.Controls.Add(Me.cvl_id_lbl)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "pt_reg"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Patient Registration"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cvl_id_lbl As Label
    Friend WithEvents cvl_id_txtbx As TextBox
    Friend WithEvents frst_nm_lbl As Label
    Friend WithEvents frst_nm_txtbx As TextBox
    Friend WithEvents scnd_nm_lbl As Label
    Friend WithEvents scnd_nm_txtbx As TextBox
    Friend WithEvents thrd_nm_lbl As Label
    Friend WithEvents thrd_nm_txtbx As TextBox
    Friend WithEvents frth_nm_lbl As Label
    Friend WithEvents frth_nm_txtbx As TextBox
    Friend WithEvents trib_nm_lbl As Label
    Friend WithEvents trib_nm_txtbx As TextBox
    Friend WithEvents dob_lbl As Label
    Friend WithEvents gndr_lbl As Label
    Friend WithEvents phn_no_lbl As Label
    Friend WithEvents phn_no_txtbx As TextBox
    Friend WithEvents adrs_lbl As Label
    Friend WithEvents adrs_txtbx As TextBox
    Friend WithEvents nation_lbl As Label
    Friend WithEvents nation_txtbx As TextBox
    Friend WithEvents eml_lbl As Label
    Friend WithEvents eml_txtbx As TextBox
    Friend WithEvents dob_pkr As DateTimePicker
    Friend WithEvents gndr_cbx As ComboBox
    Friend WithEvents sbmt_btn As Button
    Friend WithEvents prfx_cbx As ComboBox
    Friend WithEvents prfx_lbl As Label
    Friend WithEvents bld_typ_lbl As Label
    Friend WithEvents bld_typ_txtbx As ComboBox
End Class
