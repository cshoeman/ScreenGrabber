﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Settings
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Settings))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.optionsScreenShoot = New System.Windows.Forms.ComboBox()
        Me.SettingsOK = New System.Windows.Forms.Button()
        Me.AboutButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(90, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Screens to shoot:"
        '
        'optionsScreenShoot
        '
        Me.optionsScreenShoot.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.optionsScreenShoot.FormattingEnabled = True
        Me.optionsScreenShoot.Items.AddRange(New Object() {"Primary monitor", "All monitors"})
        Me.optionsScreenShoot.Location = New System.Drawing.Point(108, 6)
        Me.optionsScreenShoot.Name = "optionsScreenShoot"
        Me.optionsScreenShoot.Size = New System.Drawing.Size(121, 21)
        Me.optionsScreenShoot.TabIndex = 1
        '
        'SettingsOK
        '
        Me.SettingsOK.Location = New System.Drawing.Point(210, 127)
        Me.SettingsOK.Name = "SettingsOK"
        Me.SettingsOK.Size = New System.Drawing.Size(75, 23)
        Me.SettingsOK.TabIndex = 2
        Me.SettingsOK.Text = "OK"
        Me.SettingsOK.UseVisualStyleBackColor = True
        '
        'AboutButton
        '
        Me.AboutButton.Location = New System.Drawing.Point(12, 127)
        Me.AboutButton.Name = "AboutButton"
        Me.AboutButton.Size = New System.Drawing.Size(75, 23)
        Me.AboutButton.TabIndex = 3
        Me.AboutButton.Text = "About"
        Me.AboutButton.UseVisualStyleBackColor = True
        '
        'Settings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(297, 162)
        Me.Controls.Add(Me.AboutButton)
        Me.Controls.Add(Me.SettingsOK)
        Me.Controls.Add(Me.optionsScreenShoot)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Settings"
        Me.Text = "Settings"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents optionsScreenShoot As ComboBox
    Friend WithEvents SettingsOK As Button
    Friend WithEvents AboutButton As Button
End Class
