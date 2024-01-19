Imports System.Data.Common
Imports System.Data.OleDb

Module Module1

#Region "Variables"
    Public loading As Boolean
    Public conexion As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\" & user & ".accdb")
    Public comando As New OleDbCommand
    Public verif As String
    Public cargar As OleDbDataReader
    Public CrearCarpeta1 As Object = CreateObject("Scripting.FileSystemObject")
    Public user As String = Form5.Text3.Text
    Public path As String = Application.StartupPath
    '                           If(                 Condicion    ),    Si se cumple                        ,   Si no se cumple                                    )
    Public pathUser = If(Dir(path & "/Usuarios/" & user), pathUser = (path & "/Usuarios/" & user), CrearCarpeta1.createFolder(path & "/Usuarios/" & user))

#End Region
#Region "Verificador de conexion"
    Public Sub verificador()
        Try
            conexion.Open()
            verif = "Conectado"
        Catch ex As Exception
            verif = "Error"
            MsgBox(ex.ToString)
        End Try
    End Sub
#End Region

#Region "crear Base de Datos"
    Sub crearusuariol()
        'crea la carpeta de archivos
        'Dim CrearCarpeta As Object = CreateObject("Scripting.FileSystemObject")
        'CrearCarpeta.createFolder(path & "\BaseData")
        'CrearCarpeta.createFolder(path & "\Imagenes")
        'Crea el Archivo 
        Dim Formato = CreateObject("ADOX.catalog")
        Formato.Create("Provider=Microsoft.ACE.OLEDB.12.0;Data Source='" & path & "/" & user & ".accdb'")

    End Sub
    Public Function CrearUsuario(RutaBaseDatos As String) As Boolean



        On Error Resume Next
        Dim BaseData As Object
        RutaBaseDatos = CrearUsuario(Application.StartupPath & "\Usuarios" & user & "\BaseData\" & user & ".accdb")

        CrearUsuario = True

        BaseData = CreateObject("ADOX.Catalog")
        BaseData.Create("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & CrearUsuario & ";")

        Return CrearUsuario
        'crea tablas :s
        Call verificador()

        Dim tbl As New CatalogLocation
        Dim da As New OleDb.OleDbCommand("CREATE TABLE DatosPer(User CHAR,Nom CHAR, Apes CHAR, Año CHAR, Cont CHAR)", conexion)
        da.ExecuteReader()

        'user = ""
        Return pathUser
    End Function

#End Region


End Module
