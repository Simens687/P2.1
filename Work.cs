using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Shapes;

namespace WpfApp2
{
    public class Work : iCRUD
    {
        public void Create(List<Zametka> zametki)
        {
            List<List<Zametka>> allzametki = new List<List<Zametka>>();
            allzametki.Add(zametki);
            string json = JsonConvert.SerializeObject(allzametki);
            File.WriteAllText("D:\\Zametochki.json", json);
        }

        public void Delete()
        {
            throw new NotImplementedException();
        }

        public List<List<Zametka>> Read()
        {
            string text = File.ReadAllText("D:\\Zametochki.json");
            List<List<Zametka>> result = JsonConvert.DeserializeObject<List<List<Zametka>>>(text);
            return result;
        }

        public void Update()
        {
            throw new NotImplementedException();
        }
    }
}
