class DerivedPoint : Point
{
  static void Main()
  {
    var dpoint = new DerivedPoint();

    dpoint.x = 10;
    dpoint.y = 15;
    Console.WriteLine($"X = {dpoint.x}, Y = {dpoint.y}");
  }  
}