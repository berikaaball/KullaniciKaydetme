<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MarkaKayit
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
        Me.components = New System.ComponentModel.Container()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TBoxMarkaAdi = New System.Windows.Forms.TextBox()
        Me.DGVMarkaTablosu = New System.Windows.Forms.DataGridView()
        Me.MarkaAdi = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MarkaNo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BtnKaydet = New System.Windows.Forms.Button()
        Me.BtnSil = New System.Windows.Forms.Button()
        Me.BtnDuzenle = New System.Windows.Forms.Button()
        Me.BtnEkle = New System.Windows.Forms.Button()
        Me.MarkaTablosuBS = New System.Windows.Forms.BindingSource(Me.components)
        Me.MarkaTablosuDS = New System.Data.DataSet()
        CType(Me.DGVMarkaTablosu, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MarkaTablosuBS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MarkaTablosuDS, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label1.Location = New System.Drawing.Point(61, 43)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(89, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Marka Adı:"
        '
        'TBoxMarkaAdi
        '
        Me.TBoxMarkaAdi.Location = New System.Drawing.Point(63, 66)
        Me.TBoxMarkaAdi.Name = "TBoxMarkaAdi"
        Me.TBoxMarkaAdi.ReadOnly = True
        Me.TBoxMarkaAdi.Size = New System.Drawing.Size(366, 22)
        Me.TBoxMarkaAdi.TabIndex = 1
        '
        'DGVMarkaTablosu
        '
        Me.DGVMarkaTablosu.AllowUserToAddRows = False
        Me.DGVMarkaTablosu.AllowUserToDeleteRows = False
        Me.DGVMarkaTablosu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVMarkaTablosu.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.MarkaAdi, Me.MarkaNo})
        Me.DGVMarkaTablosu.Location = New System.Drawing.Point(63, 111)
        Me.DGVMarkaTablosu.MultiSelect = False
        Me.DGVMarkaTablosu.Name = "DGVMarkaTablosu"
        Me.DGVMarkaTablosu.ReadOnly = True
        Me.DGVMarkaTablosu.RowHeadersWidth = 51
        Me.DGVMarkaTablosu.RowTemplate.Height = 24
        Me.DGVMarkaTablosu.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGVMarkaTablosu.Size = New System.Drawing.Size(366, 262)
        Me.DGVMarkaTablosu.TabIndex = 2
        '
        'MarkaAdi
        '
        Me.MarkaAdi.HeaderText = "Marka Adı:"
        Me.MarkaAdi.MinimumWidth = 6
        Me.MarkaAdi.Name = "MarkaAdi"
        Me.MarkaAdi.ReadOnly = True
        Me.MarkaAdi.Width = 256
        '
        'MarkaNo
        '
        Me.MarkaNo.HeaderText = "MarkaNo"
        Me.MarkaNo.MinimumWidth = 6
        Me.MarkaNo.Name = "MarkaNo"
        Me.MarkaNo.ReadOnly = True
        Me.MarkaNo.Visible = False
        Me.MarkaNo.Width = 125
        '
        'BtnKaydet
        '
        Me.BtnKaydet.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.BtnKaydet.Image = Global.KullanıcıEylemleri.My.Resources.Resources.Kaydet
        Me.BtnKaydet.Location = New System.Drawing.Point(342, 395)
        Me.BtnKaydet.Name = "BtnKaydet"
        Me.BtnKaydet.Size = New System.Drawing.Size(87, 79)
        Me.BtnKaydet.TabIndex = 6
        Me.BtnKaydet.Text = "Kaydet"
        Me.BtnKaydet.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.BtnKaydet.UseVisualStyleBackColor = True
        '
        'BtnSil
        '
        Me.BtnSil.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.BtnSil.Image = Global.KullanıcıEylemleri.My.Resources.Resources.Sil
        Me.BtnSil.Location = New System.Drawing.Point(249, 395)
        Me.BtnSil.Name = "BtnSil"
        Me.BtnSil.Size = New System.Drawing.Size(87, 79)
        Me.BtnSil.TabIndex = 5
        Me.BtnSil.Text = "Sil"
        Me.BtnSil.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.BtnSil.UseVisualStyleBackColor = True
        '
        'BtnDuzenle
        '
        Me.BtnDuzenle.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.BtnDuzenle.Image = Global.KullanıcıEylemleri.My.Resources.Resources.Duzenle
        Me.BtnDuzenle.Location = New System.Drawing.Point(156, 395)
        Me.BtnDuzenle.Name = "BtnDuzenle"
        Me.BtnDuzenle.Size = New System.Drawing.Size(87, 79)
        Me.BtnDuzenle.TabIndex = 4
        Me.BtnDuzenle.Text = "Düzenle"
        Me.BtnDuzenle.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.BtnDuzenle.UseVisualStyleBackColor = True
        '
        'BtnEkle
        '
        Me.BtnEkle.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.BtnEkle.Image = Global.KullanıcıEylemleri.My.Resources.Resources.Ekle
        Me.BtnEkle.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BtnEkle.Location = New System.Drawing.Point(63, 395)
        Me.BtnEkle.Name = "BtnEkle"
        Me.BtnEkle.Size = New System.Drawing.Size(87, 79)
        Me.BtnEkle.TabIndex = 3
        Me.BtnEkle.Text = "Ekle"
        Me.BtnEkle.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.BtnEkle.UseVisualStyleBackColor = True
        '
        'MarkaTablosuBS
        '
        '
        'MarkaTablosuDS
        '
        Me.MarkaTablosuDS.DataSetName = "NewDataSet"
        '
        'MarkaKayit
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(535, 523)
        Me.Controls.Add(Me.BtnKaydet)
        Me.Controls.Add(Me.BtnSil)
        Me.Controls.Add(Me.BtnDuzenle)
        Me.Controls.Add(Me.BtnEkle)
        Me.Controls.Add(Me.DGVMarkaTablosu)
        Me.Controls.Add(Me.TBoxMarkaAdi)
        Me.Controls.Add(Me.Label1)
        Me.Name = "MarkaKayit"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "MarkaKayit"
        CType(Me.DGVMarkaTablosu, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MarkaTablosuBS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MarkaTablosuDS, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents TBoxMarkaAdi As TextBox
    Friend WithEvents DGVMarkaTablosu As DataGridView
    Friend WithEvents BtnEkle As Button
    Friend WithEvents BtnDuzenle As Button
    Friend WithEvents BtnSil As Button
    Friend WithEvents BtnKaydet As Button
    Friend WithEvents MarkaAdi As DataGridViewTextBoxColumn
    Friend WithEvents MarkaNo As DataGridViewTextBoxColumn
    Friend WithEvents MarkaTablosuBS As BindingSource
    Friend WithEvents MarkaTablosuDS As DataSet
End Class
