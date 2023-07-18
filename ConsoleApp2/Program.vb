Imports System

Module Program
    Sub Main(args As String())
        Console.WriteLine("\\\\\\\\\\TICKET BOOKING SYSTEM WELCOMS YOU\\\\\\\\\\")
        Dim obj As trainbooking = New trainbooking
        obj.getTrainDetails()
        obj.printdetails()
    End Sub
End Module
