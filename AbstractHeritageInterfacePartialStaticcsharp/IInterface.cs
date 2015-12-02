namespace AbstractHeritageInterfacePartialStaticcsharp
{
    /// <summary>
    /// An interface is simply a plan (skeleton).
    /// A good image is : imagine an house. The plan of the house is the INTERFACE. The house is the CLASS which is based on the plan.
    /// So the interface provide an panel of properties and/or methods to impelment inside your class which is based on this interface.
    /// Note : public/private/... statement should not be provided (reason : useless actually)
    /// </summary>
    public interface IPlan
    {
        //Properties
        string Name { get; set; }
        int Height { get; set; }
        int RoomCount { get; set; }

        //Methods
        string GetPresentation();
    }

    /// <summary>
    /// This is the class which is based on our interface. 
    /// This is mandatory to implement each of properties and methods provided by the interface.
    /// </summary>
    public class House : IPlan
    {

        public string Name { get; set; }

        public int Height { get; set; }

        public int RoomCount { get; set; }

        public string GetPresentation()
        {
            return string.Format("The name of this house is : {0}, its height is : {1}, and contains {2} rooms.", Name,
                Height, RoomCount);
        }
    }
}
