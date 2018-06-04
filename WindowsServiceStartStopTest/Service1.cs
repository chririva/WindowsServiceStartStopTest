using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;

namespace WindowsServiceStartStopTest
{
    public partial class ServiceStartStopTest : ServiceBase
    {
        public ServiceStartStopTest()
        {
            InitializeComponent();
        }

        protected override void OnStart(string[] args)
        {
            File.Create(@"C:\tmp\onstart.txt");
        }

        protected override void OnStop()
        {
            File.Create(@"C:\tmp\onstop.txt");
        }
    }
}
