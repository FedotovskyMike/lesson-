int Max(int arg1, int arg2, int arg3)
{
    int result = arg1;
    if(arg2 > result) result = arg2;
    if(arg3 > result) result = arg3;
    return result;
}

int a1 = 10;
int a2 = 25;
int a3 = 3534;
int b1 = 55;
int b2 = 67;
int b3 = 98;
int c1 = 36;
int c2 = 75;
int c3 = 63560;

int max1 = Max(a1, b1, c1);
int max2 = Max(a2, b2, c2);
int max3 = Max(a3, b3, c3);
int max = Max(max1, max2, max3);


Console.WriteLine(max);


