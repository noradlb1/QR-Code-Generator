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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.TextBoxpassword = New System.Windows.Forms.TextBox()
        Me.TextBoxssid = New System.Windows.Forms.TextBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.ButtonSaveBarcode = New System.Windows.Forms.Button()
        Me.ButtonBarcodeGen = New System.Windows.Forms.Button()
        Me.TextBoxbarcodes = New System.Windows.Forms.TextBox()
        Me.PictureBoxbarcodes = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        CType(Me.PictureBoxbarcodes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.Location = New System.Drawing.Point(6, 464)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(320, 33)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "QR Generator"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(6, 6)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(320, 223)
        Me.TextBox1.TabIndex = 1
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(6, 235)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(320, 223)
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Location = New System.Drawing.Point(12, 12)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(340, 528)
        Me.TabControl1.TabIndex = 3
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.Label3)
        Me.TabPage1.Controls.Add(Me.Label2)
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Controls.Add(Me.ComboBox1)
        Me.TabPage1.Controls.Add(Me.TextBoxpassword)
        Me.TabPage1.Controls.Add(Me.TextBoxssid)
        Me.TabPage1.Controls.Add(Me.PictureBox2)
        Me.TabPage1.Controls.Add(Me.Button2)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(332, 502)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Wifi QR Gen"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 12)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(56, 13)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Wifi Name"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 115)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 13)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Password"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 164)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(84, 13)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "WPA Most used"
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"AES", "WEP", "WPA", "WPA2 "})
        Me.ComboBox1.Location = New System.Drawing.Point(6, 180)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(320, 21)
        Me.ComboBox1.TabIndex = 7
        Me.ComboBox1.Text = "WPA"
        '
        'TextBoxpassword
        '
        Me.TextBoxpassword.Location = New System.Drawing.Point(6, 134)
        Me.TextBoxpassword.Name = "TextBoxpassword"
        Me.TextBoxpassword.Size = New System.Drawing.Size(320, 20)
        Me.TextBoxpassword.TabIndex = 6
        Me.TextBoxpassword.UseSystemPasswordChar = True
        '
        'TextBoxssid
        '
        Me.TextBoxssid.Location = New System.Drawing.Point(6, 32)
        Me.TextBoxssid.Multiline = True
        Me.TextBoxssid.Name = "TextBoxssid"
        Me.TextBoxssid.Size = New System.Drawing.Size(320, 72)
        Me.TextBoxssid.TabIndex = 4
        '
        'PictureBox2
        '
        Me.PictureBox2.Location = New System.Drawing.Point(6, 235)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(320, 223)
        Me.PictureBox2.TabIndex = 5
        Me.PictureBox2.TabStop = False
        '
        'Button2
        '
        Me.Button2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button2.Location = New System.Drawing.Point(6, 464)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(320, 33)
        Me.Button2.TabIndex = 3
        Me.Button2.Text = "Wifi QR Generator"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.TextBox1)
        Me.TabPage2.Controls.Add(Me.PictureBox1)
        Me.TabPage2.Controls.Add(Me.Button1)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(332, 502)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "QR  Code Gen"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.ButtonSaveBarcode)
        Me.TabPage3.Controls.Add(Me.ButtonBarcodeGen)
        Me.TabPage3.Controls.Add(Me.TextBoxbarcodes)
        Me.TabPage3.Controls.Add(Me.PictureBoxbarcodes)
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(332, 502)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Barcodes"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'ButtonSaveBarcode
        '
        Me.ButtonSaveBarcode.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonSaveBarcode.Location = New System.Drawing.Point(6, 463)
        Me.ButtonSaveBarcode.Name = "ButtonSaveBarcode"
        Me.ButtonSaveBarcode.Size = New System.Drawing.Size(320, 33)
        Me.ButtonSaveBarcode.TabIndex = 3
        Me.ButtonSaveBarcode.Text = "SaveBarcode"
        Me.ButtonSaveBarcode.UseVisualStyleBackColor = True
        '
        'ButtonBarcodeGen
        '
        Me.ButtonBarcodeGen.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonBarcodeGen.Location = New System.Drawing.Point(6, 419)
        Me.ButtonBarcodeGen.Name = "ButtonBarcodeGen"
        Me.ButtonBarcodeGen.Size = New System.Drawing.Size(320, 33)
        Me.ButtonBarcodeGen.TabIndex = 2
        Me.ButtonBarcodeGen.Text = "GenBarcode"
        Me.ButtonBarcodeGen.UseVisualStyleBackColor = True
        '
        'TextBoxbarcodes
        '
        Me.TextBoxbarcodes.Location = New System.Drawing.Point(6, 6)
        Me.TextBoxbarcodes.Multiline = True
        Me.TextBoxbarcodes.Name = "TextBoxbarcodes"
        Me.TextBoxbarcodes.Size = New System.Drawing.Size(320, 178)
        Me.TextBoxbarcodes.TabIndex = 1
        '
        'PictureBoxbarcodes
        '
        Me.PictureBoxbarcodes.Location = New System.Drawing.Point(6, 190)
        Me.PictureBoxbarcodes.Name = "PictureBoxbarcodes"
        Me.PictureBoxbarcodes.Size = New System.Drawing.Size(320, 223)
        Me.PictureBoxbarcodes.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBoxbarcodes.TabIndex = 0
        Me.PictureBoxbarcodes.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(359, 550)
        Me.Controls.Add(Me.TabControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.Text = "QR Code Generator"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage3.PerformLayout()
        CType(Me.PictureBoxbarcodes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents TextBoxssid As TextBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Button2 As Button
    Friend WithEvents TextBoxpassword As TextBox
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents ButtonBarcodeGen As Button
    Friend WithEvents TextBoxbarcodes As TextBox
    Friend WithEvents PictureBoxbarcodes As PictureBox
    Friend WithEvents ButtonSaveBarcode As Button
End Class
