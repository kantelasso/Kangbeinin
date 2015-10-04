Public Class Nom2fdobatoh2

    Private Sub Nom3page12_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles Nom3page12.LinkClicked
        chap1Noms.Text = "ߕߐ߯ߣߘߐߓߌߟߊ"
        Nom2fdobatoh.Show()
        Me.Close()
    End Sub

    Private Sub exercices_Click(sender As Object, e As EventArgs) Handles exercices.Click
        kdohbohlida.test0.Text = "test2"
        kdohbohlida.Show()
        Me.Close()
    End Sub

    Private Sub exoActive_CheckedChanged(sender As Object, e As EventArgs) Handles exoActive.CheckedChanged
        If exoActive.Checked = True Then
            exercices.Visible = True
            expNom1.ForeColor = Color.Gray
        ElseIf exoActive.Checked = False Then
            exercices.Visible = False
            expNom1.ForeColor = Color.Black
        End If
    End Sub
End Class