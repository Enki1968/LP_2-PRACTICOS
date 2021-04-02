Public Class Form1
    'Declaración de ENUM
    Enum EntradaDatos As Integer 'as Integer es opcional
        NumeroEntero
        NumeroDecimal
        Texto
        FechaHora
    End Enum
    Private Sub btnMostrar_Click(sender As System.Object, e As System.EventArgs) Handles btnMostrar.Click

        Dim EA As EntradaDatos = EntradaDatos.FechaHora
        ' Muestra el valor numerico
        MessageBox.Show(EA)  ' muestra 3
        ' Muestra el valor numerico
        MessageBox.Show(EA.ToString) ' muestra FechaHora

        'General y fixed, muestran el nombre de Enum
        MessageBox.Show(EA.ToString("F")) 'DateTime
        'Decimal, muestran el valor de Enum
        MessageBox.Show(EA.ToString("D")) 'DateTime
        'General y fixed, muestra ocho digitos hexadecimal
        MessageBox.Show(EA.ToString("X")) 'DateTime

    End Sub
End Class
