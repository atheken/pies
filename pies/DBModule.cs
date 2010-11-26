using System;
using Manos;

namespace pies
{
	public class DBModule : ManosModule
	{
		public DBModule ()
		{
			
		}
		
		public void Read(IManosContext ctx)
		{
			//don't do anything special yet.
			ctx.Response.End(BitConverter.GetBytes(42));
		}
	}
}

