Imports System
Imports System.Type
Imports System.ApplicationId
Imports System.Activator
Imports System.Runtime.InteropServices
Imports Inventor
Imports System.Math
Imports System.Drawing
Imports System.IO
Module Module3
    Structure Mystructure
        Dim x3_1 As Single
        Dim y3_1 As Single
        Dim x3_2 As Single
        Dim y3_2 As Single
        Dim D As Single
    End Structure
    Structure Vnutrfunction
        Dim x1, x2, y1, y2 As Single
    End Structure
    Structure Vect
        Dim x, y As Single
    End Structure

    Public Function PickEskiz()
        i = 0
        crcell = Form1.DataGridView2.CurrentCell.RowIndex
        If kolvoclikov = 0 Then
            l = crcell
        Else
            l = crcell + 1
            'MsgBox("l=" & l)
        End If
        Dim Lsprt() As Inventor.DrawingCurveSegment
        Dim Ls() As Inventor.DrawingCurve
        'Dim otrans As Transaction
        Dim comp As Object
        Dim comps As ObjectCollection
        Dim ocircle As Circle2d
        comps = _invApp.TransientObjects.CreateObjectCollection
        'otrans = _invApp.TransactionManager.StartTransaction(_invApp.ActiveDocument, "выбор контура")
        Form1.ListBox3.Items.Clear()
        kolvoclikov = kolvoclikov + 1


        Dim st0 As New DataGridViewCellStyle
        st0.ForeColor = System.Drawing.Color.Tomato
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
        Dim v1, v2, v3 As Integer
        v1 = CInt(Int((255 * Rnd())))
        v2 = CInt(Int((255 * Rnd())))
        v3 = CInt(Int((255 * Rnd())))
        Select Case l
            Case 0
                paintcolor = _invApp.TransientObjects.CreateColor(v1, v2, v3)
                'paintcolor = _invApp.TransientObjects.CreateColor(255, 165, 0)
                Form1.DataGridView2.Rows(l).Cells(0).Style = st0
            Case 1
                paintcolor = _invApp.TransientObjects.CreateColor(0, 255, 0)
                Form1.DataGridView2.Rows(l).Cells(0).Style = st1
            Case 2
                paintcolor = _invApp.TransientObjects.CreateColor(0, 0, 255)
                Form1.DataGridView2.Rows(l).Cells(0).Style = st2
            Case 3
                paintcolor = _invApp.TransientObjects.CreateColor(255, 0, 255)
                Form1.DataGridView2.Rows(l).Cells(0).Style = st3
            Case 4
                paintcolor = _invApp.TransientObjects.CreateColor(0, 255, 255)
                Form1.DataGridView2.Rows(l).Cells(0).Style = st4
            Case 5
                paintcolor = _invApp.TransientObjects.CreateColor(255, 165, 0)
                Form1.DataGridView2.Rows(l).Cells(0).Style = st0
            Case 6
                paintcolor = _invApp.TransientObjects.CreateColor(0, 255, 0)
                Form1.DataGridView2.Rows(l).Cells(0).Style = st1
            Case 7
                paintcolor = _invApp.TransientObjects.CreateColor(0, 0, 255)
                Form1.DataGridView2.Rows(l).Cells(0).Style = st2
            Case 8
                paintcolor = _invApp.TransientObjects.CreateColor(255, 0, 255)
                Form1.DataGridView2.Rows(l).Cells(0).Style = st3
            Case 9
                paintcolor = _invApp.TransientObjects.CreateColor(0, 255, 255)
                Form1.DataGridView2.Rows(l).Cells(0).Style = st4
            Case 10
                paintcolor = _invApp.TransientObjects.CreateColor(255, 165, 0)
                Form1.DataGridView2.Rows(l).Cells(0).Style = st0
            Case 11
                paintcolor = _invApp.TransientObjects.CreateColor(0, 255, 0)
                Form1.DataGridView2.Rows(l).Cells(0).Style = st1
            Case 12
                paintcolor = _invApp.TransientObjects.CreateColor(0, 0, 255)
                Form1.DataGridView2.Rows(l).Cells(0).Style = st2
            Case 13
                paintcolor = _invApp.TransientObjects.CreateColor(255, 0, 255)
                Form1.DataGridView2.Rows(l).Cells(0).Style = st3
            Case 14
                paintcolor = _invApp.TransientObjects.CreateColor(0, 255, 255)
                Form1.DataGridView2.Rows(l).Cells(0).Style = st4
        End Select
        While True
            comp = _invApp.CommandManager.Pick(Inventor.SelectionFilterEnum.kDrawingCurveSegmentFilter, "Выберите кривую эскиза №" & i + 1 & "Для выхода нажмите Esc")
            If IsNothing(comp) Then Exit While
            comps.Add(comp)



            ReDim Preserve Lsprt(50)
            ReDim Preserve Ls(50)
            Lsprt(i) = comp
            Ls(i) = Lsprt(i).Parent
            Ls(i).Color = paintcolor
            Ls(i).LineWeight = 0.05
            i = i + 1
        End While
        i = 0
        kolvo(0, l) = comps.Count
        For k = 0 To 39
            kolvo(k, l) = kolvo(0, l)
        Next
        k = 0
        If l = 0 Then
            ReDim element(50, 40, 15)
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

        For i = 0 To kolvo(0, l) - 1

            For Each comp In comps
                Select Case Lsprt(i).GeometryType
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
            Next
            For k = 0 To 39
                element(i, k, l) = element(i, 0, l)
            Next
            k = 0
            'i = 0



            If element(i, 0, l) = "Отрезок" Then
                '  Ls(i) = Lsprt(i)
                odc1pt(0) = Round(Lsprt(i).StartPoint.X, 3)
                odc1pt(1) = Round(Lsprt(i).StartPoint.Y, 3)
                odc1pt(2) = Round(Lsprt(i).EndPoint.X, 3)
                odc1pt(3) = Round(Lsprt(i).EndPoint.Y, 3)
                odc1pt(4) = Round(Ls(i).MidPoint.X, 3)
                odc1pt(5) = Round(Ls(i).MidPoint.Y, 3)
                XabsobshN(i, l) = odc1pt(0) * 10
                YabsobshN(i, l) = odc1pt(1) * 10
                XabsobshK(i, l) = odc1pt(2) * 10
                YabsobshK(i, l) = odc1pt(3) * 10
                XabsobshM(i, l) = odc1pt(4) * 10
                YabsobshM(i, l) = odc1pt(5) * 10
                Call Form1.poiskminmax()
            ElseIf element(i, 0, l) = "Дуга" Then

                odc1pt(0) = Round(Lsprt(i).StartPoint.X, 3)
                odc1pt(1) = Round(Lsprt(i).StartPoint.Y, 3)
                odc1pt(2) = Round(Lsprt(i).EndPoint.X, 3)
                odc1pt(3) = Round(Lsprt(i).EndPoint.Y, 3)
                odc1pt(4) = Round(Ls(i).CenterPoint.X, 3)
                odc1pt(5) = Round(Ls(i).CenterPoint.Y, 3)
                odc1pt(6) = Round(Ls(i).MidPoint.X, 3)
                odc1pt(7) = Round(Ls(i).MidPoint.Y, 3)
                XabsobshN(i, l) = odc1pt(0) * 10
                YabsobshN(i, l) = odc1pt(1) * 10
                XabsobshK(i, l) = odc1pt(2) * 10
                YabsobshK(i, l) = odc1pt(3) * 10
                XabsobshC(i, l) = odc1pt(4) * 10
                YabsobshC(i, l) = odc1pt(5) * 10
                XabsobshM(i, l) = odc1pt(6) * 10
                YabsobshM(i, l) = odc1pt(7) * 10
                Call Form1.poiskminmax()
                ' End If
            ElseIf element(i, 0, l) = "Окружность" Then
                ocircle = Lsprt(i).Geometry
                odc1pt(0) = Round(Ls(i).CenterPoint.X, 4)
                odc1pt(1) = Round(Ls(i).CenterPoint.Y, 4)
                odc1pt(2) = ocircle.Radius * 10
                diamokr(i, l) = 2 * odc1pt(2)
                Yabscentr(i) = odc1pt(1) * 10
                Xabscentr(i) = odc1pt(0) * 10
                XabsobshC(i, l) = odc1pt(0) * 10
                YabsobshC(i, l) = odc1pt(1) * 10
                Call Form1.poiskminmax()

            End If
            'Call Proverka_na_vipuklost()
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
                Call Form1.Ustanofka_Sk_Stanka()
            End If
        Next
        If Form1.RadioButton1.Checked = True Then
            viborRB(l) = "Vneshniy contour"
        ElseIf Form1.RadioButton2.Checked = True Then
            viborRB(l) = "Vnutrenniy contour"
        ElseIf Form1.RadioButton3.Checked = True Then
            viborRB(l) = "Paz"
        ElseIf Form1.RadioButton10.Checked = True Then
            viborRB(l) = "Otverstie"
        ElseIf Form1.RadioButton19.Checked = True Then
            viborRB(l) = "Ploskost"
        ElseIf Form1.RadioButton13.Checked = True Then
            viborRB(l) = "Rezba"
        ElseIf Form1.RadioButton11.Checked = True Then
            viborRB(l) = "Ustup"
        End If
        If l > 0 Then
            Form1.DataGridView2.Focus()
            SendKeys.Send("{DOWN}")
        End If
        Form1.DataGridView2.Rows(l).Cells(0).Value = "контур№" & l + 1 & " (" & viborRB(l) & ")"
        l = l + 1
        If l > 14 Then
            l = 0
        End If
        i = 0
    End Function
    Public Function PickXY()
        _invApp = Marshal.GetActiveObject("Inventor.Application")
        Dim LsprtXY(2) As Inventor.SketchEntity
        Dim LsXY(2) As Inventor.SketchLine
        Dim otrans As Transaction
        Dim comp As Object
        Dim comps As ObjectCollection
        comps = _invApp.TransientObjects.CreateObjectCollection
        Dim XnXY(2), XkXY(2), YnXY(2), YkXY(2) As Single
        i = 0
        otrans = _invApp.TransactionManager.StartTransaction(_invApp.ActiveDocument, "Выбор ЛСК")
        While i <= 1
            System.Windows.Forms.Application.DoEvents()
            System.Threading.Thread.Sleep(200)
            System.Windows.Forms.Application.DoEvents()

            comp = _invApp.CommandManager.Pick(Inventor.SelectionFilterEnum.kSketchCurveFilter, "Выберите ось Х")
            If i = 0 Then
                LsXY(i) = comp
                paintcolor = _invApp.TransientObjects.CreateColor(255, 0, 0)
                '   LsXY(i).OverrideColor() = paintcolor

            ElseIf i = 1 Then
                comp = _invApp.CommandManager.Pick(Inventor.SelectionFilterEnum.kSketchCurveFilter, "Выберите ось У")
                paintcolor = _invApp.TransientObjects.CreateColor(0, 255, 0)
                '     LsXY(i).OverrideColor() = paintcolor
            ElseIf IsNothing(comp) Then
                Exit While
            End If
            comps.Add(comp)
            i = i + 1
        End While
        i = 0
        ReDim LsXY(2)
        For Each comp In comps
            LsprtXY(i) = comp
            Select Case LsprtXY(i).Type
                Case 83896064
                    LsXY(i) = LsprtXY(i)
                    XnXY(i) = LsXY(i).Geometry.StartPoint.X * 10
                    XkXY(i) = LsXY(i).Geometry.EndPoint.X * 10
                    YnXY(i) = LsXY(i).Geometry.StartPoint.Y * 10
                    YkXY(i) = LsXY(i).Geometry.EndPoint.Y * 10
                    'Form1.ListBox5.Items.Add("XnXY(i)=" & XnXY(i))
                    'Form1.ListBox5.Items.Add("XkXY(i)=" & XkXY(i))
                    'Form1.ListBox5.Items.Add("ynXY(i)=" & YnXY(i))
                    'Form1.ListBox5.Items.Add("ykXY(i)=" & YkXY(i))
            End Select
            i = i + 1
        Next
        i = 0
        If Round(XnXY(0), 0) = Round(XnXY(1), 0) And Round(YnXY(0), 0) = Round(YnXY(1), 0) Then
            Xcoord = XnXY(0)
            Ycoord = YnXY(0)
        ElseIf Round(XnXY(0), 0) = Round(XkXY(1), 0) And Round(YnXY(0), 0) = Round(YkXY(1), 0) Then
            Xcoord = XnXY(0)
            Ycoord = YnXY(0)
        ElseIf Round(XkXY(0), 0) = Round(XnXY(1), 0) And Round(YkXY(0), 0) = Round(YnXY(1), 0) Then
            Xcoord = XkXY(0)
            Ycoord = YkXY(0)
        ElseIf Round(XkXY(0), 0) = Round(XkXY(1), 0) And Round(YkXY(0), 0) = Round(YkXY(1), 0) Then
            Xcoord = XkXY(0)
            Ycoord = YkXY(0)
        End If
        ' Form1.ListBox5.Items.Add(Xcoord & "   " & Ycoord)
        otrans.End()
    End Function
    Public Function vhod_frezi()
        'Dim Xvhod(l), Yvhod(l) As Single

        If viborRB(crcell) = "Vneshniy contour" Then
            Dim yraz, xraz, obshmin As Single
            xraz = Math.Min(Abs(XobshrisN(kolvo(k, l) - 1, kp, l) - (Xmaxloc(l) - Xcoord + 2 * xprip)), Abs(XobshrisN(kolvo(k, l) - 1, kp, l) + xprip))
            yraz = Math.Min(Abs(YobshrisN(kolvo(k, l) - 1, kp, l) - (Ymaxloc(l) - Ycoord + 2 * yprip)), Abs(YobshrisN(kolvo(k, l) - 1, kp, l) + yprip))
            obshmin = Math.Min(xraz, yraz)
            If (vr_dannie(20, crcell) = 0 And vr_dannie(21, crcell) = 0) Or Form2.CheckBox1.Checked = True Then
                If element(0, 0, l) <> "Окружность" Then

                    If Round(Abs(XobshrisN(kolvo(k, l) - 1, kp, l) - (Xmaxloc(l) - Xcoord + 2 * xprip)), 1) = Round(obshmin, 1) Then
                        Xvhod(l) = XobshrisN(kolvo(k, l) - 1, kp, l) + Convert.ToString(vr_dannie(9, crcell))
                        Yvhod(l) = YobshrisN(kolvo(k, l) - 1, kp, l)
                        Kontour.DrawLine(pen4, Xvhod(l) + Sdvg, Yvhod(l) + Sdvg, XobshrisN(kolvo(k, l) - 1, kp, l) + Sdvg, YobshrisN(kolvo(k, l) - 1, kp, l) + Sdvg)
                    ElseIf Round(Abs(XobshrisN(kolvo(k, l) - 1, kp, l) + xprip), 1) = Round(obshmin, 1) Then
                        Xvhod(l) = XobshrisN(kolvo(k, l) - 1, kp, l) - Convert.ToString(vr_dannie(9, crcell))
                        Yvhod(l) = YobshrisN(kolvo(k, l) - 1, kp, l)
                        Kontour.DrawLine(pen4, Xvhod(l) + Sdvg, Yvhod(l) + Sdvg, XobshrisN(kolvo(k, l) - 1, kp, l) + Sdvg, YobshrisN(kolvo(k, l) - 1, kp, l) + Sdvg)
                    ElseIf Round(Abs(YobshrisN(kolvo(k, l) - 1, kp, l) - Ymaxloc(l) - Ycoord + 2 * yprip), 1) = Round(obshmin, 1) Then
                        Xvhod(l) = XobshrisN(kolvo(k, l) - 1, kp, l)
                        Yvhod(l) = YobshrisN(kolvo(k, l) - 1, kp, l) + Convert.ToString(vr_dannie(9, crcell))
                        Kontour.DrawLine(pen4, Xvhod(l) + Sdvg, Yvhod(l) + Sdvg, XobshrisN(kolvo(k, l) - 1, kp, l) + Sdvg, YobshrisN(kolvo(k, l) - 1, kp, l) + Sdvg)
                    ElseIf Round(Abs(YobshrisN(kolvo(k, l) - 1, kp, l) + yprip), 1) = Round(obshmin, 1) Then
                        Xvhod(l) = XobshrisN(kolvo(k, l) - 1, kp, l)
                        Yvhod(l) = YobshrisN(kolvo(k, l) - 1, kp, l) - Convert.ToString(vr_dannie(9, crcell))
                        Kontour.DrawLine(pen4, Xvhod(l) + Sdvg, Yvhod(l) + Sdvg, XobshrisN(kolvo(k, l) - 1, kp, l) + Sdvg, YobshrisN(kolvo(k, l) - 1, kp, l) + Sdvg)
                    End If
                Else
                    Xvhod(l) = XotnobshC(0, l) - Robshris(kolvo(0, l) - 1, kp, l) - Convert.ToString(vr_dannie(9, crcell))
                    Yvhod(l) = YotnobshC(0, l)
                End If
                Form2.TextBoxXvhod.Text = Convert.ToString(Xvhod(l))
                Form2.TextBoxYvhod.Text = Convert.ToString(Xvhod(l))
                Form2.TextBoxautox.Text = Convert.ToString(Xvhod(l))
                Form2.TextBoxautoy.Text = Convert.ToString(Yvhod(l))
                vr_dannie(20, crcell) = Xvhod(l)
                vr_dannie(21, crcell) = Yvhod(l)
            Else
                'MsgBox(vr_dannie(20, crcell))
                Xvhod(l) = Single.Parse(vr_dannie(20, crcell))
                Yvhod(l) = Single.Parse(vr_dannie(21, crcell))
                vr_dannie(20, crcell) = Xvhod(l)
                vr_dannie(21, crcell) = Yvhod(l)
            End If
            Dim brush1 As New SolidBrush(System.Drawing.Color.Red)
            Kontour.FillEllipse(brush1, Xvhod(l) - 3 + Sdvg, Yvhod(l) - 3 + Sdvg, 6, 6)
            If element(0, 0, l) <> "Окружность" Then
                Kontour.DrawLine(pen4, Xvhod(l) + Sdvg, Yvhod(l) + Sdvg, XobshrisN(kolvo(k, l) - 1, kp, l) + Sdvg, YobshrisN(kolvo(k, l) - 1, kp, l) + Sdvg)
            Else
                Kontour.DrawLine(pen4, Xvhod(l) + Sdvg, Yvhod(l) + Sdvg, XotnobshC(0, l) - Robshris(kolvo(0, l) - 1, kp, l) + Sdvg, YotnobshC(0, l) + Sdvg)
            End If

            Zvhod(l) = Decimal.Parse(Form1.TextBoxbzrast.Text)
            Try
                kchastey = Math.Ceiling((Zvhod(l) - Decimal.Parse(Form1.TextBoxnpl.Text)) / Decimal.Parse(Form1.TextBoxmaxZ.Text))
                ReDim zvhodpr(kchastey + 1, 15)
                ' Form1.ListBox5.Items.Add("Количество частей = " & kchastey)
                For i = 0 To kchastey
                    zvhodpr(i, l) = Math.Round(Zvhod(l) - (i / kchastey) * (Zvhod(l) - Decimal.Parse(Form1.TextBoxnpl.Text)), 3)

                Next
                vremya(l) = (rastoyanie(l) * kchastey) / Single.Parse(Form1.TextBoxSrez.Text) + Single.Parse(Form1.TextBoxviskon.Text) / Single.Parse(Form1.TextBoxpdchvert.Text)
                Form1.TextBoxmin.Text = Fix(vremya(l))
                Form1.TextBoxsek.Text = Round((vremya(l) - Fix(vremya(l))) * 60, 0)
                i = 0
            Catch ex As Exception
                Form1.ListBox5.Items.Add(ex.Message)
                p = p + 1
                Dim stacktr As New StackTrace(ex, True)
                If stacktr.FrameCount > 0 Then
                    Dim stackfr As New StackFrame
                    stackfr = stacktr.GetFrame(0)
                    Dim errorline As Integer = stackfr.GetFileLineNumber()
                    Dim functionname As String = stackfr.GetMethod().Name
                    Form1.ListBox5.Items.Add("Ошибка в " & functionname & " на линии" & errorline)
                    p = p + 1
                    Form1.ListBox5.Items.Add(ex.Message)
                    p = p + 1
                End If
            End Try
        ElseIf viborRB(crcell) = "Vnutrenniy contour" Then
            If vr_dannie(10, crcell) = 0 Then
                Form2.TextBoxugolzag.Text = "1"
                vr_dannie(10, crcell) = 1
            Else
                Form2.TextBoxugolzag.Text = vr_dannie(10, crcell)
            End If
            If (vr_dannie(20, crcell) = 0 And vr_dannie(21, crcell) = 0) Or Form2.CheckBox1.Checked = True Then
                Xvhod(l) = (Xmaxloc(l) - Xminloc(l)) / 2
                Yvhod(l) = (Ymaxloc(l) - Yminloc(l)) / 2
                Form2.TextBoxXvhod.Text = Convert.ToString(Xvhod(l))
                Form2.TextBoxYvhod.Text = Convert.ToString(Xvhod(l))
                Form2.TextBoxautox.Text = Convert.ToString(Xvhod(l))
                Form2.TextBoxautoy.Text = Convert.ToString(Yvhod(l))
                vr_dannie(20, crcell) = Xvhod(l)
                vr_dannie(21, crcell) = Yvhod(l)
            Else
                'MsgBox(vr_dannie(20, crcell))
                Xvhod(l) = Single.Parse(vr_dannie(20, crcell))
                Yvhod(l) = Single.Parse(vr_dannie(21, crcell))
                vr_dannie(20, crcell) = Xvhod(l)
                vr_dannie(21, crcell) = Yvhod(l)
            End If
            Dim brush1 As New SolidBrush(System.Drawing.Color.Red)
            Kontour.FillEllipse(brush1, Xvhod(l) - 3 + Sdvg, Yvhod(l) - 3 + Sdvg, 6, 6)
            Rvhod(l) = Dfrez(ni) / 2 - 0.1
            n = Math.Ceiling(2 * (Convert.ToDecimal(Form1.TextBoxbzrast.Text) + Convert.ToDecimal(Form1.TextBoxdeltaniz.Text) - Convert.ToDecimal(Form1.TextBoxnpl.Text)) / ((2 * Rvhod(l) * PI) * (Tan(vr_dannie(10, crcell) * PI / 180))))
            'Form1.ListBox5.Items.Add("n = " & n)
            Zvhod(l) = (Round((Rvhod(l) * PI * n) * Tan(vr_dannie(10, crcell) * PI / 180) - Convert.ToDecimal(Form1.TextBoxdeltaniz.Text) + Convert.ToDecimal(Form1.TextBoxnpl.Text), 3))
            'Form1.ListBox5.Items.Add("Zvhod(l) = " & Zvhod(l))
            Try
                kchastey = Math.Ceiling((Zvhod(l) - Decimal.Parse(Form1.TextBoxnpl.Text)) / Decimal.Parse(Form1.TextBoxmaxZ.Text))
                ReDim zvhodpr(kchastey + 1, 15)
                ' Form1.ListBox5.Items.Add("Количество частей = " & kchastey)
                For i = 0 To kchastey
                    zvhodpr(i, l) = Math.Round(Zvhod(l) - i * (n / kchastey) * ((Rvhod(l) * PI) * Tan(vr_dannie(10, crcell) * PI / 180)), 3)
                    'Form1.ListBox5.Items.Add("Zвход=" & zvhodpr(i, l))
                Next
                ' MsgBox(rastoyanie(l))
                vremya(l) = (rastoyanie(l) * kchastey) / Single.Parse(Form1.TextBoxSrez.Text) + Single.Parse(Form1.TextBoxviskon.Text) / Single.Parse(Form1.TextBoxpdchvert.Text)
                Form1.TextBoxmin.Text = Fix(vremya(l))
                Form1.TextBoxsek.Text = Round((vremya(l) - Fix(vremya(l))) * 60, 0)
                i = 0
            Catch ex As Exception
                Dim stacktr As New StackTrace(ex, True)
                If stacktr.FrameCount > 0 Then
                    Dim stackfr As New StackFrame
                    stackfr = stacktr.GetFrame(0)
                    Dim errorline As Integer = stackfr.GetFileLineNumber()
                    Dim functionname As String = stackfr.GetMethod().Name
                    Form1.ListBox5.Items.Add("Ошибка во -вход в карман- " & functionname & " на линии" & errorline)
                    p = p + 1
                    Form1.ListBox5.Items.Add(ex.Message)
                    p = p + 1
                End If
            End Try
        ElseIf viborRB(crcell) = "Ploskost" Then
            'MsgBox(rastoyanie(l))
            Xvhod(l) = XobshrisN(0, 0, l)
            Yvhod(l) = YobshrisN(0, 0, l)
            Zvhod(l) = Decimal.Parse(Form1.TextBoxbzrast.Text)
            Try
                kchastey = Math.Ceiling((Zvhod(l) - Decimal.Parse(Form1.TextBoxvpl.Text) - Decimal.Parse(Form1.TextBoxdletaverh.Text)) / Decimal.Parse(Form1.TextBoxmaxZ.Text))
                ReDim zvhodpr(kchastey + 1, 15)
                ' Form1.ListBox5.Items.Add("Количество частей = " & kchastey)
                For i = 0 To kchastey
                    zvhodpr(i, l) = Math.Round(Zvhod(l) - (i / kchastey) * (Zvhod(l) - Decimal.Parse(Form1.TextBoxvpl.Text) - Decimal.Parse(Form1.TextBoxdletaverh.Text)), 3)
                    'Form1.ListBox5.Items.Add("Zвход=" & zvhodpr(i, l))
                Next
                vremya(l) = (rastoyanie(l) * kchastey) / Single.Parse(Form1.TextBoxSrez.Text)

                Form1.TextBoxmin.Text = Fix(vremya(l))
                Form1.TextBoxsek.Text = Round((vremya(l) - Fix(vremya(l))) * 60, 0)
                i = 0
            Catch ex As Exception
                Dim stacktr As New StackTrace(ex, True)
                If stacktr.FrameCount > 0 Then
                    Dim stackfr As New StackFrame
                    stackfr = stacktr.GetFrame(0)
                    Dim errorline As Integer = stackfr.GetFileLineNumber()
                    Dim functionname As String = stackfr.GetMethod().Name
                    Form1.ListBox5.Items.Add("Ошибка в " & functionname & " на линии" & errorline)
                    p = p + 1

                End If
            End Try
            Dim brush1 As New SolidBrush(System.Drawing.Color.Red)
            Kontour.FillEllipse(brush1, Xvhod(l) - 3 + Sdvg, Yvhod(l) - 3 + Sdvg, 6, 6)
        ElseIf viborRB(crcell) = "Ustup" Then
            'Form1.ListBox5.Items.Add("Ustup1")
            Zvhod(l) = Decimal.Parse(Form1.TextBoxbzrast.Text)
            Try
                kchastey = Math.Ceiling((Zvhod(l) - Decimal.Parse(Form1.TextBoxnpl.Text)) / Decimal.Parse(Form1.TextBoxmaxZ.Text))
                ReDim zvhodpr(kchastey + 1, 15)
                ' Form1.ListBox5.Items.Add("Количество частей = " & kchastey)
                For i = 0 To kchastey
                    zvhodpr(i, l) = Math.Round(Zvhod(l) - (i / kchastey) * (Zvhod(l) - Decimal.Parse(Form1.TextBoxnpl.Text)), 3)
                    ' Form1.ListBox5.Items.Add("Zвход=" & zvhodpr(i, l))
                Next

                ' Form1.ListBox5.Items.Add(kchastey)
            Catch ex As Exception
                Form1.ListBox5.Items.Add(ex.Message)
                p = p + 1
                Dim stacktr As New StackTrace(ex, True)
                If stacktr.FrameCount > 0 Then
                    Dim stackfr As New StackFrame
                    stackfr = stacktr.GetFrame(0)
                    Dim errorline As Integer = stackfr.GetFileLineNumber()
                    Dim functionname As String = stackfr.GetMethod().Name
                    Form1.ListBox5.Items.Add("Ошибка в " & functionname & " на линии" & errorline)
                    p = p + 1
                    Form1.ListBox5.Items.Add(ex.Message)
                    p = p + 1
                End If
            End Try
        End If
    End Function


    Public Function optimisation_of_contour()
        Dim kl, bl, Discr, radius As Single
        Dim x(1), y(1), xj(1), yj(1), Ak(1), Bk(1), Ck(1) As Single

        Try
            Dim jpred As Integer
            l = crcell
            If Form1.RadioButton20.Checked = True And Form1.CheckBoxviborka.Checked = True Then
                For k = 1 To kpobsh(l)
                    For o = 0 To 1
                        Dim Xrisvrem(kolvo(k, l)), Yrisvrem(kolvo(k, l)) As Single
                        For j = 0 To kolvo(k, l) - 1
                            For s = 0 To 1
                                If j > 0 Then
                                    jpred = j - 1
                                Else
                                    jpred = kolvo(k, l) - 1
                                End If

                                'Пересечение с верхом
                                If YobshrisN(j, k, l) < -yprip - Dfrez(ni) * per / 2 Or YobshrisN(jpred, k, l) < -yprip - Dfrez(ni) * per / 2 Then
                                    If element(j, k, l) = "Отрезок" Then
                                        'если отрезок вне заготовки полностью
                                        If YobshrisN(j, k, l) < -yprip - Dfrez(ni) * per / 2 And YobshrisN(jpred, k, l) < -yprip - Dfrez(ni) * per / 2 Then
                                            'Ничего не делаем

                                            'Конец пересекает верх, начало - нет
                                        ElseIf YobshrisN(j, k, l) < -yprip - Dfrez(ni) * per / 2 And YobshrisN(jpred, k, l) >= -yprip - Dfrez(ni) * per / 2 Then
                                            Yrisvrem(j) = -yprip - Dfrez(ni) * per / 2
                                            xj(0) = XobshrisN(jpred, k, l)
                                            yj(0) = YobshrisN(jpred, k, l)
                                            xj(1) = XobshrisN(j, k, l)
                                            yj(1) = YobshrisN(j, k, l)
                                            If xj(0) <> xj(1) Then
                                                kl = (yj(0) - yj(1)) / (xj(0) - xj(1))
                                                bl = yj(0) - kl * xj(0)
                                                If kl <> 0 Then
                                                    x(0) = (Yrisvrem(j) - bl) / kl
                                                Else
                                                    Form1.ListBox5.Items.Add("нет пересечений")
                                                End If
                                            Else
                                                x(0) = xj(0)
                                            End If
                                            Xrisvrem(j) = x(0)
                                            'Начало пересекает верх, конец -  нет
                                        ElseIf YobshrisN(j, k, l) >= -yprip - Dfrez(ni) * per / 2 And YobshrisN(jpred, k, l) < -yprip - Dfrez(ni) * per / 2 Then
                                            Yrisvrem(jpred) = -yprip - Dfrez(ni) * per / 2
                                            xj(0) = XobshrisN(jpred, k, l)
                                            yj(0) = YobshrisN(jpred, k, l)
                                            xj(1) = XobshrisN(j, k, l)
                                            yj(1) = YobshrisN(j, k, l)
                                            If xj(0) <> xj(1) Then
                                                kl = (yj(0) - yj(1)) / (xj(0) - xj(1))
                                                bl = yj(0) - kl * xj(0)
                                                If kl <> 0 Then
                                                    x(0) = (Yrisvrem(jpred) - bl) / kl
                                                Else
                                                    Form1.ListBox5.Items.Add("нет пересечений")
                                                End If
                                            Else
                                                x(0) = xj(0)
                                            End If
                                            Xrisvrem(jpred) = x(0)
                                            'отрезок полностью в заготовке
                                        ElseIf YobshrisN(j, k, l) >= -yprip - Dfrez(ni) * per / 2 And YobshrisN(jpred, k, l) >= -yprip - Dfrez(ni) * per / 2 Then
                                            'Ничего не делаем
                                        End If


                                    ElseIf element(j, k, l) = "Дуга" Then

                                        'если дуга вне заготовки полностью
                                        If YobshrisN(j, k, l) < -yprip And YobshrisN(jpred, k, l) < -yprip Then
                                            element(j, k, l) = "Отрезок"
                                            'Конец пересекает верх, начало - нет
                                        ElseIf YobshrisN(j, k, l) < -yprip - Dfrez(ni) * per / 2 And YobshrisN(jpred, k, l) >= -yprip - Dfrez(ni) * per / 2 Then
                                            radius = Sqrt((XobshrisN(j, k, l) - TXotnC(j, k)) ^ 2 + (YobshrisN(j, k, l) - TYotnC(j, k)) ^ 2)
                                            Yrisvrem(j) = -yprip - Dfrez(ni) * per / 2
                                            xj(0) = XobshrisN(jpred, k, l)
                                            yj(0) = YobshrisN(jpred, k, l)
                                            xj(1) = XobshrisN(j, k, l)
                                            yj(1) = YobshrisN(j, k, l)
                                            Discr = 4 * (TXotnC(j, k)) ^ 2 - 4 * ((TXotnC(j, k)) ^ 2 + (Yrisvrem(j) - TYotnC(j, k)) ^ 2 - radius ^ 2)
                                            x(0) = (2 * TXotnC(j, k) + Sqrt(Discr)) / 2
                                            x(1) = (2 * TXotnC(j, k) - Sqrt(Discr)) / 2
                                            For h = 0 To 1
                                                Ak(h) = Sqrt((x(h) - xj(1)) ^ 2 + (yj(0) - yj(1)) ^ 2)
                                                Bk(h) = Sqrt((x(h) - TXotnC(j, k)) ^ 2 + (yj(0) - TYotnC(j, k)) ^ 2)
                                                Ck(h) = Sqrt((xj(1) - TXotnC(j, k)) ^ 2 + (yj(1) - TYotnC(j, k)) ^ 2)
                                                alfa(h) = Math.Acos(theorcos(Ak(h), Bk(h), Ck(h))) * 180 / PI
                                                If alfa(h) > 180 Then
                                                    alfa(h) = 360 - alfa(h)
                                                End If
                                            Next
                                            If alfa(0) < alfa(1) Then
                                                Xrisvrem(j) = x(0)
                                            Else
                                                Xrisvrem(j) = x(1)
                                            End If

                                            'Начало пересекает верх, конец -  нет
                                        ElseIf YobshrisN(j, k, l) >= -yprip - Dfrez(ni) * per / 2 And YobshrisN(jpred, k, l) < -yprip - Dfrez(ni) * per / 2 Then

                                            radius = Sqrt((XobshrisN(jpred, k, l) - TXotnC(j, k)) ^ 2 + (YobshrisN(jpred, k, l) - TYotnC(j, k)) ^ 2)
                                            Yrisvrem(jpred) = -yprip - Dfrez(ni) * per / 2
                                            xj(0) = XobshrisN(jpred, k, l)
                                            yj(0) = YobshrisN(jpred, k, l)
                                            xj(1) = XobshrisN(j, k, l)
                                            yj(1) = YobshrisN(j, k, l)
                                            Discr = 4 * (TXotnC(j, k)) ^ 2 - 4 * ((TXotnC(j, k)) ^ 2 + (Yrisvrem(jpred) - TYotnC(j, k)) ^ 2 - radius ^ 2)
                                            x(0) = (2 * TXotnC(j, k) + Sqrt(Discr)) / 2
                                            x(1) = (2 * TXotnC(j, k) - Sqrt(Discr)) / 2
                                            For h = 0 To 1
                                                Ak(h) = Sqrt((x(h) - xj(1)) ^ 2 + (yj(0) - yj(1)) ^ 2)
                                                Bk(h) = Sqrt((x(h) - TXotnC(j, k)) ^ 2 + (yj(0) - TYotnC(j, k)) ^ 2)
                                                Ck(h) = Sqrt((xj(1) - TXotnC(j, k)) ^ 2 + (yj(1) - TYotnC(j, k)) ^ 2)
                                                alfa(h) = Math.Acos(theorcos(Ak(h), Bk(h), Ck(h))) * 180 / PI
                                                If alfa(h) > 180 Then
                                                    alfa(h) = 360 - alfa(h)
                                                End If
                                                'With Form1.ListBox5.Items

                                                '    .Add("--------------------")
                                                '    .Add("D =" & Discr)
                                                '    .Add("x(" & h & ") =" & x(h))
                                                '    .Add("A(" & h & ") =" & Ak(h))
                                                '    .Add("B(" & h & ") =" & Bk(h))
                                                '    .Add("C(" & h & ") =" & Ck(h))
                                                '    .Add("alfa(" & h & ") =" & alfa(h))
                                                'End With
                                            Next
                                            If alfa(0) < alfa(1) Then
                                                Xrisvrem(jpred) = x(0)
                                            Else
                                                Xrisvrem(jpred) = x(1)
                                            End If
                                            'дуга полностью в заготовке
                                        ElseIf YobshrisN(j, k, l) >= -yprip - Dfrez(ni) * per / 2 And YobshrisN(jpred, k, l) >= -yprip - Dfrez(ni) * per / 2 Then
                                            'ничего не делаем
                                        End If
                                    End If
                                    'Пересечение с низом
                                ElseIf YobshrisN(j, k, l) > -(Yminloc(0) - Ycoord) + yprip + Dfrez(ni) * per / 2 Or YobshrisN(jpred, k, l) > -(Yminloc(0) - Ycoord) + yprip + Dfrez(ni) * per / 2 Then
                                    If element(j, k, l) = "Отрезок" Then
                                        'если отрезок вне заготовки полностью
                                        If YobshrisN(j, k, l) > -(Yminloc(0) - Ycoord) + yprip + Dfrez(ni) * per / 2 And YobshrisN(jpred, k, l) > -(Yminloc(0) - Ycoord) + yprip + Dfrez(ni) * per / 2 Then
                                            'Ничего не делаем

                                            'Конец пересекает низ, начало - нет
                                        ElseIf YobshrisN(j, k, l) > -(Yminloc(0) - Ycoord) + yprip + Dfrez(ni) * per / 2 And YobshrisN(jpred, k, l) <= -(Yminloc(0) - Ycoord) + yprip + Dfrez(ni) * per / 2 Then
                                            Yrisvrem(j) = -(Yminloc(0) - Ycoord) + yprip + Dfrez(ni) * per / 2
                                            xj(0) = XobshrisN(jpred, k, l)
                                            yj(0) = YobshrisN(jpred, k, l)
                                            xj(1) = XobshrisN(j, k, l)
                                            yj(1) = YobshrisN(j, k, l)
                                            If xj(0) <> xj(1) Then
                                                kl = (yj(0) - yj(1)) / (xj(0) - xj(1))
                                                bl = yj(0) - kl * xj(0)
                                                If kl <> 0 Then
                                                    x(0) = (Yrisvrem(j) - bl) / kl
                                                Else
                                                    Form1.ListBox5.Items.Add("нет пересечений")
                                                End If
                                            Else
                                                x(0) = xj(0)
                                            End If
                                            Xrisvrem(j) = x(0)
                                            'Начало пересекает низ, конец -  нет
                                        ElseIf YobshrisN(j, k, l) <= -(Yminloc(0) - Ycoord) + yprip + Dfrez(ni) * per / 2 And YobshrisN(jpred, k, l) > -(Yminloc(0) - Ycoord) + yprip + Dfrez(ni) * per / 2 Then
                                            Yrisvrem(jpred) = -(Yminloc(0) - Ycoord) + yprip + Dfrez(ni) * per / 2
                                            xj(0) = XobshrisN(jpred, k, l)
                                            yj(0) = YobshrisN(jpred, k, l)
                                            xj(1) = XobshrisN(j, k, l)
                                            yj(1) = YobshrisN(j, k, l)
                                            If xj(0) <> xj(1) Then
                                                kl = (yj(0) - yj(1)) / (xj(0) - xj(1))
                                                bl = yj(0) - kl * xj(0)
                                                If kl <> 0 Then
                                                    x(0) = (Yrisvrem(jpred) - bl) / kl
                                                Else
                                                    Form1.ListBox5.Items.Add("нет пересечений")
                                                End If
                                            Else
                                                x(0) = xj(0)
                                            End If
                                            Xrisvrem(jpred) = x(0)
                                            'отрезок полностью в заготовке
                                        ElseIf YobshrisN(j, k, l) <= -(Yminloc(0) - Ycoord) + yprip + Dfrez(ni) * per / 2 And YobshrisN(jpred, k, l) <= -(Yminloc(0) - Ycoord) + yprip + Dfrez(ni) * per / 2 Then
                                            'Ничего не делаем
                                        End If


                                    ElseIf element(j, k, l) = "Дуга" Then

                                        'если дуга вне заготовки полностью
                                        If YobshrisN(j, k, l) > -(Yminloc(0) - Ycoord) + yprip And YobshrisN(jpred, k, l) > -(Yminloc(0) - Ycoord) + yprip Then
                                            element(j, k, l) = "Отрезок"
                                            'Конец пересекает низ, начало - нет
                                        ElseIf YobshrisN(j, k, l) > -(Yminloc(0) - Ycoord) + yprip + Dfrez(ni) * per / 2 And YobshrisN(jpred, k, l) <= -(Yminloc(0) - Ycoord) + yprip + Dfrez(ni) * per / 2 Then
                                            radius = Sqrt((XobshrisN(j, k, l) - TXotnC(j, k)) ^ 2 + (YobshrisN(j, k, l) - TYotnC(j, k)) ^ 2)
                                            Yrisvrem(j) = -(Yminloc(0) - Ycoord) + yprip + Dfrez(ni) * per / 2
                                            xj(0) = XobshrisN(j, k, l)
                                            yj(0) = YobshrisN(j, k, l)
                                            xj(1) = XobshrisN(jpred, k, l)
                                            yj(1) = YobshrisN(jpred, k, l)
                                            Discr = 4 * (TXotnC(j, k)) ^ 2 - 4 * ((TXotnC(j, k)) ^ 2 + (Yrisvrem(j) - TYotnC(j, k)) ^ 2 - radius ^ 2)
                                            x(0) = (2 * TXotnC(j, k) + Sqrt(Discr)) / 2
                                            x(1) = (2 * TXotnC(j, k) - Sqrt(Discr)) / 2
                                            For h = 0 To 1
                                                Ak(h) = Sqrt((x(h) - xj(1)) ^ 2 + (yj(0) - yj(1)) ^ 2)
                                                Bk(h) = Sqrt((x(h) - TXotnC(j, k)) ^ 2 + (yj(0) - TYotnC(j, k)) ^ 2)
                                                Ck(h) = Sqrt((xj(1) - TXotnC(j, k)) ^ 2 + (yj(1) - TYotnC(j, k)) ^ 2)
                                                alfa(h) = Math.Acos(theorcos(Ak(h), Bk(h), Ck(h))) * 180 / PI
                                                If alfa(h) > 180 Then
                                                    alfa(h) = 360 - alfa(h)
                                                End If
                                            Next
                                            If alfa(0) < alfa(1) Then
                                                Xrisvrem(j) = x(0)
                                            Else
                                                Xrisvrem(j) = x(1)
                                            End If

                                            'Начало пересекает низ, конец -  нет
                                        ElseIf YobshrisN(j, k, l) <= -(Yminloc(0) - Ycoord) + yprip + Dfrez(ni) * per / 2 And YobshrisN(jpred, k, l) > -(Yminloc(0) - Ycoord) + yprip + Dfrez(ni) * per / 2 Then

                                            radius = Sqrt((XobshrisN(jpred, k, l) - TXotnC(j, k)) ^ 2 + (YobshrisN(jpred, k, l) - TYotnC(j, k)) ^ 2)
                                            Yrisvrem(jpred) = -(Yminloc(0) - Ycoord) + yprip + Dfrez(ni) * per / 2
                                            xj(0) = XobshrisN(jpred, k, l)
                                            yj(0) = YobshrisN(jpred, k, l)
                                            xj(1) = XobshrisN(j, k, l)
                                            yj(1) = YobshrisN(j, k, l)
                                            Discr = 4 * (TXotnC(j, k)) ^ 2 - 4 * ((TXotnC(j, k)) ^ 2 + (Yrisvrem(jpred) - TYotnC(j, k)) ^ 2 - radius ^ 2)
                                            x(0) = (2 * TXotnC(j, k) + Sqrt(Discr)) / 2
                                            x(1) = (2 * TXotnC(j, k) - Sqrt(Discr)) / 2
                                            For h = 0 To 1
                                                Ak(h) = Sqrt((x(h) - xj(1)) ^ 2 + (yj(0) - yj(1)) ^ 2)
                                                Bk(h) = Sqrt((x(h) - TXotnC(j, k)) ^ 2 + (yj(0) - TYotnC(j, k)) ^ 2)
                                                Ck(h) = Sqrt((xj(1) - TXotnC(j, k)) ^ 2 + (yj(1) - TYotnC(j, k)) ^ 2)
                                                alfa(h) = Math.Acos(theorcos(Ak(h), Bk(h), Ck(h))) * 180 / PI
                                                If alfa(h) > 180 Then
                                                    alfa(h) = 360 - alfa(h)
                                                End If
                                                'With Form1.ListBox5.Items

                                                '    .Add("--------------------")
                                                '    .Add("D =" & Discr)
                                                '    .Add("x(" & h & ") =" & x(h))
                                                '    .Add("A(" & h & ") =" & Ak(h))
                                                '    .Add("B(" & h & ") =" & Bk(h))
                                                '    .Add("C(" & h & ") =" & Ck(h))
                                                '    .Add("alfa(" & h & ") =" & alfa(h))
                                                'End With
                                            Next
                                            If alfa(0) < alfa(1) Then
                                                Xrisvrem(jpred) = x(0)
                                            Else
                                                Xrisvrem(jpred) = x(1)
                                            End If
                                            'дуга полностью в заготовке
                                        ElseIf YobshrisN(j, k, l) <= -(Yminloc(0) - Ycoord) + yprip + Dfrez(ni) * per / 2 And YobshrisN(jpred, k, l) <= -(Yminloc(0) - Ycoord) + yprip + Dfrez(ni) * per / 2 Then
                                            'ничего не делаем
                                        End If
                                    End If
                                    'пересечение справа
                                ElseIf XobshrisN(j, k, l) > Xmaxloc(0) - Xcoord + xprip + Dfrez(ni) * per / 2 Or XobshrisN(jpred, k, l) > Xmaxloc(0) - Xcoord + xprip + Dfrez(ni) * per / 2 Then
                                    If element(j, k, l) = "Отрезок" Then
                                        'если отрезок вне заготовки полностью
                                        If XobshrisN(j, k, l) > Xmaxloc(0) - Xcoord + xprip + Dfrez(ni) * per / 2 And XobshrisN(jpred, k, l) > Xmaxloc(0) - Xcoord + xprip + Dfrez(ni) * per / 2 Then
                                            'Ничего не делаем

                                            'Конец пересекает справа, начало - нет
                                        ElseIf XobshrisN(j, k, l) > Xmaxloc(0) - Xcoord + xprip + Dfrez(ni) * per / 2 And XobshrisN(jpred, k, l) <= Xmaxloc(0) - Xcoord + xprip + Dfrez(ni) * per / 2 Then
                                            Xrisvrem(j) = Xmaxloc(0) - Xcoord + xprip + Dfrez(ni) * per / 2
                                            xj(0) = XobshrisN(jpred, k, l)
                                            yj(0) = YobshrisN(jpred, k, l)
                                            xj(1) = XobshrisN(j, k, l)
                                            yj(1) = YobshrisN(j, k, l)
                                            If xj(0) <> xj(1) Then
                                                kl = (yj(0) - yj(1)) / (xj(0) - xj(1))
                                                bl = yj(0) - kl * xj(0)
                                                If kl <> 0 Then
                                                    y(0) = k1 * Xrisvrem(j) + b1
                                                Else
                                                    Form1.ListBox5.Items.Add("нет пересечений")
                                                End If
                                            Else
                                                y(0) = yj(0)
                                            End If
                                            Yrisvrem(j) = y(0)
                                            'Начало пересекает низ, конец -  нет
                                        ElseIf XobshrisN(j, k, l) <= Xmaxloc(0) - Xcoord + xprip + Dfrez(ni) * per / 2 And XobshrisN(jpred, k, l) > Xmaxloc(0) - Xcoord + xprip + Dfrez(ni) * per / 2 Then
                                            Xrisvrem(jpred) = Xmaxloc(0) - Xcoord + xprip + Dfrez(ni) * per / 2
                                            xj(0) = XobshrisN(jpred, k, l)
                                            yj(0) = YobshrisN(jpred, k, l)
                                            xj(1) = XobshrisN(j, k, l)
                                            yj(1) = YobshrisN(j, k, l)
                                            If xj(0) <> xj(1) Then
                                                kl = (yj(0) - yj(1)) / (xj(0) - xj(1))
                                                bl = yj(0) - kl * xj(0)
                                                If kl <> 0 Then
                                                    y(0) = k1 * Xrisvrem(jpred) + b1
                                                Else
                                                    Form1.ListBox5.Items.Add("нет пересечений")
                                                End If
                                            Else
                                                y(0) = yj(0)
                                            End If
                                            Yrisvrem(j) = y(0)
                                            'отрезок полностью в заготовке
                                        ElseIf XobshrisN(j, k, l) <= Xmaxloc(0) - Xcoord + xprip + Dfrez(ni) * per / 2 And XobshrisN(jpred, k, l) <= Xmaxloc(0) - Xcoord + xprip + Dfrez(ni) * per / 2 Then
                                            'Ничего не делаем
                                        End If


                                    ElseIf element(j, k, l) = "Дуга" Then

                                        'если дуга вне заготовки полностью
                                        If XobshrisN(j, k, l) > Xmaxloc(0) - Xcoord + xprip + Dfrez(ni) * per / 2 And XobshrisN(jpred, k, l) > Xmaxloc(0) - Xcoord + xprip + Dfrez(ni) * per / 2 Then
                                            element(j, k, l) = "Отрезок"
                                            'Конец пересекает низ, начало - нет
                                        ElseIf XobshrisN(j, k, l) > Xmaxloc(0) - Xcoord + xprip + Dfrez(ni) * per / 2 And XobshrisN(jpred, k, l) <= Xmaxloc(0) - Xcoord + xprip + Dfrez(ni) * per / 2 Then
                                            radius = Sqrt((XobshrisN(j, k, l) - TXotnC(j, k)) ^ 2 + (YobshrisN(j, k, l) - TYotnC(j, k)) ^ 2)
                                            Xrisvrem(j) = Xmaxloc(0) - Xcoord + xprip + Dfrez(ni) * per / 2
                                            xj(0) = XobshrisN(j, k, l)
                                            yj(0) = YobshrisN(j, k, l)
                                            xj(1) = XobshrisN(jpred, k, l)
                                            yj(1) = YobshrisN(jpred, k, l)
                                            Discr = 4 * (TYotnC(j, k)) ^ 2 - 4 * ((TYotnC(j, k)) ^ 2 + (Xrisvrem(j) - TXotnC(j, k)) ^ 2 - radius ^ 2)
                                            y(0) = (2 * TYotnC(j, k) + Sqrt(Discr)) / 2
                                            y(1) = (2 * TYotnC(j, k) - Sqrt(Discr)) / 2
                                            For h = 0 To 1
                                                Ak(h) = Sqrt((xj(0) - Xrisvrem(j)) ^ 2 + (yj(0) - y(h)) ^ 2)
                                                Bk(h) = Sqrt((xj(0) - TXotnC(j, k)) ^ 2 + (yj(0) - TYotnC(j, k)) ^ 2)
                                                Ck(h) = Sqrt((Xrisvrem(j) - TXotnC(j, k)) ^ 2 + (y(h) - TYotnC(j, k)) ^ 2)
                                                alfa(h) = Math.Acos(theorcos(Ak(h), Bk(h), Ck(h))) * 180 / PI
                                                If alfa(h) > 180 Then
                                                    alfa(h) = 360 - alfa(h)
                                                End If
                                                'With Form1.ListBox5.Items

                                                '    .Add("-------------------1")
                                                '    .Add("D =" & Discr)
                                                '    .Add("y(" & h & ") =" & y(h))
                                                '    .Add("A(" & h & ") =" & Ak(h))
                                                '    .Add("B(" & h & ") =" & Bk(h))
                                                '    .Add("C(" & h & ") =" & Ck(h))
                                                '    .Add("alfa(" & h & ") =" & alfa(h))
                                                'End With
                                            Next
                                            If alfa(0) < alfa(1) Then
                                                Yrisvrem(j) = y(0)
                                            Else
                                                Yrisvrem(j) = y(1)
                                            End If

                                            'Начало пересекает справа, конец -  нет
                                        ElseIf XobshrisN(j, k, l) <= Xmaxloc(0) - Xcoord + xprip + Dfrez(ni) * per / 2 And XobshrisN(jpred, k, l) > Xmaxloc(0) - Xcoord + xprip + Dfrez(ni) * per / 2 Then

                                            radius = Sqrt((XobshrisN(j, k, l) - TXotnC(j, k)) ^ 2 + (YobshrisN(j, k, l) - TYotnC(j, k)) ^ 2)
                                            Xrisvrem(jpred) = Xmaxloc(0) - Xcoord + xprip + Dfrez(ni) * per / 2
                                            xj(0) = XobshrisN(j, k, l)
                                            yj(0) = YobshrisN(j, k, l)
                                            xj(1) = XobshrisN(jpred, k, l)
                                            yj(1) = YobshrisN(jpred, k, l)
                                            Discr = 4 * (TYotnC(j, k)) ^ 2 - 4 * ((TYotnC(j, k)) ^ 2 + (Xrisvrem(jpred) - TXotnC(j, k)) ^ 2 - radius ^ 2)
                                            y(0) = (2 * TYotnC(j, k) + Sqrt(Discr)) / 2
                                            y(1) = (2 * TYotnC(j, k) - Sqrt(Discr)) / 2
                                            For h = 0 To 1
                                                Ak(h) = Sqrt((xj(0) - xj(1)) ^ 2 + (yj(0) - y(h)) ^ 2)
                                                Bk(h) = Sqrt((xj(0) - TXotnC(j, k)) ^ 2 + (yj(0) - TYotnC(j, k)) ^ 2)
                                                Ck(h) = Sqrt((xj(1) - TXotnC(j, k)) ^ 2 + (y(h) - TYotnC(j, k)) ^ 2)
                                                alfa(h) = Math.Acos(theorcos(Ak(h), Bk(h), Ck(h))) * 180 / PI
                                                If alfa(h) > 180 Then
                                                    alfa(h) = 360 - alfa(h)
                                                End If
                                                'With Form1.ListBox5.Items

                                                '    .Add("-------------------2")
                                                '    .Add("D =" & Discr)
                                                '    .Add("y(" & h & ") =" & y(h))
                                                '    .Add("A(" & h & ") =" & Ak(h))
                                                '    .Add("B(" & h & ") =" & Bk(h))
                                                '    .Add("C(" & h & ") =" & Ck(h))
                                                '    .Add("alfa(" & h & ") =" & alfa(h))
                                                'End With
                                            Next
                                            If alfa(0) < alfa(1) Then
                                                Yrisvrem(jpred) = y(0)
                                            Else
                                                Yrisvrem(jpred) = y(1)
                                            End If
                                            'дуга полностью в заготовке
                                        ElseIf XobshrisN(j, k, l) <= Xmaxloc(0) - Xcoord + xprip + Dfrez(ni) * per / 2 And XobshrisN(jpred, k, l) <= Xmaxloc(0) - Xcoord + xprip + Dfrez(ni) * per / 2 Then
                                            'ничего не делаем
                                        End If
                                    End If

                                    'пересечение слева
                                ElseIf XobshrisN(j, k, l) < -xprip - Dfrez(ni) * per / 2 Or XobshrisN(jpred, k, l) < -xprip - Dfrez(ni) * per / 2 Then
                                    If element(j, k, l) = "Отрезок" Then
                                        'если отрезок вне заготовки полностью
                                        If XobshrisN(j, k, l) < -xprip - Dfrez(ni) * per / 2 And XobshrisN(jpred, k, l) < -xprip - Dfrez(ni) * per / 2 Then
                                            'Ничего не делаем

                                            'Конец пересекает слева, начало - нет
                                        ElseIf XobshrisN(j, k, l) < -xprip - Dfrez(ni) * per / 2 And XobshrisN(jpred, k, l) >= -xprip - Dfrez(ni) * per / 2 Then
                                            Xrisvrem(j) = -xprip - Dfrez(ni) * per / 2
                                            xj(0) = XobshrisN(jpred, k, l)
                                            yj(0) = YobshrisN(jpred, k, l)
                                            xj(1) = XobshrisN(j, k, l)
                                            yj(1) = YobshrisN(j, k, l)
                                            If xj(0) <> xj(1) Then
                                                kl = (yj(0) - yj(1)) / (xj(0) - xj(1))
                                                bl = yj(0) - kl * xj(0)
                                                If kl <> 0 Then
                                                    y(0) = k1 * Xrisvrem(j) + b1
                                                Else
                                                    Form1.ListBox5.Items.Add("нет пересечений")
                                                End If
                                            Else
                                                y(0) = yj(0)
                                            End If
                                            Yrisvrem(j) = y(0)
                                            'Начало пересекает низ, конец -  нет
                                        ElseIf XobshrisN(j, k, l) >= -xprip - Dfrez(ni) * per / 2 And XobshrisN(jpred, k, l) < -xprip - Dfrez(ni) * per / 2 Then
                                            Xrisvrem(j) = -xprip - Dfrez(ni) * per / 2
                                            xj(0) = XobshrisN(jpred, k, l)
                                            yj(0) = YobshrisN(jpred, k, l)
                                            xj(1) = XobshrisN(j, k, l)
                                            yj(1) = YobshrisN(j, k, l)
                                            If xj(0) <> xj(1) Then
                                                kl = (yj(0) - yj(1)) / (xj(0) - xj(1))
                                                bl = yj(0) - kl * xj(0)
                                                If kl <> 0 Then
                                                    y(0) = k1 * Xrisvrem(jpred) + b1
                                                Else
                                                    Form1.ListBox5.Items.Add("нет пересечений")
                                                End If
                                            Else
                                                y(0) = yj(0)
                                            End If
                                            Yrisvrem(j) = y(0)
                                            'отрезок полностью в заготовке
                                        ElseIf XobshrisN(j, k, l) >= -xprip - Dfrez(ni) * per / 2 And XobshrisN(jpred, k, l) >= -xprip - Dfrez(ni) * per / 2 Then
                                            'Ничего не делаем
                                        End If


                                    ElseIf element(j, k, l) = "Дуга" Then

                                        'если дуга вне заготовки полностью
                                        If XobshrisN(j, k, l) < -xprip - Dfrez(ni) * per / 2 And XobshrisN(jpred, k, l) < -xprip - Dfrez(ni) * per / 2 Then
                                            element(j, k, l) = "Отрезок"
                                            'Конец пересекает низ, начало - нет
                                        ElseIf XobshrisN(j, k, l) < -xprip - Dfrez(ni) * per / 2 And XobshrisN(jpred, k, l) >= -xprip - Dfrez(ni) * per / 2 Then
                                            radius = Sqrt((XobshrisN(j, k, l) - TXotnC(j, k)) ^ 2 + (YobshrisN(j, k, l) - TYotnC(j, k)) ^ 2)
                                            Xrisvrem(j) = -xprip - Dfrez(ni) * per / 2
                                            xj(0) = XobshrisN(jpred, k, l)
                                            yj(0) = YobshrisN(jpred, k, l)
                                            xj(1) = XobshrisN(j, k, l)
                                            yj(1) = YobshrisN(j, k, l)
                                            Discr = 4 * (TYotnC(j, k)) ^ 2 - 4 * ((TYotnC(j, k)) ^ 2 + (Xrisvrem(j) - TXotnC(j, k)) ^ 2 - radius ^ 2)
                                            y(0) = (2 * TYotnC(j, k) + Sqrt(Discr)) / 2
                                            y(1) = (2 * TYotnC(j, k) - Sqrt(Discr)) / 2
                                            For h = 0 To 1
                                                Ak(h) = Sqrt((xj(0) - Xrisvrem(j)) ^ 2 + (yj(0) - y(h)) ^ 2)
                                                Bk(h) = Sqrt((xj(0) - TXotnC(j, k)) ^ 2 + (yj(0) - TYotnC(j, k)) ^ 2)
                                                Ck(h) = Sqrt((Xrisvrem(j) - TXotnC(j, k)) ^ 2 + (y(h) - TYotnC(j, k)) ^ 2)
                                                alfa(h) = Math.Acos(theorcos(Ak(h), Bk(h), Ck(h))) * 180 / PI
                                                If alfa(h) > 180 Then
                                                    alfa(h) = 360 - alfa(h)
                                                End If
                                                'With Form1.ListBox5.Items

                                                '    .Add("-------------------1")
                                                '    .Add("D =" & Discr)
                                                '    .Add("y(" & h & ") =" & y(h))
                                                '    .Add("A(" & h & ") =" & Ak(h))
                                                '    .Add("B(" & h & ") =" & Bk(h))
                                                '    .Add("C(" & h & ") =" & Ck(h))
                                                '    .Add("alfa(" & h & ") =" & alfa(h))
                                                'End With
                                            Next
                                            If alfa(0) < alfa(1) Then
                                                Yrisvrem(j) = y(0)
                                            Else
                                                Yrisvrem(j) = y(1)
                                            End If

                                            'Начало пересекает справа, конец -  нет
                                        ElseIf XobshrisN(j, k, l) >= -xprip - Dfrez(ni) * per / 2 And XobshrisN(jpred, k, l) < -xprip - Dfrez(ni) * per / 2 Then

                                            radius = Sqrt((XobshrisN(j, k, l) - TXotnC(j, k)) ^ 2 + (YobshrisN(j, k, l) - TYotnC(j, k)) ^ 2)
                                            Xrisvrem(jpred) = -xprip - Dfrez(ni) * per / 2
                                            xj(0) = XobshrisN(j, k, l)
                                            yj(0) = YobshrisN(j, k, l)
                                            xj(1) = XobshrisN(jpred, k, l)
                                            yj(1) = YobshrisN(jpred, k, l)
                                            Discr = 4 * (TYotnC(j, k)) ^ 2 - 4 * ((TYotnC(j, k)) ^ 2 + (Xrisvrem(jpred) - TXotnC(j, k)) ^ 2 - radius ^ 2)
                                            y(0) = (2 * TYotnC(j, k) + Sqrt(Discr)) / 2
                                            y(1) = (2 * TYotnC(j, k) - Sqrt(Discr)) / 2
                                            For h = 0 To 1
                                                Ak(h) = Sqrt((xj(0) - xj(1)) ^ 2 + (yj(0) - y(h)) ^ 2)
                                                Bk(h) = Sqrt((xj(0) - TXotnC(j, k)) ^ 2 + (yj(0) - TYotnC(j, k)) ^ 2)
                                                Ck(h) = Sqrt((xj(1) - TXotnC(j, k)) ^ 2 + (y(h) - TYotnC(j, k)) ^ 2)
                                                alfa(h) = Math.Acos(theorcos(Ak(h), Bk(h), Ck(h))) * 180 / PI
                                                If alfa(h) > 180 Then
                                                    alfa(h) = 360 - alfa(h)
                                                End If
                                                'With Form1.ListBox5.Items

                                                '    .Add("-------------------2")
                                                '    .Add("D =" & Discr)
                                                '    .Add("y(" & h & ") =" & y(h))
                                                '    .Add("A(" & h & ") =" & Ak(h))
                                                '    .Add("B(" & h & ") =" & Bk(h))
                                                '    .Add("C(" & h & ") =" & Ck(h))
                                                '    .Add("alfa(" & h & ") =" & alfa(h))
                                                'End With
                                            Next
                                            If alfa(0) < alfa(1) Then
                                                Yrisvrem(jpred) = y(0)
                                            Else
                                                Yrisvrem(jpred) = y(1)
                                            End If
                                            'дуга полностью в заготовке
                                        ElseIf XobshrisN(j, k, l) >= -xprip - Dfrez(ni) * per / 2 And XobshrisN(jpred, k, l) >= -xprip - Dfrez(ni) * per / 2 Then
                                            'ничего не делаем
                                        End If
                                    End If


                                End If


                            Next
                        Next

                        For j = 0 To kolvo(k, l) - 1
                            If Xrisvrem(j) <> 0 Or Yrisvrem(j) <> 0 Then
                                XobshrisN(j, k, l) = Xrisvrem(j)
                                YobshrisN(j, k, l) = Yrisvrem(j)
                                GcodeXN(j, k, l) = Round(XobshrisN(j, k, l) + xprip, 3)
                                GcodeYN(j, k, l) = Round(-YobshrisN(j, k, l) - yprip, 3)
                                GcodeR(j, k, l) = Round(Sqrt((XobshrisN(j, k, l) - TXotnC(j, k)) ^ 2 + (YobshrisN(j, k, l) - TYotnC(j, k)) ^ 2), 3)
                            End If
                        Next

                    Next
                Next

                i = 0
                k = 0
            End If
        Catch ex As Exception
            Dim stacktr As New StackTrace(ex, True)
            If stacktr.FrameCount > 0 Then
                Dim stackfr As New StackFrame
                stackfr = stacktr.GetFrame(0)
                Dim errorline As Integer = stackfr.GetFileLineNumber()
                Dim functionname As String = stackfr.GetMethod().Name
                Form1.ListBox5.Items.Add("Ошибка в " & functionname & " на линии" & errorline)
                p = p + 1

            End If
        End Try
    End Function
    Public Function ris_duga(Nachtchk As Drawing.PointF, Kontchk As Drawing.PointF, Centrtch As Drawing.PointF, mypen As Pen)
        Dim radius As Single
        radius = Sqrt((Nachtchk.X - Centrtch.X) ^ 2 + (Nachtchk.Y - Centrtch.Y) ^ 2)
        'MsgBox("radius=" & radius)
        'находим нужный У
        'Dim discr As Single
        Dim rast(2), y(2) As Single
        Dim kontchkN As Drawing.PointF
        kontchkN.Y = Kontchk.Y
        Dim a, b, e, s As Single
        Dim rec As Rectangle
        a = Round((Nachtchk.Y - Centrtch.Y) * radius, 6) : b = Round((Nachtchk.X - Centrtch.X) * radius, 6) : s = Round(Math.Atan2(a, b), 6)
        a = Round((kontchkN.Y - Centrtch.Y) * radius, 6) : b = Round((Kontchk.X - Centrtch.X) * radius, 6) : e = Round(Math.Atan2(a, b), 6)

        rec.X = Centrtch.X - radius + Sdvg
        rec.Y = Centrtch.Y - radius + Sdvg
        rec.Width = 2 * radius
        rec.Height = 2 * radius
        If e < 0 Then e = 2 * PI + e
        If s < 0 Then s = 2 * PI + s
        e = e * 180 / PI
        s = s * 180 / PI
        If j < kolvo(0, l) - 1 Then

            ' If element(j - 1, k, l) = "Дуга" And element(j, k, l) = "Дуга" And Sqrt((XotnobshC(j - 1, l) - XotnobshC(j, l)) ^ 2 + (YotnobshC(j - 1, l) - YotnobshC(j, l)) ^ 2) > Max(robsh(j), robsh(j - 1)) Then
            If Vipuklost(j, l) = "Внутри" Then

                If Math.Abs(e - s) <= 180 Then
                    a = minus * Math.Abs(e - s)
                Else
                    a = minus * (360 - Math.Abs(e - s))
                End If
                minus = -minus
            Else
                If Math.Abs(e - s) <= 180 Then
                    a = Math.Abs(e - s)
                Else
                    a = 360 - Math.Abs(e - s)
                End If
            End If
        Else
            If Vipuklost(j, l) = "Внутри" Then
                ' If element(kolvo(k, l) - 1, k, l) = "Дуга" And element(j, k, l) = "Дуга" And Sqrt((XotnobshC(kolvo(k, l) - 1, l) - XotnobshC(j, l)) ^ 2 + (YotnobshC(kolvo(k, l) - 1, l) - YotnobshC(j, l)) ^ 2) > Max(robsh(j), robsh(kolvo(k, l) - 1)) Then
                If Math.Abs(e - s) <= 180 Then
                    a = minus * Math.Abs(e - s)
                Else
                    a = minus * (360 - Math.Abs(e - s))
                End If
                minus = -minus
            Else
                If Math.Abs(e - s) <= 180 Then
                    a = Math.Abs(e - s)
                Else
                    a = 360 - Math.Abs(e - s)
                End If
            End If
        End If
        If j <= kolvo(k, l) - 2 Then
            If element(j + 1, k, l) = "Отрезок" Then minus = -1
        Else
            If element(0, k, l) = "Отрезок" Then minus = -1
        End If
        Kontour.DrawArc(mypen, rec, s, a)
        'Form4.gr.DrawArc(Pens.Blue, rec, s, a)
        Exit Function
    End Function
    Public Function koltcevaya_traertoria()
        Dim temp As Single
        'j = i
        If j > 0 Then
            If Round(XabsobshK(j - 1, l), 2) <> Round(XabsobshN(j, l), 2) Or Round(YabsobshK(j - 1, l), 2) <> Round(YabsobshN(j, l), 2) Then
                temp = XabsobshN(j, l)
                XabsobshN(j, l) = XabsobshK(j, l)
                XabsobshK(j, l) = temp

                temp = XobshotnN(j, l)
                XobshotnN(j, l) = XobshotnK(j, l)
                XobshotnK(j, l) = temp


                temp = YabsobshN(j, l)
                YabsobshN(j, l) = YabsobshK(j, l)
                YabsobshK(j, l) = temp

                temp = YobshotnN(j, l)
                YobshotnN(j, l) = YobshotnK(j, l)
                YobshotnK(j, l) = temp
            Else
                Exit Function
            End If
        Else
            If Round(XabsobshK(kolvo(0, l) - 1, l), 2) <> Round(XabsobshN(j, l), 2) And Round(YabsobshK(kolvo(0, l), l), 2) <> Round(YabsobshN(j, l), 2) Then
                temp = XabsobshN(j, l)
                XabsobshN(j, l) = XabsobshK(j, l)
                XabsobshK(j, l) = temp

                temp = XobshotnN(j, l)
                XobshotnN(j, l) = XobshotnK(j, l)
                XobshotnK(j, l) = temp

                temp = YabsobshN(j, l)
                YabsobshN(j, l) = YabsobshK(j, l)
                YabsobshK(j, l) = temp

                temp = YobshotnN(j, l)
                YobshotnN(j, l) = YobshotnK(j, l)
                YobshotnK(j, l) = temp
            Else
                Exit Function
            End If
        End If


    End Function


    Public Function theorcos(A As Single, B As Single, C As Single) As Single
        theorcos = ((-A ^ 2 + B ^ 2 + C ^ 2) / (2 * B * C))
    End Function
    'Public Function otladka(A As String, B As String)
    '    Dim f As Integer
    '    f = Form1.ListBox3.SelectedIndex
    '    Form4.PictureBox1.Image = Nothing
    '    Form4.PictureBox1.Refresh()
    '    'Form4.gr.DrawString(A, New Font("Arial", 12), Brushes.Black, XtchkontK1(f) + Sdvg, YtchkontK1(f) + Sdvg + 10)
    '    'Form4.gr.DrawString(B, New Font("Arial", 12), Brushes.Green, XtchkontK1(f) + Sdvg, YtchkontK1(f) + Sdvg + 20)
    '    'Form4.gr.DrawLine(Pens.Red, XtchkontK1(f) + Sdvg, YtchkontK1(f) + Sdvg, XtchkontN1(f) + Sdvg, YtchkontN1(f) + Sdvg)
    '    'Form4.gr.DrawLine(Pens.Red, XtchkontK1(f) + Sdvg, YtchkontK1(f) + Sdvg, XtchkontK2(f) + Sdvg, YtchkontK2(f) + Sdvg)
    '    'Form4.gr.DrawString("K2", New Font("Arial", 12), Brushes.Black, XtchkontK2(f) + Sdvg, YtchkontK2(f) + Sdvg)
    '    'Form4.gr.DrawString("N1", New Font("Arial", 12), Brushes.Black, XtchkontN1(f) + Sdvg, YtchkontN1(f) + Sdvg)

    '    'Form4.gr.DrawLine(Pens.Blue, XtchkontK1(f) + Sdvg, YtchkontK1(f) + Sdvg, XtchkontK1(f) + Sdvg + Convert.ToSingle(markerX * 50 * Sin(tau(f) * PI / 180)), YtchkontK1(f) + Sdvg + Convert.ToSingle(markerY * 50 * Cos(tau(f) * PI / 180)))

    'End Function
    Public Function rachet_traectorii_mod_3()
        Dim A, Bi, E, Ci, Di, R1, R2, xp2, yp2 As Single

        Dim xk1_1(1), xk1_2(1), xn1(1), xk2(1), yk1_1(1), yk1_2(1), yn1(1), yk2(1) As Single
        Dim k1(1), k2(1), b1(1), b2(1), x3(1), y3(1) As Single
        Dim x_ekv_n1, x_ekv_k1_1, y_ekv_n1, y_ekv_k1_1 As Single
        Dim R(1) As Single
        Dim x3_it(4), y3_it(4) As Single

        Dim jpred As Integer
        Dim opoint(3) As PointF
        crcell = Form1.DataGridView2.CurrentCell.RowIndex
        l = crcell
        kp = kpobsh(crcell)


        j = 0
        'kolvo = kolvoobsh(crcell)
        ' Form4.Show()
        'If nadolimenyat(0, 0, l) = False Then
        For k = 0 To kp
            kolvo(k, l) = kolvo(0, l)
            For j = 0 To kolvo(0, l)

                element(j, k, l) = element(j, 0, l)
                TXotnN(j, k) = Round(XobshotnN(j, l), 3)
                TXotnK(j, k) = Round(XobshotnK(j, l), 3)
                TYotnN(j, k) = Round(YobshotnN(j, l), 3)
                TYotnK(j, k) = Round(YobshotnK(j, l), 3)
                TXotnS(j, k) = Round(XobshotnS(j, l), 3)
                TYotnS(j, k) = Round(YobshotnS(j, l), 3)
                TXotnC(j, k) = Round(XotnobshC(j, l), 3)
                TYotnC(j, k) = Round(YotnobshC(j, l), 3)
            Next
        Next
        'End If
        Try
            If viborRB(crcell) = "Vneshniy contour" Or viborRB(crcell) = "Vnutrenniy contour" Or viborRB(crcell) = "Ustup" Then
                For k = 1 To kp
                    For j = 0 To kolvo(k, l) - 1
                        If element(j, k, l) = "Дуга" Then
                            robsh(j) = Sqrt((TXotnN(j, k) - TXotnC(j, k)) ^ 2 + (TYotnN(j, k) - TYotnC(j, k)) ^ 2)
                            If robsh(j) <= Dfrez(ni) / 2 + Dfrez(ni) / 2 * per * (k - 1) And ((viborRB(crcell) = "Vneshniy contour" And Vipuklost(jnext, l) = "Внутри") Or (viborRB(crcell) = "Vnutrenniy contour" And Vipuklost(jnext, l) = "Снаружи")) Then
                                ' nadolimenyat(0, 0, l) = True
                                kolvo(k, l) = kolvo(k, l) - 1

                                For h = j To kolvo(k, l) - 1
                                    If h < kolvo(k, l) Then
                                        jnext = h + 1
                                    Else
                                        jnext = 0
                                    End If
                                    element(h, k, l) = element(jnext, k, l)
                                    TXotnN(h, k) = TXotnN(jnext, k)
                                    TYotnN(h, k) = TYotnN(jnext, k)
                                    TXotnK(h, k) = TXotnK(jnext, k)
                                    TYotnK(h, k) = TYotnK(jnext, k)
                                    TXotnC(h, k) = TXotnC(jnext, k)
                                    TYotnC(h, k) = TYotnC(jnext, k)
                                    TXotnS(h, k) = TXotnS(jnext, k)
                                    TYotnS(h, k) = TYotnS(jnext, k)
                                Next

                                If j < kolvo(k, l) - 1 Then
                                    jnext = j + 1
                                Else
                                    jnext = 0
                                End If
                                If j > 0 Then
                                    jpred = j - 1
                                Else
                                    jpred = kolvo(k, l) - 1
                                End If

                                opoint(0).X = TXotnN(jpred, k)
                                opoint(0).Y = TYotnN(jpred, k)

                                opoint(1).X = TXotnK(jpred, k)
                                opoint(1).Y = TYotnK(jpred, k)


                                opoint(2).X = TXotnN(j, k)
                                opoint(2).Y = TYotnN(j, k)

                                opoint(3).X = TXotnK(j, k)
                                opoint(3).Y = TYotnK(j, k)

                                TXotnK(jpred, k) = peresech(opoint(0), opoint(1), opoint(2), opoint(3)).X
                                TYotnK(jpred, k) = peresech(opoint(0), opoint(1), opoint(2), opoint(3)).Y
                                TXotnN(j, k) = TXotnK(jpred, k)
                                TYotnN(j, k) = TYotnK(jpred, k)
                                ' Kontour.DrawEllipse(Pens.Green, TXotnK(jpred, k) + Sdvg - 3, TYotnK(jpred, k) + Sdvg - 3, 6, 6)
                            End If
                        ElseIf element(j, k, l) = "Отрезок" Then
                            If Sqrt((TXotnN(j, k) - TXotnC(j, k)) ^ 2 + (TYotnN(j, k) - TYotnC(j, k)) ^ 2) <= Dfrez(ni) / 2 + Dfrez(ni) / 2 * per * (k - 1) Then
                                Kontour.DrawEllipse(Pens.Blue, TXotnK(j, k) + Sdvg - 3, TYotnK(j, k) + Sdvg - 3, 6, 6)
                            End If
                        End If
                    Next
                Next
                For k = 1 To kp
                    ' j = 0
                    For j = 0 To kolvo(k, l) - 1
                        If j < kolvo(k, l) - 1 Then
                            jnext = j + 1
                        Else
                            jnext = 0
                        End If

                        If element(j, k, l) = "Окружность" Then
                            'If j = 0 Then k = k - 1
                            If viborRB(crcell) = "Vneshniy contour" Then
                                Robshris(j, k, l) = diamokr(j, l) / 2 + Dfrez(ni) / 2 + prip + (k - 1) * per * Dfrez(ni) / 2
                                GcodeXN(j, k, l) = Round(XotnobshC(j, l) + Robshris(j, k, l) + xprip, 3)
                                GcodeXK(j, k, l) = Round(XotnobshC(j, l) - Robshris(j, k, l) + xprip, 3)
                            ElseIf viborRB(crcell) = "Vnutrenniy contour" Then
                                Robshris(j, k, l) = diamokr(j, l) / 2 - Dfrez(ni) / 2 - prip - (k - 1) * per * Dfrez(ni) / 2
                                GcodeXN(j, k, l) = Round(XotnobshC(j, l) - Robshris(j, k, l) + xprip, 3)
                                GcodeXK(j, k, l) = Round(XotnobshC(j, l) + Robshris(j, k, l) + xprip, 3)
                            End If
                            GcodeR(j, k, l) = Round(Robshris(j, k, l), 3)
                            GcodeYN(j, k, l) = Round(-YotnobshC(j, l) - yprip, 3)
                            GcodeYK(j, k, l) = Round(-YotnobshC(j, l) - yprip, 3)

                        ElseIf element(j, k, l) = "Отрезок" Then

                            If element(jnext, k, l) = "Отрезок" Then
                                For s = 0 To 1
                                    If s = 0 Then
                                        x_ekv_k1_1 = reshSAY(TXotnK(j, k), TYotnK(j, k), TXotnN(j, k), TYotnN(j, k), (Dfrez(ni) / 2 + (k - 1) * per * Dfrez(ni) / 2)).x3_1
                                        y_ekv_k1_1 = reshSAY(TXotnK(j, k), TYotnK(j, k), TXotnN(j, k), TYotnN(j, k), (Dfrez(ni) / 2 + (k - 1) * per * Dfrez(ni) / 2)).y3_1
                                    Else
                                        x_ekv_k1_1 = reshSAY(TXotnK(j, k), TYotnK(j, k), TXotnN(j, k), TYotnN(j, k), (Dfrez(ni) / 2 + (k - 1) * per * Dfrez(ni) / 2)).x3_2
                                        y_ekv_k1_1 = reshSAY(TXotnK(j, k), TYotnK(j, k), TXotnN(j, k), TYotnN(j, k), (Dfrez(ni) / 2 + (k - 1) * per * Dfrez(ni) / 2)).y3_2
                                    End If
                                    If TXotnK(j, k) = TXotnN(j, k) And TYotnN(j, k) <> TYotnK(j, k) Then
                                        x_ekv_n1 = x_ekv_k1_1
                                        y_ekv_n1 = TYotnN(j, k)
                                    ElseIf TXotnK(j, k) <> TXotnN(j, k) And TYotnN(j, k) = TYotnK(j, k) Then
                                        x_ekv_n1 = TXotnN(j, k)
                                        y_ekv_n1 = y_ekv_k1_1
                                    Else
                                        If Round((x_ekv_k1_1 - reshSAY(TXotnN(j, k), TYotnN(j, k), TXotnK(j, k), TYotnK(j, k), (Dfrez(ni) / 2 + (k - 1) * per * Dfrez(ni) / 2)).x3_1) / (TXotnK(j, k) - TXotnN(j, k)), 1) = Round((y_ekv_k1_1 - reshSAY(TXotnN(j, k), TYotnN(j, k), TXotnK(j, k), TYotnK(j, k), (Dfrez(ni) / 2 + (k - 1) * per * Dfrez(ni) / 2)).y3_1) / (TYotnK(j, k) - TYotnN(j, k)), 1) Then
                                            x_ekv_n1 = reshSAY(TXotnN(j, k), TYotnN(j, k), TXotnK(j, k), TYotnK(j, k), (Dfrez(ni) / 2 + (k - 1) * per * Dfrez(ni) / 2)).x3_1
                                            y_ekv_n1 = reshSAY(TXotnN(j, k), TYotnN(j, k), TXotnK(j, k), TYotnK(j, k), (Dfrez(ni) / 2 + (k - 1) * per * Dfrez(ni) / 2)).y3_1
                                        Else
                                            x_ekv_n1 = reshSAY(TXotnN(j, k), TYotnN(j, k), TXotnK(j, k), TYotnK(j, k), (Dfrez(ni) / 2 + (k - 1) * per * Dfrez(ni) / 2)).x3_2
                                            y_ekv_n1 = reshSAY(TXotnN(j, k), TYotnN(j, k), TXotnK(j, k), TYotnK(j, k), (Dfrez(ni) / 2 + (k - 1) * per * Dfrez(ni) / 2)).y3_2
                                        End If
                                    End If
                                    'Try
                                    xk1_2(0) = reshSAY(TXotnK(j, k), TYotnK(j, k), TXotnK(jnext, k), TYotnK(jnext, k), (Dfrez(ni) / 2 + (k - 1) * per * Dfrez(ni) / 2)).x3_1
                                    yk1_2(0) = reshSAY(TXotnK(j, k), TYotnK(j, k), TXotnK(jnext, k), TYotnK(jnext, k), (Dfrez(ni) / 2 + (k - 1) * per * Dfrez(ni) / 2)).y3_1
                                    If TXotnK(j, k) = TXotnK(jnext, k) And TYotnK(jnext, k) <> TYotnK(j, k) Then
                                        xk2(0) = xk1_2(0)
                                        yk2(0) = TYotnK(jnext, k)
                                        x3(0) = xk2(0)
                                        If TXotnN(j, k) = TXotnK(j, k) And TYotnN(j, k) <> TYotnK(j, k) Then
                                            y3(0) = TYotnK(j, k)
                                        ElseIf TXotnN(j, k) <> TXotnK(j, k) And TYotnN(j, k) = TYotnK(j, k) Then
                                            y3(0) = y_ekv_n1
                                        Else
                                            k1(0) = (y_ekv_k1_1 - y_ekv_n1) / (x_ekv_k1_1 - x_ekv_n1)
                                            b1(0) = y_ekv_k1_1 - k1(0) * x_ekv_k1_1
                                            y3(0) = k1(0) * x3(0) + b1(0)

                                        End If
                                    ElseIf TXotnK(j, k) <> TXotnK(jnext, k) And TYotnK(jnext, k) = TYotnK(j, k) Then
                                        xk2(0) = TYotnK(jnext, k)
                                        yk2(0) = yk1_2(0)
                                        y3(0) = yk2(0)
                                        If TXotnN(j, k) = TXotnK(j, k) And TYotnN(j, k) <> TYotnK(j, k) Then
                                            x3(0) = x_ekv_n1
                                        ElseIf TXotnN(j, k) <> TXotnK(j, k) And TYotnN(j, k) = TYotnK(j, k) Then
                                            x3(0) = TXotnK(j, k)
                                        Else
                                            k1(0) = (y_ekv_k1_1 - y_ekv_n1) / (x_ekv_k1_1 - x_ekv_n1)
                                            b1(0) = y_ekv_k1_1 - k1(0) * x_ekv_k1_1
                                            x3(0) = (y3(0) - b1(0)) / k1(0)
                                        End If
                                    Else
                                        If Round((xk1_2(0) - reshSAY(TXotnK(jnext, k), TYotnK(jnext, k), TXotnK(j, k), TYotnK(j, k), (Dfrez(ni) / 2 + (k - 1) * per * Dfrez(ni) / 2)).x3_1) / (TXotnK(j, k) - TXotnK(jnext, k)), 1) = Round((yk1_2(0) - reshSAY(TXotnK(jnext, k), TYotnK(jnext, k), TXotnK(j, k), TYotnK(j, k), (Dfrez(ni) / 2 + (k - 1) * per * Dfrez(ni) / 2)).y3_1) / (TYotnK(j, k) - TYotnK(jnext, k)), 1) Then
                                            xk2(0) = reshSAY(TXotnK(jnext, k), TYotnK(jnext, k), TXotnK(j, k), TYotnK(j, k), (Dfrez(ni) / 2 + (k - 1) * per * Dfrez(ni) / 2)).x3_1
                                            yk2(0) = reshSAY(TXotnK(jnext, k), TYotnK(jnext, k), TXotnK(j, k), TYotnK(j, k), (Dfrez(ni) / 2 + (k - 1) * per * Dfrez(ni) / 2)).y3_1
                                        Else
                                            xk2(0) = reshSAY(TXotnK(jnext, k), TYotnK(jnext, k), TXotnK(j, k), TYotnK(j, k), (Dfrez(ni) / 2 + (k - 1) * per * Dfrez(ni) / 2)).x3_2
                                            yk2(0) = reshSAY(TXotnK(jnext, k), TYotnK(jnext, k), TXotnK(j, k), TYotnK(j, k), (Dfrez(ni) / 2 + (k - 1) * per * Dfrez(ni) / 2)).y3_2
                                        End If
                                        If TXotnN(j, k) = TXotnK(j, k) And TYotnN(j, k) <> TYotnK(j, k) Then
                                            x3(0) = x_ekv_n1
                                            k2(0) = (yk1_2(0) - yk2(0)) / (xk1_2(0) - xk2(0))
                                            b2(0) = yk1_2(0) - k2(0) * xk1_2(0)
                                            y3(0) = k2(0) * x3(0) + b2(0)

                                        ElseIf TXotnN(j, k) <> TXotnK(j, k) And TYotnN(j, k) = TYotnK(j, k) Then
                                            y3(0) = y_ekv_n1
                                            k2(0) = (yk1_2(0) - yk2(0)) / (xk1_2(0) - xk2(0))
                                            b2(0) = yk1_2(0) - k2(0) * xk1_2(0)
                                            x3(0) = (y3(0) - b2(0)) / k2(0)
                                        Else
                                            k1(0) = (y_ekv_k1_1 - y_ekv_n1) / (x_ekv_k1_1 - x_ekv_n1)
                                            b1(0) = y_ekv_k1_1 - k1(0) * x_ekv_k1_1

                                            k2(0) = (yk1_2(0) - yk2(0)) / (xk1_2(0) - xk2(0))
                                            b2(0) = yk1_2(0) - k2(0) * xk1_2(0)

                                            x3(0) = (b2(0) - b1(0)) / (k1(0) - k2(0))
                                            y3(0) = k1(0) * x3(0) + b1(0)
                                        End If
                                    End If

                                    xk1_2(1) = reshSAY(TXotnK(j, k), TYotnK(j, k), TXotnK(jnext, k), TYotnK(jnext, k), (Dfrez(ni) / 2 + (k - 1) * per * Dfrez(ni) / 2)).x3_2
                                    yk1_2(1) = reshSAY(TXotnK(j, k), TYotnK(j, k), TXotnK(jnext, k), TYotnK(jnext, k), (Dfrez(ni) / 2 + (k - 1) * per * Dfrez(ni) / 2)).y3_2

                                    If TXotnK(j, k) = TXotnK(jnext, k) And TYotnK(jnext, k) <> TYotnK(j, k) Then
                                        xk2(1) = xk1_2(1)
                                        yk2(1) = TYotnK(jnext, k)
                                        x3(1) = xk2(1)
                                        If TXotnN(j, k) = TXotnK(j, k) And TYotnN(j, k) <> TYotnK(j, k) Then
                                            y3(1) = TYotnK(j, k)
                                        ElseIf TXotnN(j, k) <> TXotnK(j, k) And TYotnN(j, k) = TYotnK(j, k) Then
                                            y3(1) = y_ekv_n1
                                        Else
                                            k1(1) = (y_ekv_k1_1 - y_ekv_n1) / (x_ekv_k1_1 - x_ekv_n1)
                                            b1(1) = y_ekv_k1_1 - k1(1) * x_ekv_k1_1
                                            y3(1) = k1(1) * x3(1) + b1(1)

                                        End If
                                    ElseIf TXotnK(j, k) <> TXotnK(jnext, k) And TYotnK(jnext, k) = TYotnK(j, k) Then
                                        xk2(1) = TXotnK(jnext, k)
                                        yk2(1) = yk1_2(1)
                                        y3(1) = yk2(1)
                                        If TXotnN(j, k) = TXotnK(j, k) And TYotnN(j, k) <> TYotnK(j, k) Then
                                            x3(1) = x_ekv_n1
                                        ElseIf TXotnN(j, k) <> TXotnK(j, k) And TYotnN(j, k) = TYotnK(j, k) Then
                                            x3(1) = TXotnK(j, k)
                                        Else
                                            k1(1) = (y_ekv_k1_1 - y_ekv_n1) / (x_ekv_k1_1 - x_ekv_n1)
                                            b1(1) = y_ekv_k1_1 - k1(1) * x_ekv_k1_1
                                            x3(1) = (y3(1) - b1(1)) / k1(1)
                                            ' MsgBox(x3(1))
                                        End If
                                    Else
                                        If Round((xk1_2(1) - reshSAY(TXotnK(jnext, k), TYotnK(jnext, k), TXotnK(j, k), TYotnK(j, k), (Dfrez(ni) / 2 + (k - 1) * per * Dfrez(ni) / 2)).x3_1) / (TXotnK(j, k) - TXotnK(jnext, k)), 1) = Round((yk1_2(1) - reshSAY(TXotnK(jnext, k), TYotnK(jnext, k), TXotnK(j, k), TYotnK(j, k), (Dfrez(ni) / 2 + (k - 1) * per * Dfrez(ni) / 2)).y3_1) / (TYotnK(j, k) - TYotnK(jnext, k)), 1) Then
                                            xk2(1) = reshSAY(TXotnK(jnext, k), TYotnK(jnext, k), TXotnK(j, k), TYotnK(j, k), (Dfrez(ni) / 2 + (k - 1) * per * Dfrez(ni) / 2)).x3_1
                                            yk2(1) = reshSAY(TXotnK(jnext, k), TYotnK(jnext, k), TXotnK(j, k), TYotnK(j, k), (Dfrez(ni) / 2 + (k - 1) * per * Dfrez(ni) / 2)).y3_1
                                        Else
                                            xk2(1) = reshSAY(TXotnK(jnext, k), TYotnK(jnext, k), TXotnK(j, k), TYotnK(j, k), (Dfrez(ni) / 2 + (k - 1) * per * Dfrez(ni) / 2)).x3_2
                                            yk2(1) = reshSAY(TXotnK(jnext, k), TYotnK(jnext, k), TXotnK(j, k), TYotnK(j, k), (Dfrez(ni) / 2 + (k - 1) * per * Dfrez(ni) / 2)).y3_2
                                        End If
                                        If TXotnN(j, k) = TXotnK(j, k) And TYotnN(j, k) <> TYotnK(j, k) Then
                                            x3(1) = x_ekv_n1
                                            k2(1) = (yk1_2(1) - yk2(1)) / (xk1_2(1) - xk2(1))
                                            b2(1) = yk1_2(1) - k2(1) * xk1_2(1)
                                            y3(1) = k2(1) * x3(1) + b2(1)

                                        ElseIf TXotnN(j, k) <> TXotnK(j, k) And TYotnN(j, k) = TYotnK(j, k) Then
                                            y3(1) = y_ekv_n1
                                            k2(1) = (yk1_2(1) - yk2(1)) / (xk1_2(1) - xk2(1))
                                            b2(1) = yk1_2(1) - k2(1) * xk1_2(1)
                                            x3(1) = (y3(1) - b2(1)) / k2(1)
                                        Else
                                            k1(1) = (y_ekv_k1_1 - y_ekv_n1) / (x_ekv_k1_1 - x_ekv_n1)
                                            b1(1) = y_ekv_k1_1 - k1(1) * x_ekv_k1_1

                                            k2(1) = (yk1_2(1) - yk2(1)) / (xk1_2(1) - xk2(1))
                                            b2(1) = yk1_2(1) - k2(1) * xk1_2(1)

                                            x3(1) = (b2(1) - b1(1)) / (k1(1) - k2(1))
                                            y3(1) = k1(1) * x3(1) + b1(1)

                                        End If
                                    End If
                                    If s = 0 Then
                                        x3_it(0) = x3(0)
                                        y3_it(0) = y3(0)
                                        x3_it(1) = x3(1)
                                        y3_it(1) = y3(1)
                                    Else
                                        x3_it(2) = x3(0)
                                        y3_it(2) = y3(0)
                                        x3_it(3) = x3(1)
                                        y3_it(3) = y3(1)
                                    End If
                                    'Kontour.DrawEllipse(Pens.Blue, x3(0) + Sdvg - 5, y3(0) + Sdvg - 5, 10, 10)
                                    'Kontour.DrawEllipse(Pens.Blue, x3(1) + Sdvg - 5, y3(1) + Sdvg - 5, 10, 10)
                                Next


                                Dim d(3), kd(3), bd(3), Xs(3), Ys(3), d1(3), d2(3), d3(3), x_1, x_3, y_1, y_3 As Single
                                x_1 = KVK(TXotnN(j, k), TXotnK(j, k), TXotnK(jnext, k), TYotnN(j, k), TYotnK(j, k), TYotnK(jnext, k)).x1
                                y_1 = KVK(TXotnN(j, k), TXotnK(j, k), TXotnK(jnext, k), TYotnN(j, k), TYotnK(j, k), TYotnK(jnext, k)).y1
                                x_3 = KVK(TXotnN(j, k), TXotnK(j, k), TXotnK(jnext, k), TYotnN(j, k), TYotnK(j, k), TYotnK(jnext, k)).x2
                                y_3 = KVK(TXotnN(j, k), TXotnK(j, k), TXotnK(jnext, k), TYotnN(j, k), TYotnK(j, k), TYotnK(jnext, k)).y2
                                For s = 0 To 3
                                    If (viborRB(crcell) = "Vneshniy contour" And Vipuklost(jnext, l) = "Внутри") Or (viborRB(crcell) = "Vnutrenniy contour" And Vipuklost(jnext, l) = "Снаружи") Then

                                        d1(s) = (x_1 - x3_it(s)) * (TYotnK(j, k) - y_1) - (TXotnK(j, k) - x_1) * (y_1 - y3_it(s))
                                        d2(s) = (TXotnK(j, k) - x3_it(s)) * (y_3 - TYotnK(j, k)) - (x_3 - TXotnK(j, k)) * (TYotnK(j, k) - y3_it(s))
                                        d3(s) = (x_3 - x3_it(s)) * (y_1 - y_3) - (x_1 - x_3) * (y_3 - y3_it(s))
                                        If (d1(s) >= 0 And d2(s) >= 0 And d3(s) >= 0) Or (d1(s) <= 0 And d2(s) <= 0 And d3(s) <= 0) Then
                                            Xtchkonttr(j, k) = x3_it(s)
                                            Ytchkonttr(j, k) = y3_it(s)
                                        End If
                                        'Form1.ListBox5.Items.Add("d(" & s & ")=" & d(s))
                                    Else
                                        If (TXotnK(jnext, k) - TXotnN(j, k)) <> 0 Then
                                            kd(s) = (TYotnK(jnext, k) - TYotnN(j, k)) / (TXotnK(jnext, k) - TXotnN(j, k))
                                            bd(s) = TYotnK(jnext, k) - kd(s) * TXotnK(jnext, k)
                                            d(s) = Round(Abs(y3_it(s) - kd(s) * x3_it(s) - bd(s)) / Sqrt(kd(s) ^ 2 + 1), 2)
                                        Else
                                            d(s) = Round(Abs(x3_it(s) - TXotnK(jnext, k)), 2)
                                        End If
                                        If d(s) = d.Max Then
                                            'If (Vipuklost(j, l) = "Снаружи" And viborRB(crcell) = "Vneshniy contour") Or (viborRB(crcell) = "Vnutrenniy contour" And Vipuklost(j, l) = "Внутри") Then
                                            Xtchkonttr(j, k) = x3_it(s)
                                            Ytchkonttr(j, k) = y3_it(s)
                                            'End If
                                        End If
                                    End If
                                Next


                                XobshrisN(j, k, l) = Xtchkonttr(j, k)
                                YobshrisN(j, k, l) = Ytchkonttr(j, k)
                                XobshrisK(j, k, l) = Xtchkonttr(j, k)
                                YobshrisK(j, k, l) = Ytchkonttr(j, k)
                                rastoyanie(l) = Sqrt((XobshrisN(j, k, l) - XobshrisK(j, k, l)) ^ 2 + (YobshrisN(j, k, l) - YobshrisK(j, k, l)) ^ 2) + rastoyanie(l)
                                GcodeXN(j, k, l) = Round(XobshrisN(j, k, l) + xprip, 3)
                                ' GcodeXK(j, k, l) = Round(XobshrisK(j, k, l) + xprip, 3)
                                GcodeYN(j, k, l) = Round(-YobshrisN(j, k, l) - yprip, 3)
                                'GcodeYK(j, k, l) = Round(-YobshrisK(j, k, l) - yprip, 3)

                            ElseIf element(jnext, k, l) = "Дуга" Then
                                'Form4.Show()
                                For s = 0 To 1
                                    If s = 0 Then
                                        x_ekv_k1_1 = reshSAY(TXotnK(j, k), TYotnK(j, k), TXotnN(j, k), TYotnN(j, k), (Dfrez(ni) / 2 + (k - 1) * per * Dfrez(ni) / 2)).x3_1
                                        y_ekv_k1_1 = reshSAY(TXotnK(j, k), TYotnK(j, k), TXotnN(j, k), TYotnN(j, k), (Dfrez(ni) / 2 + (k - 1) * per * Dfrez(ni) / 2)).y3_1
                                    Else
                                        x_ekv_k1_1 = reshSAY(TXotnK(j, k), TYotnK(j, k), TXotnN(j, k), TYotnN(j, k), (Dfrez(ni) / 2 + (k - 1) * per * Dfrez(ni) / 2)).x3_2
                                        y_ekv_k1_1 = reshSAY(TXotnK(j, k), TYotnK(j, k), TXotnN(j, k), TYotnN(j, k), (Dfrez(ni) / 2 + (k - 1) * per * Dfrez(ni) / 2)).y3_2
                                    End If
                                    If TXotnK(j, k) = TXotnN(j, k) And TYotnK(j, k) <> TYotnN(j, k) Then
                                        x_ekv_n1 = x_ekv_k1_1
                                        y_ekv_n1 = TYotnN(j, k)
                                    ElseIf TXotnK(j, k) <> TXotnN(j, k) And TYotnK(j, k) = TYotnN(j, k) Then
                                        x_ekv_n1 = TXotnN(j, k)
                                        y_ekv_n1 = y_ekv_k1_1
                                    Else
                                        If Round((x_ekv_k1_1 - reshSAY(TXotnN(j, k), TYotnN(j, k), TXotnK(j, k), TYotnK(j, k), (Dfrez(ni) / 2 + (k - 1) * per * Dfrez(ni) / 2)).x3_1) / (TXotnK(j, k) - TXotnN(j, k)), 1) = Round((y_ekv_k1_1 - reshSAY(TXotnN(j, k), TYotnN(j, k), TXotnK(j, k), TYotnK(j, k), (Dfrez(ni) / 2 + (k - 1) * per * Dfrez(ni) / 2)).y3_1) / (TYotnK(j, k) - TYotnN(j, k)), 1) Then
                                            x_ekv_n1 = reshSAY(TXotnN(j, k), TYotnN(j, k), TXotnK(j, k), TYotnK(j, k), (Dfrez(ni) / 2 + (k - 1) * per * Dfrez(ni) / 2)).x3_1
                                            y_ekv_n1 = reshSAY(TXotnN(j, k), TYotnN(j, k), TXotnK(j, k), TYotnK(j, k), (Dfrez(ni) / 2 + (k - 1) * per * Dfrez(ni) / 2)).y3_1
                                        Else
                                            x_ekv_n1 = reshSAY(TXotnN(j, k), TYotnN(j, k), TXotnK(j, k), TYotnK(j, k), (Dfrez(ni) / 2 + (k - 1) * per * Dfrez(ni) / 2)).x3_2
                                            y_ekv_n1 = reshSAY(TXotnN(j, k), TYotnN(j, k), TXotnK(j, k), TYotnK(j, k), (Dfrez(ni) / 2 + (k - 1) * per * Dfrez(ni) / 2)).y3_2
                                        End If
                                    End If

                                    robsh(jnext) = Sqrt((TXotnN(jnext, k) - TXotnC(jnext, k)) ^ 2 + (TYotnN(jnext, k) - TYotnC(jnext, k)) ^ 2)
                                    If (Vipuklost(jnext, l) = "Снаружи" And viborRB(crcell) = "Vneshniy contour") Or (viborRB(crcell) = "Vnutrenniy contour" And Vipuklost(jnext, l) = "Внутри") Then
                                        R(s) = robsh(jnext) + Dfrez(ni) / 2 + (k - 1) * per * Dfrez(ni) / 2
                                    Else
                                        R(s) = robsh(jnext) - Dfrez(ni) / 2 - (k - 1) * per * Dfrez(ni) / 2
                                    End If

                                    If TXotnN(j, k) = TXotnK(j, k) And TYotnN(j, k) <> TYotnK(j, k) Then
                                        b1(s) = x_ekv_n1
                                        Dim C, D As Single
                                        C = TYotnC(jnext, k) ^ 2 + (b1(s) - TXotnC(jnext, k)) ^ 2 - R(s) ^ 2
                                        D = Round(4 * TYotnC(jnext, k) ^ 2 - 4 * C, 0)
                                        If D >= 0 Then
                                            x3(0) = b1(s)
                                            y3(0) = (2 * TYotnC(jnext, k) + Sqrt(D)) / 2
                                            x3(1) = b1(s)
                                            y3(1) = (2 * TYotnC(jnext, k) - Sqrt(D)) / 2
                                        Else
                                            x3(0) = 10000
                                            y3(0) = 10000
                                            x3(1) = 10000
                                            y3(1) = 10000
                                        End If
                                    ElseIf TXotnN(j, k) <> TXotnK(j, k) And TYotnN(j, k) = TYotnK(j, k) Then
                                        k1(s) = 0
                                        b1(s) = y_ekv_k1_1 - k1(s) * x_ekv_k1_1
                                        x3(0) = ln_okr(k1(s), b1(s), TXotnC(jnext, k), TYotnC(jnext, k), R(s)).x3_1
                                        y3(0) = ln_okr(k1(s), b1(s), TXotnC(jnext, k), TYotnC(jnext, k), R(s)).y3_1
                                        x3(1) = ln_okr(k1(s), b1(s), TXotnC(jnext, k), TYotnC(jnext, k), R(s)).x3_2
                                        y3(1) = ln_okr(k1(s), b1(s), TXotnC(jnext, k), TYotnC(jnext, k), R(s)).y3_2
                                    Else
                                        k1(s) = (y_ekv_k1_1 - y_ekv_n1) / (x_ekv_k1_1 - x_ekv_n1)
                                        b1(s) = y_ekv_k1_1 - k1(s) * x_ekv_k1_1
                                        x3(0) = ln_okr(k1(s), b1(s), TXotnC(jnext, k), TYotnC(jnext, k), R(s)).x3_1
                                        y3(0) = ln_okr(k1(s), b1(s), TXotnC(jnext, k), TYotnC(jnext, k), R(s)).y3_1
                                        x3(1) = ln_okr(k1(s), b1(s), TXotnC(jnext, k), TYotnC(jnext, k), R(s)).x3_2
                                        y3(1) = ln_okr(k1(s), b1(s), TXotnC(jnext, k), TYotnC(jnext, k), R(s)).y3_2
                                    End If
                                    If (x3(0) - TXotnN(j, k)) ^ 2 + (y3(0) - TYotnN(j, k)) ^ 2 >= (x3(1) - TXotnN(j, k)) ^ 2 + (y3(1) - TYotnN(j, k)) ^ 2 Then
                                        If s = 0 Then
                                            x3_it(0) = x3(0)
                                            y3_it(0) = y3(0)
                                        Else
                                            x3_it(1) = x3(0)
                                            y3_it(1) = y3(0)
                                        End If
                                    Else
                                        If s = 0 Then
                                            x3_it(0) = x3(1)
                                            y3_it(0) = y3(1)
                                        Else
                                            x3_it(1) = x3(1)
                                            y3_it(1) = y3(1)
                                        End If
                                    End If
                                    If Round(x3_it(s), 3) = 0 And Round(y3_it(s), 3) = 0 Then
                                        'With Form4.ListBox1.Items
                                        '    .Add("______j=" & j & "_______")
                                        '    .Add("x3_it(" & s & ")=" & x3_it(s))
                                        '    .Add("y3_it(" & s & ")=" & y3_it(s))
                                        '    .Add(Vipuklost(j, l))
                                        '    .Add("========================")
                                        'End With
                                    End If
                                Next
                                If Round(x3_it(0), 3) = 0 And Round(y3_it(0), 3) = 0 Then
                                    XobshrisN(j, k, l) = x3_it(1)
                                    YobshrisN(j, k, l) = y3_it(1)
                                ElseIf Round(x3_it(1), 3) = 0 And Round(y3_it(1), 3) = 0 Then
                                    XobshrisN(j, k, l) = x3_it(0)
                                    YobshrisN(j, k, l) = y3_it(0)

                                ElseIf (x3_it(0) - TXotnN(j, k)) ^ 2 + (y3_it(0) - TYotnN(j, k)) ^ 2 >= (x3_it(1) - TXotnN(j, k)) ^ 2 + (y3_it(1) - TYotnN(j, k)) ^ 2 Then
                                    XobshrisN(j, k, l) = x3_it(1)
                                    YobshrisN(j, k, l) = y3_it(1)
                                Else
                                    XobshrisN(j, k, l) = x3_it(0)
                                    YobshrisN(j, k, l) = y3_it(0)
                                End If
                            End If
                            'Kontour.DrawEllipse(Pens.Blue, x3_it(0) + Sdvg - 2, y3_it(0) + Sdvg - 2, 4, 4)
                            'Kontour.DrawEllipse(Pens.Blue, x3_it(1) + Sdvg - 2, y3_it(1) + Sdvg - 2, 4, 4)
                            GcodeXN(j, k, l) = Round(XobshrisN(j, k, l) + xprip, 3)
                            GcodeYN(j, k, l) = Round(-YobshrisN(j, k, l) - yprip, 3)
                        ElseIf element(j, k, l) = "Дуга" Then
                            If element(jnext, k, l) = "Отрезок" Then

                                For s = 0 To 1
                                    If s = 0 Then
                                        x_ekv_k1_1 = reshSAY(TXotnK(j, k), TYotnK(j, k), TXotnK(jnext, k), TYotnK(jnext, k), (Dfrez(ni) / 2 + (k - 1) * per * Dfrez(ni) / 2)).x3_1
                                        y_ekv_k1_1 = reshSAY(TXotnK(j, k), TYotnK(j, k), TXotnK(jnext, k), TYotnK(jnext, k), (Dfrez(ni) / 2 + (k - 1) * per * Dfrez(ni) / 2)).y3_1
                                    Else
                                        x_ekv_k1_1 = reshSAY(TXotnK(j, k), TYotnK(j, k), TXotnK(jnext, k), TYotnK(jnext, k), (Dfrez(ni) / 2 + (k - 1) * per * Dfrez(ni) / 2)).x3_2
                                        y_ekv_k1_1 = reshSAY(TXotnK(j, k), TYotnK(j, k), TXotnK(jnext, k), TYotnK(jnext, k), (Dfrez(ni) / 2 + (k - 1) * per * Dfrez(ni) / 2)).y3_2
                                    End If
                                    If TXotnK(jnext, k) = TXotnN(jnext, k) And TYotnK(jnext, k) <> TYotnN(jnext, k) Then
                                        x_ekv_n1 = x_ekv_k1_1
                                        y_ekv_n1 = TYotnN(jnext, k)
                                    ElseIf TXotnK(jnext, k) <> TXotnN(jnext, k) And TYotnK(jnext, k) = TYotnN(jnext, k) Then
                                        x_ekv_n1 = TXotnN(jnext, k)
                                        y_ekv_n1 = y_ekv_k1_1
                                    Else
                                        If Round((x_ekv_k1_1 - reshSAY(TXotnK(jnext, k), TYotnK(jnext, k), TXotnK(j, k), TYotnK(j, k), (Dfrez(ni) / 2 + (k - 1) * per * Dfrez(ni) / 2)).x3_1) / (TXotnK(jnext, k) - TXotnN(jnext, k)), 1) = Round((y_ekv_k1_1 - reshSAY(TXotnK(jnext, k), TYotnK(jnext, k), TXotnK(j, k), TYotnK(j, k), (Dfrez(ni) / 2 + (k - 1) * per * Dfrez(ni) / 2)).y3_1) / (TYotnK(jnext, k) - TYotnN(jnext, k)), 1) Then
                                            x_ekv_n1 = reshSAY(TXotnK(jnext, k), TYotnK(jnext, k), TXotnK(j, k), TYotnK(j, k), (Dfrez(ni) / 2 + (k - 1) * per * Dfrez(ni) / 2)).x3_1
                                            y_ekv_n1 = reshSAY(TXotnK(jnext, k), TYotnK(jnext, k), TXotnK(j, k), TYotnK(j, k), (Dfrez(ni) / 2 + (k - 1) * per * Dfrez(ni) / 2)).y3_1
                                        Else
                                            x_ekv_n1 = reshSAY(TXotnK(jnext, k), TYotnK(jnext, k), TXotnK(j, k), TYotnK(j, k), (Dfrez(ni) / 2 + (k - 1) * per * Dfrez(ni) / 2)).x3_2
                                            y_ekv_n1 = reshSAY(TXotnK(jnext, k), TYotnK(jnext, k), TXotnK(j, k), TYotnK(j, k), (Dfrez(ni) / 2 + (k - 1) * per * Dfrez(ni) / 2)).y3_2
                                        End If
                                    End If
                                    robsh(j) = Sqrt((TXotnN(j, k) - TXotnC(j, k)) ^ 2 + (TYotnN(j, k) - TYotnC(j, k)) ^ 2)
                                    If (Vipuklost(jnext, l) = "Снаружи" And viborRB(crcell) = "Vneshniy contour") Or (viborRB(crcell) = "Vnutrenniy contour" And Vipuklost(jnext, l) = "Внутри") Then
                                        R(s) = robsh(j) + Dfrez(ni) / 2 + (k - 1) * per * Dfrez(ni) / 2
                                    Else
                                        R(s) = robsh(j) - Dfrez(ni) / 2 - (k - 1) * per * Dfrez(ni) / 2
                                    End If

                                    If TXotnN(jnext, k) = TXotnK(jnext, k) And TYotnN(jnext, k) <> TYotnK(jnext, k) Then
                                        b1(s) = x_ekv_n1
                                        Dim C, D As Single

                                        C = TYotnC(j, k) ^ 2 + (b1(s) - TXotnC(j, k)) ^ 2 - R(s) ^ 2
                                        D = Round(4 * TYotnC(j, k) ^ 2 - 4 * C, 0)
                                        If D >= 0 Then
                                            x3(0) = b1(s)
                                            y3(0) = (2 * TYotnC(j, k) + Sqrt(D)) / 2
                                            x3(1) = b1(s)
                                            y3(1) = (2 * TYotnC(j, k) - Sqrt(D)) / 2

                                        End If
                                    ElseIf TXotnN(jnext, k) <> TXotnK(jnext, k) And TYotnN(jnext, k) = TYotnK(jnext, k) Then
                                        k1(s) = 0
                                        b1(s) = y_ekv_k1_1 - k1(s) * x_ekv_k1_1
                                        x3(0) = ln_okr(k1(s), b1(s), TXotnC(j, k), TYotnC(j, k), R(s)).x3_1
                                        y3(0) = ln_okr(k1(s), b1(s), TXotnC(j, k), TYotnC(j, k), R(s)).y3_1
                                        x3(1) = ln_okr(k1(s), b1(s), TXotnC(j, k), TYotnC(j, k), R(s)).x3_2
                                        y3(1) = ln_okr(k1(s), b1(s), TXotnC(j, k), TYotnC(j, k), R(s)).y3_2
                                    Else
                                        k1(s) = (y_ekv_k1_1 - y_ekv_n1) / (x_ekv_k1_1 - x_ekv_n1)
                                        b1(s) = y_ekv_k1_1 - k1(s) * x_ekv_k1_1
                                        x3(0) = ln_okr(k1(s), b1(s), TXotnC(j, k), TYotnC(j, k), R(s)).x3_1
                                        y3(0) = ln_okr(k1(s), b1(s), TXotnC(j, k), TYotnC(j, k), R(s)).y3_1
                                        x3(1) = ln_okr(k1(s), b1(s), TXotnC(j, k), TYotnC(j, k), R(s)).x3_2
                                        y3(1) = ln_okr(k1(s), b1(s), TXotnC(j, k), TYotnC(j, k), R(s)).y3_2
                                    End If

                                    If (x3(0) - TXotnK(jnext, k)) ^ 2 + (y3(0) - TYotnK(jnext, k)) ^ 2 >= (x3(1) - TXotnK(jnext, k)) ^ 2 + (y3(1) - TYotnK(jnext, k)) ^ 2 Then
                                        If s = 0 Then
                                            x3_it(0) = x3(0)
                                            y3_it(0) = y3(0)
                                        Else
                                            x3_it(1) = x3(0)
                                            y3_it(1) = y3(0)
                                        End If
                                    Else
                                        If s = 0 Then
                                            x3_it(0) = x3(1)
                                            y3_it(0) = y3(1)
                                        Else
                                            x3_it(1) = x3(1)
                                            y3_it(1) = y3(1)
                                        End If
                                    End If
                                    If Round(x3_it(s), 3) = 0 And Round(y3_it(s), 3) = 0 Then
                                    End If
                                Next
                                If Round(x3_it(0), 3) = 0 And Round(y3_it(0), 3) = 0 Then
                                    XobshrisN(j, k, l) = x3_it(1)
                                    YobshrisN(j, k, l) = y3_it(1)
                                ElseIf Round(x3_it(1), 3) = 0 And Round(y3_it(1), 3) = 0 Then
                                    XobshrisN(j, k, l) = x3_it(0)
                                    YobshrisN(j, k, l) = y3_it(0)

                                ElseIf (x3_it(0) - TXotnK(jnext, k)) ^ 2 + (y3_it(0) - TYotnK(jnext, k)) ^ 2 >= (x3_it(1) - TXotnK(jnext, k)) ^ 2 + (y3_it(1) - TYotnK(jnext, k)) ^ 2 Then
                                    XobshrisN(j, k, l) = x3_it(1)
                                    YobshrisN(j, k, l) = y3_it(1)
                                Else
                                    XobshrisN(j, k, l) = x3_it(0)
                                    YobshrisN(j, k, l) = y3_it(0)
                                End If
                                'Kontour.DrawEllipse(Pens.Blue, x3_it(0) + Sdvg - 2, y3_it(0) + Sdvg - 2, 4, 4)
                                'Kontour.DrawEllipse(Pens.Blue, x3_it(1) + Sdvg - 2, y3_it(1) + Sdvg - 2, 4, 4)
                                R(0) = Sqrt((XobshrisN(j, k, l) - TXotnC(j, k)) ^ 2 + (YobshrisN(j, k, l) - TYotnC(j, k)) ^ 2)
                                GcodeXN(j, k, l) = Round(XobshrisN(j, k, l) + xprip, 3)
                                GcodeYN(j, k, l) = Round(-YobshrisN(j, k, l) - yprip, 3)
                                GcodeR(j, k, l) = Round(R(0), 3)
                            ElseIf element(jnext, k, l) = "Дуга" Then

                                robsh(j) = Round(Sqrt((TXotnN(j, k) - TXotnC(j, k)) ^ 2 + (TYotnN(j, k) - TYotnC(j, k)) ^ 2), 3)
                                robsh(jnext) = Round(Sqrt((TXotnN(jnext, k) - TXotnC(jnext, k)) ^ 2 + (TYotnN(jnext, k) - TYotnC(jnext, k)) ^ 2), 3)
                                If (Vipuklost(j, l) = "Снаружи" And viborRB(crcell) = "Vneshniy contour") Or (viborRB(crcell) = "Vnutrenniy contour" And Vipuklost(j, l) = "Внутри") Then
                                    R1 = robsh(j) + Dfrez(ni) / 2 + (k - 1) * per * Dfrez(ni) / 2
                                Else
                                    R1 = robsh(j) - Dfrez(ni) / 2 - (k - 1) * per * Dfrez(ni) / 2
                                End If
                                If (Vipuklost(jnext, l) = "Снаружи" And viborRB(crcell) = "Vneshniy contour") Or (viborRB(crcell) = "Vnutrenniy contour" And Vipuklost(jnext, l) = "Внутри") Then
                                    R2 = robsh(jnext) + Dfrez(ni) / 2 + (k - 1) * per * Dfrez(ni) / 2
                                Else
                                    R2 = robsh(jnext) - Dfrez(ni) / 2 - (k - 1) * per * Dfrez(ni) / 2
                                End If
                                'MsgBox(R2 & "    " & R1)
                                xp2 = Round(TXotnC(jnext, k) - TXotnC(j, k), 3)
                                yp2 = Round(TYotnC(jnext, k) - TYotnC(j, k), 3)
                                Ci = Round((R2 ^ 2 - xp2 ^ 2 - yp2 ^ 2 - R1 ^ 2) / (-2), 1)

                                If xp2 <> 0 Then
                                    A = Round((yp2 ^ 2 + xp2 ^ 2), 1)
                                    Bi = Round(-2 * yp2 * Ci, 1)
                                    E = Round(Ci ^ 2 - R1 ^ 2 * xp2 ^ 2, 1)
                                    Di = Abs(Round(Bi ^ 2 - 4 * A * E, 2))
                                    x3(0) = 0
                                    y3(0) = 0
                                    x3(1) = 0
                                    y3(1) = 0
                                    If Di >= 0 Then
                                        y3(0) = (-Bi + Sqrt(Di)) / (2 * A)
                                        x3(0) = (Ci - y3(0) * yp2) / xp2 + TXotnC(j, k)
                                        y3(0) = y3(0) + TYotnC(j, k)
                                        y3(1) = (-Bi - Sqrt(Di)) / (2 * A)
                                        x3(1) = (Ci - y3(1) * yp2) / xp2 + TXotnC(j, k)
                                        y3(1) = y3(1) + TYotnC(j, k)
                                    Else
                                        With Form1.ListBox5.Items
                                            .Add("ПЕРЕСЕЧЕНИЙ НЕТ")
                                            .Add("D=" & Di)
                                        End With
                                    End If
                                Else
                                    y3(0) = Ci / yp2 + TYotnC(j, k)
                                    x3(0) = Sqrt(R1 ^ 2 - Ci ^ 2 / yp2 ^ 2) + TXotnC(j, k)
                                End If
                                XobshrisN(j, k, l) = x3(0)
                                YobshrisN(j, k, l) = y3(0)
                                GcodeXN(j, k, l) = Round(XobshrisN(j, k, l) + xprip, 3)
                                GcodeYN(j, k, l) = Round(-YobshrisN(j, k, l) - yprip, 3)
                                GcodeR(j, k, l) = Round(R1, 3)

                            End If
                        End If
                    Next
                Next
                Call optimisation_of_contour()

            ElseIf viborRB(crcell) = "Ploskost" Then
                'rastoyanie(l) = 0
                ' If Form1.TextBoxDtf.Text <> 0 Then
                If Form1.ListBox1.SelectedIndex = 1 Or Form1.ListBox1.SelectedIndex = 2 Then
                    kolvolines(l) = Math.Ceiling((Ymaxloc(l) - Yminloc(l) + 2 * yprip) / (0.8 * Dfrez(ni)))
                Else
                    MsgBox("Для данной операции необходимо выбрать торцевую фрезу. Фреза ф80 выбрана по умолчанию")
                    Form1.ListBox1.SelectedIndex = 1
                    kolvolines(l) = Math.Ceiling((Ymaxloc(l) - Yminloc(l) + 2 * yprip) / (0.8 * Dfrez(ni)))
                End If

                i = 0
                For k = 0 To kolvolines(l) - 1
                    If k = 0 Then
                        YobshrisN(i, k, l) = -yprip + 0.4 * Dfrez(ni)
                    Else
                        YobshrisN(i, k, l) = YobshrisN(i, k - 1, l) + 0.8 * Dfrez(ni)
                    End If
                    XobshrisN(i, k, l) = Xmaxloc(l) - Xminloc(l) + xprip + 0.6 * Dfrez(ni)
                    XobshrisK(i, k, l) = -xprip - 0.6 * Dfrez(ni)

                    GcodeXN(i, k, l) = Round(XobshrisN(i, k, l) + xprip, 3)
                    GcodeXK(i, k, l) = Round(XobshrisK(i, k, l) + xprip, 3)
                    GcodeYN(i, k, l) = Round(-YobshrisN(i, k, l) - yprip, 3)
                Next

                i = 0
                k = 0
            ElseIf viborRB(crcell) = "Otverstie" Then

                If Form1.ListBox1.SelectedIndex = 0 Or (Form1.ListBox1.SelectedIndex >= 8 And Form1.ListBox1.SelectedIndex <= 13) Then
                    For k = 0 To kolvo(0, l) - 1
                        GcodeXN(0, k, l) = Round(XotnobshC(k, l) + xprip, 3)
                        GcodeYN(0, k, l) = Round(-YotnobshC(k, l) - yprip, 3)
                    Next
                    k = 0
                ElseIf Form1.ListBox1.SelectedIndex >= 3 And Form1.ListBox1.SelectedIndex <= 6 Then

                Else
                    MsgBox("Для данной операции необходимо выбрать сверло или концевую фрезу. Центровочное сверло выбрано по умолчанию")
                    Form1.ListBox1.SelectedIndex = 0
                    For k = 0 To kolvo(0, l) - 1
                        GcodeXN(0, k, l) = Round(XotnobshC(k, l) + xprip, 3)
                        GcodeYN(0, k, l) = Round(-YotnobshC(k, l) - yprip, 3)
                    Next

                End If


            ElseIf viborRB(crcell) = "Rezba" Then

                If Form1.ListBox1.SelectedIndex >= 14 Then

                Else
                    MsgBox("Для данной операции необходимо выбрать Метчик. Метчик М2 выбран по умолчанию")
                    Form1.ListBox1.SelectedIndex = 14
                End If

                'ReDim GcodeXN(1, kolvoobsh(l), 15)
                'ReDim GcodeYN(1, kolvoobsh(l), 15)
                ' MsgBox(kolvoobsh(l))
                For k = 0 To kolvo(0, l) - 1
                    GcodeXN(0, k, l) = Round(XotnobshC(k, l) + xprip, 3)
                    GcodeYN(0, k, l) = Round(-YotnobshC(k, l) - yprip, 3)
                Next

            ElseIf viborRB(crcell) = "Trahoida" Then
                Form5.Show()
                Sh_tr = Abs(XotnK(1) - XotnK(0))
                Pr_tr = Convert.ToInt32(Form5.TextBox3.Text)
                Form5.Label4.Text = Convert.ToString(Sh_tr)
                Form5.TextBox1.Text = Convert.ToString((Sh_tr - Dfrez(0)) / 2 - Pr_tr)
                Cokr_tr = Sh_tr / 2
                Rad_tr = ((Sh_tr - Dfrez(0)) / 2 - Pr_tr)
                Shag_tr = Convert.ToInt32(Form5.TextBox2.Text)
                u = 1
                If YotnK(0) > YotnN(0) Then
                    Yokr_tr(0) = YotnN(0)
                    Kontour.DrawLine(pen4, Cokr_tr + Rad_tr + Sdvg, Sdvg - yprip - 5, Cokr_tr + Rad_tr + Sdvg, Yokr_tr(u - 1) + Sdvg)
                    While Yokr_tr(u) < YotnK(0) + Rad_tr
                        Yokr_tr(u + 1) = Yokr_tr(u) + Shag_tr
                        Kontour.DrawLine(pen4, Cokr_tr + Rad_tr + Sdvg, Yokr_tr(u) + Sdvg, Cokr_tr + Rad_tr + Sdvg, Yokr_tr(u - 1) + Sdvg)
                        Kontour.DrawEllipse(pen4, Sdvg + CSng(Cokr_tr - Rad_tr), Sdvg + CSng(Yokr_tr(u) - Rad_tr), CSng(2 * Rad_tr), CSng(2 * Rad_tr))

                        u = u + 1
                    End While
                    Kontour.DrawLine(pen4, Cokr_tr + Rad_tr + Sdvg, -Yminloc(0) + Ycoord + Sdvg, Cokr_tr + Rad_tr + Sdvg, Yokr_tr(u - 1) + Sdvg)

                Else
                    Yokr_tr(0) = YotnK(0)
                    While Yokr_tr(u) < YotnN(0)
                        Yokr_tr(u) = Yokr_tr(u) + Shag_tr
                        Kontour.DrawEllipse(pen1, Sdvg + CSng(Cokr_tr - Rad_tr), Sdvg + CSng(Yokr_tr(u) - Rad_tr), CSng(2 * Rad_tr), CSng(2 * Rad_tr))
                        u = u + 1
                    End While
                End If



            Else
                    Form1.ListBox5.Items.Add("Геометрический примитив не определен")
            End If

        Catch ex As Exception
            Form1.ListBox5.Items.Add(ex.Message)
            p = p + 1
            Dim stacktr As New StackTrace(ex, True)
            If stacktr.FrameCount > 0 Then
                Dim stackfr As New StackFrame
                stackfr = stacktr.GetFrame(0)
                Dim errorline As Integer = stackfr.GetFileLineNumber()
                Dim functionname As String = stackfr.GetMethod().Name
                Form1.ListBox5.Items.Add("Ошибка в " & functionname & " на линии" & errorline)
                p = p + 1
                Form1.ListBox5.Items.Add(ex.Message)
                p = p + 1
            End If
        End Try
        j = 0
        k = 0
    End Function

    Public Function reshSAY(x1 As Single, y1 As Single, x2 As Single, y2 As Single, d As Single) As Mystructure
        If x1 = x2 And y1 <> y2 Then
            reshSAY.x3_1 = x1 + d
            reshSAY.y3_1 = y1
            reshSAY.x3_2 = x1 - d
            reshSAY.y3_2 = y1
        ElseIf x1 <> x2 And y1 = y2 Then
            reshSAY.x3_1 = x1
            reshSAY.y3_1 = y1 + d
            reshSAY.x3_2 = x1
            reshSAY.y3_2 = y1 - d
        Else

            Dim C1, A3, B3, C3, D3
            C1 = x1 ^ 2 + y1 ^ 2 - x1 * x2 - y2 * y1
            A3 = ((y2 - y1) / (x1 - x2)) ^ 2 + 1
            B3 = 2 * (((y2 - y1) / (x1 - x2)) * (C1 / (x1 - x2) - x1) - y1)
            C3 = ((C1 / (x1 - x2) - x1) ^ 2 + y1 ^ 2 - d ^ 2)
            D3 = B3 ^ 2 - 4 * A3 * C3
            reshSAY.y3_1 = (-B3 + Sqrt(D3)) / (2 * A3)
            reshSAY.x3_1 = (-reshSAY.y3_1 * (y2 - y1) - C1) / (x2 - x1)
            reshSAY.y3_2 = (-B3 - Sqrt(D3)) / (2 * A3)
            reshSAY.x3_2 = (-reshSAY.y3_2 * (y2 - y1) - C1) / (x2 - x1)
        End If
    End Function

    Public Function ln_okr(k As Single, b As Single, Xc As Single, Yc As Single, R As Single) As Mystructure

        Dim A, B_, C, D As Single
        A = 1 + k ^ 2
        B_ = 2 * ((b - Yc) * k - Xc)
        C = Xc ^ 2 + (b - Yc) ^ 2 - R ^ 2
        D = Round(B_ ^ 2 - 4 * A * C, 0)
        If D > -10 And D < 0 Then D = 0
        ln_okr.D = D
        If D > 0 Then

            ln_okr.x3_1 = (-B_ + Sqrt(D)) / (2 * A)
            ln_okr.y3_1 = k * ln_okr.x3_1 + b
            ln_okr.x3_2 = (-B_ - Sqrt(D)) / (2 * A)
            ln_okr.y3_2 = k * ln_okr.x3_2 + b
        ElseIf D = 0 Then
            ln_okr.x3_1 = (-B_) / (2 * A)
            ln_okr.y3_1 = k * ln_okr.x3_1 + b
            ln_okr.x3_2 = (-B_) / (2 * A)
            ln_okr.y3_2 = k * ln_okr.x3_2 + b
        Else
            ln_okr.x3_1 = 100000
            ln_okr.y3_1 = 100000
            ln_okr.x3_2 = 100000
            ln_okr.y3_2 = 100000
            ' Form1.ListBox5.Items.Add("D < 0 =" & D)
        End If
        'Form4.ListBox1.Items.Add("D=" & D)
    End Function

End Module
