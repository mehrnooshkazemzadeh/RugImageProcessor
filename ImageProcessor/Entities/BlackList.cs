using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ImageProcessor.Entities
{
    [Table("BlackList")]
   public class BlackList
    {
        public Guid BlackListId { get; set; }
        public string MacAddress { get; set; }
        public DateTime FromDate { get; set; }
        public DateTime ToDate { get; set; }
        public bool IsActive { get; set; }
    }
}
