using System;
using System.Collections.Generic;
using System.Text;

namespace ImageProcessor.Models
{
   public class CameraData
    {
        public List<CamerafileInfo> Files { get; set; }
        public string NewFileName { get; set; }
        public int SelectedFileNumber { get; set; }
        public bool IsFinish { get; set; }
    }
}
