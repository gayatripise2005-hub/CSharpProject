using System;
using System.Xml.Serialization;



//Serilization in C# 
//1 Json 
//2 Binary 
//3 Xml 
// Custom


public static void Main(string[] args)
{
//  var cat = new
//  {
//      Name = "Test",
//      Age = 2,
//      Colur = "black",
//      arr =new int[] { 1,2,3,4},
//      names=new string[] { "mau", "Cau", "Chiu" }
//  };

//var fs=  File.Create("C:\\Test\\Abc.json");
//  JsonSerializer.Serialize(fs,cat);
//  fs.Flush();
//  fs.Close();

// var Json= File.ReadAllText("C:\\Test\\Student.json");

//JsonSerializer.Serialize(file,student);
//file.Flush();

//++++++++++++++++++++++++++

//Deserilize 
//string data= File.ReadAllText("C:\\Test\\Abc.json");
// Console.WriteLine(data);
// Console.WriteLine("+++++++++++++++++++++");
// var ob=JsonSerializer.Deserialize<Object>(data);
// Console.WriteLine(ob);
Student s = new Student()
{
Id = 1,
Name = "Raju"
};
XmlSerializer xmlSerializer = new XmlSerializer(typeof(Student));
FileStream fs = new FileStream("C://Test/b.xml", FileMode.OpenOrCreate, FileAccess.ReadWrite);
//xmlSerializer.Serialize(fs, s);
//fs.Flush();
//fs.Close();

var res = (Student)xmlSerializer.Deserialize(fs);
Console.WriteLine(res);
fs.Close();


}







}

public class Student
{
    public int Id { get; set; }
    public string Name { get; set; }
    //toString
    public override string ToString()
    {
        return $"Student [Id {Id},Name {Name}]";
    }
}