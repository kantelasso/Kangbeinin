<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.slado = New System.Windows.Forms.TextBox()
        Me.gnafoda = New System.Windows.Forms.TextBox()
        Me.atoo = New System.Windows.Forms.Button()
        Me.toondobila = New System.Windows.Forms.Button()
        Me.manktu = New System.Windows.Forms.Button()
        Me.bsolan = New System.Windows.Forms.Button()
        Me.kumasbo = New System.Windows.Forms.Button()
        Me.kunkudun = New System.Windows.Forms.Button()
        Me.kahla = New System.Windows.Forms.Button()
        Me.dognininkali = New System.Windows.Forms.Button()
        Me.dogbeiyali = New System.Windows.Forms.Button()
        Me.kanto = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.liensDirecte = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.afficheAccueil = New System.Windows.Forms.Timer(Me.components)
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'slado
        '
        resources.ApplyResources(Me.slado, "slado")
        Me.slado.ForeColor = System.Drawing.Color.Green
        Me.slado.HideSelection = False
        Me.slado.Name = "slado"
        Me.slado.ReadOnly = True
        Me.slado.TabStop = False
        '
        'gnafoda
        '
        resources.ApplyResources(Me.gnafoda, "gnafoda")
        Me.gnafoda.Name = "gnafoda"
        Me.gnafoda.ReadOnly = True
        Me.gnafoda.TabStop = False
        '
        'atoo
        '
        resources.ApplyResources(Me.atoo, "atoo")
        Me.atoo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.atoo.ForeColor = System.Drawing.Color.Black
        Me.atoo.Name = "atoo"
        Me.atoo.UseVisualStyleBackColor = True
        '
        'toondobila
        '
        resources.ApplyResources(Me.toondobila, "toondobila")
        Me.toondobila.Cursor = System.Windows.Forms.Cursors.Hand
        Me.toondobila.ForeColor = System.Drawing.Color.Black
        Me.toondobila.Name = "toondobila"
        Me.toondobila.UseVisualStyleBackColor = True
        '
        'manktu
        '
        resources.ApplyResources(Me.manktu, "manktu")
        Me.manktu.Cursor = System.Windows.Forms.Cursors.Hand
        Me.manktu.ForeColor = System.Drawing.Color.Black
        Me.manktu.Name = "manktu"
        Me.manktu.UseVisualStyleBackColor = True
        '
        'bsolan
        '
        resources.ApplyResources(Me.bsolan, "bsolan")
        Me.bsolan.Cursor = System.Windows.Forms.Cursors.Hand
        Me.bsolan.ForeColor = System.Drawing.Color.Black
        Me.bsolan.Name = "bsolan"
        Me.bsolan.UseVisualStyleBackColor = True
        '
        'kumasbo
        '
        resources.ApplyResources(Me.kumasbo, "kumasbo")
        Me.kumasbo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.kumasbo.ForeColor = System.Drawing.Color.Black
        Me.kumasbo.Name = "kumasbo"
        Me.kumasbo.UseVisualStyleBackColor = True
        '
        'kunkudun
        '
        resources.ApplyResources(Me.kunkudun, "kunkudun")
        Me.kunkudun.Cursor = System.Windows.Forms.Cursors.Hand
        Me.kunkudun.ForeColor = System.Drawing.Color.Black
        Me.kunkudun.Name = "kunkudun"
        Me.kunkudun.UseVisualStyleBackColor = True
        '
        'kahla
        '
        resources.ApplyResources(Me.kahla, "kahla")
        Me.kahla.Cursor = System.Windows.Forms.Cursors.Hand
        Me.kahla.ForeColor = System.Drawing.Color.Black
        Me.kahla.Name = "kahla"
        Me.kahla.UseVisualStyleBackColor = True
        '
        'dognininkali
        '
        resources.ApplyResources(Me.dognininkali, "dognininkali")
        Me.dognininkali.Cursor = System.Windows.Forms.Cursors.Hand
        Me.dognininkali.ForeColor = System.Drawing.Color.Black
        Me.dognininkali.Name = "dognininkali"
        Me.dognininkali.UseVisualStyleBackColor = True
        '
        'dogbeiyali
        '
        resources.ApplyResources(Me.dogbeiyali, "dogbeiyali")
        Me.dogbeiyali.Cursor = System.Windows.Forms.Cursors.Hand
        Me.dogbeiyali.ForeColor = System.Drawing.Color.Black
        Me.dogbeiyali.Name = "dogbeiyali"
        Me.dogbeiyali.UseVisualStyleBackColor = True
        '
        'kanto
        '
        resources.ApplyResources(Me.kanto, "kanto")
        Me.kanto.Cursor = System.Windows.Forms.Cursors.Hand
        Me.kanto.ForeColor = System.Drawing.Color.Black
        Me.kanto.Name = "kanto"
        Me.kanto.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.kahla)
        Me.GroupBox1.Controls.Add(Me.kanto)
        Me.GroupBox1.Controls.Add(Me.atoo)
        Me.GroupBox1.Controls.Add(Me.dogbeiyali)
        Me.GroupBox1.Controls.Add(Me.toondobila)
        Me.GroupBox1.Controls.Add(Me.dognininkali)
        Me.GroupBox1.Controls.Add(Me.manktu)
        Me.GroupBox1.Controls.Add(Me.bsolan)
        Me.GroupBox1.Controls.Add(Me.kunkudun)
        Me.GroupBox1.Controls.Add(Me.kumasbo)
        resources.ApplyResources(Me.GroupBox1, "GroupBox1")
        Me.GroupBox1.ForeColor = System.Drawing.Color.Gray
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.TabStop = False
        '
        'Label2
        '
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label2.Cursor = System.Windows.Forms.Cursors.IBeam
        resources.ApplyResources(Me.Label2, "Label2")
        Me.Label2.Name = "Label2"
        '
        'Label1
        '
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        resources.ApplyResources(Me.Label1, "Label1")
        Me.Label1.Name = "Label1"
        '
        'liensDirecte
        '
        resources.ApplyResources(Me.liensDirecte, "liensDirecte")
        Me.liensDirecte.Cursor = System.Windows.Forms.Cursors.Hand
        Me.liensDirecte.ForeColor = System.Drawing.Color.MidnightBlue
        Me.liensDirecte.Name = "liensDirecte"
        '
        'Label3
        '
        resources.ApplyResources(Me.Label3, "Label3")
        Me.Label3.ForeColor = System.Drawing.SystemColors.GrayText
        Me.Label3.Name = "Label3"
        '
        'Label4
        '
        resources.ApplyResources(Me.Label4, "Label4")
        Me.Label4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlDark
        Me.Label4.Name = "Label4"
        '
        'afficheAccueil
        '
        Me.afficheAccueil.Interval = 10000
        '
        'Form1
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.liensDirecte)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.gnafoda)
        Me.Controls.Add(Me.slado)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form1"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents slado As System.Windows.Forms.TextBox
    Friend WithEvents gnafoda As System.Windows.Forms.TextBox
    Friend WithEvents atoo As System.Windows.Forms.Button
    Friend WithEvents toondobila As System.Windows.Forms.Button
    Friend WithEvents manktu As System.Windows.Forms.Button
    Friend WithEvents bsolan As System.Windows.Forms.Button
    Friend WithEvents kumasbo As System.Windows.Forms.Button
    Friend WithEvents kunkudun As System.Windows.Forms.Button
    Friend WithEvents kahla As System.Windows.Forms.Button
    Friend WithEvents dognininkali As System.Windows.Forms.Button
    Friend WithEvents dogbeiyali As System.Windows.Forms.Button
    Friend WithEvents kanto As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents liensDirecte As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents afficheAccueil As System.Windows.Forms.Timer

End Class
