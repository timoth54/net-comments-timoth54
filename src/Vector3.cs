using System;

namespace VectorMath
{
    /// <summary>
    /// A class representing a 3-element vector using doubles.
    /// </summary>
    public class Vector3
    {

        /// <summary>
        /// Gets or sets the X property
        /// </summary>
        public double X;

        /// <summary>
        /// Gets or sets the Y property
        /// </summary>
        public double Y;

        /// <summary>
        /// Gets or sets the Z property
        /// </summary>
        public double Z;

        /// <summary>
        /// Constructs a new instance of Vector3 with
        /// X, Y, and Z properties set to 0.
        /// </summary>
        public Vector3()
        {
            this.X = 0;
            this.Y = 0;
            this.Z = 0;
        }

        /// <summary>
        /// Constructs a new instance of Vector3 with
        /// the supplied values for X, Y, and Z.
        /// <param name="X">A double precision number for the x component of the vector.</param>
        /// <param name="Y">A double precision number for the y component of the vector.</param>
        /// <param name="Z">A double precision number for the z component of the vector.</param>
        /// </summary>
        public Vector3(double x, double y, double z)
        {
            this.X = x;
            this.Y = y;
            this.Z = z;
        }
    }
}
