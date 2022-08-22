Imports Sistema.Entidades
Imports Sistema.Negocio
Public Class FrmLogin
    Private Sub BtnCncelar_Click(sender As Object, e As EventArgs) Handles BtnCncelar.Click
        End
    End Sub

    Private Sub BtnAceptar_Click(sender As Object, e As EventArgs) Handles BtnAceptar.Click
        Try
            Dim Email As String
            Dim Clave As String
            Dim ObjUsuario As New Usuario
            Dim NegUsuario As New NegocioUsuario
            Email = TxtEmail.Text.Trim()
            Clave = TxtClave.Text.Trim()
            ObjUsuario = NegUsuario.Loguear(Email, Clave)
            If (ObjUsuario Is Nothing) Then
                MsgBox("No exixtel el usuario o la Contraseña", MsgBoxStyle.Critical, "VERIFICAR")
            Else
                If (ObjUsuario.Estado = False) Then
                    MsgBox("El Usuario No tiene Acceso al Sistema", MsgBoxStyle.Exclamation, "Consultar")
                Else
                    Me.Hide()
                    FrmPrincipal.IdUsuario = ObjUsuario.IdUsuario
                    Variables.IdUsuario = ObjUsuario.IdUsuario
                    FrmPrincipal.IdRol = ObjUsuario.IdRol
                    FrmPrincipal.NombreRol = ObjUsuario.NombreRol
                    FrmPrincipal.Nombre = ObjUsuario.Nombre
                    FrmPrincipal.Show()
                    ' Me.Close()
                End If
            End If


        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class