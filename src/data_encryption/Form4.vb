Public Class Form4

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

    End Sub

    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Form1.Enabled = False
        Dim str = Form1.RichTextBox3.Text
        Dim n As Integer
        Dim fin As String
        fin = ""
        TextBox1.Text = calc_freq(Form1.RichTextBox3.Text)
        Me.Cursor = Cursors.WaitCursor
        For n = 0 To str.Length - 1
            Dim s = str.Substring(n, 1)
            Dim temp As Integer
            temp = (TextBox1.Text).IndexOf(s)
            If (temp >= 0 And temp < 26 And s.ToUpper = s) Then
                temp = temp + 65
                fin = fin + Chr(temp)
            ElseIf (temp >= 0 And temp < 26 And s.ToUpper <> s) Then
                temp = temp + 65 + 32
                s = Chr(temp)
                fin = fin + s.ToLower
            ElseIf (temp >= 26) Then
                temp = temp + 48 - 26
                fin = fin + Chr(temp)
            Else
                fin = fin + s
            End If
        Next
        Me.Cursor = Cursors.Arrow
        RichTextBox1.Text = fin

    End Sub

    Private Sub Form4_Leave(sender As Object, e As EventArgs) Handles MyBase.Leave, MyBase.FormClosed
        Form1.Enabled = True
    End Sub
End Class