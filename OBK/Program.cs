﻿using OBK.Forms;
using OBK.Forms.StaffForm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OBK
{
    static class Program
    {
        /// <summary>
        /// 해당 응용 프로그램의 주 진입점입니다.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
            
        }
        //static public string serverUrl = "http://192.168.3.16:5000/";
        static public string serverUrl = "http://gdc3.gudi.kr:21001/";
        static public int maxoNum = 0;
    }
}
