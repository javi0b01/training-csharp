// Single-line comments
/* Multi-line
comments
*/

// Built-in Methods
// Input | Output
/* string input1 = Console.ReadLine();
Console.WriteLine(input1); */
/* Console.Write("print with 'Console.Write'");
Console.WriteLine("print with 'Console.WriteLine'"); */

// Data types
// Integer types
/* byte myByte = 255;
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
Console.WriteLine(myUlong); */
// Floating point types
/* float myFloat = 3.14159F;
Console.WriteLine(myFloat);
double myDouble = 3.141592653589793;
Console.WriteLine(myDouble);
decimal myDecimal = 99.99M;
Console.WriteLine(myDecimal); */
// Booleans
/* bool myBool = true;
Console.WriteLine(myBool); */
// Characters
/* char myChar = 'A';
Console.WriteLine(myChar); */
// Strings
/* string myString = "Hello, World!";
Console.WriteLine(myString); */

// Variables
// Explicit
/* string myExplicitVariable = "works!";
Console.WriteLine(myExplicitVariable); */

// Implicit, local and fix type
/* var myImplicitVariable = "works!";
Console.WriteLine(myImplicitVariable); */

// Constant
/* const string myConstant = "works!";
Console.WriteLine(myConstant); */

// Scope
/* string myGlobal = "I'm global";
Console.WriteLine(myGlobal);
{
  string myLocal = "I'm local";
  Console.WriteLine(myLocal);
  var myLocalVar = "I'm local with var";
  Console.WriteLine(myLocalVar);
  Console.WriteLine(myGlobal);
} */

// Strings
/* string str1 = "Hello";
string str2 = "World"; */
// Concatenation
/* string strResult = str1 + str2;
Console.WriteLine(strResult);
Console.WriteLine(str1 + ", " + str2 + "!"); */
// Interpolation
/* strResult = $"{str1}, {str2}!!";
Console.WriteLine(strResult);
Console.WriteLine("{0}, Mundo!", str1);
Console.WriteLine("{0}, {1}.", str1, str2); */

// Casting
// Implicit (automatically)
/* int int1 = 10;
double double1 = int1;
Console.WriteLine(double1); */
// Explicit (manually)
/* double double2 = 10.5;
int int2 = (int)double2;
Console.WriteLine(int2);
string? inputAge = Console.ReadLine();
int age = 0;
if (!string.IsNullOrEmpty(inputAge))
{
    age = int.Parse(inputAge);
}
else
{
    Console.WriteLine("Input was null or empty. Defaulting age to 0.");
}
Console.WriteLine(age); */

// Operators
// Assignment
/* int num = 10;
Console.WriteLine(num);
num += 5;
Console.WriteLine(num);
num -= 5;
Console.WriteLine(num);
num *= 5;
Console.WriteLine(num);
num /= 5;
Console.WriteLine(num);
num %= 5;
Console.WriteLine(num);
num = 10;
Console.WriteLine(num);
num &= 5;// (only bits that are 1 in both numbers stay 1)
Console.WriteLine(num);
num = 10;
Console.WriteLine(num);
num |= 5;// (bits that are 1 in either number become 1)
Console.WriteLine(num);
num = 10;
Console.WriteLine(num);
num ^= 5;// (bits that differ become 1)
Console.WriteLine(num);
num = 10;
Console.WriteLine(num);
num >>= 5;// Right shifting by 5 bits discards all bits, leaving 0
Console.WriteLine(num);
num = 10;
Console.WriteLine(num);
num <<= 5;// Left shifting multiplies the number
Console.WriteLine(num); */

// Concatenation
/* string str1 = "Hello";
string str2 = "World";
Console.WriteLine(str1 + ", " + str2 + "!"); */

// Arithmetic
/* double num1 = 10;
double num2 = 5;
double doubleResult = num1 + num2;
Console.WriteLine(doubleResult);
doubleResult = num1 - num2;
Console.WriteLine(doubleResult);
doubleResult = num1 * num2;
Console.WriteLine(doubleResult);
doubleResult = num1 / num2;
Console.WriteLine(doubleResult);
doubleResult = num1 % num2;
Console.WriteLine(doubleResult);
int num = 1;
Console.WriteLine(num);
num++;
Console.WriteLine(num);
num--;
Console.WriteLine(num); */

// Comparison
/* int num1 = 10;
int num2 = 5;
bool result = num1 == num2;
Console.WriteLine(result);
result = num1 != num2;
Console.WriteLine(result);
result = num1 > num2;
Console.WriteLine(result);
result = num1 < num2;
Console.WriteLine(result);
result = num1 >= num2;
Console.WriteLine(result);
result = num1 <= num2;
Console.WriteLine(result); */

// Logical
/* int num1 = 10;
int num2 = 5;
bool result = num1 < 1 && num2 < 50;
Console.WriteLine(result);
result = num1 < 1 || num2 < 50;
Console.WriteLine(result);
result = !result;
Console.WriteLine(result); */
