Public Class frmHEX2DEC

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        If TextBox1.Text.Length > 0 Then
            Label3.Text = HEX2DEC(TextBox1.Text)
        End If
        If TextBox2.Text.Length > 0 Then
            Label4.Text = Hex(Val(TextBox2.Text))
        End If
    End Sub
End Class