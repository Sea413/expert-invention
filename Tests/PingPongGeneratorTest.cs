using Xunit;
namespace PingPong
{
  public class PingPongTest
  {
    [Fact]
    public void IsPingPong_ForNumberDivisibleBy3_true()
    {
      PingPong testPingPong = new PingPong();
      Assert.Equal(true, testPingPong.PingPongMethod(3));
    }
  }
}
