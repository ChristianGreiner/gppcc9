using Duality;
using Duality.Drawing;
using Duality.Resources;

namespace FillItUp
{
    public class Hud : OverlayRenderer, ICmpInitializable
    {
        public ContentRef<Font> TextFont
        {
            get { return textFont; }
            set { textFont = value; }
        }

        private ContentRef<Font> textFont = Font.GenericMonospace10;

        public void OnInit(InitContext context)
        {

        }

        public void OnShutdown(ShutdownContext context)
        {

        }

        public override void Draw(IDrawDevice device)
        {
            base.Draw(device);
            var canvas = new Canvas(device);
            canvas.State.ColorTint = ColorRgba.Black;
            canvas.State.TransformScale = new Vector2(0.5f);
            canvas.State.TextFont = textFont;
            canvas.DrawText("Score", 20, 30, 0f, Alignment.Left, false);

        }
    }
}