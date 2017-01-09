﻿using System;
using InteropExcel = Microsoft.Office.Interop.Excel;	 

namespace Interop
{
	public class IOWrite
	{
		private DataStruct _data;
		private InteropExcel.Application excel;

		public IOWrite(DataStruct data)
		{
		}

		public bool exportTable()
		{
			try {

				//Междинни проверки
				excel = InteropExcel.Application ();

				if (excel == null) return false;

				excel.Quit();
				return true;
			}
			catch
			{
			}
			return false;
		}

		public void addRow(DataRow _row)
		{
			try
			{



			}
			catch
			{


			}
		}

		public void runFile()
		{
			try
			{
				System.Diagnostics.Process.Start(getPath());
			} catch {
			}
		}

		private string getPath()
		{
			return System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Table.xlsx");
		}
	}
}
