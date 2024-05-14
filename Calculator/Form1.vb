Public Class Form1

    Private currentNumber As String = ""
    Private oper As String = ""
    Private firstNumber As Double = 0

    Private Sub Button_Click(sender As Object, e As EventArgs) Handles Button1.Click, Button2.Click, Button3.Click, Button4.Click, Button5.Click, Button6.Click, Button7.Click, Button8.Click, Button9.Click, Button10.Click, Button11.Click, Button13.Click, Button14.Click, Button15.Click, Button16.Click
        Dim buttonText As String = sender.Text

        If IsNumeric(buttonText) Then
            currentNumber &= buttonText
            TextBox1.Text = currentNumber
        Else
            If currentNumber <> "" Then
                oper = buttonText
                TextBox1.Text = oper
                firstNumber = Double.Parse(currentNumber)
                currentNumber = ""
            End If
        End If

    End Sub




    Private Sub ButtonEquals_Click(sender As Object, e As EventArgs) Handles ButtonEquals.Click
        Dim secondNumber As Double = Double.Parse(currentNumber)

        Select Case oper
            Case "+"
                TextBox1.Text = Add(firstNumber, secondNumber)
            Case "-"
                TextBox1.Text = Subtract(firstNumber, secondNumber)
            Case "*"
                TextBox1.Text = Multiply(firstNumber, secondNumber)
            Case "/"
                If secondNumber = 0 Then
                    MessageBox.Show("Division by zero is not allowed!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Else
                    TextBox1.Text = Divide(firstNumber, secondNumber)
                End If
        End Select

        currentNumber = ""
        oper = ""
    End Sub

    Private Sub ButtonClear_Click(sender As Object, e As EventArgs) Handles ButtonClear.Click
        currentNumber = ""
        oper = ""
        firstNumber = 0
        TextBox1.Text = ""
    End Sub

    Function Add(num1 As Double, num2 As Double) As Double
        Return (num1 + num2).ToString()
    End Function

    Function Subtract(num1 As Double, num2 As Double) As Double
        Return (num1 - num2).ToString()
    End Function

    Function Multiply(num1 As Double, num2 As Double) As Double
        Return (num1 * num2).ToString()
    End Function

    Function Divide(num1 As Double, num2 As Double) As Double
        Return (num1 / num2).ToString()
    End Function
End Class
