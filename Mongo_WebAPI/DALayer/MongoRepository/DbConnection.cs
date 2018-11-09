using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Text;

namespace Mongo_WebAPI.MongoRepository
{
    class DbConnection
    {
        private static MongoClient _client;
        private static MongoServer _server;
        public static MongoServer ConnectServer()
        {
            _client = new MongoClient("mongodb://localhost:27017"); //can make it configurable via .config file
            _server = _client.GetServer();
            return _server;
        }
    }
}
