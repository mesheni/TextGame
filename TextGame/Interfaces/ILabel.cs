using System;
using System.Collections.Generic;
using System.Text;

namespace TextGame.Interfaces
{
    internal interface ILabel
    {
        struct Label
        {
            private string name;
            private int begin, end;
            private string next;

            public string nameLabel { get; set; }
            public string nextLabel { get; set; }
            public int beginLabel { get; set; }
            public int endLabel { get; set; }
        }
    }
}
