using Aquarium.SeaCreatures.Genera;

namespace Aquarium.SeaCreatures.Species
{
    public class HippocampusKuda : Hippocampus
    {
        public HippocampusKuda (string name) : base(name)
        {
            HippocampusKudaSetter();
        }

        public HippocampusKuda (int length) : base(length)
        {
            HippocampusKudaSetter();
        }

        public HippocampusKuda (string name, int length) : base(name, length)
        {
            HippocampusKudaSetter();
        }
        private void HippocampusKudaSetter()
        {
            this.CommonName = "Estuary Seahorse";
            this.AveLength = "23cm";
            this.Color = "dark with a grainy texture but can also be yellow, cream or redish with blotches and numerous small dark spots";
            this.Habitat = "the Persian Gulf to Southeast Asia, Australia, Japan, and several Pacific islands including Hawaii, and is also found the eastern coast of Africa from Tanzania to South Africa";
            this.Likes = "a quiet tank, without large, belligerent fish, and a slow-moving current";
            this.Diet = "carnivorous";
            this.FavFood = "small animals like brine shrimp and even newborn guppies";
        }
    }
}