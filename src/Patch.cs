using HarmonyLib;
using RimWorld;
using System;
using System.Drawing;
using System.Linq;
using System.Text;
using Verse;

namespace Base64xmlDecoder
{

    [HarmonyPatch(typeof(RimWorld.IO.VirtualFileInfoExt), nameof(RimWorld.IO.VirtualFileInfoExt.LoadAsXDocument), new Type[] {typeof(string)})]
    public static class Base64XMLDecoderPatch
    {
        const string header = "base64,";

        [HarmonyPrefix]
        public static void Prefix(ref string fileContents)
        {
            if (!fileContents.StartsWith(header))
            return;

            Encoding enc = Encoding.GetEncoding("UTF-8");

            string base64data = fileContents.Substring(header.Count());

            fileContents = enc.GetString(Convert.FromBase64String(base64data));

        }

    }
}
