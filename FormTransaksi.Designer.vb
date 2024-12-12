<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormTransaksi
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormTransaksi))
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.DGV2Kasir = New System.Windows.Forms.DataGridView()
        Me.id_barang_transaksi = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.id_transaksi = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.merk_barang_transaksi = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tipe_barang_transaksi = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tahun_produksi_barang_transaksi = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.harga_satuan_transaksi = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.harga_total_transaksi = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.kuantitas_transaksi = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.waktu_transaksi = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.garansi_barang_transaksi = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nama_pegawai_kasir = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.txt_search = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Panel2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DGV2Kasir, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel2
        '
        Me.Panel2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel2.Controls.Add(Me.GroupBox1)
        Me.Panel2.Location = New System.Drawing.Point(1, 89)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1612, 718)
        Me.Panel2.TabIndex = 4
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.DGV2Kasir)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.txt_search)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(11, 18)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1522, 693)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Cari Barang"
        '
        'DGV2Kasir
        '
        Me.DGV2Kasir.AllowUserToAddRows = False
        Me.DGV2Kasir.AllowUserToDeleteRows = False
        Me.DGV2Kasir.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DGV2Kasir.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV2Kasir.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.id_barang_transaksi, Me.id_transaksi, Me.merk_barang_transaksi, Me.tipe_barang_transaksi, Me.tahun_produksi_barang_transaksi, Me.harga_satuan_transaksi, Me.harga_total_transaksi, Me.kuantitas_transaksi, Me.waktu_transaksi, Me.garansi_barang_transaksi, Me.nama_pegawai_kasir})
        Me.DGV2Kasir.Location = New System.Drawing.Point(6, 70)
        Me.DGV2Kasir.Name = "DGV2Kasir"
        Me.DGV2Kasir.ReadOnly = True
        Me.DGV2Kasir.RowHeadersWidth = 51
        Me.DGV2Kasir.RowTemplate.Height = 24
        Me.DGV2Kasir.Size = New System.Drawing.Size(1501, 617)
        Me.DGV2Kasir.TabIndex = 17
        '
        'id_barang_transaksi
        '
        Me.id_barang_transaksi.HeaderText = "ID BARANG"
        Me.id_barang_transaksi.MinimumWidth = 6
        Me.id_barang_transaksi.Name = "id_barang_transaksi"
        Me.id_barang_transaksi.ReadOnly = True
        Me.id_barang_transaksi.Width = 125
        '
        'id_transaksi
        '
        Me.id_transaksi.HeaderText = "ID TRANSAKSI"
        Me.id_transaksi.MinimumWidth = 6
        Me.id_transaksi.Name = "id_transaksi"
        Me.id_transaksi.ReadOnly = True
        Me.id_transaksi.Width = 125
        '
        'merk_barang_transaksi
        '
        Me.merk_barang_transaksi.HeaderText = "MERK BARANG"
        Me.merk_barang_transaksi.MinimumWidth = 6
        Me.merk_barang_transaksi.Name = "merk_barang_transaksi"
        Me.merk_barang_transaksi.ReadOnly = True
        Me.merk_barang_transaksi.Width = 125
        '
        'tipe_barang_transaksi
        '
        Me.tipe_barang_transaksi.HeaderText = "TIPE BARANG"
        Me.tipe_barang_transaksi.MinimumWidth = 6
        Me.tipe_barang_transaksi.Name = "tipe_barang_transaksi"
        Me.tipe_barang_transaksi.ReadOnly = True
        Me.tipe_barang_transaksi.Width = 125
        '
        'tahun_produksi_barang_transaksi
        '
        Me.tahun_produksi_barang_transaksi.HeaderText = "TAHUN PRODUKSI"
        Me.tahun_produksi_barang_transaksi.MinimumWidth = 6
        Me.tahun_produksi_barang_transaksi.Name = "tahun_produksi_barang_transaksi"
        Me.tahun_produksi_barang_transaksi.ReadOnly = True
        Me.tahun_produksi_barang_transaksi.Width = 125
        '
        'harga_satuan_transaksi
        '
        Me.harga_satuan_transaksi.HeaderText = "HARGA SATUAN"
        Me.harga_satuan_transaksi.MinimumWidth = 6
        Me.harga_satuan_transaksi.Name = "harga_satuan_transaksi"
        Me.harga_satuan_transaksi.ReadOnly = True
        Me.harga_satuan_transaksi.Width = 125
        '
        'harga_total_transaksi
        '
        Me.harga_total_transaksi.HeaderText = "HARGA TOTAL"
        Me.harga_total_transaksi.MinimumWidth = 6
        Me.harga_total_transaksi.Name = "harga_total_transaksi"
        Me.harga_total_transaksi.ReadOnly = True
        Me.harga_total_transaksi.Width = 125
        '
        'kuantitas_transaksi
        '
        Me.kuantitas_transaksi.HeaderText = "QTY"
        Me.kuantitas_transaksi.MinimumWidth = 6
        Me.kuantitas_transaksi.Name = "kuantitas_transaksi"
        Me.kuantitas_transaksi.ReadOnly = True
        Me.kuantitas_transaksi.Width = 125
        '
        'waktu_transaksi
        '
        Me.waktu_transaksi.HeaderText = "WAKTU TRANSAKSI"
        Me.waktu_transaksi.MinimumWidth = 6
        Me.waktu_transaksi.Name = "waktu_transaksi"
        Me.waktu_transaksi.ReadOnly = True
        Me.waktu_transaksi.Width = 125
        '
        'garansi_barang_transaksi
        '
        Me.garansi_barang_transaksi.HeaderText = "GARANSI BARANG"
        Me.garansi_barang_transaksi.MinimumWidth = 6
        Me.garansi_barang_transaksi.Name = "garansi_barang_transaksi"
        Me.garansi_barang_transaksi.ReadOnly = True
        Me.garansi_barang_transaksi.Width = 125
        '
        'nama_pegawai_kasir
        '
        Me.nama_pegawai_kasir.HeaderText = "NAMA PEGAWAI"
        Me.nama_pegawai_kasir.MinimumWidth = 6
        Me.nama_pegawai_kasir.Name = "nama_pegawai_kasir"
        Me.nama_pegawai_kasir.ReadOnly = True
        Me.nama_pegawai_kasir.Width = 125
        '
        'Button1
        '
        Me.Button1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button1.BackColor = System.Drawing.Color.Navy
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(1294, 25)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(213, 39)
        Me.Button1.TabIndex = 16
        Me.Button1.Text = "CETAK"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'txt_search
        '
        Me.txt_search.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_search.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_search.Location = New System.Drawing.Point(6, 26)
        Me.txt_search.Name = "txt_search"
        Me.txt_search.Size = New System.Drawing.Size(926, 38)
        Me.txt_search.TabIndex = 0
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.Color.Black
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(1, 800)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1643, 50)
        Me.Panel1.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label1.Location = New System.Drawing.Point(20, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(796, 20)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Designed And Development By Kelompok 4 || Muhammad Alfan Muwaffiqul Ihsan || Nare" &
    "ndra Adi Nugraha"
        '
        'Label8
        '
        Me.Label8.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 28.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label8.Location = New System.Drawing.Point(27, 21)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(881, 55)
        Me.Label8.TabIndex = 21
        Me.Label8.Text = "TRANSAKSI RIZEKI JAYA KOMPUTER"
        '
        'Button6
        '
        Me.Button6.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button6.BackColor = System.Drawing.Color.Transparent
        Me.Button6.BackgroundImage = CType(resources.GetObject("Button6.BackgroundImage"), System.Drawing.Image)
        Me.Button6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Button6.ForeColor = System.Drawing.Color.Transparent
        Me.Button6.Location = New System.Drawing.Point(1466, 21)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(53, 50)
        Me.Button6.TabIndex = 17
        Me.Button6.UseVisualStyleBackColor = False
        '
        'FormTransaksi
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(1610, 850)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FormTransaksi"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormTransaksi"
        Me.Panel2.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DGV2Kasir, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel2 As Panel
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txt_search As TextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Button6 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents DGV2Kasir As DataGridView
    Friend WithEvents id_barang_transaksi As DataGridViewTextBoxColumn
    Friend WithEvents id_transaksi As DataGridViewTextBoxColumn
    Friend WithEvents merk_barang_transaksi As DataGridViewTextBoxColumn
    Friend WithEvents tipe_barang_transaksi As DataGridViewTextBoxColumn
    Friend WithEvents tahun_produksi_barang_transaksi As DataGridViewTextBoxColumn
    Friend WithEvents harga_satuan_transaksi As DataGridViewTextBoxColumn
    Friend WithEvents harga_total_transaksi As DataGridViewTextBoxColumn
    Friend WithEvents kuantitas_transaksi As DataGridViewTextBoxColumn
    Friend WithEvents waktu_transaksi As DataGridViewTextBoxColumn
    Friend WithEvents garansi_barang_transaksi As DataGridViewTextBoxColumn
    Friend WithEvents nama_pegawai_kasir As DataGridViewTextBoxColumn
End Class
