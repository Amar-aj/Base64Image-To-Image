using Azure.Core;
using System.ComponentModel;
using System.IO;
using System.Text.RegularExpressions;
using System.Threading;
using WinFormsAppImageDbToFolder.AppContext;
using WinFormsAppImageDbToFolder.Models;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

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
                item.Image = path;
                //dbContext.Product.Update(item);
                //await dbContext.SaveChangesAsync();
            }
            MessageBox.Show("Success");
        }

        private async void btnBrand_Click(object sender, EventArgs e)
        {
            var data = dbContext.Brand.ToList();
            foreach (var item in data)
            {
                FileUploadRequest fileUploadRequest = new FileUploadRequest() { Data = item.Image, Name = item.BrandId.ToString(), Extension = ".png" };
                LocalFileStorageService localFileStorageService = new LocalFileStorageService();
                var path = await localFileStorageService.UploadAsync<Brand>(fileUploadRequest, FileType.Image);
                item.Image = path;
                //dbContext.Product.Update(item);
                //await dbContext.SaveChangesAsync();
            }
            MessageBox.Show("Success");
        }

        private async void btnCategory_Click(object sender, EventArgs e)
        {
            var data = dbContext.Category.ToList();
            foreach (var item in data)
            {
                FileUploadRequest fileUploadRequest = new FileUploadRequest() { Data = item.Image, Name = item.CategoryId.ToString(), Extension = ".png" };
                LocalFileStorageService localFileStorageService = new LocalFileStorageService();
                var path = await localFileStorageService.UploadAsync<Category>(fileUploadRequest, FileType.Image);
                item.Image = path;
                //dbContext.Product.Update(item);
                //await dbContext.SaveChangesAsync();
            }
            MessageBox.Show("Success");
        }

        private async void btnCompany_Click(object sender, EventArgs e)
        {
            var data = dbContext.Company.ToList();
            foreach (var item in data)
            {
                FileUploadRequest fileUploadRequest = new FileUploadRequest() { Data = item.Image, Name = item.CompanyId.ToString(), Extension = ".png" };
                LocalFileStorageService localFileStorageService = new LocalFileStorageService();
                var path = await localFileStorageService.UploadAsync<Company>(fileUploadRequest, FileType.Image);
                item.Image = path;
                //dbContext.Product.Update(item);
                //await dbContext.SaveChangesAsync();
            }
            MessageBox.Show("Success");
        }

        private async void btnPayment_Click(object sender, EventArgs e)
        {
            var data = dbContext.Payment.ToList();
            foreach (var item in data)
            {
                FileUploadRequest fileUploadRequest = new FileUploadRequest() { Data = item.Image, Name = item.PaymentId.ToString(), Extension = ".png" };
                LocalFileStorageService localFileStorageService = new LocalFileStorageService();
                var path = await localFileStorageService.UploadAsync<Payment>(fileUploadRequest, FileType.Image);
              
                item.Image = path;
                //dbContext.Product.Update(item);
                //await dbContext.SaveChangesAsync();
            }
            MessageBox.Show("Success");
        }

        private async void btnProductPictureMapping_Click(object sender, EventArgs e)
        {
            var data = dbContext.ProductPictureMapping.ToList();
            foreach (var item in data)
            {
                FileUploadRequest fileUploadRequest = new FileUploadRequest() { Data = item.PictureName, Name = item.ProductId.ToString() + "-" + item.ProductId.ToString(), Extension = ".png" };
                LocalFileStorageService localFileStorageService = new LocalFileStorageService();
                var path = await localFileStorageService.UploadAsync<ProductPictureMapping>(fileUploadRequest, FileType.Image);
                //MessageBox.Show(path);
                item.PictureName = path;
                //item.PicturePath = path;
                //dbContext.Product.Update(item);
                //await dbContext.SaveChangesAsync();
            }
            MessageBox.Show("Success");
        }
    }
}
