using ImageProcessor.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ImageProcessor.Models
{
    public class BlackListManager
    {
        public static bool IsMacAddressInBlackList(string macAddress)
        {
            using (var context =new RegisterDbContext())
            {
                return context.BlackLists.Any(x => x.MacAddress == macAddress && x.IsActive);
            }
        }
    }
}
