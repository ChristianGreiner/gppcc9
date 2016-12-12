using Duality;
using Duality.Audio;
using Duality.Components;
using Duality.Input;
using Duality.Resources;
using System;
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

		public int HighestCombo
		{
			get { return highestCombo; }
		}

		private Cup activeCup = null;
		private readonly ContentRef<Sound> comboSound = new ContentRef<Sound>(null, "Data/Audio/combo.Sound.res");
		private readonly ContentRef<Sound> tickingSound = new ContentRef<Sound>(null, "Data/Audio/ticking-clock.Sound.res");
		private readonly ContentRef<Sound> timeSlowdown = new ContentRef<Sound>(null, "Data/Audio/time-slowdown.Sound.res");
		private readonly ContentRef<Sound> timeSpeedup = new ContentRef<Sound>(null, "Data/Audio/time-speedup.Sound.res");
		private SoundInstance tickingSoundInstance = null;

		[DontSerialize]
		private int highestCombo;

		[DontSerialize]
		private bool tickingSoundPlaying = false;

		[DontSerialize]
		private bool slowdownActive = false;

		[DontSerialize]
		private bool gameOver = false;

		[DontSerialize]
		private bool gameStarted = false;

		[DontSerialize]
		private int score = 0;

		[DontSerialize]
		private float startGameTimer = 4000f; // 4000f;

		[DontSerialize]
		private float countdown = 21000f; // 21

		[DontSerialize]
		private float slowdownTimer = 3000f;

		[DontSerialize]
		private float gameoverTimer = 2000f;

		[DontSerialize]
		private int comboCounter = 0;

		[DontSerialize]
		private bool previousScoreSuccess = false;

		private readonly Random rnd = new Random();
		private readonly Vector3Tween cupIntroTween = new Vector3Tween();

		public void OnInit(InitContext context)
		{
			if (context == InitContext.Activate)
			{
				var resX = -DualityApp.TargetResolution.X;
				var cupPos = activeCup.GameObj.Transform.Pos;
				cupIntroTween.Start(new Vector3(resX, cupPos.Y, cupPos.Z), new Vector3(0, cupPos.Y, cupPos.Z), 4000f, Easing.CubicEaseOut);
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

					if (highestCombo < comboCounter)
						highestCombo = comboCounter;
				}

				// add time to countdown
				if ((comboCounter % 5) == 0)
				{
					DualityApp.Sound.PlaySound(comboSound);
					countdown += 3000f;

					// slow down the time
					var slowDownChance = rnd.Next(0, 10);
					if (slowDownChance == 5)
						TimeSlowDown();
				}
			}
			else
			{
				previousScoreSuccess = false;
				comboCounter = 0;

				// speed up the time when the previous score wasnt a combo
				TimeSpeedUp();
			}
		}

		private void TimeSlowDown()
		{
			if (!slowdownActive)
			{
				slowdownActive = true;
				DualityApp.Sound.PlaySound(timeSlowdown);
				Time.TimeScale = .5f;
			}
		}

		private void TimeSpeedUp()
		{
			if (slowdownActive)
			{
				slowdownActive = false;
				Time.TimeScale = 1f;
				slowdownTimer = 3000f;
				DualityApp.Sound.PlaySound(timeSpeedup);
			}
		}

		public void OnUpdate()
		{
			var keystate = DualityApp.Keyboard.KeyPressed(Key.Space);

			if (gameStarted && !(countdown <= 0.0f))
			{
				activeCup?.Fill(keystate);
				countdown = MathF.Max(0.0f, countdown - Time.MsPFMult * Time.TimeMult);

				if (countdown <= 6000.0f && !tickingSoundPlaying)
				{
					tickingSoundInstance = DualityApp.Sound.PlaySound(tickingSound);
					tickingSoundPlaying = true;
					tickingSoundInstance.Looped = true;
				}
			}

			if (slowdownActive && slowdownTimer >= 0.0f)
			{
				slowdownTimer = slowdownTimer - Time.MsPFMult * Time.TimeMult;

				if (slowdownTimer <= 0.0f)
				{
					TimeSpeedUp();
				}
			}

			if (countdown <= 0.0f)
			{
				gameoverTimer = MathF.Max(0.0f, gameoverTimer - Time.MsPFMult * Time.TimeMult);
				gameOver = true;
				tickingSoundInstance?.Stop();

				// don't reload the scene instantly when the game is finished and the play spamms the space key
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

			// for intro animation
			if (cupIntroTween.State == TweenState.Running)
			{
				if (activeCup != null)
					activeCup.GameObj.Transform.Pos = cupIntroTween.CurrentValue;
			}

			cupIntroTween?.Update(Time.LastDelta);
		}
	}
}