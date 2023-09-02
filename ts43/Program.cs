
double Input(string msg)
{
    Console.WriteLine(msg);
 double res = Convert.ToDouble(Console.ReadLine());
 return res;
}

double b1=Input("Enter b1");
double k1=Input("Enter k1");
double b2=Input("Enter b2");
double k2=Input("Enter k2");
double x = -(b1 - b2) / (k1 - k2);
double y = k1 * x + b1;

Console.Write($" Cross point: [{x},{y}]");