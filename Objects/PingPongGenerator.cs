using System.Collections.Generic;

namespace PingPongGen
{

  public class PingPong
  {
    private int _numba;
    private int _id;
    private static List<string> _instances = new List<string> {};

    public PingPong(int numba)
    {
      _numba = numba;
      for (int i = 1; i <= numba; i++)
      {
        if (i % 15 == 0)
        {
          _instances.Add("PingPong");
        }
        else if (i % 3 == 0)
        {
          _instances.Add("Ping");
        }
        else if (i % 5 == 0)
        {
          _instances.Add("Pong");
        }
        else
        {
          _instances.Add(i.ToString());
        }
      }
    }
        public List<string> GetAll()
        {
          return _instances;
        }
        public static void ClearAll()
        {
   _instances.Clear();
        }

  }
}
