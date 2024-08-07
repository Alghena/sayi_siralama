namespace odev4
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        public object Items { get; private set; }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listBox1.Items.Add(textBox1.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int[] arr = Array.ConvertAll(textBox1.Text.Split('-'), int.Parse);
            int n = arr.Length;
            for (int i = 0; i < n - 1; i++)
            {
                int maxIndex = i;
                for (int j = i + 1; j < n; j++)
                {
                    if (arr[j] > arr[maxIndex])
                    {
                        maxIndex = j;
                    }
                }
                int temp = arr[i];
                arr[i] = arr[maxIndex];
                arr[maxIndex] = temp;
            }
            listBox2.Items.Clear();
            listBox2.Items.Add("Büyükten Küçüðe sýralanmasý");
            listBox2.Items.Add(string.Join("-", arr));

        }

        private void button3_Click(object sender, EventArgs e)
        {
            int[] arr = Array.ConvertAll(textBox1.Text.Split('-'), int.Parse);
            int n = arr.Length;
            for (int i = 1; i < n; ++i)
            {
                int key = arr[i];
                int j = i - 1;
                while (j >= 0 && arr[j] > key)
                {
                    arr[j + 1] = arr[j];
                    j = j - 1;

                }
                arr[j + 1] = key;
            }
            listBox2.Items.Add("Küçükten Büyüðe Sýralanmasý");
            listBox2.Items.Add(string.Join("-", arr));
        }
    }
}
        
    

