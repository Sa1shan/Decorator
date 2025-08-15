using Source.Abstract;

namespace Source.Main
{
    public class HotdogClassic : Hotdog
    {
        public HotdogClassic(string name) : base("HotdogClassic")
        {
        }

        public override int GetCost()
        {
            return 210;
        }
    }
}