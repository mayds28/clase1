Imports System.Reflection.Emit
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.Button

Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim valor1 As Integer
        Dim valor2 As Integer
        Dim suma As Integer
        valor1 = TextBox1.Text
        valor2 = TextBox2.Text
        suma = valor1 + valor2
        Label3.Text = suma
        MessageBox.Show("Acabasteeeeee!!!!")

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim valor1 As Integer
        Dim valor2 As Integer
        Dim resta As Integer
        valor1 = TextBox1.Text
        valor2 = TextBox2.Text
        resta = valor1 - valor2
        Label3.Text = resta
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim valor1 As Integer
        Dim valor2 As Integer
        Dim multiplicación As Integer
        valor1 = TextBox1.Text
        valor2 = TextBox2.Text
        multiplicación = valor1 * valor2
        Label3.Text = multiplicación
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If RadioButton1.Checked = True Then
            Width = 100
            Height = 200
        Else
            If RadioButton2.Checked = True Then
                Width = 500
                Height = 600
            Else
                If RadioButton3.Checked = True Then
                    Width = 1200
                    Height = 1000

                Else
                    If RadioButton4.Checked = True Then
                        Width = 800
                        Height = 1000
                    End If
                End If
            End If
        End If
    End Sub


End Class
