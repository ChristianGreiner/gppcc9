using Duality;
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
                if (NextScene != null)
                {
                    Scene.SwitchTo(NextScene);
                }
            }
        }
    }
}