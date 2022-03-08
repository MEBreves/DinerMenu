'Miranda Breves
'RCET0265
'Spring 2022
'Diner Menu Program
'https://github.com/MEBreves/DinerMenu

Option Strict On
Option Explicit On

Public Class DinerMenuForm

    'UI updates for when the user clicks the soup button
    Private Sub SoupButton_Click(sender As Object, e As EventArgs) Handles SoupButton.Click

        'The two picture boxes are set to contain pictures of food and have a tooltip with the food's name on hover
        FoodPicture1.BackgroundImage = My.Resources.Tomato_Basil_Soup
        ToolTip1.SetToolTip(FoodPicture1, "Tomato Basil Soup")
        FoodPicture2.BackgroundImage = My.Resources.Clam_Chowder_Breadbowl
        ToolTip1.SetToolTip(FoodPicture2, "Clam Chowder in a Breadbowl")

        'The label describing the menu specials is updated for the soup selection
        DisplaySpecialLabel.Text = "Monday: Broccoli Cheddar Soup and Salad" &
                                   vbNewLine & "Tuesday: Minestrone with Rolls" &
                                   vbNewLine & "Wednesday: Potato Soup with Bacon Bits and Rolls" &
                                   vbNewLine & "Thursday: Tomato-Basil Soup and Grilled Cheese" &
                                   vbNewLine & "Friday: Clam Chowder in a Breadbowl" &
                                   vbNewLine & "Saturday: Gazpacho Soup with Quesidillas" &
                                   vbNewLine & vbNewLine & "Sunday: Unfortunately, we are closed."

    End Sub
    'UI updates for when the user clicks the soup button
    Private Sub SaladButton_Click(sender As Object, e As EventArgs) Handles SaladButton.Click

        'The two picture boxes are set to contain pictures of food and have a tooltip with the food's name on hover
        FoodPicture1.BackgroundImage = My.Resources.Cobb_Salad
        ToolTip1.SetToolTip(FoodPicture1, "Cobb Salad")
        FoodPicture2.BackgroundImage = My.Resources.Ambrosia
        ToolTip1.SetToolTip(FoodPicture2, "Ambrosia")

        'The label describing the menu specials is updated for the soup selection
        DisplaySpecialLabel.Text = "Our Salads" &
                                   vbNewLine & StrDup(110, "-") &
                                   vbNewLine & "Caesar Salad: Spring Mix with parmesian, croutons, salt, and pepper" &
                                   vbNewLine & "Cobb Salad: Salad greens, tomato, bacon, chicken, avocado, and hard-boiled eggs" &
                                   vbNewLine & "Chicken Garden Salad: Grilled chicken breast with various garden vegetables" &
                                   vbNewLine & "Grilled Shrimp Salad with Avocado: Grilled shrimp on a spring mix with avocado" &
                                   vbNewLine & "Pasta Salad: Rotini pasta with cherry tomatoes, olives, mozzarella, and zucchini" &
                                   vbNewLine & "Ambrosia: A dessert salad with fresh pineapple, mango, orange slices, coconut " &
                                   "shavings, and whipped cream"

    End Sub

    'UI updates for when the user clicks the soup button
    Private Sub FishButton_Click(sender As Object, e As EventArgs) Handles FishButton.Click

        'The two picture boxes are set to contain pictures of food and have a tooltip with the food's name on hover
        FoodPicture1.BackgroundImage = My.Resources.Calamari_and_Tempura
        ToolTip1.SetToolTip(FoodPicture1, "Calamari and Tempura")
        FoodPicture2.BackgroundImage = My.Resources.Salmon_and_Salad
        ToolTip1.SetToolTip(FoodPicture2, "Glazed Salmon and Salad")

        'The label describing the menu specials is updated for the soup selection
        DisplaySpecialLabel.Text = "Fish Specials" &
                                   vbNewLine & StrDup(110, "-") &
                                   vbNewLine & "Crispy Calimari with Tempura" &
                                   vbNewLine & "Panko-breaded and fried squid with tempura battered onions, sweet potato, " &
                                   "broccoli, carrots, zucchini and dipping sauce." &
                                   vbNewLine & vbNewLine & "Glazed Salmon with Mango Salad" &
                                   vbNewLine & "A sweet and tangy pinapple flavored glazed salmon cut with a mango salad " &
                                   "containing mango slices, almonds, a spring mix, and a sweet dressing."

    End Sub

    'Exits the program when user clicks the exit button
    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Me.Close()
    End Sub

End Class