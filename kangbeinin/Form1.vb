Public Class Form1

    Public Nom As String
    Public Prenom As String

    Public Sub accueilIntro()
        gnafoda.Text = "ߞߊ߲ߜߍ߲ߣߍ߲ ߦߋ߫ ߞߊ߲ߜߍ ߢߊߝߐ߫ ߛߎ߲ߝߘߍߣߍ߲ ߘߏ߫ ߟߋ߬ ߘߌ߫߸ ߊ߬ ߦߋ߫ ߞߊ߲ߜߍ ߞߎߡߊߘߋ߲ ߠߎ߬ ߓߍ߯ ߟߋ߬ ߢߊߝߐ߫ ߟߊ߫ ߊ߬ߟߎ߬ ߞߏ߫ ߟߊ߫ ߞߴߊ߬ߟߎ߬ ߟߊߒߡߊ ߘߏ߫ ߟߎ߫ ߘߌ߫߸" _
            & " ߞߵߊ߬ ߓߊ߲߫ ߞߵߊߟߎ߫ ߢߌ߬ߣߌ߲߬ߞߊ߬ ߟߊߒߡߊ ߘߏ߫ ߟߎ߫ ߛߓߍ ߟߊ߫߸ ߣߴߊߟߎ߫ ߛߋ߫ ߘߊ߫ ߏ߬ ߟߎ߬ ߛߓߍ߫ ߟߊ߫ ߞߵߏ߬ ߟߊ߫ ߞߘߐߓߐߟߌ߫ ߜߘߍ߫ ߟߎ߫ ߞߊ߲߬߸ ߊ߬ ߖߍ߬ߘߍ ߦߋ߫ ߏ߬ ߟߎ߬ ߟߊߜߍ߫ ߞߎߡߊߘߋ߲ ߠߎ߬ ߓߍ߯ ߘߐ߫" _
            & " ߛߌߦߊߡߊ߲߫ ߞߍߣߍ߲߫ ߣߴߊߟߎ߫ ߓߟߏ߫ ߞߊ߲ߜߍ ߘߐ߫ ߏ߬ ߘߌ߫. ߊ߬ ߕߐ߭ ߕߍ߫ ߝߏߛߌ߬ ߘߌ߫ ߏ߬ ߞߐ߫ ߣߌ߫ ߖߘߍ߬ߟߊ߬ߞߐ߮ ߕߍ߫. ߊ߬ ߛߐ߲߬ߞߌ߲߬ ߞߎߡߊߘߋ߲ ߠߎ߬ ߞߊ߲߬ ߞߌߣߌ߲ ߝߍ߬ ߞߵߊ߬ ߘߊߡߌ߬ߣߊ߬."
        slado.Text = "ߒߞߏ ߞߊ߲ߜߍ"
        liensDirecte.Visible = False
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        accueilIntro()
        If My.Settings.Connexion = False Then
            chap1Noms.ConnectEtat.Text = "ߌ ߜߊ߲߬ߞߎ߲߬"
        ElseIf My.Settings.Connexion = True Then
            chap1Noms.ConnectEtat.Text = My.Settings.Nom & " " & My.Settings.Prenom
        End If
    End Sub

    Private Sub atoo_Click(sender As Object, e As EventArgs) Handles atoo.Click
        gnafoda.Text = "ߕߐ߮ ߦߋ߫ ߞߎߡߊߘߋ߲ ߠߋ߬ ߘߌ߫ ߡߍ߲ ߦߋ߫ ߟߊ߬ߞߋ߲߬ߛߎ߬ߟߌ ߞߍ ߟߊ߫߸ ߞߊ߬ ߝߋ߲ ߕߏ߫ ߊ߬ ߞߋߟߋ߲߫ ߠߊ߫ ߞߊ߬ߣߌ߲߬߸ ߖߡߊ߬ߦߊ ߘߐ߫ ߥߟߊ߫ ߞߋ߲ߟߋ߲߬ߧߊ ߘߐ߫߸" _
            & " ߏ߬ ߟߋ߫ ߣߊ߬ ߊ߬ ߞߍ߫ ߟߊ߫ ߛߎ߮ ߝߌ߬ߟߊ߬ ߘߌ߫: ߝߘߏ߬ߓߊ߬ߕߐ߮ ߣߌ߫ ߞߋ߬ߟߋ߲߬ߠߊ߬ߕߐ߮.ߝߘߏ߬ߓߊ߬ߕߐ߮ ߏ߬ ߦߋ߫ ߝߋ߲߫ ߛߎ߯ ߞߋߟߋ߲ ߓߍ߯ ߟߋ߬ ߕߐ߯ ߘߌ߫ ߦߏ߫ ߡߐ߱߸ߘߎ߱߸ ߓߊ߸ " _
            & "ߞߋ߬ߟߋ߲߬ߠߊ߬ߕߐ߮ ߦߋ߫ ߝߋ߲߫ ߞߋߟߋ߲ ߠߋ߬ ߕߐ߮ ߘߌ߫ ߞߵߊ߬ ߓߐ߫ ߝߋ߲ ߕߐ߭ ߓߍ߯ ߡߊ߬߸ ߤߊߟߌ߫ ߊ߬ ߛߎ߯ ߞߋߟߋ߲ߢߐ߲߮ ߠߎ߬ ߦߏ߫ ߕߊ߲߬: ߛߟߏ߬ߡߣߊ߬߸ ߞߊ߲ߞߊ߲߫߸ ߖߋ߬ߟߌߓߊ߬."
        slado.Text = atoo.Text
        liensDirecte.Visible = True
        afficheAccueil.Stop()
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles liensDirecte.Click
        chap1Noms.Show()
        Me.WindowState = FormWindowState.Minimized

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click
        gbankounda.Show()
    End Sub

    Private Sub toondobila_Click(sender As Object, e As EventArgs) Handles toondobila.Click
        'veut basculer ds le chap 2
        chap1Noms.chapitre.Text = "chapitre2"
        gnafoda.Text = "ߕߐ߯ߣߘߐߓߌߟߊ ߦߋ߫ ߞߎߡߊߘߋ߲ ߠߋ߬ ߘߌ߫ ߡߍ߲ ߦߋ߫ ߓߌ߬ߟߊ߬ ߟߊ߫ ߞߎߡߊߕߌ߮ ߛߊ߬ߓߊ ߕߐ߮ ߣߐ߭ ߘߐ߫߸ " _
            & "ߊ߬ ߦߋ߫ ߟߊߥߟߌ߬ ߟߊ߫ ߕߐ߮ ߡߊߛߋ߬ߦߌ ߢߍߛߌߟߊߢߍ ߟߋ߫ ߡߊ߬ ߞߎߡߦߊ ߘߐ߫. ߊ߬ߟߎ߬ ߦߋ߫ ߛߌ߱ ߝߌ߬ߟߊ߫ ߟߋ߬ ߘߌ߫:ߕߎ߲߬ߕߊ ߣߌ߫ ߕߎ߲߬ߓߊߟߌ. " _
            & "ߞߎߡߊ߫ ߜߘߍ߫ ߟߋ߫ ߕߎ߲߬ ߠߊ߫ ߕߎ߲߬ߕߊ ߟߊ߫ ߛߊ߫ ߊ߬ ߞߘߐ ߘߌ߫ ߢߊߦߋ߫. ߕߎ߲߬ߓߊߟߌ ߡߊ߬ߞߏ߬ߕߍ߫ ߞߎߡߊ߫ ߜߘߍ߫ ߟߊ߫ ߊ߬ ߞߘߐ ߢߊߦߋ ߘߐ߫. " _
            & vbNewLine & "ߊ߬ߟߎ߬ ߝߟߍ߫ ߣߌ߲߬: ߒ߸ ߌ߸ ߊ߬߸ ߊ߲߸ ߊߟߎ߫߸ ߊ߬ߟߎ߬ (ߕߎ߲߬ߕߊ ߟߎ߬) ߒߠߋ߸ ߌߟߋ߸ ߊ߬ߟߋ߸ ߊ߲ߠߎ߬߸ ߊߟߎ߸ ߊ߬ߟߎ (ߕߎ߲߬ߓߊߟߌ ߟߎ߬). "
        slado.Text = toondobila.Text
        liensDirecte.Visible = True
        afficheAccueil.Stop()
    End Sub

    'cette fonction signale que les chapitres inachevés sont indisponibles
    'affiche l'accueil après 10 secondes
    Public Sub pasFini(chap)
        slado.Text = chap.Text
        gnafoda.Text = "ߦߙߐ ߣߌ߲߬ ߡߊ߫ ߓߊ߲߫ ߝߟߐ߫߸ " & vbNewLine & "ߕߌ߲ߞߌ߫ ߊ߲ ߢߍ߫ ߊ߬ ߓߊ߯ߙߊ ߣߐ߰ߦߊ ߟߊ߫. "
        liensDirecte.Visible = False
        afficheAccueil.Stop()
        afficheAccueil.Start()
    End Sub

    Private Sub manktu_Click(sender As Object, e As EventArgs) Handles manktu.Click
        pasFini(manktu)
    End Sub

    Private Sub bsolan_Click(sender As Object, e As EventArgs) Handles bsolan.Click
        pasFini(bsolan)
    End Sub

    Private Sub kumasbo_Click(sender As Object, e As EventArgs) Handles kumasbo.Click
        pasFini(kumasbo)
    End Sub

    Private Sub kunkudun_Click(sender As Object, e As EventArgs) Handles kunkudun.Click
        pasFini(kunkudun)
    End Sub

    Private Sub kahla_Click(sender As Object, e As EventArgs) Handles kahla.Click
        pasFini(kahla)
    End Sub

    Private Sub dognininkali_Click(sender As Object, e As EventArgs) Handles dognininkali.Click
        pasFini(dognininkali)
    End Sub

    Private Sub dogbeiyali_Click(sender As Object, e As EventArgs) Handles dogbeiyali.Click
        pasFini(dogbeiyali)
    End Sub

    Private Sub kanto_Click(sender As Object, e As EventArgs) Handles kanto.Click
        pasFini(kanto)
    End Sub

    Private Sub afficheAccueil_Tick(sender As Object, e As EventArgs) Handles afficheAccueil.Tick
        accueilIntro()
    End Sub
End Class
