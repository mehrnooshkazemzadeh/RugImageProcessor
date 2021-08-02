using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ImageProcessor.Entities
{
    [Table("RegisterKeyMacs")]
    public class RegisterKeyMac
    {
        public Guid RegisterKeyMacId { get; set; }
        public Guid RegisterKeyId { get; set; }
        public string MacAddress { get; set; }
    }
}
