Imports System.Data.SqlClient

Public Class ClsConexion
    Dim con As New SqlConnection("Server=LAPTOP-1J7APA1A;Database=Prueba;Integrated Security=true;")
    Dim cmd As New SqlCommand
    Sub Conectar()
        Try
            con.Open()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

End Class
