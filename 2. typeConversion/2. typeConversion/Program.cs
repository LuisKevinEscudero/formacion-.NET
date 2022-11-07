byte b = 1;
int i = b;
Console.WriteLine(i);

int x = 1;
byte y = (byte)x;
Console.WriteLine(y);

var number = "1234";
int a = Convert.ToInt32(number);
Console.WriteLine(a);

try
{
	var n = "32213";
	byte d = Convert.ToByte(n);
	Console.WriteLine(n);
}
catch (Exception)
{
	Console.WriteLine("the number can not converted to a byte");
}

try
{
	string s = "true";
	bool r = Convert.ToBoolean(s);
	Console.WriteLine(s);
}
catch (Exception)
{
	Console.WriteLine("ERROR LOCOO!");
}
