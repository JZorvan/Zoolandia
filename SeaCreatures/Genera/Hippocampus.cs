namespace Aquarium.SeaCreatures.Genera
{
    public abstract class Hippocampus : SeaCreature
    {
        private void HippocampusSetter()
        {
            this.Genus = "Hippocampus";
        }
        public Hippocampus (string name) : base(name)
        {
            HippocampusSetter();
        }

        public Hippocampus (int length) : base(length)
        {
            HippocampusSetter();
        }

        public Hippocampus (string name, int length) : base(name, length)
        {
            HippocampusSetter();
        }
    }
}