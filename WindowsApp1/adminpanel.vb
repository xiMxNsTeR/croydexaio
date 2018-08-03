Public Class adminpanel
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Process.Start("C:\Users\sam.james\source\repos\WindowsApp1\WindowsApp1\Scripts\itlog.bat")
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Process.Start("C:\Users\sam.james\source\repos\WindowsApp1\WindowsApp1\Scripts\opensoftwarefolder.bat")
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Process.Start("C:\Windows\system32\dsa.msc")
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Process.Start("C:\Users\sam.james\source\repos\WindowsApp1\WindowsApp1\Scripts\contacts.bat")
    End Sub
End Class