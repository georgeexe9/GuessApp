using System.Drawing;

namespace GuessApp
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.ClearButton = new System.Windows.Forms.Button();
            this.StartGameButton = new System.Windows.Forms.Button();
            this.SaveButton = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.AnswBox3 = new System.Windows.Forms.TextBox();
            this.QuestionBox = new System.Windows.Forms.TextBox();
            this.RightAsw = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.AnswBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.AnswBox2 = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.настройкиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.QuestionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ShowQuestionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DeleteQuestionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.изчистиСписъкToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.статистикаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.QuestionCountToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ResultToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveButtonQuestions = new System.Windows.Forms.ToolStripMenuItem();
            this.HelpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CloseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listView1 = new System.Windows.Forms.ListView();
            this.QuestionHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.AnswersHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CorrectAnswer = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label7 = new System.Windows.Forms.Label();
            this.LabelQuestionInfo = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(153, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(237, 51);
            this.label1.TabIndex = 0;
            this.label1.Text = "Question game";
            // 
            // ClearButton
            // 
            this.ClearButton.BackColor = System.Drawing.Color.White;
            this.ClearButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ClearButton.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClearButton.ForeColor = System.Drawing.Color.Black;
            this.ClearButton.Location = new System.Drawing.Point(23, 243);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(99, 25);
            this.ClearButton.TabIndex = 15;
            this.ClearButton.Text = "Изчисти";
            this.ClearButton.UseVisualStyleBackColor = false;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // StartGameButton
            // 
            this.StartGameButton.BackColor = System.Drawing.Color.White;
            this.StartGameButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.StartGameButton.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StartGameButton.Location = new System.Drawing.Point(144, 641);
            this.StartGameButton.Name = "StartGameButton";
            this.StartGameButton.Size = new System.Drawing.Size(246, 29);
            this.StartGameButton.TabIndex = 13;
            this.StartGameButton.Text = "Стартирай игра";
            this.StartGameButton.UseVisualStyleBackColor = false;
            this.StartGameButton.Click += new System.EventHandler(this.StartGameButton_Click);
            // 
            // SaveButton
            // 
            this.SaveButton.BackColor = System.Drawing.Color.White;
            this.SaveButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.SaveButton.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveButton.ForeColor = System.Drawing.Color.Black;
            this.SaveButton.Location = new System.Drawing.Point(141, 243);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(204, 25);
            this.SaveButton.TabIndex = 12;
            this.SaveButton.Text = "Запиши";
            this.SaveButton.UseVisualStyleBackColor = false;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // label10
            // 
            this.label10.AllowDrop = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(20, 40);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(115, 21);
            this.label10.TabIndex = 14;
            this.label10.Text = "Твоят въпрос е:";
            this.label10.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label5
            // 
            this.label5.AllowDrop = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(20, 151);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 22);
            this.label5.TabIndex = 11;
            this.label5.Text = "Отговор #3";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // AnswBox3
            // 
            this.AnswBox3.Font = new System.Drawing.Font("Segoe Script", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AnswBox3.Location = new System.Drawing.Point(141, 145);
            this.AnswBox3.Name = "AnswBox3";
            this.AnswBox3.Size = new System.Drawing.Size(139, 28);
            this.AnswBox3.TabIndex = 10;
            // 
            // QuestionBox
            // 
            this.QuestionBox.Font = new System.Drawing.Font("Segoe Script", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QuestionBox.Location = new System.Drawing.Point(141, 33);
            this.QuestionBox.Name = "QuestionBox";
            this.QuestionBox.Size = new System.Drawing.Size(204, 28);
            this.QuestionBox.TabIndex = 1;
            // 
            // RightAsw
            // 
            this.RightAsw.Font = new System.Drawing.Font("Segoe Script", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RightAsw.Location = new System.Drawing.Point(141, 200);
            this.RightAsw.Name = "RightAsw";
            this.RightAsw.Size = new System.Drawing.Size(139, 28);
            this.RightAsw.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AllowDrop = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(32, 206);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(103, 22);
            this.label6.TabIndex = 9;
            this.label6.Text = "Верен отговор:";
            // 
            // label4
            // 
            this.label4.AllowDrop = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(20, 117);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 22);
            this.label4.TabIndex = 6;
            this.label4.Text = "Отговор #2";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // AnswBox1
            // 
            this.AnswBox1.Font = new System.Drawing.Font("Segoe Script", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AnswBox1.Location = new System.Drawing.Point(141, 77);
            this.AnswBox1.Name = "AnswBox1";
            this.AnswBox1.Size = new System.Drawing.Size(139, 28);
            this.AnswBox1.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AllowDrop = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(20, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 22);
            this.label3.TabIndex = 5;
            this.label3.Text = "Отговор #1";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // AnswBox2
            // 
            this.AnswBox2.Font = new System.Drawing.Font("Segoe Script", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AnswBox2.Location = new System.Drawing.Point(141, 111);
            this.AnswBox2.Name = "AnswBox2";
            this.AnswBox2.Size = new System.Drawing.Size(139, 28);
            this.AnswBox2.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.groupBox1.Controls.Add(this.QuestionBox);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.ClearButton);
            this.groupBox1.Controls.Add(this.RightAsw);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.AnswBox1);
            this.groupBox1.Controls.Add(this.SaveButton);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.AnswBox3);
            this.groupBox1.Controls.Add(this.AnswBox2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(89, 116);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(355, 295);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Създай въпрос";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(159, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(232, 16);
            this.label2.TabIndex = 19;
            this.label2.Text = ":Задай въпрос и отговори на него:";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("menuStrip1.BackgroundImage")));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.настройкиToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(525, 24);
            this.menuStrip1.TabIndex = 21;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // настройкиToolStripMenuItem
            // 
            this.настройкиToolStripMenuItem.BackColor = System.Drawing.Color.White;
            this.настройкиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.QuestionsToolStripMenuItem,
            this.статистикаToolStripMenuItem,
            this.SaveButtonQuestions,
            this.HelpToolStripMenuItem,
            this.CloseToolStripMenuItem});
            this.настройкиToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.настройкиToolStripMenuItem.Name = "настройкиToolStripMenuItem";
            this.настройкиToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.настройкиToolStripMenuItem.Text = "Опции";
            // 
            // QuestionsToolStripMenuItem
            // 
            this.QuestionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ShowQuestionsToolStripMenuItem,
            this.DeleteQuestionsToolStripMenuItem,
            this.изчистиСписъкToolStripMenuItem});
            this.QuestionsToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.QuestionsToolStripMenuItem.Name = "QuestionsToolStripMenuItem";
            this.QuestionsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.QuestionsToolStripMenuItem.Text = "Въпроси опции";
            // 
            // ShowQuestionsToolStripMenuItem
            // 
            this.ShowQuestionsToolStripMenuItem.Name = "ShowQuestionsToolStripMenuItem";
            this.ShowQuestionsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.ShowQuestionsToolStripMenuItem.Text = "Покажи въпроси";
            this.ShowQuestionsToolStripMenuItem.Click += new System.EventHandler(this.ShowQuestionsToolStripMenuItem_Click);
            // 
            // DeleteQuestionsToolStripMenuItem
            // 
            this.DeleteQuestionsToolStripMenuItem.Name = "DeleteQuestionsToolStripMenuItem";
            this.DeleteQuestionsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.DeleteQuestionsToolStripMenuItem.Text = "Изтрий въпроси";
            this.DeleteQuestionsToolStripMenuItem.Click += new System.EventHandler(this.DeleteQuestionsToolStripMenuItem_Click);
            // 
            // изчистиСписъкToolStripMenuItem
            // 
            this.изчистиСписъкToolStripMenuItem.Name = "изчистиСписъкToolStripMenuItem";
            this.изчистиСписъкToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.изчистиСписъкToolStripMenuItem.Text = "Изчисти списък";
            this.изчистиСписъкToolStripMenuItem.Click += new System.EventHandler(this.изчистиСписъкToolStripMenuItem_Click);
            // 
            // статистикаToolStripMenuItem
            // 
            this.статистикаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.QuestionCountToolStripMenuItem,
            this.ResultToolStripMenuItem});
            this.статистикаToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.статистикаToolStripMenuItem.Name = "статистикаToolStripMenuItem";
            this.статистикаToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.статистикаToolStripMenuItem.Text = "Статистика";
            // 
            // QuestionCountToolStripMenuItem
            // 
            this.QuestionCountToolStripMenuItem.Name = "QuestionCountToolStripMenuItem";
            this.QuestionCountToolStripMenuItem.Size = new System.Drawing.Size(209, 22);
            this.QuestionCountToolStripMenuItem.Text = "Брой въведени  въпроси";
            // 
            // ResultToolStripMenuItem
            // 
            this.ResultToolStripMenuItem.Name = "ResultToolStripMenuItem";
            this.ResultToolStripMenuItem.Size = new System.Drawing.Size(209, 22);
            this.ResultToolStripMenuItem.Text = "Резултат";
            // 
            // SaveButtonQuestions
            // 
            this.SaveButtonQuestions.ForeColor = System.Drawing.Color.Black;
            this.SaveButtonQuestions.Name = "SaveButtonQuestions";
            this.SaveButtonQuestions.Size = new System.Drawing.Size(180, 22);
            this.SaveButtonQuestions.Text = "Запиши въпроси";
            // 
            // HelpToolStripMenuItem
            // 
            this.HelpToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem";
            this.HelpToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.HelpToolStripMenuItem.Text = "Помощ";
            // 
            // CloseToolStripMenuItem
            // 
            this.CloseToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.CloseToolStripMenuItem.Name = "CloseToolStripMenuItem";
            this.CloseToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.CloseToolStripMenuItem.Text = "Затвори";
            // 
            // listView1
            // 
            this.listView1.Alignment = System.Windows.Forms.ListViewAlignment.Left;
            this.listView1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.listView1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("listView1.BackgroundImage")));
            this.listView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.QuestionHeader,
            this.AnswersHeader,
            this.CorrectAnswer});
            this.listView1.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView1.ForeColor = System.Drawing.Color.White;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(23, 448);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(490, 187);
            this.listView1.TabIndex = 22;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // QuestionHeader
            // 
            this.QuestionHeader.Text = "Въпрос";
            this.QuestionHeader.Width = 155;
            // 
            // AnswersHeader
            // 
            this.AnswersHeader.Text = "Въведени отговори";
            this.AnswersHeader.Width = 216;
            // 
            // CorrectAnswer
            // 
            this.CorrectAnswer.Text = "Правилен отговор";
            this.CorrectAnswer.Width = 123;
            // 
            // label7
            // 
            this.label7.AllowDrop = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(20, 424);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(169, 21);
            this.label7.TabIndex = 16;
            this.label7.Text = "Вече въведени въпроси:";
            // 
            // LabelQuestionInfo
            // 
            this.LabelQuestionInfo.AllowDrop = true;
            this.LabelQuestionInfo.BackColor = System.Drawing.Color.Transparent;
            this.LabelQuestionInfo.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelQuestionInfo.ForeColor = System.Drawing.Color.White;
            this.LabelQuestionInfo.Location = new System.Drawing.Point(194, 424);
            this.LabelQuestionInfo.Name = "LabelQuestionInfo";
            this.LabelQuestionInfo.Size = new System.Drawing.Size(19, 21);
            this.LabelQuestionInfo.TabIndex = 23;
            this.LabelQuestionInfo.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(525, 682);
            this.Controls.Add(this.LabelQuestionInfo);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.StartGameButton);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Question game";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button StartGameButton;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox AnswBox3;
        private System.Windows.Forms.TextBox QuestionBox;
        private System.Windows.Forms.TextBox RightAsw;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox AnswBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox AnswBox2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem настройкиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SaveButtonQuestions;
        private System.Windows.Forms.ToolStripMenuItem HelpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem CloseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem статистикаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem QuestionCountToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ResultToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem QuestionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ShowQuestionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem DeleteQuestionsToolStripMenuItem;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader QuestionHeader;
        private System.Windows.Forms.ColumnHeader AnswersHeader;
        private System.Windows.Forms.ColumnHeader CorrectAnswer;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label LabelQuestionInfo;
        private System.Windows.Forms.ToolStripMenuItem изчистиСписъкToolStripMenuItem;
    }
}

