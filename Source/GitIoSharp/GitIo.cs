using System;

namespace GitIoSharp
{
	public class GitIo
	{
		private readonly GetIoService _gitIoService;

		public GitIo()
		{
			_gitIoService = new GetIoService();
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