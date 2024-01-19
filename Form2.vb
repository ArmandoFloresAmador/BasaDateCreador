Imports System.IO
Imports System.Runtime.InteropServices

Public Class Form2
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        Form1.Show()
    End Sub
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
    Private Sub PtxCerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PtxCerrar.Click
        End
    End Sub
    Private Sub PtxMinimizar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PtxMinimizar.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub
    Private Sub PtxNormal_Click(sender As Object, e As EventArgs) Handles PtxNormal.Click
        If Me.WindowState = FormWindowState.Maximized Then
            Me.WindowState = FormWindowState.Normal
        Else
            Me.WindowState = FormWindowState.Maximized
        End If
    End Sub
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        '       If(                 Condicion                                     ),    Si se cumple            ,   Si no se cumple       )                              
        Dim p = If(Directory.Exists("C:\Users\antia\Desktop\Nueva carpeta/Usuario"), MsgBox(" No se encuentra "), MsgBox(" Se encuentra "))
    End Sub
#End Region
End Class