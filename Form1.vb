Public Class Form1
    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub TextBox11_TextChanged(sender As Object, e As EventArgs) Handles Venta.TextChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Yardas = Val(TextBox1.Text) + Val(TextBox2.Text) + Val(TextBox3.Text) + Val(TextBox4.Text)

        If Imperial.Checked = True And Val(Yardas) > 3 Then
            MsgBox("Sobrepasa el máximo permitido de yardas. Imperial 3 yardas.")
            TextBox1.Clear()
            TextBox2.Clear()
            TextBox3.Clear()
            TextBox4.Clear()

        End If

        If Matrimonial.Checked = True And Val(Yardas) > 5 Then
            MsgBox("Sobrepasa el máximo permitido de yardas. Matrimonial 5 yardas.")
            TextBox1.Clear()
            TextBox2.Clear()
            TextBox3.Clear()
            TextBox4.Clear()
        End If

        If Queen.Checked = True And Val(Yardas) > 6 Then
            MsgBox("Sobrepasa el máximo permitido de yardas. Queen 6 yardas.")
            TextBox1.Clear()
            TextBox2.Clear()
            TextBox3.Clear()
            TextBox4.Clear()
        End If

        If King.Checked = True And Val(Yardas) > 7 Then
            MsgBox("Sobrepasa el máximo permitido de yardas. King 7 yardas.")
            TextBox1.Clear()
            TextBox2.Clear()
            TextBox3.Clear()
            TextBox4.Clear()
        End If

        If Imperial.Checked = True Then
            PMano.Text = 65.5
        ElseIf Matrimonial.Checked = True Then
            PMano.Text = 85.99
        ElseIf Queen.Checked = True Then
            PMano.Text = 99.99
        ElseIf King.Checked = True Then
            PMano.Text = 105.99
        End If

        If CheckBox1.Checked = True Then
            Plino.Text = Val(TextBox1.Text) * 15
        Else
            Plino.Text = 0
        End If

        If CheckBox2.Checked = True Then
            Palgodon.Text = Val(TextBox2.Text) * 23.99
        Else
            Palgodon.Text = 0
        End If

        If CheckBox3.Checked = True Then
            Pseda.Text = Val(TextBox3.Text) * 23.99
        Else
            Pseda.Text = 0
        End If

        If CheckBox4.Checked = True Then
            Philo.Text = Val(TextBox4.Text) * 23.99
        Else
            Philo.Text = 0
        End If


        Costo.Text = Val(PMano.Text) + Val(Yardas)

        Venta.Text = (Val(Costo.Text) * 65 / 100) + Val(Costo.Text)



    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        TextBox1.Clear()
        TextBox2.Clear()
        TextBox3.Clear()
        TextBox4.Clear()
        PMano.Clear()
        Plino.Clear()
        Palgodon.Clear()
        Pseda.Clear()
        Philo.Clear()
        Costo.Clear()
        Venta.Clear()


    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Form2.Show()

    End Sub
End Class
