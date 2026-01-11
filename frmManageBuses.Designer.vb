<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmManageBuses
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
        Me.lblPlateNo = New System.Windows.Forms.Label()
        Me.txtBusNumber = New System.Windows.Forms.TextBox()
        Me.lblCapacity = New System.Windows.Forms.Label()
        Me.txtCapacity = New System.Windows.Forms.TextBox()
        Me.lblDriver = New System.Windows.Forms.Label()
        Me.txtPrimaryDriver = New System.Windows.Forms.TextBox()
        Me.btnAddBus = New System.Windows.Forms.Button()
        Me.btnUpdateBus = New System.Windows.Forms.Button()
        Me.btnDeleteBus = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.dgvBuses = New System.Windows.Forms.DataGridView()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtSecondaryDriver = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        CType(Me.dgvBuses, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblTitle
        '
        Me.lblTitle.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblTitle.AutoSize = True
        Me.lblTitle.BackColor = System.Drawing.Color.Transparent
        Me.lblTitle.Font = New System.Drawing.Font("Impact", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.ForeColor = System.Drawing.Color.White
        Me.lblTitle.Location = New System.Drawing.Point(62, -7)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(325, 60)
        Me.lblTitle.TabIndex = 0
        Me.lblTitle.Text = "Manage Buses"
        '
        'lblPlateNo
        '
        Me.lblPlateNo.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblPlateNo.AutoSize = True
        Me.lblPlateNo.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPlateNo.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.lblPlateNo.Location = New System.Drawing.Point(91, 16)
        Me.lblPlateNo.Name = "lblPlateNo"
        Me.lblPlateNo.Size = New System.Drawing.Size(88, 25)
        Me.lblPlateNo.TabIndex = 1
        Me.lblPlateNo.Text = "PlateNo:"
        '
        'txtBusNumber
        '
        Me.txtBusNumber.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtBusNumber.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBusNumber.Location = New System.Drawing.Point(179, 16)
        Me.txtBusNumber.Name = "txtBusNumber"
        Me.txtBusNumber.Size = New System.Drawing.Size(391, 22)
        Me.txtBusNumber.TabIndex = 2
        '
        'lblCapacity
        '
        Me.lblCapacity.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblCapacity.AutoSize = True
        Me.lblCapacity.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCapacity.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.lblCapacity.Location = New System.Drawing.Point(87, 52)
        Me.lblCapacity.Name = "lblCapacity"
        Me.lblCapacity.Size = New System.Drawing.Size(92, 25)
        Me.lblCapacity.TabIndex = 3
        Me.lblCapacity.Text = "Capacity:"
        '
        'txtCapacity
        '
        Me.txtCapacity.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtCapacity.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCapacity.Location = New System.Drawing.Point(179, 55)
        Me.txtCapacity.Name = "txtCapacity"
        Me.txtCapacity.Size = New System.Drawing.Size(273, 22)
        Me.txtCapacity.TabIndex = 4
        '
        'lblDriver
        '
        Me.lblDriver.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblDriver.AutoSize = True
        Me.lblDriver.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDriver.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.lblDriver.Location = New System.Drawing.Point(30, 89)
        Me.lblDriver.Name = "lblDriver"
        Me.lblDriver.Size = New System.Drawing.Size(149, 25)
        Me.lblDriver.TabIndex = 5
        Me.lblDriver.Text = "Primary Driver:"
        '
        'txtPrimaryDriver
        '
        Me.txtPrimaryDriver.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtPrimaryDriver.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPrimaryDriver.Location = New System.Drawing.Point(179, 92)
        Me.txtPrimaryDriver.Name = "txtPrimaryDriver"
        Me.txtPrimaryDriver.Size = New System.Drawing.Size(417, 22)
        Me.txtPrimaryDriver.TabIndex = 6
        '
        'btnAddBus
        '
        Me.btnAddBus.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnAddBus.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddBus.Location = New System.Drawing.Point(36, 11)
        Me.btnAddBus.Name = "btnAddBus"
        Me.btnAddBus.Size = New System.Drawing.Size(129, 34)
        Me.btnAddBus.TabIndex = 7
        Me.btnAddBus.Text = "Add"
        Me.btnAddBus.UseVisualStyleBackColor = True
        '
        'btnUpdateBus
        '
        Me.btnUpdateBus.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnUpdateBus.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdateBus.Location = New System.Drawing.Point(36, 50)
        Me.btnUpdateBus.Name = "btnUpdateBus"
        Me.btnUpdateBus.Size = New System.Drawing.Size(129, 34)
        Me.btnUpdateBus.TabIndex = 8
        Me.btnUpdateBus.Text = "Update"
        Me.btnUpdateBus.UseVisualStyleBackColor = True
        '
        'btnDeleteBus
        '
        Me.btnDeleteBus.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnDeleteBus.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDeleteBus.Location = New System.Drawing.Point(36, 88)
        Me.btnDeleteBus.Name = "btnDeleteBus"
        Me.btnDeleteBus.Size = New System.Drawing.Size(129, 34)
        Me.btnDeleteBus.TabIndex = 9
        Me.btnDeleteBus.Text = "Delete"
        Me.btnDeleteBus.UseVisualStyleBackColor = True
        '
        'btnClose
        '
        Me.btnClose.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnClose.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.ForeColor = System.Drawing.Color.Red
        Me.btnClose.Location = New System.Drawing.Point(36, 127)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(129, 34)
        Me.btnClose.TabIndex = 10
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'dgvBuses
        '
        Me.dgvBuses.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.dgvBuses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvBuses.Location = New System.Drawing.Point(109, 226)
        Me.dgvBuses.Name = "dgvBuses"
        Me.dgvBuses.Size = New System.Drawing.Size(851, 203)
        Me.dgvBuses.TabIndex = 11
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtSecondaryDriver)
        Me.GroupBox1.Controls.Add(Me.lblCapacity)
        Me.GroupBox1.Controls.Add(Me.lblPlateNo)
        Me.GroupBox1.Controls.Add(Me.txtBusNumber)
        Me.GroupBox1.Controls.Add(Me.txtCapacity)
        Me.GroupBox1.Controls.Add(Me.lblDriver)
        Me.GroupBox1.Controls.Add(Me.txtPrimaryDriver)
        Me.GroupBox1.Location = New System.Drawing.Point(109, 56)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(637, 162)
        Me.GroupBox1.TabIndex = 12
        Me.GroupBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label1.Location = New System.Drawing.Point(6, 127)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(173, 25)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Secondary Driver:"
        '
        'txtSecondaryDriver
        '
        Me.txtSecondaryDriver.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtSecondaryDriver.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSecondaryDriver.Location = New System.Drawing.Point(179, 130)
        Me.txtSecondaryDriver.Name = "txtSecondaryDriver"
        Me.txtSecondaryDriver.Size = New System.Drawing.Size(417, 22)
        Me.txtSecondaryDriver.TabIndex = 7
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.btnClose)
        Me.GroupBox2.Controls.Add(Me.btnDeleteBus)
        Me.GroupBox2.Controls.Add(Me.btnAddBus)
        Me.GroupBox2.Controls.Add(Me.btnUpdateBus)
        Me.GroupBox2.Location = New System.Drawing.Point(761, 56)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(199, 167)
        Me.GroupBox2.TabIndex = 13
        Me.GroupBox2.TabStop = False
        '
        'frmManageBuses
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.BackgroundImage = Global.BusBookingSystem.My.Resources.Resources.adminpicc
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1070, 451)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.dgvBuses)
        Me.Controls.Add(Me.lblTitle)
        Me.Name = "frmManageBuses"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Guardian Coach - Manage Buses"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.dgvBuses, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblTitle As Label
    Friend WithEvents lblPlateNo As Label
    Friend WithEvents txtBusNumber As TextBox
    Friend WithEvents lblCapacity As Label
    Friend WithEvents txtCapacity As TextBox
    Friend WithEvents lblDriver As Label
    Friend WithEvents txtPrimaryDriver As TextBox
    Friend WithEvents btnAddBus As Button
    Friend WithEvents btnUpdateBus As Button
    Friend WithEvents btnDeleteBus As Button
    Friend WithEvents btnClose As Button
    Friend WithEvents dgvBuses As DataGridView
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents txtSecondaryDriver As TextBox
    Friend WithEvents Label1 As Label
End Class
