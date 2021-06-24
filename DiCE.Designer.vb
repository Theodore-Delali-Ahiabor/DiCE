<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
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
        Me.systemtime = New System.Windows.Forms.Timer(Me.components)
        Me.buttonhidetimer = New System.Windows.Forms.Timer(Me.components)
        Me.loginpanel = New System.Windows.Forms.Panel()
        Me.lblinvalidmessage = New System.Windows.Forms.Label()
        Me.btnsignup = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtid = New System.Windows.Forms.TextBox()
        Me.btnlogin = New System.Windows.Forms.Button()
        Me.txtloginpassword = New System.Windows.Forms.TextBox()
        Me.txtloginusername = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnpopup = New System.Windows.Forms.Button()
        Me.adminpanel = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
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
        Me.adminactive4 = New System.Windows.Forms.Button()
        Me.adminactive3 = New System.Windows.Forms.Button()
        Me.adminactive2 = New System.Windows.Forms.Button()
        Me.adminactive1 = New System.Windows.Forms.Button()
        Me.tabadminorderstats = New System.Windows.Forms.Button()
        Me.tabadminviewuserlogs = New System.Windows.Forms.Button()
        Me.tabadminsearchuser = New System.Windows.Forms.Button()
        Me.tabadminadduser = New System.Windows.Forms.Button()
        Me.btnlogout = New System.Windows.Forms.Button()
        Me.userspanel = New System.Windows.Forms.Panel()
        Me.waiterpanel = New System.Windows.Forms.Panel()
        Me.waiteractive6 = New System.Windows.Forms.Button()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.foodspanel = New System.Windows.Forms.Panel()
        Me.foodtypepanel1 = New System.Windows.Forms.Panel()
        Me.Label40 = New System.Windows.Forms.Label()
        Me.Label38 = New System.Windows.Forms.Label()
        Me.foodsname1 = New System.Windows.Forms.Button()
        Me.foodprice1 = New System.Windows.Forms.Label()
        Me.Label33 = New System.Windows.Forms.Label()
        Me.foodqty1 = New System.Windows.Forms.NumericUpDown()
        Me.foodimg1 = New System.Windows.Forms.Button()
        Me.foodtypepanel12 = New System.Windows.Forms.Panel()
        Me.Label69 = New System.Windows.Forms.Label()
        Me.Label71 = New System.Windows.Forms.Label()
        Me.foodsname12 = New System.Windows.Forms.Button()
        Me.foodprice12 = New System.Windows.Forms.Label()
        Me.Label73 = New System.Windows.Forms.Label()
        Me.foodqty12 = New System.Windows.Forms.NumericUpDown()
        Me.foodimg12 = New System.Windows.Forms.Button()
        Me.foodtypepanel11 = New System.Windows.Forms.Panel()
        Me.Label62 = New System.Windows.Forms.Label()
        Me.Label67 = New System.Windows.Forms.Label()
        Me.foodsname11 = New System.Windows.Forms.Button()
        Me.foodprice11 = New System.Windows.Forms.Label()
        Me.Label70 = New System.Windows.Forms.Label()
        Me.foodqty11 = New System.Windows.Forms.NumericUpDown()
        Me.foodimg11 = New System.Windows.Forms.Button()
        Me.foodtypepanel10 = New System.Windows.Forms.Panel()
        Me.Label65 = New System.Windows.Forms.Label()
        Me.Label66 = New System.Windows.Forms.Label()
        Me.foodsname10 = New System.Windows.Forms.Button()
        Me.foodprice10 = New System.Windows.Forms.Label()
        Me.Label68 = New System.Windows.Forms.Label()
        Me.foodqty10 = New System.Windows.Forms.NumericUpDown()
        Me.foodimg10 = New System.Windows.Forms.Button()
        Me.foodtypepanel9 = New System.Windows.Forms.Panel()
        Me.Label49 = New System.Windows.Forms.Label()
        Me.Label58 = New System.Windows.Forms.Label()
        Me.foodsname9 = New System.Windows.Forms.Button()
        Me.foodprice9 = New System.Windows.Forms.Label()
        Me.Label64 = New System.Windows.Forms.Label()
        Me.foodqty9 = New System.Windows.Forms.NumericUpDown()
        Me.foodimg9 = New System.Windows.Forms.Button()
        Me.foodtypepanel8 = New System.Windows.Forms.Panel()
        Me.Label60 = New System.Windows.Forms.Label()
        Me.Label61 = New System.Windows.Forms.Label()
        Me.foodsname8 = New System.Windows.Forms.Button()
        Me.foodprice8 = New System.Windows.Forms.Label()
        Me.Label63 = New System.Windows.Forms.Label()
        Me.NumericUpDown7 = New System.Windows.Forms.NumericUpDown()
        Me.foodimg8 = New System.Windows.Forms.Button()
        Me.foodtypepanel7 = New System.Windows.Forms.Panel()
        Me.Label56 = New System.Windows.Forms.Label()
        Me.Label57 = New System.Windows.Forms.Label()
        Me.foodsname7 = New System.Windows.Forms.Button()
        Me.foodprice7 = New System.Windows.Forms.Label()
        Me.Label59 = New System.Windows.Forms.Label()
        Me.foodqty7 = New System.Windows.Forms.NumericUpDown()
        Me.foodimg7 = New System.Windows.Forms.Button()
        Me.foodtypepanel6 = New System.Windows.Forms.Panel()
        Me.Label42 = New System.Windows.Forms.Label()
        Me.Label45 = New System.Windows.Forms.Label()
        Me.foodsname6 = New System.Windows.Forms.Button()
        Me.foodprice6 = New System.Windows.Forms.Label()
        Me.Label54 = New System.Windows.Forms.Label()
        Me.foodqty6 = New System.Windows.Forms.NumericUpDown()
        Me.foodimg6 = New System.Windows.Forms.Button()
        Me.foodtypepanel4 = New System.Windows.Forms.Panel()
        Me.Label39 = New System.Windows.Forms.Label()
        Me.Label41 = New System.Windows.Forms.Label()
        Me.foodsname4 = New System.Windows.Forms.Button()
        Me.foodprice4 = New System.Windows.Forms.Label()
        Me.Label51 = New System.Windows.Forms.Label()
        Me.foodqty4 = New System.Windows.Forms.NumericUpDown()
        Me.foodimg4 = New System.Windows.Forms.Button()
        Me.foodtypepanel2 = New System.Windows.Forms.Panel()
        Me.foodimg2 = New System.Windows.Forms.Button()
        Me.foodsname2 = New System.Windows.Forms.Button()
        Me.Label43 = New System.Windows.Forms.Label()
        Me.Label44 = New System.Windows.Forms.Label()
        Me.foodprice2 = New System.Windows.Forms.Label()
        Me.Label46 = New System.Windows.Forms.Label()
        Me.foodqty2 = New System.Windows.Forms.NumericUpDown()
        Me.foodtypepanel5 = New System.Windows.Forms.Panel()
        Me.Label52 = New System.Windows.Forms.Label()
        Me.Label53 = New System.Windows.Forms.Label()
        Me.foodsname5 = New System.Windows.Forms.Button()
        Me.foodprice5 = New System.Windows.Forms.Label()
        Me.Label55 = New System.Windows.Forms.Label()
        Me.foodqty5 = New System.Windows.Forms.NumericUpDown()
        Me.foodimg5 = New System.Windows.Forms.Button()
        Me.foodtypepanel3 = New System.Windows.Forms.Panel()
        Me.Label47 = New System.Windows.Forms.Label()
        Me.Label48 = New System.Windows.Forms.Label()
        Me.foodsname3 = New System.Windows.Forms.Button()
        Me.foodprice3 = New System.Windows.Forms.Label()
        Me.Label50 = New System.Windows.Forms.Label()
        Me.foodqty3 = New System.Windows.Forms.NumericUpDown()
        Me.foodimg3 = New System.Windows.Forms.Button()
        Me.foodsDGV = New System.Windows.Forms.DataGridView()
        Me.drinkspanel = New System.Windows.Forms.Panel()
        Me.tabwaitercancel = New System.Windows.Forms.Button()
        Me.tabwaiterfoods = New System.Windows.Forms.Button()
        Me.waiteractive5 = New System.Windows.Forms.Button()
        Me.waiteractive1 = New System.Windows.Forms.Button()
        Me.tabwaitersummary = New System.Windows.Forms.Button()
        Me.tabwaiterdrinks = New System.Windows.Forms.Button()
        Me.waiteractive4 = New System.Windows.Forms.Button()
        Me.waiteractive2 = New System.Windows.Forms.Button()
        Me.tabwaitdessert = New System.Windows.Forms.Button()
        Me.tabwaiterpastries = New System.Windows.Forms.Button()
        Me.waiteractive3 = New System.Windows.Forms.Button()
        Me.chefpanel = New System.Windows.Forms.Panel()
        Me.managerpanel = New System.Windows.Forms.Panel()
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
        Me.titlebar = New System.Windows.Forms.MenuStrip()
        Me.closeicon = New System.Windows.Forms.Panel()
        Me.invalidlogintimer = New System.Windows.Forms.Timer(Me.components)
        Me.foodtypepanel20 = New System.Windows.Forms.Panel()
        Me.Label72 = New System.Windows.Forms.Label()
        Me.Label74 = New System.Windows.Forms.Label()
        Me.foodsname20 = New System.Windows.Forms.Button()
        Me.foodprice20 = New System.Windows.Forms.Label()
        Me.Label76 = New System.Windows.Forms.Label()
        Me.foodqty20 = New System.Windows.Forms.NumericUpDown()
        Me.foodimg20 = New System.Windows.Forms.Button()
        Me.foodtypepanel19 = New System.Windows.Forms.Panel()
        Me.Label77 = New System.Windows.Forms.Label()
        Me.Label78 = New System.Windows.Forms.Label()
        Me.foodsname19 = New System.Windows.Forms.Button()
        Me.foodprice19 = New System.Windows.Forms.Label()
        Me.Label80 = New System.Windows.Forms.Label()
        Me.foodqty19 = New System.Windows.Forms.NumericUpDown()
        Me.foodimg19 = New System.Windows.Forms.Button()
        Me.foodtypepanel18 = New System.Windows.Forms.Panel()
        Me.Label81 = New System.Windows.Forms.Label()
        Me.Label82 = New System.Windows.Forms.Label()
        Me.foodsname18 = New System.Windows.Forms.Button()
        Me.foodprice18 = New System.Windows.Forms.Label()
        Me.Label84 = New System.Windows.Forms.Label()
        Me.foodqty18 = New System.Windows.Forms.NumericUpDown()
        Me.foodimg18 = New System.Windows.Forms.Button()
        Me.foodtypepanel17 = New System.Windows.Forms.Panel()
        Me.Label85 = New System.Windows.Forms.Label()
        Me.Label86 = New System.Windows.Forms.Label()
        Me.foodsname17 = New System.Windows.Forms.Button()
        Me.foodprice17 = New System.Windows.Forms.Label()
        Me.Label88 = New System.Windows.Forms.Label()
        Me.foodqty17 = New System.Windows.Forms.NumericUpDown()
        Me.foodimg17 = New System.Windows.Forms.Button()
        Me.foodtypepanel16 = New System.Windows.Forms.Panel()
        Me.Label89 = New System.Windows.Forms.Label()
        Me.Label90 = New System.Windows.Forms.Label()
        Me.foodsname16 = New System.Windows.Forms.Button()
        Me.foodprice16 = New System.Windows.Forms.Label()
        Me.Label92 = New System.Windows.Forms.Label()
        Me.foodqty16 = New System.Windows.Forms.NumericUpDown()
        Me.foodimg16 = New System.Windows.Forms.Button()
        Me.foodtypepanel15 = New System.Windows.Forms.Panel()
        Me.Label93 = New System.Windows.Forms.Label()
        Me.Label94 = New System.Windows.Forms.Label()
        Me.foodsname15 = New System.Windows.Forms.Button()
        Me.foodprice15 = New System.Windows.Forms.Label()
        Me.Label96 = New System.Windows.Forms.Label()
        Me.foodqty15 = New System.Windows.Forms.NumericUpDown()
        Me.foodimg15 = New System.Windows.Forms.Button()
        Me.foodtypepanel14 = New System.Windows.Forms.Panel()
        Me.Label97 = New System.Windows.Forms.Label()
        Me.Label98 = New System.Windows.Forms.Label()
        Me.foodsname14 = New System.Windows.Forms.Button()
        Me.foodprice14 = New System.Windows.Forms.Label()
        Me.Label100 = New System.Windows.Forms.Label()
        Me.foodqty14 = New System.Windows.Forms.NumericUpDown()
        Me.foodimg14 = New System.Windows.Forms.Button()
        Me.foodtypepanel13 = New System.Windows.Forms.Panel()
        Me.Label101 = New System.Windows.Forms.Label()
        Me.Label102 = New System.Windows.Forms.Label()
        Me.foodsname13 = New System.Windows.Forms.Button()
        Me.foodprice13 = New System.Windows.Forms.Label()
        Me.Label104 = New System.Windows.Forms.Label()
        Me.foodqty13 = New System.Windows.Forms.NumericUpDown()
        Me.foodimg13 = New System.Windows.Forms.Button()
        Me.statusbar.SuspendLayout()
        Me.loginpanel.SuspendLayout()
        Me.adminpanel.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.adminadduserpanel.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.txtnewmaritalstat.SuspendLayout()
        Me.adminsearchuserpanel.SuspendLayout()
        Me.updatepanel.SuspendLayout()
        Me.genderpanel.SuspendLayout()
        Me.maritalstatpanel.SuspendLayout()
        Me.numbersearchpanel.SuspendLayout()
        Me.userspanel.SuspendLayout()
        Me.waiterpanel.SuspendLayout()
        Me.Panel6.SuspendLayout()
        Me.foodspanel.SuspendLayout()
        Me.foodtypepanel1.SuspendLayout()
        CType(Me.foodqty1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.foodtypepanel12.SuspendLayout()
        CType(Me.foodqty12, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.foodtypepanel11.SuspendLayout()
        CType(Me.foodqty11, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.foodtypepanel10.SuspendLayout()
        CType(Me.foodqty10, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.foodtypepanel9.SuspendLayout()
        CType(Me.foodqty9, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.foodtypepanel8.SuspendLayout()
        CType(Me.NumericUpDown7, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.foodtypepanel7.SuspendLayout()
        CType(Me.foodqty7, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.foodtypepanel6.SuspendLayout()
        CType(Me.foodqty6, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.foodtypepanel4.SuspendLayout()
        CType(Me.foodqty4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.foodtypepanel2.SuspendLayout()
        CType(Me.foodqty2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.foodtypepanel5.SuspendLayout()
        CType(Me.foodqty5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.foodtypepanel3.SuspendLayout()
        CType(Me.foodqty3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.foodsDGV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.signuppanel.SuspendLayout()
        Me.foodtypepanel20.SuspendLayout()
        CType(Me.foodqty20, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.foodtypepanel19.SuspendLayout()
        CType(Me.foodqty19, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.foodtypepanel18.SuspendLayout()
        CType(Me.foodqty18, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.foodtypepanel17.SuspendLayout()
        CType(Me.foodqty17, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.foodtypepanel16.SuspendLayout()
        CType(Me.foodqty16, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.foodtypepanel15.SuspendLayout()
        CType(Me.foodqty15, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.foodtypepanel14.SuspendLayout()
        CType(Me.foodqty14, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.foodtypepanel13.SuspendLayout()
        CType(Me.foodqty13, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'statusbar
        '
        Me.statusbar.BackColor = System.Drawing.Color.PaleTurquoise
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
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(41, 20)
        Me.ToolStripStatusLabel1.Text = "User"
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
        Me.loginpanel.Controls.Add(Me.lblinvalidmessage)
        Me.loginpanel.Controls.Add(Me.btnsignup)
        Me.loginpanel.Controls.Add(Me.Label8)
        Me.loginpanel.Controls.Add(Me.txtid)
        Me.loginpanel.Controls.Add(Me.btnlogin)
        Me.loginpanel.Controls.Add(Me.txtloginpassword)
        Me.loginpanel.Controls.Add(Me.txtloginusername)
        Me.loginpanel.Controls.Add(Me.Label2)
        Me.loginpanel.Controls.Add(Me.Label1)
        Me.loginpanel.Location = New System.Drawing.Point(28, 21)
        Me.loginpanel.Name = "loginpanel"
        Me.loginpanel.Size = New System.Drawing.Size(257, 198)
        Me.loginpanel.TabIndex = 1
        '
        'lblinvalidmessage
        '
        Me.lblinvalidmessage.AutoSize = True
        Me.lblinvalidmessage.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblinvalidmessage.Font = New System.Drawing.Font("Ebrima", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblinvalidmessage.ForeColor = System.Drawing.Color.Red
        Me.lblinvalidmessage.Location = New System.Drawing.Point(578, 412)
        Me.lblinvalidmessage.Name = "lblinvalidmessage"
        Me.lblinvalidmessage.Size = New System.Drawing.Size(82, 25)
        Me.lblinvalidmessage.TabIndex = 10
        Me.lblinvalidmessage.Text = "INVALID"
        Me.lblinvalidmessage.Visible = False
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
        'txtloginpassword
        '
        Me.txtloginpassword.Font = New System.Drawing.Font("Ebrima", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtloginpassword.Location = New System.Drawing.Point(536, 341)
        Me.txtloginpassword.Name = "txtloginpassword"
        Me.txtloginpassword.Size = New System.Drawing.Size(305, 35)
        Me.txtloginpassword.TabIndex = 5
        Me.txtloginpassword.UseSystemPasswordChar = True
        '
        'txtloginusername
        '
        Me.txtloginusername.Font = New System.Drawing.Font("Ebrima", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtloginusername.Location = New System.Drawing.Point(536, 231)
        Me.txtloginusername.Name = "txtloginusername"
        Me.txtloginusername.Size = New System.Drawing.Size(305, 35)
        Me.txtloginusername.TabIndex = 4
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
        Me.btnpopup.Location = New System.Drawing.Point(1103, 45)
        Me.btnpopup.Name = "btnpopup"
        Me.btnpopup.Size = New System.Drawing.Size(238, 50)
        Me.btnpopup.TabIndex = 14
        Me.btnpopup.Text = "popup"
        Me.btnpopup.UseVisualStyleBackColor = False
        Me.btnpopup.Visible = False
        '
        'adminpanel
        '
        Me.adminpanel.BackColor = System.Drawing.Color.Azure
        Me.adminpanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.adminpanel.Controls.Add(Me.Panel2)
        Me.adminpanel.Controls.Add(Me.adminactive4)
        Me.adminpanel.Controls.Add(Me.adminactive3)
        Me.adminpanel.Controls.Add(Me.adminactive2)
        Me.adminpanel.Controls.Add(Me.adminactive1)
        Me.adminpanel.Controls.Add(Me.tabadminorderstats)
        Me.adminpanel.Controls.Add(Me.tabadminviewuserlogs)
        Me.adminpanel.Controls.Add(Me.tabadminsearchuser)
        Me.adminpanel.Controls.Add(Me.tabadminadduser)
        Me.adminpanel.Location = New System.Drawing.Point(564, 260)
        Me.adminpanel.Name = "adminpanel"
        Me.adminpanel.Size = New System.Drawing.Size(181, 153)
        Me.adminpanel.TabIndex = 3
        Me.adminpanel.Tag = ""
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Transparent
        Me.Panel2.Controls.Add(Me.adminuserlogspanel)
        Me.Panel2.Controls.Add(Me.adminorderstatspanel)
        Me.Panel2.Controls.Add(Me.adminadduserpanel)
        Me.Panel2.Controls.Add(Me.adminsearchuserpanel)
        Me.Panel2.Location = New System.Drawing.Point(226, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1124, 682)
        Me.Panel2.TabIndex = 6
        '
        'adminuserlogspanel
        '
        Me.adminuserlogspanel.Location = New System.Drawing.Point(32, 270)
        Me.adminuserlogspanel.Name = "adminuserlogspanel"
        Me.adminuserlogspanel.Size = New System.Drawing.Size(208, 74)
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
        Me.adminadduserpanel.Location = New System.Drawing.Point(32, 32)
        Me.adminadduserpanel.Name = "adminadduserpanel"
        Me.adminadduserpanel.Size = New System.Drawing.Size(208, 95)
        Me.adminadduserpanel.TabIndex = 0
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.rbtnmale)
        Me.Panel3.Controls.Add(Me.rbtnfemale)
        Me.Panel3.Location = New System.Drawing.Point(115, 485)
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
        Me.txtnewmaritalstat.Location = New System.Drawing.Point(542, 313)
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
        Me.Label35.Location = New System.Drawing.Point(538, 367)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(162, 20)
        Me.Label35.TabIndex = 33
        Me.Label35.Text = "Monthly Salary (GHC)"
        '
        'Label34
        '
        Me.Label34.AutoSize = True
        Me.Label34.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label34.Location = New System.Drawing.Point(538, 284)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(107, 20)
        Me.Label34.TabIndex = 32
        Me.Label34.Text = "Marital Status"
        '
        'txtnewsalary
        '
        Me.txtnewsalary.Font = New System.Drawing.Font("Ebrima", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtnewsalary.Location = New System.Drawing.Point(542, 396)
        Me.txtnewsalary.Name = "txtnewsalary"
        Me.txtnewsalary.Size = New System.Drawing.Size(305, 35)
        Me.txtnewsalary.TabIndex = 31
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(538, 206)
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
        Me.cmbusertype.Location = New System.Drawing.Point(542, 238)
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
        Me.btnnewusersave.Location = New System.Drawing.Point(401, 580)
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
        Me.chkbnewactive.Location = New System.Drawing.Point(565, 493)
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
        Me.txtnewDOB.Location = New System.Drawing.Point(542, 157)
        Me.txtnewDOB.Name = "txtnewDOB"
        Me.txtnewDOB.Size = New System.Drawing.Size(304, 35)
        Me.txtnewDOB.TabIndex = 23
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(538, 450)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(65, 20)
        Me.Label12.TabIndex = 22
        Me.Label12.Text = "Active ?"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(538, 132)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(102, 20)
        Me.Label11.TabIndex = 21
        Me.Label11.Text = "Date Of Birth"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(118, 441)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(63, 20)
        Me.Label10.TabIndex = 20
        Me.Label10.Text = "Gender"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(538, 54)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(111, 20)
        Me.Label9.TabIndex = 19
        Me.Label9.Text = "Email Address"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(113, 367)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(165, 20)
        Me.Label7.TabIndex = 18
        Me.Label7.Text = "Mobile Phone Number"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(113, 284)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(42, 20)
        Me.Label6.TabIndex = 17
        Me.Label6.Text = "Role"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(111, 206)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(86, 20)
        Me.Label5.TabIndex = 16
        Me.Label5.Text = "Last Name"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(111, 132)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(113, 20)
        Me.Label4.TabIndex = 15
        Me.Label4.Text = "Other Name(s)"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(111, 52)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(86, 20)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = "First Name"
        '
        'txtnewemail
        '
        Me.txtnewemail.Font = New System.Drawing.Font("Ebrima", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtnewemail.Location = New System.Drawing.Point(542, 83)
        Me.txtnewemail.Name = "txtnewemail"
        Me.txtnewemail.Size = New System.Drawing.Size(305, 35)
        Me.txtnewemail.TabIndex = 10
        '
        'txtnewnumber
        '
        Me.txtnewnumber.Font = New System.Drawing.Font("Ebrima", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtnewnumber.Location = New System.Drawing.Point(117, 396)
        Me.txtnewnumber.Name = "txtnewnumber"
        Me.txtnewnumber.Size = New System.Drawing.Size(305, 35)
        Me.txtnewnumber.TabIndex = 9
        '
        'txtnewrole
        '
        Me.txtnewrole.Font = New System.Drawing.Font("Ebrima", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtnewrole.Location = New System.Drawing.Point(117, 315)
        Me.txtnewrole.Name = "txtnewrole"
        Me.txtnewrole.Size = New System.Drawing.Size(305, 35)
        Me.txtnewrole.TabIndex = 8
        '
        'txtnewlname
        '
        Me.txtnewlname.Font = New System.Drawing.Font("Ebrima", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtnewlname.Location = New System.Drawing.Point(115, 238)
        Me.txtnewlname.Name = "txtnewlname"
        Me.txtnewlname.Size = New System.Drawing.Size(305, 35)
        Me.txtnewlname.TabIndex = 7
        '
        'txtnewonames
        '
        Me.txtnewonames.Font = New System.Drawing.Font("Ebrima", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtnewonames.Location = New System.Drawing.Point(115, 159)
        Me.txtnewonames.Name = "txtnewonames"
        Me.txtnewonames.Size = New System.Drawing.Size(305, 35)
        Me.txtnewonames.TabIndex = 6
        '
        'txtnewfname
        '
        Me.txtnewfname.Font = New System.Drawing.Font("Ebrima", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtnewfname.Location = New System.Drawing.Point(115, 83)
        Me.txtnewfname.Name = "txtnewfname"
        Me.txtnewfname.Size = New System.Drawing.Size(305, 35)
        Me.txtnewfname.TabIndex = 5
        '
        'adminsearchuserpanel
        '
        Me.adminsearchuserpanel.Controls.Add(Me.updatepanel)
        Me.adminsearchuserpanel.Controls.Add(Me.numbersearchpanel)
        Me.adminsearchuserpanel.Location = New System.Drawing.Point(31, 140)
        Me.adminsearchuserpanel.Name = "adminsearchuserpanel"
        Me.adminsearchuserpanel.Size = New System.Drawing.Size(209, 86)
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
        Me.updatepanel.Location = New System.Drawing.Point(253, 101)
        Me.updatepanel.Name = "updatepanel"
        Me.updatepanel.Size = New System.Drawing.Size(206, 137)
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
        'adminactive4
        '
        Me.adminactive4.BackColor = System.Drawing.Color.LightSeaGreen
        Me.adminactive4.Enabled = False
        Me.adminactive4.FlatAppearance.BorderSize = 0
        Me.adminactive4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.adminactive4.Location = New System.Drawing.Point(12, 298)
        Me.adminactive4.Name = "adminactive4"
        Me.adminactive4.Size = New System.Drawing.Size(10, 52)
        Me.adminactive4.TabIndex = 11
        Me.adminactive4.Text = "Button8"
        Me.adminactive4.UseVisualStyleBackColor = False
        '
        'adminactive3
        '
        Me.adminactive3.BackColor = System.Drawing.Color.LightSeaGreen
        Me.adminactive3.Enabled = False
        Me.adminactive3.FlatAppearance.BorderSize = 0
        Me.adminactive3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.adminactive3.Location = New System.Drawing.Point(12, 215)
        Me.adminactive3.Name = "adminactive3"
        Me.adminactive3.Size = New System.Drawing.Size(10, 52)
        Me.adminactive3.TabIndex = 10
        Me.adminactive3.Text = "Button8"
        Me.adminactive3.UseVisualStyleBackColor = False
        '
        'adminactive2
        '
        Me.adminactive2.BackColor = System.Drawing.Color.LightSeaGreen
        Me.adminactive2.Enabled = False
        Me.adminactive2.FlatAppearance.BorderSize = 0
        Me.adminactive2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.adminactive2.Location = New System.Drawing.Point(12, 134)
        Me.adminactive2.Name = "adminactive2"
        Me.adminactive2.Size = New System.Drawing.Size(10, 52)
        Me.adminactive2.TabIndex = 9
        Me.adminactive2.Text = "Button8"
        Me.adminactive2.UseVisualStyleBackColor = False
        '
        'adminactive1
        '
        Me.adminactive1.BackColor = System.Drawing.Color.LightSeaGreen
        Me.adminactive1.Enabled = False
        Me.adminactive1.FlatAppearance.BorderSize = 0
        Me.adminactive1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.adminactive1.Location = New System.Drawing.Point(12, 52)
        Me.adminactive1.Name = "adminactive1"
        Me.adminactive1.Size = New System.Drawing.Size(10, 52)
        Me.adminactive1.TabIndex = 8
        Me.adminactive1.Text = "Button8"
        Me.adminactive1.UseVisualStyleBackColor = False
        '
        'tabadminorderstats
        '
        Me.tabadminorderstats.BackColor = System.Drawing.Color.LightCyan
        Me.tabadminorderstats.Cursor = System.Windows.Forms.Cursors.Hand
        Me.tabadminorderstats.FlatAppearance.BorderSize = 0
        Me.tabadminorderstats.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PaleTurquoise
        Me.tabadminorderstats.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.tabadminorderstats.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tabadminorderstats.ForeColor = System.Drawing.Color.LightSeaGreen
        Me.tabadminorderstats.Location = New System.Drawing.Point(12, 215)
        Me.tabadminorderstats.Name = "tabadminorderstats"
        Me.tabadminorderstats.Size = New System.Drawing.Size(208, 52)
        Me.tabadminorderstats.TabIndex = 7
        Me.tabadminorderstats.Text = "ORDER STATISTICS"
        Me.tabadminorderstats.UseVisualStyleBackColor = False
        '
        'tabadminviewuserlogs
        '
        Me.tabadminviewuserlogs.BackColor = System.Drawing.Color.LightCyan
        Me.tabadminviewuserlogs.Cursor = System.Windows.Forms.Cursors.Hand
        Me.tabadminviewuserlogs.FlatAppearance.BorderSize = 0
        Me.tabadminviewuserlogs.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PaleTurquoise
        Me.tabadminviewuserlogs.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.tabadminviewuserlogs.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tabadminviewuserlogs.ForeColor = System.Drawing.Color.LightSeaGreen
        Me.tabadminviewuserlogs.Location = New System.Drawing.Point(12, 298)
        Me.tabadminviewuserlogs.Name = "tabadminviewuserlogs"
        Me.tabadminviewuserlogs.Size = New System.Drawing.Size(208, 52)
        Me.tabadminviewuserlogs.TabIndex = 5
        Me.tabadminviewuserlogs.Text = "USER LOGS"
        Me.tabadminviewuserlogs.UseVisualStyleBackColor = False
        '
        'tabadminsearchuser
        '
        Me.tabadminsearchuser.BackColor = System.Drawing.Color.LightCyan
        Me.tabadminsearchuser.Cursor = System.Windows.Forms.Cursors.Hand
        Me.tabadminsearchuser.FlatAppearance.BorderSize = 0
        Me.tabadminsearchuser.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PaleTurquoise
        Me.tabadminsearchuser.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.tabadminsearchuser.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tabadminsearchuser.ForeColor = System.Drawing.Color.LightSeaGreen
        Me.tabadminsearchuser.Location = New System.Drawing.Point(12, 133)
        Me.tabadminsearchuser.Name = "tabadminsearchuser"
        Me.tabadminsearchuser.Size = New System.Drawing.Size(208, 52)
        Me.tabadminsearchuser.TabIndex = 3
        Me.tabadminsearchuser.Text = "SEARCH USER"
        Me.tabadminsearchuser.UseVisualStyleBackColor = False
        '
        'tabadminadduser
        '
        Me.tabadminadduser.BackColor = System.Drawing.Color.LightCyan
        Me.tabadminadduser.Cursor = System.Windows.Forms.Cursors.Hand
        Me.tabadminadduser.FlatAppearance.BorderSize = 0
        Me.tabadminadduser.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PaleTurquoise
        Me.tabadminadduser.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.tabadminadduser.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tabadminadduser.ForeColor = System.Drawing.Color.LightSeaGreen
        Me.tabadminadduser.Location = New System.Drawing.Point(22, 52)
        Me.tabadminadduser.Name = "tabadminadduser"
        Me.tabadminadduser.Size = New System.Drawing.Size(198, 52)
        Me.tabadminadduser.TabIndex = 2
        Me.tabadminadduser.Text = "ADD NEW USER"
        Me.tabadminadduser.UseVisualStyleBackColor = False
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
        Me.btnlogout.Location = New System.Drawing.Point(56, 595)
        Me.btnlogout.Name = "btnlogout"
        Me.btnlogout.Size = New System.Drawing.Size(119, 52)
        Me.btnlogout.TabIndex = 16
        Me.btnlogout.Text = "LOGOUT"
        Me.btnlogout.UseVisualStyleBackColor = False
        '
        'userspanel
        '
        Me.userspanel.BackColor = System.Drawing.Color.Azure
        Me.userspanel.Controls.Add(Me.btnlogout)
        Me.userspanel.Controls.Add(Me.adminpanel)
        Me.userspanel.Controls.Add(Me.chefpanel)
        Me.userspanel.Controls.Add(Me.managerpanel)
        Me.userspanel.Controls.Add(Me.waiterpanel)
        Me.userspanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.userspanel.Location = New System.Drawing.Point(0, 0)
        Me.userspanel.Name = "userspanel"
        Me.userspanel.Size = New System.Drawing.Size(1350, 682)
        Me.userspanel.TabIndex = 2
        Me.userspanel.Visible = False
        '
        'waiterpanel
        '
        Me.waiterpanel.BackColor = System.Drawing.Color.Azure
        Me.waiterpanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.waiterpanel.Controls.Add(Me.waiteractive6)
        Me.waiterpanel.Controls.Add(Me.Panel6)
        Me.waiterpanel.Controls.Add(Me.tabwaitercancel)
        Me.waiterpanel.Controls.Add(Me.tabwaiterfoods)
        Me.waiterpanel.Controls.Add(Me.waiteractive5)
        Me.waiterpanel.Controls.Add(Me.waiteractive1)
        Me.waiterpanel.Controls.Add(Me.tabwaitersummary)
        Me.waiterpanel.Controls.Add(Me.tabwaiterdrinks)
        Me.waiterpanel.Controls.Add(Me.waiteractive4)
        Me.waiterpanel.Controls.Add(Me.waiteractive2)
        Me.waiterpanel.Controls.Add(Me.tabwaitdessert)
        Me.waiterpanel.Controls.Add(Me.tabwaiterpastries)
        Me.waiterpanel.Controls.Add(Me.waiteractive3)
        Me.waiterpanel.Location = New System.Drawing.Point(349, 260)
        Me.waiterpanel.Name = "waiterpanel"
        Me.waiterpanel.Size = New System.Drawing.Size(166, 211)
        Me.waiterpanel.TabIndex = 17
        '
        'waiteractive6
        '
        Me.waiteractive6.BackColor = System.Drawing.Color.LightSeaGreen
        Me.waiteractive6.Enabled = False
        Me.waiteractive6.FlatAppearance.BorderSize = 0
        Me.waiteractive6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.waiteractive6.Location = New System.Drawing.Point(12, 418)
        Me.waiteractive6.Name = "waiteractive6"
        Me.waiteractive6.Size = New System.Drawing.Size(10, 52)
        Me.waiteractive6.TabIndex = 32
        Me.waiteractive6.Text = "Button8"
        Me.waiteractive6.UseVisualStyleBackColor = False
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.Color.Transparent
        Me.Panel6.Controls.Add(Me.foodspanel)
        Me.Panel6.Controls.Add(Me.drinkspanel)
        Me.Panel6.Location = New System.Drawing.Point(226, 0)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(1124, 682)
        Me.Panel6.TabIndex = 6
        '
        'foodspanel
        '
        Me.foodspanel.AutoScroll = True
        Me.foodspanel.Controls.Add(Me.foodtypepanel20)
        Me.foodspanel.Controls.Add(Me.foodtypepanel19)
        Me.foodspanel.Controls.Add(Me.foodtypepanel18)
        Me.foodspanel.Controls.Add(Me.foodtypepanel17)
        Me.foodspanel.Controls.Add(Me.foodtypepanel16)
        Me.foodspanel.Controls.Add(Me.foodtypepanel15)
        Me.foodspanel.Controls.Add(Me.foodtypepanel14)
        Me.foodspanel.Controls.Add(Me.foodtypepanel13)
        Me.foodspanel.Controls.Add(Me.foodtypepanel1)
        Me.foodspanel.Controls.Add(Me.foodtypepanel12)
        Me.foodspanel.Controls.Add(Me.foodtypepanel11)
        Me.foodspanel.Controls.Add(Me.foodtypepanel10)
        Me.foodspanel.Controls.Add(Me.foodtypepanel9)
        Me.foodspanel.Controls.Add(Me.foodtypepanel8)
        Me.foodspanel.Controls.Add(Me.foodtypepanel7)
        Me.foodspanel.Controls.Add(Me.foodtypepanel6)
        Me.foodspanel.Controls.Add(Me.foodtypepanel4)
        Me.foodspanel.Controls.Add(Me.foodtypepanel2)
        Me.foodspanel.Controls.Add(Me.foodtypepanel5)
        Me.foodspanel.Controls.Add(Me.foodtypepanel3)
        Me.foodspanel.Controls.Add(Me.foodsDGV)
        Me.foodspanel.Location = New System.Drawing.Point(28, 28)
        Me.foodspanel.Name = "foodspanel"
        Me.foodspanel.Size = New System.Drawing.Size(198, 92)
        Me.foodspanel.TabIndex = 0
        Me.foodspanel.Visible = False
        '
        'foodtypepanel1
        '
        Me.foodtypepanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.foodtypepanel1.Controls.Add(Me.Label40)
        Me.foodtypepanel1.Controls.Add(Me.Label38)
        Me.foodtypepanel1.Controls.Add(Me.foodsname1)
        Me.foodtypepanel1.Controls.Add(Me.foodprice1)
        Me.foodtypepanel1.Controls.Add(Me.Label33)
        Me.foodtypepanel1.Controls.Add(Me.foodqty1)
        Me.foodtypepanel1.Controls.Add(Me.foodimg1)
        Me.foodtypepanel1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.foodtypepanel1.Location = New System.Drawing.Point(58, 32)
        Me.foodtypepanel1.Name = "foodtypepanel1"
        Me.foodtypepanel1.Size = New System.Drawing.Size(207, 226)
        Me.foodtypepanel1.TabIndex = 7
        '
        'Label40
        '
        Me.Label40.AutoSize = True
        Me.Label40.BackColor = System.Drawing.Color.Transparent
        Me.Label40.Font = New System.Drawing.Font("Ebrima", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label40.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Label40.Location = New System.Drawing.Point(128, 168)
        Me.Label40.Name = "Label40"
        Me.Label40.Size = New System.Drawing.Size(66, 19)
        Me.Label40.TabIndex = 30
        Me.Label40.Text = "Quantity"
        '
        'Label38
        '
        Me.Label38.AutoSize = True
        Me.Label38.BackColor = System.Drawing.Color.Transparent
        Me.Label38.Font = New System.Drawing.Font("Ebrima", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label38.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Label38.Location = New System.Drawing.Point(21, 170)
        Me.Label38.Name = "Label38"
        Me.Label38.Size = New System.Drawing.Size(74, 19)
        Me.Label38.TabIndex = 29
        Me.Label38.Text = "Unit Price"
        '
        'foodsname1
        '
        Me.foodsname1.BackColor = System.Drawing.Color.Transparent
        Me.foodsname1.FlatAppearance.BorderSize = 0
        Me.foodsname1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.foodsname1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.foodsname1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.foodsname1.Font = New System.Drawing.Font("Ebrima", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.foodsname1.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.foodsname1.Location = New System.Drawing.Point(0, 3)
        Me.foodsname1.Name = "foodsname1"
        Me.foodsname1.Size = New System.Drawing.Size(202, 33)
        Me.foodsname1.TabIndex = 28
        Me.foodsname1.Text = "Name"
        Me.foodsname1.UseVisualStyleBackColor = False
        '
        'foodprice1
        '
        Me.foodprice1.AutoSize = True
        Me.foodprice1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.foodprice1.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.foodprice1.Location = New System.Drawing.Point(51, 192)
        Me.foodprice1.Name = "foodprice1"
        Me.foodprice1.Size = New System.Drawing.Size(49, 20)
        Me.foodprice1.TabIndex = 27
        Me.foodprice1.Text = "00.00"
        '
        'Label33
        '
        Me.Label33.AutoSize = True
        Me.Label33.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label33.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Label33.Location = New System.Drawing.Point(11, 192)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(49, 20)
        Me.Label33.TabIndex = 26
        Me.Label33.Text = "GHC "
        '
        'foodqty1
        '
        Me.foodqty1.BackColor = System.Drawing.Color.LightCyan
        Me.foodqty1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.foodqty1.Font = New System.Drawing.Font("Ebrima", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.foodqty1.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.foodqty1.Location = New System.Drawing.Point(132, 190)
        Me.foodqty1.Name = "foodqty1"
        Me.foodqty1.Size = New System.Drawing.Size(51, 31)
        Me.foodqty1.TabIndex = 25
        Me.foodqty1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.foodqty1.ThousandsSeparator = True
        '
        'foodimg1
        '
        Me.foodimg1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.foodimg1.FlatAppearance.BorderSize = 0
        Me.foodimg1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.foodimg1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.foodimg1.Location = New System.Drawing.Point(15, 42)
        Me.foodimg1.Name = "foodimg1"
        Me.foodimg1.Size = New System.Drawing.Size(176, 117)
        Me.foodimg1.TabIndex = 24
        Me.foodimg1.UseVisualStyleBackColor = True
        '
        'foodtypepanel12
        '
        Me.foodtypepanel12.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.foodtypepanel12.Controls.Add(Me.Label69)
        Me.foodtypepanel12.Controls.Add(Me.Label71)
        Me.foodtypepanel12.Controls.Add(Me.foodsname12)
        Me.foodtypepanel12.Controls.Add(Me.foodprice12)
        Me.foodtypepanel12.Controls.Add(Me.Label73)
        Me.foodtypepanel12.Controls.Add(Me.foodqty12)
        Me.foodtypepanel12.Controls.Add(Me.foodimg12)
        Me.foodtypepanel12.Cursor = System.Windows.Forms.Cursors.Hand
        Me.foodtypepanel12.Location = New System.Drawing.Point(874, 603)
        Me.foodtypepanel12.Name = "foodtypepanel12"
        Me.foodtypepanel12.Size = New System.Drawing.Size(207, 226)
        Me.foodtypepanel12.TabIndex = 15
        Me.foodtypepanel12.Visible = False
        '
        'Label69
        '
        Me.Label69.AutoSize = True
        Me.Label69.Font = New System.Drawing.Font("Ebrima", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label69.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Label69.Location = New System.Drawing.Point(127, 166)
        Me.Label69.Name = "Label69"
        Me.Label69.Size = New System.Drawing.Size(66, 19)
        Me.Label69.TabIndex = 7
        Me.Label69.Text = "Quantity"
        '
        'Label71
        '
        Me.Label71.AutoSize = True
        Me.Label71.Font = New System.Drawing.Font("Ebrima", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label71.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Label71.Location = New System.Drawing.Point(20, 168)
        Me.Label71.Name = "Label71"
        Me.Label71.Size = New System.Drawing.Size(74, 19)
        Me.Label71.TabIndex = 6
        Me.Label71.Text = "Unit Price"
        '
        'foodsname12
        '
        Me.foodsname12.BackColor = System.Drawing.Color.Azure
        Me.foodsname12.FlatAppearance.BorderSize = 0
        Me.foodsname12.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent
        Me.foodsname12.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.foodsname12.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.foodsname12.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.foodsname12.Font = New System.Drawing.Font("Ebrima", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.foodsname12.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.foodsname12.Location = New System.Drawing.Point(-2, -1)
        Me.foodsname12.Name = "foodsname12"
        Me.foodsname12.Size = New System.Drawing.Size(208, 36)
        Me.foodsname12.TabIndex = 5
        Me.foodsname12.Text = "Name"
        Me.foodsname12.UseVisualStyleBackColor = False
        '
        'foodprice12
        '
        Me.foodprice12.AutoSize = True
        Me.foodprice12.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.foodprice12.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.foodprice12.Location = New System.Drawing.Point(50, 193)
        Me.foodprice12.Name = "foodprice12"
        Me.foodprice12.Size = New System.Drawing.Size(49, 20)
        Me.foodprice12.TabIndex = 4
        Me.foodprice12.Text = "00.00"
        Me.foodprice12.Visible = False
        '
        'Label73
        '
        Me.Label73.AutoSize = True
        Me.Label73.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label73.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Label73.Location = New System.Drawing.Point(10, 193)
        Me.Label73.Name = "Label73"
        Me.Label73.Size = New System.Drawing.Size(49, 20)
        Me.Label73.TabIndex = 3
        Me.Label73.Text = "GHC "
        '
        'foodqty12
        '
        Me.foodqty12.BackColor = System.Drawing.Color.LightCyan
        Me.foodqty12.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.foodqty12.Font = New System.Drawing.Font("Ebrima", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.foodqty12.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.foodqty12.Location = New System.Drawing.Point(131, 188)
        Me.foodqty12.Name = "foodqty12"
        Me.foodqty12.Size = New System.Drawing.Size(51, 31)
        Me.foodqty12.TabIndex = 1
        Me.foodqty12.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.foodqty12.ThousandsSeparator = True
        '
        'foodimg12
        '
        Me.foodimg12.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.foodimg12.FlatAppearance.BorderSize = 0
        Me.foodimg12.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.foodimg12.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.foodimg12.Location = New System.Drawing.Point(14, 35)
        Me.foodimg12.Name = "foodimg12"
        Me.foodimg12.Size = New System.Drawing.Size(176, 123)
        Me.foodimg12.TabIndex = 0
        Me.foodimg12.UseVisualStyleBackColor = True
        '
        'foodtypepanel11
        '
        Me.foodtypepanel11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.foodtypepanel11.Controls.Add(Me.Label62)
        Me.foodtypepanel11.Controls.Add(Me.Label67)
        Me.foodtypepanel11.Controls.Add(Me.foodsname11)
        Me.foodtypepanel11.Controls.Add(Me.foodprice11)
        Me.foodtypepanel11.Controls.Add(Me.Label70)
        Me.foodtypepanel11.Controls.Add(Me.foodqty11)
        Me.foodtypepanel11.Controls.Add(Me.foodimg11)
        Me.foodtypepanel11.Cursor = System.Windows.Forms.Cursors.Hand
        Me.foodtypepanel11.Location = New System.Drawing.Point(598, 603)
        Me.foodtypepanel11.Name = "foodtypepanel11"
        Me.foodtypepanel11.Size = New System.Drawing.Size(207, 226)
        Me.foodtypepanel11.TabIndex = 14
        Me.foodtypepanel11.Visible = False
        '
        'Label62
        '
        Me.Label62.AutoSize = True
        Me.Label62.Font = New System.Drawing.Font("Ebrima", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label62.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Label62.Location = New System.Drawing.Point(127, 166)
        Me.Label62.Name = "Label62"
        Me.Label62.Size = New System.Drawing.Size(66, 19)
        Me.Label62.TabIndex = 7
        Me.Label62.Text = "Quantity"
        '
        'Label67
        '
        Me.Label67.AutoSize = True
        Me.Label67.Font = New System.Drawing.Font("Ebrima", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label67.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Label67.Location = New System.Drawing.Point(20, 168)
        Me.Label67.Name = "Label67"
        Me.Label67.Size = New System.Drawing.Size(74, 19)
        Me.Label67.TabIndex = 6
        Me.Label67.Text = "Unit Price"
        '
        'foodsname11
        '
        Me.foodsname11.BackColor = System.Drawing.Color.Azure
        Me.foodsname11.FlatAppearance.BorderSize = 0
        Me.foodsname11.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent
        Me.foodsname11.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.foodsname11.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.foodsname11.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.foodsname11.Font = New System.Drawing.Font("Ebrima", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.foodsname11.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.foodsname11.Location = New System.Drawing.Point(-2, -1)
        Me.foodsname11.Name = "foodsname11"
        Me.foodsname11.Size = New System.Drawing.Size(208, 36)
        Me.foodsname11.TabIndex = 5
        Me.foodsname11.Text = "Name"
        Me.foodsname11.UseVisualStyleBackColor = False
        '
        'foodprice11
        '
        Me.foodprice11.AutoSize = True
        Me.foodprice11.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.foodprice11.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.foodprice11.Location = New System.Drawing.Point(50, 193)
        Me.foodprice11.Name = "foodprice11"
        Me.foodprice11.Size = New System.Drawing.Size(49, 20)
        Me.foodprice11.TabIndex = 4
        Me.foodprice11.Text = "00.00"
        Me.foodprice11.Visible = False
        '
        'Label70
        '
        Me.Label70.AutoSize = True
        Me.Label70.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label70.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Label70.Location = New System.Drawing.Point(10, 193)
        Me.Label70.Name = "Label70"
        Me.Label70.Size = New System.Drawing.Size(49, 20)
        Me.Label70.TabIndex = 3
        Me.Label70.Text = "GHC "
        '
        'foodqty11
        '
        Me.foodqty11.BackColor = System.Drawing.Color.LightCyan
        Me.foodqty11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.foodqty11.Font = New System.Drawing.Font("Ebrima", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.foodqty11.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.foodqty11.Location = New System.Drawing.Point(131, 188)
        Me.foodqty11.Name = "foodqty11"
        Me.foodqty11.Size = New System.Drawing.Size(51, 31)
        Me.foodqty11.TabIndex = 1
        Me.foodqty11.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.foodqty11.ThousandsSeparator = True
        '
        'foodimg11
        '
        Me.foodimg11.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.foodimg11.FlatAppearance.BorderSize = 0
        Me.foodimg11.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.foodimg11.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.foodimg11.Location = New System.Drawing.Point(14, 35)
        Me.foodimg11.Name = "foodimg11"
        Me.foodimg11.Size = New System.Drawing.Size(176, 123)
        Me.foodimg11.TabIndex = 0
        Me.foodimg11.UseVisualStyleBackColor = True
        '
        'foodtypepanel10
        '
        Me.foodtypepanel10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.foodtypepanel10.Controls.Add(Me.Label65)
        Me.foodtypepanel10.Controls.Add(Me.Label66)
        Me.foodtypepanel10.Controls.Add(Me.foodsname10)
        Me.foodtypepanel10.Controls.Add(Me.foodprice10)
        Me.foodtypepanel10.Controls.Add(Me.Label68)
        Me.foodtypepanel10.Controls.Add(Me.foodqty10)
        Me.foodtypepanel10.Controls.Add(Me.foodimg10)
        Me.foodtypepanel10.Cursor = System.Windows.Forms.Cursors.Hand
        Me.foodtypepanel10.Location = New System.Drawing.Point(326, 603)
        Me.foodtypepanel10.Name = "foodtypepanel10"
        Me.foodtypepanel10.Size = New System.Drawing.Size(207, 226)
        Me.foodtypepanel10.TabIndex = 13
        Me.foodtypepanel10.Visible = False
        '
        'Label65
        '
        Me.Label65.AutoSize = True
        Me.Label65.Font = New System.Drawing.Font("Ebrima", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label65.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Label65.Location = New System.Drawing.Point(127, 166)
        Me.Label65.Name = "Label65"
        Me.Label65.Size = New System.Drawing.Size(66, 19)
        Me.Label65.TabIndex = 7
        Me.Label65.Text = "Quantity"
        '
        'Label66
        '
        Me.Label66.AutoSize = True
        Me.Label66.Font = New System.Drawing.Font("Ebrima", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label66.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Label66.Location = New System.Drawing.Point(20, 168)
        Me.Label66.Name = "Label66"
        Me.Label66.Size = New System.Drawing.Size(74, 19)
        Me.Label66.TabIndex = 6
        Me.Label66.Text = "Unit Price"
        '
        'foodsname10
        '
        Me.foodsname10.BackColor = System.Drawing.Color.Azure
        Me.foodsname10.FlatAppearance.BorderSize = 0
        Me.foodsname10.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent
        Me.foodsname10.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.foodsname10.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.foodsname10.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.foodsname10.Font = New System.Drawing.Font("Ebrima", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.foodsname10.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.foodsname10.Location = New System.Drawing.Point(-2, -1)
        Me.foodsname10.Name = "foodsname10"
        Me.foodsname10.Size = New System.Drawing.Size(208, 36)
        Me.foodsname10.TabIndex = 5
        Me.foodsname10.Text = "Name"
        Me.foodsname10.UseVisualStyleBackColor = False
        '
        'foodprice10
        '
        Me.foodprice10.AutoSize = True
        Me.foodprice10.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.foodprice10.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.foodprice10.Location = New System.Drawing.Point(50, 193)
        Me.foodprice10.Name = "foodprice10"
        Me.foodprice10.Size = New System.Drawing.Size(49, 20)
        Me.foodprice10.TabIndex = 4
        Me.foodprice10.Text = "00.00"
        '
        'Label68
        '
        Me.Label68.AutoSize = True
        Me.Label68.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label68.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Label68.Location = New System.Drawing.Point(10, 193)
        Me.Label68.Name = "Label68"
        Me.Label68.Size = New System.Drawing.Size(49, 20)
        Me.Label68.TabIndex = 3
        Me.Label68.Text = "GHC "
        '
        'foodqty10
        '
        Me.foodqty10.BackColor = System.Drawing.Color.LightCyan
        Me.foodqty10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.foodqty10.Font = New System.Drawing.Font("Ebrima", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.foodqty10.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.foodqty10.Location = New System.Drawing.Point(131, 188)
        Me.foodqty10.Name = "foodqty10"
        Me.foodqty10.Size = New System.Drawing.Size(51, 31)
        Me.foodqty10.TabIndex = 1
        Me.foodqty10.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.foodqty10.ThousandsSeparator = True
        '
        'foodimg10
        '
        Me.foodimg10.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.foodimg10.FlatAppearance.BorderSize = 0
        Me.foodimg10.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.foodimg10.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.foodimg10.Location = New System.Drawing.Point(14, 35)
        Me.foodimg10.Name = "foodimg10"
        Me.foodimg10.Size = New System.Drawing.Size(176, 123)
        Me.foodimg10.TabIndex = 0
        Me.foodimg10.UseVisualStyleBackColor = True
        '
        'foodtypepanel9
        '
        Me.foodtypepanel9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.foodtypepanel9.Controls.Add(Me.Label49)
        Me.foodtypepanel9.Controls.Add(Me.Label58)
        Me.foodtypepanel9.Controls.Add(Me.foodsname9)
        Me.foodtypepanel9.Controls.Add(Me.foodprice9)
        Me.foodtypepanel9.Controls.Add(Me.Label64)
        Me.foodtypepanel9.Controls.Add(Me.foodqty9)
        Me.foodtypepanel9.Controls.Add(Me.foodimg9)
        Me.foodtypepanel9.Cursor = System.Windows.Forms.Cursors.Hand
        Me.foodtypepanel9.Location = New System.Drawing.Point(58, 603)
        Me.foodtypepanel9.Name = "foodtypepanel9"
        Me.foodtypepanel9.Size = New System.Drawing.Size(207, 226)
        Me.foodtypepanel9.TabIndex = 12
        Me.foodtypepanel9.Visible = False
        '
        'Label49
        '
        Me.Label49.AutoSize = True
        Me.Label49.Font = New System.Drawing.Font("Ebrima", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label49.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Label49.Location = New System.Drawing.Point(127, 166)
        Me.Label49.Name = "Label49"
        Me.Label49.Size = New System.Drawing.Size(66, 19)
        Me.Label49.TabIndex = 7
        Me.Label49.Text = "Quantity"
        '
        'Label58
        '
        Me.Label58.AutoSize = True
        Me.Label58.Font = New System.Drawing.Font("Ebrima", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label58.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Label58.Location = New System.Drawing.Point(20, 168)
        Me.Label58.Name = "Label58"
        Me.Label58.Size = New System.Drawing.Size(74, 19)
        Me.Label58.TabIndex = 6
        Me.Label58.Text = "Unit Price"
        '
        'foodsname9
        '
        Me.foodsname9.BackColor = System.Drawing.Color.Azure
        Me.foodsname9.FlatAppearance.BorderSize = 0
        Me.foodsname9.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent
        Me.foodsname9.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.foodsname9.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.foodsname9.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.foodsname9.Font = New System.Drawing.Font("Ebrima", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.foodsname9.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.foodsname9.Location = New System.Drawing.Point(-2, -1)
        Me.foodsname9.Name = "foodsname9"
        Me.foodsname9.Size = New System.Drawing.Size(208, 36)
        Me.foodsname9.TabIndex = 5
        Me.foodsname9.Text = "Name"
        Me.foodsname9.UseVisualStyleBackColor = False
        '
        'foodprice9
        '
        Me.foodprice9.AutoSize = True
        Me.foodprice9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.foodprice9.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.foodprice9.Location = New System.Drawing.Point(50, 193)
        Me.foodprice9.Name = "foodprice9"
        Me.foodprice9.Size = New System.Drawing.Size(49, 20)
        Me.foodprice9.TabIndex = 4
        Me.foodprice9.Text = "00.00"
        '
        'Label64
        '
        Me.Label64.AutoSize = True
        Me.Label64.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label64.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Label64.Location = New System.Drawing.Point(10, 193)
        Me.Label64.Name = "Label64"
        Me.Label64.Size = New System.Drawing.Size(49, 20)
        Me.Label64.TabIndex = 3
        Me.Label64.Text = "GHC "
        '
        'foodqty9
        '
        Me.foodqty9.BackColor = System.Drawing.Color.LightCyan
        Me.foodqty9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.foodqty9.Font = New System.Drawing.Font("Ebrima", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.foodqty9.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.foodqty9.Location = New System.Drawing.Point(131, 188)
        Me.foodqty9.Name = "foodqty9"
        Me.foodqty9.Size = New System.Drawing.Size(51, 31)
        Me.foodqty9.TabIndex = 1
        Me.foodqty9.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.foodqty9.ThousandsSeparator = True
        '
        'foodimg9
        '
        Me.foodimg9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.foodimg9.FlatAppearance.BorderSize = 0
        Me.foodimg9.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.foodimg9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.foodimg9.Location = New System.Drawing.Point(14, 35)
        Me.foodimg9.Name = "foodimg9"
        Me.foodimg9.Size = New System.Drawing.Size(176, 123)
        Me.foodimg9.TabIndex = 0
        Me.foodimg9.UseVisualStyleBackColor = True
        '
        'foodtypepanel8
        '
        Me.foodtypepanel8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.foodtypepanel8.Controls.Add(Me.Label60)
        Me.foodtypepanel8.Controls.Add(Me.Label61)
        Me.foodtypepanel8.Controls.Add(Me.foodsname8)
        Me.foodtypepanel8.Controls.Add(Me.foodprice8)
        Me.foodtypepanel8.Controls.Add(Me.Label63)
        Me.foodtypepanel8.Controls.Add(Me.NumericUpDown7)
        Me.foodtypepanel8.Controls.Add(Me.foodimg8)
        Me.foodtypepanel8.Cursor = System.Windows.Forms.Cursors.Hand
        Me.foodtypepanel8.Location = New System.Drawing.Point(874, 321)
        Me.foodtypepanel8.Name = "foodtypepanel8"
        Me.foodtypepanel8.Size = New System.Drawing.Size(207, 226)
        Me.foodtypepanel8.TabIndex = 11
        Me.foodtypepanel8.Visible = False
        '
        'Label60
        '
        Me.Label60.AutoSize = True
        Me.Label60.Font = New System.Drawing.Font("Ebrima", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label60.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Label60.Location = New System.Drawing.Point(127, 166)
        Me.Label60.Name = "Label60"
        Me.Label60.Size = New System.Drawing.Size(66, 19)
        Me.Label60.TabIndex = 7
        Me.Label60.Text = "Quantity"
        '
        'Label61
        '
        Me.Label61.AutoSize = True
        Me.Label61.Font = New System.Drawing.Font("Ebrima", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label61.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Label61.Location = New System.Drawing.Point(20, 168)
        Me.Label61.Name = "Label61"
        Me.Label61.Size = New System.Drawing.Size(74, 19)
        Me.Label61.TabIndex = 6
        Me.Label61.Text = "Unit Price"
        '
        'foodsname8
        '
        Me.foodsname8.BackColor = System.Drawing.Color.Azure
        Me.foodsname8.FlatAppearance.BorderSize = 0
        Me.foodsname8.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent
        Me.foodsname8.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.foodsname8.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.foodsname8.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.foodsname8.Font = New System.Drawing.Font("Ebrima", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.foodsname8.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.foodsname8.Location = New System.Drawing.Point(-2, -1)
        Me.foodsname8.Name = "foodsname8"
        Me.foodsname8.Size = New System.Drawing.Size(208, 36)
        Me.foodsname8.TabIndex = 5
        Me.foodsname8.Text = "Name"
        Me.foodsname8.UseVisualStyleBackColor = False
        '
        'foodprice8
        '
        Me.foodprice8.AutoSize = True
        Me.foodprice8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.foodprice8.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.foodprice8.Location = New System.Drawing.Point(50, 193)
        Me.foodprice8.Name = "foodprice8"
        Me.foodprice8.Size = New System.Drawing.Size(49, 20)
        Me.foodprice8.TabIndex = 4
        Me.foodprice8.Text = "00.00"
        '
        'Label63
        '
        Me.Label63.AutoSize = True
        Me.Label63.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label63.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Label63.Location = New System.Drawing.Point(10, 193)
        Me.Label63.Name = "Label63"
        Me.Label63.Size = New System.Drawing.Size(49, 20)
        Me.Label63.TabIndex = 3
        Me.Label63.Text = "GHC "
        '
        'NumericUpDown7
        '
        Me.NumericUpDown7.BackColor = System.Drawing.Color.LightCyan
        Me.NumericUpDown7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.NumericUpDown7.Font = New System.Drawing.Font("Ebrima", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NumericUpDown7.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.NumericUpDown7.Location = New System.Drawing.Point(131, 188)
        Me.NumericUpDown7.Name = "NumericUpDown7"
        Me.NumericUpDown7.Size = New System.Drawing.Size(51, 31)
        Me.NumericUpDown7.TabIndex = 1
        Me.NumericUpDown7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.NumericUpDown7.ThousandsSeparator = True
        '
        'foodimg8
        '
        Me.foodimg8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.foodimg8.FlatAppearance.BorderSize = 0
        Me.foodimg8.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.foodimg8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.foodimg8.Location = New System.Drawing.Point(14, 35)
        Me.foodimg8.Name = "foodimg8"
        Me.foodimg8.Size = New System.Drawing.Size(176, 123)
        Me.foodimg8.TabIndex = 0
        Me.foodimg8.UseVisualStyleBackColor = True
        '
        'foodtypepanel7
        '
        Me.foodtypepanel7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.foodtypepanel7.Controls.Add(Me.Label56)
        Me.foodtypepanel7.Controls.Add(Me.Label57)
        Me.foodtypepanel7.Controls.Add(Me.foodsname7)
        Me.foodtypepanel7.Controls.Add(Me.foodprice7)
        Me.foodtypepanel7.Controls.Add(Me.Label59)
        Me.foodtypepanel7.Controls.Add(Me.foodqty7)
        Me.foodtypepanel7.Controls.Add(Me.foodimg7)
        Me.foodtypepanel7.Cursor = System.Windows.Forms.Cursors.Hand
        Me.foodtypepanel7.Location = New System.Drawing.Point(598, 321)
        Me.foodtypepanel7.Name = "foodtypepanel7"
        Me.foodtypepanel7.Size = New System.Drawing.Size(207, 226)
        Me.foodtypepanel7.TabIndex = 10
        Me.foodtypepanel7.Visible = False
        '
        'Label56
        '
        Me.Label56.AutoSize = True
        Me.Label56.Font = New System.Drawing.Font("Ebrima", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label56.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Label56.Location = New System.Drawing.Point(127, 166)
        Me.Label56.Name = "Label56"
        Me.Label56.Size = New System.Drawing.Size(66, 19)
        Me.Label56.TabIndex = 7
        Me.Label56.Text = "Quantity"
        '
        'Label57
        '
        Me.Label57.AutoSize = True
        Me.Label57.Font = New System.Drawing.Font("Ebrima", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label57.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Label57.Location = New System.Drawing.Point(20, 168)
        Me.Label57.Name = "Label57"
        Me.Label57.Size = New System.Drawing.Size(74, 19)
        Me.Label57.TabIndex = 6
        Me.Label57.Text = "Unit Price"
        '
        'foodsname7
        '
        Me.foodsname7.BackColor = System.Drawing.Color.Azure
        Me.foodsname7.FlatAppearance.BorderSize = 0
        Me.foodsname7.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent
        Me.foodsname7.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.foodsname7.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.foodsname7.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.foodsname7.Font = New System.Drawing.Font("Ebrima", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.foodsname7.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.foodsname7.Location = New System.Drawing.Point(-2, -1)
        Me.foodsname7.Name = "foodsname7"
        Me.foodsname7.Size = New System.Drawing.Size(208, 36)
        Me.foodsname7.TabIndex = 5
        Me.foodsname7.Text = "Name"
        Me.foodsname7.UseVisualStyleBackColor = False
        '
        'foodprice7
        '
        Me.foodprice7.AutoSize = True
        Me.foodprice7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.foodprice7.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.foodprice7.Location = New System.Drawing.Point(50, 193)
        Me.foodprice7.Name = "foodprice7"
        Me.foodprice7.Size = New System.Drawing.Size(49, 20)
        Me.foodprice7.TabIndex = 4
        Me.foodprice7.Text = "00.00"
        '
        'Label59
        '
        Me.Label59.AutoSize = True
        Me.Label59.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label59.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Label59.Location = New System.Drawing.Point(10, 193)
        Me.Label59.Name = "Label59"
        Me.Label59.Size = New System.Drawing.Size(49, 20)
        Me.Label59.TabIndex = 3
        Me.Label59.Text = "GHC "
        '
        'foodqty7
        '
        Me.foodqty7.BackColor = System.Drawing.Color.LightCyan
        Me.foodqty7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.foodqty7.Font = New System.Drawing.Font("Ebrima", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.foodqty7.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.foodqty7.Location = New System.Drawing.Point(131, 188)
        Me.foodqty7.Name = "foodqty7"
        Me.foodqty7.Size = New System.Drawing.Size(51, 31)
        Me.foodqty7.TabIndex = 1
        Me.foodqty7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.foodqty7.ThousandsSeparator = True
        '
        'foodimg7
        '
        Me.foodimg7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.foodimg7.FlatAppearance.BorderSize = 0
        Me.foodimg7.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.foodimg7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.foodimg7.Location = New System.Drawing.Point(14, 35)
        Me.foodimg7.Name = "foodimg7"
        Me.foodimg7.Size = New System.Drawing.Size(176, 123)
        Me.foodimg7.TabIndex = 0
        Me.foodimg7.UseVisualStyleBackColor = True
        '
        'foodtypepanel6
        '
        Me.foodtypepanel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.foodtypepanel6.Controls.Add(Me.Label42)
        Me.foodtypepanel6.Controls.Add(Me.Label45)
        Me.foodtypepanel6.Controls.Add(Me.foodsname6)
        Me.foodtypepanel6.Controls.Add(Me.foodprice6)
        Me.foodtypepanel6.Controls.Add(Me.Label54)
        Me.foodtypepanel6.Controls.Add(Me.foodqty6)
        Me.foodtypepanel6.Controls.Add(Me.foodimg6)
        Me.foodtypepanel6.Cursor = System.Windows.Forms.Cursors.Hand
        Me.foodtypepanel6.Location = New System.Drawing.Point(326, 321)
        Me.foodtypepanel6.Name = "foodtypepanel6"
        Me.foodtypepanel6.Size = New System.Drawing.Size(207, 226)
        Me.foodtypepanel6.TabIndex = 9
        Me.foodtypepanel6.Visible = False
        '
        'Label42
        '
        Me.Label42.AutoSize = True
        Me.Label42.Font = New System.Drawing.Font("Ebrima", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label42.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Label42.Location = New System.Drawing.Point(127, 166)
        Me.Label42.Name = "Label42"
        Me.Label42.Size = New System.Drawing.Size(66, 19)
        Me.Label42.TabIndex = 7
        Me.Label42.Text = "Quantity"
        '
        'Label45
        '
        Me.Label45.AutoSize = True
        Me.Label45.Font = New System.Drawing.Font("Ebrima", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label45.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Label45.Location = New System.Drawing.Point(20, 168)
        Me.Label45.Name = "Label45"
        Me.Label45.Size = New System.Drawing.Size(74, 19)
        Me.Label45.TabIndex = 6
        Me.Label45.Text = "Unit Price"
        '
        'foodsname6
        '
        Me.foodsname6.BackColor = System.Drawing.Color.Azure
        Me.foodsname6.FlatAppearance.BorderSize = 0
        Me.foodsname6.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent
        Me.foodsname6.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.foodsname6.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.foodsname6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.foodsname6.Font = New System.Drawing.Font("Ebrima", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.foodsname6.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.foodsname6.Location = New System.Drawing.Point(-2, -1)
        Me.foodsname6.Name = "foodsname6"
        Me.foodsname6.Size = New System.Drawing.Size(208, 36)
        Me.foodsname6.TabIndex = 5
        Me.foodsname6.Text = "Name"
        Me.foodsname6.UseVisualStyleBackColor = False
        '
        'foodprice6
        '
        Me.foodprice6.AutoSize = True
        Me.foodprice6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.foodprice6.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.foodprice6.Location = New System.Drawing.Point(50, 193)
        Me.foodprice6.Name = "foodprice6"
        Me.foodprice6.Size = New System.Drawing.Size(49, 20)
        Me.foodprice6.TabIndex = 4
        Me.foodprice6.Text = "00.00"
        '
        'Label54
        '
        Me.Label54.AutoSize = True
        Me.Label54.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label54.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Label54.Location = New System.Drawing.Point(10, 193)
        Me.Label54.Name = "Label54"
        Me.Label54.Size = New System.Drawing.Size(49, 20)
        Me.Label54.TabIndex = 3
        Me.Label54.Text = "GHC "
        '
        'foodqty6
        '
        Me.foodqty6.BackColor = System.Drawing.Color.LightCyan
        Me.foodqty6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.foodqty6.Font = New System.Drawing.Font("Ebrima", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.foodqty6.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.foodqty6.Location = New System.Drawing.Point(131, 188)
        Me.foodqty6.Name = "foodqty6"
        Me.foodqty6.Size = New System.Drawing.Size(51, 31)
        Me.foodqty6.TabIndex = 1
        Me.foodqty6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.foodqty6.ThousandsSeparator = True
        '
        'foodimg6
        '
        Me.foodimg6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.foodimg6.FlatAppearance.BorderSize = 0
        Me.foodimg6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.foodimg6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.foodimg6.Location = New System.Drawing.Point(14, 35)
        Me.foodimg6.Name = "foodimg6"
        Me.foodimg6.Size = New System.Drawing.Size(176, 123)
        Me.foodimg6.TabIndex = 0
        Me.foodimg6.UseVisualStyleBackColor = True
        '
        'foodtypepanel4
        '
        Me.foodtypepanel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.foodtypepanel4.Controls.Add(Me.Label39)
        Me.foodtypepanel4.Controls.Add(Me.Label41)
        Me.foodtypepanel4.Controls.Add(Me.foodsname4)
        Me.foodtypepanel4.Controls.Add(Me.foodprice4)
        Me.foodtypepanel4.Controls.Add(Me.Label51)
        Me.foodtypepanel4.Controls.Add(Me.foodqty4)
        Me.foodtypepanel4.Controls.Add(Me.foodimg4)
        Me.foodtypepanel4.Location = New System.Drawing.Point(874, 32)
        Me.foodtypepanel4.Name = "foodtypepanel4"
        Me.foodtypepanel4.Size = New System.Drawing.Size(207, 226)
        Me.foodtypepanel4.TabIndex = 8
        Me.foodtypepanel4.Visible = False
        '
        'Label39
        '
        Me.Label39.AutoSize = True
        Me.Label39.Font = New System.Drawing.Font("Ebrima", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label39.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Label39.Location = New System.Drawing.Point(127, 166)
        Me.Label39.Name = "Label39"
        Me.Label39.Size = New System.Drawing.Size(66, 19)
        Me.Label39.TabIndex = 7
        Me.Label39.Text = "Quantity"
        '
        'Label41
        '
        Me.Label41.AutoSize = True
        Me.Label41.Font = New System.Drawing.Font("Ebrima", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label41.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Label41.Location = New System.Drawing.Point(20, 168)
        Me.Label41.Name = "Label41"
        Me.Label41.Size = New System.Drawing.Size(74, 19)
        Me.Label41.TabIndex = 6
        Me.Label41.Text = "Unit Price"
        '
        'foodsname4
        '
        Me.foodsname4.BackColor = System.Drawing.Color.Azure
        Me.foodsname4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.foodsname4.FlatAppearance.BorderSize = 0
        Me.foodsname4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.foodsname4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.foodsname4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.foodsname4.Font = New System.Drawing.Font("Ebrima", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.foodsname4.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.foodsname4.Location = New System.Drawing.Point(-2, -1)
        Me.foodsname4.Name = "foodsname4"
        Me.foodsname4.Size = New System.Drawing.Size(208, 36)
        Me.foodsname4.TabIndex = 5
        Me.foodsname4.Text = "Name"
        Me.foodsname4.UseVisualStyleBackColor = False
        '
        'foodprice4
        '
        Me.foodprice4.AutoSize = True
        Me.foodprice4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.foodprice4.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.foodprice4.Location = New System.Drawing.Point(50, 193)
        Me.foodprice4.Name = "foodprice4"
        Me.foodprice4.Size = New System.Drawing.Size(49, 20)
        Me.foodprice4.TabIndex = 4
        Me.foodprice4.Text = "00.00"
        '
        'Label51
        '
        Me.Label51.AutoSize = True
        Me.Label51.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label51.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Label51.Location = New System.Drawing.Point(10, 193)
        Me.Label51.Name = "Label51"
        Me.Label51.Size = New System.Drawing.Size(49, 20)
        Me.Label51.TabIndex = 3
        Me.Label51.Text = "GHC "
        '
        'foodqty4
        '
        Me.foodqty4.BackColor = System.Drawing.Color.LightCyan
        Me.foodqty4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.foodqty4.Font = New System.Drawing.Font("Ebrima", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.foodqty4.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.foodqty4.Location = New System.Drawing.Point(131, 188)
        Me.foodqty4.Name = "foodqty4"
        Me.foodqty4.Size = New System.Drawing.Size(51, 31)
        Me.foodqty4.TabIndex = 1
        Me.foodqty4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.foodqty4.ThousandsSeparator = True
        '
        'foodimg4
        '
        Me.foodimg4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.foodimg4.FlatAppearance.BorderSize = 0
        Me.foodimg4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.foodimg4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.foodimg4.Location = New System.Drawing.Point(14, 35)
        Me.foodimg4.Name = "foodimg4"
        Me.foodimg4.Size = New System.Drawing.Size(176, 123)
        Me.foodimg4.TabIndex = 0
        Me.foodimg4.UseVisualStyleBackColor = True
        '
        'foodtypepanel2
        '
        Me.foodtypepanel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.foodtypepanel2.Controls.Add(Me.foodimg2)
        Me.foodtypepanel2.Controls.Add(Me.foodsname2)
        Me.foodtypepanel2.Controls.Add(Me.Label43)
        Me.foodtypepanel2.Controls.Add(Me.Label44)
        Me.foodtypepanel2.Controls.Add(Me.foodprice2)
        Me.foodtypepanel2.Controls.Add(Me.Label46)
        Me.foodtypepanel2.Controls.Add(Me.foodqty2)
        Me.foodtypepanel2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.foodtypepanel2.Location = New System.Drawing.Point(326, 32)
        Me.foodtypepanel2.Name = "foodtypepanel2"
        Me.foodtypepanel2.Size = New System.Drawing.Size(207, 226)
        Me.foodtypepanel2.TabIndex = 8
        Me.foodtypepanel2.Visible = False
        '
        'foodimg2
        '
        Me.foodimg2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.foodimg2.FlatAppearance.BorderSize = 0
        Me.foodimg2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.foodimg2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.foodimg2.Location = New System.Drawing.Point(14, 35)
        Me.foodimg2.Name = "foodimg2"
        Me.foodimg2.Size = New System.Drawing.Size(176, 123)
        Me.foodimg2.TabIndex = 0
        Me.foodimg2.UseVisualStyleBackColor = True
        '
        'foodsname2
        '
        Me.foodsname2.BackColor = System.Drawing.Color.Azure
        Me.foodsname2.FlatAppearance.BorderSize = 0
        Me.foodsname2.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent
        Me.foodsname2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.foodsname2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.foodsname2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.foodsname2.Font = New System.Drawing.Font("Ebrima", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.foodsname2.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.foodsname2.Location = New System.Drawing.Point(-2, -1)
        Me.foodsname2.Name = "foodsname2"
        Me.foodsname2.Size = New System.Drawing.Size(209, 37)
        Me.foodsname2.TabIndex = 5
        Me.foodsname2.Text = "Name"
        Me.foodsname2.UseVisualStyleBackColor = False
        '
        'Label43
        '
        Me.Label43.AutoSize = True
        Me.Label43.Font = New System.Drawing.Font("Ebrima", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label43.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Label43.Location = New System.Drawing.Point(127, 166)
        Me.Label43.Name = "Label43"
        Me.Label43.Size = New System.Drawing.Size(66, 19)
        Me.Label43.TabIndex = 7
        Me.Label43.Text = "Quantity"
        '
        'Label44
        '
        Me.Label44.AutoSize = True
        Me.Label44.Font = New System.Drawing.Font("Ebrima", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label44.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Label44.Location = New System.Drawing.Point(20, 168)
        Me.Label44.Name = "Label44"
        Me.Label44.Size = New System.Drawing.Size(74, 19)
        Me.Label44.TabIndex = 6
        Me.Label44.Text = "Unit Price"
        '
        'foodprice2
        '
        Me.foodprice2.AutoSize = True
        Me.foodprice2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.foodprice2.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.foodprice2.Location = New System.Drawing.Point(50, 193)
        Me.foodprice2.Name = "foodprice2"
        Me.foodprice2.Size = New System.Drawing.Size(49, 20)
        Me.foodprice2.TabIndex = 4
        Me.foodprice2.Text = "00.00"
        '
        'Label46
        '
        Me.Label46.AutoSize = True
        Me.Label46.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label46.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Label46.Location = New System.Drawing.Point(10, 193)
        Me.Label46.Name = "Label46"
        Me.Label46.Size = New System.Drawing.Size(49, 20)
        Me.Label46.TabIndex = 3
        Me.Label46.Text = "GHC "
        '
        'foodqty2
        '
        Me.foodqty2.BackColor = System.Drawing.Color.LightCyan
        Me.foodqty2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.foodqty2.Font = New System.Drawing.Font("Ebrima", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.foodqty2.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.foodqty2.Location = New System.Drawing.Point(131, 188)
        Me.foodqty2.Name = "foodqty2"
        Me.foodqty2.Size = New System.Drawing.Size(51, 31)
        Me.foodqty2.TabIndex = 1
        Me.foodqty2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.foodqty2.ThousandsSeparator = True
        '
        'foodtypepanel5
        '
        Me.foodtypepanel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.foodtypepanel5.Controls.Add(Me.Label52)
        Me.foodtypepanel5.Controls.Add(Me.Label53)
        Me.foodtypepanel5.Controls.Add(Me.foodsname5)
        Me.foodtypepanel5.Controls.Add(Me.foodprice5)
        Me.foodtypepanel5.Controls.Add(Me.Label55)
        Me.foodtypepanel5.Controls.Add(Me.foodqty5)
        Me.foodtypepanel5.Controls.Add(Me.foodimg5)
        Me.foodtypepanel5.Cursor = System.Windows.Forms.Cursors.Hand
        Me.foodtypepanel5.Location = New System.Drawing.Point(58, 321)
        Me.foodtypepanel5.Name = "foodtypepanel5"
        Me.foodtypepanel5.Size = New System.Drawing.Size(207, 226)
        Me.foodtypepanel5.TabIndex = 4
        Me.foodtypepanel5.Visible = False
        '
        'Label52
        '
        Me.Label52.AutoSize = True
        Me.Label52.Font = New System.Drawing.Font("Ebrima", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label52.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Label52.Location = New System.Drawing.Point(127, 166)
        Me.Label52.Name = "Label52"
        Me.Label52.Size = New System.Drawing.Size(66, 19)
        Me.Label52.TabIndex = 7
        Me.Label52.Text = "Quantity"
        '
        'Label53
        '
        Me.Label53.AutoSize = True
        Me.Label53.Font = New System.Drawing.Font("Ebrima", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label53.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Label53.Location = New System.Drawing.Point(20, 168)
        Me.Label53.Name = "Label53"
        Me.Label53.Size = New System.Drawing.Size(74, 19)
        Me.Label53.TabIndex = 6
        Me.Label53.Text = "Unit Price"
        '
        'foodsname5
        '
        Me.foodsname5.BackColor = System.Drawing.Color.Azure
        Me.foodsname5.FlatAppearance.BorderSize = 0
        Me.foodsname5.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent
        Me.foodsname5.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.foodsname5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.foodsname5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.foodsname5.Font = New System.Drawing.Font("Ebrima", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.foodsname5.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.foodsname5.Location = New System.Drawing.Point(-2, -1)
        Me.foodsname5.Name = "foodsname5"
        Me.foodsname5.Size = New System.Drawing.Size(208, 36)
        Me.foodsname5.TabIndex = 5
        Me.foodsname5.Text = "Name"
        Me.foodsname5.UseVisualStyleBackColor = False
        '
        'foodprice5
        '
        Me.foodprice5.AutoSize = True
        Me.foodprice5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.foodprice5.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.foodprice5.Location = New System.Drawing.Point(50, 193)
        Me.foodprice5.Name = "foodprice5"
        Me.foodprice5.Size = New System.Drawing.Size(49, 20)
        Me.foodprice5.TabIndex = 4
        Me.foodprice5.Text = "00.00"
        '
        'Label55
        '
        Me.Label55.AutoSize = True
        Me.Label55.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label55.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Label55.Location = New System.Drawing.Point(10, 193)
        Me.Label55.Name = "Label55"
        Me.Label55.Size = New System.Drawing.Size(49, 20)
        Me.Label55.TabIndex = 3
        Me.Label55.Text = "GHC "
        '
        'foodqty5
        '
        Me.foodqty5.BackColor = System.Drawing.Color.LightCyan
        Me.foodqty5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.foodqty5.Font = New System.Drawing.Font("Ebrima", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.foodqty5.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.foodqty5.Location = New System.Drawing.Point(131, 188)
        Me.foodqty5.Name = "foodqty5"
        Me.foodqty5.Size = New System.Drawing.Size(51, 31)
        Me.foodqty5.TabIndex = 1
        Me.foodqty5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.foodqty5.ThousandsSeparator = True
        '
        'foodimg5
        '
        Me.foodimg5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.foodimg5.FlatAppearance.BorderSize = 0
        Me.foodimg5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.foodimg5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.foodimg5.Location = New System.Drawing.Point(14, 35)
        Me.foodimg5.Name = "foodimg5"
        Me.foodimg5.Size = New System.Drawing.Size(176, 123)
        Me.foodimg5.TabIndex = 0
        Me.foodimg5.UseVisualStyleBackColor = True
        '
        'foodtypepanel3
        '
        Me.foodtypepanel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.foodtypepanel3.Controls.Add(Me.Label47)
        Me.foodtypepanel3.Controls.Add(Me.Label48)
        Me.foodtypepanel3.Controls.Add(Me.foodsname3)
        Me.foodtypepanel3.Controls.Add(Me.foodprice3)
        Me.foodtypepanel3.Controls.Add(Me.Label50)
        Me.foodtypepanel3.Controls.Add(Me.foodqty3)
        Me.foodtypepanel3.Controls.Add(Me.foodimg3)
        Me.foodtypepanel3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.foodtypepanel3.Location = New System.Drawing.Point(598, 32)
        Me.foodtypepanel3.Name = "foodtypepanel3"
        Me.foodtypepanel3.Size = New System.Drawing.Size(207, 226)
        Me.foodtypepanel3.TabIndex = 3
        Me.foodtypepanel3.Visible = False
        '
        'Label47
        '
        Me.Label47.AutoSize = True
        Me.Label47.Font = New System.Drawing.Font("Ebrima", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label47.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Label47.Location = New System.Drawing.Point(127, 166)
        Me.Label47.Name = "Label47"
        Me.Label47.Size = New System.Drawing.Size(66, 19)
        Me.Label47.TabIndex = 7
        Me.Label47.Text = "Quantity"
        '
        'Label48
        '
        Me.Label48.AutoSize = True
        Me.Label48.Font = New System.Drawing.Font("Ebrima", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label48.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Label48.Location = New System.Drawing.Point(20, 168)
        Me.Label48.Name = "Label48"
        Me.Label48.Size = New System.Drawing.Size(74, 19)
        Me.Label48.TabIndex = 6
        Me.Label48.Text = "Unit Price"
        '
        'foodsname3
        '
        Me.foodsname3.BackColor = System.Drawing.Color.Azure
        Me.foodsname3.FlatAppearance.BorderSize = 0
        Me.foodsname3.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent
        Me.foodsname3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.foodsname3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.foodsname3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.foodsname3.Font = New System.Drawing.Font("Ebrima", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.foodsname3.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.foodsname3.Location = New System.Drawing.Point(-2, -1)
        Me.foodsname3.Name = "foodsname3"
        Me.foodsname3.Size = New System.Drawing.Size(208, 36)
        Me.foodsname3.TabIndex = 5
        Me.foodsname3.Text = "Name"
        Me.foodsname3.UseVisualStyleBackColor = False
        '
        'foodprice3
        '
        Me.foodprice3.AutoSize = True
        Me.foodprice3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.foodprice3.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.foodprice3.Location = New System.Drawing.Point(50, 193)
        Me.foodprice3.Name = "foodprice3"
        Me.foodprice3.Size = New System.Drawing.Size(49, 20)
        Me.foodprice3.TabIndex = 4
        Me.foodprice3.Text = "00.00"
        '
        'Label50
        '
        Me.Label50.AutoSize = True
        Me.Label50.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label50.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Label50.Location = New System.Drawing.Point(10, 193)
        Me.Label50.Name = "Label50"
        Me.Label50.Size = New System.Drawing.Size(49, 20)
        Me.Label50.TabIndex = 3
        Me.Label50.Text = "GHC "
        '
        'foodqty3
        '
        Me.foodqty3.BackColor = System.Drawing.Color.LightCyan
        Me.foodqty3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.foodqty3.Font = New System.Drawing.Font("Ebrima", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.foodqty3.Location = New System.Drawing.Point(131, 188)
        Me.foodqty3.Name = "foodqty3"
        Me.foodqty3.Size = New System.Drawing.Size(51, 31)
        Me.foodqty3.TabIndex = 1
        Me.foodqty3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.foodqty3.ThousandsSeparator = True
        '
        'foodimg3
        '
        Me.foodimg3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.foodimg3.FlatAppearance.BorderSize = 0
        Me.foodimg3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.foodimg3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.foodimg3.Location = New System.Drawing.Point(14, 35)
        Me.foodimg3.Name = "foodimg3"
        Me.foodimg3.Size = New System.Drawing.Size(176, 123)
        Me.foodimg3.TabIndex = 0
        Me.foodimg3.UseVisualStyleBackColor = True
        '
        'foodsDGV
        '
        Me.foodsDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.foodsDGV.Location = New System.Drawing.Point(325, 1413)
        Me.foodsDGV.Name = "foodsDGV"
        Me.foodsDGV.RowHeadersVisible = False
        Me.foodsDGV.Size = New System.Drawing.Size(480, 61)
        Me.foodsDGV.TabIndex = 2
        Me.foodsDGV.Visible = False
        '
        'drinkspanel
        '
        Me.drinkspanel.Location = New System.Drawing.Point(26, 130)
        Me.drinkspanel.Name = "drinkspanel"
        Me.drinkspanel.Size = New System.Drawing.Size(200, 100)
        Me.drinkspanel.TabIndex = 1
        Me.drinkspanel.Visible = False
        '
        'tabwaitercancel
        '
        Me.tabwaitercancel.BackColor = System.Drawing.Color.LightCyan
        Me.tabwaitercancel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.tabwaitercancel.FlatAppearance.BorderSize = 0
        Me.tabwaitercancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PaleTurquoise
        Me.tabwaitercancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.tabwaitercancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tabwaitercancel.ForeColor = System.Drawing.Color.LightSeaGreen
        Me.tabwaitercancel.Location = New System.Drawing.Point(22, 418)
        Me.tabwaitercancel.Name = "tabwaitercancel"
        Me.tabwaitercancel.Size = New System.Drawing.Size(198, 52)
        Me.tabwaitercancel.TabIndex = 31
        Me.tabwaitercancel.Text = "CANCEL OEDER"
        Me.tabwaitercancel.UseVisualStyleBackColor = False
        '
        'tabwaiterfoods
        '
        Me.tabwaiterfoods.BackColor = System.Drawing.Color.LightCyan
        Me.tabwaiterfoods.Cursor = System.Windows.Forms.Cursors.Hand
        Me.tabwaiterfoods.FlatAppearance.BorderSize = 0
        Me.tabwaiterfoods.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PaleTurquoise
        Me.tabwaiterfoods.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.tabwaiterfoods.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tabwaiterfoods.ForeColor = System.Drawing.Color.LightSeaGreen
        Me.tabwaiterfoods.Location = New System.Drawing.Point(22, 32)
        Me.tabwaiterfoods.Name = "tabwaiterfoods"
        Me.tabwaiterfoods.Size = New System.Drawing.Size(198, 52)
        Me.tabwaiterfoods.TabIndex = 21
        Me.tabwaiterfoods.Text = "FOODS"
        Me.tabwaiterfoods.UseVisualStyleBackColor = False
        '
        'waiteractive5
        '
        Me.waiteractive5.BackColor = System.Drawing.Color.LightSeaGreen
        Me.waiteractive5.Enabled = False
        Me.waiteractive5.FlatAppearance.BorderSize = 0
        Me.waiteractive5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.waiteractive5.Location = New System.Drawing.Point(12, 342)
        Me.waiteractive5.Name = "waiteractive5"
        Me.waiteractive5.Size = New System.Drawing.Size(10, 52)
        Me.waiteractive5.TabIndex = 30
        Me.waiteractive5.Text = "Button8"
        Me.waiteractive5.UseVisualStyleBackColor = False
        '
        'waiteractive1
        '
        Me.waiteractive1.BackColor = System.Drawing.Color.LightSeaGreen
        Me.waiteractive1.Enabled = False
        Me.waiteractive1.FlatAppearance.BorderSize = 0
        Me.waiteractive1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.waiteractive1.Location = New System.Drawing.Point(12, 32)
        Me.waiteractive1.Name = "waiteractive1"
        Me.waiteractive1.Size = New System.Drawing.Size(10, 52)
        Me.waiteractive1.TabIndex = 22
        Me.waiteractive1.Text = "Button8"
        Me.waiteractive1.UseVisualStyleBackColor = False
        '
        'tabwaitersummary
        '
        Me.tabwaitersummary.BackColor = System.Drawing.Color.LightCyan
        Me.tabwaitersummary.Cursor = System.Windows.Forms.Cursors.Hand
        Me.tabwaitersummary.FlatAppearance.BorderSize = 0
        Me.tabwaitersummary.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PaleTurquoise
        Me.tabwaitersummary.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.tabwaitersummary.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tabwaitersummary.ForeColor = System.Drawing.Color.LightSeaGreen
        Me.tabwaitersummary.Location = New System.Drawing.Point(22, 342)
        Me.tabwaitersummary.Name = "tabwaitersummary"
        Me.tabwaitersummary.Size = New System.Drawing.Size(198, 52)
        Me.tabwaitersummary.TabIndex = 29
        Me.tabwaitersummary.Text = "SUMMARY"
        Me.tabwaitersummary.UseVisualStyleBackColor = False
        '
        'tabwaiterdrinks
        '
        Me.tabwaiterdrinks.BackColor = System.Drawing.Color.LightCyan
        Me.tabwaiterdrinks.Cursor = System.Windows.Forms.Cursors.Hand
        Me.tabwaiterdrinks.FlatAppearance.BorderSize = 0
        Me.tabwaiterdrinks.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PaleTurquoise
        Me.tabwaiterdrinks.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.tabwaiterdrinks.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tabwaiterdrinks.ForeColor = System.Drawing.Color.LightSeaGreen
        Me.tabwaiterdrinks.Location = New System.Drawing.Point(22, 109)
        Me.tabwaiterdrinks.Name = "tabwaiterdrinks"
        Me.tabwaiterdrinks.Size = New System.Drawing.Size(198, 52)
        Me.tabwaiterdrinks.TabIndex = 23
        Me.tabwaiterdrinks.Text = "DRINKS"
        Me.tabwaiterdrinks.UseVisualStyleBackColor = False
        '
        'waiteractive4
        '
        Me.waiteractive4.BackColor = System.Drawing.Color.LightSeaGreen
        Me.waiteractive4.Enabled = False
        Me.waiteractive4.FlatAppearance.BorderSize = 0
        Me.waiteractive4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.waiteractive4.Location = New System.Drawing.Point(12, 263)
        Me.waiteractive4.Name = "waiteractive4"
        Me.waiteractive4.Size = New System.Drawing.Size(10, 52)
        Me.waiteractive4.TabIndex = 28
        Me.waiteractive4.Text = "Button8"
        Me.waiteractive4.UseVisualStyleBackColor = False
        '
        'waiteractive2
        '
        Me.waiteractive2.BackColor = System.Drawing.Color.LightSeaGreen
        Me.waiteractive2.Enabled = False
        Me.waiteractive2.FlatAppearance.BorderSize = 0
        Me.waiteractive2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.waiteractive2.Location = New System.Drawing.Point(12, 109)
        Me.waiteractive2.Name = "waiteractive2"
        Me.waiteractive2.Size = New System.Drawing.Size(10, 52)
        Me.waiteractive2.TabIndex = 24
        Me.waiteractive2.Text = "Button8"
        Me.waiteractive2.UseVisualStyleBackColor = False
        '
        'tabwaitdessert
        '
        Me.tabwaitdessert.BackColor = System.Drawing.Color.LightCyan
        Me.tabwaitdessert.Cursor = System.Windows.Forms.Cursors.Hand
        Me.tabwaitdessert.FlatAppearance.BorderSize = 0
        Me.tabwaitdessert.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PaleTurquoise
        Me.tabwaitdessert.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.tabwaitdessert.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tabwaitdessert.ForeColor = System.Drawing.Color.LightSeaGreen
        Me.tabwaitdessert.Location = New System.Drawing.Point(22, 263)
        Me.tabwaitdessert.Name = "tabwaitdessert"
        Me.tabwaitdessert.Size = New System.Drawing.Size(198, 52)
        Me.tabwaitdessert.TabIndex = 27
        Me.tabwaitdessert.Text = "DESSERT"
        Me.tabwaitdessert.UseVisualStyleBackColor = False
        '
        'tabwaiterpastries
        '
        Me.tabwaiterpastries.BackColor = System.Drawing.Color.LightCyan
        Me.tabwaiterpastries.Cursor = System.Windows.Forms.Cursors.Hand
        Me.tabwaiterpastries.FlatAppearance.BorderSize = 0
        Me.tabwaiterpastries.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PaleTurquoise
        Me.tabwaiterpastries.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.tabwaiterpastries.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tabwaiterpastries.ForeColor = System.Drawing.Color.LightSeaGreen
        Me.tabwaiterpastries.Location = New System.Drawing.Point(22, 182)
        Me.tabwaiterpastries.Name = "tabwaiterpastries"
        Me.tabwaiterpastries.Size = New System.Drawing.Size(198, 52)
        Me.tabwaiterpastries.TabIndex = 25
        Me.tabwaiterpastries.Text = "PASTRIES"
        Me.tabwaiterpastries.UseVisualStyleBackColor = False
        '
        'waiteractive3
        '
        Me.waiteractive3.BackColor = System.Drawing.Color.LightSeaGreen
        Me.waiteractive3.Enabled = False
        Me.waiteractive3.FlatAppearance.BorderSize = 0
        Me.waiteractive3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.waiteractive3.Location = New System.Drawing.Point(12, 182)
        Me.waiteractive3.Name = "waiteractive3"
        Me.waiteractive3.Size = New System.Drawing.Size(10, 52)
        Me.waiteractive3.TabIndex = 26
        Me.waiteractive3.Text = "Button8"
        Me.waiteractive3.UseVisualStyleBackColor = False
        '
        'chefpanel
        '
        Me.chefpanel.BackColor = System.Drawing.Color.Azure
        Me.chefpanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.chefpanel.Location = New System.Drawing.Point(334, 25)
        Me.chefpanel.Name = "chefpanel"
        Me.chefpanel.Size = New System.Drawing.Size(259, 198)
        Me.chefpanel.TabIndex = 4
        '
        'managerpanel
        '
        Me.managerpanel.BackColor = System.Drawing.Color.Azure
        Me.managerpanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.managerpanel.Location = New System.Drawing.Point(28, 248)
        Me.managerpanel.Name = "managerpanel"
        Me.managerpanel.Size = New System.Drawing.Size(257, 223)
        Me.managerpanel.TabIndex = 5
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
        'titlebar
        '
        Me.titlebar.BackColor = System.Drawing.Color.PaleTurquoise
        Me.titlebar.Location = New System.Drawing.Point(0, 0)
        Me.titlebar.Name = "titlebar"
        Me.titlebar.Size = New System.Drawing.Size(1350, 24)
        Me.titlebar.TabIndex = 16
        Me.titlebar.Text = "MenuStrip1"
        '
        'closeicon
        '
        Me.closeicon.BackColor = System.Drawing.Color.PaleTurquoise
        Me.closeicon.BackgroundImage = Global.DiCE.My.Resources.Resources.Close_1
        Me.closeicon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.closeicon.Location = New System.Drawing.Point(1319, 0)
        Me.closeicon.Name = "closeicon"
        Me.closeicon.Size = New System.Drawing.Size(28, 24)
        Me.closeicon.TabIndex = 0
        '
        'invalidlogintimer
        '
        '
        'foodtypepanel20
        '
        Me.foodtypepanel20.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.foodtypepanel20.Controls.Add(Me.Label72)
        Me.foodtypepanel20.Controls.Add(Me.Label74)
        Me.foodtypepanel20.Controls.Add(Me.foodsname20)
        Me.foodtypepanel20.Controls.Add(Me.foodprice20)
        Me.foodtypepanel20.Controls.Add(Me.Label76)
        Me.foodtypepanel20.Controls.Add(Me.foodqty20)
        Me.foodtypepanel20.Controls.Add(Me.foodimg20)
        Me.foodtypepanel20.Cursor = System.Windows.Forms.Cursors.Hand
        Me.foodtypepanel20.Location = New System.Drawing.Point(874, 1175)
        Me.foodtypepanel20.Name = "foodtypepanel20"
        Me.foodtypepanel20.Size = New System.Drawing.Size(207, 226)
        Me.foodtypepanel20.TabIndex = 23
        Me.foodtypepanel20.Visible = False
        '
        'Label72
        '
        Me.Label72.AutoSize = True
        Me.Label72.Font = New System.Drawing.Font("Ebrima", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label72.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Label72.Location = New System.Drawing.Point(127, 166)
        Me.Label72.Name = "Label72"
        Me.Label72.Size = New System.Drawing.Size(66, 19)
        Me.Label72.TabIndex = 7
        Me.Label72.Text = "Quantity"
        '
        'Label74
        '
        Me.Label74.AutoSize = True
        Me.Label74.Font = New System.Drawing.Font("Ebrima", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label74.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Label74.Location = New System.Drawing.Point(20, 168)
        Me.Label74.Name = "Label74"
        Me.Label74.Size = New System.Drawing.Size(74, 19)
        Me.Label74.TabIndex = 6
        Me.Label74.Text = "Unit Price"
        '
        'foodsname20
        '
        Me.foodsname20.BackColor = System.Drawing.Color.Azure
        Me.foodsname20.FlatAppearance.BorderSize = 0
        Me.foodsname20.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent
        Me.foodsname20.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.foodsname20.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.foodsname20.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.foodsname20.Font = New System.Drawing.Font("Ebrima", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.foodsname20.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.foodsname20.Location = New System.Drawing.Point(-2, -1)
        Me.foodsname20.Name = "foodsname20"
        Me.foodsname20.Size = New System.Drawing.Size(208, 36)
        Me.foodsname20.TabIndex = 5
        Me.foodsname20.Text = "Name"
        Me.foodsname20.UseVisualStyleBackColor = False
        '
        'foodprice20
        '
        Me.foodprice20.AutoSize = True
        Me.foodprice20.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.foodprice20.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.foodprice20.Location = New System.Drawing.Point(50, 193)
        Me.foodprice20.Name = "foodprice20"
        Me.foodprice20.Size = New System.Drawing.Size(49, 20)
        Me.foodprice20.TabIndex = 4
        Me.foodprice20.Text = "00.00"
        Me.foodprice20.Visible = False
        '
        'Label76
        '
        Me.Label76.AutoSize = True
        Me.Label76.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label76.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Label76.Location = New System.Drawing.Point(10, 193)
        Me.Label76.Name = "Label76"
        Me.Label76.Size = New System.Drawing.Size(49, 20)
        Me.Label76.TabIndex = 3
        Me.Label76.Text = "GHC "
        '
        'foodqty20
        '
        Me.foodqty20.BackColor = System.Drawing.Color.LightCyan
        Me.foodqty20.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.foodqty20.Font = New System.Drawing.Font("Ebrima", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.foodqty20.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.foodqty20.Location = New System.Drawing.Point(131, 188)
        Me.foodqty20.Name = "foodqty20"
        Me.foodqty20.Size = New System.Drawing.Size(51, 31)
        Me.foodqty20.TabIndex = 1
        Me.foodqty20.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.foodqty20.ThousandsSeparator = True
        '
        'foodimg20
        '
        Me.foodimg20.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.foodimg20.FlatAppearance.BorderSize = 0
        Me.foodimg20.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.foodimg20.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.foodimg20.Location = New System.Drawing.Point(14, 35)
        Me.foodimg20.Name = "foodimg20"
        Me.foodimg20.Size = New System.Drawing.Size(176, 123)
        Me.foodimg20.TabIndex = 0
        Me.foodimg20.UseVisualStyleBackColor = True
        '
        'foodtypepanel19
        '
        Me.foodtypepanel19.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.foodtypepanel19.Controls.Add(Me.Label77)
        Me.foodtypepanel19.Controls.Add(Me.Label78)
        Me.foodtypepanel19.Controls.Add(Me.foodsname19)
        Me.foodtypepanel19.Controls.Add(Me.foodprice19)
        Me.foodtypepanel19.Controls.Add(Me.Label80)
        Me.foodtypepanel19.Controls.Add(Me.foodqty19)
        Me.foodtypepanel19.Controls.Add(Me.foodimg19)
        Me.foodtypepanel19.Cursor = System.Windows.Forms.Cursors.Hand
        Me.foodtypepanel19.Location = New System.Drawing.Point(598, 1175)
        Me.foodtypepanel19.Name = "foodtypepanel19"
        Me.foodtypepanel19.Size = New System.Drawing.Size(207, 226)
        Me.foodtypepanel19.TabIndex = 22
        Me.foodtypepanel19.Visible = False
        '
        'Label77
        '
        Me.Label77.AutoSize = True
        Me.Label77.Font = New System.Drawing.Font("Ebrima", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label77.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Label77.Location = New System.Drawing.Point(127, 166)
        Me.Label77.Name = "Label77"
        Me.Label77.Size = New System.Drawing.Size(66, 19)
        Me.Label77.TabIndex = 7
        Me.Label77.Text = "Quantity"
        '
        'Label78
        '
        Me.Label78.AutoSize = True
        Me.Label78.Font = New System.Drawing.Font("Ebrima", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label78.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Label78.Location = New System.Drawing.Point(20, 168)
        Me.Label78.Name = "Label78"
        Me.Label78.Size = New System.Drawing.Size(74, 19)
        Me.Label78.TabIndex = 6
        Me.Label78.Text = "Unit Price"
        '
        'foodsname19
        '
        Me.foodsname19.BackColor = System.Drawing.Color.Azure
        Me.foodsname19.FlatAppearance.BorderSize = 0
        Me.foodsname19.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent
        Me.foodsname19.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.foodsname19.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.foodsname19.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.foodsname19.Font = New System.Drawing.Font("Ebrima", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.foodsname19.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.foodsname19.Location = New System.Drawing.Point(-2, -1)
        Me.foodsname19.Name = "foodsname19"
        Me.foodsname19.Size = New System.Drawing.Size(208, 36)
        Me.foodsname19.TabIndex = 5
        Me.foodsname19.Text = "Name"
        Me.foodsname19.UseVisualStyleBackColor = False
        '
        'foodprice19
        '
        Me.foodprice19.AutoSize = True
        Me.foodprice19.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.foodprice19.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.foodprice19.Location = New System.Drawing.Point(50, 193)
        Me.foodprice19.Name = "foodprice19"
        Me.foodprice19.Size = New System.Drawing.Size(49, 20)
        Me.foodprice19.TabIndex = 4
        Me.foodprice19.Text = "00.00"
        Me.foodprice19.Visible = False
        '
        'Label80
        '
        Me.Label80.AutoSize = True
        Me.Label80.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label80.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Label80.Location = New System.Drawing.Point(10, 193)
        Me.Label80.Name = "Label80"
        Me.Label80.Size = New System.Drawing.Size(49, 20)
        Me.Label80.TabIndex = 3
        Me.Label80.Text = "GHC "
        '
        'foodqty19
        '
        Me.foodqty19.BackColor = System.Drawing.Color.LightCyan
        Me.foodqty19.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.foodqty19.Font = New System.Drawing.Font("Ebrima", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.foodqty19.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.foodqty19.Location = New System.Drawing.Point(131, 188)
        Me.foodqty19.Name = "foodqty19"
        Me.foodqty19.Size = New System.Drawing.Size(51, 31)
        Me.foodqty19.TabIndex = 1
        Me.foodqty19.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.foodqty19.ThousandsSeparator = True
        '
        'foodimg19
        '
        Me.foodimg19.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.foodimg19.FlatAppearance.BorderSize = 0
        Me.foodimg19.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.foodimg19.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.foodimg19.Location = New System.Drawing.Point(14, 35)
        Me.foodimg19.Name = "foodimg19"
        Me.foodimg19.Size = New System.Drawing.Size(176, 123)
        Me.foodimg19.TabIndex = 0
        Me.foodimg19.UseVisualStyleBackColor = True
        '
        'foodtypepanel18
        '
        Me.foodtypepanel18.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.foodtypepanel18.Controls.Add(Me.Label81)
        Me.foodtypepanel18.Controls.Add(Me.Label82)
        Me.foodtypepanel18.Controls.Add(Me.foodsname18)
        Me.foodtypepanel18.Controls.Add(Me.foodprice18)
        Me.foodtypepanel18.Controls.Add(Me.Label84)
        Me.foodtypepanel18.Controls.Add(Me.foodqty18)
        Me.foodtypepanel18.Controls.Add(Me.foodimg18)
        Me.foodtypepanel18.Cursor = System.Windows.Forms.Cursors.Hand
        Me.foodtypepanel18.Location = New System.Drawing.Point(326, 1175)
        Me.foodtypepanel18.Name = "foodtypepanel18"
        Me.foodtypepanel18.Size = New System.Drawing.Size(207, 226)
        Me.foodtypepanel18.TabIndex = 21
        Me.foodtypepanel18.Visible = False
        '
        'Label81
        '
        Me.Label81.AutoSize = True
        Me.Label81.Font = New System.Drawing.Font("Ebrima", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label81.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Label81.Location = New System.Drawing.Point(127, 166)
        Me.Label81.Name = "Label81"
        Me.Label81.Size = New System.Drawing.Size(66, 19)
        Me.Label81.TabIndex = 7
        Me.Label81.Text = "Quantity"
        '
        'Label82
        '
        Me.Label82.AutoSize = True
        Me.Label82.Font = New System.Drawing.Font("Ebrima", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label82.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Label82.Location = New System.Drawing.Point(20, 168)
        Me.Label82.Name = "Label82"
        Me.Label82.Size = New System.Drawing.Size(74, 19)
        Me.Label82.TabIndex = 6
        Me.Label82.Text = "Unit Price"
        '
        'foodsname18
        '
        Me.foodsname18.BackColor = System.Drawing.Color.Azure
        Me.foodsname18.FlatAppearance.BorderSize = 0
        Me.foodsname18.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent
        Me.foodsname18.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.foodsname18.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.foodsname18.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.foodsname18.Font = New System.Drawing.Font("Ebrima", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.foodsname18.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.foodsname18.Location = New System.Drawing.Point(-2, -1)
        Me.foodsname18.Name = "foodsname18"
        Me.foodsname18.Size = New System.Drawing.Size(208, 36)
        Me.foodsname18.TabIndex = 5
        Me.foodsname18.Text = "Name"
        Me.foodsname18.UseVisualStyleBackColor = False
        '
        'foodprice18
        '
        Me.foodprice18.AutoSize = True
        Me.foodprice18.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.foodprice18.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.foodprice18.Location = New System.Drawing.Point(50, 193)
        Me.foodprice18.Name = "foodprice18"
        Me.foodprice18.Size = New System.Drawing.Size(49, 20)
        Me.foodprice18.TabIndex = 4
        Me.foodprice18.Text = "00.00"
        '
        'Label84
        '
        Me.Label84.AutoSize = True
        Me.Label84.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label84.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Label84.Location = New System.Drawing.Point(10, 193)
        Me.Label84.Name = "Label84"
        Me.Label84.Size = New System.Drawing.Size(49, 20)
        Me.Label84.TabIndex = 3
        Me.Label84.Text = "GHC "
        '
        'foodqty18
        '
        Me.foodqty18.BackColor = System.Drawing.Color.LightCyan
        Me.foodqty18.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.foodqty18.Font = New System.Drawing.Font("Ebrima", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.foodqty18.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.foodqty18.Location = New System.Drawing.Point(131, 188)
        Me.foodqty18.Name = "foodqty18"
        Me.foodqty18.Size = New System.Drawing.Size(51, 31)
        Me.foodqty18.TabIndex = 1
        Me.foodqty18.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.foodqty18.ThousandsSeparator = True
        '
        'foodimg18
        '
        Me.foodimg18.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.foodimg18.FlatAppearance.BorderSize = 0
        Me.foodimg18.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.foodimg18.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.foodimg18.Location = New System.Drawing.Point(14, 35)
        Me.foodimg18.Name = "foodimg18"
        Me.foodimg18.Size = New System.Drawing.Size(176, 123)
        Me.foodimg18.TabIndex = 0
        Me.foodimg18.UseVisualStyleBackColor = True
        '
        'foodtypepanel17
        '
        Me.foodtypepanel17.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.foodtypepanel17.Controls.Add(Me.Label85)
        Me.foodtypepanel17.Controls.Add(Me.Label86)
        Me.foodtypepanel17.Controls.Add(Me.foodsname17)
        Me.foodtypepanel17.Controls.Add(Me.foodprice17)
        Me.foodtypepanel17.Controls.Add(Me.Label88)
        Me.foodtypepanel17.Controls.Add(Me.foodqty17)
        Me.foodtypepanel17.Controls.Add(Me.foodimg17)
        Me.foodtypepanel17.Cursor = System.Windows.Forms.Cursors.Hand
        Me.foodtypepanel17.Location = New System.Drawing.Point(58, 1175)
        Me.foodtypepanel17.Name = "foodtypepanel17"
        Me.foodtypepanel17.Size = New System.Drawing.Size(207, 226)
        Me.foodtypepanel17.TabIndex = 20
        Me.foodtypepanel17.Visible = False
        '
        'Label85
        '
        Me.Label85.AutoSize = True
        Me.Label85.Font = New System.Drawing.Font("Ebrima", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label85.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Label85.Location = New System.Drawing.Point(127, 166)
        Me.Label85.Name = "Label85"
        Me.Label85.Size = New System.Drawing.Size(66, 19)
        Me.Label85.TabIndex = 7
        Me.Label85.Text = "Quantity"
        '
        'Label86
        '
        Me.Label86.AutoSize = True
        Me.Label86.Font = New System.Drawing.Font("Ebrima", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label86.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Label86.Location = New System.Drawing.Point(20, 168)
        Me.Label86.Name = "Label86"
        Me.Label86.Size = New System.Drawing.Size(74, 19)
        Me.Label86.TabIndex = 6
        Me.Label86.Text = "Unit Price"
        '
        'foodsname17
        '
        Me.foodsname17.BackColor = System.Drawing.Color.Azure
        Me.foodsname17.FlatAppearance.BorderSize = 0
        Me.foodsname17.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent
        Me.foodsname17.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.foodsname17.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.foodsname17.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.foodsname17.Font = New System.Drawing.Font("Ebrima", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.foodsname17.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.foodsname17.Location = New System.Drawing.Point(-2, -1)
        Me.foodsname17.Name = "foodsname17"
        Me.foodsname17.Size = New System.Drawing.Size(208, 36)
        Me.foodsname17.TabIndex = 5
        Me.foodsname17.Text = "Name"
        Me.foodsname17.UseVisualStyleBackColor = False
        '
        'foodprice17
        '
        Me.foodprice17.AutoSize = True
        Me.foodprice17.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.foodprice17.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.foodprice17.Location = New System.Drawing.Point(50, 193)
        Me.foodprice17.Name = "foodprice17"
        Me.foodprice17.Size = New System.Drawing.Size(49, 20)
        Me.foodprice17.TabIndex = 4
        Me.foodprice17.Text = "00.00"
        '
        'Label88
        '
        Me.Label88.AutoSize = True
        Me.Label88.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label88.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Label88.Location = New System.Drawing.Point(10, 193)
        Me.Label88.Name = "Label88"
        Me.Label88.Size = New System.Drawing.Size(49, 20)
        Me.Label88.TabIndex = 3
        Me.Label88.Text = "GHC "
        '
        'foodqty17
        '
        Me.foodqty17.BackColor = System.Drawing.Color.LightCyan
        Me.foodqty17.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.foodqty17.Font = New System.Drawing.Font("Ebrima", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.foodqty17.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.foodqty17.Location = New System.Drawing.Point(131, 188)
        Me.foodqty17.Name = "foodqty17"
        Me.foodqty17.Size = New System.Drawing.Size(51, 31)
        Me.foodqty17.TabIndex = 1
        Me.foodqty17.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.foodqty17.ThousandsSeparator = True
        '
        'foodimg17
        '
        Me.foodimg17.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.foodimg17.FlatAppearance.BorderSize = 0
        Me.foodimg17.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.foodimg17.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.foodimg17.Location = New System.Drawing.Point(14, 35)
        Me.foodimg17.Name = "foodimg17"
        Me.foodimg17.Size = New System.Drawing.Size(176, 123)
        Me.foodimg17.TabIndex = 0
        Me.foodimg17.UseVisualStyleBackColor = True
        '
        'foodtypepanel16
        '
        Me.foodtypepanel16.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.foodtypepanel16.Controls.Add(Me.Label89)
        Me.foodtypepanel16.Controls.Add(Me.Label90)
        Me.foodtypepanel16.Controls.Add(Me.foodsname16)
        Me.foodtypepanel16.Controls.Add(Me.foodprice16)
        Me.foodtypepanel16.Controls.Add(Me.Label92)
        Me.foodtypepanel16.Controls.Add(Me.foodqty16)
        Me.foodtypepanel16.Controls.Add(Me.foodimg16)
        Me.foodtypepanel16.Cursor = System.Windows.Forms.Cursors.Hand
        Me.foodtypepanel16.Location = New System.Drawing.Point(874, 893)
        Me.foodtypepanel16.Name = "foodtypepanel16"
        Me.foodtypepanel16.Size = New System.Drawing.Size(207, 226)
        Me.foodtypepanel16.TabIndex = 19
        Me.foodtypepanel16.Visible = False
        '
        'Label89
        '
        Me.Label89.AutoSize = True
        Me.Label89.Font = New System.Drawing.Font("Ebrima", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label89.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Label89.Location = New System.Drawing.Point(127, 166)
        Me.Label89.Name = "Label89"
        Me.Label89.Size = New System.Drawing.Size(66, 19)
        Me.Label89.TabIndex = 7
        Me.Label89.Text = "Quantity"
        '
        'Label90
        '
        Me.Label90.AutoSize = True
        Me.Label90.Font = New System.Drawing.Font("Ebrima", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label90.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Label90.Location = New System.Drawing.Point(20, 168)
        Me.Label90.Name = "Label90"
        Me.Label90.Size = New System.Drawing.Size(74, 19)
        Me.Label90.TabIndex = 6
        Me.Label90.Text = "Unit Price"
        '
        'foodsname16
        '
        Me.foodsname16.BackColor = System.Drawing.Color.Azure
        Me.foodsname16.FlatAppearance.BorderSize = 0
        Me.foodsname16.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent
        Me.foodsname16.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.foodsname16.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.foodsname16.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.foodsname16.Font = New System.Drawing.Font("Ebrima", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.foodsname16.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.foodsname16.Location = New System.Drawing.Point(-2, -1)
        Me.foodsname16.Name = "foodsname16"
        Me.foodsname16.Size = New System.Drawing.Size(208, 36)
        Me.foodsname16.TabIndex = 5
        Me.foodsname16.Text = "Name"
        Me.foodsname16.UseVisualStyleBackColor = False
        '
        'foodprice16
        '
        Me.foodprice16.AutoSize = True
        Me.foodprice16.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.foodprice16.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.foodprice16.Location = New System.Drawing.Point(50, 193)
        Me.foodprice16.Name = "foodprice16"
        Me.foodprice16.Size = New System.Drawing.Size(49, 20)
        Me.foodprice16.TabIndex = 4
        Me.foodprice16.Text = "00.00"
        '
        'Label92
        '
        Me.Label92.AutoSize = True
        Me.Label92.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label92.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Label92.Location = New System.Drawing.Point(10, 193)
        Me.Label92.Name = "Label92"
        Me.Label92.Size = New System.Drawing.Size(49, 20)
        Me.Label92.TabIndex = 3
        Me.Label92.Text = "GHC "
        '
        'foodqty16
        '
        Me.foodqty16.BackColor = System.Drawing.Color.LightCyan
        Me.foodqty16.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.foodqty16.Font = New System.Drawing.Font("Ebrima", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.foodqty16.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.foodqty16.Location = New System.Drawing.Point(131, 188)
        Me.foodqty16.Name = "foodqty16"
        Me.foodqty16.Size = New System.Drawing.Size(51, 31)
        Me.foodqty16.TabIndex = 1
        Me.foodqty16.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.foodqty16.ThousandsSeparator = True
        '
        'foodimg16
        '
        Me.foodimg16.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.foodimg16.FlatAppearance.BorderSize = 0
        Me.foodimg16.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.foodimg16.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.foodimg16.Location = New System.Drawing.Point(14, 35)
        Me.foodimg16.Name = "foodimg16"
        Me.foodimg16.Size = New System.Drawing.Size(176, 123)
        Me.foodimg16.TabIndex = 0
        Me.foodimg16.UseVisualStyleBackColor = True
        '
        'foodtypepanel15
        '
        Me.foodtypepanel15.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.foodtypepanel15.Controls.Add(Me.Label93)
        Me.foodtypepanel15.Controls.Add(Me.Label94)
        Me.foodtypepanel15.Controls.Add(Me.foodsname15)
        Me.foodtypepanel15.Controls.Add(Me.foodprice15)
        Me.foodtypepanel15.Controls.Add(Me.Label96)
        Me.foodtypepanel15.Controls.Add(Me.foodqty15)
        Me.foodtypepanel15.Controls.Add(Me.foodimg15)
        Me.foodtypepanel15.Cursor = System.Windows.Forms.Cursors.Hand
        Me.foodtypepanel15.Location = New System.Drawing.Point(598, 893)
        Me.foodtypepanel15.Name = "foodtypepanel15"
        Me.foodtypepanel15.Size = New System.Drawing.Size(207, 226)
        Me.foodtypepanel15.TabIndex = 18
        Me.foodtypepanel15.Visible = False
        '
        'Label93
        '
        Me.Label93.AutoSize = True
        Me.Label93.Font = New System.Drawing.Font("Ebrima", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label93.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Label93.Location = New System.Drawing.Point(127, 166)
        Me.Label93.Name = "Label93"
        Me.Label93.Size = New System.Drawing.Size(66, 19)
        Me.Label93.TabIndex = 7
        Me.Label93.Text = "Quantity"
        '
        'Label94
        '
        Me.Label94.AutoSize = True
        Me.Label94.Font = New System.Drawing.Font("Ebrima", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label94.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Label94.Location = New System.Drawing.Point(20, 168)
        Me.Label94.Name = "Label94"
        Me.Label94.Size = New System.Drawing.Size(74, 19)
        Me.Label94.TabIndex = 6
        Me.Label94.Text = "Unit Price"
        '
        'foodsname15
        '
        Me.foodsname15.BackColor = System.Drawing.Color.Azure
        Me.foodsname15.FlatAppearance.BorderSize = 0
        Me.foodsname15.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent
        Me.foodsname15.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.foodsname15.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.foodsname15.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.foodsname15.Font = New System.Drawing.Font("Ebrima", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.foodsname15.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.foodsname15.Location = New System.Drawing.Point(-2, -1)
        Me.foodsname15.Name = "foodsname15"
        Me.foodsname15.Size = New System.Drawing.Size(208, 36)
        Me.foodsname15.TabIndex = 5
        Me.foodsname15.Text = "Name"
        Me.foodsname15.UseVisualStyleBackColor = False
        '
        'foodprice15
        '
        Me.foodprice15.AutoSize = True
        Me.foodprice15.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.foodprice15.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.foodprice15.Location = New System.Drawing.Point(50, 193)
        Me.foodprice15.Name = "foodprice15"
        Me.foodprice15.Size = New System.Drawing.Size(49, 20)
        Me.foodprice15.TabIndex = 4
        Me.foodprice15.Text = "00.00"
        '
        'Label96
        '
        Me.Label96.AutoSize = True
        Me.Label96.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label96.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Label96.Location = New System.Drawing.Point(10, 193)
        Me.Label96.Name = "Label96"
        Me.Label96.Size = New System.Drawing.Size(49, 20)
        Me.Label96.TabIndex = 3
        Me.Label96.Text = "GHC "
        '
        'foodqty15
        '
        Me.foodqty15.BackColor = System.Drawing.Color.LightCyan
        Me.foodqty15.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.foodqty15.Font = New System.Drawing.Font("Ebrima", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.foodqty15.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.foodqty15.Location = New System.Drawing.Point(131, 188)
        Me.foodqty15.Name = "foodqty15"
        Me.foodqty15.Size = New System.Drawing.Size(51, 31)
        Me.foodqty15.TabIndex = 1
        Me.foodqty15.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.foodqty15.ThousandsSeparator = True
        '
        'foodimg15
        '
        Me.foodimg15.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.foodimg15.FlatAppearance.BorderSize = 0
        Me.foodimg15.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.foodimg15.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.foodimg15.Location = New System.Drawing.Point(14, 35)
        Me.foodimg15.Name = "foodimg15"
        Me.foodimg15.Size = New System.Drawing.Size(176, 123)
        Me.foodimg15.TabIndex = 0
        Me.foodimg15.UseVisualStyleBackColor = True
        '
        'foodtypepanel14
        '
        Me.foodtypepanel14.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.foodtypepanel14.Controls.Add(Me.Label97)
        Me.foodtypepanel14.Controls.Add(Me.Label98)
        Me.foodtypepanel14.Controls.Add(Me.foodsname14)
        Me.foodtypepanel14.Controls.Add(Me.foodprice14)
        Me.foodtypepanel14.Controls.Add(Me.Label100)
        Me.foodtypepanel14.Controls.Add(Me.foodqty14)
        Me.foodtypepanel14.Controls.Add(Me.foodimg14)
        Me.foodtypepanel14.Cursor = System.Windows.Forms.Cursors.Hand
        Me.foodtypepanel14.Location = New System.Drawing.Point(326, 893)
        Me.foodtypepanel14.Name = "foodtypepanel14"
        Me.foodtypepanel14.Size = New System.Drawing.Size(207, 226)
        Me.foodtypepanel14.TabIndex = 17
        Me.foodtypepanel14.Visible = False
        '
        'Label97
        '
        Me.Label97.AutoSize = True
        Me.Label97.Font = New System.Drawing.Font("Ebrima", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label97.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Label97.Location = New System.Drawing.Point(127, 166)
        Me.Label97.Name = "Label97"
        Me.Label97.Size = New System.Drawing.Size(66, 19)
        Me.Label97.TabIndex = 7
        Me.Label97.Text = "Quantity"
        '
        'Label98
        '
        Me.Label98.AutoSize = True
        Me.Label98.Font = New System.Drawing.Font("Ebrima", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label98.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Label98.Location = New System.Drawing.Point(20, 168)
        Me.Label98.Name = "Label98"
        Me.Label98.Size = New System.Drawing.Size(74, 19)
        Me.Label98.TabIndex = 6
        Me.Label98.Text = "Unit Price"
        '
        'foodsname14
        '
        Me.foodsname14.BackColor = System.Drawing.Color.Azure
        Me.foodsname14.FlatAppearance.BorderSize = 0
        Me.foodsname14.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent
        Me.foodsname14.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.foodsname14.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.foodsname14.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.foodsname14.Font = New System.Drawing.Font("Ebrima", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.foodsname14.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.foodsname14.Location = New System.Drawing.Point(-2, -1)
        Me.foodsname14.Name = "foodsname14"
        Me.foodsname14.Size = New System.Drawing.Size(208, 36)
        Me.foodsname14.TabIndex = 5
        Me.foodsname14.Text = "Name"
        Me.foodsname14.UseVisualStyleBackColor = False
        '
        'foodprice14
        '
        Me.foodprice14.AutoSize = True
        Me.foodprice14.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.foodprice14.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.foodprice14.Location = New System.Drawing.Point(50, 193)
        Me.foodprice14.Name = "foodprice14"
        Me.foodprice14.Size = New System.Drawing.Size(49, 20)
        Me.foodprice14.TabIndex = 4
        Me.foodprice14.Text = "00.00"
        '
        'Label100
        '
        Me.Label100.AutoSize = True
        Me.Label100.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label100.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Label100.Location = New System.Drawing.Point(10, 193)
        Me.Label100.Name = "Label100"
        Me.Label100.Size = New System.Drawing.Size(49, 20)
        Me.Label100.TabIndex = 3
        Me.Label100.Text = "GHC "
        '
        'foodqty14
        '
        Me.foodqty14.BackColor = System.Drawing.Color.LightCyan
        Me.foodqty14.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.foodqty14.Font = New System.Drawing.Font("Ebrima", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.foodqty14.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.foodqty14.Location = New System.Drawing.Point(131, 188)
        Me.foodqty14.Name = "foodqty14"
        Me.foodqty14.Size = New System.Drawing.Size(51, 31)
        Me.foodqty14.TabIndex = 1
        Me.foodqty14.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.foodqty14.ThousandsSeparator = True
        '
        'foodimg14
        '
        Me.foodimg14.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.foodimg14.FlatAppearance.BorderSize = 0
        Me.foodimg14.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.foodimg14.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.foodimg14.Location = New System.Drawing.Point(14, 35)
        Me.foodimg14.Name = "foodimg14"
        Me.foodimg14.Size = New System.Drawing.Size(176, 123)
        Me.foodimg14.TabIndex = 0
        Me.foodimg14.UseVisualStyleBackColor = True
        '
        'foodtypepanel13
        '
        Me.foodtypepanel13.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.foodtypepanel13.Controls.Add(Me.Label101)
        Me.foodtypepanel13.Controls.Add(Me.Label102)
        Me.foodtypepanel13.Controls.Add(Me.foodsname13)
        Me.foodtypepanel13.Controls.Add(Me.foodprice13)
        Me.foodtypepanel13.Controls.Add(Me.Label104)
        Me.foodtypepanel13.Controls.Add(Me.foodqty13)
        Me.foodtypepanel13.Controls.Add(Me.foodimg13)
        Me.foodtypepanel13.Cursor = System.Windows.Forms.Cursors.Hand
        Me.foodtypepanel13.Location = New System.Drawing.Point(58, 893)
        Me.foodtypepanel13.Name = "foodtypepanel13"
        Me.foodtypepanel13.Size = New System.Drawing.Size(207, 226)
        Me.foodtypepanel13.TabIndex = 16
        Me.foodtypepanel13.Visible = False
        '
        'Label101
        '
        Me.Label101.AutoSize = True
        Me.Label101.Font = New System.Drawing.Font("Ebrima", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label101.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Label101.Location = New System.Drawing.Point(127, 166)
        Me.Label101.Name = "Label101"
        Me.Label101.Size = New System.Drawing.Size(66, 19)
        Me.Label101.TabIndex = 7
        Me.Label101.Text = "Quantity"
        '
        'Label102
        '
        Me.Label102.AutoSize = True
        Me.Label102.Font = New System.Drawing.Font("Ebrima", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label102.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Label102.Location = New System.Drawing.Point(20, 168)
        Me.Label102.Name = "Label102"
        Me.Label102.Size = New System.Drawing.Size(74, 19)
        Me.Label102.TabIndex = 6
        Me.Label102.Text = "Unit Price"
        '
        'foodsname13
        '
        Me.foodsname13.BackColor = System.Drawing.Color.Azure
        Me.foodsname13.FlatAppearance.BorderSize = 0
        Me.foodsname13.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent
        Me.foodsname13.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.foodsname13.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.foodsname13.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.foodsname13.Font = New System.Drawing.Font("Ebrima", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.foodsname13.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.foodsname13.Location = New System.Drawing.Point(-2, -1)
        Me.foodsname13.Name = "foodsname13"
        Me.foodsname13.Size = New System.Drawing.Size(208, 36)
        Me.foodsname13.TabIndex = 5
        Me.foodsname13.Text = "Name"
        Me.foodsname13.UseVisualStyleBackColor = False
        '
        'foodprice13
        '
        Me.foodprice13.AutoSize = True
        Me.foodprice13.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.foodprice13.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.foodprice13.Location = New System.Drawing.Point(50, 193)
        Me.foodprice13.Name = "foodprice13"
        Me.foodprice13.Size = New System.Drawing.Size(49, 20)
        Me.foodprice13.TabIndex = 4
        Me.foodprice13.Text = "00.00"
        '
        'Label104
        '
        Me.Label104.AutoSize = True
        Me.Label104.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label104.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Label104.Location = New System.Drawing.Point(10, 193)
        Me.Label104.Name = "Label104"
        Me.Label104.Size = New System.Drawing.Size(49, 20)
        Me.Label104.TabIndex = 3
        Me.Label104.Text = "GHC "
        '
        'foodqty13
        '
        Me.foodqty13.BackColor = System.Drawing.Color.LightCyan
        Me.foodqty13.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.foodqty13.Font = New System.Drawing.Font("Ebrima", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.foodqty13.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.foodqty13.Location = New System.Drawing.Point(131, 188)
        Me.foodqty13.Name = "foodqty13"
        Me.foodqty13.Size = New System.Drawing.Size(51, 31)
        Me.foodqty13.TabIndex = 1
        Me.foodqty13.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.foodqty13.ThousandsSeparator = True
        '
        'foodimg13
        '
        Me.foodimg13.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.foodimg13.FlatAppearance.BorderSize = 0
        Me.foodimg13.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.foodimg13.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.foodimg13.Location = New System.Drawing.Point(14, 35)
        Me.foodimg13.Name = "foodimg13"
        Me.foodimg13.Size = New System.Drawing.Size(176, 123)
        Me.foodimg13.TabIndex = 0
        Me.foodimg13.UseVisualStyleBackColor = True
        '
        'DiCE
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.AutoSize = True
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(1350, 731)
        Me.ControlBox = False
        Me.Controls.Add(Me.closeicon)
        Me.Controls.Add(Me.btnpopup)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.statusbar)
        Me.Controls.Add(Me.titlebar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MinimizeBox = False
        Me.Name = "DiCE"
        Me.RightToLeftLayout = True
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "DiCE Menu Application "
        Me.TopMost = True
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.statusbar.ResumeLayout(False)
        Me.statusbar.PerformLayout()
        Me.loginpanel.ResumeLayout(False)
        Me.loginpanel.PerformLayout()
        Me.adminpanel.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.adminadduserpanel.ResumeLayout(False)
        Me.adminadduserpanel.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.txtnewmaritalstat.ResumeLayout(False)
        Me.txtnewmaritalstat.PerformLayout()
        Me.adminsearchuserpanel.ResumeLayout(False)
        Me.updatepanel.ResumeLayout(False)
        Me.updatepanel.PerformLayout()
        Me.genderpanel.ResumeLayout(False)
        Me.genderpanel.PerformLayout()
        Me.maritalstatpanel.ResumeLayout(False)
        Me.maritalstatpanel.PerformLayout()
        Me.numbersearchpanel.ResumeLayout(False)
        Me.numbersearchpanel.PerformLayout()
        Me.userspanel.ResumeLayout(False)
        Me.waiterpanel.ResumeLayout(False)
        Me.Panel6.ResumeLayout(False)
        Me.foodspanel.ResumeLayout(False)
        Me.foodtypepanel1.ResumeLayout(False)
        Me.foodtypepanel1.PerformLayout()
        CType(Me.foodqty1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.foodtypepanel12.ResumeLayout(False)
        Me.foodtypepanel12.PerformLayout()
        CType(Me.foodqty12, System.ComponentModel.ISupportInitialize).EndInit()
        Me.foodtypepanel11.ResumeLayout(False)
        Me.foodtypepanel11.PerformLayout()
        CType(Me.foodqty11, System.ComponentModel.ISupportInitialize).EndInit()
        Me.foodtypepanel10.ResumeLayout(False)
        Me.foodtypepanel10.PerformLayout()
        CType(Me.foodqty10, System.ComponentModel.ISupportInitialize).EndInit()
        Me.foodtypepanel9.ResumeLayout(False)
        Me.foodtypepanel9.PerformLayout()
        CType(Me.foodqty9, System.ComponentModel.ISupportInitialize).EndInit()
        Me.foodtypepanel8.ResumeLayout(False)
        Me.foodtypepanel8.PerformLayout()
        CType(Me.NumericUpDown7, System.ComponentModel.ISupportInitialize).EndInit()
        Me.foodtypepanel7.ResumeLayout(False)
        Me.foodtypepanel7.PerformLayout()
        CType(Me.foodqty7, System.ComponentModel.ISupportInitialize).EndInit()
        Me.foodtypepanel6.ResumeLayout(False)
        Me.foodtypepanel6.PerformLayout()
        CType(Me.foodqty6, System.ComponentModel.ISupportInitialize).EndInit()
        Me.foodtypepanel4.ResumeLayout(False)
        Me.foodtypepanel4.PerformLayout()
        CType(Me.foodqty4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.foodtypepanel2.ResumeLayout(False)
        Me.foodtypepanel2.PerformLayout()
        CType(Me.foodqty2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.foodtypepanel5.ResumeLayout(False)
        Me.foodtypepanel5.PerformLayout()
        CType(Me.foodqty5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.foodtypepanel3.ResumeLayout(False)
        Me.foodtypepanel3.PerformLayout()
        CType(Me.foodqty3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.foodsDGV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.signuppanel.ResumeLayout(False)
        Me.signuppanel.PerformLayout()
        Me.foodtypepanel20.ResumeLayout(False)
        Me.foodtypepanel20.PerformLayout()
        CType(Me.foodqty20, System.ComponentModel.ISupportInitialize).EndInit()
        Me.foodtypepanel19.ResumeLayout(False)
        Me.foodtypepanel19.PerformLayout()
        CType(Me.foodqty19, System.ComponentModel.ISupportInitialize).EndInit()
        Me.foodtypepanel18.ResumeLayout(False)
        Me.foodtypepanel18.PerformLayout()
        CType(Me.foodqty18, System.ComponentModel.ISupportInitialize).EndInit()
        Me.foodtypepanel17.ResumeLayout(False)
        Me.foodtypepanel17.PerformLayout()
        CType(Me.foodqty17, System.ComponentModel.ISupportInitialize).EndInit()
        Me.foodtypepanel16.ResumeLayout(False)
        Me.foodtypepanel16.PerformLayout()
        CType(Me.foodqty16, System.ComponentModel.ISupportInitialize).EndInit()
        Me.foodtypepanel15.ResumeLayout(False)
        Me.foodtypepanel15.PerformLayout()
        CType(Me.foodqty15, System.ComponentModel.ISupportInitialize).EndInit()
        Me.foodtypepanel14.ResumeLayout(False)
        Me.foodtypepanel14.PerformLayout()
        CType(Me.foodqty14, System.ComponentModel.ISupportInitialize).EndInit()
        Me.foodtypepanel13.ResumeLayout(False)
        Me.foodtypepanel13.PerformLayout()
        CType(Me.foodqty13, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents systemtime As System.Windows.Forms.Timer
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtloginusername As System.Windows.Forms.TextBox
    Friend WithEvents txtloginpassword As System.Windows.Forms.TextBox
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
    Friend WithEvents tabadminviewuserlogs As System.Windows.Forms.Button
    Friend WithEvents tabadminsearchuser As System.Windows.Forms.Button
    Friend WithEvents tabadminadduser As System.Windows.Forms.Button
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
    Friend WithEvents titlebar As MenuStrip
    Friend WithEvents adminactive1 As Button
    Friend WithEvents adminactive4 As Button
    Friend WithEvents adminactive3 As Button
    Friend WithEvents adminactive2 As Button
    Friend WithEvents closeicon As Panel
    Friend WithEvents waiterpanel As Panel
    Friend WithEvents Panel6 As Panel
    Friend WithEvents foodspanel As Panel
    Friend WithEvents drinkspanel As Panel
    Friend WithEvents waiteractive6 As Button
    Friend WithEvents tabwaitercancel As Button
    Friend WithEvents tabwaiterfoods As Button
    Friend WithEvents waiteractive5 As Button
    Friend WithEvents waiteractive1 As Button
    Friend WithEvents tabwaitersummary As Button
    Friend WithEvents tabwaiterdrinks As Button
    Friend WithEvents waiteractive4 As Button
    Friend WithEvents waiteractive2 As Button
    Friend WithEvents tabwaitdessert As Button
    Friend WithEvents tabwaiterpastries As Button
    Friend WithEvents waiteractive3 As Button
    Friend WithEvents invalidlogintimer As Timer
    Friend WithEvents lblinvalidmessage As Label
    Friend WithEvents foodsDGV As DataGridView
    Friend WithEvents foodtypepanel4 As Panel
    Friend WithEvents Label39 As Label
    Friend WithEvents Label41 As Label
    Friend WithEvents foodsname4 As Button
    Friend WithEvents foodprice4 As Label
    Friend WithEvents Label51 As Label
    Friend WithEvents foodqty4 As NumericUpDown
    Friend WithEvents foodimg4 As Button
    Friend WithEvents foodtypepanel2 As Panel
    Friend WithEvents Label43 As Label
    Friend WithEvents Label44 As Label
    Friend WithEvents foodsname2 As Button
    Friend WithEvents foodprice2 As Label
    Friend WithEvents Label46 As Label
    Friend WithEvents foodqty2 As NumericUpDown
    Friend WithEvents foodimg2 As Button
    Friend WithEvents foodtypepanel5 As Panel
    Friend WithEvents Label52 As Label
    Friend WithEvents Label53 As Label
    Friend WithEvents foodsname5 As Button
    Friend WithEvents foodprice5 As Label
    Friend WithEvents Label55 As Label
    Friend WithEvents foodqty5 As NumericUpDown
    Friend WithEvents foodimg5 As Button
    Friend WithEvents foodtypepanel3 As Panel
    Friend WithEvents Label47 As Label
    Friend WithEvents Label48 As Label
    Friend WithEvents foodsname3 As Button
    Friend WithEvents foodprice3 As Label
    Friend WithEvents Label50 As Label
    Friend WithEvents foodqty3 As NumericUpDown
    Friend WithEvents foodimg3 As Button
    Friend WithEvents foodtypepanel8 As Panel
    Friend WithEvents Label60 As Label
    Friend WithEvents Label61 As Label
    Friend WithEvents foodsname8 As Button
    Friend WithEvents foodprice8 As Label
    Friend WithEvents Label63 As Label
    Friend WithEvents NumericUpDown7 As NumericUpDown
    Friend WithEvents foodimg8 As Button
    Friend WithEvents foodtypepanel7 As Panel
    Friend WithEvents Label56 As Label
    Friend WithEvents Label57 As Label
    Friend WithEvents foodsname7 As Button
    Friend WithEvents foodprice7 As Label
    Friend WithEvents Label59 As Label
    Friend WithEvents foodqty7 As NumericUpDown
    Friend WithEvents foodimg7 As Button
    Friend WithEvents foodtypepanel6 As Panel
    Friend WithEvents Label42 As Label
    Friend WithEvents Label45 As Label
    Friend WithEvents foodsname6 As Button
    Friend WithEvents foodprice6 As Label
    Friend WithEvents Label54 As Label
    Friend WithEvents foodqty6 As NumericUpDown
    Friend WithEvents foodtypepanel10 As Panel
    Friend WithEvents Label65 As Label
    Friend WithEvents Label66 As Label
    Friend WithEvents foodsname10 As Button
    Friend WithEvents foodprice10 As Label
    Friend WithEvents Label68 As Label
    Friend WithEvents foodqty10 As NumericUpDown
    Friend WithEvents foodimg10 As Button
    Friend WithEvents foodtypepanel9 As Panel
    Friend WithEvents Label49 As Label
    Friend WithEvents Label58 As Label
    Friend WithEvents foodsname9 As Button
    Friend WithEvents foodprice9 As Label
    Friend WithEvents Label64 As Label
    Friend WithEvents foodqty9 As NumericUpDown
    Friend WithEvents foodimg9 As Button
    Friend WithEvents foodtypepanel11 As Panel
    Friend WithEvents Label62 As Label
    Friend WithEvents Label67 As Label
    Friend WithEvents foodsname11 As Button
    Friend WithEvents foodprice11 As Label
    Friend WithEvents Label70 As Label
    Friend WithEvents foodqty11 As NumericUpDown
    Friend WithEvents foodimg11 As Button
    Friend WithEvents foodtypepanel12 As Panel
    Friend WithEvents Label69 As Label
    Friend WithEvents Label71 As Label
    Friend WithEvents foodsname12 As Button
    Friend WithEvents foodprice12 As Label
    Friend WithEvents Label73 As Label
    Friend WithEvents foodqty12 As NumericUpDown
    Friend WithEvents foodimg12 As Button
    'Friend WithEvents DiCEDatabaseDataSet As DiCE.DiCEDatabaseDataSet
    Friend WithEvents foodimg6 As Button
    Friend WithEvents foodtypepanel1 As Panel
    Friend WithEvents Label40 As Label
    Friend WithEvents Label38 As Label
    Friend WithEvents foodsname1 As Button
    Friend WithEvents foodprice1 As Label
    Friend WithEvents Label33 As Label
    Friend WithEvents foodqty1 As NumericUpDown
    Friend WithEvents foodimg1 As Button
    Friend WithEvents foodtypepanel20 As Panel
    Friend WithEvents Label72 As Label
    Friend WithEvents Label74 As Label
    Friend WithEvents foodsname20 As Button
    Friend WithEvents foodprice20 As Label
    Friend WithEvents Label76 As Label
    Friend WithEvents foodqty20 As NumericUpDown
    Friend WithEvents foodimg20 As Button
    Friend WithEvents foodtypepanel19 As Panel
    Friend WithEvents Label77 As Label
    Friend WithEvents Label78 As Label
    Friend WithEvents foodsname19 As Button
    Friend WithEvents foodprice19 As Label
    Friend WithEvents Label80 As Label
    Friend WithEvents foodqty19 As NumericUpDown
    Friend WithEvents foodimg19 As Button
    Friend WithEvents foodtypepanel18 As Panel
    Friend WithEvents Label81 As Label
    Friend WithEvents Label82 As Label
    Friend WithEvents foodsname18 As Button
    Friend WithEvents foodprice18 As Label
    Friend WithEvents Label84 As Label
    Friend WithEvents foodqty18 As NumericUpDown
    Friend WithEvents foodimg18 As Button
    Friend WithEvents foodtypepanel17 As Panel
    Friend WithEvents Label85 As Label
    Friend WithEvents Label86 As Label
    Friend WithEvents foodsname17 As Button
    Friend WithEvents foodprice17 As Label
    Friend WithEvents Label88 As Label
    Friend WithEvents foodqty17 As NumericUpDown
    Friend WithEvents foodimg17 As Button
    Friend WithEvents foodtypepanel16 As Panel
    Friend WithEvents Label89 As Label
    Friend WithEvents Label90 As Label
    Friend WithEvents foodsname16 As Button
    Friend WithEvents foodprice16 As Label
    Friend WithEvents Label92 As Label
    Friend WithEvents foodqty16 As NumericUpDown
    Friend WithEvents foodimg16 As Button
    Friend WithEvents foodtypepanel15 As Panel
    Friend WithEvents Label93 As Label
    Friend WithEvents Label94 As Label
    Friend WithEvents foodsname15 As Button
    Friend WithEvents foodprice15 As Label
    Friend WithEvents Label96 As Label
    Friend WithEvents foodqty15 As NumericUpDown
    Friend WithEvents foodimg15 As Button
    Friend WithEvents foodtypepanel14 As Panel
    Friend WithEvents Label97 As Label
    Friend WithEvents Label98 As Label
    Friend WithEvents foodsname14 As Button
    Friend WithEvents foodprice14 As Label
    Friend WithEvents Label100 As Label
    Friend WithEvents foodqty14 As NumericUpDown
    Friend WithEvents foodimg14 As Button
    Friend WithEvents foodtypepanel13 As Panel
    Friend WithEvents Label101 As Label
    Friend WithEvents Label102 As Label
    Friend WithEvents foodsname13 As Button
    Friend WithEvents foodprice13 As Label
    Friend WithEvents Label104 As Label
    Friend WithEvents foodqty13 As NumericUpDown
    Friend WithEvents foodimg13 As Button
End Class
