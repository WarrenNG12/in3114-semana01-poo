Public Class RegistroCuentas

    Private ReadOnly cuentas As New List(Of Cuenta)

    Public Sub Agregar(nueva As Cuenta)
        For Each existente As Cuenta In cuentas
            If String.Equals(existente.Numero, nueva.Numero, StringComparison.OrdinalIgnoreCase) Then
                Throw New ArgumentException("Ya existe una cuenta con ese número.")
            End If
        Next
        cuentas.Add(nueva)
    End Sub

End Class