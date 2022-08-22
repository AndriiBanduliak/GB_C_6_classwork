using static System.Console;
using System.Linq;
Clear();
WriteLine("Enter the number :");

int num = int.Parse(ReadLine()!);
WriteLine(Convert.ToString(num,8));
WriteLine(GetNum1(num));
WriteLine(DecToNum(num,8));


string GetNum1(int number)
{
    string result="";

    while(number>0)
    {
        result=number%8+result;
        number/=8;
    }
    return result;
}

string DecToNum(int decNumber, int otherSystem)
{
    string res="";
    string nums="0123456789ABCDEF";
    while(decNumber>0)
    {
        int ost=decNumber/otherSystem;
        res=nums[decNumber-otherSystem*ost]+res;
        decNumber/=otherSystem;
    }
    return res;
}