Imports MySql.Data.MySqlClient
Imports System.Data
Imports System.Drawing.Printing
Imports System.Text

Public Class frmReports
    Private WithEvents printDoc As New PrintDocument()
    Private printText As String = ""
    Private Sub frmReports_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Default: show reports for the last 7 days
        dtpStart.Value = DateTime.Now.AddDays(-7)
        dtpEnd.Value = DateTime.Now
    End Sub

    Private Sub btnLoadReport_Click(sender As Object, e As EventArgs) Handles btnLoadReport.Click
        LoadReport()
    End Sub
    Private Sub LoadReport()
        Using conn As MySqlConnection = DBHelper.GetConnection()
            Try
                conn.Open()

                Dim sql As String =
                "SELECT s.trip_date AS TripDate, b.plate_no AS Bus, " &
                "CONCAT(r.origin, ' → ', r.destination) AS Route, " &
                "r.fare AS Fare, COUNT(bk.booking_id) AS TotalBookings, " &
                "SUM(bk.fare_paid) AS TotalRevenue " &
                "FROM schedules s " &
                "JOIN buses b ON s.bus_id = b.bus_id " &
                "JOIN routes r ON s.route_id = r.route_id " &
                "LEFT JOIN bookings bk ON s.schedule_id = bk.schedule_id " &
                "WHERE s.trip_date BETWEEN @start AND @end " &
                "GROUP BY s.schedule_id " &
                "ORDER BY s.trip_date DESC"

                Dim cmd As New MySqlCommand(sql, conn)
                cmd.Parameters.AddWithValue("@start", dtpStart.Value.Date)
                cmd.Parameters.AddWithValue("@end", dtpEnd.Value.Date)

                Dim dt As New DataTable()
                dt.Load(cmd.ExecuteReader())
                dgvReport.DataSource = dt

                ' ✅ Format columns
                If dgvReport.Columns.Contains("Fare") Then
                    dgvReport.Columns("Fare").DefaultCellStyle.Format = "N2"
                End If
                If dgvReport.Columns.Contains("TotalRevenue") Then
                    dgvReport.Columns("TotalRevenue").DefaultCellStyle.Format = "N2"
                End If

                ' ✅ Calculate overall total revenue
                Dim totalRevenue As Decimal = 0
                For Each row As DataRow In dt.Rows
                    If Not IsDBNull(row("TotalRevenue")) Then
                        totalRevenue += Convert.ToDecimal(row("TotalRevenue"))
                    End If
                Next

                lblTotalRevenue.Text = "Total Revenue: KSh " & totalRevenue.ToString("N2")

            Catch ex As Exception
                MessageBox.Show("Error loading report: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Using
    End Sub
    Private Sub PreparePrintText()
        Dim sb As New StringBuilder()
        sb.AppendLine("Guardian Coach - Trip & Revenue Report")
        sb.AppendLine("Date Range: " & dtpStart.Value.ToShortDateString() & " to " & dtpEnd.Value.ToShortDateString())
        sb.AppendLine(New String("-"c, 80))
        sb.AppendLine(String.Format("{0,-12} {1,-10} {2,-30} {3,8} {4,10} {5,12}", "TripDate", "Bus", "Route", "Fare", "Bookings", "Revenue"))
        sb.AppendLine(New String("-"c, 80))

        For Each row As DataGridViewRow In dgvReport.Rows
            If Not row.IsNewRow Then
                sb.AppendLine(String.Format("{0,-12} {1,-10} {2,-30} {3,8:N0} {4,10:N0} {5,12:N0}",
                    row.Cells("TripDate").Value,
                    row.Cells("Bus").Value,
                    row.Cells("Route").Value,
                    row.Cells("Fare").Value,
                    row.Cells("TotalBookings").Value,
                    row.Cells("TotalRevenue").Value))
            End If
        Next

        sb.AppendLine(New String("-"c, 80))
        sb.AppendLine(lblTotalRevenue.Text)
        sb.AppendLine(vbCrLf & "Printed on: " & DateTime.Now.ToString("yyyy-MM-dd HH:mm"))
        printText = sb.ToString()
    End Sub

    Private Sub printDoc_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles printDoc.PrintPage
        Dim font As New Font("Consolas", 10)
        e.Graphics.DrawString(printText, font, Brushes.Black, 50, 50)
    End Sub

    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        PreparePrintText()
        Dim preview As New PrintPreviewDialog()
        preview.Document = printDoc
        preview.WindowState = FormWindowState.Maximized
        preview.ShowDialog()

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class