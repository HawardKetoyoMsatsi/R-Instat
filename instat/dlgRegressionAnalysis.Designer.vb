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
        Me.ucrSelectorByDataFrameAddRemove1 = New instat.ucrSelectorByDataFrameAddRemove()
        Me.ucrReceiverMultipleXVariables = New instat.ucrReceiverMultiple()
        Me.ucrReceiverSingleYVar = New instat.ucrReceiverSingle()
        Me.ucrSummaryCheck = New instat.ucrCheck()
        Me.UcrCheck1 = New instat.ucrCheck()
        Me.ucrColors1 = New instat.ucrColors()
        Me.lblXVariables = New System.Windows.Forms.Label()
        Me.lblColors = New System.Windows.Forms.Label()
        Me.lblSummary = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblYVariable = New System.Windows.Forms.Label()
        Me.ucrYesToGraph = New instat.ucrRadio()
        Me.ucrNoToGraph = New instat.ucrRadio()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ucrBase
        '
        Me.ucrBase.Location = New System.Drawing.Point(9, 359)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(410, 52)
        Me.ucrBase.TabIndex = 0
        '
        'ucrSelectorByDataFrameAddRemove1
        '
        Me.ucrSelectorByDataFrameAddRemove1.bDropUnusedFilterLevels = False
        Me.ucrSelectorByDataFrameAddRemove1.bShowHiddenColumns = False
        Me.ucrSelectorByDataFrameAddRemove1.bUseCurrentFilter = True
        Me.ucrSelectorByDataFrameAddRemove1.Location = New System.Drawing.Point(9, 18)
        Me.ucrSelectorByDataFrameAddRemove1.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrSelectorByDataFrameAddRemove1.Name = "ucrSelectorByDataFrameAddRemove1"
        Me.ucrSelectorByDataFrameAddRemove1.Size = New System.Drawing.Size(210, 180)
        Me.ucrSelectorByDataFrameAddRemove1.TabIndex = 1
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
        'ucrSummaryCheck
        '
        Me.ucrSummaryCheck.Checked = False
        Me.ucrSummaryCheck.Location = New System.Drawing.Point(9, 257)
        Me.ucrSummaryCheck.Name = "ucrSummaryCheck"
        Me.ucrSummaryCheck.Size = New System.Drawing.Size(100, 20)
        Me.ucrSummaryCheck.TabIndex = 4
        '
        'UcrCheck1
        '
        Me.UcrCheck1.Checked = False
        Me.UcrCheck1.Location = New System.Drawing.Point(9, 319)
        Me.UcrCheck1.Name = "UcrCheck1"
        Me.UcrCheck1.Size = New System.Drawing.Size(100, 20)
        Me.UcrCheck1.TabIndex = 5
        '
        'ucrColors1
        '
        Me.ucrColors1.AddQuotesIfUnrecognised = True
        Me.ucrColors1.GetSetSelectedIndex = -1
        Me.ucrColors1.IsReadOnly = False
        Me.ucrColors1.Location = New System.Drawing.Point(255, 318)
        Me.ucrColors1.Name = "ucrColors1"
        Me.ucrColors1.Size = New System.Drawing.Size(137, 21)
        Me.ucrColors1.TabIndex = 6
        '
        'lblXVariables
        '
        Me.lblXVariables.AutoSize = True
        Me.lblXVariables.Location = New System.Drawing.Point(269, 85)
        Me.lblXVariables.Name = "lblXVariables"
        Me.lblXVariables.Size = New System.Drawing.Size(60, 13)
        Me.lblXVariables.TabIndex = 7
        Me.lblXVariables.Text = "X Variables"
        '
        'lblColors
        '
        Me.lblColors.AutoSize = True
        Me.lblColors.Location = New System.Drawing.Point(252, 302)
        Me.lblColors.Name = "lblColors"
        Me.lblColors.Size = New System.Drawing.Size(31, 13)
        Me.lblColors.TabIndex = 8
        Me.lblColors.Text = "Color"
        '
        'lblSummary
        '
        Me.lblSummary.AutoSize = True
        Me.lblSummary.Location = New System.Drawing.Point(9, 302)
        Me.lblSummary.Name = "lblSummary"
        Me.lblSummary.Size = New System.Drawing.Size(50, 13)
        Me.lblSummary.TabIndex = 9
        Me.lblSummary.Text = "Summary"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(9, 241)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(101, 13)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Omit Missing Values"
        '
        'lblYVariable
        '
        Me.lblYVariable.AutoSize = True
        Me.lblYVariable.Location = New System.Drawing.Point(269, 28)
        Me.lblYVariable.Name = "lblYVariable"
        Me.lblYVariable.Size = New System.Drawing.Size(55, 13)
        Me.lblYVariable.TabIndex = 11
        Me.lblYVariable.Text = "Y Variable"
        '
        'ucrYesToGraph
        '
        Me.ucrYesToGraph.Location = New System.Drawing.Point(17, 13)
        Me.ucrYesToGraph.Name = "ucrYesToGraph"
        Me.ucrYesToGraph.Size = New System.Drawing.Size(100, 20)
        Me.ucrYesToGraph.TabIndex = 12
        '
        'ucrNoToGraph
        '
        Me.ucrNoToGraph.Location = New System.Drawing.Point(272, 257)
        Me.ucrNoToGraph.Name = "ucrNoToGraph"
        Me.ucrNoToGraph.Size = New System.Drawing.Size(100, 35)
        Me.ucrNoToGraph.TabIndex = 13
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.ucrYesToGraph)
        Me.GroupBox1.Location = New System.Drawing.Point(255, 221)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(164, 78)
        Me.GroupBox1.TabIndex = 14
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Plot"
        '
        'dlgRegressionAnalysis
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(449, 423)
        Me.Controls.Add(Me.ucrNoToGraph)
        Me.Controls.Add(Me.lblYVariable)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.lblSummary)
        Me.Controls.Add(Me.lblColors)
        Me.Controls.Add(Me.lblXVariables)
        Me.Controls.Add(Me.ucrColors1)
        Me.Controls.Add(Me.UcrCheck1)
        Me.Controls.Add(Me.ucrSummaryCheck)
        Me.Controls.Add(Me.ucrReceiverSingleYVar)
        Me.Controls.Add(Me.ucrReceiverMultipleXVariables)
        Me.Controls.Add(Me.ucrSelectorByDataFrameAddRemove1)
        Me.Controls.Add(Me.ucrBase)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgRegressionAnalysis"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Regression Analysis"
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents ucrSelectorByDataFrameAddRemove1 As ucrSelectorByDataFrameAddRemove
    Friend WithEvents ucrReceiverMultipleXVariables As ucrReceiverMultiple
    Friend WithEvents ucrNoToGraph As ucrRadio
    Friend WithEvents lblYVariable As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents lblSummary As Label
    Friend WithEvents lblColors As Label
    Friend WithEvents lblXVariables As Label
    Friend WithEvents ucrColors1 As ucrColors
    Friend WithEvents UcrCheck1 As ucrCheck
    Friend WithEvents ucrSummaryCheck As ucrCheck
    Friend WithEvents ucrReceiverSingleYVar As ucrReceiverSingle
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents ucrYesToGraph As ucrRadio
End Class
