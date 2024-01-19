Imports System.Runtime.InteropServices
Imports System.IO
Public Class Form5
#Region "Movimiento de barra de titulo"
    <DllImport("user32.DLL", EntryPoint:="ReleaseCapture")>
    Private Shared Sub ReleaseCapture()
    End Sub
    <DllImport("user32.DLL", EntryPoint:="SendMessage")>
    Private Shared Sub SendMessage(hWnd As IntPtr, wMsg As Integer, wParam As Integer, lParam As Integer)
    End Sub
    Private Sub Barradetitulo_MouseMove(sender As Object, e As MouseEventArgs) Handles Panel1.MouseMove
        ReleaseCapture()
        SendMessage(Me.Handle, &H112&, &HF012&, 0)
    End Sub
    Private Sub PtxMinimizar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PtxMinimizar.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub
    Private Sub PtxCerrar_Click(sender As Object, e As EventArgs) Handles PtxCerrar.Click
        Form1.Enabled = True
        Me.Hide()

    End Sub
#End Region
    Private Sub Form5_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form4.Show()
        Me.Hide()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If (File.Exists(Application.StartupPath & "/Usuarios/" & usuario & "/Datos/" & usuario & ".accdb")) Then
            'Dim valor As Long =
            ' Dim NombreNuevo As String = Text3.Text + Valor
            'MsgBox("El Usuario que intenta crear ya existe" & vbNewLine & "desea crear en su lugar" &  & "?" & vbYesNo + vbInformation & "Error de usuario duplicado")
            MsgBox("El Usuario que intenta crear ya existe" & vbNewLine & "fabor de crear uno con diferente usuario", vbOKOnly + vbCritical, "Error de usuario duplicado")
        Else
            Call directoriosParaUsuario()
            Call CreadordeUsuarios()
            Me.Hide()
            Form1.Enabled = True
        End If
    End Sub
#Region "texts"
    Private Sub Text1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Text1.KeyPress
        If Asc(e.KeyChar) = 13 Then
            Text2.Focus()
            e.Handled = True
        End If
    End Sub
    Private Sub Text2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Text1.KeyPress
        If Asc(e.KeyChar) = 13 Then
            Text3.Focus()
            e.Handled = True
        End If
    End Sub
    Private Sub Text3_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Text1.KeyPress
        If Asc(e.KeyChar) = 13 Then
            Text4.Focus()
            e.Handled = True
        End If
    End Sub
    Private Sub Text4_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Text1.KeyPress
        If Asc(e.KeyChar) = 13 Then
            Text5.Focus()
            e.Handled = True
        End If
    End Sub
    Private Sub Text5_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Text1.KeyPress
        If Asc(e.KeyChar) = 13 Then
            Text6.Focus()
            e.Handled = True
        End If
    End Sub
    Private Sub Text6_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Text1.KeyPress
        If Asc(e.KeyChar) = 13 Then

            e.Handled = True
        End If
    End Sub
#End Region



End Class