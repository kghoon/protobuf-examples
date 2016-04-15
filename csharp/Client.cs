using Google.Protobuf;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using static ProtobufExample.Person.Types;

namespace ProtobufExample
{
	public class Client
	{
		private static int nextPersonId = 1;

		public async Task Run()
		{
			await Task.Yield();

			Console.WriteLine("Client Start");

			TcpClient tcpClient = new TcpClient();
			tcpClient.Connect(GetServerEndPoint());

			var networkStream = tcpClient.GetStream();

			using (var sr = new StreamReader(networkStream, Encoding.Default))
			{
				var addressBook = MakeAddressBook();

				// send length of payload
				byte[] length = BitConverter.GetBytes(addressBook.CalculateSize());
				Debug.Assert(length.Length == 4);
				networkStream.Write(length, 0, length.Length);

				// send payload
				addressBook.WriteTo(networkStream);
				
				string response = sr.ReadLine();
				Console.WriteLine($"Response: {response}");
			}

			Console.WriteLine("Client End");

			tcpClient.Close();
		}

		private IPEndPoint GetServerEndPoint()
		{
			var addr = IPAddress.Parse(Config.SERVER_ADDR);
			return new IPEndPoint(addr, Config.SERVER_PORT);
		}

		private AddressBook MakeAddressBook()
		{
			return new AddressBook
			{
				Person = {
					new Person
					{
						Name = "Jihoon",
						Id = nextPersonId++,
						Email = "jhkang@piensoft.co.kr",
						Phones = {
							new PhoneNumber { Number = "010-1000-0001", Type = PhoneType.MOBILE },
							new PhoneNumber { Number = "02-2000-0002", Type = PhoneType.WORK }
						}
					},
					new Person
					{
						Name = "Yongkyu",
						Id = nextPersonId++,
						Email = "yongkyu@piensoft.co.kr",
						Phones =
						{
							new PhoneNumber { Number = "010-1001-1001", Type = PhoneType.MOBILE },
							new PhoneNumber { Number = "02-2001-1002", Type = PhoneType.WORK }
						}
					}
				}
			};
		}
	}
}
