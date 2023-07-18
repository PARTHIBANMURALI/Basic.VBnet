Imports System
Imports System.Reflection.Metadata.Ecma335
Imports System.Runtime.CompilerServices
Imports System.Runtime.InteropServices

Module Program
    Sub Main(args As String())
        'tables()
        'amstrong()
        phone()
        'cyclicarray()
        'sortarr()
        'unique()
        'series()
        'checkpass()
        'palindrome()
        'checkemail()
        'nextpalindrome()
    End Sub
    Sub tables()

        Console.WriteLine("enter the table to be priented")
        Dim a As Integer
        a = Console.ReadLine()
        Console.WriteLine("enter the iteration to be printed")
        Dim b As Int16
        b = Console.ReadLine()
        Dim c As Integer = 0
        For i As Integer = 1 To b
            c = a * i
            Console.WriteLine("{0} * {1}= {2}", a, i, c)
        Next
    End Sub
    Sub amstrong()

        Console.WriteLine("PRINTING AMSTRONG NUMBER IN BETWWEEN 1000 ")
        For i As Int32 = 1 To 1000
            Dim temp As Int32 = 0
            Dim r As Int32 = 0
            Dim res As Int32 = 0
            Dim count As Int32 = 0
            Dim number As Integer = i
            temp = i
            While (number > 0)
                count = count + 1
                number = number / 10
            End While

            While (temp > 0)
                r = (temp Mod 10)
                res = res + (r ^ count)
                temp = temp \ 10
            End While
            If i = res Then
                Console.WriteLine("{0}", res)
            End If
        Next
    End Sub
    Sub phone()
        Console.WriteLine("PHONE NUMBER")
        Dim ph As Long = 8056129724
        Dim even As Int16 = 0
        Dim odd As Int16 = 0
        Dim oddcount As Integer = 0
        Dim evencount As Integer = 0
        Dim finalcount As Integer = 0
        Dim lastdig As Int32 = 0
        Dim count As Int16 = 1
        While (ph > 0)
            For i As Integer = 1 To 10
                lastdig = ph Mod 10
                If i Mod 2 = 0 Then
                    even = even + lastdig
                Else
                    odd = odd + lastdig
                End If
                ph = ph \ 10
            Next
        End While
        Console.WriteLine(even)
        Console.WriteLine(odd)
        evencount = getsingle(even)
        oddcount = getsingle(odd)
        Console.WriteLine(evencount)
        Console.WriteLine(oddcount)
        Dim fin As Int16 = 0
        fin = oddcount + evencount
        finalcount = getsingle(fin)
        Console.WriteLine("{0}", finalcount)
    End Sub
    Function getsingle(ByVal num As Integer) As Integer
        If num < 10 Then
            Return num
        End If
        Dim sum As Integer = 0
        While num > 0
            sum += num Mod 10
            num \= 10
        End While
        Return getsingle(sum)
    End Function

    Sub cyclicarray()
        Dim arr() As Integer = New Integer(10) {}
        Console.WriteLine("ENTER THE NUMBER OF ELEMENT IN AN ARRRAY")
        Dim size As Int16 = 0
        size = Console.ReadLine()
        For i As Int16 = 0 To size - 1
            arr(i) = Convert.ToString(Console.ReadLine())
        Next
        Console.WriteLine("ENTER THE NUMBER OF CYCLIC ROTAION ")
        Dim r = Console.ReadLine()
        Dim x As Integer
        While (x > 0)
            Dim temp As Integer = arr(0)
            For i As Integer = 0 To r - 1
                arr(i) = arr(i + 1)
            Next
            arr(r - 1) = temp
            x -= 1
        End While
        For i As Int16 = 0 To size
            Console.WriteLine(arr(i))
        Next



    End Sub
    Sub sortarr()
        Dim a() As String = New String(10) {}
        Console.WriteLine("ENTER THE NUMBER OF STRINGS")
        Dim size = Console.ReadLine()
        For i As Int16 = 0 To size
            a(i) = Convert.ToString(Console.ReadLine())
        Next
        For i As Int16 = 0 To size
            For j As Int16 = 1 To size
                If a(j) < a(j - 1) Then
                    Dim temp As Integer = 0
                    temp = a(j)
                    a(j) = a(j - 1)
                    a(j - 1) = temp
                End If
            Next
        Next
        For i As Int16 = 0 To size
            Console.WriteLine(a(i))
        Next

    End Sub
    Sub unique()
        Dim b() As String = New String(10) {}
        Console.WriteLine(" ENTER THE NUMBER OF STRINGS")
        Dim size = Convert.ToInt16(Console.ReadLine())
        For i As Int16 = 0 To size
            b(i) = Convert.ToString(Console.ReadLine())
        Next
        For i As Int16 = 0 To size - 1
            For j As Int16 = i + 1 To size - 1
                If b(i) = b(j) Then
                    b(j) = ""
                End If
            Next
        Next
        Dim sum As Integer = 0
        For Each i In b
            If i <> "" Then
                sum += 1
            End If
        Next
        Console.WriteLine(sum)
        Dim k As Integer = 0
        Dim unique() As String = New String(sum) {}
        For Each i In b
            If i <> "" Then
                unique(k) = i
                k += 1
            End If
        Next
        For i = 0 To unique.Length - 1
            Console.WriteLine(unique(i))
        Next


    End Sub
    Sub series()
        Dim table As Integer = 0
        Dim evenpos As Integer = 0
        Dim oddpos As Integer = 0
        Dim num1 As Integer = 0
        Dim num2 As Integer = 1
        Dim j As Integer = 1
        Console.WriteLine("ENTER THE NUMBER OF ELEMENT ")
        Dim size As Int16 = 0
        size = Convert.ToInt16(Console.ReadLine())
        Console.WriteLine("ENTER THE TABLE WANT TO INSERT IN EVEN POSITION")
        table = Convert.ToInt16(Console.ReadLine())
        Dim num() As Integer = New Integer(size) {}
        For i As Int16 = 1 To size
            If i Mod 2 = 0 Then
                If i = 2 Then
                    num(i - 1) = 0
                ElseIf i = 4 Then
                    num(i - 1) = 1
                Else
                    num(i - 1) = evenposition(num1, num2)
                    num1 = num2
                    num2 = num(i - 1)
                End If
            Else
                num(i - 1) = oddposition(j, table)
                j = j + 1
            End If
        Next
        For i As Int16 = 0 To size - 1
            Console.Write(num(i) & " ,")
        Next
    End Sub
    Function oddposition(ByVal num As Integer, t As Integer) As Integer
        Dim c As Integer = 0
        c = num * t
        Return c
    End Function
    Function evenposition(ByVal num1 As Integer, ByVal num2 As Integer) As Integer
        Dim fib As Integer = 0
        fib = num1 + num2
        Return fib
    End Function
    Sub checkpass()
        Dim name As String
        Dim corname As String = "parthibanmurali"
        Dim pass As String
        Dim corpass As String = "ramram"
        Dim passcheck As String
        Dim usecheck As String
        Console.WriteLine("ENTER THE CORRECT USERNAME")
        name = Console.ReadLine()
        Console.WriteLine("ENTER THE CORRECT PASSWORD")
        pass = Console.ReadLine()
        usecheck = check(corname, name)
        passcheck = pas(pass, corpass)
        If passcheck = corpass Then
            Console.WriteLine("LOGIN SUCESSFULL")
        End If
    End Sub
    Function check(corname As String, name As String)
        If corname = name Then
            Console.WriteLine("ENTERED USERNAME IS CORRECT")
            Return corname
        Else
            Console.WriteLine("ENTERED USERNAME IS WRONG REENTER")
            Dim Rename As String
            Rename = Console.ReadLine()
            Return check(corname, Rename)
        End If

    End Function
    Function pas(pass As String, corpass As String)
        If pass = corpass Then
            Console.WriteLine("ENTERED PASSWORD IS CORRECT")
            Return pass
        Else
            Console.WriteLine("ENTERED PASSWORD IS WRONG REENTER PASSWORD")
            Dim reentered As String
            reentered = Console.ReadLine()
            Return pas(reentered, corpass)
        End If
    End Function
    Sub palindrome()
        Dim mainstr As String
        Dim str As String
        Dim final As Boolean
        Console.WriteLine("ENTER THE STRING TO CHECK PALINDROME")
        mainstr = Console.ReadLine()
        str = mainstr
        final = pal(mainstr)
        If final = True Then
            Console.WriteLine("GIVEN STRING IS PALINDROME")
        Else
            Console.WriteLine("GIVEN STRING IS NOT A PALINDROME")
        End If
    End Sub
    Function pal(s As String) As Boolean
        Dim fir As Integer = 0
        Dim last As Integer
        last = s.Length - 1
        While fir < last
            If s(fir) <> s(last) Then
                Return False
            End If
            fir += 1
            last -= 1
        End While
        Return True
    End Function
    Sub checkemail()
        Dim email As String
        Dim capletter As Integer
        Dim smallleter As Integer
        Dim number As Integer
        Dim special As Integer
        Console.WriteLine("ENTER THE EMAIL TO CHECK")
        email = Console.ReadLine()
        For i As Integer = 0 To email.Length - 1
            If (Asc(email(i)) >= 65 And Asc(email(i)) <= 90) Then
                capletter += 1
            ElseIf (Asc(email(i)) >= 97 And Asc(email(i)) <= 122) Then
                smallleter += 1
            ElseIf (Asc(email(i)) >= 48 And Asc(email(i)) <= 57) Then
                number += 1
            Else
                special += 1
            End If
        Next
        Console.WriteLine("NUMBER OF CAPITAL LETTERS IN EMAIL :" & capletter)
        Console.WriteLine("NUMBER OF SMALL LETTERS IN EMAIL :" & smallleter)
        Console.WriteLine("NUMBER OF NUMBER IN EMAIL :" & number)
        Console.WriteLine("NUMBER OF SPECIAL CHARACTERS IN EMAIL :" & special)
    End Sub
    Sub nextpalindrome()
        Dim str As String
        Dim strfinal As Boolean
        Dim intfinal As Boolean
        Console.WriteLine("ENTER THE STRING TO CHECK PALINDROME")
        str = Console.ReadLine()
        If (Asc(str(1)) >= 65 And Asc(str(1)) <= 122) Then
            Console.WriteLine("ENTERED STRING IS IN WORDS FORM")
            strfinal = pal(str)
            If strfinal = True Then
                Console.WriteLine("GIVEN STRING IS PALINDROME")
            Else
                Console.WriteLine("GIVEN STRING IS NOT A PALINDROME")
            End If
        Else
            Console.WriteLine("ENTERED STRING IS IN INTEGER FORM")
            intfinal = pal(str)
            If intfinal = True Then
                Console.WriteLine("GIVEN INTEGER  IS PALINDROME")
            Else
                Console.WriteLine("GIVEN INTEGER IS NOT A PALINDROME")
            End If
        End If
    End Sub
End Module
