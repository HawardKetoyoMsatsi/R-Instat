'R-Instat
' Copyright (C) 2015-2017
'
' This program is free software: you can redistribute it and/or modify
' it under the terms of the GNU General Public License as published by
' the Free Software Foundation, either version 3 of the License, or
' (at your option) any later version.
'
' This program is distributed in the hope that it will be useful,
' but WITHOUT ANY WARRANTY; without even the implied warranty of
' MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
' GNU General Public License for more details.
'
' You should have received a copy of the GNU General Public License 
' along with this program.  If not, see <http://www.gnu.org/licenses/>.

Imports instat
Imports instat.Translations
Public Class dlgOtherRosePlots
    Private bFirstLoad As Boolean = True
    Private bReset As Boolean = True

    'R function
    Private clsOtherRosePlots As RFunction
    Private clsMultiplePollutants As RFunction

    Private Sub dlgOtherRosePlots_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        autoTranslate(Me)
        If bFirstLoad Then
            InitiliseDialog()
            bFirstLoad = False
        End If

        If bReset Then
            SetDefaults()
        End If
        SetRCodeForControls(bReset)
        bReset = False
        TestOkEnabled()
    End Sub

    Private Sub InitiliseDialog()
        Dim dctStatisctic As New Dictionary(Of String, String)
        Dim dctFacets As New Dictionary(Of String, String)
        Dim dctColor As New Dictionary(Of String, String)

        ucrBase.clsRsyntax.iCallType = 3

        ucrPnlOptions.AddRadioButton(rdoPercentileRose)
        ucrPnlOptions.AddRadioButton(rdoPolarCluster)
        ucrPnlOptions.AddRadioButton(rdoPolarFrequency)
        ucrPnlOptions.AddRadioButton(rdoPolarPlot)
        ucrPnlOptions.AddRadioButton(rdoPolarAnnulus)

        ucrPnlOptions.AddParameterValuesCondition(rdoPercentileRose, "mymethod", Chr(34) & "percentile_rose" & Chr(34))
        ucrPnlOptions.AddParameterValuesCondition(rdoPolarCluster, "mymethod", Chr(34) & "polar_cluster" & Chr(34))
        ucrPnlOptions.AddParameterValuesCondition(rdoPolarFrequency, "mymethod", Chr(34) & "polar_frequency" & Chr(34))
        ucrPnlOptions.AddParameterValuesCondition(rdoPolarPlot, "mymethod", Chr(34) & "polar_plot" & Chr(34))
        ucrPnlOptions.AddParameterValuesCondition(rdoPolarAnnulus, "mymethod", Chr(34) & "polar_annulus" & Chr(34))

        ucrSelectorOtherRosePlots.SetParameter(New RParameter("mydata", 0))
        ucrSelectorOtherRosePlots.SetParameterIsrfunction()

        UcrReceiverDate.Selector = ucrSelectorOtherRosePlots
        UcrReceiverDate.SetParameter(New RParameter("date_name", 1))
        UcrReceiverDate.SetParameterIsString()

        ucrReceiverWindDirection.Selector = ucrSelectorOtherRosePlots
        ucrReceiverWindDirection.SetParameter(New RParameter("wd_name", 2))
        ucrReceiverWindDirection.SetParameterIsString()

        ucrReceiverWindSpeed.SetParameter(New RParameter("ws_name", 3))
        ucrReceiverWindSpeed.Selector = ucrSelectorOtherRosePlots
        ucrReceiverWindSpeed.SetParameterIsString()

        ucrReceiverPollutant.Selector = ucrSelectorOtherRosePlots
        ucrReceiverPollutant.SetParameterIsString()
        ucrReceiverPollutant.SetLinkedDisplayControl(lblPollutant)

        ucrReceiverMultiplePollutant.Selector = ucrSelectorOtherRosePlots
        ucrReceiverMultiplePollutant.SetParameterIsString()

        ucrInputStatistic.SetParameter(New RParameter("statistic", 6))
        dctStatisctic.Add("Frequency", Chr(34) & "frequency" & Chr(34))
        dctStatisctic.Add("Mean", Chr(34) & "mean" & Chr(34))
        dctStatisctic.Add("Median", Chr(34) & "median" & Chr(34))
        dctStatisctic.Add("Max", Chr(34) & "max" & Chr(34))
        dctStatisctic.Add("StdDev", Chr(34) & "stddev" & Chr(34))
        dctStatisctic.Add("Weighted Mean", Chr(34) & "weighted.mean" & Chr(34))
        ucrInputStatistic.SetItems(dctStatisctic)
        ucrInputStatistic.SetDropDownStyleAsNonEditable()

        ucrInputStatistic.SetLinkedDisplayControl(lblStatistic)

        ucrInputFacets.SetParameter(New RParameter("type", 7))
        dctFacets.Add("Default", Chr(34) & "default" & Chr(34))
        dctFacets.Add("Year", Chr(34) & "year" & Chr(34))
        dctFacets.Add("Hour", Chr(34) & "hour" & Chr(34))
        dctFacets.Add("Month", Chr(34) & "month" & Chr(34))
        dctFacets.Add("Season", Chr(34) & "season" & Chr(34))
        dctFacets.Add("Weekday", Chr(34) & "weekday" & Chr(34))
        dctFacets.Add("Weekend", Chr(34) & "weekend" & Chr(34))
        dctFacets.Add("Monthyear", Chr(34) & "monthyear" & Chr(34))
        dctFacets.Add("Daylight", Chr(34) & "daylight" & Chr(34))
        dctFacets.Add("DST", Chr(34) & "dst" & Chr(34))
        ucrInputFacets.SetItems(dctFacets)
        ucrInputFacets.SetDropDownStyleAsNonEditable()
        ucrInputFacets.SetLinkedDisplayControl(lblFacets)

        ucrInputColor.SetParameter(New RParameter("cols", 8))
        dctColor.Add("Default", Chr(34) & "default" & Chr(34))
        dctColor.Add("Increment", Chr(34) & "increment" & Chr(34))
        dctColor.Add("Heat", Chr(34) & "heat" & Chr(34))
        dctColor.Add("Jet", Chr(34) & "jet" & Chr(34))
        ucrInputColor.SetItems(dctColor)
        ucrInputColor.SetDropDownStyleAsNonEditable()
        ucrInputColor.SetLinkedDisplayControl(lblFacets)

        ucrChkMultiplePollutants.SetText("Multiple Pollutants")
        ucrChkMultiplePollutants.AddParameterValueFunctionNamesCondition(True, "pollutant", "c", True)

        ucrChkTransform.SetText("Transform")
        ucrChkTransform.SetParameter(New RParameter("trans", 9))
        ucrChkTransform.SetValuesCheckedAndUnchecked("TRUE", "FALSE")

        ucrChkIncludePollutant.SetText("Include Pollutant")
        ucrChkIncludePollutant.AddParameterPresentCondition(True, "pollutant", True)


        ucrPnlOptions.AddToLinkedControls(ucrChkIncludePollutant, {rdoPolarFrequency}, bNewLinkedHideIfParameterMissing:=True)
        ucrPnlOptions.AddToLinkedControls(ucrInputFacets, {rdoPolarFrequency, rdoPolarAnnulus, rdoPolarPlot, rdoPercentileRose}, bNewLinkedHideIfParameterMissing:=True, bNewLinkedAddRemoveParameter:=True)
        ucrPnlOptions.AddToLinkedControls(ucrChkTransform, {rdoPolarFrequency}, bNewLinkedHideIfParameterMissing:=True, bNewLinkedAddRemoveParameter:=True)
        ucrPnlOptions.AddToLinkedControls(ucrReceiverPollutant, {rdoPolarAnnulus}, bNewLinkedHideIfParameterMissing:=True)
        ucrPnlOptions.AddToLinkedControls(ucrChkMultiplePollutants, {rdoPolarAnnulus, rdoPolarPlot}, bNewLinkedHideIfParameterMissing:=True)


        ucrChkIncludePollutant.AddToLinkedControls(ucrReceiverPollutant, {True}, bNewLinkedHideIfParameterMissing:=True)
        ucrChkIncludePollutant.AddToLinkedControls(ucrInputStatistic, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:=Chr(34) & "mean" & Chr(34))
        ucrChkMultiplePollutants.AddToLinkedControls(ucrReceiverMultiplePollutant, {True}, bNewLinkedHideIfParameterMissing:=True)


    End Sub

    Private Sub SetDefaults()
        clsOtherRosePlots = New RFunction
        clsMultiplePollutants = New RFunction

        ucrSelectorOtherRosePlots.Reset()
        UcrReceiverDate.SetMeAsReceiver()
        ucrSaveGraph.Reset()

        clsOtherRosePlots.SetRCommand("other_rose_plots")
        clsOtherRosePlots.AddParameter("mymethod", Chr(34) & "polar_frequency" & Chr(34), iPosition:=4)
        clsOtherRosePlots.AddParameter("type", Chr(34) & "default" & Chr(34), iPosition:=7)
        clsOtherRosePlots.AddParameter("cols", Chr(34) & "default" & Chr(34), iPosition:=7)

        clsMultiplePollutants.SetRCommand("c")

        ucrBase.clsRsyntax.ClearCodes()
        ucrBase.clsRsyntax.SetBaseRFunction(clsOtherRosePlots)
    End Sub

    Private Sub SetRCodeForControls(bReset As Boolean)
        SetRCode(Me, ucrBase.clsRsyntax.clsBaseFunction, bReset)
    End Sub

    Private Sub TestOkEnabled()
        'If Not UcrReceiverDate.IsEmpty AndAlso Not ucrReceiverWindDirection.IsEmpty AndAlso Not ucrReceiverWindSpeed.IsEmpty Then
        '    If rdoPolarPlot.Checked Then
        '        If (Not ucrReceiverMultiplePollutants.IsEmpty AndAlso ucrChkMultiplePollutants.Checked) OrElse (Not ucrReceiverSinglePollutantPPlotandPAnnulus.IsEmpty AndAlso Not ucrChkMultiplePollutants.Checked) Then
        '            ucrBase.OKEnabled(True)
        '        Else
        '            ucrBase.OKEnabled(False)
        '        End If
        '    End If
        '    If rdoPolarFrequency.Checked Then
        '        If (ucrChkIncludePollutant.Checked AndAlso Not ucrReceiverSinglePollutantPolarFreq.IsEmpty) OrElse Not ucrChkIncludePollutant.Checked Then
        '            ucrBase.OKEnabled(True)
        '        Else
        '            ucrBase.OKEnabled(False)
        '        End If
        '    End If

        '    If rdoPolarAnnulus.Checked Then
        '        If (Not ucrReceiverMultiplePollutants.IsEmpty AndAlso ucrChkMultiplePollutants.Checked) OrElse (Not ucrReceiverSinglePollutantPPlotandPAnnulus.IsEmpty AndAlso Not ucrChkMultiplePollutants.Checked) Then
        '            ucrBase.OKEnabled(True)
        '        Else
        '            ucrBase.OKEnabled(False)
        '        End If
        '    End If

        '    If rdoPolarCluster.Checked Then
        '        If Not UcrReceiverSinglePollutantPClusterandPRose.IsEmpty Then
        '            ucrBase.OKEnabled(True)
        '        Else
        '            ucrBase.OKEnabled(False)
        '        End If
        '    End If

        '    If rdoPercentileRose.Checked Then
        '        If Not UcrReceiverSinglePollutantPClusterandPRose.IsEmpty Then
        '            ucrBase.OKEnabled(True)
        '        Else
        '            ucrBase.OKEnabled(False)
        '        End If
        '    End If
        'Else
        '    ucrBase.OKEnabled(False)
        'End If
    End Sub

    Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        SetDefaults()
        SetRCodeForControls(True)
        TestOkEnabled()
        SetDialogOptions()
    End Sub

    Private Sub SetDialogOptions()
        If rdoPolarAnnulus.Checked Then
            clsOtherRosePlots.AddParameter("mymethod", Chr(34) & "polar_annulus" & Chr(34), iPosition:=4)
        ElseIf rdoPolarCluster.Checked Then
            clsOtherRosePlots.AddParameter("mymethod", Chr(34) & "polar_cluster" & Chr(34), iPosition:=4)
        ElseIf rdoPolarFrequency.Checked Then
            clsOtherRosePlots.AddParameter("mymethod", Chr(34) & "polar_frequency" & Chr(34), iPosition:=4)
        ElseIf rdoPolarPlot.Checked Then
            clsOtherRosePlots.AddParameter("mymethod", Chr(34) & "polar_plot" & Chr(34), iPosition:=4)
        ElseIf rdoPercentileRose.Checked Then
            clsOtherRosePlots.AddParameter("mymethod", Chr(34) & "percentile_rose" & Chr(34), iPosition:=4)
        End If
    End Sub
    Private Sub UcrReceiverDate_ControlContentsChanged(ucrChangedControl As ucrCore) Handles UcrReceiverDate.ControlValueChanged, ucrReceiverWindSpeed.ControlValueChanged, ucrReceiverWindDirection.ControlValueChanged
        TestOkEnabled()
    End Sub

    Private Sub ucrPnlOptions_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrPnlOptions.ControlValueChanged
        SetDialogOptions()
    End Sub

    Private Sub Pollutant_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrReceiverPollutant.ControlValueChanged, ucrChkIncludePollutant.ControlValueChanged
        If rdoPolarFrequency.Checked Then
            If ucrChkIncludePollutant.Checked Then
                If Not ucrReceiverPollutant.IsEmpty Then
                    clsOtherRosePlots.AddParameter("pollutant", ucrReceiverPollutant.GetVariableNames(), iPosition:=5)
                Else
                    clsOtherRosePlots.RemoveParameterByName("pollutant")
                End If
            Else
                clsOtherRosePlots.RemoveParameterByName("pollutant")
            End If
        ElseIf rdoPolarAnnulus.checked Then
            AddRemovePollutants()
        End If

    End Sub
    Private Sub AddRemovePollutants()
        If ucrChkMultiplePollutants.Checked Then
            If Not ucrReceiverMultiplePollutant.IsEmpty Then
                Dim iposition As Integer = 0
                For Each i In ucrReceiverMultiplePollutant.GetVariableNamesAsList()
                    clsMultiplePollutants.AddParameter(iposition, Chr(34) & i & Chr(34), iPosition:=iposition, bIncludeArgumentName:=False)
                    iposition = iposition + 1
                Next
            End If
            clsOtherRosePlots.AddParameter("pollutant", clsRFunctionParameter:=clsMultiplePollutants, iPosition:=5)
            ucrReceiverPollutant.Visible = False
        Else
            clsOtherRosePlots.AddParameter("pollutant", ucrReceiverPollutant.GetVariableNames(), iPosition:=5)
            ucrReceiverPollutant.Visible = True
        End If
    End Sub

    Private Sub ucrChkMultiplePollutants_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrChkMultiplePollutants.ControlValueChanged, ucrReceiverMultiplePollutant.ControlValueChanged
        AddRemovePollutants()
    End Sub
End Class