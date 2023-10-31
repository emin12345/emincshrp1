int getsum (int target)
{
    int sum = 0;


    int number = 0;
    while(sum +number < target)
    {
        sum=sum+number;
        number++;
        
    }return sum;
}
Console.WriteLine(getsum(11));