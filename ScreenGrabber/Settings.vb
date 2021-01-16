﻿Public Class Settings

    Public stg_MonitorCapture As String = "All monitors"

    Private Sub AboutButton_Click(sender As Object, e As EventArgs) Handles AboutButton.Click
        MsgBox("Screen Grabber" + vbCrLf + "by Chris Shoeman" + vbCrLf + "" + vbCrLf + "2019-2021 Chris Shoeman." + vbCrLf + "Version 1.0.0" + vbCrLf + "" + vbCrLf + "Distributed under the MIT License", MsgBoxStyle.OkOnly, "Screen Grabber")
    End Sub

    Private Sub Settings_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        optionsScreenShoot.SelectedItem = optionsScreenShoot.Items(1)
        DirectorySave.Text = screenShot.saveDirectory
        Me.Activate()
    End Sub

    Private Sub SettingsOK_Click(sender As Object, e As EventArgs) Handles SettingsOK.Click
        screenShot.saveDirectory = DirectorySave.Text
        If Not My.Computer.FileSystem.DirectoryExists(screenShot.saveDirectory) Then
            My.Computer.FileSystem.CreateDirectory(screenShot.saveDirectory)
        End If
        Me.Close()
    End Sub

    Private Sub optionsScreenShoot_DropDownClosed(sender As Object, e As EventArgs) Handles optionsScreenShoot.DropDownClosed
        stg_MonitorCapture = optionsScreenShoot.SelectedItem
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Application.Exit()
    End Sub
End Class