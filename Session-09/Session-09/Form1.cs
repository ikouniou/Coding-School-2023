using CalculatorLib;

namespace Session_09 {
    public partial class Form1 : Form {

        private decimal? _value1 = null;
        private decimal? _value2 = null;
        private decimal? _result = null;

        private CalcOperation _calcOperation;
        enum CalcOperation {
            Addition,
            Substraction,
            Multiplication,
            Division,
            Power,
            Root

        }
        public Form1() {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) {

        }

        private void button1_Click(object sender, EventArgs e) {
            
            decimal number = 0;
            WriteNumber(number);
        }

        private void button2_Click(object sender, EventArgs e) {
           
            decimal number = 1;
            WriteNumber(number);
        }

        private void button4_Click(object sender, EventArgs e) {
            decimal number = 3;
            WriteNumber(number);
        }

        private void button12_Click(object sender, EventArgs e) {
            textBox1.Text += " + ";
            _calcOperation = CalcOperation.Addition;
        }

        private void button3_Click(object sender, EventArgs e) {
           
            decimal number = 2;
            WriteNumber(number);
        }

        private void button11_Click(object sender, EventArgs e) {
            textBox1.Text += " = ";

            switch (_calcOperation) {
                case CalcOperation.Addition:

                    Addition addition = new Addition();
                    _result = addition.Do(_value1, _value2);
                    //_result = _value1 + _value2;
                    break;

                case CalcOperation.Substraction:

                    Substraction substraction = new Substraction();
                    _result = substraction.Do(_value1, _value2);
                    //_result = _value1 - _value2;
                    break;

                case CalcOperation.Multiplication:

                    Multiplication multiplication = new Multiplication();
                    _result = multiplication.Do(_value1, _value2);
                    //_result = _value1 * _value2;
                    break;

                 case CalcOperation.Division:

                    Division division = new Division();
                    _result = division.Do(_value1, _value2);
                    //if(_value2 != 0) {
                    //    _result = _value1 / _value2;
                    //} 
                    break;

                case CalcOperation.Power:

                    Power power = new Power();
                    _result = power.Do(_value1, _value2);
                    //_result = (decimal)Math.Pow((double)_value1, (double)2);
                    break;

                case CalcOperation.Root:

                    Root root = new Root();
                    _result = root.Do(_value1, _value2);
                    //_result = (decimal)Math.Sqrt((double)_value1);
                    break;

                default:
                    break;
            }

            textBox1.Text += _result;
        }

        private void button5_Click(object sender, EventArgs e) {
            
            decimal number = 4;
            WriteNumber(number);
        }

        private void button6_Click(object sender, EventArgs e) {

            decimal number = 5;
            WriteNumber(number);
        }

        private void button7_Click(object sender, EventArgs e) {
            
            decimal number = 6;
            WriteNumber(number);
        }

        private void button8_Click(object sender, EventArgs e) {

            decimal number = 7;
            WriteNumber(number);
        }

        private void button9_Click(object sender, EventArgs e) {
            
            decimal number = 8;
            WriteNumber(number);
        }

        private void button10_Click(object sender, EventArgs e) {
            
            decimal number = 9;
            WriteNumber(number);
        }

        private void button13_Click(object sender, EventArgs e) {
            textBox1.Text += " - ";
            _calcOperation = CalcOperation.Substraction;
        }

        private void button16_Click(object sender, EventArgs e) {
            textBox1.Text += " x ";
            _calcOperation = CalcOperation.Multiplication;
        }

        private void button15_Click(object sender, EventArgs e) {
            textBox1.Text += " / ";
            _calcOperation = CalcOperation.Division;
        }

        private void button14_Click(object sender, EventArgs e) {
            textBox1.Text += " ^(x) ";
            _calcOperation = CalcOperation.Power;
        }

        private void button17_Click(object sender, EventArgs e) {
            textBox1.Text += " sqrt() ";
            _calcOperation = CalcOperation.Root;
        }

        private void WriteNumber(decimal number) {
            if (_result != null) {

                textBox1.Text = string.Empty;
                _value1 = null;
                _value2 = null;
                _result = null;
            }

            textBox1.Text += number; ;

            if (_value1 == null) {
                _value1 = number;
            } else {
                _value2 = number;
            }
        }

        private void button19_Click(object sender, EventArgs e) {
            textBox1.Text = string.Empty;
        }
    }
}