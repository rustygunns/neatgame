Public Class frmMain

    Private Sub btnNeat_Click(sender As Object, e As EventArgs)
        MessageBox.Show("Thats Pretty Neat", "Neat")
    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles radGreenShirt.CheckedChanged

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

    End Sub

    Private Sub radRyan_CheckedChanged(sender As Object, e As EventArgs) Handles radRyan.CheckedChanged

        If radRyan.Checked = True And radRedShirt.Checked = True And radRedPants.Checked = True Then
            picRyanRedRed.Visible = True
        Else
            picRyanRedRed.Visible = False
        End If

    End Sub
End Class
