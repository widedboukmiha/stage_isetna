using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stage_isetna.Business
{
    class Type
    {
        public int Id { get; set; }
        public string Nom { get; set; }
        public override string ToString()
        {
            return Nom;
        }
    }
}
