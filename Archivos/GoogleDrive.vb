
Public Class GoogleDrive

    'Dim lGDrive As New GoogleDrive
    'lGDrive = New GoogleDrive("GPA.CONTABLE1")
    'lstr_res = lGDrive.Subir(txt_archivo.text, "Estudio")
    'lGDrive.Cerrar

    Private mstr_cd_gd As String = ""
    Private mstr_cd_proyecto As String = ""
    Private mjson_secreto As String = ""

    Public Sub New(ByVal pstr_cd_gd As String, ByVal pstr_cd_proyecto As String, ByVal pjson_secreto As String)

        mstr_cd_gd = pstr_cd_gd
        mstr_cd_proyecto = pstr_cd_proyecto
        mjson_secreto = pjson_secreto

    End Sub

    Public Function Autenticar() As String

        Dim lstr_res As String = "OK"

        '????

        Return lstr_res

    End Function

    Public Function Cerrar() As String

        Dim lstr_res As String = "OK"

        '????

        Return lstr_res

    End Function

    Private Function pf_PuedoTrabajar() As String

        Dim lstr_res As String = "OK"

        If mstr_cd_gd = "" Then
            lstr_res = "Falta Especificar el Código de GD"
        End If

        If lstr_res = "OK" AndAlso (mstr_cd_proyecto = "" Or mjson_secreto = "") Then
            lstr_res = "Falta Configurar la Conexión"
        End If

        'Token 
        '????

        Return lstr_res

    End Function

    Public Function Subir(
        ByVal pstr_archivo As String,
        ByVal pstr_carpeta_drive As String
        ) As String

        Dim lstr_id As String = ""
        Dim lstr_res As String = "OK"

        'Valido Si puedo Operar en GD
        lstr_res = pf_PuedoTrabajar()
        If lstr_res <> "OK" Then Return lstr_res

        'Autentico
        lstr_res = Me.Autenticar

        'Obtengo el ID de la carpeta en GD
        lstr_id = Me.ObtenerIDCarpeta(pstr_carpeta_drive, True)

        'Subo el archivo
        Try


        Catch ex As Exception
            lstr_res = ex.Message
        End Try

        Return lstr_res

    End Function

    Public Function ObtenerIDCarpeta(
        ByVal pstr_carpeta_nombre As String,
        ByVal pbln_CrearSiNoExiste As Boolean
        ) As String

        Dim lstr_id As String = ""

        '??? busco carpeta
        '???

        If lstr_id = "" And pbln_CrearSiNoExiste Then
            Me.CrearCarpeta(pstr_carpeta_nombre)
            'lstr_id = ???
        End If

        Return lstr_id

    End Function

    Public Function ObtenerIDArchivo(ByVal pstr_archivo As String) As String

        Dim lstr_id As String = ""

        '??? busco archivo
        '???

        Return lstr_id

    End Function

    Public Function CrearCarpeta(ByVal pstr_carpeta_nombre As String) As String

        Dim lstr_res As String = "OK"

        Return lstr_res

    End Function

    Public Function Descargar(ByVal pstr_archivo As String, ByVal pstr_carpeta_destino As String) As String

        Dim lstr_id_archivo As String = ""
        Dim lstr_res As String = "OK"

        lstr_id_archivo = Me.ObtenerIDArchivo(pstr_archivo)

        If lstr_id_archivo = "" Then
            lstr_res = "Archivo Inexistente"
        Else
            '?????
        End If

        Return lstr_res

    End Function

End Class
