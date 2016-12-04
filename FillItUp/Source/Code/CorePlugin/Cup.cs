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

		private bool showLimit = true;
		private bool showDebug = false;

		[DontSerialize]
		private SpriteRenderer spriteRenderer = null;

		[DontSerialize]
		private float waterFillHeight = 0f;

		[DontSerialize]
		private readonly Random rnd = new Random();

		[DontSerialize]
		private float waterLimitPosY = 0f;

		[DontSerialize]
		private int waterLimitY = 0;

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
				spriteRenderer = GameObj.GetComponent<SpriteRenderer>();
				gameManager = GameObj.ParentScene.FindComponent<GameManager>();
			}
		}

		public void OnShutdown(ShutdownContext context)
		{
		}

		public void Init()
		{
			SetRandomLimit();
		}

		public void Fill(bool keyState)
		{
			if (keyState)
			{
				if (waterFillHeight <= maxFillHeight)
				{
					Log.Editor.Write("Water Height: " + waterFillHeight + " Range Pos: " + waterLimitPosY);
					waterFillHeight += fillSpeed;
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
			if (DualityApp.Keyboard.KeyHit(Key.A))
			{
				SetRandomLimit();
			}

			if (DualityApp.Keyboard.KeyHit(Key.R))
			{
				Scene.Reload();
			}
		}

		public void RestartGame()
		{
			SetRandomLimit();
			waterFillHeight = 0;
			isFilling = false;
			fillingSoundPlaying = false;
		}

		public void SetRandomLimit()
		{
			showLimit = true;
			var offset = 20;
			limitRange = rnd.Next(10, 30);
			waterLimitPosY = rnd.Next(-maxFillHeight + offset, -offset - limitRange / 2);
			// fix this
			Log.Editor.Write("Range: " + limitRange + " Range Pos: " + waterLimitPosY);
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
			canvas.State.ColorTint = new ColorRgba(52, 152, 219);
			canvas.FillRect(pos.X - cupWidth / 2f, cupBottomPosY - waterFillHeight, 0.2f, cupWidth, waterFillHeight);
		}
	}
}