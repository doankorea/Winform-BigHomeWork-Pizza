using System;
using System.Drawing;
using System.Windows.Forms;

namespace QlyNhaHangPizza.Model
{
    public partial class ucProduct : UserControl
    {
        public ucProduct()
        {
            InitializeComponent();
        }

        public event EventHandler onSelect = null;
        public int id { get; set; }

        public string PName
        {
            get { return lblName.Text; }
            set { lblName.Text = value; }
        }

        public float PPrice { get; set; }
        public int PCategory { get; set; }

        public string ImagePath { get; set; } // Thêm thuộc tính để lưu đường dẫn ảnh

        public void LoadImage()
        {
            if (!string.IsNullOrEmpty(ImagePath) && System.IO.File.Exists(ImagePath))
            {
                txtImage.Image = Image.FromFile(ImagePath);
            }
            else
            {
                txtImage.Image = null; 
            }
        }

        private void txtImage_Click(object sender, EventArgs e)
        {
            onSelect?.Invoke(this, e);
        }
    }
}
