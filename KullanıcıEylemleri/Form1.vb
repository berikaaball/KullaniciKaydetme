Imports System.ComponentModel
Imports System.Data.SqlClient
Imports System.Data.SqlTypes
Imports System.IO
Imports System.Security.Cryptography
Imports System.Security.Policy
Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Panel1.Visible = False
    End Sub

    Private Sub BtnKaydet_Click(sender As Object, e As EventArgs) Handles BtnKaydet.Click
        Dim Ad, Soyad, EPosta, Sifre, SifreTekrar As String
        Dim GSorusu As String = Nothing
        Dim Cevap As String = Nothing

        Ad = TBoxAd.Text.Trim
        Soyad = TBoxSoyad.Text.Trim
        If Ad.Length < 1 AndAlso Soyad.Length < 1 Then
            MessageBox.Show("Kullanıcı adı ve soyadı boş olamaz.", "Uyarı")
            Exit Sub
        End If

        Sifre = TBoxSifre.Text
        SifreTekrar = TBoxTekrar.Text
        Sifre = KodUret(SHA512.Create, Sifre)
        SifreTekrar = KodUret(SHA512.Create, SifreTekrar)
        If Sifre.Length < 1 AndAlso SifreTekrar.Length < 1 Then
            MessageBox.Show("Şifre ve tekrarı boş geçilemez.", "Hata")
            Exit Sub
        End If

        EPosta = TBoxEposta.Text.Trim

        If Sifre <> SifreTekrar Then
            MessageBox.Show("Şifre ve tekrarı eşleşmiyor.", "Hata")
            Exit Sub
        End If

        If Not EPostaKontrol(EPosta) Then
            MessageBox.Show("Geçerli bir e-posta adresi girdiğinizden emin olunuz.", "Hata")
            Exit Sub
        End If

        If CBoxGuvenlikSorusu.Checked Then
            GSorusu = TBoxSoru.Text
            Cevap = TBoxCevap.Text
            If GSorusu.Length < 1 AndAlso Cevap.Length < 1 Then
                MessageBox.Show("Geçerli bir soru ve yanıt girdiğinizden emin olunuz.", "Uyarı")
                Exit Sub
            End If
        Else
            GSorusu = " "
            Cevap = " "
        End If

        Dim SqlBaglanti As New SqlConnection(SQLBaglantiCumlesi)
        Dim sorgu As String = "INSERT INTO KullaniciKayit (KullaniciAdi,KullaniciSoyadi,GuvenlikSorusu,SoruYanit,Fotograf,EPosta,Sifre)
           VALUES (@Ad,@Soyad,@GSorusu,@Cevap,@Fotograf,@EPosta,@Sifre)"
        Dim SqlKomut As New SqlCommand(sorgu, SqlBaglanti)
        'SqlKomut.Parameters.AddWithValue("@Ad", Ad)
        'SqlKomut.Parameters.AddWithValue("@Soyad", Soyad)
        'SqlKomut.Parameters.AddWithValue("@GSorusu", GSorusu)
        'SqlKomut.Parameters.AddWithValue("@Cevap", Cevap)
        SqlKomut.Parameters.Add("@Ad", SqlDbType.NVarChar, 20).Value = Ad
        SqlKomut.Parameters.Add("@Soyad", SqlDbType.NVarChar, 20).Value = Soyad
        SqlKomut.Parameters.Add("@GSorusu", SqlDbType.NVarChar, 35).Value = GSorusu
        SqlKomut.Parameters.Add("@Cevap", SqlDbType.NVarChar, 30).Value = Cevap
        SqlKomut.Parameters.Add("@EPosta", SqlDbType.NVarChar, 40).Value = EPosta
        SqlKomut.Parameters.Add("@Sifre", SqlDbType.NVarChar, 128).Value = Sifre
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

        TBoxAd.Clear()
        TBoxSoyad.Clear()
        TBoxEposta.Clear()
        TBoxSifre.Clear()
        TBoxTekrar.Clear()
        PBoxResim.Image = Nothing
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
        'Dim GSorusu As String
        'Dim Cevap As String


    End Sub

    Private Sub TBoxSifre_Validating(sender As Object, e As CancelEventArgs) Handles TBoxSifre.Validating
        Dim Sifre As String = Nothing

        If Not IsAlphabetic(Sifre) Then
            MessageBox.Show("Şifreniz sadece harflerden oluşmalıdır. Boşluk, özel karakter veya sayı içermemelidir.", "Uyarı")
            Exit Sub
        End If
    End Sub
End Class
