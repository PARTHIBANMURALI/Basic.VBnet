Public Class library
    Dim book_name() As String = New String() {}
    Dim book_code() As String = New String() {}
    Dim author() As String = New String() {}
    Dim username As String
    Dim Options As String
    Dim book_count As Integer
    Dim delay As Int16
    Dim fine As Int16

    Sub getdetails()
        Console.WriteLine("ENTER THE USERNAME :")
        username = Console.ReadLine()
        Console.WriteLine("ENTER THE NUMBER OF BOOKS USER WANTED TO GET")
        book_count = Console.ReadLine()
        For i As Integer = 0 To book_count - 1
            Array.Resize(book_name, i + 1)
            Array.Resize(book_code, i + 1)
            Array.Resize(author, i + 1)
            Console.WriteLine("ENTER THE BOOKNAME No:" & i + 1)
            book_name(i) = Console.ReadLine()
            Console.WriteLine("ENTER THEBOOKCODE NO" & i + 1)
            book_code(i) = Console.ReadLine()
            Console.WriteLine("ENTER THE AUTHOR NAME FOR BOOK No: " & i + 1)
            author(i) = Console.ReadLine()
        Next
        Dim purdate As DateTime = getinputdate("ENTER THE DATE OF PURCHASE (YYYY-MM-DD) :")
        Dim sumdate As DateTime = getinputdate("ENTER THE DATE OF SUBMISSION (YYYY-MM-DD) :")
        delay = (sumdate - purdate).Days
        If delay > 10 Then
            Dim days As Int16
            days = delay - 10
            fine = calculatefine(days)
            Console.WriteLine("DUE DAYS ARE {0} YOU HAVE TO PAY {1}", days, fine)
        Else
            Console.WriteLine("NO DUE GOOD BOY")
        End If

    End Sub

    Function getinputdate(pt As String)
        Console.WriteLine(pt)
        Return DateTime.Parse(Console.ReadLine())
    End Function
    Function calculatefine(d As Int16)
        Dim f As Int16
        f = d * 25
        Return f
    End Function
End Class
Public Class bank
    Dim acc_no As Int64
    Dim acc_name As String
    Dim account_balance As Int64
    Dim amount As Int16
    Dim main_bal As Int16

    Sub getdetails()
        Console.WriteLine("ENTER THE USERNAME :")
        acc_name = Console.ReadLine()
        Console.WriteLine("ENTER THE ACCOUNT NUMBER ")
        acc_no = Console.ReadLine()
        Console.WriteLine("ENTER THE ACCOUNT BALANCE")
        account_balance = Console.ReadLine()
        Console.WriteLine("ENTER THE OPERATION WANTED TO PERFORM  ")
        Console.WriteLine("OPTION 1 : WITHDRAW")
        Console.WriteLine("OPTION 2 : DEPOSITE")
        Console.WriteLine("OPTION 3 : BALANCE CHECK")
        Dim op As Int16 = Console.ReadLine()
        If op = 1 Then
            Console.WriteLine("ENTER THE AMMOUNT WANTED TO WITHDRAW")
            amount = Console.ReadLine()
            If account_balance < amount Then
                Console.WriteLine("INSUFFICIANT BALANCE")
            Else
                main_bal = withdraw(amount, account_balance)
                Console.WriteLine("DEBITED SUCESSFULLY , AVAILABLE BALANCE : " & main_bal)
            End If
        ElseIf op = 2 Then
            Console.WriteLine("ENTER THE AMMOUNT WANTED TO DEPOSITE")
            amount = Console.ReadLine()
            main_bal = deposite(amount, account_balance)
            Console.WriteLine("CREDITED SUCCESSFULLY , AVAILABLE BALANCE :" & main_bal)
        Else
            Console.WriteLine("ACCOUNT BALANCE IS : " & account_balance)
        End If
    End Sub
    Function withdraw(a As Int16, ab As Int16)
        main_bal = ab - a
        Return main_bal
    End Function
    Function deposite(a As Int16, ab As Int16)
        main_bal = ab + a
        Return main_bal
    End Function

End Class
