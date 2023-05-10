using CSharpNet;
using CSharpNet.Infrastructures;
using System.Drawing.Imaging;
using System.Security;

namespace CNNTest;

public partial class Form1 : Form
{
    private OpenFileDialog _openFileDialog;
    private SaveFileDialog _SaveFileDialog;
    private Bitmap InputImage;
    private Bitmap OutputImage;
    private int[,] Matrix;

    public Form1()
    {
        InitializeComponent();
    }

    private void Form1_Load(object sender, EventArgs e)
    {
        _openFileDialog = new OpenFileDialog()
        {
            Filter = "Images files (*.jpg,*.png)|*.jpg;*.png|(*.jpg)|*.jpg|(*.png)|*.png",
        };

        _SaveFileDialog = new SaveFileDialog();
    }

    private void File_Btn_Click(object sender, EventArgs e)
    {
        if (_openFileDialog.ShowDialog() == DialogResult.OK)
        {
            try
            {
                Path_TXT.Text = _openFileDialog.FileName;

                var image = new Bitmap(_openFileDialog.FileName);
                pic_box_1.Image = image;
                pic_box_1.SizeMode = PictureBoxSizeMode.Zoom;

                InputImage = new Bitmap(
                    image,
                    Width_txt.Text.ToInt(),
                    Height_txt.Text.ToInt());
            }
            catch (SecurityException ex)
            {
                MessageBox.Show($"Security error.\n\nError message: {ex.Message}\n\n" +
                $"Details:\n\n{ex.StackTrace}");
            }
        }
    }

    private void Convert_Btn_Click(object sender, EventArgs e)
    {
        ServiceHandler();
    }

    private void KernelSizeCounter_ValueChanged(object sender, EventArgs e)
    {
        ServiceHandler();
    }

    private void Save_Btn_Click(object sender, EventArgs e)
    {
        if (_SaveFileDialog.ShowDialog() == DialogResult.OK)
        {
            try
            {
                OutputImage.Save(_SaveFileDialog.FileName, ImageFormat.Jpeg);
            }
            catch (SecurityException ex)
            {
                MessageBox.Show($"Security error.\n\nError message: {ex.Message}\n\n" +
                $"Details:\n\n{ex.StackTrace}");
            }
        }
    }

    private void PollingMaxValue_ValueChanged(object sender, EventArgs e)
    {
        ServiceHandler();
    }

    public void ServiceHandler()
    {
        var cNet = new ImageProcessor();
        Matrix = cNet.ConvertToGrayScaleMatrix(InputImage);

        int width = Matrix.GetLength(0);
        int height = Matrix.GetLength(1);

        var kernel = new float[3, 3]
        {
            { Matrix_00.Text.ToFloat(), Matrix_01.Text.ToFloat(), Matrix_02.Text.ToFloat() },
            { Matrix_10.Text.ToFloat(), Matrix_11.Text.ToFloat(), Matrix_12.Text.ToFloat() },
            { Matrix_20.Text.ToFloat(), Matrix_21.Text.ToFloat(), Matrix_22.Text.ToFloat() },
        };
        Matrix = cNet.Filter(Matrix, kernel);

        Matrix = cNet.CreateConvolution(
            Matrix,
            kernelWidth: (int)KernelSizeCounter.Value,
            kernelHeight: (int)KernelSizeCounter.Value);

        var pollingWidth = (int)PollingMaxValue.Value;
        var pollingHeight = (int)PollingMaxValue.Value;
        Matrix = cNet.CreatePollingMax(Matrix, pollingWidth, pollingHeight);

        Matrix = cNet.UpscaleImage(Matrix, width, height);
        OutputImage = cNet.ConvertToBitmap(Matrix);

        pic_box_2.Image = OutputImage;
        pic_box_2.SizeMode = PictureBoxSizeMode.Zoom;
    }
}