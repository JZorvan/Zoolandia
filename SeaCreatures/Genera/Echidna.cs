namespace Aquarium.SeaCreatures.Genera
{
    public abstract class Echidna: SeaCreature
    {
        private void PteroisSetter()
        {
            this.Genus = "Echidna";
 	    this.Type = "Eel";		
        }
        public Echidna (string name) : base(name)
        {
            EchidnaSetter();
        }

        public Echidna (int length) : base(length)
        {
            EchidnaSetter();
        }

        public Echidna (string name, int length) : base(name, length)
        {
            EchidnaSetter();
        }
    }
}