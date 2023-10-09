namespace Task3_Countrycloc_
{
    public partial class Form1 : Form
    {
        System.Windows.Forms.Timer timer;
        public Form1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
           timer = new System.Windows.Forms.Timer();
            timer.Interval = 950;

           timer.Tick += Timer_Tick;
            timer.Start();

        }

        private void Timer_Tick(object? sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToLongTimeString();

          
        }

        private void button4_Click(object sender, EventArgs e)
        {
            timer = new System.Windows.Forms.Timer();
            timer.Interval = 850;
          
           

            timer.Tick += Timer_Tick_1;
            timer.Start();
        }
        private void Timer_Tick_1(object? sender, EventArgs e)
        {
            label2.Text = (DateTime.Now.ToLongTimeString());
            string ff = DateTime.Now.ToLongTimeString();
       

        }
    }
}