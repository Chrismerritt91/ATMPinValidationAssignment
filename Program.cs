class DebitCard
{

    private string _pin;

    public string Pin
    {
        get
        {
            return _pin;
        }
        set
        {
            if (value == null || value == "")
            {
                Console.WriteLine("Input Cannot Be Blank");
            }
            else
            {
                bool b = int.TryParse(value, out int i);
                if (b == false)
                {
                    _pin = "Invalid";
                }
                else
                {
                    if (value.Length == 4 || value.Length == 6)
                    {
                        _pin = value;
                    }
                    else
                    {
                        _pin = "Invalid";
                    }
                }
            }


        }
    }

}

class program
{

    static void Main()
    {

        DebitCard d = new DebitCard();

        d.Pin = "1234";
        Console.WriteLine(d.Pin);
        d.Pin = "1234ef";
        Console.WriteLine(d.Pin);
        d.Pin = "123456";
        Console.WriteLine(d.Pin);
        d.Pin = "0";
        Console.WriteLine(d.Pin);
        d.Pin = "a4";
        Console.WriteLine(d.Pin);
        d.Pin = null;
        Console.WriteLine(d.Pin);
        Console.ReadKey();

    }

}