Public Class nomAll

    Private Sub nomAll_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        If chap1Noms.Text = "ߕߐ߯ߣߘߐߓߌߟߊ" Then
            chap1Noms.paragraphes()
        End If

    End Sub

    Private Sub exercices1Nom_Click(sender As Object, e As EventArgs) Handles exercices.Click
        kdohbohlida.Show()
        Me.Hide()
    End Sub

    Private Sub exoActiveCheckbox_CheckedChanged(sender As Object, e As EventArgs) Handles exoActive.CheckedChanged
        If exoActive.Checked = True Then
            exercices.Visible = True
            exoActive.ForeColor = Color.Black
            expNom1.ForeColor = Color.Gray
            Type1Noms.ForeColor = Color.DarkBlue
        ElseIf exoActive.Checked = False Then
            exercices.Visible = False
            exoActive.ForeColor = Color.Gray
            expNom1.ForeColor = Color.Black
            Type1Noms.ForeColor = Color.DarkGreen
        End If
    End Sub

 
End Class