Imports MySql.Data.MySqlClient

Public Class frmLogin
    ' --- PUBLIC/FORM CONTROLS NAMES REQUIRED ---
    ' txtUsername  (TextBox)
    ' txtPassword  (TextBox)
    ' btnLogin     (Button)
    ' btnExit      (Button)
    ' btnShowHide  (Button)  <-- toggles Show/Hide

    Private passwordVisible As Boolean = False

    Public Sub New()
        InitializeComponent()

        ' Ensure runtime event wiring in case the designer didn't
        AddHandler Me.Load, AddressOf frmLogin_Load
        AddHandler btnLogin.Click, AddressOf btnLogin_Click
        AddHandler btnExit.Click, AddressOf btnExit_Click
        AddHandler btnShowHide.Click, AddressOf btnShowHide_Click
    End Sub

    Private Sub frmLogin_Load(sender As Object, e As EventArgs)
        Try
            ' Ensure the password textbox exists
            If txtPassword IsNot Nothing Then
                txtPassword.UseSystemPasswordChar = True
            End If

            ' Ensure the Show/Hide button has initial text
            If btnShowHide IsNot Nothing Then
                btnShowHide.Text = "Show"
            End If
        Catch ex As Exception
            MessageBox.Show("frmLogin_Load error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs)
        Try
            Dim username As String = If(txtUsername?.Text, "").Trim()
            Dim password As String = If(txtPassword?.Text, "").Trim()

            If String.IsNullOrWhiteSpace(username) OrElse String.IsNullOrWhiteSpace(password) Then
                MessageBox.Show("Please enter both username and password.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If

            Dim hashed As String = PasswordHelper.HashPassword(password)

            Using conn As MySqlConnection = DBHelper.GetConnection()
                conn.Open()
                Dim sql As String = "SELECT role, fullname FROM users WHERE username=@u AND password_hash=@p"
                Dim cmd As New MySqlCommand(sql, conn)
                cmd.Parameters.AddWithValue("@u", username)
                cmd.Parameters.AddWithValue("@p", hashed)

                Dim rdr As MySqlDataReader = cmd.ExecuteReader()
                If rdr.Read() Then
                    Dim role As String = rdr("role").ToString()
                    Dim fullname As String = rdr("fullname").ToString()

                    CurrentUser = New UserSession() With {
                        .Username = username,
                        .FullName = fullname,
                        .Role = role
                    }

                    MessageBox.Show($"Welcome, {fullname}!", "Login Successful", MessageBoxButtons.OK, MessageBoxIcon.Information)

                    If role.Trim().ToLower() = "admin" Then
                        Dim frm As New frmAdminDashboard()
                        frm.Show()
                    Else
                        Dim frm As New frmClerkDashboard()
                        frm.Show()
                    End If

                    Me.Hide()
                Else
                    MessageBox.Show("Invalid username or password.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
                rdr.Close()
            End Using
        Catch ex As Exception
            MessageBox.Show("Login error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnShowHide_Click(sender As Object, e As EventArgs)
        Try
            ' If txtPassword does not exist, show error and return
            If txtPassword Is Nothing Then
                MessageBox.Show("txtPassword control not found. Make sure control name is txtPassword.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If

            passwordVisible = Not passwordVisible
            txtPassword.UseSystemPasswordChar = Not passwordVisible

            If btnShowHide IsNot Nothing Then
                btnShowHide.Text = If(passwordVisible, "Hide", "Show")
            End If
        Catch ex As Exception
            MessageBox.Show("Toggle error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs)
        Application.Exit()
    End Sub
End Class