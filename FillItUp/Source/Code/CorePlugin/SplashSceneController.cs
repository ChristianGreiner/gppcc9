using Duality;
using Duality.Input;
using Duality.Resources;

namespace FillItUp
{
	public class SplashSceneController : Component, ICmpUpdatable
	{
        public ContentRef<Scene> MainMenu
        {
            get { return mainMenu; }
            set { mainMenu = value; }
        }

        private ContentRef<Scene> mainMenu = null;

        public void OnUpdate()
        {
            var keyboard = DualityApp.Keyboard;

            if (keyboard.KeyHit(Key.Space))
            {
                if (mainMenu != null)
                    Scene.SwitchTo(mainMenu);
            }
        }
	}
}
