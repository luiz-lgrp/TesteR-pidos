Calc calc = new Calc();
var resultado = calc.fatorial(5);

Console.WriteLine(resultado);

class Calc
{
	public int fatorial(int n)
	{
		int res;
		if (n <= 1)
			res = 1;
		else
			res = fatorial(n - 1) * n;

		return res;
	}	
}


//int factorial(int n)
//{
//    if (n <= 1)
//    {
//        return 1;
//    }
//    else
//    {
//        return factorial(n - 1) * n;
//    }
//}