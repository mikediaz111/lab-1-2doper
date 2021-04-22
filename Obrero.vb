Public Class Obrero
    Inherits Trabajador

    Private costohora As Integer
    Private costohoraextra As Integer
    Private horasextra As Integer
    Private horas As Integer

    Public Sub New(nomb As String, apell As String, dui As String, est As String, fech As String, sex As String, costohor As Integer, costhorextr As Integer, horasext As Integer, hors As Integer)
        MyBase.New(nomb, apell, dui, est, fech, sex, costohor, costhorextr, horasext, hors)
        costohora = costohor
        costohoraextra = costhorextr
        horasextra = horasext
        horas = hors
    End Sub

    Public Property PCostoHora As String
        Get
            Return costohora
        End Get
        Set(value As String)
            costohora = value
        End Set
    End Property

    Public Property PCostoHoraExtra As String
        Get
            Return costohoraextra
        End Get
        Set(value As String)
            costohoraextra = value
        End Set
    End Property

    Public Property PHorasExtra As String
        Get
            Return horasextra
        End Get
        Set(value As String)
            horasextra = value
        End Set
    End Property

    Public Property PHoras As String
        Get
            Return horas
        End Get
        Set(value As String)
            horas = value
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
        Console.WriteLine("costo hora: " & costohora)
        Console.WriteLine("costo hora extra: " & costohoraextra)
        Console.WriteLine("horas extra: " & horasextra)
        Console.WriteLine("horas : " & horas)

    End Sub

End Class
