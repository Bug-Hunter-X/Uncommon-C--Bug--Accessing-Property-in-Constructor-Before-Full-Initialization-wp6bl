public class ExampleClass
{
    public int MyProperty { get; set; }

    public ExampleClass(int value)
    {
        MyProperty = value;
    }

    public void MyMethod()
    {
        // Accessing a property in a constructor before it's fully initialized.
        // This is a common issue that can sometimes lead to unexpected behavior.
        Console.WriteLine(MyProperty); 
    }
}