
using Manos;
using System;

namespace pies {

	public class PiesApp : ManosApp {

		public PiesApp ()
		{
			Route("/DB",new DBModule());
		}
	}
}
