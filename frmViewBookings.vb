Imports MySql.Data.MySqlClient

Public Class frmViewBookings

    Private Sub frmViewBookings_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Fill status filter options
        cboFilterStatus.Items.Clear()
        cboFilterStatus.Items.Add("All")
        cboFilterStatus.Items.Add("Booked")
        cboFilterStatus.Items.Add("Cancelled")
        cboFilterStatus.SelectedIndex = 0

        LoadBookings()
    End Sub

    Private Sub LoadBookings(Optional searchTerm As String = "", Optional tripDate As String = "", Optional statusFilter As String = "All")
        Using conn As MySqlConnection = DBHelper.GetConnection()
            Try
                conn.Open()

                Dim sql As String = "
                    SELECT b.booking_id, b.passenger_name, b.phone, b.seat_no, r.origin, r.destination, 
                           s.trip_date, s.departure_time, b.fare_paid, b.status
                    FROM bookings b
                    JOIN schedules s ON b.schedule_id = s.schedule_id
                    JOIN routes r ON s.route_id = r.route_id
                    WHERE 1=1"

                ' Optional filters
                If searchTerm <> "" Then
                    sql &= " AND (b.passenger_name LIKE @search OR b.phone LIKE @search)"
                End If
                If tripDate <> "" Then
                    sql &= " AND DATE(s.trip_date) = @tripDate"
                End If
                If statusFilter <> "All" Then
                    sql &= " AND b.status = @status"
                End If

                sql &= " ORDER BY s.trip_date DESC, s.departure_time DESC"

                Dim cmd As New MySqlCommand(sql, conn)
                If searchTerm <> "" Then cmd.Parameters.AddWithValue("@search", "%" & searchTerm & "%")
                If tripDate <> "" Then cmd.Parameters.AddWithValue("@tripDate", tripDate)
                If statusFilter <> "All" Then cmd.Parameters.AddWithValue("@status", statusFilter)

                Dim dt As New DataTable()
                dt.Load(cmd.ExecuteReader())
                dgvViewBookings.DataSource = dt

            Catch ex As Exception
                MessageBox.Show("Error loading bookings: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Using
    End Sub

    ' 🔍 Search Button
    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        LoadBookings(txtSearch.Text.Trim(), "", cboFilterStatus.Text)
    End Sub

    ' 📅 Apply Filters Button
    Private Sub btnApplyFilters_Click(sender As Object, e As EventArgs) Handles btnApplyFilters.Click
        Dim tripDate As String = dtpTripDate.Value.ToString("yyyy-MM-dd")
        LoadBookings(txtSearch.Text.Trim(), tripDate, cboFilterStatus.Text)
    End Sub

    ' ❌ Cancel Booking Button
    Private Sub btnCancelBooking_Click(sender As Object, e As EventArgs) Handles btnCancelBooking.Click
        If dgvViewBookings.SelectedRows.Count = 0 Then
            MessageBox.Show("Please select a booking to cancel.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End If

        Dim bookingId As Integer = dgvViewBookings.SelectedRows(0).Cells("booking_id").Value

        Using conn As MySqlConnection = DBHelper.GetConnection()
            conn.Open()
            Dim sql As String = "UPDATE bookings SET status='Cancelled' WHERE booking_id=@bid"
            Dim cmd As New MySqlCommand(sql, conn)
            cmd.Parameters.AddWithValue("@bid", bookingId)
            cmd.ExecuteNonQuery()
        End Using

        MessageBox.Show("Booking cancelled successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
        LoadBookings()
    End Sub

    ' 🚪 Close Button
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub


End Class