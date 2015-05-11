using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BlackJack
{
    class Player //kort och pengar. Hit or Stand or Bust. Nanm och kön och ålder.
    {
        private string m_strUSer;

        public string User
        {
            get { return m_strUSer; }
            set { m_strUSer = value; }
        }

        public Player(string strUSer)
        {
            m_strUSer = strUSer;
        }

        public Player()
        {
            Console.WriteLine("Player Called");
        }

        public void GetUser()
        {
            Console.WriteLine("Player: " + m_strUSer);
        }

        ~Player()
        {
            Console.WriteLine("PLayer Destroyed");
        }
    }
}
