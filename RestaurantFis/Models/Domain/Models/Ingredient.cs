using RestaurantFis.Models.Domain.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantFis.Models.Domain.Models
{
    internal class Ingredient
    {
        private string denumire;
        private StilAlimentar stilAlimentar;

        public Ingredient(string denumire, StilAlimentar stilAlimentar)
        {
            this.denumire = denumire;
            this.stilAlimentar = stilAlimentar;
        }

        public string Denumire { get => denumire; set => denumire = value; }
    }
}
