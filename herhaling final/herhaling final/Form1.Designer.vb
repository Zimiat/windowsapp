<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.lbl_naam = New System.Windows.Forms.Label()
        Me.lbl_voorn = New System.Windows.Forms.Label()
        Me.lbl_Geslacht = New System.Windows.Forms.Label()
        Me.lbl_rekeningsnummer = New System.Windows.Forms.Label()
        Me.txtB_zichtr = New System.Windows.Forms.TextBox()
        Me.txtB_spaarr = New System.Windows.Forms.TextBox()
        Me.txtB_valuta = New System.Windows.Forms.TextBox()
        Me.btn_Stort = New System.Windows.Forms.Button()
        Me.btn_omzetten = New System.Windows.Forms.Button()
        Me.lbl_dagensparen = New System.Windows.Forms.Label()
        Me.lbl_rente = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.btn_nummerverb = New System.Windows.Forms.Button()
        Me.txtB_rekeningnr = New System.Windows.Forms.TextBox()
        Me.txtB_rente = New System.Windows.Forms.TextBox()
        Me.btn_login = New System.Windows.Forms.Button()
        Me.txtB_naam = New System.Windows.Forms.TextBox()
        Me.txtB_voorn = New System.Windows.Forms.TextBox()
        Me.txtB_geslacht = New System.Windows.Forms.TextBox()
        Me.ZIchtrekening = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lbl_naam
        '
        Me.lbl_naam.AutoSize = True
        Me.lbl_naam.Location = New System.Drawing.Point(90, 111)
        Me.lbl_naam.Name = "lbl_naam"
        Me.lbl_naam.Size = New System.Drawing.Size(49, 20)
        Me.lbl_naam.TabIndex = 0
        Me.lbl_naam.Text = "Naam"
        '
        'lbl_voorn
        '
        Me.lbl_voorn.AutoSize = True
        Me.lbl_voorn.Location = New System.Drawing.Point(90, 147)
        Me.lbl_voorn.Name = "lbl_voorn"
        Me.lbl_voorn.Size = New System.Drawing.Size(77, 20)
        Me.lbl_voorn.TabIndex = 1
        Me.lbl_voorn.Text = "Voornaam"
        '
        'lbl_Geslacht
        '
        Me.lbl_Geslacht.AutoSize = True
        Me.lbl_Geslacht.Location = New System.Drawing.Point(90, 186)
        Me.lbl_Geslacht.Name = "lbl_Geslacht"
        Me.lbl_Geslacht.Size = New System.Drawing.Size(65, 20)
        Me.lbl_Geslacht.TabIndex = 2
        Me.lbl_Geslacht.Text = "Geslacht"
        '
        'lbl_rekeningsnummer
        '
        Me.lbl_rekeningsnummer.AutoSize = True
        Me.lbl_rekeningsnummer.Location = New System.Drawing.Point(49, 73)
        Me.lbl_rekeningsnummer.Name = "lbl_rekeningsnummer"
        Me.lbl_rekeningsnummer.Size = New System.Drawing.Size(131, 20)
        Me.lbl_rekeningsnummer.TabIndex = 5
        Me.lbl_rekeningsnummer.Text = "Rekeningsnummer"
        '
        'txtB_zichtr
        '
        Me.txtB_zichtr.Location = New System.Drawing.Point(446, 103)
        Me.txtB_zichtr.Name = "txtB_zichtr"
        Me.txtB_zichtr.Size = New System.Drawing.Size(169, 27)
        Me.txtB_zichtr.TabIndex = 7
        '
        'txtB_spaarr
        '
        Me.txtB_spaarr.Location = New System.Drawing.Point(446, 136)
        Me.txtB_spaarr.Name = "txtB_spaarr"
        Me.txtB_spaarr.Size = New System.Drawing.Size(169, 27)
        Me.txtB_spaarr.TabIndex = 8
        '
        'txtB_valuta
        '
        Me.txtB_valuta.Location = New System.Drawing.Point(446, 72)
        Me.txtB_valuta.Name = "txtB_valuta"
        Me.txtB_valuta.Size = New System.Drawing.Size(67, 27)
        Me.txtB_valuta.TabIndex = 9
        '
        'btn_Stort
        '
        Me.btn_Stort.Location = New System.Drawing.Point(673, 105)
        Me.btn_Stort.Name = "btn_Stort"
        Me.btn_Stort.Size = New System.Drawing.Size(94, 29)
        Me.btn_Stort.TabIndex = 10
        Me.btn_Stort.Text = "Storten"
        Me.btn_Stort.UseVisualStyleBackColor = True
        '
        'btn_omzetten
        '
        Me.btn_omzetten.Location = New System.Drawing.Point(673, 140)
        Me.btn_omzetten.Name = "btn_omzetten"
        Me.btn_omzetten.Size = New System.Drawing.Size(94, 29)
        Me.btn_omzetten.TabIndex = 11
        Me.btn_omzetten.Text = "Omzetten"
        Me.btn_omzetten.UseVisualStyleBackColor = True
        '
        'lbl_dagensparen
        '
        Me.lbl_dagensparen.AutoSize = True
        Me.lbl_dagensparen.Location = New System.Drawing.Point(26, 287)
        Me.lbl_dagensparen.Name = "lbl_dagensparen"
        Me.lbl_dagensparen.Size = New System.Drawing.Size(154, 20)
        Me.lbl_dagensparen.TabIndex = 12
        Me.lbl_dagensparen.Text = "Dagen aan het sparen"
        '
        'lbl_rente
        '
        Me.lbl_rente.AutoSize = True
        Me.lbl_rente.Location = New System.Drawing.Point(104, 256)
        Me.lbl_rente.Name = "lbl_rente"
        Me.lbl_rente.Size = New System.Drawing.Size(76, 20)
        Me.lbl_rente.TabIndex = 13
        Me.lbl_rente.Text = "Rentevoet"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(343, 329)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(242, 100)
        Me.TextBox1.TabIndex = 15
        '
        'btn_nummerverb
        '
        Me.btn_nummerverb.Location = New System.Drawing.Point(658, 175)
        Me.btn_nummerverb.Name = "btn_nummerverb"
        Me.btn_nummerverb.Size = New System.Drawing.Size(139, 73)
        Me.btn_nummerverb.TabIndex = 16
        Me.btn_nummerverb.Text = "Rekeningsnummer verbergen"
        Me.btn_nummerverb.UseVisualStyleBackColor = True
        '
        'txtB_rekeningnr
        '
        Me.txtB_rekeningnr.Location = New System.Drawing.Point(186, 66)
        Me.txtB_rekeningnr.Name = "txtB_rekeningnr"
        Me.txtB_rekeningnr.Size = New System.Drawing.Size(152, 27)
        Me.txtB_rekeningnr.TabIndex = 17
        '
        'txtB_rente
        '
        Me.txtB_rente.Location = New System.Drawing.Point(186, 249)
        Me.txtB_rente.Name = "txtB_rente"
        Me.txtB_rente.Size = New System.Drawing.Size(58, 27)
        Me.txtB_rente.TabIndex = 19
        '
        'btn_login
        '
        Me.btn_login.Location = New System.Drawing.Point(673, 70)
        Me.btn_login.Name = "btn_login"
        Me.btn_login.Size = New System.Drawing.Size(94, 29)
        Me.btn_login.TabIndex = 20
        Me.btn_login.Text = "Login"
        Me.btn_login.UseVisualStyleBackColor = True
        '
        'txtB_naam
        '
        Me.txtB_naam.Location = New System.Drawing.Point(184, 108)
        Me.txtB_naam.Name = "txtB_naam"
        Me.txtB_naam.Size = New System.Drawing.Size(125, 27)
        Me.txtB_naam.TabIndex = 21
        '
        'txtB_voorn
        '
        Me.txtB_voorn.Location = New System.Drawing.Point(184, 144)
        Me.txtB_voorn.Name = "txtB_voorn"
        Me.txtB_voorn.Size = New System.Drawing.Size(125, 27)
        Me.txtB_voorn.TabIndex = 22
        '
        'txtB_geslacht
        '
        Me.txtB_geslacht.Location = New System.Drawing.Point(184, 186)
        Me.txtB_geslacht.Name = "txtB_geslacht"
        Me.txtB_geslacht.Size = New System.Drawing.Size(125, 27)
        Me.txtB_geslacht.TabIndex = 23
        '
        'ZIchtrekening
        '
        Me.ZIchtrekening.AutoSize = True
        Me.ZIchtrekening.Location = New System.Drawing.Point(341, 104)
        Me.ZIchtrekening.Name = "ZIchtrekening"
        Me.ZIchtrekening.Size = New System.Drawing.Size(99, 20)
        Me.ZIchtrekening.TabIndex = 24
        Me.ZIchtrekening.Text = "Zichtrekening"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(343, 136)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(104, 20)
        Me.Label1.TabIndex = 25
        Me.Label1.Text = "Spaarrekening"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(344, 73)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(50, 20)
        Me.Label2.TabIndex = 26
        Me.Label2.Text = "Valuta"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ZIchtrekening)
        Me.Controls.Add(Me.txtB_geslacht)
        Me.Controls.Add(Me.txtB_voorn)
        Me.Controls.Add(Me.txtB_naam)
        Me.Controls.Add(Me.btn_login)
        Me.Controls.Add(Me.txtB_rente)
        Me.Controls.Add(Me.txtB_rekeningnr)
        Me.Controls.Add(Me.btn_nummerverb)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.lbl_rente)
        Me.Controls.Add(Me.lbl_dagensparen)
        Me.Controls.Add(Me.btn_omzetten)
        Me.Controls.Add(Me.btn_Stort)
        Me.Controls.Add(Me.txtB_valuta)
        Me.Controls.Add(Me.txtB_spaarr)
        Me.Controls.Add(Me.txtB_zichtr)
        Me.Controls.Add(Me.lbl_rekeningsnummer)
        Me.Controls.Add(Me.lbl_Geslacht)
        Me.Controls.Add(Me.lbl_voorn)
        Me.Controls.Add(Me.lbl_naam)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbl_naam As Label
    Friend WithEvents lbl_voorn As Label
    Friend WithEvents lbl_Geslacht As Label
    Friend WithEvents lbl_rekeningsnummer As Label
    Friend WithEvents txtB_zichtr As TextBox
    Friend WithEvents txtB_spaarr As TextBox
    Friend WithEvents txtB_valuta As TextBox
    Friend WithEvents btn_Stort As Button
    Friend WithEvents btn_omzetten As Button
    Friend WithEvents lbl_dagensparen As Label
    Friend WithEvents lbl_rente As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents btn_nummerverb As Button
    Friend WithEvents txtB_rekeningnr As TextBox
    Friend WithEvents txtB_rente As TextBox
    Friend WithEvents btn_login As Button
    Friend WithEvents txtB_naam As TextBox
    Friend WithEvents txtB_voorn As TextBox
    Friend WithEvents txtB_geslacht As TextBox
    Friend WithEvents ZIchtrekening As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
End Class
