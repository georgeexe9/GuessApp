using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace GuessApp
{
    /// <summary>
    /// ================================== GUESS APP ==================================
    /// ==== Notes ===
    /// 
    /// 
    /// </summary>

    public partial class Form1 : Form
    {
        List<string> answers = new List<string>();
        private readonly Questions questions = new Questions();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            


        }
    
        private void SaveData()
        {
            string question = QuestionBox.Text.Trim();
            string answer1 = AnswBox1.Text.Trim();
            string answer2 = AnswBox2.Text.Trim();
            string answer3 = AnswBox3.Text.Trim();
            string rightAnswer = RightAsw.Text.Trim();

            if (question != "" && answer1 != "" && answer2 != "" && answer3 != "" && rightAnswer != "") 
            {
                answers.Add(question);
                answers.Add(answer1);
                answers.Add(answer2);
                answers.Add(answer3);
                answers.Add(rightAnswer);

               
                questions.SetQuestion(question, answers, rightAnswer);
                //Console.WriteLine("EEEE" + questions.Question);
                //Console.WriteLine("EEEEE" + questions.DisplayQuestions());

                string displayQuestion = questions.Question;
                string displayAnswers = questions.DisplayAnswers();
                string[] formattedAnswers = displayAnswers.Split(',');
                string correctAnswer = questions.CorrectAnswer;

                ListViewItem item = new ListViewItem(displayQuestion);
 
                item.SubItems.Add(string.Join(" ", formattedAnswers));
                item.SubItems.Add(correctAnswer);
                listView1.Items.Add(item);


            }
            else
            {
                MessageBox.Show("Моля въведете всички празни полета", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
            


        private void SaveButton_Click(object sender, EventArgs e)
        {
           
            SaveData();
        }

        private void DeleteQuestionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }
    }
}