using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AstracClass;
internal abstract class Human
{
    public string? Fullname { get; set; }
    public int? age { get; set; }

    public abstract void ShowInfo();

    public override string ToString()
    {
        return $"{{{nameof(Fullname)}={Fullname}, {nameof(age)}={age.ToString()}}}";
    }
}
