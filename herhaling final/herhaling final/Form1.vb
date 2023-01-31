Imports System.Security.Principal

Public Class Form1

    Dim naam As String = InputBox($"Geef je naam in:")
    Dim voornaam As String = InputBox($"Geef je voornaam in:")
    Dim geslacht As String = InputBox($"Geef je geslacht in (Man/Vrouw/Andere):")

    Dim rekeningnr As Double = InputBox($"Geef je rekeningsnummer in (XXX XXX XXX):")
    Dim zicht_rn As Double = InputBox($"Hoeveel heb je op je zichtrekening (XXX XXX,XX):")
    Dim spaarr_rn As Double = InputBox($"Hoeveel heb je op je spaarrekening (XXX XXX,XX):")
    Dim rente As Double = InputBox($"Kies je rentevoet:(x,x)")

    Dim transactie As String
    Dim transacties() As String
    Dim i As Integer

    Dim valuta As String = "Euro"

    Private Sub btn_login_Click(sender As Object, e As EventArgs) Handles btn_login.Click
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtB_naam.Text = naam
        txtB_voorn.Text = voornaam
        txtB_geslacht.Text = geslacht
        txtB_rekeningnr.Text = rekeningnr
        txtB_zichtr.Text = ($"€{zicht_rn}")
        txtB_spaarr.Text = ($"€{spaarr_rn}")
        txtB_rente.Text = rente
        txtB_valuta.Text = valuta

    End Sub

    Private Sub btn_Stort_Click(sender As Object, e As EventArgs) Handles btn_Stort.Click
        Dim bedrag As Double = InputBox("Kies een bedrag op op uw zichtrekening te storten (00,00):")
        zicht_rn += bedrag
        txtB_zichtr.Text = ($"€{zicht_rn}")
    End Sub

    Private Sub btn_omzetten_Click(sender As Object, e As EventArgs) Handles btn_omzetten.Click
        Dim keuze As Integer = InputBox($"Wil je van:{vbCrLf}1. Van zichtrekening naar spaarrekening storten.{vbCrLf}2.Van spaarrekening naar zichtrekening.{vbCrLf}Maak een keuze.")
        If keuze = 1 Then
            Dim bedrag As Double = InputBox($"Hoeveel wil je op je spaarrekening storten?:")
            zicht_rn -= bedrag
            spaarr_rn += bedrag
            txtB_zichtr.Text = ($"€{Math.Round(zicht_rn),2}")
            txtB_spaarr.Text = ($"€{Math.Round(spaarr_rn),2}")
            transacties(i) = ($"Storting van zicht naar spaarrekening voor een bedrag van €{bedrag}")
            i = i + 1
        End If
        If keuze = 2 Then
            Dim bedrag As Double = InputBox($"Hoeveel wil je op je zichtrekening storten?:")
            spaarr_rn -= bedrag
            zicht_rn += bedrag
            txtB_zichtr.Text = ($"€{Math.Round(zicht_rn),2}")
            txtB_spaarr.Text = ($"€{Math.Round(spaarr_rn),2}")
            transacties(i) = ($"Storting van spaar naar rekening voor een bedrag van €{bedrag}")
            i = i + 1
        End If
    End Sub

End Class
