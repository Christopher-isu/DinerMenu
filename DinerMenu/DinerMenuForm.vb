'ChristopherZ
'Spring 2025
'RCET2265
'Diner Menu
'https://github.com/Christopher-isu/DinerMenu.git
Public Class DinerMenuForm
    Private Sub SoupButton_Click(sender As Object, e As EventArgs) Handles SoupButton.Click
        ' This is the code that runs when the SoupButton is clicked
        DisplaySpecialLabel.Text = "- 300ml of reclaimed water -" & Environment.NewLine &
                                   "- 500mg of yellow bacterial goo -" & Environment.NewLine &
                                   "- picture of a soup to look at while you eat it -"
        DisplaySpecialLabel.TextAlign = ContentAlignment.MiddleCenter ' This centers the text in the label
    End Sub

    Private Sub SaladButton_Click(sender As Object, e As EventArgs) Handles SaladButton.Click
        ' This is the code that runs when the SaladButton is clicked
        DisplaySpecialLabel.Text = "- 300ml of reclaimed water -" & Environment.NewLine &
                                   "- 500mg of green bacterial goo -" & Environment.NewLine &
                                   "- picture of a salad to look at while you eat it -"
        DisplaySpecialLabel.TextAlign = ContentAlignment.MiddleCenter ' This centers the text in the label
    End Sub

    Private Sub FishButton_Click(sender As Object, e As EventArgs) Handles FishButton.Click
        ' This is the code that runs when the FishButton is clicked
        DisplaySpecialLabel.Text = "- 300ml of reclaimed water -" & Environment.NewLine &
                                   "- 500mg of blue bacterial goo -" & Environment.NewLine &
                                   "- picture of a fish to look at while you eat it -"
        DisplaySpecialLabel.TextAlign = ContentAlignment.MiddleCenter ' This centers the text in the label
    End Sub

    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        ' This is the code that runs when the ExitButton is clicked
        Me.Close() ' This closes the form
    End Sub

End Class
