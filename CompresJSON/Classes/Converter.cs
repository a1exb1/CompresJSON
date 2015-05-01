﻿//using System;
//using System.Collections.Generic;
//using System.Linq;
using System.Text;
//using System.Web;

namespace CompresJSON
{
    public class Converter
    {

        public static byte[] StringToBytes(string str)
        {
            UTF8Encoding encoding = new UTF8Encoding();
            return encoding.GetBytes(str);
        }

        public static string BytesToString(byte[] bytes)
        {
            UTF8Encoding encoding = new UTF8Encoding();
            return encoding.GetString(bytes);
        }

    }

}




