Imports System.ComponentModel
Imports System.Data.SqlClient
Imports System.Data.SqlTypes
Imports System.IO
Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Panel1.Visible = False
    End Sub

    Private Sub BtnKaydet_Click(sender As Object, e As EventArgs) Handles BtnKaydet.Click
        Dim Ad, Soyad As String
        Dim GSorusu As String = Nothing
        Dim Cevap As String = Nothing

        Ad = TBoxAd.Text.Trim
        Soyad = TBoxSoyad.Text.Trim
        If Ad.Length < 1 AndAlso Soyad.Length < 1 Then
            MessageBox.Show("Kullanıcı adı veya şifre boş olamaz.", "Uyarı")
            Exit Sub
        End If

        If CBoxGuvenlikSorusu.Checked Then
            GSorusu = TBoxSoru.Text.Trim
            Cevap = TBoxCevap.Text.Trim
            If GSorusu.Length < 1 AndAlso Cevap.Length < 1 Then
                MessageBox.Show("Geçerli bir soru ve yanıt girdiğinizden emin olunuz.", "Uyarı")
                Exit Sub
            End If
        Else
            GSorusu = Nothing
            Cevap = Nothing
        End If

        Dim SqlBaglanti As New SqlConnection(SQLBaglantiCumlesi)
        Dim sorgu As String = "INSERT INTO KullaniciKayit (KullaniciAdi,KullaniciSoyadi,GuvenlikSorusu,SoruYanit,Fotograf)
           VALUES (@Ad,@Soyad,@GSorusu,@Cevap,@Fotograf)"
        Dim SqlKomut As New SqlCommand(sorgu, SqlBaglanti)
        'SqlKomut.Parameters.AddWithValue("@Ad", Ad)
        'SqlKomut.Parameters.AddWithValue("@Soyad", Soyad)
        'SqlKomut.Parameters.AddWithValue("@GSorusu", GSorusu)
        'SqlKomut.Parameters.AddWithValue("@Cevap", Cevap)
        SqlKomut.Parameters.Add("@Ad", SqlDbType.NVarChar, 20).Value = Ad
        SqlKomut.Parameters.Add("@Soyad", SqlDbType.NVarChar, 20).Value = Soyad
        SqlKomut.Parameters.Add("@GSorusu", SqlDbType.NVarChar, 35).Value = GSorusu
        SqlKomut.Parameters.Add("@Cevap", SqlDbType.NVarChar, 30).Value = Cevap
        'SqlKomut.Parameters.Add("@Fotograf", SqlDbType.VarBinary)

        Dim ResimMS As New MemoryStream
        If Not IsNothing(PBoxResim.Image) Then
            PBoxResim.Image.Save(ResimMS, PBoxResim.Image.RawFormat)
            Dim resimBytes As Byte() = ResimMS.ToArray()
            SqlKomut.Parameters.AddWithValue("@Fotograf", resimBytes)
        Else
            SqlKomut.Parameters.AddWithValue("@Fotograf", DBNull.Value)
        End If

        Try
            SqlBaglanti.Open()
            If SqlKomut.ExecuteNonQuery > 0 Then
                MessageBox.Show("Kaydınız başarıyla gerçekleştirildi.", "Bildirim")
            End If
        Catch ex As Exception
            MessageBox.Show("Kullanıcı kaydedilemedi: " & ex.Message, "Hata")
        Finally
            SqlBaglanti.Close()
        End Try
    End Sub



    Private Sub BtnVazgec_Click(sender As Object, e As EventArgs) Handles BtnVazgec.Click
        Me.Close()
    End Sub

    Private Sub TBoxAd_Validating(sender As Object, e As CancelEventArgs) Handles TBoxAd.Validating
        Dim Ad As String = TBoxAd.Text

        Dim SqlBaglanti As New SqlConnection(SQLBaglantiCumlesi)
        Dim sorgu As String = "SELECT KullaniciAdi FROM KullaniciKayit WHERE KullaniciAdi=@KullaniciAdi"
        Dim SqlKomut As New SqlCommand(sorgu, SqlBaglanti)
        SqlKomut.Parameters.AddWithValue("@KullaniciAdi", Ad)
        Dim KTablo As New DataTable

        Try
            SqlBaglanti.Open()
            KTablo.Load(SqlKomut.ExecuteReader)
            If KTablo.Rows.Count > 0 Then
                MessageBox.Show("Bu isimde bir kullanıcı mevcut. Lütfen başka bir isim seçiniz.", "Uyarı")
                e.Cancel = True
            End If
            'Catch ex As Exception
            '    MessageBox.Show("Hata: " & ex.Message, "Hata")
            '    e.Cancel = True
            'Catch ex As SqlException
            '    ' SQL ile ilgili hataları yakala ve detaylı hata mesajı göster
            '    MessageBox.Show("SQL hatası: " & ex.Message & vbCrLf & "StackTrace: " & ex.StackTrace, "Hata")
            '    e.Cancel = True
            'Catch ex As InvalidOperationException
            '    ' Geçersiz işlemlerle ilgili hataları yakala ve detaylı hata mesajı göster
            '    MessageBox.Show("Geçersiz işlem hatası: " & ex.Message & vbCrLf & "StackTrace: " & ex.StackTrace, "Hata")
            '    e.Cancel = True
            'Catch ex As Exception
            '    ' Diğer genel hataları yakala ve detaylı hata mesajı göster
            '    MessageBox.Show("Genel hata: " & ex.Message & vbCrLf & "StackTrace: " & ex.StackTrace, "Hata")
            '    e.Cancel = True
        Finally
            SqlBaglanti.Close()
        End Try
    End Sub

    Private Sub BtnResimYukle_Click(sender As Object, e As EventArgs) Handles BtnResimYukle.Click
        ResimOFD.FileName = Nothing
        ResimOFD.Filter = "JPG Resimleri|*.jpg;*.jpeg|PNG Resimleri|*.png|BMP Resimleri|*.bmp"
        ResimOFD.FilterIndex = 1
        If ResimOFD.ShowDialog = DialogResult.OK Then
            PBoxResim.Image = Image.FromFile(ResimOFD.FileName)
        End If
    End Sub

    Private Sub CBoxGuvenlikSorusu_CheckedChanged(sender As Object, e As EventArgs) Handles CBoxGuvenlikSorusu.CheckedChanged
        Panel1.Visible = CBoxGuvenlikSorusu.Checked

    End Sub
End Class
