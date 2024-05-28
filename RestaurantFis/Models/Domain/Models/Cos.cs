using RestaurantFis.Models.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantFis.Models.Domain.Models
{
    internal class Cos : ICos
    {
        private List<ElementComanda> elemente;

        public Cos()
        {
            elemente = new List<ElementComanda>();
        }

        internal List<ElementComanda> Elemente { get => elemente; set => elemente = value; }

        public bool actualizareCantitate(ElementComanda element, int cantitate)
        {
            throw new NotImplementedException();
        }

        public bool adaugaElement(ElementComanda element)
        {
            throw new NotImplementedException();
        }

        public double calculeazaTotal()
        {
            throw new NotImplementedException();
        }

        public bool eliminaElement(ElementComanda element)
        {
            throw new NotImplementedException();
        }
    }
}
