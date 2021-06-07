Imports System.Data.OleDb
Imports System.Windows.Forms.DockStyle
Public Class DiCE
    Dim con As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\theod\Desktop\  \Projects\Visual Basic\DiCE\DiCEDatabase.accdb"
    Dim ds As New DataSet
    Dim da As OleDbDataAdapter
    Dim SQLstmtA, SQLstmtC, SQLstmtM, SQLstmtW As String
    Dim SQLstmtnewW, SQLstmtnewC, SQLstmtnewM, SQLstmtnewA As String
    Dim SQLstmtUW, SQLstmtUC, SQLstmtUM, SQLstmtUA As String
    Dim Retrieve As Integer
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles systemtime.Tick
        lbldate.Text = Date.Now.ToShortDateString
        lbltime.Text = TimeOfDay
    End Sub
    Private Sub FormDiCE_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        btnlogout.Hide()
        Timer1_Tick(sender, e)
        userspanel.Hide()
        txtpassword.Clear()
        txtusername.Clear()
        txtusername.Focus()
        loginpanel.Dock = Fill
        lbluser.Text = "User"
        lblrole.Text = "role"
    End Sub
    'DISABLING SYMBOLS AND SPACE IN THE USERNAME TEXTBOX
    Private Sub txtusername_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtusername.KeyPress
        If Char.IsLetterOrDigit(e.KeyChar) Or Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub
    Private Sub btnsignup_Click(sender As Object, e As EventArgs) Handles btnsignup.Click
        signuppanel.Dock = Fill
        signuppanel.Show()
        loginpanel.Hide()
        btntologin.Show()
    End Sub
    'THE LOGIN PROCESS
    Private Sub btnlogin_Click(sender As Object, e As EventArgs) Handles btnlogin.Click
        If txtpassword.Text <> "" And txtusername.Text <> "" Then
            Try
                SQLstmtA = "Select * from Administrator_Login where User_Name = '" & txtusername.Text & "' and Password = '" & txtpassword.Text & "'"
                SQLstmtC = "Select * from Chef_Login where User_Name = '" & txtusername.Text & "' and Password = '" & txtpassword.Text & "'"
                SQLstmtM = "Select * from ManagerOrSupervisor_Login where User_Name = '" & txtusername.Text & "' and Password = '" & txtpassword.Text & "'"
                SQLstmtW = "Select * from WaiterOrWaitress_Login where User_Name = '" & txtusername.Text & "' and Password = '" & txtpassword.Text & "'"
                Dim mycon As New OleDbConnection(con)
                Dim mycmdA As New OleDbCommand(SQLstmtA, mycon)
                Dim mycmdC As New OleDbCommand(SQLstmtC, mycon)
                Dim mycmdM As New OleDbCommand(SQLstmtM, mycon)
                Dim mycmdW As New OleDbCommand(SQLstmtW, mycon)
                mycmdA.Connection.Open()
                Dim myredA As OleDbDataReader = mycmdA.ExecuteReader(CommandBehavior.CloseConnection)
                Dim myredC As OleDbDataReader = mycmdC.ExecuteReader(CommandBehavior.CloseConnection)
                Dim myredM As OleDbDataReader = mycmdM.ExecuteReader(CommandBehavior.CloseConnection)
                Dim myredW As OleDbDataReader = mycmdW.ExecuteReader(CommandBehavior.CloseConnection)

                If myredA.Read() Then
                    txtid.Text = myredA.Item("ID").ToString
                ElseIf myredC.Read() Then
                    txtid.Text = myredC.Item("ID").ToString
                ElseIf myredM.Read() Then
                    txtid.Text = myredM.Item("ID").ToString
                ElseIf myredW.Read() Then
                    txtid.Text = myredW.Item("ID").ToString
                End If

                If myredA.HasRows Then
                    If StrComp(txtusername.Text, myredA.Item("User_Name").ToString, CompareMethod.Binary) _
                        Or StrComp(txtpassword.Text, myredA.Item("Password").ToString(), CompareMethod.Binary) Then
                        invalid()
                    Else
                        If myredA.Item("Active").ToString = True Then
                            lblrole.Text = myredA.Item("Role").ToString
                            adminpanel.Dock = Fill
                            adminpanel.Show()
                            LogInProcess()
                            chefpanel.Hide()
                            managerpanel.Hide()
                            waiterpanel.Hide()
                            btnadduser_Click(sender, e)
                        Else
                            MsgBox("User has been Deactivated contact Administrator for Reactivation", MsgBoxStyle.Information, "Access Denied")
                        End If
                    End If
                    mycon.Close()
                    mycmdC.Connection.Open()
                ElseIf myredC.HasRows Then
                    If StrComp(txtusername.Text, myredC.Item("User_Name").ToString, CompareMethod.Binary) _
                       Or StrComp(txtpassword.Text, myredC.Item("Password").ToString(), CompareMethod.Binary) Then
                        invalid()
                    Else
                        If myredC.Item("Active").ToString = True Then
                            lblrole.Text = myredC.Item("Role").ToString
                            chefpanel.Dock = Fill
                            chefpanel.Show()
                            adminpanel.Hide()
                            managerpanel.Hide()
                            waiterpanel.Hide()
                            LogInProcess()
                        Else
                            MsgBox("User has been Deactivated contact Administrator for Reactivation", MsgBoxStyle.Information, "Access Denied")
                        End If
                    End If
                    mycon.Close()
                    mycmdM.Connection.Open()
                ElseIf myredM.HasRows Then
                    If StrComp(txtusername.Text, myredM.Item("User_Name").ToString, CompareMethod.Binary) _
                       Or StrComp(txtpassword.Text, myredM.Item("Password").ToString(), CompareMethod.Binary) Then
                        invalid()
                    Else
                        If myredM.Item("Active").ToString = True Then
                            lblrole.Text = myredM.Item("Role").ToString
                            managerpanel.Dock = Fill
                            managerpanel.Show()
                            adminpanel.Hide()
                            chefpanel.Hide()
                            waiterpanel.Hide()
                            LogInProcess()
                        Else
                            MsgBox("User has been Deactivated, contact Administrator for Reactivation", MsgBoxStyle.Information, "Access Denied")
                        End If
                    End If
                    mycon.Close()
                    mycmdW.Connection.Open()
                ElseIf myredW.HasRows Then
                    If StrComp(txtusername.Text, myredW.Item("User_Name").ToString, CompareMethod.Binary) _
                       Or StrComp(txtpassword.Text, myredW.Item("Password").ToString(), CompareMethod.Binary) Then
                        invalid()
                    Else
                        If myredW.Item("Active").ToString = True Then
                            lblrole.Text = myredW.Item("Role").ToString
                            waiterpanel.Dock = Fill
                            waiterpanel.Show()
                            adminpanel.Hide()
                            chefpanel.Hide()
                            managerpanel.Hide()
                            LogInProcess()
                        Else
                            MsgBox("User is inactivate contact Administrator for Reactivation", MsgBoxStyle.Information, "Access Denied")
                        End If
                    End If
                    mycon.Close()
                Else
                    invalid()
                End If
            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try
        ElseIf txtusername.Text = "" And txtpassword.Text = "" Then
            btnpopup.BackColor = Color.LightCoral
            btnpopup.ForeColor = Color.Linen
            btnpopup.Text = "User Name and Password Fields are Empty"
            btnpopup.Show()
            PopOut()
            txtusername.Focus()
        ElseIf txtusername.Text = "" Then
            btnpopup.BackColor = Color.LightCoral
            btnpopup.ForeColor = Color.Linen
            btnpopup.Text = "The User Name Field is Empty "
            btnpopup.Show()
            PopOut()
            txtusername.Focus()
        ElseIf txtpassword.Text = "" Then
            btnpopup.BackColor = Color.LightCoral
            btnpopup.ForeColor = Color.Linen
            btnpopup.Text = "The Password Fiels is Empty"
            btnpopup.Show()
            PopOut()
            txtpassword.Focus()
        End If
    End Sub
    'HIDES THE POPUP BUTTON AFTER 3 SECONDS
    Public Sub PopOut()
        buttonhidetimer.Enabled = True
        buttonhidetimer.Interval = 3000
    End Sub
    'CALL IF LOGIN IS SUCCESSFUL
    Public Sub LogInProcess()
        userspanel.Dock = Fill
        userspanel.Show()
        lbluser.Text = txtusername.Text
        loginpanel.Hide()
        btnlogout.Show()
        btnpopup.Show()
        btnpopup.BackColor = Color.Aquamarine
        btnpopup.ForeColor = Color.DodgerBlue
        btnpopup.Text = "Login was Successful"
        PopOut()
    End Sub
    'CALL IF LOGIN DETAILS ARE INVAID
    Public Sub invalid()
        btnpopup.BackColor = Color.LightCoral
        btnpopup.ForeColor = Color.Linen
        btnpopup.Text = "Invalid Username or Password"
        btnpopup.Show()
        PopOut()
        txtusername.Clear()
        txtpassword.Clear()
        txtusername.Focus()
    End Sub
    'THE LOG OUT BUTTON
    Private Sub btnlogout_Click(sender As Object, e As EventArgs) Handles btnlogout.Click
        btnlogout.Hide()
        userspanel.Hide()
        loginpanel.Show()
        btnpopup.Show()
        btnpopup.BackColor = Color.Aquamarine
        btnpopup.ForeColor = Color.DodgerBlue
        btnpopup.Text = "LogOut was Successful"
        PopOut()
        FormDiCE_Load(sender, e)
    End Sub
    'HIDES THE POPUP WHEN CLICKED
    Private Sub btnpopup_Click(sender As Object, e As EventArgs) Handles btnpopup.Click
        btnpopup.Hide()
    End Sub
    'TIMER FOR POP UP
    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles buttonhidetimer.Tick
        btnpopup.Hide()
    End Sub
    'CALL WHEN NEW USER RECORDS SAVE SUCCESSFULY
    Public Sub newrecordsaved()
        btnpopup.BackColor = Color.Aquamarine
        btnpopup.ForeColor = Color.DodgerBlue
        btnpopup.Show()
        btnpopup.Text = "Record Successfully Saved"
        PopOut()
        txtnewfname.Clear()
        txtnewonames.Clear()
        txtnewlname.Clear()
        txtnewrole.Clear()
        txtnewnumber.Clear()
        txtnewemail.Clear()
        rbtnfemale.Checked = False
        rbtnmale.Checked = False
        'txtnewDOB.Text = ""
        cmbusertype.Text = ""
        chkbnewactive.Checked = True
        If signuppanel.Dock = Fill Then
            txtsignupusername.Clear()
            txtsignpassword.Clear()
            txtsignupreenterpassword.Clear()
            signuppanel.Hide()
            loginpanel.Dock = Fill
            loginpanel.Show()
        End If
    End Sub
    'ADDING NEW USERS TO DATABASE
    Dim gender As String
    Private Sub btnnewusersave_Click(sender As Object, e As EventArgs) Handles btnnewusersave.Click
        If rbtnfemale.Checked = True Then
            gender = "Female"
        ElseIf rbtnmale.Checked = True Then
            gender = "Male"
        End If
        If chkbnewactive.Checked = True Then
                Try
                    If cmbusertype.Text = "Waiter/Waitress" Then
                        SQLstmtnewW = "insert into WaiterOrWaitress_Login([Role],[Mobile_Number],[Email],[First_Name],[Last_Name],[Other_Name(s)],[Gender],[Birth_Date],[Active]) values('" & txtnewrole.Text & "','" & txtnewnumber.Text & "','" & txtnewemail.Text & "','" & txtnewfname.Text & "','" & txtnewlname.Text & "','" & txtnewonames.Text & "','" & gender & "','" & txtnewDOB.Text & "','" & chkbnewactive.CheckState & "')"
                        da = New OleDbDataAdapter(SQLstmtnewW, con)
                        da.Fill(ds, "WaiterOrWaitress_Login")
                        newrecordsaved()
                    ElseIf cmbusertype.Text = "Chef/Cook" Then
                        SQLstmtnewC = "insert into Chef_Login([Role],[Mobile_Number],[Email],[First_Name],[Last_Name],[Other_Name(s)],[Gender],[Birth_Date],[Active]) values('" & txtnewrole.Text & "','" & txtnewnumber.Text & "','" & txtnewemail.Text & "','" & txtnewfname.Text & "','" & txtnewlname.Text & "','" & txtnewonames.Text & "','" & gender & "','" & txtnewDOB.Text & "','" & chkbnewactive.CheckState & "')"
                        da = New OleDbDataAdapter(SQLstmtnewC, con)
                        da.Fill(ds, "Chef_Login")
                        newrecordsaved()
                    ElseIf cmbusertype.Text = "Manager/Supervisor" Then
                        SQLstmtnewM = "insert into ManagerOrSupervisor_Login([Role],[Mobile_Number],[Email],[First_Name],[Last_Name],[Other_Name(s)],[Gender],[Birth_Date],[Active]) values('" & txtnewrole.Text & "','" & txtnewnumber.Text & "','" & txtnewemail.Text & "','" & txtnewfname.Text & "','" & txtnewlname.Text & "','" & txtnewonames.Text & "','" & gender & "','" & txtnewDOB.Text & "','" & chkbnewactive.CheckState & "')"
                        da = New OleDbDataAdapter(SQLstmtnewM, con)
                        da.Fill(ds, "ManagerOrSupervisor_Login")
                        newrecordsaved()
                    ElseIf cmbusertype.Text = "Administrator" Then
                        SQLstmtnewA = "insert into Administrator_Login([Role],[Mobile_Number],[Email],[First_Name],[Last_Name],[Other_Name(s)],[Gender],[Birth_Date],[Active]) values('" & txtnewrole.Text & "','" & txtnewnumber.Text & "','" & txtnewemail.Text & "','" & txtnewfname.Text & "','" & txtnewlname.Text & "','" & txtnewonames.Text & "','" & gender & "','" & txtnewDOB.Text & "','" & chkbnewactive.CheckState & "')"
                        da = New OleDbDataAdapter(SQLstmtnewA, con)
                        da.Fill(ds, "Administrator_Login")
                        newrecordsaved()
                    Else
                        btnpopup.BackColor = Color.LightCoral
                        btnpopup.ForeColor = Color.Linen
                        btnpopup.Show()
                        btnpopup.Text = "'Sign Up As' Field Empty"
                        PopOut()
                        cmbusertype.Focus()
                    End If
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            Else
                btnpopup.BackColor = Color.LightCoral
                btnpopup.ForeColor = Color.Linen
                btnpopup.Show()
                btnpopup.Text = "User must be Active !!!"
                PopOut()
            End If
    End Sub

    
    Private Sub btnadduser_Click(sender As Object, e As EventArgs) Handles btnadduser.Click
        adduserpanel.Dock = Fill
        adduserpanel.Show()
        updateuserpanel.Hide()
        deleteuserpanel.Hide()
        userlogspanel.Hide()
        orderstatspanel.Hide()
    End Sub

    Private Sub btneditorupdateor_Click(sender As Object, e As EventArgs) Handles btneditorupdateor.Click
        btneditorupdateor.Text = "UPDATE"
        If btneditorupdateor.Text = "Edit" Then
            txtupdateid.Enabled = False
            txtupdateemail.Enabled = False
            txtupdatefname.Enabled = False
            txtupdategender.Enabled = False
            txtupdatelname.Enabled = False
            txtupdatenumber.Enabled = False
            txtupdateonames.Enabled = False
            txtupdatepassword.Enabled = False
            txtupdaterole.Enabled = False
            txtupdateusername.Enabled = False
        ElseIf btneditorupdateor.Text = "UPDATE" Then
            txtupdateid.Enabled = False
            txtupdateemail.Enabled = True
            txtupdatefname.Enabled = True
            txtupdategender.Enabled = True
            txtupdatelname.Enabled = True
            txtupdatenumber.Enabled = True
            txtupdateonames.Enabled = True
            txtupdatepassword.Enabled = True
            txtupdaterole.Enabled = True
            txtupdateusername.Enabled = True
            txtupdategender.Enabled = True
            updatedatetimepicker.Enabled = True
            chkbupdateactive.Enabled = True
            If txtupdatepassword.Enabled = True Then
                Try
                    If Retrieve = 1 Then
                        SQLstmtUA = "Update Administrator_Login Set [User_Name] = '" & CStr(txtupdateusername.Text) & "', [Password] = '" & CStr(txtupdatepassword.Text) & "',[Role] = '" & txtupdaterole.Text & "',[Mobile_Number] = '" & txtupdatenumber.Text & "',[Email] = '" & txtupdateemail.Text & "',[First_Name] = '" & txtupdatefname.Text & "',[Last_Name] = '" & txtupdatelname.Text & "',[Other_Name(s)] = '" & txtupdateonames.Text & "',[Gender] = '" & txtupdategender.Text & "',[Birth_Date] = '" & updatedatetimepicker.Text & "',[Active] = '" & chkbupdateactive.CheckState & "'  where CStr([ID]) = '" & CStr(txtupdateretrieveorupdateid.Text) & "'"
                        da = New OleDbDataAdapter(SQLstmtUA, con)
                        da.Fill(ds, "Administrator_Login")
                        newrecordsaved()
                    ElseIf Retrieve = 2 Then
                        SQLstmtUC = "Update Chef_Login Set [User_Name] = '" & CStr(txtupdateusername.Text) & "', [Password] = '" & CStr(txtupdatepassword.Text) & "',[Role] = '" & txtupdaterole.Text & "',[Mobile_Number] = '" & txtupdatenumber.Text & "',[Email] = '" & txtupdateemail.Text & "',[First_Name] = '" & txtupdatefname.Text & "',[Last_Name] = '" & txtupdatelname.Text & "',[Other_Name(s)] = '" & txtupdateonames.Text & "',[Gender] = '" & txtupdategender.Text & "',[Birth_Date] = '" & updatedatetimepicker.Text & "',[Active] = '" & chkbupdateactive.CheckState & "'  where CStr([ID]) = '" & CStr(txtupdateretrieveorupdateid.Text) & "'"
                        da = New OleDbDataAdapter(SQLstmtUC, con)
                        da.Fill(ds, "Chef_Login")
                        newrecordsaved()
                    ElseIf Retrieve = 3 Then
                        SQLstmtUM = "Update ManagerOrSupervisor_Login Set [User_Name] = '" & CStr(txtupdateusername.Text) & "', [Password] = '" & CStr(txtupdatepassword.Text) & "',[Role] = '" & txtupdaterole.Text & "',[Mobile_Number] = '" & txtupdatenumber.Text & "',[Email] = '" & txtupdateemail.Text & "',[First_Name] = '" & txtupdatefname.Text & "',[Last_Name] = '" & txtupdatelname.Text & "',[Other_Name(s)] = '" & txtupdateonames.Text & "',[Gender] = '" & txtupdategender.Text & "',[Birth_Date] = '" & updatedatetimepicker.Text & "',[Active] = '" & chkbupdateactive.CheckState & "'  where CStr([ID]) = '" & CStr(txtupdateretrieveorupdateid.Text) & "'"
                        da = New OleDbDataAdapter(SQLstmtUM, con)
                        da.Fill(ds, "ManagerOrSupervisor_Login")
                        newrecordsaved()
                    ElseIf Retrieve = 4 Then
                        SQLstmtUW = "Update WaiterOrWaitress_Login Set [User_Name] = '" & CStr(txtupdateusername.Text) & "', [Password] = '" & CStr(txtupdatepassword.Text) & "',[Role] = '" & txtupdaterole.Text & "',[Mobile_Number] = '" & txtupdatenumber.Text & "',[Email] = '" & txtupdateemail.Text & "',[First_Name] = '" & txtupdatefname.Text & "',[Last_Name] = '" & txtupdatelname.Text & "',[Other_Name(s)] = '" & txtupdateonames.Text & "',[Gender] = '" & txtupdategender.Text & "',[Birth_Date] = '" & updatedatetimepicker.Text & "',[Active] = '" & chkbupdateactive.CheckState & "'  where CStr([ID]) = '" & CStr(txtupdateretrieveorupdateid.Text) & "'"
                        da = New OleDbDataAdapter(SQLstmtUW, con)
                        da.Fill(ds, "WaiterOrWaitress_Login")
                        newrecordsaved()
                    End If
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            End If
        End If

    End Sub
    Dim SQLstmtCA, SQLstmtCC, SQLstmtCM, SQLstmtCW As String
    Dim SQLstmtCNA, SQLstmtCNC, SQLstmtCNM, SQLstmtCNW As String

    Private Sub btntologin_Click(sender As Object, e As EventArgs) Handles btntologin.Click
        If signuppanel.Dock = Fill Then
            btntologin.Hide()
            signuppanel.Hide()
            loginpanel.Dock = Fill
            loginpanel.Show()
        End If
    End Sub

    Dim NewSignupCon As Integer
    Public Sub eligible()
        txtsignpassword.Enabled = True
        txtsignupreenterpassword.Enabled = True
        txtsignupusername.Enabled = True
        btnsignupeligibilityupdate.Hide()
        txtsignupemail.Enabled = False
        txtsignupmobilenumber.Enabled = False
        btnsignupsave.Visible = True
        txtsignupusername.Focus()
        lblsignupemail.Text = "Email"
        lblsignupmobilenumber.Text = "Mobile Number"
    End Sub
    Public Sub ineligible()
        btnpopup.Show()
        btnpopup.BackColor = Color.LightCoral
        btnpopup.ForeColor = Color.Linen
        btnpopup.Text = "User Name and password Alredy Exist "
        txtsignupmobilenumber.Clear()
        txtsignupemail.Clear()
        txtsignupmobilenumber.Focus()
        PopOut()

    End Sub
    Private Sub btnsignupeligibilitysignup_Click(sender As Object, e As EventArgs) Handles btnsignupeligibilityupdate.Click
        If txtsignupmobilenumber.Text <> "" Then
            Try
                SQLstmtCA = "Select * from Administrator_Login where CStr([Mobile_Number]) = '" & CStr(txtsignupmobilenumber.Text) & "'And [Email] = '" & txtsignupemail.Text & "'"
                SQLstmtCC = "Select * from Chef_Login where  CStr([Mobile_Number]) = '" & CStr(txtsignupmobilenumber.Text) & "'And [Email] = '" & txtsignupemail.Text & "'"
                SQLstmtCM = "Select * from ManagerOrSupervisor_Login where CStr([Mobile_Number]) = '" & CStr(txtsignupmobilenumber.Text) & "'And [Email] = '" & txtsignupemail.Text & "'"
                SQLstmtCW = "Select * from WaiterOrWaitress_Login where CStr([Mobile_Number]) = '" & CStr(txtsignupmobilenumber.Text) & "'And [Email] = '" & txtsignupemail.Text & "'"
                Dim mycon As New OleDbConnection(con)
                Dim mycmdCA As New OleDbCommand(SQLstmtCA, mycon)
                Dim mycmdCC As New OleDbCommand(SQLstmtCC, mycon)
                Dim mycmdCM As New OleDbCommand(SQLstmtCM, mycon)
                Dim mycmdCW As New OleDbCommand(SQLstmtCW, mycon)
                mycmdCA.Connection.Open()
                Dim myredCA As OleDbDataReader = mycmdCA.ExecuteReader(CommandBehavior.CloseConnection)
                Dim myredCC As OleDbDataReader = mycmdCC.ExecuteReader(CommandBehavior.CloseConnection)
                Dim myredCM As OleDbDataReader = mycmdCM.ExecuteReader(CommandBehavior.CloseConnection)
                Dim myredCW As OleDbDataReader = mycmdCW.ExecuteReader(CommandBehavior.CloseConnection)

                If myredCA.Read() And myredCA.HasRows() Then
                    If myredCA.Item("Active").ToString = True And myredCA.Item("User_Name").ToString = "" And myredCA.Item("Password").ToString = "" Then
                        txtsignupid.Text = myredCA.Item("ID").ToString
                        txtsignupid.Text = myredCA.Item("ID").ToString
                        txtsignupfname.Text = myredCA("First_Name").ToString
                        txtsignuplname.Text = myredCA("Last_Name").ToString
                        txtsignuprole.Text = myredCA("Role").ToString
                        eligible()
                        NewSignupCon = 1
                    ElseIf myredCA.Item("User_Name").ToString <> "" And myredCA.Item("Password").ToString <> "" Then
                        ineligible()
                    End If
                    mycon.Close()
                    mycmdCC.Connection.Open()
                ElseIf myredCC.Read() And myredCC.HasRows() Then
                    If myredCC.Item("Active").ToString = True Then
                        txtsignupid.Text = myredCC.Item("ID").ToString
                        txtsignupfname.Text = myredCC("First_Name").ToString
                        txtsignuplname.Text = myredCC("Last_Name").ToString
                        txtsignuprole.Text = myredCC("Role").ToString
                        eligible()
                        NewSignupCon = 2
                    ElseIf myredCC.Item("User_Name").ToString <> "" And myredCC.Item("Password").ToString <> "" Then
                        ineligible()
                    End If
                    mycon.Close()
                    mycmdCM.Connection.Open()
                ElseIf myredCM.Read() And myredCM.HasRows() Then
                    If myredCM.Item("Active").ToString = True Then
                        txtsignupid.Text = myredCM.Item("ID").ToString
                        txtsignupfname.Text = myredCM("First_Name").ToString
                        txtsignuplname.Text = myredCM("Last_Name").ToString
                        txtsignuprole.Text = myredCM("Role").ToString
                        eligible()
                        NewSignupCon = 3
                    ElseIf myredCM.Item("User_Name").ToString <> "" And myredCM.Item("Password").ToString <> "" Then
                        ineligible()

                    End If
                    mycon.Close()
                    mycmdCW.Connection.Open()
                ElseIf myredCW.Read() And myredCW.HasRows() Then
                    If myredCW.Item("Active").ToString = True Then
                        txtsignupid.Text = myredCC.Item("ID").ToString
                        txtsignupfname.Text = myredCW("First_Name").ToString
                        txtsignuplname.Text = myredCW("Last_Name").ToString
                        txtsignuprole.Text = myredCW("Role").ToString
                        eligible()
                        NewSignupCon = 4
                    ElseIf myredCW.Item("User_Name").ToString <> "" And myredCW.Item("Password").ToString <> "" Then
                        ineligible()
                    End If
                Else
                    btnpopup.Show()
                    btnpopup.BackColor = Color.LightCoral
                    btnpopup.ForeColor = Color.Linen
                    btnpopup.Text = "The User Is Inactive, Contact Admin "
                    txtsignupmobilenumber.Clear()
                    txtsignupemail.Clear()
                    txtsignupmobilenumber.Focus()
                    PopOut()
                End If
                mycon.Close()
                mycmdCC.Connection.Open()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        Else
            btnpopup.Show()
            btnpopup.BackColor = Color.LightCoral
            btnpopup.ForeColor = Color.Linen
            btnpopup.Text = "Number Field is Empty "
            txtsignupmobilenumber.Focus()
            PopOut()
        End If
    End Sub
    Private Sub btnsignupsave_Click(sender As Object, e As EventArgs) Handles btnsignupsave.Click
        Try
            If NewSignupCon = 1 Then
                SQLstmtCNA = "Update Administrator_Login Set [User_Name] = '" & CStr(txtsignupusername.Text) & "', [Password] = '" & CStr(txtsignupreenterpassword.Text) & "' where [email] = '" & txtsignupemail.Text & "'"
                da = New OleDbDataAdapter(SQLstmtCNA, con)
                da.Fill(ds, "Administrator_Login")
                newrecordsaved()
            ElseIf NewSignupCon = 2 Then
                SQLstmtCNC = "Update Chef_Login Set [User_Name] = '" & CStr(txtsignupusername.Text) & "', [Password] = '" & CStr(txtsignupreenterpassword.Text) & "' where [email] = '" & txtsignupemail.Text & "'"
                da = New OleDbDataAdapter(SQLstmtCNC, con)
                da.Fill(ds, "Chef_Login")
                newrecordsaved()
            ElseIf NewSignupCon = 3 Then
                SQLstmtCNM = "Update ManagerOrSupervisor_Login Set [User_Name] = '" & CStr(txtsignupusername.Text) & "', [Password] = '" & CStr(txtsignupreenterpassword.Text) & "' where [email] = '" & txtsignupemail.Text & "'"
                da = New OleDbDataAdapter(SQLstmtCNM, con)
                da.Fill(ds, "ManagerOrSupervisor_Login")
                newrecordsaved()
            ElseIf NewSignupCon = 4 Then
                SQLstmtCNW = "Update WaiterOrWaitress_Login Set [User_Name] = '" & CStr(txtsignupusername.Text) & "', [Password] = '" & CStr(txtsignupreenterpassword.Text) & "' where [email] = '" & txtsignupemail.Text & "'"
                da = New OleDbDataAdapter(SQLstmtCNW, con)
                da.Fill(ds, "WaiterOrWaitress_Login")
                newrecordsaved()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub btnupdateinfo_Click(sender As Object, e As EventArgs) Handles btnupdateinfo.Click
        txtretrievenumber.Focus()
        updateuserpanel.Dock = Fill
        updateuserpanel.Show()
        adduserpanel.Hide()
        deleteuserpanel.Hide()
        userlogspanel.Hide()
        orderstatspanel.Hide()
        numberretrievepanel.Dock = Fill
        numberretrievepanel.Show()
        updatepanel.Hide()
    End Sub

    Private Sub btndeleteuser_Click(sender As Object, e As EventArgs) Handles btndeleteuser.Click
        deleteuserpanel.Dock = Fill
        deleteuserpanel.Show()
        adduserpanel.Hide()
        updateuserpanel.Hide()
        userlogspanel.Hide()
        orderstatspanel.Hide()
    End Sub

    Private Sub btnviewuserlogs_Click(sender As Object, e As EventArgs) Handles btnviewuserlogs.Click
        userlogspanel.Dock = Fill
        userlogspanel.Show()
        adduserpanel.Hide()
        deleteuserpanel.Hide()
        updateuserpanel.Hide()
        orderstatspanel.Hide()
    End Sub

    Private Sub btnorderstats_Click(sender As Object, e As EventArgs) Handles btnorderstats.Click
        orderstatspanel.Dock = Fill
        orderstatspanel.Show()
        adduserpanel.Hide()
        deleteuserpanel.Hide()
        userlogspanel.Hide()
        updateuserpanel.Hide()
    End Sub


    Dim SQLstmtRA, SQLstmtRC, SQLstmtRM, SQLstmtRW As String
    Private Sub btnretrieve_Click(sender As Object, e As EventArgs) Handles btnretrieve.Click
        Try
            SQLstmtRA = "Select * from Administrator_Login where CStr(Mobile_Number) = '" & CStr(txtretrievenumber.Text) & "'"
            SQLstmtRC = "Select * from Chef_Login where  CStr(Mobile_Number) = '" & CStr(txtretrievenumber.Text) & "'"
            SQLstmtRM = "Select * from ManagerOrSupervisor_Login where CStr(Mobile_Number) = '" & CStr(txtretrievenumber.Text) & "'"
            SQLstmtRW = "Select * from WaiterOrWaitress_Login where CStr(Mobile_Number) = '" & CStr(txtretrievenumber.Text) & "'"
            Dim mycon As New OleDbConnection(con)
            Dim mycmdRA As New OleDbCommand(SQLstmtRA, mycon)
            Dim mycmdRC As New OleDbCommand(SQLstmtRC, mycon)
            Dim mycmdRM As New OleDbCommand(SQLstmtRM, mycon)
            Dim mycmdRW As New OleDbCommand(SQLstmtRW, mycon)
            mycmdRA.Connection.Open()
            Dim myredRA As OleDbDataReader = mycmdRA.ExecuteReader(CommandBehavior.CloseConnection)
            Dim myredRC As OleDbDataReader = mycmdRC.ExecuteReader(CommandBehavior.CloseConnection)
            Dim myredRM As OleDbDataReader = mycmdRM.ExecuteReader(CommandBehavior.CloseConnection)
            Dim myredRW As OleDbDataReader = mycmdRW.ExecuteReader(CommandBehavior.CloseConnection)

            If myredRA.Read() And myredRA.HasRows() Then
                txtretrieveid.Text = myredRA.Item("ID").ToString
                numberretrievepanel.Hide()
                updatepanel.Dock = Fill
                updatepanel.Show()
                txtupdateid.Text = myredRA.Item("ID").ToString
                txtupdatefname.Text = myredRA.Item("First_Name").ToString
                txtupdatelname.Text = myredRA.Item("Last_Name").ToString
                txtupdateonames.Text = myredRA.Item("Other_Name(s)").ToString
                txtupdaterole.Text = myredRA.Item("Role").ToString
                txtupdatenumber.Text = myredRA.Item("Mobile_Number").ToString
                txtupdateusername.Text = myredRA.Item("User_Name").ToString
                txtupdatepassword.Text = myredRA.Item("Password").ToString
                txtupdateemail.Text = myredRA.Item("Email").ToString
                txtupdategender.Text = myredRA.Item("Gender").ToString
                txtupdateretrieveorupdateid.Text = myredRA.Item("ID").ToString
                updatedatetimepicker.Value = myredRA("Birth_Date").ToString
                Retrieve = 1
                mycon.Close()
                mycmdRC.Connection.Open()
            ElseIf myredRC.Read() And myredRC.HasRows Then
                txtid.Text = myredRC.Item("ID").ToString
                numberretrievepanel.Hide()
                updatepanel.Dock = Fill
                updatepanel.Show()
                txtupdateid.Text = myredRC.Item("ID").ToString
                txtupdatefname.Text = myredRC.Item("First_Name").ToString
                txtupdatelname.Text = myredRC.Item("Last_Name").ToString
                txtupdateonames.Text = myredRC.Item("Other_Name(s)").ToString
                txtupdaterole.Text = myredRC.Item("Role").ToString
                txtupdatenumber.Text = myredRC.Item("Mobile_Number").ToString
                txtupdateusername.Text = myredRC.Item("User_Name").ToString
                txtupdatepassword.Text = myredRC.Item("Password").ToString
                txtupdateemail.Text = myredRC.Item("Email").ToString
                txtupdategender.Text = myredRC.Item("Gender").ToString
                txtupdateretrieveorupdateid.Text = myredRC.Item("ID").ToString
                updatedatetimepicker.Value = myredRC("Birth_Date").ToString
                Retrieve = 2
                mycon.Close()
                mycmdRM.Connection.Open()
            ElseIf myredRM.Read() And myredRM.HasRows Then
                txtid.Text = myredRM.Item("ID").ToString
                numberretrievepanel.Hide()
                updatepanel.Dock = Fill
                updatepanel.Show()
                txtupdateid.Text = myredRM.Item("ID").ToString
                txtupdatefname.Text = myredRM.Item("First_Name").ToString
                txtupdatelname.Text = myredRM.Item("Last_Name").ToString
                txtupdateonames.Text = myredRM.Item("Other_Name(s)").ToString
                txtupdaterole.Text = myredRM.Item("Role").ToString
                txtupdatenumber.Text = myredRM.Item("Mobile_Number").ToString
                txtupdateusername.Text = myredRM.Item("User_Name").ToString
                txtupdatepassword.Text = myredRM.Item("Password").ToString
                txtupdateemail.Text = myredRM.Item("Email").ToString
                txtupdategender.Text = myredRM.Item("Gender").ToString
                txtupdateretrieveorupdateid.Text = myredRM.Item("ID").ToString
                updatedatetimepicker.Value = myredRM("Birth_Date").ToString
                Retrieve = 3
                mycon.Close()
                mycmdRW.Connection.Open()
            ElseIf myredRW.Read() And myredRM.HasRows Then
                txtid.Text = myredRW.Item("ID").ToString
                numberretrievepanel.Hide()
                updatepanel.Dock = Fill
                updatepanel.Show()
                txtupdateid.Text = myredRW.Item("ID").ToString
                txtupdatefname.Text = myredRW.Item("First_Name").ToString
                txtupdatelname.Text = myredRW.Item("Last_Name").ToString
                txtupdateonames.Text = myredRW.Item("Other_Name(s)").ToString
                txtupdaterole.Text = myredRW.Item("Role").ToString
                txtupdatenumber.Text = myredRW.Item("Mobile_Number").ToString
                txtupdateusername.Text = myredRW.Item("User_Name").ToString
                txtupdatepassword.Text = myredRW.Item("Password").ToString
                txtupdateemail.Text = myredRW.Item("Email").ToString
                txtupdategender.Text = myredRW.Item("Gender").ToString
                txtupdateretrieveorupdateid.Text = myredRW.Item("ID").ToString
                updatedatetimepicker.Value = myredRW("Birth_Date").ToString
                Retrieve = 4
                mycon.Close()
            Else
                btnpopup.BackColor = Color.LightCoral
                btnpopup.ForeColor = Color.Linen
                btnpopup.Show()
                btnpopup.Text = "User Not Found"
                PopOut()
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub
End Class
