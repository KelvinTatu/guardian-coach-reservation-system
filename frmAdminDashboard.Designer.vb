<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAdminDashboard
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
        Me.btnManageBuses = New System.Windows.Forms.Button()
        Me.btnManageRoutes = New System.Windows.Forms.Button()
        Me.btnManageSchedules = New System.Windows.Forms.Button()
        Me.btnManageUsers = New System.Windows.Forms.Button()
        Me.btnReports = New System.Windows.Forms.Button()
        Me.btnLogout = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblTitle
        '
        Me.lblTitle.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblTitle.AutoSize = True
        Me.lblTitle.BackColor = System.Drawing.Color.Transparent
        Me.lblTitle.Font = New System.Drawing.Font("Impact", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.ForeColor = System.Drawing.Color.White
        Me.lblTitle.Location = New System.Drawing.Point(73, -8)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(387, 60)
        Me.lblTitle.TabIndex = 0
        Me.lblTitle.Text = "Admin Dashboard"
        '
        'btnManageBuses
        '
        Me.btnManageBuses.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnManageBuses.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnManageBuses.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnManageBuses.Location = New System.Drawing.Point(78, 57)
        Me.btnManageBuses.Name = "btnManageBuses"
        Me.btnManageBuses.Size = New System.Drawing.Size(184, 100)
        Me.btnManageBuses.TabIndex = 1
        Me.btnManageBuses.Text = "Manage " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Buses"
        Me.btnManageBuses.UseVisualStyleBackColor = True
        '
        'btnManageRoutes
        '
        Me.btnManageRoutes.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnManageRoutes.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnManageRoutes.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnManageRoutes.Location = New System.Drawing.Point(306, 57)
        Me.btnManageRoutes.Name = "btnManageRoutes"
        Me.btnManageRoutes.Size = New System.Drawing.Size(184, 100)
        Me.btnManageRoutes.TabIndex = 2
        Me.btnManageRoutes.Text = "Manage " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Routes"
        Me.btnManageRoutes.UseVisualStyleBackColor = True
        '
        'btnManageSchedules
        '
        Me.btnManageSchedules.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnManageSchedules.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnManageSchedules.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnManageSchedules.Location = New System.Drawing.Point(520, 57)
        Me.btnManageSchedules.Name = "btnManageSchedules"
        Me.btnManageSchedules.Size = New System.Drawing.Size(179, 100)
        Me.btnManageSchedules.TabIndex = 3
        Me.btnManageSchedules.Text = "Manage Schedules"
        Me.btnManageSchedules.UseVisualStyleBackColor = True
        '
        'btnManageUsers
        '
        Me.btnManageUsers.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnManageUsers.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnManageUsers.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnManageUsers.Location = New System.Drawing.Point(78, 184)
        Me.btnManageUsers.Name = "btnManageUsers"
        Me.btnManageUsers.Size = New System.Drawing.Size(184, 100)
        Me.btnManageUsers.TabIndex = 4
        Me.btnManageUsers.Text = "Manage " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Users"
        Me.btnManageUsers.UseVisualStyleBackColor = True
        '
        'btnReports
        '
        Me.btnReports.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnReports.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnReports.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReports.Location = New System.Drawing.Point(306, 184)
        Me.btnReports.Name = "btnReports"
        Me.btnReports.Size = New System.Drawing.Size(184, 100)
        Me.btnReports.TabIndex = 5
        Me.btnReports.Text = "Reports"
        Me.btnReports.UseVisualStyleBackColor = True
        '
        'btnLogout
        '
        Me.btnLogout.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnLogout.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnLogout.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogout.ForeColor = System.Drawing.Color.Red
        Me.btnLogout.Location = New System.Drawing.Point(818, 376)
        Me.btnLogout.Name = "btnLogout"
        Me.btnLogout.Size = New System.Drawing.Size(99, 54)
        Me.btnLogout.TabIndex = 6
        Me.btnLogout.Text = "Logout"
        Me.btnLogout.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.btnReports)
        Me.GroupBox1.Controls.Add(Me.btnManageUsers)
        Me.GroupBox1.Controls.Add(Me.btnManageSchedules)
        Me.GroupBox1.Controls.Add(Me.btnManageRoutes)
        Me.GroupBox1.Controls.Add(Me.btnManageBuses)
        Me.GroupBox1.Location = New System.Drawing.Point(170, 46)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(747, 324)
        Me.GroupBox1.TabIndex = 7
        Me.GroupBox1.TabStop = False
        '
        'frmAdminDashboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.BackgroundImage = Global.BusBookingSystem.My.Resources.Resources.adminpic
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1076, 448)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnLogout)
        Me.Controls.Add(Me.lblTitle)
        Me.Name = "frmAdminDashboard"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Guardian Coach Bus Booking System - Admin Dashboard"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblTitle As Label
    Friend WithEvents btnManageBuses As Button
    Friend WithEvents btnManageRoutes As Button
    Friend WithEvents btnManageSchedules As Button
    Friend WithEvents btnManageUsers As Button
    Friend WithEvents btnReports As Button
    Friend WithEvents btnLogout As Button
    Friend WithEvents GroupBox1 As GroupBox
End Class
