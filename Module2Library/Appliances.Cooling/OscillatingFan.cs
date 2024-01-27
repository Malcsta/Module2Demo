using System;

namespace Appliances.Cooling
{
    public class OscillatingFan : Fan
    {
        private int oscillatingAngle;
        
        /// <summary>
        /// Gets the angle that the fan is facing.
        /// </summary>
        public int OscillatingAngle
        {
            get
            {
                return this.oscillatingAngle;
            }

            private set
            {
                if(value < 0 || value > 120)
                {
                    throw new ArgumentOutOfRangeException(
                        "value",
                        "The value must be 1 to 120 (inclusive)."
                    );
                }

                this.oscillatingAngle = value;
            }
        }

        /// <summary>
        /// Gets and sets whether the fan is oscillating.
        /// </summary>
        public bool IsOscillating
        {
            get;
            set;
        }

        public OscillatingFan(double size, FanColor color) 
            : base(size, color)
        {
            this.oscillatingAngle = 0;
            this.IsOscillating = false;
        }

        public void ToggleOscillation()
        {
            this.IsOscillating = !this.IsOscillating;
        }
    }
}