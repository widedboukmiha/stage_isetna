using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stage_isetna.Business
{
    class Users
    {
        public int Id { get; set; }
        public String Nom { get; set; }
        public String Prenom { get; set; }
        public String Mail { get; set; }
        public String Password { get; set; }
        public string Cin { get; internal set; }
        public string Login { get; internal set; }
    }
}
