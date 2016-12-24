Public Class Form1

    Private Sub ENCRYPT_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub KEY_TextChanged(sender As Object, e As EventArgs) Handles KEY.TextChanged
        Dim n As Integer
        If (KEY.Text <> "") Then
            Try
                n = KEY.Text
                If ((n < 0 Or n > 25)) Then
                    KEY.Text = KEY.Text.Substring(0, KEY.Text.Length - 1)
                    MsgBox("can take input within 0 to 25 only !!!", MsgBoxStyle.OkOnly, "error")
                End If
            Catch
                KEY.Text = KEY.Text.Substring(0, KEY.Text.Length - 1)
                MsgBox("can take input within 0 to 25 only !!!", MsgBoxStyle.OkOnly, "error")
            End Try

        End If
    End Sub

    Private Sub encrypt_MouseClick(sender As Object, e As MouseEventArgs) Handles encrypt.MouseClick
        RichTextBox2.Text = ceaser_encrypt(RichTextBox1.Text, KEY.Text)
    End Sub

    Private Sub decrypt_Click(sender As Object, e As EventArgs) Handles decrypt.Click
        RichTextBox1.Text = ceaser_decrypt(RichTextBox2.Text, KEY.Text)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form3.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Form2.Show()
    End Sub

    Private Sub TabPage2_Click(sender As Object, e As EventArgs) Handles TabPage2.Click

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim str = RichTextBox4.Text
        Dim n As Integer
        Dim fin As String
        fin = ""
        Me.Cursor = Cursors.WaitCursor
        For n = 0 To str.Length - 1
            Dim s = str.Substring(n, 1)
            If (s >= "A" And s <= "Z") Then
                Dim temp As Integer
                temp = AscW(s) - 65
                fin = fin + (keygen.Text).Substring(temp, 1)
            ElseIf (s >= "a" And s <= "z") Then
                Dim temp As Integer
                temp = AscW(s) - 65 - 32
                s = (keygen.Text.Substring(temp, 1))
                fin = fin + s.ToLower
            ElseIf (s >= "0" And s <= "9") Then
                Dim temp As Integer
                temp = AscW(s) - AscW("0") + 32 - 6
                fin = fin + (keygen.Text.Substring(temp, 1))
            Else
                fin = fin + s
            End If
        Next
        Me.Cursor = Cursors.Arrow
        RichTextBox3.Text = fin
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim str = RichTextBox3.Text
        Dim n As Integer
        Dim fin As String
        fin = ""
        Me.Cursor = Cursors.WaitCursor
        For n = 0 To str.Length - 1
            Dim s = str.Substring(n, 1)
            Dim temp As Integer
            temp = (keygen.Text).IndexOf(s)
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
        RichTextBox4.Text = fin
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Form4.Show()
    End Sub

    Private Sub RichTextBox5_TextChanged(sender As Object, e As EventArgs) Handles RichTextBox5.TextChanged
        RichTextBox5.Text = RichTextBox5.Text.ToUpper
        Try
            If (RichTextBox5.Text.Substring(RichTextBox5.Text.Length - 1, 1) < "A" Or (RichTextBox5.Text.Substring(RichTextBox5.Text.Length - 1, 1)) > "Z") Then
                RichTextBox5.Text.Remove(RichTextBox5.Text.Length - 1)
            End If
        Catch ex As Exception

        End Try
        
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        If (TextBox3.Text = "") Then
            MsgBox("error: empty public key", MsgBoxStyle.OkOnly)
            Return
        End If
        Dim arr() = {151, 157, 163, 167, 173, 179, 181, 191, 193, 197, 199}
        Dim product As ULong
        Dim c As ULong
        c = TextBox1.Text
        product = (arr(c)) * (arr(c - 1))
        Dim str As String
        str = RichTextBox5.Text
        Dim final As String
        final = ""
        Dim k As Integer
        k = TextBox3.Text
        For i = 0 To str.Length - 1
            Dim n As ULong
            n = AscW(str.Substring(i, 1))
            For j = 1 To k
                n = n * n Mod product
            Next
            Dim nn As String
            nn = n Mod product
            final = final + ToString(nn) + " "
        Next
        RichTextBox6.Text = final
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.FormBorderStyle = Windows.Forms.FormBorderStyle.FixedToolWindow

    End Sub

    Private Sub TextBox7_TextChanged(sender As Object, e As EventArgs) Handles TextBox7.TextChanged
        Dim n As Long
        If (TextBox7.Text <> "") Then
            Try
                n = TextBox7.Text
            Catch ex As Exception
                TextBox7.Text = (TextBox7.Text).Substring(0, (TextBox7.Text).Length - 1)
                MsgBox("error: only positive integers allowed", MsgBoxStyle.OkOnly, "error")
            End Try
            If (n < 0 And n > 9999999999) Then
                MsgBox("error: only positive integers allowed", MsgBoxStyle.OkOnly, "error")
            End If
        End If
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        If (TextBox7.Text = "") Then
            MsgBox("first enter the key", MsgBoxStyle.OkOnly, "error")
            Return
        End If
        Dim str As String
        Dim final = ""
        Str = RichTextBox8.Text
        Dim no As Integer
        Dim k As Integer
        k = TextBox7.Text
        no = str.Length / k
        If (str.Length Mod k <> 0) Then
            no = no + 1
        End If
        For i = 0 To k - 1
            Dim n As Integer
            n = i
            While (n < str.Length)
                final = final + str.Substring(n, 1)
                n = n + k
            End While
        Next
        RichTextBox7.Text = final
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        If (TextBox7.Text = "") Then
            MsgBox("first enter the key", MsgBoxStyle.OkOnly, "error")
            Return
        End If
        Dim str As String
        Dim final = ""
        str = RichTextBox7.Text
        Dim no As Integer
        Dim k As Integer
        k = TextBox7.Text
        Dim remainder = str.Length Mod k
        no = (str.Length + k - remainder) / k
        For i = 0 To no - 1
            Dim n As Integer
            n = i
            Dim count = 0
            While (n < str.Length)
                final = final + str.Substring(n, 1)
                n = n + no
                count = count + 1
                If (count > remainder) Then
                    n = n - 1
                End If
                If (i = no - 1 And count >= remainder) Then
                    n = str.Length
                End If
            End While
        Next
        RichTextBox8.Text = final
    End Sub

    Private Sub TextBox9_TextChanged(sender As Object, e As EventArgs) Handles TextBox9.TextChanged
        Dim str As String
        str = TextBox9.Text
        For i = 0 To str.Length - 1
            Dim s = str.Substring(i, 1)
            If (Not ((s >= "a" And s <= "z") Or (s >= "A" And s <= "Z") Or (str = ""))) Then
                TextBox9.Text = str.Substring(0, str.Length - 1)
                MsgBox("error:only alphabets are allowed.no other characters are allowed !!!", MsgBoxStyle.OkOnly, "error")
            End If
        Next
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        If (TextBox9.Text = "") Then
            MsgBox("first enter the key", MsgBoxStyle.OkOnly, "error")
            Return
        End If
        Dim str As String
        str = RichTextBox12.Text
        Dim final As String
        final = ""
        Dim code As String
        code = TextBox9.Text
        Dim counter = 0
        For i = 0 To str.Length - 1
            Dim c As Integer
            c = AscW(code.Substring(counter, 1))
            If (c >= 65 And c <= 90) Then
                c = c - 65
                final = final + ceaser_encrypt(str.Substring(i, 1), c + 1)
            ElseIf (c >= 97 And c <= 122) Then
                c = c - 97
                final = final + ceaser_encrypt(str.Substring(i, 1), c + 1)
            Else
                final = final + str.Substring(i, 1)
            End If
            counter = (counter + 1) Mod (code.Length)
        Next
        RichTextBox11.Text = final
    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        If (TextBox9.Text = "") Then
            MsgBox("first enter the key", MsgBoxStyle.OkOnly, "error")
            Return
        End If
        Dim str As String
        str = RichTextBox11.Text
        Dim final As String
        final = ""
        Dim code As String
        code = TextBox9.Text
        Dim counter = 0
        For i = 0 To str.Length - 1
            Dim c As Integer
            c = AscW(code.Substring(counter, 1))
            If (c >= 65 And c <= 90) Then
                c = c - 65
                final = final + ceaser_decrypt(str.Substring(i, 1), c + 1)
            ElseIf (c >= 97 And c <= 122) Then
                c = c - 97
                final = final + ceaser_decrypt(str.Substring(i, 1), c + 1)
            Else
                final = final + str.Substring(i, 1)
            End If
            counter = (counter + 1) Mod (code.Length)
        Next
        RichTextBox12.Text = final
    End Sub

    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Button14.Click
        Dim str As String
        Dim k As String
        Me.Cursor = Cursors.WaitCursor
        k = TextBox10.Text
        str = RichTextBox14.Text
        str = row_shuffle(str, k)
        str = column_shuffle(str, k)
        str = xoring(str, k)
        RichTextBox13.Text = str
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub Button15_Click(sender As Object, e As EventArgs) Handles Button15.Click
        Dim str As String
        Dim k As String
        Me.Cursor = Cursors.WaitCursor
        k = TextBox10.Text
        str = RichTextBox13.Text
        str = row_shuffle(str, k)
        str = column_shuffle(str, k)
        str = xoring(str, k)
        RichTextBox14.Text = str
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        GENERATE.Show()
    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles TextBox3.TextChanged
        Dim n As Integer
        If (TextBox3.Text <> "") Then
            Try
                n = TextBox3.Text
                If (n <= 0) Then
                    TextBox3.Text = TextBox3.Text.Substring(0, TextBox3.Text.Length - 1)
                    MsgBox("error: key cannot be less than equal to zero !!!", MsgBoxStyle.OkOnly, "ERROR !!!")
                End If
            Catch ex As Exception
                TextBox3.Text = TextBox3.Text.Substring(0, TextBox3.Text.Length - 1)
                MsgBox("error: invalid input, only integers allowed", MsgBoxStyle.OkOnly, "ERROR !!!")
            End Try
        End If
    End Sub

    Private Sub TextBox4_TextChanged(sender As Object, e As EventArgs) Handles TextBox41.TextChanged
        Dim n As Integer
        If (TextBox41.Text <> "") Then
            Try
                n = TextBox3.Text
                If (n <= 0) Then
                    TextBox41.Text = TextBox41.Text.Substring(0, TextBox41.Text.Length - 1)
                    MsgBox("error: key cannot be less than equal to zero !!!", MsgBoxStyle.OkOnly, "ERROR !!!")
                End If
            Catch ex As Exception
                TextBox41.Text = TextBox3.Text.Substring(0, TextBox41.Text.Length - 1)
                MsgBox("error: invalid input, only integers allowed", MsgBoxStyle.OkOnly, "ERROR !!!")
            End Try
        End If
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        If (TextBox3.Text = "") Then
            MsgBox("error: empty private key", MsgBoxStyle.OkOnly)
            Return
        End If
        Dim arr() = {2, 5, 7, 11, 9, 13, 17, 19, 23, 29, 3}
        Dim product As ULong
        Dim c As ULong
        c = TextBox1.Text
        product = (arr(c)) * (arr(c - 1))
        Dim str As String
        str = RichTextBox6.Text
        Dim final As String
        final = ""
        Dim k As Integer
        k = TextBox41.Text
        For i = 0 To str.Length - 1
            Dim n As ULong
            n = AscW(str.Substring(i, 1)) - 65
            For j = 1 To k
                n = n * n
            Next
            n = n Mod product
            final = final + Chr(n + 65)
        Next
        RichTextBox5.Text = final
    End Sub


End Class
