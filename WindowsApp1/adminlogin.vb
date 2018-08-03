Public Class adminlogin
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text = "arm50Firerum" Then
            adminpanel.Show()
            Me.Hide()
        End If
    End Sub
End Class