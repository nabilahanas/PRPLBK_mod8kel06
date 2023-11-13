Public Class Form1

    Dim Conv As New TempConvComp.TempConvComp

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ComboBox1.Items.AddRange({"Celcius", "Reamur", "Fahrenheit", "Kelvin"})
        ComboBox2.Items.AddRange({"Celcius", "Reamur", "Fahrenheit", "Kelvin"})
        TextBox2.Enabled = False
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If String.IsNullOrEmpty(TextBox1.Text) OrElse Not IsNumeric(TextBox1.Text) Then
            MessageBox.Show("Mohon masukkan bilangan bulat", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If
        If ComboBox1.SelectedItem.ToString() = ComboBox2.SelectedItem.ToString() Then
            MessageBox.Show("Pilih opsi yang berbeda untuk konversi", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        Dim inputTemp As Double = CDbl(TextBox1.Text)
        Dim convertedTemp As Double = ConvertTemperature(ComboBox1.SelectedItem.ToString(), ComboBox2.SelectedItem.ToString(), inputTemp)

        TextBox2.Text = $"{convertedTemp:N2}"
    End Sub
    Private Function ConvertTemperature(fromType As String, toType As String, value As Double) As Double
        Select Case fromType
            Case "Celcius"
                Select Case toType
                    Case "Reamur"
                        Return Conv.cToR(value)
                    Case "Fahrenheit"
                        Return Conv.cToF(value)
                    Case "Kelvin"
                        Return Conv.cToK(value)
                End Select
            Case "Reamur"
                Select Case toType
                    Case "Celcius"
                        Return Conv.rToC(value)
                    Case "Fahrenheit"
                        Return Conv.rToF(value)
                    Case "Kelvin"
                        Return Conv.rToK(value)
                End Select
            Case "Fahrenheit"
                Select Case toType
                    Case "Celcius"
                        Return Conv.fToC(value)
                    Case "Reamur"
                        Return Conv.fToR(value)
                    Case "Kelvin"
                        Return Conv.fToK(value)
                End Select
            Case "Kelvin"
                Select Case toType
                    Case "Celcius"
                        Return Conv.kToC(value)
                    Case "Reamur"
                        Return Conv.kToR(value)
                    Case "Fahrenheit"
                        Return Conv.kToF(value)
                End Select
        End Select

        Return 0.0
    End Function

    Private Sub txtInput_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox1.KeyPress
        If (Not Char.IsDigit(e.KeyChar) AndAlso e.KeyChar <> "-" AndAlso e.KeyChar <> "." AndAlso e.KeyChar <> ControlChars.Back) Then
            e.Handled = True
        End If
        If (e.KeyChar = "."c AndAlso (TryCast(sender, TextBox).Text.Contains("."))) Then
            e.Handled = True
        End If
        If (e.KeyChar = "-"c AndAlso TryCast(sender, TextBox).SelectionStart <> 0) Then
            e.Handled = True
        End If
    End Sub
End Class

