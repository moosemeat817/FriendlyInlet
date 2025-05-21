using MelonLoader.Utils;
using UnityEngine.AddressableAssets;
using Il2CppSystem;
using UnityEngine.UIElements;
using UnityEngine;
using Il2Cpp;


namespace FriendlyInlet
{
    public class FriendlyInletManager : MonoBehaviour
    {

        public void PlaceTerrain()
        {
            string scene = GameManager.m_ActiveScene;


            if (scene == "CanneryRegion")
            {
                MelonLogger.Msg("****************************** AC bridge");
                // BRoken Railroad Log Bridge
                GameObject logBridge = GameObject.Find("OBJ_WalkwayBridge_01_Prefab");

                Vector3 position = new Vector3(670.4035f, 241.3179f, 1232.979f);
                Vector3 rotation = new Vector3(357.6259f, 95.9862f, 20.8763f);
                Vector3 scale = new Vector3(2f, 1.5f, 1.5f);

                SceneUtils.InstantiateObjectInScene(logBridge, position, rotation, scale);

            }

        }






        public void PlaceAssets()
        {
            string scene = GameManager.m_ActiveScene;

            /*
            if (scene == "CanneryRegion" && Settings.options.bleakPlank)
            {

                // Workshop Bridge Plank
                Vector3 position2 = new Vector3(-409.6051f, 31.8377f, -567.3127f);
                Vector3 rotation2 = new Vector3(1.4751f, 37.5107f, 359.649f);
                Vector3 scale2 = new Vector3(2.8f, 2f, 3f);

                SceneUtils.PlaceAssetsInScene("OBJ_WoodPlankSingle", position2, rotation2, scale2);
            }
            */
           
        }

    }
}
