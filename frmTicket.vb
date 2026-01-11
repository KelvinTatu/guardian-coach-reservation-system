Imports System.Drawing.Printing

Public Class frmTicket
    Private passengerName As String
    Private phone As String
    Private seatNo As String
    Private fare As String
    Private tripInfo As String
    Private bookedBy As String

    Private WithEvents printDoc As New PrintDocument()

    ' Constructor
    Public Sub New(pName As String, pPhone As String, pSeat As String, pFare As String, pTrip As String)
        InitializeComponent()
        passengerName = pName
        phone = pPhone
        seatNo = pSeat
        fare = pFare
        tripInfo = pTrip
    End Sub

    ' Load form
    Private Sub frmTicket_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblCompany.Text = "GUARDIAN COACH LTD"
        lblTicketNo.Text = "Ticket No: " & "BK-" & Format(Now, "yyMMddHHmm")
        lblPassenger.Text = "Passenger: " & passengerName
        lblPhone.Text = "Phone: " & phone
        lblSeat.Text = "Seat No: " & seatNo
        lblFare.Text = "Fare: Ksh " & fare
        lblRoute.Text = "Route: " & tripInfo
        lblBus.Text = "Bus: " & tripInfo.Split("-"c)(0).Trim()
        lblBookedOn.Text = "Booked On: " & DateTime.Now.ToString("dd-MMM-yyyy hh:mm tt")
    End Sub

    ' ✅ Fast direct print
    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        Try
            printDoc.PrinterSettings = New PrinterSettings()
            printDoc.Print() ' Direct print, no preview
            MessageBox.Show("Ticket sent to printer successfully!", "Printed", MessageBoxButtons.OK, MessageBoxIcon.Information)

            ' Optional auto-close
            Me.Close()

        Catch ex As Exception
            MessageBox.Show("Printing failed: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' 🖨️ Print layout
    Private Sub printDoc_PrintPage(sender As Object, e As PrintPageEventArgs) Handles printDoc.PrintPage
        Dim fntTitle As New Font("Arial", 14, FontStyle.Bold)
        Dim fntBody As New Font("Consolas", 10)
        Dim y As Integer = 60

        ' Title
        e.Graphics.DrawString("GUARDIAN COACH LTD", fntTitle, Brushes.Black, 180, y)
        y += 40
        e.Graphics.DrawString("Booking & Seat Reservation Ticket", fntBody, Brushes.Black, 160, y)
        y += 40

        ' Ticket Info
        e.Graphics.DrawString(lblTicketNo.Text, fntBody, Brushes.Black, 60, y) : y += 25
        e.Graphics.DrawString(lblPassenger.Text, fntBody, Brushes.Black, 60, y) : y += 25
        e.Graphics.DrawString(lblPhone.Text, fntBody, Brushes.Black, 60, y) : y += 25
        e.Graphics.DrawString(lblBus.Text, fntBody, Brushes.Black, 60, y) : y += 25
        e.Graphics.DrawString(lblRoute.Text, fntBody, Brushes.Black, 60, y) : y += 25
        e.Graphics.DrawString(lblSeat.Text, fntBody, Brushes.Black, 60, y) : y += 25
        e.Graphics.DrawString(lblFare.Text, fntBody, Brushes.Black, 60, y) : y += 25
        e.Graphics.DrawString(lblBookedOn.Text, fntBody, Brushes.Black, 60, y) : y += 25

        ' Footer
        e.Graphics.DrawString("Thank you for choosing Guardian Coach!", fntBody, Brushes.Black, 100, y)
    End Sub

    ' Close button
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub
End Class
