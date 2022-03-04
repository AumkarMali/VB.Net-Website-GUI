Public Class frmInfoPage

    Private Sub btnGoToIntro_Click(sender As Object, e As EventArgs) Handles btnGoToIntro.Click
        Dim myForm As New frmIntroScreen
        'show Information form on button click
        myForm.Show()
        Me.Hide()
    End Sub
End Class