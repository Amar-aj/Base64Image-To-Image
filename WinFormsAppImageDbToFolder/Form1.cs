using Azure.Core;
using System.ComponentModel;
using System.Text.RegularExpressions;
using System.Threading;
using WinFormsAppImageDbToFolder.AppContext;
using WinFormsAppImageDbToFolder.Models;

namespace WinFormsAppImageDbToFolder
{
    public partial class Form1 : Form
    {
        private ApplicationDbContext? dbContext;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.dbContext = new ApplicationDbContext();

        }

        private async void btnProduct_Click(object sender, EventArgs e)
        {
            var products = dbContext.Product.ToList();
            foreach (var item in products)
            {
                FileUploadRequest fileUploadRequest = new FileUploadRequest() { Data = item.Image, Name = item.ProductId.ToString(), Extension = ".png" };
                LocalFileStorageService localFileStorageService = new LocalFileStorageService();
                var path = await localFileStorageService.UploadAsync<Product>(fileUploadRequest, FileType.Image);
                MessageBox.Show(path);
                item.Image= path;
                //dbContext.Product.Update(item);
                //await dbContext.SaveChangesAsync();
            }



        }
      

    }
}
 