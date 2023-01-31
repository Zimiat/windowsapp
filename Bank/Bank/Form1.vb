Imports System.Reflection.Emit

Public Class Form1
    Dim namen, voornamen, genders As String
    Dim fictieveRekeningNummer As Integer
    Dim bedragZichtRekening, bedragSpaarRekening As Double
    Dim valuta As String
    Dim dagenSparen As Integer
    Dim rentevoet As Double
    Dim transacties As New List(Of String)

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        namen = InputBox("Naam")
        voornamen = InputBox("Voornaam")
        genders = InputBox("Gender")
        fictieveRekeningNummer = InputBox("Fictieve Rekeningnummer")
        bedragZichtRekening = InputBox("Bedrag Zichtrekening")
        bedragSpaarRekening = InputBox("Bedrag Spaarrekening")
        valuta = "Euro"
        dagenSparen = InputBox("Hoeveel dagen ben je aan het sparen")
        rentevoet = InputBox("Rentevoet")

        Label1.Text = "Naam: " & namen & vbNewLine &
                      "Voornaam: " & voornamen & vbNewLine &
                      "Gender: " & genders & vbNewLine &
                      "Fictieve Rekeningnummer: " & fictieveRekeningNummer & vbNewLine &
                      "Bedrag Zichtrekening: " & bedragZichtRekening & vbNewLine &
                      "Bedrag Spaarrekening: " & bedragSpaarRekening & vbNewLine &
                      "Valuta: " & valuta & vbNewLine &
                      "Dagen Sparen: " & dagenSparen & vbNewLine &
                      "Rentevoet: " & rentevoet
    End Sub
End Class
