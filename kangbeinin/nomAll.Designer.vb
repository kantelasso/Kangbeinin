<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class nomAll
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(nomAll))
        Me.Type1Noms = New System.Windows.Forms.Label()
        Me.expNom1 = New System.Windows.Forms.Label()
        Me.exercices = New System.Windows.Forms.Button()
        Me.exoActive = New System.Windows.Forms.CheckBox()
        Me.SuspendLayout()
        '
        'Type1Noms
        '
        Me.Type1Noms.AutoSize = True
        Me.Type1Noms.BackColor = System.Drawing.SystemColors.Control
        Me.Type1Noms.Font = New System.Drawing.Font("Ebrima", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Type1Noms.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Type1Noms.Location = New System.Drawing.Point(253, 4)
        Me.Type1Noms.Name = "Type1Noms"
        Me.Type1Noms.Size = New System.Drawing.Size(110, 32)
        Me.Type1Noms.TabIndex = 1
        Me.Type1Noms.Text = "ߞߣߐߘߏ߲ߠߌ"
        '
        'expNom1
        '
        Me.expNom1.Font = New System.Drawing.Font("Ebrima", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.expNom1.Location = New System.Drawing.Point(12, 45)
        Me.expNom1.Name = "expNom1"
        Me.expNom1.Size = New System.Drawing.Size(635, 511)
        Me.expNom1.TabIndex = 2
        Me.expNom1.Text = resources.GetString("expNom1.Text")
        '
        'exercices
        '
        Me.exercices.Font = New System.Drawing.Font("Ebrima", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.exercices.Location = New System.Drawing.Point(264, 631)
        Me.exercices.Name = "exercices"
        Me.exercices.Size = New System.Drawing.Size(131, 33)
        Me.exercices.TabIndex = 5
        Me.exercices.Text = "ߞߘߐߓߐߟߌ ߟߎ߬"
        Me.exercices.UseVisualStyleBackColor = True
        Me.exercices.Visible = False
        '
        'exoActive
        '
        Me.exoActive.AutoSize = True
        Me.exoActive.Font = New System.Drawing.Font("Ebrima", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.exoActive.ForeColor = System.Drawing.SystemColors.ButtonShadow
        Me.exoActive.Location = New System.Drawing.Point(38, 591)
        Me.exoActive.Name = "exoActive"
        Me.exoActive.Size = New System.Drawing.Size(582, 29)
        Me.exoActive.TabIndex = 6
        Me.exoActive.Text = "ߒ ߓߘߊ߫ ߕߐ߮ ߞߘߐ ߣߴߊ߬ ߣߊ߬ߝߊ ߟߐ߲߫ ߝߋߎ߫߸ ߒ ߘߌ߫ ߛߋ߫ ߞߘߐߓߐߟߌ ߟߎ߬ ߞߍ߫ ߟߊ߫ ߡߎ߬ߕߎ߲߬."
        Me.exoActive.UseVisualStyleBackColor = True
        '
        'nomAll
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(659, 691)
        Me.Controls.Add(Me.exoActive)
        Me.Controls.Add(Me.exercices)
        Me.Controls.Add(Me.expNom1)
        Me.Controls.Add(Me.Type1Noms)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "nomAll"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.RightToLeftLayout = True
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "ߕߐ߮ ߞߣߐߘߏ߲ߠߌ"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Type1Noms As System.Windows.Forms.Label
    Friend WithEvents expNom1 As System.Windows.Forms.Label
    Friend WithEvents exercices As System.Windows.Forms.Button
    Friend WithEvents exoActive As System.Windows.Forms.CheckBox
End Class
