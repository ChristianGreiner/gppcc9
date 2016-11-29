using Duality;
using Duality.Input;

namespace FillItUp
{
	public class GameManager : Component, ICmpUpdatable
	{
		public HUD Hud
		{
			get { return hud; }
			set { hud = value; }
		}

		public Cup ActiveCup
		{
			get { return activeCup; }
			set { activeCup = value; }
		}

		private HUD hud = null;

		private Cup activeCup = null;

		public void OnUpdate()
		{
			var keyboard = DualityApp.Keyboard;
			var buttonState = keyboard.KeyPressed(Key.Space);

			if (hud != null)
				hud.Score++;

			activeCup?.Fill(buttonState);
		}
	}
}