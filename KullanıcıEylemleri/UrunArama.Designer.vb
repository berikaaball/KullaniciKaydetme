<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UrunArama
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
        Me.TBoxUrunAra = New System.Windows.Forms.TextBox()
        Me.BtnAra = New System.Windows.Forms.Button()
        Me.DGVUrunAdi = New System.Windows.Forms.DataGridView()
        Me.BtnTamam = New System.Windows.Forms.Button()
        Me.BtnVazgec = New System.Windows.Forms.Button()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.UrunTablosuBS = New System.Windows.Forms.BindingSource(Me.components)
        Me.UrunTablosuDS = New System.Data.DataSet()
        Me.UrunNoC = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MarkaNoC = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BirimCinsiNoC = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UrunGrupNoC = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UrunAdiC = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MarkaAdiC = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UrunGrubuC = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BirimCinsiC = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BarkodNoC = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UretimYeriC = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AciklamaC = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DGVUrunAdi, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.UrunTablosuBS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UrunTablosuDS, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label1.Location = New System.Drawing.Point(248, 40)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(104, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Ürün Arama:"
        '
        'TBoxUrunAra
        '
        Me.TBoxUrunAra.Location = New System.Drawing.Point(376, 40)
        Me.TBoxUrunAra.Name = "TBoxUrunAra"
        Me.TBoxUrunAra.Size = New System.Drawing.Size(326, 22)
        Me.TBoxUrunAra.TabIndex = 1
        '
        'BtnAra
        '
        Me.BtnAra.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.BtnAra.Location = New System.Drawing.Point(753, 40)
        Me.BtnAra.Name = "BtnAra"
        Me.BtnAra.Size = New System.Drawing.Size(102, 55)
        Me.BtnAra.TabIndex = 2
        Me.BtnAra.Text = "Ara"
        Me.BtnAra.UseVisualStyleBackColor = True
        '
        'DGVUrunAdi
        '
        Me.DGVUrunAdi.AllowUserToAddRows = False
        Me.DGVUrunAdi.AllowUserToDeleteRows = False
        Me.DGVUrunAdi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVUrunAdi.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.UrunNoC, Me.MarkaNoC, Me.BirimCinsiNoC, Me.UrunGrupNoC, Me.UrunAdiC, Me.MarkaAdiC, Me.UrunGrubuC, Me.BirimCinsiC, Me.BarkodNoC, Me.UretimYeriC, Me.AciklamaC})
        Me.DGVUrunAdi.Location = New System.Drawing.Point(12, 101)
        Me.DGVUrunAdi.Name = "DGVUrunAdi"
        Me.DGVUrunAdi.ReadOnly = True
        Me.DGVUrunAdi.RowHeadersWidth = 51
        Me.DGVUrunAdi.RowTemplate.Height = 24
        Me.DGVUrunAdi.Size = New System.Drawing.Size(1202, 306)
        Me.DGVUrunAdi.TabIndex = 3
        '
        'BtnTamam
        '
        Me.BtnTamam.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.BtnTamam.Location = New System.Drawing.Point(3, 3)
        Me.BtnTamam.Name = "BtnTamam"
        Me.BtnTamam.Size = New System.Drawing.Size(133, 56)
        Me.BtnTamam.TabIndex = 4
        Me.BtnTamam.Text = "Tamam"
        Me.BtnTamam.UseVisualStyleBackColor = True
        '
        'BtnVazgec
        '
        Me.BtnVazgec.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.BtnVazgec.Location = New System.Drawing.Point(142, 3)
        Me.BtnVazgec.Name = "BtnVazgec"
        Me.BtnVazgec.Size = New System.Drawing.Size(133, 56)
        Me.BtnVazgec.TabIndex = 5
        Me.BtnVazgec.Text = "Vazgeç"
        Me.BtnVazgec.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.BtnTamam, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.BtnVazgec, 1, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(376, 413)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(278, 63)
        Me.TableLayoutPanel1.TabIndex = 6
        '
        'UrunTablosuDS
        '
        Me.UrunTablosuDS.DataSetName = "NewDataSet"
        '
        'UrunNoC
        '
        Me.UrunNoC.HeaderText = "Ürün No"
        Me.UrunNoC.MinimumWidth = 6
        Me.UrunNoC.Name = "UrunNoC"
        Me.UrunNoC.ReadOnly = True
        Me.UrunNoC.Visible = False
        Me.UrunNoC.Width = 125
        '
        'MarkaNoC
        '
        Me.MarkaNoC.HeaderText = "Marka No"
        Me.MarkaNoC.MinimumWidth = 6
        Me.MarkaNoC.Name = "MarkaNoC"
        Me.MarkaNoC.ReadOnly = True
        Me.MarkaNoC.Visible = False
        Me.MarkaNoC.Width = 125
        '
        'BirimCinsiNoC
        '
        Me.BirimCinsiNoC.HeaderText = "Birim Cinsi No"
        Me.BirimCinsiNoC.MinimumWidth = 6
        Me.BirimCinsiNoC.Name = "BirimCinsiNoC"
        Me.BirimCinsiNoC.ReadOnly = True
        Me.BirimCinsiNoC.Visible = False
        Me.BirimCinsiNoC.Width = 125
        '
        'UrunGrupNoC
        '
        Me.UrunGrupNoC.HeaderText = "Ürün Grup No"
        Me.UrunGrupNoC.MinimumWidth = 6
        Me.UrunGrupNoC.Name = "UrunGrupNoC"
        Me.UrunGrupNoC.ReadOnly = True
        Me.UrunGrupNoC.Visible = False
        Me.UrunGrupNoC.Width = 125
        '
        'UrunAdiC
        '
        Me.UrunAdiC.HeaderText = "Ürün Adı"
        Me.UrunAdiC.MinimumWidth = 6
        Me.UrunAdiC.Name = "UrunAdiC"
        Me.UrunAdiC.ReadOnly = True
        Me.UrunAdiC.Width = 125
        '
        'MarkaAdiC
        '
        Me.MarkaAdiC.HeaderText = "Marka Adı"
        Me.MarkaAdiC.MinimumWidth = 6
        Me.MarkaAdiC.Name = "MarkaAdiC"
        Me.MarkaAdiC.ReadOnly = True
        Me.MarkaAdiC.Width = 125
        '
        'UrunGrubuC
        '
        Me.UrunGrubuC.HeaderText = "Ürün Grubu"
        Me.UrunGrubuC.MinimumWidth = 6
        Me.UrunGrubuC.Name = "UrunGrubuC"
        Me.UrunGrubuC.ReadOnly = True
        Me.UrunGrubuC.Width = 125
        '
        'BirimCinsiC
        '
        Me.BirimCinsiC.HeaderText = "Birim Cinsi"
        Me.BirimCinsiC.MinimumWidth = 6
        Me.BirimCinsiC.Name = "BirimCinsiC"
        Me.BirimCinsiC.ReadOnly = True
        Me.BirimCinsiC.Width = 125
        '
        'BarkodNoC
        '
        Me.BarkodNoC.HeaderText = "Barkod No"
        Me.BarkodNoC.MinimumWidth = 6
        Me.BarkodNoC.Name = "BarkodNoC"
        Me.BarkodNoC.ReadOnly = True
        Me.BarkodNoC.Width = 125
        '
        'UretimYeriC
        '
        Me.UretimYeriC.HeaderText = "Üretim Yeri"
        Me.UretimYeriC.MinimumWidth = 6
        Me.UretimYeriC.Name = "UretimYeriC"
        Me.UretimYeriC.ReadOnly = True
        Me.UretimYeriC.Width = 125
        '
        'AciklamaC
        '
        Me.AciklamaC.HeaderText = "Açıklama"
        Me.AciklamaC.MinimumWidth = 6
        Me.AciklamaC.Name = "AciklamaC"
        Me.AciklamaC.ReadOnly = True
        Me.AciklamaC.Width = 125
        '
        'UrunArama
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1239, 484)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.DGVUrunAdi)
        Me.Controls.Add(Me.BtnAra)
        Me.Controls.Add(Me.TBoxUrunAra)
        Me.Controls.Add(Me.Label1)
        Me.Name = "UrunArama"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "UrunAramavb"
        CType(Me.DGVUrunAdi, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel1.ResumeLayout(False)
        CType(Me.UrunTablosuBS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UrunTablosuDS, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents TBoxUrunAra As TextBox
    Friend WithEvents BtnAra As Button
    Friend WithEvents DGVUrunAdi As DataGridView
    Friend WithEvents BtnTamam As Button
    Friend WithEvents BtnVazgec As Button
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents UrunTablosuBS As BindingSource
    Friend WithEvents UrunTablosuDS As DataSet
    Friend WithEvents UrunNoC As DataGridViewTextBoxColumn
    Friend WithEvents MarkaNoC As DataGridViewTextBoxColumn
    Friend WithEvents BirimCinsiNoC As DataGridViewTextBoxColumn
    Friend WithEvents UrunGrupNoC As DataGridViewTextBoxColumn
    Friend WithEvents UrunAdiC As DataGridViewTextBoxColumn
    Friend WithEvents MarkaAdiC As DataGridViewTextBoxColumn
    Friend WithEvents UrunGrubuC As DataGridViewTextBoxColumn
    Friend WithEvents BirimCinsiC As DataGridViewTextBoxColumn
    Friend WithEvents BarkodNoC As DataGridViewTextBoxColumn
    Friend WithEvents UretimYeriC As DataGridViewTextBoxColumn
    Friend WithEvents AciklamaC As DataGridViewTextBoxColumn
End Class
