using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GAMELibrary
{
    public abstract class Soldier
    {


        public virtual double GetPower()
        {
            return 0;
        }
        public virtual void SetRating(double value)
        {
            
        }
       public virtual double GetRating()
        {
            return 0;
        }

    }

    public abstract class Rider : Soldier
    {
       

    }

    public class Archer : Soldier
    {
        public double Power { get; set; }
        public double Rating { get; set; }
        public Archer(double P, double R) { Power = P;Rating = R; }

        public override double GetPower()
        {
            return Power;
        }
        public override void SetRating(double value)
        {
            Rating = value;
        }

        public override double GetRating()
        {
            return Rating;
        }
    }

    public class Templar : Soldier
    {
        public double Power { get; set; }
        public double Rating { get; set; }
        public Templar(double P, double R) { Power = P; Rating = R; }

        public override double GetPower()
        {
            return Power;
        }

        public override void SetRating(double value)
        {
            Rating = value;
        }
        public override double GetRating()
        {
            return Rating;
        }
    }

    public class Knight : Rider
    {
        public double Power { get; set; }
        public double Rating { get; set; }
        public Knight(double P, double R) { Power = P; Rating = R; }

        public override double GetPower()
        {
            return Power;
        }

        public override void SetRating(double value)
        {
            Rating = value;
        }

        public override double GetRating()
        {
            return Rating;
        }

    }
    public class Elephant : Rider
    {
        public double Power { get; set; }
        public double Rating { get; set; }
        public Elephant(double P, double R) { Power = P; Rating = R; }

        public override double GetPower()
        {
            return Power;
        }

        public override void SetRating(double value)
        {
            Rating+=value;
        }

        public override double GetRating()
        {
            return Rating;
        }
    }
}
