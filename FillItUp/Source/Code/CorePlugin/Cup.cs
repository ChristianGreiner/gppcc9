using Duality;
using Duality.Audio;
using Duality.Components;
using Duality.Components.Renderers;
using Duality.Drawing;
using Duality.Input;
using Duality.Resources;
using System;

namespace FillItUp
{
	public class Cup : Renderer, ICmpInitializable, ICmpUpdatable
	{
		public override float BoundRadius { get; } = float.MaxValue;

		public float CupWidth
		{
			get { return cupWidth; }
			set { cupWidth = value; }
		}

		public float CupBottomPosY
		{
			get { return cupBottomPosY; }
			set { cupBottomPosY = value; }
		}

		public float WaterFillHeight
		{
			get { return waterFillHeight; }
		}

		public int MaxFillHeight
		{
			get { return maxFillHeight; }
			set { maxFillHeight = value; }
		}

		public float FillSpeed
		{
			get { return fillSpeed; }
			set { fillSpeed = value; }
		}

		private float cupWidth = 110f;
		private float cupBottomPosY = 80f;
		private int maxFillHeight = 160;
		private float fillSpeed = 2f;
		private readonly ContentRef<Sound> fillingSound = new ContentRef<Sound>(null, "Data/Audio/cup-fill.Sound.res");
		private readonly ContentRef<Sound> successSound = new ContentRef<Sound>(null, "Data/Audio/success.Sound.res");
		private readonly Random rnd = new Random();

		private readonly ColorRgba waterColor = new ColorRgba(52, 152, 219);
		private readonly ColorRgba coffeeColor = new ColorRgba(111, 78, 55);
		private readonly ColorRgba sodaColor = new ColorRgba(241, 196, 15);
		private readonly ColorRgba greenTeeColor = new ColorRgba(46, 204, 113);

		private bool showLimit = true;
		private bool showDebug = false;

		[DontSerialize]
		private ColorRgba currentLiquidColor = ColorRgba.White;

		[DontSerialize]
		private float waterFillHeight = 0f;

		[DontSerialize]
		private float waterLimitPosY = 0f;

		[DontSerialize]
		private int limitRange = 0;

		[DontSerialize]
		private bool isFilling = false;

		[DontSerialize]
		private bool fillingSoundPlaying = false;

		[DontSerialize]
		private SoundInstance fillingSoundInstance = null;

		[DontSerialize]
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

		public void Init()
		{
			SetRandomLimit();
			currentLiquidColor = waterColor;
		}

		public void Fill(bool keyState)
		{
			if (keyState)
			{
				if (waterFillHeight <= maxFillHeight)
				{
					waterFillHeight += fillSpeed * Time.TimeScale;
					isFilling = true;
				}
			}

			// play filling sound
			if (isFilling && !fillingSoundPlaying)
			{
				fillingSoundInstance = DualityApp.Sound.PlaySound(fillingSound);
				fillingSoundPlaying = true;
			}

			if (!keyState && isFilling)
			{
				fillingSoundInstance.Stop();
				if (waterFillHeight >= -waterLimitPosY - limitRange / 2 && waterFillHeight <= -waterLimitPosY + limitRange / 2)
				{
					Log.Editor.Write("WON");
					DualityApp.Sound.PlaySound(successSound);
					gameManager?.InformScore(true);
				}
				else
				{
					gameManager?.InformScore(false);
					Log.Editor.Write("LOOSE");
				}

				RestartGame();
			}
		}

		public void OnUpdate()
		{
		}

		public void RestartGame()
		{
			SetRandomLimit();
			waterFillHeight = 0;
			isFilling = false;
			fillingSoundPlaying = false;

			// set random color
			var colorId = rnd.Next(0, 4);
			switch (colorId)
			{
				case 0:
					currentLiquidColor = waterColor;
					break;

				case 1:
					currentLiquidColor = coffeeColor;
					break;

				case 2:
					currentLiquidColor = sodaColor;
					break;

				case 3:
					currentLiquidColor = greenTeeColor;
					break;
			}
		}

		public void SetRandomLimit()
		{
			showLimit = true;
			var offset = 20;
			limitRange = rnd.Next(10, 30);
			waterLimitPosY = rnd.Next(-maxFillHeight + offset, -offset - limitRange / 2);
		}

		public override void Draw(IDrawDevice device)
		{
			var canvas = new Canvas(device);
			var pos = GameObj.Transform.Pos;

			if (showLimit)
			{
				// draw fill limit
				canvas.State.ColorTint = new ColorRgba(255, 0, 0, 0.5f);
				canvas.FillRect(pos.X - cupWidth / 2f, waterLimitPosY - limitRange / 2, 0.1f, cupWidth, limitRange);

				if (showDebug)
				{
					canvas.State.ColorTint = ColorRgba.White;
					canvas.DrawLine(pos.X - cupWidth / 2f, waterLimitPosY, pos.X + cupWidth / 2, waterLimitPosY);

					// draw borders
					canvas.State.ColorTint = ColorRgba.Green;
					canvas.DrawLine(pos.X - cupWidth / 2f, waterLimitPosY + limitRange / 2, pos.X + cupWidth / 2, waterLimitPosY + limitRange / 2);
					canvas.DrawLine(pos.X - cupWidth / 2f, waterLimitPosY - limitRange / 2, pos.X + cupWidth / 2, waterLimitPosY - limitRange / 2);
				}
			}

			// draw water
			canvas.State.ColorTint = currentLiquidColor;
			canvas.FillRect(pos.X - cupWidth / 2f, cupBottomPosY - waterFillHeight, 0.2f, cupWidth, waterFillHeight);
		}
	}
}