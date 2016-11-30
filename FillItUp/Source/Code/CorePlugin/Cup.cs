using System;
using Duality;
using Duality.Components;
using Duality.Drawing;
using Duality.Input;
using Duality.Resources;

namespace FillItUp
{
    public class Cup : Renderer, ICmpInitializable, ICmpUpdatable
    {
        public override float BoundRadius { get; } = float.MaxValue;

        public float CupWidth
        {
            get { return cupWidth; }
            set { cupWidth = value; }
        }

        public float CupBottomPosY
        {
            get { return cupBottomPosY; }
            set { cupBottomPosY = value; }
        }

        public float WaterFillHeight
        {
            get { return waterFillHeight; }
        }

        public float MaxFillHeight
        {
            get { return maxFillHeight; }
            set { maxFillHeight = value; }
        }

        public float FillSpeed
        {
            get { return fillSpeed; }
            set { fillSpeed = value; }
        }

        private float cupWidth = 110f;
        private float cupBottomPosY = 80f;
        private float maxFillHeight = 160f;
        private float fillSpeed = 2f;

        [DontSerialize]
        private float waterFillHeight = 0f;

        [DontSerialize]
        private readonly Random rnd = new Random();

        [DontSerialize]
        private Range limitRange = new Range();

        [DontSerialize]
        private float waterLimitPosY = 0f;

        [DontSerialize]
        private float waterLimitY = 0f;

        [DontSerialize]
        private bool isFilling = false;

        public void OnInit(InitContext context)
        {
            if (context == InitContext.Activate)
            {
                SetRandomLimit();
            }
        }

        public void OnShutdown(ShutdownContext context)
        {
        }

        public void Fill(bool keyState)
        {
            if (keyState)
            {
                if (waterFillHeight <= maxFillHeight)
                {
                    Log.Editor.Write("Water Height: " + waterFillHeight);
                    waterFillHeight += fillSpeed;
                    isFilling = true;
                }
            }

            if (!keyState && isFilling)
            {
                if (waterFillHeight >= waterLimitY - limitRange.MinValue && waterFillHeight <= waterLimitY + limitRange.MaxValue)
                {
                    Log.Editor.Write("WON!");
                }

            }
        }

        public void OnUpdate()
        {
            if (DualityApp.Keyboard.KeyHit(Key.A))
            {
                SetRandomLimit();
            }

            if (DualityApp.Keyboard.KeyHit(Key.R))
            {
                Scene.Reload();
            }
        }

        public void SetRandomLimit()
        {
            var offset = 20f;
            var rndRangeValue = rnd.Next(10, 30);
            waterLimitPosY = rnd.NextFloat(cupBottomPosY - limitRange.MinValue - offset, -cupBottomPosY - limitRange.MaxValue + offset);
            limitRange = new Range(rndRangeValue);

            // fix this
            waterLimitY = waterLimitPosY + cupBottomPosY;

            Log.Editor.Write("Range: " + rndRangeValue.ToString() + " Range Pos: " + waterLimitPosY);

        }

        public override void Draw(IDrawDevice device)
        {
            var canvas = new Canvas(device);
            var pos = GameObj.Transform.Pos;

            // draw fill limit
            canvas.State.ColorTint = new ColorRgba(255, 0, 0, 0.5f);
            canvas.FillRect(pos.X - cupWidth / 2f, waterLimitPosY, 0.1f, cupWidth, limitRange.MaxValue);

            // draw water
            canvas.State.ColorTint = new ColorRgba(52, 152, 219);
            canvas.FillRect(pos.X - cupWidth / 2f, cupBottomPosY - waterFillHeight, 0.2f, cupWidth, waterFillHeight);
        }

    }
}