using System;

namespace GitIoSharp.TestClient
{
	class Program
	{
		static void Main(string[] args)
		{
			var gitIo = new GitIo();
			Console.WriteLine(gitIo.Shorten(new Uri("http://github.com/dimapasko")));
			Console.WriteLine(gitIo.Shorten(new Uri("https://github.com/csharpus"), "csharpus"));
			Console.ReadLine();
		}
	}
}