using System.Collections.Generic;

namespace PingPongGen
{
public class LeapYear
{
  public bool IsLeapYear (int year)
 {
  return year % 4 == 0;
}
}
}
//   public class PingPong
//   {
//
//     private int _id;
//     private static List <PingPong> _instances = new List <PingPong> {};
//
//     public PingPong ()
//     {
//
//       _instances.Add(this);
//       _id = _instances.Count;
//     }
//
//     // public int GetDaNumba()
//     // {
//     //   return _numba;
//     // }
//     public int GetId()
//     {
//       return _id;
//     }
//     public bool Return3(int inputnumber)
//     {
//       if (inputnumber == 3)
//       {
//         return true;
//       }
//     }

    // public string PingPongMethod(int number)
    // {
    //   int userNumber = this.GetDaNumba();
    //   List<string> changedValues = new List<string> {};
    //   for (var i = 1; i <= userNumber; i++)
    //   {
    //     // var PingPongRestults = new PingPong;
    //     // PingPongResults(i);
    //     if (i % 15 == 0)
    //     {
    //       changedValues[i] = int.ToString("PingPong");
    //     }
    //     else if (i % 3 == 0)
    //     {
    //       changedValues[i] = int.ToString("Ping");
    //     }
    //     else if (i % 5 == 0)
    //     {
    //       changedValues[i] = int.ToString("Pong");
    //     }
    //     else
    //     {
    //       changedValues[i] = int.ToString(i);
    //     }
      // }
