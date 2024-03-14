using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mdiproject.dbinfo
{
    internal class Users
    {
        public int IDX { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public String Addr { get; set; }

        public override string ToString()
        {
            return base.ToString() +$" IDX = {IDX}  \n"+
                                    $" NAME = {Name}  \n" +
                                    $" PASSWORD = {Password}  \n" +
                                    $" EMAIL = {Email}  \n" +
                                    $" ADDR = {Addr}";
        }
    }
}
