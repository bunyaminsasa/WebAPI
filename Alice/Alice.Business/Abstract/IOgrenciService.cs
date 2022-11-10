using Alice.DataAccess.Migrations;
using Alice.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alice.Business.Abstract
{
    public interface IOgrenciService
    {
        List<Ogrenci> GetAllOgrenci();
        Ogrenci GetOgrenciById(int id);
        Ogrenci GetOgrenciByName(string name);
        Ogrenci CreateOgrenci(Ogrenci ogrenci);
        Ogrenci UpdateOgrenci(Ogrenci ogrenci);
        void DeleteOgrenciById(int id);

    }
}
