using System;
using System.Runtime.Serialization;

namespace GitIoSharp
{
	public class GitIoException : ApplicationException, ISerializable
	{
		public GitIoException()
		{
		}

		public GitIoException(string message)
			: base(message)
		{
		}

		public GitIoException(string message, Exception inner)
			: base(message, inner)
		{
		}

		protected GitIoException(SerializationInfo info, StreamingContext context)
			: base (info, context)
		{
		}
	}
}