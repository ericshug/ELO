using EloBuddy;
using ExorAIO.Utilities;
using LeagueSharp;
using LeagueSharp.SDK.Core.Utils;

using TargetSelector = PortAIO.TSManager; namespace ExorAIO.Champions.Anivia
{
    /// <summary>
    ///     The logics class.
    /// </summary>
    internal partial class Logics
    {
        /// <summary>
        ///     Called on do-cast.
        /// </summary>
        /// <param name="(sender as AIHeroClient)">The (sender as AIHeroClient).</param>
        /// <param name="args">The args.</param>
        public static void Weaving(Obj_AI_Base sender, GameObjectProcessSpellCastEventArgs args)
        {
            if (!(args.Target is AIHeroClient) || Invulnerable.Check((AIHeroClient) args.Target)) {}
        }
    }
}