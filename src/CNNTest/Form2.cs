using CSharpNet;
using CSharpNet.Infrastructures;
using System.Security;

namespace CNNTest;

public partial class Form2 : Form
{
    private Bitmap InputImage;
    private Bitmap OriginalImage;
    private int[,] Matrix;
    private OpenFileDialog _openFileDialog;
    private ImageProcessor CNet;
    private Size InputSize;

    public Form2()
    {
        InitializeComponent();
        CNet = new ImageProcessor();
        InputSize = new Size(Input_Width.Text.ToInt(), Input_Height.Text.ToInt());
    }

    private void Form2_Load(object sender, EventArgs e)
    {
        _openFileDialog = new OpenFileDialog()
        {
            Filter = "Images files (*.jpg,*.png)|*.jpg;*.png|(*.jpg)|*.jpg|(*.png)|*.png",
        };
    }

    private void InputPicture_DoubleClick(object sender, EventArgs e)
    {
        if (_openFileDialog.ShowDialog() == DialogResult.OK)
        {
            try
            {
                OriginalImage = new Bitmap(_openFileDialog.FileName);
                InputSize = new Size(Input_Width.Text.ToInt(), Input_Height.Text.ToInt());
                InputImage = new Bitmap(OriginalImage, InputSize);

                Matrix = CNet.ConvertToGrayScaleMatrix(InputImage);

                InputPicture.Image = InputImage;
                InputPicture.SizeMode = PictureBoxSizeMode.Zoom;
            }
            catch (SecurityException ex)
            {
                MessageBox.Show($"Security error.\n\nError message: {ex.Message}\n\n" +
                $"Details:\n\n{ex.StackTrace}");
            }
        }
    }

    private void Conv_00_Click(object sender, EventArgs e)
    {
        SelectedImage.Image = Conv_00.Image;
    }

    private void Conv_01_Click(object sender, EventArgs e)
    {
        SelectedImage.Image = Conv_01.Image;
    }

    private void ConvKernelSize_ValueChanged(object sender, EventArgs e)
    {
        Operations();
    }

    private void PollingKernelSize_ValueChanged(object sender, EventArgs e)
    {
        Operations();
    }

    private void Convert_Btn_Click(object sender, EventArgs e)
    {
        Operations();
    }

    private void Operations()
    {
        if (OriginalImage != null)
        {
            ImageProcess_PB.Value = 0;

            InputSize = new Size(Input_Width.Text.ToInt(), Input_Height.Text.ToInt());
            InputImage = new Bitmap(OriginalImage, InputSize);

            InputPicture.Image = InputImage;
            InputPicture.SizeMode = PictureBoxSizeMode.Zoom;

            ImageProcess_PB.Value = 20;

            Matrix = CNet.ConvertToGrayScaleMatrix(InputImage);

            ImageProcess_PB.Value = 40;

            int width = Matrix.GetLength(0);
            int height = Matrix.GetLength(1);

            var pollingWidth = (int)PollingKernelSize.Value;
            var pollingHeight = (int)PollingKernelSize.Value;

            var kernel = new float[3, 3]
            {
                { Matrix0_00.Text.ToFloat(), Matrix0_01.Text.ToFloat(), Matrix0_02.Text.ToFloat() },
                { Matrix0_10.Text.ToFloat(), Matrix0_11.Text.ToFloat(), Matrix0_12.Text.ToFloat() },
                { Matrix0_20.Text.ToFloat(), Matrix0_21.Text.ToFloat(), Matrix0_22.Text.ToFloat() },
            };
            ImageOperations(Conv_00, kernel, width, height, pollingWidth, pollingHeight);

            ImageProcess_PB.Value = 60;

            kernel = kernel.QuarterRightTurn();
            ImageOperations(Conv_01, kernel, width, height, pollingWidth, pollingHeight);

            ImageProcess_PB.Value = 80;

            var images = new List<Bitmap>()
            {
                (Bitmap)Conv_00.Image.Clone(),
                (Bitmap)Conv_01.Image.Clone(),
            };
            SelectedImage.Image = CNet.MergeImages(images);

            ImageProcess_PB.Value = 100;
        }
    }

    private void ImageOperations(
        PictureBox image,
        float[,] kernel,
        int width,
        int height,
        int pollingWidth,
        int pollingHeight)
    {
        var matrix = CNet.Filter(Matrix, kernel);

        if ((int)ConvKernelSize.Value > 1)
        {
            matrix = CNet.CreateConvolution(
                matrix,
                kernelWidth: (int)ConvKernelSize.Value,
                kernelHeight: (int)ConvKernelSize.Value);
        }

        if (pollingWidth > 0)
        {
            matrix = CNet.CreatePollingMax(matrix, pollingWidth, pollingHeight);
        }

        matrix = CNet.UpscaleImage(matrix, width, height);
        var outputImage = CNet.ConvertToBitmap(matrix);

        image.Image = outputImage;
        image.SizeMode = PictureBoxSizeMode.Zoom;
    }
}