using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Protype
{
    public interface IBuilder
    {        
        public IBuilder Reset();
        public IBuilder setSeats(int s);
        public IBuilder setEngine(int e);
        public IBuilder setTripComputer(bool t);
        public IBuilder setGPS(bool g);
    }
    public class Car
    {
        public int    seats { get; set; }
        public int    engine { get; set; }
        public bool   tripcomp { get; set; }
        public bool    GPS { get; set; }
        public string? Name { get; set; }
    }
    public class AutomaticCar:Car
    {        
    }
    public class ManualCar:Car
    {
    }
    public class ManualCarBuilder : IBuilder
    {
        private ManualCar? ManualCar;

        public ManualCarBuilder(ManualCar? manualCar)
        {
            this.Reset();
        }

        public IBuilder  Reset()
        {
            this.ManualCar = new ManualCar();
            return this;
        }

        public IBuilder setEngine(int e)
        {
            ManualCar.engine = e;
            return this;
        }

        public IBuilder setGPS(bool g)
        {
            ManualCar.GPS = g;
            return this;
        }

        public IBuilder setSeats(int s)
        {
            ManualCar.seats = s;
            return this;
        }

        public IBuilder setTripComputer(bool t)
        {
            ManualCar.tripcomp = t;
            return this;
        }
        public Car getResult()
        {
            return ManualCar;
        }
    }
    public class AutoCarBuilder : IBuilder
    {
        private AutomaticCar? autocar;

        public AutoCarBuilder(ManualCar? manualCar)
        {
            this.Reset();
        }

        public IBuilder Reset()
        {
            this.autocar = new AutomaticCar();
            return this;
        }

        public IBuilder setEngine(int e)
        {
            autocar.engine = e;
            return this;
        }

        public IBuilder setGPS(bool g)
        {
            autocar.GPS = g;
            return this;
        }

        public IBuilder setSeats(int s)
        {
            autocar.seats = s;
            return this;
        }

        public IBuilder setTripComputer(bool t)
        {
            autocar.tripcomp = t;
            return this;
        }
        public Car getResult()
        {
            return autocar;
        }
    }
}
