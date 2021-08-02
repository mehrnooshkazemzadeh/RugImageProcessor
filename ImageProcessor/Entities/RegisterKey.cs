using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ImageProcessor.Entities
{
    [Table("RegisterKeys")]
   public class RegisterKey
    {
        public Guid RegisterKeyId { get; set; }
        public string ProductName { get; set; }
        public string Key { get; set; }
        public int ValidNumber { get; set; }
        public int UsedNumber { get; set; }
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public bool IsUsed { get; set; }
    }
}
