using System;

class SimpleTimer
{
   private DateTime timestart;
   public TimeSpan timer() {
      timestart = DateTime.Now;
      Timer t = new Timer(TimerCallback, null, 0, 1000);
      Console.ReadLine();
      t.Dispose();
      TimeSpan dt = DateTime.Now - timestart;
      return dt;
   }

   private void TimerCallback(Object o) {
      Console.Clear();
      TimeSpan dt = DateTime.Now - timestart;
      Console.WriteLine(dt.ToString(@"hh\:mm\:ss"));
   }
}