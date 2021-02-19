<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PolygonForm
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.ButtonTest = New System.Windows.Forms.Button()
        Me.ComboBoxColor = New System.Windows.Forms.ComboBox()
        Me.ButtonCancel = New System.Windows.Forms.Button()
        Me.ButtonOK = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.ButtonTest, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.ComboBoxColor, 1, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.ButtonCancel, 1, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.ButtonOK, 0, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.Label4, 0, 3)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Margin = New System.Windows.Forms.Padding(0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 5
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(284, 361)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'ButtonTest
        '
        Me.ButtonTest.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ButtonTest.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.ButtonTest.Location = New System.Drawing.Point(1, 1)
        Me.ButtonTest.Margin = New System.Windows.Forms.Padding(1)
        Me.ButtonTest.Name = "ButtonTest"
        Me.ButtonTest.Size = New System.Drawing.Size(140, 70)
        Me.ButtonTest.TabIndex = 15
        Me.ButtonTest.Text = "Apply"
        Me.ButtonTest.UseVisualStyleBackColor = True
        '
        'ComboBoxColor
        '
        Me.ComboBoxColor.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ComboBoxColor.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.ComboBoxColor.FormattingEnabled = True
        Me.ComboBoxColor.Items.AddRange(New Object() {"Blue", "Green", "Orange", "Purple", "Red", "Yellow"})
        Me.ComboBoxColor.Location = New System.Drawing.Point(143, 217)
        Me.ComboBoxColor.Margin = New System.Windows.Forms.Padding(1)
        Me.ComboBoxColor.Name = "ComboBoxColor"
        Me.ComboBoxColor.Size = New System.Drawing.Size(140, 45)
        Me.ComboBoxColor.TabIndex = 14
        '
        'ButtonCancel
        '
        Me.ButtonCancel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ButtonCancel.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.ButtonCancel.Location = New System.Drawing.Point(143, 289)
        Me.ButtonCancel.Margin = New System.Windows.Forms.Padding(1)
        Me.ButtonCancel.Name = "ButtonCancel"
        Me.ButtonCancel.Size = New System.Drawing.Size(140, 71)
        Me.ButtonCancel.TabIndex = 13
        Me.ButtonCancel.Text = "Cancel"
        Me.ButtonCancel.UseVisualStyleBackColor = True
        '
        'ButtonOK
        '
        Me.ButtonOK.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ButtonOK.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.ButtonOK.Location = New System.Drawing.Point(1, 289)
        Me.ButtonOK.Margin = New System.Windows.Forms.Padding(1)
        Me.ButtonOK.Name = "ButtonOK"
        Me.ButtonOK.Size = New System.Drawing.Size(140, 71)
        Me.ButtonOK.TabIndex = 12
        Me.ButtonOK.Text = "Apply"
        Me.ButtonOK.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label4.Location = New System.Drawing.Point(1, 217)
        Me.Label4.Margin = New System.Windows.Forms.Padding(1)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(140, 70)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Color"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PolygonForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 361)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.MinimumSize = New System.Drawing.Size(300, 400)
        Me.Name = "PolygonForm"
        Me.Text = "PolygonForm"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents Label4 As Label
    Friend WithEvents ButtonCancel As Button
    Friend WithEvents ButtonOK As Button
    Friend WithEvents ComboBoxColor As ComboBox
    Friend WithEvents ButtonTest As Button
End Class
