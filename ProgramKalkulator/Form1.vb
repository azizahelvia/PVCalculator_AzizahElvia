Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ViewBox.Text = ViewBox.Text + "1"
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ViewBox.Text = ViewBox.Text + "2"
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        ViewBox.Text = ViewBox.Text + "3"
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        ViewBox.Text = ViewBox.Text + "4"
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        ViewBox.Text = ViewBox.Text + "5"
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        ViewBox.Text = ViewBox.Text + "6"
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        ViewBox.Text = ViewBox.Text + "7"
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        ViewBox.Text = ViewBox.Text + "8"
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        ViewBox.Text = ViewBox.Text + "9"
    End Sub

    Private Sub Button0_Click(sender As Object, e As EventArgs) Handles Button0.Click
        ViewBox.Text = ViewBox.Text + "0"
    End Sub

    Private Sub Button00_Click(sender As Object, e As EventArgs) Handles Button00.Click
        ViewBox.Text = ViewBox.Text + "00"
    End Sub

    Private Sub ButtonDecimal_Click(sender As Object, e As EventArgs) Handles ButtonDecimal.Click
        ViewBox.Text = ViewBox.Text + "."
    End Sub

    Private Sub ButtonAdd_Click(sender As Object, e As EventArgs) Handles ButtonAdd.Click
        Label1.Text = ViewBox.Text
        Label2.Text = "+"
        ViewBox.Text = ""
    End Sub

    Private Sub ButtonSubs_Click(sender As Object, e As EventArgs) Handles ButtonSubs.Click
        Label1.Text = ViewBox.Text
        Label2.Text = "-"
        ViewBox.Text = ""
    End Sub

    Private Sub ButtonMult_Click(sender As Object, e As EventArgs) Handles ButtonMult.Click
        Label1.Text = ViewBox.Text
        Label2.Text = "x"
        ViewBox.Text = ""
    End Sub

    Private Sub ButtonDiv_Click(sender As Object, e As EventArgs) Handles ButtonDiv.Click
        Label1.Text = ViewBox.Text
        Label2.Text = "÷"
        ViewBox.Text = ""
    End Sub

    Private Sub ButtonClear_Click(sender As Object, e As EventArgs) Handles ButtonClear.Click
        ViewBox.Text = ""
        Label2.Text = ""
    End Sub

    Private Sub ButtonClearEntry_Click(sender As Object, e As EventArgs) Handles ButtonClearEntry.Click
        ViewBox.Text = ""
        Label2.Text = ""
        Label1.Text = ""
    End Sub

    Private Sub ButtonEqual_Click(sender As Object, e As EventArgs) Handles ButtonEqual.Click
        If Label2.Text = "+" Then
            ViewBox.Text = Val(Label1.Text) + Val(ViewBox.Text)
            Label1.Text = ""
            Label2.Text = "="
        End If

        If Label2.Text = "-" Then
            ViewBox.Text = Val(Label1.Text) - Val(ViewBox.Text)
            Label1.Text = ""
            Label2.Text = "="
        End If

        If Label2.Text = "x" Then
            ViewBox.Text = Val(Label1.Text) * Val(ViewBox.Text)
            Label1.Text = ""
            Label2.Text = "="
        End If

        If Label2.Text = "÷" Then
            If Val(ViewBox.Text) = "0" Then
                ViewBox.Text = "Cannot Divided By 0"
            Else
                ViewBox.Text = Val(Label1.Text) / Val(ViewBox.Text)
            End If
            Label1.Text = ""
            Label2.Text = "="
        End If
    End Sub

End Class
