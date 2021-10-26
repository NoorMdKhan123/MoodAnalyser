using System;

namespace MoodAnalyserAssignment
{
    public class MoodAnalyser
    {
        static void Main(string[] args)
        {
         
        }

        public MoodAnalyser()
        {
        }
        string message;
        public MoodAnalyser(string message)
        {
            this.message = message;
        }
        public string AnalyseMood()
        {
            string mood = "I am in sad mood";
            if (mood.Contains("sad"))
            {
                return "SAD";
            }
            else
                return "HAPPY";
            
        }
    }
}
