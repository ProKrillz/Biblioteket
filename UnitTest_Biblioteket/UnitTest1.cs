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
            Bibliotek b = new (biblo);
            b.OpretLaaner(name, email);

            Assert.True(b.HentLaaner(1) == $"Lånernummer: {number}\nNavn: {name}\nEmail: {email}\nEr lånet hos: {biblo}");
            
        }

    }
}