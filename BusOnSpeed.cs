using System.Threading;

namespace LAB2 {
    public class BusOnSpeed : Bus {
        private int speed;

        public int Speed {
            get => speed;
            set => speed = value;
        }

        private string mark = "I dont know what you expected me to do UwU";

        public override double Count() {
            return base.Count() * 0.05 * speed;
        }

        public BusOnSpeed(int p, int s, int sp) : base(p, s) {
            speed = sp;
        }
    }
}