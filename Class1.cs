using BepInEx;
using RoR2;

namespace MyUserName
{
    [BepInDependency("com.bepis.r2api")]
    //Change these
    [BepInPlugin("com.MyCompanyName.MyModName", "My Mod's Title and if we see this exact name on Thunderstore we will deprecate your mod", "1.0.0")]
    public class MyModName : BaseUnityPlugin
    {
        public void Awake()
        {
            Logger.LogMessage("Loaded MyModName!");
        }
    }
}