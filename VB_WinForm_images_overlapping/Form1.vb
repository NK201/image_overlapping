Imports System.IO
Imports System.Security
Imports System.Text.RegularExpressions
Imports System.Drawing.Imaging
Imports System.Drawing.Graphics


Public Class Form1



    Dim PATH As String = ""

    Private Sub btnOpen_Click(sender As Object, e As EventArgs) Handles btnOpen.Click
        OpenFileDialog1.Title = "Bitte 10 Bilder auswaehlen"
        OpenFileDialog1.Multiselect = True
        OpenFileDialog1.ShowDialog()


        OpenFileDialog2.Title = "Bitte Config file waehlen"
        OpenFileDialog2.Multiselect = False
        OpenFileDialog2.ShowDialog()


        If OpenFileDialog1.FileNames.Length = 10 Then
            lblImageAmount.Text = OpenFileDialog1.FileNames.Length
            lblFile.Text = OpenFileDialog1.FileName
            Dim File As String
            Dim i As Integer = 0

            While FlowLayoutPanel1.Controls.Count > 0
                FlowLayoutPanel1.Controls.RemoveAt(0)
            End While

            For Each File In OpenFileDialog1.FileNames
                Try

                    Dim fl As New FlowLayoutPanel()

                    Dim label As New Label()
                    Dim pb As New PictureBox()

                    Dim loadedImage As Image = Image.FromFile(File)

                    fl.Height = loadedImage.Height + 50
                    fl.Width = loadedImage.Width
                    fl.Tag = File
                    fl.BackColor = Color.White

                    label.Height = 50
                    label.Width = loadedImage.Width
                    label.TextAlign = 32
                    label.Font = New Font("Times New Roman", 18)

                    pb.Height = loadedImage.Height
                    pb.Width = loadedImage.Width
                    pb.Padding = New Padding(0, 0, 0, 0)
                    pb.Image = loadedImage
                    pb.Tag = File
                    pb.BackColor = Color.White



                    Dim g As Graphics = g.FromImage(pb.Image)
                    ' Dim g As Graphics = pb.CreateGraphics()


                    Dim pen1 As New System.Drawing.Pen(Color.White, 1)

                    g.DrawLine(pen1, 127, 0, 127, 1280)
                    g.DrawLine(pen1, 0, 127, 2000, 127)
                    g.DrawLine(pen1, 127 + 55, 0, 127 + 55, 1280)
                    g.DrawLine(pen1, 0, 127 + 55, 2000, 127 + 55)
                    g.DrawLine(pen1, 127 + 110, 0, 127 + 110, 1280)
                    g.DrawLine(pen1, 0, 127 + 110, 2000, 127 + 110)
                    g.DrawLine(pen1, 127 - 55, 0, 127 - 55, 1280)
                    g.DrawLine(pen1, 0, 127 - 55, 2000, 127 - 55)
                    g.DrawLine(pen1, 127 - 110, 0, 127 - 110, 1280)
                    g.DrawLine(pen1, 0, 127 - 110, 2000, 127 - 110)
                    g.DrawLine(pen1, 127 - 165, 0, 127 - 165, 1280)
                    g.DrawLine(pen1, 0, 127 - 165, 2000, 127 - 165)

                    Dim layerName As String
                    Dim s As String = 0
                    layerName = ""
                    Dim myChars() As Char = pb.Tag.ToCharArray() 'Gesamtdateipfad!!!! darf keine anderen zahlen enthalten
                    For Each ch As Char In myChars
                        '  layerName = ""
                        If Char.IsDigit(ch) Then
                            If s = 0 Then
                                layerName = ch
                                s = +1
                            Else layerName += ch
                            End If


                        End If
                    Next


                    Dim z As String = 0
                    Dim linie As String = 0
                    Dim zeile As String = 0
                    Dim Layerzeile As String = 1000
                    Dim layerlines() = IO.File.ReadAllLines(OpenFileDialog2.FileName)


                    For Each line In layerlines
                        zeile += 1

                        If line.Contains("Layer #") Then
                            Layerzeile = zeile + +layerName + 1 ' plus 1 da Bildernamen bei 0 beginnen
                        End If
                        If zeile = Layerzeile Then
                            Dim distanceArray() As String = line.Split(Chr(9))
                            z = distanceArray(1)
                        Else
                        End If
                    Next
                    layerName = layerName + +1

                    label.Text = "L" & layerName & "  " & z & "mm"

                    fl.Controls.Add(label)
                    fl.Controls.Add(pb)

                    FlowLayoutPanel1.Controls.Add(fl)
                    FlowLayoutPanel1.Invalidate()
                    FlowLayoutPanel1.Update()

                    If i.Equals(4) Then
                        FlowLayoutPanel1.SetFlowBreak(fl, True)
                    End If
                    i += 1
                Catch SecEx As SecurityException
                    ' The user lacks appropriate permissions to read files, discover paths, etc.
                    MessageBox.Show("Security error. Please contact your administrator for details.\n\n" &
                        "Error message: " & SecEx.Message & "\n\n" &
                        "Details (send to Support):\n\n" & SecEx.StackTrace)
                Catch ex As Exception
                    MessageBox.Show(("Cannot display the image: " & File.Substring(File.LastIndexOf("\"c)) &
                    ". You may not have permission to read the file, or " + "it may be corrupt." _
                    & ControlChars.Lf & ControlChars.Lf & "Reported error: " & ex.Message))
                End Try
            Next
        Else
            lblImageAmount.Text = 0
            While FlowLayoutPanel1.Controls.Count > 0
                FlowLayoutPanel1.Controls.RemoveAt(0)
            End While
            lblFile.Text = "No file selected"
        End If

        FlowLayoutPanel1.BackColor = Color.White
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        SaveFileDialog1.Title = "Bitte pfad auswählen"
        SaveFileDialog1.Filter = "JPeg Image|.jpg|Bitmap Image|.bmp"

        If SaveFileDialog1.ShowDialog() = DialogResult.OK Then
            '  MessageBox.Show(SaveFileDialog1.FileName)
            PATH = SaveFileDialog1.FileName
            savePathLabel.Text = "Save path: " & PATH
        End If

        Dim myBmp As New Bitmap(FlowLayoutPanel1.ClientRectangle.Width, FlowLayoutPanel1.ClientRectangle.Height)

        FlowLayoutPanel1.DrawToBitmap(myBmp, New Rectangle(0, 0, FlowLayoutPanel1.Width, FlowLayoutPanel1.Height))


        Try
            myBmp.Save(PATH)
        Catch exception As Exception
            MessageBox.Show("Fehler")
            Return

        End Try

        MessageBox.Show("Saved to " & PATH)


    End Sub


End Class
