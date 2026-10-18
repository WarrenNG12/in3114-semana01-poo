Public MustInherit Class Cuenta

    Public ReadOnly Property Numero As String
    Public ReadOnly Property Titular As String
    Public Property Saldo As Decimal

    Public Sub New(numero As String, titular As String, saldoInicial As Decimal)
        If String.IsNullOrWhiteSpace(numero) Then
            Throw New ArgumentException("El número de cuenta es obligatorio.")
        End If
        If String.IsNullOrWhiteSpace(titular) Then
            Throw New ArgumentException("El nombre del asociado es obligatorio.")
        End If
        If saldoInicial < 0 Then
            Throw New ArgumentException("El saldo inicial no puede ser negativo.")
        End If

        Me.Numero = numero
        Me.Titular = titular
        Me.Saldo = saldoInicial
    End Sub

    Public MustOverride Function CalcularInteresAnual() As Decimal

    Public Overrides Function ToString() As String
        Return $"{Numero} - {Titular} - Saldo: {Saldo:N2}"
    End Function


    ' Cada hija define sus reglas. Devuelve "" si se puede retirar,
    ' o el motivo del rechazo si no se puede.
    Public MustOverride Function PuedeRetirar(monto As Decimal, mes As Integer) As String

    Public Function Retirar(monto As Decimal, mes As Integer) As String
        If monto <= 0 Then
            Return "El monto debe ser mayor que cero."
        End If

        Dim motivo As String = PuedeRetirar(monto, mes)
        If motivo <> "" Then
            Return motivo
        End If

        Saldo -= monto
        Return ""
    End Function
End Class