<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.PBoxResim = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.BtnKaydet = New System.Windows.Forms.Button()
        Me.CBoxGuvenlikSorusu = New System.Windows.Forms.CheckBox()
        Me.BtnResimYukle = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.TBoxSoru = New System.Windows.Forms.TextBox()
        Me.TBoxCevap = New System.Windows.Forms.TextBox()
        Me.TBoxAd = New System.Windows.Forms.TextBox()
        Me.TBoxSoyad = New System.Windows.Forms.TextBox()
        Me.BtnVazgec = New System.Windows.Forms.Button()
        Me.ResimOFD = New System.Windows.Forms.OpenFileDialog()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TBoxEposta = New System.Windows.Forms.TextBox()
        Me.TBoxSifre = New System.Windows.Forms.TextBox()
        Me.TBoxTekrar = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        CType(Me.PBoxResim, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'PBoxResim
        '
        Me.PBoxResim.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PBoxResim.Location = New System.Drawing.Point(38, 48)
        Me.PBoxResim.Name = "PBoxResim"
        Me.PBoxResim.Size = New System.Drawing.Size(154, 137)
        Me.PBoxResim.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PBoxResim.TabIndex = 0
        Me.PBoxResim.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label1.Location = New System.Drawing.Point(236, 38)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(60, 20)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Adınız:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label2.Location = New System.Drawing.Point(236, 115)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(86, 20)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Soyadınız:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label3.Location = New System.Drawing.Point(16, 23)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(136, 20)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Güvenlik Sorusu:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label4.Location = New System.Drawing.Point(16, 134)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(77, 20)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Yanıtınız:"
        '
        'BtnKaydet
        '
        Me.BtnKaydet.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.BtnKaydet.Location = New System.Drawing.Point(241, 269)
        Me.BtnKaydet.Name = "BtnKaydet"
        Me.BtnKaydet.Size = New System.Drawing.Size(105, 45)
        Me.BtnKaydet.TabIndex = 5
        Me.BtnKaydet.Text = "Kaydet"
        Me.BtnKaydet.UseVisualStyleBackColor = True
        '
        'CBoxGuvenlikSorusu
        '
        Me.CBoxGuvenlikSorusu.AutoSize = True
        Me.CBoxGuvenlikSorusu.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.CBoxGuvenlikSorusu.Location = New System.Drawing.Point(240, 205)
        Me.CBoxGuvenlikSorusu.Name = "CBoxGuvenlikSorusu"
        Me.CBoxGuvenlikSorusu.Size = New System.Drawing.Size(190, 24)
        Me.CBoxGuvenlikSorusu.TabIndex = 6
        Me.CBoxGuvenlikSorusu.Text = "Güvenlik Sorusu Ekle"
        Me.CBoxGuvenlikSorusu.UseVisualStyleBackColor = True
        '
        'BtnResimYukle
        '
        Me.BtnResimYukle.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.BtnResimYukle.Location = New System.Drawing.Point(38, 207)
        Me.BtnResimYukle.Name = "BtnResimYukle"
        Me.BtnResimYukle.Size = New System.Drawing.Size(125, 39)
        Me.BtnResimYukle.TabIndex = 7
        Me.BtnResimYukle.Text = "Resim Yükle"
        Me.BtnResimYukle.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.TBoxSoru)
        Me.Panel1.Controls.Add(Me.TBoxCevap)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Location = New System.Drawing.Point(724, 38)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(272, 233)
        Me.Panel1.TabIndex = 8
        '
        'TBoxSoru
        '
        Me.TBoxSoru.Location = New System.Drawing.Point(20, 46)
        Me.TBoxSoru.Name = "TBoxSoru"
        Me.TBoxSoru.Size = New System.Drawing.Size(174, 22)
        Me.TBoxSoru.TabIndex = 11
        '
        'TBoxCevap
        '
        Me.TBoxCevap.Location = New System.Drawing.Point(20, 168)
        Me.TBoxCevap.Name = "TBoxCevap"
        Me.TBoxCevap.Size = New System.Drawing.Size(174, 22)
        Me.TBoxCevap.TabIndex = 12
        '
        'TBoxAd
        '
        Me.TBoxAd.BackColor = System.Drawing.SystemColors.HighlightText
        Me.TBoxAd.Location = New System.Drawing.Point(240, 71)
        Me.TBoxAd.Name = "TBoxAd"
        Me.TBoxAd.Size = New System.Drawing.Size(174, 22)
        Me.TBoxAd.TabIndex = 9
        '
        'TBoxSoyad
        '
        Me.TBoxSoyad.Location = New System.Drawing.Point(240, 153)
        Me.TBoxSoyad.Name = "TBoxSoyad"
        Me.TBoxSoyad.Size = New System.Drawing.Size(174, 22)
        Me.TBoxSoyad.TabIndex = 10
        '
        'BtnVazgec
        '
        Me.BtnVazgec.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.BtnVazgec.Location = New System.Drawing.Point(376, 269)
        Me.BtnVazgec.Name = "BtnVazgec"
        Me.BtnVazgec.Size = New System.Drawing.Size(105, 45)
        Me.BtnVazgec.TabIndex = 11
        Me.BtnVazgec.Text = "Vazgeç"
        Me.BtnVazgec.UseVisualStyleBackColor = True
        '
        'ResimOFD
        '
        Me.ResimOFD.FileName = "OpenFileDialog1"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label5.Location = New System.Drawing.Point(491, 38)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(72, 20)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "E-posta:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label6.Location = New System.Drawing.Point(491, 115)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(49, 20)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "Şifre:"
        '
        'TBoxEposta
        '
        Me.TBoxEposta.Location = New System.Drawing.Point(495, 71)
        Me.TBoxEposta.Name = "TBoxEposta"
        Me.TBoxEposta.Size = New System.Drawing.Size(177, 22)
        Me.TBoxEposta.TabIndex = 14
        '
        'TBoxSifre
        '
        Me.TBoxSifre.Location = New System.Drawing.Point(495, 153)
        Me.TBoxSifre.Name = "TBoxSifre"
        Me.TBoxSifre.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TBoxSifre.Size = New System.Drawing.Size(177, 22)
        Me.TBoxSifre.TabIndex = 15
        '
        'TBoxTekrar
        '
        Me.TBoxTekrar.Location = New System.Drawing.Point(495, 238)
        Me.TBoxTekrar.Name = "TBoxTekrar"
        Me.TBoxTekrar.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TBoxTekrar.Size = New System.Drawing.Size(177, 22)
        Me.TBoxTekrar.TabIndex = 17
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label7.Location = New System.Drawing.Point(491, 200)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(96, 20)
        Me.Label7.TabIndex = 16
        Me.Label7.Text = "Şifre Tekar:"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1020, 369)
        Me.Controls.Add(Me.TBoxTekrar)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.TBoxSifre)
        Me.Controls.Add(Me.TBoxEposta)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.BtnVazgec)
        Me.Controls.Add(Me.TBoxSoyad)
        Me.Controls.Add(Me.TBoxAd)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.BtnResimYukle)
        Me.Controls.Add(Me.CBoxGuvenlikSorusu)
        Me.Controls.Add(Me.BtnKaydet)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PBoxResim)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Kullanıcı Kayıt"
        CType(Me.PBoxResim, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PBoxResim As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents BtnKaydet As Button
    Friend WithEvents CBoxGuvenlikSorusu As CheckBox
    Friend WithEvents BtnResimYukle As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents TBoxSoru As TextBox
    Friend WithEvents TBoxCevap As TextBox
    Friend WithEvents TBoxAd As TextBox
    Friend WithEvents TBoxSoyad As TextBox
    Friend WithEvents BtnVazgec As Button
    Friend WithEvents ResimOFD As OpenFileDialog
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents TBoxEposta As TextBox
    Friend WithEvents TBoxSifre As TextBox
    Friend WithEvents TBoxTekrar As TextBox
    Friend WithEvents Label7 As Label
End Class
