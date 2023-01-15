using GoogleDriveService.Controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp1
{
	internal class Program
	{
		static void Main(string[] args)
		{
			GoogleDriveController googleDriveController = new GoogleDriveController(
			"AIzaSyC7wl3KCgVzXT0qkPoLxup57mKZy2clrug",
			"API-GoogleDriveApi");
			
			//crear gmail cvm.repo01
			//validar si la cuentad de correo es igual a las que estan dentro del cliente secreto

			var lstr_result = googleDriveController.Autenticar();

			if (lstr_result == "OK")
			{
				lstr_result = googleDriveController.CrearCarpeta("pepe");
				Console.WriteLine(googleDriveController.Subir(@"D:\Descargas\610px-MANDEL_Z-2+C_medium.jpg", "a", "7/27/2022"));

				List<string> lst_files_en_carpeta = googleDriveController.ListarArchivosEnCarpeta("7/27/2022");
				List<string> lst_archivos_eliminados = googleDriveController.ListarEliminados();
				List<string> lst_folders = googleDriveController.ListarCarpetas();
				List<string> lst_files = googleDriveController.ListarArchivos();

				googleDriveController.Cerrar();
			}
			Console.ReadKey();
		}
	}
}
