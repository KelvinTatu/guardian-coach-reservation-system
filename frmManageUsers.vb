Imports MySql.Data.MySqlClient

Public Class frmManageUsers
    Private Sub frmManageUsers_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadUsers()
    End Sub

    ' ✅ Load all users into DataGridView
    Private Sub LoadUsers()
        Using conn As MySqlConnection = DBHelper.GetConnection()
            Try
                conn.Open()
                Dim sql As String = "SELECT user_id, fullname, username, role, created_at FROM users ORDER BY created_at DESC"
                Dim cmd As New MySqlCommand(sql, conn)
                Dim dt As New DataTable()
                dt.Load(cmd.ExecuteReader())
                dgvUsers.DataSource = dt
            Catch ex As Exception
                MessageBox.Show("Error loading users: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Using
    End Sub

    ' ✅ Add new user
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Dim fullname As String = txtFullname.Text.Trim()
        Dim username As String = txtUsername.Text.Trim()
        Dim password As String = txtPassword.Text.Trim()
        Dim role As String = cboRole.Text.Trim()

        If fullname = "" Or username = "" Or password = "" Or role = "" Then
            MessageBox.Show("Please fill all fields.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim hashedPass As String = PasswordHelper.HashPassword(password)

        Using conn As MySqlConnection = DBHelper.GetConnection()
            Try
                conn.Open()
                Dim checkSql As String = "SELECT COUNT(*) FROM users WHERE username=@u"
                Dim checkCmd As New MySqlCommand(checkSql, conn)
                checkCmd.Parameters.AddWithValue("@u", username)
                Dim exists As Integer = Convert.ToInt32(checkCmd.ExecuteScalar())
                If exists > 0 Then
                    MessageBox.Show("Username already exists.", "Duplicate", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    Return
                End If

                Dim sql As String = "INSERT INTO users(fullname, username, password_hash, role) VALUES(@f, @u, @p, @r)"
                Dim cmd As New MySqlCommand(sql, conn)
                cmd.Parameters.AddWithValue("@f", fullname)
                cmd.Parameters.AddWithValue("@u", username)
                cmd.Parameters.AddWithValue("@p", hashedPass)
                cmd.Parameters.AddWithValue("@r", role)
                cmd.ExecuteNonQuery()

                MessageBox.Show("User added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                LoadUsers()
                ClearFields()
            Catch ex As Exception
                MessageBox.Show("Error adding user: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Using
    End Sub

    ' ✅ Update user details
    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        If dgvUsers.CurrentRow Is Nothing Then
            MessageBox.Show("Please select a user to update.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim userId As Integer = Convert.ToInt32(dgvUsers.CurrentRow.Cells("user_id").Value)
        Dim fullname As String = txtFullname.Text.Trim()
        Dim username As String = txtUsername.Text.Trim()
        Dim password As String = txtPassword.Text.Trim()
        Dim role As String = cboRole.Text.Trim()

        If fullname = "" Or username = "" Or role = "" Then
            MessageBox.Show("Full name, username, and role are required.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim hashedPass As String = If(password = "", Nothing, PasswordHelper.HashPassword(password))

        Using conn As MySqlConnection = DBHelper.GetConnection()
            Try
                conn.Open()
                Dim sql As String

                If password = "" Then
                    sql = "UPDATE users SET fullname=@f, username=@u, role=@r WHERE user_id=@id"
                Else
                    sql = "UPDATE users SET fullname=@f, username=@u, password_hash=@p, role=@r WHERE user_id=@id"
                End If

                Dim cmd As New MySqlCommand(sql, conn)
                cmd.Parameters.AddWithValue("@f", fullname)
                cmd.Parameters.AddWithValue("@u", username)
                cmd.Parameters.AddWithValue("@r", role)
                cmd.Parameters.AddWithValue("@id", userId)
                If password <> "" Then cmd.Parameters.AddWithValue("@p", hashedPass)

                cmd.ExecuteNonQuery()
                MessageBox.Show("User updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                LoadUsers()
                ClearFields()
            Catch ex As Exception
                MessageBox.Show("Error updating user: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Using
    End Sub

    ' ✅ Delete user
    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If dgvUsers.CurrentRow Is Nothing Then
            MessageBox.Show("Please select a user to delete.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim userId As Integer = Convert.ToInt32(dgvUsers.CurrentRow.Cells("user_id").Value)
        If MessageBox.Show("Are you sure you want to delete this user?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.No Then
            Return
        End If

        Using conn As MySqlConnection = DBHelper.GetConnection()
            Try
                conn.Open()
                Dim sql As String = "DELETE FROM users WHERE user_id=@id"
                Dim cmd As New MySqlCommand(sql, conn)
                cmd.Parameters.AddWithValue("@id", userId)
                cmd.ExecuteNonQuery()

                MessageBox.Show("User deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                LoadUsers()
                ClearFields()
            Catch ex As Exception
                MessageBox.Show("Error deleting user: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Using
    End Sub

    ' ✅ Fill textboxes when selecting a row
    Private Sub dgvUsers_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvUsers.CellClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow = dgvUsers.Rows(e.RowIndex)
            txtFullname.Text = row.Cells("fullname").Value.ToString()
            txtUsername.Text = row.Cells("username").Value.ToString()
            cboRole.Text = row.Cells("role").Value.ToString()
            txtPassword.Clear() ' blank on select for security
        End If
    End Sub

    ' ✅ Clear fields
    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        ClearFields()
    End Sub

    Private Sub ClearFields()
        txtFullname.Clear()
        txtUsername.Clear()
        txtPassword.Clear()
        cboRole.SelectedIndex = -1
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Dim result As DialogResult = MessageBox.Show("Are you sure you want to close the Manage Users window?", "Confirm Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = DialogResult.Yes Then
            Me.Close()
        End If
    End Sub
End Class
