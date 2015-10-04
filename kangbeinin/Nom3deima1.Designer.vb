<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Nom3deima1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Nom3deima1))
        Me.expNom1 = New System.Windows.Forms.Label()
        Me.Type1Noms = New System.Windows.Forms.Label()
        Me.Nom3page12 = New System.Windows.Forms.LinkLabel()
        Me.exoActive = New System.Windows.Forms.CheckBox()
        Me.exercices = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'expNom1
        '
        Me.expNom1.Font = New System.Drawing.Font("Ebrima", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.expNom1.Location = New System.Drawing.Point(12, 70)
        Me.expNom1.Name = "expNom1"
        Me.expNom1.Size = New System.Drawing.Size(635, 560)
        Me.expNom1.TabIndex = 4
        Me.expNom1.Text = resources.GetString("expNom1.Text")
        '
        'Type1Noms
        '
        Me.Type1Noms.AutoSize = True
        Me.Type1Noms.BackColor = System.Drawing.SystemColors.Control
        Me.Type1Noms.Font = New System.Drawing.Font("Ebrima", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Type1Noms.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Type1Noms.Location = New System.Drawing.Point(242, 17)
        Me.Type1Noms.Name = "Type1Noms"
        Me.Type1Noms.Size = New System.Drawing.Size(175, 32)
        Me.Type1Noms.TabIndex = 3
        Me.Type1Noms.Text = "ߕߐ߮ ߟߊߓߊ߲߫ ߞߊ߲ߡߊߛߙߋ"
        '
        'Nom3page12
        '
        Me.Nom3page12.AutoSize = True
        Me.Nom3page12.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Nom3page12.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline
        Me.Nom3page12.Location = New System.Drawing.Point(556, 640)
        Me.Nom3page12.Name = "Nom3page12"
        Me.Nom3page12.Size = New System.Drawing.Size(91, 25)
        Me.Nom3page12.TabIndex = 6
        Me.Nom3page12.TabStop = True
        Me.Nom3page12.Text = "ߞߐߜߍ ߣߊ߬ߕߐ"
        '
        'exoActive
        '
        Me.exoActive.AutoSize = True
        Me.exoActive.Font = New System.Drawing.Font("Ebrima", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.exoActive.ForeColor = System.Drawing.SystemColors.ButtonShadow
        Me.exoActive.Location = New System.Drawing.Point(16, 640)
        Me.exoActive.Name = "exoActive"
        Me.exoActive.Size = New System.Drawing.Size(401, 29)
        Me.exoActive.TabIndex = 11
        Me.exoActive.Text = "ߞߘߐߓߐߟߌ ߟߎ߬ ߟߊߓߐ߫ ߡߎ߬ߕߎ߲߬߸ ߒ ߧߋ߫ ߜߊ߬ߟߏ ߟߊ߫ ߊ߬ߟߎ߫ ߞߊ߲߬."
        Me.exoActive.UseVisualStyleBackColor = True
        Me.exoActive.Visible = False
        '
        'exercices
        '
        Me.exercices.Font = New System.Drawing.Font("Ebrima", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.exercices.Location = New System.Drawing.Point(424, 640)
        Me.exercices.Name = "exercices"
        Me.exercices.Size = New System.Drawing.Size(131, 33)
        Me.exercices.TabIndex = 10
        Me.exercices.Text = "ߞߘߐߓߐߟߌ ߟߎ߬"
        Me.exercices.UseVisualStyleBackColor = True
        Me.exercices.Visible = False
        '
        'Nom3deima1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(659, 691)
        Me.Controls.Add(Me.exoActive)
        Me.Controls.Add(Me.exercices)
        Me.Controls.Add(Me.Nom3page12)
        Me.Controls.Add(Me.expNom1)
        Me.Controls.Add(Me.Type1Noms)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "Nom3deima1"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.RightToLeftLayout = True
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "ߕߐ߮ ߞߊ߲ߡߊߛߙߋ߫ ߞߏ"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents expNom1 As System.Windows.Forms.Label
    Friend WithEvents Type1Noms As System.Windows.Forms.Label
    Friend WithEvents Nom3page12 As System.Windows.Forms.LinkLabel
    Friend WithEvents exoActive As System.Windows.Forms.CheckBox
    Friend WithEvents exercices As System.Windows.Forms.Button
End Class
