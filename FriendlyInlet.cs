using MelonLoader.Utils;
using UnityEngine;
using UnityEngine.Rendering.PostProcessing;

namespace FriendlyInlet
{
    public class Main : MelonMod
    {
        public override void OnInitializeMelon()
        {
            if (Settings.OnLoad != null)
            {
                Settings.OnLoad();
            }
        }

        /*
        public override void OnSceneWasInitialized(int buildIndex, string sceneName)
        {
        */
        public override void OnSceneWasLoaded(int buildIndex, string sceneName)
        {
            if (string.IsNullOrEmpty(sceneName))
            {
                return;
            }

            if (sceneName == "CanneryRegion_SANDBOX" && Settings.options != null && Settings.options.bleakWood)
            {
                // Island
                SafeSetPositionAndRotation("Design/NaturalResources/BranchSpawners/Sticks/Forest/RadialSpawn_sticks (33)",
                    new Vector3(131.26f, 56.48f, -864.45f), Quaternion.Euler(new Vector3(-0, 0, 0)));
                SafeSetPositionAndRotation("Design/NaturalResources/BranchSpawners/Sticks/Forest/RadialSpawn_sticks (39)",
                    new Vector3(134.68f, 30.95f, -704.89f), Quaternion.Euler(new Vector3(-0, 0, 0)));

                // Cabin
                SafeSetPositionAndRotation("Design/NaturalResources/BranchSpawners/Sticks/Forest/RadialSpawn_sticks (48)",
                    new Vector3(211.33f, 39.92f, -302.74f), Quaternion.Euler(new Vector3(-0, 0, 0)));
                SafeSetPositionAndRotation("Design/NaturalResources/BranchSpawners/Sticks/Forest/RadialSpawn_sticks (54)",
                    new Vector3(177.47f, 42.44f, -233.94f), Quaternion.Euler(new Vector3(-0, 0, 0)));

                // Cannery South
                SafeSetPositionAndRotation("Design/NaturalResources/BranchSpawners/Sticks/Forest/RadialSpawn_sticks (112)",
                    new Vector3(-561.10f, 42.47f, -597.77f), Quaternion.Euler(new Vector3(-0, 0, 0)));
                SafeSetPositionAndRotation("Design/NaturalResources/BranchSpawners/Sticks/Forest/RadialSpawn_sticks (114)",
                    new Vector3(-586.56f, 36.58f, -569.30f), Quaternion.Euler(new Vector3(-0, 0, 0)));

                // Cannery North
                SafeSetPositionAndRotation("Design/NaturalResources/BranchSpawners/Sticks/Forest/RadialSpawn_sticks (117)",
                    new Vector3(-644.30f, 50.74f, -263.65f), Quaternion.Euler(new Vector3(-0, 0, 0)));
                SafeSetPositionAndRotation("Design/NaturalResources/BranchSpawners/Sticks/Delta/RadialSpawn_sticks (9)",
                    new Vector3(-733.96f, 107.42f, -156.90f), Quaternion.Euler(new Vector3(-0, 0, 0)));

                // Misc
                SafeSetPositionAndRotation("Design/NaturalResources/BranchSpawners/Sticks/Delta/RadialSpawn_sticks (18)",
                    new Vector3(406.47f, 44.03f, -481.75f), Quaternion.Euler(new Vector3(-0, 0, 0)));
                SafeSetPositionAndRotation("Design/NaturalResources/BranchSpawners/Sticks/Delta/RadialSpawn_sticks (27)",
                    new Vector3(-959.42f, 55.54f, -680.39f), Quaternion.Euler(new Vector3(-0, 0, 0)));

                // Fir
                SafeSetPositionAndRotation("Design/NaturalResources/BranchSpawners/BigBranches/RadialSpawn_branches_hard (3)",
                    new Vector3(176.81f, 42.38f, -233.32f), Quaternion.Euler(new Vector3(-0, 0, 0)));
                SafeSetPositionAndRotation("Design/NaturalResources/BranchSpawners/BigBranches/RadialSpawn_branches_hard (9)",
                    new Vector3(-973.69f, 53.11f, -679.66f), Quaternion.Euler(new Vector3(-0, 0, 0)));

                // Cedar
                SafeSetPositionAndRotation("Design/NaturalResources/BranchSpawners/BigBranches/RadialSpawn_branches_soft (3)",
                    new Vector3(-489.66f, 36.58f, -352.12f), Quaternion.Euler(new Vector3(-0, 0, 0)));
                SafeSetPositionAndRotation("Design/NaturalResources/BranchSpawners/BigBranches/RadialSpawn_branches_soft (6)",
                    new Vector3(-919.49f, 62.62f, -666.96f), Quaternion.Euler(new Vector3(-0, 0, 0)));

                // Branches
                SafeSetPositionAndRotation("Design/NaturalResources/BranchSpawners/SmallBranches/RadialSpawn_small_branch (4)",
                    new Vector3(191.88f, 38.10f, -277.58f), Quaternion.Euler(new Vector3(-0, 0, 0)));
                SafeSetPositionAndRotation("Design/NaturalResources/BranchSpawners/SmallBranches/RadialSpawn_small_branch (13)",
                    new Vector3(-949.50f, 53.00f, -637.54f), Quaternion.Euler(new Vector3(-0, 0, 0)));
            }

            if (sceneName == "CanneryRegion_SANDBOX" && Settings.options != null && Settings.options.bleakWoodPile)
            {
                // Island
                SafeSetPositionAndRotation("Design/NaturalResources/BranchSpawners/Sticks/Forest/RadialSpawn_sticks (30)",
                    new Vector3(163.46f, 36.53f, -771.66f), Quaternion.Euler(new Vector3(-0, 0, 0)));
                SafeSetPositionAndRotation("Design/NaturalResources/BranchSpawners/Sticks/Forest/RadialSpawn_sticks (36)",
                    new Vector3(136.51f, 35.97f, -754.53f), Quaternion.Euler(new Vector3(-0, 0, 0)));
                SafeSetPositionAndRotation("Design/NaturalResources/BranchSpawners/Sticks/Forest/RadialSpawn_sticks (42)",
                    new Vector3(235.77f, 28.09f, -796.25f), Quaternion.Euler(new Vector3(-0, 0, 0)));

                // Cabin
                SafeSetPositionAndRotation("Design/NaturalResources/BranchSpawners/Sticks/Forest/RadialSpawn_sticks (45)",
                    new Vector3(188.20f, 35.06f, -356.77f), Quaternion.Euler(new Vector3(-0, 0, 0)));
                SafeSetPositionAndRotation("Design/NaturalResources/BranchSpawners/Sticks/Forest/RadialSpawn_sticks (51)",
                    new Vector3(203.15f, 42.25f, -274.23f), Quaternion.Euler(new Vector3(-0, 0, 0)));
                SafeSetPositionAndRotation("Design/NaturalResources/BranchSpawners/Sticks/Forest/RadialSpawn_sticks (57)",
                    new Vector3(213.99f, 41.05f, -312.58f), Quaternion.Euler(new Vector3(-0, 0, 0)));

                // Cannery South
                SafeSetPositionAndRotation("Design/NaturalResources/BranchSpawners/Sticks/Forest/RadialSpawn_sticks (60)",
                    new Vector3(-513.35f, 35.87f, -513.57f), Quaternion.Euler(new Vector3(-0, 0, 0)));
                SafeSetPositionAndRotation("Design/NaturalResources/BranchSpawners/Sticks/Forest/RadialSpawn_sticks (113)",
                    new Vector3(-552.36f, 43.87f, -613.85f), Quaternion.Euler(new Vector3(-0, 0, 0)));
                SafeSetPositionAndRotation("Design/NaturalResources/BranchSpawners/Sticks/Forest/RadialSpawn_sticks (115)",
                    new Vector3(-730.38f, 37.10f, -439.50f), Quaternion.Euler(new Vector3(-0, 0, 0)));

                // Cannery North
                SafeSetPositionAndRotation("Design/NaturalResources/BranchSpawners/Sticks/Forest/RadialSpawn_sticks (116)",
                    new Vector3(-418.80f, 34.96f, -369.03f), Quaternion.Euler(new Vector3(-0, 0, 0)));
                SafeSetPositionAndRotation("Design/NaturalResources/BranchSpawners/Sticks/Forest/RadialSpawn_sticks (118)",
                    new Vector3(-710.79f, 53.48f, -307.87f), Quaternion.Euler(new Vector3(-0, 0, 0)));
                SafeSetPositionAndRotation("Design/NaturalResources/BranchSpawners/Sticks/Delta/RadialSpawn_sticks (12)",
                    new Vector3(-754.49f, 89.99f, -97.51f), Quaternion.Euler(new Vector3(-0, 0, 0)));

                // Misc
                SafeSetPositionAndRotation("Design/NaturalResources/BranchSpawners/Sticks/Delta/RadialSpawn_sticks (15)",
                    new Vector3(402.18f, 37.37f, -543.74f), Quaternion.Euler(new Vector3(-0, 0, 0)));
                SafeSetPositionAndRotation("Design/NaturalResources/BranchSpawners/Sticks/Delta/RadialSpawn_sticks (21)",
                    new Vector3(374.04f, 47.80f, -406.96f), Quaternion.Euler(new Vector3(-0, 0, 0)));
                SafeSetPositionAndRotation("Design/NaturalResources/BranchSpawners/Sticks/Delta/RadialSpawn_sticks (24)",
                    new Vector3(-924.69f, 62.60f, -667.16f), Quaternion.Euler(new Vector3(-0, 0, 0)));

                // Fir
                SafeSetPositionAndRotation("Design/NaturalResources/BranchSpawners/BigBranches/RadialSpawn_branches_hard (1)",
                    new Vector3(204.44f, 43.26f, -707.41f), Quaternion.Euler(new Vector3(-0, 0, 0)));
                SafeSetPositionAndRotation("Design/NaturalResources/BranchSpawners/BigBranches/RadialSpawn_branches_hard (7)",
                    new Vector3(-709.43f, 35.90f, -432.28f), Quaternion.Euler(new Vector3(-0, 0, 0)));

                // Cedar
                SafeSetPositionAndRotation("Design/NaturalResources/BranchSpawners/BigBranches/RadialSpawn_branches_soft (1)",
                    new Vector3(201.51f, 44.39f, -263.20f), Quaternion.Euler(new Vector3(-0, 0, 0)));
                SafeSetPositionAndRotation("Design/NaturalResources/BranchSpawners/BigBranches/RadialSpawn_branches_soft (5)",
                    new Vector3(-516.57f, 35.76f, -515.05f), Quaternion.Euler(new Vector3(-0, 0, 0)));

                // Branches
                SafeSetPositionAndRotation("Design/NaturalResources/BranchSpawners/SmallBranches/RadialSpawn_small_branch (1)",
                    new Vector3(214.95f, 43.91f, -712.40f), Quaternion.Euler(new Vector3(-0, 0, 0)));
                SafeSetPositionAndRotation("Design/NaturalResources/BranchSpawners/SmallBranches/RadialSpawn_small_branch (10)",
                    new Vector3(-683.74f, 36.19f, -505.89f), Quaternion.Euler(new Vector3(-0, 0, 0)));
            }

            if (sceneName == "CanneryRegion_SANDBOX_WILDLIFE" && Settings.options != null && Settings.options.tameWolves)
            {
                // Disable Cannery
                SafeSetActive("Wildlife/Wolves/CanneryBuildings/SPAWNREGION_Timberwolf", false);
                SafeSetActive("Wildlife/Wolves/CanneryBuildings/Timberwolf_CanneryReplenishSpawns/TimberwolfPackA/SPAWNREGION_Timberwolf (A)", false);
                SafeSetActive("Wildlife/Wolves/CanneryBuildings/Timberwolf_CanneryReplenishSpawns/TimberwolfPackB/SPAWNREGION_Timberwolf (B)", false);
                SafeSetActive("Wildlife/Wolves/CanneryBuildings/Timberwolf_CanneryReplenishSpawns/TimberwolfPackC/SPAWNREGION_Timberwolf (C)", false);
                SafeSetActive("Wildlife/Wolves/CanneryBuildings/Timberwolf_CanneryReplenishSpawns/TimberwolfPackD/SPAWNREGION_Timberwolf (D)", false);

                // Move Forest Packs
                SafeSetPositionAndRotation("Wildlife/Wolves/Ice/SPAWNREGION_Timberwolf (3)",
                    new Vector3(-1001.913f, 31.7f, 477.4684f), Quaternion.Euler(new Vector3(-0, 0, 0)));
                SafeSetPositionAndRotation("Wildlife/Wolves/Forest/SPAWNREGION_Wolf_forest1",
                    new Vector3(-1098.50f, 51.62f, -181.78f), Quaternion.Euler(new Vector3(-0, 0, 0)));
                SafeSetPositionAndRotation("Wildlife/Wolves/Forest/SPAWNREGION_Timberwolf_forest1",
                    new Vector3(-1098.50f, 51.62f, -181.78f), Quaternion.Euler(new Vector3(-0, 0, 0)));
                SafeSetPositionAndRotation("Wildlife/Wolves/Forest/SPAWNREGION_Timberwolf_forest2",
                    new Vector3(-1098.50f, 51.62f, -181.78f), Quaternion.Euler(new Vector3(-0, 0, 0)));
                SafeSetPositionAndRotation("Wildlife/Wolves/Forest/SPAWNREGION_Timberwolf_forest3",
                    new Vector3(-1098.50f, 51.62f, -181.78f), Quaternion.Euler(new Vector3(-0, 0, 0)));
                SafeSetPositionAndRotation("Wildlife/Wolves/Forest/SPAWNREGION_Timberwolf_forest4",
                    new Vector3(-1098.50f, 51.62f, -181.78f), Quaternion.Euler(new Vector3(-0, 0, 0)));

                // Disable Delta Packs
                SafeSetActive("Wildlife/Wolves/Delta/PackSet02A/SPAWNREGION_Timberwolf (4)", false);
                SafeSetActive("Wildlife/Wolves/Delta/PackSet02B/SPAWNREGION_Timberwolf (5)", false);
            }

            /*
            public override void OnSceneWasLoaded(int buildIndex, string sceneName)
            {

                /*
                if (sceneName == "CanneryRegion")
                {
                    GameObject.Find("/Art/Structures/Dam/Fence/Fence_West").gameObject.SetActive(true);
                    GameObject.Find("Design/Transitions/BrokenWindow/ExteriorLoadTrigger").transform.SetPositionAndRotation(new Vector3(606.7629f, 90.992f, 268.2598f), Quaternion.Euler(new Vector3(-0, 0, 0)));
                    GameObject.Find("Design/Transitions/BrokenWindow/ExteriorLoadTrigger").gameObject.transform.localScale = new Vector3(1.8f, 2f, 2f);

                }


                if (sceneName == "CanneryRegion" || sceneName == "CanneryRegion_SANDBOX")
                {
                    new PeakInletManager().PlaceTerrain();
                }

                if(sceneName == "CanneryRegion" || sceneName == "CanneryRegion_SANDBOX")
                {
                    new PeakInletManager().PlaceAssets();
                }


                if (sceneName == "CanneryRegion" || sceneName == "CanneryRegion_SANDBOX")
                {
                    Clones.ChangeObjects();
                }
                */
        }

        // Helper methods to add null checks
        private void SafeSetPositionAndRotation(string path, Vector3 position, Quaternion rotation)
        {
            GameObject obj = GameObject.Find(path);
            if (obj != null && obj.transform != null)
            {
                obj.transform.SetPositionAndRotation(position, rotation);
            }
        }

        private void SafeSetActive(string path, bool active)
        {
            GameObject obj = GameObject.Find(path);
            if (obj != null)
            {
                obj.SetActive(active);
            }
        }
    }
}