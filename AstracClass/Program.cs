using AstracClass;
using System.Text;

//1 calss astrac không thể khởi tạo đối tượng

Console.InputEncoding = System.Text.Encoding.UTF8;
Console.OutputEncoding = System.Text.Encoding.UTF8;

Teacher tea = new()

{
    Fullname = "trọng đỗ",
    age = 20
};
tea.ShowInfo();
Console.WriteLine(tea);
