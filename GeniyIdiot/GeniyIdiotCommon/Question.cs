using System;
using System.Collections.Generic;
using System.Linq;

namespace GeniyIdiotCommon
{
    public class Question
    {
        public string Text { get; set; }
        public int Answer { get; set; }

        public override string ToString()
        {
            return Text;
        }

    }
}