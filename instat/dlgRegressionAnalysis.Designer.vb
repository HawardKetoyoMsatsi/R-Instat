<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dlgRegressionAnalysis
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
        Me.ucrBase = New instat.ucrButtons()
        Me.ucrDataframeSelector = New instat.ucrSelectorByDataFrameAddRemove()
        Me.ucrReceiverMultipleXVariables = New instat.ucrReceiverMultiple()
        Me.ucrReceiverSingleYVar = New instat.ucrReceiverSingle()
        Me.ucrChkMissingValues = New instat.ucrCheck()
        Me.ucrCheckSummary = New instat.ucrCheck()
        Me.ucrInputComboColor = New instat.ucrColors()
        Me.lblXVariables = New System.Windows.Forms.Label()
        Me.lblColors = New System.Windows.Forms.Label()
        Me.lblSummary = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblYVariable = New System.Windows.Forms.Label()
        Me.rdoYesToGraph = New instat.ucrRadio()
        Me.rdoNoToGraph = New instat.ucrRadio()
        Me.grpPlots = New System.Windows.Forms.GroupBox()
        Me.grpPlots.SuspendLayout()
        Me.SuspendLayout()
        '
        'ucrBase
        '
        Me.ucrBase.Location = New System.Drawing.Point(9, 359)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(410, 52)
        Me.ucrBase.TabIndex = 0
        '
        'ucrDataframeSelector
        '
        Me.ucrDataframeSelector.bDropUnusedFilterLevels = False
        Me.ucrDataframeSelector.bShowHiddenColumns = False
        Me.ucrDataframeSelector.bUseCurrentFilter = True
        Me.ucrDataframeSelector.ForeColor = System.Drawing.SystemColors.ControlText
        Me.ucrDataframeSelector.Location = New System.Drawing.Point(9, 18)
        Me.ucrDataframeSelector.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrDataframeSelector.Name = "ucrDataframeSelector"
        Me.ucrDataframeSelector.Size = New System.Drawing.Size(210, 180)
        Me.ucrDataframeSelector.TabIndex = 1
        '
        'ucrReceiverMultipleXVariables
        '
        Me.ucrReceiverMultipleXVariables.frmParent = Me
        Me.ucrReceiverMultipleXVariables.Location = New System.Drawing.Point(272, 98)
        Me.ucrReceiverMultipleXVariables.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverMultipleXVariables.Name = "ucrReceiverMultipleXVariables"
        Me.ucrReceiverMultipleXVariables.Selector = Nothing
        Me.ucrReceiverMultipleXVariables.Size = New System.Drawing.Size(120, 100)
        Me.ucrReceiverMultipleXVariables.strNcFilePath = ""
        Me.ucrReceiverMultipleXVariables.TabIndex = 2
        Me.ucrReceiverMultipleXVariables.ucrSelector = Nothing
        '
        'ucrReceiverSingleYVar
        '
        Me.ucrReceiverSingleYVar.ForeColor = System.Drawing.SystemColors.ControlText
        Me.ucrReceiverSingleYVar.frmParent = Me
        Me.ucrReceiverSingleYVar.Location = New System.Drawing.Point(272, 41)
        Me.ucrReceiverSingleYVar.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverSingleYVar.Name = "ucrReceiverSingleYVar"
        Me.ucrReceiverSingleYVar.Selector = Nothing
        Me.ucrReceiverSingleYVar.Size = New System.Drawing.Size(120, 20)
        Me.ucrReceiverSingleYVar.strNcFilePath = ""
        Me.ucrReceiverSingleYVar.TabIndex = 3
        Me.ucrReceiverSingleYVar.ucrSelector = Nothing
        '
        'ucrChkMissingValues
        '
        Me.ucrChkMissingValues.Checked = False
        Me.ucrChkMissingValues.Location = New System.Drawing.Point(9, 257)
        Me.ucrChkMissingValues.Name = "ucrChkMissingValues"
        Me.ucrChkMissingValues.Size = New System.Drawing.Size(100, 20)
        Me.ucrChkMissingValues.TabIndex = 4
        '
        'ucrCheckSummary
        '
        Me.ucrCheckSummary.Checked = False
        Me.ucrCheckSummary.Location = New System.Drawing.Point(9, 319)
        Me.ucrCheckSummary.Name = "ucrCheckSummary"
        Me.ucrCheckSummary.Size = New System.Drawing.Size(100, 20)
        Me.ucrCheckSummary.TabIndex = 5
        '
        'ucrInputComboColor
        '
        Me.ucrInputComboColor.AddQuotesIfUnrecognised = True
        Me.ucrInputComboColor.GetSetSelectedIndex = -1
        Me.ucrInputComboColor.IsReadOnly = False
        Me.ucrInputComboColor.Location = New System.Drawing.Point(255, 318)
        Me.ucrInputComboColor.Name = "ucrInputComboColor"
        Me.ucrInputComboColor.Size = New System.Drawing.Size(137, 21)
        Me.ucrInputComboColor.TabIndex = 6
        '
        'lblXVariables
        '
        Me.lblXVariables.AutoSize = True
        Me.lblXVariables.Location = New System.Drawing.Point(269, 85)
        Me.lblXVariables.Name = "lblXVariables"
        Me.lblXVariables.Size = New System.Drawing.Size(63, 13)
        Me.lblXVariables.TabIndex = 7
        Me.lblXVariables.Text = "X Variables:"
        '
        'lblColors
        '
        Me.lblColors.AutoSize = True
        Me.lblColors.Location = New System.Drawing.Point(252, 302)
        Me.lblColors.Name = "lblColors"
        Me.lblColors.Size = New System.Drawing.Size(34, 13)
        Me.lblColors.TabIndex = 8
        Me.lblColors.Text = "Color:"
        '
        'lblSummary
        '
        Me.lblSummary.AutoSize = True
        Me.lblSummary.Location = New System.Drawing.Point(9, 302)
        Me.lblSummary.Name = "lblSummary"
        Me.lblSummary.Size = New System.Drawing.Size(53, 13)
        Me.lblSummary.TabIndex = 9
        Me.lblSummary.Text = "Summary:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(9, 241)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(104, 13)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Omit Missing Values:"
        '
        'lblYVariable
        '
        Me.lblYVariable.AutoSize = True
        Me.lblYVariable.Location = New System.Drawing.Point(269, 28)
        Me.lblYVariable.Name = "lblYVariable"
        Me.lblYVariable.Size = New System.Drawing.Size(58, 13)
        Me.lblYVariable.TabIndex = 11
        Me.lblYVariable.Text = "Y Variable:"
        '
        'rdoYesToGraph
        '
        Me.rdoYesToGraph.Location = New System.Drawing.Point(17, 13)
        Me.rdoYesToGraph.Name = "rdoYesToGraph"
        Me.rdoYesToGraph.Size = New System.Drawing.Size(100, 20)
        Me.rdoYesToGraph.TabIndex = 12
        '
        'rdoNoToGraph
        '
        Me.rdoNoToGraph.Location = New System.Drawing.Point(272, 257)
        Me.rdoNoToGraph.Name = "rdoNoToGraph"
        Me.rdoNoToGraph.Size = New System.Drawing.Size(100, 35)
        Me.rdoNoToGraph.TabIndex = 13
        '
        'grpPlots
        '
        Me.grpPlots.Controls.Add(Me.rdoYesToGraph)
        Me.grpPlots.Location = New System.Drawing.Point(255, 221)
        Me.grpPlots.Name = "grpPlots"
        Me.grpPlots.Size = New System.Drawing.Size(164, 78)
        Me.grpPlots.TabIndex = 14
        Me.grpPlots.TabStop = False
        Me.grpPlots.Text = "Plot"
        '
        'dlgRegressionAnalysis
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(429, 423)
        Me.Controls.Add(Me.rdoNoToGraph)
        Me.Controls.Add(Me.lblYVariable)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.lblSummary)
        Me.Controls.Add(Me.lblColors)
        Me.Controls.Add(Me.lblXVariables)
        Me.Controls.Add(Me.ucrInputComboColor)
        Me.Controls.Add(Me.ucrCheckSummary)
        Me.Controls.Add(Me.ucrChkMissingValues)
        Me.Controls.Add(Me.ucrReceiverSingleYVar)
        Me.Controls.Add(Me.ucrReceiverMultipleXVariables)
        Me.Controls.Add(Me.ucrDataframeSelector)
        Me.Controls.Add(Me.ucrBase)
        Me.Controls.Add(Me.grpPlots)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgRegressionAnalysis"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Regression Analysis"
        Me.grpPlots.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents ucrDataframeSelector As ucrSelectorByDataFrameAddRemove
    Friend WithEvents ucrReceiverMultipleXVariables As ucrReceiverMultiple
    Friend WithEvents rdoNoToGraph As ucrRadio
    Friend WithEvents lblYVariable As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents lblSummary As Label
    Friend WithEvents lblColors As Label
    Friend WithEvents lblXVariables As Label
    Friend WithEvents ucrInputComboColor As ucrColors
    Friend WithEvents ucrCheckSummary As ucrCheck
    Friend WithEvents ucrChkMissingValues As ucrCheck
    Friend WithEvents ucrReceiverSingleYVar As ucrReceiverSingle
    Friend WithEvents grpPlots As GroupBox
    Friend WithEvents rdoYesToGraph As ucrRadio
End Class
