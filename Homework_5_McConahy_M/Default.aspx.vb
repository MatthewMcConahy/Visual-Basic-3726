
Imports Microsoft.SqlServer.Server


'Programmer: Matthew McConahy
'Date: 3/27/2020
'Description: This is the default class and the calculations taking place from CalorieCalculations class
'This will display the webpage and output the vars

Partial Class Main
    Inherits System.Web.UI.Page

    'Global vars
    Dim TotalCaloriesCurrentInteger As Integer = 0
    Dim TotalCaloriesInteger As Integer = 0
    Dim TotalItemsInteger As Integer = 0

    Protected Sub CalculateButton_Click(sender As Object, e As EventArgs) Handles CalculateButton.Click
        Dim CalorieCounts As CalorieCalculations

        Try

            CalorieCounts = New CalorieCalculations(Integer.Parse(FatTextBox.Text),
                                                    Integer.Parse(ProtienTextBox.Text),
                                                    Integer.Parse(CarbsTextBox.Text))
            'Increments the count of items
            TotalItemsInteger += 1

            ' For the current item calculations
            TotalCaloriesCurrentInteger = CalorieCounts.TotalAmountCaloriesForCurrent

            'For the Current Item
            TotalCurrentCaloriesLabel.Text = TotalCaloriesCurrentInteger.ToString
            TotalCurrentCaloriesLabel.Visible = True


            'Adding items to the total count
            TotalItemsHiddenField.Value = TotalItemsInteger.ToString()
            TotalItemsAmountLabel.Text = TotalItemsHiddenField.Value
            TotalItemsAmountLabel.Visible = True

            'Adding all Calories to the Total Count
            TotalCaloriesHiddenField.Value = TotalCaloriesCurrentInteger + TotalCaloriesInteger
            TotalCaloriesOverallLabel.Text = TotalCaloriesHiddenField.Value
            TotalCaloriesOverallLabel.Visible = True

        Catch ex As FormatException

        End Try

    End Sub
    Protected Sub ClearButton_Click(sender As Object, e As EventArgs) Handles ClearButton.Click
        'Clears out all texts box
        CarbsTextBox.Text = ""
        ProtienTextBox.Text = ""
        FatTextBox.Text = ""

    End Sub
    Protected Sub Page_Load(sender As Object, e As EventArgs) Handles Me.Load
        ValidationSettings.UnobtrusiveValidationMode = UnobtrusiveValidationMode.None

        'Grabs the inital value to be able to changed
        TotalItemsInteger = Integer.Parse(TotalItemsHiddenField.Value)
        TotalCaloriesInteger = Integer.Parse(TotalCaloriesHiddenField.Value)

    End Sub
End Class
