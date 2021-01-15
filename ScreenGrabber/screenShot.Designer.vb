<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class screenShot
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(screenShot))
        Me.TrayIcon = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.SuspendLayout()
        '
        'TrayIcon
        '
        Me.TrayIcon.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info
        Me.TrayIcon.BalloonTipText = "Press Print Screen to take a screenshot. Click for settings."
        Me.TrayIcon.BalloonTipTitle = "Screen Grabber"
        Me.TrayIcon.Icon = CType(resources.GetObject("TrayIcon.Icon"), System.Drawing.Icon)
        Me.TrayIcon.Text = "ScreenGrabber"
        Me.TrayIcon.Visible = True
        '
        'screenShot
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.ClientSize = New System.Drawing.Size(1, 1)
        Me.ControlBox = False
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(1, 1)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(1, 1)
        Me.Name = "screenShot"
        Me.Opacity = 0R
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.Text = "ScreenGrabber"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TrayIcon As NotifyIcon
End Class
