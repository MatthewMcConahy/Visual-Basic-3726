'Project: Homework 3
'Author: Matthew McConahy  
'Date: Spring 2020
'Description: 
'Being able to read in text files, edit. Display coffee flavors and 
'Use of MenuItems
Imports System.IO ' using classes from this namespace

Public Class MainForm '
    Const FileNameStringCONST As String = "flavors.txt" 'used To store filename
    Dim OrginalFileSize As Integer ' If this value is different from when the file is loaded, it will save
    Dim OrginalFileSizeChanges As Integer ' if this value differs from the orginal. The user will be promoted to save 

    Private Sub DisplayFlavorCountToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DisplayFlavorCountToolStripMenuItem.Click
        ' will display the amount of flavors currently
        MessageBox.Show("The amount of flavors " +
                        AddingFlavorComboBox.Items.Count.ToString,
                        "Amount of Flavors")
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        ' save the file before exiting, if they're changes
        CloseFile()
    End Sub


    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' loads automatically, will check for the file
        DoesFileExist(FileNameStringCONST)
    End Sub

    Sub CloseFile()
        ' will kill the program and check if the file has had any changes to do it
        Dim ChangeBoolean As Boolean ' will check the statements, if true or false
        Dim CloseSaveStreamWriter As StreamWriter
        Dim UserAnswerYesOrNoString As String ' records answer for saving or not

        CloseSaveStreamWriter = New StreamWriter(FileNameStringCONST)
        ChangeBoolean = OrginalFileSize.CompareTo(OrginalFileSizeChanges) ' check if any changes were ever made

        Try
            If (ChangeBoolean = True) Then
                UserAnswerYesOrNoString = MessageBox.Show("Changes have been made to the file, Do you want to save",
                                "Save File",
                                MessageBoxButtons.YesNo)
            Else
                ' nothing happens files werent changed
            End If

            If (UserAnswerYesOrNoString = vbYes) Then
                ' will write out to the file
                For counter As Integer = 0 To AddingFlavorComboBox.Items.Count - 1
                    Dim SaveFileLineString As String
                    SaveFileLineString = AddingFlavorComboBox.Items.Item(counter)
                    CloseSaveStreamWriter.WriteLine(SaveFileLineString)
                Next
            Else
                ' nothing, since no user picked no
            End If


        Catch ex As IOException
            MessageBox.Show("File was unable to be saved")

        Finally
            If CloseSaveStreamWriter IsNot Nothing Then
                CloseSaveStreamWriter.Close()
                Close()
            End If
        End Try

    End Sub

    Sub SaveFile()
        ' will save the flavor called on the file 
        Dim SaveStreamWriter As StreamWriter
        SaveStreamWriter = New StreamWriter(FileNameStringCONST)

        Try
            For counter As Integer = 0 To AddingFlavorComboBox.Items.Count - 1
                Dim SaveFileLineString As String
                SaveFileLineString = AddingFlavorComboBox.Items.Item(counter)
                SaveStreamWriter.WriteLine(SaveFileLineString)
            Next
        Catch ex As IOException
            MessageBox.Show("Error Saving the file", "Unable to save the file")
            ' will kill the stream
        Finally
            If SaveStreamWriter IsNot Nothing Then
                SaveStreamWriter.Close()
            End If
        End Try
    End Sub

    Function DoesFileExist(FileNameStringCONST As String)
        ' function will check if file exists 
        ' if the file does not exist, user will be prompted to enter it
        Dim UserAnswerString As String
        Dim counter As Integer
        Dim FileStreamReader As StreamReader
        Dim FlavorStreamWriter As StreamWriter

        Try
            If (File.Exists(FileNameStringCONST) = True) Then
                FileStreamReader = New StreamReader(FileNameStringCONST)

                ' feeds all the strings from the file
                Do Until FileStreamReader.EndOfStream
                    Dim LineString As String ' will make lines to bring into file
                    LineString = FileStreamReader.ReadLine
                    AddingFlavorComboBox.Items.Add(LineString).ToString()
                Loop
                OrginalFileSize = AddingFlavorComboBox.Items.Count

                FileStreamReader.Close()
            Else
                ' will ask the user to create the file
                UserAnswerString = MessageBox.Show("Do you want to create the file",
                                               "File does not exist",
                                               MessageBoxButtons.YesNo,
                                               MessageBoxIcon.Question)
                ' will create file for user to work with
            End If
            If (UserAnswerString = vbYes) Then
                FlavorStreamWriter = New StreamWriter(FileNameStringCONST, True)
                FlavorStreamWriter.Close()
            Else
                'close application
            End If
        Catch ex As IOException
            MessageBox.Show("Error opening file", "File Error")
        End Try


    End Function

    Sub AddFlavors()
        ' will append the flavors to list
        Dim AddingFlavorString As String

        AddingFlavorString = AddingFlavorComboBox.Text
        If (AddingFlavorString = "") Then
            MessageBox.Show("You need to enter a flavor name", "Missing flavor name")
        Else
            AddingFlavorComboBox.Items.Add(AddingFlavorString)
            OrginalFileSizeChanges = OrginalFileSize + 1
        End If
    End Sub

    Sub RemoveFlavors()
        'Removing flavor from total
        Dim RemovingFlavorString As String

        RemovingFlavorString = AddingFlavorComboBox.Text

        If (RemovingFlavorString = "") Then
            MessageBox.Show("You cannot remove a flavor, if it does not exist", "Missing flavor")
        Else
            AddingFlavorComboBox.Items.Remove(RemovingFlavorString)
            OrginalFileSizeChanges = OrginalFileSize - 1
        End If
    End Sub

    Sub ClearingFlavors()
        'It will clear the list and will ask the user if they wanna clear the list
        Dim UserChoiceString As String
        Dim EmptyString As String

        UserChoiceString = MessageBox.Show("Do you want to clear the list?",
                                               "Confirmation of clearing",
                                               MessageBoxButtons.YesNo,
                                               MessageBoxIcon.Question)
        ' checks the user input
        If (UserChoiceString = vbYes) Then
            AddingFlavorComboBox.Items.Clear()
            AddingFlavorComboBox.Text = ""
            OrginalFileSizeChanges = 0
        Else
            'will do nothing, since we arent clearing the list
        End If


    End Sub



    Private Sub SaveFlavorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveFlavorToolStripMenuItem.Click
        'write and save to file
        SaveFile()
    End Sub

    Private Sub AddCoffeeFlavorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddCoffeeFlavorToolStripMenuItem.Click
        'adding flavors onto list
        AddFlavors()
    End Sub

    Private Sub RemoveCoffeeFlavorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RemoveCoffeeFlavorToolStripMenuItem.Click
        'remove one flavor at time
        RemoveFlavors()
    End Sub

    Private Sub ClearFlavorsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClearFlavorsToolStripMenuItem.Click
        ' remove all the flavors
        ' will ask user before any impact happens
        ClearingFlavors()
    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        MessageBox.Show("Welcome to Bety's Coffee", "Welcome")
    End Sub
End Class
