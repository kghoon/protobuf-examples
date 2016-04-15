using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProtobufExample
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Hello,World!?");

			Task.WaitAll(new Task[]
			{
				new Server().Run(),
				new Client().Run(),
			});

			Console.WriteLine("Finished");
		}
	}
}
