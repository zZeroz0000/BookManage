namespace WebApplication2.Models
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("Book")]
    public partial class Book
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        
        public int ID { get; set; }

        [Required(ErrorMessage = "Tiêu đề không được để trống")]
        [StringLength(250, ErrorMessage = "Tiêu đề sách không quá 250 kí tự")]
        [Display(Name = "Tiêu đề")]
        public string Title { get; set; }

        [Required(ErrorMessage = "Mô tả không được để trống")]
        [StringLength(250, ErrorMessage = "Mô tả sách không quá 100 kí tự")]
        [Display(Name = "Mô tả")]
        public string Descriptions { get; set; }

        [Required(ErrorMessage = "Tác giả không được để trống")]
        [StringLength(250, ErrorMessage = "Tác giả sách không quá 30 kí t?")]
        [Display(Name = "Tác giả")]
        public string Author { get; set; }

        [Display(Name = "Ảnh")]
        public string Images { get; set; }

        [Required(ErrorMessage = "Giá không được để trống")]
        [Range(1000,1000000,ErrorMessage="Giá tiền trong khoảng 1000 và 1000000")]
        [Display(Name = "Giá")]
        public int? Price { get; set; }
    }
}
