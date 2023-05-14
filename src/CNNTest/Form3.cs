using CSharpNet;
using System.Security;

namespace CNNTest
{
    public partial class Form3 : Form
    {
        private OpenFileDialog _openFileDialog;
        private ImageProcessor _cNet;
        public Bitmap _originalImage { get; private set; }
        private int[,] _matrix;

        public Form3()
        {
            InitializeComponent();
            _cNet = new ImageProcessor();
            _openFileDialog = new OpenFileDialog()
            {
                Filter = "Images files (*.jpg,*.png)|*.jpg;*.png|(*.jpg)|*.jpg|(*.png)|*.png",
            };
        }

        private void pictureBox1_DoubleClick(object sender, EventArgs e)
        {
            if (_openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    _originalImage = new Bitmap(_openFileDialog.FileName);

                    _matrix = _cNet.ConvertToGrayScaleMatrix(_originalImage);

                    pictureBox1.Image = _originalImage;
                    pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
                }
                catch (SecurityException ex)
                {
                    MessageBox.Show($"Security error.\n\nError message: {ex.Message}\n\n" +
                    $"Details:\n\n{ex.StackTrace}");
                }
            }
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            await ImageProcess();
        }

        private async void trackBar1_Scroll(object sender, EventArgs e)
        {
            label2.Text = trackBar1.Value.ToString();

            await ImageProcess();
        }

        private async Task<int> ImageProcess()
        {
            progressBar1.Value = 0;
            _matrix = _cNet.ConvertToGrayScaleMatrix(_originalImage);

            var w = _matrix!.GetLength(0);
            var h = _matrix.GetLength(1);

            var edgeValue = trackBar1.Value;

            for (int i = 0; i < w; i++)
            {
                for (int j = 0; j < h; j++)
                {
                    var pixelValue = _matrix[i, j];
                    if (pixelValue > edgeValue)
                    {
                        _matrix[i, j] = 255;
                    }

                    else
                    {
                        _matrix[i, j] = 0;
                    }
                }

                var p = ((float)i / (float)w) * 100;
                var z = (int)p;
                progressBar1.Value = z;
            }

            var outputImage = _cNet.ConvertToBitmap(_matrix);
            pictureBox2.Image = outputImage;
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;

            return await Task.FromResult(1);
        }
    }
}
