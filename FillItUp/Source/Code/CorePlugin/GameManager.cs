using Duality;
using Duality.Input;

namespace FillItUp
{
    public class GameManager : Component, ICmpUpdatable
    {
        public Cup ActiveCup
        {
            get { return activeCup; }
            set { activeCup = value; }
        }

        private Cup activeCup = null;

        public void OnUpdate()
        {
            var keystate = DualityApp.Keyboard.KeyPressed(Key.Space);
            activeCup?.Fill(keystate);
        }
    }
}