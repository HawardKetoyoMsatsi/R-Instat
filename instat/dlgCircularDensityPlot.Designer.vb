<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class dlgCircularDensityPlot
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.ucrBase = New instat.ucrButtons()
        Me.ucrSelectorDataFrame = New instat.ucrSelectorByDataFrameAddRemove()
        Me.ucrReceiverVariable = New instat.ucrReceiverSingle()
        Me.lblVariable = New System.Windows.Forms.Label()
        Me.ucrSaveDensity = New instat.ucrSave()
        Me.ucrChkOmitMissing = New instat.ucrCheck()
        Me.ucrInputBandWidth = New instat.ucrInputTextBox()
        Me.lblBandWidth = New System.Windows.Forms.Label()
        Me.ucrInputComboKernel = New instat.ucrInputComboBox()
        Me.lblKernel = New System.Windows.Forms.Label()
        Me.rdoScatterPlot = New System.Windows.Forms.RadioButton()
        Me.rdoDensity = New System.Windows.Forms.RadioButton()
        Me.rdoRosePlot = New System.Windows.Forms.RadioButton()
        Me.ucrPnlOptions = New instat.UcrPanel()
        Me.lblUnits = New System.Windows.Forms.Label()
        Me.ucrInputUnits = New instat.ucrInputComboBox()
        Me.SuspendLayout()
        '
        'ucrBase
        '
        Me.ucrBase.Location = New System.Drawing.Point(5, 328)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(410, 52)
        Me.ucrBase.TabIndex = 0
        '
        'ucrSelectorDataFrame
        '
        Me.ucrSelectorDataFrame.bDropUnusedFilterLevels = False
        Me.ucrSelectorDataFrame.bShowHiddenColumns = False
        Me.ucrSelectorDataFrame.bUseCurrentFilter = True
        Me.ucrSelectorDataFrame.Location = New System.Drawing.Point(13, 50)
        Me.ucrSelectorDataFrame.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrSelectorDataFrame.Name = "ucrSelectorDataFrame"
        Me.ucrSelectorDataFrame.Size = New System.Drawing.Size(210, 180)
        Me.ucrSelectorDataFrame.TabIndex = 1
        '
        'ucrReceiverVariable
        '
        Me.ucrReceiverVariable.frmParent = Me
        Me.ucrReceiverVariable.Location = New System.Drawing.Point(292, 64)
        Me.ucrReceiverVariable.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverVariable.Name = "ucrReceiverVariable"
        Me.ucrReceiverVariable.Selector = Nothing
        Me.ucrReceiverVariable.Size = New System.Drawing.Size(120, 20)
        Me.ucrReceiverVariable.strNcFilePath = ""
        Me.ucrReceiverVariable.TabIndex = 2
        Me.ucrReceiverVariable.ucrSelector = Nothing
        '
        'lblVariable
        '
        Me.lblVariable.AutoSize = True
        Me.lblVariable.Location = New System.Drawing.Point(288, 50)
        Me.lblVariable.Name = "lblVariable"
        Me.lblVariable.Size = New System.Drawing.Size(48, 13)
        Me.lblVariable.TabIndex = 3
        Me.lblVariable.Text = "Variable:"
        '
        'ucrSaveDensity
        '
        Me.ucrSaveDensity.Location = New System.Drawing.Point(13, 297)
        Me.ucrSaveDensity.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ucrSaveDensity.Name = "ucrSaveDensity"
        Me.ucrSaveDensity.Size = New System.Drawing.Size(249, 21)
        Me.ucrSaveDensity.TabIndex = 4
        '
        'ucrChkOmitMissing
        '
        Me.ucrChkOmitMissing.Checked = False
        Me.ucrChkOmitMissing.Location = New System.Drawing.Point(13, 269)
        Me.ucrChkOmitMissing.Name = "ucrChkOmitMissing"
        Me.ucrChkOmitMissing.Size = New System.Drawing.Size(170, 20)
        Me.ucrChkOmitMissing.TabIndex = 5
        '
        'ucrInputBandWidth
        '
        Me.ucrInputBandWidth.AddQuotesIfUnrecognised = True
        Me.ucrInputBandWidth.IsMultiline = False
        Me.ucrInputBandWidth.IsReadOnly = False
        Me.ucrInputBandWidth.Location = New System.Drawing.Point(355, 209)
        Me.ucrInputBandWidth.Name = "ucrInputBandWidth"
        Me.ucrInputBandWidth.Size = New System.Drawing.Size(56, 21)
        Me.ucrInputBandWidth.TabIndex = 6
        '
        'lblBandWidth
        '
        Me.lblBandWidth.AutoSize = True
        Me.lblBandWidth.Location = New System.Drawing.Point(273, 212)
        Me.lblBandWidth.Name = "lblBandWidth"
        Me.lblBandWidth.Size = New System.Drawing.Size(63, 13)
        Me.lblBandWidth.TabIndex = 7
        Me.lblBandWidth.Text = "Bandwidth: "
        '
        'ucrInputComboKernel
        '
        Me.ucrInputComboKernel.AddQuotesIfUnrecognised = True
        Me.ucrInputComboKernel.GetSetSelectedIndex = -1
        Me.ucrInputComboKernel.IsReadOnly = False
        Me.ucrInputComboKernel.Location = New System.Drawing.Point(320, 241)
        Me.ucrInputComboKernel.Name = "ucrInputComboKernel"
        Me.ucrInputComboKernel.Size = New System.Drawing.Size(93, 21)
        Me.ucrInputComboKernel.TabIndex = 8
        '
        'lblKernel
        '
        Me.lblKernel.AutoSize = True
        Me.lblKernel.Location = New System.Drawing.Point(272, 245)
        Me.lblKernel.Name = "lblKernel"
        Me.lblKernel.Size = New System.Drawing.Size(43, 13)
        Me.lblKernel.TabIndex = 9
        Me.lblKernel.Text = "Kernel :"
        '
        'rdoScatterPlot
        '
        Me.rdoScatterPlot.Appearance = System.Windows.Forms.Appearance.Button
        Me.rdoScatterPlot.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoScatterPlot.FlatAppearance.BorderSize = 2
        Me.rdoScatterPlot.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoScatterPlot.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rdoScatterPlot.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoScatterPlot.Location = New System.Drawing.Point(271, 11)
        Me.rdoScatterPlot.Name = "rdoScatterPlot"
        Me.rdoScatterPlot.Size = New System.Drawing.Size(125, 28)
        Me.rdoScatterPlot.TabIndex = 13
        Me.rdoScatterPlot.TabStop = True
        Me.rdoScatterPlot.Tag = "ScatterOPlot"
        Me.rdoScatterPlot.Text = "Scatter Plot"
        Me.rdoScatterPlot.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdoScatterPlot.UseVisualStyleBackColor = True
        '
        'rdoDensity
        '
        Me.rdoDensity.Appearance = System.Windows.Forms.Appearance.Button
        Me.rdoDensity.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoDensity.FlatAppearance.BorderSize = 2
        Me.rdoDensity.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoDensity.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rdoDensity.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoDensity.Location = New System.Drawing.Point(148, 11)
        Me.rdoDensity.Name = "rdoDensity"
        Me.rdoDensity.Size = New System.Drawing.Size(125, 28)
        Me.rdoDensity.TabIndex = 12
        Me.rdoDensity.TabStop = True
        Me.rdoDensity.Tag = "Density"
        Me.rdoDensity.Text = "Density"
        Me.rdoDensity.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdoDensity.UseVisualStyleBackColor = True
        '
        'rdoRosePlot
        '
        Me.rdoRosePlot.Appearance = System.Windows.Forms.Appearance.Button
        Me.rdoRosePlot.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoRosePlot.FlatAppearance.BorderSize = 2
        Me.rdoRosePlot.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoRosePlot.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rdoRosePlot.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoRosePlot.Location = New System.Drawing.Point(25, 11)
        Me.rdoRosePlot.Name = "rdoRosePlot"
        Me.rdoRosePlot.Size = New System.Drawing.Size(125, 28)
        Me.rdoRosePlot.TabIndex = 11
        Me.rdoRosePlot.TabStop = True
        Me.rdoRosePlot.Tag = "RosePlot"
        Me.rdoRosePlot.Text = "Roseplot"
        Me.rdoRosePlot.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdoRosePlot.UseVisualStyleBackColor = True
        '
        'ucrPnlOptions
        '
        Me.ucrPnlOptions.Location = New System.Drawing.Point(24, 10)
        Me.ucrPnlOptions.Margin = New System.Windows.Forms.Padding(5)
        Me.ucrPnlOptions.Name = "ucrPnlOptions"
        Me.ucrPnlOptions.Size = New System.Drawing.Size(373, 30)
        Me.ucrPnlOptions.TabIndex = 10
        '
        'lblUnits
        '
        Me.lblUnits.AutoSize = True
        Me.lblUnits.Location = New System.Drawing.Point(272, 269)
        Me.lblUnits.Name = "lblUnits"
        Me.lblUnits.Size = New System.Drawing.Size(34, 13)
        Me.lblUnits.TabIndex = 15
        Me.lblUnits.Text = "Units:"
        '
        'ucrInputUnits
        '
        Me.ucrInputUnits.AddQuotesIfUnrecognised = True
        Me.ucrInputUnits.GetSetSelectedIndex = -1
        Me.ucrInputUnits.IsReadOnly = False
        Me.ucrInputUnits.Location = New System.Drawing.Point(320, 265)
        Me.ucrInputUnits.Name = "ucrInputUnits"
        Me.ucrInputUnits.Size = New System.Drawing.Size(93, 21)
        Me.ucrInputUnits.TabIndex = 14
        '
        'dlgCircularDensityPlot
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(420, 392)
        Me.Controls.Add(Me.lblUnits)
        Me.Controls.Add(Me.ucrInputUnits)
        Me.Controls.Add(Me.rdoScatterPlot)
        Me.Controls.Add(Me.rdoDensity)
        Me.Controls.Add(Me.rdoRosePlot)
        Me.Controls.Add(Me.ucrPnlOptions)
        Me.Controls.Add(Me.lblKernel)
        Me.Controls.Add(Me.ucrInputComboKernel)
        Me.Controls.Add(Me.lblBandWidth)
        Me.Controls.Add(Me.ucrInputBandWidth)
        Me.Controls.Add(Me.ucrChkOmitMissing)
        Me.Controls.Add(Me.ucrSaveDensity)
        Me.Controls.Add(Me.lblVariable)
        Me.Controls.Add(Me.ucrReceiverVariable)
        Me.Controls.Add(Me.ucrSelectorDataFrame)
        Me.Controls.Add(Me.ucrBase)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgCircularDensityPlot"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Density Plot"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents ucrSelectorDataFrame As ucrSelectorByDataFrameAddRemove
    Friend WithEvents ucrReceiverVariable As ucrReceiverSingle
    Friend WithEvents ucrSaveDensity As ucrSave
    Friend WithEvents lblVariable As Label
    Friend WithEvents ucrInputBandWidth As ucrInputTextBox
    Friend WithEvents ucrChkOmitMissing As ucrCheck
    Friend WithEvents lblBandWidth As Label
    Friend WithEvents lblKernel As Label
    Friend WithEvents ucrInputComboKernel As ucrInputComboBox
    Friend WithEvents rdoScatterPlot As RadioButton
    Friend WithEvents rdoDensity As RadioButton
    Friend WithEvents rdoRosePlot As RadioButton
    Friend WithEvents ucrPnlOptions As UcrPanel
    Friend WithEvents lblUnits As Label
    Friend WithEvents ucrInputUnits As ucrInputComboBox
End Class
