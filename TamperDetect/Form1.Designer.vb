<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Me.components = New System.ComponentModel.Container()
        Me.lblAlert = New System.Windows.Forms.Label()
        Me.lblStatus = New System.Windows.Forms.Label()
        Me.lblState = New System.Windows.Forms.Label()
        Me.tmrCheck = New System.Windows.Forms.Timer(Me.components)
        Me.lblTPS = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblAlert
        '
        Me.lblAlert.BackColor = System.Drawing.Color.Lime
        Me.lblAlert.Location = New System.Drawing.Point(12, 9)
        Me.lblAlert.Name = "lblAlert"
        Me.lblAlert.Size = New System.Drawing.Size(64, 64)
        Me.lblAlert.TabIndex = 0
        '
        'lblStatus
        '
        Me.lblStatus.AutoSize = True
        Me.lblStatus.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStatus.ForeColor = System.Drawing.Color.White
        Me.lblStatus.Location = New System.Drawing.Point(82, 9)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(45, 15)
        Me.lblStatus.TabIndex = 1
        Me.lblStatus.Text = "Status:"
        '
        'lblState
        '
        Me.lblState.AutoSize = True
        Me.lblState.Font = New System.Drawing.Font("Arial", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblState.ForeColor = System.Drawing.Color.White
        Me.lblState.Location = New System.Drawing.Point(82, 24)
        Me.lblState.Name = "lblState"
        Me.lblState.Size = New System.Drawing.Size(170, 56)
        Me.lblState.TabIndex = 2
        Me.lblState.Text = "GOOD"
        '
        'tmrCheck
        '
        Me.tmrCheck.Enabled = True
        Me.tmrCheck.Interval = 10
        '
        'lblTPS
        '
        Me.lblTPS.BackColor = System.Drawing.Color.Lime
        Me.lblTPS.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTPS.ForeColor = System.Drawing.Color.Black
        Me.lblTPS.Location = New System.Drawing.Point(12, 49)
        Me.lblTPS.Name = "lblTPS"
        Me.lblTPS.Size = New System.Drawing.Size(64, 24)
        Me.lblTPS.TabIndex = 3
        Me.lblTPS.Text = "0/s"
        Me.lblTPS.TextAlign = System.Drawing.ContentAlignment.BottomRight
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(277, 83)
        Me.Controls.Add(Me.lblTPS)
        Me.Controls.Add(Me.lblState)
        Me.Controls.Add(Me.lblStatus)
        Me.Controls.Add(Me.lblAlert)
        Me.Name = "frmMain"
        Me.Text = "Keyboard Tamper Detect"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblAlert As System.Windows.Forms.Label
    Friend WithEvents lblStatus As System.Windows.Forms.Label
    Friend WithEvents lblState As System.Windows.Forms.Label
    Friend WithEvents tmrCheck As System.Windows.Forms.Timer
    Friend WithEvents lblTPS As System.Windows.Forms.Label

End Class
