<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dlgMachineLearning
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
        Me.lblRVType = New System.Windows.Forms.Label()
        Me.cmdDisplayOptions = New System.Windows.Forms.Button()
        Me.lblModelPreview = New System.Windows.Forms.Label()
        Me.cmdModelOptions = New System.Windows.Forms.Button()
        Me.lblResponseVariable = New System.Windows.Forms.Label()
        Me.ucrTryModelling = New instat.ucrTry()
        Me.ucrModelName = New instat.ucrSave()
        Me.ucrChkConvertToVariate = New instat.ucrCheck()
        Me.ucrInputModelPreview = New instat.ucrInputTextBox()
        Me.ucrReceiverResponseVar = New instat.ucrReceiverSingle()
        Me.ucrSelectorByDataFrameAddRemoveForFitModel = New instat.ucrSelectorByDataFrameAddRemove()
        Me.ucrBase = New instat.ucrButtons()
        Me.lblType = New System.Windows.Forms.Label()
        Me.lblModel = New System.Windows.Forms.Label()
        Me.ucrInputModel = New instat.ucrInputComboBox()
        Me.ucrPnlExplanatoryVariablesOrModel = New instat.UcrPanel()
        Me.grpExplanatory = New System.Windows.Forms.GroupBox()
        Me.rdoExplanatoryModel = New System.Windows.Forms.RadioButton()
        Me.rdoExplanatoryVariable = New System.Windows.Forms.RadioButton()
        Me.grpExplanatory.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblRVType
        '
        Me.lblRVType.AutoSize = True
        Me.lblRVType.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblRVType.Location = New System.Drawing.Point(8, 199)
        Me.lblRVType.Name = "lblRVType"
        Me.lblRVType.Size = New System.Drawing.Size(126, 13)
        Me.lblRVType.TabIndex = 26
        Me.lblRVType.Text = "Response Variable Type:"
        '
        'cmdDisplayOptions
        '
        Me.cmdDisplayOptions.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdDisplayOptions.Location = New System.Drawing.Point(374, 388)
        Me.cmdDisplayOptions.Name = "cmdDisplayOptions"
        Me.cmdDisplayOptions.Size = New System.Drawing.Size(124, 23)
        Me.cmdDisplayOptions.TabIndex = 33
        Me.cmdDisplayOptions.Text = "Display Options"
        Me.cmdDisplayOptions.UseVisualStyleBackColor = True
        '
        'lblModelPreview
        '
        Me.lblModelPreview.AutoSize = True
        Me.lblModelPreview.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblModelPreview.Location = New System.Drawing.Point(8, 365)
        Me.lblModelPreview.Name = "lblModelPreview"
        Me.lblModelPreview.Size = New System.Drawing.Size(80, 13)
        Me.lblModelPreview.TabIndex = 30
        Me.lblModelPreview.Text = "Model Preview:"
        '
        'cmdModelOptions
        '
        Me.cmdModelOptions.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdModelOptions.Location = New System.Drawing.Point(374, 360)
        Me.cmdModelOptions.Name = "cmdModelOptions"
        Me.cmdModelOptions.Size = New System.Drawing.Size(124, 23)
        Me.cmdModelOptions.TabIndex = 32
        Me.cmdModelOptions.Text = "Model Options"
        Me.cmdModelOptions.UseVisualStyleBackColor = True
        '
        'lblResponseVariable
        '
        Me.lblResponseVariable.AutoSize = True
        Me.lblResponseVariable.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblResponseVariable.Location = New System.Drawing.Point(246, 43)
        Me.lblResponseVariable.Name = "lblResponseVariable"
        Me.lblResponseVariable.Size = New System.Drawing.Size(99, 13)
        Me.lblResponseVariable.TabIndex = 19
        Me.lblResponseVariable.Text = "Response Variable:"
        '
        'ucrTryModelling
        '
        Me.ucrTryModelling.Location = New System.Drawing.Point(8, 326)
        Me.ucrTryModelling.Name = "ucrTryModelling"
        Me.ucrTryModelling.RunCommandAsMultipleLines = False
        Me.ucrTryModelling.Size = New System.Drawing.Size(457, 29)
        Me.ucrTryModelling.TabIndex = 29
        '
        'ucrModelName
        '
        Me.ucrModelName.Location = New System.Drawing.Point(8, 389)
        Me.ucrModelName.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ucrModelName.Name = "ucrModelName"
        Me.ucrModelName.Size = New System.Drawing.Size(279, 24)
        Me.ucrModelName.TabIndex = 34
        '
        'ucrChkConvertToVariate
        '
        Me.ucrChkConvertToVariate.Checked = False
        Me.ucrChkConvertToVariate.Location = New System.Drawing.Point(380, 58)
        Me.ucrChkConvertToVariate.Name = "ucrChkConvertToVariate"
        Me.ucrChkConvertToVariate.Size = New System.Drawing.Size(120, 20)
        Me.ucrChkConvertToVariate.TabIndex = 21
        '
        'ucrInputModelPreview
        '
        Me.ucrInputModelPreview.AddQuotesIfUnrecognised = True
        Me.ucrInputModelPreview.IsMultiline = False
        Me.ucrInputModelPreview.IsReadOnly = False
        Me.ucrInputModelPreview.Location = New System.Drawing.Point(104, 361)
        Me.ucrInputModelPreview.Name = "ucrInputModelPreview"
        Me.ucrInputModelPreview.Size = New System.Drawing.Size(261, 21)
        Me.ucrInputModelPreview.TabIndex = 31
        '
        'ucrReceiverResponseVar
        '
        Me.ucrReceiverResponseVar.frmParent = Me
        Me.ucrReceiverResponseVar.Location = New System.Drawing.Point(245, 58)
        Me.ucrReceiverResponseVar.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverResponseVar.Name = "ucrReceiverResponseVar"
        Me.ucrReceiverResponseVar.Selector = Nothing
        Me.ucrReceiverResponseVar.Size = New System.Drawing.Size(120, 20)
        Me.ucrReceiverResponseVar.strNcFilePath = ""
        Me.ucrReceiverResponseVar.TabIndex = 20
        Me.ucrReceiverResponseVar.ucrSelector = Nothing
        '
        'ucrSelectorByDataFrameAddRemoveForFitModel
        '
        Me.ucrSelectorByDataFrameAddRemoveForFitModel.bDropUnusedFilterLevels = False
        Me.ucrSelectorByDataFrameAddRemoveForFitModel.bShowHiddenColumns = False
        Me.ucrSelectorByDataFrameAddRemoveForFitModel.bUseCurrentFilter = True
        Me.ucrSelectorByDataFrameAddRemoveForFitModel.Location = New System.Drawing.Point(8, 10)
        Me.ucrSelectorByDataFrameAddRemoveForFitModel.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrSelectorByDataFrameAddRemoveForFitModel.Name = "ucrSelectorByDataFrameAddRemoveForFitModel"
        Me.ucrSelectorByDataFrameAddRemoveForFitModel.Size = New System.Drawing.Size(215, 180)
        Me.ucrSelectorByDataFrameAddRemoveForFitModel.TabIndex = 18
        '
        'ucrBase
        '
        Me.ucrBase.Location = New System.Drawing.Point(8, 417)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(405, 52)
        Me.ucrBase.TabIndex = 35
        '
        'lblType
        '
        Me.lblType.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblType.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblType.Location = New System.Drawing.Point(157, 199)
        Me.lblType.Name = "lblType"
        Me.lblType.Size = New System.Drawing.Size(79, 16)
        Me.lblType.TabIndex = 27
        '
        'lblModel
        '
        Me.lblModel.AutoSize = True
        Me.lblModel.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblModel.Location = New System.Drawing.Point(8, 223)
        Me.lblModel.Name = "lblModel"
        Me.lblModel.Size = New System.Drawing.Size(39, 13)
        Me.lblModel.TabIndex = 36
        Me.lblModel.Text = "Model:"
        '
        'ucrInputModel
        '
        Me.ucrInputModel.AddQuotesIfUnrecognised = True
        Me.ucrInputModel.GetSetSelectedIndex = -1
        Me.ucrInputModel.IsReadOnly = False
        Me.ucrInputModel.Location = New System.Drawing.Point(53, 221)
        Me.ucrInputModel.Name = "ucrInputModel"
        Me.ucrInputModel.Size = New System.Drawing.Size(110, 21)
        Me.ucrInputModel.TabIndex = 37
        '
        'ucrPnlExplanatoryVariablesOrModel
        '
        Me.ucrPnlExplanatoryVariablesOrModel.Location = New System.Drawing.Point(5, 16)
        Me.ucrPnlExplanatoryVariablesOrModel.Name = "ucrPnlExplanatoryVariablesOrModel"
        Me.ucrPnlExplanatoryVariablesOrModel.Size = New System.Drawing.Size(183, 20)
        Me.ucrPnlExplanatoryVariablesOrModel.TabIndex = 0
        '
        'grpExplanatory
        '
        Me.grpExplanatory.Controls.Add(Me.rdoExplanatoryModel)
        Me.grpExplanatory.Controls.Add(Me.rdoExplanatoryVariable)
        Me.grpExplanatory.Controls.Add(Me.ucrPnlExplanatoryVariablesOrModel)
        Me.grpExplanatory.Location = New System.Drawing.Point(245, 81)
        Me.grpExplanatory.Name = "grpExplanatory"
        Me.grpExplanatory.Size = New System.Drawing.Size(205, 46)
        Me.grpExplanatory.TabIndex = 38
        Me.grpExplanatory.TabStop = False
        Me.grpExplanatory.Tag = "Explanatory"
        Me.grpExplanatory.Text = "Explanatory"
        '
        'rdoExplanatoryModel
        '
        Me.rdoExplanatoryModel.AutoSize = True
        Me.rdoExplanatoryModel.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoExplanatoryModel.Location = New System.Drawing.Point(97, 19)
        Me.rdoExplanatoryModel.Name = "rdoExplanatoryModel"
        Me.rdoExplanatoryModel.Size = New System.Drawing.Size(54, 17)
        Me.rdoExplanatoryModel.TabIndex = 2
        Me.rdoExplanatoryModel.TabStop = True
        Me.rdoExplanatoryModel.Tag = "Last"
        Me.rdoExplanatoryModel.Text = "Model"
        Me.rdoExplanatoryModel.UseVisualStyleBackColor = True
        '
        'rdoExplanatoryVariable
        '
        Me.rdoExplanatoryVariable.AutoSize = True
        Me.rdoExplanatoryVariable.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoExplanatoryVariable.Location = New System.Drawing.Point(10, 19)
        Me.rdoExplanatoryVariable.Name = "rdoExplanatoryVariable"
        Me.rdoExplanatoryVariable.Size = New System.Drawing.Size(68, 17)
        Me.rdoExplanatoryVariable.TabIndex = 1
        Me.rdoExplanatoryVariable.TabStop = True
        Me.rdoExplanatoryVariable.Tag = "First"
        Me.rdoExplanatoryVariable.Text = "Variables"
        Me.rdoExplanatoryVariable.UseVisualStyleBackColor = True
        '
        'dlgMachineLearning
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(510, 471)
        Me.Controls.Add(Me.grpExplanatory)
        Me.Controls.Add(Me.ucrInputModel)
        Me.Controls.Add(Me.lblModel)
        Me.Controls.Add(Me.lblType)
        Me.Controls.Add(Me.lblRVType)
        Me.Controls.Add(Me.ucrTryModelling)
        Me.Controls.Add(Me.ucrModelName)
        Me.Controls.Add(Me.ucrChkConvertToVariate)
        Me.Controls.Add(Me.cmdDisplayOptions)
        Me.Controls.Add(Me.ucrInputModelPreview)
        Me.Controls.Add(Me.lblModelPreview)
        Me.Controls.Add(Me.cmdModelOptions)
        Me.Controls.Add(Me.ucrReceiverResponseVar)
        Me.Controls.Add(Me.lblResponseVariable)
        Me.Controls.Add(Me.ucrSelectorByDataFrameAddRemoveForFitModel)
        Me.Controls.Add(Me.ucrBase)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgMachineLearning"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Machine Learning"
        Me.grpExplanatory.ResumeLayout(False)
        Me.grpExplanatory.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblRVType As Label
    Friend WithEvents ucrTryModelling As ucrTry
    Friend WithEvents ucrModelName As ucrSave
    Friend WithEvents ucrChkConvertToVariate As ucrCheck
    Friend WithEvents cmdDisplayOptions As Button
    Friend WithEvents ucrInputModelPreview As ucrInputTextBox
    Friend WithEvents lblModelPreview As Label
    Friend WithEvents cmdModelOptions As Button
    Friend WithEvents ucrReceiverResponseVar As ucrReceiverSingle
    Friend WithEvents lblResponseVariable As Label
    Friend WithEvents ucrSelectorByDataFrameAddRemoveForFitModel As ucrSelectorByDataFrameAddRemove
    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents ucrInputModel As ucrInputComboBox
    Friend WithEvents lblModel As Label
    Friend WithEvents lblType As Label
    Friend WithEvents grpExplanatory As GroupBox
    Friend WithEvents rdoExplanatoryModel As RadioButton
    Friend WithEvents rdoExplanatoryVariable As RadioButton
    Friend WithEvents ucrPnlExplanatoryVariablesOrModel As UcrPanel
End Class
