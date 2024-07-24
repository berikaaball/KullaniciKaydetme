Imports System.Data.SqlClient
Module Baglanti
    Public Function SQLBaglantiCumlesi() As String
        Dim cumleolusturucu As New SqlConnectionStringBuilder
        cumleolusturucu.DataSource = "localhost\SQLEXPRESS"
        cumleolusturucu.InitialCatalog = "KullaniciEylemleri"
        cumleolusturucu.IntegratedSecurity = True
        'Return cumleolusturucu.ConnectionString
        'Dim connectionString As String = "Server=DESKTOP-RORVUON\\SQLEXPRESS;Database=KullaniciEylemleri;Integrated Security=True;"
        'Dim connectionstring As String = "Server=localhost\SQLEXPRESS;Database=KullaniciEylemleri;Trusted_Connection=True;"
        Return cumleolusturucu.ConnectionString
    End Function

End Module
