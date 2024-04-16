Imports System.Drawing.Printing
Imports System.IO
Imports ZXing
Imports ZXing.QrCode
Imports System
Imports System.Text
Imports System.Timers
Imports System.Drawing
Imports System.Windows.Forms
Imports IronBarCode
Imports BarcodeWriter = ZXing.BarcodeWriter
Imports BarcodeReader = IronBarCode.BarcodeReader
Imports System.Net
Imports Emgu.CV
Imports Emgu.CV.CvEnum
Imports Emgu.CV.Structure

Public Class Form1
    Private Sub CheckBoxCustomSize_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBoxCustomSize.CheckedChanged
        If CheckBoxCustomSize.Checked = True Then
            NumericUpDownWidth.Enabled = True
            NumericUpDownHeight.Enabled = True
            NumericUpDownXPosition.Enabled = True
            NumericUpDownYPosition.Enabled = True
        Else
            NumericUpDownWidth.Enabled = False
            NumericUpDownHeight.Enabled = False
            NumericUpDownXPosition.Enabled = False
            NumericUpDownYPosition.Enabled = False
        End If
    End Sub
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        NumericUpDownWidth.Enabled = False
        NumericUpDownHeight.Enabled = False
        NumericUpDownXPosition.Enabled = False
        NumericUpDownYPosition.Enabled = False
        ' تنفيذ إنشاء جدول قاعدة البيانات عند تحميل النموذج

    End Sub
    ' زر إنشاء رمز الاستجابة السريعة العادي
    Private Sub ButtonGenerateQR_Click(sender As Object, e As EventArgs) Handles ButtonGenerateQR.Click
        Dim qrGenerator As New BarcodeWriter
        qrGenerator.Format = BarcodeFormat.QR_CODE
        qrGenerator.Options = New ZXing.Common.EncodingOptions With {
            .Width = 316,
            .Height = 220
        }
        Dim result As Bitmap = qrGenerator.Write(TextBoxQRData.Text)
        PictureBoxQR.Image = result

        ' حفظ الصورة
        SaveImage(result)
    End Sub

    ' زر إنشاء رمز الاستجابة السريعة للواي فاي
    Private Sub ButtonGenerateWifiQR_Click(sender As Object, e As EventArgs) Handles ButtonGenerateWifiQR.Click
        Dim ssid As String = TextBoxssid.Text
        Dim password As String = TextBoxpassword.Text
        Dim encryptionType As String = ComboBoxEncryptionType.Text
        Dim wifiData As String = $"WIFI:S:{ssid};T:{encryptionType};P:{password};;"

        Dim qrWriter As New BarcodeWriter()
        qrWriter.Format = BarcodeFormat.QR_CODE
        qrWriter.Options = New QrCodeEncodingOptions With {
            .Width = 316,
            .Height = 220
        }

        Dim qrCodeBitmap As Bitmap = qrWriter.Write(wifiData)
        PictureBoxWifiQR.Image = qrCodeBitmap

        ' حفظ الصورة
        SaveImage(qrCodeBitmap)
    End Sub

    ' زر إنشاء الباركود
    Private Sub ButtonGenerateBarcode_Click(sender As Object, e As EventArgs) Handles ButtonGenerateBarcode.Click
        Dim result As Bitmap = Nothing ' إنشاء متغير لحفظ الصورة

        ' إنشاء الباركود حسب نوعه المحدد في ComboBoxBarcodeType
        Select Case ComboBoxBarcodeType.Text
            Case "CODE_128"
                Dim writer As New BarcodeWriter()
                writer.Format = BarcodeFormat.CODE_128
                result = writer.Write(TextBoxbarcodes.Text)
            Case "UPC_A"
                Try
                    Dim writer As New BarcodeWriter()
                    writer.Format = BarcodeFormat.UPC_A
                    result = writer.Write(TextBoxbarcodes.Text)
                Catch ex As Exception
                    MessageBox.Show("يجب أن يحتوي النص على 11 رقمًا فقط.", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                End Try
            Case "EAN_13"
                Try
                    Dim writer As New BarcodeWriter()
                    writer.Format = BarcodeFormat.EAN_13
                    result = writer.Write(TextBoxbarcodes.Text)
                Catch ex As Exception
                    MessageBox.Show("يجب أن يحتوي النص على 12 رقمًا فقط.", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                End Try
            Case "All_1D"
                Try
                    Dim writer As New BarcodeWriter()
                    writer.Format = BarcodeFormat.All_1D
                    result = writer.Write(TextBoxbarcodes.Text)
                Catch ex As Exception
                    MessageBox.Show("خطء.", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                End Try
            Case "AZTEC"
                Try
                    Dim writer As New BarcodeWriter()
                    writer.Format = BarcodeFormat.AZTEC
                    result = writer.Write(TextBoxbarcodes.Text)
                Catch ex As Exception
                    MessageBox.Show("خطء.", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                End Try
            Case "CODABAR"
                Try
                    Dim writer As New BarcodeWriter()
                    writer.Format = BarcodeFormat.CODABAR
                    result = writer.Write(TextBoxbarcodes.Text)
                Catch ex As Exception
                    MessageBox.Show("يجب ان يحتوي على ارقام.", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                End Try
            Case "CODE_39"
                Try
                    Dim writer As New BarcodeWriter()
                    writer.Format = BarcodeFormat.CODE_39
                    result = writer.Write(TextBoxbarcodes.Text)
                Catch ex As Exception
                    MessageBox.Show("يجب أن يحتوي النص على 12 رقمًا فقط.", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                End Try
            Case "CODE_93"
                Try
                    Dim writer As New BarcodeWriter()
                    writer.Format = BarcodeFormat.CODE_93
                    result = writer.Write(TextBoxbarcodes.Text)
                Catch ex As Exception
                    MessageBox.Show("يجب أن يحتوي النص على 12 رقمًا فقط.", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                End Try
            Case "DATA_MATRIX"
                Try
                    Dim writer As New BarcodeWriter()
                    writer.Format = BarcodeFormat.DATA_MATRIX
                    result = writer.Write(TextBoxbarcodes.Text)
                Catch ex As Exception
                    MessageBox.Show("يجب أن يحتوي النص على 12 رقمًا فقط.", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                End Try
            Case "EAN_8"
                Try
                    Dim writer As New BarcodeWriter()
                    writer.Format = BarcodeFormat.EAN_8
                    result = writer.Write(TextBoxbarcodes.Text)
                Catch ex As Exception
                    MessageBox.Show("يجب أن يحتوي النص على 7 ارقام فقط.", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                End Try
            Case "IMB"
                Try
                    Dim writer As New BarcodeWriter()
                    writer.Format = BarcodeFormat.IMB
                    result = writer.Write(TextBoxbarcodes.Text)
                Catch ex As Exception
                    MessageBox.Show("خطء", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                End Try
            Case "ITF"
                Try
                    Dim writer As New BarcodeWriter()
                    writer.Format = BarcodeFormat.ITF
                    result = writer.Write(TextBoxbarcodes.Text)
                Catch ex As Exception
                    MessageBox.Show(" يجب ان يحتوي على ارقام عدد جوزي وليس فردي.", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                End Try
            Case "MAXICODE"
                Try
                    Dim writer As New BarcodeWriter()
                    writer.Format = BarcodeFormat.MAXICODE
                    result = writer.Write(TextBoxbarcodes.Text)
                Catch ex As Exception
                    MessageBox.Show("خطء", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                End Try
            Case "MSI"
                Try
                    Dim writer As New BarcodeWriter()
                    writer.Format = BarcodeFormat.MSI
                    result = writer.Write(TextBoxbarcodes.Text)
                Catch ex As Exception
                    MessageBox.Show("يجب ان يحتوي على ارقام.", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                End Try
            Case "PDF_417"
                Try
                    Dim writer As New BarcodeWriter()
                    writer.Format = BarcodeFormat.PDF_417
                    result = writer.Write(TextBoxbarcodes.Text)
                    MessageBox.Show("يجب ان يكون كتالي مثال (This is a PDF417 by MONSTER-MC).", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    TextBoxbarcodes.Text = "This is a PDF417 by MONSTER-MC"
                Catch ex As Exception
                    MessageBox.Show("يجب ان يحتوي على ارقام.", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                End Try
            Case "PHARMA_CODE"
                Try
                    Dim writer As New BarcodeWriter()
                    writer.Format = BarcodeFormat.PHARMA_CODE
                    result = writer.Write(TextBoxbarcodes.Text)
                Catch ex As Exception
                    MessageBox.Show("خطء", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                End Try
            Case "PLESSEY"
                Try
                    Dim writer As New BarcodeWriter()
                    writer.Format = BarcodeFormat.PLESSEY
                    result = writer.Write(TextBoxbarcodes.Text)
                Catch ex As Exception
                    MessageBox.Show("يجب ان يحتوي على ارقام ويمكنك ايضا كتابا احرف بعد الرقم ولا يدعم جميع الأحرف يجب ان يكون الحرف كبير.", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                End Try
            Case "QR_CODE"
                Try
                    Dim writer As New BarcodeWriter()
                    writer.Format = BarcodeFormat.QR_CODE
                    result = writer.Write(TextBoxbarcodes.Text)
                Catch ex As Exception
                    MessageBox.Show("يجب ان يحتوي على ارقام.", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                End Try
            Case "RSS_14"
                Try
                    Dim writer As New BarcodeWriter()
                    writer.Format = BarcodeFormat.RSS_14
                    result = writer.Write(TextBoxbarcodes.Text)
                Catch ex As Exception
                    MessageBox.Show("يجب ان يحتوي على ارقام.", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                End Try
            Case "RSS_EXPANDED"
                Try
                    Dim writer As New BarcodeWriter()
                    writer.Format = BarcodeFormat.RSS_EXPANDED
                    result = writer.Write(TextBoxbarcodes.Text)
                Catch ex As Exception
                    MessageBox.Show("يجب ان يحتوي على ارقام.", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                End Try
            Case "UPC_E"
                Try
                    Dim writer As New BarcodeWriter()
                    writer.Format = BarcodeFormat.UPC_E
                    result = writer.Write(TextBoxbarcodes.Text)
                Catch ex As Exception
                    MessageBox.Show("يجب ان يحتوي على ارقام.", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                End Try
            Case "UPC_EAN_EXTENSION"
                Try
                    Dim writer As New BarcodeWriter()
                    writer.Format = BarcodeFormat.UPC_EAN_EXTENSION
                    result = writer.Write(TextBoxbarcodes.Text)
                Catch ex As Exception
                    MessageBox.Show("يجب ان يحتوي على ارقام.", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                End Try
            Case Else
                MessageBox.Show("Please select a valid barcode type.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
        End Select

        ' التحقق من أن تم إنشاء الصورة بنجاح قبل محاولة حفظها
        If result IsNot Nothing Then
            ' عرض الصورة على PictureBox
            PictureBoxbarcodes.Image = result
        End If

    End Sub
    Private Sub ButtonSaveBarcode_Click(sender As Object, e As EventArgs) Handles ButtonSaveBarcode.Click
        ' التحقق مما إذا كانت PictureBoxbarcodes تحتوي على صورة
        If PictureBoxbarcodes.Image IsNot Nothing Then
            ' حفظ الصورة باستخدام الدالة SaveImage
            SaveImage(DirectCast(PictureBoxbarcodes.Image, Bitmap))
        Else
            MessageBox.Show("No image to save.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    'Private Sub SaveImage(image As Image)
    '    ' قم بتنفيذ الكود لحفظ الصورة هنا
    '    ' مثال: image.Save("اسم_الملف.png")
    'End Sub

#Region "OnlyNumbers"
    Private Sub HandleBarcodeInput(sender As Object, e As KeyPressEventArgs) Handles TextBoxbarcodes.KeyPress
        ' التحقق من الخيار المحدد في ComboBoxBarcodeType وتنفيذ العملية المناسبة
        Select Case ComboBoxBarcodeType.SelectedItem.ToString()
            Case "EAN_13", "UPC_A"
                ' التحقق مما إذا كان النص في TextBoxbarcodes يحتوي على أكثر من 12 رقمًا
                If TextBoxbarcodes.Text.Length > 12 Then
                    MessageBox.Show("يجب أن يحتوي النص على 12 رقمًا فقط.", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    ' إذا كان النص أطول من 12 رقمًا، قم بإزالة الأحرف الزائدة
                    TextBoxbarcodes.Text = TextBoxbarcodes.Text.Substring(0, 12)
                    ' حرك المؤشر إلى نهاية النص لتجنب الاختراق
                    TextBoxbarcodes.Select(TextBoxbarcodes.Text.Length, 0)
                End If
                ' التحقق مما إذا كان الحرف المدخل هو رقم
                If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
                    ' إذا كان الحرف المدخل ليس رقمًا، فمنعه من الظهور في TextBox
                    e.Handled = True
                End If
                ' التحقق مما إذا كان النص بعد إضافة الحرف سيكون أطول من 12
                Dim textBox As TextBox = DirectCast(sender, TextBox)
                If textBox.TextLength >= 12 AndAlso Not Char.IsControl(e.KeyChar) Then
                    e.Handled = True
                End If
        End Select
    End Sub
#End Region

    ' زر حفظ الصورة
    Private Sub SaveImage(image As Bitmap)
        If image IsNot Nothing Then
            Dim saveDialog As New SaveFileDialog()
            saveDialog.Filter = "PNG Image|*.png|JPEG Image|*.jpg|BMP Image|*.bmp"
            saveDialog.Title = "Save Image"
            If saveDialog.ShowDialog() = DialogResult.OK Then
                Using fileStream As New FileStream(saveDialog.FileName, FileMode.Create)
                    Select Case saveDialog.FilterIndex
                        Case 1
                            image.Save(fileStream, System.Drawing.Imaging.ImageFormat.Png)
                        Case 2
                            image.Save(fileStream, System.Drawing.Imaging.ImageFormat.Jpeg)
                        Case 3
                            image.Save(fileStream, System.Drawing.Imaging.ImageFormat.Bmp)
                    End Select
                End Using
            End If
        Else
            MessageBox.Show("No image to save.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    ' زر طباعة الصورة
    Private Sub ButtonPrint_Click(sender As Object, e As EventArgs) Handles ButtonPrint.Click
        'Dim imageToPrint As Image = PictureBoxQR.Image ' يمكنك تغيير PictureBoxQR.Image إلى الصورة التي تريد طباعتها

        'Dim printDialog As New PrintDialog()
        'Dim printDocument As New PrintDocument()
        'printDialog.Document = printDocument

        'AddHandler printDocument.PrintPage, Sub(senderPrint As Object, ePrint As PrintPageEventArgs)
        '                                        ePrint.Graphics.DrawImage(imageToPrint, 0, 0)
        '                                    End Sub

        'If printDialog.ShowDialog() = DialogResult.OK Then
        '    printDocument.Print()
        'End If

        ' زر طباعة الصورة بتخصيص الحجم والتصميم
        Dim imageToPrint As Image = PictureBoxQR.Image ' الصورة التي سيتم طباعتها

        ' التحقق مما إذا كان المستخدم قام بتحديد تخصيص الحجم والتصميم
        If CheckBoxCustomSize.Checked Then

            ' استخدام الحجم المخصص إذا تم تحديده
            Dim imageWidth As Integer = CInt(NumericUpDownWidth.Value)
            Dim imageHeight As Integer = CInt(NumericUpDownHeight.Value)
            Dim xPosition As Integer = CInt(NumericUpDownXPosition.Value)
            Dim yPosition As Integer = CInt(NumericUpDownYPosition.Value)

            ' إنشاء مربع حوار لتخصيص الطباعة
            Dim printDialogCustom As New PrintDialog()
            Dim printDocumentCustom As New PrintDocument()
            printDialogCustom.Document = printDocumentCustom

            ' إضافة حدث لتخصيص الطباعة
            AddHandler printDocumentCustom.PrintPage, Sub(senderPrint As Object, ePrint As PrintPageEventArgs)
                                                          ' رسم الصورة على الصفحة باستخدام الحجم والتصميم المحددين
                                                          ePrint.Graphics.DrawImage(imageToPrint, xPosition, yPosition, imageWidth, imageHeight)
                                                      End Sub

            ' اختيار الطابعة والإعدادات الأخرى
            If printDialogCustom.ShowDialog() = DialogResult.OK Then
                printDocumentCustom.Print()
            End If
        Else
            ' إذا لم يتم تحديد تخصيص الحجم والتصميم، اطبع بالحجم الافتراضي
            Dim printDialogDefault As New PrintDialog()
            Dim printDocumentDefault As New PrintDocument()
            printDialogDefault.Document = printDocumentDefault

            ' إضافة حدث للطباعة بالحجم الافتراضي
            AddHandler printDocumentDefault.PrintPage, Sub(senderPrint As Object, ePrint As PrintPageEventArgs)
                                                           ePrint.Graphics.DrawImage(imageToPrint, 0, 0)
                                                       End Sub

            ' اختيار الطابعة والإعدادات الأخرى
            If printDialogDefault.ShowDialog() = DialogResult.OK Then
                printDocumentDefault.Print()
            End If
        End If
    End Sub
#Region "Preview"
    ' زر معاينة الطباعة
    Private Sub ButtonButtonPreview_Click(sender As Object, e As EventArgs) Handles ButtonButtonPreview.Click
        ' تحديد الصورة المراد معاينتها
        Dim imageToPreview As Image = PictureBoxQR.Image ' يمكنك تغيير PictureBoxQR.Image إلى الصورة التي تريد معاينتها

        ' إنشاء نافذة معاينة جديدة
        Dim previewForm As New Form()
        previewForm.Text = "Print Preview"
        previewForm.StartPosition = FormStartPosition.CenterScreen
        previewForm.Size = New Size(400, 400) ' يمكنك تغيير الحجم حسب الحاجة

        ' إضافة PictureBox لعرض الصورة
        Dim pictureBoxPreview As New PictureBox()
        pictureBoxPreview.Dock = DockStyle.Fill
        pictureBoxPreview.SizeMode = PictureBoxSizeMode.Zoom
        pictureBoxPreview.Image = imageToPreview

        ' إضافة PictureBox إلى نافذة المعاينة
        previewForm.Controls.Add(pictureBoxPreview)

        ' التحقق مما إذا تم تحديد حجم وموضع مخصص
        If CheckBoxCustomSize.Checked Then
            ' استخدام الحجم المخصص إذا تم تحديده
            Dim imageWidth As Integer = CInt(NumericUpDownWidth.Value)
            Dim imageHeight As Integer = CInt(NumericUpDownHeight.Value)
            Dim xPosition As Integer = CInt(NumericUpDownXPosition.Value)
            Dim yPosition As Integer = CInt(NumericUpDownYPosition.Value)

            ' تحديد حجم النافذة المعاينة وموضعها بناءً على القيم المحددة
            previewForm.Size = New Size(imageWidth + 50, imageHeight + 50)
            previewForm.Location = New Point(xPosition, yPosition)
        End If

        ' عرض نافذة المعاينة
        previewForm.ShowDialog()
    End Sub

#End Region
#Region "Gen Number"
    ' الدالة التي تنشئ سلسلة نصية عشوائية
    Public Function rs(ByVal length As Integer) As String
        Dim s As New System.Text.StringBuilder
        Dim r() As String = {"1", "2", "3", "4", "5", "6", "7", "8", "9", "0"}
        Dim sy As Integer = UBound(r)
        ' تهيئة مولد الأرقام العشوائية
        Randomize()
        For x As Integer = 1 To length
            ' إضافة أرقام عشوائية إلى السلسلة النصية
            s.Append(r((Rnd() * sy)))
        Next
        ' إرجاع السلسلة الناتجة كقيمة نصية
        Return s.ToString
    End Function
    Private Sub ButtonGenNumbers_Click(sender As Object, e As EventArgs) Handles ButtonGenNumbers.Click
        TextBoxGenNumbers.Text = rs(NumericUpDownGenNumbers.Value) ' استخدام القيمة المحددة في NumericUpDown
    End Sub
#End Region
#Region "Word Gen"
    ' الدالة التي تنشئ سلسلة نصية عشوائية
    Public Function rrss(ByVal length As Integer) As String
        Dim ss As New System.Text.StringBuilder
        Dim rr() As String = {"a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m",
                             "n", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z",
                             "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M",
                             "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z"}
        Dim sy As Integer = UBound(rr)
        ' تهيئة مولد الأرقام العشوائية
        Randomize()
        For x As Integer = 1 To length
            ' إضافة حرف عشوائي إلى السلسلة النصية
            ss.Append(rr((Rnd() * sy)))
        Next
        ' إرجاع السلسلة الناتجة كقيمة نصية
        Return ss.ToString
    End Function

    Private Sub ButtonWordGen_Click(sender As Object, e As EventArgs) Handles ButtonWordGen.Click
        ' استدعاء الدالة وتعيين القيمة المعادة للنصيّ
        TextBoxWordGen.Text = rrss(NumericUpDownWordGen.Value) ' استخدام القيمة المحددة في NumericUpDown
    End Sub
#End Region
#Region "Gen Number And Words"
    ' الدالة التي تنشئ سلسلة نصية عشوائية
    Public Function rst(ByVal length As Integer) As String
        Dim s As New System.Text.StringBuilder
        Dim rNumbers() As String = {"1", "2", "3", "4", "5", "6", "7", "8", "9", "0"}
        Dim rLetters() As String = {"a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m",
                                    "n", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z",
                                    "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M",
                                    "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z"}
        Dim rCombined() As String = rNumbers.Concat(rLetters).ToArray()
        Dim sy As Integer = UBound(rCombined)
        ' تهيئة مولد الأرقام العشوائية
        Randomize()
        For x As Integer = 1 To length
            ' إضافة حرف أو رقم عشوائي إلى السلسلة النصية
            s.Append(rCombined((Rnd() * sy)))
        Next
        ' إرجاع السلسلة الناتجة كقيمة نصية
        Return s.ToString
    End Function

    Private Sub ButtonGenNumbAndWord_Click(sender As Object, e As EventArgs) Handles ButtonGenNumbAndWord.Click

        ' استدعاء الدالة وتعيين القيمة المعادة للنصيّ
        TextBoxGenNumbAndWord.Text = rst(NumericUpDownGenNumbAndWord.Value) ' استخدام القيمة المحددة في NumericUpDown
    End Sub
#End Region
#Region "Scann Code"
    Private Sub btnScan_Click(sender As Object, e As EventArgs) Handles btnScan.Click
        Try
            ' إنشاء كائن لفتح نافذة لاختيار الصورة مع امتدادات: jpg، png
            Using openFileDialog As OpenFileDialog = New OpenFileDialog() With {
            .Filter = "JPG|*.jpg|PNG|*.png"
        }
                ' في حالة اختيار الصورة
                If openFileDialog.ShowDialog() = DialogResult.OK Then
                    ' عرض شريط التقدم
                    ProgressBar1.Style = ProgressBarStyle.Marquee
                    ProgressBar1.Visible = True

                    ' تحديث النافذة لعرض شريط التقدم
                    Me.Refresh()

                    ' تمثيل وقت المعالجة (قم بتغيير هذا بكود قراءة الباركود الفعلي)
                    System.Threading.Thread.Sleep(2000)

                    ' وضع الصورة المحددة في صندوق الصورة
                    BarcodeScannerPictureBox.Image = Image.FromFile(openFileDialog.FileName)
                    ' تغيير حجم صندوق الصورة
                    BarcodeScannerPictureBox.SizeMode = PictureBoxSizeMode.AutoSize

                    ' قراءة الباركود من الصورة
                    Dim result = BarcodeReader.QuicklyReadOneBarcode(BarcodeScannerPictureBox.Image, BarcodeEncoding.QRCode Or BarcodeEncoding.Code128 Or BarcodeEncoding.All, True)

                    ' إخفاء شريط التقدم
                    ProgressBar1.Visible = False

                    If result IsNot Nothing Then
                        ' عرض نص الباركود في مربع النص
                        resultTextBox.Text = ($"Barcode Text: {result.ToString()}")
                    Else
                        ' عرض رسالة خطأ في حالة عدم العثور على باركود
                        MessageBox.Show("لا يمكن قراءة الباركود. يُرجى التأكد من أن الصورة تحتوي على باركود صالح.", "خطأ في القراءة", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                End If
            End Using
        Catch ex As Exception
            ' عرض رسالة خطأ لأي استثناءات أخرى
            MessageBox.Show($"حدث خطأ أثناء قراءة الصورة: {ex.Message}", "خطأ غير متوقع", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

#End Region
#Region "إضافة خيار لتحميل الصور من مصادر مختلفة، مثل الكاميرا المباشرة أو الإنترنت."
    'Private capture As VideoCapture
    Private Sub OpenCamera()
        Try
            Dim capture As New VideoCapture() ' إنشاء كائن للوصول إلى الكاميرا
            Dim image As Mat = capture.QueryFrame() ' التقاط صورة من الكاميرا

            ' تحويل الصورة إلى Image
            Dim stride As Integer = image.Width * image.NumberOfChannels ' حساب عرض الصورة بالبايتات
            Dim bmpData As New Imaging.BitmapData()
            bmpData.Scan0 = image.DataPointer
            bmpData.Stride = stride
            bmpData.Width = image.Width
            bmpData.Height = image.Height
            bmpData.PixelFormat = Imaging.PixelFormat.Format24bppRgb
            Dim convertedImage As Image = New Bitmap(image.Width, image.Height, stride, Imaging.PixelFormat.Format24bppRgb, image.DataPointer)

            ' عرض الصورة في PictureBox
            BarcodeScannerPictureBox.Image = convertedImage
        Catch ex As Exception
            MessageBox.Show($"حدث خطأ أثناء فتح الكاميرا: {ex.Message}", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Async Sub DownloadImageFromUrl(url As String)
        Try
            Dim client As New WebClient()
            Dim imageBytes As Byte() = Await client.DownloadDataTaskAsync(url) ' تحميل الصورة من الإنترنت
            Dim stream As New MemoryStream(imageBytes)
            BarcodeScannerPictureBox.Image = Image.FromStream(stream) ' عرض الصورة في PictureBox
        Catch ex As Exception
            MessageBox.Show($"حدث خطأ أثناء تحميل الصورة من الإنترنت تأكد من ان رابط الصوره مباشر: {ex.Message}", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnOpenCamera_Click(sender As Object, e As EventArgs) Handles btnOpenCamera.Click
        OpenCamera() ' استدعاء الوظيفة لفتح الكاميرا
    End Sub
#Disable Warning
    Private Async Sub btnLoadFromUrl_Click(sender As Object, e As EventArgs) Handles btnLoadFromUrl.Click
        If BarcodeScannerPictureBox.Image IsNot Nothing Then
            'System.Threading.Thread.Sleep(7000)
            ReadQrCodesFromLink()
        Else

            Dim url As String = txtImageUrl.Text
            DownloadImageFromUrl(url) ' استدعاء الوظيفة لتحميل الصورة من الإنترنت
            Await Task.Delay(1000)
            ReadQrCodesFromLink()
        End If
    End Sub
#Enable Warning
    Public Async Sub ReadQrCodesFromLink()
        If BarcodeScannerPictureBox.Image IsNot Nothing Then
            Try
                Await Task.Delay(1000)
                Dim result = BarcodeReader.QuicklyReadOneBarcode(BarcodeScannerPictureBox.Image, BarcodeEncoding.QRCode Or BarcodeEncoding.Code128 Or BarcodeEncoding.All, True)
                resultTextBox.Text = ($"Barcode Text: {result.ToString()}")
            Catch ex As Exception

            End Try
        Else
        End If
    End Sub
#End Region
End Class
