using System;

public struct Distance {
    public int feet;
    public int inches;

    public void Print() {
        Console.WriteLine("{0}' - {1}''", feet, inches);
    }
}
class Program {
    static void Main() {

        Distance d1, d2, d3;
        var input = Console.ReadLine().Split();
        d1.feet = int.Parse(input[0]);
        d1.inches = int.Parse(input[1]);
        input = Console.ReadLine().Split();
        d2.feet = int.Parse(input[0]);
        d2.inches = int.Parse(input[1]);
        d3.inches = (d1.feet + d2.feet) * 12 + d1.inches + d2.inches;
        d3.feet = (int) (d3.inches / 12);
        d3.inches = d3.inches % 12;
        d3.Print();
    }
}
