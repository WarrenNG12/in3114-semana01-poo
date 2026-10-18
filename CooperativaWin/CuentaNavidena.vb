Public Class CuentaNavidena
    Inherits Cuenta

    Public Sub New(numero As String, titular As String, saldoInicial As Decimal)
        MyBase.New(numero, titular, saldoInicial)
    End Sub

    Public Overrides Function CalcularInteresAnual() As Decimal
        Return Saldo * 0.06D
    End Function

    Public Overrides Function PuedeRetirar(monto As Decimal, mes As Integer) As String
        If mes <> 12 Then
            Return "La cuenta navideña solo permite retiros en diciembre."
        End If
        If monto > Saldo Then
            Return "El monto supera el saldo disponible."
        End If
        Return ""
    End Function

End Class