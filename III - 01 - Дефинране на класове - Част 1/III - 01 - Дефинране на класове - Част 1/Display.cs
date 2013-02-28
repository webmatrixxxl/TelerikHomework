using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace III___01___Дефинране_на_класове___Част_1
{
    class Display
    {
        //<fields>
        private int? width;
        private int? height;
        private int? colors;
        //</fields>

        //<constructor>
        public Display()
            : this(null, null, null)
        {

        }
        public Display(int? height, int? width, int? colors)
        {
            this.height = height;
            this.width = width;
            this.colors = colors;
        }
        //<constructor>

        //<properties>
        public int? Width
        {
            get
            {
                return this.width;
            }

            set
            {
                this.width = value;
            }
        }
        public int? Height
        {
            get
            {
                return this.height;
            }

            set
            {
                this.height = value;
            }
        }
        public int? Colors
        {
            get
            {
                return this.colors;
            }

            set
            {
                this.colors = value;
            }
        }
        //</properties>

    }
   
}
