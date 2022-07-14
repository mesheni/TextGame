using System;

namespace TextGame.Interfaces
{
    internal interface IPers
    {
        struct Pers
        {
            public enum Color
            {
                red,
                green,
                blue,
            }
            private string name;
            private string alias;

            
            public string namePers { get; set; }
            public Color colorPers;
            public string aliasPers { get; set; }
        }
    }
}
