Public Class Form1
    Private Sub btEjecutar_Click(sender As Object, e As EventArgs) Handles btEjecutar.Click
        For n = 0 To 2000 Step 2
            lstMostrarPares.Items.Add("" & n)
        Next
    End Sub
End Class
