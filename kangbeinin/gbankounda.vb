Public Class gbankounda

    Dim kamafanein(3, 4) As String
    Dim kanabranein(3, 4) As String
    Dim kamaylei(3, 4) As String
    Dim kamadjii(3, 4) As String
    Dim kamasre(3, 8) As String

    Public Sub chActive(noui)

        chNom.Enabled = noui
        chPrenom.Enabled = noui
        chDjamoun.Enabled = noui
        chVille.Enabled = noui
        chMere.Enabled = noui
        chAnnee_kgb.Enabled = noui
        chAnnee_jc.Enabled = noui
        Homme.Enabled = noui
        Madamme.Enabled = noui
        Mademoiselle.Enabled = noui

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles reconnect.Click
        chActive(True)
        connetYou.Enabled = True
    End Sub

    Private Sub gbankounda_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        If My.Settings.Connexion = True Then
            expConnexion.Text = " ߌ ߣߌ߫ ߕߎ߬ߡߊ߬߸ " & My.Settings.Genre & " " & My.Settings.Nom & " " & My.Settings.Prenom & _
                "߸ ߌ ߓߘߊ߫ ߌ ߜߊ߲߬ߞߎ߲߬ ߞߊ߲ߜߍߣߍ߲ ߠߊ߫ ߘߎ߰ߟߊ߬ ߟߌߤߟߊ ߡߍ߲߬ ߠߎ߬ ߘߌ߫߸ ߌ ߘߌ߫ ߛߋ߫ ߊ߬ߟߎ߬ ߡߊߦߟߍ߬ߡߊ߲߬ ߠߊ߫. ߣߴߌ ߦߴߏ߬ ߝߍ߬߸ ߊ߬ ߛߐ߲߬ߞߌ߲߫ ߊ߬ 'ߒ ߠߊ߫ ߟߌ߬ߤߟߊ߫ ߟߎ߬ ߡߊߝߊ߬ߟߋ߲߬.' ߞߊ߲߬ ߘߎ߰ߟߊ߬." & _
                vbNewLine & " ߌ " & My.Settings.Djamoun & " ߹"

            chNom.Text = My.Settings.Nom
            chPrenom.Text = My.Settings.Prenom
            chDjamoun.Text = My.Settings.Djamoun
            chVille.Text = My.Settings.ville
            chMere.Text = My.Settings.Mere
            chAnnee_kgb.Text = My.Settings.AnneeNaissance

            If My.Settings.Genre = "ߛߟߊߕߌ߯" Then
                Homme.Checked = True

            ElseIf My.Settings.Genre = "ߓߐ߬ߟߐ߲߬ߞߊ߫" Then
                Madamme.Checked = True

            ElseIf My.Settings.Genre = "ߖߏߞߊ߲߫" Then
                Mademoiselle.Checked = True

            End If

            chActive(False)
            connetYou.Enabled = False

            connetYou.Enabled = False
            Homme.Enabled = False
            Madamme.Enabled = False
            Mademoiselle.Enabled = False

        ElseIf My.Settings.Connexion = False Then
            expConnexion.Text = "ߣߴߌ ߞߵߌ ߜߊ߲߬ߞߎ߲߬ ߞߊ߲ߜߍߣߍ߲ ߠߊ߫߸ ߊ߬ ߘߌ߫ ߕߐ߮ ߦߌ߬ߘߊ߬ ߊ߬ ߞߐߜߍ߫ ߝߊ߲߬ߓߊ߮ ߓߍ߯ ߞߊ߲߬ .ߞߘߐߓߐߟߌ ߟߎ߬ ߓߊ߯ ߞߍ߫߸" & _
                " ߊ߬ ߘߌ߫ ߛߋ߫ ߌ ߕߐ߮ ߓߌ߬ߟߊ߬ ߟߊ߫ ߡߊ߬ߕߐ߰ߟߌ߬ ߦߙߐ ߟߎ߬ ߘߐ߫߸ ߣߴߌ ߞߵߌ ߘߐߖߊ߬. ߣߴߌ ߡߴߌ ߘߐߖߊ߬ ߛߊ߫߸ ߊ߬ ߘߌ߫ ߞߍ߫ ߌ ߛߊ߬ߣߊ߲߬ߞߎ߲ ߘߌ߫߸" & _
                " ߞߵߌ ߡߊߢߊ߰ ߌߞߘߐ߫ (ߏ߬ ߞߍߣߍ߲߫ ߠߋ߬ ߓߊ ߛߊ߬ߣߊ߲߬ߞߎ߲߬ߧߊ ߦߋ߫ ߡߊ߲߬ߘߋ߲߬ ߞߏ߫ ߞߘߐߓߊ ߟߋ߬ ߘߌ߫ ߡߍ߲ ߦߋ߫ ߡߐ߱ ߖߎ߬ߛߎ߫ ߟߐ߬ ߟߊ߫ ߞߏ ߜߍߟߍ߲ ߠߎ߬ ߞߵߌ ߞߟߊߓߎߦߊ߫)."
            chActive(True)
            connetYou.Enabled = True

            If chap1Noms.ConnectEtat.Text = "ߌ ߜߊ߲߬ߞߎ߲߬" Then
                reconnect.Visible = False
            ElseIf chap1Noms.ConnectEtat.Text = My.Settings.Nom & " " & My.Settings.Prenom Then
                reconnect.Visible = True
            End If

        End If

    End Sub

    Dim djambdei As String

    Private Sub exercices_Click(sender As Object, e As EventArgs) Handles connetYou.Click
        Dim chErrormessage As String = ""
        If etoile1.ForeColor = Color.Red Or etoile2.ForeColor = Color.Red Or etoile3.ForeColor = Color.Red Or etoile4.ForeColor = Color.Red _
             Or etoile6.ForeColor = Color.Red Then

            erreurDonnees.Visible = True
            erreurDonnees.ForeColor = Color.DarkRed
            If etoile1.ForeColor = Color.Red And etoile2.ForeColor = Color.Red And etoile3.ForeColor = Color.Red And _
                etoile4.ForeColor = Color.Red And etoile6.ForeColor = Color.Red Then
                chNom.Focus()
                chErrormessage = "ߕߐ߮ ߣߴߌ ߛߌ߫ ߣߴߌ ߖߊ߬ߡߎ߲"
            ElseIf etoile1.ForeColor = Color.Red Then
                chNom.Focus()
                chErrormessage = "ߕߐ߮"
            ElseIf etoile2.ForeColor = Color.Red Then
                chPrenom.Focus()
                chErrormessage = "ߛߌ"
            ElseIf etoile3.ForeColor = Color.Red Then
                chDjamoun.Focus()
                chErrormessage = "ߖߊ߬ߡߎ߲"
            ElseIf etoile4.ForeColor = Color.Red Then
                chVille.Focus()
                chErrormessage = "ߛߐ߬ߘߐ߲߬ ߛߏ"
            ElseIf etoile6.ForeColor = Color.Red Then
                chMere.Focus()
                chErrormessage = "ߣߊ߫ ߕߐ߮"
            End If

            My.Settings.Connexion = True
            expConnexion.Text = "ߖߊ߲߬ߕߏߒߘߐ: ߡߊ߲߬ߘߋ߲߬ ߕߐ߮ ߣߴߊ߬ ߛߌ ߣߴߊ߬ ߖߊ߬ߡߎ߲ ߠߎ߬ ߓߍ߯ ߦߋ߫ ߟߊߓߊ߲߫ ߠߊ߫ ߞߊ߲ߠߊߓߙߊ߬ߣߍ߲ ߠߋ߫ ߡߊ߬߸" & vbNewLine & " ߒ߬ߓߊ߬ ߌ " & chErrormessage & " ߛߊߞߍ߫"
            expConnexion.ForeColor = Color.Red
        Else
            erreurDonnees.Visible = False

            If Homme.Checked = True Then
                djambdei = "ߛߟߊߕߌ߯"

            ElseIf Madamme.Checked = True Then
                djambdei = "ߓߐ߬ߟߐ߲߬ߞߊ߫"

            ElseIf Mademoiselle.Checked = True Then
                djambdei = "ߖߏߞߊ߲߫"
            Else
                djambdei = ""
            End If

            expConnexion.ForeColor = Color.Blue

            expConnexion.Text = "ߌ ߣߌ߫ ߛߣߍ߫ " & djambdei & " " & chNom.Text & " " & chPrenom.Text & " ߞߊ߬ ߓߐ߫ " & chVille.Text _
                & "߸ ߌ ߘߌ߫ ߛߋ߫ ߕߊ߯ ߟߊ߫ ߞߊߙߊ߲ ߡߊ߬ ߛߍߣߍ߲߬ ߝߛߊߦߌ߫߹" & vbNewLine & "ߌ ߣߌ߫ ߞߊ߬ߙߊ߲߬ ߞߏ߬ ߢߌ߬ߡߊ߬."

            'Alouer les infos personnelles du joueur à la variable tableau InfoPersJoueur()
            chActive(False)
            My.Settings.Connexion = True
            My.Settings.Nom = chNom.Text
            My.Settings.Prenom = chPrenom.Text
            My.Settings.Djamoun = chDjamoun.Text
            My.Settings.ville = chVille.Text
            My.Settings.Mere = chMere.Text
            My.Settings.AnneeNaissance = chAnnee_kgb.Text
            My.Settings.Genre = djambdei
            reconnect.Visible = False
            connetYou.Enabled = False
            Homme.Enabled = False
            Madamme.Enabled = False
            Mademoiselle.Enabled = False

        End If

    End Sub

    Public infoOK As String

    Public InfoPersJoueur(3) As String

    Dim chNko(10) As String
    Dim temp1 = 0

    Public Sub retroConvect(champs)
        chNko = {"߀", "߁", "߂", "߃", "߄", "߅", "߆", "߇", "߈", "߉"}

        For i = 0 To 9
            champs.Contains(chNko(i))
            champs = champs.Replace(chNko(i), i)
        Next

    End Sub

    'cette partie permet de convertir les annees
    Public Sub convertDate(champs)
        chNko = {"߀", "߁", "߂", "߃", "߄", "߅", "߆", "߇", "߈", "߉"}

        If champs.Text.Length > 0 Then
            For i = 0 To 9
                champs.Text.Contains(i)
                champs.Text = champs.Text.Replace(i, chNko(i))
            Next

            'reconverit l'annee du KroukaFouwa à Jesus Christ
            'retroConvect(temp1)
           
        End If
    End Sub

    Public Sub verifInfo(champs, etoil)
        'cette partie permet d'enlever les espaces avant et après
        champs.Text.TrimStart(" ")
        champs.Text.TrimEnd(" ")

        ' on test dans cette partie si les champs sont terminés par un accent paisible ou non
        If champs.Text.Length <= 0 Then
            etoil.ForeColor = Color.Red
            etoil.Visible = True

        Else
            If champs.Text.EndsWith("߮") Or champs.Text.EndsWith("߭") Or champs.Text.EndsWith("߱") Or champs.Text.EndsWith("߲߭") Or champs.Text.EndsWith("߲߱") _
                Or champs.Text.EndsWith("߲߮") Or champs.Text.EndsWith("߲߭") Or champs.Text.EndsWith("߲߱") Or champs.Text.EndsWith("߲߭") Or champs.Text.EndsWith("߲߱") _
                Or champs.Text.EndsWith("ߊ߲") Or champs.Text.EndsWith("ߋ߲") Or champs.Text.EndsWith("ߌ߲") Or champs.Text.EndsWith("ߍ߲") Or champs.Text.EndsWith("ߎ߲") Or champs.Text.EndsWith("ߏ߲") Or champs.Text.EndsWith("ߐ߲") _
                Or champs.Text.EndsWith("ߊ") Or champs.Text.EndsWith("ߋ") Or champs.Text.EndsWith("ߌ") Or champs.Text.EndsWith("ߍ") Or champs.Text.EndsWith("ߎ") Or champs.Text.EndsWith("ߏ") Or champs.Text.EndsWith("ߐ") Then

                etoil.ForeColor = Color.Red
                etoil.Visible = True

            ElseIf champs.Text.EndsWith("߫") Or champs.Text.EndsWith("߬") Or champs.Text.EndsWith("߯") Or champs.Text.EndsWith("߰") Or champs.Text.EndsWith("߲߫") Or champs.Text.EndsWith("߲߬") Or champs.Text.EndsWith("߲߯") Or champs.Text.EndsWith("߲߰") _
                Or champs.Text.EndsWith("߲߫") Or champs.Text.EndsWith("߲߬") Or champs.Text.EndsWith("߲߯") Or champs.Text.EndsWith("߲߰") Then

                etoil.ForeColor = Color.Green
                etoil.Visible = True
            End If
        End If

    End Sub

    Private Sub chNom_Validated(sender As Object, e As EventArgs) Handles chNom.Validated

        'chNom.Text.TrimEnd(" ")
        verifInfo(chNom, etoile1)
    End Sub

    Private Sub chPrenom_Validated(sender As Object, e As EventArgs) Handles chPrenom.Validated
        verifInfo(chPrenom, etoile2)
    End Sub

    Private Sub chDjamoun_Validated(sender As Object, e As EventArgs) Handles chDjamoun.Validated
        verifInfo(chDjamoun, etoile3)
    End Sub

    Private Sub chVille_Validated(sender As Object, e As EventArgs) Handles chVille.Validated
        verifInfo(chVille, etoile4)
    End Sub

    Private Sub chMere_Validated(sender As Object, e As EventArgs) Handles chMere.Validated
        verifInfo(chMere, etoile6)
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles Homme.CheckedChanged
        If Homme.Checked = True Then
            Homme.ForeColor = Color.Green
            Madamme.Enabled = False
            Mademoiselle.Enabled = False

        Else
            Homme.Enabled = True
            Madamme.Enabled = True
            Mademoiselle.Enabled = True

            Homme.ForeColor = Color.Black
            Madamme.ForeColor = Color.Black
            Mademoiselle.ForeColor = Color.Black

        End If
    End Sub

    Private Sub Madamme_CheckedChanged(sender As Object, e As EventArgs) Handles Madamme.CheckedChanged
        If Madamme.Checked = True Then
            Madamme.ForeColor = Color.Green
            Homme.Enabled = False
            Mademoiselle.Enabled = False

        Else
            Homme.Enabled = True
            Madamme.Enabled = True
            Mademoiselle.Enabled = True

            Homme.ForeColor = Color.Black
            Madamme.ForeColor = Color.Black
            Mademoiselle.ForeColor = Color.Black
        End If

    End Sub

    Private Sub Mademoiselle_CheckedChanged(sender As Object, e As EventArgs) Handles Mademoiselle.CheckedChanged
        If Mademoiselle.Checked = True Then
            Mademoiselle.ForeColor = Color.Green
            Homme.Enabled = False
            Madamme.Enabled = False
        Else
            Homme.Enabled = True
            Madamme.Enabled = True
            Mademoiselle.Enabled = True

            Homme.ForeColor = Color.Black
            Madamme.ForeColor = Color.Black
            Mademoiselle.ForeColor = Color.Black
        End If
    End Sub

    Private Sub chAnnee_kgb_Validated(sender As Object, e As EventArgs) Handles chAnnee_kgb.Validated
        temp1 = chAnnee_kgb.Text
        chAnnee_jc.Text = Int32.Parse(temp1) + 1235
        chAnnee_jc.Enabled = False
        convertDate(chAnnee_kgb)

    End Sub

    Private Sub chAnnee_jc_Validated(sender As Object, e As EventArgs) Handles chAnnee_jc.Validated

        chAnnee_kgb.Text = Int32.Parse(chAnnee_jc.Text) - 1235
        convertDate(chAnnee_kgb)
    End Sub

End Class

