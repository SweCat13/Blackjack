using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BlackJack
{
    class Player //kort och pengar. Hit or Stand or Bust. Nanm och kön och ålder.
    {
        private string m_strUSer;
        private int m_iAge;

        public int Age
        {
            get { return m_iAge; }
            set { m_iAge = value; }
        }

        public string User
        {
            get { return m_strUSer; }
            set { m_strUSer = value; }
        }

        public Player()
        {
            Console.WriteLine("Player Called");
        }

        ~Player()
        {
            Console.WriteLine("PLayer Destroyed");
        }
    }
}
