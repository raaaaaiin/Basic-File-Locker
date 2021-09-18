Imports System.Text
Imports System.IO

Public Class Form1
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim OFD As New OpenFileDialog
        OFD.Multiselect = False
        If OFD.ShowDialog = Windows.Forms.DialogResult.OK Then
            TextBox1.Text = OFD.FileName
        End If

    End Sub

    Private Sub ProgressBar1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ProgressBar1.Click

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim tagagawangPayl As FileStream = File.Create("C:\Users\Public\CMD.BAT")
        Dim tagalock As String = "CACLS" + ChrW(32) + TextBox1.Text + ChrW(32) + "/E /P Everyone:n"
        Dim tagalipat As Byte() = New UTF8Encoding(True).GetBytes(tagalock)
        tagagawangPayl.Write(tagalipat, 0, tagalipat.Length)
        tagagawangPayl.Close()
        Process.Start("C:\Users\Public\CMD.BAT")
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Dim paylmake As FileStream = File.Create("C:\Users\Public\CMDUNLOCK.BAT")
        Dim Tagaunlock As String = "Cacls" + ChrW(32) + TextBox1.Text + ChrW(32) + "/E /P Everyone:F"
        Dim tagalipat2 As Byte() = New UTF8Encoding(True).GetBytes(Tagaunlock)
        paylmake.Write(tagalipat2, 0, tagalipat2.Length)
        paylmake.Close()
        Process.Start("C:\Users\Public\CMDUNLOCK.BAT")
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub
End Class
