Imports System
Imports System.Type
Imports System.ApplicationId
Imports System.Activator
Imports System.Runtime.InteropServices
Imports Inventor
Imports System.Math
Imports System.Drawing
Imports System.IO
Public Class Form1
    Public scale1, scalesdvg As Single
    Public rectangle1 As Rectangle
    Private Sub TrackBar1_Scroll(sender As Object, e As EventArgs) Handles TrackBar1.Scroll
        PictureBox1.Image = Nothing
        Form4.PictureBox1.Image = Nothing
        Dim maxscale As Single = 5000
        Dim minscale As Single = 1
        scale1 = Math.Pow(maxscale / 1000, TrackBar1.Value / (TrackBar1.Maximum))
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        'ListBox3.Items.Clear()

        Try
            PictureBox1.Image = Nothing
            PictureBox1.Refresh()
            'Kontour = PictureBox1.CreateGraphics
            lloc = l
            For l = 0 To crcell
                'kolvo = kolvoobsh(l)
                'Call otrisovka_vsego_mod()
                j = 0
                Call otrisovka_vsego_mod_2()
                j = 0
                Call Ris_siscoord()
                j = 0
                Call otrisovka_zagotovki()
                j = 0
            Next
            l = lloc
            If TextBoxperfrez.Text = Nothing Then
                MsgBox("Заполните необходимые поля")
                TextBoxperfrez.BackColor = Drawing.Color.Yellow
                Return
            End If
            TextBoxperfrez.BackColor = Drawing.Color.White
            per = TextBoxperfrez.Text * 0.02

            If CheckBoxviborka.Checked = True And RadioButton20.Checked = True Then
                Try
                    kpobsh(DataGridView2.CurrentCell.RowIndex) = Convert.ToInt32(TextBoxkolvopr.Text)
                    TextBoxkolvopr.BackColor = Drawing.Color.White
                Catch ex As Exception
                    TextBoxkolvopr.BackColor = Drawing.Color.Yellow
                    Me.ListBox5.Items.Add("Введите количество проходов")
                    p = p + 1
                End Try
            ElseIf CheckBoxviborka.Checked = True And RadioButton21.Checked = True Then
                Try
                    kpobsh(DataGridView2.CurrentCell.RowIndex) = Convert.ToInt32(TextBoxkolvopr.Text)
                    TextBoxkolvopr.BackColor = Drawing.Color.White
                Catch ex As Exception
                    TextBoxkolvopr.BackColor = Drawing.Color.Yellow
                    Me.ListBox5.Items.Add("Введите количество проходов")
                    p = p + 1
                End Try
            Else
                kpobsh(DataGridView2.CurrentCell.RowIndex) = 1
            End If
            TextBox1.BackColor = Drawing.Color.White


            kp = kpobsh(DataGridView2.CurrentCell.RowIndex)
            prip = Convert.ToSingle(Me.TextBoxprip.Text)
            If crcell = 0 Then
                ReDim XobshrisN(50, 40, 15)
                ReDim YobshrisN(50, 40, 15)
                ReDim XobshrisK(50, 40, 15)
                ReDim YobshrisK(50, 40, 15)
                ReDim Robshris(50, 40, 15)
                ReDim pervoeprevishenie(50, 40, 15)
                ReDim XdcncN(50, 40)
                ReDim XdcncK(50, 40)
                ReDim YdcncNris(50, 40)
                ReDim YdcncKris(50, 40)
                ReDim temp(50, 40)
                'контакт отрезков
                ReDim XtchkontN1(50)
                ReDim YtchkontN1(50)
                ReDim XtchkontK1(50)
                ReDim YtchkontK1(50)
                ReDim XtchkontK2(50)
                ReDim YtchkontK2(50)
                ReDim Xtchkonttr(50, 40)
                ReDim Ytchkonttr(50, 40)
                ReDim gamma(50)
                ReDim delta(50)
                ReDim tau(50)

                ReDim GcodeXN(50, 40, 15)
                ReDim GcodeXK(50, 40, 15)
                ReDim GcodeYN(50, 40, 15)
                ReDim GcodeYK(50, 40, 15)
                ReDim GcodeR(50, 40, 15)
            End If
            'Call Proverka_na_peresech_traektoriy()
            crcell = DataGridView2.CurrentCell.RowIndex

            lloc = l
            l = crcell
            kp = kpobsh(l)
            'kolvo = kolvoobsh(l)
            k = 0
            i = 0
            Call rachet_traectorii_mod_3()
            k = 0
            Call New_ris_traect()
            k = 0
            Call vhod_frezi()
            k = 0

            Instr(l) = Convert.ToString(ListBox1.SelectedItem)
            Dinst(l) = Dfrez(ni)
            l = lloc


        Catch ex1 As Exception
            Me.ListBox5.Items.Add(ex1.Message)
            p = p + 1
            Dim stacktr As New StackTrace(ex1, True)
            If stacktr.FrameCount > 0 Then
                Dim stackfr As New StackFrame
                stackfr = stacktr.GetFrame(0)
                Dim errorline As Integer = stackfr.GetFileLineNumber()
                Dim functionname As String = stackfr.GetMethod().Name
                Me.ListBox5.Items.Add("Ошибка в " & functionname & " на линии" & errorline)
                p = p + 1
                Me.ListBox5.Items.Add(ex1.Message)
                p = p + 1
            End If
        End Try

    End Sub
    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        DataGridView1.CurrentCell.Value = "-"
        nomercudastavitinst = DataGridView1.CurrentCell.RowIndex
        ni = 0

        For i = 0 To 19
            If Convert.ToString(DataGridView1.Rows(i).Cells(1).Value) <> "-" Then
                ni = ni + 1
                'MsgBox(Instr(l) & "  D=" & Dinst(l) & "  T=" & Tinst(l))
            End If
        Next

        'l = 0
        i = 0
    End Sub


    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick

    End Sub


    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

        Try
            Dim NumItems As Integer
            Dim i As Integer
            Dim ItemNum As Integer
            Dim TempItem As String
            Dim TempList()

            If DataGridView1.CurrentCell.RowIndex = 0 Then Exit Sub

            NumItems = 20
            ReDim TempList(19)

            '   Заполнение массива элементами списка
            For i = 0 To 19
                TempList(i) = DataGridView1.Rows(i).Cells(1).Value
            Next i
            i = 0

            ItemNum = DataGridView1.CurrentCell.RowIndex

            TempItem = TempList(ItemNum)
            TempList(ItemNum) = TempList(ItemNum - 1)
            TempList(ItemNum - 1) = TempItem

            DataGridView1.Rows(ItemNum).Cells(1).Value = TempList(ItemNum)
            DataGridView1.Rows(ItemNum - 1).Cells(1).Value = TempList(ItemNum - 1)
            DataGridView1.ClearSelection()

            DataGridView1.CurrentCell.Selected = False
            DataGridView1_CellClick(DataGridView1, New DataGridViewCellEventArgs(1, ItemNum - 1))
            DataGridView1.Rows(ItemNum - 1).Cells(1).Selected = True
            DataGridView1.Focus()
            SendKeys.Send("{UP}")

        Catch ex As Exception
            Me.ListBox5.Items.Add(p & "  " & "не выбран инструмент")
            p = p + 1
        End Try
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click

        Try
            Dim NumItems As Integer
            Dim i As Integer
            Dim ItemNum As Integer
            Dim TempItem As String
            Dim TempList()

            If DataGridView1.CurrentCell.RowIndex = 19 Then Exit Sub

            NumItems = 20
            ReDim TempList(19)

            '   Заполнение массива элементами списка
            For i = 0 To 19
                TempList(i) = DataGridView1.Rows(i).Cells(1).Value
            Next i
            i = 0

            '   Выделенные элементы
            ItemNum = DataGridView1.CurrentCell.RowIndex

            '   Обмен элементами
            TempItem = TempList(ItemNum)
            TempList(ItemNum) = TempList(ItemNum + 1)
            TempList(ItemNum + 1) = TempItem

            DataGridView1.Rows(ItemNum).Cells(1).Value = TempList(ItemNum)
            DataGridView1.Rows(ItemNum + 1).Cells(1).Value = TempList(ItemNum + 1)

            '   Изменение индекса элемента

            'DataGridView1_CellContentClick(DataGridView1, New DataGridViewCellEventArgs(1, ItemNum + 1))

            'DataGridView1.InvalidateRow(ItemNum)
            DataGridView1.CurrentCell.Selected = False
            DataGridView1_CellClick(DataGridView1, New DataGridViewCellEventArgs(1, ItemNum + 1))
            DataGridView1.Rows(ItemNum + 1).Cells(1).Selected = True

            DataGridView1.Focus()
            SendKeys.Send("{DOWN}")

        Catch ex As Exception
            Me.ListBox5.Items.Add(p & "  " & "не выбран инструмент")
            p = p + 1
        End Try
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click

        DataGridView1.Rows(nomercudastavitinst).Cells(1).Value = ListBox1.SelectedItem
        nomercudastavitinst = nomercudastavitinst + 1
        ni = ni + 1

    End Sub


    Private Sub УвеличитьМасштабЧертежаToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles УвеличитьМасштабЧертежаToolStripMenuItem.Click
        Try

            oView1.ScaleString = 2

        Catch ex As Exception
            Me.ListBox5.Items.Add(p & "  " & "Не найден базовый вид")
            p = p + 1
            Return
        End Try
    End Sub




    Private Sub Ochistka_Click(sender As Object, e As EventArgs) Handles Ochistka.Click
        'Form4.Show()
        PictureBox1.Image = Nothing
    End Sub



    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Try
            If TextBox1.Text = Nothing And TextBox2.Text = Nothing Then
                MsgBox("Введите габариты заготовки")
                TextBox1.BackColor = Drawing.Color.Yellow
                TextBox2.BackColor = Drawing.Color.Yellow
                Return
            End If
            TextBox1.BackColor = Drawing.Color.White
            TextBox2.BackColor = Drawing.Color.White
            crcell = DataGridView2.CurrentCell.RowIndex
            If kolvoclikov = 1 Then
                If AutoSK(crcell) = True Then
                    xprip = (Single.Parse(TextBox1.Text) - Xmaxloc(0) + Xminloc(0)) / 2
                    yprip = (Single.Parse(TextBox2.Text) - Ymaxloc(0) + Yminloc(0)) / 2
                Else
                    xprip = (Single.Parse(TextBox1.Text) - Single.Parse(TextBoxmaxX.Text)) / 2
                    yprip = (Single.Parse(TextBox2.Text) - Single.Parse(TextBoxmaxY.Text)) / 2
                    xprip2 = Xcoord + Single.Parse(TextBox1.Text) - Xmaxloc(0)
                    yprip2 = Yminloc(0) - Ycoord + Single.Parse(TextBox2.Text)
                End If
            End If
            '  Sdvg = 15 * Math.Pow(1.5, TrackBar1.Value / (TrackBar1.Maximum)) + Sqrt(xprip ^ 2 + yprip ^ 2)
            Sdvg = 10 * scalesdvg + Sqrt(xprip ^ 2 + yprip ^ 2)
            Kontour = PictureBox1.CreateGraphics
            Kontour.ScaleTransform(1, 1)
            j = 0
            pen1 = New Pen(Brushes.Black, 0.5)
            pen2 = New Pen(Brushes.Red, 1)
            pen3 = New Pen(Brushes.Green, 1)
            pen4 = New Pen(Brushes.Red, 0.5)
            pen4.DashStyle = Drawing2D.DashStyle.Solid
            pen5 = New Pen(Brushes.Blue, 0.5)
            crcell = DataGridView2.CurrentCell.RowIndex
            lloc = l
            For l = 0 To crcell
                j = 0
                j = 0
                Call otrisovka_vsego_mod_2()
                    j = 0
                Call Ris_siscoord()
                j = 0
                minus = -1
                Call otrisovka_zagotovki()
                j = 0
            Next
            l = lloc
        Catch ex As Exception
            Dim stacktr As New StackTrace(ex, True)
            If stacktr.FrameCount > 0 Then
                Dim stackfr As New StackFrame
                stackfr = stacktr.GetFrame(0)
                Dim errorline As Integer = stackfr.GetFileLineNumber()
                Dim functionname As String = stackfr.GetMethod().Name
                Me.ListBox5.Items.Add("Ошибка в " & functionname & " на линии" & errorline)
                p = p + 1
                Me.ListBox5.Items.Add(ex.Message)
                p = p + 1
            End If
        End Try

    End Sub

    Sub New()

        InitializeComponent()
        'ReDim kolvoobsh(14)
        ReDim dugaprejnya(50, 15)
        For i = 0 To 49
            For l = 0 To 14
                dugaprejnya(i, l) = True

            Next
        Next
        For i = 0 To 14
            AutoSK(i) = True
            ch_podvod(i) = False
            ch_viborka(i) = False
            ch_auto(i) = True
            ch_vkl(i) = True
        Next
        i = 0
        l = 0

        'ni = 0

        k = 0
        j = 0
        i = 0
        l = 0
        scale1 = 1.0
        ni = 0
        m = 0
        TextBox1.Text = "100"
        TextBox2.Text = "100"
        'TextBox3.Text = "20"
        TextBoxprip.Text = "0,2"
        Nmax = 7000
        TextBoxperfrez.Text = "40"
        TextBox10.Text = "D:\12 semestr\ramka_v_МТ2САМ\Gcodes"

        TextBoxDkf.Text = 0
        TextBoxDtf.Text = 0
        Form2.TextBoxXvhod.Text = 0
        Form2.TextBoxYvhod.Text = 0
        ' TextBox12.Text = "10"
        'TextBox12.Enabled = False
        Dim brush1 As New SolidBrush(System.Drawing.Color.Red)
        Dim brush2 As New SolidBrush(System.Drawing.Color.Green)
        Dim brush3 As New SolidBrush(System.Drawing.Color.Blue)
        Dim brush4 As New SolidBrush(System.Drawing.Color.Pink)
        Dim brush5 As New SolidBrush(System.Drawing.Color.Aqua)
        ListBox1.SelectedIndex = 4
        'ListBox1.SetSelected(ListBox1.SelectedIndex, True)
        CheckBoxchern.Checked = True
        RadioButton4.Checked = True
        RadioButton26.Checked = True

        'RadioButton4.Checked = True
        RadioButtonalum.Checked = True
        RadioButton16.Checked = True
        RadioButton20.Checked = True
        RadioButton22.Checked = True
        RadioButton20.Enabled = False
        RadioButton21.Enabled = False
        TextBoxkolvopr.Enabled = False
        ListBox1.SetSelected(ListBox1.SelectedIndex, True)

        nomercudastavitinst = 0
        kolvoclikov = 0

        nadocheck = True
        DataGridView1.Rows.Add(20)
        'Dim Tmagazin As New List(Of Integer)() From {1, 2, 3, 4, 5, 6, 7}
        For i = 1 To 19

            DataGridView1.Rows(i - 1).Cells(0).Value = i
            DataGridView1.Rows(i - 1).Cells(1).Value = "-"
            Instr(i) = "_"
        Next i
        i = 0
        DataGridView2.Rows.Add(14)
        vr_dannie(10, crcell) = 1
        markerX = 1
        markerY = 1
    End Sub



    Private Sub ПовернутьГлавныйВидНалевоToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ПовернутьГлавныйВидНалевоToolStripMenuItem.Click

        Try
            If clck = 1 Then
                oView1.Rotation = -Atan(1) * 2
                clck = 2
            ElseIf clck = 2 Then
                oView1.Rotation = -Atan(1) * 4
                clck = 3
            ElseIf clck = 3 Then
                oView1.Rotation = -Atan(1) * 6
                clck = 1
            End If
        Catch ex As Exception
            Me.ListBox5.Items.Add(p & "  " & "Не найден базовый вид")
            p = p + 1
            Return
        End Try
    End Sub

    Private Sub ОчиститьПолеЧертежаToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ОчиститьПолеЧертежаToolStripMenuItem.Click
        Try
            oView1.Delete()

        Catch ex As Exception
            Me.ListBox5.Items.Add(p & "  " & "нет главного вида")
            p = p + 1
        End Try
        Try
            oView1.Delete()
            oView2.Delete()
            oView3.Delete()
            oView4.Delete()
            oView5.Delete()
        Catch ex As Exception
            Me.ListBox5.Items.Add(p & "  " & "нечего удалять")
            p = p + 1
        End Try
    End Sub

    Private Sub ВставитьГлавныйВидToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ВставитьГлавныйВидToolStripMenuItem.Click
        Try
            _invApp = Marshal.GetActiveObject("Inventor.Application")
            If _invApp.Documents.Count = 0 Then
                MsgBox("Надо открыть документ чертежа")
                Return
            End If
            If _invApp.ActiveDocument.DocumentType <> DocumentTypeEnum.kDrawingDocumentObject Then
                MsgBox("Требуется открыть чертеж")
                Return
            End If
            Dim oPartDoc As PartDocument
            Doc1 = _invApp.ActiveDocument
            Sheet1 = Doc1.Sheets.Item(1)
            oPoint1 = _invApp.TransientGeometry.CreatePoint2d(20.0, 16.0)
            oPoint2 = _invApp.TransientGeometry.CreatePoint2d(20.0, 25.0)
            oPoint3 = _invApp.TransientGeometry.CreatePoint2d(20.0, 7.0)
            oPoint6 = _invApp.TransientGeometry.CreatePoint2d(20.0, 2.0)
            oPoint4 = _invApp.TransientGeometry.CreatePoint2d(10.0, 16.0)
            oPoint5 = _invApp.TransientGeometry.CreatePoint2d(30.0, 16.0)
            ' OpenFileDialog1.InitialDirectory = "D:\СAM\MT2CAM"А
            OpenFileDialog1.Title = "Пожалуйста, выберите файл модели"
            If OpenFileDialog1.ShowDialog() = DialogResult.OK Then
                fileinv = OpenFileDialog1.FileName
                oPartDoc = _invApp.Documents.Open(fileinv, False)
                oView1 = Sheet1.DrawingViews.AddBaseView(oPartDoc, oPoint1, 1, ViewOrientationTypeEnum.kTopViewOrientation, DrawingViewStyleEnum.kHiddenLineRemovedDrawingViewStyle, )
                Call oPartDoc.Close(True)
            End If
        Catch ex As Exception
            Me.ListBox5.Items.Add(p & "  " & ex.Message)
            p = p + 1
        End Try
    End Sub
    'Dim Xris(), XrisK() As Integer 'Х относительно новой СК
    Private Sub ПовернутьГлавныйВидToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ПовернутьГлавныйВидToolStripMenuItem.Click

        Try
            If clck = 1 Then
                oView1.Rotation = Atan(1) * 2
                clck = 2
            ElseIf clck = 2 Then
                oView1.Rotation = Atan(1) * 4
                clck = 3
            ElseIf clck = 3 Then
                oView1.Rotation = Atan(1) * 6
                clck = 1
            End If
        Catch ex As Exception
            Me.ListBox5.Items.Add(p & "  " & "Не найден базовый вид")
            p = p + 1
            Return
        End Try
    End Sub
    Private Sub ВставитьПроекционныеВидыToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ВставитьПроекционныеВидыToolStripMenuItem.Click
        Try
            oView2 = Sheet1.DrawingViews.AddProjectedView(oView1, oPoint2, DrawingViewStyleEnum.kHiddenLineRemovedDrawingViewStyle)
            oView3 = Sheet1.DrawingViews.AddProjectedView(oView1, oPoint3, DrawingViewStyleEnum.kHiddenLineRemovedDrawingViewStyle)
            oView4 = Sheet1.DrawingViews.AddProjectedView(oView1, oPoint4, DrawingViewStyleEnum.kHiddenLineRemovedDrawingViewStyle)
            oView5 = Sheet1.DrawingViews.AddProjectedView(oView1, oPoint5, DrawingViewStyleEnum.kHiddenLineRemovedDrawingViewStyle)
            oView6 = Sheet1.DrawingViews.AddProjectedView(oView3, oPoint6, DrawingViewStyleEnum.kHiddenLineRemovedDrawingViewStyle)
        Catch ex As Exception
            Me.ListBox5.Items.Add(p & "  " & "Не найден базовый вид")
            p = p + 1
            Return
        End Try
    End Sub

    Dim YrisN(), YrisK() As Integer 'У относительно новой СК

    Private Sub НовыйToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles НовыйToolStripMenuItem.Click
        InitializeComponent()
        Try
            _invApp = Marshal.GetActiveObject("Inventor.Application")
        Catch ex As Exception
            Try
                Dim invAppType As Type =
                GetTypeFromProgID("Inventor.Application")

                _invApp = CreateInstance(invAppType)
                _invApp.Visible = True

            Catch ex2 As Exception
                Me.ListBox5.Items.Add(p & "  " & ex2.ToString())
                p = p + 1
                Me.ListBox5.Items.Add(p & "  " & "Не удалось ни найти, ни создать сеанс Inventor")
                p = p + 1
            End Try
        End Try
    End Sub

    Private Sub ViborKontura_Click(sender As Object, e As EventArgs) Handles ViborKontura.Click
        crcell = DataGridView2.CurrentCell.RowIndex
        ListBox3.Items.Clear()
        If kolvoclikov = 0 Then
            l = crcell
        Else
            l = crcell + 1
            'MsgBox("l=" & l)
        End If

        Try
            _invApp = Marshal.GetActiveObject("Inventor.Application")
            Dim otrans As Transaction
            otrans = _invApp.TransactionManager.StartTransaction(_invApp.ActiveDocument, "выбор контура")
            ' _invApp.ActiveDocument.SelectionPriority = 67586
            Dim obj As Object
            Dim oDoc As DrawingDocument
            oDoc = _invApp.ActiveDocument
            ListBox3.Items.Clear()
            kolvoclikov = kolvoclikov + 1
            If RadioButton22.Checked = True Then
                i = 0
                k = 0
                oS = _invApp.ActiveDocument.SelectSet

                kolvo(0, l) = oS.Count
                For k = 0 To 39
                    kolvo(k, l) = kolvo(0, l)
                Next
                k = 0
                'kolvoobsh(l) = kolvo
                If l = 0 Then
                    ReDim XabsN(50)
                    ReDim YabsN(50)
                    ReDim XabsK(50)
                    ReDim YabsK(50)
                    'ReDim elementponomeru(50)
                    ReDim odc1pt(8)
                    ReDim diamokr(50, 15)
                    ReDim Xabsmid(50)
                    ReDim Yabsmid(50)
                    ReDim Yabscentr(50)
                    ReDim Xabscentr(50)
                    ReDim robsh(50)
                    'ReDim dugaponomeru(50)
                    ReDim a1(50)
                    ReDim a2(50)
                    ReDim alfa(50)
                    ReDim betta(50)

                    ReDim Xpmmin(50)
                    ReDim Ypmmin(50)
                    ReDim Ypmmax(50)
                    ReDim Xpmmax(50)

                    'абсолютные общие
                    ReDim XabsobshN(50, 15)
                    ReDim YabsobshN(50, 15)
                    ReDim XabsobshK(50, 15)
                    ReDim YabsobshK(50, 15)
                    ReDim XabsobshM(50, 15)
                    ReDim YabsobshM(50, 15)
                    ReDim XabsobshC(50, 15)
                    ReDim YabsobshC(50, 15)
                    ReDim Xmaxloc(15)
                    ReDim Xminloc(15)
                    ReDim Ymaxloc(15)
                    ReDim Yminloc(15)
                    'относительные общие
                    ReDim XobshotnS(50, 15)
                    ReDim YobshotnS(50, 15)
                    ReDim XobshotnN(50, 15)
                    ReDim YobshotnN(50, 15)
                    ReDim XobshotnK(50, 15)
                    ReDim YobshotnK(50, 15)
                    ReDim XotnobshC(50, 15)
                    ReDim YotnobshC(50, 15)

                    ReDim alfaobsh(50, 15)
                    ReDim bettaobsh(50, 15)
                    ReDim Robsh2(50, 15)
                    ReDim element(50, 40, 15)
                    ReDim dugaponomeruobsh(50, 15)
                    ReDim kpobsh(15)
                    ReDim VectAngle(50)
                    ReDim Vipuklost(50, 15)
                    k = 0
                    i = 0
                End If
                Dim st0 As New DataGridViewCellStyle
                st0.ForeColor = System.Drawing.Color.Tomato
                ' st0.ForeColor = System.Drawing.Color.
                'st0.Font = New System.Drawing.Font("Microsoft Sans Serif", 9)
                Dim st1 As New DataGridViewCellStyle
                st1.ForeColor = System.Drawing.Color.Green
                Dim st2 As New DataGridViewCellStyle
                st2.ForeColor = System.Drawing.Color.Blue
                Dim st3 As New DataGridViewCellStyle
                st3.ForeColor = System.Drawing.Color.Purple
                Dim st4 As New DataGridViewCellStyle
                st4.ForeColor = System.Drawing.Color.Aqua
                'MsgBox("norm")
                DataGridView2.Rows.Add()
                Dim v1, v2, v3 As Integer
                v1 = CInt(Int((255 * Rnd())))
                v2 = CInt(Int((255 * Rnd())))
                v3 = CInt(Int((255 * Rnd())))
                Select Case l
                    Case 0
                        paintcolor = _invApp.TransientObjects.CreateColor(v1, v2, v3)
                        'paintcolor = _invApp.TransientObjects.CreateColor(255, 165, 0)
                        DataGridView2.Rows(l).Cells(0).Style = st0
                    Case 1
                        paintcolor = _invApp.TransientObjects.CreateColor(0, 255, 0)
                        DataGridView2.Rows(l).Cells(0).Style = st1
                    Case 2
                        paintcolor = _invApp.TransientObjects.CreateColor(0, 0, 255)
                        DataGridView2.Rows(l).Cells(0).Style = st2
                    Case 3
                        paintcolor = _invApp.TransientObjects.CreateColor(255, 0, 255)
                        DataGridView2.Rows(l).Cells(0).Style = st3
                    Case 4
                        paintcolor = _invApp.TransientObjects.CreateColor(0, 255, 255)
                        DataGridView2.Rows(l).Cells(0).Style = st4
                    Case 5
                        paintcolor = _invApp.TransientObjects.CreateColor(255, 165, 0)
                        DataGridView2.Rows(l).Cells(0).Style = st0
                    Case 6
                        paintcolor = _invApp.TransientObjects.CreateColor(0, 255, 0)
                        DataGridView2.Rows(l).Cells(0).Style = st1
                    Case 7
                        paintcolor = _invApp.TransientObjects.CreateColor(0, 0, 255)
                        DataGridView2.Rows(l).Cells(0).Style = st2
                    Case 8
                        paintcolor = _invApp.TransientObjects.CreateColor(255, 0, 255)
                        DataGridView2.Rows(l).Cells(0).Style = st3
                    Case 9
                        paintcolor = _invApp.TransientObjects.CreateColor(0, 255, 255)
                        DataGridView2.Rows(l).Cells(0).Style = st4
                    Case 10
                        paintcolor = _invApp.TransientObjects.CreateColor(255, 165, 0)
                        DataGridView2.Rows(l).Cells(0).Style = st0
                    Case 11
                        paintcolor = _invApp.TransientObjects.CreateColor(0, 255, 0)
                        DataGridView2.Rows(l).Cells(0).Style = st1
                    Case 12
                        paintcolor = _invApp.TransientObjects.CreateColor(0, 0, 255)
                        DataGridView2.Rows(l).Cells(0).Style = st2
                    Case 3
                        paintcolor = _invApp.TransientObjects.CreateColor(255, 0, 255)
                        DataGridView2.Rows(l).Cells(0).Style = st3
                    Case 14
                        paintcolor = _invApp.TransientObjects.CreateColor(0, 255, 255)
                        DataGridView2.Rows(l).Cells(0).Style = st4
                End Select
                For Each obj In oS

                    Dim ocircle As Circle2d
                    oDCS1 = obj
                    oDC1 = oDCS1.Parent
                    oDC1.Color = paintcolor
                    oDC1.LineWeight = 0.05
                    Call Proverka_na_dugu()

                    If element(i, 0, l) = "Отрезок" Then

                        odc1pt(0) = Round(oDCS1.StartPoint.X, 4)
                        odc1pt(1) = Round(oDCS1.StartPoint.Y, 4)
                        odc1pt(2) = Round(oDCS1.EndPoint.X, 4)
                        odc1pt(3) = Round(oDCS1.EndPoint.Y, 4)
                        odc1pt(4) = Round(oDC1.MidPoint.X, 4)
                        odc1pt(5) = Round(oDC1.MidPoint.Y, 4)
                        XabsobshN(i, l) = odc1pt(0) * 10
                        YabsobshN(i, l) = odc1pt(1) * 10
                        XabsobshK(i, l) = odc1pt(2) * 10
                        YabsobshK(i, l) = odc1pt(3) * 10
                        XabsobshM(i, l) = odc1pt(4) * 10
                        YabsobshM(i, l) = odc1pt(5) * 10
                        Call poiskminmax()
                    ElseIf element(i, 0, l) = "Дуга" Then

                        odc1pt(0) = Round(oDCS1.StartPoint.X, 4)
                        odc1pt(1) = Round(oDCS1.StartPoint.Y, 4)
                        odc1pt(2) = Round(oDCS1.EndPoint.X, 4)
                        odc1pt(3) = Round(oDCS1.EndPoint.Y, 4)
                        odc1pt(4) = Round(oDC1.CenterPoint.X, 4)
                        odc1pt(5) = Round(oDC1.CenterPoint.Y, 4)
                        odc1pt(6) = Round(oDC1.MidPoint.X, 4)
                        odc1pt(7) = Round(oDC1.MidPoint.Y, 4)
                        XabsobshN(i, l) = odc1pt(0) * 10
                        YabsobshN(i, l) = odc1pt(1) * 10
                        XabsobshK(i, l) = odc1pt(2) * 10
                        YabsobshK(i, l) = odc1pt(3) * 10
                        XabsobshC(i, l) = odc1pt(4) * 10
                        YabsobshC(i, l) = odc1pt(5) * 10
                        XabsobshM(i, l) = odc1pt(6) * 10
                        YabsobshM(i, l) = odc1pt(7) * 10
                        'If kolvoclikov = 1 Then
                        Call poiskminmax()
                        ' End If
                    ElseIf element(i, 0, l) = "Окружность" Then
                        ocircle = oDCS1.Geometry
                        'Dim odcs As DrawingCurveSegment
                        odc1pt(0) = Round(oDC1.CenterPoint.X, 4)
                        odc1pt(1) = Round(oDC1.CenterPoint.Y, 4)
                        'odcs = ocircle
                        odc1pt(2) = ocircle.Radius * 10
                        diamokr(i, l) = 2 * odc1pt(2)
                        Yabscentr(i) = odc1pt(1) * 10
                        Xabscentr(i) = odc1pt(0) * 10
                        XabsobshC(i, l) = odc1pt(0) * 10
                        YabsobshC(i, l) = odc1pt(1) * 10
                        Call poiskminmax()
                        'MsgBox("diamokr(i, l) = " & odc1pt(2))
                    End If

                    ' Call korrektirovka_traekt()
                    If i = kolvo(0, l) - 1 Then
                        If l = 0 Then
                            ReDim XotnN(50)
                            ReDim YotnN(50)
                            ReDim XotnK(50)
                            ReDim YotnK(50)
                            ReDim XotnC(50)
                            ReDim YotnC(50)
                            ReDim XotnS(50)
                            ReDim YotnS(50)
                            ReDim XobshotnS(50, 15)
                            ReDim YobshotnS(50, 15)
                            ReDim XobshotnN(50, 15)
                            ReDim YobshotnN(50, 15)
                            ReDim XobshotnK(50, 15)
                            ReDim YobshotnK(50, 15)
                            ReDim XotnobshC(50, 15)
                            ReDim YotnobshC(50, 15)
                        End If
                        Call Ustanofka_Sk_Stanka()

                    End If

                    i = i + 1
                Next
                If RadioButton1.Checked = True Then
                    viborRB(l) = "Vneshniy contour"
                ElseIf RadioButton2.Checked = True Then
                    viborRB(l) = "Vnutrenniy contour"
                ElseIf RadioButton3.Checked = True Then
                    viborRB(l) = "Paz"
                ElseIf RadioButton10.Checked = True Then
                    viborRB(l) = "Otverstie"
                ElseIf RadioButton19.Checked = True Then
                    viborRB(l) = "Ploskost"
                ElseIf RadioButton13.Checked = True Then
                    viborRB(l) = "Rezba"
                ElseIf RadioButton11.Checked = True Then
                    viborRB(l) = "Ustup"
                ElseIf RadioButton4.Checked = True Then
                    viborRB(l) = "Trahoida"
                End If
                TextBox11.Text = viborRB(crcell) & Convert.ToString(crcell + 1)
                If l > 0 Then
                    DataGridView2.Focus()
                    SendKeys.Send("{DOWN}")
                End If
                CheckBoxviborka.Checked = False
                TextBoxkolvopr.Text = "1"
                DataGridView2.Rows(l).Cells(0).Value = "контур№" & l + 1 & " (" & viborRB(l) & ")"
                l = l + 1
                If l > 14 Then
                    l = 0
                End If
                i = 0
            End If

            otrans.End()
        Catch ex As Exception
            Dim stacktr As New StackTrace(ex, True)
            If stacktr.FrameCount > 0 Then
                Dim stackfr As New StackFrame
                stackfr = stacktr.GetFrame(0)
                Dim errorline As Integer = stackfr.GetFileLineNumber()
                Dim functionname As String = stackfr.GetMethod().Name
                Me.ListBox5.Items.Add("Ошибка в " & functionname & " на линии" & errorline)
                p = p + 1
                Me.ListBox5.Items.Add(ex.Message)
                p = p + 1
            End If
        End Try


    End Sub


    Public Function Ustanofka_Sk_Stanka()

        If kolvoclikov = 1 And AutoSK(l) = True And RadioButton16.Checked = True Then
            If TextBoxXASK.Text = "0" Then
                AutoSK(l) = True
                Xcoord = Xminloc(0)
                Ycoord = Ymaxloc(0)
                TextBoxXASK.Text = Round(Xcoord, 3)
                TextBoxYASK.Text = Round(Ycoord, 3)
            Else
                AutoSK(l) = False
                Xcoord = Single.Parse(TextBoxXASK.Text)
                Ycoord = Single.Parse(TextBoxYASK.Text)
            End If
        ElseIf kolvoclikov = 1 And AutoSK(l) = True And RadioButton17.Checked = True Then

            If TextBoxXASK.Text = "0" Then
                Xcoord = (Xmaxloc(0) + Xminloc(0)) / 2
                Ycoord = (Ymaxloc(0) + Yminloc(0)) / 2
                TextBoxXASK.Text = Round(Xcoord, 3)
                TextBoxYASK.Text = Round(Ycoord, 3)
            Else
                Xcoord = Single.Parse(TextBoxXASK.Text)
                Ycoord = Single.Parse(TextBoxYASK.Text)
            End If

        End If
        j = 0
        For j = 0 To kolvo(0, l) - 1
            XobshotnN(j, l) = XabsobshN(j, l) - Xcoord
            YobshotnN(j, l) = Ycoord - YabsobshN(j, l)
            XobshotnK(j, l) = XabsobshK(j, l) - Xcoord
            YobshotnK(j, l) = Ycoord - YabsobshK(j, l)
            YotnobshC(j, l) = Ycoord - YabsobshC(j, l)
            XotnobshC(j, l) = XabsobshC(j, l) - Xcoord
            XobshotnS(j, l) = XabsobshM(j, l) - Xcoord
            YobshotnS(j, l) = Ycoord - YabsobshM(j, l)




            'Me.ListBox5.Items.Add(XobshotnN(j, l))
            Call koltcevaya_traertoria()
        Next
        For j = 0 To kolvo(0, l) - 1
            If kolvo(0, l) >= 2 And element(j, 0, l) <> "Окружность" Then
                Call Proverka_na_vipuklost()
            End If
            'j = j + 1
        Next
        j = 0
    End Function





    Public Function Proverka_na_dugu()

        Select Case oDCS1.GeometryType
            Case 5249
                MsgBox("Неизвестный тип кривой", "ВНИМАНИЕ")
            Case 5250
                element(i, 0, l) = "Линия"
            Case 5251
                element(i, 0, l) = "Отрезок"
            Case 5252

                element(i, 0, l) = "Окружность"
            Case 5253
                element(i, 0, l) = "Дуга"
            Case 5254

                element(i, 0, l) = "Эллипс"
            Case 5255
                element(i, 0, l) = "Эллиптическая дуга"
            Case 5256
                element(i, 0, l) = "Сплайн"
        End Select
        For k = 0 To 39
            element(i, k, l) = element(i, 0, l)
        Next
        k = 0

    End Function
    Public Function poiskminmax()

        XabsN(i) = XabsobshN(i, l)
        YabsN(i) = YabsobshN(i, l)
        XabsK(i) = XabsobshK(i, l)
        YabsK(i) = YabsobshK(i, l)
        Xabsmid(i) = XabsobshM(i, l)
        Yabsmid(i) = YabsobshM(i, l)
        If element(i, 0, l) = "Дуга" Then
            robsh(i) = Sqrt((XabsK(i) - Xabscentr(i)) ^ 2 + (YabsK(i) - Yabscentr(i)) ^ 2)
            If i = 0 Then
                Xminloc(l) = Xabsmid(i)
                Xmaxloc(l) = Xabsmid(i)
                Yminloc(l) = Yabsmid(i)
                Ymaxloc(l) = Yabsmid(i)
            End If
            If Xabsmid(i) > Xmaxloc(l) Then
                Xmaxloc(l) = Xabsmid(i)
            End If
            If Xabsmid(i) < Xminloc(l) Then
                Xminloc(l) = Xabsmid(i)
            End If
            If Yabsmid(i) > Ymaxloc(l) Then
                Ymaxloc(l) = Yabsmid(i)
            End If
            If Yabsmid(i) < Yminloc(l) Then
                Yminloc(l) = Yabsmid(i)
            End If

        End If
        If element(i, 0, l) = "Отрезок" Then

            If XabsN(i) <= XabsK(i) Then
                Xpmmin(i) = XabsN(i)
                Xpmmax(i) = XabsK(i)
            Else
                Xpmmin(i) = XabsK(i)
                Xpmmax(i) = XabsN(i)
            End If
            If YabsN(i) <= YabsK(i) Then
                Ypmmin(i) = YabsN(i)
                Ypmmax(i) = YabsK(i)
            Else
                Ypmmin(i) = YabsK(i)
                Ypmmax(i) = YabsN(i)
            End If
            If i = 0 Then
                Xminloc(l) = Xpmmin(0)
                Xmaxloc(l) = Xpmmax(0)
                Yminloc(l) = Ypmmin(0)
                Ymaxloc(l) = Ypmmax(0)
            End If
            If Xminloc(l) > Xpmmin(i) Then
                Xminloc(l) = Xpmmin(i)
            End If
            If Yminloc(l) > Ypmmin(i) Then
                Yminloc(l) = Ypmmin(i)
            End If
            If Ymaxloc(l) < Ypmmax(i) Then
                Ymaxloc(l) = Ypmmax(i)
            End If
            If Xmaxloc(l) < Xpmmax(i) Then
                Xmaxloc(l) = Xpmmax(i)
            End If
        End If

        If element(i, 0, l) = "Окружность" Then
            Xpmmin(i) = Xabscentr(i) - diamokr(i, l) / 2
            Xpmmax(i) = Xabscentr(i) + diamokr(i, l) / 2
            Ypmmin(i) = Yabscentr(i) - diamokr(i, l) / 2
            Ypmmax(i) = Yabscentr(i) + diamokr(i, l) / 2
            If i = 0 Then
                Xminloc(l) = Xpmmin(0)
                Xmaxloc(l) = Xpmmax(0)
                Yminloc(l) = Ypmmin(0)
                Ymaxloc(l) = Ypmmax(0)
            End If
            If Xminloc(l) > Xpmmin(i) Then
                Xminloc(l) = Xpmmin(i)
            End If
            If Yminloc(l) > Ypmmin(i) Then
                Yminloc(l) = Ypmmin(i)
            End If
            If Ymaxloc(l) < Ypmmax(i) Then
                Ymaxloc(l) = Ypmmax(i)
            End If
            If Xmaxloc(l) < Xpmmax(i) Then
                Xmaxloc(l) = Xpmmax(i)
            End If
        End If
    End Function

    Public Function Wait(seconds)
        'включение таймера
        Timer1.Enabled = True
        Dim k As Integer
        k = 0
        'установка интервала для таймера
        Me.Timer1.Interval = 1000 * seconds

        ' выключение таймера
        Timer1.Enabled = False
    End Function

    Public Function Ris_siscoord()
        If RadioButton16.Checked = True Then
            Kontour.DrawLine(pen2, Sdvg - xprip, Sdvg - yprip, Sdvg + 10 - xprip, Sdvg - yprip)
            Kontour.DrawLine(pen2, Sdvg + 10 - xprip, Sdvg - yprip, Sdvg + 7 - xprip, Sdvg - yprip - 1)
            Kontour.DrawLine(pen2, Sdvg + 10 - xprip, Sdvg - yprip, Sdvg + 7 - xprip, Sdvg - yprip + 1)
            Kontour.DrawLine(pen3, Sdvg - xprip, Sdvg - yprip, Sdvg - xprip, Sdvg - 10 - yprip)
            Kontour.DrawLine(pen3, Sdvg - xprip, Sdvg - 10 - yprip, Sdvg - 1 - xprip, Sdvg - 7 - yprip)
            Kontour.DrawLine(pen3, Sdvg - xprip, Sdvg - 10 - yprip, Sdvg + 1 - xprip, Sdvg - 7 - yprip)
        ElseIf RadioButton17.Checked = True Then
            Dim xsred, ysred As Single
            xsred = (Xmaxloc(0) - Xminloc(0)) / 2
            ysred = (Ymaxloc(0) - Yminloc(0)) / 2
            xsred = 0
            ysred = 0
            Kontour.DrawLine(pen2, Sdvg + xsred, Sdvg + ysred, Sdvg + 10 + xsred, Sdvg + ysred)
            Kontour.DrawLine(pen2, Sdvg + xsred + 10, Sdvg + ysred, Sdvg + 7 + xsred, Sdvg + ysred - 1)
            Kontour.DrawLine(pen2, Sdvg + xsred + 10, Sdvg + ysred, Sdvg + 7 + xsred, Sdvg + ysred + 1)
            Kontour.DrawLine(pen3, Sdvg + xsred, Sdvg + ysred, Sdvg + xsred, Sdvg + ysred - 10)
            Kontour.DrawLine(pen3, Sdvg + xsred, Sdvg + ysred - 10, Sdvg - 1 + xsred, Sdvg + ysred - 7)
            Kontour.DrawLine(pen3, Sdvg + xsred, Sdvg + ysred - 10, Sdvg + 1 + xsred, Sdvg + ysred - 7)
            ListBox5.Items.Add("Sdvg=" & Sdvg)
        End If
    End Function

    Public Function otrisovka_zagotovki()
        Try
            If RadioButton16.Checked = True Then
                If AutoSK(crcell) = True Then

                    'If kolvoclikov = 1 Then
                    rectangle1.X = Sdvg - xprip
                        rectangle1.Y = Sdvg - yprip
                        rectangle1.Width = Xmaxloc(0) - Xcoord + Sdvg + xprip - (Sdvg - xprip)
                        rectangle1.Height = -Yminloc(0) + Ycoord + Sdvg + yprip - (Sdvg - yprip)
                    'End If
                Else
                    ' If kolvoclikov = 1 Then
                    rectangle1.X = Sdvg - xprip
                        rectangle1.Y = Sdvg - yprip
                        rectangle1.Width = Xmaxloc(0) - Xcoord + xprip2
                        rectangle1.Height = -Yminloc(0) + Ycoord + yprip2
                    'End If
                End If
                Kontour.DrawRectangle(pen5, rectangle1)
                ElseIf RadioButton17.Checked Then
                    If kolvoclikov = 1 Then
                    rectangle1.X = Sdvg - (Xmaxloc(0) - Xminloc(0)) / 2 - xprip
                    rectangle1.Y = Sdvg - (Ymaxloc(0) - Yminloc(0)) / 2 - yprip
                    rectangle1.Width = Single.Parse(TextBox1.Text)
                    rectangle1.Height = Single.Parse(TextBox1.Text)
                End If
                Kontour.DrawEllipse(pen5, rectangle1)
            End If
        Catch ex As Exception
            Me.ListBox5.Items.Add(p & "  " & "Отрисовка заготовки невожзможна")
            p = p + 1
        End Try
        'MsgBox("заготовка отрисована чотко")
    End Function






    Public Function Proverka_na_peresech_traektoriy()
        If l = 0 Then
            ReDim zazor(50)
            x11 = -xprip
            y11 = -yprip
            x21 = Xmaxloc(l) - Xcoord + xprip
            y21 = -Yminloc(l) + Ycoord + yprip
            x12 = -xprip
            y12 = -Yminloc(l) + Ycoord + yprip
            x22 = Xmaxloc(l) - Xcoord + xprip
            y22 = -yprip
            k1 = (y21 - y11) / (x21 - x11)
            k2 = (y12 - y22) / (x22 - x12)
            b1 = y11 - x11 * k1
            b2 = y12 - x12 * k2
            XotnC(j - 1) = XotnobshC(j - 1, l)
            YotnC(j - 1) = YotnobshC(j - 1, l)
            'robsh(j - 1) = Robsh2(j - 1, l)
            xc = Round(XotnC(j - 1) + xprip, 2)
            yc = Round(YotnC(j - 1) + yprip, 2)
            R = Round(robsh(j - 1), 2)

            'Пересечение
            Dim akv, bkv, ckv, D, Aokr, Bokr, Cokr, l1, l2, l3, l4 As Single
            'C первой прямой(слева сверху - направо вниз)
            Aokr = -2 * xc
            Bokr = -2 * yc
            Cokr = -R ^ 2 + xc ^ 2 + yc ^ 2
            akv = (1 + k1 ^ 2)
            bkv = 2 * k1 * b1 + Aokr + Bokr * k1
            ckv = b1 ^ 2 + Bokr * b1 + Cokr
            D = bkv ^ 2 - 4 * akv * ckv
            If D > 0 Then
                x1 = (-bkv + Sqrt(D)) / (2 * akv)
                x2 = (-bkv - Sqrt(D)) / (2 * akv)
                y1 = k1 * x1 + b1
                y2 = k1 * x2 + b1
                If x11 < x1 And x1 < x21 Then
                    If y21 > y1 And y1 > y11 Then

                        l1 = Sqrt((x21 - x1) ^ 2 + (y1 - y21) ^ 2)
                        l3 = Sqrt((x1 - x11) ^ 2 + (y11 - y1) ^ 2)

                    End If
                End If
                If x11 < x2 And x2 < x21 Then
                    If y21 > y2 And y2 > y11 Then

                        l2 = Sqrt((x21 - x2) ^ 2 + (y2 - y21) ^ 2)
                        l4 = Sqrt((x2 - x11) ^ 2 + (y11 - y2) ^ 2)

                    End If
                End If
                l1 = Min(l1, l2)
                l3 = Min(l3, l4)

                zazor(j - 1) = Min(l1, l3)
                'MsgBox(zazor(j - 1))

                If j <= 1 Then
                    zazormax = zazor(j - 1)
                Else
                    zazormax = Max(zazor(j - 1), zazormax)
                End If

                'MsgBox("j=", j, )
            Else
                zazormax = Max(Sqrt(xprip ^ 2 + yprip ^ 2), zazormax)
            End If
        End If
        ' MsgBox("zazor=" & zazormax)
    End Function

    Private Sub TextBox4_TextChanged(sender As Object, e As EventArgs) Handles TextBoxprip.TextChanged
        Try
            TextBoxprip.BackColor = Drawing.Color.White
            prip = TextBoxprip.Text
        Catch ex As Exception
            Me.ListBox5.Items.Add(p & "  " & "введите неотрицательное число, знаки '-' и '.' недопустимы")
            p = p + 1
            TextBoxprip.BackColor = Drawing.Color.Yellow
        End Try
    End Sub

    Private Sub TextBoxDkf_TextChanged(sender As Object, e As EventArgs) Handles TextBoxDkf.TextChanged
        Try
            TextBoxDkf.BackColor = Drawing.Color.White
            Dfrez(ni) = TextBoxDkf.Text
        Catch ex As Exception
            Me.ListBox5.Items.Add(p & "  " & "введите неотрицательное число, знаки '-' и '.' недопустимы")
            p = p + 1
            TextBoxDkf.BackColor = Drawing.Color.Yellow
        End Try
    End Sub

    Private Sub TextBoxDtf_TextChanged(sender As Object, e As EventArgs) Handles TextBoxDtf.TextChanged
        Try
            TextBoxDkf.BackColor = Drawing.Color.White
            Dfrez(ni) = TextBoxDkf.Text
        Catch ex As Exception
            Me.ListBox5.Items.Add(p & "  " & "введите неотрицательное число, знаки '-' и '.' недопустимы")
            p = p + 1
            TextBoxDkf.BackColor = Drawing.Color.Yellow
        End Try
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        Try

            If TextBox3.Text = Nothing Then
                MsgBox("Введите габариты заготовки")
                TextBox3.BackColor = Drawing.Color.Yellow
                Return
            End If
            TextBox3.BackColor = Drawing.Color.White
            Z = Convert.ToString(TextBox3.Text)
            'MsgBox("l=" & l)
            crcell = DataGridView2.CurrentCell.RowIndex

            lloc = l
                    l = crcell
            ' kolvo = kolvoobsh(l)
            Call G_code_zapis2()
            l = lloc

        Catch ex As Exception
            Me.ListBox5.Items.Add(p & "  " & "Сбой в записи G-code")
            p = p + 1
            Me.ListBox5.Items.Add(p & "  " & ex.Message)
            p = p + 1
        End Try
        'Call G_code_zapis()
    End Sub



    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        ListBox2.Items.Clear()
    End Sub

    Public Function raschet_rej_rez()
        Try
            Dim Vrez, Nrez, Srez As Single
            Vrez = Single.Parse(TextBoxVrez.Text)
            If ListBox1.SelectedIndex < 8 And ListBox1.SelectedIndex > 0 Then
                Nrez = Round((1000 * Vrez) / (PI * Dfrez(ni)), 0)
                If Nrez >= Nmax Then
                    Vrez = Round(PI * Dfrez(ni) * Nmax / 1000, 1)
                    TextBoxVrez.Text = Vrez

                    Nrez = Nmax
                End If
            Else
                Nrez = Round((1000 * Vrez) / (PI * Dsv(ni)), 0)
                If Nrez >= Nmax Then
                    Vrez = Round(PI * Dsv(ni) * Nmax / 1000, 1)
                    TextBoxVrez.Text = Vrez

                    Nrez = Nmax
                End If
            End If

            TextBoxobchern.Text = Nrez
            If ListBox1.SelectedIndex >= 14 Then
                Slabel(ListBox1.SelectedIndex) = Nrez * ShagM(ListBox1.SelectedIndex)
                TextBoxpdchvert.Text = Slabel(ListBox1.SelectedIndex)
            Else
                TextBoxpdchvert.Text = Round(Single.Parse(TextBoxSrez.Text) / 5, 0)

            End If
            TextBoxpodchist.Text = Round(0.5 * Single.Parse(TextBoxSrez.Text), 0)

            If Nrez * 2 < Nmax Then
                TextBoxobchist.Text = Nrez * 2
            Else
                TextBoxobchist.Text = Convert.ToString(Nmax)

            End If
            If ListBox1.SelectedIndex = 1 Then
                TextBoxobchist.Text = Convert.ToString(Nrez + 300)
            End If
        Catch ex As Exception
            Dim stacktr As New StackTrace(ex, True)
            If stacktr.FrameCount > 0 Then
                Dim stackfr As New StackFrame
                stackfr = stacktr.GetFrame(0)
                Dim errorline As Integer = stackfr.GetFileLineNumber()
                Dim functionname As String = stackfr.GetMethod().Name
                Me.ListBox5.Items.Add("Ошибка в " & functionname & " на линии" & errorline)
                p = p + 1

            End If
        End Try
    End Function
    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged
        Select Case ListBox1.SelectedIndex
            Case 0

                PictureBox3.Image = MT2CAM.My.Resources.Resources.centrdrill
                TextBoxDzone.Enabled = True
                TextBoxDzdva.Enabled = True
                TextBoxLvil.Enabled = True
                TextBoxLrch.Enabled = True
                TextBoxDzone.Text = "1,6"
                TextBoxDzdva.Text = "4"
                TextBoxLvil.Text = "70"
                TextBoxLrch.Text = "12"
                TextBoxDkf.Enabled = False
                TextBoxDtf.Enabled = False
                TextBoxDsv.Enabled = False
                Dfrez(ni) = 0
                Dsv(ni) = 5
                Label25.Text = "Сверло центровочное"
                Glabel(0) = "Zentrovochnoe sverlo"
                If RadioButtonalum.Checked = True Then
                    Vlabel(0) = 80
                    Slabel(0) = 510 * 5
                ElseIf RadioButtonstil.Checked = True Then
                    Vlabel(0) = 80
                    Slabel(0) = 510
                End If
                TextBoxVrez.Text = Vlabel(0)
                TextBoxSrez.Text = Slabel(0)
                Call raschet_rej_rez()


            Case 1
                PictureBox3.Image = MT2CAM.My.Resources.Resources.facemill
                TextBoxDtf.Enabled = True
                TextBoxLrch.Enabled = True
                TextBoxDzone.Enabled = False
                TextBoxDzdva.Enabled = False
                TextBoxLvil.Enabled = False
                TextBoxLrch.Text = "7"
                TextBoxDkf.Enabled = False
                TextBoxDtf.Text = "80"
                TextBoxDsv.Enabled = False

                Dfrez(ni) = TextBoxDtf.Text
                Label25.Text = "Торцевая фреза ф80"
                Glabel(1) = "Torcevaya freza d80"
                If RadioButtonalum.Checked = True Then
                    Vlabel(1) = 678.5
                    Slabel(1) = 1200
                ElseIf RadioButtonstil.Checked = True Then
                    Vlabel(1) = 200
                    Slabel(1) = 500
                End If

                TextBoxVrez.Text = Vlabel(1)
                TextBoxSrez.Text = Slabel(1)
                Call raschet_rej_rez()
            Case 2
                PictureBox3.Image = MT2CAM.My.Resources.Resources.facemillsmall
                TextBoxDtf.Enabled = True
                TextBoxLvil.Enabled = True
                TextBoxLrch.Enabled = True
                TextBoxDzone.Enabled = False
                TextBoxDzdva.Enabled = False
                TextBoxLvil.Text = "70"
                TextBoxLrch.Text = "10"
                TextBoxDkf.Enabled = False
                TextBoxDtf.Text = "20"
                TextBoxDsv.Enabled = False

                Dfrez(ni) = TextBoxDtf.Text
                Label25.Text = "Торцевая фреза ф20"
                Glabel(2) = "Torcevaya freza d20"
                If RadioButtonalum.Checked = True Then
                    Vlabel(2) = 169.6
                    Slabel(2) = 1200
                ElseIf RadioButtonstil.Checked = True Then
                    Vlabel(2) = 150
                    Slabel(2) = 350
                End If
                TextBoxVrez.Text = Vlabel(2)
                TextBoxSrez.Text = Slabel(2)
                Call raschet_rej_rez()

            Case 3
                TextBoxDkf.Enabled = True
                TextBoxLvil.Enabled = True
                TextBoxLrch.Enabled = True
                TextBoxDzone.Enabled = False
                TextBoxDzdva.Enabled = False
                TextBoxLvil.Text = "60"
                TextBoxLrch.Text = "55"
                TextBoxDkf.Text = "12"
                TextBoxDtf.Enabled = False
                TextBoxDsv.Enabled = False
                Dfrez(ni) = TextBoxDkf.Text
                PictureBox3.Image = MT2CAM.My.Resources.Resources.endmill
                'Labeldtk.Show()
                Label25.Text = "Концевая фреза ф12"
                Glabel(3) = "Koncevaya freza d12"
                If RadioButtonalum.Checked = True Then
                    Vlabel(3) = 250
                    Slabel(3) = 1434
                ElseIf RadioButtonstil.Checked = True Then
                    Vlabel(3) = 120
                    Slabel(3) = 300
                End If
                TextBoxVrez.Text = Vlabel(3)
                TextBoxSrez.Text = Slabel(3)
                Call raschet_rej_rez()
            Case 4
                TextBoxDkf.Enabled = True
                TextBoxLvil.Enabled = True
                TextBoxLrch.Enabled = True
                TextBoxDzone.Enabled = False
                TextBoxDzdva.Enabled = False
                TextBoxLvil.Text = "50"
                TextBoxLrch.Text = "45"
                TextBoxDkf.Text = "10"
                TextBoxDtf.Enabled = False
                TextBoxDsv.Enabled = False
                Dfrez(ni) = TextBoxDkf.Text
                PictureBox3.Image = MT2CAM.My.Resources.Resources.endmill
                Label25.Text = "Концевая фреза ф10"
                Glabel(4) = "Koncevaya freza d10"
                If RadioButtonalum.Checked = True Then
                    Vlabel(4) = 250
                    Slabel(4) = 1434
                ElseIf RadioButtonstil.Checked = True Then
                    Vlabel(4) = 120
                    Slabel(4) = 300
                End If
                TextBoxVrez.Text = Vlabel(4)
                TextBoxSrez.Text = Slabel(4)
                Call raschet_rej_rez()
            Case 5
                TextBoxDkf.Enabled = True
                TextBoxLvil.Enabled = True
                TextBoxLrch.Enabled = True
                TextBoxDzone.Enabled = False
                TextBoxDzdva.Enabled = False
                TextBoxLvil.Text = "35"
                TextBoxLrch.Text = "30"
                TextBoxDkf.Text = "6"
                TextBoxDtf.Enabled = False
                TextBoxDsv.Enabled = False
                Dfrez(ni) = TextBoxDkf.Text
                PictureBox3.Image = MT2CAM.My.Resources.Resources.endmill
                Label25.Text = "Концевая фреза ф6"
                Glabel(5) = "Koncevaya freza d6"
                If RadioButtonalum.Checked = True Then
                    Vlabel(5) = 250
                    Slabel(5) = 1590
                ElseIf RadioButtonstil.Checked = True Then
                    Vlabel(5) = 120
                    Slabel(5) = 250
                End If
                TextBoxVrez.Text = Vlabel(5)
                TextBoxSrez.Text = Slabel(5)
                Call raschet_rej_rez()
            Case 6
                TextBoxDkf.Enabled = True
                TextBoxLvil.Enabled = True
                TextBoxLrch.Enabled = True
                TextBoxDzone.Enabled = False
                TextBoxDzdva.Enabled = False
                TextBoxLvil.Text = "25"
                TextBoxLrch.Text = "20"
                TextBoxDkf.Text = "4"
                TextBoxDtf.Enabled = False
                TextBoxDsv.Enabled = False
                Dfrez(ni) = TextBoxDkf.Text
                PictureBox3.Image = MT2CAM.My.Resources.Resources.endmill
                Label25.Text = "Концевая фреза ф4"
                Glabel(6) = "Koncevaya freza d4"
                If RadioButtonalum.Checked = True Then
                    Vlabel(6) = 200
                    Slabel(6) = 1590
                ElseIf RadioButtonstil.Checked = True Then
                    Vlabel(6) = 120
                    Slabel(6) = 200
                End If
                TextBoxVrez.Text = Vlabel(6)
                TextBoxSrez.Text = Slabel(6)
                Call raschet_rej_rez()
            Case 7
                TextBoxDkf.Enabled = True
                TextBoxLvil.Enabled = True
                TextBoxLrch.Enabled = True
                TextBoxDzone.Enabled = False
                TextBoxDzdva.Enabled = False
                TextBoxLvil.Text = "30"
                TextBoxLrch.Text = "5"
                TextBoxDkf.Text = "6"
                TextBoxDtf.Enabled = False
                TextBoxDsv.Enabled = False
                Dfrez(ni) = TextBoxDkf.Text
                PictureBox3.Image = MT2CAM.My.Resources.Resources.chamfermill
                Label25.Text = "фасочная фреза ф6"
                Glabel(7) = "fasochnaya freza d6"
                Vlabel(7) = 150
                Slabel(7) = 1000
                TextBoxVrez.Text = Vlabel(7)
                TextBoxSrez.Text = Slabel(7)
                Call raschet_rej_rez()
            Case 8
                TextBoxDsv.Enabled = True
                TextBoxLvil.Enabled = True
                TextBoxLrch.Enabled = True
                TextBoxDzone.Enabled = False
                TextBoxDzdva.Enabled = False
                TextBoxLvil.Text = "30"
                TextBoxLrch.Text = "25"
                TextBoxDkf.Enabled = False
                TextBoxDtf.Enabled = False
                TextBoxDsv.Text = "1.6"
                Dfrez(ni) = 0
                Dsv(ni) = 1.6
                PictureBox3.Image = MT2CAM.My.Resources.Resources.drill
                Label25.Text = "Сверло ф1,6"
                Glabel(8) = "Sverlo 1.6"
                If RadioButtonalum.Checked = True Then
                    Vlabel(8) = 80
                    Slabel(8) = 510 * 5
                ElseIf RadioButtonstil.Checked = True Then
                    Vlabel(8) = 35
                    Slabel(8) = 500
                End If
                TextBoxVrez.Text = Vlabel(8)
                TextBoxSrez.Text = Slabel(8)
                Call raschet_rej_rez()
               ' MsgBox(Dsv(ni))
            Case 9
                TextBoxDsv.Enabled = True
                TextBoxLvil.Enabled = True
                TextBoxLrch.Enabled = True
                TextBoxDzone.Enabled = False
                TextBoxDzdva.Enabled = False
                TextBoxLvil.Text = "30"
                TextBoxLrch.Text = "25"
                TextBoxDkf.Enabled = False
                TextBoxDtf.Enabled = False
                TextBoxDsv.Text = "2.05"
                'Dfrez(ni) = 0
                Dsv(ni) = 2.05
                PictureBox3.Image = MT2CAM.My.Resources.Resources.drill
                Label25.Text = "Сверло ф2,05"
                Glabel(9) = "Sverlo 2.05"
                If RadioButtonalum.Checked = True Then
                    Vlabel(9) = 80
                    Slabel(9) = 510 * 5
                ElseIf RadioButtonstil.Checked = True Then
                    Vlabel(9) = 35
                    Slabel(9) = 500
                End If
                TextBoxVrez.Text = Vlabel(9)
                TextBoxSrez.Text = Slabel(9)
                Call raschet_rej_rez()

            Case 10
                TextBoxDsv.Enabled = True
                TextBoxLvil.Enabled = True
                TextBoxLrch.Enabled = True
                TextBoxDzone.Enabled = False
                TextBoxDzdva.Enabled = False
                TextBoxLvil.Text = "35"
                TextBoxLrch.Text = "30"
                TextBoxDkf.Enabled = False
                TextBoxDtf.Enabled = False
                TextBoxDsv.Text = "2.5"
                Dfrez(ni) = 0
                Dsv(ni) = 2.5
                PictureBox3.Image = MT2CAM.My.Resources.Resources.drill
                Label25.Text = "Сверло ф2,5"
                Glabel(10) = "Sverlo 2.5"
                If RadioButtonalum.Checked = True Then
                    Vlabel(10) = 80
                    Slabel(10) = 510 * 5
                ElseIf RadioButtonstil.Checked = True Then
                    Vlabel(10) = 35
                    Slabel(10) = 500
                End If
                TextBoxVrez.Text = Vlabel(10)
                TextBoxSrez.Text = Slabel(10)
                Call raschet_rej_rez()

            Case 11
                TextBoxDsv.Enabled = True
                TextBoxLvil.Enabled = True
                TextBoxLrch.Enabled = True
                TextBoxDzone.Enabled = False
                TextBoxDzdva.Enabled = False
                TextBoxLvil.Text = "40"
                TextBoxLrch.Text = "37"
                TextBoxDkf.Enabled = False
                TextBoxDtf.Enabled = False
                TextBoxDsv.Text = "3.3"
                Dfrez(ni) = 0
                Dsv(ni) = 3.3
                PictureBox3.Image = MT2CAM.My.Resources.Resources.drill
                Label25.Text = "Сверло ф3,3"
                Glabel(11) = "Sverlo 3.3"
                If RadioButtonalum.Checked = True Then
                    Vlabel(11) = 80
                    Slabel(11) = 510 * 5
                ElseIf RadioButtonstil.Checked = True Then
                    Vlabel(11) = 35
                    Slabel(11) = 500
                End If
                TextBoxVrez.Text = Vlabel(11)
                TextBoxSrez.Text = Slabel(11)
                Call raschet_rej_rez()

            Case 12
                TextBoxDsv.Enabled = True
                TextBoxLvil.Enabled = True
                TextBoxLrch.Enabled = True
                TextBoxDzone.Enabled = False
                TextBoxDzdva.Enabled = False
                TextBoxLvil.Text = "50"
                TextBoxLrch.Text = "45"
                TextBoxDkf.Enabled = False
                TextBoxDtf.Enabled = False
                TextBoxDsv.Text = "4.2"
                Dfrez(ni) = 0
                Dsv(ni) = 4.2
                PictureBox3.Image = MT2CAM.My.Resources.Resources.drill
                Label25.Text = "Сверло ф4,2"
                Glabel(12) = "Sverlo 4.2"
                If RadioButtonalum.Checked = True Then
                    Vlabel(12) = 80
                    Slabel(12) = 510 * 5
                ElseIf RadioButtonstil.Checked = True Then
                    Vlabel(12) = 35
                    Slabel(12) = 500
                End If
                TextBoxVrez.Text = Vlabel(12)
                TextBoxSrez.Text = Slabel(12)
                Call raschet_rej_rez()

            Case 13
                TextBoxDsv.Enabled = True
                TextBoxLvil.Enabled = True
                TextBoxLrch.Enabled = True
                TextBoxDzone.Enabled = False
                TextBoxDzdva.Enabled = False
                TextBoxLvil.Text = "55"
                TextBoxLrch.Text = "50"
                TextBoxDkf.Enabled = False
                TextBoxDtf.Enabled = False
                TextBoxDsv.Text = "5"
                Dfrez(ni) = 0
                Dsv(ni) = 5
                PictureBox3.Image = MT2CAM.My.Resources.Resources.drill
                Label25.Text = "Сверло ф5"
                Glabel(13) = "Sverlo 5"
                If RadioButtonalum.Checked = True Then
                    Vlabel(13) = 80
                    Slabel(13) = 510 * 5
                ElseIf RadioButtonstil.Checked = True Then
                    Vlabel(13) = 35
                    Slabel(13) = 500
                End If
                TextBoxVrez.Text = Vlabel(13)
                TextBoxSrez.Text = Slabel(13)
                Call raschet_rej_rez()
            Case 14
                PictureBox3.Image = MT2CAM.My.Resources.Resources.tap
                TextBoxDsv.Enabled = True
                TextBoxLvil.Enabled = True
                TextBoxLrch.Enabled = True
                TextBoxDzone.Enabled = False
                TextBoxDzdva.Enabled = False
                TextBoxLvil.Text = "25"
                TextBoxLrch.Text = "18"
                TextBoxDkf.Enabled = False
                TextBoxDtf.Enabled = False
                TextBoxDsv.Text = "2"
                Dfrez(ni) = 0
                Dsv(ni) = 2
                ShagM(14) = 0.4
                Label25.Text = "Метчик М2х0.4"
                Glabel(14) = "Metchik M2x0.4"
                Vlabel(14) = 5
                Slabel(14) = 0
                TextBoxVrez.Text = Vlabel(14)
                TextBoxpdchvert.Text = Slabel(14)
                Call raschet_rej_rez()
            Case 15
                PictureBox3.Image = MT2CAM.My.Resources.Resources.tap
                TextBoxDsv.Enabled = True
                TextBoxLvil.Enabled = True
                TextBoxLrch.Enabled = True
                TextBoxDzone.Enabled = False
                TextBoxDzdva.Enabled = False
                TextBoxLvil.Text = "40"
                TextBoxLrch.Text = "30"
                TextBoxDkf.Enabled = False
                TextBoxDtf.Enabled = False
                TextBoxDsv.Text = "3"
                Dfrez(ni) = 0
                Dsv(ni) = 3
                ShagM(15) = 0.5
                Label25.Text = "Метчик М3х0.5"
                Glabel(15) = "Metchik M3x0.5"
                Vlabel(15) = 5
                Slabel(15) = 0
                TextBoxVrez.Text = Vlabel(15)
                TextBoxpdchvert.Text = Slabel(15)
                Call raschet_rej_rez()
            Case 16
                PictureBox3.Image = MT2CAM.My.Resources.Resources.tap
                TextBoxDsv.Enabled = True
                TextBoxLvil.Enabled = True
                TextBoxLrch.Enabled = True
                TextBoxDzone.Enabled = False
                TextBoxDzdva.Enabled = False
                TextBoxLvil.Text = "42"
                TextBoxLrch.Text = "30"
                TextBoxDkf.Enabled = False
                TextBoxDtf.Enabled = False
                TextBoxDsv.Text = "3.5"
                Dfrez(ni) = 0
                Dsv(ni) = 3.5
                ShagM(16) = 0.6
                Label25.Text = "Метчик М3.5х0.6"
                Glabel(16) = "Metchik M3.5x0.6"
                Vlabel(16) = 10
                Slabel(16) = 0
                TextBoxVrez.Text = Vlabel(16)
                TextBoxpdchvert.Text = Slabel(16)
                Call raschet_rej_rez()

            Case 17
                PictureBox3.Image = MT2CAM.My.Resources.Resources.tap
                TextBoxDsv.Enabled = True
                TextBoxLvil.Enabled = True
                TextBoxLrch.Enabled = True
                TextBoxDzone.Enabled = False
                TextBoxDzdva.Enabled = False
                TextBoxLvil.Text = "45"
                TextBoxLrch.Text = "35"
                TextBoxDkf.Enabled = False
                TextBoxDtf.Enabled = False
                TextBoxDsv.Text = "4"
                Dfrez(ni) = 0
                Dsv(ni) = 4
                ShagM(17) = 0.7
                Label25.Text = "Метчик М4х0.7"
                Glabel(17) = "Metchik M4x0.7"
                Vlabel(17) = 10
                Slabel(17) = 0
                TextBoxVrez.Text = Vlabel(17)
                TextBoxpdchvert.Text = Slabel(17)
                Call raschet_rej_rez()
            Case 18
                PictureBox3.Image = MT2CAM.My.Resources.Resources.tap
                TextBoxDsv.Enabled = True
                TextBoxLvil.Enabled = True
                TextBoxLrch.Enabled = True
                TextBoxDzone.Enabled = False
                TextBoxDzdva.Enabled = False
                TextBoxLvil.Text = "50"
                TextBoxLrch.Text = "35"
                TextBoxDkf.Enabled = False
                TextBoxDtf.Enabled = False
                TextBoxDsv.Text = "5"
                Dfrez(ni) = 0
                Dsv(ni) = 5
                ShagM(18) = 0.8
                Label25.Text = "Метчик М5х0.8"
                Glabel(18) = "Metchik M5x0.8"
                Vlabel(18) = 12
                Slabel(18) = 0
                TextBoxVrez.Text = Vlabel(18)
                TextBoxpdchvert.Text = Slabel(18)
                Call raschet_rej_rez()

            Case 19
                PictureBox3.Image = MT2CAM.My.Resources.Resources.tap
                TextBoxDsv.Enabled = True
                TextBoxLvil.Enabled = True
                TextBoxLrch.Enabled = True
                TextBoxDzone.Enabled = False
                TextBoxDzdva.Enabled = False
                TextBoxLvil.Text = "50"
                TextBoxLrch.Text = "35"
                TextBoxDkf.Enabled = False
                TextBoxDtf.Enabled = False
                TextBoxDsv.Text = "6"
                Dfrez(ni) = 0
                Dsv(ni) = 6
                ShagM(19) = 1
                Label25.Text = "Метчик М6х1"
                Glabel(19) = "Metchik M6x1"
                Vlabel(19) = 15
                Slabel(19) = 0
                TextBoxVrez.Text = Vlabel(19)
                TextBoxpdchvert.Text = Slabel(19)
                Call raschet_rej_rez()

            Case Else
                MsgBox("Выберите концевую фрезу")
                Exit Select

        End Select
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        kolvoclikov = 0
        zazormax = 0
        TextBoxXASK.Text = "0"
        TextBoxYASK.Text = "0"
        For i = 0 To 14
            AutoSK(i) = True
        Next
        i = 0
        Xcoord = 0
        Ycoord = 0
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        Try
            'Form4.Show()
            l = crcell
            If DataGridView2.Rows(l + 1).Cells(0).Value = "" Then
                DataGridView2.Rows(l).Cells(0).Value = ""
                'ListBox3.Items.RemoveAt(ListBox3.Items.Count - 1)

                If l < 0 Then
                    l = 0
                End If
            Else
                Me.ListBox5.Items.Add(p & "Можно удалить только последнюю строку")
                p = p + 1
                Exit Sub
            End If
        Catch ex As Exception
            Dim stacktr As New StackTrace(ex, True)
            If stacktr.FrameCount > 0 Then
                Dim stackfr As New StackFrame
                stackfr = stacktr.GetFrame(0)
                Dim errorline As Integer = stackfr.GetFileLineNumber()
                Dim functionname As String = stackfr.GetMethod().Name
                Me.ListBox5.Items.Add(p & "Ошибка в " & functionname & " на линии" & errorline)
                p = p + 1

            End If
        End Try
    End Sub

    Private Sub TrackBar1_MouseUp(sender As Object, e As MouseEventArgs) Handles TrackBar1.MouseUp

        Try
            'gr = Form4.PictureBox1.CreateGraphics
            Kontour = PictureBox1.CreateGraphics
            Sdvg = 10 * scalesdvg + Sqrt(xprip ^ 2 + yprip ^ 2)
            Kontour.ScaleTransform(scale1, scale1)
            'Form4.gr.ScaleTransform(scale, scale)
            j = 0
            pen1 = New Pen(Brushes.Black, 0.5)
            pen2 = New Pen(Brushes.Red, 1)
            pen3 = New Pen(Brushes.Green, 1)
            pen4 = New Pen(Brushes.Red, 0.7)
            pen4.DashStyle = Drawing2D.DashStyle.Solid
            pen5 = New Pen(Brushes.Blue, 0.5)
            crcell = DataGridView2.CurrentCell.RowIndex
            lloc = l
            For l = 0 To crcell
                'kolvo = kolvoobsh(l)
                j = 0
                If CheckBox4.Checked = False Then
                    ' Call otrisovka_vsego_mod()
                    j = 0
                    Call otrisovka_vsego_mod_2()
                    j = 0
                Else
                    'Call otrisovka_vsego_mod_3()
                    j = 0
                End If
                Call Ris_siscoord()
                j = 0
                Call otrisovka_zagotovki()
                j = 0
            Next
            l = lloc
        Catch ex As Exception
            Me.ListBox5.Items.Add(p & "  " & "Произошла ошибка")
            p = p + 1
        End Try

    End Sub
    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Button14.Click
        Dim sli1 As Integer
        crcell = DataGridView2.CurrentRow.Index
        Try
            If CheckBox5.Checked = False Then
                sli1 = sli
                If Vipuklost(ListBox3.SelectedIndex, crcell) = "Снаружи" Then
                    Vipuklost(ListBox3.SelectedIndex, crcell) = "Внутри"
                ElseIf Vipuklost(ListBox3.SelectedIndex, crcell) = "Внутри" Then
                    Vipuklost(ListBox3.SelectedIndex, crcell) = "Снаружи"
                End If
                ListBox3.Items.Insert(ListBox3.SelectedIndex, "тчк." & ListBox3.SelectedIndex & ":  " & Vipuklost(ListBox3.SelectedIndex, crcell))
                ListBox3.Items.RemoveAt(ListBox3.SelectedIndex)

                ' MsgBox(sli)
                ListBox3.SelectedIndex = sli1
            ElseIf CheckBox5.Checked = True Then
                If element(Me.ListBox3.SelectedIndex, 0, l) = "Дуга" Then
                    'Call raschet_kontochek_otrezkov_mod2()
                    ' Call otrisovka_taertorii_instr()
                End If
            End If

        Catch ex1 As Exception
            Me.ListBox5.Items.Add(ex1.Message)
            p = p + 1
            Dim stacktr As New StackTrace(ex1, True)
            If stacktr.FrameCount > 0 Then
                Dim stackfr As New StackFrame
                stackfr = stacktr.GetFrame(0)
                Dim errorline As Integer = stackfr.GetFileLineNumber()
                Dim functionname As String = stackfr.GetMethod().Name
                Me.ListBox5.Items.Add("Ошибка в " & functionname & " на линии" & errorline)
                p = p + 1
                Me.ListBox5.Items.Add(ex1.Message)
                p = p + 1
            End If
        End Try
        ' End If
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Try
            l = crcell
            lloc = l
            For i = 0 To 19
                For l = 0 To 14
                    If Convert.ToString(DataGridView1.Rows(i).Cells(1).Value) = Instr(l) Then
                        Tinst(l) = Convert.ToInt32(DataGridView1.Rows(i).Cells(0).Value)
                        Me.ListBox5.Items.Add(p & (Instr(l) & "  D=" & Dinst(l) & "  T=" & Tinst(l)))
                        p = p + 1
                        ' MsgBox(Instr(l) & "  D=" & Dinst(l) & "  T=" & Tinst(l))
                    End If
                Next
            Next
            l = lloc
            i = 0
        Catch ex As Exception
            Me.ListBox5.Items.Add(p & "  " & "Сбой сохранения")
            p = p + 1
        End Try
    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles TextBox3.TextChanged


        Try
            If TextBox3.Text = Nothing Then
                TextBox3.Text = "0"
            End If
            TextBox3.BackColor = Drawing.Color.White
            'TextBoxnpl.Text = "9"
            'TextBoxdeltaniz.Text = "0"
            'TextBoxdletaverh.Text = "0"
            If TextBoxviskon.Text Is Nothing Or TextBoxviskon.Text = "" Then
                TextBoxviskon.Text = "0"
            End If

            TextBoxplbez.Text = Convert.ToString(TextBox3.Text + 50)
            TextBoxvpl.Text = Convert.ToString(TextBox3.Text - 0.5)
            TextBoxnpl.Text = Convert.ToString(Single.Parse(TextBoxvpl.Text) - Single.Parse(TextBoxviskon.Text))
            TextBoxbzrast.Text = Convert.ToString(TextBoxvpl.Text + 1)
            'Dim ch1 As Double = Convert.ToDouble(TextBoxvpl.Text)
            'Dim ch2 As Double = Convert.ToDouble(TextBoxviskon.Text)
            'TextBoxnpl.Text = Convert.ToString(ch1 - ch2)
        Catch ex As Exception
            Me.ListBox5.Items.Add(p & "  " & ex.Message)
            p = p + 1
            Me.ListBox5.Items.Add(p & "  " & "введите число, знак '.' недопустим")
            p = p + 1
            TextBox3.BackColor = Drawing.Color.Yellow
        End Try

    End Sub

    Private Sub TextBoxviskon_TextChanged(sender As Object, e As EventArgs) Handles TextBoxviskon.TextChanged
        Try
            If TextBoxviskon.Text Is Nothing Or TextBoxviskon.Text = "" Then
                TextBoxviskon.Text = "0"
            End If
            If TextBoxvpl.Text Is Nothing Or TextBoxvpl.Text = "" Then
                TextBoxvpl.Text = "0"
            End If
            TextBoxviskon.BackColor = Drawing.Color.White
            TextBoxnpl.Text = Convert.ToString(Single.Parse(TextBoxvpl.Text) - Single.Parse(TextBoxviskon.Text))

        Catch ex1 As Exception

            Dim stacktr As New StackTrace(ex1, True)
            If stacktr.FrameCount > 0 Then
                Dim stackfr As New StackFrame
                stackfr = stacktr.GetFrame(0)
                Dim errorline As Integer = stackfr.GetFileLineNumber()
                Dim functionname As String = stackfr.GetMethod().Name
                ListBox5.Items.Add("Ошибка в " & functionname & " на линии" & errorline)
                p = p + 1
                ListBox5.Items.Add(ex1.Message)
                p = p + 1
            End If
            TextBoxviskon.BackColor = Drawing.Color.Yellow
        End Try

    End Sub



    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim SFD As New FolderBrowserDialog ' создаем новый экземпляр  FolderBrowserDialog с именем SFD
        If SFD.ShowDialog = Windows.Forms.DialogResult.OK Then ' если была выбрана папка в диалоговом окне
            TextBox10.Text = SFD.SelectedPath ' присваиваем textbox1 выбранный путь
        End If
    End Sub

    Private Sub Button12_Click_1(sender As Object, e As EventArgs) Handles Button12.Click
        Dim stroka As String
        Dim strokaispr As String
        crcell = DataGridView2.CurrentCell.RowIndex
        With ListBox2.Items
            .Add("M30")
            .Add("%")
        End With
        If TextBox10.Text <> "" And TextBox11.Text <> "" Then 'проверяем, не пустые ли textbox1.text и textbox2.text
            Try ' отлавливаем исключение, в случае, если, к примеру, не будет прав на запись в выбранный каталог
                'IO.File.WriteAllText(ListBox2.Container, System.Text.Encoding.Default) ' записываем содержимое textbox3.text  по заданному пути
                Dim writer As New System.IO.StreamWriter(TextBox10.Text & "\" & TextBox11.Text)
                For i = 0 To ListBox2.Items.Count - 1
                    stroka = Convert.ToString(ListBox2.Items(i))
                    strokaispr = stroka.Replace(",", ".")
                    writer.WriteLine(Convert.ToString(strokaispr))
                Next
                writer.Close()
            Catch ex As Exception
                Me.ListBox5.Items.Add(p & "  " & ex.Message) ' сообщение, в случае ошибки
                p = p + 1
            End Try
        Else
            Exit Sub ' если textbox1 или textbox2 пустой, то ничего не делаем
        End If
        ' writer.writealltest()
        ' writer.Close()
        Process.Start("notepad.exe", TextBox10.Text & "\" & TextBox11.Text) ' запускаем файл именно в блокноте
        ' IO.File.Delete(filepath) ' убиваем временный файл. То, что он открыт в блокноте, нам не помешает
    End Sub

    Private Sub ListBox3_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox3.SelectedIndexChanged

        sli = ListBox3.SelectedIndex
        Try
            sli = ListBox3.SelectedIndex

            PictureBox1.Image = Nothing
            PictureBox1.Refresh()
            '  Kontour = PictureBox1.CreateGraphics
            ' Sdvg = 15 * Math.Pow(1.2, TrackBar1.Value / (TrackBar1.Maximum)) + Sqrt(xprip ^ 2 + yprip ^ 2)
            'Sdvg = 10 * scalesdvg + Sqrt(xprip ^ 2 + yprip ^ 2)
            'Kontour.ScaleTransform(scale, scale)
            j = 0
            pen1 = New Pen(Brushes.Black, 0.5)
            pen2 = New Pen(Brushes.Red, 1)
            pen3 = New Pen(Brushes.Green, 1)
            pen4 = New Pen(Brushes.Red, 0.7)
            pen4.DashStyle = Drawing2D.DashStyle.Solid
            pen5 = New Pen(Brushes.Blue, 0.5)
            pen6 = New Pen(Brushes.DarkGreen, 0.7)
            crcell = DataGridView2.CurrentCell.RowIndex
            lloc = l
            For l = 0 To crcell
                'kolvo = kolvoobsh(l)
                j = 0
                If CheckBox4.Checked = False Then
                    'Call otrisovka_vsego_mod()
                    j = 0
                    Call otrisovka_vsego_mod_2()
                    j = 0
                Else
                    'Call otrisovka_vsego_mod_3()
                    j = 0
                End If
                Call Ris_siscoord()
                j = 0
                Call otrisovka_zagotovki()
                j = 0
            Next
            If TextBoxperfrez.Text = Nothing Then
                MsgBox("Заполните необходимые поля")

                TextBoxperfrez.BackColor = Drawing.Color.Yellow
                Return
            End If
            TextBoxperfrez.BackColor = Drawing.Color.White
            per = TextBoxperfrez.Text * 0.02

            If CheckBoxviborka.Checked = True Then
                'MsgBox("zazor=" & zazormax)
                kpobsh(DataGridView2.CurrentCell.RowIndex) = Math.Ceiling((zazormax - Dfrez(ni) / 2 - prip) / (per * Dfrez(ni) / 2))
                If kpobsh(DataGridView2.CurrentCell.RowIndex) <= 0 Then
                    kpobsh(DataGridView2.CurrentCell.RowIndex) = 1
                End If
            Else
                kpobsh(DataGridView2.CurrentCell.RowIndex) = 1
            End If
            kp = kpobsh(DataGridView2.CurrentCell.RowIndex)
            prip = Convert.ToSingle(Me.TextBoxprip.Text)
            If crcell = 0 Then
                ReDim XobshrisN(50, 40, 15)
                ReDim YobshrisN(50, 40, 15)
                ReDim XobshrisK(50, 40, 15)
                ReDim YobshrisK(50, 40, 15)
                ReDim Robshris(50, 40, 15)
                ReDim pervoeprevishenie(50, 40, 15)
                ReDim XdcncN(50, 40)
                ReDim XdcncK(50, 40)
                ReDim YdcncNris(50, 40)
                ReDim YdcncKris(50, 40)
                ReDim temp(50, 40)
                'контакт отрезков
                ReDim XtchkontN1(50)
                ReDim YtchkontN1(50)
                ReDim XtchkontK1(50)
                ReDim YtchkontK1(50)
                ReDim XtchkontK2(50)
                ReDim YtchkontK2(50)
                ReDim Xtchkonttr(50, 40)
                ReDim Ytchkonttr(50, 40)
                ReDim gamma(50)
                ReDim delta(50)
                ReDim tau(50)

                ReDim GcodeXN(50, 40, 15)
                ReDim GcodeXK(50, 40, 15)
                ReDim GcodeYN(50, 40, 15)
                ReDim GcodeYK(50, 40, 15)
                ReDim GcodeR(50, 40, 15)
            End If
            crcell = DataGridView2.CurrentCell.RowIndex

            lloc = l
            l = crcell
            kp = kpobsh(l)
            k = 0
            Call rachet_traectorii_mod_3()
            k = 0
            Call New_ris_traect()
            k = 0
            Instr(l) = Convert.ToString(ListBox1.SelectedItem)
            Dinst(l) = Dfrez(ni)
            l = lloc
            i = ListBox3.SelectedIndex
            If i >= 0 Then

                Kontour.DrawEllipse(pen6, XobshotnN(i, crcell) - 5 + Sdvg, YobshotnN(i, crcell) - 5 + Sdvg, 10, 10)
                l = lloc
            End If
            i = 0
        Catch ex1 As Exception
            Me.ListBox5.Items.Add(ex1.Message)
            p = p + 1
            Dim stacktr As New StackTrace(ex1, True)
            If stacktr.FrameCount > 0 Then
                Dim stackfr As New StackFrame
                stackfr = stacktr.GetFrame(0)
                Dim errorline As Integer = stackfr.GetFileLineNumber()
                Dim functionname As String = stackfr.GetMethod().Name
                Me.ListBox5.Items.Add("Ошибка в " & functionname & " на линии" & errorline)
                p = p + 1
                Me.ListBox5.Items.Add(ex1.Message)
                p = p + 1
            End If
        End Try
    End Sub

    Private Sub TextBox13_TextChanged(sender As Object, e As EventArgs) Handles TextBoxkolvopr.TextChanged
        If CheckBoxviborka.Checked = True And RadioButton21.Checked = True Then
            Try
                kpobsh(DataGridView2.CurrentCell.RowIndex) = Convert.ToInt32(TextBoxkolvopr.Text)
                TextBoxkolvopr.BackColor = Drawing.Color.White
            Catch ex As Exception
                TextBoxkolvopr.BackColor = Drawing.Color.Yellow
                Me.ListBox5.Items.Add(p & "  " & "Введите количество проходов")
                p = p + 1
            End Try
        Else
            kpobsh(DataGridView2.CurrentCell.RowIndex) = 1
        End If
        kp = kpobsh(DataGridView2.CurrentCell.RowIndex)
    End Sub

    Private Sub CheckBox3_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBoxviborka.CheckedChanged
        If CheckBoxviborka.Checked = True Then
            RadioButton20.Enabled = True
            RadioButton21.Enabled = True
            TextBoxkolvopr.Enabled = True
            TextBoxkolvopr.Text = 1
        Else
            RadioButton20.Enabled = False
            RadioButton21.Enabled = False
            TextBoxkolvopr.Enabled = False
            TextBoxkolvopr.Text = 1
        End If
    End Sub

    Private Sub RadioButton20_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton20.CheckedChanged
        If RadioButton20.Checked = True Then
            RadioButton20.Enabled = True

            TextBoxkolvopr.Enabled = True
        Else

            RadioButton21.Enabled = True
            TextBoxkolvopr.Enabled = True
        End If
    End Sub

    Private Sub Button15_Click(sender As Object, e As EventArgs)

        Try
            nadocheck = False
            For k = 0 To ListBox3.Items.Count - 1

                Vipuklost(k, l - 1) = "Внутри"
                'ListBox3.Items.Insert(k, "тчк." & k & ":  " & Vipuklost(k, l - 1))
                ListBox3.Items.RemoveAt(k)
            Next
        Catch ex As Exception
            Me.ListBox5.Items.Add(p & "  " & "Сбой")
            p = p + 1
        End Try
        k = 0
        nadocheck = True
    End Sub

    Private Sub Button16_Click(sender As Object, e As EventArgs)
        Try
            For i = 0 To ListBox3.Items.Count - 1


                Vipuklost(i, l) = "Снаружи"
                ListBox3.Items(i) = "тчк." & i & ":  " & Vipuklost(i, l - 1)
            Next
        Catch ex As Exception
            Me.ListBox5.Items.Add(p & "  " & ex.Message)
            p = p + 1
        End Try
        i = 0
    End Sub

    Private Sub CheckBox4_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox4.CheckedChanged
        Try
            ListBox4.Items.Clear()
            If CheckBox4.Checked = True Then
                ListBox4.Enabled = True
                With ListBox4.Items
                    .Add("i =" & i)
                    .Add("j =" & j)
                    .Add("k =" & k)
                    .Add("l =" & l)
                    .Add("lloc =" & lloc)
                    .Add("kp =" & kp)
                    .Add("kpobsh(l) =" & kpobsh(l))
                    .Add("ni =" & ni)
                    .Add("Tinst() =" & Tinst(l - 1))
                    .Add("Инструмент: " & Instr(l - 1))
                End With
            Else
                ListBox4.Enabled = False
            End If
        Catch ex As Exception
            Me.ListBox5.Items.Add(p & "  " & ex.Message)
            p = p + 1
        End Try
    End Sub

    Private Sub ListBox4_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox4.SelectedIndexChanged

    End Sub

    Private Sub RadioButton23_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton23.CheckedChanged
        _invApp = Marshal.GetActiveObject("Inventor.Application")
        Dim otrans As Transaction
        otrans = _invApp.TransactionManager.StartTransaction(_invApp.ActiveDocument, "выбор контура")
        If RadioButton23.Checked = True Then
            If MsgBox("При переключении на режим эскиза требуется сразу выбрать нужные элементы. Продолжить?", vbYesNo, "Режим эскиза") = vbYes Then
                Try
                    ViborKontura.Enabled = False
                    Call PickEskiz()
                Catch ex1 As Exception
                    Dim stacktr As New StackTrace(ex1, True)
                    If stacktr.FrameCount > 0 Then
                        Dim stackfr As New StackFrame
                        stackfr = stacktr.GetFrame(0)
                        Dim errorline As Integer = stackfr.GetFileLineNumber()
                        Dim functionname As String = stackfr.GetMethod().Name
                        Me.ListBox5.Items.Add("Ошибка в " & functionname & " на линии" & errorline)
                        p = p + 1
                        Me.ListBox5.Items.Add(ex1.Message)
                        p = p + 1
                    End If
                End Try

            Else
                RadioButton23.Checked = False
                Exit Sub
            End If
            RadioButton23.Checked = False
            RadioButton22.Checked = True
            ViborKontura.Enabled = True

        End If

        otrans.End()
    End Sub


    Private Sub ЭкспортВGcodeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ЭкспортВGcodeToolStripMenuItem.Click
        Try
            Dim SFD As New FolderBrowserDialog ' создаем новый экземпляр  FolderBrowserDialog с именем SFD
            Dim sfd1 As New SaveFileDialog 'With {.Filter = ".txt"}
            Dim stroka As String
            Dim strokaispr As String
            Dim lmes As Integer = 0
            Dim writer As System.IO.StreamWriter
            Try
                sfd1.Title = "Пожалуйста, выберите проект"
                If sfd1.ShowDialog = Windows.Forms.DialogResult.OK Then ' если была выбрана папка в диалоговом окне

                    prjname = sfd1.FileName
                    If prjname.Contains("mt2prj") = True Then
                        writer = New System.IO.StreamWriter(prjname)
                    Else
                        writer = New System.IO.StreamWriter(prjname & ".mt2prj")
                    End If
                End If
                'Dim writer As New System.IO.StreamWriter(prjname & ".mt2prj")
                'For i = 0 To ListBox2.Items.Count - 1
                'stroka = Convert.ToString(ListBox2.Items(i))
                'strokaispr = stroka.Replace(",", ".")
                With writer
                    .WriteLine("TextBox1")
                    .WriteLine(TextBox1.Text)
                    .WriteLine("TextBox2")
                    .WriteLine(TextBox2.Text)
                    .WriteLine("TextBox3")
                    .WriteLine(TextBox3.Text)
                    .WriteLine("TextBoxXASK")
                    .WriteLine(TextBoxXASK.Text)
                    .WriteLine("TextBoxYASK")
                    .WriteLine(TextBoxYASK.Text)
                    .WriteLine("Xcoord")
                    .WriteLine(Xcoord)
                    .WriteLine("Ycoord")
                    .WriteLine(Ycoord)
                    .WriteLine("Xmaxloc")
                    .WriteLine(Xmaxloc(0))
                    .WriteLine("Xminloc")
                    .WriteLine(Xminloc(0))
                    .WriteLine("Ymaxloc")
                    .WriteLine(Ymaxloc(0))
                    .WriteLine("Yminloc")
                    .WriteLine(Yminloc(0))
                End With
                While lmes <= 14
                    If DataGridView2.Rows(lmes).Cells(0).Value <> "" Then
                        'crcell = DataGridView2.CurrentCell.RowIndex
                        With writer
                            .WriteLine("ViborRB(" & lmes & ")")
                            .WriteLine(viborRB(lmes))
                            .WriteLine("kolvo(0, " & lmes & ")")
                            .WriteLine(kolvo(0, lmes))
                            .WriteLine("AutoSK(" & lmes & ")")
                            .WriteLine(Convert.ToByte(AutoSK(lmes)))
                            .WriteLine("ch_podvod(" & lmes & ")")
                            .WriteLine(Convert.ToByte(ch_podvod(lmes)))
                            .WriteLine("ch_viborka(" & lmes & ")")
                            .WriteLine(Convert.ToByte(ch_viborka(lmes)))
                            .WriteLine("ch_auto(" & lmes & ")")
                            .WriteLine(Convert.ToByte(ch_auto(lmes)))
                            .WriteLine("ch_vkl(" & lmes & ")")
                            .WriteLine(Convert.ToByte(ch_vkl(lmes)))
                            .WriteLine("rb_auto20(" & lmes & ")")
                            .WriteLine(Convert.ToByte(rb_auto20(lmes)))
                            .WriteLine("rb_hand21(" & lmes & ")")
                            .WriteLine(Convert.ToByte(rb_hand21(lmes)))


                        End With
                        For i = 0 To kolvo(0, lmes) - 1
                            With writer
                                .WriteLine("element(" & i & ", 0, " & lmes & ")")
                                .WriteLine(element(i, 0, lmes))
                                .WriteLine("XabsobshN(" & i & ", " & lmes & ")")
                                .WriteLine(XabsobshN(i, lmes))
                                .WriteLine("XabsobshK(" & i & ", " & lmes & ")")
                                .WriteLine(XabsobshK(i, lmes))
                                .WriteLine("YabsobshN(" & i & ", " & lmes & ")")
                                .WriteLine(YabsobshN(i, lmes))
                                .WriteLine("YabsobshK(" & i & ", " & lmes & ")")
                                .WriteLine(YabsobshK(i, lmes))
                                .WriteLine("XabsobshC(" & i & ", " & lmes & ")")
                                .WriteLine(XabsobshC(i, lmes))
                                .WriteLine("YabsobshC(" & i & ", " & lmes & ")")
                                .WriteLine(YabsobshC(i, lmes))
                                .WriteLine("XabsobshM(" & i & ", " & lmes & ")")
                                .WriteLine(XabsobshM(i, lmes))
                                .WriteLine("YabsobshM(" & i & ", " & lmes & ")")
                                .WriteLine(YabsobshM(i, lmes))
                                .WriteLine("Vipuklost(" & i & ", " & lmes & ")")
                                .WriteLine(Vipuklost(i, lmes))
                                .WriteLine("diamokr(" & i & ", " & lmes & ")")
                                .WriteLine(diamokr(i, lmes))

                            End With
                        Next
                        i = 0
                    Else
                        Exit While
                    End If
                    For i = 0 To 22
                        writer.WriteLine("vr_dannie(" & i & ", " & lmes & ")")
                        writer.WriteLine(vr_dannie(i, lmes))
                    Next
                    lmes = lmes + 1
                End While

                writer.Close()
            Catch ex As Exception
                Me.ListBox5.Items.Add(p & "  " & ex.Message) ' сообщение, в случае ошибки
                p = p + 1
            End Try
            If prjname.Contains("mt2prj") = True Then
                Process.Start("notepad.exe", prjname)
            Else
                Process.Start("notepad.exe", prjname & ".mt2prj")
            End If
            'Process.Start("notepad.exe", prjname) ' запускаем файл именно в блокноте
            'IO.File.Delete(prjname & ".mt2prj") ' убиваем временный файл. То, что он открыт в блокноте, нам не помешает
        Catch ex As Exception
            ListBox5.Items.Add(p & "Ошибка при записи в файл")
            p = p + 1
        End Try
    End Sub




    Private Sub Button18_Click(sender As Object, e As EventArgs) Handles Button18.Click
        Try
            AutoSK(l) = False
            'Inbx(l) = InputBox("Введите количество элементов эскиза")
            Call PickXY()
            'otrans = _invApp.TransactionManager.StartTransaction(_invApp.ActiveDocument, "выбор контура")


        Catch ex1 As Exception

            Dim stacktr As New StackTrace(ex1, True)
            If stacktr.FrameCount > 0 Then
                Dim stackfr As New StackFrame
                stackfr = stacktr.GetFrame(0)
                Dim errorline As Integer = stackfr.GetFileLineNumber()
                Dim functionname As String = stackfr.GetMethod().Name
                Me.ListBox5.Items.Add(p & "Ошибка в " & functionname & " на линии" & errorline)
                p = p + 1
                Me.ListBox5.Items.Add(p & ex1.Message)
                p = p + 1
            End If
        End Try
    End Sub

    Private Sub RadioButton18_CheckedChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub RadioButton17_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton17.CheckedChanged
        If RadioButton17.Checked = False Then
            'Label2.Enabled = True
            Label2.Text = "Длина, мм Х:"
            Label3.Visible = True
            TextBox2.Enabled = True
        Else
            'Label2.Enabled = True

            Label2.Text = "Диаметр, мм:"
            Label3.Visible = False
            TextBox2.Enabled = False
        End If
    End Sub



    Private Sub Button17_Click(sender As Object, e As EventArgs)
        If DataGridView2.CurrentCell.RowIndex > 0 Then
            Dim curval As String = DataGridView2.CurrentCell.Value.ToString()
            Dim rowindex1 As Integer = DataGridView2.CurrentCell.RowIndex
            DataGridView2.Rows.RemoveAt(rowindex1)
            DataGridView2.Rows.Insert(rowindex1 + 1, curval)
            DataGridView2.ClearSelection()
            DataGridView2.Rows(rowindex1 + 1).Cells(0).Selected = True


        End If
    End Sub



    Private Sub RadioButton26_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton26.CheckedChanged
        If RadioButton26.Checked = True Then

            RadioButton18.Checked = False
            Call raschet_rej_rez()
            TextBoxVrez.Enabled = False
            TextBoxSrez.Enabled = False
            TextBoxVrez.Text = Vlabel(ListBox1.SelectedIndex)
            TextBoxSrez.Text = Slabel(ListBox1.SelectedIndex)
        Else
            Call raschet_rej_rez()
            TextBoxVrez.Enabled = True
            TextBoxSrez.Enabled = True
        End If
    End Sub

    Private Sub TextBox14_TextChanged(sender As Object, e As EventArgs) Handles TextBoxVrez.TextChanged
        Try

            TextBoxVrez.BackColor = Drawing.Color.White
            Call raschet_rej_rez()
        Catch ex As Exception
            'MsgBox("V")
            TextBoxVrez.BackColor = Drawing.Color.Yellow
            ListBox5.Items.Add(p & "  V:" & ex.Message)
            p = p + 1
        End Try
    End Sub

    Private Sub TextBox15_TextChanged(sender As Object, e As EventArgs) Handles TextBoxSrez.TextChanged
        Try
            TextBoxSrez.BackColor = Drawing.Color.White
            Call raschet_rej_rez()
        Catch ex As Exception
            TextBoxSrez.BackColor = Drawing.Color.Yellow
            ListBox5.Items.Add(p & "  S:" & ex.Message)
            p = p + 1
        End Try
    End Sub

    Private Sub Button19_Click(sender As Object, e As EventArgs) Handles Button19.Click
        Try
            crcell = DataGridView2.CurrentCell.RowIndex

            vr_dannie(0, crcell) = Single.Parse(TextBoxprip.Text)
            vr_dannie(1, crcell) = Single.Parse(TextBoxpdchvert.Text)
            vr_dannie(2, crcell) = Single.Parse(TextBoxobchern.Text)
            vr_dannie(3, crcell) = Single.Parse(TextBoxobchern.Text)
            vr_dannie(4, crcell) = Single.Parse(TextBoxperfrez.Text)
            vr_dannie(11, crcell) = Single.Parse(TextBoxviskon.Text)
            vr_dannie(12, crcell) = Single.Parse(TextBoxplbez.Text)
            vr_dannie(13, crcell) = Single.Parse(TextBoxbzrast.Text)
            vr_dannie(14, crcell) = Single.Parse(TextBoxvpl.Text)
            vr_dannie(15, crcell) = Single.Parse(TextBoxnpl.Text)
            vr_dannie(16, crcell) = Single.Parse(TextBoxmaxZ.Text)
            vr_dannie(19, crcell) = ListBox1.SelectedIndex

            If Form2.CheckBoxvkpodv.Checked = True Then
                ch_podvod(crcell) = True
                vr_dannie(9, crcell) = Single.Parse(Form2.TextBoxdlpodv.Text)
                vr_dannie(10, crcell) = Single.Parse(Form2.TextBoxugolzag.Text)
            Else
                ch_podvod(crcell) = False

            End If
            If CheckBoxviborka.Checked = True Then
                ch_viborka(crcell) = True
                If RadioButton20.Checked = True Then
                    rb_auto20(crcell) = True
                    rb_hand21(crcell) = False
                    vr_dannie(8, crcell) = TextBoxkolvopr.Text
                ElseIf RadioButton21.Checked = True Then
                    rb_auto20(crcell) = False
                    rb_hand21(crcell) = True
                    vr_dannie(8, crcell) = TextBoxkolvopr.Text
                End If
            Else
                ch_viborka(crcell) = False
                rb_auto20(crcell) = False
                rb_hand21(crcell) = False
            End If
            If Single.Parse(TextBoxLvil.Text) < Single.Parse(TextBoxviskon.Text) Then
                MsgBox("ВНИМАНИЕ: Высота контура превышает вылет инструмента")
                'TabControl1.TabPages(1).Show()
                TextBoxviskon.BackColor = Drawing.Color.Red
                Exit Sub
            ElseIf (TextBoxLrch.Text) < Single.Parse(TextBoxviskon.Text) Then
                MsgBox("ВНИМАНИЕ: Высота контура превышает высоту рабочей части инструмента")
            End If
            If viborRB(crcell) = "Otverstie" Then
                If ListBox1.SelectedIndex = 0 Or (ListBox1.SelectedIndex >= 8 And ListBox1.SelectedIndex <= 13) Then
                    If diamokr(j, crcell) < Dsv(ni) And ListBox1.SelectedIndex <> 0 Then
                        If MsgBox("Диаметр сверла превышает диаметр отверстия. Выбрать другое сверло?", vbYesNo, "Внимание!") = vbYes Then
                            TabControl1.TabPages(1).Show()
                            TextBoxDsv.BackColor = Drawing.Color.Yellow
                            Exit Sub
                        End If
                    End If
                ElseIf ListBox1.SelectedIndex >= 3 And ListBox1.SelectedIndex <= 6 Then
                    If diamokr(j, l) <= Dfrez(ni) Then
                        MsgBox("ВНИМАНИЕ: Диаметр фрезы превышает диаметр отверстия")
                        TabControl1.TabPages(1).Show()
                        TextBoxDkf.BackColor = Drawing.Color.Red
                        Exit Sub
                    End If
                End If
            End If
        Catch ex1 As Exception

            Dim stacktr As New StackTrace(ex1, True)
            If stacktr.FrameCount > 0 Then
                Dim stackfr As New StackFrame
                stackfr = stacktr.GetFrame(0)
                Dim errorline As Integer = stackfr.GetFileLineNumber()
                Dim functionname As String = stackfr.GetMethod().Name
                Me.ListBox5.Items.Add(p & "Ошибка в " & functionname & " на линии" & errorline)
                p = p + 1
                Me.ListBox5.Items.Add(p & ex1.Message)
                p = p + 1
            End If
        End Try

    End Sub

    Private Sub DataGridView2_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView2.CellContentClick
        ' Dim crcell As Integer
        crcell = DataGridView2.CurrentCell.RowIndex
        ' ListBox5.Items.Add(DataGridView2.CurrentCell.RowIndex)

        If vr_dannie(0, crcell) <> 0 Then
            TextBoxprip.Text = vr_dannie(0, crcell)
            ListBox1.SetSelected(vr_dannie(19, crcell), True)
        End If
        If vr_dannie(1, crcell) <> 0 Then
            TextBoxpdchvert.Text = vr_dannie(1, crcell)
        End If
        If vr_dannie(2, crcell) <> 0 Then
            TextBoxobchern.Text = vr_dannie(2, crcell)
        End If
        If vr_dannie(3, crcell) <> 0 Then
            TextBoxpodchist.Text = vr_dannie(3, crcell)
        End If
        If vr_dannie(4, crcell) <> 0 Then
            TextBoxperfrez.Text = vr_dannie(4, crcell)
        End If
        If vr_dannie(9, crcell) <> 0 Then
            Form2.TextBoxdlpodv.Text = vr_dannie(9, crcell)
        End If
        If vr_dannie(10, crcell) <> 0 Then
            Form2.TextBoxugolzag.Text = vr_dannie(10, crcell)
        End If
        If vr_dannie(11, crcell) <> 0 Then
            TextBoxviskon.Text = vr_dannie(11, crcell)
        End If
        If vr_dannie(12, crcell) <> 0 Then
            TextBoxplbez.Text = vr_dannie(12, crcell)
        End If
        If vr_dannie(13, crcell) <> 0 Then
            TextBoxbzrast.Text = vr_dannie(13, crcell)
        End If
        If vr_dannie(14, crcell) <> 0 Then
            TextBoxvpl.Text = vr_dannie(14, crcell)
        End If
        If vr_dannie(15, crcell) <> 0 Then
            TextBoxnpl.Text = vr_dannie(15, crcell)
        End If
        If vr_dannie(16, crcell) <> 0 Then
            TextBoxmaxZ.Text = vr_dannie(16, crcell)
        End If
        If vr_dannie(20, crcell) <> 0 Or vr_dannie(21, crcell) <> 0 Then
            Form2.TextBoxXvhod.Text = vr_dannie(20, crcell)
            Form2.TextBoxYvhod.Text = vr_dannie(21, crcell)
        End If
        If ch_podvod(crcell) = True Then
            Form2.CheckBoxvkpodv.Checked = True
        Else
            Form2.CheckBoxvkpodv.Checked = False

        End If
        If ch_viborka(crcell) = True Then
            CheckBoxviborka.Checked = True
        Else
            CheckBoxviborka.Checked = False
        End If

        If ch_viborka(crcell) = True Then
            CheckBoxviborka.Checked = True
            If rb_auto20(crcell) = True Then
                RadioButton20.Checked = True
                RadioButton21.Checked = False
                TextBoxkolvopr.Text = vr_dannie(8, crcell)
            ElseIf rb_hand21(crcell) = True Then
                RadioButton20.Checked = False
                RadioButton21.Checked = True
                TextBoxkolvopr.Text = vr_dannie(8, crcell)
            End If
        Else
            CheckBoxviborka.Checked = False
            RadioButton20.Checked = False
            RadioButton21.Checked = False
        End If

        Try
            TextBox11.Text = viborRB(crcell) & Convert.ToString(crcell + 1)
        Catch ex As Exception
            Exit Try
        End Try

    End Sub

    Private Sub RadioButton19_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton19.CheckedChanged
        If RadioButton19.Checked = True Then
            TextBoxviskon.Text = "0"
        End If
    End Sub

    Private Sub Button17_Click_1(sender As Object, e As EventArgs) Handles Button17.Click
        Form2.Show()
        crcell = DataGridView2.CurrentCell.RowIndex
        If ch_podvod(crcell) = True Then
            Form2.CheckBoxvkpodv.Checked = True
        Else
            Form2.CheckBoxvkpodv.Checked = False
            Form2.TextBoxdlpodv.Enabled = False
            Form2.TextBoxugolzag.Enabled = False
        End If
    End Sub

    Private Sub TextBoxvpl_TextChanged(sender As Object, e As EventArgs) Handles TextBoxvpl.TextChanged
        Try
            If TextBoxvpl.Text Is Nothing Then
                TextBoxvpl.Text = "0"
            End If
            TextBoxvpl.BackColor = Drawing.Color.White
            TextBoxnpl.Text = Convert.ToString(Single.Parse(TextBoxvpl.Text) - Single.Parse(TextBoxviskon.Text))
            TextBoxbzrast.Text = Convert.ToString(TextBoxvpl.Text + 1)

        Catch ex1 As Exception

            Dim stacktr As New StackTrace(ex1, True)
            If stacktr.FrameCount > 0 Then
                Dim stackfr As New StackFrame
                stackfr = stacktr.GetFrame(0)
                Dim errorline As Integer = stackfr.GetFileLineNumber()
                Dim functionname As String = stackfr.GetMethod().Name
                ListBox5.Items.Add("Ошибка в " & functionname & " на линии" & errorline)
                p = p + 1
                ListBox5.Items.Add(ex1.Message)
                p = p + 1
            End If
            TextBoxvpl.BackColor = Drawing.Color.Yellow
        End Try
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        Try
            TextBox1.BackColor = Drawing.Color.White
            If RadioButton17.Checked = True Then
                TextBox2.Text = TextBox1.Text
            End If
        Catch ex1 As Exception

            Dim stacktr As New StackTrace(ex1, True)
        If stacktr.FrameCount > 0 Then
            Dim stackfr As New StackFrame
            stackfr = stacktr.GetFrame(0)
            Dim errorline As Integer = stackfr.GetFileLineNumber()
            Dim functionname As String = stackfr.GetMethod().Name
            ListBox5.Items.Add("Ошибка в " & functionname & " на линии" & errorline)
            p = p + 1
            ListBox5.Items.Add(ex1.Message)
            p = p + 1
        End If
            TextBox1.BackColor = Drawing.Color.Yellow
        End Try
    End Sub

    Private Sub CheckBoxchist_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBoxchist.CheckedChanged
        If CheckBoxchist.Checked = True Then
            CheckBoxchern.Checked = False
            TextBoxprip.Text = "0"
            CheckBoxviborka.Checked = False
        Else
            CheckBoxchern.Checked = True
            TextBoxprip.Text = "0,2"
        End If
    End Sub

    Private Sub Label41_Click(sender As Object, e As EventArgs) Handles Label41.Click

    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub TrackBar2_Scroll(sender As Object, e As EventArgs) Handles TrackBar2.Scroll
        PictureBox1.Image = Nothing
        Dim maxscale As Single = 5000
        Dim minscale As Single = 1
        scalesdvg = Math.Pow(20, TrackBar2.Value / (TrackBar2.Maximum))
        ' TextBox1.Text = scalesdvg
    End Sub

    Private Sub TrackBar2_MouseUp(sender As Object, e As MouseEventArgs) Handles TrackBar2.MouseUp
        Try
            Sdvg = 10 * scalesdvg + Sqrt(xprip ^ 2 + yprip ^ 2)
            ' Kontour.ScaleTransform(scale, scale)
            j = 0
            pen1 = New Pen(Brushes.Black, 0.5)
            pen2 = New Pen(Brushes.Red, 1)
            pen3 = New Pen(Brushes.Green, 1)
            pen4 = New Pen(Brushes.Red, 0.7)
            pen4.DashStyle = Drawing2D.DashStyle.Solid
            pen5 = New Pen(Brushes.Blue, 0.5)
            For l = 0 To crcell
                'kolvo = kolvoobsh(l)
                j = 0
                If CheckBox4.Checked = False Then
                    'Call otrisovka_vsego_mod()
                    j = 0
                    Call otrisovka_vsego_mod_2()
                    j = 0
                Else
                    'Call otrisovka_vsego_mod_3()
                    j = 0
                End If
                Call Ris_siscoord()
                j = 0
                Call otrisovka_zagotovki()
                j = 0
            Next
            l = lloc
        Catch ex As Exception
            Me.ListBox5.Items.Add(p & "  " & "Произошла ошибка")
            p = p + 1
        End Try
    End Sub

    Private Sub RadioButton19_MouseHover(sender As Object, e As EventArgs) Handles RadioButton19.MouseHover
        Dim t As New ToolTip
        'Dim otime As Single
        If CheckBoxpoyasn.Checked = True Then
            Form3.PictureBox1.Image = MT2CAM.My.Resources.Resources.Ploskost1
            Form3.Show()
            i = 0
            Timer1.Enabled = True
            Timer1.Start()
        End If
    End Sub

    Private Sub RadioButton1_MouseHover(sender As Object, e As EventArgs) Handles RadioButton1.MouseHover
        Dim t As New ToolTip
        If CheckBoxpoyasn.Checked = True Then
            Form3.PictureBox1.Image = MT2CAM.My.Resources.Resources.vneshka1
            Form3.Show()
            i = 0
            Timer1.Enabled = True
            Timer1.Start()
        End If
    End Sub
    Private Sub RadioButton2_MouseHover(sender As Object, e As EventArgs) Handles RadioButton2.MouseHover
        Dim t As New ToolTip
        If CheckBoxpoyasn.Checked = True Then
            Form3.PictureBox1.Image = MT2CAM.My.Resources.Resources.vnutro1
            'Form3.Location = ptloc
            Form3.Show()
            i = 0
            Timer1.Enabled = True
            Timer1.Start()
        End If
    End Sub



    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        i = i + 1
        'MsgBox(i)
        If i > 10 Then
            Timer1.Stop()
            Form3.Close()
        End If

    End Sub

    Private Sub TextBoxmaxZ_TextChanged(sender As Object, e As EventArgs) Handles TextBoxmaxZ.TextChanged
        Try
            If TextBoxmaxZ.Text Is Nothing Then
                TextBoxmaxZ.Text = "1"
            End If
            TextBoxmaxZ.BackColor = Drawing.Color.White

        Catch ex1 As Exception

            Dim stacktr As New StackTrace(ex1, True)
            If stacktr.FrameCount > 0 Then
                Dim stackfr As New StackFrame
                stackfr = stacktr.GetFrame(0)
                Dim errorline As Integer = stackfr.GetFileLineNumber()
                Dim functionname As String = stackfr.GetMethod().Name
                ListBox5.Items.Add("Ошибка в " & functionname & " на линии" & errorline)
                p = p + 1
                ListBox5.Items.Add(ex1.Message)
                p = p + 1
            End If
            TextBoxmaxZ.BackColor = Drawing.Color.Yellow
        End Try
    End Sub

    Private Sub RadioButtonstil_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButtonstil.CheckedChanged
        If RadioButtonstil.Checked = True Then
            Nmax = 4000
        ElseIf RadioButtonalum.Checked = True Then
            Nmax = 7000
        End If
        ListBox1.SetSelected(ListBox1.SelectedIndex, True)
        Call raschet_rej_rez()
    End Sub

    Private Sub ОткрытьПроектToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ОткрытьПроектToolStripMenuItem.Click
        Try
            Dim ofd1 As New OpenFileDialog
            Dim st As String
            Dim lmes, g As Integer
            ofd1.Title = "Пожалуйста, выберите проект"
            If ofd1.ShowDialog = Windows.Forms.DialogResult.OK Then ' если была выбрана папка в диалоговом окне
                prjname = ofd1.FileName
            End If
            Dim sr As StreamReader = New StreamReader(prjname)
            Dim mstring() = IO.File.ReadAllLines(prjname)
            ReDim XabsN(50)
            ReDim YabsN(50)
            ReDim XabsK(50)
            ReDim YabsK(50)
            'ReDim elementponomeru(50)
            ReDim odc1pt(8)
            ReDim diamokr(50, 15)
            ReDim Xabsmid(50)
            ReDim Yabsmid(50)
            ReDim Yabscentr(50)
            ReDim Xabscentr(50)
            ReDim robsh(50)
            'ReDim dugaponomeru(50)

            ReDim Xpmmin(50)
            ReDim Ypmmin(50)
            ReDim Ypmmax(50)
            ReDim Xpmmax(50)

            ReDim a1(50)
            ReDim a2(50)
            ReDim alfa(50)
            ReDim betta(50)
            ReDim XotnN(50)
            ReDim YotnN(50)
            ReDim XotnK(50)
            ReDim YotnK(50)
            ReDim XotnC(50)
            ReDim YotnC(50)
            ReDim XotnS(50)
            ReDim YotnS(50)
            ReDim XobshotnS(50, 15)
            ReDim YobshotnS(50, 15)
            ReDim XobshotnN(50, 15)
            ReDim YobshotnN(50, 15)
            ReDim XobshotnK(50, 15)
            ReDim YobshotnK(50, 15)
            ReDim XotnobshC(50, 15)
            ReDim YotnobshC(50, 15)
            'абсолютные общие
            ReDim XabsobshN(50, 15)
            ReDim YabsobshN(50, 15)
            ReDim XabsobshK(50, 15)
            ReDim YabsobshK(50, 15)
            ReDim XabsobshM(50, 15)
            ReDim YabsobshM(50, 15)
            ReDim XabsobshC(50, 15)
            ReDim YabsobshC(50, 15)
            ReDim Xmaxloc(15)
            ReDim Xminloc(15)
            ReDim Ymaxloc(15)
            ReDim Yminloc(15)
            'относительные общие
            ReDim XobshotnS(50, 15)
            ReDim YobshotnS(50, 15)
            ReDim XobshotnN(50, 15)
            ReDim YobshotnN(50, 15)
            ReDim XobshotnK(50, 15)
            ReDim YobshotnK(50, 15)
            ReDim XotnobshC(50, 15)
            ReDim YotnobshC(50, 15)
            ReDim alfaobsh(50, 15)
            ReDim bettaobsh(50, 15)
            ReDim Robsh2(50, 15)
            ReDim element(50, 40, 15)
            ReDim dugaponomeruobsh(50, 15)
            ReDim kpobsh(15)
            ReDim VectAngle(50)
            ReDim Vipuklost(50, 15)
            k = 0
            i = 0
            While g < mstring.Length
                'st = mstring(g)
                Select Case mstring(g)
                    Case "TextBoxXASK"
                        TextBoxXASK.Text = mstring(g + 1)
                    Case "TextBox1"
                        TextBox1.Text = mstring(g + 1)
                    Case "TextBox2"
                        TextBox2.Text = mstring(g + 1)
                    Case "TextBox3"
                        TextBox3.Text = mstring(g + 1)
                    Case "TextBoxYASK"
                        TextBoxYASK.Text = mstring(g + 1)
                    Case "Xcoord"
                        Xcoord = Single.Parse(mstring(g + 1))
                    Case "Ycoord"
                        Ycoord = Single.Parse(mstring(g + 1))
                    Case "Xmaxloc"
                        Xmaxloc(0) = Single.Parse(mstring(g + 1))
                    Case "Xminloc"
                        Xminloc(0) = Single.Parse(mstring(g + 1))
                    Case "Ymaxloc"
                        Ymaxloc(0) = Single.Parse(mstring(g + 1))
                    Case "Yminloc"
                        Yminloc(0) = Single.Parse(mstring(g + 1))
                End Select
                g = g + 1
            End While
            g = 0
            lmes = 0
            While lmes <= 14
                kolvoclikov = kolvoclikov + 1
                While g < mstring.Length
                    'st = mstring(g)
                    Select Case mstring(g)
                        Case Convert.ToString("ViborRB(" & lmes & ")")
                            viborRB(lmes) = mstring(g + 1)
                            'If lmes > 0 Then
                            '    DataGridView2.Focus()
                            '    SendKeys.Send("{DOWN}")
                            'End If
                            DataGridView2.Rows(lmes).Cells(0).Value = "контур№" & lmes + 1 & " (" & viborRB(lmes) & ")"
                        Case Convert.ToString("kolvo(0, " & lmes & ")")
                            kolvo(0, lmes) = Single.Parse(mstring(g + 1))

                            'MsgBox(kolvo(0, lmes))
                        Case "AutoSK(" & lmes & ")"
                            AutoSK(lmes) = Convert.ToBoolean(Convert.ToByte(mstring(g + 1)))
                        Case "ch_podvod(" & lmes & ")"
                            ch_podvod(lmes) = Convert.ToBoolean(Convert.ToByte(mstring(g + 1)))
                        Case "ch_viborka(" & lmes & ")"
                            ch_viborka(lmes) = Convert.ToBoolean(Convert.ToByte(mstring(g + 1)))
                        Case "ch_auto(" & lmes & ")"
                            ch_auto(lmes) = Convert.ToBoolean(Convert.ToByte(mstring(g + 1)))
                        Case "ch_vkl(" & lmes & ")"
                            ch_vkl(lmes) = Convert.ToBoolean(Convert.ToByte(mstring(g + 1)))
                        Case "rb_auto20(" & lmes & ")"
                            rb_auto20(lmes) = Convert.ToBoolean(Convert.ToByte(mstring(g + 1)))
                        Case "rb_hand21(" & lmes & ")"
                            rb_hand21(lmes) = Convert.ToBoolean(Convert.ToByte(mstring(g + 1)))
                    End Select
                    g = g + 1
                End While
                g = 0

                While g < mstring.Length
                    For i = 0 To kolvo(0, lmes) - 1
                        Select Case mstring(g)
                            Case Convert.ToString("element(" & i & ", 0, " & lmes & ")")
                                element(i, 0, lmes) = mstring(g + 1)
                            Case Convert.ToString("Vipuklost(" & i & ", " & lmes & ")")
                                Vipuklost(i, lmes) = mstring(g + 1)

                            Case Convert.ToString("XabsobshN(" & i & ", " & lmes & ")")
                                XabsobshN(i, lmes) = Single.Parse(mstring(g + 1))
                            Case Convert.ToString("XabsobshK(" & i & ", " & lmes & ")")
                                XabsobshK(i, lmes) = Single.Parse(mstring(g + 1))
                            Case Convert.ToString("YabsobshN(" & i & ", " & lmes & ")")
                                YabsobshN(i, lmes) = Single.Parse(mstring(g + 1))
                            Case Convert.ToString("YabsobshK(" & i & ", " & lmes & ")")
                                YabsobshK(i, lmes) = Single.Parse(mstring(g + 1))
                            Case Convert.ToString("XabsobshC(" & i & ", " & lmes & ")")
                                XabsobshC(i, lmes) = Single.Parse(mstring(g + 1))
                            Case Convert.ToString("YabsobshC(" & i & ", " & lmes & ")")
                                YabsobshC(i, lmes) = Single.Parse(mstring(g + 1))
                            Case Convert.ToString("XabsobshM(" & i & ", " & lmes & ")")
                                XabsobshM(i, lmes) = Single.Parse(mstring(g + 1))
                            Case Convert.ToString("YabsobshM(" & i & ", " & lmes & ")")
                                YabsobshM(i, lmes) = Single.Parse(mstring(g + 1))
                            Case Convert.ToString("diamokr(" & i & ", " & lmes & ")")
                                diamokr(i, lmes) = Single.Parse(mstring(g + 1))
                        End Select
                        XobshotnN(i, lmes) = XabsobshN(i, lmes) - Xcoord
                        YobshotnN(i, lmes) = Ycoord - YabsobshN(i, lmes)
                        XobshotnK(i, lmes) = XabsobshK(i, lmes) - Xcoord
                        YobshotnK(i, lmes) = Ycoord - YabsobshK(i, lmes)
                        YotnobshC(i, lmes) = Ycoord - YabsobshC(i, lmes)
                        XotnobshC(i, lmes) = XabsobshC(i, lmes) - Xcoord
                        XobshotnS(i, lmes) = XabsobshM(i, lmes) - Xcoord
                        YobshotnS(i, lmes) = Ycoord - YabsobshM(i, lmes)

                    Next
                    For i = 0 To 21
                        If mstring(g) = Convert.ToString("vr_dannie(" & i & ", " & lmes & ")") Then
                            vr_dannie(i, lmes) = Single.Parse(mstring(g + 1))
                        End If
                    Next
                    g = g + 1
                End While
                g = 0
                Button1.PerformClick()
                crcell = lmes
                'TabControl1.TabIndex = 1

                DataGridView2.Focus()
                DataGridView2.Rows(0).Cells(0).Selected = True
                DataGridView2_CellClick(DataGridView1, New DataGridViewCellEventArgs(0, 0))
                ListBox1.Focus()
                ListBox1.SetSelected(vr_dannie(19, 0), True)
                ' Button7.PerformClick()
                'Button7.PerformClick()
                lmes = lmes + 1
            End While
            lmes = 0
        Catch ex As Exception
            ListBox5.Items.Add(p & "Ошибка при открытии файла")
            p = p + 1
            ListBox5.Items.Add(ex.Message)
            p = p + 1
        End Try
    End Sub



    Private Sub RadioButton10_MouseHover(sender As Object, e As EventArgs) Handles RadioButton10.MouseHover
        If CheckBoxpoyasn.Checked = True Then
            Form3.PictureBox1.Image = MT2CAM.My.Resources.Resources.sverlo1
            Form3.Show()
            i = 0
            Timer1.Enabled = True
            Timer1.Start()
        End If
    End Sub

    Private Sub RadioButton4_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton4.CheckedChanged
        If RadioButton4.Checked = True Then
            Button15.Enabled = True
        Else
            Button15.Enabled = False
        End If

    End Sub

    Private Sub Button15_Click_1(sender As Object, e As EventArgs) Handles Button15.Click
        Form5.Show()
    End Sub

    Private Sub RadioButton13_MouseHover(sender As Object, e As EventArgs) Handles RadioButton13.MouseHover
        If CheckBoxpoyasn.Checked = True Then
            Form3.PictureBox1.Image = MT2CAM.My.Resources.Resources.metchik1
            Form3.Show()
            i = 0
            Timer1.Enabled = True
            Timer1.Start()
        End If
    End Sub

    Private Sub DataGridView2_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView2.CellClick

    End Sub
End Class
