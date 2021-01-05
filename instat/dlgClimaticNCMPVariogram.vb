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
Public Class dlgClimaticNCMPVariogram
    Public bFirstLoad As Boolean = True
    Private bResetSubdialog As Boolean = False
    Private bReset As Boolean = True
    Private clsDefaultFunction As New RFunction

    Private Sub dlgClimaticNCMPVariogram_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If bFirstLoad Then
            InitialiseDialog()
        End If
        If bReset Then
            SetDefaults()
        End If
        SetRCodeForControls(bReset)
        If bFirstLoad Then
            bFirstLoad = False
        End If
        bReset = False
        autoTranslate(Me)
        TestOkEnabled()
    End Sub

    Private Sub InitialiseDialog()
        ucrSelectorVariogram.SetParameter(New RParameter("df", 0))
        ucrSelectorVariogram.SetParameterIsrfunction()
        ucrSelectorVariogram.ucrAvailableDataFrames.lblDataFrame.Text = "Indices Data Frames:"

        ucrReceiverStation.SetParameter(New RParameter("station", 1))
        ucrReceiverStation.SetParameterIsString()
        ucrReceiverStation.Selector = ucrSelectorVariogram
        ucrReceiverStation.SetClimaticType("station")
        ucrReceiverStation.bAutoFill = True

        ucrReceiverYear.SetParameter(New RParameter("year", 2))
        ucrReceiverYear.SetParameterIsString()
        ucrReceiverYear.Selector = ucrSelectorVariogram
        ucrReceiverYear.SetClimaticType("year")
        ucrReceiverYear.bAutoFill = True

        ucrReceiverMonth.SetParameter(New RParameter("month", 3))
        ucrReceiverMonth.SetParameterIsString()
        ucrReceiverMonth.Selector = ucrSelectorVariogram
        ucrReceiverMonth.SetClimaticType("month")
        ucrReceiverMonth.bAutoFill = True

        ucrNudNYB.SetParameter(New RParameter("nyb", 4))
        ucrNudNYB.SetMinMax(1900, 2000)
        'ucrNudNYB.SetRDefault(1981)

        ucrNudNYE.SetParameter(New RParameter("nye", 5))
        ucrNudNYE.SetMinMax(2000, 2019) ' TODO: how to set as current year - 1
        'ucrNudNYE.SetRDefault(2010) 

        ucrInputFilePath.SetParameter(New RParameter("ncmp_folder", 11))
        ucrInputFilePath.IsReadOnly = True
    End Sub

    Private Sub SetDefaults()
        clsDefaultFunction = New RFunction

        ucrSelectorVariogram.Reset()
        ucrReceiverStation.SetMeAsReceiver()
        ucrInputFilePath.Reset()
        ucrInputFilePath.SetName("")
        bResetSubdialog = True

        clsDefaultFunction.SetRCommand("p3_variogram")
        '        ucrBase.clsRsyntax.SetBaseRFunction(clsDefaultFunction)
    End Sub

    Private Sub SetRCodeForControls(bReset)
        '     SetRCode(Me, ucrBase.clsRsyntax.clsBaseFunction, bReset)
    End Sub

    Private Sub TestOkEnabled()
        '        If ucrReceiverStation.IsEmpty OrElse ucrReceiverYear.IsEmpty OrElse ucrReceiverMonth.IsEmpty OrElse ucrNudNYB.Value = "" OrElse ucrNudNYE.Value = "" OrElse ucrInputFilePath.IsEmpty Then
        '            ucrBase.TestOKEnabled(False)
        '        Else
        '            ucrBase.TestOKEnabled(True)
        '        End If
    End Sub
    Private Sub cmdStationMetadata_click(sender As Object, e As EventArgs) Handles cmdStationMetadata.Click
        '   sdgClimaticNCMPMetadata.SetRFunction(ucrBase.clsRsyntax, clsDefaultFunction, bReset:=bResetSubdialog)
        sdgClimaticNCMPMetadata.ShowDialog()
        bResetSubdialog = True
    End Sub

    '    Private Sub ucrBase_ClickOk(sender As Object, e As EventArgs)
    '        frmMain.strSaveFilePath = ucrInputFilePath.GetText()
    '        frmMain.clsRecentItems.addToMenu(Replace(ucrInputFilePath.GetText(), "/", "\"))
    '    End Sub

    '  Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
    '      SetDefaults()
    '      SetRCodeForControls(True)
    '      TestOkEnabled()
    '  End Sub

    Private Sub ucrInputFilePath_Click(sender As Object, e As EventArgs) Handles ucrInputFilePath.Click
        If ucrInputFilePath.IsEmpty() Then
            SelectLocationToSave()
        End If
    End Sub

    Private Sub SelectLocationToSave()
        Using dlgSave As New SaveFileDialog
            dlgSave.Title = "Save NCMP Output"
            If ucrInputFilePath.GetText() <> "" Then
                dlgSave.InitialDirectory = ucrInputFilePath.GetText().Replace("/", "\")
            Else
                dlgSave.InitialDirectory = frmMain.clsInstatOptions.strWorkingDirectory
            End If
            If dlgSave.ShowDialog() = DialogResult.OK Then
                ucrInputFilePath.SetName(dlgSave.FileName.Replace("\", "/"))
            End If
            TestOkEnabled()
        End Using
    End Sub

    Private Sub cmdChooseFile_Click(sender As Object, e As EventArgs) Handles cmdChooseFile.Click
        SelectLocationToSave()
    End Sub

    Private Sub CoreControls_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrReceiverStation.ControlContentsChanged, ucrReceiverYear.ControlContentsChanged, ucrReceiverMonth.ControlContentsChanged, ucrNudNYB.ControlContentsChanged, ucrNudNYE.ControlContentsChanged, ucrInputFilePath.ControlContentsChanged
        TestOkEnabled()
    End Sub
End Class