Imports System.Data.Odbc
Imports Microsoft.Reporting.WinForms
Public Class FormTransaksi
    Private Sub FormData_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        initializeColumns()
        loadTransactionHistory()
    End Sub
    Private Sub searchTransactionHistory()
        Try
            Dim searchText As String = "%" & txt_search.Text & "%"
            Dim dbConnect As OdbcConnection = ConnectionOdbc.getInstance().getConnection()
            Dim searchQuery As String = "SELECT id_barang, merk_barang, tipe_barang, harga_barang, harga_total, id_transaksi, kuantitas, " &
                      "waktu_transaksi, nama_pegawal_kasir, nominal_total_keseluruhan, nama_pembeli, " &
                      "no_telepon_pembeli, alamat_pembeli " &
                      "FROM histori_transaksi WHERE id_barang LIKE '" & searchText & "' OR merk_barang LIKE '" & searchText & "' OR tipe_barang LIKE '" & searchText & "' OR " &
                      "nama_pembeli LIKE '" & searchText & "' OR waktu_transaksi LIKE '" & searchText & "' OR id_transaksi LIKE '" & searchText & "' OR nama_pegawal_kasir LIKE '" & searchText & "'"

            Dim cmd As New OdbcCommand(searchQuery, dbConnect)
            Dim reader As OdbcDataReader = cmd.ExecuteReader()
            DGV2Kasir.Rows.Clear()
            While reader.Read()
                DGV2Kasir.Rows.Add(
                reader("id_barang"),
                reader("merk_barang"),
                reader("tipe_barang"),
                reader("harga_barang"),
                reader("harga_total"),
                reader("id_transaksi"),
                reader("kuantitas"),
                reader("waktu_transaksi"),
                reader("nama_pegawal_kasir"),
                reader("nominal_total_keseluruhan"),
                reader("nama_pembeli"),
                reader("no_telepon_pembeli"),
                reader("alamat_pembeli")
            )
            End While

            reader.Close()

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Sub

    Private Sub initializeColumns()
        ' Bersihkan kolom jika sudah ada
        DGV2Kasir.Columns.Clear()

        ' Tambahkan kolom sesuai dengan tabel histori_transaksi
        DGV2Kasir.Columns.Add("id_barang", "ID Barang")
        DGV2Kasir.Columns.Add("merk_barang", "Merk Barang")
        DGV2Kasir.Columns.Add("tipe_barang", "Tipe Barang")
        DGV2Kasir.Columns.Add("harga_barang", "Harga Barang")
        DGV2Kasir.Columns.Add("harga_total", "Harga Total")
        DGV2Kasir.Columns.Add("id_transaksi", "ID Transaksi")
        DGV2Kasir.Columns.Add("kuantitas", "Kuantitas")
        DGV2Kasir.Columns.Add("waktu_transaksi", "Waktu Transaksi")

        DGV2Kasir.Columns.Add("nama_pegawal_kasir", "Nama Pegawai Kasir")
        DGV2Kasir.Columns.Add("nominal_total_keseluruhan", "Total Keseluruhan")
        DGV2Kasir.Columns.Add("nama_pembeli", "Nama Pembeli")
        DGV2Kasir.Columns.Add("no_telepon_pembeli", "No Telepon Pembeli")
        DGV2Kasir.Columns.Add("alamat_pembeli", "Alamat Pembeli")
    End Sub

    Private Sub loadTransactionHistory()
        Try
            Dim dbConnect As OdbcConnection = ConnectionOdbc.getInstance().getConnection()
            Dim viewQuery As String = "SELECT id_barang, merk_barang, tipe_barang, harga_barang, harga_total, id_transaksi, kuantitas, " &
                                  "waktu_transaksi, nama_pegawal_kasir, nominal_total_keseluruhan, nama_pembeli, " &
                                  "no_telepon_pembeli, alamat_pembeli FROM histori_transaksi"
            Dim cmd As New OdbcCommand(viewQuery, dbConnect)
            Dim reader As OdbcDataReader = cmd.ExecuteReader()
            DGV2Kasir.Rows.Clear()
            While reader.Read()
                DGV2Kasir.Rows.Add(
                reader("id_barang"),
                reader("merk_barang"),
                reader("tipe_barang"),
                reader("harga_barang"),
                reader("harga_total"),
                reader("id_transaksi"),
                reader("kuantitas"),
                reader("waktu_transaksi"),
                reader("nama_pegawal_kasir"),
                reader("nominal_total_keseluruhan"),
                reader("nama_pembeli"),
                reader("no_telepon_pembeli"),
                reader("alamat_pembeli")
            )
            End While

            ' Menutup reader setelah selesai
            reader.Close()

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Sub


    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Me.Close()
    End Sub

    Private Sub TextBox7_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label8_Click(sender As Object, e As EventArgs) Handles Label8.Click

    End Sub

    Private Sub DataGridView2_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)

    End Sub

    Private Sub txt_search_TextChanged(sender As Object, e As EventArgs) Handles txt_search.TextChanged
        If String.IsNullOrWhiteSpace(txt_search.Text) Then
            loadTransactionHistory()
        Else
            searchTransactionHistory()
        End If
    End Sub


    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub FormTransaksi_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        idTrsLoad()
    End Sub

    Private Sub idTrsLoad()
        Try
            Dim dbConnect As OdbcConnection = ConnectionOdbc.getInstance().getConnection()
            Dim viewQuery As String = "SELECT id_transaksi FROM histori_transaksi"
            Dim cmd As New OdbcCommand(viewQuery, dbConnect)
            Dim reader As OdbcDataReader = cmd.ExecuteReader()
            While reader.Read()
                Dim idTransaksi As String = reader("id_transaksi").ToString()

            End While
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        cetakForm()
    End Sub

    Private Sub cetakForm()
        Dim dataPrint As New DataTable

        dataPrint.Columns.Add("idBarang", GetType(String))
        dataPrint.Columns.Add("Merk", GetType(String))
        dataPrint.Columns.Add("Tipe", GetType(String))
        dataPrint.Columns.Add("Harga", GetType(String))
        dataPrint.Columns.Add("QTY", GetType(String))
        dataPrint.Columns.Add("Ttl", GetType(String))

        ' Menambahkan data dari DataGridView ke DataTable
        For Each row As DataGridViewRow In DGV2Kasir.Rows
            If Not row.IsNewRow Then
                dataPrint.Rows.Add(
                row.Cells("id_barang").Value,
                row.Cells("merk_barang").Value,
                row.Cells("tipe_barang").Value,
                row.Cells("harga_barang").Value,
                row.Cells("kuantitas").Value,
                row.Cells("harga_total").Value
            )
            End If
        Next

        Dim namaPembeli As String = ""
        Dim alamat As String = ""
        Dim telepon As String = ""
        Dim total As String = ""
        Dim idtrs As String = ""
        If DGV2Kasir.Rows.Count > 0 AndAlso Not DGV2Kasir.Rows(0).IsNewRow Then
            namaPembeli = DGV2Kasir.Rows(0).Cells("nama_pembeli").Value.ToString()
            alamat = DGV2Kasir.Rows(0).Cells("alamat_pembeli").Value.ToString()
            telepon = DGV2Kasir.Rows(0).Cells("no_telepon_pembeli").Value.ToString()
            total = DGV2Kasir.Rows(0).Cells("nominal_total_keseluruhan").Value.ToString()
            idtrs = DGV2Kasir.Rows(0).Cells("id_transaksi").Value.ToString()
        End If

        FormViewHistory.ReportViewer.LocalReport.DataSources.Clear()
        FormViewHistory.ReportViewer.LocalReport.DataSources.Add(New ReportDataSource("DataSet1", dataPrint))

        Dim parameter(4) As ReportParameter
        parameter(0) = New ReportParameter("NAMA", namaPembeli)
        parameter(1) = New ReportParameter("ALAMAT", alamat)
        parameter(2) = New ReportParameter("TELEPON", telepon)
        parameter(3) = New ReportParameter("TOTAL", total)
        parameter(4) = New ReportParameter("IDTRS", idtrs)

        FormViewHistory.ReportViewer.LocalReport.SetParameters(parameter)
        FormViewHistory.ReportViewer.LocalReport.Refresh()
        FormViewHistory.ShowDialog()
    End Sub

    Private Sub cb_id_transaksi_SelectedIndexChanged(sender As Object, e As EventArgs)
        searchTransactionHistory()
    End Sub


End Class