﻿using System;

namespace MoodAnalyserAssignment
{
    public class MoodAnalyser
    {
        static void Main(string[] args)
        {
         
        }
        public  string AnalyseMood()
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
