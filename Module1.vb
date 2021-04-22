Module Module1

    Sub Main()
        Dim persona(0) As Persona
        persona(0) = New Persona("Miguel", "Diaz", "45577678", "contratado", "02/02/2002", "masculino")

        Dim trabajador(0) As Trabajador
        trabajador(0) = New Trabajador("Luis", "Martinez", "799797", "contratado", "01/01/2010", "masculino", "$8.50", "7.25%", "$1,500", "$1391.25")

        Dim obrero(0) As Obrero
        obrero(0) = New Obrero("jose", "Valencia", "045895272", "despedido", "03/03/2015", "masculino", "$7.25", "$10.75", "7", "44")


        For Each forpersona As Persona In persona
            forpersona.Descripcion()
        Next

        For Each fortrabajador As Trabajador In trabajador
            fortrabajador.Descripcion()
        Next

        For Each forobrero As Trabajador In trabajador
            forobrero.Descripcion()
        Next

    End Sub

End Module

