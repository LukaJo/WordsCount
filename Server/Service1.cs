using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace Server
{
    public class Service1 : IService1
    {
        public int GetWordsCount(string text)
        {
            char[] delimiters = new char[] { ' ', '\r', '\n', ',', '.', ':', ';', '!', '?', '%', '&', '(', ')', '/', '-', '_', '*', '+', '=', '|', '[', ']', '{', '}', '<', '>', '#', '@', '$', '~', '^'};

            return text.Split(delimiters, StringSplitOptions.RemoveEmptyEntries).Length;
        }

    }
}
