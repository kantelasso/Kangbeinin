Public Class kdohbohli

    Private Sub CheckBox5_CheckedChanged(sender As Object, e As EventArgs) Handles presACorrigerCheckBox.CheckedChanged
        If presACorrigerCheckBox.Checked = True Then
            questionsGroupBox1.ForeColor = Color.Gray
            presACorrigerCheckBox.ForeColor = Color.Black
            corriger.Visible = True
        ElseIf presACorrigerCheckBox.Checked = False Then
            questionsGroupBox1.ForeColor = Color.Black
            presACorrigerCheckBox.ForeColor = Color.Gray
            corriger.Visible = False
        End If
    End Sub

    ' la variable qui permet de stocker la note du joueur
    Dim noteControlNom1 As Integer = 0
    Dim noteEnNqo As String

    Private Sub corriger_Click(sender As Object, e As EventArgs) Handles corriger.Click
        presACorrigerCheckBox.Enabled = False
        'questionsGroupBox1.Enabled = False
        questionsGroupBox1.ForeColor = Color.Gray

        'Ce control permet d'évaluer les choix, il donne finalement la note trouvée
        If qNIntro1.Checked = False Then
            noteControlNom1 = noteControlNom1 + 1
            rNIntro1.ForeColor = Color.Green
        ElseIf qNIntro1.Checked = True Then
            noteControlNom1 = noteControlNom1 - 1
        End If

        If qNIntro2.Checked = False Then
            noteControlNom1 = noteControlNom1 - 1
        ElseIf qNIntro2.Checked = True Then
            noteControlNom1 = noteControlNom1 + 1
            rNIntro2.ForeColor = Color.Green
        End If

        If qNIntro3.Checked = False Then
            noteControlNom1 = noteControlNom1 + 1
            rNIntro3.ForeColor = Color.Green
        ElseIf qNIntro3.Checked = True Then
            noteControlNom1 = noteControlNom1 - 1
        End If

        If qNIntro4.Checked = False Then
            noteControlNom1 = noteControlNom1 - 1
        ElseIf qNIntro4.Checked = True Then
            noteControlNom1 = noteControlNom1 + 1
            rNIntro4.ForeColor = Color.Green
        End If

        If qNIntro5.Checked = False Then
            noteControlNom1 = noteControlNom1 - 1
        ElseIf qNIntro5.Checked = True Then
            noteControlNom1 = noteControlNom1 + 1
            rNIntro5.ForeColor = Color.Green
        End If

        If qNIntro6.Checked = False Then
            noteControlNom1 = noteControlNom1 - 1
        ElseIf qNIntro6.Checked = True Then
            noteControlNom1 = noteControlNom1 + 1
            rNIntro6.ForeColor = Color.Green
        End If

        If qNIntro7.Checked = False Then
            noteControlNom1 = noteControlNom1 + 1
            rNIntro7.ForeColor = Color.Green
        ElseIf qNIntro7.Checked = True Then
            noteControlNom1 = noteControlNom1 - 1
        End If

        If qNIntro8.Checked = False Then
            noteControlNom1 = noteControlNom1 - 1
        ElseIf qNIntro8.Checked = True Then
            noteControlNom1 = noteControlNom1 + 1
            rNIntro8.ForeColor = Color.Green
        End If

        If qNIntro9.Checked = False Then
            noteControlNom1 = noteControlNom1 + 1
            rNIntro9.ForeColor = Color.Green
        ElseIf qNIntro9.Checked = True Then
            noteControlNom1 = noteControlNom1 - 1
        End If

        If qNIntro10.Checked = False Then
            noteControlNom1 = noteControlNom1 + 1
            rNIntro10.ForeColor = Color.Green 
        ElseIf qNIntro10.Checked = True Then
            noteControlNom1 = noteControlNom1 - 1
        End If

        ' La partie qualificative 
        If noteControlNom1 < 0 Then
            exo1PreInfo.Text = "ߋ߯ ߓߐ ߡߊ߫ ߘߌߦߊ߫ ߛߊ߭ ߟߊ߫߸ ߞߙߊ߬ߡߐ߰ ߟߊ߫ ߖߎ߬ߟߎ ߟߋ߫ ߖߍ߬ߘߍ ߌ ߟߊ߫."
            exo1PreInfo.ForeColor = Color.Red
        ElseIf noteControlNom1 = 0 Then
            exo1PreInfo.Text = "ߋߜߋ߫߸ ߤߊߟߌ߬ ߁ ߌ ߡߊ߫ ߊ߬ ߛߐ߬ߘߐ߲߬."
            exo1PreInfo.ForeColor = Color.Red
        ElseIf noteControlNom1 > 0 And noteControlNom1 < 5 Then
            exo1PreInfo.Text = "ߤߌ߯ ߞߙߊ߬ߡߐ߰߸ ߊ߬ ߡߊ߫ ߓߍ߲߬ ߝߋߎ߫. ߕߐ߮ ߟߎ߬ ߡߊߛߊ߬ߦߌ߬ ߌߞߐ߫."
            exo1PreInfo.ForeColor = Color.DarkOrange
        ElseIf noteControlNom1 >= 5 Then
            exo1PreInfo.Text = "ߌ ߓߘߊ߫ ߌ ߘߐߖߊ߬߸ ߘߏ߫ ߟߊ߫ ߌ ߘߐ߲߬ ߛߋ߲ ߞߊ߲߬"
            exo1PreInfo.ForeColor = Color.Purple
            If noteControlNom1 >= 8 Then
                exo1PreInfo.Text = "ߌ ߣߌ߫ ߞߏ߲߫߸ ߌ ߘߊ߲߬ߛߐ߰߹"
                exo1PreInfo.ForeColor = Color.Blue
                If noteControlNom1 = 10 Then
                    exo1PreInfo.Text = "ߕߋߚߋ߫ ߕߋߞߎ߫߸ ߞߙߊ߬ߡߐ߰ ߝߏ߬ߟߌ ߌ ߢߍ߫."
                    exo1PreInfo.ForeColor = Color.DarkGreen
                End If
            End If

        End If
            convertNoteToNqo()
            afficheNote1nom.Visible = True
            infoNote.Visible = True
            corriger.Enabled = False
            afficheNote1nom.Text = afficheNote1nom.Text & "\߁߀"
            afficheFautes()
    End Sub

    'Cette fonction permet de convertir la note trouvée en NKO
    Public Function convertNoteToNqo()
        noteEnNqo = noteControlNom1.ToString
        If noteEnNqo = 0 Then
            afficheNote1nom.Text = "߀"
        ElseIf noteEnNqo = 1 Then
            afficheNote1nom.Text = "߁"
        ElseIf noteEnNqo = 2 Then
            afficheNote1nom.Text = "߂"
        ElseIf noteEnNqo = 3 Then
            afficheNote1nom.Text = "߃"
        ElseIf noteEnNqo = 4 Then
            afficheNote1nom.Text = "߄"
        ElseIf noteEnNqo = 5 Then
            afficheNote1nom.Text = "߅"
        ElseIf noteEnNqo = 6 Then
            afficheNote1nom.Text = "߆"
        ElseIf noteEnNqo = 7 Then
            afficheNote1nom.Text = "߇"
        ElseIf noteEnNqo = 8 Then
            afficheNote1nom.Text = "߈"
        ElseIf noteEnNqo = 9 Then
            afficheNote1nom.Text = "߉"
        ElseIf noteEnNqo = 10 Then
            afficheNote1nom.Text = "߁߀"

        ElseIf noteEnNqo = -1 Then
            afficheNote1nom.Text = "-߁"
        ElseIf noteEnNqo = -2 Then
            afficheNote1nom.Text = "-߂"
        ElseIf noteEnNqo = -3 Then
            afficheNote1nom.Text = "-߃"
        ElseIf noteEnNqo = -4 Then
            afficheNote1nom.Text = "-߄"
        ElseIf noteEnNqo = -5 Then
            afficheNote1nom.Text = "-߅"
        ElseIf noteEnNqo = -6 Then
            afficheNote1nom.Text = "-߆"
        ElseIf noteEnNqo = -7 Then
            afficheNote1nom.Text = "-߇"
        ElseIf noteEnNqo = -8 Then
            afficheNote1nom.Text = "-߈"
        ElseIf noteEnNqo = -9 Then
            afficheNote1nom.Text = "-߉"
        ElseIf noteEnNqo = -10 Then
            afficheNote1nom.Text = "-߁߀"
        End If

    End Function

    Public Function afficheFautes()
        rNIntro1.Visible = True
        rNIntro1.Enabled = True
        rNIntro2.Visible = True
        rNIntro2.Enabled = True
        rNIntro3.Visible = True
        rNIntro3.Enabled = True
        rNIntro4.Visible = True
        rNIntro4.Enabled = True
        rNIntro5.Visible = True
        rNIntro5.Enabled = True
        rNIntro6.Visible = True
        rNIntro6.Enabled = True
        rNIntro7.Visible = True
        rNIntro7.Enabled = True
        rNIntro8.Visible = True
        rNIntro8.Enabled = True
        rNIntro9.Visible = True
        rNIntro9.Enabled = True
        rNIntro10.Visible = True
        rNIntro10.Enabled = True
    End Function

    Private Sub pasPresEncore_CheckedChanged(sender As Object, e As EventArgs) Handles pasPresEncore.CheckedChanged
        If pasPresEncore.Checked = True Then
            Me.Close()
            nomAll.Show()
            nomAll.exoActive.Checked = False
            nomAll.exercices.Visible = False
        End If
    End Sub

    Private Sub exo1PreInfo_Click(sender As Object, e As EventArgs) Handles exo1PreInfo.Click

    End Sub
End Class