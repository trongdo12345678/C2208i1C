using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalsPoly;
internal class AdvMath : BasicMath
{
    public override void Divide()
    {
        try 
        {
            Console.WriteLine(NumberOne / NumberTwo);

        } catch (Exception ex) when (NumberTwo==0)
        {
            Console.WriteLine("numbertow pHẢI KHÁC 0");
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }


    }
}
