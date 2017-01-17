using System;
using System.Collections.Generic;
using System.Text;

namespace Core
{
    public class Message : IMessage
    {
        string IMessage.Hello(string Name)
        {
            return String.Format("Hello {0}!!", Name);
        }
    }
}
