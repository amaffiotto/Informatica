namespace Andrea_Maffiotto_Modulo_3;

public static class NumeriUtility
{
    public static int Quadrato(int n)
    {
        return n * n;
    }

    public static bool IsPari(int n)
    {
        return n % 2 == 0;
    }

    public static int FindMax(int a, int b)
    {
        if (a > b)
        {
            return a;
        }
        else
        {
            return b;
        }
    }
}