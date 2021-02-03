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
        Me.lblStats = New System.Windows.Forms.Label()
        Me.ucrInputStats = New instat.ucrInputComboBox()
        Me.ucrChkPercentages = New instat.ucrCheck()
        Me.ucrSavePlot = New instat.ucrSave()
        Me.ucrFactorReceiver = New instat.ucrReceiverSingle()
        Me.cmdDensityOptions = New System.Windows.Forms.Button()
        Me.cmdOptions = New System.Windows.Forms.Button()
        Me.ucrDensitySelector = New instat.ucrSelectorByDataFrameAddRemove()
        Me.lblfactor = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ucrVariablesAsFactorforHist = New instat.ucrVariablesAsFactor()
        Me.SuspendLayout()
        '
        'ucrBase
        '
        Me.ucrBase.Location = New System.Drawing.Point(7, 334)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(410, 52)
        Me.ucrBase.TabIndex = 0
        '
        'lblStats
        '
        Me.lblStats.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblStats.Location = New System.Drawing.Point(14, 263)
        Me.lblStats.Name = "lblStats"
        Me.lblStats.Size = New System.Drawing.Size(32, 18)
        Me.lblStats.TabIndex = 20
        Me.lblStats.Text = "Stats"
        '
        'ucrInputStats
        '
        Me.ucrInputStats.AddQuotesIfUnrecognised = True
        Me.ucrInputStats.GetSetSelectedIndex = -1
        Me.ucrInputStats.IsReadOnly = False
        Me.ucrInputStats.Location = New System.Drawing.Point(57, 255)
        Me.ucrInputStats.Margin = New System.Windows.Forms.Padding(5)
        Me.ucrInputStats.Name = "ucrInputStats"
        Me.ucrInputStats.Size = New System.Drawing.Size(137, 21)
        Me.ucrInputStats.TabIndex = 21
        '
        'ucrChkPercentages
        '
        Me.ucrChkPercentages.Checked = False
        Me.ucrChkPercentages.Location = New System.Drawing.Point(203, 261)
        Me.ucrChkPercentages.Margin = New System.Windows.Forms.Padding(4)
        Me.ucrChkPercentages.Name = "ucrChkPercentages"
        Me.ucrChkPercentages.Size = New System.Drawing.Size(100, 20)
        Me.ucrChkPercentages.TabIndex = 23
        '
        'ucrSavePlot
        '
        Me.ucrSavePlot.Location = New System.Drawing.Point(14, 297)
        Me.ucrSavePlot.Margin = New System.Windows.Forms.Padding(5)
        Me.ucrSavePlot.Name = "ucrSavePlot"
        Me.ucrSavePlot.Size = New System.Drawing.Size(255, 24)
        Me.ucrSavePlot.TabIndex = 22
        '
        'ucrFactorReceiver
        '
        Me.ucrFactorReceiver.frmParent = Me
        Me.ucrFactorReceiver.Location = New System.Drawing.Point(251, 186)
        Me.ucrFactorReceiver.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrFactorReceiver.Name = "ucrFactorReceiver"
        Me.ucrFactorReceiver.Selector = Nothing
        Me.ucrFactorReceiver.Size = New System.Drawing.Size(125, 20)
        Me.ucrFactorReceiver.strNcFilePath = ""
        Me.ucrFactorReceiver.TabIndex = 17
        Me.ucrFactorReceiver.ucrSelector = Nothing
        '
        'cmdDensityOptions
        '
        Me.cmdDensityOptions.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdDensityOptions.Location = New System.Drawing.Point(14, 191)
        Me.cmdDensityOptions.Name = "cmdDensityOptions"
        Me.cmdDensityOptions.Size = New System.Drawing.Size(120, 25)
        Me.cmdDensityOptions.TabIndex = 18
        Me.cmdDensityOptions.Tag = "Density_Options"
        Me.cmdDensityOptions.Text = "Density Options"
        Me.cmdDensityOptions.UseVisualStyleBackColor = True
        '
        'cmdOptions
        '
        Me.cmdOptions.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdOptions.Location = New System.Drawing.Point(14, 222)
        Me.cmdOptions.Name = "cmdOptions"
        Me.cmdOptions.Size = New System.Drawing.Size(120, 25)
        Me.cmdOptions.TabIndex = 19
        Me.cmdOptions.Tag = "Options"
        Me.cmdOptions.Text = "Plot Options"
        Me.cmdOptions.UseVisualStyleBackColor = True
        '
        'ucrDensitySelector
        '
        Me.ucrDensitySelector.bDropUnusedFilterLevels = False
        Me.ucrDensitySelector.bShowHiddenColumns = False
        Me.ucrDensitySelector.bUseCurrentFilter = True
        Me.ucrDensitySelector.Location = New System.Drawing.Point(14, 3)
        Me.ucrDensitySelector.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrDensitySelector.Name = "ucrDensitySelector"
        Me.ucrDensitySelector.Size = New System.Drawing.Size(214, 180)
        Me.ucrDensitySelector.TabIndex = 14
        '
        'lblfactor
        '
        Me.lblfactor.AutoSize = True
        Me.lblfactor.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblfactor.Location = New System.Drawing.Point(251, 171)
        Me.lblfactor.Name = "lblfactor"
        Me.lblfactor.Size = New System.Drawing.Size(85, 13)
        Me.lblfactor.TabIndex = 16
        Me.lblfactor.Tag = "Factor_Selected:"
        Me.lblfactor.Text = "Factor Selected:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(248, 40)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 13)
        Me.Label1.TabIndex = 26
        Me.Label1.Text = "Label1"
        '
        'ucrVariablesAsFactorforHist
        '
        Me.ucrVariablesAsFactorforHist.frmParent = Me
        Me.ucrVariablesAsFactorforHist.Location = New System.Drawing.Point(251, 58)
        Me.ucrVariablesAsFactorforHist.Margin = New System.Windows.Forms.Padding(5)
        Me.ucrVariablesAsFactorforHist.Name = "ucrVariablesAsFactorforHist"
        Me.ucrVariablesAsFactorforHist.Selector = Nothing
        Me.ucrVariablesAsFactorforHist.Size = New System.Drawing.Size(125, 97)
        Me.ucrVariablesAsFactorforHist.strNcFilePath = ""
        Me.ucrVariablesAsFactorforHist.TabIndex = 27
        Me.ucrVariablesAsFactorforHist.ucrSelector = Nothing
        Me.ucrVariablesAsFactorforHist.ucrVariableSelector = Nothing
        '
        'dlgCircularDensityPlot
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(412, 392)
        Me.Controls.Add(Me.ucrVariablesAsFactorforHist)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblStats)
        Me.Controls.Add(Me.ucrInputStats)
        Me.Controls.Add(Me.ucrChkPercentages)
        Me.Controls.Add(Me.ucrSavePlot)
        Me.Controls.Add(Me.ucrFactorReceiver)
        Me.Controls.Add(Me.cmdDensityOptions)
        Me.Controls.Add(Me.cmdOptions)
        Me.Controls.Add(Me.ucrDensitySelector)
        Me.Controls.Add(Me.lblfactor)
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
    Friend WithEvents lblStats As Label
    Friend WithEvents ucrInputStats As ucrInputComboBox
    Friend WithEvents ucrChkPercentages As ucrCheck
    Friend WithEvents ucrSavePlot As ucrSave
    Friend WithEvents ucrFactorReceiver As ucrReceiverSingle
    Friend WithEvents cmdDensityOptions As Button
    Friend WithEvents cmdOptions As Button
    Friend WithEvents ucrDensitySelector As ucrSelectorByDataFrameAddRemove
    Friend WithEvents lblfactor As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents ucrVariablesAsFactorforHist As ucrVariablesAsFactor
End Class
