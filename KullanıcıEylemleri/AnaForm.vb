Public Class AnaForm
    Private Kapat As Boolean = False
    Public KAdi, KSifre As String
    Public Resim As Image

    Private Sub AnaForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Kapat Then
            Application.Exit()
        End If
        PBoxResim.Image = Resim
        If My.Application.Info.Title <> "" Then
            Me.Text = My.Application.Info.Title
        Else
            'If the application title is missing, use the application name, without the extension
            Me.Text = System.IO.Path.GetFileNameWithoutExtension(My.Application.Info.AssemblyName)
        End If
    End Sub

    Private Sub ProgramıKapatToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProgramıKapatToolStripMenuItem.Click
        Application.Exit()
    End Sub

    Private Sub YeniKullanıcıKaydıToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles YeniKullanıcıKaydıToolStripMenuItem.Click
        KullaniciKayit.ShowDialog(Me)
        KullaniciKayit.Dispose()
    End Sub

    Private Sub MarkaKaydıToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MarkaKaydıToolStripMenuItem.Click
        MarkaKayit.ShowDialog(Me)
        'MarkaKayit.Dispose()
    End Sub

    Private Sub ÜrünKaydıToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ÜrünKaydıToolStripMenuItem.Click
        UrunKayit.MdiParent = Me
        UrunKayit.Show()
        UrunKayit.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub ÜrünAramaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ÜrünAramaToolStripMenuItem.Click
        UrunArama.ShowDialog(Me)
    End Sub

    Public Sub New()
        Dim KGFormu As New KullaniciGiris
        If KGFormu.ShowDialog(Me) <> DialogResult.OK Then
            KAdi = KGFormu.Ad
            KSifre = KGFormu.Sifre
            Resim = KGFormu.resim
            Kapat = True
        End If
        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

End Class