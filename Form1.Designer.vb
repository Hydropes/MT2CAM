<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ФайлToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.НовыйToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ВставитьВидыС3DМоделиToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ВставитьГлавныйВидToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ПовернутьГлавныйВидToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ПовернутьГлавныйВидНалевоToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.УвеличитьМасштабЧертежаToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.УменьшитьМасштабЧертежаToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ВставитьПроекционныеВидыToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ОчиститьПолеЧертежаToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ДействияСФайломToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ЭкспортВGcodeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ОткрытьПроектToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Ochistka = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Button11 = New System.Windows.Forms.Button()
        Me.Button13 = New System.Windows.Forms.Button()
        Me.ListBox5 = New System.Windows.Forms.ListBox()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.TabPage4 = New System.Windows.Forms.TabPage()
        Me.TextBoxsek = New System.Windows.Forms.TextBox()
        Me.TextBoxmin = New System.Windows.Forms.TextBox()
        Me.TextBox11 = New System.Windows.Forms.TextBox()
        Me.TextBox10 = New System.Windows.Forms.TextBox()
        Me.Label34 = New System.Windows.Forms.Label()
        Me.Label33 = New System.Windows.Forms.Label()
        Me.Label32 = New System.Windows.Forms.Label()
        Me.ListBox4 = New System.Windows.Forms.ListBox()
        Me.CheckBox4 = New System.Windows.Forms.CheckBox()
        Me.Button12 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Button10 = New System.Windows.Forms.Button()
        Me.Button9 = New System.Windows.Forms.Button()
        Me.ListBox2 = New System.Windows.Forms.ListBox()
        Me.TextBoxmaxY = New System.Windows.Forms.TextBox()
        Me.TextBoxmaxX = New System.Windows.Forms.TextBox()
        Me.Label35 = New System.Windows.Forms.Label()
        Me.Label36 = New System.Windows.Forms.Label()
        Me.CheckBoxpoyasn = New System.Windows.Forms.CheckBox()
        Me.TextBoxYASK = New System.Windows.Forms.TextBox()
        Me.TextBoxXASK = New System.Windows.Forms.TextBox()
        Me.Label41 = New System.Windows.Forms.Label()
        Me.Label40 = New System.Windows.Forms.Label()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.Button19 = New System.Windows.Forms.Button()
        Me.GroupBox8 = New System.Windows.Forms.GroupBox()
        Me.TextBoxSrez = New System.Windows.Forms.TextBox()
        Me.TextBoxVrez = New System.Windows.Forms.TextBox()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.RadioButton18 = New System.Windows.Forms.RadioButton()
        Me.RadioButton26 = New System.Windows.Forms.RadioButton()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.Button17 = New System.Windows.Forms.Button()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.RadioButton21 = New System.Windows.Forms.RadioButton()
        Me.RadioButton20 = New System.Windows.Forms.RadioButton()
        Me.TextBoxkolvopr = New System.Windows.Forms.TextBox()
        Me.TextBoxmaxZ = New System.Windows.Forms.TextBox()
        Me.TextBoxviskon = New System.Windows.Forms.TextBox()
        Me.TextBoxdeltaniz = New System.Windows.Forms.TextBox()
        Me.TextBoxdletaverh = New System.Windows.Forms.TextBox()
        Me.TextBoxnpl = New System.Windows.Forms.TextBox()
        Me.TextBoxvpl = New System.Windows.Forms.TextBox()
        Me.TextBoxplbez = New System.Windows.Forms.TextBox()
        Me.TextBoxperfrez = New System.Windows.Forms.TextBox()
        Me.TextBoxbzrast = New System.Windows.Forms.TextBox()
        Me.TextBoxobchist = New System.Windows.Forms.TextBox()
        Me.TextBoxpodchist = New System.Windows.Forms.TextBox()
        Me.TextBoxobchern = New System.Windows.Forms.TextBox()
        Me.TextBoxpdchvert = New System.Windows.Forms.TextBox()
        Me.TextBoxprip = New System.Windows.Forms.TextBox()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.RadioButtonalum = New System.Windows.Forms.RadioButton()
        Me.RadioButtonstil = New System.Windows.Forms.RadioButton()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.CheckBoxviborka = New System.Windows.Forms.CheckBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.CheckBoxchist = New System.Windows.Forms.CheckBox()
        Me.CheckBoxchern = New System.Windows.Forms.CheckBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.RasstanofkaInsrtGrBox = New System.Windows.Forms.GroupBox()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.ParamInsrtGrBox = New System.Windows.Forms.GroupBox()
        Me.TextBoxLrch = New System.Windows.Forms.TextBox()
        Me.TextBoxLvil = New System.Windows.Forms.TextBox()
        Me.TextBoxDsv = New System.Windows.Forms.TextBox()
        Me.TextBoxDzdva = New System.Windows.Forms.TextBox()
        Me.TextBoxDzone = New System.Windows.Forms.TextBox()
        Me.TextBoxDtf = New System.Windows.Forms.TextBox()
        Me.TextBoxDkf = New System.Windows.Forms.TextBox()
        Me.LabelLrch = New System.Windows.Forms.Label()
        Me.LabelLvil = New System.Windows.Forms.Label()
        Me.Labeldcv = New System.Windows.Forms.Label()
        Me.Labeldzdva = New System.Windows.Forms.Label()
        Me.Labeldzone = New System.Windows.Forms.Label()
        Me.Labeldtf = New System.Windows.Forms.Label()
        Me.Labeldtk = New System.Windows.Forms.Label()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.GroupBox7 = New System.Windows.Forms.GroupBox()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.TrackBar2 = New System.Windows.Forms.TrackBar()
        Me.TrackBar1 = New System.Windows.Forms.TrackBar()
        Me.Button18 = New System.Windows.Forms.Button()
        Me.ViborKontura = New System.Windows.Forms.Button()
        Me.CheckBox5 = New System.Windows.Forms.CheckBox()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.RadioButton23 = New System.Windows.Forms.RadioButton()
        Me.RadioButton22 = New System.Windows.Forms.RadioButton()
        Me.Button14 = New System.Windows.Forms.Button()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.RadioButton17 = New System.Windows.Forms.RadioButton()
        Me.RadioButton16 = New System.Windows.Forms.RadioButton()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ListBox3 = New System.Windows.Forms.ListBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.RadioButton13 = New System.Windows.Forms.RadioButton()
        Me.RadioButton19 = New System.Windows.Forms.RadioButton()
        Me.RadioButton12 = New System.Windows.Forms.RadioButton()
        Me.RadioButton11 = New System.Windows.Forms.RadioButton()
        Me.RadioButton10 = New System.Windows.Forms.RadioButton()
        Me.RadioButton3 = New System.Windows.Forms.RadioButton()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.RadioButton4 = New System.Windows.Forms.RadioButton()
        Me.Button15 = New System.Windows.Forms.Button()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage4.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        Me.GroupBox8.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.RasstanofkaInsrtGrBox.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ParamInsrtGrBox.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage1.SuspendLayout()
        Me.GroupBox7.SuspendLayout()
        CType(Me.TrackBar2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TrackBar1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox6.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ФайлToolStripMenuItem, Me.ДействияСФайломToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1006, 28)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ФайлToolStripMenuItem
        '
        Me.ФайлToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.НовыйToolStripMenuItem, Me.ВставитьВидыС3DМоделиToolStripMenuItem})
        Me.ФайлToolStripMenuItem.Name = "ФайлToolStripMenuItem"
        Me.ФайлToolStripMenuItem.Size = New System.Drawing.Size(173, 24)
        Me.ФайлToolStripMenuItem.Text = "Действия с чертежом"
        '
        'НовыйToolStripMenuItem
        '
        Me.НовыйToolStripMenuItem.Name = "НовыйToolStripMenuItem"
        Me.НовыйToolStripMenuItem.Size = New System.Drawing.Size(284, 26)
        Me.НовыйToolStripMenuItem.Text = "Открыть Inventor"
        '
        'ВставитьВидыС3DМоделиToolStripMenuItem
        '
        Me.ВставитьВидыС3DМоделиToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ВставитьГлавныйВидToolStripMenuItem, Me.ПовернутьГлавныйВидToolStripMenuItem, Me.ПовернутьГлавныйВидНалевоToolStripMenuItem, Me.УвеличитьМасштабЧертежаToolStripMenuItem, Me.УменьшитьМасштабЧертежаToolStripMenuItem, Me.ВставитьПроекционныеВидыToolStripMenuItem, Me.ОчиститьПолеЧертежаToolStripMenuItem})
        Me.ВставитьВидыС3DМоделиToolStripMenuItem.Name = "ВставитьВидыС3DМоделиToolStripMenuItem"
        Me.ВставитьВидыС3DМоделиToolStripMenuItem.Size = New System.Drawing.Size(284, 26)
        Me.ВставитьВидыС3DМоделиToolStripMenuItem.Text = "Вставить виды с 3D модели"
        '
        'ВставитьГлавныйВидToolStripMenuItem
        '
        Me.ВставитьГлавныйВидToolStripMenuItem.Name = "ВставитьГлавныйВидToolStripMenuItem"
        Me.ВставитьГлавныйВидToolStripMenuItem.Size = New System.Drawing.Size(323, 26)
        Me.ВставитьГлавныйВидToolStripMenuItem.Text = "Вставить главный вид"
        '
        'ПовернутьГлавныйВидToolStripMenuItem
        '
        Me.ПовернутьГлавныйВидToolStripMenuItem.Name = "ПовернутьГлавныйВидToolStripMenuItem"
        Me.ПовернутьГлавныйВидToolStripMenuItem.Size = New System.Drawing.Size(323, 26)
        Me.ПовернутьГлавныйВидToolStripMenuItem.Text = "Повернуть главный вид налево"
        '
        'ПовернутьГлавныйВидНалевоToolStripMenuItem
        '
        Me.ПовернутьГлавныйВидНалевоToolStripMenuItem.Name = "ПовернутьГлавныйВидНалевоToolStripMenuItem"
        Me.ПовернутьГлавныйВидНалевоToolStripMenuItem.Size = New System.Drawing.Size(323, 26)
        Me.ПовернутьГлавныйВидНалевоToolStripMenuItem.Text = "Повернуть главный вид направо"
        '
        'УвеличитьМасштабЧертежаToolStripMenuItem
        '
        Me.УвеличитьМасштабЧертежаToolStripMenuItem.Name = "УвеличитьМасштабЧертежаToolStripMenuItem"
        Me.УвеличитьМасштабЧертежаToolStripMenuItem.Size = New System.Drawing.Size(323, 26)
        Me.УвеличитьМасштабЧертежаToolStripMenuItem.Text = "Увеличить масштаб чертежа"
        '
        'УменьшитьМасштабЧертежаToolStripMenuItem
        '
        Me.УменьшитьМасштабЧертежаToolStripMenuItem.Name = "УменьшитьМасштабЧертежаToolStripMenuItem"
        Me.УменьшитьМасштабЧертежаToolStripMenuItem.Size = New System.Drawing.Size(323, 26)
        Me.УменьшитьМасштабЧертежаToolStripMenuItem.Text = "Уменьшить масштаб чертежа"
        '
        'ВставитьПроекционныеВидыToolStripMenuItem
        '
        Me.ВставитьПроекционныеВидыToolStripMenuItem.Name = "ВставитьПроекционныеВидыToolStripMenuItem"
        Me.ВставитьПроекционныеВидыToolStripMenuItem.Size = New System.Drawing.Size(323, 26)
        Me.ВставитьПроекционныеВидыToolStripMenuItem.Text = "Вставить проекционные виды"
        '
        'ОчиститьПолеЧертежаToolStripMenuItem
        '
        Me.ОчиститьПолеЧертежаToolStripMenuItem.Name = "ОчиститьПолеЧертежаToolStripMenuItem"
        Me.ОчиститьПолеЧертежаToolStripMenuItem.Size = New System.Drawing.Size(323, 26)
        Me.ОчиститьПолеЧертежаToolStripMenuItem.Text = "Очистить поле чертежа"
        '
        'ДействияСФайломToolStripMenuItem
        '
        Me.ДействияСФайломToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ЭкспортВGcodeToolStripMenuItem, Me.ОткрытьПроектToolStripMenuItem})
        Me.ДействияСФайломToolStripMenuItem.Name = "ДействияСФайломToolStripMenuItem"
        Me.ДействияСФайломToolStripMenuItem.Size = New System.Drawing.Size(158, 24)
        Me.ДействияСФайломToolStripMenuItem.Text = "Действия с файлом"
        '
        'ЭкспортВGcodeToolStripMenuItem
        '
        Me.ЭкспортВGcodeToolStripMenuItem.Name = "ЭкспортВGcodeToolStripMenuItem"
        Me.ЭкспортВGcodeToolStripMenuItem.Size = New System.Drawing.Size(218, 26)
        Me.ЭкспортВGcodeToolStripMenuItem.Text = "Сохранить проект"
        '
        'ОткрытьПроектToolStripMenuItem
        '
        Me.ОткрытьПроектToolStripMenuItem.Name = "ОткрытьПроектToolStripMenuItem"
        Me.ОткрытьПроектToolStripMenuItem.Size = New System.Drawing.Size(218, 26)
        Me.ОткрытьПроектToolStripMenuItem.Text = "Открыть проект"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.LightGray
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.Maroon
        Me.Button1.Location = New System.Drawing.Point(618, 478)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(132, 60)
        Me.Button1.TabIndex = 7
        Me.Button1.Text = "Построить контур"
        Me.Button1.UseMnemonic = False
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Timer1
        '
        Me.Timer1.Interval = 1000
        '
        'Ochistka
        '
        Me.Ochistka.BackColor = System.Drawing.Color.LightGray
        Me.Ochistka.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Ochistka.ForeColor = System.Drawing.Color.Maroon
        Me.Ochistka.Location = New System.Drawing.Point(618, 610)
        Me.Ochistka.Name = "Ochistka"
        Me.Ochistka.Size = New System.Drawing.Size(132, 60)
        Me.Ochistka.TabIndex = 15
        Me.Ochistka.Text = "Очистить поле"
        Me.Ochistka.UseVisualStyleBackColor = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Maroon
        Me.Label5.Location = New System.Drawing.Point(242, 450)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(138, 25)
        Me.Label5.TabIndex = 20
        Me.Label5.Text = "Траектории "
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'DataGridView2
        '
        Me.DataGridView2.AllowUserToOrderColumns = True
        Me.DataGridView2.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DataGridView2.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.ColumnHeadersVisible = False
        Me.DataGridView2.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column3})
        Me.DataGridView2.Location = New System.Drawing.Point(760, 478)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.RowHeadersVisible = False
        Me.DataGridView2.RowHeadersWidth = 51
        Me.DataGridView2.RowTemplate.Height = 24
        Me.DataGridView2.Size = New System.Drawing.Size(231, 120)
        Me.DataGridView2.TabIndex = 33
        '
        'Column3
        '
        Me.Column3.HeaderText = "Контуры"
        Me.Column3.MinimumWidth = 6
        Me.Column3.Name = "Column3"
        Me.Column3.Width = 160
        '
        'Button7
        '
        Me.Button7.BackColor = System.Drawing.Color.LightGray
        Me.Button7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Button7.ForeColor = System.Drawing.Color.Maroon
        Me.Button7.Location = New System.Drawing.Point(618, 544)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(132, 60)
        Me.Button7.TabIndex = 23
        Me.Button7.Text = "Построить траекторию"
        Me.Button7.UseVisualStyleBackColor = False
        '
        'Button11
        '
        Me.Button11.BackColor = System.Drawing.Color.LightGray
        Me.Button11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Button11.ForeColor = System.Drawing.Color.Maroon
        Me.Button11.Location = New System.Drawing.Point(618, 676)
        Me.Button11.Name = "Button11"
        Me.Button11.Size = New System.Drawing.Size(132, 62)
        Me.Button11.TabIndex = 25
        Me.Button11.Text = "Сброс СК"
        Me.Button11.UseVisualStyleBackColor = False
        '
        'Button13
        '
        Me.Button13.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Button13.ForeColor = System.Drawing.Color.Maroon
        Me.Button13.Location = New System.Drawing.Point(818, 611)
        Me.Button13.Name = "Button13"
        Me.Button13.Size = New System.Drawing.Size(132, 62)
        Me.Button13.TabIndex = 26
        Me.Button13.Text = "Удалить контур"
        Me.Button13.UseVisualStyleBackColor = True
        '
        'ListBox5
        '
        Me.ListBox5.FormattingEnabled = True
        Me.ListBox5.ItemHeight = 16
        Me.ListBox5.Location = New System.Drawing.Point(618, 797)
        Me.ListBox5.Name = "ListBox5"
        Me.ListBox5.Size = New System.Drawing.Size(417, 148)
        Me.ListBox5.TabIndex = 34
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label24.ForeColor = System.Drawing.Color.Maroon
        Me.Label24.Location = New System.Drawing.Point(742, 759)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(136, 18)
        Me.Label24.TabIndex = 35
        Me.Label24.Text = "Отчёт об ошибках"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Cornsilk
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox1.Location = New System.Drawing.Point(12, 478)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(600, 467)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox1.TabIndex = 5
        Me.PictureBox1.TabStop = False
        '
        'TabPage4
        '
        Me.TabPage4.BackColor = System.Drawing.Color.DarkGray
        Me.TabPage4.Controls.Add(Me.TextBoxsek)
        Me.TabPage4.Controls.Add(Me.TextBoxmin)
        Me.TabPage4.Controls.Add(Me.TextBox11)
        Me.TabPage4.Controls.Add(Me.TextBox10)
        Me.TabPage4.Controls.Add(Me.Label34)
        Me.TabPage4.Controls.Add(Me.Label33)
        Me.TabPage4.Controls.Add(Me.Label32)
        Me.TabPage4.Controls.Add(Me.ListBox4)
        Me.TabPage4.Controls.Add(Me.CheckBox4)
        Me.TabPage4.Controls.Add(Me.Button12)
        Me.TabPage4.Controls.Add(Me.Button2)
        Me.TabPage4.Controls.Add(Me.Label22)
        Me.TabPage4.Controls.Add(Me.Label21)
        Me.TabPage4.Controls.Add(Me.Button10)
        Me.TabPage4.Controls.Add(Me.Button9)
        Me.TabPage4.Controls.Add(Me.ListBox2)
        Me.TabPage4.Location = New System.Drawing.Point(4, 25)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage4.Size = New System.Drawing.Size(995, 382)
        Me.TabPage4.TabIndex = 3
        Me.TabPage4.Text = "Перевод в G-code"
        '
        'TextBoxsek
        '
        Me.TextBoxsek.Location = New System.Drawing.Point(145, 351)
        Me.TextBoxsek.Name = "TextBoxsek"
        Me.TextBoxsek.Size = New System.Drawing.Size(68, 22)
        Me.TextBoxsek.TabIndex = 32
        '
        'TextBoxmin
        '
        Me.TextBoxmin.Location = New System.Drawing.Point(19, 350)
        Me.TextBoxmin.Name = "TextBoxmin"
        Me.TextBoxmin.Size = New System.Drawing.Size(63, 22)
        Me.TextBoxmin.TabIndex = 31
        '
        'TextBox11
        '
        Me.TextBox11.Location = New System.Drawing.Point(19, 205)
        Me.TextBox11.Name = "TextBox11"
        Me.TextBox11.Size = New System.Drawing.Size(278, 22)
        Me.TextBox11.TabIndex = 25
        '
        'TextBox10
        '
        Me.TextBox10.Location = New System.Drawing.Point(19, 127)
        Me.TextBox10.Name = "TextBox10"
        Me.TextBox10.Size = New System.Drawing.Size(278, 22)
        Me.TextBox10.TabIndex = 23
        '
        'Label34
        '
        Me.Label34.AutoSize = True
        Me.Label34.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label34.ForeColor = System.Drawing.Color.Maroon
        Me.Label34.Location = New System.Drawing.Point(219, 352)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(36, 18)
        Me.Label34.TabIndex = 34
        Me.Label34.Text = "сек."
        '
        'Label33
        '
        Me.Label33.AutoSize = True
        Me.Label33.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label33.ForeColor = System.Drawing.Color.Maroon
        Me.Label33.Location = New System.Drawing.Point(100, 351)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(39, 18)
        Me.Label33.TabIndex = 33
        Me.Label33.Text = "мин."
        '
        'Label32
        '
        Me.Label32.AutoSize = True
        Me.Label32.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label32.ForeColor = System.Drawing.Color.Maroon
        Me.Label32.Location = New System.Drawing.Point(16, 317)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(136, 18)
        Me.Label32.TabIndex = 30
        Me.Label32.Text = "Время обработки:"
        '
        'ListBox4
        '
        Me.ListBox4.FormattingEnabled = True
        Me.ListBox4.ItemHeight = 16
        Me.ListBox4.Location = New System.Drawing.Point(768, 43)
        Me.ListBox4.Name = "ListBox4"
        Me.ListBox4.Size = New System.Drawing.Size(216, 324)
        Me.ListBox4.TabIndex = 29
        '
        'CheckBox4
        '
        Me.CheckBox4.AutoSize = True
        Me.CheckBox4.ForeColor = System.Drawing.Color.Maroon
        Me.CheckBox4.Location = New System.Drawing.Point(768, 16)
        Me.CheckBox4.Name = "CheckBox4"
        Me.CheckBox4.Size = New System.Drawing.Size(121, 21)
        Me.CheckBox4.TabIndex = 28
        Me.CheckBox4.Text = "Расширенное"
        Me.CheckBox4.UseVisualStyleBackColor = True
        '
        'Button12
        '
        Me.Button12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Button12.ForeColor = System.Drawing.Color.Maroon
        Me.Button12.Location = New System.Drawing.Point(19, 243)
        Me.Button12.Name = "Button12"
        Me.Button12.Size = New System.Drawing.Size(162, 61)
        Me.Button12.TabIndex = 27
        Me.Button12.Text = "Сохранить"
        Me.Button12.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.LightGray
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.Maroon
        Me.Button2.Location = New System.Drawing.Point(324, 121)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(40, 32)
        Me.Button2.TabIndex = 26
        Me.Button2.Text = "..."
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label22.ForeColor = System.Drawing.Color.Maroon
        Me.Label22.Location = New System.Drawing.Point(16, 170)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(191, 18)
        Me.Label22.TabIndex = 24
        Me.Label22.Text = "Имя файла и расширение:"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label21.ForeColor = System.Drawing.Color.Maroon
        Me.Label21.Location = New System.Drawing.Point(16, 91)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(106, 18)
        Me.Label21.TabIndex = 22
        Me.Label21.Text = "Путь к файлу:"
        '
        'Button10
        '
        Me.Button10.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.Button10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Button10.ForeColor = System.Drawing.Color.Maroon
        Me.Button10.Location = New System.Drawing.Point(202, 16)
        Me.Button10.Name = "Button10"
        Me.Button10.Size = New System.Drawing.Size(162, 61)
        Me.Button10.TabIndex = 21
        Me.Button10.Text = "Очистить поле"
        Me.Button10.UseVisualStyleBackColor = False
        '
        'Button9
        '
        Me.Button9.BackColor = System.Drawing.Color.LightGray
        Me.Button9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Button9.ForeColor = System.Drawing.Color.Maroon
        Me.Button9.Location = New System.Drawing.Point(19, 16)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(162, 61)
        Me.Button9.TabIndex = 20
        Me.Button9.Text = "Перевести в G-code"
        Me.Button9.UseVisualStyleBackColor = False
        '
        'ListBox2
        '
        Me.ListBox2.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.ListBox2.FormattingEnabled = True
        Me.ListBox2.ItemHeight = 16
        Me.ListBox2.Location = New System.Drawing.Point(389, 16)
        Me.ListBox2.Name = "ListBox2"
        Me.ListBox2.Size = New System.Drawing.Size(357, 356)
        Me.ListBox2.TabIndex = 19
        '
        'TextBoxmaxY
        '
        Me.TextBoxmaxY.Location = New System.Drawing.Point(292, 130)
        Me.TextBoxmaxY.Name = "TextBoxmaxY"
        Me.TextBoxmaxY.Size = New System.Drawing.Size(55, 22)
        Me.TextBoxmaxY.TabIndex = 43
        Me.TextBoxmaxY.Text = "0"
        '
        'TextBoxmaxX
        '
        Me.TextBoxmaxX.Location = New System.Drawing.Point(292, 100)
        Me.TextBoxmaxX.Name = "TextBoxmaxX"
        Me.TextBoxmaxX.Size = New System.Drawing.Size(55, 22)
        Me.TextBoxmaxX.TabIndex = 41
        Me.TextBoxmaxX.Text = "0"
        '
        'Label35
        '
        Me.Label35.AutoSize = True
        Me.Label35.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label35.ForeColor = System.Drawing.Color.Maroon
        Me.Label35.Location = New System.Drawing.Point(224, 130)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(53, 18)
        Me.Label35.TabIndex = 42
        Me.Label35.Text = "max Y:"
        '
        'Label36
        '
        Me.Label36.AutoSize = True
        Me.Label36.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label36.ForeColor = System.Drawing.Color.Maroon
        Me.Label36.Location = New System.Drawing.Point(223, 100)
        Me.Label36.Name = "Label36"
        Me.Label36.Size = New System.Drawing.Size(54, 18)
        Me.Label36.TabIndex = 40
        Me.Label36.Text = "max X:"
        '
        'CheckBoxpoyasn
        '
        Me.CheckBoxpoyasn.AutoSize = True
        Me.CheckBoxpoyasn.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.CheckBoxpoyasn.ForeColor = System.Drawing.Color.Maroon
        Me.CheckBoxpoyasn.Location = New System.Drawing.Point(215, 179)
        Me.CheckBoxpoyasn.Name = "CheckBoxpoyasn"
        Me.CheckBoxpoyasn.Size = New System.Drawing.Size(142, 58)
        Me.CheckBoxpoyasn.TabIndex = 39
        Me.CheckBoxpoyasn.Text = "Показывать " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "пояснительные " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "изображения"
        Me.CheckBoxpoyasn.UseVisualStyleBackColor = True
        '
        'TextBoxYASK
        '
        Me.TextBoxYASK.Location = New System.Drawing.Point(292, 66)
        Me.TextBoxYASK.Name = "TextBoxYASK"
        Me.TextBoxYASK.Size = New System.Drawing.Size(55, 22)
        Me.TextBoxYASK.TabIndex = 38
        Me.TextBoxYASK.Text = "0"
        '
        'TextBoxXASK
        '
        Me.TextBoxXASK.Location = New System.Drawing.Point(292, 36)
        Me.TextBoxXASK.Name = "TextBoxXASK"
        Me.TextBoxXASK.Size = New System.Drawing.Size(55, 22)
        Me.TextBoxXASK.TabIndex = 36
        Me.TextBoxXASK.Text = "0"
        '
        'Label41
        '
        Me.Label41.AutoSize = True
        Me.Label41.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label41.ForeColor = System.Drawing.Color.Maroon
        Me.Label41.Location = New System.Drawing.Point(224, 66)
        Me.Label41.Name = "Label41"
        Me.Label41.Size = New System.Drawing.Size(55, 18)
        Me.Label41.TabIndex = 37
        Me.Label41.Text = "Y АСК:"
        '
        'Label40
        '
        Me.Label40.AutoSize = True
        Me.Label40.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label40.ForeColor = System.Drawing.Color.Maroon
        Me.Label40.Location = New System.Drawing.Point(223, 36)
        Me.Label40.Name = "Label40"
        Me.Label40.Size = New System.Drawing.Size(56, 18)
        Me.Label40.TabIndex = 35
        Me.Label40.Text = "X АСК:"
        '
        'TabPage3
        '
        Me.TabPage3.BackColor = System.Drawing.Color.DarkGray
        Me.TabPage3.Controls.Add(Me.Button19)
        Me.TabPage3.Controls.Add(Me.GroupBox8)
        Me.TabPage3.Controls.Add(Me.Label27)
        Me.TabPage3.Controls.Add(Me.Label26)
        Me.TabPage3.Controls.Add(Me.Label7)
        Me.TabPage3.Controls.Add(Me.Label25)
        Me.TabPage3.Controls.Add(Me.Button17)
        Me.TabPage3.Controls.Add(Me.GroupBox5)
        Me.TabPage3.Controls.Add(Me.TextBoxmaxZ)
        Me.TabPage3.Controls.Add(Me.TextBoxviskon)
        Me.TabPage3.Controls.Add(Me.TextBoxdeltaniz)
        Me.TabPage3.Controls.Add(Me.TextBoxdletaverh)
        Me.TabPage3.Controls.Add(Me.TextBoxnpl)
        Me.TabPage3.Controls.Add(Me.TextBoxvpl)
        Me.TabPage3.Controls.Add(Me.TextBoxplbez)
        Me.TabPage3.Controls.Add(Me.TextBoxperfrez)
        Me.TabPage3.Controls.Add(Me.TextBoxbzrast)
        Me.TabPage3.Controls.Add(Me.TextBoxobchist)
        Me.TabPage3.Controls.Add(Me.TextBoxpodchist)
        Me.TabPage3.Controls.Add(Me.TextBoxobchern)
        Me.TabPage3.Controls.Add(Me.TextBoxpdchvert)
        Me.TabPage3.Controls.Add(Me.TextBoxprip)
        Me.TabPage3.Controls.Add(Me.Label23)
        Me.TabPage3.Controls.Add(Me.Label20)
        Me.TabPage3.Controls.Add(Me.GroupBox3)
        Me.TabPage3.Controls.Add(Me.Label19)
        Me.TabPage3.Controls.Add(Me.Label18)
        Me.TabPage3.Controls.Add(Me.Label17)
        Me.TabPage3.Controls.Add(Me.Label16)
        Me.TabPage3.Controls.Add(Me.Label11)
        Me.TabPage3.Controls.Add(Me.Label14)
        Me.TabPage3.Controls.Add(Me.CheckBoxviborka)
        Me.TabPage3.Controls.Add(Me.Label15)
        Me.TabPage3.Controls.Add(Me.CheckBoxchist)
        Me.TabPage3.Controls.Add(Me.CheckBoxchern)
        Me.TabPage3.Controls.Add(Me.Label13)
        Me.TabPage3.Controls.Add(Me.Label12)
        Me.TabPage3.Controls.Add(Me.Label10)
        Me.TabPage3.Controls.Add(Me.Label9)
        Me.TabPage3.Controls.Add(Me.Label8)
        Me.TabPage3.Location = New System.Drawing.Point(4, 25)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(995, 382)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Назначение режимов"
        '
        'Button19
        '
        Me.Button19.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Button19.ForeColor = System.Drawing.Color.Maroon
        Me.Button19.Location = New System.Drawing.Point(859, 274)
        Me.Button19.Name = "Button19"
        Me.Button19.Size = New System.Drawing.Size(128, 54)
        Me.Button19.TabIndex = 53
        Me.Button19.Text = "Сохранить данные "
        Me.Button19.UseVisualStyleBackColor = True
        '
        'GroupBox8
        '
        Me.GroupBox8.BackColor = System.Drawing.Color.DarkGray
        Me.GroupBox8.Controls.Add(Me.TextBoxSrez)
        Me.GroupBox8.Controls.Add(Me.TextBoxVrez)
        Me.GroupBox8.Controls.Add(Me.Label29)
        Me.GroupBox8.Controls.Add(Me.Label28)
        Me.GroupBox8.Controls.Add(Me.RadioButton18)
        Me.GroupBox8.Controls.Add(Me.RadioButton26)
        Me.GroupBox8.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.GroupBox8.ForeColor = System.Drawing.Color.Maroon
        Me.GroupBox8.Location = New System.Drawing.Point(541, 24)
        Me.GroupBox8.Name = "GroupBox8"
        Me.GroupBox8.Size = New System.Drawing.Size(414, 82)
        Me.GroupBox8.TabIndex = 52
        Me.GroupBox8.TabStop = False
        Me.GroupBox8.Text = "Исходные данные для режимов резания"
        '
        'TextBoxSrez
        '
        Me.TextBoxSrez.Location = New System.Drawing.Point(332, 50)
        Me.TextBoxSrez.Name = "TextBoxSrez"
        Me.TextBoxSrez.Size = New System.Drawing.Size(58, 22)
        Me.TextBoxSrez.TabIndex = 54
        '
        'TextBoxVrez
        '
        Me.TextBoxVrez.Location = New System.Drawing.Point(146, 50)
        Me.TextBoxVrez.Name = "TextBoxVrez"
        Me.TextBoxVrez.Size = New System.Drawing.Size(58, 22)
        Me.TextBoxVrez.TabIndex = 53
        Me.TextBoxVrez.Text = "0"
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label29.ForeColor = System.Drawing.Color.Maroon
        Me.Label29.Location = New System.Drawing.Point(216, 53)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(117, 17)
        Me.Label29.TabIndex = 55
        Me.Label29.Text = "Подача, мм/мин:"
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label28.ForeColor = System.Drawing.Color.Maroon
        Me.Label28.Location = New System.Drawing.Point(6, 53)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(119, 17)
        Me.Label28.TabIndex = 53
        Me.Label28.Text = "Скорость, м/мин:"
        '
        'RadioButton18
        '
        Me.RadioButton18.AutoSize = True
        Me.RadioButton18.Location = New System.Drawing.Point(265, 23)
        Me.RadioButton18.Name = "RadioButton18"
        Me.RadioButton18.Size = New System.Drawing.Size(86, 21)
        Me.RadioButton18.TabIndex = 1
        Me.RadioButton18.TabStop = True
        Me.RadioButton18.Text = "Вручную"
        Me.RadioButton18.UseVisualStyleBackColor = True
        '
        'RadioButton26
        '
        Me.RadioButton26.AutoSize = True
        Me.RadioButton26.Location = New System.Drawing.Point(67, 23)
        Me.RadioButton26.Name = "RadioButton26"
        Me.RadioButton26.Size = New System.Drawing.Size(109, 21)
        Me.RadioButton26.TabIndex = 0
        Me.RadioButton26.TabStop = True
        Me.RadioButton26.Text = "По каталогу"
        Me.RadioButton26.UseVisualStyleBackColor = True
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label27.ForeColor = System.Drawing.Color.Maroon
        Me.Label27.Location = New System.Drawing.Point(291, 3)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(407, 18)
        Me.Label27.TabIndex = 51
        Me.Label27.Text = "Настройка режимов резания и условий обработки"
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label26.ForeColor = System.Drawing.Color.Maroon
        Me.Label26.Location = New System.Drawing.Point(394, 237)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(227, 18)
        Me.Label26.TabIndex = 50
        Me.Label26.Text = "Настройка уровней контура"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Maroon
        Me.Label7.Location = New System.Drawing.Point(50, 24)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(198, 18)
        Me.Label7.TabIndex = 49
        Me.Label7.Text = "Выбранный инструмент:"
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label25.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Label25.Location = New System.Drawing.Point(62, 68)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(173, 18)
        Me.Label25.TabIndex = 48
        Me.Label25.Text = "Фреза концевая ф10"
        '
        'Button17
        '
        Me.Button17.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Button17.ForeColor = System.Drawing.Color.Maroon
        Me.Button17.Location = New System.Drawing.Point(859, 141)
        Me.Button17.Name = "Button17"
        Me.Button17.Size = New System.Drawing.Size(128, 55)
        Me.Button17.TabIndex = 47
        Me.Button17.Text = "Настроить подвод/отвод"
        Me.Button17.UseVisualStyleBackColor = True
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.RadioButton21)
        Me.GroupBox5.Controls.Add(Me.RadioButton20)
        Me.GroupBox5.Controls.Add(Me.TextBoxkolvopr)
        Me.GroupBox5.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.GroupBox5.ForeColor = System.Drawing.Color.Maroon
        Me.GroupBox5.Location = New System.Drawing.Point(614, 141)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(193, 93)
        Me.GroupBox5.TabIndex = 44
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Количество проходов"
        '
        'RadioButton21
        '
        Me.RadioButton21.AutoSize = True
        Me.RadioButton21.Location = New System.Drawing.Point(9, 54)
        Me.RadioButton21.Name = "RadioButton21"
        Me.RadioButton21.Size = New System.Drawing.Size(86, 21)
        Me.RadioButton21.TabIndex = 2
        Me.RadioButton21.TabStop = True
        Me.RadioButton21.Text = "Вручную"
        Me.RadioButton21.UseVisualStyleBackColor = True
        '
        'RadioButton20
        '
        Me.RadioButton20.AutoSize = True
        Me.RadioButton20.Location = New System.Drawing.Point(9, 26)
        Me.RadioButton20.Name = "RadioButton20"
        Me.RadioButton20.Size = New System.Drawing.Size(130, 21)
        Me.RadioButton20.TabIndex = 1
        Me.RadioButton20.TabStop = True
        Me.RadioButton20.Text = "Автоматически"
        Me.RadioButton20.UseVisualStyleBackColor = True
        '
        'TextBoxkolvopr
        '
        Me.TextBoxkolvopr.Location = New System.Drawing.Point(113, 54)
        Me.TextBoxkolvopr.Name = "TextBoxkolvopr"
        Me.TextBoxkolvopr.Size = New System.Drawing.Size(47, 22)
        Me.TextBoxkolvopr.TabIndex = 0
        '
        'TextBoxmaxZ
        '
        Me.TextBoxmaxZ.Location = New System.Drawing.Point(569, 339)
        Me.TextBoxmaxZ.Name = "TextBoxmaxZ"
        Me.TextBoxmaxZ.Size = New System.Drawing.Size(39, 22)
        Me.TextBoxmaxZ.TabIndex = 43
        Me.TextBoxmaxZ.Text = "3"
        '
        'TextBoxviskon
        '
        Me.TextBoxviskon.Location = New System.Drawing.Point(248, 266)
        Me.TextBoxviskon.Name = "TextBoxviskon"
        Me.TextBoxviskon.Size = New System.Drawing.Size(44, 22)
        Me.TextBoxviskon.TabIndex = 40
        Me.TextBoxviskon.Text = "20"
        '
        'TextBoxdeltaniz
        '
        Me.TextBoxdeltaniz.Location = New System.Drawing.Point(771, 305)
        Me.TextBoxdeltaniz.Name = "TextBoxdeltaniz"
        Me.TextBoxdeltaniz.Size = New System.Drawing.Size(53, 22)
        Me.TextBoxdeltaniz.TabIndex = 39
        Me.TextBoxdeltaniz.Text = "0"
        '
        'TextBoxdletaverh
        '
        Me.TextBoxdletaverh.Location = New System.Drawing.Point(771, 273)
        Me.TextBoxdletaverh.Name = "TextBoxdletaverh"
        Me.TextBoxdletaverh.Size = New System.Drawing.Size(53, 22)
        Me.TextBoxdletaverh.TabIndex = 38
        Me.TextBoxdletaverh.Text = "0"
        '
        'TextBoxnpl
        '
        Me.TextBoxnpl.Location = New System.Drawing.Point(569, 306)
        Me.TextBoxnpl.Name = "TextBoxnpl"
        Me.TextBoxnpl.Size = New System.Drawing.Size(39, 22)
        Me.TextBoxnpl.TabIndex = 36
        Me.TextBoxnpl.Text = "9"
        '
        'TextBoxvpl
        '
        Me.TextBoxvpl.Location = New System.Drawing.Point(569, 271)
        Me.TextBoxvpl.Name = "TextBoxvpl"
        Me.TextBoxvpl.Size = New System.Drawing.Size(39, 22)
        Me.TextBoxvpl.TabIndex = 35
        Me.TextBoxvpl.Text = "19"
        '
        'TextBoxplbez
        '
        Me.TextBoxplbez.Location = New System.Drawing.Point(248, 304)
        Me.TextBoxplbez.Name = "TextBoxplbez"
        Me.TextBoxplbez.Size = New System.Drawing.Size(44, 22)
        Me.TextBoxplbez.TabIndex = 29
        Me.TextBoxplbez.Text = "70"
        '
        'TextBoxperfrez
        '
        Me.TextBoxperfrez.Location = New System.Drawing.Point(541, 143)
        Me.TextBoxperfrez.Name = "TextBoxperfrez"
        Me.TextBoxperfrez.Size = New System.Drawing.Size(52, 22)
        Me.TextBoxperfrez.TabIndex = 13
        '
        'TextBoxbzrast
        '
        Me.TextBoxbzrast.Location = New System.Drawing.Point(248, 337)
        Me.TextBoxbzrast.Name = "TextBoxbzrast"
        Me.TextBoxbzrast.Size = New System.Drawing.Size(44, 22)
        Me.TextBoxbzrast.TabIndex = 30
        '
        'TextBoxobchist
        '
        Me.TextBoxobchist.Location = New System.Drawing.Point(541, 204)
        Me.TextBoxobchist.Name = "TextBoxobchist"
        Me.TextBoxobchist.Size = New System.Drawing.Size(52, 22)
        Me.TextBoxobchist.TabIndex = 12
        '
        'TextBoxpodchist
        '
        Me.TextBoxpodchist.Location = New System.Drawing.Point(541, 173)
        Me.TextBoxpodchist.Name = "TextBoxpodchist"
        Me.TextBoxpodchist.Size = New System.Drawing.Size(52, 22)
        Me.TextBoxpodchist.TabIndex = 11
        '
        'TextBoxobchern
        '
        Me.TextBoxobchern.Location = New System.Drawing.Point(248, 204)
        Me.TextBoxobchern.Name = "TextBoxobchern"
        Me.TextBoxobchern.Size = New System.Drawing.Size(58, 22)
        Me.TextBoxobchern.TabIndex = 8
        '
        'TextBoxpdchvert
        '
        Me.TextBoxpdchvert.Location = New System.Drawing.Point(248, 174)
        Me.TextBoxpdchvert.Name = "TextBoxpdchvert"
        Me.TextBoxpdchvert.Size = New System.Drawing.Size(58, 22)
        Me.TextBoxpdchvert.TabIndex = 7
        '
        'TextBoxprip
        '
        Me.TextBoxprip.Location = New System.Drawing.Point(248, 143)
        Me.TextBoxprip.Name = "TextBoxprip"
        Me.TextBoxprip.Size = New System.Drawing.Size(58, 22)
        Me.TextBoxprip.TabIndex = 6
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label23.ForeColor = System.Drawing.Color.Maroon
        Me.Label23.Location = New System.Drawing.Point(331, 342)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(184, 17)
        Me.Label23.TabIndex = 42
        Me.Label23.Text = "Макс. высота прохода, мм:"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label20.ForeColor = System.Drawing.Color.Maroon
        Me.Label20.Location = New System.Drawing.Point(21, 274)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(144, 17)
        Me.Label20.TabIndex = 41
        Me.Label20.Text = "Высота контура, мм:"
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.DarkGray
        Me.GroupBox3.Controls.Add(Me.RadioButtonalum)
        Me.GroupBox3.Controls.Add(Me.RadioButtonstil)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.GroupBox3.ForeColor = System.Drawing.Color.Maroon
        Me.GroupBox3.Location = New System.Drawing.Point(334, 24)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(153, 70)
        Me.GroupBox3.TabIndex = 21
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Материал"
        '
        'RadioButtonalum
        '
        Me.RadioButtonalum.AutoSize = True
        Me.RadioButtonalum.Location = New System.Drawing.Point(15, 44)
        Me.RadioButtonalum.Name = "RadioButtonalum"
        Me.RadioButtonalum.Size = New System.Drawing.Size(97, 21)
        Me.RadioButtonalum.TabIndex = 1
        Me.RadioButtonalum.TabStop = True
        Me.RadioButtonalum.Text = "Алюминий"
        Me.RadioButtonalum.UseVisualStyleBackColor = True
        '
        'RadioButtonstil
        '
        Me.RadioButtonstil.AutoSize = True
        Me.RadioButtonstil.Location = New System.Drawing.Point(15, 23)
        Me.RadioButtonstil.Name = "RadioButtonstil"
        Me.RadioButtonstil.Size = New System.Drawing.Size(68, 21)
        Me.RadioButtonstil.TabIndex = 0
        Me.RadioButtonstil.TabStop = True
        Me.RadioButtonstil.Text = "Сталь"
        Me.RadioButtonstil.UseVisualStyleBackColor = True
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label19.ForeColor = System.Drawing.Color.Maroon
        Me.Label19.Location = New System.Drawing.Point(638, 305)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(107, 17)
        Me.Label19.TabIndex = 37
        Me.Label19.Text = "Смещение, мм:"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label18.ForeColor = System.Drawing.Color.Maroon
        Me.Label18.Location = New System.Drawing.Point(638, 273)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(107, 17)
        Me.Label18.TabIndex = 34
        Me.Label18.Text = "Смещение, мм:"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.Maroon
        Me.Label17.Location = New System.Drawing.Point(331, 306)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(211, 17)
        Me.Label17.TabIndex = 33
        Me.Label17.Text = "Нижняя плоскость детали, мм:"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.Maroon
        Me.Label16.Location = New System.Drawing.Point(331, 271)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(215, 17)
        Me.Label16.TabIndex = 32
        Me.Label16.Text = "Верхняя плоскость детали, мм:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Maroon
        Me.Label11.Location = New System.Drawing.Point(331, 146)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(158, 17)
        Me.Label11.TabIndex = 14
        Me.Label11.Text = "Перекрытие фрезы, %"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.Maroon
        Me.Label14.Location = New System.Drawing.Point(21, 311)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(203, 17)
        Me.Label14.TabIndex = 27
        Me.Label14.Text = "Плоскость безопасности, мм:"
        '
        'CheckBoxviborka
        '
        Me.CheckBoxviborka.AutoSize = True
        Me.CheckBoxviborka.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.CheckBoxviborka.ForeColor = System.Drawing.Color.Maroon
        Me.CheckBoxviborka.Location = New System.Drawing.Point(630, 112)
        Me.CheckBoxviborka.Name = "CheckBoxviborka"
        Me.CheckBoxviborka.Size = New System.Drawing.Size(164, 21)
        Me.CheckBoxviborka.TabIndex = 31
        Me.CheckBoxviborka.Text = "Выборка материала"
        Me.CheckBoxviborka.UseVisualStyleBackColor = True
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.Maroon
        Me.Label15.Location = New System.Drawing.Point(21, 343)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(198, 17)
        Me.Label15.TabIndex = 28
        Me.Label15.Text = "Безопасное расстояние, мм:"
        '
        'CheckBoxchist
        '
        Me.CheckBoxchist.AutoSize = True
        Me.CheckBoxchist.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.CheckBoxchist.ForeColor = System.Drawing.Color.Maroon
        Me.CheckBoxchist.Location = New System.Drawing.Point(334, 112)
        Me.CheckBoxchist.Name = "CheckBoxchist"
        Me.CheckBoxchist.Size = New System.Drawing.Size(167, 21)
        Me.CheckBoxchist.TabIndex = 10
        Me.CheckBoxchist.Text = "Чистовая обработка"
        Me.CheckBoxchist.UseVisualStyleBackColor = True
        '
        'CheckBoxchern
        '
        Me.CheckBoxchern.AutoSize = True
        Me.CheckBoxchern.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.CheckBoxchern.ForeColor = System.Drawing.Color.Maroon
        Me.CheckBoxchern.Location = New System.Drawing.Point(25, 112)
        Me.CheckBoxchern.Name = "CheckBoxchern"
        Me.CheckBoxchern.Size = New System.Drawing.Size(169, 21)
        Me.CheckBoxchern.TabIndex = 9
        Me.CheckBoxchern.Text = "Черновая обработка"
        Me.CheckBoxchern.UseVisualStyleBackColor = True
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.Maroon
        Me.Label13.Location = New System.Drawing.Point(331, 207)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(188, 17)
        Me.Label13.TabIndex = 5
        Me.Label13.Text = "Обороты чистовые, об/мин"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.Maroon
        Me.Label12.Location = New System.Drawing.Point(331, 176)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(178, 17)
        Me.Label12.TabIndex = 4
        Me.Label12.Text = "Подача чистовая, мм/мин"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Maroon
        Me.Label10.Location = New System.Drawing.Point(23, 207)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(190, 17)
        Me.Label10.TabIndex = 2
        Me.Label10.Text = "Обороты черновые, об/мин"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Maroon
        Me.Label9.Location = New System.Drawing.Point(23, 177)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(209, 17)
        Me.Label9.TabIndex = 1
        Me.Label9.Text = "Подача вертикальная, мм/мин"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Maroon
        Me.Label8.Location = New System.Drawing.Point(23, 146)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(156, 17)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "Припуск черновой, мм"
        '
        'TabPage2
        '
        Me.TabPage2.BackColor = System.Drawing.Color.DarkGray
        Me.TabPage2.Controls.Add(Me.RasstanofkaInsrtGrBox)
        Me.TabPage2.Controls.Add(Me.ParamInsrtGrBox)
        Me.TabPage2.Controls.Add(Me.PictureBox3)
        Me.TabPage2.Controls.Add(Me.ListBox1)
        Me.TabPage2.Location = New System.Drawing.Point(4, 25)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(995, 382)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Выбор инструмента"
        '
        'RasstanofkaInsrtGrBox
        '
        Me.RasstanofkaInsrtGrBox.Controls.Add(Me.Button8)
        Me.RasstanofkaInsrtGrBox.Controls.Add(Me.Button6)
        Me.RasstanofkaInsrtGrBox.Controls.Add(Me.DataGridView1)
        Me.RasstanofkaInsrtGrBox.Controls.Add(Me.Button4)
        Me.RasstanofkaInsrtGrBox.Controls.Add(Me.Button3)
        Me.RasstanofkaInsrtGrBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.RasstanofkaInsrtGrBox.ForeColor = System.Drawing.Color.Maroon
        Me.RasstanofkaInsrtGrBox.Location = New System.Drawing.Point(702, 15)
        Me.RasstanofkaInsrtGrBox.Name = "RasstanofkaInsrtGrBox"
        Me.RasstanofkaInsrtGrBox.Size = New System.Drawing.Size(285, 352)
        Me.RasstanofkaInsrtGrBox.TabIndex = 7
        Me.RasstanofkaInsrtGrBox.TabStop = False
        Me.RasstanofkaInsrtGrBox.Text = "Расстановка инструмента "
        '
        'Button8
        '
        Me.Button8.Location = New System.Drawing.Point(145, 302)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(131, 38)
        Me.Button8.TabIndex = 13
        Me.Button8.Text = "Сохранить"
        Me.Button8.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.Location = New System.Drawing.Point(145, 253)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(134, 38)
        Me.Button6.TabIndex = 12
        Me.Button6.Text = "Удалить"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToOrderColumns = True
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2})
        Me.DataGridView1.Location = New System.Drawing.Point(4, 23)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(281, 220)
        Me.DataGridView1.TabIndex = 11
        '
        'Column1
        '
        Me.Column1.HeaderText = "№"
        Me.Column1.MinimumWidth = 6
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.Width = 25
        '
        'Column2
        '
        Me.Column2.HeaderText = "Инструмент"
        Me.Column2.MinimumWidth = 6
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        Me.Column2.Width = 170
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(6, 302)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(133, 38)
        Me.Button4.TabIndex = 10
        Me.Button4.Text = "Вниз"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(6, 253)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(133, 39)
        Me.Button3.TabIndex = 9
        Me.Button3.Text = "Вверх"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'ParamInsrtGrBox
        '
        Me.ParamInsrtGrBox.Controls.Add(Me.TextBoxLrch)
        Me.ParamInsrtGrBox.Controls.Add(Me.TextBoxLvil)
        Me.ParamInsrtGrBox.Controls.Add(Me.TextBoxDsv)
        Me.ParamInsrtGrBox.Controls.Add(Me.TextBoxDzdva)
        Me.ParamInsrtGrBox.Controls.Add(Me.TextBoxDzone)
        Me.ParamInsrtGrBox.Controls.Add(Me.TextBoxDtf)
        Me.ParamInsrtGrBox.Controls.Add(Me.TextBoxDkf)
        Me.ParamInsrtGrBox.Controls.Add(Me.LabelLrch)
        Me.ParamInsrtGrBox.Controls.Add(Me.LabelLvil)
        Me.ParamInsrtGrBox.Controls.Add(Me.Labeldcv)
        Me.ParamInsrtGrBox.Controls.Add(Me.Labeldzdva)
        Me.ParamInsrtGrBox.Controls.Add(Me.Labeldzone)
        Me.ParamInsrtGrBox.Controls.Add(Me.Labeldtf)
        Me.ParamInsrtGrBox.Controls.Add(Me.Labeldtk)
        Me.ParamInsrtGrBox.Controls.Add(Me.Button5)
        Me.ParamInsrtGrBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.ParamInsrtGrBox.ForeColor = System.Drawing.Color.Maroon
        Me.ParamInsrtGrBox.Location = New System.Drawing.Point(233, 15)
        Me.ParamInsrtGrBox.Name = "ParamInsrtGrBox"
        Me.ParamInsrtGrBox.Size = New System.Drawing.Size(188, 353)
        Me.ParamInsrtGrBox.TabIndex = 6
        Me.ParamInsrtGrBox.TabStop = False
        Me.ParamInsrtGrBox.Text = "Параметры инструмента"
        '
        'TextBoxLrch
        '
        Me.TextBoxLrch.Location = New System.Drawing.Point(79, 223)
        Me.TextBoxLrch.Name = "TextBoxLrch"
        Me.TextBoxLrch.Size = New System.Drawing.Size(99, 24)
        Me.TextBoxLrch.TabIndex = 14
        '
        'TextBoxLvil
        '
        Me.TextBoxLvil.Location = New System.Drawing.Point(79, 194)
        Me.TextBoxLvil.Name = "TextBoxLvil"
        Me.TextBoxLvil.Size = New System.Drawing.Size(100, 24)
        Me.TextBoxLvil.TabIndex = 13
        '
        'TextBoxDsv
        '
        Me.TextBoxDsv.Location = New System.Drawing.Point(79, 164)
        Me.TextBoxDsv.Name = "TextBoxDsv"
        Me.TextBoxDsv.Size = New System.Drawing.Size(100, 24)
        Me.TextBoxDsv.TabIndex = 12
        '
        'TextBoxDzdva
        '
        Me.TextBoxDzdva.Location = New System.Drawing.Point(79, 134)
        Me.TextBoxDzdva.Name = "TextBoxDzdva"
        Me.TextBoxDzdva.Size = New System.Drawing.Size(100, 24)
        Me.TextBoxDzdva.TabIndex = 11
        '
        'TextBoxDzone
        '
        Me.TextBoxDzone.Location = New System.Drawing.Point(79, 104)
        Me.TextBoxDzone.Name = "TextBoxDzone"
        Me.TextBoxDzone.Size = New System.Drawing.Size(100, 24)
        Me.TextBoxDzone.TabIndex = 10
        '
        'TextBoxDtf
        '
        Me.TextBoxDtf.Location = New System.Drawing.Point(79, 73)
        Me.TextBoxDtf.Name = "TextBoxDtf"
        Me.TextBoxDtf.Size = New System.Drawing.Size(100, 24)
        Me.TextBoxDtf.TabIndex = 9
        '
        'TextBoxDkf
        '
        Me.TextBoxDkf.Location = New System.Drawing.Point(79, 43)
        Me.TextBoxDkf.Name = "TextBoxDkf"
        Me.TextBoxDkf.Size = New System.Drawing.Size(100, 24)
        Me.TextBoxDkf.TabIndex = 8
        '
        'LabelLrch
        '
        Me.LabelLrch.AutoSize = True
        Me.LabelLrch.Location = New System.Drawing.Point(13, 225)
        Me.LabelLrch.Name = "LabelLrch"
        Me.LabelLrch.Size = New System.Drawing.Size(45, 18)
        Me.LabelLrch.TabIndex = 7
        Me.LabelLrch.Text = "Lрч ="
        '
        'LabelLvil
        '
        Me.LabelLvil.AutoSize = True
        Me.LabelLvil.Location = New System.Drawing.Point(13, 198)
        Me.LabelLvil.Name = "LabelLvil"
        Me.LabelLvil.Size = New System.Drawing.Size(57, 18)
        Me.LabelLvil.TabIndex = 6
        Me.LabelLvil.Text = "Lвыл ="
        '
        'Labeldcv
        '
        Me.Labeldcv.AutoSize = True
        Me.Labeldcv.Location = New System.Drawing.Point(13, 168)
        Me.Labeldcv.Name = "Labeldcv"
        Me.Labeldcv.Size = New System.Drawing.Size(48, 18)
        Me.Labeldcv.TabIndex = 5
        Me.Labeldcv.Text = "Dсв ="
        '
        'Labeldzdva
        '
        Me.Labeldzdva.AutoSize = True
        Me.Labeldzdva.Location = New System.Drawing.Point(13, 135)
        Me.Labeldzdva.Name = "Labeldzdva"
        Me.Labeldzdva.Size = New System.Drawing.Size(48, 18)
        Me.Labeldzdva.TabIndex = 4
        Me.Labeldzdva.Text = "Dц2 ="
        '
        'Labeldzone
        '
        Me.Labeldzone.AutoSize = True
        Me.Labeldzone.Location = New System.Drawing.Point(13, 107)
        Me.Labeldzone.Name = "Labeldzone"
        Me.Labeldzone.Size = New System.Drawing.Size(48, 18)
        Me.Labeldzone.TabIndex = 3
        Me.Labeldzone.Text = "Dц1 ="
        '
        'Labeldtf
        '
        Me.Labeldtf.AutoSize = True
        Me.Labeldtf.Location = New System.Drawing.Point(13, 76)
        Me.Labeldtf.Name = "Labeldtf"
        Me.Labeldtf.Size = New System.Drawing.Size(52, 18)
        Me.Labeldtf.TabIndex = 2
        Me.Labeldtf.Text = "Dтф ="
        '
        'Labeldtk
        '
        Me.Labeldtk.AutoSize = True
        Me.Labeldtk.Location = New System.Drawing.Point(13, 44)
        Me.Labeldtk.Name = "Labeldtk"
        Me.Labeldtk.Size = New System.Drawing.Size(53, 18)
        Me.Labeldtk.TabIndex = 1
        Me.Labeldtk.Text = "Dкф ="
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(22, 294)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(138, 46)
        Me.Button5.TabIndex = 0
        Me.Button5.Text = "Добавить"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = Global.MT2CAM.My.Resources.Resources.tap
        Me.PictureBox3.Location = New System.Drawing.Point(427, 6)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(269, 366)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox3.TabIndex = 5
        Me.PictureBox3.TabStop = False
        '
        'ListBox1
        '
        Me.ListBox1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ListBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.ListBox1.ForeColor = System.Drawing.Color.Maroon
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.ItemHeight = 18
        Me.ListBox1.Items.AddRange(New Object() {"Центровочное сверло", "Торцевая фреза ф80", "Торцевая фреза ф20", "Концевая фреза ф12", "Концевая фреза ф10", "Концевая фреза ф6", "Концевая фреза ф4", "Фасочная фреза ф6", "Сверло ф1,6", "Сверло ф2,05", "Сверло ф2,5", "Сверло ф3,3", "Сверло ф4,2", "Сверло ф5", "Метчик М2", "Метчик М3", "Метчик М3.5", "Метчик М4", "Метчик М5", "Метчик М6"})
        Me.ListBox1.Location = New System.Drawing.Point(8, 15)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(219, 328)
        Me.ListBox1.TabIndex = 4
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.Color.DarkGray
        Me.TabPage1.Controls.Add(Me.Button15)
        Me.TabPage1.Controls.Add(Me.TextBoxmaxY)
        Me.TabPage1.Controls.Add(Me.GroupBox7)
        Me.TabPage1.Controls.Add(Me.Button18)
        Me.TabPage1.Controls.Add(Me.TextBoxmaxX)
        Me.TabPage1.Controls.Add(Me.ViborKontura)
        Me.TabPage1.Controls.Add(Me.CheckBox5)
        Me.TabPage1.Controls.Add(Me.GroupBox6)
        Me.TabPage1.Controls.Add(Me.Label35)
        Me.TabPage1.Controls.Add(Me.Button14)
        Me.TabPage1.Controls.Add(Me.GroupBox4)
        Me.TabPage1.Controls.Add(Me.Label36)
        Me.TabPage1.Controls.Add(Me.Label6)
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Controls.Add(Me.TextBoxYASK)
        Me.TabPage1.Controls.Add(Me.CheckBoxpoyasn)
        Me.TabPage1.Controls.Add(Me.ListBox3)
        Me.TabPage1.Controls.Add(Me.PictureBox2)
        Me.TabPage1.Controls.Add(Me.TextBoxXASK)
        Me.TabPage1.Controls.Add(Me.TextBox1)
        Me.TabPage1.Controls.Add(Me.TextBox2)
        Me.TabPage1.Controls.Add(Me.TextBox3)
        Me.TabPage1.Controls.Add(Me.GroupBox1)
        Me.TabPage1.Controls.Add(Me.Label2)
        Me.TabPage1.Controls.Add(Me.Label3)
        Me.TabPage1.Controls.Add(Me.Label41)
        Me.TabPage1.Controls.Add(Me.Label4)
        Me.TabPage1.Controls.Add(Me.Label40)
        Me.TabPage1.Location = New System.Drawing.Point(4, 25)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(995, 382)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Выбор контура"
        '
        'GroupBox7
        '
        Me.GroupBox7.Controls.Add(Me.Label31)
        Me.GroupBox7.Controls.Add(Me.Label30)
        Me.GroupBox7.Controls.Add(Me.TrackBar2)
        Me.GroupBox7.Controls.Add(Me.TrackBar1)
        Me.GroupBox7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.GroupBox7.ForeColor = System.Drawing.Color.Maroon
        Me.GroupBox7.Location = New System.Drawing.Point(575, 230)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Size = New System.Drawing.Size(384, 138)
        Me.GroupBox7.TabIndex = 42
        Me.GroupBox7.TabStop = False
        Me.GroupBox7.Text = "Редактирование визуализации"
        '
        'Label31
        '
        Me.Label31.AutoSize = True
        Me.Label31.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label31.ForeColor = System.Drawing.Color.Maroon
        Me.Label31.Location = New System.Drawing.Point(7, 84)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(66, 20)
        Me.Label31.TabIndex = 44
        Me.Label31.Text = "Сдвиг"
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label30.ForeColor = System.Drawing.Color.Maroon
        Me.Label30.Location = New System.Drawing.Point(7, 37)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(93, 20)
        Me.Label30.TabIndex = 43
        Me.Label30.Text = "Масштаб"
        '
        'TrackBar2
        '
        Me.TrackBar2.Location = New System.Drawing.Point(106, 80)
        Me.TrackBar2.Maximum = 1000
        Me.TrackBar2.Name = "TrackBar2"
        Me.TrackBar2.Size = New System.Drawing.Size(265, 56)
        Me.TrackBar2.TabIndex = 24
        '
        'TrackBar1
        '
        Me.TrackBar1.Location = New System.Drawing.Point(106, 27)
        Me.TrackBar1.Maximum = 1000
        Me.TrackBar1.Name = "TrackBar1"
        Me.TrackBar1.Size = New System.Drawing.Size(274, 56)
        Me.TrackBar1.TabIndex = 22
        '
        'Button18
        '
        Me.Button18.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Button18.ForeColor = System.Drawing.Color.Maroon
        Me.Button18.Location = New System.Drawing.Point(8, 211)
        Me.Button18.Name = "Button18"
        Me.Button18.Size = New System.Drawing.Size(117, 59)
        Me.Button18.TabIndex = 41
        Me.Button18.Text = "Локальная СК"
        Me.Button18.UseVisualStyleBackColor = True
        '
        'ViborKontura
        '
        Me.ViborKontura.BackColor = System.Drawing.Color.LightGray
        Me.ViborKontura.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.ViborKontura.ForeColor = System.Drawing.Color.Maroon
        Me.ViborKontura.Location = New System.Drawing.Point(382, 310)
        Me.ViborKontura.Name = "ViborKontura"
        Me.ViborKontura.Size = New System.Drawing.Size(154, 64)
        Me.ViborKontura.TabIndex = 0
        Me.ViborKontura.Text = "Выбор контура"
        Me.ViborKontura.UseVisualStyleBackColor = False
        '
        'CheckBox5
        '
        Me.CheckBox5.AutoSize = True
        Me.CheckBox5.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.CheckBox5.ForeColor = System.Drawing.Color.Maroon
        Me.CheckBox5.Location = New System.Drawing.Point(833, 114)
        Me.CheckBox5.Name = "CheckBox5"
        Me.CheckBox5.Size = New System.Drawing.Size(88, 55)
        Me.CheckBox5.TabIndex = 40
        Me.CheckBox5.Text = "Менять " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "местами" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "тчк. дуги"
        Me.CheckBox5.UseVisualStyleBackColor = True
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.RadioButton23)
        Me.GroupBox6.Controls.Add(Me.RadioButton22)
        Me.GroupBox6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.GroupBox6.ForeColor = System.Drawing.Color.Maroon
        Me.GroupBox6.Location = New System.Drawing.Point(8, 125)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(149, 82)
        Me.GroupBox6.TabIndex = 37
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "Режим выбора"
        '
        'RadioButton23
        '
        Me.RadioButton23.AutoSize = True
        Me.RadioButton23.Location = New System.Drawing.Point(6, 48)
        Me.RadioButton23.Name = "RadioButton23"
        Me.RadioButton23.Size = New System.Drawing.Size(100, 22)
        Me.RadioButton23.TabIndex = 1
        Me.RadioButton23.TabStop = True
        Me.RadioButton23.Text = "По эскизу"
        Me.RadioButton23.UseVisualStyleBackColor = True
        '
        'RadioButton22
        '
        Me.RadioButton22.AutoSize = True
        Me.RadioButton22.Location = New System.Drawing.Point(6, 23)
        Me.RadioButton22.Name = "RadioButton22"
        Me.RadioButton22.Size = New System.Drawing.Size(110, 22)
        Me.RadioButton22.TabIndex = 0
        Me.RadioButton22.TabStop = True
        Me.RadioButton22.Text = "По чертежу"
        Me.RadioButton22.UseVisualStyleBackColor = True
        '
        'Button14
        '
        Me.Button14.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Button14.ForeColor = System.Drawing.Color.Maroon
        Me.Button14.Location = New System.Drawing.Point(833, 52)
        Me.Button14.Name = "Button14"
        Me.Button14.Size = New System.Drawing.Size(113, 54)
        Me.Button14.TabIndex = 34
        Me.Button14.Text = "Изменить"
        Me.Button14.UseVisualStyleBackColor = True
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.RadioButton17)
        Me.GroupBox4.Controls.Add(Me.RadioButton16)
        Me.GroupBox4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.GroupBox4.ForeColor = System.Drawing.Color.Maroon
        Me.GroupBox4.Location = New System.Drawing.Point(8, 36)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(185, 83)
        Me.GroupBox4.TabIndex = 25
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Форма заготовки"
        '
        'RadioButton17
        '
        Me.RadioButton17.AutoSize = True
        Me.RadioButton17.Location = New System.Drawing.Point(6, 52)
        Me.RadioButton17.Name = "RadioButton17"
        Me.RadioButton17.Size = New System.Drawing.Size(90, 22)
        Me.RadioButton17.TabIndex = 1
        Me.RadioButton17.TabStop = True
        Me.RadioButton17.Text = "Цилиндр"
        Me.RadioButton17.UseVisualStyleBackColor = True
        '
        'RadioButton16
        '
        Me.RadioButton16.AutoSize = True
        Me.RadioButton16.Location = New System.Drawing.Point(7, 26)
        Me.RadioButton16.Name = "RadioButton16"
        Me.RadioButton16.Size = New System.Drawing.Size(83, 22)
        Me.RadioButton16.TabIndex = 0
        Me.RadioButton16.TabStop = True
        Me.RadioButton16.Text = "Призма"
        Me.RadioButton16.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Maroon
        Me.Label6.Location = New System.Drawing.Point(117, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(216, 20)
        Me.Label6.TabIndex = 24
        Me.Label6.Text = "Параметры заготовки"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Maroon
        Me.Label1.Location = New System.Drawing.Point(659, 3)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(245, 20)
        Me.Label1.TabIndex = 23
        Me.Label1.Text = "Редактирование контура"
        '
        'ListBox3
        '
        Me.ListBox3.FormattingEnabled = True
        Me.ListBox3.ItemHeight = 16
        Me.ListBox3.Location = New System.Drawing.Point(575, 28)
        Me.ListBox3.Name = "ListBox3"
        Me.ListBox3.Size = New System.Drawing.Size(232, 196)
        Me.ListBox3.TabIndex = 33
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(8, 276)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(91, 91)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 8
        Me.PictureBox2.TabStop = False
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(249, 278)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(79, 22)
        Me.TextBox1.TabIndex = 9
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(249, 310)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(79, 22)
        Me.TextBox2.TabIndex = 10
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(249, 347)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(79, 22)
        Me.TextBox3.TabIndex = 11
        Me.TextBox3.Text = "25"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.RadioButton4)
        Me.GroupBox1.Controls.Add(Me.RadioButton13)
        Me.GroupBox1.Controls.Add(Me.RadioButton19)
        Me.GroupBox1.Controls.Add(Me.RadioButton12)
        Me.GroupBox1.Controls.Add(Me.RadioButton11)
        Me.GroupBox1.Controls.Add(Me.RadioButton10)
        Me.GroupBox1.Controls.Add(Me.RadioButton3)
        Me.GroupBox1.Controls.Add(Me.RadioButton2)
        Me.GroupBox1.Controls.Add(Me.RadioButton1)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.Maroon
        Me.GroupBox1.Location = New System.Drawing.Point(376, 28)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(169, 272)
        Me.GroupBox1.TabIndex = 16
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Выбор контуров"
        '
        'RadioButton13
        '
        Me.RadioButton13.AutoSize = True
        Me.RadioButton13.Location = New System.Drawing.Point(6, 207)
        Me.RadioButton13.Name = "RadioButton13"
        Me.RadioButton13.Size = New System.Drawing.Size(80, 22)
        Me.RadioButton13.TabIndex = 8
        Me.RadioButton13.TabStop = True
        Me.RadioButton13.Text = "Резьба"
        Me.RadioButton13.UseVisualStyleBackColor = True
        '
        'RadioButton19
        '
        Me.RadioButton19.AutoSize = True
        Me.RadioButton19.Location = New System.Drawing.Point(6, 20)
        Me.RadioButton19.Name = "RadioButton19"
        Me.RadioButton19.Size = New System.Drawing.Size(106, 22)
        Me.RadioButton19.TabIndex = 7
        Me.RadioButton19.TabStop = True
        Me.RadioButton19.Text = "Плоскость"
        Me.RadioButton19.UseVisualStyleBackColor = True
        '
        'RadioButton12
        '
        Me.RadioButton12.AutoSize = True
        Me.RadioButton12.Location = New System.Drawing.Point(6, 151)
        Me.RadioButton12.Name = "RadioButton12"
        Me.RadioButton12.Size = New System.Drawing.Size(98, 22)
        Me.RadioButton12.TabIndex = 5
        Me.RadioButton12.TabStop = True
        Me.RadioButton12.Text = "Островок"
        Me.RadioButton12.UseVisualStyleBackColor = True
        '
        'RadioButton11
        '
        Me.RadioButton11.AutoSize = True
        Me.RadioButton11.Location = New System.Drawing.Point(6, 123)
        Me.RadioButton11.Name = "RadioButton11"
        Me.RadioButton11.Size = New System.Drawing.Size(69, 22)
        Me.RadioButton11.TabIndex = 4
        Me.RadioButton11.TabStop = True
        Me.RadioButton11.Text = "Уступ"
        Me.RadioButton11.UseVisualStyleBackColor = True
        '
        'RadioButton10
        '
        Me.RadioButton10.AutoSize = True
        Me.RadioButton10.Location = New System.Drawing.Point(6, 179)
        Me.RadioButton10.Name = "RadioButton10"
        Me.RadioButton10.Size = New System.Drawing.Size(103, 22)
        Me.RadioButton10.TabIndex = 3
        Me.RadioButton10.TabStop = True
        Me.RadioButton10.Text = "Отверстие"
        Me.RadioButton10.UseVisualStyleBackColor = True
        '
        'RadioButton3
        '
        Me.RadioButton3.AutoSize = True
        Me.RadioButton3.Location = New System.Drawing.Point(6, 95)
        Me.RadioButton3.Name = "RadioButton3"
        Me.RadioButton3.Size = New System.Drawing.Size(56, 22)
        Me.RadioButton3.TabIndex = 2
        Me.RadioButton3.TabStop = True
        Me.RadioButton3.Text = "Паз"
        Me.RadioButton3.UseVisualStyleBackColor = True
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Location = New System.Drawing.Point(6, 69)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(82, 22)
        Me.RadioButton2.TabIndex = 1
        Me.RadioButton2.TabStop = True
        Me.RadioButton2.Text = "Карман"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Location = New System.Drawing.Point(6, 43)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(141, 22)
        Me.RadioButton1.TabIndex = 0
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "Внешний контур"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Maroon
        Me.Label2.Location = New System.Drawing.Point(115, 279)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(101, 18)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "Длина, мм Х:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Maroon
        Me.Label3.Location = New System.Drawing.Point(115, 314)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(108, 18)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "Ширина, мм Y:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Maroon
        Me.Label4.Location = New System.Drawing.Point(115, 348)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(108, 18)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = "Высота, мм Z:"
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Controls.Add(Me.TabPage4)
        Me.TabControl1.Location = New System.Drawing.Point(0, 31)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1003, 411)
        Me.TabControl1.TabIndex = 22
        '
        'RadioButton4
        '
        Me.RadioButton4.AutoSize = True
        Me.RadioButton4.Location = New System.Drawing.Point(6, 235)
        Me.RadioButton4.Name = "RadioButton4"
        Me.RadioButton4.Size = New System.Drawing.Size(135, 22)
        Me.RadioButton4.TabIndex = 9
        Me.RadioButton4.TabStop = True
        Me.RadioButton4.Text = "Паз (трохоида)"
        Me.RadioButton4.UseVisualStyleBackColor = True
        '
        'Button15
        '
        Me.Button15.Enabled = False
        Me.Button15.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Button15.ForeColor = System.Drawing.Color.Maroon
        Me.Button15.Location = New System.Drawing.Point(833, 170)
        Me.Button15.Name = "Button15"
        Me.Button15.Size = New System.Drawing.Size(113, 54)
        Me.Button15.TabIndex = 44
        Me.Button15.Text = "Параметры трохоиды" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.Button15.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkGray
        Me.ClientSize = New System.Drawing.Size(1006, 967)
        Me.Controls.Add(Me.Label24)
        Me.Controls.Add(Me.ListBox5)
        Me.Controls.Add(Me.DataGridView2)
        Me.Controls.Add(Me.Button13)
        Me.Controls.Add(Me.Button11)
        Me.Controls.Add(Me.Button7)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Ochistka)
        Me.Controls.Add(Me.Button1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Text = "MT2CAM"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage4.ResumeLayout(False)
        Me.TabPage4.PerformLayout()
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage3.PerformLayout()
        Me.GroupBox8.ResumeLayout(False)
        Me.GroupBox8.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.RasstanofkaInsrtGrBox.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ParamInsrtGrBox.ResumeLayout(False)
        Me.ParamInsrtGrBox.PerformLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.GroupBox7.ResumeLayout(False)
        Me.GroupBox7.PerformLayout()
        CType(Me.TrackBar2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TrackBar1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ФайлToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents НовыйToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ВставитьВидыС3DМоделиToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents ПовернутьГлавныйВидToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ПовернутьГлавныйВидНалевоToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ВставитьПроекционныеВидыToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ВставитьГлавныйВидToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ОчиститьПолеЧертежаToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Button1 As Button
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Ochistka As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents УвеличитьМасштабЧертежаToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents УменьшитьМасштабЧертежаToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ДействияСФайломToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Button7 As Button
    Friend WithEvents Button11 As Button
    Friend WithEvents Button13 As Button
    Friend WithEvents DataGridView2 As DataGridView
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents ЭкспортВGcodeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ListBox5 As ListBox
    Friend WithEvents Label24 As Label
    Friend WithEvents TabPage4 As TabPage
    Friend WithEvents TextBoxYASK As TextBox
    Friend WithEvents TextBoxsek As TextBox
    Friend WithEvents TextBoxXASK As TextBox
    Friend WithEvents TextBoxmin As TextBox
    Friend WithEvents TextBox11 As TextBox
    Friend WithEvents TextBox10 As TextBox
    Friend WithEvents Label34 As Label
    Friend WithEvents Label33 As Label
    Friend WithEvents Label41 As Label
    Friend WithEvents Label40 As Label
    Friend WithEvents Label32 As Label
    Friend WithEvents ListBox4 As ListBox
    Friend WithEvents CheckBox4 As CheckBox
    Friend WithEvents Button12 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Label22 As Label
    Friend WithEvents Label21 As Label
    Friend WithEvents Button10 As Button
    Friend WithEvents Button9 As Button
    Friend WithEvents ListBox2 As ListBox
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents Button19 As Button
    Friend WithEvents GroupBox8 As GroupBox
    Friend WithEvents TextBoxSrez As TextBox
    Friend WithEvents TextBoxVrez As TextBox
    Friend WithEvents Label29 As Label
    Friend WithEvents Label28 As Label
    Friend WithEvents RadioButton18 As RadioButton
    Friend WithEvents RadioButton26 As RadioButton
    Friend WithEvents Label27 As Label
    Friend WithEvents Label26 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label25 As Label
    Friend WithEvents Button17 As Button
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents RadioButton21 As RadioButton
    Friend WithEvents RadioButton20 As RadioButton
    Friend WithEvents TextBoxkolvopr As TextBox
    Friend WithEvents TextBoxmaxZ As TextBox
    Friend WithEvents TextBoxviskon As TextBox
    Friend WithEvents TextBoxdeltaniz As TextBox
    Friend WithEvents TextBoxdletaverh As TextBox
    Friend WithEvents TextBoxnpl As TextBox
    Friend WithEvents TextBoxvpl As TextBox
    Friend WithEvents TextBoxplbez As TextBox
    Friend WithEvents TextBoxperfrez As TextBox
    Friend WithEvents TextBoxbzrast As TextBox
    Friend WithEvents TextBoxobchist As TextBox
    Friend WithEvents TextBoxpodchist As TextBox
    Friend WithEvents TextBoxobchern As TextBox
    Friend WithEvents TextBoxpdchvert As TextBox
    Friend WithEvents TextBoxprip As TextBox
    Friend WithEvents Label23 As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents RadioButtonalum As RadioButton
    Friend WithEvents RadioButtonstil As RadioButton
    Friend WithEvents Label19 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents CheckBoxviborka As CheckBox
    Friend WithEvents Label15 As Label
    Friend WithEvents CheckBoxchist As CheckBox
    Friend WithEvents CheckBoxchern As CheckBox
    Friend WithEvents Label13 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents RasstanofkaInsrtGrBox As GroupBox
    Friend WithEvents Button8 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Button4 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents ParamInsrtGrBox As GroupBox
    Friend WithEvents TextBoxLrch As TextBox
    Friend WithEvents TextBoxLvil As TextBox
    Friend WithEvents TextBoxDsv As TextBox
    Friend WithEvents TextBoxDzdva As TextBox
    Friend WithEvents TextBoxDzone As TextBox
    Friend WithEvents TextBoxDtf As TextBox
    Friend WithEvents TextBoxDkf As TextBox
    Friend WithEvents LabelLrch As Label
    Friend WithEvents LabelLvil As Label
    Friend WithEvents Labeldcv As Label
    Friend WithEvents Labeldzdva As Label
    Friend WithEvents Labeldzone As Label
    Friend WithEvents Labeldtf As Label
    Friend WithEvents Labeldtk As Label
    Friend WithEvents Button5 As Button
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents GroupBox7 As GroupBox
    Friend WithEvents Label31 As Label
    Friend WithEvents Label30 As Label
    Friend WithEvents TrackBar2 As TrackBar
    Friend WithEvents TrackBar1 As TrackBar
    Friend WithEvents Button18 As Button
    Friend WithEvents ViborKontura As Button
    Friend WithEvents CheckBox5 As CheckBox
    Friend WithEvents GroupBox6 As GroupBox
    Friend WithEvents RadioButton23 As RadioButton
    Friend WithEvents RadioButton22 As RadioButton
    Friend WithEvents Button14 As Button
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents RadioButton17 As RadioButton
    Friend WithEvents RadioButton16 As RadioButton
    Friend WithEvents Label6 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents ListBox3 As ListBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents RadioButton13 As RadioButton
    Friend WithEvents RadioButton19 As RadioButton
    Friend WithEvents RadioButton12 As RadioButton
    Friend WithEvents RadioButton11 As RadioButton
    Friend WithEvents RadioButton10 As RadioButton
    Friend WithEvents RadioButton3 As RadioButton
    Friend WithEvents RadioButton2 As RadioButton
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents CheckBoxpoyasn As CheckBox
    Friend WithEvents TextBoxmaxY As TextBox
    Friend WithEvents TextBoxmaxX As TextBox
    Friend WithEvents Label35 As Label
    Friend WithEvents Label36 As Label
    Friend WithEvents ОткрытьПроектToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RadioButton4 As RadioButton
    Friend WithEvents Button15 As Button
End Class
