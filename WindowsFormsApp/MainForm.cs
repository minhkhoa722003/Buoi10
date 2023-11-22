using System;
using System.Windows.Forms;
using System.Drawing;
namespace WindowsFormsApp
{
    public partial class MainForm : Form
    {
        private int currentQuestionIndex = 0;
        private string[] questions = { "Câu hỏi 1: Đâu là quốc gia lớn nhất thế giới?", "Câu hỏi 2: Ai là người đầu tiên đặt chân lên mặt trăng?","Câu 3: Bạn nghĩ kì này bạn rớt môn gì ?" };
        private string[][] answers = { new string[] { "A. Nga", "B. Mỹ", "C. Trung Quốc", "D. Ấn Độ" }, new string[] { "A. Neil Armstrong", "B. Buzz Aldrin", "C. Yuri Gagarin", "D. Alan Shepard" }, new string[] {"A. Lập trình web","B. Công nghệ NET","C. Hệ quản trị CSDL","Trí tuệ nhân tạo"} };
        private string[] correctAnswers = { "B", "A","A" };
        private string[] selectedAnswers;
        private string[] userAnswers = new string[2];
        public MainForm()
        {
            InitializeComponent();
            selectedAnswers = new string[questions.Length];
            DisplayQuestion();
        }

        private void DisplayQuestion()
        {
            if (currentQuestionIndex >= 0 && currentQuestionIndex < questions.Length)
            {
                labelQuestion.Text = questions[currentQuestionIndex];
                radioButtonA.Text = answers[currentQuestionIndex][0];
                radioButtonB.Text = answers[currentQuestionIndex][1];
                radioButtonC.Text = answers[currentQuestionIndex][2];
                radioButtonD.Text = answers[currentQuestionIndex][3];
                if (selectedAnswers[currentQuestionIndex] == "A")
                    radioButtonA.Checked = true;
                else if (selectedAnswers[currentQuestionIndex] == "B")
                    radioButtonB.Checked = true;
                else if (selectedAnswers[currentQuestionIndex] == "C")
                    radioButtonC.Checked = true;
                else if (selectedAnswers[currentQuestionIndex] == "D")
                    radioButtonD.Checked = true;
                else
                {
                    radioButtonA.Checked = false;
                    radioButtonB.Checked = false;
                    radioButtonC.Checked = false;
                    radioButtonD.Checked = false;
                }

                button1.Enabled = currentQuestionIndex > 0;
                button2.Enabled = currentQuestionIndex < questions.Length - 1;
            }
        }
        private void radioButtonA_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonA.Checked)
                selectedAnswers[currentQuestionIndex] = "A";
        }

        private void radioButtonB_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonB.Checked)
                selectedAnswers[currentQuestionIndex] = "B";
        }

        private void radioButtonC_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonC.Checked)
                selectedAnswers[currentQuestionIndex] = "C";
        }

        private void radioButtonD_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonD.Checked)
                selectedAnswers[currentQuestionIndex] = "D";
        }



        private void labelResult_Click(object sender, EventArgs e)
        {
            if (selectedAnswers[currentQuestionIndex] == "B")
            {
                labelResult.Text = "Kết quả: Đúng";
            }
            else
            {
                labelResult.Text = "Kết quả: Sai";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            currentQuestionIndex--;
            DisplayQuestion();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            currentQuestionIndex++;
            DisplayQuestion();
        }
    }
}