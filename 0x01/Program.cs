// comment inline
/* comment
multi
line
*/

/* Console.Write("print with 'Console.Write'");
Console.WriteLine("print with 'Console.WriteLine'"); */

// Data types
// Integer types
byte myByte = 255;
Console.WriteLine(myByte);
sbyte mySbyte = -128;
Console.WriteLine(mySbyte);
short myShort = 32767;
Console.WriteLine(myShort);
ushort myUshort = 65535;
Console.WriteLine(myUshort);
int myInt = -2147483648;
Console.WriteLine(myInt);
uint myUint = 4294967295;
Console.WriteLine(myUint);
long myLong = -9223372036854775808L;
Console.WriteLine(myLong);
ulong myUlong = 18446744073709551615UL;
Console.WriteLine(myUlong);
// Floating point types
float myFloat = 3.14159F;
Console.WriteLine(myFloat);
double myDouble = 3.141592653589793;
Console.WriteLine(myDouble);
decimal myDecimal = 99.99M;
Console.WriteLine(myDecimal);
// Booleans
bool myBool = true;
Console.WriteLine(myBool);
// Characters
char myChar = 'A';
Console.WriteLine(myChar);
// Strings
string myString = "Hello, World!";
Console.WriteLine(myString);

// Variables
// Explicit
string myExplicitVariable = "works!";
Console.WriteLine(myExplicitVariable);

// Implicit, local and fix type
var myImplicitVariable = "works!";
Console.WriteLine(myImplicitVariable);

// Constant
const string myConstant = "works!";
Console.WriteLine(myConstant);

// Scope
string myGlobal = "I'm global";
Console.WriteLine(myGlobal);
{
  string myLocal = "I'm local";
  Console.WriteLine(myLocal);
  var myLocalVar = "I'm local with var";
  Console.WriteLine(myLocalVar);
  Console.WriteLine(myGlobal);
}

// Strings
string str1 = "Hello";
string str2 = "World";
// Concatenation
string strResult = str1 + str2;
Console.WriteLine(strResult);
Console.WriteLine(str1 + ", " + str2 + "!");
// Interpolation
strResult = $"{str1}, {str2}!!";
Console.WriteLine(strResult);
Console.WriteLine("{0}, Mundo!", str1);
Console.WriteLine("{0}, {1}.", str1, str2);

// Casting
// Implicit
int int1 = 10;
double double1 = int1;
Console.WriteLine(double1);
// Explicit
