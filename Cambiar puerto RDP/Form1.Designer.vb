<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.stds = New System.Windows.Forms.RadioButton()
        Me.alts = New System.Windows.Forms.RadioButton()
        Me.port = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.SuspendLayout()
        '
        'stds
        '
        Me.stds.AutoSize = True
        Me.stds.Location = New System.Drawing.Point(44, 39)
        Me.stds.Name = "stds"
        Me.stds.Size = New System.Drawing.Size(67, 17)
        Me.stds.TabIndex = 0
        Me.stds.TabStop = True
        Me.stds.Text = "Estándar"
        Me.stds.UseVisualStyleBackColor = True
        '
        'alts
        '
        Me.alts.AutoSize = True
        Me.alts.Location = New System.Drawing.Point(44, 62)
        Me.alts.Name = "alts"
        Me.alts.Size = New System.Drawing.Size(75, 17)
        Me.alts.TabIndex = 1
        Me.alts.TabStop = True
        Me.alts.Text = "Alternativo"
        Me.alts.UseVisualStyleBackColor = True
        '
        'port
        '
        Me.port.Location = New System.Drawing.Point(125, 62)
        Me.port.Name = "port"
        Me.port.Size = New System.Drawing.Size(48, 20)
        Me.port.TabIndex = 2
        Me.port.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(133, 41)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(31, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "3389"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(10, 13)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(101, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Elija un puerto TCP:"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(25, 101)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(80, 21)
        Me.Button1.TabIndex = 5
        Me.Button1.Text = "Aceptar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(115, 101)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(80, 21)
        Me.Button2.TabIndex = 6
        Me.Button2.Text = "Cancelar"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(41, 138)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(132, 26)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "© 2010 Julio González Gil " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Bajo Licencia GPL v3.0"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Location = New System.Drawing.Point(38, 166)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(139, 13)
        Me.LinkLabel1.TabIndex = 8
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "http://www.juliogonzalez.es"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(217, 188)
        Me.Controls.Add(Me.LinkLabel1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.port)
        Me.Controls.Add(Me.alts)
        Me.Controls.Add(Me.stds)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cambiar puerto RDP"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents stds As System.Windows.Forms.RadioButton
    Friend WithEvents alts As System.Windows.Forms.RadioButton
    Friend WithEvents port As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents LinkLabel1 As System.Windows.Forms.LinkLabel

End Class
