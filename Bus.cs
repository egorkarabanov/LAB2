namespace LAB2 {
    public class Bus {
        private int price, seats;

        public int Price {
            get => price;
            set => price = value;
        }

        public int Seats {
            get => seats;
            set => seats = value;
        }

        public virtual double Count() {
            return seats * price;
        }

        public Bus(int p, int s) {
            price = p;
            seats = s;
        }
    }
}