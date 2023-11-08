using System;
namespace task_2._1
{
	public class Point
	{
		private int[] coordinates = new int[3];
		private double mass;

		public Point()
		{
		}

        public Point(int x, int y, int z, double mass)
        {
            X = x;
            Y = y;
            Z = z;
            Mass = mass;
        }

        public int X
		{
			get { return coordinates[0]; }
			set { coordinates[0] = value; }
		}

        public int Y
        {
            get { return coordinates[1]; }
            set { coordinates[1] = value; }
        }

        public int Z
        {
            get { return coordinates[2]; }
            set { coordinates[2] = value; }
        }

		public double Mass
		{
			get { return mass; }
			set { mass = Math.Max(0, value); }
		}

        public bool IsZero()
        {
            return X == 0 && Y == 0 && Z == 0;
        }

        public double CalculateDistance(Point otherPoint)
        {
            double dx = X - otherPoint.X;
            double dy = Y - otherPoint.Y;
            double dz = Z - otherPoint.Z;
            return Math.Sqrt(dx * dx + dy * dy + dz * dz);
        }
    }
}

