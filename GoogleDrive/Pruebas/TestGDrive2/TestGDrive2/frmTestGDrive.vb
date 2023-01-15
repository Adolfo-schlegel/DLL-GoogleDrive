
Imports CVM_CNT2

Public Class frmTestGDrive

    Private Sub cmd_subir_Click(sender As Object, e As EventArgs) Handles cmd_subir.Click

        'Dim lGDrive2 As New GoogleDriveService.Controller.GoogleDriveController("c:\temp\GDrive.Credentials",
        '                                "MYGoogleDrive",
        '                                "C:\Temp\GDrive.ClientSecret\client_secret_260028708618-mssuc80o0rdt0k318p5c49l7mntjki6b.apps.googleusercontent.com.json")

        'Dim lstr_archivo As String = ""
        'Dim lstr_res As String = "OK"

        'lstr_archivo = "d:\temp\backup_gpa_contable_TestGDrive.zip"

        'With lGDrive2
        '    lstr_res = .Autenticar
        '    If lstr_res = "OK" Then lstr_res = .Subir(lstr_archivo, "Test GDrive", "Estudio")
        '    lstr_res = .Cerrar()
        'End With

        'lGDrive2 = Nothing

    End Sub

    Private Sub cmd_subir_cnt_Click(sender As Object, e As EventArgs) Handles cmd_subir_cnt.Click
        Dim lstr_res As String = "OK"

        lstr_res = RN.SubirGDrive("Test")

    End Sub
End Class
