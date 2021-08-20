<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dlgMyDialog
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
        Me.ucrInputComboBox2 = New instat.ucrInputComboBox()
        Me.lblLabel1 = New System.Windows.Forms.Label()
        Me.lblLabel2 = New System.Windows.Forms.Label()
        Me.ucrChkSum = New instat.ucrCheck()
        Me.ucrSelectorCalculator = New instat.ucrSelectorByDataFrameAddRemove()
        Me.ucrSaveGraph1 = New instat.ucrSaveGraph()
        Me.UcrReceiverSingle1 = New instat.ucrReceiverSingle()
        Me.lblLabel3 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'ucrButtons
        '
        Me.ucrButtons.Location = New System.Drawing.Point(9, 398)
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
        Me.ucrInputComboBox1.Location = New System.Drawing.Point(183, 280)
        Me.ucrInputComboBox1.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.ucrInputComboBox1.Name = "ucrInputComboBox1"
        Me.ucrInputComboBox1.Size = New System.Drawing.Size(183, 26)
        Me.ucrInputComboBox1.TabIndex = 1
        '
        'ucrInputComboBox2
        '
        Me.ucrInputComboBox2.AddQuotesIfUnrecognised = True
        Me.ucrInputComboBox2.GetSetSelectedIndex = -1
        Me.ucrInputComboBox2.IsReadOnly = False
        Me.ucrInputComboBox2.Location = New System.Drawing.Point(183, 318)
        Me.ucrInputComboBox2.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.ucrInputComboBox2.Name = "ucrInputComboBox2"
        Me.ucrInputComboBox2.Size = New System.Drawing.Size(183, 26)
        Me.ucrInputComboBox2.TabIndex = 2
        '
        'lblLabel1
        '
        Me.lblLabel1.AutoSize = True
        Me.lblLabel1.Location = New System.Drawing.Point(12, 291)
        Me.lblLabel1.Name = "lblLabel1"
        Me.lblLabel1.Size = New System.Drawing.Size(118, 17)
        Me.lblLabel1.TabIndex = 3
        Me.lblLabel1.Text = "Input first number"
        '
        'lblLabel2
        '
        Me.lblLabel2.AutoSize = True
        Me.lblLabel2.Location = New System.Drawing.Point(12, 320)
        Me.lblLabel2.Name = "lblLabel2"
        Me.lblLabel2.Size = New System.Drawing.Size(141, 17)
        Me.lblLabel2.TabIndex = 4
        Me.lblLabel2.Text = "Input second number"
        '
        'ucrChkSum
        '
        Me.ucrChkSum.Checked = False
        Me.ucrChkSum.Location = New System.Drawing.Point(14, 355)
        Me.ucrChkSum.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.ucrChkSum.Name = "ucrChkSum"
        Me.ucrChkSum.Size = New System.Drawing.Size(182, 25)
        Me.ucrChkSum.TabIndex = 5
        '
        'ucrSelectorCalculator
        '
        Me.ucrSelectorCalculator.bDropUnusedFilterLevels = False
        Me.ucrSelectorCalculator.bShowHiddenColumns = False
        Me.ucrSelectorCalculator.bUseCurrentFilter = True
        Me.ucrSelectorCalculator.Location = New System.Drawing.Point(9, 9)
        Me.ucrSelectorCalculator.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrSelectorCalculator.Name = "ucrSelectorCalculator"
        Me.ucrSelectorCalculator.Size = New System.Drawing.Size(280, 222)
        Me.ucrSelectorCalculator.TabIndex = 6
        '
        'ucrSaveGraph1
        '
        Me.ucrSaveGraph1.Location = New System.Drawing.Point(360, 146)
        Me.ucrSaveGraph1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ucrSaveGraph1.Name = "ucrSaveGraph1"
        Me.ucrSaveGraph1.Size = New System.Drawing.Size(183, 39)
        Me.ucrSaveGraph1.TabIndex = 7
        '
        'UcrReceiverSingle1
        '
        Me.UcrReceiverSingle1.frmParent = Me
        Me.UcrReceiverSingle1.Location = New System.Drawing.Point(360, 86)
        Me.UcrReceiverSingle1.Margin = New System.Windows.Forms.Padding(0)
        Me.UcrReceiverSingle1.Name = "UcrReceiverSingle1"
        Me.UcrReceiverSingle1.Selector = Nothing
        Me.UcrReceiverSingle1.Size = New System.Drawing.Size(160, 25)
        Me.UcrReceiverSingle1.strNcFilePath = ""
        Me.UcrReceiverSingle1.TabIndex = 8
        Me.UcrReceiverSingle1.ucrSelector = Nothing
        '
        'lblLabel3
        '
        Me.lblLabel3.AutoSize = True
        Me.lblLabel3.Location = New System.Drawing.Point(292, 86)
        Me.lblLabel3.Name = "lblLabel3"
        Me.lblLabel3.Size = New System.Drawing.Size(64, 17)
        Me.lblLabel3.TabIndex = 9
        Me.lblLabel3.Text = "Receiver"
        '
        'dlgMyDialog
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.ClientSize = New System.Drawing.Size(556, 475)
        Me.Controls.Add(Me.lblLabel3)
        Me.Controls.Add(Me.UcrReceiverSingle1)
        Me.Controls.Add(Me.ucrSaveGraph1)
        Me.Controls.Add(Me.ucrSelectorCalculator)
        Me.Controls.Add(Me.ucrChkSum)
        Me.Controls.Add(Me.lblLabel2)
        Me.Controls.Add(Me.lblLabel1)
        Me.Controls.Add(Me.ucrInputComboBox2)
        Me.Controls.Add(Me.ucrInputComboBox1)
        Me.Controls.Add(Me.ucrButtons)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgMyDialog"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Calculator"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrButtons As ucrButtons
    Friend WithEvents ucrInputComboBox1 As ucrInputComboBox
    Friend WithEvents ucrInputComboBox2 As ucrInputComboBox
    Friend WithEvents lblLabel1 As Label
    Friend WithEvents lblLabel2 As Label
    Friend WithEvents ucrChkSum As ucrCheck
    Friend WithEvents ucrSelectorCalculator As ucrSelectorByDataFrameAddRemove
    Friend WithEvents ucrSaveGraph1 As ucrSaveGraph
    Friend WithEvents UcrReceiverSingle1 As ucrReceiverSingle
    Friend WithEvents lblLabel3 As Label
End Class
