# Práctica CooperativaWin

# 1. Cuenta juvenil (4 % y retiro máximo de 25 000):¿qué archivos se modifican y cuáles no?

Habría que crear un archivo nuevo, CuentaJuvenil.vb, que herede de Cuenta y defina su interés (4 %) y su regla de retiro (máximo 25 000 por operación y sin pasar del saldo). También habría que modificar Form1.vb, solo para agregar "Juvenil" al combo de tipos y un ElseIf en el botón Registrar que cree la cuenta juvenil.

No hay que modificar Cuenta.vb, CuentaAVista.vb, CuentaNavidena.vb, RegistroCuentas.vb ni ServicioCredito.vb. Tampoco el código de los botones Retirar y de interés, porque solo llaman a Retirar() y CalcularInteresAnual() sin preguntar de qué tipo es la cuenta. Eso es polimorfismo.

### 2. ¿Dónde se colocó la validación del saldo inicial negativo y por qué allí y no en el botón?

Está en el constructor de la clase Cuenta (Cuenta.vb). Se puso ahí porque las reglas del negocio deben estar en las clases y no en el formulario. Además, así toda cuenta que se cree, de cualquier tipo, pasa por la misma validación y no hay que repetirla. El botón solo muestra el mensaje de error con un Try/Catch.

### 3. ¿Qué vería el usuario si la consulta crediticia se hiciera sin Await, con una pausa que bloquee el hilo?

La ventana se congelaría durante los tres segundos: no se podría mover, ni hacer clic en nada, y Windows la mostraría como "No responde". El mensaje "Consultando..." tampoco se alcanzaría a ver, y los clics que el usuario hiciera durante la espera se acumularían. Pasados los tres segundos la ventana volvería a funcionar y aparecería el resultado. Con Await la ventana sigue respondiendo durante la espera.