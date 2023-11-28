using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classs3
{
    internal class Ev
    {
         string adres;
         string metrekare;
         string kat;
         int odasayisi;
         bool otopark;
         string kacyillik;
         string kiralık;
         string ısınmayolu;
        string esyalı;
        string balkonlu;
        string banyosayisi;
        string krediyeuygun;
        bool asansor;

        public string Adres { get => adres; set => adres = value; }
        public string Metrekare { get => metrekare; set => metrekare = value; }
        public string Kat { get => kat; set => kat = value; }
        public int Odasayisi { get => odasayisi; set => odasayisi = value; }
        public bool Otopark { get => otopark; set => otopark = value; }
        public string Kacyillik { get => kacyillik; set => kacyillik = value; }
        public string Kiralık { get => kiralık; set => kiralık = value; }
        public string Isınmayolu { get => ısınmayolu; set => ısınmayolu = value; }
        public string Esyalı { get => esyalı; set => esyalı = value; }

        public Ev(string adres, string metrekare, string kat, int odasayisi, bool otopark, string kacyillik, string kiralık, string ısınmayolu, string esyalı)
        {
            Adres = adres;
            Metrekare = metrekare;
            Kat = kat;
            Odasayisi = odasayisi;
            Otopark = otopark;
            Kacyillik = kacyillik;
            Kiralık = kiralık;
            Isınmayolu = ısınmayolu;
            Esyalı = esyalı;
        }
    }




}
