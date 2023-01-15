using Google.Apis.Auth.OAuth2;
using Google.Apis.Drive.v3;
using Google.Apis.Util.Store;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;

namespace GoogleDriveService.Services.GoogleDrive
{
	public class Auth
	{
		public string strAplicationName;
		private string str_api_key;
		static string[] Scopes = { DriveService.Scope.Drive, DriveService.Scope.DriveFile };
		private UserCredential credential;
		private DriveService Service;

		public Auth(string pstrClientCredentialsPath, string pstrClientSecretPath, string pstrAplicationName)
		{
			strAplicationName = pstrAplicationName;

			//OAuth2
			using (var stream = new FileStream(pstrClientSecretPath, FileMode.Open, FileAccess.Read))
			{
				credential = GoogleWebAuthorizationBroker.AuthorizeAsync(
					GoogleClientSecrets.Load(stream).Secrets,
					Scopes,
					"user",
					CancellationToken.None,
					new FileDataStore(pstrClientCredentialsPath, true)).Result;
				Console.WriteLine("Creadenciales guardadas en: " + pstrClientCredentialsPath);
			}
		}
		public Auth(string pstr_api_key, string pstrAplicationName)
		{
			strAplicationName = pstrAplicationName;
			str_api_key = pstr_api_key;
		}

		public DriveService MakeService()
		{
			if(str_api_key != "")
			{
				Service = new DriveService(new Google.Apis.Services.BaseClientService.Initializer
				{
					ApiKey = str_api_key,
					ApplicationName =strAplicationName					
				});
			}
			else
			{
				Service = new DriveService(new Google.Apis.Services.BaseClientService.Initializer
				{
					HttpClientInitializer = credential,
					ApplicationName = strAplicationName
				});
			}			
			return Service;
		}
	}
}

