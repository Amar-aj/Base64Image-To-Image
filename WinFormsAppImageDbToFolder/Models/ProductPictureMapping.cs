using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsAppImageDbToFolder.Models
{
    public class ProductPictureMapping
    {
        [Key]
        public int ProductPictureMappingId { get; set; }
        [Required]
        public int ProductId { get; set; }
        public string PictureName { get; set; }
        public string PicturePath { get; set; }
        public bool IsActive { get; set; }
        public DateTime? CreatedOn { get; set; }
        public DateTime? ModifiedOn { get; set; }
    }
}
