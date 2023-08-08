Imports System
Imports System.Type
Imports System.ApplicationId
Imports System.Activator
Imports System.Runtime.InteropServices
Imports Inventor
Imports System.Math
Imports System.Drawing
Imports System.IO

Module Module1

    Public _invApp As Inventor.Application 'Активное приложение Inventor 2020
    Public Doc1 As Inventor.DrawingDocument 'Активный чертежный документ Inventor 2020

    'Public SK As System.Windows.Forms.PaintEventArgs '
    Public Sheet1 As Inventor.Sheet 'Активный лист чертежного документа Inventor 2020
    Public oDCS1 As DrawingCurveSegment 'Чертёжная кривая на чертеже
    Public oDC1 As DrawingCurve 'Коллекция чертежный кривых на чертеже
    Public Lsprt As SketchEntity 'Эскизный элемент на чертеже

    Public oView1, oView2, oView3, oView4, oView5, oView6 As DrawingView 'Проекционные виды
    'Public CheBo As CheckBox
    Public oPoint1, oPoint2, oPoint3, oPoint4, oPoint5, oPoint6 As Point2d 'Точки привязки чертежных видов при проецировании
    Public fileinv As String 'Файл, содержащий требуемую пространственную модель
    Public oS As SelectSet 'Объект выбора 
    Public paintcolor As Inventor.Color 'Цвета Inventor 2020, необходимые для отличия выбранных контуров
    Public Kontour As Graphics 'Графический экран внутри АТП
    Public pen1, pen2, pen3, pen4, pen5, pen6 As Pen 'Набор цветов АТП для придания цвета заготовке, контру, траектории и тп.
    Public xprip, yprip, zprip, xprip1, xprip2, yprip1, yprip2 As Single 'Припуск на сторону
    'Public count As Integer
    Public odc1pt() As Double 'Временные числовые пременные, получающие информацию об объекте непосредственно из чертежного документа Inventor 2020
    Public j, i, jnext, l, n, m, p, lloc As Integer 'Переменные для ведения счёта
    'Public elementponomeru(), dugaponomeru() As String 'Номер выбранного элемента, номер выбранной дуги
    Public robsh(), alfa(), betta(), gamma(), delta(), tau() As Single 'Массивы. Радиус выбранной дуги, и расчитаные для нее углы
    Public km1, km2 As Single 'Длины катетов, использующие в функции построния сопряженных отрезков
    Public Xpmmin(), Ypmmin(), Ypmmax(), Xpmmax() As Single 'Массивы. Временные числовые данные в функции поиска минимальной и максимальной координаты контура
    Public XabsN(), XabsK() As Double 'Массивы. Х относительно левого нижнего угла чертежа Inventor 2020
    Public YabsN(), YabsK() As Double 'Массивы. У относительно левого нижнего угла чертежа Inventor 2020
    Public Yabscentr(), Xabscentr(), Xabsmid(), Yabsmid() As Double 'Массивы. Х, У центра и середены дуги относительно левого нижнего угла чертежа Inventor 2020
    Public XotnN(), XotnK(), XotnC(), XotnS() As Single 'Массивы. Х начальный, конечный, центра окружности и середины дуги относительно новой СК
    Public YotnN(), YotnK(), YotnC(), YotnS() As Single 'Массивы. У начальный, конечный, центра окружности и середины дуги относительно новой СК
    Public Sdvg As Single 'Сдвиг изображения относительна нуля графического поля АТП
    Public Yminloc(), Ymaxloc(), Xminloc(), Xmaxloc() As Single 'Массивы. Максимум и минимум Х и У в абсолютных координатах чертежного документа Inventor 2020
    Public Dfrez(20), Dsv(20) As Single 'Диаметр текущей фрезы, сверла
    Public ni As Single 'номер текущего инструмента
    Public Xcoord, Ycoord As Single 'центр новой ЛСК
    Public a1(), a2() As Double 'Длины катетов, использующиеся для кооректрного построения дуг
    Public GcodeXN(,,), GcodeXK(,,), GcodeYN(,,), GcodeYK(,,), GcodeR(,,) As Single 'Координаты в джикод относительно СК G54
    Public k As Integer 'Переменная счёта, используется для многопроходной обработки
    Public MashtabIsobr, MaxGabar As Integer '
    Public Z As Integer 'Высота заготовки
    Public XdcncN(,), XdcncK(,), YdcncN(,), YdcncK(,), YdcncNris(,), YdcncKris(,) As Single 'Массивы. Х, У необходимы для расчёта точек дуг 
    Public XtchkontN1(), XtchkontK1(), XtchkontK2(), YtchkontN1(), YtchkontK1(), YtchkontK2(), Xtchkonttr(,), Ytchkonttr(,) As Single 'Массивы. Х, У необходимы для расчёта точек дуг 
    Public nadolimenyat(,,) As Boolean 'Логический элемент. Используется для для элемента "карман", когда дуга в траектории превращается в точку из-за удалённости контура от линии траектории или слишком больного радиуса инструмента
    Public nomerdugi(,) As Single '
    'Public pr As Double
    Public crv2dev As Inventor.Curve2dEvaluator '
    Public kolvo(40, 15) As Integer 'количество элементов выбранного контура
    Public diamokr(,) As Single 'диаметр окружности на чертеже
    Public nomercudastavitinst As Integer '
    Public k1, k2, kobsh, zazor(), zazormax As Single '
    Public b1, b2, bobsh, R As Single '
    Public x11, x21, x12, x22, x1, x2, xc As Single '
    Public y11, y21, y12, y22, y1, y2, yc As Single '
    Public temp(,) As Single '
    Public kp As Integer 'количество проходов 
    Public prip As Single 'припуск на сторону
    Public per As Single 'перекрытие фрезы в сотых долях
    Public kolvoclikov As Integer = 0 '
    Public nadocheck As Boolean 'проверка на наличие внутренннего сопряжения
    Public XobshrisN(,,), XobshrisK(,,), YobshrisN(,,), YobshrisK(,,), Gcodexobshris(,,), Gcodeyobshris(,,), alfaobsh(,), bettaobsh(,) As Single '
    Public element(,,) As String
    Public dugaponomeruobsh(,) As String
    Public Robshris(,,) As Single
    Public XabsobshN(,), YabsobshN(,), XabsobshK(,), YabsobshK(,), XabsobshC(,), YabsobshC(,), Robsh2(,), XabsobshM(,), YabsobshM(,), XobshotnS(,), YobshotnS(,), XobshotnN(,), YobshotnN(,), XobshotnK(,), YobshotnK(,), YotnobshC(,), XotnobshC(,) As Single
    Public kpobsh() As Integer '
    Public VectAngle() As Single '
    Public Vipuklost(,) As String '
    Public Instr(20) As String '
    Public Dinst(20), Tinst(20) As Integer '
    Public sli As Integer '
    Public Dfrezvrem As Single '
    Public dugaprejnya(,) As Boolean '
    Public pervoeprevishenie(,,) As Boolean '
    Public Xvhod(15), Yvhod(15), Zvhod(15), Rvhod(15) As Single '
    Public zvhodpr(,) As Single '
    Public AutoSK(15) As Boolean '
    Public kchastey As Integer '
    Public curr As Integer 'текущий индекс строки
    Public kolvolines(15) As Integer 'количество линий прохода торцевой фрезы
    Public Slabel(20), Vlabel(20) As Single '
    Public Glabel(20) As String '
    Public vr_dannie(22, 15) As Single '
    Public viborRB(15) As String '
    Public crcell As Integer '
    Public ch_viborka(15), ch_podvod(15), rb_auto20(15), rb_hand21(15), ch_auto(15), ch_vkl(15) As Boolean '
    Public ShagM(20) As Single '
    Public rastoyanie(15), vremya(15) As Single
    Public clck As Integer = 1
    Public seconds As Integer
    Public Nmax As Integer
    Public prjname As String
    Public minus As Short = -1
    Public markerX, markerY As Integer
    Public TXotnN(50, 40), TYotnN(50, 40), TXotnK(50, 40), TYotnK(50, 40), TXotnC(50, 40), TYotnC(50, 40), TXotnS(50, 40), TYotnS(50, 40) As Single
    'TRAHOIDA
    Public Sh_tr, Rad_tr, Sm_tr, Pr_tr, Shag_tr, u As Integer
    Public Cokr_tr As Integer
    Public Yokr_tr(100) As Integer





    Public Function New_ris_traect()
        minus = -1
        rastoyanie(crcell) = 0
        Dim jpred As Integer
        Dim pen4 As New Pen(Brushes.Red, 0.5)
        l = crcell
        If viborRB(l) = "Vnutrenniy contour" Or viborRB(l) = "Vneshniy contour" Or viborRB(l) = "Ustup" Then


            For k = 1 To kpobsh(l)
                For j = 0 To kolvo(k, l) - 1
                    If element(0, k, l) <> "Окружность" Then
                        If j > 0 Then
                            jpred = j - 1
                        Else
                            jpred = kolvo(k, l) - 1
                        End If
                        If element(j, k, l) = "Отрезок" Then
                            Kontour.DrawLine(pen4, XobshrisN(jpred, k, l) + Sdvg, YobshrisN(jpred, k, l) + Sdvg, XobshrisN(j, k, l) + Sdvg, YobshrisN(j, k, l) + Sdvg)
                            rastoyanie(l) = Sqrt((XobshrisN(jpred, k, l) - XobshrisK(j, k, l)) ^ 2 + (YobshrisN(jpred, k, l) - YobshrisK(j, k, l)) ^ 2) + rastoyanie(l)
                        ElseIf element(j, k, l) = "Дуга" Then
                            Dim pduga(2) As Drawing.PointF


                            pduga(0).X = XobshrisN(jpred, k, l)
                            pduga(0).Y = YobshrisN(jpred, k, l)
                            pduga(1).X = XobshrisN(j, k, l)
                            pduga(1).Y = YobshrisN(j, k, l)
                            pduga(2).X = XotnobshC(j, l)
                            pduga(2).Y = YotnobshC(j, l)
                            Call ris_duga_traekt(pduga(0), pduga(1), pduga(2), pen4, j, k)
                        End If
                        ' Kontour.DrawEllipse(Pens.Green, XobshrisN(j, k, l) - 2 + Sdvg, YobshrisN(j, k, l) - 2 + Sdvg, 4, 4)
                    ElseIf element(0, k, l) = "Окружность" Then
                        If viborRB(crcell) = "Vneshniy contour" Then
                            Kontour.DrawEllipse(pen4, XotnobshC(j, l) - Robshris(j, k, l) + Sdvg, YotnobshC(j, l) - Robshris(j, k, l) + Sdvg, 2 * Robshris(j, k, l), 2 * Robshris(j, k, l))
                        ElseIf viborRB(crcell) = "Vnutrenniy contour" Then
                            Kontour.DrawEllipse(pen4, XotnobshC(j, l) - Robshris(j, k, l) + Sdvg, YotnobshC(j, l) - Robshris(j, k, l) + Sdvg, 2 * Robshris(j, k, l), 2 * Robshris(j, k, l))
                        End If
                        j = j + 1

                    End If
                Next
            Next


        ElseIf viborRB(crcell) = "Ploskost" Then
            For k = 0 To kolvolines(l) - 1
                Kontour.DrawLine(pen4, XobshrisN(j, k, l) + Sdvg, YobshrisN(j, k, l) + Sdvg, XobshrisK(j, k, l) + Sdvg, YobshrisN(j, k, l) + Sdvg)
                If k > 0 Then
                    Kontour.DrawLine(pen4, XobshrisK(j, k - 1, l) + Sdvg, YobshrisN(j, k - 1, l) + Sdvg, XobshrisN(j, k, l) + Sdvg, YobshrisN(j, k, l) + Sdvg)
                End If
                rastoyanie(l) = rastoyanie(l) + XobshrisN(0, k, l) - XobshrisK(0, k, l)
            Next

        ElseIf viborRB(crcell) = "Otverstie" Then
            For k = 0 To kolvo(0, l) - 2
                Kontour.DrawLine(pen4, XotnobshC(k, l) + Sdvg, YotnobshC(k, l) + Sdvg, XotnobshC(k + 1, l) + Sdvg, YotnobshC(k + 1, l) + Sdvg)
            Next
        ElseIf viborRB(crcell) = "Rezba" Then
            For k = 0 To kolvo(0, l) - 2
                Kontour.DrawLine(pen4, XotnobshC(k, l) + Sdvg, YotnobshC(k, l) + Sdvg, XotnobshC(k + 1, l) + Sdvg, YotnobshC(k + 1, l) + Sdvg)
            Next
        End If
        j = 0

    End Function
    Public Function peresech(N1 As PointF, K1 As PointF, N2 As PointF, K2 As PointF) As Drawing.PointF
        Dim kp1, kp2, b1, b2 As Single
        If N1.X = K1.X And N2.X <> K2.X Then

            kp2 = (N2.Y - K2.Y) / (N2.X - K2.X)
            b2 = N2.Y - kp2 * N2.X
            peresech.X = N1.X
            peresech.Y = kp2 * peresech.X + b2
        ElseIf N1.X <> K1.X And N2.X = K2.X Then

            kp1 = (N1.Y - K1.Y) / (N1.X - K1.X)
            b1 = N1.Y - kp1 * N1.X
            peresech.X = N2.X
            peresech.Y = kp1 * peresech.X + b1
        Else
            kp1 = (N1.Y - K1.Y) / (N1.X - K1.X)
            b1 = N1.Y - kp1 * N1.X
            kp2 = (N2.Y - K2.Y) / (N2.X - K2.X)
            b2 = N2.Y - kp2 * N2.X
            If kp1 = kp2 Then
                MsgBox("Прямые не пересекаются", "ВНИМАНИЕ")
            Else
                peresech.X = (b2 - b1) / (kp1 - kp2)
                peresech.Y = kp1 * peresech.X + b1
            End If
        End If
    End Function






    Public Function Correctirofka_traektorii()
        'x
        If Abs(XdcncK(i, k) - (Xmaxloc(l) - Xminloc(l) + xprip)) < 0.5 Then
            XdcncK(i, k) = Xmaxloc(l) - Xminloc(l) + xprip
        End If
        If Abs(XdcncN(i, k) - (Xmaxloc(l) - Xminloc(l) + xprip)) < 0.5 Then
            XdcncN(i, k) = Xmaxloc(l) - Xminloc(l) + xprip
        End If
        If Abs(XdcncK(i, k) - xprip) < 0.5 Then
            XdcncK(i, k) = xprip
        End If
        If Abs(XdcncN(i, k) - xprip) < 0.5 Then
            XdcncN(i, k) = xprip
        End If
        'y
        If Abs(YdcncK(i, k) - (Ymaxloc(l) - Yminloc(l) + yprip)) < 0.5 Then
            YdcncK(i, k) = Ymaxloc(l) - Yminloc(l) + yprip
        End If
        If Abs(YdcncN(i, k) - (Ymaxloc(l) - Yminloc(l) + yprip)) < 0.5 Then
            YdcncN(i, k) = Ymaxloc(l) - Yminloc(l) + yprip
        End If
        If Abs(YdcncK(i, k) - yprip) < 0.5 Then
            YdcncK(i, k) = yprip
        End If
        If Abs(YdcncN(i, k) - yprip) < 0.5 Then
            YdcncN(i, k) = yprip
        End If
    End Function


    Public Function korrektirovka_traekt()
        Dim vr As Single
        If element(i, 0, l) = "Дуга" Then
            If i >= 0 And i <= kolvo(0, l) - 2 Then
                If Round(XabsobshN(i, l), 1) <> Round(XabsobshN(i + 1, l), 1) And Round(XabsobshN(i, l), 1) <> Round(XabsobshK(i + 1, l), 1) And Round(XabsobshK(i, l), 1) <> Round(XabsobshN(i + 1, l), 1) And Round(XabsobshK(i, l), 1) <> Round(XabsobshK(i + 1, l), 1) Then
                    If Round(YabsobshN(i, l), 1) <> Round(YabsobshN(i + 1, l), 1) And Round(YabsobshN(i, l), 1) <> Round(YabsobshK(i + 1, l), 1) And Round(YabsobshK(i, l), 1) <> Round(YabsobshN(i + 1, l), 1) And Round(YabsobshK(i, l), 1) <> Round(YabsobshK(i + 1, l), 1) Then
                        vr = XabsobshN(i, l)
                        XabsobshN(i, l) = XabsobshK(i, l)
                        XabsobshK(i, l) = vr
                        vr = YabsobshN(i, l)
                        YabsobshN(i, l) = YabsobshK(i, l)
                        YabsobshK(i, l) = vr
                    End If
                End If
            ElseIf i = kolvo(0, l) - 1 Then
                If Round(XabsobshN(i, l), 1) <> Round(XabsobshN(0, l), 1) And Round(XabsobshN(i, l), 1) <> Round(XabsobshK(0, l), 1) And Round(XabsobshK(i, l), 1) <> Round(XabsobshN(0, l), 1) And Round(XabsobshK(i, l), 1) <> Round(XabsobshK(0, l), 1) Then
                    vr = XabsobshN(i, l)
                    XabsobshN(i, l) = XabsobshK(i, l)
                    XabsobshK(i, l) = vr
                    vr = YabsobshN(i, l)
                    YabsobshN(i, l) = YabsobshK(i, l)
                    YabsobshK(i, l) = vr
                End If
            End If
        End If
    End Function


End Module
