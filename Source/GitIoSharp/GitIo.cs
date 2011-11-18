using System;
using System.IO;
using System.Net;

namespace GitIoSharp
{
	public class GitIo
	{
		public Uri Shorten(Uri url)
		{
			var req = WebRequest.Create("http://git.io");
			req.ContentType = "application/x-www-form-urlencoded";
			req.Method = "POST";
			//We need to count how many bytes we're sending. Post'ed Faked Forms should be name=value&
			var bytes = System.Text.Encoding.ASCII.GetBytes("url=" + url);
			req.ContentLength = bytes.Length;
			Stream os = req.GetRequestStream();
			os.Write(bytes, 0, bytes.Length);
			os.Close();
			var resp = req.GetResponse();
			return new Uri(resp.Headers[HttpResponseHeader.Location]);
		}

		public void Shorten(string url, string code)
		{
		}
	}
}