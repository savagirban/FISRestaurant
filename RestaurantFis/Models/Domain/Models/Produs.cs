using RestaurantFis.Models.Domain.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantFis.Models.Domain.Models
{
    internal class Produs
    {
        #region Campuri
        private string denumire;
        private string descriere;
        private double pret;
        private StatusProdus statusProdus;
        private DimensiuneProdus dimensiuneProdus;

        public Produs()
        {
        }

        public Produs(string denumire, string descriere, double pret, StatusProdus statusProdus, DimensiuneProdus dimensiuneProdus)
        {
            this.denumire = denumire;
            this.descriere = descriere;
            this.pret = pret;
            this.statusProdus = statusProdus;
            this.dimensiuneProdus = dimensiuneProdus;
        }

        public string Denumire { get => denumire; set => denumire = value; }
        public string Descriere { get => descriere; set => descriere = value; }
        public double Pret { get => pret; set => pret = value; }
        internal StatusProdus StatusProdus { get => statusProdus; set => statusProdus = value; }
        #endregion


    }
}
