using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            public interface ITV
        {
            void SellTV();
        }

        public interface IDisplay
        {
            void SellDisplay();
        }

        class SamsungTV : ITV
        {
            public void SellTV();
        }

        class DellTV : ITV
        {
            public void SellTV();
        }

        class SamsungDisplay : IDisplay
        {
            public void SellDisplay();
        }

        class DellDisplay : IDisplay
        {
            public void SellDisplay();
        }

        abstract class AbstractFactory
        {
            public abstract ITV createTV();
            public abstract IDisplay createDisplay();
        }

        class DellFactory : AbstractFactory
        {
            public override ITV createTV()
            {
                return new DellTV();
            }
            public override IDisplay createDisplay()
            {
                return new IDisplay();
            }
        }

        class SamsungFactory : AbstractFactory
        {
            public override ITV createTV()
            {
                return new SamsungTV();
            }
            public override IDisplay createDisplay()
            {
                return new SamsungDisplay();
            }
        }
    }
    }
}

/*koristimo OpenClosed Prinicple jer možemo dodavati još
 * brandova i apstraktnih tvornica kao i još novih proizvođača
 * -koristimo SRP jer klase ovise o apstrakciji(interfaceovima)
 * -ISP-svako klasa nasljeđuje točno određeni interface čiju
 * funkcionalnost treba
 * 
