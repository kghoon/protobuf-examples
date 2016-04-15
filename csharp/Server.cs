using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace ProtobufExample
{
	public class Server
	{
		public async Task Run()
		{
			await Task.Yield();

			Console.WriteLine("Server start");

			var tcpListener = new TcpListener(IPAddress.Any, Config.SERVER_PORT);
			tcpListener.Start();

			var tcpClient = tcpListener.AcceptTcpClient();
			Console.WriteLine("Client accepted");

			var netStream = tcpClient.GetStream();

			int length = ReadPayloadLength(netStream);
			Console.WriteLine($"Payload length: {length}");

			try
			{
				AddressBook addressBook = ReadPayload(netStream, length);

				foreach (var person in addressBook.Person)
				{
					Console.WriteLine($"Name:{person.Name}, Id:{person.Id}");
					foreach (var phone in person.Phones)
					{
						Console.WriteLine($"Type:{phone.Type}, Number:{phone.Number}");
					}
					Console.WriteLine("=====");
				}

				var writer = new StreamWriter(netStream);
				writer.WriteLine($"Server recieved {length} bytes from client successfully!");
				writer.Flush();

			}
			catch (Exception e)
			{
				// do nothing
			}
			finally
			{
				tcpClient.Close();
				Console.WriteLine("Server end");
			}
		}

		private int ReadPayloadLength(NetworkStream netStream)
		{
			byte[] buf = new byte[4];
			int n = netStream.Read(buf, 0, 4);
			
			Debug.Assert(n == 4);

			return BitConverter.ToInt32(buf, 0);
		}

		private AddressBook ReadPayload(NetworkStream netStream, int length)
		{
			var buf = new byte[length];
			int n = netStream.Read(buf, 0, length);
			Debug.Assert(n == length);

			return AddressBook.Parser.ParseFrom(buf);
		}
	}
}
