Public Class frmIntroScreen

    'Define Font attributes
    Dim StarterButtonsFont As New System.Drawing.Font("sans serif", 11)
    Dim IntroLabelFont As New System.Drawing.Font("helvetica", 14)

    'Initialize
    Private Sub frmIntroScreen_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'Start button(s) initizialze
        btnOrderPageInit.FlatStyle = FlatStyle.Flat
        btnOrderPageInit.ForeColor = System.Drawing.Color.Black
        btnOrderPageInit.FlatAppearance.BorderColor = System.Drawing.Color.Gray
        btnOrderPageInit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Orange
        btnOrderPageInit.Font = StarterButtonsFont

        btnExtraInfoPageInit.FlatStyle = FlatStyle.Flat
        btnExtraInfoPageInit.ForeColor = System.Drawing.Color.Black
        btnExtraInfoPageInit.FlatAppearance.BorderColor = System.Drawing.Color.Gray
        btnExtraInfoPageInit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Orange
        btnExtraInfoPageInit.Font = StarterButtonsFont

        'Label StytleSheet
        lblStartingInfo.Font = IntroLabelFont
        lblStartingInfo.ForeColor = Color.BlueViolet

    End Sub

    Private Sub btnOrderPageInit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOrderPageInit.Click

        Dim myForm As New frmCustomize
        'show Customization form on button click
        myForm.Show()
        Me.Hide()
    End Sub


    Private Sub btnExtraInfoPageInit_Click(sender As Object, e As EventArgs) Handles btnExtraInfoPageInit.Click

        Dim myForm As New frmInfoPage
        'show Information form on button click
        myForm.Show()
        Me.Hide()
    End Sub
End Class

