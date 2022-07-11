using System;

namespace TextGame.Interfaces
{
    internal interface IPers
    {
        struct Pers
        {
            public enum ColorPers
            {
                red,
                green,
                blue,
            }


            string namePers;
            public string NamePers { get; set; }
            public ColorPers colorPers;
        }
    }
}
