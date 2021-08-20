<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dldMyDialog
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
        Me.ucrButtons = New instat.ucrButtons()
        Me.ucrInputComboBox1 = New instat.ucrInputComboBox()
        Me.UcrInputComboBox2 = New instat.ucrInputComboBox()
        Me.lblLabel1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.UcrCheck1 = New instat.ucrCheck()
        Me.SuspendLayout()
        '
        'ucrButtons
        '
        Me.ucrButtons.Location = New System.Drawing.Point(4, 373)
        Me.ucrButtons.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ucrButtons.Name = "ucrButtons"
        Me.ucrButtons.Size = New System.Drawing.Size(547, 64)
        Me.ucrButtons.TabIndex = 0
        '
        'ucrInputComboBox1
        '
        Me.ucrInputComboBox1.AddQuotesIfUnrecognised = True
        Me.ucrInputComboBox1.GetSetSelectedIndex = -1
        Me.ucrInputComboBox1.IsReadOnly = False
        Me.ucrInputComboBox1.Location = New System.Drawing.Point(183, 54)
        Me.ucrInputComboBox1.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.ucrInputComboBox1.Name = "ucrInputComboBox1"
        Me.ucrInputComboBox1.Size = New System.Drawing.Size(183, 26)
        Me.ucrInputComboBox1.TabIndex = 1
        '
        'UcrInputComboBox2
        '
        Me.UcrInputComboBox2.AddQuotesIfUnrecognised = True
        Me.UcrInputComboBox2.GetSetSelectedIndex = -1
        Me.UcrInputComboBox2.IsReadOnly = False
        Me.UcrInputComboBox2.Location = New System.Drawing.Point(183, 123)
        Me.UcrInputComboBox2.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.UcrInputComboBox2.Name = "UcrInputComboBox2"
        Me.UcrInputComboBox2.Size = New System.Drawing.Size(183, 26)
        Me.UcrInputComboBox2.TabIndex = 2
        '
        'lblLabel1
        '
        Me.lblLabel1.AutoSize = True
        Me.lblLabel1.Location = New System.Drawing.Point(23, 54)
        Me.lblLabel1.Name = "lblLabel1"
        Me.lblLabel1.Size = New System.Drawing.Size(118, 17)
        Me.lblLabel1.TabIndex = 3
        Me.lblLabel1.Text = "Input first number"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(23, 123)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(141, 17)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Input second number"
        '
        'UcrCheck1
        '
        Me.UcrCheck1.Checked = False
        Me.UcrCheck1.Location = New System.Drawing.Point(26, 211)
        Me.UcrCheck1.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.UcrCheck1.Name = "UcrCheck1"
        Me.UcrCheck1.Size = New System.Drawing.Size(182, 25)
        Me.UcrCheck1.TabIndex = 5
        '
        'dldMyDialog
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.ClientSize = New System.Drawing.Size(556, 450)
        Me.Controls.Add(Me.UcrCheck1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lblLabel1)
        Me.Controls.Add(Me.UcrInputComboBox2)
        Me.Controls.Add(Me.ucrInputComboBox1)
        Me.Controls.Add(Me.ucrButtons)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dldMyDialog"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Calculator"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrButtons As ucrButtons
    Friend WithEvents ucrInputComboBox1 As ucrInputComboBox
    Friend WithEvents UcrInputComboBox2 As ucrInputComboBox
    Friend WithEvents lblLabel1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents UcrCheck1 As ucrCheck
End Class
