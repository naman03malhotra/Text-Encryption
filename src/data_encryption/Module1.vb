Module ceaser
    Function ceaser_encrypt(ByVal t As String, ByRef n As Integer) As String
        Dim c As Integer
        Dim i As Integer
        Dim final As String
        final = ""
        For i = 0 To t.Length - 1
            c = AscW(t.Substring(i, 1))
            If ((c >= 65 And c <= 90) Or (c >= 97 And c <= 122)) Then
                c = c + n
            If (c > 122 Or (c > 90 And (c - n) <= 90)) Then
                c = c - 26
                End If
            End If
            final = final + Chr(c)
        Next
        Return final
    End Function
    Function ceaser_decrypt(ByVal t As String, ByRef n As Integer) As String
        Dim c As Integer
        Dim i As Integer
        Dim final As String
        final = ""
        For i = 0 To t.Length - 1
            c = AscW(t.Substring(i, 1))
            If ((c >= 65 And c <= 90) Or (c >= 97 And c <= 122)) Then
                c = c - n
            If (c < 65 Or (c < 97 And (c + n) >= 97)) Then
                c = c + 26
                End If
            End If
            final = final + Chr(c)
        Next
        Return final
    End Function
    Function calc_freq(ByRef str As String) As String
        Dim st(26) As Char
        st = ""
        Dim temp = 0
        Dim last = 1
        For i = 0 To str.Length - 1
            Dim c As String
            c = str.Substring(i, 1)
            c = c.ToUpper
            For j = 1 To st.Length
                If (c = st(j) And j = 0 And temp = 0) Then
                    temp = 1
                ElseIf (c = st(j) And temp = 0) Then
                    st(j) = st(j - 1)
                    st(j - 1) = c
                    temp = 1
                End If
            Next
            If (temp = 0) Then
                st(last) = c
                last = last + 1
                temp = 0
            End If
        Next
        Return st
    End Function
    Function row_shuffle(ByVal str As String, ByVal key As String) As String
        Dim l = key.Length
        Dim array(l, str.Length / l) As Char
        For i = 0 To l - 1
            For j = 0 To str.Length / l - 1
                If ((i * l + j) < str.Length) Then
                    array(i, j) = str.Substring(i * l + j, 1)
                Else
                    array(i, j) = " "
                End If
            Next
        Next
        Dim k As Integer
        For i = 0 To l - 1
            k = AscW(key.Substring(i, 1)) Mod l
            For j = 0 To str.Length / l - 1
                Dim temp As Char
                temp = array(i, j)
                array(i, j) = array(k, j)
                array(k, j) = temp
            Next
        Next
        str = ""
        For i = 0 To l - 1
            For j = 0 To str.Length / l - 1
                str = str + array(i, j)
            Next
        Next
        Return str
    End Function
    Function column_shuffle(ByVal str As String, ByVal key As String) As String
        Dim l = key.Length
        Dim array(l, str.Length / l) As Char
        For i = 0 To l - 1
            Dim j As Integer
            For j = 0 To str.Length / l - 1
                If ((i * l + j) < str.Length) Then
                    array(i, j) = str.Substring(i * l + j, 1)
                Else
                    array(i, j) = " "
                End If
            Next
        Next
        Dim k As Integer
        For i = 0 To str.Length / l - 1
            k = AscW(key.Substring(i, 1)) Mod l
            For j = 0 To l - 1
                Dim temp As Char
                temp = array(j, i)
                array(j, i) = array(j, k)
                array(j, k) = temp
            Next
        Next
        str = ""
        For i = 0 To l - 1
            Dim J As Integer
            For j = 0 To str.Length / l - 1
                str = str + array(i, j)
            Next
        Next
        Return str
    End Function
    Function xoring(ByVal str As String, ByVal key As String) As String
        Dim l = key.Length
        Dim final As String
        final = ""
        Dim array(l, str.Length / l) As Char
        For i = 0 To str.Length / l - 1
            Dim k As String
            For j = 0 To l - 1
                k = key.Substring(j, 1)
                final = final + Chr(k Xor str.Substring(i * l + j, 1))
            Next
        Next
        Return final
    End Function
    Function power(ByVal n As Integer, ByVal p As Integer) As Integer
        For i = 1 To p
            n = n * n
        Next
        Return n
    End Function
End Module

