Imports System.Text

Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim Llower_case As String = "йцукенгшщзхъфывапролджэячсмитьбю"
        Dim nums As String = "0123456789"
        Dim letters As String = "!""#$%&'()*"
        Dim rand As New Random
        Dim sBuilder As New StringBuilder
        For i As Integer = 1 To 2
            Dim ind As Integer = rand.Next(0, 10)
            sBuilder.Append(nums.Substring(ind, 1))
        Next
        For i As Integer = 3 To 11 - (TextBox1.Text.Length) - 1
            Dim ind As Integer = rand.Next(0, 32)
            sBuilder.Append(Llower_case.Substring(ind, 1))
        Next
        For i As Integer = 11 - (TextBox1.Text.Length) - 1 To 11
            Dim ind As Integer = rand.Next(0, 10)
            sBuilder.Append(letters.Substring(ind, 1))
        Next

        Label3.Text = sBuilder.ToString
    End Sub
End Class
