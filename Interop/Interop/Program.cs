﻿using System;

namespace Interop
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			DataStruct data = new DataStruct();
			IOWrite write = new IOWrite(data);

			Console.WriteLine("Hello World!");
		}
	}
}
