
using Manos;
using Manos.Http;
using System;
using System.Linq;

namespace pies {

	public class PiesApp : ManosApp {

		public PiesApp ()
		{
		}
		
		[Get("/echo/(?<value>.+?)/(?<id>.+?)/")]
		public void Echo(IManosContext ctx, String value, int id)
		{
			ctx.Response.SetHeader("Content-Type","text/html");
			for(; id > 0; id--)
			{
				ctx.Response.Write(value + "<br/>");
			}
			ctx.Response.End();
		}
		
	}
}
