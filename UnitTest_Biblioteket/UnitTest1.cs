using Biblioteket;

namespace UnitTest_Biblioteket

{
    public class UnitTest1
    {     
        [Fact]
        public void Test1()
        {
            string name = "Name", biblo = "test", email = "email";
            int number = 1;
            Bibliotek b = new Bibliotek (biblo);
            b.OpretLaaner(name, email);

            Assert.True(b.HentLaaner(number) == $"L?nernummer: {number}\nNavn: {name}\nEmail: {email}\nEr l?net hos: {biblo}");           
        }
    }
}