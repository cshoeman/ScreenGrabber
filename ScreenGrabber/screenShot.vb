Imports System.Drawing.Imaging.ImageFormat
Imports System.Drawing.ImageFormatConverter
Imports System.Runtime.InteropServices
Public Class screenShot

    Public myScreens() As Screen = Screen.AllScreens
    Public scw As Integer
    Public sch As Integer
    Public sct As Integer = 0
    Public scl As Integer = 0

    Protected Overrides Sub WndProc(ByRef m As System.Windows.Forms.Message)
        ' Key hook for the system
        If m.Msg = Hotkey.WM_HOTKEY Then
            Hotkey.handleHotKeyEvent(m.WParam)
            TakeScreenShot().Dispose()
        End If
        MyBase.WndProc(m)
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ' Create a screenshots folder if it doesn't already exist
        If Not My.Computer.FileSystem.DirectoryExists(My.Computer.FileSystem.SpecialDirectories.MyPictures + "\Screenshots\") Then
            My.Computer.FileSystem.CreateDirectory(My.Computer.FileSystem.SpecialDirectories.MyPictures + "\Screenshots\")
        End If

        ' Get the dimensions of the screen
        ' scw = Screen.PrimaryScreen.Bounds.Width
        ' sch = Screen.PrimaryScreen.Bounds.Height


        ' Bind to Print Screen key
        Hotkey.registerHotkeyNoAscii(Me, 44, Hotkey.KeyModifier.None)

        TrayIcon.ShowBalloonTip(5, TrayIcon.BalloonTipTitle, TrayIcon.BalloonTipText, TrayIcon.BalloonTipIcon)
    End Sub

    Private Sub ScreenShot_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        ' Unbind the key
        Hotkey.unregisterHotkeys(Me)
    End Sub






    Private Function TakeScreenShot() As Bitmap
        ' Create a bitmap from the screenshot

        Debug.WriteLine("Screens: " + (myScreens.Length).ToString)

        For i As Integer = 0 To 0 Step 1
            ' For i As Integer = 0 To myScreens.Length Step 1

            Debug.WriteLine("Capturing screen" + i.ToString)

            ' scw = myScreens(i).Bounds.Width
            ' sch = myScreens(i).Bounds.Height
            Select Case Settings.stg_MonitorCapture
                Case "Primary monitor"
                    scw = Screen.PrimaryScreen.Bounds.Width
                    sch = Screen.PrimaryScreen.Bounds.Height
                Case "All monitors"
                    scw = SystemInformation.VirtualScreen.Width
                    sch = SystemInformation.VirtualScreen.Height
                Case Else
                    scw = SystemInformation.VirtualScreen.Width
                    sch = SystemInformation.VirtualScreen.Height
            End Select

            Debug.WriteLine(i.ToString + ": Screen bounds: " + scw.ToString + "x" + sch.ToString)


            Try
                Dim screenSize As Size = New Size(scw, sch)

                Debug.WriteLine(i.ToString + ": Gathering screen size")

                Try
                    Dim screenGrab As New Bitmap(scw, sch)

                    Debug.WriteLine(i.ToString + ": Generating bitmap")

                    Try
                        Dim g As Graphics = Graphics.FromImage(screenGrab)

                        Debug.WriteLine(i.ToString + ": Grabbing graphics")

                        Try
                            g.CopyFromScreen(New Point(scl, sct), New Point(0, 0), screenSize)

                            Debug.WriteLine(i.ToString + ": Copying screen")

                            Try
                                Try
                                    ' Save the image with the date
                                    Dim saveDate As String = Date.Now.Year.ToString + "-" + Date.Now.Month.ToString + "-" + Date.Now.Day.ToString + "_" + Date.Now.Hour.ToString + "-" + Date.Now.Minute.ToString + "-" + Date.Now.Second.ToString
                                    screenGrab.Save(My.Computer.FileSystem.SpecialDirectories.MyPictures + "\Screenshots\" + saveDate.ToString + ".png", System.Drawing.Imaging.ImageFormat.Png)

                                    Debug.WriteLine(i.ToString + ": Saving image")

                                    ' Garbage collection
                                    g.Dispose()
                                    screenGrab.Dispose()

                                    Debug.WriteLine(i.ToString + ": Garbage collecting")
                                Catch ex As Exception
                                    Debug.Print("could not save image")
                                End Try
                                Return screenGrab
                            Catch ex As Exception
                            End Try
                        Catch ex As Exception
                        End Try
                    Catch ex As Exception
                    End Try
                Catch ex As Exception
                End Try
            Catch ex As Exception
            End Try
        Next


    End Function

    Private Sub TrayIcon_Click(sender As Object, e As EventArgs) Handles TrayIcon.Click
        Settings.ShowDialog()
    End Sub
End Class
