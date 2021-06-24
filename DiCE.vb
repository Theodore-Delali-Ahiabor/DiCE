Imports System.Data.OleDb
Imports System.Windows.Forms.DockStyle
Imports System.Windows.Forms.DataGridViewImageColumn
Public Class DiCE
    ReadOnly con As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\theod\Desktop\  \Projects\Visual Basic\DiCE\DiCEDatabase.accdb"
    Dim ds As New DataSet
    Dim da As OleDbDataAdapter
    Dim SQLstmtUA As String
    Dim countdown As Integer
    Dim invalidcount As Integer = 0
    Private Sub systemtime_Tick(sender As Object, e As EventArgs) Handles systemtime.Tick
        lbldate.Text = Date.Now.ToShortDateString
        lbltime.Text = TimeOfDay
    End Sub
    'HIDES THE POPUP WHEN CLICKED
    Private Sub btnpopup_Click(sender As Object, e As EventArgs) Handles btnpopup.Click
        btnpopup.Hide()
    End Sub
    'TIMER FOR POP UP
    Private Sub buttonhidetimer_Tick(sender As Object, e As EventArgs) Handles buttonhidetimer.Tick
        btnpopup.Hide()
    End Sub
    'CALL WHEN NEW USER RECORDS SAVE SUCCESSFULY
    Private Sub invalidlogintimer_Tick(sender As Object, e As EventArgs) Handles invalidlogintimer.Tick
        countdown -= 1
        lblinvalidmessage.Visible = False
        btnlogin.Visible = True
        btnsignup.Visible = True
        txtloginpassword.Enabled = True
        txtloginusername.Enabled = True
    End Sub
    Private Sub FormDiCE_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        btnlogout.Hide()
        systemtime_Tick(sender, e)
        userspanel.Hide()
        'txtloginpassword.Clear()
        'txtloginusername.Clear()
        'txtloginusername.Focus()
        loginpanel.Visible = True
        loginpanel.Dock = Fill
        lbluser.Text = "User"
        lblrole.Text = "role"
        txtloginpassword.Text = "welcome"
        txtloginusername.Text = "TheodoreW"
        btnlogin.Focus()
    End Sub
    'DISABLING SYMBOLS AND SPACE IN THE USERNAME TEXTBOX
    Private Sub txtusername_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtloginusername.KeyPress
        If Char.IsLetterOrDigit(e.KeyChar) Or Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub
    Private Sub btnsignup_Click(sender As Object, e As EventArgs) Handles btnsignup.Click
        signuppanel.Dock = Fill
        txtsignupmobilenumber.Focus()
        signuppanel.Show()
        loginpanel.Hide()
        btntologin.Show()
        txtsignupmobilenumber.Clear()
        txtsignupemail.Clear()
        txtsignupmobilenumber.Enabled = True
        txtsignupemail.Enabled = True
    End Sub
    'THE LOGIN PROCESS
    Private Sub btnlogin_Click(sender As Object, e As EventArgs) Handles btnlogin.Click
        If txtloginpassword.Text <> "" And txtloginusername.Text <> "" Then
            Try
                Dim LoginSQLStmt As String = "Select * from User_Login where User_Name = '" & txtloginusername.Text & "' and Password = '" & txtloginpassword.Text & "'"
                Dim myLoginCon As New OleDbConnection(con)
                Dim myLoginCmd As New OleDbCommand(LoginSQLStmt, myLoginCon)
                myLoginCmd.Connection.Open()
                Dim myLoginRead As OleDbDataReader = myLoginCmd.ExecuteReader(CommandBehavior.CloseConnection)
                If myLoginRead.Read() And myLoginRead.HasRows Then
                    If StrComp(txtloginusername.Text, myLoginRead.Item("User_Name").ToString, CompareMethod.Binary) _
                       And StrComp(txtloginpassword.Text, myLoginRead.Item("Password").ToString(), CompareMethod.Binary) Then
                        invalid()
                    Else
                        If myLoginRead.Item("Position") = "Administrator" And myLoginRead.Item("Active").ToString = True Then
                            lblrole.Text = myLoginRead.Item("Role").ToString
                            lbluser.Text = myLoginRead.Item("First_Name") + " " + myLoginRead.Item("Other_Name(s)") + " " + myLoginRead.Item("Last_Name")
                            adminpanel.Dock = Fill
                            adminpanel.Show()
                            LogInProcess()
                            chefpanel.Hide()
                            managerpanel.Hide()
                            waiterpanel.Hide()
                            tabadminadduser_Click(sender, e)
                        ElseIf myLoginRead.Item("Position") = "Chef/Cook" And myLoginRead.Item("Active").ToString = True Then
                            lblrole.Text = myLoginRead.Item("Role").ToString
                            lbluser.Text = myLoginRead.Item("First_Name") + " " + myLoginRead.Item("Other_Name(s)") + " " + myLoginRead.Item("Last_Name")
                            chefpanel.Dock = Fill
                            chefpanel.Show()
                            adminpanel.Hide()
                            managerpanel.Hide()
                            waiterpanel.Hide()
                            LogInProcess()
                        ElseIf myLoginRead.Item("Position") = "Manager/supervisor" And myLoginRead.Item("Active").ToString = True Then
                            lblrole.Text = myLoginRead.Item("Role").ToString
                            lbluser.Text = myLoginRead.Item("First_Name") + " " + myLoginRead.Item("Other_Name(s)") + " " + myLoginRead.Item("Last_Name")
                            managerpanel.Dock = Fill
                            managerpanel.Show()
                            adminpanel.Hide()
                            chefpanel.Hide()
                            waiterpanel.Hide()
                            LogInProcess()
                        ElseIf myLoginRead.Item("Position") = "Waiter/Waitress" And myLoginRead.Item("Active").ToString = True Then
                            lblrole.Text = myLoginRead.Item("Role").ToString
                            lbluser.Text = myLoginRead.Item("First_Name") + " " + myLoginRead.Item("Other_Name(s)") + " " + myLoginRead.Item("Last_Name")
                            waiterpanel.Dock = Fill
                            waiterpanel.Show()
                            adminpanel.Hide()
                            chefpanel.Hide()
                            managerpanel.Hide()
                            LogInProcess()
                            tabwaiterfoods_Click(sender, e)
                            'waiterlogin()

                        Else
                            MsgBox("User has been Deactivated contact Administrator for Reactivation", MsgBoxStyle.Information, "Access Denied")
                        End If
                    End If
                    myLoginCon.Close()
                Else
                    invalid()
                End If
            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try
        ElseIf txtloginusername.Text = "" And txtloginpassword.Text = "" Then
            btnpopup.BackColor = Color.LightCoral
            btnpopup.ForeColor = Color.Linen
            btnpopup.Text = "User Name and Password Fields are Empty"
            btnpopup.Show()
            PopOut()
            txtloginusername.Focus()
        ElseIf txtloginusername.Text = "" Then
            btnpopup.BackColor = Color.LightCoral
            btnpopup.ForeColor = Color.Linen
            btnpopup.Text = "The User Name Field is Empty "
            btnpopup.Show()
            PopOut()
            txtloginusername.Focus()
        ElseIf txtloginpassword.Text = "" Then
            btnpopup.BackColor = Color.LightCoral
            btnpopup.ForeColor = Color.Linen
            btnpopup.Text = "The Password Fiels is Empty"
            btnpopup.Show()
            PopOut()
            txtloginpassword.Focus()
        End If
    End Sub
    'HIDES THE POPUP BUTTON AFTER 3 SECONDS
    Public Sub PopOut()
        buttonhidetimer.Enabled = True
        buttonhidetimer.Interval = 5000
    End Sub
    'CALL IF LOGIN IS SUCCESSFUL
    Public Sub LogInProcess()
        userspanel.Dock = Fill
        userspanel.Show()
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
        txtloginusername.Clear()
        txtloginpassword.Clear()
        txtloginusername.Focus()
        invalidcount += 1

        If invalidcount = 5 Then
            countdown = 10
            invalidlogintimer.Enabled = True
            invalidlogintimer.Interval = 10000
            lblinvalidmessage.Text = "Try again in " & countdown & " seconds"

            lblinvalidmessage.Visible = True
            txtloginusername.Enabled = False
            txtloginpassword.Enabled = False
            btnlogin.Visible = False
            btnsignup.Visible = False
        ElseIf invalidcount = 6 Then
            MsgBox("Try again in 1 munite")
        ElseIf invalidcount = 7 Then
            MsgBox("Try again in 5 Munites")
        ElseIf invalidcount = 8 Then
            MsgBox("Try again in 10 munites")
        ElseIf invalidcount = 9 Then
            MsgBox("Try again in 30 munites")
        ElseIf invalidcount = 10 Then
            MsgBox("User Has been Deactivated")
        End If
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
        txtnewsalary.Clear()
        rbtnfemale.Checked = False
        rbtnmale.Checked = False
        cmbusertype.Text = ""
        chkbnewactive.Checked = True
        If signuppanel.Dock = Fill Then
            txtsignupusername.Clear()
            txtsignpassword.Clear()
            txtsignupconfirmpassword.Clear()
            signuppanel.Hide()
            loginpanel.Dock = Fill
            loginpanel.Show()
        End If
    End Sub
    Private Sub rbtnmarried_Click(sender As Object, e As EventArgs) Handles rbtnmarried.Click
        If rbtnmarried.Checked = True Then
            chkbmaritalstat.Checked = True
        End If
    End Sub

    Private Sub rbtnsingle_Click(sender As Object, e As EventArgs) Handles rbtnsingle.Click
        If rbtnsingle.Checked = True Then
            chkbmaritalstat.Checked = False
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
                Dim AddNewUserSQLstamt As String
                If txtnewnumber.Text <> "" And txtnewemail.Text <> "" And cmbusertype.Text <> "" Then
                    AddNewUserSQLstamt = "insert into User_Login([Role],[Mobile_Number],[Email],[First_Name],[Last_Name],[Other_Name(s)],[Gender],[Birth_Date],[Monthly_Salary(GHC)],[Marital_Status],[Active]) values('" & txtnewrole.Text & "','" & txtnewnumber.Text & "','" & txtnewemail.Text & "','" & txtnewfname.Text & "','" & txtnewlname.Text & "','" & txtnewonames.Text & "','" & gender & "','" & txtnewDOB.Text & "','" & txtnewsalary.Text & "','" & chkbmaritalstat.CheckState & "','" & chkbnewactive.CheckState & "')"
                    da = New OleDbDataAdapter(AddNewUserSQLstamt, con)
                    da.Fill(ds, "User_Login")
                    newrecordsaved()
                ElseIf txtnewnumber.Text = "" Then
                    btnpopup.BackColor = Color.LightCoral
                    btnpopup.ForeColor = Color.Linen
                    btnpopup.Show()
                    btnpopup.Text = "Mobile Number Field is Empty"
                    txtnewnumber.Focus()
                    PopOut()
                ElseIf txtnewemail.Text = "" Then
                    btnpopup.BackColor = Color.LightCoral
                    btnpopup.ForeColor = Color.Linen
                    btnpopup.Show()
                    btnpopup.Text = "Email Address Field is Empty"
                    txtnewemail.Focus()
                    PopOut()
                ElseIf cmbusertype.Text = "" Then
                    btnpopup.BackColor = Color.LightCoral
                    btnpopup.ForeColor = Color.Linen
                    btnpopup.Show()
                    btnpopup.Text = "Position Field is Empty"
                    'cmbusertype.
                    PopOut()
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
            txtupdatemaritalstat.Enabled = False
            txtupdatesalary.Enabled = False
            maritalstatpanel.Enabled = False
            genderpanel.Enabled = False
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
            txtupdatemaritalstat.Enabled = True
            txtupdatesalary.Enabled = True
            maritalstatpanel.Enabled = True
            genderpanel.Enabled = True
            If txtupdatepassword.Enabled = True Then
                If txtupdatemaritalstat.Text = "Single" Then
                    chkbupdatemaritalstat.Checked = False
                ElseIf txtupdatemaritalstat.Text = "Married" Then
                    chkbupdatemaritalstat.Checked = True
                End If
                Try
                    SQLstmtUA = "Update User_Login Set [User_Name] = '" & CStr(txtupdateusername.Text) & "', [Password] = '" & CStr(txtupdatepassword.Text) & "',[Role] = '" & txtupdaterole.Text & "',[Mobile_Number] = '" & txtupdatenumber.Text & "',[Email] = '" & txtupdateemail.Text & "',[First_Name] = '" & txtupdatefname.Text & "',[Last_Name] = '" & txtupdatelname.Text & "',[Other_Name(s)] = '" & txtupdateonames.Text & "',[Gender] = '" & txtupdategender.Text & "',[Birth_Date] = '" & updatedatetimepicker.Text & "',[Active] = '" & chkbupdateactive.CheckState & "',[Marital_Status] = '" & chkbupdatemaritalstat.CheckState & "',[Monthly_Salary(GHC)] = '" & CStr(txtupdatesalary.Text) & "'  where CStr([ID]) = '" & CStr(txtupdateretrieveorupdateid.Text) & "'"
                    da = New OleDbDataAdapter(SQLstmtUA, con)
                    da.Fill(ds, "Userr_Login")
                    newrecordsaved()
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            End If
        End If

    End Sub
    Private Sub btntologin_Click(sender As Object, e As EventArgs) Handles btntologin.Click
        btntologin.Hide()
        signuppanel.Hide()
        loginpanel.Dock = Fill
        loginpanel.Show()
        FormDiCE_Load(sender, e)
    End Sub
    Public Sub eligible()
        txtsignpassword.Enabled = True
        txtsignupconfirmpassword.Enabled = True
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
        If txtsignupmobilenumber.Text <> "" And txtsignupemail.Text <> "" Then
            Try
                Dim EligibleCheckSQLstmt As String
                EligibleCheckSQLstmt = "Select * from User_Login where CStr([Mobile_Number]) = '" & CStr(txtsignupmobilenumber.Text) & "'And [Email] = '" & txtsignupemail.Text & "'"
                Dim EligibleCheckCon As New OleDbConnection(con)
                Dim EligibleCheckCmd As New OleDbCommand(EligibleCheckSQLstmt, EligibleCheckCon)
                EligibleCheckCmd.Connection.Open()
                Dim EligibleCheckRead As OleDbDataReader = EligibleCheckCmd.ExecuteReader(CommandBehavior.CloseConnection)
                If EligibleCheckRead.Read() And EligibleCheckRead.HasRows() Then
                    If EligibleCheckRead.Item("Active").ToString = True And EligibleCheckRead.Item("User_Name").ToString = "" And EligibleCheckRead.Item("Password").ToString = "" Then
                        txtsignupid.Text = EligibleCheckRead.Item("ID").ToString
                        txtsignupid.Text = EligibleCheckRead.Item("ID").ToString
                        txtsignupfname.Text = EligibleCheckRead("First_Name").ToString
                        txtsignuplname.Text = EligibleCheckRead("Last_Name").ToString
                        txtsignuprole.Text = EligibleCheckRead("Role").ToString
                        eligible()
                    ElseIf EligibleCheckRead.Item("User_Name").ToString <> "" And EligibleCheckRead.Item("Password").ToString <> "" Then
                        ineligible()
                    End If
                Else
                    btnpopup.Show()
                    btnpopup.BackColor = Color.LightCoral
                    btnpopup.ForeColor = Color.Linen
                    btnpopup.Text = "User Not Found "
                    PopOut()
                End If
                EligibleCheckCon.Close()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        ElseIf txtsignupmobilenumber.Text = "" Then
            btnpopup.Show()
            btnpopup.BackColor = Color.LightCoral
            btnpopup.ForeColor = Color.Linen
            btnpopup.Text = "Number Field is Empty "
            txtsignupmobilenumber.Focus()
            PopOut()
        ElseIf txtsignupemail.Text = "" Then
            btnpopup.Show()
            btnpopup.BackColor = Color.LightCoral
            btnpopup.ForeColor = Color.Linen
            btnpopup.Text = "Email Address Field is Empty "
            txtsignupemail.Focus()
            PopOut()
        End If
    End Sub
    Private Sub btnsignupsave_Click(sender As Object, e As EventArgs) Handles btnsignupsave.Click
        Dim SignupSaveSQLstmt As String
        If txtsignupconfirmpassword.Text <> "" And txtsignpassword.Text <> "" Then
            If txtsignpassword.Text.ToString = txtsignupconfirmpassword.Text.ToString() Then
                Try
                    SignupSaveSQLstmt = "Update User_Login Set [User_Name] = '" & CStr(txtsignupusername.Text) & "', [Password] = '" & CStr(txtsignupconfirmpassword.Text) & "' where [email] = '" & txtsignupemail.Text & "'"
                    da = New OleDbDataAdapter(SignupSaveSQLstmt, con)
                    da.Fill(ds, "User_Login")
                    newrecordsaved()
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            Else
                txtsignupconfirmpassword.Clear()
                txtsignpassword.Clear()
                txtsignpassword.Focus()
                btnpopup.BackColor = Color.LightCoral
                btnpopup.ForeColor = Color.Linen
                btnpopup.Show()
                btnpopup.Text = "Password Mismatch"
                PopOut()
            End If
        ElseIf txtsignupusername.Text = "" Then
            txtsignupusername.Focus()
            btnpopup.BackColor = Color.LightCoral
            btnpopup.ForeColor = Color.Linen
            btnpopup.Show()
            btnpopup.Text = "User Name Field Empty"
            PopOut()
        ElseIf txtsignupconfirmpassword.Text = "" Then
            txtsignpassword.Focus()
            btnpopup.BackColor = Color.LightCoral
            btnpopup.ForeColor = Color.Linen
            btnpopup.Show()
            btnpopup.Text = "Password Confirmation Field Empty"
            PopOut()
        ElseIf txtsignpassword.Text = "" Then
            txtsignpassword.Focus()
            btnpopup.BackColor = Color.LightCoral
            btnpopup.ForeColor = Color.Linen
            btnpopup.Show()
            btnpopup.Text = "Password Field Empty"
            PopOut()
        End If
    End Sub
    Private Sub tabadminadduser_Click(sender As Object, e As EventArgs) Handles tabadminadduser.Click
        adminadduserpanel.Dock = Fill
        adminadduserpanel.Show()
        adminsearchuserpanel.Hide()
        adminuserlogspanel.Hide()
        adminorderstatspanel.Hide()
        adminactive1.Visible = True
        adminactive2.Visible = False
        adminactive3.Visible = False
        adminactive4.Visible = False
    End Sub
    Private Sub tabadminupdateinfo_Click(sender As Object, e As EventArgs) Handles tabadminsearchuser.Click
        txtretrievenumber.Clear()
        txtretrievenumber.Focus()
        adminsearchuserpanel.Dock = Fill
        adminsearchuserpanel.Show()
        adminadduserpanel.Hide()
        adminuserlogspanel.Hide()
        adminorderstatspanel.Hide()
        numbersearchpanel.Dock = Fill
        numbersearchpanel.Show()
        updatepanel.Hide()
        adminactive1.Visible = False
        adminactive2.Visible = True
        adminactive3.Visible = False
        adminactive4.Visible = False
    End Sub
    Private Sub tabviewuserlogs_Click(sender As Object, e As EventArgs) Handles tabadminviewuserlogs.Click
        adminuserlogspanel.Dock = Fill
        adminuserlogspanel.Show()
        adminadduserpanel.Hide()
        adminsearchuserpanel.Hide()
        adminorderstatspanel.Hide()
        adminactive1.Visible = False
        adminactive2.Visible = False
        adminactive3.Visible = False
        adminactive4.Visible = True
    End Sub

    Private Sub tabadminorderstats_Click(sender As Object, e As EventArgs) Handles tabadminorderstats.Click
        adminorderstatspanel.Dock = Fill
        adminorderstatspanel.Show()
        adminadduserpanel.Hide()
        adminuserlogspanel.Hide()
        adminsearchuserpanel.Hide()
        adminactive1.Visible = False
        adminactive2.Visible = False
        adminactive3.Visible = True
        adminactive4.Visible = False
    End Sub

    Private Sub btnretrieve_Click(sender As Object, e As EventArgs) Handles btnretrieve.Click
        Try
            Dim SearchSQLstmt As String
            SearchSQLstmt = "Select * from User_Login where CStr(Mobile_Number) = '" & CStr(txtretrievenumber.Text) & "'"
            Dim mySearchCon As New OleDbConnection(con)
            Dim mySearchCmd As New OleDbCommand(SearchSQLstmt, mySearchCon)
            mySearchCmd.Connection.Open()
            Dim mySearchRead As OleDbDataReader = mySearchCmd.ExecuteReader(CommandBehavior.CloseConnection)
            If mySearchRead.Read() And mySearchRead.HasRows() Then
                numbersearchpanel.Hide()
                updatepanel.Dock = Fill
                updatepanel.Show()
                txtupdateid.Text = mySearchRead.Item("ID").ToString
                txtupdatefname.Text = mySearchRead.Item("First_Name").ToString
                txtupdatelname.Text = mySearchRead.Item("Last_Name").ToString
                txtupdateonames.Text = mySearchRead.Item("Other_Name(s)").ToString
                txtupdaterole.Text = mySearchRead.Item("Role").ToString
                txtupdatenumber.Text = mySearchRead.Item("Mobile_Number").ToString
                txtupdateusername.Text = mySearchRead.Item("User_Name").ToString
                txtupdatepassword.Text = mySearchRead.Item("Password").ToString
                txtupdateemail.Text = mySearchRead.Item("Email").ToString
                txtupdategender.Text = mySearchRead.Item("Gender").ToString
                txtupdateretrieveorupdateid.Text = mySearchRead.Item("ID").ToString
                updatedatetimepicker.Value = mySearchRead("Birth_Date").ToString
                txtupdatesalary.Text = mySearchRead("Monthly_Salary(GHC)").ToString
                If mySearchRead.Item("Marital_Status").ToString = "False" Then
                    txtupdatemaritalstat.Text = "Single"
                ElseIf mySearchRead.Item("Marital_Status").ToString = "True" Then
                    txtupdatemaritalstat.Text = "Married"
                End If
                mySearchCon.Close()
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

    Private Sub btnadmindeleteuser_Click(sender As Object, e As EventArgs) Handles btnadmindeleteuser.Click
        Try
            Dim DeleteUserSQLstmt As String
            DeleteUserSQLstmt = "Select * from User_Login where CStr(Mobile_Number) = '" & CStr(txtretrievenumber.Text) & "'"
            Dim myDeleteUserCon As New OleDbConnection(con)
            Dim myDeleteUserCmd As New OleDbCommand(DeleteUserSQLstmt, myDeleteUserCon)
            myDeleteUserCmd.Connection.Open()
            Dim myDeleteUserRead As OleDbDataReader = myDeleteUserCmd.ExecuteReader(CommandBehavior.CloseConnection)

            Dim DeleteResult As DialogResult

            If myDeleteUserRead.Read() And myDeleteUserRead.HasRows() Then
                DeleteResult = MessageBox.Show("Are You Sure You Want To Delete This User ?", "WARNING !!! ", MessageBoxButtons.YesNo)
                If DeleteResult = DialogResult.Yes Then
                    Dim mycmdDel = New OleDbCommand("Delete From User_Login Where CStr([ID]) = '" & CStr(txtupdateretrieveorupdateid.Text) & "'", myDeleteUserCon)
                    mycmdDel.ExecuteNonQuery()
                    MsgBox("User Delete was Succesful", MsgBoxStyle.Information)
                    updatepanel.Hide()
                    numbersearchpanel.Dock = DockStyle.Fill
                    numbersearchpanel.Show()
                    txtretrievenumber.Clear()
                    txtretrievenumber.Focus()
                ElseIf DeleteResult = DialogResult.No Then
                    updatepanel.Show()
                    updatepanel.Dock = Fill
                End If

                myDeleteUserCon.Close()
                myDeleteUserCmd.Connection.Open()
            Else
                btnpopup.BackColor = Color.LightCoral
                btnpopup.ForeColor = Color.Linen
                btnpopup.Show()
                btnpopup.Text = "User Not Found"
                PopOut()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub tabwaiterfoods_Click(sender As Object, e As EventArgs) Handles tabwaiterfoods.Click
        waiteractive1.Visible = True
        waiteractive2.Visible = False
        waiteractive3.Visible = False
        waiteractive4.Visible = False
        waiteractive5.Visible = False
        waiteractive6.Visible = False
        waiterlogin()
        foodspanel.Show()
        foodspanel.Dock = DockStyle.Fill
        drinkspanel.Hide()
    End Sub

    Private Sub tabwaiterdrinks_Click(sender As Object, e As EventArgs) Handles tabwaiterdrinks.Click
        waiteractive1.Visible = False
        waiteractive2.Visible = True
        waiteractive3.Visible = False
        waiteractive4.Visible = False
        waiteractive5.Visible = False
        waiteractive6.Visible = False
        foodspanel.Hide()
        foodspanel.Dock = DockStyle.Fill
        drinkspanel.Show()
    End Sub

    Private Sub tabwaiterpastries_Click(sender As Object, e As EventArgs) Handles tabwaiterpastries.Click
        waiteractive1.Visible = False
        waiteractive2.Visible = False
        waiteractive3.Visible = True
        waiteractive4.Visible = False
        waiteractive5.Visible = False
        waiteractive6.Visible = False
    End Sub

    Private Sub tabwaitdessert_Click(sender As Object, e As EventArgs) Handles tabwaitdessert.Click
        waiteractive1.Visible = False
        waiteractive2.Visible = False
        waiteractive3.Visible = False
        waiteractive4.Visible = True
        waiteractive5.Visible = False
        waiteractive6.Visible = False
    End Sub

    Private Sub tabwaitersummary_Click(sender As Object, e As EventArgs) Handles tabwaitersummary.Click
        waiteractive1.Visible = False
        waiteractive2.Visible = False
        waiteractive3.Visible = False
        waiteractive4.Visible = False
        waiteractive5.Visible = True
        waiteractive6.Visible = False
    End Sub

    Private Sub tabwaitercancel_Click(sender As Object, e As EventArgs) Handles tabwaitercancel.Click
        waiteractive1.Visible = False
        waiteractive2.Visible = False
        waiteractive3.Visible = False
        waiteractive4.Visible = False
        waiteractive5.Visible = False
        waiteractive6.Visible = True
    End Sub
    Private Sub closeicon_MouseClick(sender As Object, e As MouseEventArgs) Handles closeicon.MouseClick
        Me.Close()
    End Sub
    Public Sub waiterlogin()

        Dim foodsSQLStmt As String = "Select * from Foods_Menu where CStr([Available]) = True And [name] <>'" & "" & "'"
        Dim foodsCon As New OleDbConnection(con)
        Dim foodsCmd As New OleDbCommand(foodsSQLStmt, foodsCon)
        foodsCmd.Connection.Open()
        Dim foodsRead As OleDbDataReader = foodsCmd.ExecuteReader(CommandBehavior.CloseConnection)
        If foodsRead.Read And foodsRead.HasRows Then
            Dim dt As DataTable = New DataTable()
            da = New OleDbDataAdapter(foodsSQLStmt, foodsCon)
            Dim tb As New DataTable
            da.Fill(tb)
            foodsDGV.DataSource = tb
            foodsDGV.Columns(4).DefaultCellStyle.Format = "N2"
            foodsDGV.Columns(6).CellTemplate.ValueType = GetType(Double)

            If foodsDGV.Rows.Count = 2 Then
                foodsname1.Text = foodsDGV.Rows(0).Cells(1).Value
                foodtypepanel1.Visible = True
                foodprice1.Text = foodsDGV.Rows(0).Cells(4).Value

                foodimg1.BackgroundImage = Image.FromFile("..\..\Resources\" & foodsDGV.Rows(0).Cells(6).Value & "")
            ElseIf foodsDGV.Rows.Count = 3 Then
                foodsname1.Text = foodsDGV.Rows(0).Cells(1).Value
                foodsname2.Text = foodsDGV.Rows(1).Cells(1).Value
                foodtypepanel1.Visible = True
                foodtypepanel2.Visible = True
                foodprice1.Text = foodsDGV.Rows(0).Cells(4).Value
                foodprice2.Text = foodsDGV.Rows(1).Cells(4).Value

                foodimg1.BackgroundImage = Image.FromFile("..\..\Resources\" & foodsDGV.Rows(0).Cells(6).Value & "")
                foodimg2.BackgroundImage = Image.FromFile("..\..\Resources\" & foodsDGV.Rows(1).Cells(6).Value & "")
            ElseIf foodsDGV.Rows.Count = 4 Then
                foodsname1.Text = foodsDGV.Rows(0).Cells(1).Value
                foodsname2.Text = foodsDGV.Rows(1).Cells(1).Value
                foodsname3.Text = foodsDGV.Rows(2).Cells(1).Value
                foodtypepanel1.Visible = True
                foodtypepanel2.Visible = True
                foodtypepanel3.Visible = True
                foodprice1.Text = foodsDGV.Rows(0).Cells(4).Value
                foodprice2.Text = foodsDGV.Rows(1).Cells(4).Value
                foodprice3.Text = foodsDGV.Rows(2).Cells(4).Value

                foodimg1.BackgroundImage = Image.FromFile("..\..\Resources\" & foodsDGV.Rows(0).Cells(6).Value & "")
                foodimg2.BackgroundImage = Image.FromFile("..\..\Resources\" & foodsDGV.Rows(1).Cells(6).Value & "")
                foodimg3.BackgroundImage = Image.FromFile("..\..\Resources\" & foodsDGV.Rows(2).Cells(6).Value & "")
            ElseIf foodsDGV.Rows.Count = 5 Then
                foodsname1.Text = foodsDGV.Rows(0).Cells(1).Value
                foodsname2.Text = foodsDGV.Rows(1).Cells(1).Value
                foodsname3.Text = foodsDGV.Rows(2).Cells(1).Value
                foodsname4.Text = foodsDGV.Rows(3).Cells(1).Value
                foodtypepanel1.Visible = True
                foodtypepanel2.Visible = True
                foodtypepanel3.Visible = True
                foodtypepanel4.Visible = True
                foodprice1.Text = foodsDGV.Rows(0).Cells(4).Value
                foodprice2.Text = foodsDGV.Rows(1).Cells(4).Value
                foodprice3.Text = foodsDGV.Rows(2).Cells(4).Value
                foodprice4.Text = foodsDGV.Rows(3).Cells(4).Value
                foodimg1.BackgroundImage = Image.FromFile("..\..\Resources\" & foodsDGV.Rows(0).Cells(6).Value & "")
                foodimg2.BackgroundImage = Image.FromFile("..\..\Resources\" & foodsDGV.Rows(1).Cells(6).Value & "")
                foodimg3.BackgroundImage = Image.FromFile("..\..\Resources\" & foodsDGV.Rows(2).Cells(6).Value & "")
                foodimg4.BackgroundImage = Image.FromFile("..\..\Resources\" & foodsDGV.Rows(3).Cells(6).Value & "")
            ElseIf foodsDGV.Rows.Count = 6 Then
                foodsname1.Text = foodsDGV.Rows(0).Cells(1).Value
                foodsname2.Text = foodsDGV.Rows(1).Cells(1).Value
                foodsname3.Text = foodsDGV.Rows(2).Cells(1).Value
                foodsname4.Text = foodsDGV.Rows(3).Cells(1).Value
                foodsname5.Text = foodsDGV.Rows(4).Cells(1).Value
                foodtypepanel1.Visible = True
                foodtypepanel2.Visible = True
                foodtypepanel3.Visible = True
                foodtypepanel4.Visible = True
                foodtypepanel5.Visible = True
                foodprice1.Text = foodsDGV.Rows(0).Cells(4).Value
                foodprice2.Text = foodsDGV.Rows(1).Cells(4).Value
                foodprice3.Text = foodsDGV.Rows(2).Cells(4).Value
                foodprice4.Text = foodsDGV.Rows(3).Cells(4).Value
                foodprice5.Text = foodsDGV.Rows(4).Cells(4).Value
                foodimg1.BackgroundImage = Image.FromFile("..\..\Resources\" & foodsDGV.Rows(0).Cells(6).Value & "")
                foodimg2.BackgroundImage = Image.FromFile("..\..\Resources\" & foodsDGV.Rows(1).Cells(6).Value & "")
                foodimg3.BackgroundImage = Image.FromFile("..\..\Resources\" & foodsDGV.Rows(2).Cells(6).Value & "")
                foodimg4.BackgroundImage = Image.FromFile("..\..\Resources\" & foodsDGV.Rows(3).Cells(6).Value & "")
                foodimg5.BackgroundImage = Image.FromFile("..\..\Resources\" & foodsDGV.Rows(4).Cells(6).Value & "")
            ElseIf foodsDGV.Rows.Count = 7 Then
                foodsname1.Text = foodsDGV.Rows(0).Cells(1).Value
                foodsname2.Text = foodsDGV.Rows(1).Cells(1).Value
                foodsname3.Text = foodsDGV.Rows(2).Cells(1).Value
                foodsname4.Text = foodsDGV.Rows(3).Cells(1).Value
                foodsname5.Text = foodsDGV.Rows(4).Cells(1).Value
                foodsname6.Text = foodsDGV.Rows(5).Cells(1).Value
                foodtypepanel1.Visible = True
                foodtypepanel2.Visible = True
                foodtypepanel3.Visible = True
                foodtypepanel4.Visible = True
                foodtypepanel5.Visible = True
                foodtypepanel6.Visible = True
                foodprice1.Text = foodsDGV.Rows(0).Cells(4).Value
                foodprice2.Text = foodsDGV.Rows(1).Cells(4).Value
                foodprice3.Text = foodsDGV.Rows(2).Cells(4).Value
                foodprice4.Text = foodsDGV.Rows(3).Cells(4).Value
                foodprice5.Text = foodsDGV.Rows(4).Cells(4).Value
                foodprice6.Text = foodsDGV.Rows(5).Cells(4).Value
                foodimg1.BackgroundImage = Image.FromFile("..\..\Resources\" & foodsDGV.Rows(0).Cells(6).Value & "")
                foodimg2.BackgroundImage = Image.FromFile("..\..\Resources\" & foodsDGV.Rows(1).Cells(6).Value & "")
                foodimg3.BackgroundImage = Image.FromFile("..\..\Resources\" & foodsDGV.Rows(2).Cells(6).Value & "")
                foodimg4.BackgroundImage = Image.FromFile("..\..\Resources\" & foodsDGV.Rows(3).Cells(6).Value & "")
                foodimg5.BackgroundImage = Image.FromFile("..\..\Resources\" & foodsDGV.Rows(4).Cells(6).Value & "")
                foodimg6.BackgroundImage = Image.FromFile("..\..\Resources\" & foodsDGV.Rows(5).Cells(6).Value & "")
            ElseIf foodsDGV.Rows.Count = 8 Then
                foodsname1.Text = foodsDGV.Rows(0).Cells(1).Value
                foodsname2.Text = foodsDGV.Rows(1).Cells(1).Value
                foodsname3.Text = foodsDGV.Rows(2).Cells(1).Value
                foodsname4.Text = foodsDGV.Rows(3).Cells(1).Value
                foodsname5.Text = foodsDGV.Rows(4).Cells(1).Value
                foodsname6.Text = foodsDGV.Rows(5).Cells(1).Value
                foodsname7.Text = foodsDGV.Rows(6).Cells(1).Value
                foodtypepanel1.Visible = True
                foodtypepanel2.Visible = True
                foodtypepanel3.Visible = True
                foodtypepanel4.Visible = True
                foodtypepanel5.Visible = True
                foodtypepanel6.Visible = True
                foodtypepanel7.Visible = True
                foodprice1.Text = foodsDGV.Rows(0).Cells(4).Value
                foodprice2.Text = foodsDGV.Rows(1).Cells(4).Value
                foodprice3.Text = foodsDGV.Rows(2).Cells(4).Value
                foodprice4.Text = foodsDGV.Rows(3).Cells(4).Value
                foodprice5.Text = foodsDGV.Rows(4).Cells(4).Value
                foodprice6.Text = foodsDGV.Rows(5).Cells(4).Value
                foodprice7.Text = foodsDGV.Rows(6).Cells(4).Value
                foodimg1.BackgroundImage = Image.FromFile("..\..\Resources\" & foodsDGV.Rows(0).Cells(6).Value & "")
                foodimg2.BackgroundImage = Image.FromFile("..\..\Resources\" & foodsDGV.Rows(1).Cells(6).Value & "")
                foodimg3.BackgroundImage = Image.FromFile("..\..\Resources\" & foodsDGV.Rows(2).Cells(6).Value & "")
                foodimg4.BackgroundImage = Image.FromFile("..\..\Resources\" & foodsDGV.Rows(3).Cells(6).Value & "")
                foodimg5.BackgroundImage = Image.FromFile("..\..\Resources\" & foodsDGV.Rows(4).Cells(6).Value & "")
                foodimg6.BackgroundImage = Image.FromFile("..\..\Resources\" & foodsDGV.Rows(5).Cells(6).Value & "")
                foodimg7.BackgroundImage = Image.FromFile("..\..\Resources\" & foodsDGV.Rows(6).Cells(6).Value & "")
            ElseIf foodsDGV.Rows.Count = 9 Then
                foodsname1.Text = foodsDGV.Rows(0).Cells(1).Value
                foodsname2.Text = foodsDGV.Rows(1).Cells(1).Value
                foodsname3.Text = foodsDGV.Rows(2).Cells(1).Value
                foodsname4.Text = foodsDGV.Rows(3).Cells(1).Value
                foodsname5.Text = foodsDGV.Rows(4).Cells(1).Value
                foodsname6.Text = foodsDGV.Rows(5).Cells(1).Value
                foodsname7.Text = foodsDGV.Rows(6).Cells(1).Value
                foodsname8.Text = foodsDGV.Rows(7).Cells(1).Value
                foodtypepanel1.Visible = True
                foodtypepanel2.Visible = True
                foodtypepanel3.Visible = True
                foodtypepanel4.Visible = True
                foodtypepanel5.Visible = True
                foodtypepanel6.Visible = True
                foodtypepanel7.Visible = True
                foodtypepanel8.Visible = True
                foodprice1.Text = foodsDGV.Rows(0).Cells(4).Value
                foodprice2.Text = foodsDGV.Rows(1).Cells(4).Value
                foodprice3.Text = foodsDGV.Rows(2).Cells(4).Value
                foodprice4.Text = foodsDGV.Rows(3).Cells(4).Value
                foodprice5.Text = foodsDGV.Rows(4).Cells(4).Value
                foodprice6.Text = foodsDGV.Rows(5).Cells(4).Value
                foodprice7.Text = foodsDGV.Rows(6).Cells(4).Value
                foodprice8.Text = foodsDGV.Rows(7).Cells(4).Value
                foodimg1.BackgroundImage = Image.FromFile("..\..\Resources\" & foodsDGV.Rows(0).Cells(6).Value & "")
                foodimg2.BackgroundImage = Image.FromFile("..\..\Resources\" & foodsDGV.Rows(1).Cells(6).Value & "")
                foodimg3.BackgroundImage = Image.FromFile("..\..\Resources\" & foodsDGV.Rows(2).Cells(6).Value & "")
                foodimg4.BackgroundImage = Image.FromFile("..\..\Resources\" & foodsDGV.Rows(3).Cells(6).Value & "")
                foodimg5.BackgroundImage = Image.FromFile("..\..\Resources\" & foodsDGV.Rows(4).Cells(6).Value & "")
                foodimg6.BackgroundImage = Image.FromFile("..\..\Resources\" & foodsDGV.Rows(5).Cells(6).Value & "")
                foodimg7.BackgroundImage = Image.FromFile("..\..\Resources\" & foodsDGV.Rows(6).Cells(6).Value & "")
                foodimg8.BackgroundImage = Image.FromFile("..\..\Resources\" & foodsDGV.Rows(7).Cells(6).Value & "")
            ElseIf foodsDGV.Rows.Count = 10 Then
                foodsname1.Text = foodsDGV.Rows(0).Cells(1).Value
                foodsname2.Text = foodsDGV.Rows(1).Cells(1).Value
                foodsname3.Text = foodsDGV.Rows(2).Cells(1).Value
                foodsname4.Text = foodsDGV.Rows(3).Cells(1).Value
                foodsname5.Text = foodsDGV.Rows(4).Cells(1).Value
                foodsname6.Text = foodsDGV.Rows(5).Cells(1).Value
                foodsname7.Text = foodsDGV.Rows(6).Cells(1).Value
                foodsname8.Text = foodsDGV.Rows(7).Cells(1).Value
                foodsname9.Text = foodsDGV.Rows(8).Cells(1).Value
                foodtypepanel1.Visible = True
                foodtypepanel2.Visible = True
                foodtypepanel3.Visible = True
                foodtypepanel4.Visible = True
                foodtypepanel5.Visible = True
                foodtypepanel6.Visible = True
                foodtypepanel7.Visible = True
                foodtypepanel8.Visible = True
                foodtypepanel9.Visible = True
                foodprice1.Text = foodsDGV.Rows(0).Cells(4).Value
                foodprice2.Text = foodsDGV.Rows(1).Cells(4).Value
                foodprice3.Text = foodsDGV.Rows(2).Cells(4).Value
                foodprice4.Text = foodsDGV.Rows(3).Cells(4).Value
                foodprice5.Text = foodsDGV.Rows(4).Cells(4).Value
                foodprice6.Text = foodsDGV.Rows(5).Cells(4).Value
                foodprice7.Text = foodsDGV.Rows(6).Cells(4).Value
                foodprice8.Text = foodsDGV.Rows(7).Cells(4).Value
                foodprice9.Text = foodsDGV.Rows(8).Cells(4).Value

                foodimg1.BackgroundImage = Image.FromFile("..\..\Resources\" & foodsDGV.Rows(0).Cells(6).Value & "")
                foodimg2.BackgroundImage = Image.FromFile("..\..\Resources\" & foodsDGV.Rows(1).Cells(6).Value & "")
                foodimg3.BackgroundImage = Image.FromFile("..\..\Resources\" & foodsDGV.Rows(2).Cells(6).Value & "")
                foodimg4.BackgroundImage = Image.FromFile("..\..\Resources\" & foodsDGV.Rows(3).Cells(6).Value & "")
                foodimg5.BackgroundImage = Image.FromFile("..\..\Resources\" & foodsDGV.Rows(4).Cells(6).Value & "")
                foodimg6.BackgroundImage = Image.FromFile("..\..\Resources\" & foodsDGV.Rows(5).Cells(6).Value & "")
                foodimg7.BackgroundImage = Image.FromFile("..\..\Resources\" & foodsDGV.Rows(6).Cells(6).Value & "")
                foodimg8.BackgroundImage = Image.FromFile("..\..\Resources\" & foodsDGV.Rows(7).Cells(6).Value & "")
                foodimg9.BackgroundImage = Image.FromFile("..\..\Resources\" & foodsDGV.Rows(8).Cells(6).Value & "")

            ElseIf foodsDGV.Rows.Count = 11 Then
                foodsname1.Text = foodsDGV.Rows(0).Cells(1).Value
                foodsname2.Text = foodsDGV.Rows(1).Cells(1).Value
                foodsname3.Text = foodsDGV.Rows(2).Cells(1).Value
                foodsname4.Text = foodsDGV.Rows(3).Cells(1).Value
                foodsname5.Text = foodsDGV.Rows(4).Cells(1).Value
                foodsname6.Text = foodsDGV.Rows(5).Cells(1).Value
                foodsname7.Text = foodsDGV.Rows(6).Cells(1).Value
                foodsname8.Text = foodsDGV.Rows(7).Cells(1).Value
                foodsname9.Text = foodsDGV.Rows(8).Cells(1).Value
                foodsname10.Text = foodsDGV.Rows(9).Cells(1).Value
                foodtypepanel1.Visible = True
                foodtypepanel2.Visible = True
                foodtypepanel3.Visible = True
                foodtypepanel4.Visible = True
                foodtypepanel5.Visible = True
                foodtypepanel6.Visible = True
                foodtypepanel7.Visible = True
                foodtypepanel8.Visible = True
                foodtypepanel9.Visible = True
                foodtypepanel10.Visible = True
                foodprice1.Text = foodsDGV.Rows(0).Cells(4).Value
                foodprice2.Text = foodsDGV.Rows(1).Cells(4).Value
                foodprice3.Text = foodsDGV.Rows(2).Cells(4).Value
                foodprice4.Text = foodsDGV.Rows(3).Cells(4).Value
                foodprice5.Text = foodsDGV.Rows(4).Cells(4).Value
                foodprice6.Text = foodsDGV.Rows(5).Cells(4).Value
                foodprice7.Text = foodsDGV.Rows(6).Cells(4).Value
                foodprice8.Text = foodsDGV.Rows(7).Cells(4).Value
                foodprice9.Text = foodsDGV.Rows(8).Cells(4).Value
                foodprice10.Text = foodsDGV.Rows(9).Cells(4).Value
                foodimg1.BackgroundImage = Image.FromFile("..\..\Resources\" & foodsDGV.Rows(0).Cells(6).Value & "")
                foodimg2.BackgroundImage = Image.FromFile("..\..\Resources\" & foodsDGV.Rows(1).Cells(6).Value & "")
                foodimg3.BackgroundImage = Image.FromFile("..\..\Resources\" & foodsDGV.Rows(2).Cells(6).Value & "")
                foodimg4.BackgroundImage = Image.FromFile("..\..\Resources\" & foodsDGV.Rows(3).Cells(6).Value & "")
                foodimg5.BackgroundImage = Image.FromFile("..\..\Resources\" & foodsDGV.Rows(4).Cells(6).Value & "")
                foodimg6.BackgroundImage = Image.FromFile("..\..\Resources\" & foodsDGV.Rows(5).Cells(6).Value & "")
                foodimg7.BackgroundImage = Image.FromFile("..\..\Resources\" & foodsDGV.Rows(6).Cells(6).Value & "")
                foodimg8.BackgroundImage = Image.FromFile("..\..\Resources\" & foodsDGV.Rows(7).Cells(6).Value & "")
                foodimg9.BackgroundImage = Image.FromFile("..\..\Resources\" & foodsDGV.Rows(8).Cells(6).Value & "")
                foodimg10.BackgroundImage = Image.FromFile("..\..\Resources\" & foodsDGV.Rows(9).Cells(6).Value & "")
            End If

            foodsCon.Close()
        End If
    End Sub
    Private Sub foodtypepanel1_Click(sender As Object, e As EventArgs) Handles foodtypepanel1.Click
        If foodtypepanel1.BackColor = Color.Transparent Then
            foodqty1.Value = 1
            foodtypepanel1.BackColor = Color.PaleTurquoise
            foodtypepanel1.ForeColor = Color.LightSeaGreen
        Else
            foodqty1.Value = 0
            foodtypepanel1.BackColor = Color.Transparent
        End If
    End Sub
    Private Sub foodimg1_Click(sender As Object, e As EventArgs) Handles foodimg1.Click
        foodtypepanel1_Click(sender, e)
    End Sub
    Private Sub foodsname1_Click(sender As Object, e As EventArgs) Handles foodsname1.Click
        foodtypepanel1_Click(sender, e)
    End Sub


End Class
