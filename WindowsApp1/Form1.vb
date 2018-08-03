Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Process.Start("C:\Windows\system32\dsa.msc")
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Process.Start("C:\Users\sam.james\source\repos\WindowsApp1\WindowsApp1\Scripts\gpupdate.bat")
    End Sub

End Class