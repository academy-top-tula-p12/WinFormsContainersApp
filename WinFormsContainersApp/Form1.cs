namespace WinFormsContainersApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            flowLayoutPanel1.FlowDirection = FlowDirection.BottomUp;

            for(int i = 0; i < 5; i++)
            {
                Button btn = new Button();
                btn.Width = 100;
                btn.Height = 50;
                btn.Text = (i + 1).ToString();
                flowLayoutPanel1.Controls.Add(btn);
            }
        }

        void ButtonSelfMade()
        {
            //Button button = new();
            //button.Size = new Size(new Point(100, 50));
            //button.BackColor = Color.DarkGoldenrod;
            //button.ForeColor = Color.White;

            //int x = (this.Width - button.Width) / 2;
            //int y = (this.Height - button.Height) / 2;
            //button.Location = new Point(x, y);

            //button.Text = "Hello";

            //this.Controls.Add(button);
        }
    }
}
