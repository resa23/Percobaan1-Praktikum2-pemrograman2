﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P2_1_1204053
{
    public class DVD: Product_1204053
    {
        protected string duration;

        public DVD(string title, string duration)
        {
            this.MyTitle = title;
            this.Duration = duration;
            this.MyType = "DVD";

            Console.WriteLine("Ini dari class DVD");
        }

        public string Duration
    {
        get
        {
            return duration;
        }

        set
        {
            duration = value;
        }
      }
   }
}
