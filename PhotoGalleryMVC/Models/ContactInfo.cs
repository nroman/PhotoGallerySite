using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PhotoGalleryMVC.Models
{
    public class ContactInfo
    {
        public String FullName { get; set; }

        public String Email { get; set; }

        public String MessageText { get; set; }

        public Byte[] File { get; set; }
    }
}