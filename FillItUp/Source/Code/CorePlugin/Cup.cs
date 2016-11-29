using Duality;
using Duality.Components.Renderers;

namespace FillItUp
{
	public class Cup : Component, ICmpInitializable
	{
		public SpriteRenderer WaterRenderer
		{
			get { return waterRenderer; }
			set { waterRenderer = value; }
		}

		public float MaxFillHeight
		{
			get { return maxFillHeight; }
			set { maxFillHeight = value; }
		}

		public float FillSpeed
		{
			get { return fillSpeed; }
			set { fillSpeed = value; }
		}

		private SpriteRenderer waterRenderer = null;
		private float maxFillHeight = 250f;
		private float fillSpeed = 1;

		public void OnInit(InitContext context)
		{
		}

		public void OnShutdown(ShutdownContext context)
		{
		}

		public void Fill(bool keyState)
		{
			Log.Editor.Write("Button State: " + keyState);

			if (waterRenderer == null) return;
			var rec = waterRenderer.Rect;
			if (rec.H < maxFillHeight)
			{
				var value = rec.H + 1 * fillSpeed * Time.LastDelta;
				waterRenderer.Rect = new Rect(rec.X, rec.Y, rec.W, value);
			}
		}
	}
}