<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.lblFile = New System.Windows.Forms.Label()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.btnOpen = New System.Windows.Forms.Button()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblSelectedImages = New System.Windows.Forms.Label()
        Me.lblImageAmount = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.OpenFileDialog2 = New System.Windows.Forms.OpenFileDialog()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.savePathLabel = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblFile
        '
        Me.lblFile.AutoSize = True
        Me.lblFile.Location = New System.Drawing.Point(261, 35)
        Me.lblFile.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblFile.Name = "lblFile"
        Me.lblFile.Size = New System.Drawing.Size(80, 13)
        Me.lblFile.TabIndex = 0
        Me.lblFile.Text = "No file selected"
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'btnOpen
        '
        Me.btnOpen.Location = New System.Drawing.Point(2, 35)
        Me.btnOpen.Margin = New System.Windows.Forms.Padding(2)
        Me.btnOpen.Name = "btnOpen"
        Me.btnOpen.Size = New System.Drawing.Size(109, 38)
        Me.btnOpen.TabIndex = 1
        Me.btnOpen.Text = "Open File and Config"
        Me.btnOpen.UseVisualStyleBackColor = True
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.AutoSize = True
        Me.FlowLayoutPanel1.BackColor = System.Drawing.SystemColors.Control
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(2, 80)
        Me.FlowLayoutPanel1.Margin = New System.Windows.Forms.Padding(2)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(1100, 366)
        Me.FlowLayoutPanel1.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(-1, 7)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(121, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Please select 10 images"
        '
        'lblSelectedImages
        '
        Me.lblSelectedImages.AutoSize = True
        Me.lblSelectedImages.Location = New System.Drawing.Point(164, 7)
        Me.lblSelectedImages.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblSelectedImages.Name = "lblSelectedImages"
        Me.lblSelectedImages.Size = New System.Drawing.Size(89, 13)
        Me.lblSelectedImages.TabIndex = 4
        Me.lblSelectedImages.Text = "Selected Images:"
        '
        'lblImageAmount
        '
        Me.lblImageAmount.AutoSize = True
        Me.lblImageAmount.Location = New System.Drawing.Point(253, 7)
        Me.lblImageAmount.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblImageAmount.Name = "lblImageAmount"
        Me.lblImageAmount.Size = New System.Drawing.Size(13, 13)
        Me.lblImageAmount.TabIndex = 5
        Me.lblImageAmount.Text = "0"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(128, 35)
        Me.Button1.Margin = New System.Windows.Forms.Padding(2)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(113, 38)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "Export"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'OpenFileDialog2
        '
        Me.OpenFileDialog2.FileName = "OpenFileDialog2"
        '
        'savePathLabel
        '
        Me.savePathLabel.AutoSize = True
        Me.savePathLabel.Location = New System.Drawing.Point(266, 60)
        Me.savePathLabel.Name = "savePathLabel"
        Me.savePathLabel.Size = New System.Drawing.Size(0, 13)
        Me.savePathLabel.TabIndex = 7
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(1028, 456)
        Me.Controls.Add(Me.savePathLabel)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.lblImageAmount)
        Me.Controls.Add(Me.lblSelectedImages)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.FlowLayoutPanel1)
        Me.Controls.Add(Me.btnOpen)
        Me.Controls.Add(Me.lblFile)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "Form1"
        Me.Text = "Image Overlapping stuff"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblFile As Label
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents btnOpen As Button
    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents Label1 As Label
    Friend WithEvents lblSelectedImages As Label
    Friend WithEvents lblImageAmount As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents OpenFileDialog2 As OpenFileDialog
    Friend WithEvents SaveFileDialog1 As SaveFileDialog
    Friend WithEvents savePathLabel As Label
End Class
