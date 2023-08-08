
Imports System
Imports System.Type
Imports System.ApplicationId
Imports System.Activator
Imports System.Runtime.InteropServices
Imports Inventor
Imports System.Math
Imports System.Drawing
Imports System.IO

Public Class Form4
    Public radius As Single
    Public gr As Graphics

    Sub New()

        ' Этот вызов является обязательным для конструктора.
        InitializeComponent()

        gr = PictureBox1.CreateGraphics
        gr.ScaleTransform(1, 1)
        gr.Clear(Drawing.Color.White)

        ' Добавить код инициализации после вызова InitializeComponent().

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        PictureBox1.Image = Nothing
        PictureBox1.Refresh()
        Dim xp2, yp2, A, Bi, Ci, Di, R1, R2, C As Single
        Dim x3(1), y3(1), xc(1), yc(1) As Single
        k = Single.Parse(TextBoxXC1.Text)

        'b = Single.Parse(TextBoxYC1.Text)
        'xc = Single.Parse(TextBoxXC2.Text)
        'yc = Single.Parse(TextBoxYC2.Text)
        R1 = Single.Parse(TextBoxR1.Text)
        R2 = Single.Parse(TextBoxR2.Text)
        xc(0) = Single.Parse(TextBoxXC1.Text)
        xc(1) = Single.Parse(TextBoxXC2.Text)
        yc(0) = Single.Parse(TextBoxYC1.Text)
        yc(1) = Single.Parse(TextBoxYC2.Text)

        xp2 = Round(xc(1) - xc(0), 3)
        yp2 = Round(yc(1) - yc(0), 3)
        Ci = Round((R2 ^ 2 - xp2 ^ 2 - yp2 ^ 2 - R1 ^ 2) / (-2), 1)

        If xp2 <> 0 Then
            A = Round((yp2 ^ 2 + xp2 ^ 2), 4)
            Bi = Round(-2 * yp2 * Ci, 1)
            C = Round(Ci ^ 2 - R1 ^ 2 * xp2 ^ 2, 4)
            Di = Abs(Round(Bi ^ 2 - 4 * A * C, 2))
            x3(0) = 0
            y3(0) = 0
            x3(1) = 0
            y3(1) = 0
            If Di >= 0 Then
                y3(0) = (-Bi + Sqrt(Di)) / (2 * A)
                x3(0) = (Ci - y3(0) * yp2) / xp2 + xc(0)
                y3(0) = y3(0) + yc(0)
                y3(1) = (-Bi - Sqrt(Di)) / (2 * A)
                x3(1) = (Ci - y3(1) * yp2) / xp2 + xc(0)
                y3(1) = y3(1) + yc(0)
            Else
            End If
        Else
            y3(0) = Ci / yp2 + yc(0)
            x3(0) = Sqrt(R1 ^ 2 - Ci ^ 2 / yp2 ^ 2) + xc(0)
        End If
        TextBoxD.Text = Di
        TextBoxx1.Text = x3(0)
        TextBoxx2.Text = x3(1)
        TextBoxy1.Text = y3(0)
        TextBoxy2.Text = y3(1)





        'TextBoxR2.Text = ln_okr(k, b, xc, yc, R).D
        'TextBoxx1.Text = ln_okr(k, b, xc, yc, R).x3_1
        'TextBoxy1.Text = ln_okr(k, b, xc, yc, R).y3_1
        'TextBoxx2.Text = ln_okr(k, b, xc, yc, R).x3_2
        'TextBoxy2.Text = ln_okr(k, b, xc, yc, R).y3_2
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        markerX = -markerX
        If markerX = 1 Then
            Button2.Text = "+"
        ElseIf markerX = -1 Then
            Button2.Text = "-"
        End If
        Form1.Button7.PerformClick()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        markerY = -markerY
        If markerY = 1 Then
            Button3.Text = "+"
        ElseIf markerY = -1 Then
            Button3.Text = "-"
        End If
        Form1.Button7.PerformClick()
    End Sub
End Class