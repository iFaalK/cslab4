namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        private FigureContainer figureContainer = new FigureContainer();
        private void UpdateFiguresInfo()
        {
            richTextBox1.Clear();
            var figuresInfo = figureContainer.GetFiguresInfo();
            foreach (var info in figuresInfo)
            {
                richTextBox1.AppendText(info + Environment.NewLine);
            }
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                double radius = double.Parse(textBox8.Text);
                var circle = new Circle(radius);
                figureContainer.AddFigure(circle);
                UpdateFiguresInfo();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            figureContainer = new FigureContainer();
            UpdateFiguresInfo();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                double width = double.Parse(textBox6.Text);
                double height = double.Parse(textBox7.Text);
                var rectangle = new Rectangle(width, height);
                figureContainer.AddFigure(rectangle);
                UpdateFiguresInfo();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                double a = double.Parse(textBox1.Text);
                double b = double.Parse(textBox5.Text);
                double h = double.Parse(textBox2.Text);
                var Trapezoid = new Trapezoid(a, b, h);
                figureContainer.AddFigure(Trapezoid);
                UpdateFiguresInfo();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
