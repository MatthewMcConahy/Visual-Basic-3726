Imports Microsoft.VisualBasic

'Programmer: Matthew McConahy
'Date: 4/27/20
'Description: This is where we hold all the calculations for the calories 

Public Class CalorieCalculations

    'All Vars
    Private FatInteger As Integer
    Private ProtienInteger As Integer
    Private CarbsInteger As Integer
    Private TotalCalories As Integer

    Public Sub New(ByVal FatIn As Integer,
                   ByVal ProtienIn As Integer,
                   ByVal CarbsIn As Integer)

        Fat = FatIn
        Protien = ProtienIn
        Carbs = CarbsIn

        CalculateCalories()
    End Sub

    'Sets Fat and checks to make sure its above 1
    Property Fat As Integer
        Get
            Return FatInteger
        End Get
        Set(ByVal value As Integer)
            If (value >= 0) Then
                FatInteger = value
            End If
        End Set
    End Property

    'Sets Protien
    Property Protien As Integer
        Get
            Return ProtienInteger
        End Get
        Set(ByVal value As Integer)
            If (value >= 0) Then
                ProtienInteger = value
            End If
        End Set
    End Property

    'Sets Carbs
    Property Carbs As Integer
        Get
            Return CarbsInteger
        End Get
        Set(value As Integer)
            If (value >= 0) Then
                CarbsInteger = value
            End If
        End Set
    End Property

    'Sets total Calories
    ReadOnly Property TotalAmountCaloriesForCurrent As Integer
        Get
            Return TotalCalories
        End Get
    End Property

    'Will calculate the amount of calories for the whole item
    Protected Function CalculateCalories()
        TotalCalories = (Fat * 9) + (Carbs * 4) + (Protien * 4)
        Return TotalCalories
    End Function
End Class
