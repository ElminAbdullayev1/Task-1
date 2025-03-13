#region Task1
/*int[] arr = { 1, 2, 3, 4, 5 };
Console.WriteLine("Reqem yaz!");
int n = Convert.ToInt32(Console.ReadLine());

bool BoyukOlanda = false;
foreach (int num in arr)
{
    if (n > num)
    {
        BoyukOlanda = true;
        break;
    }
}
Console.WriteLine(BoyukOlanda);
*/
#endregion
#region Task2
/*int[] arr = { 1, 2, 3, 4, 5 };
int BoyukReqem = arr[0];
for (int i = 0; i < arr.Length; i++)
{
    if (BoyukReqem < arr[i])
    {
        BoyukReqem = arr[i];
    }
}
Console.WriteLine(BoyukReqem);
*/
#endregion
#region Task3
/*Console.WriteLine("Reqem yaz");
int pol = int.Parse(Console.ReadLine());
int qaliq;
int ters = 0;
while (pol != 0)
{
    qaliq = pol % 10;
    ters = ters * 10 + qaliq;
    pol -= qaliq;
    pol = pol /= 10;
}
Console.WriteLine(ters);*/
#endregion
#region Task4
/*{
    Console.Write("Faktorialı ededi yaz bura ");
    int num = int.Parse(Console.ReadLine());

    long factorial = Faktorial(num);
    Console.WriteLine($"{num}! = {factorial}");
}

static long Faktorial(int n)
{
    if (n == 0 || n == 1)
        return 1;
    return n * Faktorial(n - 1);
}
*/
#endregion
#region Task5
/*Console.WriteLine("Reqem yaz");
int n = int.Parse(Console.ReadLine());
int hasil = 1;
int qaliq;
while ( n > 0)
    {
    qaliq = n % 10;
    hasil *= qaliq;
    n /= 10;
}
Console.WriteLine(hasil);*/
#endregion
#region Task6
/*Console.WriteLine("Reqem yaz");
int reqem = int.Parse(Console.ReadLine());
if (reqem <= 1) 
{
    Console.WriteLine("Sadedi yoxsa Murekkeb?");
}
else
{
    Console.WriteLine(reqem);
}
for (int i = 2; i < reqem; i++)
    {
        if (reqem % i == 0)
        {
            Console.WriteLine("Murekkeb");
            break;
        }
        else
        {
            Console.WriteLine("Sade");
            break;
        }
    }*/
#endregion
#region Task7
/*Console.WriteLine("Sozuvu yaz");
string[] sozler = {"Aztu", "Salam", "Dunya", "Balaca", "Code"};
string axtardiginSoz = Console.ReadLine();
bool tapildi = false;
foreach (string soz in sozler)
{
    if (soz == axtardiginSoz)
    {
        tapildi = true;
        break;
    }
}
Console.WriteLine(tapildi);*/
#endregion
#region Task8
/*Console.WriteLine("Soz yaz");
string soz = Console.ReadLine();
Console.WriteLine("Herf yaz");
char herf = char.Parse(Console.ReadLine());
bool HerfVar = false;
foreach (char c in soz)
{
    if (c == herf)
    {
        HerfVar= true;
    }
}
Console.WriteLine(HerfVar);*/
#endregion
#region Task9
/*Console.WriteLine("Soz yaz");
string soz = Console.ReadLine();
string tersSoz = "";
bool Xetali = false;
for (int i = soz.Length - 1; i >= 0; i--)
{
    if (!Xetali)
    {
        tersSoz += soz[i];
    }
}
Console.WriteLine(tersSoz);*/
#endregion
#region Task10
/*Console.WriteLine("Cumle  yaz");
string daxilEt = Console.ReadLine();
string[] sozler = daxilEt.Split(' ');
string tersSoz = "";
for (int i = sozler.Length - 1; i >= 0; i--)
{
    tersSoz += sozler[i] + " ";
}
Console.WriteLine(tersSoz);*/
#endregion