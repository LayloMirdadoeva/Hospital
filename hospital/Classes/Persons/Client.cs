using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    public class Client
    {
        public int ClientId { get; set; }
        public string Name { get; set; }

        //public override string Info
        //{
        //    get { return $"{base.Info} TypeOfDiseaseClient: {TypeOfDisease}"; }
        //}

        //public string TypeOfDisease { get; set; }
        //public override void Sick()
        //{
        //    Console.WriteLine("Client is sick");
        //}
 
    }
    public class CollectionClass
    {
        Client _client1;
        Client _client2;
        Client _client3;

        public CollectionClass()
        {
            Client client = new Client();
            _client1 = new Client();
            {
                client.Name = "Shahlo";
                client.ClientId = 1;
              

            };
            _client2 = new Client();
            {
                client.Name = "Manizha";
                client.ClientId = 256;
            }
            _client3 = new Client();
            {
                client.Name = "Oisha";
                client.ClientId = 25;
            };


        }
        public void DictoinaryFunction()
        {
            var clients = new Dictionary<int, Client>();
            clients.Add(_client1.ClientId, _client1);
            clients.Add(_client2.ClientId, _client1);
            clients.Add(_client3.ClientId, _client1);

            foreach (var client in clients)
                Console.WriteLine($"Client  {client.Key} {client.Value.Name}");
            Console.ReadKey();
        }
        
    }
    
}
