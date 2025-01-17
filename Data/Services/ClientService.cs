﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FitnessProject.Data
{
    public class ClientService
    {
        private readonly ApplicationDbContext db;

        public ClientService(ApplicationDbContext _db)
        {
            db = _db;
        }

        public List<Client> GetClients()
        {
            var clientList = db.Clients.ToList();
            return clientList;
        }

        public int AddClient(Client objClient)
        {
            db.Clients.Add(objClient);
            db.SaveChanges();

            int id = objClient.Client_id;
            return id;
        }

        public Client GetClientById(int id)
        {
            Client client = db.Clients.FirstOrDefault(c => c.Client_id == id);
            return client;
        }
        public Client GetClientByBarcode(String barcode)
        {
            Client client = db.Clients.FirstOrDefault(c => c.Bar_code == barcode);
            return client;
        }

        public Client GetClientByEmail(String email)
        {
            Client client = db.Clients.FirstOrDefault(c => c.Email == email);
            return client;
        }

        public string UpdateClient(Client objClient)
        {
            db.Clients.Update(objClient);
            db.SaveChanges();
            return "Client updated succesfully.";
        }

        public string DeleteClient(Client objClient)
        {
            db.Clients.Remove(objClient);
            db.SaveChanges();
            return "Client deleted succesfully.";
        }
    }
}
