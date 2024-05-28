using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantFis.Models.Domain.Models
{
    internal class Preambalat : Produs
    {
        private DateTime dataExpirare;

        public Preambalat(DateTime dataExpirare)
        {
            this.dataExpirare = dataExpirare;
        }
        public Preambalat() : base() { }

        public DateTime DataExpirare { get => dataExpirare; set => dataExpirare = value; }
    }
}
