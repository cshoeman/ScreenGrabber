Imports System.Drawing.Imaging.ImageFormat
Imports System.Drawing.ImageFormatConverter
Imports System.Runtime.InteropServices
Public Class screenShot

    Public myScreens() As Screen = Screen.AllScreens
    Public scw As Integer
    Public sch As Integer
    Public sct As Integer = 0
    Public scl As Integer = 0
    Public saveDirectory As String = My.Computer.FileSystem.SpecialDirectories.MyPictures + "\Screenshots\"

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
        If Not My.Computer.FileSystem.DirectoryExists(saveDirectory) Then
            My.Computer.FileSystem.CreateDirectory(saveDirectory)
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

        Debug.WriteLine("Capturing screen")

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

        Debug.WriteLine("Screen bounds: " + scw.ToString + "x" + sch.ToString)


        Try
            Dim screenSize As Size = New Size(scw, sch)

            Debug.WriteLine("Gathering screen size")

            Try
                Dim screenGrab As New Bitmap(scw, sch)

                Debug.WriteLine("Generating bitmap")

                Try
                    Dim g As Graphics = Graphics.FromImage(screenGrab)

                    Debug.WriteLine("Grabbing graphics")

                    Try
                        g.CopyFromScreen(New Point(scl, sct), New Point(0, 0), screenSize)

                        Debug.WriteLine("Copying screen")

                        Try
                            ' Save the image with the date
                            Dim saveDate As String = Date.Now.Year.ToString + "-" + Date.Now.Month.ToString + "-" + Date.Now.Day.ToString + "_" + Date.Now.Hour.ToString + "-" + Date.Now.Minute.ToString + "-" + Date.Now.Second.ToString
                            screenGrab.Save(saveDirectory + saveDate.ToString + ".png", System.Drawing.Imaging.ImageFormat.Png)

                            Debug.WriteLine("Saving image")

                            ' Garbage collection
                            g.Dispose()
                            screenGrab.Dispose()

                            Debug.WriteLine("Garbage collecting")
                        Catch ex As Exception
                            Debug.Print("Could not save image: Exception thrown in Save (Check code!)")
                        End Try
                    Catch ex As Exception
                        Debug.Print("Could not save image: Exception thrown in g.CopyFromScreen (Check code!)")
                    End Try
                Catch ex As Exception
                    Debug.Print("Could not save image: Exception thrown in Graphics (Check code!)")
                End Try
                Return screenGrab
            Catch ex As Exception
                Debug.Print("Could not save image: Exception thrown in screenGrab (Check code!)")
            End Try
        Catch ex As Exception
            Debug.Print("Could not save image: Exception thrown in screenSize (Check code!)")
        End Try

    End Function

    Private Sub TrayIcon_Click(sender As Object, e As EventArgs) Handles TrayIcon.Click
        Try
            Settings.Show()
            Settings.BringToFront()
        Catch ex As Exception
            Debug.WriteLine("Exception found in Settings.ShowDialog - dialog may already be open. Attempting to bring to front...")
            Try
                Settings.BringToFront()
            Catch ex2 As Exception
                Debug.WriteLine("Attempt to bring to front failed. Find the issue.")
            End Try
        End Try
    End Sub
End Class
