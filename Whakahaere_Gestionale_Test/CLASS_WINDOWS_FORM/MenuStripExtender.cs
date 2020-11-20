using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace Override
{
    //  Implement class on your object:
    //  using Override; 
    //  toolStripName.Renderer = new ToolStripProfessionalRenderer(new MyColorTable());


    public class MyColorTable : ProfessionalColorTable
    {
        public override Color ToolStripDropDownBackground
        {
            get
            { 
                return Color.Gray;
            }
        }

        public override Color ImageMarginGradientBegin
        {
            get
            { 
                return Color.Gray;
            }
        }

        public override Color ImageMarginGradientMiddle
        {
            get
            {
                return Color.Gray;
            }
        }

        public override Color ImageMarginGradientEnd
        {
            get
            {
                return Color.Gray;
            }
        }

        public override Color MenuBorder
        {
            get
            {
                return Color.Gray;
            }
        }

        public override Color MenuItemBorder
        {
            get
            {
                return Color.Gray;
            }
        }

        public override Color MenuItemSelected
        {
            get
            {
                return Color.Blue;
            }
        }

        public override Color MenuStripGradientBegin
        {
            get
            {
                return Color.Violet;
            }
        }

        public override Color MenuStripGradientEnd
        {
            get
            {

                return Color.Gray;
            }
        }

        public override Color MenuItemSelectedGradientBegin
        {
            get
            {
                return Color.Transparent; //selezione, colore sovrastante

            }
        }

        public override Color MenuItemSelectedGradientEnd
        {
            get
            {
                return Color.Transparent;// Color.Black; //selezione, colore sottostante
            }
        }

        public override Color MenuItemPressedGradientBegin
        {
            get
            {
                return Color.Blue;
            }
        }

        public override Color MenuItemPressedGradientEnd
        {
            get
            {
                return Color.Blue;
            }
        }

    }

}
