class single
{
    private static single me;
    public int a;
    private single()
    {
        a = 5;
    }

    public static single getinstance()
    {
        if(me == null)
        {
            me = new single();
        }
        return me;
    } 

    public void PrintA()
    {
        System.Console.WriteLine(a);
    }
}