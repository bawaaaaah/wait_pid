using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wait_pid
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] pid = new int[args.Length];
            for(int i = args.Length; i-- > 0;)
            {
                if (!int.TryParse(args[i], out pid[i]))
                {
                    throw (new Exception("INVALIDE PARAMETER DOESN'T SEEM TO BE A INTEGER => " + args[i]));
                }
                if(pid[i] <= 0)
                    throw (new Exception("INVALIDE PARAMETER DOESN'T SEEM TO BE A GREATER THAN 0 PID=> " + args[i]));
            }
            Process p;
            for (int i = pid.Length; i-- > 0;)
            {
                try
                {
                    p = Process.GetProcessById(pid[i]);
                    p.WaitForExit();
                }
                catch (Exception)
                {
                }
            }
        }
    }
}
