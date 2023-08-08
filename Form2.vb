Public Class Form2
    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBoxvkpodv.CheckedChanged
        If CheckBoxvkpodv.Checked = True Then
            ch_vkl(crcell) = True
            If viborRB(crcell) = "Vneshniy contour" Then
                TextBoxdlpodv.Enabled = True

                TextBoxugolzag.Enabled = False
                ' Call vhod_frezi()
            ElseIf viborRB(crcell) = "Vnutrenniy contour" Then
                TextBoxugolzag.Enabled = True
                TextBoxdlpodv.Enabled = False
                ' Call vhod_frezi()
            End If

        Else
            ch_vkl(crcell) = False
            TextBoxugolzag.Enabled = False
            TextBoxdlpodv.Enabled = False
            'Xvhod(l) = 0
            'Yvhod(l) = 0
        End If
    End Sub

    Private Sub Form2_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Try
            vr_dannie(9, crcell) = TextBoxdlpodv.Text
            vr_dannie(10, crcell) = TextBoxugolzag.Text
            vr_dannie(20, crcell) = Single.Parse(TextBoxXvhod.Text)
            vr_dannie(21, crcell) = Single.Parse(TextBoxYvhod.Text)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Form2_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        Try
            If ch_auto(crcell) = True Then
                CheckBox1.Checked = True
            Else
                CheckBox1.Checked = False
            End If
            If ch_vkl(crcell) = True Then
                CheckBoxvkpodv.Checked = True
            Else
                CheckBoxvkpodv.Checked = False
            End If
            TextBoxdlpodv.Text = vr_dannie(9, crcell)
            If vr_dannie(10, crcell) <> 0 Then
                TextBoxugolzag.Text = vr_dannie(10, crcell)
            Else
                TextBoxugolzag.Text = "1"
            End If
            TextBoxXvhod.Text = Convert.ToString(vr_dannie(20, crcell))
            TextBoxYvhod.Text = Convert.ToString(vr_dannie(21, crcell))
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub TextBoxXvhod_TextChanged(sender As Object, e As EventArgs) Handles TextBoxXvhod.TextChanged
        Try
            If TextBoxXvhod.Text Is Nothing Or TextBoxXvhod.Text = "" Then
                TextBoxXvhod.Text = 0
            End If
            If TextBoxXvhod.Text <> "-" Then
                TextBoxXvhod.BackColor = Drawing.Color.White
                vr_dannie(20, crcell) = Single.Parse(TextBoxXvhod.Text)
            End If

        Catch ex As Exception
            TextBoxXvhod.BackColor = Drawing.Color.Yellow
            Form1.ListBox5.Items.Add(p & ex.Message)
            p = p + 1
        End Try
    End Sub

    Private Sub CheckBox1_CheckedChanged_1(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            TextBoxXvhod.Enabled = False
            TextBoxYvhod.Enabled = False
            ch_auto(crcell) = True
        Else
            TextBoxXvhod.Enabled = True
            TextBoxYvhod.Enabled = True
            ch_auto(crcell) = False
        End If
    End Sub

    Private Sub TextBoxYvhod_TextChanged(sender As Object, e As EventArgs) Handles TextBoxYvhod.TextChanged
        Try
            If TextBoxYvhod.Text Is Nothing Or TextBoxYvhod.Text = "" Then
                TextBoxYvhod.Text = 0
            End If
            If TextBoxYvhod.Text <> "-" Then
                TextBoxYvhod.BackColor = Drawing.Color.White
                vr_dannie(21, crcell) = Single.Parse(TextBoxYvhod.Text)
            End If

        Catch ex As Exception
            TextBoxYvhod.BackColor = Drawing.Color.Yellow
            Form1.ListBox5.Items.Add(p & ex.Message)
            p = p + 1
        End Try
    End Sub
End Class