Public Class Form3

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Form1.Enabled = False
        Dim x As Integer
        x = Label1.Text
        RichTextBox1.Text = ceaser_decrypt(Form1.RichTextBox2.Text, x)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim x As Integer
        x = Label1.Text
        x = x - 1
        Label1.Text = x
        RichTextBox1.Text = ceaser_decrypt(Form1.RichTextBox2.Text, x)
        If (x = 0) Then
            Button1.Visible = False
        End If
        If (x < 25) Then
            Button2.Visible = True
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim x As Integer
        x = Label1.Text
        x = x + 1
        Label1.Text = x
        RichTextBox1.Text = ceaser_decrypt(Form1.RichTextBox2.Text, x)
        If (x > 0) Then
            Button1.Visible = True
        End If
        If (x = 25) Then
            Button2.Visible = False
        End If
    End Sub

    Private Sub Form3_Click(sender As Object, e As EventArgs) Handles MyBase.FormClosed
        Form1.Enabled = True
    End Sub
End Class