using AccsetModifi;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessModifyCont;
internal class Weed : Pland
{
    #region Test
    static void Main(string[] args)
    {
        Weed we = new();
        we.Public();
        we.Protected();
        we.ProtectedInternal();

        Pland pla = new();
        pla.Public();

    }
    #endregion

}
