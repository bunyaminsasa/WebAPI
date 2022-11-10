using Alice.Business.Abstract;
using Alice.DataAccess.Abstract;
using Alice.DataAccess.Migrations;
using Alice.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alice.Business.Concrete
{
    public class OgrenciMenager : IOgrenciService
    {
        private IOgrenciRepository ogr;
        public OgrenciMenager(IOgrenciRepository _ogr)
        {
            ogr = _ogr;
        }


        public Ogrenci CreateOgrenci(Ogrenci ogrenci)
        {
            return ogr.CreateOgrenci(ogrenci);
        }

        public void DeleteOgrenciById(int id)
        {
            if (id > 0) ogr.DeleteOgrenciById(id);
            else throw new Exception("ID değeri 1'den küçük olamaz");
        }

        public List<Ogrenci> GetAllOgrenci()
        {
            return ogr.GetAllOgrenci();
        }

        public Ogrenci GetOgrenciById(int id)
        {
            if (id > 0) return ogr.GetOgrenciById(id);
            else throw new Exception("ID değeri 1'den küçük olamaz");
        }

        public Ogrenci GetOgrenciByName(string name)
        {
            return ogr.GetOgrenciByName(name);
        }

        public Ogrenci UpdateOgrenci(Ogrenci ogrenci)
        {
            return ogr.UpdateOgrenci(ogrenci);
        }
    }
}
