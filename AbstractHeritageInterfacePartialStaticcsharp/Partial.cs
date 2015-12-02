namespace AbstractHeritageInterfacePartialStaticcsharp
{
    /// <summary>
    /// First partial class
    /// </summary>
    public partial class BigClass
    {
        public int Value1 { get; set; }
    }

    /// <summary>
    /// Second partial class
    /// </summary>
    public partial class BigClass
    {
        public int Value2 { get; set; }
    }


    /// <summary>
    /// Third partial class
    /// </summary>
    public partial class BigClass
    {
        public int Value3 { get; set; }
    }

    /// <summary>
    /// Partial feature enable us to split a class in multiple part. 
    /// </summary>
    public class TestBigClass
    {
        public string ReturnAllValues()
        {
            var myBigClass = new BigClass();
            return string.Format("Value1 is : {0} and Value2 is : {1} and Value3 is : {2}", myBigClass.Value1, myBigClass.Value2, myBigClass.Value3);
        }
    }

}
