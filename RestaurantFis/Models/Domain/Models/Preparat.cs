using RestaurantFis.Models.Domain.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantFis.Models.Domain.Models
{
    internal class Preparat : Produs
    {
        readonly List<Ingredient> ingrediente;

        public Preparat()
        {
            ingrediente = new List<Ingredient>();
        }

        public Preparat(string denumire, string descriere, double pret, StatusProdus statusProdus, DimensiuneProdus dimensiuneProdus) : base(denumire, descriere, pret, statusProdus, dimensiuneProdus)
        {
            ingrediente = new List<Ingredient>();
        }
        public Preparat(List<Ingredient> ingrediente, string denumire, string descriere, double pret, StatusProdus statusProdus, DimensiuneProdus dimensiuneProdus) : base(denumire, descriere, pret, statusProdus, dimensiuneProdus)
        {
            this.ingrediente = ingrediente;
        }
    }

}
