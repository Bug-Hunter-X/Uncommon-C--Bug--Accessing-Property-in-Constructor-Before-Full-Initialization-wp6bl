public class ExampleClass
{
    public int MyProperty { get; set; }

    public ExampleClass(int value)
    {
        InitializeProperty(value);
        Console.WriteLine(MyProperty); // Now it's safe
    }

    private void InitializeProperty(int value)
    {
        MyProperty = value;  // Ensure complete initialization before accessing
    }

    public void MyMethod()
    {
        // Accessing the property here is fine since it's been properly initialized
        Console.WriteLine(MyProperty);
    }
}