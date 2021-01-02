using System.Windows.Forms;

namespace homework_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            Ellipse ellipse = new Ellipse(40, 80, 400, 20);
            ellipse.Draw(e.Graphics);
            ellipse.Show(label1);

            Circle circle = new Circle(40, 700, 30);
            circle.Draw(e.Graphics);
            circle.Show(label2);


            label3.Text = "Ellipse and circle sum=" + (ellipse + circle);
        }
    }
}
