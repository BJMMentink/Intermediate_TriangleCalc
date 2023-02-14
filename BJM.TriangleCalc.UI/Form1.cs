namespace BJM.TriangleCalc.UI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            double Height = 0;
            double Width = 0;
            if (double.TryParse(txtHeight.Text, out Height)) { }
            if (double.TryParse(txtBase.Text, out Width)) { }

            AreaCalc areaCalc = new AreaCalc();
            areaCalc.dblHeight = Height;
            areaCalc.dblBase = Width;
            lblArea.Text = "Area: " + areaCalc.AreaTotal.ToString();
            lblPerimiter.Text = "Perimeter: " + areaCalc.Perimeter().ToString();
        }
    }
}