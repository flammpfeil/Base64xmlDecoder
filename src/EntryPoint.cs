using System.Reflection;
using Verse;
using HarmonyLib;

namespace Base64xmlDecoder
{
    public class Core : Mod
    {

        public Core(ModContentPack content) : base(content)
        {
            Harmony harmonyInstance = new Harmony("flammpfeil.base64xmldecoder");
            harmonyInstance.PatchAll(Assembly.GetExecutingAssembly());
            
        }
    }

}
