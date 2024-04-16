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
        Me.ButtonGenerateQR = New System.Windows.Forms.Button()
        Me.TextBoxQRData = New System.Windows.Forms.TextBox()
        Me.PictureBoxQR = New System.Windows.Forms.PictureBox()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ComboBoxEncryptionType = New System.Windows.Forms.ComboBox()
        Me.TextBoxpassword = New System.Windows.Forms.TextBox()
        Me.TextBoxssid = New System.Windows.Forms.TextBox()
        Me.PictureBoxWifiQR = New System.Windows.Forms.PictureBox()
        Me.ButtonGenerateWifiQR = New System.Windows.Forms.Button()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.ButtonButtonPreview = New System.Windows.Forms.Button()
        Me.CheckBoxCustomSize = New System.Windows.Forms.CheckBox()
        Me.NumericUpDownYPosition = New System.Windows.Forms.NumericUpDown()
        Me.NumericUpDownXPosition = New System.Windows.Forms.NumericUpDown()
        Me.NumericUpDownHeight = New System.Windows.Forms.NumericUpDown()
        Me.NumericUpDownWidth = New System.Windows.Forms.NumericUpDown()
        Me.ButtonPrint = New System.Windows.Forms.Button()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.ComboBoxBarcodeType = New System.Windows.Forms.ComboBox()
        Me.ButtonSaveBarcode = New System.Windows.Forms.Button()
        Me.ButtonGenerateBarcode = New System.Windows.Forms.Button()
        Me.TextBoxbarcodes = New System.Windows.Forms.TextBox()
        Me.PictureBoxbarcodes = New System.Windows.Forms.PictureBox()
        Me.TabPage4 = New System.Windows.Forms.TabPage()
        Me.NumericUpDownGenNumbAndWord = New System.Windows.Forms.NumericUpDown()
        Me.TextBoxGenNumbAndWord = New System.Windows.Forms.TextBox()
        Me.ButtonGenNumbAndWord = New System.Windows.Forms.Button()
        Me.NumericUpDownWordGen = New System.Windows.Forms.NumericUpDown()
        Me.TextBoxWordGen = New System.Windows.Forms.TextBox()
        Me.ButtonWordGen = New System.Windows.Forms.Button()
        Me.NumericUpDownGenNumbers = New System.Windows.Forms.NumericUpDown()
        Me.TextBoxGenNumbers = New System.Windows.Forms.TextBox()
        Me.ButtonGenNumbers = New System.Windows.Forms.Button()
        Me.TabPage5 = New System.Windows.Forms.TabPage()
        Me.txtImageUrl = New System.Windows.Forms.TextBox()
        Me.btnLoadFromUrl = New System.Windows.Forms.Button()
        Me.btnOpenCamera = New System.Windows.Forms.Button()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.resultTextBox = New System.Windows.Forms.TextBox()
        Me.BarcodeScannerPictureBox = New System.Windows.Forms.PictureBox()
        Me.btnScan = New System.Windows.Forms.Button()
        CType(Me.PictureBoxQR, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.PictureBoxWifiQR, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        CType(Me.NumericUpDownYPosition, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDownXPosition, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDownHeight, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDownWidth, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage3.SuspendLayout()
        CType(Me.PictureBoxbarcodes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage4.SuspendLayout()
        CType(Me.NumericUpDownGenNumbAndWord, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDownWordGen, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDownGenNumbers, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage5.SuspendLayout()
        CType(Me.BarcodeScannerPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ButtonGenerateQR
        '
        Me.ButtonGenerateQR.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonGenerateQR.Location = New System.Drawing.Point(6, 463)
        Me.ButtonGenerateQR.Name = "ButtonGenerateQR"
        Me.ButtonGenerateQR.Size = New System.Drawing.Size(320, 33)
        Me.ButtonGenerateQR.TabIndex = 0
        Me.ButtonGenerateQR.Text = "QR Generator"
        Me.ButtonGenerateQR.UseVisualStyleBackColor = True
        '
        'TextBoxQRData
        '
        Me.TextBoxQRData.Location = New System.Drawing.Point(6, 6)
        Me.TextBoxQRData.Multiline = True
        Me.TextBoxQRData.Name = "TextBoxQRData"
        Me.TextBoxQRData.Size = New System.Drawing.Size(320, 223)
        Me.TextBoxQRData.TabIndex = 1
        '
        'PictureBoxQR
        '
        Me.PictureBoxQR.Location = New System.Drawing.Point(6, 235)
        Me.PictureBoxQR.Name = "PictureBoxQR"
        Me.PictureBoxQR.Size = New System.Drawing.Size(320, 223)
        Me.PictureBoxQR.TabIndex = 2
        Me.PictureBoxQR.TabStop = False
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Controls.Add(Me.TabPage4)
        Me.TabControl1.Controls.Add(Me.TabPage5)
        Me.TabControl1.Location = New System.Drawing.Point(12, 12)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(340, 593)
        Me.TabControl1.TabIndex = 3
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.Label3)
        Me.TabPage1.Controls.Add(Me.Label2)
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Controls.Add(Me.ComboBoxEncryptionType)
        Me.TabPage1.Controls.Add(Me.TextBoxpassword)
        Me.TabPage1.Controls.Add(Me.TextBoxssid)
        Me.TabPage1.Controls.Add(Me.PictureBoxWifiQR)
        Me.TabPage1.Controls.Add(Me.ButtonGenerateWifiQR)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(332, 567)
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
        'ComboBoxEncryptionType
        '
        Me.ComboBoxEncryptionType.FormattingEnabled = True
        Me.ComboBoxEncryptionType.Items.AddRange(New Object() {"AES", "WEP", "WPA", "WPA2 "})
        Me.ComboBoxEncryptionType.Location = New System.Drawing.Point(6, 180)
        Me.ComboBoxEncryptionType.Name = "ComboBoxEncryptionType"
        Me.ComboBoxEncryptionType.Size = New System.Drawing.Size(320, 21)
        Me.ComboBoxEncryptionType.TabIndex = 7
        Me.ComboBoxEncryptionType.Text = "WPA"
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
        'PictureBoxWifiQR
        '
        Me.PictureBoxWifiQR.Location = New System.Drawing.Point(6, 235)
        Me.PictureBoxWifiQR.Name = "PictureBoxWifiQR"
        Me.PictureBoxWifiQR.Size = New System.Drawing.Size(320, 223)
        Me.PictureBoxWifiQR.TabIndex = 5
        Me.PictureBoxWifiQR.TabStop = False
        '
        'ButtonGenerateWifiQR
        '
        Me.ButtonGenerateWifiQR.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonGenerateWifiQR.Location = New System.Drawing.Point(6, 464)
        Me.ButtonGenerateWifiQR.Name = "ButtonGenerateWifiQR"
        Me.ButtonGenerateWifiQR.Size = New System.Drawing.Size(320, 33)
        Me.ButtonGenerateWifiQR.TabIndex = 3
        Me.ButtonGenerateWifiQR.Text = "Wifi QR Generator"
        Me.ButtonGenerateWifiQR.UseVisualStyleBackColor = True
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.ButtonButtonPreview)
        Me.TabPage2.Controls.Add(Me.CheckBoxCustomSize)
        Me.TabPage2.Controls.Add(Me.NumericUpDownYPosition)
        Me.TabPage2.Controls.Add(Me.NumericUpDownXPosition)
        Me.TabPage2.Controls.Add(Me.NumericUpDownHeight)
        Me.TabPage2.Controls.Add(Me.NumericUpDownWidth)
        Me.TabPage2.Controls.Add(Me.ButtonPrint)
        Me.TabPage2.Controls.Add(Me.TextBoxQRData)
        Me.TabPage2.Controls.Add(Me.PictureBoxQR)
        Me.TabPage2.Controls.Add(Me.ButtonGenerateQR)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(332, 567)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "QR  Code Gen"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'ButtonButtonPreview
        '
        Me.ButtonButtonPreview.Location = New System.Drawing.Point(228, 541)
        Me.ButtonButtonPreview.Name = "ButtonButtonPreview"
        Me.ButtonButtonPreview.Size = New System.Drawing.Size(75, 23)
        Me.ButtonButtonPreview.TabIndex = 9
        Me.ButtonButtonPreview.Text = "Preview"
        Me.ButtonButtonPreview.UseVisualStyleBackColor = True
        '
        'CheckBoxCustomSize
        '
        Me.CheckBoxCustomSize.AutoSize = True
        Me.CheckBoxCustomSize.Location = New System.Drawing.Point(26, 544)
        Me.CheckBoxCustomSize.Name = "CheckBoxCustomSize"
        Me.CheckBoxCustomSize.Size = New System.Drawing.Size(130, 17)
        Me.CheckBoxCustomSize.TabIndex = 8
        Me.CheckBoxCustomSize.Text = "CheckBoxCustomSize"
        Me.CheckBoxCustomSize.UseVisualStyleBackColor = True
        '
        'NumericUpDownYPosition
        '
        Me.NumericUpDownYPosition.Location = New System.Drawing.Point(206, 522)
        Me.NumericUpDownYPosition.Maximum = New Decimal(New Integer() {8000, 0, 0, 0})
        Me.NumericUpDownYPosition.Name = "NumericUpDownYPosition"
        Me.NumericUpDownYPosition.Size = New System.Drawing.Size(120, 20)
        Me.NumericUpDownYPosition.TabIndex = 7
        Me.NumericUpDownYPosition.Value = New Decimal(New Integer() {50, 0, 0, 0})
        '
        'NumericUpDownXPosition
        '
        Me.NumericUpDownXPosition.Location = New System.Drawing.Point(206, 496)
        Me.NumericUpDownXPosition.Maximum = New Decimal(New Integer() {8000, 0, 0, 0})
        Me.NumericUpDownXPosition.Name = "NumericUpDownXPosition"
        Me.NumericUpDownXPosition.Size = New System.Drawing.Size(120, 20)
        Me.NumericUpDownXPosition.TabIndex = 6
        Me.NumericUpDownXPosition.Value = New Decimal(New Integer() {50, 0, 0, 0})
        '
        'NumericUpDownHeight
        '
        Me.NumericUpDownHeight.Location = New System.Drawing.Point(87, 522)
        Me.NumericUpDownHeight.Maximum = New Decimal(New Integer() {8000, 0, 0, 0})
        Me.NumericUpDownHeight.Name = "NumericUpDownHeight"
        Me.NumericUpDownHeight.Size = New System.Drawing.Size(120, 20)
        Me.NumericUpDownHeight.TabIndex = 5
        Me.NumericUpDownHeight.Value = New Decimal(New Integer() {200, 0, 0, 0})
        '
        'NumericUpDownWidth
        '
        Me.NumericUpDownWidth.Location = New System.Drawing.Point(87, 496)
        Me.NumericUpDownWidth.Maximum = New Decimal(New Integer() {80000, 0, 0, 0})
        Me.NumericUpDownWidth.Name = "NumericUpDownWidth"
        Me.NumericUpDownWidth.Size = New System.Drawing.Size(120, 20)
        Me.NumericUpDownWidth.TabIndex = 4
        Me.NumericUpDownWidth.Value = New Decimal(New Integer() {200, 0, 0, 0})
        '
        'ButtonPrint
        '
        Me.ButtonPrint.Location = New System.Drawing.Point(6, 496)
        Me.ButtonPrint.Name = "ButtonPrint"
        Me.ButtonPrint.Size = New System.Drawing.Size(75, 23)
        Me.ButtonPrint.TabIndex = 3
        Me.ButtonPrint.Text = "ButtonPrintQR"
        Me.ButtonPrint.UseVisualStyleBackColor = True
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.ComboBoxBarcodeType)
        Me.TabPage3.Controls.Add(Me.ButtonSaveBarcode)
        Me.TabPage3.Controls.Add(Me.ButtonGenerateBarcode)
        Me.TabPage3.Controls.Add(Me.TextBoxbarcodes)
        Me.TabPage3.Controls.Add(Me.PictureBoxbarcodes)
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(332, 567)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Barcodes"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'ComboBoxBarcodeType
        '
        Me.ComboBoxBarcodeType.FormattingEnabled = True
        Me.ComboBoxBarcodeType.Items.AddRange(New Object() {"CODE_128", "UPC_A", "EAN_13", "All_1D", "AZTEC", "CODABAR", "CODE_39", "CODE_93", "DATA_MATRIX", "EAN_8", "IMB", "ITF", "MAXICODE", "MSI", "PDF_417", "PHARMA_CODE", "PLESSEY", "QR_CODE", "RSS_14", "RSS_EXPANDED", "UPC_E", "UPC_EAN_EXTENSION"})
        Me.ComboBoxBarcodeType.Location = New System.Drawing.Point(6, 120)
        Me.ComboBoxBarcodeType.Name = "ComboBoxBarcodeType"
        Me.ComboBoxBarcodeType.Size = New System.Drawing.Size(320, 21)
        Me.ComboBoxBarcodeType.TabIndex = 4
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
        'ButtonGenerateBarcode
        '
        Me.ButtonGenerateBarcode.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonGenerateBarcode.Location = New System.Drawing.Point(6, 419)
        Me.ButtonGenerateBarcode.Name = "ButtonGenerateBarcode"
        Me.ButtonGenerateBarcode.Size = New System.Drawing.Size(320, 33)
        Me.ButtonGenerateBarcode.TabIndex = 2
        Me.ButtonGenerateBarcode.Text = "GenBarcode"
        Me.ButtonGenerateBarcode.UseVisualStyleBackColor = True
        '
        'TextBoxbarcodes
        '
        Me.TextBoxbarcodes.Location = New System.Drawing.Point(6, 6)
        Me.TextBoxbarcodes.Multiline = True
        Me.TextBoxbarcodes.Name = "TextBoxbarcodes"
        Me.TextBoxbarcodes.Size = New System.Drawing.Size(320, 92)
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
        'TabPage4
        '
        Me.TabPage4.Controls.Add(Me.NumericUpDownGenNumbAndWord)
        Me.TabPage4.Controls.Add(Me.TextBoxGenNumbAndWord)
        Me.TabPage4.Controls.Add(Me.ButtonGenNumbAndWord)
        Me.TabPage4.Controls.Add(Me.NumericUpDownWordGen)
        Me.TabPage4.Controls.Add(Me.TextBoxWordGen)
        Me.TabPage4.Controls.Add(Me.ButtonWordGen)
        Me.TabPage4.Controls.Add(Me.NumericUpDownGenNumbers)
        Me.TabPage4.Controls.Add(Me.TextBoxGenNumbers)
        Me.TabPage4.Controls.Add(Me.ButtonGenNumbers)
        Me.TabPage4.Location = New System.Drawing.Point(4, 22)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage4.Size = New System.Drawing.Size(332, 567)
        Me.TabPage4.TabIndex = 3
        Me.TabPage4.Text = "Genrator"
        Me.TabPage4.UseVisualStyleBackColor = True
        '
        'NumericUpDownGenNumbAndWord
        '
        Me.NumericUpDownGenNumbAndWord.Location = New System.Drawing.Point(21, 200)
        Me.NumericUpDownGenNumbAndWord.Name = "NumericUpDownGenNumbAndWord"
        Me.NumericUpDownGenNumbAndWord.Size = New System.Drawing.Size(120, 20)
        Me.NumericUpDownGenNumbAndWord.TabIndex = 9
        '
        'TextBoxGenNumbAndWord
        '
        Me.TextBoxGenNumbAndWord.Location = New System.Drawing.Point(4, 174)
        Me.TextBoxGenNumbAndWord.Multiline = True
        Me.TextBoxGenNumbAndWord.Name = "TextBoxGenNumbAndWord"
        Me.TextBoxGenNumbAndWord.Size = New System.Drawing.Size(149, 20)
        Me.TextBoxGenNumbAndWord.TabIndex = 8
        '
        'ButtonGenNumbAndWord
        '
        Me.ButtonGenNumbAndWord.Location = New System.Drawing.Point(21, 226)
        Me.ButtonGenNumbAndWord.Name = "ButtonGenNumbAndWord"
        Me.ButtonGenNumbAndWord.Size = New System.Drawing.Size(120, 23)
        Me.ButtonGenNumbAndWord.TabIndex = 7
        Me.ButtonGenNumbAndWord.Text = "GenNumbAndWord"
        Me.ButtonGenNumbAndWord.UseVisualStyleBackColor = True
        '
        'NumericUpDownWordGen
        '
        Me.NumericUpDownWordGen.Location = New System.Drawing.Point(21, 119)
        Me.NumericUpDownWordGen.Name = "NumericUpDownWordGen"
        Me.NumericUpDownWordGen.Size = New System.Drawing.Size(120, 20)
        Me.NumericUpDownWordGen.TabIndex = 6
        '
        'TextBoxWordGen
        '
        Me.TextBoxWordGen.Location = New System.Drawing.Point(4, 94)
        Me.TextBoxWordGen.Multiline = True
        Me.TextBoxWordGen.Name = "TextBoxWordGen"
        Me.TextBoxWordGen.Size = New System.Drawing.Size(149, 20)
        Me.TextBoxWordGen.TabIndex = 5
        '
        'ButtonWordGen
        '
        Me.ButtonWordGen.Location = New System.Drawing.Point(21, 145)
        Me.ButtonWordGen.Name = "ButtonWordGen"
        Me.ButtonWordGen.Size = New System.Drawing.Size(120, 23)
        Me.ButtonWordGen.TabIndex = 4
        Me.ButtonWordGen.Text = "ButtonWordGen"
        Me.ButtonWordGen.UseVisualStyleBackColor = True
        '
        'NumericUpDownGenNumbers
        '
        Me.NumericUpDownGenNumbers.Location = New System.Drawing.Point(21, 33)
        Me.NumericUpDownGenNumbers.Name = "NumericUpDownGenNumbers"
        Me.NumericUpDownGenNumbers.Size = New System.Drawing.Size(120, 20)
        Me.NumericUpDownGenNumbers.TabIndex = 3
        '
        'TextBoxGenNumbers
        '
        Me.TextBoxGenNumbers.Location = New System.Drawing.Point(4, 7)
        Me.TextBoxGenNumbers.Multiline = True
        Me.TextBoxGenNumbers.Name = "TextBoxGenNumbers"
        Me.TextBoxGenNumbers.Size = New System.Drawing.Size(149, 20)
        Me.TextBoxGenNumbers.TabIndex = 1
        '
        'ButtonGenNumbers
        '
        Me.ButtonGenNumbers.Location = New System.Drawing.Point(21, 59)
        Me.ButtonGenNumbers.Name = "ButtonGenNumbers"
        Me.ButtonGenNumbers.Size = New System.Drawing.Size(120, 23)
        Me.ButtonGenNumbers.TabIndex = 0
        Me.ButtonGenNumbers.Text = "ButtonGenNumbers"
        Me.ButtonGenNumbers.UseVisualStyleBackColor = True
        '
        'TabPage5
        '
        Me.TabPage5.Controls.Add(Me.txtImageUrl)
        Me.TabPage5.Controls.Add(Me.btnLoadFromUrl)
        Me.TabPage5.Controls.Add(Me.btnOpenCamera)
        Me.TabPage5.Controls.Add(Me.ProgressBar1)
        Me.TabPage5.Controls.Add(Me.resultTextBox)
        Me.TabPage5.Controls.Add(Me.BarcodeScannerPictureBox)
        Me.TabPage5.Controls.Add(Me.btnScan)
        Me.TabPage5.Location = New System.Drawing.Point(4, 22)
        Me.TabPage5.Name = "TabPage5"
        Me.TabPage5.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage5.Size = New System.Drawing.Size(332, 567)
        Me.TabPage5.TabIndex = 4
        Me.TabPage5.Text = "Digital Signature"
        Me.TabPage5.UseVisualStyleBackColor = True
        '
        'txtImageUrl
        '
        Me.txtImageUrl.Location = New System.Drawing.Point(9, 106)
        Me.txtImageUrl.Name = "txtImageUrl"
        Me.txtImageUrl.Size = New System.Drawing.Size(320, 20)
        Me.txtImageUrl.TabIndex = 7
        '
        'btnLoadFromUrl
        '
        Me.btnLoadFromUrl.Location = New System.Drawing.Point(113, 151)
        Me.btnLoadFromUrl.Name = "btnLoadFromUrl"
        Me.btnLoadFromUrl.Size = New System.Drawing.Size(99, 23)
        Me.btnLoadFromUrl.TabIndex = 6
        Me.btnLoadFromUrl.Text = "btnLoadFromUrl"
        Me.btnLoadFromUrl.UseVisualStyleBackColor = True
        '
        'btnOpenCamera
        '
        Me.btnOpenCamera.Location = New System.Drawing.Point(113, 56)
        Me.btnOpenCamera.Name = "btnOpenCamera"
        Me.btnOpenCamera.Size = New System.Drawing.Size(99, 23)
        Me.btnOpenCamera.TabIndex = 5
        Me.btnOpenCamera.Text = "btnOpenCamera"
        Me.btnOpenCamera.UseVisualStyleBackColor = True
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(36, 503)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(256, 23)
        Me.ProgressBar1.TabIndex = 4
        '
        'resultTextBox
        '
        Me.resultTextBox.Location = New System.Drawing.Point(9, 180)
        Me.resultTextBox.Name = "resultTextBox"
        Me.resultTextBox.Size = New System.Drawing.Size(320, 20)
        Me.resultTextBox.TabIndex = 3
        '
        'BarcodeScannerPictureBox
        '
        Me.BarcodeScannerPictureBox.Location = New System.Drawing.Point(6, 206)
        Me.BarcodeScannerPictureBox.Name = "BarcodeScannerPictureBox"
        Me.BarcodeScannerPictureBox.Size = New System.Drawing.Size(323, 261)
        Me.BarcodeScannerPictureBox.TabIndex = 2
        Me.BarcodeScannerPictureBox.TabStop = False
        '
        'btnScan
        '
        Me.btnScan.Location = New System.Drawing.Point(126, 6)
        Me.btnScan.Name = "btnScan"
        Me.btnScan.Size = New System.Drawing.Size(75, 23)
        Me.btnScan.TabIndex = 0
        Me.btnScan.Text = "btnScan"
        Me.btnScan.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(359, 607)
        Me.Controls.Add(Me.TabControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.Text = "QR Code Generator"
        CType(Me.PictureBoxQR, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        CType(Me.PictureBoxWifiQR, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        CType(Me.NumericUpDownYPosition, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDownXPosition, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDownHeight, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDownWidth, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage3.PerformLayout()
        CType(Me.PictureBoxbarcodes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage4.ResumeLayout(False)
        Me.TabPage4.PerformLayout()
        CType(Me.NumericUpDownGenNumbAndWord, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDownWordGen, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDownGenNumbers, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage5.ResumeLayout(False)
        Me.TabPage5.PerformLayout()
        CType(Me.BarcodeScannerPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ButtonGenerateQR As Button
    Friend WithEvents TextBoxQRData As TextBox
    Friend WithEvents PictureBoxQR As PictureBox
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents TextBoxssid As TextBox
    Friend WithEvents PictureBoxWifiQR As PictureBox
    Friend WithEvents ButtonGenerateWifiQR As Button
    Friend WithEvents TextBoxpassword As TextBox
    Friend WithEvents ComboBoxEncryptionType As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents ButtonGenerateBarcode As Button
    Friend WithEvents TextBoxbarcodes As TextBox
    Friend WithEvents PictureBoxbarcodes As PictureBox
    Friend WithEvents ButtonSaveBarcode As Button
    Friend WithEvents ButtonPrint As Button
    Friend WithEvents ComboBoxBarcodeType As ComboBox
    Friend WithEvents TabPage4 As TabPage
    Friend WithEvents TextBoxGenNumbers As TextBox
    Friend WithEvents ButtonGenNumbers As Button
    Friend WithEvents NumericUpDownGenNumbers As NumericUpDown
    Friend WithEvents TextBoxWordGen As TextBox
    Friend WithEvents ButtonWordGen As Button
    Friend WithEvents NumericUpDownWordGen As NumericUpDown
    Friend WithEvents NumericUpDownGenNumbAndWord As NumericUpDown
    Friend WithEvents TextBoxGenNumbAndWord As TextBox
    Friend WithEvents ButtonGenNumbAndWord As Button
    Friend WithEvents NumericUpDownYPosition As NumericUpDown
    Friend WithEvents NumericUpDownXPosition As NumericUpDown
    Friend WithEvents NumericUpDownHeight As NumericUpDown
    Friend WithEvents NumericUpDownWidth As NumericUpDown
    Friend WithEvents CheckBoxCustomSize As CheckBox
    Friend WithEvents ButtonButtonPreview As Button
    Friend WithEvents TabPage5 As TabPage
    Friend WithEvents btnScan As Button
    Friend WithEvents BarcodeScannerPictureBox As PictureBox
    Friend WithEvents resultTextBox As TextBox
    Friend WithEvents ProgressBar1 As ProgressBar
    Friend WithEvents btnOpenCamera As Button
    Friend WithEvents btnLoadFromUrl As Button
    Friend WithEvents txtImageUrl As TextBox
End Class
