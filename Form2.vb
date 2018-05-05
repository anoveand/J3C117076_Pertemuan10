Public Class Form2

    Private Sub btnproses_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnproses.Click
        Dim awal, akhir As Integer
        awal = txtawal.Text
        akhir = txtakhir.Text
        For i = awal To akhir
            ListBox1.Items.Add(i)
        Next

        If awal > akhir Then
            MessageBox.Show("Nilai awal harus lebih kecil dari nilai Akhir !", "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End If

    End Sub

    Private Sub btnnext_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnnext.Click
        Form3.Show()
        Me.Hide()
    End Sub

    Private Sub btnhapus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnhapus.Click
        txtawal.Clear()
        txtakhir.Clear()
        ListBox1.Items.Clear()
    End Sub
End Class