using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DocumentSystem
{
    public class AudioDocument : MultimediaDocument
    {
        public long? SempleRate { get; protected set; }

        public override void LoadProperty(string key, string value)
        {
            if (key == "semplerate")
            {
                this.SempleRate = long.Parse(value);
            }
            base.LoadProperty(key, value); // Code reuse form Document Class that have LoadeProperty method
        }

        public override void SaveAllProperties(IList<KeyValuePair<string, object>> output)
        {
            output.Add(new KeyValuePair<string, object>("semplerate", this.SempleRate));
            base.SaveAllProperties(output);

        }
    }

    
}
