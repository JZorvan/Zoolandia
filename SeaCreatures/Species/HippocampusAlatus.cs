using Aquarium.SeaCreatures.Genera;

namespace Aquarium.SeaCreatures.Species
{
    public class HippocampusAlatus : Hippocampus
    {
        public HippocampusAlatus (string name) : base(name)
        {
            HippocampusAlatusSetter();
        }

        public HippocampusAlatus (int length) : base(length)
        {
            HippocampusAlatusSetter();
        }

        public HippocampusAlatus (string name, int length) : base(name, length)
        {
            HippocampusAlatusSetter();
        }
        private void HippocampusAlatusSetter()
        {
            this.CommonName = "Winged Seahorse";
            this.AveLength = "12cm";
            this.Color = "pale pinkish-white with numerous small dark spots. Dark reddish dermal filaments are more or less developed on the nape, the middle of the trunk, the anterior part of the tail and the head";
            this.Habitat = "the central Indo-Pacific area from Indonesia to Philippines and also on the northern coasts of Australia";
            this.Likes = "strong current channels with soft bottoms with coral outcrops and various debris among which it can shelter and hang with his tail";
            this.Diet = "carnivorous";
            this.FavFood = "small crustaceans and other planktonic organisms";
        }
    }
}