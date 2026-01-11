Imports MySql.Data.MySqlClient

Public Class frmManageRoutes
    Private Sub frmManageRoutes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadRoutes()
    End Sub

    ' Function to fetch routes from DB
    Private Sub LoadRoutes()
        Using conn As MySqlConnection = DBHelper.GetConnection()
            Try
                conn.Open()
                Dim sql As String = "SELECT route_id, origin, destination, fare FROM routes"
                Dim da As New MySqlDataAdapter(sql, conn)
                Dim dt As New DataTable()
                da.Fill(dt)
                dgvRoutes.DataSource = dt
            Catch ex As Exception
                MessageBox.Show("Error loading routes: " & ex.Message)
            End Try
        End Using
    End Sub

    Private Sub btnAddRoute_Click(sender As Object, e As EventArgs) Handles btnAddRoute.Click
        ' Basic validation
        If txtOrigin.Text = "" Or txtDestination.Text = "" Or txtFare.Text = "" Then
            MessageBox.Show("Please enter Origin, Destination, and Fare.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Using conn As MySqlConnection = DBHelper.GetConnection()
            Try
                conn.Open()

                ' 🔹 Check for duplicate (Origin + Destination only)
                Dim checkSql As String = "SELECT COUNT(*) FROM routes WHERE origin=@origin AND destination=@destination"
                Dim checkCmd As New MySqlCommand(checkSql, conn)
                checkCmd.Parameters.AddWithValue("@origin", txtOrigin.Text.Trim())
                checkCmd.Parameters.AddWithValue("@destination", txtDestination.Text.Trim())
                Dim count As Integer = Convert.ToInt32(checkCmd.ExecuteScalar())

                If count > 0 Then
                    MessageBox.Show("This route already exists! You can update the fare instead.", "Duplicate Entry", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    Return
                End If

                ' 🔹 Insert new route
                Dim sql As String = "INSERT INTO routes (origin, destination, fare) VALUES (@origin, @destination, @fare)"
                Dim cmd As New MySqlCommand(sql, conn)
                cmd.Parameters.AddWithValue("@origin", txtOrigin.Text.Trim())
                cmd.Parameters.AddWithValue("@destination", txtDestination.Text.Trim())
                cmd.Parameters.AddWithValue("@fare", CDec(txtFare.Text.Trim()))
                cmd.ExecuteNonQuery()

                MessageBox.Show("Route added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

                LoadRoutes()
                txtOrigin.Clear()
                txtDestination.Clear()
                txtFare.Clear()

            Catch ex As Exception
                MessageBox.Show("Error adding route: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Using
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub dgvRoutes_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvRoutes.CellClick
        ' Prevent errors when clicking header row
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow = dgvRoutes.Rows(e.RowIndex)

            ' Fill textboxes with row values
            txtOrigin.Text = row.Cells("origin").Value.ToString()
            txtDestination.Text = row.Cells("destination").Value.ToString()
            txtFare.Text = row.Cells("fare").Value.ToString()
        End If
    End Sub

    Private Sub btnUpdateRoute_Click(sender As Object, e As EventArgs) Handles btnUpdateRoute.Click
        If dgvRoutes.CurrentRow Is Nothing Then
            MessageBox.Show("Please select a route to update.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        If txtOrigin.Text = "" Or txtDestination.Text = "" Or txtFare.Text = "" Then
            MessageBox.Show("Please enter Origin, Destination, and Fare.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim routeId As Integer = Convert.ToInt32(dgvRoutes.CurrentRow.Cells("route_id").Value)

        Using conn As MySqlConnection = DBHelper.GetConnection()
            Try
                conn.Open()

                ' 🔹 Check if another route with same Origin + Destination + Fare exists
                Dim checkSql As String = "SELECT COUNT(*) FROM routes WHERE origin=@origin AND destination=@destination AND fare=@fare AND route_id<>@id"
                Dim checkCmd As New MySqlCommand(checkSql, conn)
                checkCmd.Parameters.AddWithValue("@origin", txtOrigin.Text.Trim())
                checkCmd.Parameters.AddWithValue("@destination", txtDestination.Text.Trim())
                checkCmd.Parameters.AddWithValue("@fare", CDec(txtFare.Text.Trim()))
                checkCmd.Parameters.AddWithValue("@id", routeId)
                Dim count As Integer = Convert.ToInt32(checkCmd.ExecuteScalar())

                If count > 0 Then
                    MessageBox.Show("Another route with the same fare already exists!", "Duplicate Entry", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    Return
                End If

                ' 🔹 Proceed with update
                Dim sql As String = "UPDATE routes SET origin=@origin, destination=@destination, fare=@fare WHERE route_id=@id"
                Dim cmd As New MySqlCommand(sql, conn)
                cmd.Parameters.AddWithValue("@origin", txtOrigin.Text.Trim())
                cmd.Parameters.AddWithValue("@destination", txtDestination.Text.Trim())
                cmd.Parameters.AddWithValue("@fare", CDec(txtFare.Text.Trim()))
                cmd.Parameters.AddWithValue("@id", routeId)
                cmd.ExecuteNonQuery()

                MessageBox.Show("Route updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

                LoadRoutes()
            Catch ex As Exception
                MessageBox.Show("Error updating route: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Using
    End Sub

    Private Sub btnDeleteRoute_Click(sender As Object, e As EventArgs) Handles btnDeleteRoute.Click
        If dgvRoutes.CurrentRow Is Nothing Then
            MessageBox.Show("Please select a route to delete.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim routeId As Integer = Convert.ToInt32(dgvRoutes.CurrentRow.Cells("route_id").Value)

        ' Confirm before deleting
        If MessageBox.Show("Are you sure you want to delete this route?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            Using conn As MySqlConnection = DBHelper.GetConnection()
                Try
                    conn.Open()
                    Dim sql As String = "DELETE FROM routes WHERE route_id=@id"
                    Dim cmd As New MySqlCommand(sql, conn)
                    cmd.Parameters.AddWithValue("@id", routeId)
                    cmd.ExecuteNonQuery()

                    MessageBox.Show("Route deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

                    LoadRoutes()
                Catch ex As Exception
                    MessageBox.Show("Error deleting route: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            End Using
        End If
    End Sub
End Class