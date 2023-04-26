using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Blood_Bank_Manager
{
    public partial class AboutUsUC : UserControl
    {
        public AboutUsUC()
        {
            InitializeComponent();
        }

        // To make sure only one instance is created
        private static AboutUsUC _instance;
        public static AboutUsUC Instance {
            get {
                if (_instance == null) {
                    _instance = new AboutUsUC();
                }
                //_instance.bindUI();
                return _instance;
            }
        }
    }
}
