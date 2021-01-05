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
Public Class dlgClimaticNCMPSummaryFile
    Public bFirstLoad As Boolean = True
    Private bReset As Boolean = True
    Private clsDefaultFunction As New RFunction

    Private Sub dlgClimaticNCMPSummaryFile_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
        Dim dctResolution As New Dictionary(Of String, String)

        ucrSelectorA2.SetParameter(New RParameter("a2", 0))
        ucrSelectorA2.SetParameterIsRFunction()
        ucrSelectorA2.lblDataFrame.Text = "Indices Data Frames:"

        ucrSelectorA4.SetParameter(New RParameter("a4", 1))
        ucrSelectorA4.SetParameterIsRFunction()
        ucrSelectorA4.lblDataFrame.Text = "Region Average Data Frames:"

        ucrSelectorA6.SetParameter(New RParameter("a6", 2))
        ucrSelectorA6.SetParameterIsRFunction()
        ucrSelectorA6.lblDataFrame.Text = "Count Records Data Frames:"

        ucrChkStartYear.SetText("Specify Start Year for Count Period")
        ucrChkStartYear.AddToLinkedControls(ucrNudNYB, {True}, bNewLinkedHideIfParameterMissing:=True, bNewLinkedAddRemoveParameter:=True)
        ucrChkStartYear.SetDefaultState(False)

        ucrChkEndYear.SetText("Specify End Year for Count Period")
        ucrChkEndYear.AddToLinkedControls(ucrNudNYE, {True}, bNewLinkedHideIfParameterMissing:=True, bNewLinkedAddRemoveParameter:=True)
        ucrChkEndYear.SetDefaultState(False)

        ucrNudNYB.SetParameter(New RParameter("nyb", 3))
        ucrNudNYB.SetMinMax(1900) ' suitable min/max?

        ucrNudNYE.SetParameter(New RParameter("nye", 4))
        ucrNudNYE.SetMinMax(1900) ' suitable min/max?

        ucrInputFilePath.SetParameter(New RParameter("ncmp_folder", 5))
        ucrInputFilePath.IsReadOnly = True
    End Sub

    Private Sub SetDefaults()
        clsDefaultFunction = New RFunction

        ucrSelectorA2.Reset()
        ucrSelectorA4.Reset()
        ucrSelectorA6.Reset()
        ucrInputFilePath.Reset()
        ucrInputFilePath.SetName("")

        clsDefaultFunction.SetRCommand("p7_summary")
        '        ucrBase.clsRsyntax.SetBaseRFunction(clsDefaultFunction)
    End Sub

    Private Sub SetRCodeForControls(bReset)
        '        SetRCode(Me, ucrBase.clsRsyntax.clsBaseFunction, bReset)
    End Sub

    Private Sub TestOkEnabled()
        '        If ucrSelectorA2.cboAvailableDataFrames.Text = "" OrElse ucrSelectorA4.cboAvailableDataFrames.Text = "" OrElse ucrSelectorA6.cboAvailableDataFrames.Text = "" Then
        ' add in checkbox options
        '            ucrBase.TestOKEnabled(False)
        '        Else
        '            ucrBase.TestOKEnabled(True)
        '        End If
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

    Private Sub CoreControls_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrSelectorA2.ControlContentsChanged, ucrSelectorA4.ControlContentsChanged, ucrSelectorA6.ControlContentsChanged, ucrNudNYB.ControlContentsChanged, ucrNudNYE.ControlContentsChanged, ucrInputFilePath.ControlContentsChanged, ucrChkStartYear.ControlContentsChanged, ucrChkEndYear.ControlContentsChanged
        TestOkEnabled()
    End Sub
End Class