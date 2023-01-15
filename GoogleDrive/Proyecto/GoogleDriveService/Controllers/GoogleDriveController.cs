using GoogleDriveService.ClientService;
using GoogleDriveService.Services.GoogleDrive;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GoogleDriveService.Controller
{
    public class GoogleDriveController
    {
        private string pstr_credentialPath = "";
        private string pstr_NameProyect = "";
        private string pstr_clientSecret = "";

        private string pstr_api_key = "";

        GDService _GDService;

        public GoogleDriveController(string pstr_credentialPath, string pstr_NameProyect, string pstr_clientSecret)
        {
            this.pstr_credentialPath = pstr_credentialPath;
            this.pstr_NameProyect = pstr_NameProyect;
            this.pstr_clientSecret = pstr_clientSecret;
        }
		public GoogleDriveController(string pstr_api_key, string pstrAplicationName)
		{
            this.pstr_api_key = pstr_api_key;
			this.pstr_NameProyect = pstrAplicationName;
		}

		public string Autenticar()
        {
            string lstr_res = "OK";

            try
			{
                if(pstr_api_key != "")
					_GDService = new GDService(new Auth(pstr_api_key, pstr_NameProyect).MakeService());
				_GDService = new GDService(new Auth(pstr_credentialPath, pstr_clientSecret, pstr_NameProyect).MakeService());
            }
            catch(Exception ex)
			{
                lstr_res = ex.Message;
            }
            
            return lstr_res;
        }

        public string Cerrar()
        {
            string lstr_res = "OK";

            _GDService.Dispose();

            return lstr_res;
        }

        //private string pf_PuedoTrabajar()
        //{
        //    string lstr_res = "OK";

        //    if (mstr_path_credentials == "")
        //        lstr_res = "Falta Especificar el Código de GD";

        //    if (lstr_res == "OK" && (mstr_cd_proyecto == "" | mjson_secreto == ""))
        //        lstr_res = "Falta Configurar la Conexión";

        //    // Token 
        //    // ????

        //    return lstr_res;
        //}

        public string Subir(string pstr_archivo,string pstr_description, string pstr_carpeta_drive)
        {
            string lstr_res = "OK";           

            try
            {
                _GDService.UploadFile(pstr_description, pstr_archivo, pstr_carpeta_drive);
            }
            catch (Exception ex)
            {
                lstr_res = ex.Message;
            }

            return lstr_res;
        }

        public string CrearCarpeta(string pstr_carpeta_nombre)
        {
            string lstr_res = "OK";

            _GDService.CreateFolder(pstr_carpeta_nombre);

            return lstr_res;
        }

        public List<string> ListarCarpetas() => _GDService.ListFolders();

        public List<string> ListarArchivos() => _GDService.ListAllFiles();

        public List<string> ListarArchivosEnCarpeta(string pstr_carpeta_nombre) => _GDService.ListFilesInFolder(pstr_carpeta_nombre);

        public List<string> ListarEliminados() => _GDService.ListTrashFiles();


        //falta
        public string Descargar(string pstr_archivo, string pstr_carpeta_destino)
        {
            string lstr_res = "OK";


            return lstr_res;
        }
    }
}


