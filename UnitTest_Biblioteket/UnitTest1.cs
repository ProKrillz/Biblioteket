using Biblioteket;
namespace UnitTest_Biblioteket

{
    public class UnitTest1
    {
        
        [Fact]
        public void Test1()
        {
            string name = "Name", biblo = "test";
            int number = 1;
            Bibliotek b = new (biblo);
            b.OpretLaaner(number, name);

            Assert.True(b.HentLaaner(1) == $"L�nernummer: {number}\nNavn: {name}\nEr l�net hos: {biblo}");
            
        }

    }
}