using Xunit;
using System;
using System.Collections.Generic;
namespace PingPongGen
{
  public class PingPongTest
  {
    public class PPGTest
    {
      [Fact]
      public void Test_Pingpong_Method1()
      {
        //Arrange
        int numba = 7;
        PingPong pg = new PingPong(numba);
        List<string> test1 = pg.GetAll();

        //Act
        List<string> testList = new List<string>{"1", "2", "Ping", "4", "Pong", "Ping", "7"};

        //Assert
        Assert.Equal(testList, test1);
      }
      public void Dispose()
      {
  PingPong.ClearAll();
      }
    }
  }
}
