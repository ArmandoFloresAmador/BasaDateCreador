Imports System.Data.OleDb
Imports System.IO

Module Creador_de_Usuarios
#Region "Variables"
    Public usuario = Form5.Text3.Text
    Public ruta As String = Application.StartupPath
    Public RutaDeUsuario As String = (ruta & "/Usuarios/" & usuario)
    Dim CreadordeRutadeUsuarios = If(Directory.Exists(RutaDeUsuario), Nothing, Directory.CreateDirectory(RutaDeUsuario))
    Public comando As New OleDb.OleDbCommand
    Public conexion As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & RutaDeUsuario & "/Datos/" & usuario & ".accdb")
    Public Basedeusuarios As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & ruta & "/Usuarios/Usuarios.accdb")

#End Region

#Region "Creador de directorios para usuario"
    Sub directoriosParaUsuario()
        Directory.CreateDirectory(RutaDeUsuario & "/Datos")
        Directory.CreateDirectory(RutaDeUsuario & "/Bases de datos")
        Directory.CreateDirectory(RutaDeUsuario & "/Imagenes")
    End Sub
#End Region

#Region "Creador de Archivo"
    Sub CreadordeUsuarios()
        Dim fs = CreateObject("ADOX.Catalog")
        fs.Create("Provider=Microsoft.ACE.OLEDB.12.0;Data Source='" & RutaDeUsuario & "/Datos/" & usuario & ".accdb'")
        conexion.Open()
        comando = New OleDbCommand("CREATE TABLE DatosdelUsuario(Nombre Char, Apellidos Char, Años Char, correo CHAR)", conexion)
        comando = New OleDbCommand("INSERT INTO DatosdelUsuario(Nombre, Apellidos, Años, correo" & Chr(13) &
                                   "VALUES(Form5.text1.text, Form5.text2.text, From5.text5.text, From5.text6.text)", conexion)
        comando.Parameters.AddWithValue("@Nombre", Form5.Text1.Text)
        comando.Parameters.AddWithValue("@Apellidos", Form5.Text2.Text)
        comando.Parameters.AddWithValue("@Años", Form5.Text5.Text)
        comando.Parameters.AddWithValue("@correo", Form5.Text6.Text)
        comando.ExecuteReader()

        If Not (File.Exists(ruta & "/Usuarios/Usuarios.accdb")) Then
            fs.Create("Provider=Microsoft.ACE.OLEDB.12.0;Data Source='" & ruta & "/Usuarios/Usuarios.accdb'")
            Basedeusuarios.Open()
            comando = New OleDbCommand("CREATE TABLE UsuariosActivos(Usuario CHAR, Contraseña VARCHAR(200))", Basedeusuarios)
            comando.ExecuteReader()
        End If
        Basedeusuarios.Open()
        comando = New OleDbCommand("INSERT INTO UsuariosActivos(Usuario, Contraseña)" & Chr(13) &
                             "VALUES(Form5.Text3, Form5.Text4)", Basedeusuarios)
            comando.Parameters.AddWithValue("@Usuario", Form5.Text3.Text) 'ToUpper No es nesesario, su funcion es combertir a mayusculas toda la palabra
            comando.Parameters.AddWithValue("@Contraseña", Form5.Text4.Text)
        comando.ExecuteReader()
    End Sub
#End Region

#Region "Mensaje de exito y limpiador"
    Sub MensajeLimpiador()
        If (File.Exists(RutaDeUsuario & "/Datos/" & usuario & ".accdb'")) Then
            MsgBox("El Usuario se a creado con exito" & vbOKOnly + vbInformation & "Usuario Creado")
        Else
            MsgBox("No fue posible crear el usuario" & vbOKOnly + vbCritical & "Error")
            Try
                conexion.Open()
            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try
        End If
    End Sub
#End Region
End Module
