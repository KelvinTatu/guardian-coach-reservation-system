<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTicket
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmTicket))
        Me.lblCompany = New System.Windows.Forms.Label()
        Me.lblTicketNo = New System.Windows.Forms.Label()
        Me.lblPassenger = New System.Windows.Forms.Label()
        Me.lblPhone = New System.Windows.Forms.Label()
        Me.lblBus = New System.Windows.Forms.Label()
        Me.lblRoute = New System.Windows.Forms.Label()
        Me.lblSeat = New System.Windows.Forms.Label()
        Me.lblFare = New System.Windows.Forms.Label()
        Me.lblBookedOn = New System.Windows.Forms.Label()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.PrintPreviewDialog1 = New System.Windows.Forms.PrintPreviewDialog()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.btnPrint = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblCompany
        '
        Me.lblCompany.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblCompany.AutoSize = True
        Me.lblCompany.Font = New System.Drawing.Font("Impact", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCompany.ForeColor = System.Drawing.Color.Black
        Me.lblCompany.Location = New System.Drawing.Point(46, 9)
        Me.lblCompany.Name = "lblCompany"
        Me.lblCompany.Size = New System.Drawing.Size(528, 60)
        Me.lblCompany.TabIndex = 0
        Me.lblCompany.Text = "THE GUARDIAN COACH LTD"
        '
        'lblTicketNo
        '
        Me.lblTicketNo.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblTicketNo.AutoSize = True
        Me.lblTicketNo.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTicketNo.Location = New System.Drawing.Point(55, 14)
        Me.lblTicketNo.Name = "lblTicketNo"
        Me.lblTicketNo.Size = New System.Drawing.Size(102, 25)
        Me.lblTicketNo.TabIndex = 1
        Me.lblTicketNo.Text = "Ticket No:"
        '
        'lblPassenger
        '
        Me.lblPassenger.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblPassenger.AutoSize = True
        Me.lblPassenger.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPassenger.Location = New System.Drawing.Point(49, 41)
        Me.lblPassenger.Name = "lblPassenger"
        Me.lblPassenger.Size = New System.Drawing.Size(108, 25)
        Me.lblPassenger.TabIndex = 2
        Me.lblPassenger.Text = "Passenger:"
        '
        'lblPhone
        '
        Me.lblPhone.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblPhone.AutoSize = True
        Me.lblPhone.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPhone.Location = New System.Drawing.Point(83, 70)
        Me.lblPhone.Name = "lblPhone"
        Me.lblPhone.Size = New System.Drawing.Size(74, 25)
        Me.lblPhone.TabIndex = 3
        Me.lblPhone.Text = "Phone:"
        '
        'lblBus
        '
        Me.lblBus.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblBus.AutoSize = True
        Me.lblBus.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBus.Location = New System.Drawing.Point(108, 96)
        Me.lblBus.Name = "lblBus"
        Me.lblBus.Size = New System.Drawing.Size(49, 25)
        Me.lblBus.TabIndex = 4
        Me.lblBus.Text = "Bus:"
        '
        'lblRoute
        '
        Me.lblRoute.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblRoute.AutoSize = True
        Me.lblRoute.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRoute.Location = New System.Drawing.Point(2, 126)
        Me.lblRoute.Name = "lblRoute"
        Me.lblRoute.Size = New System.Drawing.Size(155, 25)
        Me.lblRoute.TabIndex = 5
        Me.lblRoute.Text = "Route and Date:"
        '
        'lblSeat
        '
        Me.lblSeat.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblSeat.AutoSize = True
        Me.lblSeat.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSeat.Location = New System.Drawing.Point(102, 156)
        Me.lblSeat.Name = "lblSeat"
        Me.lblSeat.Size = New System.Drawing.Size(55, 25)
        Me.lblSeat.TabIndex = 6
        Me.lblSeat.Text = "Seat:"
        '
        'lblFare
        '
        Me.lblFare.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblFare.AutoSize = True
        Me.lblFare.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFare.Location = New System.Drawing.Point(103, 186)
        Me.lblFare.Name = "lblFare"
        Me.lblFare.Size = New System.Drawing.Size(54, 25)
        Me.lblFare.TabIndex = 7
        Me.lblFare.Text = "Fare:"
        '
        'lblBookedOn
        '
        Me.lblBookedOn.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblBookedOn.AutoSize = True
        Me.lblBookedOn.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBookedOn.Location = New System.Drawing.Point(42, 215)
        Me.lblBookedOn.Name = "lblBookedOn"
        Me.lblBookedOn.Size = New System.Drawing.Size(115, 25)
        Me.lblBookedOn.TabIndex = 9
        Me.lblBookedOn.Text = "Booked on:"
        '
        'PrintPreviewDialog1
        '
        Me.PrintPreviewDialog1.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.ClientSize = New System.Drawing.Size(400, 300)
        Me.PrintPreviewDialog1.Enabled = True
        Me.PrintPreviewDialog1.Icon = CType(resources.GetObject("PrintPreviewDialog1.Icon"), System.Drawing.Icon)
        Me.PrintPreviewDialog1.Name = "PrintPreviewDialog1"
        Me.PrintPreviewDialog1.Visible = False
        '
        'btnClose
        '
        Me.btnClose.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnClose.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.ForeColor = System.Drawing.Color.Red
        Me.btnClose.Location = New System.Drawing.Point(740, 31)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(75, 35)
        Me.btnClose.TabIndex = 10
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'btnPrint
        '
        Me.btnPrint.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnPrint.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrint.Location = New System.Drawing.Point(650, 31)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(75, 35)
        Me.btnPrint.TabIndex = 11
        Me.btnPrint.Text = "Print"
        Me.btnPrint.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.GroupBox1.Controls.Add(Me.lblBookedOn)
        Me.GroupBox1.Controls.Add(Me.lblFare)
        Me.GroupBox1.Controls.Add(Me.lblSeat)
        Me.GroupBox1.Controls.Add(Me.lblRoute)
        Me.GroupBox1.Controls.Add(Me.lblBus)
        Me.GroupBox1.Controls.Add(Me.lblPhone)
        Me.GroupBox1.Controls.Add(Me.lblPassenger)
        Me.GroupBox1.Controls.Add(Me.lblTicketNo)
        Me.GroupBox1.Location = New System.Drawing.Point(155, 72)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(660, 250)
        Me.GroupBox1.TabIndex = 12
        Me.GroupBox1.TabStop = False
        '
        'frmTicket
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(1062, 372)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnPrint)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.lblCompany)
        Me.Name = "frmTicket"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Guardian Coach - Ticket"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblCompany As Label
    Friend WithEvents lblTicketNo As Label
    Friend WithEvents lblPassenger As Label
    Friend WithEvents lblPhone As Label
    Friend WithEvents lblBus As Label
    Friend WithEvents lblRoute As Label
    Friend WithEvents lblSeat As Label
    Friend WithEvents lblFare As Label
    Friend WithEvents lblBookedOn As Label
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
    Friend WithEvents PrintPreviewDialog1 As PrintPreviewDialog
    Friend WithEvents btnClose As Button
    Friend WithEvents btnPrint As Button
    Friend WithEvents GroupBox1 As GroupBox
End Class
