<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
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
        Dim TreeNode1 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Diagnosis & Appointments")
        Dim TreeNode2 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Doctor", New System.Windows.Forms.TreeNode() {TreeNode1})
        Dim TreeNode3 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Prescription Handling")
        Dim TreeNode4 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Pharmaceuticals")
        Dim TreeNode5 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Pharmacist", New System.Windows.Forms.TreeNode() {TreeNode3, TreeNode4})
        Dim TreeNode6 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Reception Form")
        Dim TreeNode7 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Patient Files Modification")
        Dim TreeNode8 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Patient Registration")
        Dim TreeNode9 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Receptionist", New System.Windows.Forms.TreeNode() {TreeNode6, TreeNode7, TreeNode8})
        Dim TreeNode10 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Queue")
        Dim TreeNode11 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Nurse", New System.Windows.Forms.TreeNode() {TreeNode10})
        Dim TreeNode12 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Finance")
        Dim TreeNode13 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Accountant", New System.Windows.Forms.TreeNode() {TreeNode12})
        Dim TreeNode14 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Staff Files Modification")
        Dim TreeNode15 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Visit Record Modification")
        Dim TreeNode16 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Staff Registration")
        Dim TreeNode17 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Manager", New System.Windows.Forms.TreeNode() {TreeNode14, TreeNode15, TreeNode16})
        Dim TreeNode18 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("View Logs")
        Dim TreeNode19 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Administrators ONLY", New System.Windows.Forms.TreeNode() {TreeNode18})
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
        Me.StatusStrip_LF = New System.Windows.Forms.StatusStrip()
        Me.DB_Conn_SSLbl = New System.Windows.Forms.ToolStripStatusLabel()
        Me.nav_tree = New System.Windows.Forms.TreeView()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.CloseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LogOutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ContactUsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StatusStrip_LF.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'StatusStrip_LF
        '
        Me.StatusStrip_LF.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DB_Conn_SSLbl})
        Me.StatusStrip_LF.Location = New System.Drawing.Point(0, 571)
        Me.StatusStrip_LF.Name = "StatusStrip_LF"
        Me.StatusStrip_LF.Size = New System.Drawing.Size(1027, 22)
        Me.StatusStrip_LF.TabIndex = 7
        Me.StatusStrip_LF.Text = "StatusStrip1"
        '
        'DB_Conn_SSLbl
        '
        Me.DB_Conn_SSLbl.Name = "DB_Conn_SSLbl"
        Me.DB_Conn_SSLbl.Size = New System.Drawing.Size(139, 17)
        Me.DB_Conn_SSLbl.Text = "Server Connection Status"
        '
        'nav_tree
        '
        Me.nav_tree.BackColor = System.Drawing.Color.White
        Me.nav_tree.Dock = System.Windows.Forms.DockStyle.Left
        Me.nav_tree.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nav_tree.ForeColor = System.Drawing.SystemColors.WindowText
        Me.nav_tree.Location = New System.Drawing.Point(0, 24)
        Me.nav_tree.Name = "nav_tree"
        TreeNode1.Name = "diag"
        TreeNode1.Tag = "doct"
        TreeNode1.Text = "Diagnosis & Appointments"
        TreeNode2.Name = "Node0"
        TreeNode2.Tag = "doct"
        TreeNode2.Text = "Doctor"
        TreeNode3.Name = "pres"
        TreeNode3.Tag = "pharm"
        TreeNode3.Text = "Prescription Handling"
        TreeNode4.Name = "phrma"
        TreeNode4.Tag = "pharm"
        TreeNode4.Text = "Pharmaceuticals"
        TreeNode5.Name = "Node1"
        TreeNode5.Tag = "pharm"
        TreeNode5.Text = "Pharmacist"
        TreeNode6.Name = "rec_frm"
        TreeNode6.Tag = "rec"
        TreeNode6.Text = "Reception Form"
        TreeNode7.Name = "pt_modi"
        TreeNode7.Tag = "rec"
        TreeNode7.Text = "Patient Files Modification"
        TreeNode8.Name = "pt_reg"
        TreeNode8.Tag = "rec"
        TreeNode8.Text = "Patient Registration"
        TreeNode9.Name = "Node2"
        TreeNode9.Tag = "rec"
        TreeNode9.Text = "Receptionist"
        TreeNode10.Name = "queue"
        TreeNode10.Tag = "nurse"
        TreeNode10.Text = "Queue"
        TreeNode11.Name = "Node3"
        TreeNode11.Tag = "nurse"
        TreeNode11.Text = "Nurse"
        TreeNode12.Name = "fina"
        TreeNode12.Tag = "acc"
        TreeNode12.Text = "Finance"
        TreeNode13.Name = "Node4"
        TreeNode13.Tag = "acc"
        TreeNode13.Text = "Accountant"
        TreeNode14.Name = "stf_modi"
        TreeNode14.Tag = "mngr"
        TreeNode14.Text = "Staff Files Modification"
        TreeNode15.Name = "vst_modi"
        TreeNode15.Tag = "mngr"
        TreeNode15.Text = "Visit Record Modification"
        TreeNode16.Name = "stf_reg"
        TreeNode16.Tag = "mngr"
        TreeNode16.Text = "Staff Registration"
        TreeNode17.Name = "Node5"
        TreeNode17.Tag = "mngr"
        TreeNode17.Text = "Manager"
        TreeNode18.Name = "logs"
        TreeNode18.Tag = "admn"
        TreeNode18.Text = "View Logs"
        TreeNode19.Name = "Node6"
        TreeNode19.Text = "Administrators ONLY"
        Me.nav_tree.Nodes.AddRange(New System.Windows.Forms.TreeNode() {TreeNode2, TreeNode5, TreeNode9, TreeNode11, TreeNode13, TreeNode17, TreeNode19})
        Me.nav_tree.Size = New System.Drawing.Size(313, 547)
        Me.nav_tree.TabIndex = 8
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CloseToolStripMenuItem, Me.AboutToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1027, 24)
        Me.MenuStrip1.TabIndex = 9
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'CloseToolStripMenuItem
        '
        Me.CloseToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.CloseToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExitToolStripMenuItem, Me.LogOutToolStripMenuItem})
        Me.CloseToolStripMenuItem.Name = "CloseToolStripMenuItem"
        Me.CloseToolStripMenuItem.Size = New System.Drawing.Size(72, 20)
        Me.CloseToolStripMenuItem.Text = "Terminate"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'LogOutToolStripMenuItem
        '
        Me.LogOutToolStripMenuItem.Name = "LogOutToolStripMenuItem"
        Me.LogOutToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.LogOutToolStripMenuItem.Text = "Log Out"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.AboutToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AboutToolStripMenuItem1, Me.ContactUsToolStripMenuItem})
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(52, 20)
        Me.AboutToolStripMenuItem.Text = "About"
        '
        'AboutToolStripMenuItem1
        '
        Me.AboutToolStripMenuItem1.Name = "AboutToolStripMenuItem1"
        Me.AboutToolStripMenuItem1.Size = New System.Drawing.Size(132, 22)
        Me.AboutToolStripMenuItem1.Text = "About"
        '
        'ContactUsToolStripMenuItem
        '
        Me.ContactUsToolStripMenuItem.Name = "ContactUsToolStripMenuItem"
        Me.ContactUsToolStripMenuItem.Size = New System.Drawing.Size(132, 22)
        Me.ContactUsToolStripMenuItem.Text = "Contact Us"
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1027, 593)
        Me.Controls.Add(Me.nav_tree)
        Me.Controls.Add(Me.StatusStrip_LF)
        Me.Controls.Add(Me.MenuStrip1)
        Me.DoubleBuffered = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "MainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "MainForm"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.StatusStrip_LF.ResumeLayout(False)
        Me.StatusStrip_LF.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents StatusStrip_LF As StatusStrip
    Friend WithEvents DB_Conn_SSLbl As ToolStripStatusLabel
    Friend WithEvents nav_tree As TreeView
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents CloseToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LogOutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents ContactUsToolStripMenuItem As ToolStripMenuItem
End Class
