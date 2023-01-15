Imports GoogleDriveService.Controller

Public Class RN

    Shared Function SubirGDrive(
        ByVal pstr_detalle As String
        ) As String

        Dim lGDrive2 As New GoogleDriveController("C:\Users\Adolf\OneDrive\Escritorio\Datos personales\GoogleCloudOAuth\Creadentials",
                                        "MYGoogleDrive",
                                        "C:\Users\Adolf\OneDrive\Escritorio\Datos personales\GoogleCloudOAuth\client_secret_380759970163-oma9ok713mfp795gor5s0ijovsf5a6vk.apps.googleusercontent.com.json")

        Dim lstr_archivo As String = ""
        Dim lstr_res As String = "OK"

        lstr_archivo = "C:\Users\Adolf\Downloads\ICO Win96\cat.jpg"

        With lGDrive2
            lstr_res = .Autenticar
            If lstr_res = "OK" Then lstr_res = .Subir(lstr_archivo, "Test GDrive", "pepe")
            lstr_res = .Cerrar()
        End With

        lGDrive2 = Nothing

        Return lstr_res

    End Function


End Class
