Public Class Form3

    Private Sub btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn.Click
        Dim n, i, fakt, fibo, a, b, c, kuad As Integer
        n = txtn.Text

        fakt = 1
        For i = 1 To n
            fakt = i * fakt
        Next
        txtfakt.Text = fakt

        a = 0
        b = 1
        fibo = a
        fibo = b
        If n = 1 Then
            fibo = 0
        ElseIf n = 2 Then
            fibo = 1
        End If
        For i = 3 To n
            c = Val(a) + Val(b)
            fibo = c
            a = b
            b = c
        Next
        txtfibo.Text = fibo

        For i = 1 To n
            kuad = n * n
            txtkuad.Text = kuad
        Next
    End Sub
End Class