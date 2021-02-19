<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MainForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.TableLayoutPanelMain = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanelSelection = New System.Windows.Forms.TableLayoutPanel()
        Me.ButtonModifyShape = New System.Windows.Forms.Button()
        Me.TextBoxAllShapes = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ComboBoxIndex = New System.Windows.Forms.ComboBox()
        Me.ComboBoxShape = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBoxCurrentShape = New System.Windows.Forms.TextBox()
        Me.ButtonAddShape = New System.Windows.Forms.Button()
        Me.PanelShape = New System.Windows.Forms.Panel()
        Me.MenuStripMain = New System.Windows.Forms.MenuStrip()
        Me.ToolStripMenuItemFile = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItemLoad = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItemSave = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItemReset = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItemExit = New System.Windows.Forms.ToolStripMenuItem()
        Me.TableLayoutPanelMain.SuspendLayout()
        Me.TableLayoutPanelSelection.SuspendLayout()
        Me.MenuStripMain.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanelMain
        '
        Me.TableLayoutPanelMain.ColumnCount = 2
        Me.TableLayoutPanelMain.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
        Me.TableLayoutPanelMain.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 83.33334!))
        Me.TableLayoutPanelMain.Controls.Add(Me.TableLayoutPanelSelection, 0, 0)
        Me.TableLayoutPanelMain.Controls.Add(Me.PanelShape, 1, 0)
        Me.TableLayoutPanelMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanelMain.Location = New System.Drawing.Point(0, 24)
        Me.TableLayoutPanelMain.Margin = New System.Windows.Forms.Padding(1)
        Me.TableLayoutPanelMain.Name = "TableLayoutPanelMain"
        Me.TableLayoutPanelMain.RowCount = 1
        Me.TableLayoutPanelMain.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanelMain.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 837.0!))
        Me.TableLayoutPanelMain.Size = New System.Drawing.Size(1584, 837)
        Me.TableLayoutPanelMain.TabIndex = 0
        '
        'TableLayoutPanelSelection
        '
        Me.TableLayoutPanelSelection.ColumnCount = 1
        Me.TableLayoutPanelSelection.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanelSelection.Controls.Add(Me.ButtonModifyShape, 0, 4)
        Me.TableLayoutPanelSelection.Controls.Add(Me.TextBoxAllShapes, 0, 9)
        Me.TableLayoutPanelSelection.Controls.Add(Me.Label5, 0, 8)
        Me.TableLayoutPanelSelection.Controls.Add(Me.Label4, 0, 6)
        Me.TableLayoutPanelSelection.Controls.Add(Me.Label2, 0, 2)
        Me.TableLayoutPanelSelection.Controls.Add(Me.ComboBoxIndex, 0, 3)
        Me.TableLayoutPanelSelection.Controls.Add(Me.ComboBoxShape, 0, 1)
        Me.TableLayoutPanelSelection.Controls.Add(Me.Label1, 0, 0)
        Me.TableLayoutPanelSelection.Controls.Add(Me.TextBoxCurrentShape, 0, 7)
        Me.TableLayoutPanelSelection.Controls.Add(Me.ButtonAddShape, 0, 5)
        Me.TableLayoutPanelSelection.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanelSelection.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanelSelection.Margin = New System.Windows.Forms.Padding(0)
        Me.TableLayoutPanelSelection.Name = "TableLayoutPanelSelection"
        Me.TableLayoutPanelSelection.RowCount = 10
        Me.TableLayoutPanelSelection.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.999999!))
        Me.TableLayoutPanelSelection.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.999999!))
        Me.TableLayoutPanelSelection.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.999999!))
        Me.TableLayoutPanelSelection.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.999999!))
        Me.TableLayoutPanelSelection.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.999999!))
        Me.TableLayoutPanelSelection.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.999999!))
        Me.TableLayoutPanelSelection.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.999999!))
        Me.TableLayoutPanelSelection.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.999999!))
        Me.TableLayoutPanelSelection.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.999999!))
        Me.TableLayoutPanelSelection.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.999999!))
        Me.TableLayoutPanelSelection.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanelSelection.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanelSelection.Size = New System.Drawing.Size(264, 837)
        Me.TableLayoutPanelSelection.TabIndex = 0
        '
        'ButtonModifyShape
        '
        Me.ButtonModifyShape.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ButtonModifyShape.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.ButtonModifyShape.Location = New System.Drawing.Point(1, 333)
        Me.ButtonModifyShape.Margin = New System.Windows.Forms.Padding(1)
        Me.ButtonModifyShape.Name = "ButtonModifyShape"
        Me.ButtonModifyShape.Size = New System.Drawing.Size(262, 81)
        Me.ButtonModifyShape.TabIndex = 12
        Me.ButtonModifyShape.Text = "Modify Shape"
        Me.ButtonModifyShape.UseVisualStyleBackColor = True
        '
        'TextBoxAllShapes
        '
        Me.TextBoxAllShapes.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TextBoxAllShapes.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.TextBoxAllShapes.Location = New System.Drawing.Point(1, 748)
        Me.TextBoxAllShapes.Margin = New System.Windows.Forms.Padding(1)
        Me.TextBoxAllShapes.Multiline = True
        Me.TextBoxAllShapes.Name = "TextBoxAllShapes"
        Me.TextBoxAllShapes.ReadOnly = True
        Me.TextBoxAllShapes.Size = New System.Drawing.Size(262, 88)
        Me.TextBoxAllShapes.TabIndex = 10
        Me.TextBoxAllShapes.Text = "Area:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Perimeter:"
        Me.TextBoxAllShapes.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label5.Location = New System.Drawing.Point(1, 665)
        Me.Label5.Margin = New System.Windows.Forms.Padding(1)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(262, 81)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Total Collection Dimensions"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label4.Location = New System.Drawing.Point(1, 499)
        Me.Label4.Margin = New System.Windows.Forms.Padding(1)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(262, 81)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Current Shape Dimensions"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label2.Location = New System.Drawing.Point(1, 167)
        Me.Label2.Margin = New System.Windows.Forms.Padding(1)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(262, 81)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Select Display Shape"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ComboBoxIndex
        '
        Me.ComboBoxIndex.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ComboBoxIndex.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.ComboBoxIndex.FormattingEnabled = True
        Me.ComboBoxIndex.Location = New System.Drawing.Point(1, 250)
        Me.ComboBoxIndex.Margin = New System.Windows.Forms.Padding(1)
        Me.ComboBoxIndex.Name = "ComboBoxIndex"
        Me.ComboBoxIndex.Size = New System.Drawing.Size(262, 45)
        Me.ComboBoxIndex.TabIndex = 1
        '
        'ComboBoxShape
        '
        Me.ComboBoxShape.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ComboBoxShape.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.ComboBoxShape.FormattingEnabled = True
        Me.ComboBoxShape.Items.AddRange(New Object() {"Circles", "Ellipses", "Polygons", "Squares", "Equilateral Triangles"})
        Me.ComboBoxShape.Location = New System.Drawing.Point(1, 84)
        Me.ComboBoxShape.Margin = New System.Windows.Forms.Padding(1)
        Me.ComboBoxShape.Name = "ComboBoxShape"
        Me.ComboBoxShape.Size = New System.Drawing.Size(262, 45)
        Me.ComboBoxShape.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(1, 1)
        Me.Label1.Margin = New System.Windows.Forms.Padding(1)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(262, 81)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Select Shape Type"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TextBoxCurrentShape
        '
        Me.TextBoxCurrentShape.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TextBoxCurrentShape.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.TextBoxCurrentShape.Location = New System.Drawing.Point(1, 582)
        Me.TextBoxCurrentShape.Margin = New System.Windows.Forms.Padding(1)
        Me.TextBoxCurrentShape.Multiline = True
        Me.TextBoxCurrentShape.Name = "TextBoxCurrentShape"
        Me.TextBoxCurrentShape.ReadOnly = True
        Me.TextBoxCurrentShape.Size = New System.Drawing.Size(262, 81)
        Me.TextBoxCurrentShape.TabIndex = 9
        Me.TextBoxCurrentShape.Text = "Area:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Perimeter:"
        Me.TextBoxCurrentShape.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'ButtonAddShape
        '
        Me.ButtonAddShape.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ButtonAddShape.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.ButtonAddShape.Location = New System.Drawing.Point(1, 416)
        Me.ButtonAddShape.Margin = New System.Windows.Forms.Padding(1)
        Me.ButtonAddShape.Name = "ButtonAddShape"
        Me.ButtonAddShape.Size = New System.Drawing.Size(262, 81)
        Me.ButtonAddShape.TabIndex = 11
        Me.ButtonAddShape.Text = "Add Shape"
        Me.ButtonAddShape.UseVisualStyleBackColor = True
        '
        'PanelShape
        '
        Me.PanelShape.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PanelShape.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelShape.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.PanelShape.Location = New System.Drawing.Point(265, 1)
        Me.PanelShape.Margin = New System.Windows.Forms.Padding(1)
        Me.PanelShape.Name = "PanelShape"
        Me.PanelShape.Size = New System.Drawing.Size(1318, 835)
        Me.PanelShape.TabIndex = 1
        '
        'MenuStripMain
        '
        Me.MenuStripMain.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItemFile})
        Me.MenuStripMain.Location = New System.Drawing.Point(0, 0)
        Me.MenuStripMain.Name = "MenuStripMain"
        Me.MenuStripMain.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.MenuStripMain.Size = New System.Drawing.Size(1584, 24)
        Me.MenuStripMain.TabIndex = 1
        '
        'ToolStripMenuItemFile
        '
        Me.ToolStripMenuItemFile.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItemLoad, Me.ToolStripMenuItemSave, Me.ToolStripMenuItemReset, Me.ToolStripMenuItemExit})
        Me.ToolStripMenuItemFile.Name = "ToolStripMenuItemFile"
        Me.ToolStripMenuItemFile.Size = New System.Drawing.Size(37, 20)
        Me.ToolStripMenuItemFile.Text = "File"
        '
        'ToolStripMenuItemLoad
        '
        Me.ToolStripMenuItemLoad.Name = "ToolStripMenuItemLoad"
        Me.ToolStripMenuItemLoad.Size = New System.Drawing.Size(159, 22)
        Me.ToolStripMenuItemLoad.Text = "Load Shapes"
        '
        'ToolStripMenuItemSave
        '
        Me.ToolStripMenuItemSave.Name = "ToolStripMenuItemSave"
        Me.ToolStripMenuItemSave.Size = New System.Drawing.Size(159, 22)
        Me.ToolStripMenuItemSave.Text = "Save Shapes"
        '
        'ToolStripMenuItemReset
        '
        Me.ToolStripMenuItemReset.Name = "ToolStripMenuItemReset"
        Me.ToolStripMenuItemReset.Size = New System.Drawing.Size(159, 22)
        Me.ToolStripMenuItemReset.Text = "Reset Collection"
        '
        'ToolStripMenuItemExit
        '
        Me.ToolStripMenuItemExit.Name = "ToolStripMenuItemExit"
        Me.ToolStripMenuItemExit.Size = New System.Drawing.Size(159, 22)
        Me.ToolStripMenuItemExit.Text = "Exit"
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1584, 861)
        Me.Controls.Add(Me.TableLayoutPanelMain)
        Me.Controls.Add(Me.MenuStripMain)
        Me.MinimumSize = New System.Drawing.Size(1600, 900)
        Me.Name = "MainForm"
        Me.Text = "MainForm"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.TableLayoutPanelMain.ResumeLayout(False)
        Me.TableLayoutPanelSelection.ResumeLayout(False)
        Me.TableLayoutPanelSelection.PerformLayout()
        Me.MenuStripMain.ResumeLayout(False)
        Me.MenuStripMain.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TableLayoutPanelMain As TableLayoutPanel
    Friend WithEvents TableLayoutPanelSelection As TableLayoutPanel
    Friend WithEvents ComboBoxIndex As ComboBox
    Friend WithEvents PanelShape As Panel
    Friend WithEvents ComboBoxShape As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents MenuStripMain As MenuStrip
    Friend WithEvents ToolStripMenuItemFile As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItemSave As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItemExit As ToolStripMenuItem
    Friend WithEvents TextBoxAllShapes As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents TextBoxCurrentShape As TextBox
    Friend WithEvents ButtonModifyShape As Button
    Friend WithEvents ButtonAddShape As Button
    Friend WithEvents ToolStripMenuItemLoad As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItemReset As ToolStripMenuItem
End Class
