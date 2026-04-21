Imports System.Runtime.Remoting
Imports System.Runtime.Remoting.Channels
Imports Microsoft.VisualBasic.Devices
Imports MySql.Data.MySqlClient
Imports Twilio
Imports Twilio.Rest.Api.V2010.Account
Imports Twilio.Types
Module Module1
    Sub conectar_banco()
        Try
            Dim conexao = New MySqlConnection("Server=localhost;user=root;password=1234;database=OFICINA")

            conexao.Open()
            MsgBox("Conexão estabelecida com sucesso!", MsgBoxStyle.OkOnly)
        Catch ex As Exception
            MsgBox("Erro ao conectar", MsgBoxStyle.Critical)
        End Try
    End Sub
End Module
