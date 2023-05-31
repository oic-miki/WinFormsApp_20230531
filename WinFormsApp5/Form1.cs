using System.Threading.Tasks.Sources;

namespace WinFormsApp5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string a = "";

        private void button1_Click(object sender, EventArgs e)
        {

            // DOA
            a = textBox1.Text;

            label1.Text = a + " <-- a";

        }

        private void button2_Click(object sender, EventArgs e)
        {

            // OO
            B b = new B();

            b.setA(textBox2.Text);

            label2.Text = b.getA2();

        }

        private class B
        {

            private string a;

            public B setA(string a)
            {

                this.a = a;

                return this;

            }

            public string getA()
            {

                return a;

            }

            public string getA2()
            {

                return a + " <-- a";

            }

        }

    }
}