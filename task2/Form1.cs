using System.Diagnostics;
using System.Threading;

namespace task2
{
    public partial class Form1 : Form
    {
        private static int matrSize = 0;
        private static Matrix A;
        private static Matrix B;
        private static Matrix C;
        private static Stopwatch totalTime;

        public Form1()
        {
            InitializeComponent();
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            matrSize = Convert.ToInt32(textBoxSize.Text);

            A = new Matrix(matrSize);
            B = new Matrix(matrSize);

            if (checkBoxParallel.Checked)
            {
                totalTime = Stopwatch.StartNew();
                Parallel.For(0, matrSize, delegate(int i)
                            {
                                for (int j = 0; j < matrSize; ++j)
                                    for (int k = 0; k < matrSize; ++k)
                                        C.data[i, j] += A.data[i, k] * B.data[k, j];
                            });
                totalTime.Stop();
            }
            else
            {
                totalTime = Stopwatch.StartNew();
                C = A * B;
                totalTime.Stop();
            }

            labelTime.Text = "Total time: " + totalTime.ElapsedMilliseconds.ToString() + "ms";
        }

        private void textBoxSize_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if ((textBoxSize.Text != null) && (0 < Convert.ToInt32(textBoxSize.Text)))
                    buttonStart.Enabled = true;
            }
            catch
            { buttonStart.Enabled = false; }
        }
    }
}