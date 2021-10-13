using System;

namespace MoodAnalyserAssignment
{
    public class MoodAnalyser
    {
        static void Main(string[] args)
        {
         
        }

      
        string message;
        public MoodAnalyser(string message)
        {
            this.message = message;
        }
        public string AnalyseMood()
        {
            try
            {

                if (this.message.Contains("sad"))
                {
                    return "SAD";
                }
                else
                    return "HAPPY";
            }
            catch
            {
                return "HAPPY";
            }
            
        }
    }
}
