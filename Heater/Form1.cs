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

            _context_StateChanged();    //初期値表示のために呼ぶ
            _context.StateChanged += _context_StateChanged;// 登録。通知されたら、登録したイベントを通る
        }

        private void _context_StateChanged()
        {
            DisplayLabel.Text = _context.GetText();

        }

        private void UpButton_Click(object sender, EventArgs e)
        {
            //string path = "heater.txt";

            //if (_condition == Condition.OFF)
            //{
            //    var list = new List<string>();
            //    list.Add("Low");
            //    list.Add("500W");
            //    File.WriteAllLines(path, list);
            //    _condition = Condition.Low;
            //}
            //else if(_condition == Condition.Low)
            //{
            //    var list = new List<string>();
            //    list.Add("Hi");
            //    list.Add("1000W");
            //    File.WriteAllLines(path, list);
            //    _condition = Condition.High;
            //}
            //else if (_condition == Condition.High)
            //{
            //    var list = new List<string>();
            //    list.Add("OFF");
            //    list.Add("0W");
            //    File.WriteAllLines(path, list);
            //    _condition = Condition.OFF;
            //}
            //else
            //{
            //    throw new Exception("error");
            //}

            _context.Up();
            //DisplayLabel.Text = _context.GetText();

        }

        private void DownButon_Click(object sender, EventArgs e)
        {
            _context.Down();
            //DisplayLabel.Text = _context.GetText();

        }

        private void OnOffButton_Click(object sender, EventArgs e)
        {
            _context.OnOff();

        }

        private void MaxButton_Click(object sender, EventArgs e)
        {
            _context.Max();
        }
    }
}