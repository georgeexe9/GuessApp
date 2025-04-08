using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Xml.Linq;

namespace GuessApp
{

    public partial class Form1 : Form
    {
        private int counter = 0;
        private int anticounter = 0;
        //Речник, който записва въпроси и възможни отговори
        Dictionary<string, List<string>> QuestionsAnswers = new Dictionary<string, List<string>>();
        //Речник, който записва въпросите и само правилните отговори към тях.
        Dictionary<string, string> CurrectAnswers = new Dictionary<string, string>();
        public Form1()
        {
            InitializeComponent();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            SaveData();
            ClearBoxes();
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            ClearBoxes();
        }
        private void SaveData()
        {
            //Чисти Viewer1, за да не дубликира въпросите след всеки нововъведен въпрос
            Viewer1.Clear();
            string ques = QuestionBox.Text;
            string answer1 = AnswBox1.Text;
            string answer2 = AnswBox2.Text;
            string answer3 = AnswBox3.Text;
            string rightAnswer = RightAsw.Text;

            if (ques == "" || answer1 == "" || answer2 == "" || answer3 == "" || rightAnswer == "")
            {
                MessageBox.Show("Моля, въведи всички полета! Трябва да са въведени точни 3 грешни и 1 верен отговор!", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                //
                //Въведените въпроси в речника "QuestionsAnswers" са запазени като ключове, а стойностите на всеки ключ са отговори, запазени в лист
                //questions - key / List<string> - value (съдържа въпроси)
                QuestionsAnswers[ques] = new List<string>() { answer1, answer2, answer3, rightAnswer };
                //В "CurrectAnswers въпросите са запазени като ключове, а правилния им отговор като стойност
                CurrectAnswers[ques] = rightAnswer;
                MessageBox.Show("Вашия въпрос и отговорите бяха успешно запазени!", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            //задаваме въпросите като ключове в речника, а отговорите стойност в лист

            if (QuestionsAnswers.Count == 0)
            {
                MessageBox.Show("Няма въведени въпроси");
            }
            else
            {
                foreach (var s in QuestionsAnswers)
                {
                    // Показваме кючовете като въпроси в Richtextbox

                    string savedAnswers = $"Вашия въпрос е: {s.Key}";
                    Viewer1.AppendText(savedAnswers + Environment.NewLine);


                    // Визуализираме отговорите от листа(който се явява като стойност в речника)
                    for (int i = 0; i < s.Value.Count; i++)
                    {
                        Viewer1.AppendText($"{i + 1}. {s.Value[i]}\n");
                    }
                    Viewer1.AppendText(Environment.NewLine);

                }
            }
        }
        private void ClearBoxes()
        {
            QuestionBox.Clear();
            AnswBox1.Clear();
            AnswBox2.Clear();
            AnswBox3.Clear();
            RightAsw.Clear();

        }

        private void StartGameButton_Click(object sender, EventArgs e)
        {
            StartTest();
        }
        //Инициализираме индекс, който ще ни проверява номера на въпросите 
        int currentQuestionIndex = 0;
        //Инициализираме лист - questionKeys , който пази въпросите
        private List<string> questionKeys;

        private void StartTest()
        {

            if (QuestionsAnswers.Count == 0)
            {

                MessageBox.Show("Няма добавени въпроси!", "Грешка!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            //Запазваме въпросите(ключовете) от QuestionsAnswers в List<string> questionKeys;
            questionKeys = new List<string>(QuestionsAnswers.Keys);
            currentQuestionIndex = 0;
            ShowNextQuestion();
        }

        private void ShowNextQuestion()
        {
            //Проверяваме ако индексът е по-голям от questionKeys
            if (currentQuestionIndex >= questionKeys.Count)
            {
                MessageBox.Show("Тестът завърши!", "Край", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            string question = questionKeys[currentQuestionIndex];
            List<string> answers = QuestionsAnswers[question];
            //пълним viewer1 със съдържанието от речниците 
            Viewer1.Clear();
            Viewer1.AppendText($" {question}\n\n");
            Viewer1.AppendText($"1. {answers[0]}\n");
            Viewer1.AppendText($"2. {answers[1]}\n");
            Viewer1.AppendText($"3. {answers[2]}\n");
        }

        private void Submit_Click(object sender, EventArgs e)
        {

            string SelectedAnswer = AnswerBox.Text;
            if (QuestionsAnswers.Count == 0 || CurrectAnswers.Count == 0)
            {
                MessageBox.Show("Няма как да отговориш на въпрос без да знаеш отговора! Създай въпрос, кликни върху - Стартирай игра и отговори!", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                CheckAnswer(SelectedAnswer);
            }

        }
        private void CheckAnswer(string SelectedAnswer)
        {

            string question = questionKeys[currentQuestionIndex];
            string correctAnswer = CurrectAnswers[question];
            //Сравняваме въведения отговор на потребитела с този въведен в речниците - като игнорираме как се въвежда стрига
            if (SelectedAnswer.Equals(correctAnswer, StringComparison.OrdinalIgnoreCase))
            {
                MessageBox.Show("Верен отговор!", "Браво!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                Viewer1.Clear();
                AnswerBox.Clear();
                counter++;
            }
            else
            {
                MessageBox.Show($"Грешен отговор! Верният отговор е: {correctAnswer}", "Грешен отговор", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                AnswerBox.Clear();
                anticounter++;
            }
            currentQuestionIndex++;
            ShowNextQuestion();
            //ако сме преминали през всичките въпроси да покаже резултата 
            if (currentQuestionIndex >= questionKeys.Count)
            {
                MessageBox.Show($"Отговори ли сте на общо правилни - {counter} въпроси и на общо грешни - {anticounter} въпроси", "Въпроси", MessageBoxButtons.OK, MessageBoxIcon.Information);
                RightAsw.Clear();
            }

        }

        public void SaveQuestions()
        {

            if (QuestionsAnswers.Count != 0)
            {
                var toXMLfile = new XElement("Questions", QuestionsAnswers.Select(kv => new XElement("Question", new XAttribute("Key", kv.Key), kv.Value.Select(value => new XElement("Answer", value)))));
                var SaveFileDialog = new SaveFileDialog();
                //В какъв файлов формат искаме да бъде записан файла
                //можеш да си спестя тези редове просто като сложа контроли
                SaveFileDialog.Filter = "XML Files (*.xml)|*.xml|All Files (*.*)|*.*";
                SaveFileDialog.Title = "Save XML File";
                SaveFileDialog.FileName = "questions_answers.xml";
                if (SaveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string filePath = SaveFileDialog.FileName;
                    toXMLfile.Save(filePath);
                    MessageBox.Show("Въпросите бяха записани успешно", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Въпросите не бяха записани", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Няма въведени въпроси!", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void SaveButtonQuestions_Click(object sender, EventArgs e)
        {
            SaveQuestions();
        }

    }
}

