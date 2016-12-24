Public Class GENERATE


    Private Sub button2_Click(sender As Object, e As EventArgs) Handles button2.Click
        Form1.Enabled = True
        Me.Close()
    End Sub

    Private Sub GENERATE_FormClosing(sender As Object, e As EventArgs) Handles MyBase.FormClosed
        Form1.Enabled = True
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim n As Integer
        If (TextBox1.Text = "") Then
            MsgBox("error: invalid input, blank", MsgBoxStyle.OkOnly, "ERROR !!!")
            Return
        End If
        If (TextBox1.Text < "1" Or TextBox1.Text > "9") Then
            MsgBox("error: 1-9 range supported", MsgBoxStyle.OkOnly, "ERROR !!!")
            Return
        End If
        Dim arr() = {151, 157, 163, 167, 173, 179, 181, 191, 193, 197, 199}

        Dim publickey As ULong
        Dim product As ULong
        Dim c As ULong
        c = TextBox1.Text
        product = (arr(c) - 1) * (arr(c - 1) - 1)
        publickey = 2
        While ((product Mod publickey) = 0)
            publickey = publickey + 1
        End While
        TextBox2.Text = publickey
        Dim privatekey As ULong
        privatekey = 2
        While ((privatekey * publickey - 1) Mod product <> 0)
            privatekey = privatekey + 1
        End While
        TextBox3.Text = privatekey
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs)
        Dim n As Integer
        If (TextBox1.Text <> "") Then
            Try
                n = TextBox1.Text
                If (n < 0 Or n > 10) Then
                    TextBox1.Text = TextBox1.Text.Substring(0, TextBox1.Text.Length - 1)
                    MsgBox("error: id can be within range 1-10. Only 10 users allowed", MsgBoxStyle.OkOnly, "ERROR !!!")
                End If
            Catch ex As Exception
                TextBox1.Text = TextBox1.Text.Substring(0, TextBox1.Text.Length - 1)
                MsgBox("error: invalid input, only integers allowed", MsgBoxStyle.OkOnly, "ERROR !!!")
            End Try
        End If
    End Sub

    Private Sub GENERATE_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Form1.Enabled = False
    End Sub
End Class