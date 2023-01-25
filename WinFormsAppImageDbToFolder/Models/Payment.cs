using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsAppImageDbToFolder.Models
{
    public class Payment
    {
        [Key]
        public int PaymentId { get; set; }
        [Required]
        public string Name { get; set; }
        public string Description { get; set; }
        public string PublicKey { get; set; }
        public string PrivateKey { get; set; }
        public string Image { get; set; }
    }
}
