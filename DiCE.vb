Imports System.Data.OleDb
Imports System.Windows.Forms.DockStyle
Public Class FormDiCE
    Dim con As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\theod\Desktop\  \Projects\Visual Basic\DiCE\DiCEDatabase.accdb"
    Dim ds As New DataSet
    Dim da As OleDbDataAdapter
    Dim SQLstmtA, SQLstmtC, SQLstmtM, SQLstmtW As String
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles systemtime.Tick
        lbldate.Text = Date.Now.ToShortDateString
        lbltime.Text = TimeOfDay
    End Sub
    Private Sub FormDiCE_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1_Tick(sender, e)
        adminpanel.Hide()
        chefpanel.Hide()
        managerpanel.Hide()
        waiterpanel.Hide()
        txtpassword.Clear()
        txtusername.Clear()
        loginpanel.Dock = Fill

    End Sub
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
                If myredA.Read Then
                    txtid.Text = myredA.Item("ID").ToString
                ElseIf myredC.Read Then
                    txtid.Text = myredC.Item("ID").ToString
                ElseIf myredM.Read Then
                    txtid.Text = myredM.Item("ID").ToString
                ElseIf myredW.Read Then
                    txtid.Text = myredW.Item("ID").ToString
                End If
                If myredA.HasRows Then
                    If myredA.Item("Active").ToString = False Then
                        MsgBox("User has been Deactivated contact Administrator for Reactivation", MsgBoxStyle.Critical, "Warning!!!")
                    Else
                        lblrole.Text = myredA.Item("Role").ToString
                        adminpanel.Dock = Fill
                        adminpanel.Show()
                        chefpanel.Hide()
                        managerpanel.Hide()
                        waiterpanel.Hide()
                        LogInProcess()
                    End If
                    mycon.Close()
                    mycmdC.Connection.Open()
                ElseIf myredC.HasRows Then
                    If myredC.Item("Active").ToString = False Then
                        MsgBox("User has been Deactivated contact Administrator for Reactivation", MsgBoxStyle.Critical, "Warning!!!")
                    Else
                        lblrole.Text = myredC.Item("Role").ToString
                        chefpanel.Dock = Fill
                        chefpanel.Show()
                        adminpanel.Hide()
                        managerpanel.Hide()
                        waiterpanel.Hide()
                        LogInProcess()
                    End If
                    mycon.Close()
                    mycmdM.Connection.Open()
                ElseIf myredM.HasRows Then
                    If myredM.Item("Active").ToString = False Then
                        MsgBox("User has been Deactivated contact Administrator for Reactivation", MsgBoxStyle.Critical, "Warning!!!")
                    Else
                        lblrole.Text = myredM.Item("Role").ToString
                        managerpanel.Dock = Fill
                        managerpanel.Show()
                        adminpanel.Hide()
                        chefpanel.Hide()
                        waiterpanel.Hide()
                        LogInProcess()
                    End If
                    mycon.Close()
                    mycmdW.Connection.Open()
                ElseIf myredW.HasRows Then
                    If myredW.Item("Active").ToString = False Then
                        MsgBox("User has been Deactivated contact Administrator for Reactivation", MsgBoxStyle.Critical, "Warning!!!")
                    Else
                        lblrole.Text = myredW.Item("Role").ToString
                        waiterpanel.Dock = Fill
                        waiterpanel.Show()
                        adminpanel.Hide()
                        chefpanel.Hide()
                        managerpanel.Hide()
                        LogInProcess()
                    End If
                    mycon.Close()
                Else
                    btnpopup.Text = "Invalid Username or Password"
                    btnpopup.Show()
                    PopOut()
                    txtusername.Clear()
                    txtpassword.Clear()
                    txtusername.Focus()
                End If
            Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        ElseIf txtusername.Text = "" And txtpassword.Text = "" Then
            btnpopup.Text = "User Name and Password Fields are Empty"
            btnpopup.Show()
            PopOut()
        ElseIf txtusername.Text = "" Then
            btnpopup.Text = "The User Name Field is Empty "
            btnpopup.Show()
            PopOut()
        ElseIf txtpassword.Text = "" Then
            btnpopup.Text = "The Password Fiels is Empty"
            btnpopup.Show()
            PopOut()
        End If
    End Sub
    Public Sub PopOut()
        buttonhidetimer.Enabled = True
        buttonhidetimer.Interval = 3000
    End Sub
    Public Sub LogInProcess()
        lbluser.Text = txtusername.Text
        loginpanel.Hide()
        btnlogout.Show()
        btnpopup.Show()
        btnpopup.BackColor = Color.Aquamarine
        btnpopup.ForeColor = Color.DodgerBlue
        btnpopup.Text = "Login was Successful"
        PopOut()
    End Sub
    'Public Sub FadeOut()
    '    For fade = 90 To 10 Step -10
    '        btnpopup.Refresh()
    '        Threading.Thread.Sleep(50)
    '    Next
    'End Sub
    Private Sub btnlogout_Click(sender As Object, e As EventArgs) Handles btnlogout.Click
        If adminpanel.Visible = True Or chefpanel.Visible = True Or managerpanel.Visible = True Or waiterpanel.Visible = True Then
            lbluser.Text = "User"
            lblrole.Text = "role"
            btnpopup.Hide()
            txtusername.Clear()
            txtpassword.Clear()
            txtusername.Focus()
            btnlogout.Hide()
            loginpanel.Show()
            loginpanel.Dock = Fill
            txtusername.Focus()
            managerpanel.Hide()
            adminpanel.Hide()
            chefpanel.Hide()
            waiterpanel.Hide()
            btnpopup.Show()
            btnpopup.BackColor = Color.Aquamarine
            btnpopup.ForeColor = Color.DodgerBlue
            btnpopup.Text = "LogOut was Successful"
            PopOut()
        End If
    End Sub

    Private Sub btnpopup_Click(sender As Object, e As EventArgs) Handles btnpopup.Click
        btnpopup.Hide()
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles buttonhidetimer.Tick
        btnpopup.Hide()
    End Sub

End Class
