using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OPP;
internal class Student
{


    #region code co ban
    //internal class Student
    //{
    //    //các field
    //    int id;
    //    string? fullname;
    //    //tự các field sec thành luôn thuộc tính
    //    public bool Gender { get; set; } //=> auto property phải là public
    //    public DateTime Dob { get; set; }//=> auto property cách này dùng để đi làm


    //    public void Hi()
    //    {
    //        id = 1;
    //        Console.WriteLine(id);
    //        Gender = true;
    //        Console.WriteLine(Gender);
    //    }

    //    //constructor nhấn chuột phải chọn ddầu tiên để khai báo constructor
    //    public Student() { }

    //    public Student(int id, string? fullname, bool gender, DateTime dob)
    //    {
    //        this.Id = id;
    //        this.Fullname = fullname;
    //        this.Gender = gender;
    //        this.Dob = dob;
    //    }

    //    //cấc property 
    //    //khác với java c# có cách viết riêng mà không dùng get set như java

    //    public int Id
    //    {
    //        get { return id; }
    //        set { id = value; }
    //    }
    //    public string? Fullname // cái style này dùng để viết mobile
    //    {
    //        get => fullname;
    //        set => fullname = value;
    //    }

    //    public override string? ToString()
    //    {
    //        return base.ToString();
    //    }
    //}

    #endregion


    public int Id { get; set; }
    public string FullName { get; set; }
    public bool Gender { get; set; }
    public DateTime Dob { get; set; }

    //có thể không dùng contructer
    //public Student() { }

    //public Student(int id, string fullName, int gender, DateTime dob)
    //{
    //    Id = id;
    //    FullName = fullName;
    //    Gender = gender;
    //    Dob = dob;
    //}

    public override string ToString()
    {
        return $"{{{nameof(Id)}={Id.ToString()}, {nameof(FullName)}={FullName}, {nameof(Gender)}={Gender.ToString()}, {nameof(Dob)}={Dob.ToString()}}}";
    }
}