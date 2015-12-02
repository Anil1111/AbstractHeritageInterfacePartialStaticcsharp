namespace AbstractHeritageInterfacePartialStaticcsharp
{
    /// <summary>
    /// This is a mother class which contains properties and methods which will be provided to its children.
    /// Note : we are able to declare not only public element but also private, ...
    /// </summary>
    public class Animal
    {
        //Properties
        public string Name { get; set; }
        public int Age { get; set; }
        public string AnimalNoise { get; set; }

        //Methods
        public string GetAnimalNoise()
        {
            return AnimalNoise + GetExclamationPoints();
        }

        private string GetExclamationPoints()
        {
            return "!!!";
        }
    }

    /// <summary>
    /// This is a simple child class which use mother class methods and properties.
    /// Note : same way than interface to use it BUT this is a simple class not an interface
    /// </summary>
    public class Cat : Animal
    {
        public string DescribeMyCat()
        {
            return string.Format("This is a cute {0}, which is {1} years old and his cry is : {2}", Name, Age,
                GetAnimalNoise());
        }
    }
}
