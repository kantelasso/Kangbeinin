Public Class Nom1klenatoh

    Private Sub Nom1klenatoh_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If chap1Noms.Text = "ߕߐ߯ߣߘߐߓߌߟߊ" Then
            chap1Noms.chap2()
            chap1Noms.paragraphes()

        End If
    End Sub

    Private Sub comprisNom1_CheckedChanged(sender As Object, e As EventArgs) Handles exoActive.CheckedChanged
        If exoActive.Checked = True Then
            exercices.Visible = True
            expNom1.ForeColor = Color.Gray
        ElseIf exoActive.Checked = False Then
            exercices.Visible = False
            expNom1.ForeColor = Color.Black
        End If

    End Sub

    Private Sub exercices2Nom_Click(sender As Object, e As EventArgs) Handles exercices.Click

        kdohbohlida.test0.Text = "test1"
        kdohbohlida.Show()
        Me.Close()

    End Sub

   
End Class