<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormDiCE
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormDiCE))
        Me.statusbar = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.lbluser = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel3 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.lblrole = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel5 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.lbldate = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel2 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.lbltime = New System.Windows.Forms.ToolStripStatusLabel()
        Me.menubar = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveAsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PrintToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LogoutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UndoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RedoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CopyToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PasteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HELPToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReportAProblemToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.systemtime = New System.Windows.Forms.Timer(Me.components)
        Me.btnlogout = New System.Windows.Forms.Button()
        Me.buttonhidetimer = New System.Windows.Forms.Timer(Me.components)
        Me.loginpanel = New System.Windows.Forms.Panel()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtid = New System.Windows.Forms.TextBox()
        Me.btnlogin = New System.Windows.Forms.Button()
        Me.txtpassword = New System.Windows.Forms.TextBox()
        Me.txtusername = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnpopup = New System.Windows.Forms.Button()
        Me.managerpanel = New System.Windows.Forms.Panel()
        Me.chefpanel = New System.Windows.Forms.Panel()
        Me.adminpanel = New System.Windows.Forms.Panel()
        Me.waiterpanel = New System.Windows.Forms.Panel()
        Me.statusbar.SuspendLayout()
        Me.menubar.SuspendLayout()
        Me.loginpanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'statusbar
        '
        Me.statusbar.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.statusbar.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.statusbar.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1, Me.lbluser, Me.ToolStripStatusLabel3, Me.lblrole, Me.ToolStripStatusLabel5, Me.lbldate, Me.ToolStripStatusLabel2, Me.lbltime})
        Me.statusbar.Location = New System.Drawing.Point(0, 706)
        Me.statusbar.Name = "statusbar"
        Me.statusbar.Size = New System.Drawing.Size(1350, 25)
        Me.statusbar.TabIndex = 0
        Me.statusbar.Text = "StatusBar"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Bold)
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(87, 20)
        Me.ToolStripStatusLabel1.Text = "User Name"
        '
        'lbluser
        '
        Me.lbluser.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.lbluser.Name = "lbluser"
        Me.lbluser.Size = New System.Drawing.Size(35, 20)
        Me.lbluser.Text = "user"
        '
        'ToolStripStatusLabel3
        '
        Me.ToolStripStatusLabel3.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Bold)
        Me.ToolStripStatusLabel3.Name = "ToolStripStatusLabel3"
        Me.ToolStripStatusLabel3.Size = New System.Drawing.Size(40, 20)
        Me.ToolStripStatusLabel3.Text = "Role"
        '
        'lblrole
        '
        Me.lblrole.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.lblrole.Name = "lblrole"
        Me.lblrole.Size = New System.Drawing.Size(32, 20)
        Me.lblrole.Text = "role"
        '
        'ToolStripStatusLabel5
        '
        Me.ToolStripStatusLabel5.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Bold)
        Me.ToolStripStatusLabel5.Name = "ToolStripStatusLabel5"
        Me.ToolStripStatusLabel5.Size = New System.Drawing.Size(42, 20)
        Me.ToolStripStatusLabel5.Text = "Date"
        '
        'lbldate
        '
        Me.lbldate.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.lbldate.Name = "lbldate"
        Me.lbldate.Size = New System.Drawing.Size(36, 20)
        Me.lbldate.Text = "date"
        '
        'ToolStripStatusLabel2
        '
        Me.ToolStripStatusLabel2.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Bold)
        Me.ToolStripStatusLabel2.Name = "ToolStripStatusLabel2"
        Me.ToolStripStatusLabel2.Size = New System.Drawing.Size(44, 20)
        Me.ToolStripStatusLabel2.Text = "Time"
        '
        'lbltime
        '
        Me.lbltime.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.lbltime.Name = "lbltime"
        Me.lbltime.Size = New System.Drawing.Size(36, 20)
        Me.lbltime.Text = "time"
        '
        'menubar
        '
        Me.menubar.BackColor = System.Drawing.Color.LightCyan
        Me.menubar.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible
        Me.menubar.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.EditToolStripMenuItem, Me.HELPToolStripMenuItem})
        Me.menubar.Location = New System.Drawing.Point(0, 0)
        Me.menubar.Name = "menubar"
        Me.menubar.Size = New System.Drawing.Size(1350, 24)
        Me.menubar.TabIndex = 1
        Me.menubar.Text = "MenuBar"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SaveToolStripMenuItem, Me.SaveAsToolStripMenuItem, Me.PrintToolStripMenuItem, Me.LogoutToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(40, 20)
        Me.FileToolStripMenuItem.Text = "FILE"
        '
        'SaveToolStripMenuItem
        '
        Me.SaveToolStripMenuItem.Name = "SaveToolStripMenuItem"
        Me.SaveToolStripMenuItem.Size = New System.Drawing.Size(114, 22)
        Me.SaveToolStripMenuItem.Text = "Save"
        '
        'SaveAsToolStripMenuItem
        '
        Me.SaveAsToolStripMenuItem.Name = "SaveAsToolStripMenuItem"
        Me.SaveAsToolStripMenuItem.Size = New System.Drawing.Size(114, 22)
        Me.SaveAsToolStripMenuItem.Text = "Save As"
        '
        'PrintToolStripMenuItem
        '
        Me.PrintToolStripMenuItem.Name = "PrintToolStripMenuItem"
        Me.PrintToolStripMenuItem.Size = New System.Drawing.Size(114, 22)
        Me.PrintToolStripMenuItem.Text = "Print"
        '
        'LogoutToolStripMenuItem
        '
        Me.LogoutToolStripMenuItem.Name = "LogoutToolStripMenuItem"
        Me.LogoutToolStripMenuItem.Size = New System.Drawing.Size(114, 22)
        Me.LogoutToolStripMenuItem.Text = "Logout"
        '
        'EditToolStripMenuItem
        '
        Me.EditToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.UndoToolStripMenuItem, Me.RedoToolStripMenuItem, Me.CopyToolStripMenuItem, Me.CutToolStripMenuItem, Me.PasteToolStripMenuItem})
        Me.EditToolStripMenuItem.Name = "EditToolStripMenuItem"
        Me.EditToolStripMenuItem.Size = New System.Drawing.Size(42, 20)
        Me.EditToolStripMenuItem.Text = "EDIT"
        '
        'UndoToolStripMenuItem
        '
        Me.UndoToolStripMenuItem.Name = "UndoToolStripMenuItem"
        Me.UndoToolStripMenuItem.Size = New System.Drawing.Size(105, 22)
        Me.UndoToolStripMenuItem.Text = "Undo"
        '
        'RedoToolStripMenuItem
        '
        Me.RedoToolStripMenuItem.Name = "RedoToolStripMenuItem"
        Me.RedoToolStripMenuItem.Size = New System.Drawing.Size(105, 22)
        Me.RedoToolStripMenuItem.Text = "Redo"
        '
        'CopyToolStripMenuItem
        '
        Me.CopyToolStripMenuItem.Name = "CopyToolStripMenuItem"
        Me.CopyToolStripMenuItem.Size = New System.Drawing.Size(105, 22)
        Me.CopyToolStripMenuItem.Text = "Copy "
        '
        'CutToolStripMenuItem
        '
        Me.CutToolStripMenuItem.Name = "CutToolStripMenuItem"
        Me.CutToolStripMenuItem.Size = New System.Drawing.Size(105, 22)
        Me.CutToolStripMenuItem.Text = "Cut"
        '
        'PasteToolStripMenuItem
        '
        Me.PasteToolStripMenuItem.Name = "PasteToolStripMenuItem"
        Me.PasteToolStripMenuItem.Size = New System.Drawing.Size(105, 22)
        Me.PasteToolStripMenuItem.Text = "Paste"
        '
        'HELPToolStripMenuItem
        '
        Me.HELPToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AboutToolStripMenuItem, Me.ReportAProblemToolStripMenuItem})
        Me.HELPToolStripMenuItem.Name = "HELPToolStripMenuItem"
        Me.HELPToolStripMenuItem.Size = New System.Drawing.Size(47, 20)
        Me.HELPToolStripMenuItem.Text = "HELP"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(157, 22)
        Me.AboutToolStripMenuItem.Text = "About"
        '
        'ReportAProblemToolStripMenuItem
        '
        Me.ReportAProblemToolStripMenuItem.Name = "ReportAProblemToolStripMenuItem"
        Me.ReportAProblemToolStripMenuItem.Size = New System.Drawing.Size(157, 22)
        Me.ReportAProblemToolStripMenuItem.Text = "Report Problem"
        '
        'systemtime
        '
        Me.systemtime.Enabled = True
        '
        'btnlogout
        '
        Me.btnlogout.BackColor = System.Drawing.Color.Turquoise
        Me.btnlogout.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnlogout.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnlogout.FlatAppearance.BorderSize = 0
        Me.btnlogout.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnlogout.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnlogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnlogout.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnlogout.ForeColor = System.Drawing.Color.DodgerBlue
        Me.btnlogout.Location = New System.Drawing.Point(1193, 593)
        Me.btnlogout.Name = "btnlogout"
        Me.btnlogout.Size = New System.Drawing.Size(119, 52)
        Me.btnlogout.TabIndex = 15
        Me.btnlogout.Text = "LOGOUT"
        Me.btnlogout.UseVisualStyleBackColor = False
        Me.btnlogout.Visible = False
        '
        'buttonhidetimer
        '
        '
        'loginpanel
        '
        Me.loginpanel.BackColor = System.Drawing.Color.Azure
        Me.loginpanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.loginpanel.Controls.Add(Me.Label8)
        Me.loginpanel.Controls.Add(Me.txtid)
        Me.loginpanel.Controls.Add(Me.btnlogin)
        Me.loginpanel.Controls.Add(Me.txtpassword)
        Me.loginpanel.Controls.Add(Me.txtusername)
        Me.loginpanel.Controls.Add(Me.Label2)
        Me.loginpanel.Controls.Add(Me.Label1)
        Me.loginpanel.Location = New System.Drawing.Point(15, 27)
        Me.loginpanel.Name = "loginpanel"
        Me.loginpanel.Size = New System.Drawing.Size(68, 160)
        Me.loginpanel.TabIndex = 8
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Viner Hand ITC", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(636, 96)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(96, 44)
        Me.Label8.TabIndex = 8
        Me.Label8.Text = "Login"
        '
        'txtid
        '
        Me.txtid.Location = New System.Drawing.Point(582, 471)
        Me.txtid.Name = "txtid"
        Me.txtid.Size = New System.Drawing.Size(10, 20)
        Me.txtid.TabIndex = 7
        Me.txtid.Visible = False
        '
        'btnlogin
        '
        Me.btnlogin.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnlogin.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnlogin.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnlogin.FlatAppearance.BorderSize = 0
        Me.btnlogin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnlogin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnlogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnlogin.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnlogin.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnlogin.Location = New System.Drawing.Point(631, 444)
        Me.btnlogin.Name = "btnlogin"
        Me.btnlogin.Size = New System.Drawing.Size(111, 47)
        Me.btnlogin.TabIndex = 6
        Me.btnlogin.Text = "LOGIN"
        Me.btnlogin.UseVisualStyleBackColor = False
        '
        'txtpassword
        '
        Me.txtpassword.Font = New System.Drawing.Font("Ebrima", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtpassword.Location = New System.Drawing.Point(536, 341)
        Me.txtpassword.Name = "txtpassword"
        Me.txtpassword.Size = New System.Drawing.Size(305, 35)
        Me.txtpassword.TabIndex = 5
        Me.txtpassword.UseSystemPasswordChar = True
        '
        'txtusername
        '
        Me.txtusername.Font = New System.Drawing.Font("Ebrima", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtusername.Location = New System.Drawing.Point(536, 231)
        Me.txtusername.Name = "txtusername"
        Me.txtusername.Size = New System.Drawing.Size(305, 35)
        Me.txtusername.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(532, 293)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(78, 20)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Password"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(532, 178)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(89, 20)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "User Name"
        '
        'btnpopup
        '
        Me.btnpopup.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnpopup.AutoSize = True
        Me.btnpopup.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnpopup.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnpopup.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnpopup.FlatAppearance.BorderSize = 0
        Me.btnpopup.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnpopup.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, CType(0, Byte))
        Me.btnpopup.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnpopup.Location = New System.Drawing.Point(1100, 45)
        Me.btnpopup.Name = "btnpopup"
        Me.btnpopup.Size = New System.Drawing.Size(238, 50)
        Me.btnpopup.TabIndex = 14
        Me.btnpopup.Text = "popup"
        Me.btnpopup.UseVisualStyleBackColor = False
        Me.btnpopup.Visible = False
        '
        'managerpanel
        '
        Me.managerpanel.BackColor = System.Drawing.Color.Azure
        Me.managerpanel.BackgroundImage = Global.DiCE.My.Resources.Resources.Manager
        Me.managerpanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.managerpanel.Location = New System.Drawing.Point(239, 27)
        Me.managerpanel.Name = "managerpanel"
        Me.managerpanel.Size = New System.Drawing.Size(70, 160)
        Me.managerpanel.TabIndex = 13
        '
        'chefpanel
        '
        Me.chefpanel.BackColor = System.Drawing.Color.Azure
        Me.chefpanel.BackgroundImage = Global.DiCE.My.Resources.Resources.Chef_toon
        Me.chefpanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.chefpanel.Location = New System.Drawing.Point(166, 27)
        Me.chefpanel.Name = "chefpanel"
        Me.chefpanel.Size = New System.Drawing.Size(67, 160)
        Me.chefpanel.TabIndex = 12
        '
        'adminpanel
        '
        Me.adminpanel.BackColor = System.Drawing.Color.Azure
        Me.adminpanel.BackgroundImage = Global.DiCE.My.Resources.Resources.Ghost_Backgound
        Me.adminpanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.adminpanel.Location = New System.Drawing.Point(89, 27)
        Me.adminpanel.Name = "adminpanel"
        Me.adminpanel.Size = New System.Drawing.Size(71, 160)
        Me.adminpanel.TabIndex = 11
        '
        'waiterpanel
        '
        Me.waiterpanel.BackColor = System.Drawing.Color.Azure
        Me.waiterpanel.BackgroundImage = Global.DiCE.My.Resources.Resources.Waiter
        Me.waiterpanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.waiterpanel.Location = New System.Drawing.Point(315, 27)
        Me.waiterpanel.Name = "waiterpanel"
        Me.waiterpanel.Size = New System.Drawing.Size(73, 160)
        Me.waiterpanel.TabIndex = 10
        '
        'FormDiCE
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(1350, 731)
        Me.Controls.Add(Me.btnlogout)
        Me.Controls.Add(Me.btnpopup)
        Me.Controls.Add(Me.managerpanel)
        Me.Controls.Add(Me.chefpanel)
        Me.Controls.Add(Me.adminpanel)
        Me.Controls.Add(Me.waiterpanel)
        Me.Controls.Add(Me.loginpanel)
        Me.Controls.Add(Me.statusbar)
        Me.Controls.Add(Me.menubar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.menubar
        Me.Name = "FormDiCE"
        Me.RightToLeftLayout = True
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "DiCE Menu Application "
        Me.statusbar.ResumeLayout(False)
        Me.statusbar.PerformLayout()
        Me.menubar.ResumeLayout(False)
        Me.menubar.PerformLayout()
        Me.loginpanel.ResumeLayout(False)
        Me.loginpanel.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents statusbar As System.Windows.Forms.StatusStrip
    Friend WithEvents ToolStripStatusLabel1 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents lbluser As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel3 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents lblrole As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel5 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents lbldate As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel2 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents lbltime As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents menubar As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EditToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HELPToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SaveToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SaveAsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PrintToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LogoutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents UndoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RedoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CopyToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PasteToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ReportAProblemToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents systemtime As System.Windows.Forms.Timer
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtusername As System.Windows.Forms.TextBox
    Friend WithEvents txtpassword As System.Windows.Forms.TextBox
    Friend WithEvents btnlogin As System.Windows.Forms.Button
    Friend WithEvents txtid As System.Windows.Forms.TextBox
    Friend WithEvents loginpanel As System.Windows.Forms.Panel
    Friend WithEvents waiterpanel As System.Windows.Forms.Panel
    Friend WithEvents adminpanel As System.Windows.Forms.Panel
    Friend WithEvents chefpanel As System.Windows.Forms.Panel
    Friend WithEvents managerpanel As System.Windows.Forms.Panel
    Friend WithEvents btnpopup As System.Windows.Forms.Button
    Friend WithEvents btnlogout As System.Windows.Forms.Button
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents buttonhidetimer As System.Windows.Forms.Timer

End Class
