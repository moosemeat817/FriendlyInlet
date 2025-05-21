using ModSettings;

namespace FriendlyInlet
{
    internal class FriendlyInlet : JsonModSettings
    {

        [Name("Redistribute Wood")]
        [Description("Redistribute some stick, branch, cedar and fir spawns tnear the coast")]
        public bool bleakWood = false;

        [Name("More Wood!")]
        [Description("Redistribute MORE stick, branch, cedar and fir spawns tnear the coast")]
        public bool bleakWoodPile = false;

        [Name("Tame the Wolves")]
        [Description("Reduce the number of wolf spawns and relocate some out of the way")]
        public bool tameWolves = false;



    }

    internal static class Settings
    {
        public static FriendlyInlet options;

        public static void OnLoad()
        {
            options = new FriendlyInlet();
            options.AddToModSettings("Friendly Inlet", MenuType.Both);
        }
    }

}