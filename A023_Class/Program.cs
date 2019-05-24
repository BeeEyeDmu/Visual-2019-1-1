using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A023_Class
{
  class CarP
  {
    public string Name { get; set; }
    public int Number { get; set; }
    public int Year { get; set; }

    public CarP()
    {
    }

    public CarP(string name, int number, int year)
    {
      Name = name;
      Number = number;
      Year = year;
    }

    public void Print()
    {
      Console.WriteLine("Name: {0}, Number:{1}, Year:{2}",
        Name, Number, Year);
    }
  }

  class Car
  {
    private string name;
    private int number;
    private int year;

    public void SetName(string s)
    {
      name = s;
    }
  }

  class Program
  {
    static void Main(string[] args)
    {
      Car car = new Car();
      car.SetName("audi");

      CarP x = new CarP();
      x.Name = "audi";
      x.Number = 1458;
      x.Year = 2015;

      CarP y = new CarP("benz", 7878, 2019);

      x.Print();
      y.Print();

      //Console.WriteLine("Name: {0}, Number:{1}, Year:{2}",
      //  x.Name, x.Number, x.Year);

    }
  }
}
