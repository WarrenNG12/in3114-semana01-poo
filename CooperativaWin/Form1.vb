Public Class Form1
    Private ReadOnly registro As New RegistroCuentas()
    Private ReadOnly servicio As New ServicioCredito()
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cmbtipo.Items.Add("A la vista")
        cmbtipo.Items.Add("Navideña")
        For mes As Integer = 1 To 12
            cmbMes.Items.Add(mes)
        Next
    End Sub

    Private Sub btnRegistrar_Click(sender As Object, e As EventArgs) Handles btnRegistrar.Click
        Try
            Dim saldo As Decimal
            If Not Decimal.TryParse(txtSaldoInicial.Text, saldo) Then
                MessageBox.Show("El saldo inicial debe ser un número.")
                Return
            End If

            Dim nueva As Cuenta

            If cmbtipo.Text = "A la vista" Then
                nueva = New CuentaAVista(txtNumero.Text.Trim(), txtNombre.Text.Trim(), saldo)
            ElseIf cmbTipo.Text = "Navideña" Then
                nueva = New CuentaNavidena(txtNumero.Text.Trim(), txtNombre.Text.Trim(), saldo)
            Else
                MessageBox.Show("Seleccione el tipo de cuenta.")
                Return
            End If

            registro.Agregar(nueva)
            lstCuentas.Items.Add(nueva)

        Catch ex As ArgumentException
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub lstCuentas_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstCuentas.SelectedIndexChanged
        Dim seleccionada As Cuenta = TryCast(lstCuentas.SelectedItem, Cuenta)

        If seleccionada Is Nothing Then
            Return
        End If

        lblInteresAnual.Text = seleccionada.CalcularInteresAnual().ToString("N2")
    End Sub

    Private Sub btnRetirar_Click(sender As Object, e As EventArgs) Handles btnRetirar.Click
        Dim seleccionada As Cuenta = TryCast(lstCuentas.SelectedItem, Cuenta)
        If seleccionada Is Nothing Then
            MessageBox.Show("Seleccione una cuenta de la lista.")
            Return
        End If

        Dim monto As Decimal
        If Not Decimal.TryParse(txtMontoRetiro.Text, monto) Then
            MessageBox.Show("El monto debe ser un número.")
            Return
        End If

        Dim mes As Integer
        If Not Integer.TryParse(cmbMes.Text, mes) Then
            MessageBox.Show("Seleccione el mes del retiro.")
            Return
        End If

        Dim motivo As String = seleccionada.Retirar(monto, mes)

        If motivo <> "" Then
            MessageBox.Show(motivo)
            Return
        End If

        ' Refrescar el texto de la cuenta en la lista
        Dim posicion As Integer = lstCuentas.SelectedIndex
        lstCuentas.Items(posicion) = seleccionada
        lstCuentas.SelectedIndex = posicion
        lblInteresAnual.Text = seleccionada.CalcularInteresAnual().ToString("N2")
    End Sub

    Private Async Sub btnConsultar_Click(sender As Object, e As EventArgs) Handles btnConsultar.Click
        If String.IsNullOrWhiteSpace(txtCedula.Text) Then
            MessageBox.Show("Digite la cédula.")
            Return
        End If

        btnConsultar.Enabled = False
        lblResultadoConsulta.Text = "Consultando..."

        Try
            Dim moroso As Boolean = Await servicio.TieneMorosidad(txtCedula.Text.Trim())
            If moroso Then
                lblResultadoConsulta.Text = "Con morosidad"
            Else
                lblResultadoConsulta.Text = "Sin morosidad"
            End If
        Finally
            btnConsultar.Enabled = True
        End Try
    End Sub


End Class
