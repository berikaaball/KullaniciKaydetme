<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AnaForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AnaForm))
        Me.AnaMenuStrip = New System.Windows.Forms.MenuStrip()
        Me.ProgramToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StokGirişToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StokÇıkışToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProgramıKapatToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.KayıtlarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MarkaKaydıToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ÜrünKaydıToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.YeniKullanıcıKaydıToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AramalarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ÜrünAramaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.KisaYolToolStrip = New System.Windows.Forms.ToolStrip()
        Me.ToolStripButton2 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton3 = New System.Windows.Forms.ToolStripButton()
        Me.PBoxResim = New System.Windows.Forms.PictureBox()
        Me.DurumStatusStrip = New System.Windows.Forms.StatusStrip()
        Me.AnaMenuStrip.SuspendLayout()
        Me.KisaYolToolStrip.SuspendLayout()
        CType(Me.PBoxResim, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'AnaMenuStrip
        '
        Me.AnaMenuStrip.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.AnaMenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ProgramToolStripMenuItem, Me.KayıtlarToolStripMenuItem, Me.AramalarToolStripMenuItem})
        Me.AnaMenuStrip.Location = New System.Drawing.Point(0, 0)
        Me.AnaMenuStrip.Name = "AnaMenuStrip"
        Me.AnaMenuStrip.Size = New System.Drawing.Size(925, 28)
        Me.AnaMenuStrip.TabIndex = 0
        Me.AnaMenuStrip.Text = "MenuStrip1"
        '
        'ProgramToolStripMenuItem
        '
        Me.ProgramToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.StokGirişToolStripMenuItem, Me.StokÇıkışToolStripMenuItem, Me.ProgramıKapatToolStripMenuItem})
        Me.ProgramToolStripMenuItem.Name = "ProgramToolStripMenuItem"
        Me.ProgramToolStripMenuItem.Size = New System.Drawing.Size(80, 24)
        Me.ProgramToolStripMenuItem.Text = "Program"
        '
        'StokGirişToolStripMenuItem
        '
        Me.StokGirişToolStripMenuItem.Name = "StokGirişToolStripMenuItem"
        Me.StokGirişToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F8
        Me.StokGirişToolStripMenuItem.Size = New System.Drawing.Size(249, 26)
        Me.StokGirişToolStripMenuItem.Text = "Stok Giriş"
        '
        'StokÇıkışToolStripMenuItem
        '
        Me.StokÇıkışToolStripMenuItem.Name = "StokÇıkışToolStripMenuItem"
        Me.StokÇıkışToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F9
        Me.StokÇıkışToolStripMenuItem.Size = New System.Drawing.Size(249, 26)
        Me.StokÇıkışToolStripMenuItem.Text = "Stok Çıkış"
        '
        'ProgramıKapatToolStripMenuItem
        '
        Me.ProgramıKapatToolStripMenuItem.Name = "ProgramıKapatToolStripMenuItem"
        Me.ProgramıKapatToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.F4), System.Windows.Forms.Keys)
        Me.ProgramıKapatToolStripMenuItem.Size = New System.Drawing.Size(249, 26)
        Me.ProgramıKapatToolStripMenuItem.Text = "Programı Kapat"
        '
        'KayıtlarToolStripMenuItem
        '
        Me.KayıtlarToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MarkaKaydıToolStripMenuItem, Me.ÜrünKaydıToolStripMenuItem, Me.YeniKullanıcıKaydıToolStripMenuItem})
        Me.KayıtlarToolStripMenuItem.Name = "KayıtlarToolStripMenuItem"
        Me.KayıtlarToolStripMenuItem.Size = New System.Drawing.Size(73, 24)
        Me.KayıtlarToolStripMenuItem.Text = "Kayıtlar"
        '
        'MarkaKaydıToolStripMenuItem
        '
        Me.MarkaKaydıToolStripMenuItem.Name = "MarkaKaydıToolStripMenuItem"
        Me.MarkaKaydıToolStripMenuItem.Size = New System.Drawing.Size(224, 26)
        Me.MarkaKaydıToolStripMenuItem.Text = "Marka Kaydı"
        '
        'ÜrünKaydıToolStripMenuItem
        '
        Me.ÜrünKaydıToolStripMenuItem.Name = "ÜrünKaydıToolStripMenuItem"
        Me.ÜrünKaydıToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.U), System.Windows.Forms.Keys)
        Me.ÜrünKaydıToolStripMenuItem.Size = New System.Drawing.Size(224, 26)
        Me.ÜrünKaydıToolStripMenuItem.Text = "Ürün Kaydı"
        '
        'YeniKullanıcıKaydıToolStripMenuItem
        '
        Me.YeniKullanıcıKaydıToolStripMenuItem.Name = "YeniKullanıcıKaydıToolStripMenuItem"
        Me.YeniKullanıcıKaydıToolStripMenuItem.Size = New System.Drawing.Size(224, 26)
        Me.YeniKullanıcıKaydıToolStripMenuItem.Text = "Yeni Kullanıcı Kaydı"
        '
        'AramalarToolStripMenuItem
        '
        Me.AramalarToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ÜrünAramaToolStripMenuItem})
        Me.AramalarToolStripMenuItem.Name = "AramalarToolStripMenuItem"
        Me.AramalarToolStripMenuItem.Size = New System.Drawing.Size(84, 24)
        Me.AramalarToolStripMenuItem.Text = "Aramalar"
        '
        'ÜrünAramaToolStripMenuItem
        '
        Me.ÜrünAramaToolStripMenuItem.Name = "ÜrünAramaToolStripMenuItem"
        Me.ÜrünAramaToolStripMenuItem.Size = New System.Drawing.Size(224, 26)
        Me.ÜrünAramaToolStripMenuItem.Text = "Ürün Arama"
        '
        'KisaYolToolStrip
        '
        Me.KisaYolToolStrip.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.KisaYolToolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton3, Me.ToolStripButton2})
        Me.KisaYolToolStrip.Location = New System.Drawing.Point(0, 28)
        Me.KisaYolToolStrip.Name = "KisaYolToolStrip"
        Me.KisaYolToolStrip.Size = New System.Drawing.Size(925, 53)
        Me.KisaYolToolStrip.TabIndex = 1
        Me.KisaYolToolStrip.Text = "ToolStrip1"
        '
        'ToolStripButton2
        '
        Me.ToolStripButton2.AutoSize = False
        Me.ToolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton2.Image = CType(resources.GetObject("ToolStripButton2.Image"), System.Drawing.Image)
        Me.ToolStripButton2.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ToolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton2.Name = "ToolStripButton2"
        Me.ToolStripButton2.Size = New System.Drawing.Size(50, 50)
        Me.ToolStripButton2.Text = "Stok Çıkış"
        '
        'ToolStripButton3
        '
        Me.ToolStripButton3.AutoSize = False
        Me.ToolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton3.Image = CType(resources.GetObject("ToolStripButton3.Image"), System.Drawing.Image)
        Me.ToolStripButton3.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ToolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton3.Name = "ToolStripButton3"
        Me.ToolStripButton3.Size = New System.Drawing.Size(50, 50)
        Me.ToolStripButton3.Text = "Stok Giriş"
        '
        'PBoxResim
        '
        Me.PBoxResim.Location = New System.Drawing.Point(817, 31)
        Me.PBoxResim.Name = "PBoxResim"
        Me.PBoxResim.Size = New System.Drawing.Size(75, 50)
        Me.PBoxResim.TabIndex = 2
        Me.PBoxResim.TabStop = False
        '
        'DurumStatusStrip
        '
        Me.DurumStatusStrip.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.DurumStatusStrip.Location = New System.Drawing.Point(0, 463)
        Me.DurumStatusStrip.Name = "DurumStatusStrip"
        Me.DurumStatusStrip.Size = New System.Drawing.Size(925, 22)
        Me.DurumStatusStrip.TabIndex = 3
        Me.DurumStatusStrip.Text = "StatusStrip1"
        '
        'AnaForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(925, 485)
        Me.Controls.Add(Me.DurumStatusStrip)
        Me.Controls.Add(Me.PBoxResim)
        Me.Controls.Add(Me.KisaYolToolStrip)
        Me.Controls.Add(Me.AnaMenuStrip)
        Me.MainMenuStrip = Me.AnaMenuStrip
        Me.Name = "AnaForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "AnaForm"
        Me.AnaMenuStrip.ResumeLayout(False)
        Me.AnaMenuStrip.PerformLayout()
        Me.KisaYolToolStrip.ResumeLayout(False)
        Me.KisaYolToolStrip.PerformLayout()
        CType(Me.PBoxResim, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents AnaMenuStrip As MenuStrip
    Friend WithEvents ProgramToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents StokGirişToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents StokÇıkışToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ProgramıKapatToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents KayıtlarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MarkaKaydıToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ÜrünKaydıToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents YeniKullanıcıKaydıToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AramalarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ÜrünAramaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents KisaYolToolStrip As ToolStrip
    Friend WithEvents ToolStripButton2 As ToolStripButton
    Friend WithEvents ToolStripButton3 As ToolStripButton
    Friend WithEvents PBoxResim As PictureBox
    Friend WithEvents DurumStatusStrip As StatusStrip
End Class
