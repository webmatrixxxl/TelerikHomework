using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DocumentSystem
{
    public class ExcelDocument : OfficeDocument
    {
        public long? Rows { get; protected set; }
        public long? Cols { get; protected set; }

        public override void LoadProperty(string key, string value)
        {
            if (key == "rows")
            {
                this.Rows = long.Parse(value);
            }
            else if (key == "cols")
            {
                this.Cols = long.Parse(value);
            }
            base.LoadProperty(key, value); // Code reuse form Document Class that have LoadeProperty method
        }

        public override void SaveAllProperties(IList<KeyValuePair<string, object>> output)
        {
            output.Add(new KeyValuePair<string, object>("rows", this.Rows));
            output.Add(new KeyValuePair<string, object>("cols", this.Cols));
            base.SaveAllProperties(output);

        }
    }

    
}
