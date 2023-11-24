
using OPP;

//Student stu = new(1,"trongdo", true ,new DateTime(2003,04,01));
//object initializer = > class không cần tạo constroter làm gì
Student stu3 = new()
{
    Id = 1,
    Gender = false,
    FullName = "trọng",
    Dob = DateTime.Now
};
Console.WriteLine(stu3);



//Id là Property của stu

//stu.Id = 1; //set
//Console.WriteLine(stu.Id);
//stu.Fullname = "trọng Đỗ";
//Console.WriteLine(stu.Fullname);//get
//stu.Gender = true;
//Console.WriteLine(stu.Gender);
//stu.Dob = "01/01/2002";
//Console.WriteLine();
