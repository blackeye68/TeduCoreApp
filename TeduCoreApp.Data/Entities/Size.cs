using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TeduCoreApp.Data.Entities
{
    [Table("Sizes")]
    public class Size
    {
        [StringLength(250)]
        public string Name
        {
            get; set;
        }
    }
}