Imports System
Imports System.Type
Imports System.ApplicationId
Imports System.Activator
Imports System.Runtime.InteropServices
Imports Inventor
Imports System.Math
Imports System.Drawing
Imports System.IO
Module Module2

    Public Function otrisovka_vsego_mod_2()
        Do Until j > kolvo(0, l) - 1
            Xabscentr(j) = XabsobshC(j, l)
            Yabscentr(j) = YabsobshC(j, l)
            XabsN(j) = XabsobshN(j, l)
            XabsK(j) = XabsobshK(j, l)
            YabsN(j) = YabsobshN(j, l)
            YabsK(j) = YabsobshK(j, l)

            XotnC(j) = XotnobshC(j, l)
            YotnC(j) = YotnobshC(j, l)
            XotnN(j) = XobshotnN(j, l)
            XotnK(j) = XobshotnK(j, l)
            YotnN(j) = YobshotnN(j, l)
            YotnK(j) = YobshotnK(j, l)
            If element(j, 0, l) = "Отрезок" Then
                Kontour.DrawLine(pen1, XotnK(j) + Sdvg, YotnK(j) + Sdvg, XotnN(j) + Sdvg, YotnN(j) + Sdvg)
                j = j + 1
            ElseIf element(j, 0, l) = "Окружность" Then
                'MsgBox("diamokr=" & diamokr(j, l))
                Kontour.DrawEllipse(pen1, Sdvg + CSng(XotnC(j) - diamokr(j, l) / 2), Sdvg + CSng(YotnC(j) - diamokr(j, l) / 2), CSng(diamokr(j, l)), CSng(diamokr(j, l)))
                j = j + 1
            ElseIf element(j, 0, l) = "Дуга" Then
                'MsgBox("j=" & j & ",l=" & l & "element:" & element(j, l))
                Dim pduga(3) As Drawing.PointF
                Dim pen6 As New Pen(Brushes.Black, 0.5)
                pduga(0).X = XobshotnN(j, l)
                pduga(0).Y = YobshotnN(j, l)
                pduga(1).X = XobshotnK(j, l)
                pduga(1).Y = YobshotnK(j, l)
                pduga(2).X = XotnobshC(j, l)
                pduga(2).Y = YotnobshC(j, l)
                Call ris_duga(pduga(0), pduga(1), pduga(2), pen6)
                j = j + 1
            End If
        Loop
        j = 0
    End Function
    Function Mnimoe_peresechenie(xfn1 As Single, xfn2 As Single, xfk1 As Single, xfk2 As Single, yfn1 As Single, yfn2 As Single, yfk1 As Single, yfk2 As Single)
        Dim kf1, kf2, bf1, bf2, xfo, yfo As Single
        kf1 = (yfn1 - yfk1) / (xfn1 - xfk1)
        bf1 = yfn1 - kf1 * yfn1
        kf2 = (yfn2 - yfk2) / (xfn2 - xfk2)
        bf2 = yfn2 - kf2 * yfn2
        xfo = (bf2 - bf1) / (kf1 - kf2)
        yfo = kf1 * xfo + bf1

        If Abs(xfo - xfn1) <= Abs(xfo - xfk1) And Abs(xfo - xfk2) <= Abs(xfo - xfn2) Then
            XotnN(j) = xfo
            YotnN(j) = yfo
            XotnK(j + 2) = xfo
            YotnK(j + 2) = yfo
            Form1.ListBox5.Items.Add(p & ("мнимое пересечение в точке:" & XotnN(j)))
            p = p + 1
        ElseIf Abs(xfo - xfn2) <= Abs(xfo - xfk2) And Abs(xfo - xfk1) <= Abs(xfo - xfn1) Then
            XotnN(j + 2) = xfo
            YotnN(j + 2) = yfo
            XotnK(j) = xfo
            YotnK(j) = yfo
            Form1.ListBox5.Items.Add(p & "мнимое пересечение в точке:" & XotnK(j))
            p = p + 1
        End If
    End Function




    Public Function ris_duga_traekt(Nachtchk As Drawing.PointF, Kontchk As Drawing.PointF, Centrtch As Drawing.PointF, mypen As Pen, j As Integer, k As Integer)
        Dim radius(kolvo(k, l)) As Single

        For h = 0 To kolvo(k, l) - 1
            If element(h, k, l) = "Дуга" Then
                radius(h) = Sqrt((XobshrisN(h, k, l) - TXotnC(h, k)) ^ 2 + ((YobshrisN(h, k, l) - TYotnC(h, k)) ^ 2))
            End If
        Next
        Dim rast(2), y(2) As Single
        Dim kontchkN As Drawing.PointF
        kontchkN.Y = Kontchk.Y
        Dim a, b, e, s As Single
        Dim rec As Rectangle
        a = Round((Nachtchk.Y - Centrtch.Y) * radius(j), 6) : b = Round((Nachtchk.X - Centrtch.X) * radius(j), 6) : s = Round(Math.Atan2(a, b), 6)
        a = Round((kontchkN.Y - Centrtch.Y) * radius(j), 6) : b = Round((Kontchk.X - Centrtch.X) * radius(j), 6) : e = Round(Math.Atan2(a, b), 6)

        rec.X = Centrtch.X - radius(j) + Sdvg
        rec.Y = Centrtch.Y - radius(j) + Sdvg
        rec.Width = 2 * radius(j)
        rec.Height = 2 * radius(j)
        If e < 0 Then e = 2 * PI + e
        If s < 0 Then s = 2 * PI + s
        e = e * 180 / PI
        s = s * 180 / PI
        If j > 0 Then

            'If element(j - 1, k, l) = "Дуга" And element(j, k, l) = "Дуга" And Sqrt((TXotnC(j - 1, k) - TXotnC(j, k)) ^ 2 + (TYotnC(j - 1, k) - TYotnC(j - 1, k)) ^ 2) > Max(radius(j), radius(j - 1)) Then
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
            If element(kolvo(k, l) - 1, k, l) = "Дуга" And element(j, k, l) = "Дуга" And Sqrt((TXotnC(kolvo(k, l) - 1, l) - TXotnC(j, l)) ^ 2 + (TYotnC(kolvo(k, l) - 1, l) - TYotnC(j, l)) ^ 2) > Max(radius(j), radius(kolvo(k, l) - 1)) Then
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
        rastoyanie(l) = rastoyanie(l) + 2 * a * PI * radius(j) / 360
        Kontour.DrawArc(mypen, rec, s, a)
        Exit Function
    End Function

    Public Function Proverka_na_vipuklost()
        Dim nach, kon As Vect
        XotnN(j) = XobshotnN(j, l)
        XotnK(j) = XobshotnK(j, l)
        YotnN(j) = YobshotnN(j, l)
        YotnK(j) = YobshotnK(j, l)
        crcell = Form1.DataGridView2.CurrentCell.RowIndex
        nach.x = XotnK(j) - XotnN(j)
        nach.y = YotnK(j) - YotnN(j)
        If j < kolvo(0, l) - 1 Then
            XotnN(j + 1) = XobshotnN(j + 1, l)
            XotnK(j + 1) = XobshotnK(j + 1, l)
            YotnN(j + 1) = YobshotnN(j + 1, l)
            YotnK(j + 1) = YobshotnK(j + 1, l)
            kon.x = XotnK(j + 1) - XotnN(j + 1)
            kon.y = YotnK(j + 1) - YotnN(j + 1)
            VectAngle(j) = nach.x * kon.y - nach.y * kon.x
            'VectAngle(j) = (XabsobshK(j, l) - XabsobshN(j, l)) * (YabsobshK(j + 1, l) - YabsobshN(j + 1, l)) - (YabsobshK(j, l) - YabsobshN(j, l)) * (XabsobshK(j + 1, l) - XabsobshN(j + 1, l))


            If VectAngle(j) > 0 Then
                Vipuklost(j + 1, l) = "Снаружи"
            Else
                Vipuklost(j + 1, l) = "Внутри"
            End If
            Form1.ListBox3.Items.Add("тчк." & j & ":  " & Vipuklost(j + 1, l))
            'Form1.ListBox5.Items.Add("Vipuklost(" & j & ")=" & VectAngle(j))
            'MsgBox(VectAngle(j -1))
        ElseIf j = kolvo(0, l) - 1 Then
            kon.x = XotnK(0) - XotnN(0)
            kon.y = YotnK(0) - YotnN(0)
            VectAngle(j) = nach.x * kon.y - nach.y * kon.x
            'VectAngle(j) = (XabsobshK(j, l) - XabsobshN(j, l)) * (YabsobshK(0, l) - YabsobshN(0, l)) - (YabsobshK(j, l) - YabsobshN(j, l)) * (XabsobshK(0, l) - XabsobshN(0, l))
            If VectAngle(j) > 0 Then
                Vipuklost(0, l) = "Снаружи"
            Else
                Vipuklost(0, l) = "Внутри"
            End If

            Form1.ListBox3.Items.Add("тчк." & j & ":  " & Vipuklost(0, l))
            ' Form1.ListBox5.Items.Add("Vipuklost(" & j & ")=" & VectAngle(j))
        End If
        ' j = i
    End Function


    Public Function G_code_zapis2()
        ' MsgBox("l=" &crcell)
        crcell = Form1.DataGridView2.CurrentCell.RowIndex
        curr = 0
        i = 0
        j = 0
        kp = kpobsh(l)
        Dim plusminus As Boolean = True
        Try

            With Form1.ListBox2.Items
                .Add("%") '0
                .Add("O1 (" & viborRB(crcell) & ")") '1
                .Add("(T" & Tinst(crcell) & "-" & Glabel(Form1.ListBox1.SelectedIndex) & ")") '2
                .Add("G00 G90 G94 G17 G40 G49 G80") '3
                .Add("G00 G28 G91 Z0") '4
                .Add("T" & Tinst(crcell) & "M06") '5
                .Add("S" & Form1.TextBoxobchern.Text & " M03") '6
                .Add("M08") '7
            End With
            curr = curr + 7
            If viborRB(crcell) = "Vneshniy contour" Then


                With Form1.ListBox2.Items
                        .Add("G00 G54 G90 X" & Round(Xvhod(crcell) + xprip, 3) & " Y" & Round(-Yvhod(crcell) - yprip, 3)) '8
                        .Add("G43 H" & Tinst(crcell) & " D" & Tinst(crcell) & " Z" & Form1.TextBoxplbez.Text & ".") '9
                        .Add("Z" & Form1.TextBoxbzrast.Text & ".") '10
                    End With
                curr = curr + 3

                For m = 0 To kchastey - 1
                        j = 0
                        i = 0
                        k = kpobsh(crcell) - 1
                        Form1.ListBox2.Items.Add("G00 X" & Round(Xvhod(crcell) + xprip, 3) & " Y" & Round(-Yvhod(crcell) - yprip, 3))
                        Form1.ListBox2.Items.Add("G01 Z" & zvhodpr(m + 1, crcell) & " F" & Form1.TextBoxpdchvert.Text) '11
                        Form1.ListBox2.Items.Add("S" & Form1.TextBoxobchern.Text)
                        curr = curr + 2
                        Dim jpred As Integer
                        l = crcell
                        k = kpobsh(l)
                        While k >= 1
                        For j = 0 To kolvo(k, l) - 1
                            If element(0, k, l) <> "Окружность" Then
                                If j > 0 Then
                                    jpred = j - 1
                                Else
                                    jpred = kolvo(k, l) - 1
                                End If
                                If element(j, k, l) = "Отрезок" Then
                                    Form1.ListBox2.Items.Add("G01 X" & GcodeXN(j, k, crcell) & " Y" & GcodeYN(j, k, crcell))
                                    If j = kolvo(k, l) - 1 And element(0, k, l) = "Отрезок" Then
                                        Form1.ListBox2.Items.Add("G01 X" & GcodeXN(0, k, crcell) & " Y" & GcodeYN(0, k, crcell))
                                    End If
                                    '                            curr = curr + 1
                                ElseIf element(j, k, l) = "Дуга" Then
                                    If j = 0 Then 'And k = kpobsh(l) Then
                                        Form1.ListBox2.Items.Add("G01 X" & GcodeXN(kolvo(k, l) - 1, k, crcell) & " Y" & GcodeYN(kolvo(k, l) - 1, k, crcell))
                                    End If
                                    If j < kolvo(k, l) - 1 Then
                                        jnext = j + 1
                                    Else
                                        jnext = 0
                                    End If
                                    Form1.ListBox2.Items.Add("G02 X" & GcodeXN(j, k, crcell) & " Y" & GcodeYN(j, k, crcell) & " R" & GcodeR(j, k, crcell))
                                End If
                            ElseIf element(0, k, l) = "Окружность" Then
                                'MsgBox(k)
                                If k = kp Then
                                    Form1.ListBox2.Items.Add("G01 X" & Round(Xvhod(crcell) + xprip + vr_dannie(9, crcell), 3) & " Y" & Round(-Yvhod(crcell) - yprip, 3))
                                End If
                                Form1.ListBox2.Items.Add("G02 X" & GcodeXN(j, k, crcell) & " Y" & GcodeYN(j, k, crcell) & " R" & GcodeR(j, k, crcell))
                                Form1.ListBox2.Items.Add("G02 X" & GcodeXK(j, k, crcell) & " Y" & GcodeYK(j, k, crcell) & " R" & GcodeR(j, k, crcell))
                                If k = 1 Then
                                    Form1.ListBox2.Items.Add("G02 X" & GcodeXN(j, k, crcell) & " Y" & GcodeYN(j, k, crcell) & " R" & GcodeR(j, k, crcell))
                                    Form1.ListBox2.Items.Add("G02 X" & GcodeXK(j, k, crcell) & " Y" & GcodeYK(j, k, crcell) & " R" & GcodeR(j, k, crcell))
                                End If
                                curr = curr + 2

                            End If
                        Next
                        k = k - 1
                        End While

                        Form1.ListBox2.Items.Add("G01 Z" & Form1.TextBoxbzrast.Text) '11
                    Next



            ElseIf viborRB(crcell) = "Vnutrenniy contour" Then
                Form1.ListBox2.Items.Add("G00 G54 G90 X" & Round(Xvhod(crcell) + xprip, 3) & " Y" & Round(-Yvhod(crcell) - yprip - Rvhod(crcell), 3)) '8
                Form1.ListBox2.Items.Add("G43 H" & Tinst(crcell) & " D" & Tinst(crcell)) '9
                curr = curr + 3
                For m = 0 To kchastey - 1
                    With Form1.ListBox2.Items
                        .Add("G00 Z" & Form1.TextBoxplbez.Text & ".") '10
                        .Add("G00 X" & Round(Xvhod(crcell) + xprip, 3) & " Y" & Round(-Yvhod(crcell) - yprip - Rvhod(crcell), 3)) '11
                        .Add("G01 Z" & Round(zvhodpr(m, crcell) + ((2 * Rvhod(crcell) * PI) * (Tan(vr_dannie(10, crcell) * PI / 180))) * 0.5, 3) & ".") '12
                        .Add("G03 X" & Round(Xvhod(crcell) + xprip, 3) & " Y" & Round(-Yvhod(crcell) - yprip - Rvhod(crcell), 3) & " Z" & Round(zvhodpr(m, crcell) - ((2 * Rvhod(crcell) * PI) * (Tan(vr_dannie(10, crcell) * PI / 180))), 3) & " R-" & Round(Rvhod(crcell), 3) & " F300") '13

                    End With
                    curr = curr + 4
                    i = 2
                    'Form1.ListBox5.Items.Add(Form2.TextBoxugolzag.Text)
                    While Round(zvhodpr(m, crcell) - ((2 * Rvhod(crcell) * PI) * (Tan(vr_dannie(10, crcell) * PI / 180))) * 0.5 * i, 3) >= zvhodpr(m + 1, crcell)
                        If plusminus = True Then
                            Form1.ListBox2.Items.Add("X" & Round(Xvhod(crcell) + xprip, 3) & " Y" & Round(-Yvhod(crcell) - yprip + Rvhod(crcell), 3) & " Z" & Round(zvhodpr(m, crcell) - ((Rvhod(crcell) * PI) * (Tan(vr_dannie(10, crcell) * PI / 180))) * i, 3) & " R-" & Round(Rvhod(crcell), 3))
                        Else
                            If zvhodpr(m, crcell) - ((Rvhod(crcell) * PI) * (Tan(vr_dannie(10, crcell) * PI / 180))) * (i + 1) > Single.Parse(Form1.TextBoxnpl.Text) Then
                                Form1.ListBox2.Items.Add("X" & Round(Xvhod(crcell) + xprip, 3) & " Y" & Round(-Yvhod(crcell) - yprip - Rvhod(crcell), 3) & " Z" & Round(zvhodpr(m, crcell) - ((Rvhod(crcell) * PI) * (Tan(vr_dannie(10, crcell) * PI / 180))) * (i), 3) & " R-" & Round(Rvhod(crcell), 3))
                            Else
                                'If plusminus = True Then
                                Form1.ListBox2.Items.Add("X" & Round(Xvhod(crcell) + xprip, 3) & " Y" & Round(-Yvhod(crcell) - yprip + Rvhod(crcell), 3) & " Z" & Round(Single.Parse(Form1.TextBoxnpl.Text), 3) & " R-" & Round(Rvhod(crcell), 3))
                                ' Else
                                Form1.ListBox2.Items.Add("X" & Round(Xvhod(crcell) + xprip, 3) & " Y" & Round(-Yvhod(crcell) - yprip - Rvhod(crcell), 3) & " Z" & Round(Single.Parse(Form1.TextBoxnpl.Text), 3) & " R-" & Round(Rvhod(crcell), 3))
                                'End If
                            End If
                        End If
                        plusminus = Not plusminus
                        i = i + 1
                        curr = curr + 1
                    End While
                    ' Form1.ListBox2.Items.Add("G01 X" & GcodeXN(0, kp, crcell) & " Y" & GcodeYN(0, kp, crcell))
                    curr = curr + 1
                    j = 0
                    i = 0
                    Dim jpred As Integer
                    l = crcell
                    k = kpobsh(l)
                    ' k = kp
                    While k >= 1
                        j = 0
                        For j = 0 To kolvo(k, l) - 1
                            If j > 0 Then
                                jpred = j - 1
                            Else
                                jpred = kolvo(k, l) - 1
                            End If
                            If element(j, k, l) = "Отрезок" Then
                                Form1.ListBox2.Items.Add("G01 X" & GcodeXN(j, k, crcell) & " Y" & GcodeYN(j, k, crcell))
                                If j = kolvo(k, l) - 1 And element(0, k, l) = "Отрезок" Then
                                    Form1.ListBox2.Items.Add("G01 X" & GcodeXN(0, k, crcell) & " Y" & GcodeYN(0, k, crcell))
                                End If
                                '                            curr = curr + 1
                            ElseIf element(j, k, l) = "Дуга" Then
                                If j = 0 Then 'And k = kpobsh(l) Then
                                    Form1.ListBox2.Items.Add("G01 X" & GcodeXN(kolvo(k, l) - 1, k, crcell) & " Y" & GcodeYN(kolvo(k, l) - 1, k, crcell))
                                End If
                                If j < kolvo(k, l) - 1 Then
                                    jnext = j + 1
                                Else
                                    jnext = 0
                                End If
                                Form1.ListBox2.Items.Add("G02 X" & GcodeXN(j, k, crcell) & " Y" & GcodeYN(j, k, crcell) & " R" & GcodeR(j, k, crcell))
                            End If
                        Next

                        k = k - 1

                    End While
                Next
            ElseIf viborRB(crcell) = "Ploskost" Then
                Form1.ListBox2.Items.Add("G00 G54 G90 X" & GcodeXN(0, 0, crcell) & " Y" & GcodeYN(0, 0, crcell)) '8
                Form1.ListBox2.Items.Add("G43 H" & Tinst(crcell) & " D" & Tinst(crcell) & " Z" & Form1.TextBoxplbez.Text) '9
                ' MsgBox(kchastey)
                For m = 0 To kchastey - 1
                    For k = 0 To kolvolines(crcell) - 1
                        If k < kolvolines(crcell) - 1 And m <= kchastey - 1 Then
                            'With 
                            Form1.ListBox2.Items.Add("Z" & Form1.TextBoxbzrast.Text)
                            Form1.ListBox2.Items.Add("G01 Z" & zvhodpr(m + 1, crcell) & " F" & Form1.TextBoxpdchvert.Text) '0
                            Form1.ListBox2.Items.Add("X" & GcodeXK(0, k, crcell) & " F" & Form1.TextBoxSrez.Text) '1
                            Form1.ListBox2.Items.Add("G00 Z" & Form1.TextBoxplbez.Text) '3
                            Form1.ListBox2.Items.Add("X" & GcodeXN(i, k + 1, crcell) & " Y" & GcodeYN(i, k + 1, crcell))
                            'End With
                        ElseIf k = kolvolines(crcell) - 1 And m < kchastey - 1 Then
                            With Form1.ListBox2.Items
                                .Add("Z" & Form1.TextBoxbzrast.Text)
                                .Add("G01 Z" & zvhodpr(m + 1, crcell) & " F" & Form1.TextBoxpdchvert.Text) '0
                                .Add("X" & GcodeXK(0, k, crcell) & " F" & Form1.TextBoxSrez.Text) '1
                                .Add("G00 Z" & Form1.TextBoxplbez.Text) '3
                                .Add("X" & GcodeXN(i, 0, crcell) & " Y" & GcodeYN(i, 0, crcell))
                            End With
                        ElseIf k = kolvolines(crcell) - 1 And m = kchastey - 1 Then
                            With Form1.ListBox2.Items
                                .Add("Z" & Form1.TextBoxbzrast.Text)
                                .Add("G01 Z" & zvhodpr(m + 1, crcell) & " F" & Form1.TextBoxpdchvert.Text) '0
                                .Add("X" & GcodeXK(0, k, crcell) & " F" & Form1.TextBoxSrez.Text) '1
                                '.Add("G00 Z" & Form1.TextBoxplbez.Text) '3
                                '.Add("X" & GcodeXN(i, 0,crcell) & " Y" & GcodeYN(i, 0,crcell))
                            End With
                        End If
                    Next
                Next
            ElseIf viborRB(crcell) = "Otverstie" Then
                If Form1.ListBox1.SelectedIndex = 0 Or (Form1.ListBox1.SelectedIndex >= 8 And Form1.ListBox1.SelectedIndex <= 13) Then
                    'If diamokr(j,crcell) >= Dsv(ni) Then
                    Form1.TextBoxDsv.BackColor = Drawing.Color.White
                    Form1.ListBox2.Items.Add("G00 G54 G90 X" & GcodeXN(0, 0, crcell) & " Y" & GcodeYN(0, 0, crcell)) '8
                    Form1.ListBox2.Items.Add("G43 H" & Tinst(crcell) & " D" & Tinst(crcell) & " Z" & Form1.TextBoxplbez.Text) '9
                    Form1.ListBox2.Items.Add("G98 G81 X" & GcodeXN(0, 0, crcell) & " Y" & GcodeYN(0, 0, crcell) & " Z" & Form1.TextBoxnpl.Text & " R" & Form1.TextBoxbzrast.Text & " F" & Form1.TextBoxpdchvert.Text) '9
                    For k = 1 To kolvo(k, crcell) - 1
                        Form1.ListBox2.Items.Add("X" & GcodeXN(0, k, crcell) & " Y" & GcodeYN(0, k, crcell))
                    Next
                    Form1.ListBox2.Items.Add("G80")
                    'Else

                    vremya(crcell) = kolvo(k, crcell) * (Single.Parse(Form1.TextBoxbzrast.Text) - Single.Parse(Form1.TextBoxnpl.Text)) / Single.Parse(Form1.TextBoxpdchvert.Text)
                    Form1.TextBoxmin.Text = Fix(vremya(crcell))
                    Form1.TextBoxsek.Text = Round((vremya(crcell) - Fix(vremya(crcell))) * 60, 0)
                ElseIf Form1.ListBox1.SelectedIndex >= 3 And Form1.ListBox1.SelectedIndex <= 6 Then
                    rastoyanie(crcell) = 0
                    Form1.TextBoxDkf.BackColor = Drawing.Color.White
                    Form1.ListBox2.Items.Add("G00 G54 G90 X" & Round(XotnobshC(j, crcell) + xprip, 3) & " Y" & Round(-YotnobshC(j, crcell) - yprip, 3)) '8
                    Form1.ListBox2.Items.Add("G43 H" & Tinst(crcell) & " D" & Tinst(crcell) & " Z" & Form1.TextBoxplbez.Text) '9
                    For j = 0 To kolvo(k, crcell) - 1
                        n = Math.Ceiling(2 * (Convert.ToDecimal(Form1.TextBoxbzrast.Text) + Convert.ToDecimal(Form1.TextBoxdeltaniz.Text) - Convert.ToDecimal(Form1.TextBoxnpl.Text)) / ((2 * (diamokr(j, crcell) - Dfrez(ni)) / 2 * PI) * (Tan(1 * PI / 180))))
                        Zvhod(crcell) = (Round(((diamokr(j, crcell) - Dfrez(ni)) / 2 * PI * n) * Tan(1 * PI / 180) - Convert.ToDecimal(Form1.TextBoxdeltaniz.Text) + Convert.ToDecimal(Form1.TextBoxnpl.Text), 3))
                        '  Form1.ListBox5.Items.Add("Zвход=" & Zvhod(crcell))
                        kchastey = Math.Ceiling((Zvhod(crcell) - Decimal.Parse(Form1.TextBoxnpl.Text))) '/ Decimal.Parse(Form1.TextBoxmaxZ.Text))

                        ReDim zvhodpr(kchastey + 1, 15)
                        ' Form1.ListBox5.Items.Add("Количество частей = " & kchastey)
                        For i = 0 To kchastey
                            zvhodpr(i, crcell) = Math.Round(Zvhod(crcell) - i * (n / kchastey) * (((diamokr(j, crcell) - Dfrez(ni)) / 2 * PI) * Tan(1 * PI / 180)), 3)

                        Next
                        i = 0
                        With Form1.ListBox2.Items
                            .Add("G00 Z" & Form1.TextBoxplbez.Text & ".") '10
                            .Add("G00 X" & Round(XotnobshC(j, crcell) + xprip, 3) & " Y" & Round(-YotnobshC(j, crcell) - yprip - (diamokr(j, crcell) - Dfrez(ni)) / 2, 3)) '11
                            .Add("G00 Z" & zvhodpr(m, crcell) & ".") '12
                            .Add("G03 X" & Round(XotnobshC(j, crcell) + xprip, 3) & " Y" & Round(-YotnobshC(j, crcell) - yprip - (diamokr(j, crcell) - Dfrez(ni)) / 2, 3) & " Z" & Round(zvhodpr(m, crcell), 3) & " R-" & Round((diamokr(j, crcell) - Dfrez(ni)) / 2, 3) & " F" & Form1.TextBoxpdchvert.Text) '13
                        End With
                        curr = curr + 4
                        i = 2
                        'Form1.ListBox5.Items.Add(Form2.TextBoxugolzag.Text)
                        'While Round(zvhodpr(m, crcell) - ((2 * (diamokr(j, crcell) - Dfrez(ni)) / 2 * PI) * (Tan(1 * PI / 180))) * i, 3) >= Decimal.Parse(Form1.TextBoxnpl.Text)
                        '    If plusminus = True Then
                        '        Form1.ListBox2.Items.Add("X" & Round(XotnobshC(j, crcell) + xprip, 3) & " Y" & Round(-YotnobshC(j, crcell) - yprip + (diamokr(j, crcell) - Dfrez(ni)) / 2, 3) & " Z" & Round(zvhodpr(m, crcell) - ((2 * (diamokr(j, crcell) - Dfrez(ni)) / 2 * PI) * (Tan(1 * PI / 180))) * i, 3) & " R-" & Round((diamokr(j, crcell) - Dfrez(ni)) / 2, 3))
                        '        'Else
                        '        Form1.ListBox2.Items.Add("X" & Round(XotnobshC(j, crcell) + xprip, 3) & " Y" & Round(-YotnobshC(j, crcell) - yprip - (diamokr(j, crcell) - Dfrez(ni)) / 2, 3) & " Z" & Round(zvhodpr(m, crcell) - ((2 * (diamokr(j, crcell) - Dfrez(ni)) / 2 * PI) * (Tan(1 * PI / 180))) * (i + 1), 3) & " R-" & Round((diamokr(j, crcell) - Dfrez(ni)) / 2, 3))
                        '    End If
                        '    plusminus = Not plusminus

                        '    i = i + 1
                        '    curr = curr + 1
                        'End While
                        'ТЕСТОВЫЙ УЧАСТОК
                        While Round(zvhodpr(m, crcell) - ((2 * (diamokr(j, crcell) - Dfrez(ni)) / 2 * PI) * (Tan(1 * PI / 180))) * 0.5 * i, 3) >= Single.Parse(Form1.TextBoxnpl.Text)
                            If plusminus = True Then
                                Form1.ListBox2.Items.Add("X" & Round(XotnobshC(j, crcell) + xprip, 3) & " Y" & Round(-YotnobshC(j, crcell) - yprip + (diamokr(j, crcell) - Dfrez(ni)) / 2, 3) & " Z" & Round(zvhodpr(m, crcell) - (((diamokr(j, crcell) - Dfrez(ni)) / 2 * PI) * (Tan(1 * PI / 180))) * i, 3) & " R-" & Round((diamokr(j, crcell) - Dfrez(ni)) / 2, 3))
                            Else
                                If zvhodpr(m, crcell) - (((diamokr(j, crcell) - Dfrez(ni)) / 2 * PI) * (Tan(1 * PI / 180))) * (i + 1) > Single.Parse(Form1.TextBoxnpl.Text) Then
                                    Form1.ListBox2.Items.Add("X" & Round(XotnobshC(j, crcell) + xprip, 3) & " Y" & Round(-YotnobshC(j, crcell) - yprip - (diamokr(j, crcell) - Dfrez(ni)) / 2, 3) & " Z" & Round(zvhodpr(m, crcell) - (((diamokr(j, crcell) - Dfrez(ni)) / 2 * PI) * (Tan(1 * PI / 180))) * (i), 3) & " R-" & Round((diamokr(j, crcell) - Dfrez(ni)) / 2, 3))
                                Else
                                    If plusminus = True Then
                                        Form1.ListBox2.Items.Add("X" & Round(XotnobshC(j, crcell) + xprip, 3) & " Y" & Round(-YotnobshC(j, crcell) - yprip + (diamokr(j, crcell) - Dfrez(ni)) / 2, 3) & " Z" & Round(Single.Parse(Form1.TextBoxnpl.Text), 3) & " R-" & Round((diamokr(j, crcell) - Dfrez(ni)) / 2, 3))
                                    Else
                                        Form1.ListBox2.Items.Add("X" & Round(XotnobshC(j, crcell) + xprip, 3) & " Y" & Round(-YotnobshC(j, crcell) - yprip - (diamokr(j, crcell) - Dfrez(ni)) / 2, 3) & " Z" & Round(Single.Parse(Form1.TextBoxnpl.Text), 3) & " R-" & Round((diamokr(j, crcell) - Dfrez(ni)) / 2, 3))
                                    End If
                                End If
                            End If
                            plusminus = Not plusminus
                            i = i + 1
                            curr = curr + 1
                        End While
                        'ТЕСТОВЫЙ УЧАСТОК
                        rastoyanie(crcell) = Single.Parse(Form1.TextBoxplbez.Text) - Single.Parse(Form1.TextBoxnpl.Text) + rastoyanie(crcell)
                        vremya(crcell) = 1.5 * rastoyanie(crcell) / Single.Parse(Form1.TextBoxpdchvert.Text)
                        Form1.TextBoxmin.Text = Fix(vremya(crcell))
                        Form1.TextBoxsek.Text = Round((vremya(crcell) - Fix(vremya(crcell))) * 60, 0)
                        i = 0
                    Next
                    j = 0
                    i = 0

                    'Else
                    'MsgBox("ВНИМАНИЕ: Диаметр фрезы превышает диаметр отверстия")
                    'Form1.TabControl1.TabPages(1).Show()
                    'Form1.TextBoxDkf.BackColor = Drawing.Color.Red
                    ' 'Exit Function
                    ' End If
                End If
            ElseIf viborRB(crcell) = "Rezba" Then
                Form1.ListBox2.Items.Add("G00 G54 G90 X" & GcodeXN(0, 0, crcell) & " Y" & GcodeYN(0, 0, crcell)) '8
                Form1.ListBox2.Items.Add("G43 H" & Tinst(crcell) & " D" & Tinst(crcell) & " Z" & Form1.TextBoxplbez.Text) '9
                Form1.ListBox2.Items.Add("G95")
                Form1.ListBox2.Items.Add("G98 G84 X" & GcodeXN(0, 0, crcell) & " Y" & GcodeYN(0, 0, crcell) & " Z" & Form1.TextBoxnpl.Text & " R" & Form1.TextBoxbzrast.Text & " F" & Convert.ToString(ShagM(Form1.ListBox1.SelectedIndex))) '9
                For k = 1 To kolvo(0, crcell) - 1
                    Form1.ListBox2.Items.Add("X" & GcodeXN(0, k, crcell) & " Y" & GcodeYN(0, k, crcell))
                Next
                k = 0
                Form1.ListBox2.Items.Add("G80")
                Form1.ListBox2.Items.Add("G94")
                vremya(crcell) = kolvo(0, crcell) * (Single.Parse(Form1.TextBoxbzrast.Text) - Single.Parse(Form1.TextBoxnpl.Text)) / (Convert.ToString(ShagM(Form1.ListBox1.SelectedIndex)) * Single.Parse(Form1.TextBoxobchern.Text))
                Form1.TextBoxmin.Text = Fix(vremya(crcell))
                Form1.TextBoxsek.Text = Round((vremya(crcell) - Fix(vremya(crcell))) * 60, 0)
            ElseIf viborRB(crcell) = "Ustup" Then
                'MsgBox(GcodeXN(j, k,crcell))
                Form1.ListBox5.Items.Add("Ustup")
                With Form1.ListBox2.Items
                    .Add("G00 G54 G90 X" & Round(XobshotnN(j, crcell) + xprip, 3) & " Y" & Round(-YobshotnN(j, crcell) - yprip, 3)) '8
                    .Add("G43 H" & Tinst(crcell) & " D" & Tinst(crcell) & " Z" & Form1.TextBoxplbez.Text & ".") '9
                    .Add("Z" & Form1.TextBoxbzrast.Text & ".") '10
                    '.Add("G01 Z" & zvhodpr(1,crcell) & " F" & Form1.TextBox5.Text) '11
                    '.Add("X" & GcodeXN(0, kp - 1,crcell) & " Y" & GcodeYN(0, kp - 1,crcell)) '12
                End With
                curr = curr + 3
                For m = 0 To kchastey - 1
                    j = 0
                    i = 0
                    k = kp - 1
                    Form1.ListBox2.Items.Add("G00 X" & Round(XobshotnN(j, crcell) + xprip, 3) & " Y" & Round(-YobshotnN(j, crcell) - yprip, 3))
                    Form1.ListBox2.Items.Add("G01 Z" & zvhodpr(m + 1, crcell) & " F" & Form1.TextBoxpdchvert.Text) '11
                    Form1.ListBox2.Items.Add("F" & Form1.TextBoxobchern.Text)
                    curr = curr + 2
                    'While k >= 0
                    '    j = 0
                    '    While j <= kolvoobsh(crcell) - 2
                    '        'elementponomeru(j) = element(j, k, crcell)
                    '        If elementponomeru(0) = "Отрезок" Then
                    '            ' MsgBox("отр0")
                    '            If elementponomeru(j) = "Отрезок" Then
                    '            ElseIf elementponomeru(j + 1) = "Отрезок" Or elementponomeru(j + 1) = Nothing Then
                    '                If j <= kolvoobsh(crcell) - 2 Then
                    '                    Form1.ListBox2.Items.Add("G01 X" & GcodeXN(j, k, crcell) & " Y" & GcodeYN(j, k, crcell))
                    '                    curr = curr + 1
                    '                Else
                    '                    Form1.ListBox2.Items.Add("G01 X" & GcodeXN(0, k, crcell) & " Y" & GcodeYN(0, k, crcell))
                    '                    curr = curr + 1
                    '                End If
                    '                j = j + 1
                    '            End If
                    '        End If
                    '    End While
                    '    k = k - 1
                    'End While
                    Form1.ListBox2.Items.Add("G01 Z" & Form1.TextBoxbzrast.Text) '11
                Next

            End If

            j = 0
            i = 0

            k = 0
            With Form1.ListBox2.Items
                .Add("G00 Z" & Form1.TextBoxplbez.Text & ".")
                .Add("M09")
                .Add("G00 G28 G91 Z0")
                .Add("G00 G28 G91 X0")
                .Add("G00 G28 G91 Y0")
                .Add("G90")
            End With
        Catch ex1 As Exception
            Form1.ListBox5.Items.Add(ex1.Message)
            p = p + 1
            Dim stacktr As New StackTrace(ex1, True)
            If stacktr.FrameCount > 0 Then
                Dim stackfr As New StackFrame
                stackfr = stacktr.GetFrame(0)
                Dim errorline As Integer = stackfr.GetFileLineNumber()
                Dim functionname As String = stackfr.GetMethod().Name
                Form1.ListBox5.Items.Add("Ошибка в " & functionname & " на линии" & errorline)
                p = p + 1
                Form1.ListBox5.Items.Add(ex1.Message)
                p = p + 1
            End If
        End Try

    End Function
    Public Function Peresech_s_zag(Nachtchk As Drawing.PointF, Kontchk As Drawing.PointF, Centrtch As Drawing.PointF, st_zag As Single) As Single
        Try
            Dim radius As Single
            radius = Sqrt((Nachtchk.X - Centrtch.X) ^ 2 + (Nachtchk.Y - Centrtch.Y) ^ 2)
            Dim discr As Single
            Dim rast(2), y(2), x(2) As Single
            Dim A(2), B(2), C(2), alfa(2) As Single


            'MsgBox("Nachtchk.X=" & Nachtchk.X)
            'MsgBox("Kontchk.X=" & Kontchk.X)
            'MsgBox("Kontchk.Y=" & Kontchk.Y)
            If Round(st_zag, 0) = Round(Xmaxloc(0) - Xcoord + xprip + Dfrez(ni) * per / 2, 0) Or Round(st_zag, 0) = Round(-xprip - Dfrez(ni) * per / 2, 0) Then
                If Nachtchk.X > Xmaxloc(0) - Xcoord + xprip + Dfrez(ni) * per / 2 Or Nachtchk.X < -xprip - Dfrez(ni) * per / 2 Then
                    discr = 4 * (Centrtch.Y) ^ 2 - 4 * ((Centrtch.Y) ^ 2 + (st_zag - Centrtch.X) ^ 2 - radius ^ 2)
                    ' MsgBox("discr=" & discr)
                    y(0) = (2 * Centrtch.Y + Sqrt(discr)) / 2
                    y(1) = (2 * Centrtch.Y - Sqrt(discr)) / 2
                    'MsgBox(" y(0)=" & y(0))
                    'MsgBox(" y(1)=" & y(1))
                    'rast(0) = Math.Abs(y(0) - Kontchk.Y)
                    'rast(1) = Math.Abs(y(1) - Kontchk.Y)
                    'If rast(1) < rast(0) Then
                    '    Peresech_s_zag = y(1)
                    'Else
                    '    Peresech_s_zag = y(0)
                    'End If
                    For h = 0 To 1
                        A(h) = Sqrt((Nachtchk.X - Kontchk.X) ^ 2 + (y(h) - Kontchk.Y) ^ 2)
                        B(h) = Sqrt((Nachtchk.X - Centrtch.X) ^ 2 + (y(h) - Centrtch.Y) ^ 2)
                        C(h) = Sqrt((Kontchk.X - Centrtch.X) ^ 2 + (Kontchk.Y - Centrtch.Y) ^ 2)
                        alfa(h) = Math.Acos(theorcos(A(h), B(h), C(h))) * 180 / PI
                        If alfa(h) > 180 Then
                            alfa(h) = 360 - alfa(h)
                        End If
                        With Form1.ListBox5.Items
                            .Add("--------------------")
                            .Add("y(" & h & ") =" & y(h))
                            .Add("alfa(" & h & ") =" & alfa(h))
                        End With
                    Next
                ElseIf Kontchk.X > Xmaxloc(0) - Xcoord + xprip + Dfrez(ni) * per / 2 Or Kontchk.X < -xprip - Dfrez(ni) * per / 2 Then
                    discr = 4 * (Centrtch.Y) ^ 2 - 4 * ((Centrtch.Y) ^ 2 + (st_zag - Centrtch.X) ^ 2 - radius ^ 2)
                    ' MsgBox("discr=" & discr)
                    y(0) = (2 * Centrtch.Y + Sqrt(discr)) / 2
                    y(1) = (2 * Centrtch.Y - Sqrt(discr)) / 2
                    'MsgBox(" y(0)=" & y(0))
                    'MsgBox(" y(1)=" & y(1))
                    'rast(0) = Math.Abs(y(0) - Nachtchk.Y)
                    'rast(1) = Math.Abs(y(1) - Nachtchk.Y)
                    'If rast(1) < rast(0) Then
                    '    Peresech_s_zag = y(1)
                    'Else
                    '    Peresech_s_zag = y(0)
                    'End If
                    For h = 0 To 1
                        A(h) = Sqrt((Nachtchk.X - Kontchk.X) ^ 2 + (Nachtchk.Y - y(h)) ^ 2)
                        B(h) = Sqrt((Nachtchk.X - Centrtch.X) ^ 2 + (Nachtchk.Y - Centrtch.Y) ^ 2)
                        C(h) = Sqrt((Kontchk.X - Centrtch.X) ^ 2 + (y(h) - Centrtch.Y) ^ 2)
                        alfa(h) = Math.Acos(theorcos(A(h), B(h), C(h))) * 180 / PI
                        If alfa(h) > 180 Then
                            alfa(h) = 360 - alfa(h)
                        End If
                        'With Form1.ListBox5.Items
                        '    .Add("--------------------")
                        '    .Add("y(" & h & ") =" & y(h))
                        '    .Add("alfa(" & h & ") =" & alfa(h))
                        'End With
                    Next
                Else
                    Form1.ListBox5.Items.Add("Нет превышения габаритовХ")
                End If
                If alfa(0) < alfa(1) Then
                    Peresech_s_zag = y(0)
                Else
                    Peresech_s_zag = y(1)
                End If
            ElseIf Round(st_zag, 0) = Round(-Yminloc(0) + Ycoord + yprip + Dfrez(ni) * per / 2, 0) Or Round(st_zag, 0) = Round(-yprip - Dfrez(ni) * per / 2, 0) Then
                If Nachtchk.Y > -Yminloc(0) + Ycoord + yprip + Dfrez(ni) * per / 2 Or Nachtchk.Y < -yprip - Dfrez(ni) * per / 2 Then
                    discr = 4 * (Centrtch.X) ^ 2 - 4 * ((Centrtch.X) ^ 2 + (st_zag - Centrtch.Y) ^ 2 - radius ^ 2)
                    ' MsgBox("discr=" & discr)
                    x(0) = (2 * Centrtch.X + Sqrt(discr)) / 2
                    x(1) = (2 * Centrtch.X - Sqrt(discr)) / 2
                    'MsgBox(" y(0)=" & y(0))
                    'MsgBox(" y(1)=" & y(1))
                    'rast(0) = Math.Abs(x(0) - Kontchk.X)
                    'rast(1) = Math.Abs(x(1) - Kontchk.X)
                    'If rast(1) < rast(0) Then
                    '    Peresech_s_zag = x(1)
                    'Else
                    '    Peresech_s_zag = x(0)
                    'End If
                    For h = 0 To 1
                        A(h) = Sqrt((x(h) - Kontchk.X) ^ 2 + (Nachtchk.Y - Kontchk.Y) ^ 2)
                        B(h) = Sqrt((x(h) - Centrtch.X) ^ 2 + (Nachtchk.Y - Centrtch.Y) ^ 2)
                        C(h) = Sqrt((Kontchk.X - Centrtch.X) ^ 2 + (Kontchk.Y - Centrtch.Y) ^ 2)
                        alfa(h) = Math.Acos(theorcos(A(h), B(h), C(h))) * 180 / PI
                        If alfa(h) > 180 Then
                            alfa(h) = 360 - alfa(h)
                        End If
                        With Form1.ListBox5.Items
                            .Add("--------------------")
                            .Add("x(" & h & ") =" & x(h))
                            .Add("A(" & h & ") =" & A(h))
                            .Add("B(" & h & ") =" & B(h))
                            .Add("C(" & h & ") =" & C(h))
                            .Add("alfa(" & h & ") =" & alfa(h))
                        End With
                    Next
                ElseIf Kontchk.Y > -Yminloc(0) + Ycoord + yprip + Dfrez(ni) * per / 2 Or Kontchk.Y < -yprip - Dfrez(ni) * per / 2 Then
                    discr = 4 * (Centrtch.X) ^ 2 - 4 * ((Centrtch.X) ^ 2 + (st_zag - Centrtch.Y) ^ 2 - radius ^ 2)
                    ' MsgBox("discr=" & discr)
                    x(0) = (2 * Centrtch.X + Sqrt(discr)) / 2
                    x(1) = (2 * Centrtch.X - Sqrt(discr)) / 2
                    'MsgBox(" y(0)=" & y(0))
                    'MsgBox(" y(1)=" & y(1))
                    'rast(0) = Math.Abs(x(0) - Nachtchk.X)
                    'rast(1) = Math.Abs(x(1) - Nachtchk.X)
                    'If rast(1) < rast(0) Then
                    '    Peresech_s_zag = x(1)
                    'Else
                    '    Peresech_s_zag = x(0)
                    'End If
                    'With Form1.ListBox5.Items
                    '    .Add("Решение кв. ур:")
                    '    .Add("st_zag=" & st_zag)
                    '    .Add("radius=" & radius)
                    '    .Add("XobshrisN(" & i & ", k, l)=" & XobshrisN(i, k, l))
                    '    .Add("YobshrisN(" & i & ", k, l)=" & YobshrisN(i, k, l))
                    '    .Add("XobshrisK(" & i & ", k, l)=" & XobshrisK(i, k, l))
                    '    .Add("YobshrisK(" & i & ", k, l)=" & YobshrisK(i, k, l))
                    '    .Add("XotnobshC(" & i & ", k, l)=" & XotnobshC(i, l))
                    '    .Add("YotnobshC(" & i & ", k, l)=" & YotnobshC(i, l))
                    'End With
                    For h = 0 To 1
                        A(h) = Sqrt((Nachtchk.X - x(h)) ^ 2 + (Nachtchk.Y - Kontchk.Y) ^ 2)
                        B(h) = Sqrt((Nachtchk.X - Centrtch.X) ^ 2 + (Nachtchk.Y - Centrtch.Y) ^ 2)
                        C(h) = Sqrt((x(h) - Centrtch.X) ^ 2 + (Kontchk.Y - Centrtch.Y) ^ 2)
                        alfa(h) = Math.Acos(theorcos(A(h), B(h), C(h))) * 180 / PI
                        If alfa(h) > 180 Then
                            alfa(h) = 360 - alfa(h)
                        End If
                        'With Form1.ListBox5.Items
                        '    .Add("--------------------")
                        '    .Add("x(" & h & ") =" & x(h))
                        '    .Add("A(" & h & ") =" & A(h))
                        '    .Add("B(" & h & ") =" & B(h))
                        '    .Add("C(" & h & ") =" & C(h))
                        '    .Add("alfa(" & h & ") =" & alfa(h))
                        'End With
                    Next
                Else
                    Form1.ListBox5.Items.Add("Нет превышения габаритовУ")

                End If
                If alfa(0) < alfa(1) Then
                    Peresech_s_zag = x(0)
                Else
                    Peresech_s_zag = x(1)
                End If
            Else
                Form1.ListBox5.Items.Add("Нет превышения габаритов")
            End If

            'MsgBox("Kontchk.Y=" & Kontchk.Y)
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
    Public Function KVK(x1 As Single, x2 As Single, x3 As Single, y1 As Single, y2 As Single, y3 As Single) As Vnutrfunction
        Dim k12, k23, b_12, b_23, A12, B12, C12, D12, A23, B23, C23, D23 As Single
        Dim x12(1), y12(1), x23(1), y23(1), dist(1) As Single

        If x1 = x2 And y1 <> y2 Then
            x12(0) = x1
            x12(1) = x1
            C12 = (x12(0) - x2) ^ 2 + y2 ^ 2 - 1000 ^ 2
            D12 = 4 * y2 ^ 2 - 4 * C12
            y12(0) = (2 * y2 + Sqrt(D12)) / 2
            y12(1) = (2 * y2 - Sqrt(D12)) / 2
        ElseIf x1 <> x2 And y1 = y2 Then
            y12(0) = y1
            y12(1) = y1
            C12 = (y12(0) - y2) ^ 2 + x2 ^ 2 - 1000 ^ 2
            D12 = 4 * x2 ^ 2 - 4 * C12
            x12(0) = (2 * x2 + Sqrt(D12)) / 2
            x12(1) = (2 * x2 - Sqrt(D12)) / 2
        Else
            k12 = (y1 - y2) / (x1 - x2)
            b_12 = y2 - k12 * x2
            A12 = 1 + k12 ^ 2
            B12 = 2 * (k12 * (b_12 - y2) - x2)
            C12 = (x2 ^ 2 + (b_12 - y2) ^ 2 - 1000 ^ 2)
            D12 = B12 ^ 2 - 4 * A12 * C12

            x12(0) = (-B12 + Sqrt(D12)) / (2 * A12)
            y12(0) = k12 * x12(0) + b_12
            x12(1) = (-B12 - Sqrt(D12)) / (2 * A12)
            y12(1) = k12 * x12(1) + b_12
        End If
        For xx = 0 To 1
            dist(xx) = Sqrt((x12(xx) - x1) ^ 2 + (y12(xx) - y1) ^ 2)
        Next
        If dist(0) >= dist(1) Then
            KVK.x1 = x12(1)
            KVK.y1 = y12(1)
        Else
            KVK.x1 = x12(0)
            KVK.y1 = y12(0)
        End If

        If x2 = x3 And y2 <> y3 Then
            x23(0) = x2
            x23(1) = x2
            C23 = (x23(0) - x2) ^ 2 + y2 ^ 2 - 1000 ^ 2
            D23 = 4 * y2 ^ 2 - 4 * C23
            y23(0) = (2 * y2 + Sqrt(D23)) / 2
            y23(1) = (2 * y2 - Sqrt(D23)) / 2
        ElseIf x2 <> x3 And y2 = y3 Then
            y23(0) = y2
            y23(1) = y2
            C23 = (y23(0) - y2) ^ 2 + x2 ^ 2 - 1000 ^ 2
            D23 = 4 * x2 ^ 2 - 4 * C23
            x23(0) = (2 * x2 + Sqrt(D23)) / 2
            x23(1) = (2 * x2 - Sqrt(D23)) / 2
        Else
            k23 = (y2 - y3) / (x2 - x3)
            b_23 = y2 - k23 * x2
            A23 = 1 + k23 ^ 2
            B23 = 2 * (k23 * (b_23 - y2) - x2)
            C23 = (x2 ^ 2 + (b_23 - y2) ^ 2 - 1000 ^ 2)
            D23 = B23 ^ 2 - 4 * A23 * C23

            x23(0) = (-B23 + Sqrt(D23)) / (2 * A23)
            y23(0) = k23 * x23(0) + b_23
            x23(1) = (-B23 - Sqrt(D23)) / (2 * A23)
            y23(1) = k23 * x23(1) + b_23
        End If
        For xx = 0 To 1
            dist(xx) = Sqrt((x23(xx) - x3) ^ 2 + (y23(xx) - y3) ^ 2)
        Next
        If dist(0) >= dist(1) Then
            KVK.x2 = x23(1)
            KVK.y2 = y23(1)
        Else
            KVK.x2 = x23(0)
            KVK.y2 = y23(0)
        End If

    End Function
End Module
