using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WcfServiceCountWordsInString
{
    public class Service1 : IService1
    {
        public int GetData(string value, string valueToSearch)
        {
            var result = value.Split(new string[] { valueToSearch }, StringSplitOptions.None);

            return result.Count()-1;
        }
    }
}