using System;

class Program{
    static void Main(){
        SimpleClass simple = new SimpleClass();
        simple.x = 3;
        simple.y = 12;
        Console.WriteLine($"x = {simple.x} y = {simple.y}");
    }
}