using System;
using System.Collections.Generic;
using System.Text;

namespace Task_1._1._6
{
    class title_parameters 
    {
        bool bold;
        bool italic;
        bool underline;
        public bool Bold
        {
            get
            {
                return bold;
            }

            set
            {
                bold = value; 
            }
        }
        public bool Italic
        {
            get
            {
                return italic;
            }

            set
            {
                italic = value;
            }
        }
        public bool Underline
        {
            get
            {
                return underline;
            }

            set
            {
                underline = value;
            }
        }
    }
}
