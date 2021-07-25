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
        Me.SuspendLayout()
        '
        'lblFile
        '
        Me.lblFile.AutoSize = True
        Me.lblFile.Location = New System.Drawing.Point(348, 43)
        Me.lblFile.Name = "lblFile"
        Me.lblFile.Size = New System.Drawing.Size(105, 17)
        Me.lblFile.TabIndex = 0
        Me.lblFile.Text = "No file selected"
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'btnOpen
        '
        Me.btnOpen.Location = New System.Drawing.Point(2, 43)
        Me.btnOpen.Name = "btnOpen"
        Me.btnOpen.Size = New System.Drawing.Size(145, 47)
        Me.btnOpen.TabIndex = 1
        Me.btnOpen.Text = "Open File and Config"
        Me.btnOpen.UseVisualStyleBackColor = True
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.AutoSize = True
        Me.FlowLayoutPanel1.BackColor = System.Drawing.SystemColors.Control
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(2, 99)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(1467, 450)
        Me.FlowLayoutPanel1.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(-1, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(161, 17)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Please select 10 images"
        '
        'lblSelectedImages
        '
        Me.lblSelectedImages.AutoSize = True
        Me.lblSelectedImages.Location = New System.Drawing.Point(218, 9)
        Me.lblSelectedImages.Name = "lblSelectedImages"
        Me.lblSelectedImages.Size = New System.Drawing.Size(116, 17)
        Me.lblSelectedImages.TabIndex = 4
        Me.lblSelectedImages.Text = "Selected Images:"
        '
        'lblImageAmount
        '
        Me.lblImageAmount.AutoSize = True
        Me.lblImageAmount.Location = New System.Drawing.Point(337, 9)
        Me.lblImageAmount.Name = "lblImageAmount"
        Me.lblImageAmount.Size = New System.Drawing.Size(16, 17)
        Me.lblImageAmount.TabIndex = 5
        Me.lblImageAmount.Text = "0"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(171, 43)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(151, 47)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "Export"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'OpenFileDialog2
        '
        Me.OpenFileDialog2.FileName = "OpenFileDialog2"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(1498, 561)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.lblImageAmount)
        Me.Controls.Add(Me.lblSelectedImages)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.FlowLayoutPanel1)
        Me.Controls.Add(Me.btnOpen)
        Me.Controls.Add(Me.lblFile)
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
End Class
