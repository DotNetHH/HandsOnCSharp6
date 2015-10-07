namespace HandsOnCSharp6.AutoInitializers
{
    public class AutoProperty
    {
        //In C# 5.0 you were not able to initalize the AutoProperty
        public string Name { get; set; }

        //This is how you can now initialize AutoProperties
        public string Firstname { get; set; } = "John";

        public AutoProperty()
        {
            Name = "Doe";
        }
    }
}
