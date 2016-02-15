using System.Collections.Generic;

namespace PingPong.Objects
{
  public class PingPong
  {
    private int _numbas;
    private int _id;
    private static List <PingPong> _instances = new List <PingPong> {};

    public PingPong (int numbers)
    {
      _numbas = numbers;
      _instances.Add(this);
      _id = _instances.Count;
    }

    public int GetDaNumbas()
    {
      return _numbas;
    }
    public int GetId()
    {
      return _id;
    }
    public static PingPongMethod(ourNumber)
    {
      for (var i = 0; ourNumber; i++)
      {
        if (i % 15 == 0)
        {
          return "PingPong";
        }
        else if (i % 3 == 0)
        {
          return "Ping";
        }
        else if (i % 5 == 0)
        {
          return "Pong";
        }
        else
        {
          return i;
        }
      }
    }
  }
}
