Public Class trainbooking
    Protected Train_no As Integer = 0
    Protected train_fare As Integer = 0
    Protected train_name As String
    Protected passenger_count As Integer
    Protected ticket_rate As Int16
    Protected finalrate As Integer = 0
    Public passenger_name() As String = New String(1000) {}
    Public passenger_age() As Integer = New Integer(1000) {}

    Sub getTrainDetails()
        Console.WriteLine("ENTER THE TRAIN NUMBER")
        Train_no = Console.ReadLine()
        Console.WriteLine("ENTER THE TRAIN NAME")
        train_name = Console.ReadLine()
        Console.WriteLine("ENTER THE TRAIN FARE")
        train_fare = Console.ReadLine()
        Console.WriteLine("ENTER THE NUMBER OF PASSENGER TO BOOK TICKETS")
        passenger_count = Console.ReadLine()
        For i As Integer = 0 To passenger_count - 1
            Console.WriteLine("ENTER THE PASSENGER NAME" & i + 1)
            passenger_name(i) = Convert.ToString(Console.ReadLine())
        Next
        For i As Int16 = 0 To passenger_count - 1
            Console.WriteLine("ENTER THE PASSENGER AGE" & i + 1)
            passenger_age(i) = Convert.ToInt16(Console.ReadLine)
        Next
    End Sub
    Sub printdetails()
        Console.WriteLine("TRAIN NO :  {0}  , TRAIN NAME : {1}", Train_no, train_name)
        For i As Integer = 0 To passenger_count - 1
            Console.WriteLine("PASSENGER NAME : {0}  , PASSENGER AGE : {1}", passenger_name(i), passenger_age(i))
            If passenger_age(i) > 60 Then
                ticket_rate = train_fare * 0.75
            ElseIf passenger_age(i) < 5 Then
                ticket_rate = train_fare * 0.5
            Else
                ticket_rate = train_fare
            End If
            Console.WriteLine("TICKET RATE HAS TO PAY " & ticket_rate)
            finalrate += ticket_rate
        Next
        Console.WriteLine("FINAL RATE FOR TICKET IS " & finalrate)
    End Sub
End Class



