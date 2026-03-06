using System;
using System.Collections.Generic;
using System.Text;
using API_CICD.Service;

namespace AdditionTest.Test
{
    public class Test()
    {
        [Fact]
        public void Addition() 
        { 
            //Arrange

            IAdditionService test = new AddService();
            int nb1 = 12;
            int nb2 = 30;

            int expected = 42;

            int actual = test.AdditionService(nb1, nb2);
        
            Assert.Equal(expected, actual);
        
        
        
        }

    }
}
