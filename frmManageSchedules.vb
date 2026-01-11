Imports MySql.Data.MySqlClient
Imports Org.BouncyCastle.Asn1.Cmp

Public Class frmManageSchedules

    Private Sub frmManageSchedules_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ' Make grid nicer
        dgvSchedules.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvSchedules.MultiSelect = False
        dgvSchedules.ReadOnly = True
        dgvSchedules.AutoGenerateColumns = True

        ' ❌ Prevent selecting past dates from picker
        dtpDate.MinDate = Date.Today

        LoadBuses()
        LoadRoutes()
        LoadSchedules()

    End Sub

    ' 🔐 Helper function: checks if selected schedule is in the past
    Private Function IsPastSchedule() As Boolean
        Dim selectedTripDateTime As DateTime =
            dtpDate.Value.Date.Add(dtpDeparture.Value.TimeOfDay)

        Return selectedTripDateTime < DateTime.Now
    End Function

    Private Sub LoadBuses()
        Using conn As MySqlConnection = DBHelper.GetConnection()
            Try
                conn.Open()
                Dim sql As String = "SELECT bus_id, plate_no, capacity FROM buses"
                Dim cmd As New MySqlCommand(sql, conn)
                Dim dt As New DataTable()
                dt.Load(cmd.ExecuteReader())

                cboBus.DataSource = dt
                cboBus.DisplayMember = "plate_no"
                cboBus.ValueMember = "bus_id"
            Catch ex As Exception
                MessageBox.Show("Error loading buses: " & ex.Message)
            End Try
        End Using
    End Sub

    Private Sub LoadRoutes()
        Using conn As MySqlConnection = DBHelper.GetConnection()
            Try
                conn.Open()
                Dim sql As String = "SELECT route_id, origin, destination, fare FROM routes"
                Dim cmd As New MySqlCommand(sql, conn)
                Dim dt As New DataTable()
                dt.Load(cmd.ExecuteReader())

                If Not dt.Columns.Contains("route_display") Then
                    dt.Columns.Add("route_display", GetType(String))
                End If

                For Each r As DataRow In dt.Rows
                    r("route_display") = r("origin").ToString() & " → " & r("destination").ToString()
                Next

                cboRoute.DataSource = dt
                cboRoute.DisplayMember = "route_display"
                cboRoute.ValueMember = "route_id"
            Catch ex As Exception
                MessageBox.Show("Error loading routes: " & ex.Message)
            End Try
        End Using
    End Sub

    Private Sub LoadSchedules()
        Using conn As MySqlConnection = DBHelper.GetConnection()
            Try
                conn.Open()

                Dim sql As String =
                "SELECT s.schedule_id, s.bus_id, b.plate_no AS Bus, " &
                "s.route_id, CONCAT(r.origin, ' → ', r.destination) AS Route, " &
                "r.fare AS Fare, s.trip_date AS TripDate, " &
                "TIME_FORMAT(s.departure_time, '%r') AS DepartureTime, " &
                "TIME_FORMAT(s.arrival_time, '%r') AS ArrivalTime, " &
                "s.status AS Status " &
                "FROM schedules s " &
                "JOIN buses b ON s.bus_id = b.bus_id " &
                "JOIN routes r ON s.route_id = r.route_id " &
                "ORDER BY s.trip_date, s.departure_time"

                Dim cmd As New MySqlCommand(sql, conn)
                Dim dt As New DataTable()
                dt.Load(cmd.ExecuteReader())

                dgvSchedules.DataSource = dt
                dgvSchedules.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill

                If dgvSchedules.Columns.Contains("TripDate") Then
                    dgvSchedules.Columns("TripDate").DefaultCellStyle.Format = "dd-MMM-yyyy"
                End If

            Catch ex As Exception
                MessageBox.Show("Error loading schedules: " & ex.Message)
            End Try
        End Using
    End Sub

    Private Sub cboRoute_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboRoute.SelectedIndexChanged
        Try
            Dim drv As DataRowView = TryCast(cboRoute.SelectedItem, DataRowView)
            If drv IsNot Nothing Then
                txtFare.Text = drv("fare").ToString()
            End If
        Catch
            txtFare.Text = ""
        End Try
    End Sub

    Private Sub btnAddSchedule_Click(sender As Object, e As EventArgs) Handles btnAddSchedule.Click
        Using conn As MySqlConnection = DBHelper.GetConnection()
            Try
                conn.Open()

                ' ❌ BLOCK past schedules
                If IsPastSchedule() Then
                    MessageBox.Show("You cannot add a schedule in the past.", "Invalid Schedule")
                    Exit Sub
                End If

                Dim tripDateTime As DateTime =
                    dtpDate.Value.Date.Add(dtpDeparture.Value.TimeOfDay)

                Dim tripStatus As String =
                    If(tripDateTime > DateTime.Now, "Scheduled", "Completed")

                Dim sql As String =
                    "INSERT INTO schedules (bus_id, route_id, trip_date, departure_time, arrival_time, status)
                     VALUES (@bus, @route, @date, @departure, @arrival, @status)"

                Dim cmd As New MySqlCommand(sql, conn)
                cmd.Parameters.AddWithValue("@bus", cboBus.SelectedValue)
                cmd.Parameters.AddWithValue("@route", cboRoute.SelectedValue)
                cmd.Parameters.AddWithValue("@date", dtpDate.Value.Date)
                cmd.Parameters.AddWithValue("@departure", dtpDeparture.Value.ToString("HH:mm:ss"))
                cmd.Parameters.AddWithValue("@arrival", dtpArrival.Value.ToString("HH:mm:ss"))
                cmd.Parameters.AddWithValue("@status", tripStatus)

                cmd.ExecuteNonQuery()

                MessageBox.Show("Schedule added successfully!")
                LoadSchedules()

            Catch ex As Exception
                MessageBox.Show("Error adding schedule: " & ex.Message)
            End Try
        End Using
    End Sub

    Private Sub btnUpdateSchedule_Click(sender As Object, e As EventArgs) Handles btnUpdateSchedule.Click
        If dgvSchedules.CurrentRow Is Nothing Then
            MessageBox.Show("Select a schedule to update.")
            Return
        End If

        Dim scheduleId As Integer =
            Convert.ToInt32(dgvSchedules.CurrentRow.Cells("schedule_id").Value)

        Using conn As MySqlConnection = DBHelper.GetConnection()
            Try
                conn.Open()

                ' ❌ BLOCK past updates
                If IsPastSchedule() Then
                    MessageBox.Show("You cannot update a schedule to a past date/time.")
                    Exit Sub
                End If

                Dim tripDateTime As DateTime =
                    dtpDate.Value.Date.Add(dtpDeparture.Value.TimeOfDay)

                Dim tripStatus As String =
                    If(tripDateTime > DateTime.Now, "Scheduled", "Completed")

                Dim sql As String =
                    "UPDATE schedules SET bus_id=@bus, route_id=@route, trip_date=@date,
                     departure_time=@departure, arrival_time=@arrival, status=@status
                     WHERE schedule_id=@id"

                Dim cmd As New MySqlCommand(sql, conn)
                cmd.Parameters.AddWithValue("@bus", cboBus.SelectedValue)
                cmd.Parameters.AddWithValue("@route", cboRoute.SelectedValue)
                cmd.Parameters.AddWithValue("@date", dtpDate.Value.Date)
                cmd.Parameters.AddWithValue("@departure", dtpDeparture.Value.ToString("HH:mm:ss"))
                cmd.Parameters.AddWithValue("@arrival", dtpArrival.Value.ToString("HH:mm:ss"))
                cmd.Parameters.AddWithValue("@status", tripStatus)
                cmd.Parameters.AddWithValue("@id", scheduleId)

                cmd.ExecuteNonQuery()

                MessageBox.Show("Schedule updated successfully!")
                LoadSchedules()

            Catch ex As Exception
                MessageBox.Show("Error updating schedule: " & ex.Message)
            End Try
        End Using
    End Sub

    Private Sub btnDeleteSchedule_Click(sender As Object, e As EventArgs) Handles btnDeleteSchedule.Click
        If dgvSchedules.CurrentRow Is Nothing Then Exit Sub

        Dim scheduleId As Integer =
            Convert.ToInt32(dgvSchedules.CurrentRow.Cells("schedule_id").Value)

        If MessageBox.Show("Delete this schedule?", "Confirm",
                           MessageBoxButtons.YesNo) = DialogResult.Yes Then
            Using conn As MySqlConnection = DBHelper.GetConnection()
                conn.Open()
                Dim cmd As New MySqlCommand(
                    "DELETE FROM schedules WHERE schedule_id=@id", conn)
                cmd.Parameters.AddWithValue("@id", scheduleId)
                cmd.ExecuteNonQuery()
                LoadSchedules()
            End Using
        End If
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

End Class

