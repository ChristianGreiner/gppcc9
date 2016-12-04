using Duality;
using Duality.Input;
using Duality.Resources;
using System.Diagnostics;

namespace FillItUp
{
	public class GameManager : Component, ICmpInitializable, ICmpUpdatable
	{
		public Cup ActiveCup
		{
			get { return activeCup; }
			set { activeCup = value; }
		}

		public int Score
		{
			get { return score; }
		}

		public bool GameStarted
		{
			get { return gameStarted; }
		}

		public float StartGameTimer
		{
			get { return startGameTimer; }
		}

		public float Countdown
		{
			get { return countdown; }
		}

		public int ComboCounter
		{
			get { return comboCounter; }
		}

		public bool GameOver
		{
			get { return gameOver; }
		}

		private Cup activeCup = null;
		private readonly ContentRef<Sound> comboSound = new ContentRef<Sound>(null, "Data/Audio/combo.Sound.res");

		[DontSerialize]
		private bool gameOver = false;

		[DontSerialize]
		private bool gameStarted = false;

		[DontSerialize]
		private int score = 0;

		[DontSerialize]
		private float startGameTimer = 4000f;

		[DontSerialize]
		private float countdown = 21000f;

		[DontSerialize]
		private float gameoverTimer = 2000f;

		[DontSerialize]
		private int comboCounter = 0;

		[DontSerialize]
		private bool previousScoreSuccess = false;

		public void OnInit(InitContext context)
		{
			if (context == InitContext.Activate)
			{
			}
		}

		public void OnShutdown(ShutdownContext context)
		{
		}

		public void InformScore(bool success)
		{
			if (success)
			{
				previousScoreSuccess = true;

				score++;
				if (previousScoreSuccess)
				{
					comboCounter++;
					Log.Editor.Write("COMBO!");
				}

				// add time to countdown
				if (comboCounter == 5)
				{
					DualityApp.Sound.PlaySound(comboSound);
					countdown += 5000f;

					// reset the combo counter
					comboCounter = 0;
				}
			}
			else
			{
				previousScoreSuccess = false;
				comboCounter = 0;
			}
		}

		public void OnUpdate()
		{
			var keystate = DualityApp.Keyboard.KeyPressed(Key.Space);

			if (gameStarted && !(countdown <= 0.0f))
			{
				activeCup?.Fill(keystate);
				countdown = MathF.Max(0.0f, countdown - Time.MsPFMult * Time.TimeMult);
			}

			if (countdown <= 0.0f)
			{
				gameoverTimer = MathF.Max(0.0f, gameoverTimer - Time.MsPFMult * Time.TimeMult);
				gameOver = true;

				// don't reload the scene instantly when the game is finished an the play spamms the space key
				if (keystate && gameoverTimer <= 0.0f)
					Scene.Reload();
			}

			if (DualityApp.Keyboard.KeyPressed(Key.Escape))
			{
				DualityApp.Terminate();
			}

			if (!gameStarted)
			{
				startGameTimer = MathF.Max(0.0f, startGameTimer - Time.MsPFMult * Time.TimeMult);
				if (startGameTimer <= 0.0f)
				{
					gameStarted = true;
					activeCup?.Init();
				}
			}
		}
	}
}