﻿namespace Assets.Scripts.Gamemode.Settings
{
    public class KillTitansSettings : GamemodeSettings
    {
        public KillTitansSettings()
        {
            GamemodeType = GamemodeType.Titans;
            RestartOnTitansKilled = true;
            RespawnMode = RespawnMode.NEVER;
        }
    }
}
