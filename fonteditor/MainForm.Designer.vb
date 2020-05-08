<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MainForm
    Inherits System.Windows.Forms.Form

    'Форма переопределяет dispose для очистки списка компонентов.
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

    'Является обязательной для конструктора форм Windows Forms
    Private components As System.ComponentModel.IContainer

    'Примечание: следующая процедура является обязательной для конструктора форм Windows Forms
    'Для ее изменения используйте конструктор форм Windows Form.  
    'Не изменяйте ее в редакторе исходного кода.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.MainPictureBox = New System.Windows.Forms.PictureBox()
        Me.tbDataOfChar = New System.Windows.Forms.TextBox()
        Me.btReadData = New System.Windows.Forms.Button()
        Me.btClear = New System.Windows.Forms.Button()
        Me.btInvert = New System.Windows.Forms.Button()
        Me.btRotateCCW = New System.Windows.Forms.Button()
        Me.btRotateCW = New System.Windows.Forms.Button()
        Me.SourceTextBox = New System.Windows.Forms.RichTextBox()
        Me.ResultTextBox = New System.Windows.Forms.RichTextBox()
        Me.cbRotateCount = New System.Windows.Forms.ComboBox()
        Me.btRotate = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.rbEditMode = New System.Windows.Forms.RadioButton()
        Me.rbSelectMode = New System.Windows.Forms.RadioButton()
        Me.btLoadDefFont = New System.Windows.Forms.Button()
        Me.ToolTip = New System.Windows.Forms.ToolTip(Me.components)
        CType(Me.MainPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MainPictureBox
        '
        Me.MainPictureBox.BackColor = System.Drawing.SystemColors.ControlDark
        Me.MainPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.MainPictureBox.Location = New System.Drawing.Point(1, 19)
        Me.MainPictureBox.Name = "MainPictureBox"
        Me.MainPictureBox.Size = New System.Drawing.Size(258, 258)
        Me.MainPictureBox.TabIndex = 0
        Me.MainPictureBox.TabStop = False
        '
        'tbDataOfChar
        '
        Me.tbDataOfChar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbDataOfChar.Location = New System.Drawing.Point(1, 277)
        Me.tbDataOfChar.Name = "tbDataOfChar"
        Me.tbDataOfChar.Size = New System.Drawing.Size(258, 22)
        Me.tbDataOfChar.TabIndex = 4
        Me.tbDataOfChar.Text = "0x00,0x00,0x00,0x00,0x00,0x00,0x00,0x00"
        '
        'btReadData
        '
        Me.btReadData.Location = New System.Drawing.Point(209, 309)
        Me.btReadData.Name = "btReadData"
        Me.btReadData.Size = New System.Drawing.Size(50, 35)
        Me.btReadData.TabIndex = 5
        Me.btReadData.Text = "Read"
        Me.ToolTip.SetToolTip(Me.btReadData, "Drawing data of field under Graphics area")
        Me.btReadData.UseVisualStyleBackColor = True
        '
        'btClear
        '
        Me.btClear.Location = New System.Drawing.Point(157, 309)
        Me.btClear.Name = "btClear"
        Me.btClear.Size = New System.Drawing.Size(50, 35)
        Me.btClear.TabIndex = 7
        Me.btClear.Text = "Clear"
        Me.btClear.UseVisualStyleBackColor = True
        '
        'btInvert
        '
        Me.btInvert.Location = New System.Drawing.Point(1, 309)
        Me.btInvert.Name = "btInvert"
        Me.btInvert.Size = New System.Drawing.Size(50, 35)
        Me.btInvert.TabIndex = 8
        Me.btInvert.Text = "Invert"
        Me.btInvert.UseVisualStyleBackColor = True
        '
        'btRotateCCW
        '
        Me.btRotateCCW.Location = New System.Drawing.Point(53, 309)
        Me.btRotateCCW.Name = "btRotateCCW"
        Me.btRotateCCW.Size = New System.Drawing.Size(50, 35)
        Me.btRotateCCW.TabIndex = 11
        Me.btRotateCCW.Text = "Rotate CCW"
        Me.btRotateCCW.UseVisualStyleBackColor = True
        '
        'btRotateCW
        '
        Me.btRotateCW.Location = New System.Drawing.Point(105, 309)
        Me.btRotateCW.Name = "btRotateCW"
        Me.btRotateCW.Size = New System.Drawing.Size(50, 35)
        Me.btRotateCW.TabIndex = 12
        Me.btRotateCW.Text = "Rotate CW"
        Me.btRotateCW.UseVisualStyleBackColor = True
        '
        'SourceTextBox
        '
        Me.SourceTextBox.Location = New System.Drawing.Point(263, 19)
        Me.SourceTextBox.Name = "SourceTextBox"
        Me.SourceTextBox.Size = New System.Drawing.Size(335, 418)
        Me.SourceTextBox.TabIndex = 14
        Me.SourceTextBox.Text = ""
        '
        'ResultTextBox
        '
        Me.ResultTextBox.Location = New System.Drawing.Point(656, 19)
        Me.ResultTextBox.Name = "ResultTextBox"
        Me.ResultTextBox.Size = New System.Drawing.Size(335, 418)
        Me.ResultTextBox.TabIndex = 15
        Me.ResultTextBox.Text = ""
        '
        'cbRotateCount
        '
        Me.cbRotateCount.FormattingEnabled = True
        Me.cbRotateCount.Items.AddRange(New Object() {"0°", "90°", "180°", "270°"})
        Me.cbRotateCount.Location = New System.Drawing.Point(604, 199)
        Me.cbRotateCount.Name = "cbRotateCount"
        Me.cbRotateCount.Size = New System.Drawing.Size(46, 21)
        Me.cbRotateCount.TabIndex = 16
        Me.ToolTip.SetToolTip(Me.cbRotateCount, "Select needed rotate angle ")
        '
        'btRotate
        '
        Me.btRotate.Location = New System.Drawing.Point(604, 226)
        Me.btRotate.Name = "btRotate"
        Me.btRotate.Size = New System.Drawing.Size(46, 36)
        Me.btRotate.TabIndex = 17
        Me.btRotate.Text = ">>"
        Me.ToolTip.SetToolTip(Me.btRotate, "Rotate every line of Source area to  Result area")
        Me.btRotate.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(260, 3)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 13)
        Me.Label1.TabIndex = 18
        Me.Label1.Text = "Source:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(653, 3)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(40, 13)
        Me.Label2.TabIndex = 19
        Me.Label2.Text = "Result:"
        '
        'rbEditMode
        '
        Me.rbEditMode.AutoSize = True
        Me.rbEditMode.Location = New System.Drawing.Point(175, 420)
        Me.rbEditMode.Name = "rbEditMode"
        Me.rbEditMode.Size = New System.Drawing.Size(72, 17)
        Me.rbEditMode.TabIndex = 20
        Me.rbEditMode.Text = "Edit mode"
        Me.ToolTip.SetToolTip(Me.rbEditMode, "For Source and Result areas are allow to editing")
        Me.rbEditMode.UseVisualStyleBackColor = True
        '
        'rbSelectMode
        '
        Me.rbSelectMode.AutoSize = True
        Me.rbSelectMode.Location = New System.Drawing.Point(175, 397)
        Me.rbSelectMode.Name = "rbSelectMode"
        Me.rbSelectMode.Size = New System.Drawing.Size(84, 17)
        Me.rbSelectMode.TabIndex = 21
        Me.rbSelectMode.Text = "Select mode"
        Me.ToolTip.SetToolTip(Me.rbSelectMode, "Click on any line on Source or Result  areas and it  will be   appear on graphic " &
        "side")
        Me.rbSelectMode.UseVisualStyleBackColor = True
        '
        'btLoadDefFont
        '
        Me.btLoadDefFont.Location = New System.Drawing.Point(157, 368)
        Me.btLoadDefFont.Name = "btLoadDefFont"
        Me.btLoadDefFont.Size = New System.Drawing.Size(100, 23)
        Me.btLoadDefFont.TabIndex = 22
        Me.btLoadDefFont.Text = "Load default font"
        Me.btLoadDefFont.UseVisualStyleBackColor = True
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(991, 439)
        Me.Controls.Add(Me.btLoadDefFont)
        Me.Controls.Add(Me.rbSelectMode)
        Me.Controls.Add(Me.rbEditMode)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btRotate)
        Me.Controls.Add(Me.cbRotateCount)
        Me.Controls.Add(Me.ResultTextBox)
        Me.Controls.Add(Me.SourceTextBox)
        Me.Controls.Add(Me.btRotateCW)
        Me.Controls.Add(Me.btRotateCCW)
        Me.Controls.Add(Me.btInvert)
        Me.Controls.Add(Me.btClear)
        Me.Controls.Add(Me.btReadData)
        Me.Controls.Add(Me.tbDataOfChar)
        Me.Controls.Add(Me.MainPictureBox)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "MainForm"
        Me.Text = "Font editor 8x8"
        CType(Me.MainPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MainPictureBox As System.Windows.Forms.PictureBox
    Friend WithEvents tbDataOfChar As System.Windows.Forms.TextBox
    Friend WithEvents btReadData As System.Windows.Forms.Button
    Friend WithEvents btClear As System.Windows.Forms.Button
    Friend WithEvents btInvert As System.Windows.Forms.Button
    Friend WithEvents btRotateCCW As Button
    Friend WithEvents btRotateCW As Button
    Friend WithEvents SourceTextBox As RichTextBox
    Friend WithEvents ResultTextBox As RichTextBox
    Friend WithEvents cbRotateCount As ComboBox
    Friend WithEvents btRotate As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents rbEditMode As RadioButton
    Friend WithEvents rbSelectMode As RadioButton
    Friend WithEvents btLoadDefFont As Button
    Friend WithEvents ToolTip As ToolTip
End Class
