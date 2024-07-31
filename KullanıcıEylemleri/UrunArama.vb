Imports System.Data.SqlClient
Public Class UrunArama
    Public UrunNo As Integer = 0

    Private Sub BtnTamam_Click(sender As Object, e As EventArgs) Handles BtnTamam.Click
        If Not IsNothing(UrunTablosuBS.Current) Then
            Dim satir As DataRowView = UrunTablosuBS.Current
            UrunNo = satir("UrunNo")
            Me.DialogResult = System.Windows.Forms.DialogResult.OK
            Me.Close()
        End If
    End Sub

    Private Sub BtnVazgec_Click(sender As Object, e As EventArgs) Handles BtnVazgec.Click
        UrunNo = 0
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub UrunArama_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        UrunAdiAra()
        DGVUrunAdi.AutoGenerateColumns = False
        NesneleriBagla()
    End Sub
    Private Sub NesneleriBagla()
        DGVUrunAdi.DataSource = UrunTablosuBS
    End Sub

    Private Sub UrunAdiAra(Optional UrunAdi As String = Nothing)
        Dim SqlBaglanti As New SqlConnection(SQLBaglantiCumlesi)
        Dim sorgu As String = "SELECT UrunNo,UrunAdi,UT.MarkaNo,UT.UrunGrupNo,UT.BirimCinsiNo
  ,BarkodNo,UretimYeri,Aciklama,MarkaAdi,BirimCinsi,UrunGrupAdi
  FROM UrunTablosu AS UT INNER JOIN MarkaTablosu AS MT ON UT.MarkaNo=MT.MarkaNo 
  INNER JOIN BirimCinsiTablosu AS BT ON UT.BirimCinsiNo=BT.BirimCinsiNo
  INNER JOIN UrunGrupTablosu AS UGT ON UGT.UrunGrupNo=UT.UrunGrupNo
  WHERE UrunAdi Like @UrunAdi"
        Dim SqlKomut As New SqlCommand(sorgu, SqlBaglanti)
        SqlKomut.Parameters.Add("@UrunAdi", SqlDbType.NVarChar, 45).Value = "%" & UrunAdi & "%"

        If UrunTablosuDS.Tables.Contains("UrunTablosu") Then
            UrunTablosuDS.Tables("UrunTablosu").Clear()
        Else
            UrunTablosuDS.Tables.Add("UrunTablosu")
        End If

        Try
            SqlBaglanti.Open()
            UrunTablosuDS.Tables("UrunTablosu").Load(SqlKomut.ExecuteReader)
            UrunTablosuBS.DataSource = UrunTablosuDS.Tables("UrunTablosu")
        Catch ex As Exception
            MessageBox.Show("Arama hatası. Hata: " & ex.Message, "Hata")
        Finally
            SqlBaglanti.Close()
        End Try
    End Sub

    Private Sub BtnAra_Click(sender As Object, e As EventArgs) Handles BtnAra.Click
        UrunAdiAra(TBoxUrunAra.Text)
    End Sub
End Class