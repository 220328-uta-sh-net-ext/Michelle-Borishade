using Xunit;

namespace MBFancyTest
{
    public class UnitTest1
    {
        [Fact(Skip = "Skip this test for now")]  //always true, tests invariant conditions
        public void Test1()  /*Give it a value to test
                                create a dependecncy because files cannot see w/o access*/
        {
            //arrange
            int package = 8;
            int size = 10;
            int num = 7;
            string store = "Grocery";
            string name = "Mickie";
            

            //act
            int cabinet = package + size;

            //assert
            Assert.True(num != cabinet);
            
            Assert.False(num == cabinet);
            
           // Assert.Equal(package, size);
            
           // Assert.NotEqual(package, size);



        }
    }
}