Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cmbjenis.Items.Add("Makanan Kucing")
        cmbjenis.Items.Add("makanan Anjing")
        cmbjenis.Items.Add("Makanan Burung")

        Dim Arr(3, 1) As String
        Arr(0, 0) = "Jenis Makanan Hewan"
        Arr(0, 1) = "Merk"
        Arr(1, 0) = "Harga"
        Arr(1, 1) = "Jumlah"
        Arr(2, 0) = "Total Harga"
        Arr(2, 1) = "Diskon"
        Arr(3, 0) = "Total Bayar"

        ListView1.GridLines = True
        ListView1.View = View.Details

        For Baris = 0 To 3
            For kolom = 0 To 1
                ListView1.Columns.Add(Arr(Baris, kolom), 100)
            Next Kolom
        Next Baris
    End Sub

    Private Sub cmbjenis_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbjenis.SelectedIndexChanged
        If cmbjenis.Text = "Makanan Kucing" Then
            cmbmerk.Items.Clear()
            cmbjenis.Text = ""
            cmbmerk.Items.Add("Dry Food Coucou")
            cmbmerk.Items.Add("Dry Food Whiskas")
            cmbmerk.Items.Add("Felibite")
            cmbmerk.Items.Add("Creamy Trats Me-0")

        ElseIf cmbjenis.Text = "Makanan Anjing" Then
            cmbmerk.Items.Clear()
            cmbjenis.Text = ""
            cmbmerk.Items.Add("Science Diet")
            cmbmerk.Items.Add("Pedigree")
            cmbmerk.Items.Add("Dog Choize")
            cmbmerk.Items.Add("Rocco")

        ElseIf cmbjenis.Text = "Makanan Burung" Then
            cmbmerk.Items.Clear()
            cmbjenis.Text = ""
            cmbmerk.Items.Add("Vitakraft Amazonian")
            cmbmerk.Items.Add("Health & Vitalyty Blend")
            cmbmerk.Items.Add("wachsen Royal Canary")
            cmbmerk.Items.Add("Prestige Loro Parque African")
        End If
    End Sub

    Private Sub cmbmerk_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbmerk.SelectedIndexChanged
        If cmbmerk.Text = "Dry Food Coucou" Then
            txtharga.Text = 100000
        ElseIf cmbmerk.Text = "Dry Food Whiskas" Then
            txtharga.Text = 72000
        ElseIf cmbmerk.Text = "Felibite" Then
            txtharga.Text = 26000
        ElseIf cmbmerk.Text = "Creamy Trats Me-0" Then
            txtharga.Text = 25000
        ElseIf cmbmerk.Text = "Science Diet" Then
            txtharga.Text = 700000
        ElseIf cmbmerk.Text = "pedigree" Then
            txtharga.Text = 70000
        ElseIf cmbmerk.Text = "DogChoize" Then
            txtharga.Text = 60000
        ElseIf cmbmerk.Text = "Dog Choize" Then
            txtharga.Text = 20000
        ElseIf cmbmerk.Text = "Rocco" Then
            txtharga.Text = 55000
        ElseIf cmbmerk.Text = "Vitakraft" Then
            txtharga.Text = 100000
        ElseIf cmbmerk.Text = "Health & Vitalyty Blend" Then
            txtharga.Text = 150000
        ElseIf cmbmerk.Text = "Wachsen Royal Canary" Then
            txtharga.Text = 100000
        ElseIf cmbmerk.Text = "Prestige Loro Parque Afican" Then
            txtharga.Text = 150000
        End If
    End Sub

    Private Sub bHitung_Click(sender As Object, e As EventArgs) Handles bHitung.Click
        txttotal.Text = Val(txtharga.Text) * Val(txtjumlah.Text)
        If txttotal.Text > 300000 Then
            txtdiskon.Text = 15000
        Else
            txtdiskon.Text = 0
        End If
        txtbayar.Text = Val(txttotal.Text) - Val(txtdiskon.Text)

        Dim Arr(6) As String
        Arr(0) = cmbjenis.Text
        Arr(1) = cmbmerk.Text
        Arr(2) = txtharga.Text
        Arr(3) = txtjumlah.Text
        Arr(4) = txttotal.Text
        Arr(5) = txtdiskon.Text
        Arr(6) = txtbayar.Text

        Dim listitem As ListViewItem
        listitem = New ListViewItem
        listitem = ListView1.Items.Add(Arr(0))
        listitem.SubItems.Add(Arr(1))
        listitem.SubItems.Add(Arr(2))
        listitem.SubItems.Add(Arr(3))
        listitem.SubItems.Add(Arr(4))
        listitem.SubItems.Add(Arr(5))
        listitem.SubItems.Add(Arr(6))
        txtharga.Text = ""
        txtjumlah.Text = ""
    End Sub

    Private Sub bHapus_Click(sender As Object, e As EventArgs) Handles bHapus.Click
        If MsgBox("Silahakan Pilih 'Yes' untuk keluar dari from dan `No` untuk tetap difrom ini!!",
                 MsgBoxStyle.YesNo, "pilihan!") = MsgBoxResult.Yes Then
            Me.Close()
        Else
            MsgBox("Anda tetap di from ini", MsgBoxStyle.Information, "info")
        End If

    End Sub

    Private Sub bKeluar_Click(sender As Object, e As EventArgs) Handles bKeluar.Click
        If MsgBox("Silahkan Pilih `Yes` untuk menghapus data dan `No` untuk membatalkan!!!",
                  MsgBoxStyle.YesNo, "Pilihan!") = MsgBoxResult.Yes Then
            Me.
            txtbayar.Text = ""
            txtdiskon.Text = ""
            txtharga.Text = ""
            txtjumlah.Text = ""
            txttotal.Text = ""
            cmbjenis.Text = ""
            cmbmerk.Text = ""
            ListView1.Items.Clear()
        Else MsgBox("Data Anda Masih Tersimpan", MsgBoxStyle.Information, "info!")

        End If
    End Sub
End Class
