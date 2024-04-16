public abstract class Transport
{
    public abstract double Speed { get; }
    public abstract double Load_capacity { get; }
    public abstract double Range { get; }
    public abstract void GetInfo();
}
public abstract class Car : Transport
{
    public override void GetInfo()
    {
        Console.WriteLine($"Машина с грузоподъемностью {Load_capacity} может проехать {Range} км.");
    }
}
public abstract class Aircraft : Transport
{
    public override void GetInfo()
    {
        Console.WriteLine($"Самолет с грузоподъемностью {Load_capacity} может пролететь {Range} км.");
    }
}
public abstract class Ship : Transport
{
    public override void GetInfo()
    {
        Console.WriteLine($"Корабль с грузоподъемностью {Load_capacity} может проплыть {Range} км.");
    }
}
public class Lada : Car
{
    public override double Speed => 180;
    public override double Load_capacity => 475;
    public override double Range => 550;
    public override void GetInfo()
    {
        Console.WriteLine($"Lada с грузоподъемностью {Load_capacity} может проплыть {Range} км.");
    }
}
public class Mig : Aircraft
{
    public override double Speed => 3000;
    public override double Load_capacity => 21820;
    public override double Range => 2500;
    public override void GetInfo()
    {
        Console.WriteLine($"Mig с грузоподъемностью {Load_capacity} может проплыть {Range} км.");
    }
}
public class Aurora : Ship
{
    public override double Speed => 38;
    public override double Load_capacity => 7600000;
    public override double Range => 7200;
    public override void GetInfo()
    {
        Console.WriteLine($"Avrora с грузоподъемностью {Load_capacity} может проплыть {Range} км.");
    }
}
class Program
{
    static void Main()
    {
        Lada lada = new Lada();
        lada.GetInfo();
        Mig mig = new Mig();
        mig.GetInfo();
        Aurora aurora = new Aurora();
        aurora.GetInfo();

    }
}