Public Class Nom2fdobatoh

    Private Sub Nom2fdobatoh_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If chap1Noms.Text = "ߕߐ߯ߣߘߐߓߌߟߊ" Then
            chap1Noms.chap2()
            chap1Noms.paragraphes()

        End If
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

    Private Sub exercices_Click(sender As Object, e As EventArgs) Handles exercices.Click
        kdohbohlida.test0.Text = "test2"
        kdohbohlida.Show()
        Me.Close()
    End Sub

    Private Sub Nom3page12_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles Nom3page12.LinkClicked
        Nom2fdobatoh2.Show()
        Me.Close()
    End Sub
End Class