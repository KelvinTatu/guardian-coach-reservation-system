Public Class frmClerkDashboard
    Private Sub btnBookPassenger_Click(sender As Object, e As EventArgs) Handles btnBookPassenger.Click
        Dim frm As New frmBookPassenger()
        frm.ShowDialog()
    End Sub

    Private Sub btnViewBookings_Click(sender As Object, e As EventArgs) Handles btnViewBookings.Click
        Dim frm As New frmViewBookings()
        frm.ShowDialog()
    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        ' Show login form again
        Dim loginForm As New frmLogin()
        loginForm.Show()

        ' Close current dashboard
        Me.Close()
    End Sub

    Private Sub frmClerkDashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblUser.Text = "Logged in as: " & CurrentUser.FullName & " (" & CurrentUser.Role & ")"
        lblDateTime.Text = DateTime.Now.ToString("dd-MMM-yyyy hh:mm tt")
    End Sub
End Class