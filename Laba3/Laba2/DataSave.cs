﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Xml.Serialization;
using System.IO;
using ExtendedXmlSerializer.Configuration;
using ExtendedXmlSerializer.ExtensionModel.Xml;
namespace Laba2
{
    public class DataSave
    {
        public DataJson SaveInJsonFormat(Data data)
        {
            DataJson dataJson = new DataJson();
            foreach(var item in data)
            {
                dataJson.Add(JsonConvert.SerializeObject(item));
            }
            return dataJson;
        }
        public DataXml SaveInXmlFormat(Data data)
        {
            DataXml dataXml = new DataXml();
            foreach(var item in data)
            {
                var serializer = new ConfigurationContainer().Create();
                var xml = serializer.Serialize(item);

            }
            return dataXml;
        }
        public void SaveInTxtJson(Data data,string path)
        {
           
                File.WriteAllText(path, JsonConvert.SerializeObject(data));

            

        }
        public Data DeserialiseFromJson(string path)
        {
            Data result = new Data();
            using (StreamReader file = File.OpenText(path))
            {
                JsonSerializer serializer = new JsonSerializer();
                 result= (Data)serializer.Deserialize(file, typeof(Data));
            }
            return result;
        }


    }
}
