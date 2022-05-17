using System;

namespace UnitTestDemo
{
    public class Bollocks
    {
        public int BollNum { get; set; }
        public string BollString { get; set; }

        public Bollocks(int bollNum, string bollString)
        {
            BollNum = bollNum;
            BollString = bollString;
        }

        public int AddTo(int n)
        {
            return n + BollNum;
        }
        

        public int DivBy(int n)
        {
            return (BollNum / n);
        }

        public int ModOfDivBy(int n)
        {
            return (BollNum % n);
        }
    }
}
