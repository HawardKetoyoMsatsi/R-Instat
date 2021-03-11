﻿' R- Instat
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

Imports instat.Translations

Public Class dlgCircularDensityPlot
    Private bFirstLoad As Boolean = True
    Private bReset As Boolean = True
    Private clsDensityFunction As RFunction
    Private clsRecordPlotFunction As RFunction
    Private clsPlotFunction As RFunction
    Private Sub dlgCircularDensityPlot_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If bFirstLoad Then
            InitialiseDialog()
            bFirstLoad = False
        End If
        If bReset Then
            SetDefaults()
        End If
        SetRCodeForControls(bReset)
        bReset = False
        autoTranslate(Me)
        TestOkEnabled()
    End Sub

    Private Sub InitialiseDialog()
        Dim dctKernel As New Dictionary(Of String, String)

        ucrBase.clsRsyntax.iCallType = 3
        ucrBase.clsRsyntax.bExcludeAssignedFunctionOutput = False

        ucrSelectorDataFrame.SetParameter(New RParameter("data", 0))
        ucrSelectorDataFrame.SetParameterIsrfunction()

        ucrReceiverVariable.SetParameter(New RParameter("x", 0))
        ucrReceiverVariable.Selector = ucrSelectorDataFrame
        ucrReceiverVariable.SetParameterIsRFunction()
        ucrReceiverVariable.SetIncludedDataTypes({"numeric"})
        ucrReceiverVariable.strSelectorHeading = "Numerics"

        ucrInputBandWidth.SetParameter(New RParameter("bw", 1))
        ucrInputBandWidth.SetValidationTypeAsNumeric()
        ucrInputBandWidth.AddQuotesIfUnrecognised = False
        ucrInputBandWidth.SetLinkedDisplayControl(lblBandWidth)

        ucrInputComboKernel.SetParameter(New RParameter("kernel", 2))
        dctKernel.Add("vonmises", Chr(34) & "vonmises" & Chr(34))
        dctKernel.Add("wrappednormal", Chr(34) & "wrappednormal" & Chr(34))
        ucrInputComboKernel.SetItems(dctKernel)
        ucrInputComboKernel.SetDropDownStyleAsNonEditable()
        ucrInputComboKernel.SetLinkedDisplayControl(lblKernel)

        ucrChkOmitMissing.SetText("Omit Missing Values")
        ucrChkOmitMissing.SetParameter(New RParameter("na.rm", 3))
        ucrChkOmitMissing.SetText("Omit Missing Values")
        ucrChkOmitMissing.SetValuesCheckedAndUnchecked("TRUE", "FALSE")

        ucrSaveDensity.SetPrefix("circular_density")
        ucrSaveDensity.SetDataFrameSelector(ucrSelectorDataFrame.ucrAvailableDataFrames)
        ucrSaveDensity.SetIsComboBox()
        ucrSaveDensity.SetCheckBoxText("Save Graph")
        ucrSaveDensity.SetSaveTypeAsGraph()
        ucrSaveDensity.SetAssignToIfUncheckedValue("last_graph")

    End Sub

    Private Sub SetDefaults()
        clsDensityFunction = New RFunction
        clsPlotFunction = New RFunction
        clsRecordPlotFunction = New RFunction

        ucrSaveDensity.Reset()
        ucrReceiverVariable.SetMeAsReceiver()
        ucrSelectorDataFrame.Reset()

        clsDensityFunction.SetPackageName("circular")
        clsDensityFunction.SetRCommand("density.circular")
        clsDensityFunction.AddParameter("bw", "25", iPosition:=1)
        clsDensityFunction.AddParameter("kernel", Chr(34) & "vonmises" & Chr(34), iPosition:=2)
        clsDensityFunction.AddParameter("na.rm", "TRUE", iPosition:=3)

        clsPlotFunction.SetRCommand("plot")
        clsPlotFunction.AddParameter("x", clsRFunctionParameter:=clsDensityFunction, bIncludeArgumentName:=False, iPosition:=0)

        clsPlotFunction.AddParameter("main", Chr(34) & " " & Chr(34), bIncludeArgumentName:=True, iPosition:=1)
        clsPlotFunction.AddParameter("xlab", Chr(34) & " " & Chr(34), bIncludeArgumentName:=True, iPosition:=2)
        clsPlotFunction.AddParameter("ylab", Chr(34) & " " & Chr(34), bIncludeArgumentName:=True, iPosition:=3)
        clsPlotFunction.AddParameter("shrink", 1.3, bIncludeArgumentName:=True, iPosition:=4)
        'clsPlotFunction.SetAssignTo("plot")

        clsRecordPlotFunction.SetPackageName("grDevices")
        clsRecordPlotFunction.SetRCommand("recordPlot")
        'clsRecordPlotFunction.AddParameter("load", clsPlotFunction.strAssignTo, bIncludeArgumentName:=False)

        'ucrBase.clsRsyntax.AddToBeforeCodes(clsPlotFunction, 0)
        ucrBase.clsRsyntax.SetBaseRFunction(clsPlotFunction)
    End Sub

    Private Sub SetRCodeForControls(bReset As Boolean)
        'ucrInputBandWidth.AddAdditionalCodeParameterPair(clsDensityFunction, ucrInputBandWidth.GetParameter(), iAdditionalPairNo:=1)
        'ucrChkOmitMissing.AddAdditionalCodeParameterPair(clsDensityFunction, ucrChkOmitMissing.GetParameter(), iAdditionalPairNo:=1)
        'ucrInputComboKernel.AddAdditionalCodeParameterPair(clsDensityFunction, ucrInputComboKernel.GetParameter(), iAdditionalPairNo:=1)

        ucrSaveDensity.SetRCode(clsPlotFunction, bReset)
        ucrReceiverVariable.SetRCode(clsDensityFunction, bReset)
        ucrInputBandWidth.SetRCode(clsDensityFunction, bReset)
        ucrInputComboKernel.SetRCode(clsDensityFunction, bReset)
        ucrChkOmitMissing.SetRCode(clsDensityFunction, bReset)

    End Sub

    Private Sub TestOkEnabled()
        If ucrSaveDensity.IsComplete AndAlso Not ucrReceiverVariable.IsEmpty Then
            ucrBase.OKEnabled(True)
        Else
            ucrBase.OKEnabled(False)
        End If
    End Sub

    Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        SetDefaults()
        SetRCodeForControls(True)
        TestOkEnabled()
    End Sub

    Private Sub CoreControls_ControlContentsChanged() Handles ucrReceiverVariable.ControlContentsChanged, ucrSaveDensity.ControlContentsChanged
        TestOkEnabled()
    End Sub
End Class