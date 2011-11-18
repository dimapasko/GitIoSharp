using System;
using System.Net;
using System.Text;

namespace GitIoSharp
{
	public class GetIoService
	{
		public Uri Execute(string url)
		{
			var req = WebRequest.Create("http://git.io");
			req.ContentType = "application/x-www-form-urlencoded";
			req.Method = "POST";
			var bytes = Encoding.ASCII.GetBytes(url);
			req.ContentLength = bytes.Length;
			using (var os = req.GetRequestStream())
			{
				os.Write(bytes, 0, bytes.Length);
			}
			var resp = req.GetResponse();
			return new Uri(resp.Headers[HttpResponseHeader.Location]);
		}
	}
}