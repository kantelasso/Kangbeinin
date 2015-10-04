Public Class Nom3deima1

    Private Sub Nom3deima1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If chap1Noms.Text = "ߕߐ߯ߣߘߐߓߌߟߊ" Then
            chap1Noms.chap2()
            chap1Noms.paragraphes()

        End If
    End Sub

    Private Sub Nom3page12_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles Nom3page12.LinkClicked
        Nom3deima2.Show()
        Me.Close()
    End Sub


    Private Sub exoActive_CheckedChanged(sender As Object, e As EventArgs) Handles exoActive.CheckedChanged
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

    Private Sub exercices_Click(sender As Object, e As EventArgs) Handles exercices.Click
        kdohbohlida.test0.Text = "test3"
        kdohbohlida.Show()
        Me.Close()
    End Sub
End Class