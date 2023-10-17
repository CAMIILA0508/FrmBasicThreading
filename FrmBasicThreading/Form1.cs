namespace FrmBasicThreading
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public void MyThreads()
        {
            lblThread.Text = "Before Starting Thread";
            Console.WriteLine("Before Starting Thread");

            MyThreadClass threadClass = new MyThreadClass();
            Thread threadA = new Thread(new ThreadStart(threadClass.thread1));
            Thread threadB = new Thread(new ThreadStart(threadClass.thread2));
            Thread threadC = new Thread(new ThreadStart(threadClass.thread1));
            Thread threadD = new Thread(new ThreadStart(threadClass.thread2));

            threadA.Priority = ThreadPriority.Highest;
            threadA.Name = "Thread A Process";

            threadB.Priority = ThreadPriority.Normal;
            threadB.Name = "Thread B Process";

            threadC.Priority = ThreadPriority.AboveNormal;
            threadC.Name = "Thread C Process";

            threadD.Priority = ThreadPriority.BelowNormal;
            threadD.Name = "Thread D Process";

            threadA.Start();
            threadB.Start();
            threadC.Start();
            threadD.Start();

            threadA.Join();
            threadB.Join();
            threadC.Join();
            threadD.Join();

            Console.WriteLine("- End of Thread -");
            lblThread.Text = "- End of Thread -";

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
         
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MyThreads();
        }
    }
}