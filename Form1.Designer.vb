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
        Me.EarnTheme1 = New E3C__Windows_.EarnTheme()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.EarnProgressBar1 = New E3C__Windows_.EarnProgressBar()
        Me.EarnButton1 = New E3C__Windows_.EarnButton()
        Me.EarnTheme1.SuspendLayout()
        Me.SuspendLayout()
        '
        'EarnTheme1
        '
        Me.EarnTheme1.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.EarnTheme1.BorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.EarnTheme1.Controls.Add(Me.Label2)
        Me.EarnTheme1.Controls.Add(Me.Label1)
        Me.EarnTheme1.Controls.Add(Me.EarnProgressBar1)
        Me.EarnTheme1.Controls.Add(Me.EarnButton1)
        Me.EarnTheme1.Customization = "WU1L//////8="
        Me.EarnTheme1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.EarnTheme1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.EarnTheme1.Image = Nothing
        Me.EarnTheme1.Location = New System.Drawing.Point(0, 0)
        Me.EarnTheme1.Movable = True
        Me.EarnTheme1.Name = "EarnTheme1"
        Me.EarnTheme1.NoRounding = False
        Me.EarnTheme1.Sizable = True
        Me.EarnTheme1.Size = New System.Drawing.Size(563, 297)
        Me.EarnTheme1.SmartBounds = True
        Me.EarnTheme1.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultLocation
        Me.EarnTheme1.TabIndex = 0
        Me.EarnTheme1.Text = "EarnTheme1"
        Me.EarnTheme1.TransparencyKey = System.Drawing.Color.Fuchsia
        Me.EarnTheme1.Transparent = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(257, 93)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(40, 15)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "00/00"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(175, 52)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(206, 15)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Votre moyenne actuelle aux E3C est"
        '
        'EarnProgressBar1
        '
        Me.EarnProgressBar1.Animated = True
        Me.EarnProgressBar1.Customization = "8PDw/zSyT/9J0IL/////AFlNS//w8PD/"
        Me.EarnProgressBar1.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.EarnProgressBar1.Image = Nothing
        Me.EarnProgressBar1.Location = New System.Drawing.Point(124, 111)
        Me.EarnProgressBar1.Maximum = 100
        Me.EarnProgressBar1.Minimum = 0
        Me.EarnProgressBar1.Name = "EarnProgressBar1"
        Me.EarnProgressBar1.NoRounding = False
        Me.EarnProgressBar1.Size = New System.Drawing.Size(308, 23)
        Me.EarnProgressBar1.TabIndex = 1
        Me.EarnProgressBar1.Text = "EarnProgressBar1"
        Me.EarnProgressBar1.Transparent = False
        Me.EarnProgressBar1.Value = 0
        '
        'EarnButton1
        '
        Me.EarnButton1.Customization = "R819/za1VP//////"
        Me.EarnButton1.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.EarnButton1.Image = Nothing
        Me.EarnButton1.Location = New System.Drawing.Point(61, 250)
        Me.EarnButton1.Name = "EarnButton1"
        Me.EarnButton1.NoRounding = False
        Me.EarnButton1.Size = New System.Drawing.Size(425, 23)
        Me.EarnButton1.TabIndex = 0
        Me.EarnButton1.Text = "Je saisis mes notes"
        Me.EarnButton1.Transparent = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(563, 297)
        Me.Controls.Add(Me.EarnTheme1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.TransparencyKey = System.Drawing.Color.Fuchsia
        Me.EarnTheme1.ResumeLayout(False)
        Me.EarnTheme1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents EarnButton1 As E3C__Windows_.EarnButton
    Friend WithEvents EarnProgressBar1 As E3C__Windows_.EarnProgressBar
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents EarnTheme1 As E3C__Windows_.EarnTheme

End Class
