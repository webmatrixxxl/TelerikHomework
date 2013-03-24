using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DocumentSystem
{
    public abstract class BinaryDocument : Document
    {
        public long? Size { get; protected set; }

        public override void LoadProperty(string key, string value)
        {
            if (key == "size")
            {
                this.Size = long.Parse(value);
            }
            base.LoadProperty(key, value); // Code reuse form Document Class that have LoadeProperty method
        }

        public override void SaveAllProperties(IList<KeyValuePair<string, object>> output)
        {
            output.Add(new KeyValuePair<string, object>("charset", this.Size));
            base.SaveAllProperties(output);

        }
    }

    
}
