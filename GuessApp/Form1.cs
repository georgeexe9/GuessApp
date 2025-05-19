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

        private readonly List<Questions> questionList = new List<Questions>();

        public Form1()
        {
            InitializeComponent();
            ListviewStyle();
        }
        private void ListviewStyle()
        {
          
            listView1.View = View.Details;
            
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
                
                List<string> answers = new List<string>() { answer1, answer2, answer3, rightAnswer };
               
                
                Questions newQuestion = new Questions(question,answers, rightAnswer);
                newQuestion.SetQuestion(question, answers, rightAnswer);
                questionList.Add(newQuestion);  
                
                AddQuestionToListView(newQuestion);        
                LabelQuestionInfo.Text = $"{questionList.Count}";
                ClearAllTextboxes();
            }
            else
            {
                MessageBox.Show("Моля въведете всички празни полета", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void AddQuestionToListView(Questions question)
        {
            string displayQuestion = question.Question;
            string displayAnswers = question.DisplayAnswers();
            string[] formattedAnswers = displayAnswers.Split(new[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries);

            ListViewItem item = new ListViewItem(displayQuestion);
            item.SubItems.Add(string.Join(" ", formattedAnswers));
            item.SubItems.Add(question.CorrectAnswer);

            listView1.Items.Add(item);
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            SaveData();
        }

        private void DeleteQuestionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (questionList.Count == 0)
            {
                MessageBox.Show("Няма въведени въпроси и отговори", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                questionList.Clear();
                listView1.Items.Clear();
                LabelQuestionInfo.Text = "0";
            }
        }

        private void ClearAllTextboxes()
        {
            QuestionBox.Text = "";
            AnswBox1.Text = "";
            AnswBox2.Text = "";
            AnswBox3.Text = "";
            RightAsw.Text = "";
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            ClearAllTextboxes();
        }

        private void ShowQuestionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            foreach (var question in questionList)
            {
                string displayQuestion = question.Question;
                string displayAnswers = question.DisplayAnswers().Replace(Environment.NewLine, " ");
                string correctAnswer = question.CorrectAnswer;

                ListViewItem item = new ListViewItem(displayQuestion);
                item.SubItems.Add(displayAnswers);
                item.SubItems.Add(correctAnswer);

                listView1.Items.Add(item);
            }
        }

        private void изчистиСписъкToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
        }

        private void StartGameButton_Click(object sender, EventArgs e)
        {
            GamePanel gp = new GamePanel();
            gp.ShowDialog();
        }
    }

}
