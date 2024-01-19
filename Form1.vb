Imports System.IO
Imports System.Runtime.InteropServices
Imports System.Windows
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.ToolBar

Public Class Form1
    'variables
    Dim num As Integer
    'variables
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Panel2.Size = New Size(0, 456)
        Label1.Text = "hola " & Environ("COMPUTERNAME") & " :)"
        Timer1.Enabled = True
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
    Private Sub Mostrar_Tick(sender As Object, e As EventArgs) Handles Mostrar.Tick
        If Panel2.Width >= 200 Then
            Mostrar.Enabled = False
        Else
            Panel2.Width = Panel2.Width + 6
        End If
        If num = 200 Then
            num = 0
        End If
    End Sub
    Public Sub ocultar_Tick(sender As Object, e As EventArgs) Handles ocultar.Tick
        If Panel2.Width <= 0 Then
            ocultar.Enabled = False
        Else
            Panel2.Width = Panel2.Width - 9
        End If
        If num = 20 Then
            num = 0
        End If
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
    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles  PictureBox3.Click
        Mostrar.Enabled = True
    End Sub
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles  PictureBox2.Click
        ocultar.Enabled = True
    End Sub
    Dim stoptimer As Stopwatch
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ocultar.Enabled = True
        Me.Hide()
        Form2.Show()
    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        ocultar.Enabled = True
        Me.Hide()
        Form3.Show()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Label3.Text = DateTime.Now.ToString("hh,mm,ss") & "  " & DateTime.Now.ToString("d,M,yy")
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Form4.Show()
        Me.Enabled = False
    End Sub



#End Region
    Private Sub Button7_Click(sender As Object, e As EventArgs) 
        'Dim p = If(Directory.Exists("C:\Users\antia\Desktop\Nueva carpeta/Usuario"), MsgBox(" No se encuentra "), MsgBox(" Se encuentra "))
    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click

    End Sub
End Class
