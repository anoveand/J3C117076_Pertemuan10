Public Class Form1
    Dim hadiah As String

    Private Sub form1_load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim i As Integer
        For i = 1 To 31
            cbtgl.Items.Add(i)
        Next
        For i = 1 To 12
            cbbln.Items.Add(MonthName(i))
        Next
    End Sub

    Private Sub btncek_click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncek.Click
        If cbbln.SelectedIndex = 0 Then
            hadiah = "Payung"
        ElseIf cbbln.SelectedIndex = 1 Then
            hadiah = "Laptop"
        ElseIf cbbln.SelectedIndex = 2 Then
            hadiah = "Kamera"
        ElseIf cbbln.SelectedIndex = 3 Then
            hadiah = "Sepeda"
        ElseIf cbbln.SelectedIndex = 4 Then
            hadiah = "Motor"
        ElseIf cbbln.SelectedIndex = 5 Then
            hadiah = "TV"
        ElseIf cbbln.SelectedIndex = 6 Then
            hadiah = "Kulkas"
        ElseIf cbbln.SelectedIndex = 7 Then
            hadiah = "AC"
        ElseIf cbbln.SelectedIndex = 8 Then
            hadiah = "Jam tangan"
        ElseIf cbbln.SelectedIndex = 9 Then
            hadiah = "Baju"
        ElseIf cbbln.SelectedIndex = 10 Then
            hadiah = "Piring"
        ElseIf cbbln.SelectedIndex = 11 Then
            hadiah = "Printer"

        End If
        txthasil.Text = "Selamat " & txtnama.Text & ", Anda mendapatkan " & hadiah & "!"
    End Sub

    Private Sub btnbersihkan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnbersihkan.Click
        txtnama.Clear()
        txthasil.Clear()
        cbtgl.ResetText()
        cbbln.ResetText()
    End Sub

    Private Sub btnnext_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnnext.Click
        Form2.Show()
        Me.Hide()
    End Sub
End Class

