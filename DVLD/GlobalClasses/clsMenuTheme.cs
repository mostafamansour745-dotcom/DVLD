using System.Drawing;
using System.Windows.Forms;

namespace DVLD.GlobalClasses
{
    public class CustomMenuRenderer : ToolStripProfessionalRenderer
    {
        public CustomMenuRenderer() : base(new CustomColorTable()) { }

        protected override void OnRenderItemText(ToolStripItemTextRenderEventArgs e)
        {
            e.TextColor = e.Item.Selected ? Color.Gold : Color.White;
            base.OnRenderItemText(e);
        }
    }

    public class CustomColorTable : ProfessionalColorTable
    {
        public override Color ToolStripDropDownBackground => Color.FromArgb(30, 30, 36);
        public override Color MenuBorder => Color.FromArgb(50, 50, 60);
        public override Color MenuItemSelected => Color.FromArgb(60, 60, 70);
        public override Color MenuItemBorder => Color.Gold;
        public override Color MenuItemSelectedGradientBegin => Color.FromArgb(50, 50, 60);
        public override Color MenuItemSelectedGradientEnd => Color.FromArgb(50, 50, 60);
        public override Color MenuItemPressedGradientBegin => Color.FromArgb(40, 40, 50);
        public override Color MenuItemPressedGradientEnd => Color.FromArgb(40, 40, 50);
        public override Color MenuStripGradientBegin => Color.FromArgb(20, 20, 25);
        public override Color MenuStripGradientEnd => Color.FromArgb(20, 20, 25);
    }
}