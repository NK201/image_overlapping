Imports System.IO
Imports System.Security
Imports System.Text.RegularExpressions

Public Class Form1

    'Global Variable

    'Layer Anzahl = 20
    Dim layerConf(20) As Double



    Private Sub btnOpen_Click(sender As Object, e As EventArgs) Handles btnOpen.Click
        OpenFileDialog1.Title = "Bitte 10 Bilder auswaehlen"
        OpenFileDialog1.Multiselect = True
        OpenFileDialog1.ShowDialog()


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
                    Dim pb As New PictureBox()
                    Dim loadedImage As Image = Image.FromFile(File)

                    pb.Height = loadedImage.Height + 40
                    pb.Width = loadedImage.Width
                    pb.Padding = New Padding(0, 50, 0, 0)
                    pb.Image = loadedImage
                    pb.Tag = File
                    pb.BackColor = Color.White

                    FlowLayoutPanel1.Controls.Add(pb)
                    FlowLayoutPanel1.Invalidate()
                    FlowLayoutPanel1.Update()

                    If i.Equals(4) Then
                        FlowLayoutPanel1.SetFlowBreak(pb, True)
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
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'MessageBox.Show("Not implemented yet")
        Dim myBmp As New Bitmap(FlowLayoutPanel1.ClientRectangle.Width, FlowLayoutPanel1.ClientRectangle.Height)

        FlowLayoutPanel1.DrawToBitmap(myBmp, New Rectangle(0, 0, FlowLayoutPanel1.Width, FlowLayoutPanel1.Height))
        'FlowLayoutPanel1.Dispose()

        myBmp.Save("C:\_test\ausgabe.jpg")

    End Sub

    Private Sub btnDraw_Click(sender As Object, e As EventArgs) Handles btnDraw.Click
        For Each pb As PictureBox In FlowLayoutPanel1.Controls
            Dim g As Graphics = pb.CreateGraphics()

            ' Create font and brush.
            Dim drawFont As New Font("Times New Roman", 18)
            Dim drawBrush As New SolidBrush(Color.Black)

            ' Set format of string.
            Dim drawFormat As New StringFormat
            drawFormat.FormatFlags = StringFormatFlags.NoWrap

            'get Layer Name
            Dim layerName As String
            layerName = ""
            Dim myChars() As Char = pb.Tag.ToCharArray()
            For Each ch As Char In myChars
                If Char.IsDigit(ch) Then
                    layerName += ch
                End If
            Next

            ' Draw string to screen.
            g.DrawString("L" & layerName & " [X.Xmm]", drawFont, drawBrush, New PointF(10, 10), drawFormat)

            'Todo:
            '   - draw the net


        Next
    End Sub

    Private Sub btnLoadConf_Click(sender As Object, e As EventArgs) Handles btnLoadConf.Click

        OpenFileDialog2.Title = "Bitte Config file waehlen"
        OpenFileDialog2.Multiselect = False
        OpenFileDialog2.ShowDialog()

        'Dim fileReader As String
        'fileReader = My.Computer.FileSystem.ReadAllText(OpenFileDialog2.FileName)

        'MessageBox.Show(fileReader)


        'Dim reader As StreamReader = My.Computer.FileSystem.OpenTextFileReader(OpenFileDialog2.FileName)
        'Dim line As String

        'Dim counter As Integer = 0
        'Do
        '    line = reader.ReadLine()
        '    Dim result As String() = Regex.Split(line, "\t")

        '    If result(0).GetType() = () Then

        '        If result(0) = (counter + 1) Then
        '            layerConf(counter) = result(1)
        '        End If

        '    End If


        'Loop Until line Is Nothing


        'MessageBox.Show(layerConf.ToString())

    End Sub
End Class
