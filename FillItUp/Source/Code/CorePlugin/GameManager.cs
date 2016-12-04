using Duality;
using Duality.Input;
using Duality.Resources;

namespace FillItUp
{
    public class GameManager : Component, ICmpInitializable, ICmpUpdatable
    {
        public Cup ActiveCup
        {
            get { return activeCup; }
            set { activeCup = value; }
        }

        private Cup activeCup = null;

        private ContentRef<Prefab> cupPrefab = null;

        public void OnInit(InitContext context)
        {
            if (context == InitContext.Activate)
            {
                activeCup.Initialize(this);
            }
        }

        public void OnShutdown(ShutdownContext context)
        {
        }

        public void CeateNextCup()
        {
   
        }

        public void OnUpdate()
        {
            var keystate = DualityApp.Keyboard.KeyPressed(Key.Space);
            activeCup?.Fill(keystate);
        }
    }
}