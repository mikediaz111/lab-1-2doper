Public Class Persona
    Private nombre As String
    Private apellido As String
    Private dui As String
    Private estado As String
    Private sexo As String
    Private fecha_inicio As String

    Public Sub New(nomb As String, apell As String, dui As String, est As String, fech As String, sex As String)
        nombre = nomb
        apellido = apell
        dui = dui
        estado = est
        fecha_inicio = fech
        sexo = sex
    End Sub

    Public Property PNombre As String
        Get
            Return nombre
        End Get
        Set(value As String)
            nombre = value
        End Set
    End Property

    Public Property PApellido As String
        Get
            Return nombre
        End Get
        Set(value As String)
            apellido = value
        End Set
    End Property

    Public Property PDUI As String
        Get
            Return nombre
        End Get
        Set(value As String)
            dui = value
        End Set
    End Property

    Public Property PEstado As String
        Get
            Return nombre
        End Get
        Set(value As String)
            estado = value
        End Set
    End Property

    Public Property PFechaDeInicio As String
        Get
            Return fecha_inicio
        End Get
        Set(value As String)
            fecha_inicio = value
        End Set
    End Property

    Public Property PSexo As String
        Get
            Return sexo
        End Get
        Set(value As String)
            sexo = value
        End Set
    End Property

    Public Overridable Sub Descripcion()
        Console.WriteLine("--------------------------------------------------------------------")
        Console.WriteLine("datos persona")
        Console.WriteLine("nombre: " & PNombre)
        Console.WriteLine("apellido: " & PApellido)
        Console.WriteLine("dui: " & PDUI)
        Console.WriteLine("contratado: " & PEstado)
        Console.WriteLine("fecha inicio: " & PFechaDeInicio)
        Console.WriteLine("sexo: " & PSexo)

    End Sub
End Class
