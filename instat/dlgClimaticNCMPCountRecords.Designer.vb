﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class dlgClimaticNCMPCountRecords
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
        Me.ucrSaveCountRecords = New instat.ucrSave()
        Me.ucrSelectorForA4 = New instat.ucrDataFrame()
        Me.cmdStationMetadata = New System.Windows.Forms.Button()
        Me.grpOptions = New System.Windows.Forms.GroupBox()
        Me.ucrChkEndYear = New instat.ucrCheck()
        Me.ucrChkStartYear = New instat.ucrCheck()
        Me.ucrNudNYE = New instat.ucrNud()
        Me.ucrNudNYB = New instat.ucrNud()
        Me.lblStation = New System.Windows.Forms.Label()
        Me.ucrReceiverMonth = New instat.ucrReceiverSingle()
        Me.ucrReceiverYear = New instat.ucrReceiverSingle()
        Me.lblMonth = New System.Windows.Forms.Label()
        Me.lblYear = New System.Windows.Forms.Label()
        Me.ucrReceiverStation = New instat.ucrReceiverSingle()
        Me.ucrSelectorForA2 = New instat.ucrSelectorByDataFrameAddRemove()
        Me.grpOptions.SuspendLayout()
        Me.SuspendLayout()
        '
        'ucrSaveCountRecords
        '
        Me.ucrSaveCountRecords.Location = New System.Drawing.Point(10, 333)
        Me.ucrSaveCountRecords.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ucrSaveCountRecords.Name = "ucrSaveCountRecords"
        Me.ucrSaveCountRecords.Size = New System.Drawing.Size(289, 22)
        Me.ucrSaveCountRecords.TabIndex = 10
        '
        'ucrSelectorForA4
        '
        Me.ucrSelectorForA4.bDropUnusedFilterLevels = False
        Me.ucrSelectorForA4.bUseCurrentFilter = True
        Me.ucrSelectorForA4.Location = New System.Drawing.Point(10, 201)
        Me.ucrSelectorForA4.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrSelectorForA4.Name = "ucrSelectorForA4"
        Me.ucrSelectorForA4.Size = New System.Drawing.Size(151, 50)
        Me.ucrSelectorForA4.TabIndex = 8
        '
        'cmdStationMetadata
        '
        Me.cmdStationMetadata.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdStationMetadata.Location = New System.Drawing.Point(254, 181)
        Me.cmdStationMetadata.Name = "cmdStationMetadata"
        Me.cmdStationMetadata.Size = New System.Drawing.Size(120, 23)
        Me.cmdStationMetadata.TabIndex = 7
        Me.cmdStationMetadata.Text = "Station Metadata"
        Me.cmdStationMetadata.UseVisualStyleBackColor = True
        '
        'grpOptions
        '
        Me.grpOptions.Controls.Add(Me.ucrChkEndYear)
        Me.grpOptions.Controls.Add(Me.ucrChkStartYear)
        Me.grpOptions.Controls.Add(Me.ucrNudNYE)
        Me.grpOptions.Controls.Add(Me.ucrNudNYB)
        Me.grpOptions.Location = New System.Drawing.Point(10, 252)
        Me.grpOptions.Name = "grpOptions"
        Me.grpOptions.Size = New System.Drawing.Size(258, 73)
        Me.grpOptions.TabIndex = 9
        Me.grpOptions.TabStop = False
        Me.grpOptions.Text = "Options"
        '
        'ucrChkEndYear
        '
        Me.ucrChkEndYear.Checked = False
        Me.ucrChkEndYear.Location = New System.Drawing.Point(6, 46)
        Me.ucrChkEndYear.Name = "ucrChkEndYear"
        Me.ucrChkEndYear.Size = New System.Drawing.Size(187, 20)
        Me.ucrChkEndYear.TabIndex = 2
        '
        'ucrChkStartYear
        '
        Me.ucrChkStartYear.Checked = False
        Me.ucrChkStartYear.Location = New System.Drawing.Point(6, 20)
        Me.ucrChkStartYear.Name = "ucrChkStartYear"
        Me.ucrChkStartYear.Size = New System.Drawing.Size(187, 20)
        Me.ucrChkStartYear.TabIndex = 0
        '
        'ucrNudNYE
        '
        Me.ucrNudNYE.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudNYE.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudNYE.Location = New System.Drawing.Point(199, 45)
        Me.ucrNudNYE.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudNYE.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudNYE.Name = "ucrNudNYE"
        Me.ucrNudNYE.Size = New System.Drawing.Size(50, 20)
        Me.ucrNudNYE.TabIndex = 3
        Me.ucrNudNYE.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrNudNYB
        '
        Me.ucrNudNYB.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudNYB.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudNYB.Location = New System.Drawing.Point(199, 19)
        Me.ucrNudNYB.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudNYB.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudNYB.Name = "ucrNudNYB"
        Me.ucrNudNYB.Size = New System.Drawing.Size(50, 20)
        Me.ucrNudNYB.TabIndex = 1
        Me.ucrNudNYB.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'lblStation
        '
        Me.lblStation.AutoSize = True
        Me.lblStation.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblStation.Location = New System.Drawing.Point(253, 45)
        Me.lblStation.Name = "lblStation"
        Me.lblStation.Size = New System.Drawing.Size(43, 13)
        Me.lblStation.TabIndex = 1
        Me.lblStation.Text = "Station:"
        '
        'ucrReceiverMonth
        '
        Me.ucrReceiverMonth.frmParent = Me
        Me.ucrReceiverMonth.Location = New System.Drawing.Point(254, 148)
        Me.ucrReceiverMonth.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverMonth.Name = "ucrReceiverMonth"
        Me.ucrReceiverMonth.Selector = Nothing
        Me.ucrReceiverMonth.Size = New System.Drawing.Size(120, 20)
        Me.ucrReceiverMonth.strNcFilePath = ""
        Me.ucrReceiverMonth.TabIndex = 6
        Me.ucrReceiverMonth.ucrSelector = Nothing
        '
        'ucrReceiverYear
        '
        Me.ucrReceiverYear.frmParent = Me
        Me.ucrReceiverYear.Location = New System.Drawing.Point(254, 104)
        Me.ucrReceiverYear.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverYear.Name = "ucrReceiverYear"
        Me.ucrReceiverYear.Selector = Nothing
        Me.ucrReceiverYear.Size = New System.Drawing.Size(120, 20)
        Me.ucrReceiverYear.strNcFilePath = ""
        Me.ucrReceiverYear.TabIndex = 4
        Me.ucrReceiverYear.ucrSelector = Nothing
        '
        'lblMonth
        '
        Me.lblMonth.AutoSize = True
        Me.lblMonth.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblMonth.Location = New System.Drawing.Point(253, 133)
        Me.lblMonth.Name = "lblMonth"
        Me.lblMonth.Size = New System.Drawing.Size(40, 13)
        Me.lblMonth.TabIndex = 5
        Me.lblMonth.Text = "Month:"
        '
        'lblYear
        '
        Me.lblYear.AutoSize = True
        Me.lblYear.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblYear.Location = New System.Drawing.Point(253, 89)
        Me.lblYear.Name = "lblYear"
        Me.lblYear.Size = New System.Drawing.Size(32, 13)
        Me.lblYear.TabIndex = 3
        Me.lblYear.Text = "Year:"
        '
        'ucrReceiverStation
        '
        Me.ucrReceiverStation.frmParent = Me
        Me.ucrReceiverStation.Location = New System.Drawing.Point(254, 60)
        Me.ucrReceiverStation.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverStation.Name = "ucrReceiverStation"
        Me.ucrReceiverStation.Selector = Nothing
        Me.ucrReceiverStation.Size = New System.Drawing.Size(120, 20)
        Me.ucrReceiverStation.strNcFilePath = ""
        Me.ucrReceiverStation.TabIndex = 2
        Me.ucrReceiverStation.ucrSelector = Nothing
        '
        'ucrSelectorForA2
        '
        Me.ucrSelectorForA2.bDropUnusedFilterLevels = False
        Me.ucrSelectorForA2.bShowHiddenColumns = False
        Me.ucrSelectorForA2.bUseCurrentFilter = True
        Me.ucrSelectorForA2.Location = New System.Drawing.Point(10, 10)
        Me.ucrSelectorForA2.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrSelectorForA2.Name = "ucrSelectorForA2"
        Me.ucrSelectorForA2.Size = New System.Drawing.Size(210, 180)
        Me.ucrSelectorForA2.TabIndex = 0
        '
        'dlgClimaticNCMPCountRecords
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(397, 432)
        Me.Controls.Add(Me.ucrSaveCountRecords)
        Me.Controls.Add(Me.ucrSelectorForA4)
        Me.Controls.Add(Me.cmdStationMetadata)
        Me.Controls.Add(Me.grpOptions)
        Me.Controls.Add(Me.lblStation)
        Me.Controls.Add(Me.ucrReceiverMonth)
        Me.Controls.Add(Me.ucrReceiverYear)
        Me.Controls.Add(Me.lblMonth)
        Me.Controls.Add(Me.lblYear)
        Me.Controls.Add(Me.ucrReceiverStation)
        Me.Controls.Add(Me.ucrSelectorForA2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgClimaticNCMPCountRecords"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "NCMP Count Records"
        Me.grpOptions.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrSaveCountRecords As ucrSave
    Friend WithEvents ucrSelectorForA4 As ucrDataFrame
    Friend WithEvents cmdStationMetadata As Button
    Friend WithEvents grpOptions As GroupBox
    Friend WithEvents ucrChkEndYear As ucrCheck
    Friend WithEvents ucrChkStartYear As ucrCheck
    Friend WithEvents ucrNudNYE As ucrNud
    Friend WithEvents ucrNudNYB As ucrNud
    Friend WithEvents lblStation As Label
    Friend WithEvents ucrReceiverMonth As ucrReceiverSingle
    Friend WithEvents ucrReceiverYear As ucrReceiverSingle
    Friend WithEvents lblMonth As Label
    Friend WithEvents lblYear As Label
    Friend WithEvents ucrReceiverStation As ucrReceiverSingle
    Friend WithEvents ucrSelectorForA2 As ucrSelectorByDataFrameAddRemove
End Class