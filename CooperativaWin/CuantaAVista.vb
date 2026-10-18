Public Class CuentaAVista
    Inherits Cuenta

    Public Sub New(numero As String, titular As String, saldoInicial As Decimal)
        MyBase.New(numero, titular, saldoInicial)
    End Sub

    Public Overrides Function CalcularInteresAnual() As Decimal
        Return Saldo * 0.03D
    End Function

    Public Overrides Function PuedeRetirar(monto As Decimal, mes As Integer) As String
        If monto > Saldo Then
            Return "El monto supera el saldo disponible."
        End If
        Return ""
    End Function

End Class