Imports MySql.Data.MySqlClient
Imports System.Drawing

Public Class frmBookPassenger

    Private selectedSeat As Integer = -1

    Private Sub frmBookPassenger_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadSchedules()
    End Sub

    ' 🔹 Load available schedules
    Private Sub LoadSchedules()
        Using conn As MySqlConnection = DBHelper.GetConnection()
            Try
                conn.Open()
                Dim sql As String = "
                SELECT s.schedule_id, 
                       CONCAT(b.plate_no, ' - ', r.origin, ' → ', r.destination, ' (', s.trip_date, ')') AS ScheduleDisplay, 
                       r.fare 
                FROM schedules s 
                JOIN buses b ON s.bus_id = b.bus_id 
                JOIN routes r ON s.route_id = r.route_id 
                WHERE s.status IN ('Active', 'Scheduled')
                ORDER BY s.trip_date ASC, s.departure_time ASC"

                Dim cmd As New MySqlCommand(sql, conn)
                Dim dt As New DataTable()
                dt.Load(cmd.ExecuteReader())

                If dt.Rows.Count > 0 Then
                    cboSchedule.DataSource = dt
                    cboSchedule.DisplayMember = "ScheduleDisplay"
                    cboSchedule.ValueMember = "schedule_id"
                    cboSchedule.SelectedIndex = -1
                    txtFare.Clear()   ' 🔹 CLEAR fare explicitly
                    lblStatus.Text = $"{dt.Rows.Count} trips found and loaded."
                Else
                    cboSchedule.DataSource = Nothing
                    txtFare.Clear()
                    lblStatus.Text = "No active or scheduled trips found."
                End If

            Catch ex As Exception
                MessageBox.Show("Error loading schedules: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Using
    End Sub

    ' 🔹 Refresh trips
    Private Sub btnRefreshTrips_Click(sender As Object, e As EventArgs) Handles btnRefreshTrips.Click
        ' Reload schedules from database
        LoadSchedules()

        ' Clear passenger inputs
        txtPassenger.Clear()
        txtPhone.Clear()
        txtFare.Clear()

        ' Reset seat selection
        selectedSeat = -1
        pnlSeats.Controls.Clear()

        ' Reset schedule selection
        cboSchedule.SelectedIndex = -1

        lblStatus.Text = "Trips refreshed. Ready for a new booking."

    End Sub

    ' 🔹 Generate visual seat layout
    Private Sub GenerateSeatLayout(totalSeats As Integer, bookedSeats As List(Of Integer))
        pnlSeats.Controls.Clear()

        ' Layout parameters
        Dim btnSize As Integer = 40
        Dim spacing As Integer = 10
        Dim aisleWidth As Integer = 40
        Dim rows As Integer = 10  ' 10 rows of 2x2 = 40 seats
        Dim seatNumber As Integer = 1

        ' 🔹 Generate 10 rows (2 left, 2 right)
        For row As Integer = 0 To rows - 1
            ' Left side (2 seats)
            For col As Integer = 0 To 1
                CreateSeatButton(seatNumber, col, row, btnSize, spacing, aisleWidth, bookedSeats, False)
                seatNumber += 1
            Next

            ' Right side (2 seats)
            For col As Integer = 0 To 1
                CreateSeatButton(seatNumber, col, row, btnSize, spacing, aisleWidth, bookedSeats, True)
                seatNumber += 1
            Next
        Next

        ' 🔹 Add 5 seats at the back row
        Dim backRowY As Integer = rows * (btnSize + spacing) + 20
        Dim startX As Integer = 0
        Dim totalBackSeats As Integer = 5

        For i As Integer = 0 To totalBackSeats - 1
            Dim btn As New Button()
            btn.Text = seatNumber.ToString()
            btn.Width = btnSize
            btn.Height = btnSize
            btn.Left = startX + i * (btnSize + spacing)
            btn.Top = backRowY
            btn.Tag = seatNumber

            If bookedSeats.Contains(seatNumber) Then
                btn.BackColor = Color.Red
                btn.Enabled = False
            Else
                btn.BackColor = Color.LightGreen
                AddHandler btn.Click, AddressOf Seat_Click
            End If

            pnlSeats.Controls.Add(btn)
            seatNumber += 1
        Next
    End Sub

    Private Sub CreateSeatButton(seatNumber As Integer, col As Integer, row As Integer, btnSize As Integer, spacing As Integer, aisleWidth As Integer, bookedSeats As List(Of Integer), isRightSide As Boolean)
        Dim btn As New Button()
        btn.Text = seatNumber.ToString()
        btn.Width = btnSize
        btn.Height = btnSize

        ' Calculate X position (2 seats + aisle + 2 seats)
        Dim xOffset As Integer = If(isRightSide, (btnSize + spacing) * 2 + aisleWidth, 0)
        btn.Left = xOffset + col * (btnSize + spacing)
        btn.Top = row * (btnSize + spacing)
        btn.Tag = seatNumber

        ' Color for booked/unbooked seats
        If bookedSeats.Contains(seatNumber) Then
            btn.BackColor = Color.Red
            btn.Enabled = False
        Else
            btn.BackColor = Color.LightGreen
            AddHandler btn.Click, AddressOf Seat_Click
        End If

        pnlSeats.Controls.Add(btn)
    End Sub



    ' 🔹 When seat button clicked
    Private Sub Seat_Click(sender As Object, e As EventArgs)
        Dim btn As Button = CType(sender, Button)
        selectedSeat = CInt(btn.Tag)

        ' Reset all seats
        For Each ctrl As Control In pnlSeats.Controls
            If TypeOf ctrl Is Button AndAlso ctrl.Enabled Then
                ctrl.BackColor = Color.LightGreen
            End If
        Next

        ' Highlight selected
        btn.BackColor = Color.Yellow
        lblStatus.Text = "Selected seat: " & selectedSeat
    End Sub

    ' 🔹 Check available seats
    Private Sub btnCheckSeats_Click(sender As Object, e As EventArgs) Handles btnCheckSeats.Click
        If cboSchedule.SelectedIndex = -1 Then
            MessageBox.Show("Please select a trip first.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End If

        Dim selectedScheduleID As Integer = CInt(cboSchedule.SelectedValue)

        Using conn As MySqlConnection = DBHelper.GetConnection()
            conn.Open()
            Dim bookedSeats As New List(Of Integer)
            Dim sql As String = "SELECT seat_no FROM bookings WHERE schedule_id=@sid AND status='Booked'"
            Dim cmd As New MySqlCommand(sql, conn)
            cmd.Parameters.AddWithValue("@sid", selectedScheduleID)
            Dim rdr As MySqlDataReader = cmd.ExecuteReader()

            While rdr.Read()
                bookedSeats.Add(Convert.ToInt32(rdr("seat_no")))
            End While
            rdr.Close()

            GenerateSeatLayout(45, bookedSeats)
            lblStatus.Text = "Click a green seat to select."
        End Using
    End Sub

    ' 🔹 Update fare when schedule changes
    Private Sub cboSchedule_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboSchedule.SelectedIndexChanged
        If cboSchedule.SelectedIndex <> -1 Then
            Using conn As MySqlConnection = DBHelper.GetConnection()
                Try
                    conn.Open()
                    Dim sql As String = "SELECT r.fare FROM schedules s JOIN routes r ON s.route_id = r.route_id WHERE s.schedule_id=@sid"
                    Dim cmd As New MySqlCommand(sql, conn)
                    cmd.Parameters.AddWithValue("@sid", cboSchedule.SelectedValue)
                    Dim fare = cmd.ExecuteScalar()
                    txtFare.Text = If(fare IsNot Nothing, fare.ToString(), "0.00")
                Catch ex As Exception
                    MessageBox.Show("Error loading fare: " & ex.Message)
                End Try
            End Using
        End If
    End Sub

    ' 🔹 Book a seat
    Private Sub btnBook_Click(sender As Object, e As EventArgs) Handles btnBook.Click
        If cboSchedule.SelectedIndex = -1 Or selectedSeat = -1 Or txtPassenger.Text.Trim() = "" Then
            MessageBox.Show("Please fill all required fields before booking.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Using conn As MySqlConnection = DBHelper.GetConnection()
            conn.Open()

            ' Check if seat already booked
            Dim checkSql As String = "SELECT COUNT(*) FROM bookings WHERE schedule_id=@sid AND seat_no=@seat AND status='Booked'"
            Dim checkCmd As New MySqlCommand(checkSql, conn)
            checkCmd.Parameters.AddWithValue("@sid", cboSchedule.SelectedValue)
            checkCmd.Parameters.AddWithValue("@seat", selectedSeat)
            Dim exists As Integer = Convert.ToInt32(checkCmd.ExecuteScalar())

            If exists > 0 Then
                MessageBox.Show("This seat is already booked!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If

            ' Insert booking
            Dim sql As String = "INSERT INTO bookings (schedule_id, passenger_name, phone, seat_no, fare_paid, status, booked_at) 
                                 VALUES (@sid, @pname, @phone, @seat, @fare, 'Booked', NOW())"
            Dim cmd As New MySqlCommand(sql, conn)
            cmd.Parameters.AddWithValue("@sid", cboSchedule.SelectedValue)
            cmd.Parameters.AddWithValue("@pname", txtPassenger.Text.Trim())
            cmd.Parameters.AddWithValue("@phone", txtPhone.Text.Trim())
            cmd.Parameters.AddWithValue("@seat", selectedSeat)
            cmd.Parameters.AddWithValue("@fare", txtFare.Text.Trim())

            cmd.ExecuteNonQuery()

            MessageBox.Show("Booking successful! Ticket ready for printing.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            lblStatus.Text = "Seat " & selectedSeat & " booked successfully."

            ' Optionally open ticket form
            Dim ticketForm As New frmTicket(txtPassenger.Text, txtPhone.Text, selectedSeat.ToString(), txtFare.Text, cboSchedule.Text)
            ticketForm.ShowDialog()
        End Using
    End Sub

    ' 🔹 Close button
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Dim result As DialogResult = MessageBox.Show("Are you sure you want to close this window?", "Confirm Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = DialogResult.Yes Then
            Me.Close()
        End If
    End Sub


End Class
