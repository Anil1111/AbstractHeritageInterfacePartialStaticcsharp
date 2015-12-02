namespace AbstractHeritageInterfacePartialStaticcsharp
{
    /// <summary>
    /// Abstract feature is a combination of heritage and interface.
    /// Actually, thanks to abstract we are able to define serveral methods/properties and implement them.
    /// Inside our class which will use this abstract class, we will be able to :
    /// - execute and use methods and properties alread define inside abstract class OR
    /// - override the code of abstract methods not implemented (mandatory actually, like an interface)
    /// We are also able to declare private methods like for heritage
    /// </summary>
    public abstract class Vehicles
    {
        //Properties
        public string Brandname { get; set; }
        private const int SteeringWheelCount = 1;

        //Simple Method
        public int GetSteeringWheelCount()
        {
            return SteeringWheelCount;
        }

        //Abstract method (not implemented here)
        public abstract string DescribeVehicles();
    }

    /// <summary>
    /// Here, a simple example which use our abstract class
    /// It was mandatory to implement abstract method define inside our abstract class
    /// </summary>
    public class Porsche : Vehicles
    {
        public override string DescribeVehicles()
        {
            return string.Format("This a {0}, with {1} steering wheel", Brandname, GetSteeringWheelCount());
        }
    }

}
