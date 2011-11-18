using System;

namespace GitIoSharp.TestClient
{
	class Program
	{
		static void Main(string[] args)
		{
			var r = new GitIo().Shorten(new Uri("http://github.com/dimapasko"));
		}
	}
}