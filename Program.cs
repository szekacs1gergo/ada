using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Clusse
{
    class Baross
    {
        public int helyezes { get; set; }
        public string varos { get; set; }
        public string orszag { get; set; }
        public int nepesseg { get; set; }
        public Baross(string egysor)
        {
            string[] darabos = egysor.Split(';');
            helyezes = int.Parse(darabos[0]);
            varos = darabos[1];
            orszag = darabos[2];
            nepesseg = int.Parse(darabos[3]);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            /*string[] beolvas = File.ReadAllLines("varosok.txt");
            Baross[] adat = new Baross[beolvas.Length - 1];
            for (int i = 0; i < adat.Length; i++)
            {
                
            }*/
            var sr = new StreamReader("varosok.txt");
            
            List<Baross> adat = new List<Baross>();
            
            while (!sr.EndOfStream)
            {
                Baross sor =new Baross(sr.ReadLine());
                adat.Add(sor);
            }
            sr.Close();
            foreach (var item in adat)
            {
                Console.WriteLine(item.helyezes+";"+item.varos + ";" +item.orszag + ";" +item.nepesseg);
            }
            Console.ReadKey();
        }
    }
}
