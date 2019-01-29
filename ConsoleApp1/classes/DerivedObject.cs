namespace ConsoleApp1.classes
{
    public class DerivedObject : BaseObject
    {
         
        public DerivedObjectWithArray DerivedObjectWithArray { get; set; } = new DerivedObjectWithArray();

        public override ObjectWithArray ObjectWithArray => DerivedObjectWithArray;
    }
}