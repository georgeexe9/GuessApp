using System.Collections.Generic;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Windows.Controls;

namespace GuessApp
{
    public class Questions
    {
        public string Question { get; set; }
        public List<string> Answers { get; set; } = new List<string>();
        public string CorrectAnswer { get; set; }

        public Questions()
        {
            
        }
        public void SetQuestion(string question, List<string> answers, string correctAnswer)
        {
            Question = question;
            Answers = answers;
            CorrectAnswer = correctAnswer;
        }
        
        public void RemoveQuestions(string question, List<string> answers, string correctAnswer)
        {
            question = "";          
            answers.Clear();
            correctAnswer = "";
        }
        
        public string DisplayAnswers()
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0;  i < Answers.Count; i++)
            {
                sb.AppendLine($"{(char)('A' + i)}. {Answers[i]}");
            }
            return sb.ToString();
        }
       
        public void CompareAnswers()
        {

        }
        public void ExportQuestions()
        {

        }

       

    }
}