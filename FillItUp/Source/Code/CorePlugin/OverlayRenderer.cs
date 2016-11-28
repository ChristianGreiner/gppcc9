using Duality;
using Duality.Drawing;
using Duality.Editor;

namespace FillItUp
{
	public abstract class OverlayRenderer : Component, ICmpRenderer
	{
		[EditorHintFlags(MemberFlags.Invisible)]
		public float BoundRadius { get; }

		public bool IsVisible(IDrawDevice device)
		{
			return (device.VisibilityMask & VisibilityFlag.AllGroups) != VisibilityFlag.None &&
					(device.VisibilityMask & VisibilityFlag.ScreenOverlay) != VisibilityFlag.None;
		}

		public virtual void Draw(IDrawDevice device)
		{
		}
	}
}