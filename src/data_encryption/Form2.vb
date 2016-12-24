Public Class Form2


    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Form1.Enabled = True
        Me.Close()
    End Sub

    Private Sub Form2_Leave(sender As Object, e As EventArgs) Handles MyBase.FormClosed
        Form1.Enabled = True
    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Form1.Enabled = False
    End Sub

    Private Sub Button1_Click(sender As Object, ee As EventArgs) Handles Button1.Click
        Dim str As String
        Dim count As Integer
        Me.Cursor = Cursors.WaitCursor
        count = 0
        str = is_empty()
        count = count + is_disimilar(a.Text, str)
        If (is_disimilar(a.Text, str) >= 0 And a.Text <> "") Then
            a.ForeColor = Color.Red
        Else
            a.ForeColor = Color.Black
        End If
        count = count + is_disimilar(b.Text, str)
        If (is_disimilar(b.Text, str) >= 0 And b.Text <> "") Then
            b.ForeColor = Color.Red
        Else
            b.ForeColor = Color.Black
        End If
        count = count + is_disimilar(c.Text, str)
        If (is_disimilar(c.Text, str) >= 0 And c.Text <> "") Then
            c.ForeColor = Color.Red
        Else
            c.ForeColor = Color.Black
        End If
        count = count + is_disimilar(d.Text, str)
        If (is_disimilar(d.Text, str) >= 0 And d.Text <> "") Then
            d.ForeColor = Color.Red
        Else
            d.ForeColor = Color.Black
        End If
        count = count + is_disimilar(e.Text, str)
        If (is_disimilar(e.Text, str) >= 0 And e.Text <> "") Then
            e.ForeColor = Color.Red
        Else
            e.ForeColor = Color.Black
        End If
        count = count + is_disimilar(f.Text, str)
        If (is_disimilar(f.Text, str) >= 0 And f.Text <> "") Then
            f.ForeColor = Color.Red
        Else
            f.ForeColor = Color.Black
        End If
        count = count + is_disimilar(g.Text, str)
        If (is_disimilar(g.Text, str) >= 0 And g.Text <> "") Then
            g.ForeColor = Color.Red
        Else
            g.ForeColor = Color.Black
        End If
        count = count + is_disimilar(h.Text, str)
        If (is_disimilar(h.Text, str) >= 0 And h.Text <> "") Then
            h.ForeColor = Color.Red
        Else
            h.ForeColor = Color.Black
        End If
        count = count + is_disimilar(i.Text, str)
        If (is_disimilar(i.Text, str) >= 0 And i.Text <> "") Then
            i.ForeColor = Color.Red
        Else
            i.ForeColor = Color.Black
        End If
        count = count + is_disimilar(j.Text, str)
        If (is_disimilar(j.Text, str) >= 0 And j.Text <> "") Then
            j.ForeColor = Color.Red
        Else
            j.ForeColor = Color.Black
        End If
        count = count + is_disimilar(k.Text, str)
        If (is_disimilar(k.Text, str) >= 0 And k.Text <> "") Then
            k.ForeColor = Color.Red
        Else
            k.ForeColor = Color.Black
        End If
        count = count + is_disimilar(l.Text, str)
        If (is_disimilar(l.Text, str) >= 0 And l.Text <> "") Then
            l.ForeColor = Color.Red
        Else
            l.ForeColor = Color.Black
        End If
        count = count + is_disimilar(m.Text, str)
        If (is_disimilar(m.Text, str) >= 0 And m.Text <> "") Then
            m.ForeColor = Color.Red
        Else
            m.ForeColor = Color.Black
        End If
        count = count + is_disimilar(n.Text, str)
        If (is_disimilar(n.Text, str) >= 0 And n.Text <> "") Then
            n.ForeColor = Color.Red
        Else
            n.ForeColor = Color.Black
        End If
        count = count + is_disimilar(o.Text, str)
        If (is_disimilar(o.Text, str) >= 0 And o.Text <> "") Then
            o.ForeColor = Color.Red
        Else
            o.ForeColor = Color.Black
        End If
        count = count + is_disimilar(p.Text, str)
        If (is_disimilar(p.Text, str) >= 0 And p.Text <> "") Then
            p.ForeColor = Color.Red
        Else
            p.ForeColor = Color.Black
        End If
        count = count + is_disimilar(q.Text, str)
        If (is_disimilar(q.Text, str) >= 0 And q.Text <> "") Then
            q.ForeColor = Color.Red
        Else
            q.ForeColor = Color.Black
        End If
        count = count + is_disimilar(r.Text, str)
        If (is_disimilar(r.Text, str) >= 0 And r.Text <> "") Then
            r.ForeColor = Color.Red
        Else
            r.ForeColor = Color.Black
        End If
        count = count + is_disimilar(s.Text, str)
        If (is_disimilar(s.Text, str) >= 0 And s.Text <> "") Then
            s.ForeColor = Color.Red
        Else
            s.ForeColor = Color.Black
        End If
        count = count + is_disimilar(t.Text, str)
        If (is_disimilar(t.Text, str) >= 0 And t.Text <> "") Then
            t.ForeColor = Color.Red
        Else
            t.ForeColor = Color.Black
        End If
        count = count + is_disimilar(u.Text, str)
        If (is_disimilar(u.Text, str) >= 0 And u.Text <> "") Then
            u.ForeColor = Color.Red
        Else
            u.ForeColor = Color.Black
        End If
        count = count + is_disimilar(v.Text, str)
        If (is_disimilar(v.Text, str) >= 0 And v.Text <> "") Then
            v.ForeColor = Color.Red
        Else
            v.ForeColor = Color.Black
        End If
        count = count + is_disimilar(w.Text, str)
        If (is_disimilar(w.Text, str) >= 0 And w.Text <> "") Then
            w.ForeColor = Color.Red
        Else
            w.ForeColor = Color.Black
        End If
        count = count + is_disimilar(x.Text, str)
        If (is_disimilar(x.Text, str) >= 0 And x.Text <> "") Then
            x.ForeColor = Color.Red
        Else
            x.ForeColor = Color.Black
        End If
        count = count + is_disimilar(y.Text, str)
        If (is_disimilar(y.Text, str) >= 0 And y.Text <> "") Then
            y.ForeColor = Color.Red
        Else
            y.ForeColor = Color.Black
        End If
        count = count + is_disimilar(z.Text, str)
        If (is_disimilar(z.Text, str) >= 0 And z.Text <> "") Then
            z.ForeColor = Color.Red
        Else
            z.ForeColor = Color.Black
        End If
        count = count + is_disimilar(zero.Text, str)
        If (is_disimilar(zero.Text, str) >= 0 And zero.Text <> "") Then
            zero.ForeColor = Color.Red
        Else
            zero.ForeColor = Color.Black
        End If
        count = count + is_disimilar(one.Text, str)
        If (is_disimilar(one.Text, str) >= 0 And one.Text <> "") Then
            one.ForeColor = Color.Red
        Else
            one.ForeColor = Color.Black
        End If
        count = count + is_disimilar(two.Text, str)
        If (is_disimilar(two.Text, str) >= 0 And two.Text <> "") Then
            two.ForeColor = Color.Red
        Else
            two.ForeColor = Color.Black
        End If
        count = count + is_disimilar(three.Text, str)
        If (is_disimilar(three.Text, str) >= 0 And three.Text <> "") Then
            three.ForeColor = Color.Red
        Else
            three.ForeColor = Color.Black
        End If
        count = count + is_disimilar(four.Text, str)
        If (is_disimilar(four.Text, str) >= 0 And four.Text <> "") Then
            four.ForeColor = Color.Red
        Else
            four.ForeColor = Color.Black
        End If
        count = count + is_disimilar(five.Text, str)
        If (is_disimilar(five.Text, str) >= 0 And five.Text <> "") Then
            five.ForeColor = Color.Red
        Else
            five.ForeColor = Color.Black
        End If
        count = count + is_disimilar(six.Text, str)
        If (is_disimilar(six.Text, str) >= 0 And six.Text <> "") Then
            six.ForeColor = Color.Red
        Else
            six.ForeColor = Color.Black
        End If
        count = count + is_disimilar(seven.Text, str)
        If (is_disimilar(seven.Text, str) >= 0 And seven.Text <> "") Then
            seven.ForeColor = Color.Red
        Else
            seven.ForeColor = Color.Black
        End If
        count = count + is_disimilar(eight.Text, str)
        If (is_disimilar(eight.Text, str) >= 0 And eight.Text <> "") Then
            eight.ForeColor = Color.Red
        Else
            eight.ForeColor = Color.Black
        End If
        count = count + is_disimilar(nine.Text, str)
        If (is_disimilar(nine.Text, str) >= 0 And nine.Text <> "") Then
            nine.ForeColor = Color.Red
        Else
            nine.ForeColor = Color.Black
        End If
        If (str.Length = 36 And count = -36) Then
            Form1.Enabled = True
            Form1.keygen.Text = str.ToLower
            Me.Cursor = Cursors.Arrow
            Me.Close()
        End If
        Me.Cursor = Cursors.Arrow
    End Sub
    Function is_disimilar(ByVal t As String, ByVal str As String) As Integer
        If (Not ((t >= "a" And t <= "z") Or (t >= "A" And t <= "Z") Or (t >= "0" And t <= "9"))) Then
            Return 0
        End If
        Dim count As Integer
        count = -2
        For ij = 0 To str.Length - 1
            If (str.Substring(ij, 1) = t) Then
                count = count + 1
            End If
        Next
        Return count
    End Function
    Function is_empty() As String
        Dim str As String
        str = ""
        If (a.Text = "") Then
            a.BackColor = Color.Silver
        Else
            a.BackColor = Color.White
            str = str + a.Text
        End If
        If (b.Text = "") Then
            b.BackColor = Color.Silver
        Else
            str = str + b.Text
            b.BackColor = Color.White
        End If
        If (c.Text = "") Then
            c.BackColor = Color.Silver
        Else
            str = str + c.Text
            c.BackColor = Color.White
        End If
        If (d.Text = "") Then
            d.BackColor = Color.Silver
        Else
            str = str + d.Text
            d.BackColor = Color.White
        End If
        If (e.Text = "") Then
            e.BackColor = Color.Silver
        Else
            str = str + e.Text
            e.BackColor = Color.White
        End If
        If (f.Text = "") Then
            f.BackColor = Color.Silver
        Else
            str = str + f.Text
            f.BackColor = Color.White
        End If
        If (g.Text = "") Then
            g.BackColor = Color.Silver
        Else
            str = str + g.Text
            g.BackColor = Color.White
        End If
        If (h.Text = "") Then
            h.BackColor = Color.Silver
        Else
            str = str + h.Text
            h.BackColor = Color.White
        End If
        If (i.Text = "") Then
            i.BackColor = Color.Silver
        Else
            str = str + i.Text
            i.BackColor = Color.White
        End If
        If (j.Text = "") Then
            j.BackColor = Color.Silver
        Else
            str = str + j.Text
            j.BackColor = Color.White
        End If
        If (k.Text = "") Then
            k.BackColor = Color.Silver
        Else
            str = str + k.Text
            k.BackColor = Color.White
        End If
        If (l.Text = "") Then
            l.BackColor = Color.Silver
        Else
            str = str + l.Text
            l.BackColor = Color.White
        End If
        If (m.Text = "") Then
            m.BackColor = Color.Silver
        Else
            str = str + m.Text
            m.BackColor = Color.White
        End If
        If (n.Text = "") Then
            n.BackColor = Color.Silver
        Else
            str = str + n.Text
            n.BackColor = Color.White
        End If
        If (o.Text = "") Then
            o.BackColor = Color.Silver
        Else
            str = str + o.Text
            o.BackColor = Color.White
        End If
        If (p.Text = "") Then
            p.BackColor = Color.Silver
        Else
            str = str + p.Text
            p.BackColor = Color.White
        End If
        If (q.Text = "") Then
            q.BackColor = Color.Silver
        Else
            str = str + q.Text
            q.BackColor = Color.White
        End If
        If (r.Text = "") Then
            r.BackColor = Color.Silver
        Else
            str = str + r.Text
            r.BackColor = Color.White
        End If
        If (s.Text = "") Then
            s.BackColor = Color.Silver
        Else
            str = str + s.Text
            s.BackColor = Color.White
        End If
        If (t.Text = "") Then
            t.BackColor = Color.Silver
        Else
            str = str + t.Text
            t.BackColor = Color.White
        End If
        If (u.Text = "") Then
            u.BackColor = Color.Silver
        Else
            str = str + u.Text
            u.BackColor = Color.White
        End If
        If (v.Text = "") Then
            v.BackColor = Color.Silver
        Else
            str = str + v.Text
            v.BackColor = Color.White
        End If
        If (w.Text = "") Then
            w.BackColor = Color.Silver
        Else
            str = str + w.Text
            w.BackColor = Color.White
        End If
        If (x.Text = "") Then
            x.BackColor = Color.Silver
        Else
            str = str + x.Text
            x.BackColor = Color.White
        End If
        If (y.Text = "") Then
            y.BackColor = Color.Silver
        Else
            str = str + y.Text
            y.BackColor = Color.White
        End If
        If (z.Text = "") Then
            z.BackColor = Color.Silver
        Else
            str = str + z.Text
            z.BackColor = Color.White
        End If
        If (zero.Text = "") Then
            zero.BackColor = Color.Silver
        Else
            str = str + zero.Text
            zero.BackColor = Color.White
        End If
        If (one.Text = "") Then
            one.BackColor = Color.Silver
        Else
            str = str + one.Text
            one.BackColor = Color.White
        End If
        If (two.Text = "") Then
            two.BackColor = Color.Silver
        Else
            str = str + two.Text
            two.BackColor = Color.White
        End If
        If (three.Text = "") Then
            three.BackColor = Color.Silver
        Else
            str = str + three.Text
            three.BackColor = Color.White
        End If
        If (four.Text = "") Then
            four.BackColor = Color.Silver
        Else
            str = str + four.Text
            four.BackColor = Color.White
        End If
        If (five.Text = "") Then
            five.BackColor = Color.Silver
        Else
            str = str + five.Text
            five.BackColor = Color.White
        End If
        If (six.Text = "") Then
            six.BackColor = Color.Silver
        Else
            str = str + six.Text
            six.BackColor = Color.White
        End If
        If (seven.Text = "") Then
            seven.BackColor = Color.Silver
        Else
            str = str + seven.Text
            seven.BackColor = Color.White
        End If
        If (eight.Text = "") Then
            eight.BackColor = Color.Silver
        Else
            str = str + eight.Text
            eight.BackColor = Color.White
        End If
        If (nine.Text = "") Then
            nine.BackColor = Color.Silver
        Else
            str = str + nine.Text
            nine.BackColor = Color.White
        End If
        Return str
    End Function
End Class