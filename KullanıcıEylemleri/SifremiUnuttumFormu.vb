Imports System.Data.SqlClient
Imports System.Security.Cryptography
Public Class SifremiUnuttumFormu
    Public KKayitNo As Guid
    Public KAdi, KSoru, KCevap As String

    Private Sub TBoxCevap_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles TBoxCevap.Validating
        If TBoxCevap.Text = KCevap Then
            Panel1.Visible = True
            Me.Size = New Size(514, 512)
        End If
    End Sub

    Private Sub BtnVazgec_Click(sender As Object, e As EventArgs) Handles BtnVazgec.Click
        Me.DialogResult = DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub BtnKaydet_Click(sender As Object, e As EventArgs) Handles BtnKaydet.Click
        Dim Sifre As String = KodUret(SHA512.Create, TBoxSifre.Text)
        Dim Tekrar As String = KodUret(SHA512.Create, TBoxTekrar.Text)
        If KCevap <> KodUret(SHA512.Create, TBoxCevap.Text) Then
            MessageBox.Show("Yanıtınız doğru değil. Yeni şifre belirleyemezsiniz.", "Hata")
            Exit Sub
        End If
        If TBoxSifre.Text.Length < 4 Then
            MessageBox.Show("Yeni şifreniz 4 karakterden uzun olmalı.", "Uyarı")
            Exit Sub
        End If
        If Sifre <> Tekrar Then
            MessageBox.Show("Şifreniz tekrarı ile eşleşmiyor.", "Hata")
            Exit Sub
        End If

        Dim SqlBaglanti As New SqlConnection
        Dim sorgu As String = "SELECT * FROM KullaniciKayit WHERE KNo=@KNo ANDALSO Sifre=@Sifre"
        Dim SqlKomut As New SqlCommand(sorgu, SqlBaglanti)
        SqlKomut.Parameters.Add("@KNo", SqlDbType.UniqueIdentifier).Value = KKayitNo
        SqlKomut.Parameters.Add("@Sifre", SqlDbType.NVarChar, 128).Value = Sifre

        Try
            SqlBaglanti.Open()
            If SqlKomut.ExecuteNonQuery = 1 Then
                MessageBox.Show("Şifreniz başarıyla değiştirildi.", "Bildirim")
                Me.Close()
            End If
        Catch ex As Exception
            MessageBox.Show("Güncelleme hatası. Hata: " & ex.Message, "Hata")
        Finally
            SqlBaglanti.Close()
        End Try
    End Sub



    Private Sub SifremiUnuttumFormu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Size = New Size(514, 279)
        TBoxSoru.Text = KSoru
    End Sub
End Class