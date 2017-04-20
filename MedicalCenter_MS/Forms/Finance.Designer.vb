<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Finance
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Finance))
        Me.pt_grid = New System.Windows.Forms.DataGridView()
        Me.fee_rcrd_fltr_grbbx = New System.Windows.Forms.GroupBox()
        Me.status_combbx = New System.Windows.Forms.ComboBox()
        Me.srch_txtbx = New System.Windows.Forms.TextBox()
        Me.rst_tbl_btn = New System.Windows.Forms.Button()
        Me.pt_pno_rbtn = New System.Windows.Forms.RadioButton()
        Me.pt_nm_rbtn = New System.Windows.Forms.RadioButton()
        Me.pt_cvl_id_rbtn = New System.Windows.Forms.RadioButton()
        Me.pt_id_rbtn = New System.Windows.Forms.RadioButton()
        Me.fee_inf_grbbx = New System.Windows.Forms.GroupBox()
        Me.curncy_combobox = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.pay_count_txtbx = New System.Windows.Forms.TextBox()
        Me.total_txtbx = New System.Windows.Forms.TextBox()
        Me.exe_py_btn = New System.Windows.Forms.Button()
        Me.pymnt_inf_grbbx = New System.Windows.Forms.GroupBox()
        Me.pay_status_txtbx = New System.Windows.Forms.TextBox()
        Me.pay_status_lbl = New System.Windows.Forms.Label()
        Me.rmv_frm_lst_btn = New System.Windows.Forms.Button()
        Me.pay_time_txtbx = New System.Windows.Forms.TextBox()
        Me.fee_type_txtbx = New System.Windows.Forms.TextBox()
        Me.fee_txtbx = New System.Windows.Forms.TextBox()
        Me.com_time_txtbx = New System.Windows.Forms.TextBox()
        Me.py_id_txtbx = New System.Windows.Forms.TextBox()
        Me.payee_id_txtbx = New System.Windows.Forms.TextBox()
        Me.payee_name_txtbx = New System.Windows.Forms.TextBox()
        Me.usr_name_txtbx = New System.Windows.Forms.TextBox()
        Me.usr_id_txtbx = New System.Windows.Forms.TextBox()
        Me.pay_time_lbl = New System.Windows.Forms.Label()
        Me.fee_type_lbl = New System.Windows.Forms.Label()
        Me.com_time_lbl = New System.Windows.Forms.Label()
        Me.fee_lbl = New System.Windows.Forms.Label()
        Me.payee_id_lbl = New System.Windows.Forms.Label()
        Me.py_id_lbl = New System.Windows.Forms.Label()
        Me.usr_id_lbl = New System.Windows.Forms.Label()
        Me.fees_lstbx = New System.Windows.Forms.ListBox()
        Me.clr_lst_btn = New System.Windows.Forms.Button()
        Me.pay_btn = New System.Windows.Forms.Button()
        CType(Me.pt_grid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.fee_rcrd_fltr_grbbx.SuspendLayout()
        Me.fee_inf_grbbx.SuspendLayout()
        Me.pymnt_inf_grbbx.SuspendLayout()
        Me.SuspendLayout()
        '
        'pt_grid
        '
        Me.pt_grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.pt_grid.Location = New System.Drawing.Point(12, 116)
        Me.pt_grid.Name = "pt_grid"
        Me.pt_grid.Size = New System.Drawing.Size(509, 463)
        Me.pt_grid.TabIndex = 20
        '
        'fee_rcrd_fltr_grbbx
        '
        Me.fee_rcrd_fltr_grbbx.Controls.Add(Me.status_combbx)
        Me.fee_rcrd_fltr_grbbx.Controls.Add(Me.srch_txtbx)
        Me.fee_rcrd_fltr_grbbx.Controls.Add(Me.rst_tbl_btn)
        Me.fee_rcrd_fltr_grbbx.Controls.Add(Me.pt_pno_rbtn)
        Me.fee_rcrd_fltr_grbbx.Controls.Add(Me.pt_nm_rbtn)
        Me.fee_rcrd_fltr_grbbx.Controls.Add(Me.pt_cvl_id_rbtn)
        Me.fee_rcrd_fltr_grbbx.Controls.Add(Me.pt_id_rbtn)
        Me.fee_rcrd_fltr_grbbx.Location = New System.Drawing.Point(12, 12)
        Me.fee_rcrd_fltr_grbbx.Name = "fee_rcrd_fltr_grbbx"
        Me.fee_rcrd_fltr_grbbx.Size = New System.Drawing.Size(509, 98)
        Me.fee_rcrd_fltr_grbbx.TabIndex = 22
        Me.fee_rcrd_fltr_grbbx.TabStop = False
        Me.fee_rcrd_fltr_grbbx.Text = "Patient fees filter"
        '
        'status_combbx
        '
        Me.status_combbx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.status_combbx.FormattingEnabled = True
        Me.status_combbx.Items.AddRange(New Object() {"Payed", "Unpayed"})
        Me.status_combbx.Location = New System.Drawing.Point(259, 26)
        Me.status_combbx.Name = "status_combbx"
        Me.status_combbx.Size = New System.Drawing.Size(121, 21)
        Me.status_combbx.TabIndex = 9
        '
        'srch_txtbx
        '
        Me.srch_txtbx.Location = New System.Drawing.Point(10, 62)
        Me.srch_txtbx.Name = "srch_txtbx"
        Me.srch_txtbx.Size = New System.Drawing.Size(243, 20)
        Me.srch_txtbx.TabIndex = 8
        '
        'rst_tbl_btn
        '
        Me.rst_tbl_btn.Location = New System.Drawing.Point(259, 59)
        Me.rst_tbl_btn.Name = "rst_tbl_btn"
        Me.rst_tbl_btn.Size = New System.Drawing.Size(121, 23)
        Me.rst_tbl_btn.TabIndex = 7
        Me.rst_tbl_btn.Text = "Reset Table"
        Me.rst_tbl_btn.UseVisualStyleBackColor = True
        '
        'pt_pno_rbtn
        '
        Me.pt_pno_rbtn.AutoSize = True
        Me.pt_pno_rbtn.Location = New System.Drawing.Point(175, 26)
        Me.pt_pno_rbtn.Name = "pt_pno_rbtn"
        Me.pt_pno_rbtn.Size = New System.Drawing.Size(78, 17)
        Me.pt_pno_rbtn.TabIndex = 3
        Me.pt_pno_rbtn.TabStop = True
        Me.pt_pno_rbtn.Text = "Phone NO."
        Me.pt_pno_rbtn.UseVisualStyleBackColor = True
        '
        'pt_nm_rbtn
        '
        Me.pt_nm_rbtn.AutoSize = True
        Me.pt_nm_rbtn.Location = New System.Drawing.Point(116, 26)
        Me.pt_nm_rbtn.Name = "pt_nm_rbtn"
        Me.pt_nm_rbtn.Size = New System.Drawing.Size(53, 17)
        Me.pt_nm_rbtn.TabIndex = 4
        Me.pt_nm_rbtn.TabStop = True
        Me.pt_nm_rbtn.Text = "Name"
        Me.pt_nm_rbtn.UseVisualStyleBackColor = True
        '
        'pt_cvl_id_rbtn
        '
        Me.pt_cvl_id_rbtn.AutoSize = True
        Me.pt_cvl_id_rbtn.Location = New System.Drawing.Point(52, 26)
        Me.pt_cvl_id_rbtn.Name = "pt_cvl_id_rbtn"
        Me.pt_cvl_id_rbtn.Size = New System.Drawing.Size(58, 17)
        Me.pt_cvl_id_rbtn.TabIndex = 5
        Me.pt_cvl_id_rbtn.TabStop = True
        Me.pt_cvl_id_rbtn.Text = "Civil ID"
        Me.pt_cvl_id_rbtn.UseVisualStyleBackColor = True
        '
        'pt_id_rbtn
        '
        Me.pt_id_rbtn.AutoSize = True
        Me.pt_id_rbtn.Location = New System.Drawing.Point(10, 26)
        Me.pt_id_rbtn.Name = "pt_id_rbtn"
        Me.pt_id_rbtn.Size = New System.Drawing.Size(36, 17)
        Me.pt_id_rbtn.TabIndex = 6
        Me.pt_id_rbtn.TabStop = True
        Me.pt_id_rbtn.Text = "ID"
        Me.pt_id_rbtn.UseVisualStyleBackColor = True
        '
        'fee_inf_grbbx
        '
        Me.fee_inf_grbbx.Controls.Add(Me.curncy_combobox)
        Me.fee_inf_grbbx.Controls.Add(Me.Label2)
        Me.fee_inf_grbbx.Controls.Add(Me.Label1)
        Me.fee_inf_grbbx.Controls.Add(Me.pay_count_txtbx)
        Me.fee_inf_grbbx.Controls.Add(Me.total_txtbx)
        Me.fee_inf_grbbx.Controls.Add(Me.pay_btn)
        Me.fee_inf_grbbx.Location = New System.Drawing.Point(181, 268)
        Me.fee_inf_grbbx.Name = "fee_inf_grbbx"
        Me.fee_inf_grbbx.Size = New System.Drawing.Size(300, 98)
        Me.fee_inf_grbbx.TabIndex = 23
        Me.fee_inf_grbbx.TabStop = False
        Me.fee_inf_grbbx.Text = "Fee"
        '
        'curncy_combobox
        '
        Me.curncy_combobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.curncy_combobox.FormattingEnabled = True
        Me.curncy_combobox.Items.AddRange(New Object() {"OR.", "AED"})
        Me.curncy_combobox.Location = New System.Drawing.Point(237, 44)
        Me.curncy_combobox.Name = "curncy_combobox"
        Me.curncy_combobox.Size = New System.Drawing.Size(57, 21)
        Me.curncy_combobox.TabIndex = 9
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 22)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(111, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Number of Payments :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 48)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(76, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Total Amount :"
        '
        'pay_count_txtbx
        '
        Me.pay_count_txtbx.Location = New System.Drawing.Point(117, 19)
        Me.pay_count_txtbx.Name = "pay_count_txtbx"
        Me.pay_count_txtbx.ReadOnly = True
        Me.pay_count_txtbx.Size = New System.Drawing.Size(114, 20)
        Me.pay_count_txtbx.TabIndex = 0
        '
        'total_txtbx
        '
        Me.total_txtbx.Location = New System.Drawing.Point(82, 45)
        Me.total_txtbx.Name = "total_txtbx"
        Me.total_txtbx.ReadOnly = True
        Me.total_txtbx.Size = New System.Drawing.Size(149, 20)
        Me.total_txtbx.TabIndex = 0
        '
        'exe_py_btn
        '
        Me.exe_py_btn.Location = New System.Drawing.Point(6, 268)
        Me.exe_py_btn.Name = "exe_py_btn"
        Me.exe_py_btn.Size = New System.Drawing.Size(157, 98)
        Me.exe_py_btn.TabIndex = 10
        Me.exe_py_btn.Text = "Check !"
        Me.exe_py_btn.UseVisualStyleBackColor = True
        '
        'pymnt_inf_grbbx
        '
        Me.pymnt_inf_grbbx.Controls.Add(Me.exe_py_btn)
        Me.pymnt_inf_grbbx.Controls.Add(Me.pay_status_txtbx)
        Me.pymnt_inf_grbbx.Controls.Add(Me.fee_inf_grbbx)
        Me.pymnt_inf_grbbx.Controls.Add(Me.pay_status_lbl)
        Me.pymnt_inf_grbbx.Controls.Add(Me.clr_lst_btn)
        Me.pymnt_inf_grbbx.Controls.Add(Me.rmv_frm_lst_btn)
        Me.pymnt_inf_grbbx.Controls.Add(Me.pay_time_txtbx)
        Me.pymnt_inf_grbbx.Controls.Add(Me.fee_type_txtbx)
        Me.pymnt_inf_grbbx.Controls.Add(Me.fee_txtbx)
        Me.pymnt_inf_grbbx.Controls.Add(Me.com_time_txtbx)
        Me.pymnt_inf_grbbx.Controls.Add(Me.py_id_txtbx)
        Me.pymnt_inf_grbbx.Controls.Add(Me.payee_id_txtbx)
        Me.pymnt_inf_grbbx.Controls.Add(Me.payee_name_txtbx)
        Me.pymnt_inf_grbbx.Controls.Add(Me.usr_name_txtbx)
        Me.pymnt_inf_grbbx.Controls.Add(Me.usr_id_txtbx)
        Me.pymnt_inf_grbbx.Controls.Add(Me.pay_time_lbl)
        Me.pymnt_inf_grbbx.Controls.Add(Me.fee_type_lbl)
        Me.pymnt_inf_grbbx.Controls.Add(Me.com_time_lbl)
        Me.pymnt_inf_grbbx.Controls.Add(Me.fee_lbl)
        Me.pymnt_inf_grbbx.Controls.Add(Me.payee_id_lbl)
        Me.pymnt_inf_grbbx.Controls.Add(Me.py_id_lbl)
        Me.pymnt_inf_grbbx.Controls.Add(Me.usr_id_lbl)
        Me.pymnt_inf_grbbx.Controls.Add(Me.fees_lstbx)
        Me.pymnt_inf_grbbx.Location = New System.Drawing.Point(527, 116)
        Me.pymnt_inf_grbbx.Name = "pymnt_inf_grbbx"
        Me.pymnt_inf_grbbx.Size = New System.Drawing.Size(492, 375)
        Me.pymnt_inf_grbbx.TabIndex = 24
        Me.pymnt_inf_grbbx.TabStop = False
        Me.pymnt_inf_grbbx.Text = "Payment Info :"
        '
        'pay_status_txtbx
        '
        Me.pay_status_txtbx.Location = New System.Drawing.Point(181, 203)
        Me.pay_status_txtbx.Name = "pay_status_txtbx"
        Me.pay_status_txtbx.ReadOnly = True
        Me.pay_status_txtbx.Size = New System.Drawing.Size(121, 20)
        Me.pay_status_txtbx.TabIndex = 26
        Me.pay_status_txtbx.Tag = "Impo"
        '
        'pay_status_lbl
        '
        Me.pay_status_lbl.AutoSize = True
        Me.pay_status_lbl.Location = New System.Drawing.Point(78, 206)
        Me.pay_status_lbl.Name = "pay_status_lbl"
        Me.pay_status_lbl.Size = New System.Drawing.Size(90, 13)
        Me.pay_status_lbl.TabIndex = 25
        Me.pay_status_lbl.Text = "Payment Status : "
        '
        'rmv_frm_lst_btn
        '
        Me.rmv_frm_lst_btn.Location = New System.Drawing.Point(6, 237)
        Me.rmv_frm_lst_btn.Name = "rmv_frm_lst_btn"
        Me.rmv_frm_lst_btn.Size = New System.Drawing.Size(65, 23)
        Me.rmv_frm_lst_btn.TabIndex = 11
        Me.rmv_frm_lst_btn.Text = "Remove"
        Me.rmv_frm_lst_btn.UseVisualStyleBackColor = True
        '
        'pay_time_txtbx
        '
        Me.pay_time_txtbx.Location = New System.Drawing.Point(181, 177)
        Me.pay_time_txtbx.Name = "pay_time_txtbx"
        Me.pay_time_txtbx.ReadOnly = True
        Me.pay_time_txtbx.Size = New System.Drawing.Size(121, 20)
        Me.pay_time_txtbx.TabIndex = 19
        Me.pay_time_txtbx.Tag = "Impo"
        '
        'fee_type_txtbx
        '
        Me.fee_type_txtbx.Location = New System.Drawing.Point(181, 98)
        Me.fee_type_txtbx.Name = "fee_type_txtbx"
        Me.fee_type_txtbx.ReadOnly = True
        Me.fee_type_txtbx.Size = New System.Drawing.Size(121, 20)
        Me.fee_type_txtbx.TabIndex = 19
        Me.fee_type_txtbx.Tag = "Impo"
        '
        'fee_txtbx
        '
        Me.fee_txtbx.Location = New System.Drawing.Point(181, 124)
        Me.fee_txtbx.Name = "fee_txtbx"
        Me.fee_txtbx.ReadOnly = True
        Me.fee_txtbx.Size = New System.Drawing.Size(121, 20)
        Me.fee_txtbx.TabIndex = 19
        Me.fee_txtbx.Tag = "Impo"
        '
        'com_time_txtbx
        '
        Me.com_time_txtbx.Location = New System.Drawing.Point(181, 149)
        Me.com_time_txtbx.Name = "com_time_txtbx"
        Me.com_time_txtbx.ReadOnly = True
        Me.com_time_txtbx.Size = New System.Drawing.Size(121, 20)
        Me.com_time_txtbx.TabIndex = 21
        Me.com_time_txtbx.Tag = "Impo"
        '
        'py_id_txtbx
        '
        Me.py_id_txtbx.Location = New System.Drawing.Point(181, 19)
        Me.py_id_txtbx.Name = "py_id_txtbx"
        Me.py_id_txtbx.ReadOnly = True
        Me.py_id_txtbx.Size = New System.Drawing.Size(121, 20)
        Me.py_id_txtbx.TabIndex = 20
        Me.py_id_txtbx.Tag = "Impo"
        '
        'payee_id_txtbx
        '
        Me.payee_id_txtbx.Location = New System.Drawing.Point(181, 72)
        Me.payee_id_txtbx.Name = "payee_id_txtbx"
        Me.payee_id_txtbx.ReadOnly = True
        Me.payee_id_txtbx.Size = New System.Drawing.Size(121, 20)
        Me.payee_id_txtbx.TabIndex = 21
        Me.payee_id_txtbx.Tag = "Impo"
        '
        'payee_name_txtbx
        '
        Me.payee_name_txtbx.Location = New System.Drawing.Point(308, 73)
        Me.payee_name_txtbx.Name = "payee_name_txtbx"
        Me.payee_name_txtbx.ReadOnly = True
        Me.payee_name_txtbx.Size = New System.Drawing.Size(177, 20)
        Me.payee_name_txtbx.TabIndex = 21
        Me.payee_name_txtbx.Tag = "Impo"
        '
        'usr_name_txtbx
        '
        Me.usr_name_txtbx.Location = New System.Drawing.Point(308, 47)
        Me.usr_name_txtbx.Name = "usr_name_txtbx"
        Me.usr_name_txtbx.ReadOnly = True
        Me.usr_name_txtbx.Size = New System.Drawing.Size(177, 20)
        Me.usr_name_txtbx.TabIndex = 21
        Me.usr_name_txtbx.Tag = "Impo"
        '
        'usr_id_txtbx
        '
        Me.usr_id_txtbx.Location = New System.Drawing.Point(181, 47)
        Me.usr_id_txtbx.Name = "usr_id_txtbx"
        Me.usr_id_txtbx.ReadOnly = True
        Me.usr_id_txtbx.Size = New System.Drawing.Size(121, 20)
        Me.usr_id_txtbx.TabIndex = 21
        Me.usr_id_txtbx.Tag = "Impo"
        '
        'pay_time_lbl
        '
        Me.pay_time_lbl.AutoSize = True
        Me.pay_time_lbl.Location = New System.Drawing.Point(110, 180)
        Me.pay_time_lbl.Name = "pay_time_lbl"
        Me.pay_time_lbl.Size = New System.Drawing.Size(57, 13)
        Me.pay_time_lbl.TabIndex = 18
        Me.pay_time_lbl.Text = "Pay Time :"
        '
        'fee_type_lbl
        '
        Me.fee_type_lbl.AutoSize = True
        Me.fee_type_lbl.Location = New System.Drawing.Point(113, 101)
        Me.fee_type_lbl.Name = "fee_type_lbl"
        Me.fee_type_lbl.Size = New System.Drawing.Size(58, 13)
        Me.fee_type_lbl.TabIndex = 16
        Me.fee_type_lbl.Text = "Fee Type :"
        '
        'com_time_lbl
        '
        Me.com_time_lbl.AutoSize = True
        Me.com_time_lbl.Location = New System.Drawing.Point(94, 152)
        Me.com_time_lbl.Name = "com_time_lbl"
        Me.com_time_lbl.Size = New System.Drawing.Size(73, 13)
        Me.com_time_lbl.TabIndex = 17
        Me.com_time_lbl.Text = "Commit Time :"
        '
        'fee_lbl
        '
        Me.fee_lbl.AutoSize = True
        Me.fee_lbl.Location = New System.Drawing.Point(136, 127)
        Me.fee_lbl.Name = "fee_lbl"
        Me.fee_lbl.Size = New System.Drawing.Size(31, 13)
        Me.fee_lbl.TabIndex = 16
        Me.fee_lbl.Text = "Fee :"
        '
        'payee_id_lbl
        '
        Me.payee_id_lbl.AutoSize = True
        Me.payee_id_lbl.Location = New System.Drawing.Point(114, 75)
        Me.payee_id_lbl.Name = "payee_id_lbl"
        Me.payee_id_lbl.Size = New System.Drawing.Size(57, 13)
        Me.payee_id_lbl.TabIndex = 15
        Me.payee_id_lbl.Text = "Payee ID :"
        '
        'py_id_lbl
        '
        Me.py_id_lbl.AutoSize = True
        Me.py_id_lbl.Location = New System.Drawing.Point(103, 22)
        Me.py_id_lbl.Name = "py_id_lbl"
        Me.py_id_lbl.Size = New System.Drawing.Size(68, 13)
        Me.py_id_lbl.TabIndex = 13
        Me.py_id_lbl.Text = "Payment ID :"
        '
        'usr_id_lbl
        '
        Me.usr_id_lbl.AutoSize = True
        Me.usr_id_lbl.Location = New System.Drawing.Point(119, 50)
        Me.usr_id_lbl.Name = "usr_id_lbl"
        Me.usr_id_lbl.Size = New System.Drawing.Size(52, 13)
        Me.usr_id_lbl.TabIndex = 14
        Me.usr_id_lbl.Text = " User ID :"
        '
        'fees_lstbx
        '
        Me.fees_lstbx.FormattingEnabled = True
        Me.fees_lstbx.Location = New System.Drawing.Point(6, 19)
        Me.fees_lstbx.Name = "fees_lstbx"
        Me.fees_lstbx.Size = New System.Drawing.Size(65, 212)
        Me.fees_lstbx.TabIndex = 12
        '
        'clr_lst_btn
        '
        Me.clr_lst_btn.Location = New System.Drawing.Point(77, 237)
        Me.clr_lst_btn.Name = "clr_lst_btn"
        Me.clr_lst_btn.Size = New System.Drawing.Size(65, 23)
        Me.clr_lst_btn.TabIndex = 11
        Me.clr_lst_btn.Text = "Clear"
        Me.clr_lst_btn.UseVisualStyleBackColor = True
        '
        'pay_btn
        '
        Me.pay_btn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.pay_btn.Location = New System.Drawing.Point(82, 71)
        Me.pay_btn.Name = "pay_btn"
        Me.pay_btn.Size = New System.Drawing.Size(149, 23)
        Me.pay_btn.TabIndex = 11
        Me.pay_btn.Text = "Pay!"
        Me.pay_btn.UseVisualStyleBackColor = True
        '
        'Finance
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(1031, 591)
        Me.Controls.Add(Me.pymnt_inf_grbbx)
        Me.Controls.Add(Me.fee_rcrd_fltr_grbbx)
        Me.Controls.Add(Me.pt_grid)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Finance"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Finance"
        CType(Me.pt_grid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.fee_rcrd_fltr_grbbx.ResumeLayout(False)
        Me.fee_rcrd_fltr_grbbx.PerformLayout()
        Me.fee_inf_grbbx.ResumeLayout(False)
        Me.fee_inf_grbbx.PerformLayout()
        Me.pymnt_inf_grbbx.ResumeLayout(False)
        Me.pymnt_inf_grbbx.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pt_grid As DataGridView
    Friend WithEvents fee_rcrd_fltr_grbbx As GroupBox
    Friend WithEvents srch_txtbx As TextBox
    Friend WithEvents rst_tbl_btn As Button
    Friend WithEvents pt_pno_rbtn As RadioButton
    Friend WithEvents pt_nm_rbtn As RadioButton
    Friend WithEvents pt_cvl_id_rbtn As RadioButton
    Friend WithEvents pt_id_rbtn As RadioButton
    Friend WithEvents status_combbx As ComboBox
    Friend WithEvents fee_inf_grbbx As GroupBox
    Friend WithEvents curncy_combobox As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents pay_count_txtbx As TextBox
    Friend WithEvents total_txtbx As TextBox
    Friend WithEvents exe_py_btn As Button
    Friend WithEvents pymnt_inf_grbbx As GroupBox
    Friend WithEvents pay_status_txtbx As TextBox
    Friend WithEvents pay_status_lbl As Label
    Friend WithEvents rmv_frm_lst_btn As Button
    Friend WithEvents pay_time_txtbx As TextBox
    Friend WithEvents fee_txtbx As TextBox
    Friend WithEvents com_time_txtbx As TextBox
    Friend WithEvents py_id_txtbx As TextBox
    Friend WithEvents payee_id_txtbx As TextBox
    Friend WithEvents usr_id_txtbx As TextBox
    Friend WithEvents pay_time_lbl As Label
    Friend WithEvents com_time_lbl As Label
    Friend WithEvents fee_lbl As Label
    Friend WithEvents payee_id_lbl As Label
    Friend WithEvents py_id_lbl As Label
    Friend WithEvents usr_id_lbl As Label
    Friend WithEvents fees_lstbx As ListBox
    Friend WithEvents fee_type_txtbx As TextBox
    Friend WithEvents fee_type_lbl As Label
    Friend WithEvents payee_name_txtbx As TextBox
    Friend WithEvents usr_name_txtbx As TextBox
    Friend WithEvents clr_lst_btn As Button
    Friend WithEvents pay_btn As Button
End Class
