﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GESECO.BLL
{
    public static class Common
    {
        public static void WriteToFile(this Exception ex)
        {
            using (StreamWriter sw = new StreamWriter("geseco.log", true))
            {
                sw.WriteLine
                (
                    $"{DateTime.Now}\n{ex}\n"
                );
            }
        }

    }
}
