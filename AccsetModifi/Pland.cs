using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccsetModifi;
internal class Pland
{
    private void Private() => Console.WriteLine("private");

    protected void Protected() => Console.WriteLine("Protected");

    internal void Internal()=> Console.WriteLine("internal");

    private protected void PrivateProtected() => Console.WriteLine("PrivateProtected");

    protected internal void ProtectedInternal() => Console.WriteLine("ProtectedInternal");

    public void Public() => Console.WriteLine("Public");
}
