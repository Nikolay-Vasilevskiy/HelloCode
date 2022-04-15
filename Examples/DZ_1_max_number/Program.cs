int a = 1;
int b = 2;

int max = a;
int min = a;

if(a > max ) max = a;
if(b > max ) max = b;

if(a < min ) min = a;
if(b < min ) min = b;

Console.Write("max = ");
Console.WriteLine(max);

Console.Write("min = ");
Console.WriteLine(min);