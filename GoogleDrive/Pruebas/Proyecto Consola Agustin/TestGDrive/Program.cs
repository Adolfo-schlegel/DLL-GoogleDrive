using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GoogleDriveService.Controller;

namespace TestGDrive
{
    class Program
    {

        static void Main(string[] args)
        {
            GoogleDriveController gDriveController = new GoogleDriveController(@"C:\Users\agust\Desktop\Trabajo\repos\CVM.GDrive\Archivos\Creadentials",
            "API-GoogleDriveApi",
            @"C:\Users\agust\Desktop\Trabajo\repos\CVM.GDrive\GoogleDrive\Credenciales TEST\client_secret_592789102999-iliu6catpq618dktmbi8ap23jubnqh8l.apps.googleusercontent.com.json");



            var lstr_result = gDriveController.Autenticar();

            if(lstr_result == "OK")
            {
                lstr_result = gDriveController.CrearCarpeta("pepe");
                List<string> lst_files = gDriveController.ListarCarpetas();
                Console.WriteLine(lstr_result);
                gDriveController.Cerrar();
            }

            Console.ReadKey(true);
        }
        
    }
}
