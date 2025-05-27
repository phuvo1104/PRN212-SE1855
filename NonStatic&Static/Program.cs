using System.Transactions;

static int sum(int a, int b)
{
    return a + b;

}
void callsum()
{
   int s=sum(3,6);

}
double average(int a, int b)
{
    return (a + b)/2;
}
    
static void callaverage()
{
    double d = average(3, 6);
}