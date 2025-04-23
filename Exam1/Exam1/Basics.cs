 namespace Exam1;
 public class Q1_Add
 {

     public int m_x; 
     public int m_y;
     Q1_Add(int x , int y )
     {
         m_x = x;
         m_y = y;
     }
     public static int Add(int x , int y)
     {
        int sum = x + y;
        return sum;
     }
 };

public class Basics
{
    public int m_v;
    public int m_f;
    Basics(int v , int f)
    {
        m_v = v;
        m_f = f;
    }
    Basics()
    {
    }

    public static void Q2MultiplyAndReset(ref int v, ref int f)
    {
        v = v * f;
        f = 1;
    }

    /*
    public static void Q5TryCatchFinally(bool x , List<string> log)
    {
        if (x!) {var log = new[] { "Try", "AfterTry", "Finally" } }
    } */
};

public struct Type1
{
    public int Count;

};

public class Type2
{
    public int Count;


};
/*
public class Type1
{
    public int Count;

};

public class Type2
{
    public int Count;
    public Type2()
    {
        object o = count;

    }
    ~Type2()
    {
        int count = (int) o;
    }


}; */


public class Q4Person
{
    public string Name;
    public int Age;
    public Q4Person(string n , int a )
    {
        Name = n;
        Age = a;
    }
    public string Introduce()
    {
        string str = $"Hello, my name is {Name} and I am {Age} years old.";
        return str;
    }



};

/*
public class Q6Temperature()
{
    public double Celsius { get { return this.Celsius; } set { this.Celsius = (Fahrenheit - 32) * 5 / 9; } }
    public double Fahrenheit { get { return this.Fahrenheit; } set { this.Fahrenheit = (Celsius*9/5) + 32; } }

    
};
*/



public class Q7Circle :IShape
{
    public double r;
    public Q7Circle(double a)
    {
        this.r = a;
    }
    public double GetArea()
    {
        return Math.PI * r * r;
    }
    public double GetPerimeter()
    {
        return Math.PI * 2 * r;
    }
};

public class Q7Rectangle :IShape
{

    public double x;
    public double y;

    public Q7Rectangle(double a , double b)
    {
        this.x = a;
        this.y = b;
    }
    public double GetArea()
    {
        return x*y;
    }
    public double GetPerimeter()
    {
        return 2* x + 2* y;
    }
};

public interface IShape 
{
    public double GetArea();
    public double GetPerimeter();
};

public class ShapeUtils
{
    public static double Q7TotalArea(IShape[] shapes)
    {
        double total = 0;
        foreach (IShape shape in shapes)
        {
            total += shape.GetArea();
        }
        return total;

    }


}; 
