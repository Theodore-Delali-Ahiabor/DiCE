﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class DiCE
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DiCE))
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
        Me.buttonhidetimer = New System.Windows.Forms.Timer(Me.components)
        Me.loginpanel = New System.Windows.Forms.Panel()
        Me.btnsignup = New System.Windows.Forms.Button()
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
        Me.tabadminorderstats = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.adminsearchuserpanel = New System.Windows.Forms.Panel()
        Me.updatepanel = New System.Windows.Forms.Panel()
        Me.chkbupdatemaritalstat = New System.Windows.Forms.CheckBox()
        Me.genderpanel = New System.Windows.Forms.Panel()
        Me.rbtnupdatemale = New System.Windows.Forms.RadioButton()
        Me.rbtnupdatefemale = New System.Windows.Forms.RadioButton()
        Me.maritalstatpanel = New System.Windows.Forms.Panel()
        Me.rbtnupdatesingle = New System.Windows.Forms.RadioButton()
        Me.rbtnupdatemarried = New System.Windows.Forms.RadioButton()
        Me.txtupdategender = New System.Windows.Forms.ComboBox()
        Me.txtupdatemaritalstat = New System.Windows.Forms.ComboBox()
        Me.Label37 = New System.Windows.Forms.Label()
        Me.Label36 = New System.Windows.Forms.Label()
        Me.btnadmindeleteuser = New System.Windows.Forms.Button()
        Me.txtupdatesalary = New System.Windows.Forms.TextBox()
        Me.txtupdateretrieveorupdateid = New System.Windows.Forms.TextBox()
        Me.btneditorupdateor = New System.Windows.Forms.Button()
        Me.chkbupdateactive = New System.Windows.Forms.CheckBox()
        Me.updatedatetimepicker = New System.Windows.Forms.DateTimePicker()
        Me.txtupdatefname = New System.Windows.Forms.TextBox()
        Me.txtupdatelname = New System.Windows.Forms.TextBox()
        Me.txtupdateonames = New System.Windows.Forms.TextBox()
        Me.txtupdateemail = New System.Windows.Forms.TextBox()
        Me.txtupdatepassword = New System.Windows.Forms.TextBox()
        Me.txtupdateusername = New System.Windows.Forms.TextBox()
        Me.txtupdatenumber = New System.Windows.Forms.TextBox()
        Me.txtupdaterole = New System.Windows.Forms.TextBox()
        Me.txtupdateid = New System.Windows.Forms.TextBox()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.numbersearchpanel = New System.Windows.Forms.Panel()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.btnretrieve = New System.Windows.Forms.Button()
        Me.txtretrievenumber = New System.Windows.Forms.TextBox()
        Me.adminuserlogspanel = New System.Windows.Forms.Panel()
        Me.adminorderstatspanel = New System.Windows.Forms.Panel()
        Me.adminadduserpanel = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.rbtnmale = New System.Windows.Forms.RadioButton()
        Me.rbtnfemale = New System.Windows.Forms.RadioButton()
        Me.txtnewmaritalstat = New System.Windows.Forms.Panel()
        Me.chkbmaritalstat = New System.Windows.Forms.CheckBox()
        Me.rbtnsingle = New System.Windows.Forms.RadioButton()
        Me.rbtnmarried = New System.Windows.Forms.RadioButton()
        Me.Label35 = New System.Windows.Forms.Label()
        Me.Label34 = New System.Windows.Forms.Label()
        Me.txtnewsalary = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.cmbusertype = New System.Windows.Forms.ComboBox()
        Me.btnnewusersave = New System.Windows.Forms.Button()
        Me.chkbnewactive = New System.Windows.Forms.CheckBox()
        Me.txtnewDOB = New System.Windows.Forms.DateTimePicker()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtnewemail = New System.Windows.Forms.TextBox()
        Me.txtnewnumber = New System.Windows.Forms.TextBox()
        Me.txtnewrole = New System.Windows.Forms.TextBox()
        Me.txtnewlname = New System.Windows.Forms.TextBox()
        Me.txtnewonames = New System.Windows.Forms.TextBox()
        Me.txtnewfname = New System.Windows.Forms.TextBox()
        Me.tabadminviewuserlogs = New System.Windows.Forms.Button()
        Me.tabadminsearchuser = New System.Windows.Forms.Button()
        Me.tabadminadduser = New System.Windows.Forms.Button()
        Me.waiterpanel = New System.Windows.Forms.Panel()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.FoodsDataGridView = New System.Windows.Forms.DataGridView()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.userspanel = New System.Windows.Forms.Panel()
        Me.btnlogout = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.signuppanel = New System.Windows.Forms.Panel()
        Me.btntologin = New System.Windows.Forms.Button()
        Me.lblsignupemail = New System.Windows.Forms.Label()
        Me.txtsignupemail = New System.Windows.Forms.TextBox()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.txtsignupfname = New System.Windows.Forms.TextBox()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.txtsignuprole = New System.Windows.Forms.TextBox()
        Me.txtsignuplname = New System.Windows.Forms.TextBox()
        Me.Label32 = New System.Windows.Forms.Label()
        Me.btnsignupsave = New System.Windows.Forms.Button()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.txtsignupusername = New System.Windows.Forms.TextBox()
        Me.lblocnfirmpassword = New System.Windows.Forms.Label()
        Me.txtsignupconfirmpassword = New System.Windows.Forms.TextBox()
        Me.btnsignupeligibilityupdate = New System.Windows.Forms.Button()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.txtsignupid = New System.Windows.Forms.TextBox()
        Me.txtsignpassword = New System.Windows.Forms.TextBox()
        Me.txtsignupmobilenumber = New System.Windows.Forms.TextBox()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.lblsignupmobilenumber = New System.Windows.Forms.Label()
        Me.statusbar.SuspendLayout()
        Me.menubar.SuspendLayout()
        Me.loginpanel.SuspendLayout()
        Me.adminpanel.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.adminsearchuserpanel.SuspendLayout()
        Me.updatepanel.SuspendLayout()
        Me.genderpanel.SuspendLayout()
        Me.maritalstatpanel.SuspendLayout()
        Me.numbersearchpanel.SuspendLayout()
        Me.adminadduserpanel.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.txtnewmaritalstat.SuspendLayout()
        Me.waiterpanel.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.FoodsDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.userspanel.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.signuppanel.SuspendLayout()
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
        'buttonhidetimer
        '
        '
        'loginpanel
        '
        Me.loginpanel.BackColor = System.Drawing.Color.Azure
        Me.loginpanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.loginpanel.Controls.Add(Me.btnsignup)
        Me.loginpanel.Controls.Add(Me.Label8)
        Me.loginpanel.Controls.Add(Me.txtid)
        Me.loginpanel.Controls.Add(Me.btnlogin)
        Me.loginpanel.Controls.Add(Me.txtpassword)
        Me.loginpanel.Controls.Add(Me.txtusername)
        Me.loginpanel.Controls.Add(Me.Label2)
        Me.loginpanel.Controls.Add(Me.Label1)
        Me.loginpanel.Location = New System.Drawing.Point(28, 21)
        Me.loginpanel.Name = "loginpanel"
        Me.loginpanel.Size = New System.Drawing.Size(257, 198)
        Me.loginpanel.TabIndex = 1
        '
        'btnsignup
        '
        Me.btnsignup.BackColor = System.Drawing.Color.PaleTurquoise
        Me.btnsignup.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnsignup.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnsignup.FlatAppearance.BorderSize = 0
        Me.btnsignup.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightCyan
        Me.btnsignup.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightCyan
        Me.btnsignup.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnsignup.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnsignup.ForeColor = System.Drawing.Color.LightSeaGreen
        Me.btnsignup.Location = New System.Drawing.Point(554, 449)
        Me.btnsignup.Name = "btnsignup"
        Me.btnsignup.Size = New System.Drawing.Size(111, 47)
        Me.btnsignup.TabIndex = 9
        Me.btnsignup.Text = "SIGN UP"
        Me.btnsignup.UseVisualStyleBackColor = False
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
        Me.txtid.Location = New System.Drawing.Point(680, 468)
        Me.txtid.Name = "txtid"
        Me.txtid.Size = New System.Drawing.Size(10, 20)
        Me.txtid.TabIndex = 7
        Me.txtid.Visible = False
        '
        'btnlogin
        '
        Me.btnlogin.BackColor = System.Drawing.Color.LightGreen
        Me.btnlogin.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnlogin.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnlogin.FlatAppearance.BorderSize = 0
        Me.btnlogin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnlogin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnlogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnlogin.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnlogin.ForeColor = System.Drawing.Color.LightSeaGreen
        Me.btnlogin.Location = New System.Drawing.Point(706, 448)
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
        Me.btnpopup.BackColor = System.Drawing.Color.LightCoral
        Me.btnpopup.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnpopup.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnpopup.FlatAppearance.BorderSize = 0
        Me.btnpopup.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnpopup.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, CType(0, Byte))
        Me.btnpopup.ForeColor = System.Drawing.Color.Linen
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
        Me.managerpanel.Location = New System.Drawing.Point(28, 248)
        Me.managerpanel.Name = "managerpanel"
        Me.managerpanel.Size = New System.Drawing.Size(257, 223)
        Me.managerpanel.TabIndex = 5
        '
        'chefpanel
        '
        Me.chefpanel.BackColor = System.Drawing.Color.Azure
        Me.chefpanel.BackgroundImage = Global.DiCE.My.Resources.Resources.Chef_toon
        Me.chefpanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.chefpanel.Location = New System.Drawing.Point(334, 25)
        Me.chefpanel.Name = "chefpanel"
        Me.chefpanel.Size = New System.Drawing.Size(259, 198)
        Me.chefpanel.TabIndex = 4
        '
        'adminpanel
        '
        Me.adminpanel.BackColor = System.Drawing.Color.Azure
        Me.adminpanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.adminpanel.Controls.Add(Me.tabadminorderstats)
        Me.adminpanel.Controls.Add(Me.Panel2)
        Me.adminpanel.Controls.Add(Me.tabadminviewuserlogs)
        Me.adminpanel.Controls.Add(Me.tabadminsearchuser)
        Me.adminpanel.Controls.Add(Me.tabadminadduser)
        Me.adminpanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.adminpanel.Location = New System.Drawing.Point(0, 0)
        Me.adminpanel.Name = "adminpanel"
        Me.adminpanel.Size = New System.Drawing.Size(1350, 682)
        Me.adminpanel.TabIndex = 3
        '
        'tabadminorderstats
        '
        Me.tabadminorderstats.BackColor = System.Drawing.Color.LightCyan
        Me.tabadminorderstats.Cursor = System.Windows.Forms.Cursors.Hand
        Me.tabadminorderstats.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.tabadminorderstats.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tabadminorderstats.ForeColor = System.Drawing.Color.DodgerBlue
        Me.tabadminorderstats.Location = New System.Drawing.Point(49, 230)
        Me.tabadminorderstats.Name = "tabadminorderstats"
        Me.tabadminorderstats.Size = New System.Drawing.Size(171, 52)
        Me.tabadminorderstats.TabIndex = 7
        Me.tabadminorderstats.Text = "VIEW ORDER STATISTICS"
        Me.tabadminorderstats.UseVisualStyleBackColor = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Transparent
        Me.Panel2.Controls.Add(Me.adminsearchuserpanel)
        Me.Panel2.Controls.Add(Me.adminuserlogspanel)
        Me.Panel2.Controls.Add(Me.adminorderstatspanel)
        Me.Panel2.Controls.Add(Me.adminadduserpanel)
        Me.Panel2.Location = New System.Drawing.Point(259, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1091, 682)
        Me.Panel2.TabIndex = 6
        '
        'adminsearchuserpanel
        '
        Me.adminsearchuserpanel.Controls.Add(Me.updatepanel)
        Me.adminsearchuserpanel.Controls.Add(Me.numbersearchpanel)
        Me.adminsearchuserpanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.adminsearchuserpanel.Location = New System.Drawing.Point(0, 0)
        Me.adminsearchuserpanel.Name = "adminsearchuserpanel"
        Me.adminsearchuserpanel.Size = New System.Drawing.Size(1091, 682)
        Me.adminsearchuserpanel.TabIndex = 0
        '
        'updatepanel
        '
        Me.updatepanel.Controls.Add(Me.chkbupdatemaritalstat)
        Me.updatepanel.Controls.Add(Me.genderpanel)
        Me.updatepanel.Controls.Add(Me.maritalstatpanel)
        Me.updatepanel.Controls.Add(Me.txtupdategender)
        Me.updatepanel.Controls.Add(Me.txtupdatemaritalstat)
        Me.updatepanel.Controls.Add(Me.Label37)
        Me.updatepanel.Controls.Add(Me.Label36)
        Me.updatepanel.Controls.Add(Me.btnadmindeleteuser)
        Me.updatepanel.Controls.Add(Me.txtupdatesalary)
        Me.updatepanel.Controls.Add(Me.txtupdateretrieveorupdateid)
        Me.updatepanel.Controls.Add(Me.btneditorupdateor)
        Me.updatepanel.Controls.Add(Me.chkbupdateactive)
        Me.updatepanel.Controls.Add(Me.updatedatetimepicker)
        Me.updatepanel.Controls.Add(Me.txtupdatefname)
        Me.updatepanel.Controls.Add(Me.txtupdatelname)
        Me.updatepanel.Controls.Add(Me.txtupdateonames)
        Me.updatepanel.Controls.Add(Me.txtupdateemail)
        Me.updatepanel.Controls.Add(Me.txtupdatepassword)
        Me.updatepanel.Controls.Add(Me.txtupdateusername)
        Me.updatepanel.Controls.Add(Me.txtupdatenumber)
        Me.updatepanel.Controls.Add(Me.txtupdaterole)
        Me.updatepanel.Controls.Add(Me.txtupdateid)
        Me.updatepanel.Controls.Add(Me.Label26)
        Me.updatepanel.Controls.Add(Me.Label25)
        Me.updatepanel.Controls.Add(Me.Label24)
        Me.updatepanel.Controls.Add(Me.Label23)
        Me.updatepanel.Controls.Add(Me.Label22)
        Me.updatepanel.Controls.Add(Me.Label21)
        Me.updatepanel.Controls.Add(Me.Label20)
        Me.updatepanel.Controls.Add(Me.Label19)
        Me.updatepanel.Controls.Add(Me.Label18)
        Me.updatepanel.Controls.Add(Me.Label17)
        Me.updatepanel.Controls.Add(Me.Label16)
        Me.updatepanel.Controls.Add(Me.Label15)
        Me.updatepanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.updatepanel.Location = New System.Drawing.Point(0, 0)
        Me.updatepanel.Name = "updatepanel"
        Me.updatepanel.Size = New System.Drawing.Size(1091, 682)
        Me.updatepanel.TabIndex = 32
        '
        'chkbupdatemaritalstat
        '
        Me.chkbupdatemaritalstat.AutoSize = True
        Me.chkbupdatemaritalstat.Location = New System.Drawing.Point(425, 548)
        Me.chkbupdatemaritalstat.Name = "chkbupdatemaritalstat"
        Me.chkbupdatemaritalstat.Size = New System.Drawing.Size(15, 14)
        Me.chkbupdatemaritalstat.TabIndex = 36
        Me.chkbupdatemaritalstat.UseVisualStyleBackColor = True
        Me.chkbupdatemaritalstat.Visible = False
        '
        'genderpanel
        '
        Me.genderpanel.Controls.Add(Me.rbtnupdatemale)
        Me.genderpanel.Controls.Add(Me.rbtnupdatefemale)
        Me.genderpanel.Enabled = False
        Me.genderpanel.Location = New System.Drawing.Point(616, 487)
        Me.genderpanel.Name = "genderpanel"
        Me.genderpanel.Size = New System.Drawing.Size(305, 45)
        Me.genderpanel.TabIndex = 40
        Me.genderpanel.Visible = False
        '
        'rbtnupdatemale
        '
        Me.rbtnupdatemale.AutoSize = True
        Me.rbtnupdatemale.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbtnupdatemale.Location = New System.Drawing.Point(25, 10)
        Me.rbtnupdatemale.Name = "rbtnupdatemale"
        Me.rbtnupdatemale.Size = New System.Drawing.Size(61, 24)
        Me.rbtnupdatemale.TabIndex = 24
        Me.rbtnupdatemale.Text = "Male"
        Me.rbtnupdatemale.UseVisualStyleBackColor = True
        '
        'rbtnupdatefemale
        '
        Me.rbtnupdatefemale.AutoSize = True
        Me.rbtnupdatefemale.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbtnupdatefemale.Location = New System.Drawing.Point(126, 10)
        Me.rbtnupdatefemale.Name = "rbtnupdatefemale"
        Me.rbtnupdatefemale.Size = New System.Drawing.Size(80, 24)
        Me.rbtnupdatefemale.TabIndex = 25
        Me.rbtnupdatefemale.Text = "Female"
        Me.rbtnupdatefemale.UseVisualStyleBackColor = True
        '
        'maritalstatpanel
        '
        Me.maritalstatpanel.Controls.Add(Me.rbtnupdatesingle)
        Me.maritalstatpanel.Controls.Add(Me.rbtnupdatemarried)
        Me.maritalstatpanel.Enabled = False
        Me.maritalstatpanel.Location = New System.Drawing.Point(616, 538)
        Me.maritalstatpanel.Name = "maritalstatpanel"
        Me.maritalstatpanel.Size = New System.Drawing.Size(306, 44)
        Me.maritalstatpanel.TabIndex = 39
        Me.maritalstatpanel.Visible = False
        '
        'rbtnupdatesingle
        '
        Me.rbtnupdatesingle.AutoSize = True
        Me.rbtnupdatesingle.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbtnupdatesingle.Location = New System.Drawing.Point(32, 10)
        Me.rbtnupdatesingle.Name = "rbtnupdatesingle"
        Me.rbtnupdatesingle.Size = New System.Drawing.Size(71, 24)
        Me.rbtnupdatesingle.TabIndex = 34
        Me.rbtnupdatesingle.Text = "Single"
        Me.rbtnupdatesingle.UseVisualStyleBackColor = True
        '
        'rbtnupdatemarried
        '
        Me.rbtnupdatemarried.AutoSize = True
        Me.rbtnupdatemarried.Font = New System.Drawing.Font("Ebrima", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbtnupdatemarried.Location = New System.Drawing.Point(156, 10)
        Me.rbtnupdatemarried.Name = "rbtnupdatemarried"
        Me.rbtnupdatemarried.Size = New System.Drawing.Size(83, 25)
        Me.rbtnupdatemarried.TabIndex = 35
        Me.rbtnupdatemarried.Text = "Married"
        Me.rbtnupdatemarried.UseVisualStyleBackColor = True
        '
        'txtupdategender
        '
        Me.txtupdategender.Enabled = False
        Me.txtupdategender.Font = New System.Drawing.Font("Ebrima", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtupdategender.FormattingEnabled = True
        Me.txtupdategender.Items.AddRange(New Object() {"Male", "Female", "Other"})
        Me.txtupdategender.Location = New System.Drawing.Point(528, 285)
        Me.txtupdategender.Name = "txtupdategender"
        Me.txtupdategender.Size = New System.Drawing.Size(312, 36)
        Me.txtupdategender.TabIndex = 38
        '
        'txtupdatemaritalstat
        '
        Me.txtupdatemaritalstat.Enabled = False
        Me.txtupdatemaritalstat.Font = New System.Drawing.Font("Ebrima", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtupdatemaritalstat.FormattingEnabled = True
        Me.txtupdatemaritalstat.Items.AddRange(New Object() {"Single ", "Married"})
        Me.txtupdatemaritalstat.Location = New System.Drawing.Point(128, 508)
        Me.txtupdatemaritalstat.Name = "txtupdatemaritalstat"
        Me.txtupdatemaritalstat.Size = New System.Drawing.Size(312, 36)
        Me.txtupdatemaritalstat.TabIndex = 37
        '
        'Label37
        '
        Me.Label37.AutoSize = True
        Me.Label37.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label37.Location = New System.Drawing.Point(530, 406)
        Me.Label37.Name = "Label37"
        Me.Label37.Size = New System.Drawing.Size(162, 20)
        Me.Label37.TabIndex = 36
        Me.Label37.Text = "Monthly Salary (GHC)"
        '
        'Label36
        '
        Me.Label36.AutoSize = True
        Me.Label36.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label36.Location = New System.Drawing.Point(128, 479)
        Me.Label36.Name = "Label36"
        Me.Label36.Size = New System.Drawing.Size(107, 20)
        Me.Label36.TabIndex = 35
        Me.Label36.Text = "Marital Status"
        '
        'btnadmindeleteuser
        '
        Me.btnadmindeleteuser.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnadmindeleteuser.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnadmindeleteuser.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnadmindeleteuser.FlatAppearance.BorderSize = 0
        Me.btnadmindeleteuser.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnadmindeleteuser.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnadmindeleteuser.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnadmindeleteuser.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnadmindeleteuser.ForeColor = System.Drawing.Color.Red
        Me.btnadmindeleteuser.Location = New System.Drawing.Point(130, 587)
        Me.btnadmindeleteuser.Name = "btnadmindeleteuser"
        Me.btnadmindeleteuser.Size = New System.Drawing.Size(148, 52)
        Me.btnadmindeleteuser.TabIndex = 34
        Me.btnadmindeleteuser.Text = "DELETE USER"
        Me.btnadmindeleteuser.UseVisualStyleBackColor = False
        '
        'txtupdatesalary
        '
        Me.txtupdatesalary.Enabled = False
        Me.txtupdatesalary.Font = New System.Drawing.Font("Ebrima", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtupdatesalary.Location = New System.Drawing.Point(530, 441)
        Me.txtupdatesalary.Name = "txtupdatesalary"
        Me.txtupdatesalary.Size = New System.Drawing.Size(310, 35)
        Me.txtupdatesalary.TabIndex = 33
        '
        'txtupdateretrieveorupdateid
        '
        Me.txtupdateretrieveorupdateid.Location = New System.Drawing.Point(501, 619)
        Me.txtupdateretrieveorupdateid.Name = "txtupdateretrieveorupdateid"
        Me.txtupdateretrieveorupdateid.Size = New System.Drawing.Size(33, 20)
        Me.txtupdateretrieveorupdateid.TabIndex = 31
        Me.txtupdateretrieveorupdateid.Visible = False
        '
        'btneditorupdateor
        '
        Me.btneditorupdateor.BackColor = System.Drawing.Color.PaleTurquoise
        Me.btneditorupdateor.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btneditorupdateor.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btneditorupdateor.FlatAppearance.BorderSize = 0
        Me.btneditorupdateor.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btneditorupdateor.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btneditorupdateor.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btneditorupdateor.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btneditorupdateor.ForeColor = System.Drawing.Color.DodgerBlue
        Me.btneditorupdateor.Location = New System.Drawing.Point(323, 587)
        Me.btneditorupdateor.Name = "btneditorupdateor"
        Me.btneditorupdateor.Size = New System.Drawing.Size(148, 52)
        Me.btneditorupdateor.TabIndex = 30
        Me.btneditorupdateor.Text = "EDIT INFO."
        Me.btneditorupdateor.UseVisualStyleBackColor = False
        '
        'chkbupdateactive
        '
        Me.chkbupdateactive.AutoSize = True
        Me.chkbupdateactive.Checked = True
        Me.chkbupdateactive.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkbupdateactive.Enabled = False
        Me.chkbupdateactive.Location = New System.Drawing.Point(562, 530)
        Me.chkbupdateactive.Name = "chkbupdateactive"
        Me.chkbupdateactive.Size = New System.Drawing.Size(15, 14)
        Me.chkbupdateactive.TabIndex = 24
        Me.chkbupdateactive.UseVisualStyleBackColor = True
        '
        'updatedatetimepicker
        '
        Me.updatedatetimepicker.Enabled = False
        Me.updatedatetimepicker.Font = New System.Drawing.Font("Ebrima", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.updatedatetimepicker.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.updatedatetimepicker.Location = New System.Drawing.Point(530, 363)
        Me.updatedatetimepicker.Name = "updatedatetimepicker"
        Me.updatedatetimepicker.Size = New System.Drawing.Size(310, 35)
        Me.updatedatetimepicker.TabIndex = 23
        '
        'txtupdatefname
        '
        Me.txtupdatefname.Enabled = False
        Me.txtupdatefname.Font = New System.Drawing.Font("Ebrima", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtupdatefname.Location = New System.Drawing.Point(531, 59)
        Me.txtupdatefname.Name = "txtupdatefname"
        Me.txtupdatefname.Size = New System.Drawing.Size(310, 35)
        Me.txtupdatefname.TabIndex = 13
        '
        'txtupdatelname
        '
        Me.txtupdatelname.Enabled = False
        Me.txtupdatelname.Font = New System.Drawing.Font("Ebrima", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtupdatelname.Location = New System.Drawing.Point(531, 131)
        Me.txtupdatelname.Name = "txtupdatelname"
        Me.txtupdatelname.Size = New System.Drawing.Size(310, 35)
        Me.txtupdatelname.TabIndex = 15
        '
        'txtupdateonames
        '
        Me.txtupdateonames.Enabled = False
        Me.txtupdateonames.Font = New System.Drawing.Font("Ebrima", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtupdateonames.Location = New System.Drawing.Point(531, 215)
        Me.txtupdateonames.Name = "txtupdateonames"
        Me.txtupdateonames.Size = New System.Drawing.Size(310, 35)
        Me.txtupdateonames.TabIndex = 17
        '
        'txtupdateemail
        '
        Me.txtupdateemail.Enabled = False
        Me.txtupdateemail.Font = New System.Drawing.Font("Ebrima", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtupdateemail.Location = New System.Drawing.Point(130, 438)
        Me.txtupdateemail.Name = "txtupdateemail"
        Me.txtupdateemail.Size = New System.Drawing.Size(310, 35)
        Me.txtupdateemail.TabIndex = 22
        '
        'txtupdatepassword
        '
        Me.txtupdatepassword.Enabled = False
        Me.txtupdatepassword.Font = New System.Drawing.Font("Ebrima", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtupdatepassword.Location = New System.Drawing.Point(132, 365)
        Me.txtupdatepassword.Name = "txtupdatepassword"
        Me.txtupdatepassword.Size = New System.Drawing.Size(310, 35)
        Me.txtupdatepassword.TabIndex = 20
        '
        'txtupdateusername
        '
        Me.txtupdateusername.Enabled = False
        Me.txtupdateusername.Font = New System.Drawing.Font("Ebrima", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtupdateusername.Location = New System.Drawing.Point(130, 289)
        Me.txtupdateusername.Name = "txtupdateusername"
        Me.txtupdateusername.Size = New System.Drawing.Size(310, 35)
        Me.txtupdateusername.TabIndex = 18
        '
        'txtupdatenumber
        '
        Me.txtupdatenumber.Enabled = False
        Me.txtupdatenumber.Font = New System.Drawing.Font("Ebrima", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtupdatenumber.Location = New System.Drawing.Point(130, 215)
        Me.txtupdatenumber.Name = "txtupdatenumber"
        Me.txtupdatenumber.Size = New System.Drawing.Size(310, 35)
        Me.txtupdatenumber.TabIndex = 16
        '
        'txtupdaterole
        '
        Me.txtupdaterole.Enabled = False
        Me.txtupdaterole.Font = New System.Drawing.Font("Ebrima", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtupdaterole.Location = New System.Drawing.Point(130, 131)
        Me.txtupdaterole.Name = "txtupdaterole"
        Me.txtupdaterole.Size = New System.Drawing.Size(310, 35)
        Me.txtupdaterole.TabIndex = 14
        '
        'txtupdateid
        '
        Me.txtupdateid.Enabled = False
        Me.txtupdateid.Font = New System.Drawing.Font("Ebrima", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtupdateid.Location = New System.Drawing.Point(130, 59)
        Me.txtupdateid.Name = "txtupdateid"
        Me.txtupdateid.Size = New System.Drawing.Size(310, 35)
        Me.txtupdateid.TabIndex = 12
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.Location = New System.Drawing.Point(530, 487)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(65, 20)
        Me.Label26.TabIndex = 11
        Me.Label26.Text = "Active ?"
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.Location = New System.Drawing.Point(527, 335)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(76, 20)
        Me.Label25.TabIndex = 10
        Me.Label25.Text = "Bith Date"
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.Location = New System.Drawing.Point(526, 262)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(63, 20)
        Me.Label24.TabIndex = 9
        Me.Label24.Text = "Gender"
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.Location = New System.Drawing.Point(530, 177)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(103, 20)
        Me.Label23.TabIndex = 8
        Me.Label23.Text = "Other Names"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.Location = New System.Drawing.Point(526, 104)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(86, 20)
        Me.Label22.TabIndex = 7
        Me.Label22.Text = "Last Name"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.Location = New System.Drawing.Point(527, 36)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(86, 20)
        Me.Label21.TabIndex = 6
        Me.Label21.Text = "First Name"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(128, 413)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(111, 20)
        Me.Label20.TabIndex = 5
        Me.Label20.Text = "Email Address"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(126, 339)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(78, 20)
        Me.Label19.TabIndex = 4
        Me.Label19.Text = "Password"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(128, 262)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(89, 20)
        Me.Label18.TabIndex = 3
        Me.Label18.Text = "User Name"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(126, 177)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(115, 20)
        Me.Label17.TabIndex = 2
        Me.Label17.Text = "Mobile Number"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(131, 104)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(42, 20)
        Me.Label16.TabIndex = 1
        Me.Label16.Text = "Role"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(128, 36)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(26, 20)
        Me.Label15.TabIndex = 0
        Me.Label15.Text = "ID"
        '
        'numbersearchpanel
        '
        Me.numbersearchpanel.Controls.Add(Me.Label14)
        Me.numbersearchpanel.Controls.Add(Me.btnretrieve)
        Me.numbersearchpanel.Controls.Add(Me.txtretrievenumber)
        Me.numbersearchpanel.Location = New System.Drawing.Point(32, 101)
        Me.numbersearchpanel.Name = "numbersearchpanel"
        Me.numbersearchpanel.Size = New System.Drawing.Size(199, 137)
        Me.numbersearchpanel.TabIndex = 31
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(392, 113)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(208, 25)
        Me.Label14.TabIndex = 30
        Me.Label14.Text = "User Mobile Number"
        '
        'btnretrieve
        '
        Me.btnretrieve.BackColor = System.Drawing.Color.PaleGreen
        Me.btnretrieve.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnretrieve.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnretrieve.FlatAppearance.BorderSize = 0
        Me.btnretrieve.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnretrieve.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnretrieve.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnretrieve.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnretrieve.ForeColor = System.Drawing.Color.ForestGreen
        Me.btnretrieve.Location = New System.Drawing.Point(427, 268)
        Me.btnretrieve.Name = "btnretrieve"
        Me.btnretrieve.Size = New System.Drawing.Size(119, 52)
        Me.btnretrieve.TabIndex = 29
        Me.btnretrieve.Text = "RETRIEVE"
        Me.btnretrieve.UseVisualStyleBackColor = False
        '
        'txtretrievenumber
        '
        Me.txtretrievenumber.Font = New System.Drawing.Font("Ebrima", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtretrievenumber.Location = New System.Drawing.Point(339, 184)
        Me.txtretrievenumber.Name = "txtretrievenumber"
        Me.txtretrievenumber.Size = New System.Drawing.Size(305, 35)
        Me.txtretrievenumber.TabIndex = 28
        '
        'adminuserlogspanel
        '
        Me.adminuserlogspanel.Location = New System.Drawing.Point(32, 244)
        Me.adminuserlogspanel.Name = "adminuserlogspanel"
        Me.adminuserlogspanel.Size = New System.Drawing.Size(208, 100)
        Me.adminuserlogspanel.TabIndex = 0
        '
        'adminorderstatspanel
        '
        Me.adminorderstatspanel.Location = New System.Drawing.Point(32, 368)
        Me.adminorderstatspanel.Name = "adminorderstatspanel"
        Me.adminorderstatspanel.Size = New System.Drawing.Size(200, 100)
        Me.adminorderstatspanel.TabIndex = 1
        '
        'adminadduserpanel
        '
        Me.adminadduserpanel.Controls.Add(Me.Panel3)
        Me.adminadduserpanel.Controls.Add(Me.txtnewmaritalstat)
        Me.adminadduserpanel.Controls.Add(Me.Label35)
        Me.adminadduserpanel.Controls.Add(Me.Label34)
        Me.adminadduserpanel.Controls.Add(Me.txtnewsalary)
        Me.adminadduserpanel.Controls.Add(Me.Label13)
        Me.adminadduserpanel.Controls.Add(Me.cmbusertype)
        Me.adminadduserpanel.Controls.Add(Me.btnnewusersave)
        Me.adminadduserpanel.Controls.Add(Me.chkbnewactive)
        Me.adminadduserpanel.Controls.Add(Me.txtnewDOB)
        Me.adminadduserpanel.Controls.Add(Me.Label12)
        Me.adminadduserpanel.Controls.Add(Me.Label11)
        Me.adminadduserpanel.Controls.Add(Me.Label10)
        Me.adminadduserpanel.Controls.Add(Me.Label9)
        Me.adminadduserpanel.Controls.Add(Me.Label7)
        Me.adminadduserpanel.Controls.Add(Me.Label6)
        Me.adminadduserpanel.Controls.Add(Me.Label5)
        Me.adminadduserpanel.Controls.Add(Me.Label4)
        Me.adminadduserpanel.Controls.Add(Me.Label3)
        Me.adminadduserpanel.Controls.Add(Me.txtnewemail)
        Me.adminadduserpanel.Controls.Add(Me.txtnewnumber)
        Me.adminadduserpanel.Controls.Add(Me.txtnewrole)
        Me.adminadduserpanel.Controls.Add(Me.txtnewlname)
        Me.adminadduserpanel.Controls.Add(Me.txtnewonames)
        Me.adminadduserpanel.Controls.Add(Me.txtnewfname)
        Me.adminadduserpanel.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.adminadduserpanel.Location = New System.Drawing.Point(32, 25)
        Me.adminadduserpanel.Name = "adminadduserpanel"
        Me.adminadduserpanel.Size = New System.Drawing.Size(208, 93)
        Me.adminadduserpanel.TabIndex = 0
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.rbtnmale)
        Me.Panel3.Controls.Add(Me.rbtnfemale)
        Me.Panel3.Location = New System.Drawing.Point(103, 469)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(305, 45)
        Me.Panel3.TabIndex = 37
        '
        'rbtnmale
        '
        Me.rbtnmale.AutoSize = True
        Me.rbtnmale.Font = New System.Drawing.Font("Ebrima", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbtnmale.Location = New System.Drawing.Point(25, 10)
        Me.rbtnmale.Name = "rbtnmale"
        Me.rbtnmale.Size = New System.Drawing.Size(62, 25)
        Me.rbtnmale.TabIndex = 24
        Me.rbtnmale.Text = "Male"
        Me.rbtnmale.UseVisualStyleBackColor = True
        '
        'rbtnfemale
        '
        Me.rbtnfemale.AutoSize = True
        Me.rbtnfemale.Font = New System.Drawing.Font("Ebrima", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbtnfemale.Location = New System.Drawing.Point(127, 10)
        Me.rbtnfemale.Name = "rbtnfemale"
        Me.rbtnfemale.Size = New System.Drawing.Size(78, 25)
        Me.rbtnfemale.TabIndex = 25
        Me.rbtnfemale.Text = "Female"
        Me.rbtnfemale.UseVisualStyleBackColor = True
        '
        'txtnewmaritalstat
        '
        Me.txtnewmaritalstat.Controls.Add(Me.chkbmaritalstat)
        Me.txtnewmaritalstat.Controls.Add(Me.rbtnsingle)
        Me.txtnewmaritalstat.Controls.Add(Me.rbtnmarried)
        Me.txtnewmaritalstat.Location = New System.Drawing.Point(530, 297)
        Me.txtnewmaritalstat.Name = "txtnewmaritalstat"
        Me.txtnewmaritalstat.Size = New System.Drawing.Size(306, 44)
        Me.txtnewmaritalstat.TabIndex = 36
        '
        'chkbmaritalstat
        '
        Me.chkbmaritalstat.AutoSize = True
        Me.chkbmaritalstat.Location = New System.Drawing.Point(275, 16)
        Me.chkbmaritalstat.Name = "chkbmaritalstat"
        Me.chkbmaritalstat.Size = New System.Drawing.Size(15, 14)
        Me.chkbmaritalstat.TabIndex = 36
        Me.chkbmaritalstat.UseVisualStyleBackColor = True
        Me.chkbmaritalstat.Visible = False
        '
        'rbtnsingle
        '
        Me.rbtnsingle.AutoSize = True
        Me.rbtnsingle.Font = New System.Drawing.Font("Ebrima", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbtnsingle.Location = New System.Drawing.Point(32, 10)
        Me.rbtnsingle.Name = "rbtnsingle"
        Me.rbtnsingle.Size = New System.Drawing.Size(71, 25)
        Me.rbtnsingle.TabIndex = 34
        Me.rbtnsingle.Text = "Single"
        Me.rbtnsingle.UseVisualStyleBackColor = True
        '
        'rbtnmarried
        '
        Me.rbtnmarried.AutoSize = True
        Me.rbtnmarried.Font = New System.Drawing.Font("Ebrima", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbtnmarried.Location = New System.Drawing.Point(156, 10)
        Me.rbtnmarried.Name = "rbtnmarried"
        Me.rbtnmarried.Size = New System.Drawing.Size(83, 25)
        Me.rbtnmarried.TabIndex = 35
        Me.rbtnmarried.Text = "Married"
        Me.rbtnmarried.UseVisualStyleBackColor = True
        '
        'Label35
        '
        Me.Label35.AutoSize = True
        Me.Label35.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label35.Location = New System.Drawing.Point(526, 351)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(162, 20)
        Me.Label35.TabIndex = 33
        Me.Label35.Text = "Monthly Salary (GHC)"
        '
        'Label34
        '
        Me.Label34.AutoSize = True
        Me.Label34.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label34.Location = New System.Drawing.Point(526, 268)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(107, 20)
        Me.Label34.TabIndex = 32
        Me.Label34.Text = "Marital Status"
        '
        'txtnewsalary
        '
        Me.txtnewsalary.Font = New System.Drawing.Font("Ebrima", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtnewsalary.Location = New System.Drawing.Point(530, 380)
        Me.txtnewsalary.Name = "txtnewsalary"
        Me.txtnewsalary.Size = New System.Drawing.Size(305, 35)
        Me.txtnewsalary.TabIndex = 31
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(526, 190)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(69, 20)
        Me.Label13.TabIndex = 29
        Me.Label13.Text = "Position "
        '
        'cmbusertype
        '
        Me.cmbusertype.Font = New System.Drawing.Font("Ebrima", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbusertype.FormattingEnabled = True
        Me.cmbusertype.Items.AddRange(New Object() {"Waiter/Waitress", "Chef/Cook", "Manager/Supervisor", "Administrator"})
        Me.cmbusertype.Location = New System.Drawing.Point(530, 222)
        Me.cmbusertype.Name = "cmbusertype"
        Me.cmbusertype.Size = New System.Drawing.Size(305, 36)
        Me.cmbusertype.TabIndex = 28
        '
        'btnnewusersave
        '
        Me.btnnewusersave.BackColor = System.Drawing.Color.PaleGreen
        Me.btnnewusersave.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnnewusersave.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnnewusersave.FlatAppearance.BorderSize = 0
        Me.btnnewusersave.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnnewusersave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnnewusersave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnnewusersave.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnnewusersave.ForeColor = System.Drawing.Color.ForestGreen
        Me.btnnewusersave.Location = New System.Drawing.Point(384, 546)
        Me.btnnewusersave.Name = "btnnewusersave"
        Me.btnnewusersave.Size = New System.Drawing.Size(156, 52)
        Me.btnnewusersave.TabIndex = 27
        Me.btnnewusersave.Text = "ADD USER"
        Me.btnnewusersave.UseVisualStyleBackColor = False
        '
        'chkbnewactive
        '
        Me.chkbnewactive.AutoSize = True
        Me.chkbnewactive.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.chkbnewactive.Checked = True
        Me.chkbnewactive.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkbnewactive.Font = New System.Drawing.Font("Ebrima", 8.25!)
        Me.chkbnewactive.Location = New System.Drawing.Point(553, 477)
        Me.chkbnewactive.Name = "chkbnewactive"
        Me.chkbnewactive.Size = New System.Drawing.Size(15, 14)
        Me.chkbnewactive.TabIndex = 26
        Me.chkbnewactive.UseVisualStyleBackColor = True
        '
        'txtnewDOB
        '
        Me.txtnewDOB.CalendarFont = New System.Drawing.Font("Ebrima", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtnewDOB.Font = New System.Drawing.Font("Ebrima", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtnewDOB.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.txtnewDOB.Location = New System.Drawing.Point(530, 141)
        Me.txtnewDOB.Name = "txtnewDOB"
        Me.txtnewDOB.Size = New System.Drawing.Size(304, 35)
        Me.txtnewDOB.TabIndex = 23
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(526, 434)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(65, 20)
        Me.Label12.TabIndex = 22
        Me.Label12.Text = "Active ?"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(526, 116)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(102, 20)
        Me.Label11.TabIndex = 21
        Me.Label11.Text = "Date Of Birth"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(106, 425)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(63, 20)
        Me.Label10.TabIndex = 20
        Me.Label10.Text = "Gender"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(526, 38)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(111, 20)
        Me.Label9.TabIndex = 19
        Me.Label9.Text = "Email Address"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(101, 351)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(165, 20)
        Me.Label7.TabIndex = 18
        Me.Label7.Text = "Mobile Phone Number"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(101, 268)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(42, 20)
        Me.Label6.TabIndex = 17
        Me.Label6.Text = "Role"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(99, 190)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(86, 20)
        Me.Label5.TabIndex = 16
        Me.Label5.Text = "Last Name"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(99, 116)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(113, 20)
        Me.Label4.TabIndex = 15
        Me.Label4.Text = "Other Name(s)"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(99, 36)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(86, 20)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = "First Name"
        '
        'txtnewemail
        '
        Me.txtnewemail.Font = New System.Drawing.Font("Ebrima", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtnewemail.Location = New System.Drawing.Point(530, 67)
        Me.txtnewemail.Name = "txtnewemail"
        Me.txtnewemail.Size = New System.Drawing.Size(305, 35)
        Me.txtnewemail.TabIndex = 10
        '
        'txtnewnumber
        '
        Me.txtnewnumber.Font = New System.Drawing.Font("Ebrima", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtnewnumber.Location = New System.Drawing.Point(105, 380)
        Me.txtnewnumber.Name = "txtnewnumber"
        Me.txtnewnumber.Size = New System.Drawing.Size(305, 35)
        Me.txtnewnumber.TabIndex = 9
        '
        'txtnewrole
        '
        Me.txtnewrole.Font = New System.Drawing.Font("Ebrima", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtnewrole.Location = New System.Drawing.Point(105, 299)
        Me.txtnewrole.Name = "txtnewrole"
        Me.txtnewrole.Size = New System.Drawing.Size(305, 35)
        Me.txtnewrole.TabIndex = 8
        '
        'txtnewlname
        '
        Me.txtnewlname.Font = New System.Drawing.Font("Ebrima", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtnewlname.Location = New System.Drawing.Point(103, 222)
        Me.txtnewlname.Name = "txtnewlname"
        Me.txtnewlname.Size = New System.Drawing.Size(305, 35)
        Me.txtnewlname.TabIndex = 7
        '
        'txtnewonames
        '
        Me.txtnewonames.Font = New System.Drawing.Font("Ebrima", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtnewonames.Location = New System.Drawing.Point(103, 143)
        Me.txtnewonames.Name = "txtnewonames"
        Me.txtnewonames.Size = New System.Drawing.Size(305, 35)
        Me.txtnewonames.TabIndex = 6
        '
        'txtnewfname
        '
        Me.txtnewfname.Font = New System.Drawing.Font("Ebrima", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtnewfname.Location = New System.Drawing.Point(103, 67)
        Me.txtnewfname.Name = "txtnewfname"
        Me.txtnewfname.Size = New System.Drawing.Size(305, 35)
        Me.txtnewfname.TabIndex = 5
        '
        'tabadminviewuserlogs
        '
        Me.tabadminviewuserlogs.BackColor = System.Drawing.Color.LightCyan
        Me.tabadminviewuserlogs.Cursor = System.Windows.Forms.Cursors.Hand
        Me.tabadminviewuserlogs.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.tabadminviewuserlogs.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tabadminviewuserlogs.ForeColor = System.Drawing.Color.DodgerBlue
        Me.tabadminviewuserlogs.Location = New System.Drawing.Point(49, 314)
        Me.tabadminviewuserlogs.Name = "tabadminviewuserlogs"
        Me.tabadminviewuserlogs.Size = New System.Drawing.Size(171, 52)
        Me.tabadminviewuserlogs.TabIndex = 5
        Me.tabadminviewuserlogs.Text = "VIEW USER LOGS"
        Me.tabadminviewuserlogs.UseVisualStyleBackColor = False
        '
        'tabadminsearchuser
        '
        Me.tabadminsearchuser.BackColor = System.Drawing.Color.LightCyan
        Me.tabadminsearchuser.Cursor = System.Windows.Forms.Cursors.Hand
        Me.tabadminsearchuser.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.tabadminsearchuser.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tabadminsearchuser.ForeColor = System.Drawing.Color.DodgerBlue
        Me.tabadminsearchuser.Location = New System.Drawing.Point(49, 148)
        Me.tabadminsearchuser.Name = "tabadminsearchuser"
        Me.tabadminsearchuser.Size = New System.Drawing.Size(171, 52)
        Me.tabadminsearchuser.TabIndex = 3
        Me.tabadminsearchuser.Text = "SEARCH USER"
        Me.tabadminsearchuser.UseVisualStyleBackColor = False
        '
        'tabadminadduser
        '
        Me.tabadminadduser.BackColor = System.Drawing.Color.LightCyan
        Me.tabadminadduser.Cursor = System.Windows.Forms.Cursors.Hand
        Me.tabadminadduser.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.tabadminadduser.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tabadminadduser.ForeColor = System.Drawing.Color.DodgerBlue
        Me.tabadminadduser.Location = New System.Drawing.Point(49, 53)
        Me.tabadminadduser.Name = "tabadminadduser"
        Me.tabadminadduser.Size = New System.Drawing.Size(171, 52)
        Me.tabadminadduser.TabIndex = 2
        Me.tabadminadduser.Text = "ADD NEW USER"
        Me.tabadminadduser.UseVisualStyleBackColor = False
        '
        'waiterpanel
        '
        Me.waiterpanel.Controls.Add(Me.Button8)
        Me.waiterpanel.Controls.Add(Me.Button2)
        Me.waiterpanel.Controls.Add(Me.GroupBox3)
        Me.waiterpanel.Controls.Add(Me.GroupBox1)
        Me.waiterpanel.Controls.Add(Me.GroupBox2)
        Me.waiterpanel.Location = New System.Drawing.Point(28, 25)
        Me.waiterpanel.Name = "waiterpanel"
        Me.waiterpanel.Size = New System.Drawing.Size(257, 185)
        Me.waiterpanel.TabIndex = 2
        '
        'Button8
        '
        Me.Button8.BackColor = System.Drawing.Color.Turquoise
        Me.Button8.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button8.FlatAppearance.BorderSize = 0
        Me.Button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button8.ForeColor = System.Drawing.Color.DodgerBlue
        Me.Button8.Location = New System.Drawing.Point(372, 598)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(134, 52)
        Me.Button8.TabIndex = 2
        Me.Button8.Text = "PRINT ORDER"
        Me.Button8.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage
        Me.Button8.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Turquoise
        Me.Button2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.DodgerBlue
        Me.Button2.Location = New System.Drawing.Point(165, 598)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(128, 52)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "PRINT MENU"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Button6)
        Me.GroupBox3.Controls.Add(Me.Button7)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(937, 36)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(364, 531)
        Me.GroupBox3.TabIndex = 0
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Drinks"
        '
        'Button6
        '
        Me.Button6.BackColor = System.Drawing.Color.LightCyan
        Me.Button6.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button6.ForeColor = System.Drawing.Color.DodgerBlue
        Me.Button6.Location = New System.Drawing.Point(205, 469)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(135, 41)
        Me.Button6.TabIndex = 4
        Me.Button6.Text = "PLACE ORDER"
        Me.Button6.UseVisualStyleBackColor = False
        '
        'Button7
        '
        Me.Button7.BackColor = System.Drawing.Color.LightCyan
        Me.Button7.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button7.ForeColor = System.Drawing.Color.DodgerBlue
        Me.Button7.Location = New System.Drawing.Point(45, 469)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(122, 41)
        Me.Button7.TabIndex = 3
        Me.Button7.Text = "EDIT MENU"
        Me.Button7.UseVisualStyleBackColor = False
        Me.Button7.Visible = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.FoodsDataGridView)
        Me.GroupBox1.Controls.Add(Me.Button3)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(57, 42)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(369, 525)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Foods"
        '
        'FoodsDataGridView
        '
        Me.FoodsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.FoodsDataGridView.Location = New System.Drawing.Point(6, 25)
        Me.FoodsDataGridView.Name = "FoodsDataGridView"
        Me.FoodsDataGridView.Size = New System.Drawing.Size(357, 401)
        Me.FoodsDataGridView.TabIndex = 3
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.LightCyan
        Me.Button3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.ForeColor = System.Drawing.Color.DodgerBlue
        Me.Button3.Location = New System.Drawing.Point(195, 469)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(135, 41)
        Me.Button3.TabIndex = 2
        Me.Button3.Text = "PLACE ORDER"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.LightCyan
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.ForeColor = System.Drawing.Color.DodgerBlue
        Me.Button1.Location = New System.Drawing.Point(35, 469)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(122, 41)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "EDIT MENU"
        Me.Button1.UseVisualStyleBackColor = False
        Me.Button1.Visible = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Button4)
        Me.GroupBox2.Controls.Add(Me.Button5)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(492, 36)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(383, 531)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Pastries And Desserts"
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.LightCyan
        Me.Button4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.ForeColor = System.Drawing.Color.DodgerBlue
        Me.Button4.Location = New System.Drawing.Point(199, 469)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(135, 41)
        Me.Button4.TabIndex = 4
        Me.Button4.Text = "PLACE ORDER"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.Color.LightCyan
        Me.Button5.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button5.ForeColor = System.Drawing.Color.DodgerBlue
        Me.Button5.Location = New System.Drawing.Point(39, 469)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(122, 41)
        Me.Button5.TabIndex = 3
        Me.Button5.Text = "EDIT MENU"
        Me.Button5.UseVisualStyleBackColor = False
        Me.Button5.Visible = False
        '
        'userspanel
        '
        Me.userspanel.BackColor = System.Drawing.Color.Azure
        Me.userspanel.Controls.Add(Me.btnlogout)
        Me.userspanel.Controls.Add(Me.adminpanel)
        Me.userspanel.Controls.Add(Me.waiterpanel)
        Me.userspanel.Controls.Add(Me.managerpanel)
        Me.userspanel.Controls.Add(Me.chefpanel)
        Me.userspanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.userspanel.Location = New System.Drawing.Point(0, 0)
        Me.userspanel.Name = "userspanel"
        Me.userspanel.Size = New System.Drawing.Size(1350, 682)
        Me.userspanel.TabIndex = 2
        Me.userspanel.Visible = False
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
        Me.btnlogout.Location = New System.Drawing.Point(1182, 587)
        Me.btnlogout.Name = "btnlogout"
        Me.btnlogout.Size = New System.Drawing.Size(119, 52)
        Me.btnlogout.TabIndex = 16
        Me.btnlogout.Text = "LOGOUT"
        Me.btnlogout.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.userspanel)
        Me.Panel1.Controls.Add(Me.loginpanel)
        Me.Panel1.Controls.Add(Me.signuppanel)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 24)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1350, 682)
        Me.Panel1.TabIndex = 15
        '
        'signuppanel
        '
        Me.signuppanel.BackColor = System.Drawing.Color.Azure
        Me.signuppanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.signuppanel.Controls.Add(Me.btntologin)
        Me.signuppanel.Controls.Add(Me.lblsignupemail)
        Me.signuppanel.Controls.Add(Me.txtsignupemail)
        Me.signuppanel.Controls.Add(Me.Label30)
        Me.signuppanel.Controls.Add(Me.txtsignupfname)
        Me.signuppanel.Controls.Add(Me.Label31)
        Me.signuppanel.Controls.Add(Me.txtsignuprole)
        Me.signuppanel.Controls.Add(Me.txtsignuplname)
        Me.signuppanel.Controls.Add(Me.Label32)
        Me.signuppanel.Controls.Add(Me.btnsignupsave)
        Me.signuppanel.Controls.Add(Me.Label29)
        Me.signuppanel.Controls.Add(Me.txtsignupusername)
        Me.signuppanel.Controls.Add(Me.lblocnfirmpassword)
        Me.signuppanel.Controls.Add(Me.txtsignupconfirmpassword)
        Me.signuppanel.Controls.Add(Me.btnsignupeligibilityupdate)
        Me.signuppanel.Controls.Add(Me.Label27)
        Me.signuppanel.Controls.Add(Me.txtsignupid)
        Me.signuppanel.Controls.Add(Me.txtsignpassword)
        Me.signuppanel.Controls.Add(Me.txtsignupmobilenumber)
        Me.signuppanel.Controls.Add(Me.Label28)
        Me.signuppanel.Controls.Add(Me.lblsignupmobilenumber)
        Me.signuppanel.Location = New System.Drawing.Point(28, 244)
        Me.signuppanel.Name = "signuppanel"
        Me.signuppanel.Size = New System.Drawing.Size(257, 184)
        Me.signuppanel.TabIndex = 3
        '
        'btntologin
        '
        Me.btntologin.BackColor = System.Drawing.Color.LightCyan
        Me.btntologin.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btntologin.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btntologin.FlatAppearance.BorderSize = 0
        Me.btntologin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightCyan
        Me.btntologin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightCyan
        Me.btntologin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btntologin.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btntologin.ForeColor = System.Drawing.Color.ForestGreen
        Me.btntologin.Location = New System.Drawing.Point(28, 24)
        Me.btntologin.Name = "btntologin"
        Me.btntologin.Size = New System.Drawing.Size(135, 47)
        Me.btntologin.TabIndex = 23
        Me.btntologin.Text = "<<To Login"
        Me.btntologin.UseVisualStyleBackColor = False
        '
        'lblsignupemail
        '
        Me.lblsignupemail.AutoSize = True
        Me.lblsignupemail.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblsignupemail.Location = New System.Drawing.Point(97, 269)
        Me.lblsignupemail.Name = "lblsignupemail"
        Me.lblsignupemail.Size = New System.Drawing.Size(95, 20)
        Me.lblsignupemail.TabIndex = 22
        Me.lblsignupemail.Text = "Enter Email "
        '
        'txtsignupemail
        '
        Me.txtsignupemail.Font = New System.Drawing.Font("Ebrima", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtsignupemail.Location = New System.Drawing.Point(101, 322)
        Me.txtsignupemail.Name = "txtsignupemail"
        Me.txtsignupemail.Size = New System.Drawing.Size(305, 35)
        Me.txtsignupemail.TabIndex = 5
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label30.Location = New System.Drawing.Point(522, 151)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(86, 20)
        Me.Label30.TabIndex = 20
        Me.Label30.Text = "First Name"
        '
        'txtsignupfname
        '
        Me.txtsignupfname.Enabled = False
        Me.txtsignupfname.Font = New System.Drawing.Font("Ebrima", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtsignupfname.Location = New System.Drawing.Point(526, 199)
        Me.txtsignupfname.Name = "txtsignupfname"
        Me.txtsignupfname.Size = New System.Drawing.Size(305, 35)
        Me.txtsignupfname.TabIndex = 7
        '
        'Label31
        '
        Me.Label31.AutoSize = True
        Me.Label31.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label31.Location = New System.Drawing.Point(522, 394)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(42, 20)
        Me.Label31.TabIndex = 18
        Me.Label31.Text = "Role"
        '
        'txtsignuprole
        '
        Me.txtsignuprole.Enabled = False
        Me.txtsignuprole.Font = New System.Drawing.Font("Ebrima", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtsignuprole.Location = New System.Drawing.Point(526, 449)
        Me.txtsignuprole.Name = "txtsignuprole"
        Me.txtsignuprole.Size = New System.Drawing.Size(305, 35)
        Me.txtsignuprole.TabIndex = 9
        '
        'txtsignuplname
        '
        Me.txtsignuplname.Enabled = False
        Me.txtsignuplname.Font = New System.Drawing.Font("Ebrima", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtsignuplname.Location = New System.Drawing.Point(526, 321)
        Me.txtsignuplname.Name = "txtsignuplname"
        Me.txtsignuplname.Size = New System.Drawing.Size(305, 35)
        Me.txtsignuplname.TabIndex = 8
        '
        'Label32
        '
        Me.Label32.AutoSize = True
        Me.Label32.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label32.Location = New System.Drawing.Point(522, 269)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(86, 20)
        Me.Label32.TabIndex = 15
        Me.Label32.Text = "Last Name"
        '
        'btnsignupsave
        '
        Me.btnsignupsave.BackColor = System.Drawing.Color.LightGreen
        Me.btnsignupsave.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnsignupsave.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnsignupsave.FlatAppearance.BorderSize = 0
        Me.btnsignupsave.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightCyan
        Me.btnsignupsave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightCyan
        Me.btnsignupsave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnsignupsave.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnsignupsave.ForeColor = System.Drawing.Color.ForestGreen
        Me.btnsignupsave.Location = New System.Drawing.Point(813, 560)
        Me.btnsignupsave.Name = "btnsignupsave"
        Me.btnsignupsave.Size = New System.Drawing.Size(133, 47)
        Me.btnsignupsave.TabIndex = 13
        Me.btnsignupsave.Text = "SAVE"
        Me.btnsignupsave.UseVisualStyleBackColor = False
        Me.btnsignupsave.Visible = False
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label29.Location = New System.Drawing.Point(930, 151)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(167, 20)
        Me.Label29.TabIndex = 13
        Me.Label29.Text = "Enter New User Name"
        '
        'txtsignupusername
        '
        Me.txtsignupusername.Enabled = False
        Me.txtsignupusername.Font = New System.Drawing.Font("Ebrima", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtsignupusername.Location = New System.Drawing.Point(934, 199)
        Me.txtsignupusername.Name = "txtsignupusername"
        Me.txtsignupusername.Size = New System.Drawing.Size(305, 35)
        Me.txtsignupusername.TabIndex = 10
        '
        'lblocnfirmpassword
        '
        Me.lblocnfirmpassword.AutoSize = True
        Me.lblocnfirmpassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblocnfirmpassword.Location = New System.Drawing.Point(930, 394)
        Me.lblocnfirmpassword.Name = "lblocnfirmpassword"
        Me.lblocnfirmpassword.Size = New System.Drawing.Size(172, 20)
        Me.lblocnfirmpassword.TabIndex = 11
        Me.lblocnfirmpassword.Text = "Confirm New Password"
        '
        'txtsignupconfirmpassword
        '
        Me.txtsignupconfirmpassword.Enabled = False
        Me.txtsignupconfirmpassword.Font = New System.Drawing.Font("Ebrima", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtsignupconfirmpassword.Location = New System.Drawing.Point(934, 449)
        Me.txtsignupconfirmpassword.Name = "txtsignupconfirmpassword"
        Me.txtsignupconfirmpassword.Size = New System.Drawing.Size(305, 35)
        Me.txtsignupconfirmpassword.TabIndex = 12
        Me.txtsignupconfirmpassword.UseSystemPasswordChar = True
        '
        'btnsignupeligibilityupdate
        '
        Me.btnsignupeligibilityupdate.BackColor = System.Drawing.Color.PaleTurquoise
        Me.btnsignupeligibilityupdate.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnsignupeligibilityupdate.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnsignupeligibilityupdate.FlatAppearance.BorderSize = 0
        Me.btnsignupeligibilityupdate.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightCyan
        Me.btnsignupeligibilityupdate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightCyan
        Me.btnsignupeligibilityupdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnsignupeligibilityupdate.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnsignupeligibilityupdate.ForeColor = System.Drawing.Color.LightSeaGreen
        Me.btnsignupeligibilityupdate.Location = New System.Drawing.Point(134, 411)
        Me.btnsignupeligibilityupdate.Name = "btnsignupeligibilityupdate"
        Me.btnsignupeligibilityupdate.Size = New System.Drawing.Size(229, 47)
        Me.btnsignupeligibilityupdate.TabIndex = 6
        Me.btnsignupeligibilityupdate.Text = "CHECK ELIGIBILITY"
        Me.btnsignupeligibilityupdate.UseVisualStyleBackColor = False
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Font = New System.Drawing.Font("Viner Hand ITC", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label27.Location = New System.Drawing.Point(591, 41)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(127, 44)
        Me.Label27.TabIndex = 8
        Me.Label27.Text = "Sign Up"
        '
        'txtsignupid
        '
        Me.txtsignupid.Location = New System.Drawing.Point(461, 461)
        Me.txtsignupid.Name = "txtsignupid"
        Me.txtsignupid.Size = New System.Drawing.Size(10, 20)
        Me.txtsignupid.TabIndex = 7
        Me.txtsignupid.Visible = False
        '
        'txtsignpassword
        '
        Me.txtsignpassword.Enabled = False
        Me.txtsignpassword.Font = New System.Drawing.Font("Ebrima", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtsignpassword.Location = New System.Drawing.Point(934, 321)
        Me.txtsignpassword.Name = "txtsignpassword"
        Me.txtsignpassword.Size = New System.Drawing.Size(305, 35)
        Me.txtsignpassword.TabIndex = 11
        Me.txtsignpassword.UseSystemPasswordChar = True
        '
        'txtsignupmobilenumber
        '
        Me.txtsignupmobilenumber.Font = New System.Drawing.Font("Ebrima", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtsignupmobilenumber.Location = New System.Drawing.Point(101, 199)
        Me.txtsignupmobilenumber.Name = "txtsignupmobilenumber"
        Me.txtsignupmobilenumber.Size = New System.Drawing.Size(305, 35)
        Me.txtsignupmobilenumber.TabIndex = 4
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label28.Location = New System.Drawing.Point(930, 269)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(156, 20)
        Me.Label28.TabIndex = 3
        Me.Label28.Text = "Enter New Password"
        '
        'lblsignupmobilenumber
        '
        Me.lblsignupmobilenumber.AutoSize = True
        Me.lblsignupmobilenumber.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblsignupmobilenumber.Location = New System.Drawing.Point(97, 151)
        Me.lblsignupmobilenumber.Name = "lblsignupmobilenumber"
        Me.lblsignupmobilenumber.Size = New System.Drawing.Size(158, 20)
        Me.lblsignupmobilenumber.TabIndex = 2
        Me.lblsignupmobilenumber.Text = "Enter Mobile Number"
        '
        'DiCE
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.AutoSize = True
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(1350, 731)
        Me.Controls.Add(Me.btnpopup)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.statusbar)
        Me.Controls.Add(Me.menubar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.menubar
        Me.Name = "DiCE"
        Me.RightToLeftLayout = True
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "DiCE Menu Application "
        Me.statusbar.ResumeLayout(False)
        Me.statusbar.PerformLayout()
        Me.menubar.ResumeLayout(False)
        Me.menubar.PerformLayout()
        Me.loginpanel.ResumeLayout(False)
        Me.loginpanel.PerformLayout()
        Me.adminpanel.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.adminsearchuserpanel.ResumeLayout(False)
        Me.updatepanel.ResumeLayout(False)
        Me.updatepanel.PerformLayout()
        Me.genderpanel.ResumeLayout(False)
        Me.genderpanel.PerformLayout()
        Me.maritalstatpanel.ResumeLayout(False)
        Me.maritalstatpanel.PerformLayout()
        Me.numbersearchpanel.ResumeLayout(False)
        Me.numbersearchpanel.PerformLayout()
        Me.adminadduserpanel.ResumeLayout(False)
        Me.adminadduserpanel.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.txtnewmaritalstat.ResumeLayout(False)
        Me.txtnewmaritalstat.PerformLayout()
        Me.waiterpanel.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.FoodsDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.userspanel.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.signuppanel.ResumeLayout(False)
        Me.signuppanel.PerformLayout()
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
    Friend WithEvents adminpanel As System.Windows.Forms.Panel
    Friend WithEvents chefpanel As System.Windows.Forms.Panel
    Friend WithEvents managerpanel As System.Windows.Forms.Panel
    Friend WithEvents btnpopup As System.Windows.Forms.Button
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents buttonhidetimer As System.Windows.Forms.Timer
    Friend WithEvents userspanel As System.Windows.Forms.Panel
    Friend WithEvents btnlogout As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents waiterpanel As System.Windows.Forms.Panel
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents Button7 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents tabadminviewuserlogs As System.Windows.Forms.Button
    Friend WithEvents tabadminsearchuser As System.Windows.Forms.Button
    Friend WithEvents tabadminadduser As System.Windows.Forms.Button
    Friend WithEvents Button8 As System.Windows.Forms.Button
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents adminsearchuserpanel As System.Windows.Forms.Panel
    Friend WithEvents adminuserlogspanel As System.Windows.Forms.Panel
    Friend WithEvents adminadduserpanel As System.Windows.Forms.Panel
    Friend WithEvents chkbnewactive As System.Windows.Forms.CheckBox
    Friend WithEvents rbtnfemale As System.Windows.Forms.RadioButton
    Friend WithEvents rbtnmale As System.Windows.Forms.RadioButton
    Friend WithEvents txtnewDOB As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtnewemail As System.Windows.Forms.TextBox
    Friend WithEvents txtnewnumber As System.Windows.Forms.TextBox
    Friend WithEvents txtnewrole As System.Windows.Forms.TextBox
    Friend WithEvents txtnewlname As System.Windows.Forms.TextBox
    Friend WithEvents txtnewonames As System.Windows.Forms.TextBox
    Friend WithEvents txtnewfname As System.Windows.Forms.TextBox
    Friend WithEvents btnnewusersave As System.Windows.Forms.Button
    Friend WithEvents cmbusertype As System.Windows.Forms.ComboBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents btnsignup As System.Windows.Forms.Button
    Friend WithEvents tabadminorderstats As System.Windows.Forms.Button
    Friend WithEvents adminorderstatspanel As System.Windows.Forms.Panel
    Friend WithEvents numbersearchpanel As System.Windows.Forms.Panel
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents txtretrievenumber As System.Windows.Forms.TextBox
    Friend WithEvents btnretrieve As System.Windows.Forms.Button
    Friend WithEvents signuppanel As Panel
    Friend WithEvents lblocnfirmpassword As Label
    Friend WithEvents txtsignupconfirmpassword As TextBox
    Friend WithEvents btnsignupeligibilityupdate As Button
    Friend WithEvents Label27 As Label
    Friend WithEvents txtsignupid As TextBox
    Friend WithEvents txtsignpassword As TextBox
    Friend WithEvents txtsignupmobilenumber As TextBox
    Friend WithEvents Label28 As Label
    Friend WithEvents lblsignupmobilenumber As Label
    Friend WithEvents btnsignupsave As Button
    Friend WithEvents Label29 As Label
    Friend WithEvents txtsignupusername As TextBox
    Friend WithEvents Label30 As Label
    Friend WithEvents txtsignupfname As TextBox
    Friend WithEvents Label31 As Label
    Friend WithEvents txtsignuprole As TextBox
    Friend WithEvents txtsignuplname As TextBox
    Friend WithEvents Label32 As Label
    Friend WithEvents lblsignupemail As Label
    Friend WithEvents txtsignupemail As TextBox
    Friend WithEvents btntologin As Button
    Friend WithEvents menubar As MenuStrip
    Friend WithEvents FoodsDataGridView As DataGridView
    Friend WithEvents Label35 As Label
    Friend WithEvents Label34 As Label
    Friend WithEvents txtnewsalary As TextBox
    Friend WithEvents updatepanel As Panel
    Friend WithEvents Label37 As Label
    Friend WithEvents Label36 As Label
    Friend WithEvents btnadmindeleteuser As Button
    Friend WithEvents txtupdatesalary As TextBox
    Friend WithEvents txtupdateretrieveorupdateid As TextBox
    Friend WithEvents btneditorupdateor As Button
    Friend WithEvents chkbupdateactive As CheckBox
    Friend WithEvents updatedatetimepicker As DateTimePicker
    Friend WithEvents txtupdatefname As TextBox
    Friend WithEvents txtupdatelname As TextBox
    Friend WithEvents txtupdateonames As TextBox
    Friend WithEvents txtupdateemail As TextBox
    Friend WithEvents txtupdatepassword As TextBox
    Friend WithEvents txtupdateusername As TextBox
    Friend WithEvents txtupdatenumber As TextBox
    Friend WithEvents txtupdaterole As TextBox
    Friend WithEvents txtupdateid As TextBox
    Friend WithEvents Label26 As Label
    Friend WithEvents Label25 As Label
    Friend WithEvents Label24 As Label
    Friend WithEvents Label23 As Label
    Friend WithEvents Label22 As Label
    Friend WithEvents Label21 As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents txtupdategender As ComboBox
    Friend WithEvents txtupdatemaritalstat As ComboBox
    Friend WithEvents rbtnmarried As RadioButton
    Friend WithEvents rbtnsingle As RadioButton
    Friend WithEvents txtnewmaritalstat As Panel
    Friend WithEvents chkbmaritalstat As CheckBox
    Friend WithEvents genderpanel As Panel
    Friend WithEvents rbtnupdatemale As RadioButton
    Friend WithEvents rbtnupdatefemale As RadioButton
    Friend WithEvents maritalstatpanel As Panel
    Friend WithEvents chkbupdatemaritalstat As CheckBox
    Friend WithEvents rbtnupdatesingle As RadioButton
    Friend WithEvents rbtnupdatemarried As RadioButton
    Friend WithEvents Panel3 As Panel
End Class
