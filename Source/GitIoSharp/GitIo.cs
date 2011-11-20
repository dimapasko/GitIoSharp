using System;

namespace GitIoSharp
{
	public class GitIo
	{
		private readonly GitIoService _gitIoService;

		public GitIo()
		{
			_gitIoService = new GitIoService();
		}

		public Uri Shorten(Uri url)
		{
			return _gitIoService.Execute(String.Format("url={0}", url));
		}

		public Uri Shorten(Uri url, string code)
		{
			return _gitIoService.Execute(String.Format("url={0}&code={1}", url, code));
		}
	}
}