<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CircleForm
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
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.TextBoxRadius = New System.Windows.Forms.TextBox()
        Me.TextBoxCenterY = New System.Windows.Forms.TextBox()
        Me.ComboBoxColor = New System.Windows.Forms.ComboBox()
        Me.ButtonCancel = New System.Windows.Forms.Button()
        Me.ButtonOK = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBoxCenterX = New System.Windows.Forms.TextBox()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.TextBoxRadius, 1, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.TextBoxCenterY, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.ComboBoxColor, 1, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.ButtonCancel, 1, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.ButtonOK, 0, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.Label4, 0, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.Label3, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.Label2, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Label1, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.TextBoxCenterX, 1, 0)
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
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(284, 361)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'TextBoxRadius
        '
        Me.TextBoxRadius.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TextBoxRadius.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.TextBoxRadius.Location = New System.Drawing.Point(143, 145)
        Me.TextBoxRadius.Margin = New System.Windows.Forms.Padding(1)
        Me.TextBoxRadius.Name = "TextBoxRadius"
        Me.TextBoxRadius.Size = New System.Drawing.Size(140, 35)
        Me.TextBoxRadius.TabIndex = 17
        '
        'TextBoxCenterY
        '
        Me.TextBoxCenterY.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TextBoxCenterY.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.TextBoxCenterY.Location = New System.Drawing.Point(143, 73)
        Me.TextBoxCenterY.Margin = New System.Windows.Forms.Padding(1)
        Me.TextBoxCenterY.Name = "TextBoxCenterY"
        Me.TextBoxCenterY.Size = New System.Drawing.Size(140, 35)
        Me.TextBoxCenterY.TabIndex = 16
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
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label3.Location = New System.Drawing.Point(1, 145)
        Me.Label3.Margin = New System.Windows.Forms.Padding(1)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(140, 70)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Radius"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label2.Location = New System.Drawing.Point(1, 73)
        Me.Label2.Margin = New System.Windows.Forms.Padding(1)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(140, 70)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Center Y"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(1, 1)
        Me.Label1.Margin = New System.Windows.Forms.Padding(1)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(140, 70)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Center X"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TextBoxCenterX
        '
        Me.TextBoxCenterX.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TextBoxCenterX.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.TextBoxCenterX.Location = New System.Drawing.Point(143, 1)
        Me.TextBoxCenterX.Margin = New System.Windows.Forms.Padding(1)
        Me.TextBoxCenterX.Name = "TextBoxCenterX"
        Me.TextBoxCenterX.Size = New System.Drawing.Size(140, 35)
        Me.TextBoxCenterX.TabIndex = 15
        '
        'CircleForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 361)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.MinimumSize = New System.Drawing.Size(300, 400)
        Me.Name = "CircleForm"
        Me.Text = "CircleForm"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents ButtonCancel As Button
    Friend WithEvents ButtonOK As Button
    Friend WithEvents TextBoxRadius As TextBox
    Friend WithEvents TextBoxCenterY As TextBox
    Friend WithEvents ComboBoxColor As ComboBox
    Friend WithEvents TextBoxCenterX As TextBox
End Class
