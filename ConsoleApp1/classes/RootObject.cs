namespace ConsoleApp1.classes
{
    public class RootObject
    {
         
        public ObjectWithArray ObjectWithArray { get; set; } = new ObjectWithArray();

        public ObjectWithArray ObjectWithArray2 => ObjectWithArray;
    }
}