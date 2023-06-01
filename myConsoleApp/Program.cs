// See https://aka.ms/new-console-template for more information

using System;
using log4net;
using log4net.Config;



namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(typeof(Program));
        //private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        static void Main(string[] args)
        {
            XmlConfigurator.Configure(new System.IO.FileInfo("log4net.config"));

            Console.WriteLine("Hello World!");
            log.Info("Program started");
            log.Error("uppss sth happend");

            myLibrary.Class1 ml= new myLibrary.Class1();
            string st= ml.Capitalize("doG Is chAsinG A cat");
            Console.WriteLine(st);

            myLibrary.Class2 ml2= new myLibrary.Class2();
            st=ml2.MakeLower(st);
            Console.WriteLine(st);

            log.Debug(st);
        }
    }
}



