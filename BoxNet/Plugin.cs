using BepInEx;
using UnityEngine;

namespace BoxNet
{
    [BepInDependency("dev.monkephone", "1.0.10")]
    [BepInDependency("eh.boxapps", "1.0.10")]

    [BepInPlugin(Constants.GUID, Constants.Name, Constants.Version)]
    public class Plugin : BaseUnityPlugin
    {
        public void Awake()
        {
            GorillaTagger.OnPlayerSpawned(() =>
            {
                DontDestroyOnLoad(new GameObject(Constants.Name, typeof(NetBox)));
            });
        }
    }
}
