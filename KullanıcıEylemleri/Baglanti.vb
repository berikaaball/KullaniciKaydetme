Imports System.Data.SqlClient
Imports System.Text.RegularExpressions
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

    Public Function EPostaKontrol(EPosta As String) As Boolean
        Dim regex As Regex = New Regex("^([\w-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([\w-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$")
        Dim isValid As Boolean = regex.IsMatch(EPosta.Trim)
        Return isValid
    End Function
End Module
