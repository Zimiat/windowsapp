Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim eerstecijfer = InputBox("cijfer 1")
        Dim tweedecijfer = InputBox("cijfer 2")

        MsgBox($"Het kwadraat van {eerstecijfer} is {eerstecijfer ^ 2 } en het kwadraat van {tweedecijfer} is {tweedecijfer ^ 2}")
    End Sub
End Class
