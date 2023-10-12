namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        String myText = "";

        void writeText()
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            String myComponent = textBox1.Text;
            if (radioButton1.Checked)
            {
                radioButton1.Text = myComponent;
            }
            if (radioButton2.Checked)
            {
                radioButton2.Text = myComponent;
            }
            if (radioButton3.Checked)
            {
                radioButton3.Text = myComponent;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int elementlarSoni = Convert.ToInt32(textBox2.Text);
            if (checkedRadioButton.Checked)
            {
                for (int i = 1; i <= elementlarSoni; i++)
                {
                    RadioButton radioButton = new RadioButton();
                    radioButton.Text = "RaidoButton " + i;
                    radioButton.Name = "radioButton" + i.ToString();
                    radioButton.Location = new Point(600, i * 30 + 100);
                    radioButton.Width = 100;
                    this.Controls.Add(radioButton);
                }
            }
            else if (checkedCheckBox.Checked)
            {
                for (int i = 1; i <= elementlarSoni; i++)
                {
                    CheckBox checkBox = new CheckBox();
                    checkBox.Text = "CheckBox " + i;
                    checkBox.Name = "checkBox" + i.ToString();
                    checkBox.Location = new Point(710, i * 30 + 100);
                    checkBox.Width = 100;
                    this.Controls.Add(checkBox);
                }
            }
            else
            {
                MessageBox.Show("Yaratmoqchi bo'lgan komponentangizni tanlang", "Tanlamadingiz", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            
        }
    }
}