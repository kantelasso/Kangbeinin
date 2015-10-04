<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Nom1klenatoh
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Nom1klenatoh))
        Me.Type1Noms = New System.Windows.Forms.Label()
        Me.expNom1 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.exoActive = New System.Windows.Forms.CheckBox()
        Me.exercices = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Type1Noms
        '
        Me.Type1Noms.AutoSize = True
        Me.Type1Noms.BackColor = System.Drawing.SystemColors.Control
        Me.Type1Noms.Font = New System.Drawing.Font("Ebrima", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Type1Noms.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Type1Noms.Location = New System.Drawing.Point(269, 9)
        Me.Type1Noms.Name = "Type1Noms"
        Me.Type1Noms.Size = New System.Drawing.Size(121, 32)
        Me.Type1Noms.TabIndex = 2
        Me.Type1Noms.Text = "ߞߋ߬ߟߋ߲߬ߠߊ߬ߕߐ߮"
        '
        'expNom1
        '
        Me.expNom1.Font = New System.Drawing.Font("Ebrima", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.expNom1.Location = New System.Drawing.Point(12, 52)
        Me.expNom1.Name = "expNom1"
        Me.expNom1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.expNom1.Size = New System.Drawing.Size(635, 583)
        Me.expNom1.TabIndex = 3
        Me.expNom1.Text = resources.GetString("expNom1.Text")
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Ebrima", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(379, 649)
        Me.Label1.Name = "Label1"
        Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label1.Size = New System.Drawing.Size(0, 25)
        Me.Label1.TabIndex = 4
        '
        'exoActive
        '
        Me.exoActive.AutoSize = True
        Me.exoActive.Font = New System.Drawing.Font("Ebrima", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.exoActive.Location = New System.Drawing.Point(137, 645)
        Me.exoActive.Name = "exoActive"
        Me.exoActive.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.exoActive.Size = New System.Drawing.Size(184, 29)
        Me.exoActive.TabIndex = 5
        Me.exoActive.Text = "ߒ ߓߘߊ߫ ߣߌ߲߬ ߜߍ߫ ߝߋߎ߫߹ "
        Me.exoActive.UseVisualStyleBackColor = True
        '
        'exercices
        '
        Me.exercices.Font = New System.Drawing.Font("Ebrima", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.exercices.Location = New System.Drawing.Point(391, 642)
        Me.exercices.Name = "exercices"
        Me.exercices.Size = New System.Drawing.Size(131, 33)
        Me.exercices.TabIndex = 6
        Me.exercices.Text = "ߞߘߐߓߐߟߌ ߟߎ߬"
        Me.exercices.UseVisualStyleBackColor = True
        Me.exercices.Visible = False
        '
        'Nom1klenatoh
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(659, 691)
        Me.Controls.Add(Me.exercices)
        Me.Controls.Add(Me.exoActive)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.expNom1)
        Me.Controls.Add(Me.Type1Noms)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow
        Me.Name = "Nom1klenatoh"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.RightToLeftLayout = True
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "ߞߋ߬ߟߋ߲߬ߠߊ߬ߕߐ߮ ߟߎ߬"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Type1Noms As System.Windows.Forms.Label
    Friend WithEvents expNom1 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents exoActive As System.Windows.Forms.CheckBox
    Friend WithEvents exercices As System.Windows.Forms.Button
End Class
