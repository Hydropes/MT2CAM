<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
    Inherits System.Windows.Forms.Form

    'Форма переопределяет dispose для очистки списка компонентов.
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

    'Является обязательной для конструктора форм Windows Forms
    Private components As System.ComponentModel.IContainer

    'Примечание: следующая процедура является обязательной для конструктора форм Windows Forms
    'Для ее изменения используйте конструктор форм Windows Form.  
    'Не изменяйте ее в редакторе исходного кода.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.TextBoxdlpodv = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBoxugolzag = New System.Windows.Forms.TextBox()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.CheckBoxvkpodv = New System.Windows.Forms.CheckBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBoxXvhod = New System.Windows.Forms.TextBox()
        Me.TextBoxYvhod = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.TextBoxautox = New System.Windows.Forms.TextBox()
        Me.TextBoxautoy = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'TextBoxdlpodv
        '
        Me.TextBoxdlpodv.Location = New System.Drawing.Point(249, 55)
        Me.TextBoxdlpodv.Name = "TextBoxdlpodv"
        Me.TextBoxdlpodv.Size = New System.Drawing.Size(53, 22)
        Me.TextBoxdlpodv.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Maroon
        Me.Label1.Location = New System.Drawing.Point(12, 55)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(185, 18)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Длина пути подвода, мм:"
        '
        'TextBoxugolzag
        '
        Me.TextBoxugolzag.Location = New System.Drawing.Point(249, 110)
        Me.TextBoxugolzag.Name = "TextBoxugolzag"
        Me.TextBoxugolzag.Size = New System.Drawing.Size(53, 22)
        Me.TextBoxugolzag.TabIndex = 48
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label24.ForeColor = System.Drawing.Color.Maroon
        Me.Label24.Location = New System.Drawing.Point(12, 96)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(208, 36)
        Me.Label24.TabIndex = 47
        Me.Label24.Text = "Макс. заглубление фрезы " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "за оборот по спирали, град.:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Maroon
        Me.Label2.Location = New System.Drawing.Point(12, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(69, 18)
        Me.Label2.TabIndex = 49
        Me.Label2.Text = "Подвод"
        '
        'CheckBoxvkpodv
        '
        Me.CheckBoxvkpodv.AutoSize = True
        Me.CheckBoxvkpodv.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.CheckBoxvkpodv.ForeColor = System.Drawing.Color.Maroon
        Me.CheckBoxvkpodv.Location = New System.Drawing.Point(203, 9)
        Me.CheckBoxvkpodv.Name = "CheckBoxvkpodv"
        Me.CheckBoxvkpodv.Size = New System.Drawing.Size(99, 22)
        Me.CheckBoxvkpodv.TabIndex = 50
        Me.CheckBoxvkpodv.Text = "Включить"
        Me.CheckBoxvkpodv.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Maroon
        Me.Label3.Location = New System.Drawing.Point(400, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(206, 18)
        Me.Label3.TabIndex = 51
        Me.Label3.Text = "Координаты точки входа"
        '
        'TextBoxXvhod
        '
        Me.TextBoxXvhod.Location = New System.Drawing.Point(412, 54)
        Me.TextBoxXvhod.Name = "TextBoxXvhod"
        Me.TextBoxXvhod.Size = New System.Drawing.Size(85, 22)
        Me.TextBoxXvhod.TabIndex = 52
        '
        'TextBoxYvhod
        '
        Me.TextBoxYvhod.Location = New System.Drawing.Point(411, 91)
        Me.TextBoxYvhod.Name = "TextBoxYvhod"
        Me.TextBoxYvhod.Size = New System.Drawing.Size(85, 22)
        Me.TextBoxYvhod.TabIndex = 53
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Maroon
        Me.Label4.Location = New System.Drawing.Point(384, 54)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(22, 18)
        Me.Label4.TabIndex = 54
        Me.Label4.Text = "Х:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Maroon
        Me.Label5.Location = New System.Drawing.Point(384, 95)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(21, 18)
        Me.Label5.TabIndex = 55
        Me.Label5.Text = "Y:"
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.ForeColor = System.Drawing.Color.Maroon
        Me.CheckBox1.Location = New System.Drawing.Point(387, 126)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(61, 21)
        Me.CheckBox1.TabIndex = 56
        Me.CheckBox1.Text = "Авто"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'TextBoxautox
        '
        Me.TextBoxautox.Enabled = False
        Me.TextBoxautox.Location = New System.Drawing.Point(521, 53)
        Me.TextBoxautox.Name = "TextBoxautox"
        Me.TextBoxautox.Size = New System.Drawing.Size(85, 22)
        Me.TextBoxautox.TabIndex = 57
        '
        'TextBoxautoy
        '
        Me.TextBoxautoy.Enabled = False
        Me.TextBoxautoy.Location = New System.Drawing.Point(521, 91)
        Me.TextBoxautoy.Name = "TextBoxautoy"
        Me.TextBoxautoy.Size = New System.Drawing.Size(85, 22)
        Me.TextBoxautoy.TabIndex = 58
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkGray
        Me.ClientSize = New System.Drawing.Size(643, 159)
        Me.Controls.Add(Me.TextBoxautoy)
        Me.Controls.Add(Me.TextBoxautox)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TextBoxYvhod)
        Me.Controls.Add(Me.TextBoxXvhod)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.CheckBoxvkpodv)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TextBoxugolzag)
        Me.Controls.Add(Me.Label24)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextBoxdlpodv)
        Me.Name = "Form2"
        Me.Text = "Параметры подвода и отвода"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TextBoxdlpodv As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBoxugolzag As TextBox
    Friend WithEvents Label24 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents CheckBoxvkpodv As CheckBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBoxXvhod As TextBox
    Friend WithEvents TextBoxYvhod As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents TextBoxautox As TextBox
    Friend WithEvents TextBoxautoy As TextBox
End Class
