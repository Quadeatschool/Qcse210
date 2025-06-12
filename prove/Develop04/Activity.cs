public class Activity
{
    private int _duration;
    private string _startingMessage;
    private string _endingMessage;
    private string _descrbition;

    private DateTime _EndTime;

    //--------------------------------------
    public Activity(int _duration, string _startingMessage, string _endingMessage, string _descrbition, DateTime _EndTime)
    {
        int Duration = _duration;
        string StartingMessage = _startingMessage;
        string EndingMessage = _endingMessage;
        string descrbition = _descrbition;
        DateTime EndTime = _EndTime;


    }
    public void Spinner()
    {
        int sleepTime = 250;

                DateTime currentTime = DateTime.Now;
                DateTime endTime = currentTime.AddSeconds(20);

               

                string animationString = "-\\/|\\/";
                int index = 0;
                while (DateTime.Now < endTime)
                {
                    Console.Write(animationString[index++ % animationString.Length]);
                    // % in this case keeps the loop going 0-4
                    Thread.Sleep(sleepTime);
                    Console.Write("\b");

                    // if two digit time then add an if with another \b
                }

                int time = 9;
                int count = time;

                while (DateTime.Now < endTime)
                {
                    Console.Write(count--);
                    Thread.Sleep(1000);
                    Console.Write("\b");

                    // if two digit time then add an if with another \b
                }


                while (DateTime.Now < endTime)
                {

                    Console.Write(animationString[0..5]);
                    Thread.Sleep(500);
                    Console.WriteLine(" . ");
                    Console.Write("+");
                    Thread.Sleep(sleepTime);
                    Console.Write("\b");
                    Console.Write(animationString);
                    Console.Write("-");
                    Thread.Sleep(sleepTime);
                    Console.Write("\b");
                }
            }

    }

   public DateTime Timer(DateTime endtime, int duration)
{
    
   }

    public bool TimerEnded()
{
    // While(_duration = 0)
    return false;
}

    public void StartTime()
{

}
}

