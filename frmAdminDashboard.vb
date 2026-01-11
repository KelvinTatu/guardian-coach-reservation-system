Public Class frmAdminDashboard
    Private Sub frmAdminDashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        ' Show login form again
        Dim loginForm As New frmLogin()
        loginForm.Show()

        ' Close current dashboard
        Me.Close()
    End Sub

    Private Sub btnManageBuses_Click(sender As Object, e As EventArgs) Handles btnManageBuses.Click
        Dim frm As New frmManageBuses()
        frm.ShowDialog()
    End Sub

    Private Sub btnManageRoutes_Click(sender As Object, e As EventArgs) Handles btnManageRoutes.Click
        Dim frm As New frmManageRoutes()
        frm.ShowDialog()
    End Sub

    Private Sub btnManageSchedules_Click(sender As Object, e As EventArgs) Handles btnManageSchedules.Click
        Dim frm As New frmManageSchedules()
        frm.ShowDialog()
    End Sub

    Private Sub btnManageUsers_Click(sender As Object, e As EventArgs) Handles btnManageUsers.Click
        Dim frm As New frmManageUsers()
        frm.ShowDialog()
    End Sub

    Private Sub btnReports_Click(sender As Object, e As EventArgs) Handles btnReports.Click
        Dim frm As New frmReports()
        frm.ShowDialog()
    End Sub
End Class