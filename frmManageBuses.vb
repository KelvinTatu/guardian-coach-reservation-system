Imports MySql.Data.MySqlClient

Public Class frmManageBuses

    Private Sub frmManageBuses_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadBuses()
    End Sub

    ' 🔹 Load buses
    Private Sub LoadBuses()
        Using conn As MySqlConnection = DBHelper.GetConnection()
            Try
                conn.Open()
                Dim sql As String =
                    "SELECT bus_id, plate_no, capacity,
                            primary_driver_name,
                            secondary_driver_name
                     FROM buses"

                Dim da As New MySqlDataAdapter(sql, conn)
                Dim dt As New DataTable()
                da.Fill(dt)
                dgvBuses.DataSource = dt

            Catch ex As Exception
                MessageBox.Show("Error loading buses: " & ex.Message,
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Using
    End Sub

    ' 🔹 Add bus
    Private Sub btnAddBus_Click(sender As Object, e As EventArgs) Handles btnAddBus.Click

        ' Validation
        If txtBusNumber.Text = "" Or txtCapacity.Text = "" Or txtPrimaryDriver.Text = "" Then
            MessageBox.Show("Please enter Plate No, Capacity, and Primary Driver.",
                            "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Using conn As MySqlConnection = DBHelper.GetConnection()
            Try
                conn.Open()

                ' Check duplicate plate
                Dim checkSql As String = "SELECT COUNT(*) FROM buses WHERE plate_no=@plate"
                Dim checkCmd As New MySqlCommand(checkSql, conn)
                checkCmd.Parameters.AddWithValue("@plate", txtBusNumber.Text.Trim())

                If Convert.ToInt32(checkCmd.ExecuteScalar()) > 0 Then
                    MessageBox.Show("A bus with this Plate No already exists!",
                                    "Duplicate Entry", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    Return
                End If

                ' Insert bus
                Dim sql As String =
                    "INSERT INTO buses
                     (plate_no, capacity, primary_driver_name, secondary_driver_name)
                     VALUES (@plate, @cap, @pdriver, @sdriver)"

                Dim cmd As New MySqlCommand(sql, conn)
                cmd.Parameters.AddWithValue("@plate", txtBusNumber.Text.Trim())
                cmd.Parameters.AddWithValue("@cap", CInt(txtCapacity.Text.Trim()))
                cmd.Parameters.AddWithValue("@pdriver", txtPrimaryDriver.Text.Trim())
                cmd.Parameters.AddWithValue("@sdriver", txtSecondaryDriver.Text.Trim())

                cmd.ExecuteNonQuery()

                MessageBox.Show("Bus added successfully!",
                                "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

                LoadBuses()
                txtBusNumber.Clear()
                txtCapacity.Clear()
                txtPrimaryDriver.Clear()
                txtSecondaryDriver.Clear()

            Catch ex As Exception
                MessageBox.Show("Error adding bus: " & ex.Message,
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Using
    End Sub

    ' 🔹 Populate fields when grid row is clicked
    Private Sub dgvBuses_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvBuses.CellClick
        If e.RowIndex >= 0 AndAlso dgvBuses.CurrentRow IsNot Nothing Then
            Dim row As DataGridViewRow = dgvBuses.Rows(e.RowIndex)

            txtBusNumber.Text = row.Cells("plate_no").Value.ToString()
            txtCapacity.Text = row.Cells("capacity").Value.ToString()
            txtPrimaryDriver.Text = row.Cells("primary_driver_name").Value.ToString()
            txtSecondaryDriver.Text = row.Cells("secondary_driver_name").Value.ToString()
        End If
    End Sub

    ' 🔹 Update bus
    Private Sub btnUpdateBus_Click(sender As Object, e As EventArgs) Handles btnUpdateBus.Click

        If dgvBuses.CurrentRow Is Nothing Then
            MessageBox.Show("Please select a bus to update.",
                            "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        If txtBusNumber.Text = "" Or txtCapacity.Text = "" Or txtPrimaryDriver.Text = "" Then
            MessageBox.Show("Please enter Plate No, Capacity, and Primary Driver.",
                            "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim busId As Integer = Convert.ToInt32(dgvBuses.CurrentRow.Cells("bus_id").Value)

        Using conn As MySqlConnection = DBHelper.GetConnection()
            Try
                conn.Open()

                ' Check duplicate plate (exclude this bus)
                Dim checkSql As String =
                    "SELECT COUNT(*) FROM buses
                     WHERE plate_no=@plate AND bus_id<>@id"

                Dim checkCmd As New MySqlCommand(checkSql, conn)
                checkCmd.Parameters.AddWithValue("@plate", txtBusNumber.Text.Trim())
                checkCmd.Parameters.AddWithValue("@id", busId)

                If Convert.ToInt32(checkCmd.ExecuteScalar()) > 0 Then
                    MessageBox.Show("Another bus with this Plate No already exists!",
                                    "Duplicate Entry", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    Return
                End If

                ' Update bus
                Dim sql As String =
                    "UPDATE buses SET
                     plate_no=@plate,
                     capacity=@cap,
                     primary_driver_name=@pdriver,
                     secondary_driver_name=@sdriver
                     WHERE bus_id=@id"

                Dim cmd As New MySqlCommand(sql, conn)
                cmd.Parameters.AddWithValue("@plate", txtBusNumber.Text.Trim())
                cmd.Parameters.AddWithValue("@cap", CInt(txtCapacity.Text.Trim()))
                cmd.Parameters.AddWithValue("@pdriver", txtPrimaryDriver.Text.Trim())
                cmd.Parameters.AddWithValue("@sdriver", txtSecondaryDriver.Text.Trim())
                cmd.Parameters.AddWithValue("@id", busId)

                cmd.ExecuteNonQuery()

                MessageBox.Show("Bus updated successfully!",
                                "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

                LoadBuses()

            Catch ex As Exception
                MessageBox.Show("Error updating bus: " & ex.Message,
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Using
    End Sub

    ' 🔹 Delete bus
    Private Sub btnDeleteBus_Click(sender As Object, e As EventArgs) Handles btnDeleteBus.Click

        If dgvBuses.CurrentRow Is Nothing Then
            MessageBox.Show("Please select a bus to delete.",
                            "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim busId As Integer = Convert.ToInt32(dgvBuses.CurrentRow.Cells("bus_id").Value)

        If MessageBox.Show("Are you sure you want to delete this bus?",
                           "Confirm Delete",
                           MessageBoxButtons.YesNo,
                           MessageBoxIcon.Question) = DialogResult.Yes Then

            Using conn As MySqlConnection = DBHelper.GetConnection()
                Try
                    conn.Open()
                    Dim cmd As New MySqlCommand(
                        "DELETE FROM buses WHERE bus_id=@id", conn)
                    cmd.Parameters.AddWithValue("@id", busId)
                    cmd.ExecuteNonQuery()

                    MessageBox.Show("Bus deleted successfully!",
                                    "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    LoadBuses()

                Catch ex As Exception
                    MessageBox.Show("Error deleting bus: " & ex.Message,
                                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            End Using
        End If
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

End Class

