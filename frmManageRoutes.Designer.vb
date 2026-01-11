<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmManageRoutes
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
        Me.lblOrigin = New System.Windows.Forms.Label()
        Me.txtOrigin = New System.Windows.Forms.TextBox()
        Me.lblDestination = New System.Windows.Forms.Label()
        Me.txtDestination = New System.Windows.Forms.TextBox()
        Me.lblFare = New System.Windows.Forms.Label()
        Me.txtFare = New System.Windows.Forms.TextBox()
        Me.btnAddRoute = New System.Windows.Forms.Button()
        Me.btnUpdateRoute = New System.Windows.Forms.Button()
        Me.btnDeleteRoute = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.dgvRoutes = New System.Windows.Forms.DataGridView()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        CType(Me.dgvRoutes, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.lblTitle.Location = New System.Drawing.Point(56, -8)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(342, 60)
        Me.lblTitle.TabIndex = 0
        Me.lblTitle.Text = "Manage Routes"
        '
        'lblOrigin
        '
        Me.lblOrigin.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblOrigin.AutoSize = True
        Me.lblOrigin.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOrigin.ForeColor = System.Drawing.Color.White
        Me.lblOrigin.Location = New System.Drawing.Point(48, 26)
        Me.lblOrigin.Name = "lblOrigin"
        Me.lblOrigin.Size = New System.Drawing.Size(73, 25)
        Me.lblOrigin.TabIndex = 1
        Me.lblOrigin.Text = "Origin:"
        '
        'txtOrigin
        '
        Me.txtOrigin.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtOrigin.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOrigin.Location = New System.Drawing.Point(127, 29)
        Me.txtOrigin.Name = "txtOrigin"
        Me.txtOrigin.Size = New System.Drawing.Size(248, 22)
        Me.txtOrigin.TabIndex = 2
        '
        'lblDestination
        '
        Me.lblDestination.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblDestination.AutoSize = True
        Me.lblDestination.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDestination.ForeColor = System.Drawing.Color.White
        Me.lblDestination.Location = New System.Drawing.Point(2, 67)
        Me.lblDestination.Name = "lblDestination"
        Me.lblDestination.Size = New System.Drawing.Size(119, 25)
        Me.lblDestination.TabIndex = 3
        Me.lblDestination.Text = "Destination:"
        '
        'txtDestination
        '
        Me.txtDestination.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtDestination.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDestination.Location = New System.Drawing.Point(127, 70)
        Me.txtDestination.Name = "txtDestination"
        Me.txtDestination.Size = New System.Drawing.Size(248, 22)
        Me.txtDestination.TabIndex = 4
        '
        'lblFare
        '
        Me.lblFare.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblFare.AutoSize = True
        Me.lblFare.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFare.ForeColor = System.Drawing.Color.White
        Me.lblFare.Location = New System.Drawing.Point(67, 107)
        Me.lblFare.Name = "lblFare"
        Me.lblFare.Size = New System.Drawing.Size(54, 25)
        Me.lblFare.TabIndex = 5
        Me.lblFare.Text = "Fare:"
        '
        'txtFare
        '
        Me.txtFare.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtFare.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFare.Location = New System.Drawing.Point(127, 110)
        Me.txtFare.Name = "txtFare"
        Me.txtFare.Size = New System.Drawing.Size(193, 22)
        Me.txtFare.TabIndex = 6
        '
        'btnAddRoute
        '
        Me.btnAddRoute.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnAddRoute.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddRoute.Location = New System.Drawing.Point(52, 11)
        Me.btnAddRoute.Name = "btnAddRoute"
        Me.btnAddRoute.Size = New System.Drawing.Size(134, 29)
        Me.btnAddRoute.TabIndex = 7
        Me.btnAddRoute.Text = "Add"
        Me.btnAddRoute.UseVisualStyleBackColor = True
        '
        'btnUpdateRoute
        '
        Me.btnUpdateRoute.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnUpdateRoute.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdateRoute.Location = New System.Drawing.Point(52, 46)
        Me.btnUpdateRoute.Name = "btnUpdateRoute"
        Me.btnUpdateRoute.Size = New System.Drawing.Size(134, 29)
        Me.btnUpdateRoute.TabIndex = 8
        Me.btnUpdateRoute.Text = "Update"
        Me.btnUpdateRoute.UseVisualStyleBackColor = True
        '
        'btnDeleteRoute
        '
        Me.btnDeleteRoute.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnDeleteRoute.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDeleteRoute.Location = New System.Drawing.Point(52, 81)
        Me.btnDeleteRoute.Name = "btnDeleteRoute"
        Me.btnDeleteRoute.Size = New System.Drawing.Size(134, 29)
        Me.btnDeleteRoute.TabIndex = 9
        Me.btnDeleteRoute.Text = "Delete"
        Me.btnDeleteRoute.UseVisualStyleBackColor = True
        '
        'btnClose
        '
        Me.btnClose.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnClose.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.ForeColor = System.Drawing.Color.Red
        Me.btnClose.Location = New System.Drawing.Point(52, 116)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(134, 29)
        Me.btnClose.TabIndex = 10
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'dgvRoutes
        '
        Me.dgvRoutes.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.dgvRoutes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvRoutes.Location = New System.Drawing.Point(155, 206)
        Me.dgvRoutes.Name = "dgvRoutes"
        Me.dgvRoutes.Size = New System.Drawing.Size(829, 228)
        Me.dgvRoutes.TabIndex = 11
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.txtFare)
        Me.GroupBox1.Controls.Add(Me.lblFare)
        Me.GroupBox1.Controls.Add(Me.txtDestination)
        Me.GroupBox1.Controls.Add(Me.lblDestination)
        Me.GroupBox1.Controls.Add(Me.txtOrigin)
        Me.GroupBox1.Controls.Add(Me.lblOrigin)
        Me.GroupBox1.Location = New System.Drawing.Point(155, 46)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(570, 154)
        Me.GroupBox1.TabIndex = 12
        Me.GroupBox1.TabStop = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.btnClose)
        Me.GroupBox2.Controls.Add(Me.btnDeleteRoute)
        Me.GroupBox2.Controls.Add(Me.btnUpdateRoute)
        Me.GroupBox2.Controls.Add(Me.btnAddRoute)
        Me.GroupBox2.Location = New System.Drawing.Point(745, 46)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(239, 154)
        Me.GroupBox2.TabIndex = 13
        Me.GroupBox2.TabStop = False
        '
        'frmManageRoutes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.BackgroundImage = Global.BusBookingSystem.My.Resources.Resources.adminpicc
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1082, 465)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.dgvRoutes)
        Me.Controls.Add(Me.lblTitle)
        Me.Name = "frmManageRoutes"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Guardian Coach - ManageRoutes"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.dgvRoutes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblTitle As Label
    Friend WithEvents lblOrigin As Label
    Friend WithEvents txtOrigin As TextBox
    Friend WithEvents lblDestination As Label
    Friend WithEvents txtDestination As TextBox
    Friend WithEvents lblFare As Label
    Friend WithEvents txtFare As TextBox
    Friend WithEvents btnAddRoute As Button
    Friend WithEvents btnUpdateRoute As Button
    Friend WithEvents btnDeleteRoute As Button
    Friend WithEvents btnClose As Button
    Friend WithEvents dgvRoutes As DataGridView
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
End Class
