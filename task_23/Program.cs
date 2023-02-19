/*задача 23
Первый способ

int N;
int i = 1;
string line_N;

Console.WriteLine("Введите число: N:  ");
line_N = Console.ReadLine();
N = Convert.ToInt32(line_N);

while (N >= i)
{
Console.Write(Math.Pow(i, 3) + "    ");
i = i + 1;
}
*/
//Второй способ

int N;
string line_N;

Console.WriteLine("Введите число: N:  ");
line_N = Console.ReadLine();
N = Convert.ToInt32(line_N);

for (int i = 1; i <= N; i++)
{
  Console.Write(Math.Pow(i, 3) + "\t");
}