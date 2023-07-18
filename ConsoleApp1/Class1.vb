Imports System.Threading

Public Class Employee
    Dim empid As Int16 = 12
    Dim empname As String = "PARTHI"

    Public Sub New()
        Console.WriteLine("non parameterized constructor")
    End Sub

    Public Sub New(empid As Int16, empname As String)
        Console.WriteLine("parameterized constructor")
    End Sub
    Public Sub New(emp As Employee)
        Console.WriteLine("copy constructor")
        Me.empid = emp.empid
        Me.empname = emp.empname
    End Sub

    Protected Overrides Sub finalize()
        Console.WriteLine("WID : {0}, Name :{1}", empid, empname)
    End Sub
End Class
