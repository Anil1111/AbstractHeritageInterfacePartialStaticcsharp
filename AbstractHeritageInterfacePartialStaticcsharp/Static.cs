namespace AbstractHeritageInterfacePartialStaticcsharp
{
    /// <summary>
    /// The interest of a static class is to provide methods and/or properties without instantiate the class.
    /// Note : 
    /// - a method/propertyy could be static inside non-static class
    /// - if a class is static, all its method and properties need to be static
    /// </summary>
    public static class Static
    {
        //Property
        public static int Value { get; set; }

        //Method
        public static int GetValue()
        {
            return Value;
        }
    }

    /// <summary>
    /// Here we didn't instantiate Static class
    /// </summary>
    public class StaticTest
    {
        public string GetValue()
        {
            return Static.GetValue().ToString();
        }
    }
}
