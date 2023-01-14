using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ER2_ObjComposition.Entities
{
    internal class Comment
    {
        public string Text { get; set; }

        public Comment(string Text)
        {
            this.Text = Text;
        }
        public override string ToString()
        {
            return Text;
        }
    }
}
