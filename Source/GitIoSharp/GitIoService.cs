using System;
using System.Net;
using System.Text;

namespace GitIoSharp
{
	public class GitIoService
	{
		public Uri Execute(string url)
		{
			var request = WebRequest.Create("http://git.io");
			request.ContentType = "application/x-www-form-urlencoded";
			request.Method = "POST";
			var bytes = Encoding.ASCII.GetBytes(url);
			request.ContentLength = bytes.Length;
			using (var os = request.GetRequestStream())
			{
				os.Write(bytes, 0, bytes.Length);
			}
			var response = request.GetResponse();
			
			return new Uri(response.Headers[HttpResponseHeader.Location]);
		}
	}
}