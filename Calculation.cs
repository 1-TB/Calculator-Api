namespace CalculatorAPI;

public class Calculation {
 public double first {get; set;}
 public double next {get; set;}
 public string type {get; set;}
 public double result {get; set;}
}
public static class Calc {

    public static double Add(double first, double next)
    {
        return first+next;
    }
    public static double Subtract(double first,double next)
    {
        return first-next;
    }
    public static double Multiply(double first, double next)
    {
        return first * next;
    }
    public static double Divide(double first, double next)
    {
        return first/next;
    }

}