namespace HandsOnCSharp6.AutoInitializers
{
    public class GetterOnly
    {
        //If you wanted to initalize a Getter Only Property in C# 5.0
        public string Name { get; private set; }

        //In C# 6.0 you can initlize a Getter Only Property right away
        public string Firstname { get; } = "John";

        public GetterOnly(string firstname)
        {
            Name = "Doe";
            Firstname = firstname;
        }
    }
}
