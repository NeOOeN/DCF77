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
        Me.Button3 = New System.Windows.Forms.Button()
        Me.BU_Start = New System.Windows.Forms.Button()
        Me.Tim_Tim = New System.Windows.Forms.Timer(Me.components)
        Me.Tom_Tom = New System.Windows.Forms.Timer(Me.components)
        Me.LA_Test = New System.Windows.Forms.Label()
        Me.PB_Calcul = New System.Windows.Forms.ProgressBar()
        Me.LA_Signal = New System.Windows.Forms.Label()
        Me.LJ = New AxLJACKUWXLib.AxLjackuwx()
        CType(Me.LJ, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(168, 41)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 23)
        Me.Button3.TabIndex = 2
        Me.Button3.Text = "1"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'BU_Start
        '
        Me.BU_Start.Location = New System.Drawing.Point(184, 39)
        Me.BU_Start.Name = "BU_Start"
        Me.BU_Start.Size = New System.Drawing.Size(152, 42)
        Me.BU_Start.TabIndex = 19
        Me.BU_Start.Text = "Start"
        Me.BU_Start.UseVisualStyleBackColor = True
        '
        'Tim_Tim
        '
        Me.Tim_Tim.Interval = 20
        '
        'Tom_Tom
        '
        Me.Tom_Tom.Interval = 50
        '
        'LA_Test
        '
        Me.LA_Test.AutoSize = True
        Me.LA_Test.Location = New System.Drawing.Point(145, 149)
        Me.LA_Test.Name = "LA_Test"
        Me.LA_Test.Size = New System.Drawing.Size(0, 13)
        Me.LA_Test.TabIndex = 20
        '
        'PB_Calcul
        '
        Me.PB_Calcul.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.PB_Calcul.Location = New System.Drawing.Point(94, 125)
        Me.PB_Calcul.Maximum = 58
        Me.PB_Calcul.Name = "PB_Calcul"
        Me.PB_Calcul.Size = New System.Drawing.Size(317, 44)
        Me.PB_Calcul.Step = 1
        Me.PB_Calcul.Style = System.Windows.Forms.ProgressBarStyle.Continuous
        Me.PB_Calcul.TabIndex = 21
        Me.PB_Calcul.Visible = False
        '
        'LA_Signal
        '
        Me.LA_Signal.AutoSize = True
        Me.LA_Signal.Location = New System.Drawing.Point(175, 140)
        Me.LA_Signal.Name = "LA_Signal"
        Me.LA_Signal.Size = New System.Drawing.Size(161, 13)
        Me.LA_Signal.TabIndex = 24
        Me.LA_Signal.Text = "Recherche du signal en cours ..."
        Me.LA_Signal.Visible = False
        '
        'LJ
        '
        Me.LJ.Enabled = True
        Me.LJ.Location = New System.Drawing.Point(15, 12)
        Me.LJ.Name = "LJ"
        Me.LJ.OcxState = CType(resources.GetObject("LJ.OcxState"), System.Windows.Forms.AxHost.State)
        Me.LJ.Size = New System.Drawing.Size(10, 10)
        Me.LJ.TabIndex = 25
        Me.LJ.Visible = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(499, 395)
        Me.Controls.Add(Me.LJ)
        Me.Controls.Add(Me.LA_Signal)
        Me.Controls.Add(Me.PB_Calcul)
        Me.Controls.Add(Me.LA_Test)
        Me.Controls.Add(Me.BU_Start)
        Me.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form1"
        Me.Text = "Convertisseur final"
        CType(Me.LJ, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents BU_Start As System.Windows.Forms.Button
    Friend WithEvents Tim_Tim As System.Windows.Forms.Timer
    Friend WithEvents Tom_Tom As System.Windows.Forms.Timer
    Friend WithEvents LA_Test As System.Windows.Forms.Label
    Friend WithEvents PB_Calcul As System.Windows.Forms.ProgressBar
    Friend WithEvents LA_Signal As System.Windows.Forms.Label
    Friend WithEvents LJ As AxLJACKUWXLib.AxLjackuwx

End Class
