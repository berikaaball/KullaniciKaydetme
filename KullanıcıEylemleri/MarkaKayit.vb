Imports System.Data.SqlClient
Public Class MarkaKayit
    Private MarkaTablosuDA As SqlDataAdapter

    Private Sub MarkaKayit_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim SqlBaglanti As New SqlConnection(SQLBaglantiCumlesi)
        Try
            SqlBaglanti.Open()
            Dim sorgu As String = "Select * From MarkaTablosu"
            MarkaTablosuDA = New SqlDataAdapter(sorgu, SqlBaglanti)
            MarkaTablosuDA.Fill(MarkaTablosuDS, "MarkaTablosu")
            MarkaTablosuBS.DataSource = MarkaTablosuDS.Tables("MarkaTablosu")
            Dim KomutOlusturucu As New SqlCommandBuilder(MarkaTablosuDA)
            MarkaTablosuDA.InsertCommand = KomutOlusturucu.GetInsertCommand
            MarkaTablosuDA.UpdateCommand = KomutOlusturucu.GetUpdateCommand
            MarkaTablosuDA.DeleteCommand = KomutOlusturucu.GetDeleteCommand

            NesneleriBagla()
        Catch ex As Exception
            MessageBox.Show("Bağlantı hatası. Hata: " & ex.Message, "Hata")
        Finally
            SQLBaglanti.Close()
        End Try
    End Sub

    Private Sub NesneleriBagla()
        TBoxMarkaAdi.DataBindings.Add("Text", MarkaTablosuBS, "MarkaAdi")
        MarkaNo.DataPropertyName = "MarkaNo"
        MarkaAdi.DataPropertyName = "MarkaAdi"
        DGVMarkaTablosu.DataSource = MarkaTablosuBS
    End Sub

    Private Sub BtnEkle_Click(sender As Object, e As EventArgs) Handles BtnEkle.Click
        MarkaTablosuBS.AddNew()
        TBoxMarkaAdi.ReadOnly = False
    End Sub

    Private Sub BtnDuzenle_Click(sender As Object, e As EventArgs) Handles BtnDuzenle.Click
        TBoxMarkaAdi.ReadOnly = False
    End Sub

    Private Sub MarkaTablosuBS_PositionChanged(sender As Object, e As EventArgs) Handles MarkaTablosuBS.PositionChanged
        TBoxMarkaAdi.ReadOnly = True
    End Sub

    Private Sub BtnSil_Click(sender As Object, e As EventArgs) Handles BtnSil.Click
        If DGVMarkaTablosu.SelectedRows.Count = 1 Then
            Dim SatirDGV As DataGridViewRow = DGVMarkaTablosu.SelectedRows(0)
            Dim Adi As String = Nothing
            If Not IsDBNull(SatirDGV.Cells("MarkaAdi").Value) Then
                Adi = SatirDGV.Cells("MarkaAdi").Value
            End If
            Dim mesaj As String = String.Format("{0} markasını silmek istediğinize emin misiniz?", Adi)
            If MessageBox.Show(mesaj, "Silme Uyarısı", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = DialogResult.Yes Then
                MarkaTablosuBS.RemoveCurrent()
            End If
        End If
    End Sub

    Private Sub BtnKaydet_Click(sender As Object, e As EventArgs) Handles BtnKaydet.Click
        Me.Validate()
        MarkaTablosuBS.EndEdit()
        Try
            If MarkaTablosuDA.Update(MarkaTablosuDS, "MarkaTablosu") > 0 Then
                MessageBox.Show("Yapılan tüm değişiklikler başarı ile KAYDEDİLDİ.", "Kayıt İşlemi")
                TBoxMarkaAdi.ReadOnly = True
            End If
        Catch ex As Exception
            MessageBox.Show("Kayıt hatası. Hata: " & ex.Message, "Hata")
        End Try
    End Sub
End Class