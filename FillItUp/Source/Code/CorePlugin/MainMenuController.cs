using Duality;
using Duality.Drawing;
using Duality.Input;
using Duality.Resources;

namespace FillItUp
{
    public class MainMenuController : Component, ICmpUpdatable
    {
        public ContentRef<Scene>  NextScene { get; set; }

        public void OnUpdate()
        {
            var keyboard = DualityApp.Keyboard;

            if (keyboard.KeyHit(Key.Space))
            {
                var sceneSwitcher = GameObj.AddComponent<SceneSwitcher>();
                sceneSwitcher.Switch(NextScene, 500f);
            }   
        }
    }
}