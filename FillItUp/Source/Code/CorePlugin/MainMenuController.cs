using Duality;
using Duality.Input;
using Duality.Resources;

namespace FillItUp
{
    public class MainMenuController : Component, ICmpUpdatable
    {
        public ContentRef<Scene> GameScene
        {
            get { return gameScene; }
            set { gameScene = value; }
        }

        private ContentRef<Scene> gameScene = null;

        public void OnUpdate()
        {
            var keyboard = DualityApp.Keyboard;

            if (keyboard.KeyHit(Key.Space))
            {

            }
        }
    }
}