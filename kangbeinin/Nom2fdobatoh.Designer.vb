﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Nom2fdobatoh
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Nom2fdobatoh))
        Me.expNom1 = New System.Windows.Forms.Label()
        Me.Type1Noms = New System.Windows.Forms.Label()
        Me.exercices = New System.Windows.Forms.Button()
        Me.exoActive = New System.Windows.Forms.CheckBox()
        Me.Nom3page12 = New System.Windows.Forms.LinkLabel()
        Me.SuspendLayout()
        '
        'expNom1
        '
        Me.expNom1.Font = New System.Drawing.Font("Ebrima", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.expNom1.Location = New System.Drawing.Point(12, 47)
        Me.expNom1.Name = "expNom1"
        Me.expNom1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.expNom1.Size = New System.Drawing.Size(638, 587)
        Me.expNom1.TabIndex = 5
        Me.expNom1.Text = resources.GetString("expNom1.Text")
        '
        'Type1Noms
        '
        Me.Type1Noms.AutoSize = True
        Me.Type1Noms.BackColor = System.Drawing.SystemColors.Control
        Me.Type1Noms.Font = New System.Drawing.Font("Ebrima", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Type1Noms.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Type1Noms.Location = New System.Drawing.Point(275, 9)
        Me.Type1Noms.Name = "Type1Noms"
        Me.Type1Noms.Size = New System.Drawing.Size(108, 32)
        Me.Type1Noms.TabIndex = 4
        Me.Type1Noms.Text = "ߝߘߏ߬ߓߊ߬ߕߐ߮"
        '
        'exercices
        '
        Me.exercices.Font = New System.Drawing.Font("Ebrima", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.exercices.Location = New System.Drawing.Point(400, 648)
        Me.exercices.Name = "exercices"
        Me.exercices.Size = New System.Drawing.Size(131, 33)
        Me.exercices.TabIndex = 8
        Me.exercices.Text = "ߞߘߐߓߐߟߌ ߟߎ߬"
        Me.exercices.UseVisualStyleBackColor = True
        Me.exercices.Visible = False
        '
        'exoActive
        '
        Me.exoActive.AutoSize = True
        Me.exoActive.Font = New System.Drawing.Font("Ebrima", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.exoActive.Location = New System.Drawing.Point(128, 650)
        Me.exoActive.Name = "exoActive"
        Me.exoActive.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.exoActive.Size = New System.Drawing.Size(176, 29)
        Me.exoActive.TabIndex = 7
        Me.exoActive.Text = "ߣߌ߲߬ ߓߘߊ߫ ߢߊߦߋ߫ ߝߋߎ߫߹" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.exoActive.UseVisualStyleBackColor = True
        '
        'Nom3page12
        '
        Me.Nom3page12.AutoSize = True
        Me.Nom3page12.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Nom3page12.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline
        Me.Nom3page12.Location = New System.Drawing.Point(568, 648)
        Me.Nom3page12.Name = "Nom3page12"
        Me.Nom3page12.Size = New System.Drawing.Size(79, 25)
        Me.Nom3page12.TabIndex = 9
        Me.Nom3page12.TabStop = True
        Me.Nom3page12.Text = "ߊ߬ ߕߐ߭ ߝߟߍ߫"
        Me.Nom3page12.Visible = False
        '
        'Nom2fdobatoh
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(659, 691)
        Me.Controls.Add(Me.Nom3page12)
        Me.Controls.Add(Me.exercices)
        Me.Controls.Add(Me.exoActive)
        Me.Controls.Add(Me.expNom1)
        Me.Controls.Add(Me.Type1Noms)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "Nom2fdobatoh"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.RightToLeftLayout = True
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "ߝߘߏ߬ߓߊ߬ߕߐ߮ ߟߎ߬"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents expNom1 As System.Windows.Forms.Label
    Friend WithEvents Type1Noms As System.Windows.Forms.Label
    Friend WithEvents exercices As System.Windows.Forms.Button
    Friend WithEvents exoActive As System.Windows.Forms.CheckBox
    Friend WithEvents Nom3page12 As System.Windows.Forms.LinkLabel
End Class
