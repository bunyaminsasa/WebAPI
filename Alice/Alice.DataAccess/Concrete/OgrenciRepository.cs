using Alice.DataAccess.Abstract;
using Alice.DataAccess.Migrations;
using Alice.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alice.DataAccess.Concrete
{
    public class OgrenciRepository : IOgrenciRepository
    {
      

        public Ogrenci CreateOgrenci(Ogrenci ogrenci)
        {
            using (var db = new MSSQLDbContext())
            {
                db.Ogrenci.Add(ogrenci);
                db.SaveChanges();
                return ogrenci;
            }
        }

        public void DeleteOgrenciById(int id)
        {
            using (var db = new MSSQLDbContext())
            {
                var deleteOgrenci = GetOgrenciById(id);
                db.Ogrenci.Remove(deleteOgrenci);
                db.SaveChanges();
            }
        }

        public List<Ogrenci> GetAllOgrenci()
        {
            using (var db = new MSSQLDbContext())
            {
                return db.Ogrenci.ToList();
            }
        }

        public Ogrenci GetOgrenciById(int id)
        {
            using (var db = new MSSQLDbContext())
            {
                return db.Ogrenci.Find(id);
            }
        }

        public Ogrenci GetOgrenciByName(string name)
        {
            using (var db = new MSSQLDbContext())
            {
                return db.Ogrenci.FirstOrDefault(x => x.Ad.ToLower() == name.ToLower());
            }
        }

        public Ogrenci UpdateOgrenci(Ogrenci ogrenci)
        {
            using (var db = new MSSQLDbContext())
            {
                db.Ogrenci.Update(ogrenci);
                db.SaveChanges();
                return ogrenci;
            }
        }
    }
}
