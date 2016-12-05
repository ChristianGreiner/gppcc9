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

		private readonly FormattedText gameStartTimerText = new FormattedText();
		private readonly FormattedText countdownText = new FormattedText();
		private readonly FormattedText comboCounterText = new FormattedText();
		private ContentRef<Font> textFont = Font.GenericMonospace10;
		private GameManager gameManager = null;

		public void OnInit(InitContext context)
		{
			if (context == InitContext.Activate)
			{
				gameManager = GameObj.ParentScene.FindComponent<GameManager>();
			}
		}

		public void OnShutdown(ShutdownContext context)
		{
		}

		public override void Draw(IDrawDevice device)
		{
			base.Draw(device);
			var canvas = new Canvas(device);
			var resolution = DualityApp.TargetResolution;

			canvas.State.ColorTint = ColorRgba.Black;
			canvas.State.TextFont = textFont;

			if (!gameManager.GameStarted)
			{
				const float backgroundHeight = 200f;
				var countdownValue = (int)(gameManager.StartGameTimer / 1000f);
				gameStartTimerText.ApplySource(countdownValue > 0 ? countdownValue.ToString() : "GO");

				// countdown text
				canvas.State.ColorTint = ColorRgba.White;
				canvas.State.TransformScale = new Vector2(2);
				canvas.DrawText(gameStartTimerText.SourceText, resolution.X / 2f, resolution.Y / 2f, 0f, Alignment.Center);

				// background
				canvas.State.TransformScale = new Vector2(1);
				canvas.State.ColorTint = new ColorRgba(0, 0, 0, 0.9f);
				canvas.FillRect(0, resolution.Y / 2 - backgroundHeight / 2, 0.05f, resolution.X, backgroundHeight);
			}
			else if (gameManager.GameStarted)
			{
				// score
				canvas.State.TransformScale = new Vector2(0.5f);
				canvas.DrawText(gameManager.Score.ToString(), resolution.X / 2f, resolution.Y / 2f + 120, 0f, Alignment.Center);

				// countdown
				var countdownValue = (int)(gameManager.Countdown / 1000f);
				canvas.State.TransformScale = new Vector2(1f);
				canvas.State.ColorTint = countdownValue > 5 ? ColorRgba.Black : new ColorRgba(231, 76, 60);
				countdownText.ApplySource(countdownValue.ToString());
				canvas.DrawText("Time left: " + countdownText.SourceText, resolution.X / 2f, resolution.Y / 2f - 200, 0f, Alignment.Center);

				// combo counter
				var comboValue = gameManager.ComboCounter;
				canvas.State.TransformScale = new Vector2(0.75f);
				canvas.State.ColorTint = comboValue >= 3 ? new ColorRgba(39, 174, 96) : ColorRgba.Black;
				comboCounterText.ApplySource(comboValue.ToString());
				canvas.DrawText("Combos: " + comboCounterText.SourceText, resolution.X / 2f, resolution.Y / 2f - 140, 0.1f, Alignment.Center);
			}

			if (gameManager.GameOver)
			{
				const float backgroundHeight = 300f;
				gameStartTimerText.ApplySource("GAME OVER");

				// game over text
				canvas.State.ColorTint = ColorRgba.White;
				canvas.State.TransformScale = new Vector2(1.5f);
				canvas.DrawText(gameStartTimerText.SourceText, resolution.X / 2f, resolution.Y / 2f - 60, 0f, Alignment.Center);

				// cups filled text
				canvas.State.TransformScale = new Vector2(0.5f);
				canvas.DrawText("YOU FILLED " + gameManager.Score + " CUPS", resolution.X / 2f, resolution.Y / 2f + 20f, 0f, Alignment.Center);

				// restart game text
				canvas.State.TransformScale = new Vector2(0.45f);
				canvas.DrawText("PRESS SPACE TO RESTART", resolution.X / 2f, resolution.Y / 2f + 80f, 0f, Alignment.Center);

				// background
				canvas.State.TransformScale = new Vector2(1);
				canvas.State.ColorTint = new ColorRgba(0, 0, 0, 0.9f);
				canvas.FillRect(0, resolution.Y / 2 - backgroundHeight / 2, 0.05f, resolution.X, backgroundHeight);
			}
		}
	}
}