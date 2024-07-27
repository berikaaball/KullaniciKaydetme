<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class KullaniciGiris
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(KullaniciGiris))
        Me.PBoxResim = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TBoxAdiniz = New System.Windows.Forms.TextBox()
        Me.TBoxSifre = New System.Windows.Forms.TextBox()
        Me.BtnGiris = New System.Windows.Forms.Button()
        Me.BtnVazgec = New System.Windows.Forms.Button()
        Me.LLabelUnuttum = New System.Windows.Forms.LinkLabel()
        CType(Me.PBoxResim, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PBoxResim
        '
        Me.PBoxResim.Image = CType(resources.GetObject("PBoxResim.Image"), System.Drawing.Image)
        Me.PBoxResim.Location = New System.Drawing.Point(27, 41)
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
        Me.Label1.Location = New System.Drawing.Point(219, 37)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(60, 20)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Adınız:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label2.Location = New System.Drawing.Point(219, 99)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(71, 20)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Sifreniz:"
        '
        'TBoxAdiniz
        '
        Me.TBoxAdiniz.Location = New System.Drawing.Point(222, 60)
        Me.TBoxAdiniz.Name = "TBoxAdiniz"
        Me.TBoxAdiniz.Size = New System.Drawing.Size(184, 22)
        Me.TBoxAdiniz.TabIndex = 3
        '
        'TBoxSifre
        '
        Me.TBoxSifre.Location = New System.Drawing.Point(222, 122)
        Me.TBoxSifre.Name = "TBoxSifre"
        Me.TBoxSifre.Size = New System.Drawing.Size(184, 22)
        Me.TBoxSifre.TabIndex = 4
        '
        'BtnGiris
        '
        Me.BtnGiris.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.BtnGiris.Location = New System.Drawing.Point(205, 202)
        Me.BtnGiris.Name = "BtnGiris"
        Me.BtnGiris.Size = New System.Drawing.Size(87, 37)
        Me.BtnGiris.TabIndex = 9
        Me.BtnGiris.Text = "Giriş"
        Me.BtnGiris.UseVisualStyleBackColor = True
        '
        'BtnVazgec
        '
        Me.BtnVazgec.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.BtnVazgec.Location = New System.Drawing.Point(319, 202)
        Me.BtnVazgec.Name = "BtnVazgec"
        Me.BtnVazgec.Size = New System.Drawing.Size(87, 37)
        Me.BtnVazgec.TabIndex = 10
        Me.BtnVazgec.Text = "Vazgeç"
        Me.BtnVazgec.UseVisualStyleBackColor = True
        '
        'LLabelUnuttum
        '
        Me.LLabelUnuttum.AutoSize = True
        Me.LLabelUnuttum.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.LLabelUnuttum.Location = New System.Drawing.Point(292, 160)
        Me.LLabelUnuttum.Name = "LLabelUnuttum"
        Me.LLabelUnuttum.Size = New System.Drawing.Size(114, 18)
        Me.LLabelUnuttum.TabIndex = 11
        Me.LLabelUnuttum.TabStop = True
        Me.LLabelUnuttum.Text = "Şifremi Unuttum"
        '
        'KullaniciGiris
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(477, 290)
        Me.Controls.Add(Me.LLabelUnuttum)
        Me.Controls.Add(Me.BtnVazgec)
        Me.Controls.Add(Me.BtnGiris)
        Me.Controls.Add(Me.TBoxSifre)
        Me.Controls.Add(Me.TBoxAdiniz)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PBoxResim)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "KullaniciGiris"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "KullaniciGiris"
        CType(Me.PBoxResim, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PBoxResim As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TBoxAdiniz As TextBox
    Friend WithEvents TBoxSifre As TextBox
    Friend WithEvents BtnGiris As Button
    Friend WithEvents BtnVazgec As Button
    Friend WithEvents LLabelUnuttum As LinkLabel
End Class
