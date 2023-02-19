int number;
string number_n;
Console.Write("Введите число: number  ");
number_n = Console.ReadLine();
number = Convert.ToInt32(number_n);

var fist = number/10000;
var second = number/1000 % 10;
var fourth = number/100 % 10;
var fith = number % 10;

if (fist == fith)
{
  if(second == fourth)
  {

  }
  Console.Write("Введенное число является палиндроном");
}
else
{
  Console.Write("Введенное число не является палиндроном");
}


