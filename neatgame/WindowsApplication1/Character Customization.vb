Option Strict On
Option Explicit On
Option Infer Off
Public Class frmMain

    Private Sub btnNeat_Click(sender As Object, e As EventArgs)
        MessageBox.Show("Thats Pretty Neat", "Neat")
    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles radGreenShirt.CheckedChanged

        If radDavid.Checked = True And radGreenShirt.Checked = True And radRedPants.Checked = True Then
            picDavidGreenRed.Visible = True
        Else
            picDavidGreenRed.Visible = False
        End If

        If radDavid.Checked = True And radGreenShirt.Checked = True And radBluePants.Checked = True Then
            picDavidGreenBlue.Visible = True
        Else
            picDavidGreenBlue.Visible = False
        End If

        If radDavid.Checked = True And radGreenShirt.Checked = True And radOrangePants.Checked = True Then
            picDavidGreenOrange.Visible = True
        Else
            picDavidGreenOrange.Visible = False
        End If

        If radDavid.Checked = True And radGreenShirt.Checked = True And radGreenPants.Checked = True Then
            picDavidGreenGreen.Visible = True
        Else
            picDavidGreenGreen.Visible = False
        End If

        If radDavid.Checked = True And radGreenShirt.Checked = True And radBlackPants.Checked = True Then
            picDavidGreenBlack.Visible = True
        Else
            picDavidGreenBlack.Visible = False
        End If

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub radDavid_CheckedChanged(sender As Object, e As EventArgs) Handles radDavid.CheckedChanged

        If radDavid.Checked = True And radRedShirt.Checked = True And radRedPants.Checked = True Then
            picDavidRedRed.Visible = True
        Else
            picDavidRedRed.Visible = False
        End If

        If radDavid.Checked = True And radRedShirt.Checked = True And radBluePants.Checked = True Then
            picDavidRedBlue.Visible = True
        Else
            picDavidRedBlue.Visible = False
        End If

        If radDavid.Checked = True And radRedShirt.Checked = True And radGreenPants.Checked = True Then
            picDavidRedGreen.Visible = True
        Else
            picDavidRedGreen.Visible = False
        End If

        If radDavid.Checked = True And radRedShirt.Checked = True And radOrangePants.Checked = True Then
            picDavidRedOrange.Visible = True
        Else
            picDavidRedOrange.Visible = False
        End If

        If radDavid.Checked = True And radBlueShirt.Checked = True And radRedPants.Checked = True Then
            picDavidBlueRed.Visible = True
        Else
            picDavidBlueRed.Visible = False
        End If

        If radDavid.Checked = True And radBlueShirt.Checked = True And radBluePants.Checked = True Then
            picDavidBlueBlue.Visible = True
        Else
            picDavidBlueBlue.Visible = False
        End If

        If radDavid.Checked = True And radBlueShirt.Checked = True And radOrangePants.Checked = True Then
            picDavidBlueOrange.Visible = True
        Else
            picDavidBlueOrange.Visible = False
        End If

        If radDavid.Checked = True And radBlueShirt.Checked = True And radGreenPants.Checked = True Then
            picDavidBlueGreen.Visible = True
        Else
            picDavidBlueGreen.Visible = False
        End If

        If radDavid.Checked = True And radBlueShirt.Checked = True And radBlackPants.Checked = True Then
            picDavidBlueBlack.Visible = True
        Else
            picDavidBlueBlack.Visible = False
        End If

        If radDavid.Checked = True And radRedShirt.Checked = True And radBlackPants.Checked = True Then
            picDavidRedBlack.Visible = True
        Else
            picDavidRedBlack.Visible = False
        End If

        If radDavid.Checked = True And radOrangeShirt.Checked = True And radRedPants.Checked = True Then
            picDavidOrangeRed.Visible = True
        Else
            picDavidOrangeRed.Visible = False
        End If

        If radDavid.Checked = True And radOrangeShirt.Checked = True And radBluePants.Checked = True Then
            picDavidOrangeBlue.Visible = True
        Else
            picDavidOrangeBlue.Visible = False
        End If

        If radDavid.Checked = True And radOrangeShirt.Checked = True And radOrangePants.Checked = True Then
            picDavidOrangeOrange.Visible = True
        Else
            picDavidOrangeOrange.Visible = False
        End If

        If radDavid.Checked = True And radOrangeShirt.Checked = True And radGreenPants.Checked = True Then
            picDavidOrangeGreen.Visible = True
        Else
            picDavidOrangeGreen.Visible = False
        End If

        If radDavid.Checked = True And radOrangeShirt.Checked = True And radBlackPants.Checked = True Then
            picDavidOrangeBlack.Visible = True
        Else
            picDavidOrangeBlack.Visible = False
        End If

        If radDavid.Checked = True And radGreenShirt.Checked = True And radRedPants.Checked = True Then
            picDavidGreenRed.Visible = True
        Else
            picDavidGreenRed.Visible = False
        End If

        If radDavid.Checked = True And radGreenShirt.Checked = True And radBluePants.Checked = True Then
            picDavidGreenBlue.Visible = True
        Else
            picDavidGreenBlue.Visible = False
        End If

        If radDavid.Checked = True And radGreenShirt.Checked = True And radOrangePants.Checked = True Then
            picDavidGreenOrange.Visible = True
        Else
            picDavidGreenOrange.Visible = False
        End If

        If radDavid.Checked = True And radGreenShirt.Checked = True And radGreenPants.Checked = True Then
            picDavidGreenGreen.Visible = True
        Else
            picDavidGreenGreen.Visible = False
        End If

        If radDavid.Checked = True And radGreenShirt.Checked = True And radBlackPants.Checked = True Then
            picDavidGreenBlack.Visible = True
        Else
            picDavidGreenBlack.Visible = False
        End If

        If radDavid.Checked = True And radBlackShirt.Checked = True And radRedPants.Checked = True Then
            picDavidBlackRed.Visible = True
        Else
            picDavidBlackRed.Visible = False
        End If

        If radDavid.Checked = True And radBlackShirt.Checked = True And radBluePants.Checked = True Then
            picDavidBlackBlue.Visible = True
        Else
            picDavidBlackBlue.Visible = False
        End If

        If radDavid.Checked = True And radBlackShirt.Checked = True And radOrangePants.Checked = True Then
            picDavidBlackOrange.Visible = True
        Else
            picDavidBlackOrange.Visible = False
        End If

        If radDavid.Checked = True And radBlackShirt.Checked = True And radGreenPants.Checked = True Then
            picDavidBlackGreen.Visible = True
        Else
            picDavidBlackGreen.Visible = False
        End If

        If radDavid.Checked = True And radBlackShirt.Checked = True And radBlackPants.Checked = True Then
            picDavidBlackBlack.Visible = True
        Else
            picDavidBlackBlack.Visible = False
        End If
    End Sub

    Private Sub btnComplete_Click(sender As Object, e As EventArgs) Handles btnComplete.Click
        If radJake.Checked = True Then
            frmJakeSkills.Visible = True
            Me.Visible = False
        End If
        If radDavid.Checked = True Then
            frmDavidSkills.Visible = True
            Me.Visible = False
        End If
        If radRyan.Checked = True Then
            frmRyanSkills.Visible = True
            Me.Visible = False
        End If
        If radAuggie.Checked = True Then
            frmAuggieSkills.Visible = True
            Me.Visible = False
        End If
        If radZach.Checked = True Then
            frmZachSkills.Visible = True
            Me.Visible = False
        End If
    End Sub

    Private Sub radAuggie_CheckedChanged(sender As Object, e As EventArgs) Handles radAuggie.CheckedChanged

        If radAuggie.Checked = True And radRedShirt.Checked = True And radRedPants.Checked = True Then
            picAuggieRedRed.Visible = True
        Else
            picAuggieRedRed.Visible = False
        End If

    End Sub

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        picAuggieRedRed.Visible = False
        picDavidRedRed.Visible = False
        picDavidRedBlue.Visible = False
        picDavidRedGreen.Visible = False
        picDavidRedOrange.Visible = False
        picDavidBlueRed.Visible = False
        picDavidBlueBlue.Visible = False
        picDavidBlueOrange.Visible = False
        picDavidBlueGreen.Visible = False
        picDavidBlueBlack.Visible = False
        picDavidRedBlack.Visible = False
        picDavidOrangeRed.Visible = False
        picDavidOrangeBlue.Visible = False
        picDavidOrangeOrange.Visible = False
        picDavidOrangeGreen.Visible = False
        picDavidOrangeBlack.Visible = False
        picDavidGreenRed.Visible = False
        picDavidGreenBlue.Visible = False
        picDavidGreenOrange.Visible = False
        picDavidGreenGreen.Visible = False
        picDavidGreenBlack.Visible = False
        picDavidBlackRed.Visible = False
        picDavidBlackBlue.Visible = False
        picDavidBlackOrange.Visible = False
        picDavidBlackGreen.Visible = False
        picDavidBlackBlack.Visible = False
        picRyanRedRed.Visible = False

    End Sub

    Private Sub radRedShirt_CheckedChanged(sender As Object, e As EventArgs) Handles radRedShirt.CheckedChanged
        If radAuggie.Checked = True And radRedShirt.Checked = True And radRedPants.Checked = True Then
            picAuggieRedRed.Visible = True
        Else
            picAuggieRedRed.Visible = False
        End If

        If radDavid.Checked = True And radRedShirt.Checked = True And radRedPants.Checked = True Then
            picDavidRedRed.Visible = True
        Else
            picDavidRedRed.Visible = False
        End If

        If radRyan.Checked = True And radRedShirt.Checked = True And radRedPants.Checked = True Then
            picRyanRedRed.Visible = True
        Else
            picRyanRedRed.Visible = False
        End If

        If radDavid.Checked = True And radRedShirt.Checked = True And radBluePants.Checked = True Then
            picDavidRedBlue.Visible = True
        Else
            picDavidRedBlue.Visible = False
        End If

        If radDavid.Checked = True And radRedShirt.Checked = True And radGreenPants.Checked = True Then
            picDavidRedGreen.Visible = True
        Else
            picDavidRedGreen.Visible = False
        End If

        If radDavid.Checked = True And radRedShirt.Checked = True And radOrangePants.Checked = True Then
            picDavidRedOrange.Visible = True
        Else
            picDavidRedOrange.Visible = False
        End If

        If radDavid.Checked = True And radRedShirt.Checked = True And radBlackPants.Checked = True Then
            picDavidRedBlack.Visible = True
        Else
            picDavidRedBlack.Visible = False
        End If

    End Sub

    Private Sub radRedPants_CheckedChanged(sender As Object, e As EventArgs) Handles radRedPants.CheckedChanged
        If radAuggie.Checked = True And radRedShirt.Checked = True And radRedPants.Checked = True Then
            picAuggieRedRed.Visible = True
        Else
            picAuggieRedRed.Visible = False
        End If

        If radDavid.Checked = True And radRedShirt.Checked = True And radRedPants.Checked = True Then
            picDavidRedRed.Visible = True
        Else
            picDavidRedRed.Visible = False
        End If

        If radRyan.Checked = True And radRedShirt.Checked = True And radRedPants.Checked = True Then
            picRyanRedRed.Visible = True
        Else
            picRyanRedRed.Visible = False
        End If

        If radDavid.Checked = True And radBlueShirt.Checked = True And radRedPants.Checked = True Then
            picDavidBlueRed.Visible = True
        Else
            picDavidBlueRed.Visible = False
        End If

        If radDavid.Checked = True And radOrangeShirt.Checked = True And radRedPants.Checked = True Then
            picDavidOrangeRed.Visible = True
        Else
            picDavidOrangeRed.Visible = False
        End If

        If radDavid.Checked = True And radGreenShirt.Checked = True And radRedPants.Checked = True Then
            picDavidGreenRed.Visible = True
        Else
            picDavidGreenRed.Visible = False
        End If

        If radDavid.Checked = True And radBlackShirt.Checked = True And radRedPants.Checked = True Then
            picDavidBlackRed.Visible = True
        Else
            picDavidBlackRed.Visible = False
        End If

    End Sub

    Private Sub radRyan_CheckedChanged(sender As Object, e As EventArgs) Handles radRyan.CheckedChanged

        If radRyan.Checked = True And radRedShirt.Checked = True And radRedPants.Checked = True Then
            picRyanRedRed.Visible = True
        Else
            picRyanRedRed.Visible = False
        End If

    End Sub

    Private Sub radBluePants_CheckedChanged(sender As Object, e As EventArgs) Handles radBluePants.CheckedChanged

        If radDavid.Checked = True And radRedShirt.Checked = True And radBluePants.Checked = True Then
            picDavidRedBlue.Visible = True
        Else
            picDavidRedBlue.Visible = False
        End If

        If radDavid.Checked = True And radBlueShirt.Checked = True And radBluePants.Checked = True Then
            picDavidBlueBlue.Visible = True
        Else
            picDavidBlueBlue.Visible = False
        End If

        If radDavid.Checked = True And radOrangeShirt.Checked = True And radBluePants.Checked = True Then
            picDavidOrangeBlue.Visible = True
        Else
            picDavidOrangeBlue.Visible = False
        End If

        If radDavid.Checked = True And radGreenShirt.Checked = True And radBluePants.Checked = True Then
            picDavidGreenBlue.Visible = True
        Else
            picDavidGreenBlue.Visible = False
        End If

        If radDavid.Checked = True And radBlackShirt.Checked = True And radBluePants.Checked = True Then
            picDavidBlackBlue.Visible = True
        Else
            picDavidBlackBlue.Visible = False
        End If

    End Sub

    Private Sub radGreenPants_CheckedChanged(sender As Object, e As EventArgs) Handles radGreenPants.CheckedChanged

        If radDavid.Checked = True And radRedShirt.Checked = True And radGreenPants.Checked = True Then
            picDavidRedGreen.Visible = True
        Else
            picDavidRedGreen.Visible = False
        End If

        If radDavid.Checked = True And radBlueShirt.Checked = True And radGreenPants.Checked = True Then
            picDavidBlueGreen.Visible = True
        Else
            picDavidBlueGreen.Visible = False
        End If

        If radDavid.Checked = True And radOrangeShirt.Checked = True And radGreenPants.Checked = True Then
            picDavidOrangeGreen.Visible = True
        Else
            picDavidOrangeGreen.Visible = False
        End If

        If radDavid.Checked = True And radGreenShirt.Checked = True And radGreenPants.Checked = True Then
            picDavidGreenGreen.Visible = True
        Else
            picDavidGreenGreen.Visible = False
        End If

        If radDavid.Checked = True And radBlackShirt.Checked = True And radGreenPants.Checked = True Then
            picDavidBlackGreen.Visible = True
        Else
            picDavidBlackGreen.Visible = False
        End If

    End Sub

    Private Sub radOrangePants_CheckedChanged(sender As Object, e As EventArgs) Handles radOrangePants.CheckedChanged

        If radDavid.Checked = True And radRedShirt.Checked = True And radOrangePants.Checked = True Then
            picDavidRedOrange.Visible = True
        Else
            picDavidRedOrange.Visible = False
        End If

        If radDavid.Checked = True And radBlueShirt.Checked = True And radOrangePants.Checked = True Then
            picDavidBlueOrange.Visible = True
        Else
            picDavidBlueOrange.Visible = False
        End If

        If radDavid.Checked = True And radOrangeShirt.Checked = True And radOrangePants.Checked = True Then
            picDavidOrangeOrange.Visible = True
        Else
            picDavidOrangeOrange.Visible = False
        End If

        If radDavid.Checked = True And radGreenShirt.Checked = True And radOrangePants.Checked = True Then
            picDavidGreenOrange.Visible = True
        Else
            picDavidGreenOrange.Visible = False
        End If

        If radDavid.Checked = True And radBlackShirt.Checked = True And radOrangePants.Checked = True Then
            picDavidBlackOrange.Visible = True
        Else
            picDavidBlackOrange.Visible = False
        End If

    End Sub

    Private Sub radBlueShirt_CheckedChanged(sender As Object, e As EventArgs) Handles radBlueShirt.CheckedChanged

        If radDavid.Checked = True And radBlueShirt.Checked = True And radRedPants.Checked = True Then
            picDavidBlueRed.Visible = True
        Else
            picDavidBlueRed.Visible = False
        End If

        If radDavid.Checked = True And radBlueShirt.Checked = True And radBluePants.Checked = True Then
            picDavidBlueBlue.Visible = True
        Else
            picDavidBlueBlue.Visible = False
        End If

        If radDavid.Checked = True And radBlueShirt.Checked = True And radOrangePants.Checked = True Then
            picDavidBlueOrange.Visible = True
        Else
            picDavidBlueOrange.Visible = False
        End If

        If radDavid.Checked = True And radBlueShirt.Checked = True And radGreenPants.Checked = True Then
            picDavidBlueGreen.Visible = True
        Else
            picDavidBlueGreen.Visible = False
        End If

        If radDavid.Checked = True And radBlueShirt.Checked = True And radBlackPants.Checked = True Then
            picDavidBlueBlack.Visible = True
        Else
            picDavidBlueBlack.Visible = False
        End If

    End Sub

    Private Sub radBlackPants_CheckedChanged(sender As Object, e As EventArgs) Handles radBlackPants.CheckedChanged

        If radDavid.Checked = True And radBlueShirt.Checked = True And radBlackPants.Checked = True Then
            picDavidBlueBlack.Visible = True
        Else
            picDavidBlueBlack.Visible = False
        End If

        If radDavid.Checked = True And radRedShirt.Checked = True And radBlackPants.Checked = True Then
            picDavidRedBlack.Visible = True
        Else
            picDavidRedBlack.Visible = False
        End If

        If radDavid.Checked = True And radOrangeShirt.Checked = True And radBlackPants.Checked = True Then
            picDavidOrangeBlack.Visible = True
        Else
            picDavidOrangeBlack.Visible = False
        End If

        If radDavid.Checked = True And radGreenShirt.Checked = True And radBlackPants.Checked = True Then
            picDavidGreenBlack.Visible = True
        Else
            picDavidGreenBlack.Visible = False
        End If

        If radDavid.Checked = True And radBlackShirt.Checked = True And radBlackPants.Checked = True Then
            picDavidBlackBlack.Visible = True
        Else
            picDavidBlackBlack.Visible = False
        End If

    End Sub

    Private Sub radOrangeShirt_CheckedChanged(sender As Object, e As EventArgs) Handles radOrangeShirt.CheckedChanged

        If radDavid.Checked = True And radOrangeShirt.Checked = True And radRedPants.Checked = True Then
            picDavidOrangeRed.Visible = True
        Else
            picDavidOrangeRed.Visible = False
        End If

        If radDavid.Checked = True And radOrangeShirt.Checked = True And radBluePants.Checked = True Then
            picDavidOrangeBlue.Visible = True
        Else
            picDavidOrangeBlue.Visible = False
        End If

        If radDavid.Checked = True And radOrangeShirt.Checked = True And radOrangePants.Checked = True Then
            picDavidOrangeOrange.Visible = True
        Else
            picDavidOrangeOrange.Visible = False
        End If

        If radDavid.Checked = True And radOrangeShirt.Checked = True And radGreenPants.Checked = True Then
            picDavidOrangeGreen.Visible = True
        Else
            picDavidOrangeGreen.Visible = False
        End If

        If radDavid.Checked = True And radOrangeShirt.Checked = True And radBlackPants.Checked = True Then
            picDavidOrangeBlack.Visible = True
        Else
            picDavidOrangeBlack.Visible = False
        End If

    End Sub

    Private Sub radBlackShirt_CheckedChanged(sender As Object, e As EventArgs) Handles radBlackShirt.CheckedChanged

        If radDavid.Checked = True And radBlackShirt.Checked = True And radRedPants.Checked = True Then
            picDavidBlackRed.Visible = True
        Else
            picDavidBlackRed.Visible = False
        End If

        If radDavid.Checked = True And radBlackShirt.Checked = True And radBluePants.Checked = True Then
            picDavidBlackBlue.Visible = True
        Else
            picDavidBlackBlue.Visible = False
        End If

        If radDavid.Checked = True And radBlackShirt.Checked = True And radOrangePants.Checked = True Then
            picDavidBlackOrange.Visible = True
        Else
            picDavidBlackOrange.Visible = False
        End If

        If radDavid.Checked = True And radBlackShirt.Checked = True And radGreenPants.Checked = True Then
            picDavidBlackGreen.Visible = True
        Else
            picDavidBlackGreen.Visible = False
        End If

        If radDavid.Checked = True And radBlackShirt.Checked = True And radBlackPants.Checked = True Then
            picDavidBlackBlack.Visible = True
        Else
            picDavidBlackBlack.Visible = False
        End If

    End Sub
End Class
