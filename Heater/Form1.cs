using Heater.States;

namespace Heater
{
    public partial class Form1 : Form
    {
        private Context _context = new Context();


        public Form1()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            DisplayLabel.Text = _context.GetText().ToString();

        }

        private void UpButton_Click(object sender, EventArgs e)
        {
            string path = "heater.txt";

            if (_condition == Condition.OFF)
            {
                var list = new List<string>();
                list.Add("Low");
                list.Add("500W");
                File.WriteAllLines(path, list);
                _condition = Condition.Low;
            }
            else if(_condition == Condition.Low)
            {
                var list = new List<string>();
                list.Add("Hi");
                list.Add("1000W");
                File.WriteAllLines(path, list);
                _condition = Condition.High;
            }
            else if (_condition == Condition.High)
            {
                var list = new List<string>();
                list.Add("OFF");
                list.Add("0W");
                File.WriteAllLines(path, list);
                _condition = Condition.OFF;
            }
            else
            {
                throw new Exception("error");
            }

            DisplayLabel.Text = _context.GetText().ToString();

        }
    }
}