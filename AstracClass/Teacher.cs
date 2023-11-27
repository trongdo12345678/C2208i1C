using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AstracClass;

//kế thừa sử dụng dấu :   
internal class Teacher : Human
{
    public override void ShowInfo() => Console.WriteLine("this'is teacher");
    
}
