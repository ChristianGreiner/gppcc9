using System.Runtime.CompilerServices;
using Duality;
using Duality.Drawing;
using Duality.Resources;

namespace FillItUp
{
    public class HUD : OverlayRenderer
    {
        public ContentRef<Font> ScoreFont
        {
            get { return scoreFont; }
            set { scoreFont = value; }
        }

        public ContentRef<Material> LightBeam
        {
            get { return lightBeam; }
            set { lightBeam = value; }
        }

        public int Score
        {
            get { return score; }
            set { score = value; }
        }

        private ContentRef<Material> lightBeam = null;
        private ContentRef<Font> scoreFont = Font.GenericMonospace10;
        private int score = 0;

        public override void Draw(IDrawDevice device)
        {
            base.Draw(device);

            var canvas = new Canvas(device);
            var resolution = DualityApp.TargetResolution;

            canvas.State.ColorTint = ColorRgba.Black;
            canvas.State.TextFont = scoreFont;
            canvas.DrawText("Score: " + score.ToString(), 20, 20, 0, Alignment.Left);

            if (lightBeam != null && DualityApp.ExecContext != DualityApp.ExecutionContext.Editor)
            {
                canvas.State.SetMaterial(new BatchInfo(DrawTechnique.Multiply, ColorRgba.White, lightBeam.Res.MainTexture));

                canvas.FillRect(0, 0, resolution.X, resolution.Y);
            }
        }
    }
}