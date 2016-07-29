using Aquarium.SeaCreatures.Genera;

namespace Aquarium.SeaCreatures.Species
{
    public class HippocampusErectus : Hippocampus
    {
        public HippocampusErectus (string name) : base(name)
        {
            HippocampusErectusSetter();
        }

        public HippocampusErectus (int length) : base(length)
        {
            HippocampusErectusSetter();
        }

        public HippocampusErectus (string name, int length) : base(name, length)
        {
            HippocampusErectusSetter();
        }
        private void HippocampusErectusSetter()
        {
            this.CommonName = "Lined Seahorse";
            this.AveLength = "15cm";
            this.Color = "myriad of colors, from greys and blacks to reds, greens, and oranges";
            this.Habitat = "the Atlantic Ocean as far north as Canada and as far south as the Caribbean, Mexico, and Venezuela";
            this.Likes = "strong current channels with soft bottoms with coral outcrops and various debris among which it can shelter and hang with his tail";
            this.Diet = "carnivorous";
            this.FavFood = "ritual dances with their partner that they perform every morning";
        }
    }
}