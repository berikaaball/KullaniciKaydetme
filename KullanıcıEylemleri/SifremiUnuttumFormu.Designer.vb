<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SifremiUnuttumFormu
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SifremiUnuttumFormu))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TBoxSoru = New System.Windows.Forms.TextBox()
        Me.TBoxCevap = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TBoxSifre = New System.Windows.Forms.TextBox()
        Me.TBoxTekrar = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.BtnKaydet = New System.Windows.Forms.Button()
        Me.BtnVazgec = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label1.Location = New System.Drawing.Point(71, 35)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(136, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Güvenlik Sorusu:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label2.Location = New System.Drawing.Point(71, 87)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(77, 20)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Yanıtınız:"
        '
        'TBoxSoru
        '
        Me.TBoxSoru.Location = New System.Drawing.Point(74, 58)
        Me.TBoxSoru.Name = "TBoxSoru"
        Me.TBoxSoru.Size = New System.Drawing.Size(299, 22)
        Me.TBoxSoru.TabIndex = 2
        '
        'TBoxCevap
        '
        Me.TBoxCevap.Location = New System.Drawing.Point(74, 110)
        Me.TBoxCevap.Name = "TBoxCevap"
        Me.TBoxCevap.Size = New System.Drawing.Size(299, 22)
        Me.TBoxCevap.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label3.Location = New System.Drawing.Point(26, 34)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(108, 20)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Yeni Şifreniz:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label4.Location = New System.Drawing.Point(26, 101)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(161, 20)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Yeni Şifreniz Tekrar:"
        '
        'TBoxSifre
        '
        Me.TBoxSifre.Location = New System.Drawing.Point(30, 57)
        Me.TBoxSifre.Name = "TBoxSifre"
        Me.TBoxSifre.Size = New System.Drawing.Size(299, 22)
        Me.TBoxSifre.TabIndex = 6
        '
        'TBoxTekrar
        '
        Me.TBoxTekrar.Location = New System.Drawing.Point(30, 124)
        Me.TBoxTekrar.Name = "TBoxTekrar"
        Me.TBoxTekrar.Size = New System.Drawing.Size(299, 22)
        Me.TBoxTekrar.TabIndex = 7
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.TBoxTekrar)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.TBoxSifre)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Location = New System.Drawing.Point(44, 147)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(386, 198)
        Me.Panel1.TabIndex = 8
        '
        'BtnKaydet
        '
        Me.BtnKaydet.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.BtnKaydet.Location = New System.Drawing.Point(93, 377)
        Me.BtnKaydet.Name = "BtnKaydet"
        Me.BtnKaydet.Size = New System.Drawing.Size(108, 54)
        Me.BtnKaydet.TabIndex = 9
        Me.BtnKaydet.Text = "Kaydet"
        Me.BtnKaydet.UseVisualStyleBackColor = True
        '
        'BtnVazgec
        '
        Me.BtnVazgec.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.BtnVazgec.Location = New System.Drawing.Point(221, 377)
        Me.BtnVazgec.Name = "BtnVazgec"
        Me.BtnVazgec.Size = New System.Drawing.Size(108, 54)
        Me.BtnVazgec.TabIndex = 10
        Me.BtnVazgec.Text = "Vazgeç"
        Me.BtnVazgec.UseVisualStyleBackColor = True
        '
        'SifremiUnuttumFormu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(496, 465)
        Me.Controls.Add(Me.BtnVazgec)
        Me.Controls.Add(Me.BtnKaydet)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.TBoxCevap)
        Me.Controls.Add(Me.TBoxSoru)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "SifremiUnuttumFormu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "SifremiUnuttumFormu"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TBoxSoru As TextBox
    Friend WithEvents TBoxCevap As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents TBoxSifre As TextBox
    Friend WithEvents TBoxTekrar As TextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents BtnKaydet As Button
    Friend WithEvents BtnVazgec As Button
End Class
