using Duality;
using Duality.Drawing;
using Duality.Editor;
using Duality.Resources;
using System;

namespace FillItUp
{
	public class SceneSwitcher : Component
	{
		[EditorHintFlags(MemberFlags.Invisible)]
		public float BoundRadius { get; }

		public ContentRef<Scene> NextScene
		{
			get { return nextScene; }
			set { nextScene = value; }
		}

		public ColorRgba FadingColor
		{
			get { return fadingColor; }
			set { fadingColor = value; }
		}

		public float FadingDuration
		{
			get { return fadingDuration; }
			set { fadingDuration = value; }
		}

		[EditorHintFlags(MemberFlags.Invisible)]
		public EventHandler<SceneSwitchEventArgs> SceneSwitched
		{
			get { return sceneSwitched; }
			set { sceneSwitched = value; }
		}

		private ContentRef<Scene> nextScene;
		private ColorRgba fadingColor = ColorRgba.Black;
		private float fadingDuration = 2000f;
		private EventHandler<SceneSwitchEventArgs> sceneSwitched;

		[DontSerialize]
		private bool startSwitching = false;

		public void Switch()
		{
			if (!startSwitching)
			{
				startSwitching = true;
				var faderOut = GameObj.AddComponent<ColorFader>();
				faderOut.FadeOut(fadingDuration, Easing.Linear, fadingColor);
				faderOut.DisposeLater = true;

				var faderIn = new GameObject("ColorFader").AddComponent<ColorFader>();
				faderIn.FadeIn(fadingDuration, Easing.Linear, fadingColor);
				faderIn.DisposeLater = true;
				faderOut.Faded += delegate
				{
					if (nextScene != null)
					{
						nextScene.Res.AddObject(faderIn.GameObj);
						Scene.SwitchTo(nextScene);
						startSwitching = false;
					}
				};
			}
		}

		public void Switch(ContentRef<Scene> scene, float duration = 2000f)
		{
			nextScene = scene;
			fadingDuration = duration;
			Switch();
		}
	}

	public class SceneSwitchEventArgs : EventArgs
	{
		public ContentRef<Scene> NextScene
		{
			get { return nextScene; }
			set { nextScene = value; }
		}

		private ContentRef<Scene> nextScene;

		public SceneSwitchEventArgs(ContentRef<Scene> nextScene)
		{
			this.nextScene = nextScene;
		}
	}
}