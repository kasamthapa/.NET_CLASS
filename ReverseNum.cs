using System;

int num = 15;
int reverse=0;
int rem =0;
while(num>0){
    rem=num%10;
    reverse =reverse*10+rem;
    num=num/10;
}
Console.WriteLine(reverse);