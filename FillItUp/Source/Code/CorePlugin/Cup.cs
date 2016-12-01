using System;
using System.Threading;
using Duality;
using Duality.Components;
using Duality.Components.Renderers;
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

        private readonly Vector3Tween posTween = new Vector3Tween();
        private readonly ColorTween colorTween = new ColorTween();

        private bool showLimit = true;

        [DontSerialize]
        private SpriteRenderer spriteRenderer = null;

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
                spriteRenderer = GameObj.GetComponent<SpriteRenderer>();
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
                else
                {

                }
            }

            if (!keyState && isFilling)
            {
                if (waterFillHeight >= waterLimitY - limitRange.MinValue && waterFillHeight <= waterLimitY + limitRange.MaxValue)
                {
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

            if (DualityApp.Keyboard.KeyHit(Key.B))
            {
                var startColor = spriteRenderer.ColorTint;
                var pos = GameObj.Transform.Pos;
                var targetPos = pos - new Vector3(200, 0, 0);
                posTween.Start(pos, targetPos, 2000f, Easing.CubicEaseInOut);
                colorTween.Start(startColor, ColorRgba.TransparentWhite, 2000f, Easing.CubicEaseInOut);

                showLimit = false;

            }

            colorTween.Update(Time.LastDelta);
            posTween.Update(Time.LastDelta);

            if (colorTween.State == TweenState.Running && posTween.State == TweenState.Running)
            {
                GameObj.Transform.Pos = posTween.CurrentValue;
                spriteRenderer.ColorTint = colorTween.CurrentValue;
            }
        }

        public void SetRandomLimit()
        {
            showLimit = true;
            var offset = 20f;
            var rndRangeValue = rnd.Next(10, 30);
            waterLimitPosY = rnd.NextFloat(cupBottomPosY - limitRange.MinValue - offset, -cupBottomPosY - limitRange.MaxValue + offset);
            limitRange = new Range(rndRangeValue);
            fillSpeed = rnd.Next(1, 4);

            // fix this
            waterLimitY = waterLimitPosY + cupBottomPosY;

            Log.Editor.Write("Range: " + rndRangeValue.ToString() + " Range Pos: " + waterLimitPosY);

        }

        public override void Draw(IDrawDevice device)
        {
            var canvas = new Canvas(device);
            var pos = GameObj.Transform.Pos;

            if (showLimit)
            {
                // draw fill limit
                canvas.State.ColorTint = new ColorRgba(255, 0, 0, 0.5f);
                canvas.FillRect(pos.X - cupWidth / 2f, waterLimitPosY, 0.1f, cupWidth, limitRange.MaxValue);

            }

            // draw water
            canvas.State.ColorTint = new ColorRgba(52, 152, 219);
            canvas.FillRect(pos.X - cupWidth / 2f, cupBottomPosY - waterFillHeight, 0.2f, cupWidth, waterFillHeight);
        }

    }
}