using System;
using System.Runtime.InteropServices.ComTypes;
using Duality;
using Duality.Components.Physics;
using Duality.Components.Renderers;
using Duality.Input;
using Duality.Resources;

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

        public Range FillRange
        {
            get { return fillRange; }
            set { fillRange = value; }
        }

        private float maxFillHeight = 250f;
        private float fillSpeed = 1;
        private SpriteRenderer waterSpriteRenderer = null;
        private SpriteRenderer cupLimitSpriteRenderer = null;
        private float fillHeight = 200f;
        private float cupBottom = 80f;

        [DontSerialize] private readonly Random rnd = new Random();
        [DontSerialize] private float rangeHeight = 0f;
        [DontSerialize] private Range fillRange;
        [DontSerialize] private bool isFilling = false;

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
                var rec = waterSpriteRenderer.Rect;
                if (rec.H < maxFillHeight)
                {
                    var value = rec.H + 1 * fillSpeed * Time.LastDelta;
                    waterSpriteRenderer.Rect = new Rect(rec.X, rec.Y, rec.W, value);
                }
                isFilling = true;
            }

            if (!keyState && isFilling)
            {
                var rec = waterSpriteRenderer.Rect;
                Log.Editor.Write("Current Red H: " + rec.H );
                Log.Editor.Write("RANGE: " + fillRange.ToString());
                if (rec.H >= fillRange.MinValue && rec.H <= fillRange.MaxValue)
                {
                    Log.Editor.Write("WON!");
                }
                else
                {
                    Log.Editor.Write("LOOSE!");
                }

                isFilling = false;
            }
        }

        public void SetRandomLimit()
        {
            var rndPos = rnd.Next(-80, 30);
            rangeHeight = rnd.Next(20, 40);
            if (cupLimitSpriteRenderer != null)
            {
                var pos = cupLimitSpriteRenderer.GameObj.Transform.Pos;
                var rec = cupLimitSpriteRenderer.Rect;

                // set random range height
                cupLimitSpriteRenderer.Rect = new Rect(rec.X, rangeHeight * -0.5f, rec.W, rangeHeight);

                // set random position
                cupLimitSpriteRenderer.GameObj.Transform.Pos = new Vector3(pos.X, rndPos, pos.Z);

                Log.Editor.Write("RangeHeight: " + rangeHeight.ToString());
                fillRange = new Range(cupBottom + pos.X + (rangeHeight * 0.5f), cupBottom + pos.Y - (rangeHeight * 0.5f));
                Log.Editor.Write("New Range: " + fillRange.ToString());
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
    }
}