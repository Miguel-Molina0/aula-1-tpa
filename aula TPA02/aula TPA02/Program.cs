double res;
double n1;
double n2;
int opc;

Console.WriteLine("digite o primeiro número");
n1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("");


Console.WriteLine("digite o segundo número");
n2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("");

Console.WriteLine("digite a operação que deseja");
Console.WriteLine("1 - soma     2 - subtração     3 - multiplicação     4 - divisão");
opc = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("");

if (opc == 1)
{
    res = n1 + n2;
    Console.WriteLine(res);
}

else if (opc == 2)
{
    res = n1 - n2;
    Console.WriteLine(res);
}

else if (opc == 3)
{
    res = n1 * n2;
    Console.WriteLine(res);
}

else if (opc == 4)
{
    res = n1 / n2;
    Console.WriteLine(res);
}

else
{
    Console.WriteLine("invalido");
}

