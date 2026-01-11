<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBookPassenger
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.lblSchedule = New System.Windows.Forms.Label()
        Me.lblPassenger = New System.Windows.Forms.Label()
        Me.lblPhone = New System.Windows.Forms.Label()
        Me.lblFare = New System.Windows.Forms.Label()
        Me.cboSchedule = New System.Windows.Forms.ComboBox()
        Me.txtPassenger = New System.Windows.Forms.TextBox()
        Me.txtPhone = New System.Windows.Forms.TextBox()
        Me.txtFare = New System.Windows.Forms.TextBox()
        Me.btnBook = New System.Windows.Forms.Button()
        Me.btnRefreshTrips = New System.Windows.Forms.Button()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.lblStatus = New System.Windows.Forms.ToolStripStatusLabel()
        Me.btnCheckSeats = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.pnlSeats = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.StatusStrip1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblTitle
        '
        Me.lblTitle.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Impact", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.ForeColor = System.Drawing.Color.Navy
        Me.lblTitle.Location = New System.Drawing.Point(13, 9)
        Me.lblTitle.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(592, 45)
        Me.lblTitle.TabIndex = 0
        Me.lblTitle.Text = "Guardian Coach Booking _Ticketing"
        '
        'lblSchedule
        '
        Me.lblSchedule.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblSchedule.AutoSize = True
        Me.lblSchedule.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSchedule.Location = New System.Drawing.Point(6, 48)
        Me.lblSchedule.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblSchedule.Name = "lblSchedule"
        Me.lblSchedule.Size = New System.Drawing.Size(154, 25)
        Me.lblSchedule.TabIndex = 1
        Me.lblSchedule.Text = "Select Schedule:"
        '
        'lblPassenger
        '
        Me.lblPassenger.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblPassenger.AutoSize = True
        Me.lblPassenger.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPassenger.Location = New System.Drawing.Point(6, 29)
        Me.lblPassenger.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblPassenger.Name = "lblPassenger"
        Me.lblPassenger.Size = New System.Drawing.Size(201, 25)
        Me.lblPassenger.TabIndex = 2
        Me.lblPassenger.Text = "Passenger Full Name:"
        '
        'lblPhone
        '
        Me.lblPhone.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblPhone.AutoSize = True
        Me.lblPhone.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPhone.Location = New System.Drawing.Point(53, 64)
        Me.lblPhone.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblPhone.Name = "lblPhone"
        Me.lblPhone.Size = New System.Drawing.Size(154, 25)
        Me.lblPhone.TabIndex = 3
        Me.lblPhone.Text = "Phone Number:"
        '
        'lblFare
        '
        Me.lblFare.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblFare.AutoSize = True
        Me.lblFare.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFare.Location = New System.Drawing.Point(53, 82)
        Me.lblFare.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblFare.Name = "lblFare"
        Me.lblFare.Size = New System.Drawing.Size(107, 25)
        Me.lblFare.TabIndex = 5
        Me.lblFare.Text = "Fare (KSh):"
        '
        'cboSchedule
        '
        Me.cboSchedule.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.cboSchedule.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboSchedule.FormattingEnabled = True
        Me.cboSchedule.Location = New System.Drawing.Point(156, 48)
        Me.cboSchedule.Margin = New System.Windows.Forms.Padding(4)
        Me.cboSchedule.Name = "cboSchedule"
        Me.cboSchedule.Size = New System.Drawing.Size(343, 25)
        Me.cboSchedule.TabIndex = 6
        '
        'txtPassenger
        '
        Me.txtPassenger.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtPassenger.Location = New System.Drawing.Point(208, 29)
        Me.txtPassenger.Margin = New System.Windows.Forms.Padding(4)
        Me.txtPassenger.Name = "txtPassenger"
        Me.txtPassenger.Size = New System.Drawing.Size(310, 27)
        Me.txtPassenger.TabIndex = 7
        '
        'txtPhone
        '
        Me.txtPhone.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtPhone.Location = New System.Drawing.Point(208, 66)
        Me.txtPhone.Margin = New System.Windows.Forms.Padding(4)
        Me.txtPhone.Name = "txtPhone"
        Me.txtPhone.Size = New System.Drawing.Size(171, 27)
        Me.txtPhone.TabIndex = 8
        '
        'txtFare
        '
        Me.txtFare.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtFare.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFare.Location = New System.Drawing.Point(156, 82)
        Me.txtFare.Margin = New System.Windows.Forms.Padding(4)
        Me.txtFare.Name = "txtFare"
        Me.txtFare.ReadOnly = True
        Me.txtFare.Size = New System.Drawing.Size(176, 25)
        Me.txtFare.TabIndex = 10
        '
        'btnBook
        '
        Me.btnBook.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnBook.BackColor = System.Drawing.Color.LimeGreen
        Me.btnBook.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBook.Location = New System.Drawing.Point(442, 98)
        Me.btnBook.Margin = New System.Windows.Forms.Padding(4)
        Me.btnBook.Name = "btnBook"
        Me.btnBook.Size = New System.Drawing.Size(76, 57)
        Me.btnBook.TabIndex = 11
        Me.btnBook.Text = "Book Ticket"
        Me.btnBook.UseVisualStyleBackColor = False
        '
        'btnRefreshTrips
        '
        Me.btnRefreshTrips.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnRefreshTrips.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRefreshTrips.Location = New System.Drawing.Point(208, 15)
        Me.btnRefreshTrips.Margin = New System.Windows.Forms.Padding(4)
        Me.btnRefreshTrips.Name = "btnRefreshTrips"
        Me.btnRefreshTrips.Size = New System.Drawing.Size(124, 27)
        Me.btnRefreshTrips.TabIndex = 13
        Me.btnRefreshTrips.Text = "Refresh Trips"
        Me.btnRefreshTrips.UseVisualStyleBackColor = True
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.lblStatus})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 383)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(1072, 22)
        Me.StatusStrip1.TabIndex = 15
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'lblStatus
        '
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(52, 17)
        Me.lblStatus.Text = "lblStatus"
        '
        'btnCheckSeats
        '
        Me.btnCheckSeats.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnCheckSeats.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCheckSeats.Location = New System.Drawing.Point(805, 30)
        Me.btnCheckSeats.Name = "btnCheckSeats"
        Me.btnCheckSeats.Size = New System.Drawing.Size(141, 40)
        Me.btnCheckSeats.TabIndex = 16
        Me.btnCheckSeats.Text = "Check Seats"
        Me.btnCheckSeats.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.GroupBox1.Controls.Add(Me.cboSchedule)
        Me.GroupBox1.Controls.Add(Me.lblSchedule)
        Me.GroupBox1.Controls.Add(Me.txtFare)
        Me.GroupBox1.Controls.Add(Me.lblFare)
        Me.GroupBox1.Controls.Add(Me.btnRefreshTrips)
        Me.GroupBox1.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(64, 72)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(538, 128)
        Me.GroupBox1.TabIndex = 17
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Trip Selection"
        '
        'GroupBox3
        '
        Me.GroupBox3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.GroupBox3.Controls.Add(Me.txtPassenger)
        Me.GroupBox3.Controls.Add(Me.btnClose)
        Me.GroupBox3.Controls.Add(Me.lblPassenger)
        Me.GroupBox3.Controls.Add(Me.lblPhone)
        Me.GroupBox3.Controls.Add(Me.txtPhone)
        Me.GroupBox3.Controls.Add(Me.btnBook)
        Me.GroupBox3.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(64, 206)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(538, 162)
        Me.GroupBox3.TabIndex = 19
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Passenger Details"
        '
        'btnClose
        '
        Me.btnClose.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnClose.BackColor = System.Drawing.Color.Red
        Me.btnClose.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.ForeColor = System.Drawing.Color.White
        Me.btnClose.Location = New System.Drawing.Point(356, 98)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(79, 57)
        Me.btnClose.TabIndex = 20
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = False
        '
        'pnlSeats
        '
        Me.pnlSeats.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.pnlSeats.AutoScroll = True
        Me.pnlSeats.BackColor = System.Drawing.Color.Transparent
        Me.pnlSeats.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlSeats.Location = New System.Drawing.Point(618, 72)
        Me.pnlSeats.Name = "pnlSeats"
        Me.pnlSeats.Size = New System.Drawing.Size(328, 292)
        Me.pnlSeats.TabIndex = 21
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(677, 37)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(122, 21)
        Me.Label1.TabIndex = 22
        Me.Label1.Text = "Seat Selection:"
        '
        'frmBookPassenger
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.BackgroundImage = Global.BusBookingSystem.My.Resources.Resources.clerkpiccc
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1072, 405)
        Me.Controls.Add(Me.btnCheckSeats)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.pnlSeats)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.lblTitle)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frmBookPassenger"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Guardian Coach - Manage Bookings"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblTitle As Label
    Friend WithEvents lblSchedule As Label
    Friend WithEvents lblPassenger As Label
    Friend WithEvents lblPhone As Label
    Friend WithEvents lblFare As Label
    Friend WithEvents cboSchedule As ComboBox
    Friend WithEvents txtPassenger As TextBox
    Friend WithEvents txtPhone As TextBox
    Friend WithEvents txtFare As TextBox
    Friend WithEvents btnBook As Button
    Friend WithEvents btnRefreshTrips As Button
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents lblStatus As ToolStripStatusLabel
    Friend WithEvents btnCheckSeats As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents btnClose As Button
    Friend WithEvents pnlSeats As Panel
    Friend WithEvents Label1 As Label
End Class
