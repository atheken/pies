using System;
using Manos;

namespace pies
{
	public class DBModule : ManosModule
	{
		public DBModule ()
		{
			Get("/read/(?<docid>[0-9]+)/",this);
		}
		
		public void Read(PiesApp app, IManosContext ctx, int docid)
		{
			//don't do anything special yet.
			ctx.Response.End(BitConverter.GetBytes(docid));
		}
	}
}

