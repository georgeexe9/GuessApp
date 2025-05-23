﻿using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Windows.Controls;

namespace GuessApp
{
    public class Questions
    {
        public string  Question { get; set; }
        public string CorrectAnswer { get; set; }
        public List<string> Answers { get; set; } = new List<string>();
       

        //constructor
        public Questions(string question, List<string> answers, string correctAnswer)
        {
            Question = question;
            Answers = answers;
            CorrectAnswer = correctAnswer;
      
        }
        //save question
        public void SetQuestion(string question, List<string> answers, string correctAnswer)
        {
            Question = question;
            Answers = answers;
            CorrectAnswer = correctAnswer;
        }
        //remove already added question
        public void RemoveQuestions()
        {
            Question = "";          
            Answers.Clear();
            CorrectAnswer = "";
        }
        //displaying all answers
        public string DisplayAnswers()
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0;  i < Answers.Count; i++)
            {
                sb.AppendLine($"{(char)('A' + i)}. {Answers[i]}");
            }
            return sb.ToString();
        }
        
       
       
       

       

    }
}