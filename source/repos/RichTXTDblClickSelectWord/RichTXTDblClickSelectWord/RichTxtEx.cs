using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RichTXTDblClickSelectWord
{
    public class RichTxtEx : System.Windows.Forms.RichTextBox
    {
		protected override void OnDoubleClick(EventArgs e)
		{
            int posStart = this.SelectionStart;

            while (posStart > 0)
            {
                if (this.Text.Substring(posStart, 1) == " ")
                    break;

                posStart = --this.SelectionStart;
            }

            //int posFound = this.Find(new char[] { ';' }, posStart);
            int posFound = this.Find(new char[] { ' ' }, posStart);

            if (posFound > -1)
            {
                this.SelectionStart = posStart;
                this.SelectionLength = posFound - posStart + 1;
            }

            base.OnDoubleClick(e);
		}
    }
}
