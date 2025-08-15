using UnityEngine;

namespace Source.Abstract
{
    public abstract class Hotdog : MonoBehaviour
    {
        protected string Name;

        public Hotdog(string name)
        {
            Name = name;
        }

        public string GetName()
        {
            return Name;
        }

        public abstract int GetCost();
    }
}
