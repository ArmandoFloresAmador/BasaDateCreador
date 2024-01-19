Imports System.Runtime.InteropServices

Public Class Form4
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

    Private Sub LinkLabel2_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked

    End Sub

    Private Sub Imagen1_Click(sender As Object, e As EventArgs) Handles Imagen1.Click
        Text2.PasswordChar = ""

    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Me.Hide()
        Form5.Show()
    End Sub

    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Text1_TextChanged(sender As Object, e As EventArgs) Handles Text1.TextChanged

    End Sub

    Private Sub Text2_TextChanged(sender As Object, e As EventArgs) Handles Text2.TextChanged

    End Sub

#End Region
End Class