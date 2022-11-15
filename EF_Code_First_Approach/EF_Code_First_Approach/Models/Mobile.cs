using System.ComponentModel.DataAnnotations;

namespace EF_Code_First_Approach.Models
{
    public class Mobile
    {
        [Key]
        public int MobID { get; set; }
        public string? MobBrand { get; set; }
        public string? MobModel { get; set; }
        public int MobPrice { get; set; }
    }
}
