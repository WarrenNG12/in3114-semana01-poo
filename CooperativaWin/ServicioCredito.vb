Public Class ServicioCredito

    Public Async Function TieneMorosidad(cedula As String) As Task(Of Boolean)
        Await Task.Delay(3000)
        Return cedula.EndsWith("5")
    End Function

End Class