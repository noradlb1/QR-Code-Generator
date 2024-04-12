Imports System.IO
Imports ZXing
Imports ZXing.QrCode

'Imports System.Networking.Connectivity

Public Class Form1
#Region "Normal QR"
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim qrGenerator As New BarcodeWriter
        qrGenerator.Format = BarcodeFormat.QR_CODE
        qrGenerator.Options = New ZXing.Common.EncodingOptions With {
            .Width = 316,
            .Height = 220
        }
        Dim result As Bitmap = qrGenerator.Write(TextBox1.Text)
        PictureBox1.Image = result
    End Sub
#End Region
#Region "Wifi QR"
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ' احصل على قيم TextBoxes
        Dim ssid As String = TextBoxssid.Text
        Dim password As String = TextBoxpassword.Text
        Dim encryptionType As String = ComboBox1.Text ' يمكن أن يكون WPA أو WEP أو بدون تشفير

        ' بناء بيانات الاتصال بالواي فاي
        Dim wifiData As String = $"WIFI:S:{ssid};T:{encryptionType};P:{password};;"

        ' إنشاء رمز الاستجابة السريعة (QR)
        Dim qrWriter As New BarcodeWriter()
        qrWriter.Format = BarcodeFormat.QR_CODE
        qrWriter.Options = New QrCodeEncodingOptions With {
            .Width = 316,
            .Height = 220
        }

        ' إنشاء صورة رمز الاستجابة السريعة (QR)
        Dim qrCodeBitmap As Bitmap = qrWriter.Write(wifiData)

        ' عرض صورة رمز الاستجابة السريعة (QR) في PictureBox
        PictureBox2.Image = qrCodeBitmap
    End Sub

#End Region
#Region "Barcode"
    Private Sub ButtonBarcodeGen_Click(sender As Object, e As EventArgs) Handles ButtonBarcodeGen.Click
        ' Generate barcode
        Dim writer As New BarcodeWriter()
        writer.Format = BarcodeFormat.CODE_128
        'writer.Options = New QrCodeEncodingOptions With {
        '    .Width = 220,
        '    .Height = 220
        '}
        Dim result As Bitmap = writer.Write(TextBoxbarcodes.Text)

        ' Display barcode
        PictureBoxbarcodes.Image = result
    End Sub

    Private Sub ButtonSaveBarcode_Click(sender As Object, e As EventArgs) Handles ButtonSaveBarcode.Click

        ' Check if there's an image to save
        If PictureBoxbarcodes.Image IsNot Nothing Then
            ' Save dialog setup
            Dim saveDialog As New SaveFileDialog()
            saveDialog.Filter = "PNG Image|*.png|JPEG Image|*.jpg|BMP Image|*.bmp"
            saveDialog.Title = "Save Barcode Image"
            saveDialog.ShowDialog()

            ' Save image
            If saveDialog.FileName <> "" Then
                Dim fileStream As New FileStream(saveDialog.FileName, FileMode.Create)
                Select Case saveDialog.FilterIndex
                    Case 1
                        PictureBoxbarcodes.Image.Save(fileStream, System.Drawing.Imaging.ImageFormat.Png)
                    Case 2
                        PictureBoxbarcodes.Image.Save(fileStream, System.Drawing.Imaging.ImageFormat.Jpeg)
                    Case 3
                        PictureBoxbarcodes.Image.Save(fileStream, System.Drawing.Imaging.ImageFormat.Bmp)
                End Select
                fileStream.Close()
            End If
        Else
            MessageBox.Show("No barcode image to save.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub
#End Region
End Class
