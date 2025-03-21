﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomUserAPI.Model
{
    public class Login
    {
        public string uuid { get; set; }
        public string username { get; set; }
        public string password { get; set; }
        public string salt { get; set; }
        public string md5 { get; set; }
        public string sha1 { get; set; }
        public string sha256 { get; set; }
    }
}
