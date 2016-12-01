using Duality;
using Duality.Drawing;
using Duality.Editor;
using Duality.Resources;
using System;

namespace FillItUp
{
	public class ColorFader : OverlayRenderer, ICmpUpdatable
	{
		[EditorHintFlags(MemberFlags.Invisible)]
		public EventHandler Faded
		{
			get { return faded; }
			set { faded = value; }
		}

		public bool DisposeLater
		{
			get { return disposeLater; }
			set { disposeLater = value; }
		}

		private EventHandler faded;

		private bool disposeLater = false;

		[DontSerialize]
		private readonly ColorTween colorTween = new ColorTween();

		[DontSerialize]
		private bool isFading = false;

		public void FadeIn(float duration, Easing easing, ColorRgba fadingClolor)
		{
			if (!isFading)
			{
				colorTween.Start(fadingClolor, new ColorRgba(0, 0, 0, 0f), duration, easing);
				isFading = true;
			}
		}

		public void FadeOut(float duration, Easing easing, ColorRgba fadingClolor)
		{
			if (!isFading)
			{
				colorTween.Start(new ColorRgba(0, 0, 0, 0f), fadingClolor, duration, easing);
				isFading = true;
			}
		}

		public void OnUpdate()
		{
			colorTween.Update(Time.LastDelta);

			if (colorTween.State == TweenState.Stopped)
			{
				faded?.Invoke(this, EventArgs.Empty);
				colorTween.Stop(StopBehavior.ForceComplete);
				isFading = false;

				if (disposeLater)
					GameObj.DisposeLater();
			}
		}

		public override void Draw(IDrawDevice device)
		{
			base.Draw(device);
			if (colorTween.State == TweenState.Running)
			{
				var canvas = new Canvas(device);
				canvas.State.SetMaterial(new BatchInfo(DrawTechnique.Alpha, colorTween.CurrentValue));
				canvas.FillRect(0, 0, DualityApp.TargetResolution.X, DualityApp.TargetResolution.Y);
			}
		}
	}
}