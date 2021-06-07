﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class Memento
    {
        public LEDTV ledTV { get; set; }
        public Memento(LEDTV ledTV)
        {
            this.ledTV = ledTV;
        }
        public string GetDetails()
        {
            return "Memento [ledTV=" + ledTV.GetDetails() + "]";
        }
    }
}
