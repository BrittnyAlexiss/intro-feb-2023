namespace CSharpSyntax
{
    public class CreatingAndInitializingTypes
    {
        [Fact]

        public void UsingLiteralsToCreateInstancesOfTypes()
        {


            string myName = "jeff";
            char me = 'a';

            bool isVendor = true;
            int myAge = 22;

            bool isLegalAgeToDrink = myAge >= 21;

            Taco food = new Taco();
            Assert.Equal("jeff", myName);
            Assert.Equal(22, myAge);
        }
    }

    public class Taco { }
}
