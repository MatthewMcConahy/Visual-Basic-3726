<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveFlavorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddCoffeeFlavorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RemoveCoffeeFlavorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClearFlavorsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DisplayFlavorCountToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ContextMenuStrip2 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ContextMenuStrip3 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.FlavorsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddingFlavorComboBox = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.MenuStrip1.SuspendLayout()
        Me.ContextMenuStrip3.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.EditToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(265, 24)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SaveFlavorToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'SaveFlavorToolStripMenuItem
        '
        Me.SaveFlavorToolStripMenuItem.Name = "SaveFlavorToolStripMenuItem"
        Me.SaveFlavorToolStripMenuItem.Size = New System.Drawing.Size(133, 22)
        Me.SaveFlavorToolStripMenuItem.Text = "Save Flavor"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(133, 22)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'EditToolStripMenuItem
        '
        Me.EditToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddCoffeeFlavorToolStripMenuItem, Me.RemoveCoffeeFlavorToolStripMenuItem, Me.ClearFlavorsToolStripMenuItem, Me.DisplayFlavorCountToolStripMenuItem})
        Me.EditToolStripMenuItem.Name = "EditToolStripMenuItem"
        Me.EditToolStripMenuItem.Size = New System.Drawing.Size(39, 20)
        Me.EditToolStripMenuItem.Text = "Edit"
        '
        'AddCoffeeFlavorToolStripMenuItem
        '
        Me.AddCoffeeFlavorToolStripMenuItem.Name = "AddCoffeeFlavorToolStripMenuItem"
        Me.AddCoffeeFlavorToolStripMenuItem.Size = New System.Drawing.Size(190, 22)
        Me.AddCoffeeFlavorToolStripMenuItem.Text = "Add Coffee Flavor"
        '
        'RemoveCoffeeFlavorToolStripMenuItem
        '
        Me.RemoveCoffeeFlavorToolStripMenuItem.Name = "RemoveCoffeeFlavorToolStripMenuItem"
        Me.RemoveCoffeeFlavorToolStripMenuItem.Size = New System.Drawing.Size(190, 22)
        Me.RemoveCoffeeFlavorToolStripMenuItem.Text = "Remove Coffee Flavor"
        '
        'ClearFlavorsToolStripMenuItem
        '
        Me.ClearFlavorsToolStripMenuItem.Name = "ClearFlavorsToolStripMenuItem"
        Me.ClearFlavorsToolStripMenuItem.Size = New System.Drawing.Size(190, 22)
        Me.ClearFlavorsToolStripMenuItem.Text = "Clear Flavors"
        '
        'DisplayFlavorCountToolStripMenuItem
        '
        Me.DisplayFlavorCountToolStripMenuItem.Name = "DisplayFlavorCountToolStripMenuItem"
        Me.DisplayFlavorCountToolStripMenuItem.Size = New System.Drawing.Size(190, 22)
        Me.DisplayFlavorCountToolStripMenuItem.Text = "Display Flavor Count"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AboutToolStripMenuItem})
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.HelpToolStripMenuItem.Text = "Help"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.AboutToolStripMenuItem.Text = "About"
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(61, 4)
        '
        'ContextMenuStrip2
        '
        Me.ContextMenuStrip2.Name = "ContextMenuStrip2"
        Me.ContextMenuStrip2.Size = New System.Drawing.Size(61, 4)
        '
        'ContextMenuStrip3
        '
        Me.ContextMenuStrip3.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FlavorsToolStripMenuItem})
        Me.ContextMenuStrip3.Name = "ContextMenuStrip3"
        Me.ContextMenuStrip3.Size = New System.Drawing.Size(112, 26)
        '
        'FlavorsToolStripMenuItem
        '
        Me.FlavorsToolStripMenuItem.Name = "FlavorsToolStripMenuItem"
        Me.FlavorsToolStripMenuItem.Size = New System.Drawing.Size(111, 22)
        Me.FlavorsToolStripMenuItem.Text = "Flavors"
        '
        'AddingFlavorComboBox
        '
        Me.AddingFlavorComboBox.FormattingEnabled = True
        Me.AddingFlavorComboBox.Location = New System.Drawing.Point(37, 71)
        Me.AddingFlavorComboBox.Name = "AddingFlavorComboBox"
        Me.AddingFlavorComboBox.Size = New System.Drawing.Size(121, 21)
        Me.AddingFlavorComboBox.TabIndex = 6
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(37, 52)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(70, 13)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Coffee Flavor"
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(265, 206)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.AddingFlavorComboBox)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "MainForm"
        Me.Text = "Betsy's Brews"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ContextMenuStrip3.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SaveFlavorToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EditToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AddCoffeeFlavorToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RemoveCoffeeFlavorToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ClearFlavorsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DisplayFlavorCountToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents ContextMenuStrip2 As ContextMenuStrip
    Friend WithEvents ContextMenuStrip3 As ContextMenuStrip
    Friend WithEvents FlavorsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AddingFlavorComboBox As ComboBox
    Friend WithEvents Label1 As Label
End Class
