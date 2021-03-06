﻿using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;

namespace WarWolfWorks_Mod.Internal
{
    public static class Constants
    {
        public static string TEXN_STAND_SP_AB_MAIN = "Images/DefaultTexture.png";
        public static string TN_DEFAULT = "Images/DefaultTexture.png";

        #region Stands
        public const string ANIMBASENAME_STARPLATINUM_IDLE = "SPIDLEA_",
            ANIMBASENAME_STARPLATINUM_ATK = "SPATKA_";

        public static readonly Animation ANIM_STARPLATINUM_IDLE = new Animation
            (
            new KeyValuePair<TimeSpan, string>(new TimeSpan(0), ANIMBASENAME_STARPLATINUM_IDLE + "0"),
            new KeyValuePair<TimeSpan, string>(TimeSpan.FromSeconds(0.05d), ANIMBASENAME_STARPLATINUM_IDLE + "1")
            );

        public static readonly Animation ANIM_STARPLATINUM_ATK = new Animation
            (
            new KeyValuePair<TimeSpan, string>(new TimeSpan(0), ANIMBASENAME_STARPLATINUM_ATK + "0"),
            new KeyValuePair<TimeSpan, string>(TimeSpan.FromSeconds(0.05d), ANIMBASENAME_STARPLATINUM_ATK + "1")
            );

        public const string ANIMBASENAME_THEWORLD_IDLE = "TWIDLEA_",
            ANIMBASENAME_THEWORLD_ATK = "TWATKA_";

        public static readonly Animation ANIM_THEWORLD_IDLE = new Animation
           (
           new KeyValuePair<TimeSpan, string>(new TimeSpan(0), ANIMBASENAME_THEWORLD_IDLE + "0"),
           new KeyValuePair<TimeSpan, string>(TimeSpan.FromSeconds(0.05d), ANIMBASENAME_THEWORLD_IDLE + "1")
           );

        public static readonly Animation ANIM_THEWORLD_ATK = new Animation
            (
            new KeyValuePair<TimeSpan, string>(new TimeSpan(0), ANIMBASENAME_THEWORLD_ATK + "0"),
            new KeyValuePair<TimeSpan, string>(TimeSpan.FromSeconds(0.05d), ANIMBASENAME_THEWORLD_ATK + "1")
            );
        #endregion

#region Textures
        public static Texture2D TEX_UI_STAND_SP_AUTO { get; private set; }
        public static Texture2D TEX_UI_STAND_SP_PORTRAIT { get; private set; }
#endregion

        /// <summary>
        /// Initializes all non-runtime variables.
        /// </summary>
        public static void Init()
        {
            TEX_UI_STAND_SP_AUTO = WWWMOD.Instance.GetTexture("UI/SM_SP_AUTO");
            TEX_UI_STAND_SP_PORTRAIT = WWWMOD.Instance.GetTexture("UI/SM_SP_PORTRAIT");

        }
    }
}
