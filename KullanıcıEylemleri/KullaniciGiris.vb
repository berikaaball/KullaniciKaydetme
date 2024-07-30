Imports System.Data.SqlClient
Imports System.IO
Imports System.Security.Cryptography
Public Class KullaniciGiris
    Private GirisHakki = 3
    Public Ad, Sifre As String
    Public resim As Image

    Private Sub BtnGiris_Click(sender As Object, e As EventArgs) Handles BtnGiris.Click
        GirisHakki -= 1
        Ad = TBoxAdiniz.Text
        Sifre = TBoxSifre.Text
        Sifre = KodUret(SHA512Cng.Create, Sifre)
        Dim SqlBaglanti As New SqlConnection(SQLBaglantiCumlesi)
        Dim sorgu As String = "SELECT * FROM KullaniciKayit WHERE KullaniciAdi=@KullaniciAdi AND Sifre=@Sifre"
        Dim SqlKomut As New SqlCommand(sorgu, SqlBaglanti)
        SqlKomut.Parameters.Add("@KullaniciAdi", SqlDbType.NVarChar, 20).Value = Ad
        SqlKomut.Parameters.Add("@Sifre", SqlDbType.NVarChar, 128).Value = Sifre
        Dim KTablo As New DataTable

        Try
            SqlBaglanti.Open()
            KTablo.Load(SqlKomut.ExecuteReader)
            If GirisHakki >= 0 AndAlso KTablo.Rows.Count = 1 AndAlso (KTablo.Rows(0)("KullaniciAdi") = Ad) Then
                Ad = KTablo.Rows(0)("KullaniciAdi")
                Sifre = KTablo.Rows(0)("Sifre")
                If Not IsNothing(KTablo.Rows(0)("Fotograf")) Then
                    Dim ByteResim() As Byte = KTablo.Rows(0)("Fotograf")
                    Dim ResimMS As MemoryStream = New MemoryStream(ByteResim)
                    resim = Drawing.Image.FromStream(ResimMS)
                End If
                Me.DialogResult = DialogResult.OK
                Me.Close()
            ElseIf GirisHakki > 0 Then
                MessageBox.Show("Kullanıcı adı veya şifre hatalı. Tekrar deneyiniz.", "Hata")
            Else
                MessageBox.Show("Kullanıcı Adı veya Şifre Hatalı. Program Kapatılacak", "Hata")
                Application.Exit()
            End If
        Catch ex As Exception
            MessageBox.Show("Giriş hatası. Hata: " & ex.Message, "Hata")
        Finally
            SqlBaglanti.Close()
        End Try

    End Sub

    Private Sub BtnVazgec_Click(sender As Object, e As EventArgs) Handles BtnVazgec.Click
        Application.Exit()
    End Sub

    Private Sub LLabelUnuttum_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LLabelUnuttum.LinkClicked
        Dim Ad As String = TBoxAdiniz.Text
        Dim SqlBaglanti As New SqlConnection(SQLBaglantiCumlesi)
        Dim sorgu As String = "Select * From KullaniciKayit Where KullaniciAdi=@KullaniciAdi"
        Dim SqlKomut As New SqlCommand(sorgu, SqlBaglanti)
        SqlKomut.Parameters.Add("@KullaniciAdi", SqlDbType.NVarChar, 20).Value = Ad

        Dim KTablo As New DataTable

        Try
            SqlBaglanti.Open()
            KTablo.Load(SqlKomut.ExecuteReader)
            If KTablo.Rows.Count = 1 AndAlso (KTablo.Rows(0)("KullaniciAdi") = Ad) Then
                SifremiUnuttumFormu.KAdi = KTablo.Rows(0)("KullaniciAdi")
                SifremiUnuttumFormu.KKayitNo = KTablo.Rows(0)("KNo")
                SifremiUnuttumFormu.KSoru = KTablo.Rows(0)("GuvenlikSorusu")
                SifremiUnuttumFormu.KCevap = KTablo.Rows(0)("SoruYanit")
                SifremiUnuttumFormu.ShowDialog(Me)
            Else
                MessageBox.Show("Kullanıcı Adı Hatalı.", "Hata")
                Application.Exit()
            End If
        Catch ex As Exception
            MessageBox.Show("Giriş hatası. Hata: " & ex.Message, "Hata")
        Finally
            SqlBaglanti.Close()
        End Try
    End Sub

End Class