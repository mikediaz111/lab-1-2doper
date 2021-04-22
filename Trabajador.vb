Public Class Trabajador
    Inherits Persona

    Private AFP As String
    Private Salario As String
    Private Sueldo As String

    Public Sub New(nomb As String, apell As String, dui As String, est As String, fech As String, sex As String, costohor As Integer, af As String, sala As String, sueld As String)
        MyBase.New(nomb, apell, dui, est, fech, sex)
        AFP = af
        Salario = sala
        Sueldo = sueld
    End Sub

    Public Property PAFP As String
        Get
            Return AFP
        End Get
        Set(value As String)
            AFP = value
        End Set
    End Property

    Public Property PSalario As String
        Get
            Return Salario
        End Get
        Set(value As String)
            Salario = value
        End Set
    End Property

    Public Property PSueldo As String
        Get
            Return Sueldo
        End Get
        Set(value As String)
            Sueldo = value
        End Set
    End Property

    Public Overrides Sub Descripcion()
        Console.WriteLine("datos del trabajador")
        Console.WriteLine("datos persona")
        Console.WriteLine("nombre: " & PNombre)
        Console.WriteLine("apellido: " & PApellido)
        Console.WriteLine("dui: " & PDUI)
        Console.WriteLine("contratado: " & PEstado)
        Console.WriteLine("fecha inicio: " & PFechaDeInicio)
        Console.WriteLine("sexo: " & PSexo)
        Console.WriteLine("afp: " & PAFP)
        Console.WriteLine("salario: " & PSalario)
        Console.WriteLine("sueldo: " & PSueldo)

    End Sub

End Class
