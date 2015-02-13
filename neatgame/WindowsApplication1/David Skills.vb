Public Class frmDavidSkills

    Private Sub David_Skills_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub grpPassives_Enter(sender As Object, e As EventArgs) Handles grpRacialBuffs.Enter

    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        frmMain.Visible = True
        Me.Visible = False
    End Sub
End Class