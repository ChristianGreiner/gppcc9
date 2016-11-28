using System;
using System.Runtime.InteropServices.ComTypes;
using Duality;
using Duality.Components.Physics;
using Duality.Components.Renderers;
using Duality.Input;

namespace FillItUp
{
    public class Cup : Component, ICmpInitializable, ICmpUpdatable
    {
        public float FillSpeed
        {
            get { return fillSpeed; }
            set { fillSpeed = value; }
        }

        public float FillHeight
        {
            get { return fillHeight; }
            set { fillHeight = value; }
        }

        public SpriteRenderer WaterSpriteRenderer
        {
            get { return waterSpriteRenderer; }
            set { waterSpriteRenderer = value; }
        }

        public float MaxFillHeight
        {
            get { return maxFillHeight; }
            set { maxFillHeight = value; }
        }

        public SpriteRenderer CupLimitSpriteRenderer
        {
            get { return cupLimitSpriteRenderer; }
            set { cupLimitSpriteRenderer = value; }
        }

        private float maxFillHeight = 250f;
        private float fillSpeed = 1;
        private SpriteRenderer waterSpriteRenderer = null;
        private SpriteRenderer cupLimitSpriteRenderer = null;
        private float fillHeight = 200f;
        private readonly Random rnd = new Random();

        public void OnInit(InitContext context)
        {
            if (context == InitContext.Activate)
            {

            }
        }

        public void OnShutdown(ShutdownContext context)
        {
        }

        public void Fill()
        {
            var rec = waterSpriteRenderer.Rect;
            if (rec.H < maxFillHeight)
            {
                var value = rec.H + 1 * fillSpeed * Time.LastDelta;
                waterSpriteRenderer.Rect = new Rect(rec.X, rec.Y, rec.W, value);
            }

        }

        public void SetRandomLimit()
        {
            var rndPos = rnd.Next(-80, 30);
            if (cupLimitSpriteRenderer != null)
            {
                var pos = cupLimitSpriteRenderer.GameObj.Transform.Pos;
                cupLimitSpriteRenderer.GameObj.Transform.Pos = new Vector3(pos.X, rndPos, pos.Z);
            }
        }

        public void OnUpdate()
        {
            if (DualityApp.Keyboard.KeyHit(Key.A))
            {
                SetRandomLimit();
            }
        }
    }
}