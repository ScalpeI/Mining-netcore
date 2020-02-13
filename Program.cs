using MiningUpdate.Model;
using System;
using System.Threading;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Text;

namespace MiningUpdate
{
    class Program
    {
        Timer _tm = null;

        AutoResetEvent _autoEvent = null;


        RequestMrr req = new RequestMrr();
        RequestMinear reqm = new RequestMinear();
        RequestSp sp = new RequestSp();
        RequestRate rate = new RequestRate();
        bool up = false;
        private void Timer_tick(object sender)
        {
            if ((int.Parse(DateTime.Now.Minute.ToString().Substring(DateTime.Now.Minute.ToString().Length - 1, 1)) == 0) && up || (int.Parse(DateTime.Now.Minute.ToString().Substring(DateTime.Now.Minute.ToString().Length - 1, 1)) == 5 && up))
            {
                up = false;
                Console.WriteLine("Update start: {0}\n",
                            DateTime.Now.ToString("h:mm:ss"));
                new Program().reqm.Upload();
                new Program().req.Upload();
                new Program().sp.Upload();
                //new Program().rate.Upload();
            }
            else if (!up && int.Parse(DateTime.Now.Minute.ToString().Substring(DateTime.Now.Minute.ToString().Length - 1, 1)) != 0 && int.Parse(DateTime.Now.Minute.ToString().Substring(DateTime.Now.Minute.ToString().Length - 1, 1)) != 5)
            {
                up = true;
            }
            else
              Console.WriteLine("Tick: {0}\n",
                DateTime.Now.ToString("h:mm:ss"));

        }
        public void StartTimer()
        {
            _autoEvent = new AutoResetEvent(false);
            _tm = new Timer(Timer_tick, _autoEvent, 1, 1000);
            Console.Read();
        }
        static void Main(string[] args)
        {

            Program p = new Program();
            p.StartTimer();
        }
    }
}

