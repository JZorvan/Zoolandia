namespace Aquarium.SeaCreatures
{
    public abstract class SeaCreature
    {
        public SeaCreature (string name)
        {
            this.Name = name;
        }
        public SeaCreature (int length)
        {
            this.LengthCM = length;
        }
        public SeaCreature (string name, int length)
        {
            this.Name = name;
            this.LengthCM = length;
        }
        public string Name { get; set; }
        public string CommonName { get; set; }
        public string Genus { get; set; }
        public string AveLength { get; set; }
        public int LengthCM { get; set; }
        public string Color { get; set; }
        public string Habitat { get; set; }
        public string Likes { get; set; }
        public string Diet { get; set; }
        public string FavFood { get; set; }
        public virtual string Swim()
        {
            return null;
        }
        public virtual string Feed()
        {
            return null;
        }
    }
}

