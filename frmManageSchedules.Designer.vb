<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmManageSchedules
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.lblBus = New System.Windows.Forms.Label()
        Me.cboBus = New System.Windows.Forms.ComboBox()
        Me.lblRoute = New System.Windows.Forms.Label()
        Me.cboRoute = New System.Windows.Forms.ComboBox()
        Me.lblDate = New System.Windows.Forms.Label()
        Me.dtpDate = New System.Windows.Forms.DateTimePicker()
        Me.lblTime = New System.Windows.Forms.Label()
        Me.dtpDeparture = New System.Windows.Forms.DateTimePicker()
        Me.lblFare = New System.Windows.Forms.Label()
        Me.txtFare = New System.Windows.Forms.TextBox()
        Me.btnAddSchedule = New System.Windows.Forms.Button()
        Me.btnUpdateSchedule = New System.Windows.Forms.Button()
        Me.btnDeleteSchedule = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.dgvSchedules = New System.Windows.Forms.DataGridView()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lblatime = New System.Windows.Forms.Label()
        Me.dtpArrival = New System.Windows.Forms.DateTimePicker()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        CType(Me.dgvSchedules, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblBus
        '
        Me.lblBus.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblBus.AutoSize = True
        Me.lblBus.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBus.Location = New System.Drawing.Point(32, 24)
        Me.lblBus.Name = "lblBus"
        Me.lblBus.Size = New System.Drawing.Size(49, 25)
        Me.lblBus.TabIndex = 0
        Me.lblBus.Text = "Bus:"
        '
        'cboBus
        '
        Me.cboBus.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.cboBus.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboBus.FormattingEnabled = True
        Me.cboBus.Location = New System.Drawing.Point(74, 25)
        Me.cboBus.Name = "cboBus"
        Me.cboBus.Size = New System.Drawing.Size(128, 24)
        Me.cboBus.TabIndex = 1
        '
        'lblRoute
        '
        Me.lblRoute.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblRoute.AutoSize = True
        Me.lblRoute.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRoute.Location = New System.Drawing.Point(11, 67)
        Me.lblRoute.Name = "lblRoute"
        Me.lblRoute.Size = New System.Drawing.Size(70, 25)
        Me.lblRoute.TabIndex = 2
        Me.lblRoute.Text = "Route:"
        '
        'cboRoute
        '
        Me.cboRoute.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.cboRoute.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboRoute.FormattingEnabled = True
        Me.cboRoute.Location = New System.Drawing.Point(74, 68)
        Me.cboRoute.Name = "cboRoute"
        Me.cboRoute.Size = New System.Drawing.Size(128, 24)
        Me.cboRoute.TabIndex = 3
        '
        'lblDate
        '
        Me.lblDate.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblDate.AutoSize = True
        Me.lblDate.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDate.Location = New System.Drawing.Point(276, 24)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(98, 25)
        Me.lblDate.TabIndex = 4
        Me.lblDate.Text = "Trip Date:"
        '
        'dtpDate
        '
        Me.dtpDate.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.dtpDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpDate.Location = New System.Drawing.Point(370, 27)
        Me.dtpDate.Name = "dtpDate"
        Me.dtpDate.Size = New System.Drawing.Size(207, 22)
        Me.dtpDate.TabIndex = 5
        '
        'lblTime
        '
        Me.lblTime.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblTime.AutoSize = True
        Me.lblTime.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTime.Location = New System.Drawing.Point(217, 67)
        Me.lblTime.Name = "lblTime"
        Me.lblTime.Size = New System.Drawing.Size(157, 25)
        Me.lblTime.TabIndex = 6
        Me.lblTime.Text = "Departure Time:"
        '
        'dtpDeparture
        '
        Me.dtpDeparture.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.dtpDeparture.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpDeparture.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.dtpDeparture.Location = New System.Drawing.Point(370, 70)
        Me.dtpDeparture.Name = "dtpDeparture"
        Me.dtpDeparture.ShowUpDown = True
        Me.dtpDeparture.Size = New System.Drawing.Size(92, 22)
        Me.dtpDeparture.TabIndex = 7
        '
        'lblFare
        '
        Me.lblFare.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblFare.AutoSize = True
        Me.lblFare.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFare.Location = New System.Drawing.Point(27, 114)
        Me.lblFare.Name = "lblFare"
        Me.lblFare.Size = New System.Drawing.Size(54, 25)
        Me.lblFare.TabIndex = 8
        Me.lblFare.Text = "Fare:"
        '
        'txtFare
        '
        Me.txtFare.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtFare.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFare.Location = New System.Drawing.Point(74, 116)
        Me.txtFare.Name = "txtFare"
        Me.txtFare.ReadOnly = True
        Me.txtFare.Size = New System.Drawing.Size(128, 22)
        Me.txtFare.TabIndex = 9
        '
        'btnAddSchedule
        '
        Me.btnAddSchedule.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnAddSchedule.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddSchedule.Location = New System.Drawing.Point(26, 15)
        Me.btnAddSchedule.Name = "btnAddSchedule"
        Me.btnAddSchedule.Size = New System.Drawing.Size(103, 34)
        Me.btnAddSchedule.TabIndex = 10
        Me.btnAddSchedule.Text = "Add"
        Me.btnAddSchedule.UseVisualStyleBackColor = True
        '
        'btnUpdateSchedule
        '
        Me.btnUpdateSchedule.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnUpdateSchedule.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdateSchedule.Location = New System.Drawing.Point(26, 54)
        Me.btnUpdateSchedule.Name = "btnUpdateSchedule"
        Me.btnUpdateSchedule.Size = New System.Drawing.Size(103, 34)
        Me.btnUpdateSchedule.TabIndex = 11
        Me.btnUpdateSchedule.Text = "Update"
        Me.btnUpdateSchedule.UseVisualStyleBackColor = True
        '
        'btnDeleteSchedule
        '
        Me.btnDeleteSchedule.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnDeleteSchedule.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDeleteSchedule.Location = New System.Drawing.Point(26, 94)
        Me.btnDeleteSchedule.Name = "btnDeleteSchedule"
        Me.btnDeleteSchedule.Size = New System.Drawing.Size(103, 31)
        Me.btnDeleteSchedule.TabIndex = 12
        Me.btnDeleteSchedule.Text = "Delete"
        Me.btnDeleteSchedule.UseVisualStyleBackColor = True
        '
        'btnClose
        '
        Me.btnClose.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnClose.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.ForeColor = System.Drawing.Color.Red
        Me.btnClose.Location = New System.Drawing.Point(26, 132)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(103, 31)
        Me.btnClose.TabIndex = 13
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'dgvSchedules
        '
        Me.dgvSchedules.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.dgvSchedules.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvSchedules.Location = New System.Drawing.Point(168, 232)
        Me.dgvSchedules.Name = "dgvSchedules"
        Me.dgvSchedules.Size = New System.Drawing.Size(817, 208)
        Me.dgvSchedules.TabIndex = 14
        '
        'Label6
        '
        Me.Label6.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Impact", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(102, -9)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(416, 60)
        Me.Label6.TabIndex = 15
        Me.Label6.Text = "Manage Schedules"
        '
        'lblatime
        '
        Me.lblatime.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblatime.AutoSize = True
        Me.lblatime.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblatime.Location = New System.Drawing.Point(250, 113)
        Me.lblatime.Name = "lblatime"
        Me.lblatime.Size = New System.Drawing.Size(124, 25)
        Me.lblatime.TabIndex = 16
        Me.lblatime.Text = "Arrival Time:"
        '
        'dtpArrival
        '
        Me.dtpArrival.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.dtpArrival.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpArrival.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.dtpArrival.Location = New System.Drawing.Point(370, 117)
        Me.dtpArrival.Name = "dtpArrival"
        Me.dtpArrival.ShowUpDown = True
        Me.dtpArrival.Size = New System.Drawing.Size(92, 22)
        Me.dtpArrival.TabIndex = 17
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.GroupBox1.Controls.Add(Me.dtpArrival)
        Me.GroupBox1.Controls.Add(Me.lblatime)
        Me.GroupBox1.Controls.Add(Me.txtFare)
        Me.GroupBox1.Controls.Add(Me.lblFare)
        Me.GroupBox1.Controls.Add(Me.dtpDeparture)
        Me.GroupBox1.Controls.Add(Me.lblTime)
        Me.GroupBox1.Controls.Add(Me.dtpDate)
        Me.GroupBox1.Controls.Add(Me.lblDate)
        Me.GroupBox1.Controls.Add(Me.cboRoute)
        Me.GroupBox1.Controls.Add(Me.lblRoute)
        Me.GroupBox1.Controls.Add(Me.cboBus)
        Me.GroupBox1.Controls.Add(Me.lblBus)
        Me.GroupBox1.Location = New System.Drawing.Point(168, 51)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(638, 174)
        Me.GroupBox1.TabIndex = 18
        Me.GroupBox1.TabStop = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.GroupBox2.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.GroupBox2.Controls.Add(Me.btnClose)
        Me.GroupBox2.Controls.Add(Me.btnDeleteSchedule)
        Me.GroupBox2.Controls.Add(Me.btnUpdateSchedule)
        Me.GroupBox2.Controls.Add(Me.btnAddSchedule)
        Me.GroupBox2.Location = New System.Drawing.Point(823, 51)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(162, 176)
        Me.GroupBox2.TabIndex = 19
        Me.GroupBox2.TabStop = False
        '
        'frmManageSchedules
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.BackgroundImage = Global.BusBookingSystem.My.Resources.Resources.adminpicc
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1070, 458)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.dgvSchedules)
        Me.Name = "frmManageSchedules"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Guardian Coach - ManageSchedules"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.dgvSchedules, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblBus As Label
    Friend WithEvents cboBus As ComboBox
    Friend WithEvents lblRoute As Label
    Friend WithEvents cboRoute As ComboBox
    Friend WithEvents lblDate As Label
    Friend WithEvents dtpDate As DateTimePicker
    Friend WithEvents lblTime As Label
    Friend WithEvents dtpDeparture As DateTimePicker
    Friend WithEvents lblFare As Label
    Friend WithEvents txtFare As TextBox
    Friend WithEvents btnAddSchedule As Button
    Friend WithEvents btnUpdateSchedule As Button
    Friend WithEvents btnDeleteSchedule As Button
    Friend WithEvents btnClose As Button
    Friend WithEvents dgvSchedules As DataGridView
    Friend WithEvents Label6 As Label
    Friend WithEvents lblatime As Label
    Friend WithEvents dtpArrival As DateTimePicker
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
End Class
