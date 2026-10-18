<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        lblTitulo = New Label()
        lblTipo = New Label()
        lblNumero = New Label()
        lblNombre = New Label()
        lblSaldoInicial = New Label()
        cmbtipo = New ComboBox()
        txtNumero = New TextBox()
        txtNombre = New TextBox()
        txtSaldoInicial = New TextBox()
        btnRegistrar = New Button()
        lblCuentas = New Label()
        lblInteres = New Label()
        lstCuentas = New ListBox()
        lblMontoRetiro = New Label()
        lblMes = New Label()
        txtMontoRetiro = New TextBox()
        cmbMes = New ComboBox()
        btnRetirar = New Button()
        lblInteresAnual = New Label()
        lblCedula = New Label()
        txtCedula = New TextBox()
        btnConsultar = New Button()
        lblResultadoConsulta = New Label()
        SuspendLayout()
        ' 
        ' lblTitulo
        ' 
        lblTitulo.AutoSize = True
        lblTitulo.Location = New Point(44, 9)
        lblTitulo.Name = "lblTitulo"
        lblTitulo.Size = New Size(259, 20)
        lblTitulo.TabIndex = 0
        lblTitulo.Text = "Registro de cuentas de la cooperativa"
        ' 
        ' lblTipo
        ' 
        lblTipo.AutoSize = True
        lblTipo.Location = New Point(45, 62)
        lblTipo.Name = "lblTipo"
        lblTipo.Size = New Size(111, 20)
        lblTipo.TabIndex = 1
        lblTipo.Text = "Tipo de cuenta:"
        ' 
        ' lblNumero
        ' 
        lblNumero.AutoSize = True
        lblNumero.Location = New Point(44, 119)
        lblNumero.Name = "lblNumero"
        lblNumero.Size = New Size(135, 20)
        lblNumero.TabIndex = 2
        lblNumero.Text = "Numero de cuenta:"
        ' 
        ' lblNombre
        ' 
        lblNombre.AutoSize = True
        lblNombre.Location = New Point(44, 178)
        lblNombre.Name = "lblNombre"
        lblNombre.Size = New Size(149, 20)
        lblNombre.TabIndex = 3
        lblNombre.Text = "Nombre de asociado"
        ' 
        ' lblSaldoInicial
        ' 
        lblSaldoInicial.AutoSize = True
        lblSaldoInicial.Location = New Point(44, 228)
        lblSaldoInicial.Name = "lblSaldoInicial"
        lblSaldoInicial.Size = New Size(90, 20)
        lblSaldoInicial.TabIndex = 4
        lblSaldoInicial.Text = "Saldo inicial"
        ' 
        ' cmbtipo
        ' 
        cmbtipo.FormattingEnabled = True
        cmbtipo.Location = New Point(208, 59)
        cmbtipo.Name = "cmbtipo"
        cmbtipo.Size = New Size(215, 28)
        cmbtipo.TabIndex = 5
        ' 
        ' txtNumero
        ' 
        txtNumero.Location = New Point(208, 119)
        txtNumero.Name = "txtNumero"
        txtNumero.Size = New Size(206, 27)
        txtNumero.TabIndex = 6
        ' 
        ' txtNombre
        ' 
        txtNombre.Location = New Point(208, 171)
        txtNombre.Name = "txtNombre"
        txtNombre.Size = New Size(215, 27)
        txtNombre.TabIndex = 7
        ' 
        ' txtSaldoInicial
        ' 
        txtSaldoInicial.Location = New Point(208, 228)
        txtSaldoInicial.Name = "txtSaldoInicial"
        txtSaldoInicial.Size = New Size(215, 27)
        txtSaldoInicial.TabIndex = 8
        ' 
        ' btnRegistrar
        ' 
        btnRegistrar.Location = New Point(137, 298)
        btnRegistrar.Name = "btnRegistrar"
        btnRegistrar.Size = New Size(94, 29)
        btnRegistrar.TabIndex = 9
        btnRegistrar.Text = "Registar cuenta"
        btnRegistrar.UseVisualStyleBackColor = True
        ' 
        ' lblCuentas
        ' 
        lblCuentas.AutoSize = True
        lblCuentas.Location = New Point(16, 355)
        lblCuentas.Name = "lblCuentas"
        lblCuentas.Size = New Size(140, 20)
        lblCuentas.TabIndex = 10
        lblCuentas.Text = "cuentas Registradas"
        ' 
        ' lblInteres
        ' 
        lblInteres.AutoSize = True
        lblInteres.Location = New Point(12, 523)
        lblInteres.Name = "lblInteres"
        lblInteres.Size = New Size(95, 20)
        lblInteres.TabIndex = 11
        lblInteres.Text = "Interes Anual"
        ' 
        ' lstCuentas
        ' 
        lstCuentas.FormattingEnabled = True
        lstCuentas.Location = New Point(12, 395)
        lstCuentas.Name = "lstCuentas"
        lstCuentas.Size = New Size(542, 104)
        lstCuentas.TabIndex = 12
        ' 
        ' lblMontoRetiro
        ' 
        lblMontoRetiro.AutoSize = True
        lblMontoRetiro.Location = New Point(12, 587)
        lblMontoRetiro.Name = "lblMontoRetiro"
        lblMontoRetiro.Size = New Size(112, 20)
        lblMontoRetiro.TabIndex = 13
        lblMontoRetiro.Text = "Monto a retirar:"
        ' 
        ' lblMes
        ' 
        lblMes.AutoSize = True
        lblMes.Location = New Point(19, 639)
        lblMes.Name = "lblMes"
        lblMes.Size = New Size(105, 20)
        lblMes.TabIndex = 14
        lblMes.Text = "Mes del Retiro"
        ' 
        ' txtMontoRetiro
        ' 
        txtMontoRetiro.Location = New Point(152, 587)
        txtMontoRetiro.Name = "txtMontoRetiro"
        txtMontoRetiro.Size = New Size(206, 27)
        txtMontoRetiro.TabIndex = 15
        ' 
        ' cmbMes
        ' 
        cmbMes.FormattingEnabled = True
        cmbMes.Location = New Point(152, 631)
        cmbMes.Name = "cmbMes"
        cmbMes.Size = New Size(206, 28)
        cmbMes.TabIndex = 16
        ' 
        ' btnRetirar
        ' 
        btnRetirar.Location = New Point(99, 691)
        btnRetirar.Name = "btnRetirar"
        btnRetirar.Size = New Size(94, 29)
        btnRetirar.TabIndex = 17
        btnRetirar.Text = "Retirar dinero"
        btnRetirar.UseVisualStyleBackColor = True
        ' 
        ' lblInteresAnual
        ' 
        lblInteresAnual.AutoSize = True
        lblInteresAnual.Location = New Point(152, 523)
        lblInteresAnual.Name = "lblInteresAnual"
        lblInteresAnual.Size = New Size(53, 20)
        lblInteresAnual.TabIndex = 18
        lblInteresAnual.Text = "Label1"
        ' 
        ' lblCedula
        ' 
        lblCedula.AutoSize = True
        lblCedula.Location = New Point(12, 811)
        lblCedula.Name = "lblCedula"
        lblCedula.Size = New Size(147, 20)
        lblCedula.TabIndex = 19
        lblCedula.Text = "Cedula del asociado:"
        ' 
        ' txtCedula
        ' 
        txtCedula.Location = New Point(184, 808)
        txtCedula.Name = "txtCedula"
        txtCedula.Size = New Size(162, 27)
        txtCedula.TabIndex = 20
        ' 
        ' btnConsultar
        ' 
        btnConsultar.Location = New Point(30, 867)
        btnConsultar.Name = "btnConsultar"
        btnConsultar.Size = New Size(94, 29)
        btnConsultar.TabIndex = 21
        btnConsultar.Text = "Consultar historial"
        btnConsultar.UseVisualStyleBackColor = True
        ' 
        ' lblResultadoConsulta
        ' 
        lblResultadoConsulta.AutoSize = True
        lblResultadoConsulta.Location = New Point(208, 876)
        lblResultadoConsulta.Name = "lblResultadoConsulta"
        lblResultadoConsulta.Size = New Size(53, 20)
        lblResultadoConsulta.TabIndex = 22
        lblResultadoConsulta.Text = "Label2"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 1013)
        Controls.Add(lblResultadoConsulta)
        Controls.Add(btnConsultar)
        Controls.Add(txtCedula)
        Controls.Add(lblCedula)
        Controls.Add(lblInteresAnual)
        Controls.Add(btnRetirar)
        Controls.Add(cmbMes)
        Controls.Add(txtMontoRetiro)
        Controls.Add(lblMes)
        Controls.Add(lblMontoRetiro)
        Controls.Add(lstCuentas)
        Controls.Add(lblInteres)
        Controls.Add(lblCuentas)
        Controls.Add(btnRegistrar)
        Controls.Add(txtSaldoInicial)
        Controls.Add(txtNombre)
        Controls.Add(txtNumero)
        Controls.Add(cmbtipo)
        Controls.Add(lblSaldoInicial)
        Controls.Add(lblNombre)
        Controls.Add(lblNumero)
        Controls.Add(lblTipo)
        Controls.Add(lblTitulo)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblTitulo As Label
    Friend WithEvents lblTipo As Label
    Friend WithEvents lblNumero As Label
    Friend WithEvents lblNombre As Label
    Friend WithEvents lblSaldoInicial As Label
    Friend WithEvents cmbtipo As ComboBox
    Friend WithEvents txtNumero As TextBox
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents txtSaldoInicial As TextBox
    Friend WithEvents btnRegistrar As Button
    Friend WithEvents lblCuentas As Label
    Friend WithEvents lblInteres As Label
    Friend WithEvents lstCuentas As ListBox
    Friend WithEvents lblMontoRetiro As Label
    Friend WithEvents lblMes As Label
    Friend WithEvents txtMontoRetiro As TextBox
    Friend WithEvents cmbMes As ComboBox
    Friend WithEvents btnRetirar As Button
    Friend WithEvents lblInteresAnual As Label
    Friend WithEvents lblCedula As Label
    Friend WithEvents txtCedula As TextBox
    Friend WithEvents btnConsultar As Button
    Friend WithEvents lblResultadoConsulta As Label

End Class
