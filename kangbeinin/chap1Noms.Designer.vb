<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class chap1Noms
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(chap1Noms))
        Me.parag3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.parag2 = New System.Windows.Forms.Label()
        Me.parag1 = New System.Windows.Forms.Label()
        Me.chapEx = New System.Windows.Forms.Label()
        Me.nomChap = New System.Windows.Forms.Label()
        Me.ConnectEtat = New System.Windows.Forms.Label()
        Me.parag4 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.chapitre = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'parag3
        '
        Me.parag3.AutoSize = True
        Me.parag3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.parag3.Font = New System.Drawing.Font("Ebrima", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.parag3.ForeColor = System.Drawing.Color.DarkGreen
        Me.parag3.Location = New System.Drawing.Point(456, 209)
        Me.parag3.Name = "parag3"
        Me.parag3.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.parag3.Size = New System.Drawing.Size(133, 32)
        Me.parag3.TabIndex = 5
        Me.parag3.Text = "߃߲. ߝߘߏ߬ߓߊ߬ߕߐ߮"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Ebrima", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.RosyBrown
        Me.Label2.Location = New System.Drawing.Point(374, 301)
        Me.Label2.Name = "Label2"
        Me.Label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label2.Size = New System.Drawing.Size(273, 21)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "ߥߟߊ߬ߘߊ ߡߍ߲߬ ߠߎ߬ ߓߍ߯ ߟߊߓߊ߲ߕߐ߫ ߞߘߐߓߐߟߌ ߟߋ߫ ߡߊ߬." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'parag2
        '
        Me.parag2.AutoSize = True
        Me.parag2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.parag2.Font = New System.Drawing.Font("Ebrima", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.parag2.ForeColor = System.Drawing.Color.DarkGreen
        Me.parag2.Location = New System.Drawing.Point(61, 209)
        Me.parag2.Name = "parag2"
        Me.parag2.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.parag2.Size = New System.Drawing.Size(146, 32)
        Me.parag2.TabIndex = 5
        Me.parag2.Text = "߂߲. ߞߋ߬ߟߋ߲߬ߠߊ߬ߕߐ߮"
        '
        'parag1
        '
        Me.parag1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.parag1.AutoSize = True
        Me.parag1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.parag1.Font = New System.Drawing.Font("Ebrima", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.parag1.ForeColor = System.Drawing.Color.DarkGreen
        Me.parag1.Location = New System.Drawing.Point(262, 165)
        Me.parag1.Name = "parag1"
        Me.parag1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.parag1.Size = New System.Drawing.Size(135, 32)
        Me.parag1.TabIndex = 5
        Me.parag1.Text = "߁߭. ߞߣߐߘߏ߲ߠߌ"
        '
        'chapEx
        '
        Me.chapEx.Font = New System.Drawing.Font("Ebrima", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chapEx.ForeColor = System.Drawing.SystemColors.ControlText
        Me.chapEx.Location = New System.Drawing.Point(12, 44)
        Me.chapEx.Name = "chapEx"
        Me.chapEx.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.chapEx.Size = New System.Drawing.Size(622, 102)
        Me.chapEx.TabIndex = 5
        Me.chapEx.Text = resources.GetString("chapEx.Text")
        Me.chapEx.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'nomChap
        '
        Me.nomChap.AutoSize = True
        Me.nomChap.BackColor = System.Drawing.SystemColors.Control
        Me.nomChap.Font = New System.Drawing.Font("Ebrima", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nomChap.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.nomChap.Location = New System.Drawing.Point(266, 8)
        Me.nomChap.Name = "nomChap"
        Me.nomChap.Size = New System.Drawing.Size(127, 32)
        Me.nomChap.TabIndex = 6
        Me.nomChap.Text = "ߕߐ߮ ߞߣߐߘߐ"
        '
        'ConnectEtat
        '
        Me.ConnectEtat.AutoSize = True
        Me.ConnectEtat.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ConnectEtat.Font = New System.Drawing.Font("Ebrima", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ConnectEtat.ForeColor = System.Drawing.Color.DarkGray
        Me.ConnectEtat.Location = New System.Drawing.Point(532, 9)
        Me.ConnectEtat.Name = "ConnectEtat"
        Me.ConnectEtat.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.ConnectEtat.Size = New System.Drawing.Size(62, 25)
        Me.ConnectEtat.TabIndex = 5
        Me.ConnectEtat.Text = "ߌ ߜߊ߲߬ߞߎ߲߬" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.ConnectEtat.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'parag4
        '
        Me.parag4.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.parag4.AutoSize = True
        Me.parag4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.parag4.Font = New System.Drawing.Font("Ebrima", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.parag4.ForeColor = System.Drawing.Color.DarkGreen
        Me.parag4.Location = New System.Drawing.Point(234, 260)
        Me.parag4.Name = "parag4"
        Me.parag4.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.parag4.Size = New System.Drawing.Size(190, 32)
        Me.parag4.TabIndex = 5
        Me.parag4.Text = "߄߲. ߕߐ߮ ߞߊ߲ߡߊߛߙߋ߫ ߞߏ"
        '
        'Label6
        '
        Me.Label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label6.Location = New System.Drawing.Point(212, 228)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(242, 1)
        Me.Label6.TabIndex = 7
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label7
        '
        Me.Label7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label7.Location = New System.Drawing.Point(332, 202)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(1, 55)
        Me.Label7.TabIndex = 8
        Me.Label7.Text = "Label7"
        '
        'chapitre
        '
        Me.chapitre.AutoSize = True
        Me.chapitre.Location = New System.Drawing.Point(24, 9)
        Me.chapitre.Name = "chapitre"
        Me.chapitre.Size = New System.Drawing.Size(45, 13)
        Me.chapitre.TabIndex = 9
        Me.chapitre.Text = "chapitre"
        Me.chapitre.Visible = False
        '
        'chap1Noms
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(659, 331)
        Me.Controls.Add(Me.chapitre)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.nomChap)
        Me.Controls.Add(Me.parag2)
        Me.Controls.Add(Me.chapEx)
        Me.Controls.Add(Me.parag1)
        Me.Controls.Add(Me.ConnectEtat)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.parag4)
        Me.Controls.Add(Me.parag3)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "chap1Noms"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.RightToLeftLayout = True
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ߕߐ߮ ߛߌ߰ߘߊ"
        Me.TopMost = True
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents parag3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents parag2 As System.Windows.Forms.Label
    Friend WithEvents parag1 As System.Windows.Forms.Label
    Friend WithEvents chapEx As System.Windows.Forms.Label
    Friend WithEvents nomChap As System.Windows.Forms.Label
    Friend WithEvents ConnectEtat As System.Windows.Forms.Label
    Friend WithEvents parag4 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents chapitre As System.Windows.Forms.Label
End Class
