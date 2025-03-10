﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Altkom._3_5._07._2024.DesignPatterns.Structural.PrivateClassData
{
    internal class PrivateClassData
    {
        private int _intValue;
        private string _stringValue;

        public PrivateClassData(int intValue, string stringValue)
        {
            _intValue = intValue;
            _stringValue = stringValue;
        }

        public int GetIntValue()
        {
            return _intValue;   
        }

        public string GetStringValue() {
            return _stringValue;
        }

    }
}
