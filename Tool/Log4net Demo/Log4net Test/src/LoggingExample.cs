#region Copyright & License
//
// Copyright 2001-2005 The Apache Software Foundation
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
// http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
//
#endregion

// Configure log4net using the .config file
[assembly: log4net.Config.XmlConfigurator(Watch=true)]
// This will cause log4net to look for a configuration file
// called ConsoleApp.exe.config in the application base
// directory (i.e. the directory containing ConsoleApp.exe)

namespace ConsoleApp
{
	using System;

	/// <summary>
	/// Example of how to simply configure and use log4net
	/// </summary>
	public class LoggingExample
	{
		// Create a logger for use in this class
		private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
		// NOTE that using System.Reflection.MethodBase.GetCurrentMethod().DeclaringType
		// is equivalent to typeof(LoggingExample) but is more portable
		// i.e. you can copy the code directly into another class without
		// needing to edit the code.

		/// <summary>
		/// Application entry point
		/// </summary>
		/// <param name="args">command line arguments</param>
		public static void Main(string[] args)
		{
			log.Error("Error Acc");
			log.Fatal("Fatle Acc");			
			System.Console.ReadLine();
			
		}

	}
}
