/*
 * Name: Damien Altenburg
 * Program: Business Information Technology
 * Course: ADEV-2008 Programming 2
 * Created: 1.15.2024
 * Updated: 1.15.2024
 */

using System;

namespace Appliances.Cooling
{
    /// <summary>
    /// Represents a common house fan.
    /// </summary>
    /// <remarks>
    /// A fan is an apparatus with rotating blades that creates a
    /// current of air for cooling and ventilation.
    /// </remarks>
    public abstract class Fan
    {
        private double size;

        /// <summary>
        /// Gets and sets the speed of the fan.
        /// </summary>
        public FanSpeed Speed
        {
            get;
            set;
        }

        /// <summary>
        /// Gets and sets the size of the fan.
        /// </summary>
        /// <exception cref="System.ArgumentOutOfRangeException">
        /// Raised when the value is less than 1.
        /// </exception>
        public double Size
        {
            get
            {
                return this.size;
            }

            set
            {
                if(value < 1)
                {
                    throw new ArgumentOutOfRangeException(
                        "value", 
                        "The value must be greater than zero."
                    );
                }

                this.size = value;
            }
        }

        /// <summary>
        /// Gets and sets the color of the fan.
        /// </summary>
        public FanColor Color
        {
            get;
            set;
        }

        /// <summary>
        /// Initializes a new instance of the Fan class.
        /// </summary>
        /// <remarks>
        /// The default state of the fan is - speed: Off, size: 7, and 
        /// color: White.
        /// </remarks>
        public Fan() : this(7)
        {
            // invokes Fan(size)
        }

        /// <summary>
        /// Initializes a new instance of the Fan class with a specific
        /// size.
        /// </summary>
        /// <param name="size">The size of the fan.</param>
        /// <exception cref="System.ArgumentOutOfRangeException">
        /// Raised when the <paramref name="size"/> is less than one.
        /// </exception>
        public Fan(double size): this(size, FanColor.White)
        {
            // invokes Fan(double, FanColor)
        }

        /// <summary>
        /// Initializes a new instance of the Fan class.
        /// </summary>
        /// <param name="size">The size of the fan.</param>
        /// <param name="color">The color of the fan.</param>
        /// <exception cref="System.ArgumentOutOfRangeException">
        /// Raised when the <paramref name="size"/> is less than one.
        /// </exception>
        public Fan(double size, FanColor color)
        {
            if (size < 1)
            {
                throw new ArgumentOutOfRangeException(
                    "size",
                    "The size must be greater than zero."
                );
            }

            this.Speed = FanSpeed.Off;
            this.size = size;
            this.Color = color;
        }

        /// <summary>
        /// Increases the fan speed by one unit.
        /// </summary>
        /// <remarks>
        /// If the fan speed as at the maximum speed, increasing the speed will not change
        /// the fan's state.
        /// </remarks>
        public void IncreaseSpeed()
        {
            if(this.Speed != FanSpeed.Fast)
            {
                this.Speed += 1;
            }
        }

        /// <summary>
        /// Decreases the fan speed by one unit.
        /// </summary>
        /// <remarks>
        /// If the fan speed as at the minimum speed, decreasing the speed will not change
        /// the fan's state.
        /// </remarks>
        public void DecreaseSpeed()
        {
            if (this.Speed != FanSpeed.Off)
            {
                this.Speed -= 1;
            }
        }

        /// <summary>
        /// Returns true when the fan is off; otherwise false.
        /// </summary>
        /// <returns>True when the fan is off; otherwise false.</returns>
        public bool IsOn()
        {
            return this.Speed != FanSpeed.Off;
        }

        /// <summary>
        /// Returns the string representation of the fan.
        /// </summary>
        /// <returns>The string representation of the fan.</returns>
        public override string ToString()
        {
            return $"Fan: {this.size} - {this.Color} - {this.Speed}";
        }
    }
}