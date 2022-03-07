'Miranda Breves
'RCET0265
'Spring 2022
'Diner Menu Program
'github url

Option Strict On
Option Explicit On

Public Class DinerMenuForm
    Private Sub DinerMenuForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DisplaySpecialLabel.Text = ""
    End Sub

    Private Sub SoupButton_Click(sender As Object, e As EventArgs) Handles SoupButton.Click

        DisplaySpecialLabel.Text = "Monday: Broccoli Cheddar Soup and Salad" &
                                   vbNewLine & "Tuesday: Minestrone with Rolls" &
                                   vbNewLine & "Wednesday: Potato Soup with Bacon Bits and Rolls" &
                                   vbNewLine & "Thursday: Tomato-Basil Soup and Salad" &
                                   vbNewLine & "Friday: Clam Chowder in a Breadbowl" &
                                   vbNewLine & "Saturday: Gazpacho Soup with Quesidillas" &
                                   vbNewLine & vbNewLine & "Sunday: Unfortunately, we are closed."

    End Sub

    Private Sub SaladButton_Click(sender As Object, e As EventArgs) Handles SaladButton.Click

        DisplaySpecialLabel.Text = "Our Salads" &
                                   vbNewLine & StrDup(150, "-") &
                                   vbNewLine & "Caesar Salad" &
                                   vbNewLine & "Cobb Salad" &
                                   vbNewLine & "Chicken Garden Salad" &
                                   vbNewLine & "Grilled Shrimp Salad with Avocado" &
                                   vbNewLine & "Greek Salad" &
                                   vbNewLine & "Pasta Salad" &
                                   vbNewLine & "Ambrosia"

    End Sub

    Private Sub FishButton_Click(sender As Object, e As EventArgs) Handles FishButton.Click

        DisplaySpecialLabel.Text = "Fish Specials" &
                                   vbNewLine & StrDup(150, "-") &
                                   vbNewLine & "Crispy Calimari with Tempura" &
                                   vbNewLine & "Panko-breaded and fried squid with tempura battered " &
                                   "onions, sweet potato, broccoli, carrots, " &
                                   vbNewLine & "zucchini and dipping sauce." &
                                   vbNewLine & vbNewLine & "Glazed Salmon with Mango Salad" &
                                   vbNewLine & "A sweet and tangy pinapple flavored glazed salmon cut " &
                                   "with a mango salad containing mango " &
                                   vbNewLine & " slices, almonds, and a sweet dressing."

    End Sub

    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Me.Close()
    End Sub

End Class