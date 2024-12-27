public class ExampleClass
{
    private int _value;

    public int Value
    {
        get { return _value; }
        set { _value = value; }
    }

    public void DoSomething()
    {
        int x = Value; // Accessing the Value property
        // ... some code that modifies x
        Value = x; // Modifying the Value property
    }
}