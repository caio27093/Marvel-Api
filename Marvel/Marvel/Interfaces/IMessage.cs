using System;
using System.Collections.Generic;
using System.Text;

namespace Marvel.Interfaces
{
    public interface IMessage
    {
        void LongAlert ( string message );
        void ShortAlert ( string message );
        string PegaJson();
        string PegaJsonPersonagens();
    }
}
