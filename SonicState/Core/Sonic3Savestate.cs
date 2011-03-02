using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace SonicState
{
    public class Sonic3Savestate : Sonic2Savestate
    {
        public Sonic3Savestate()
        {
            this.Level = Sonic3Zone.AngelIsland;
            this.PlayerInGame = Sonic3PlayerInGame.SonicAndTails;
            this.SuperEmeralds = 0;
            this.CameraX = 0;
            this.CameraY = 0;

            this.MasterTrigger = Sonic3MasterTrigger.Level;
        }

        [Category("Gameplay")]
        [Description("The game's current zone.")]
        [SavestateVariable(0x12288)]
        public new Sonic3Zone Level { get; set; }

        [Category("Gameplay")]
        [DisplayName("Player In Game")]
        [Description("The character(s) being played in the game.")]
        [SavestateVariable(0x123EA)]
        public new Sonic3PlayerInGame PlayerInGame { get; set; }

        [Category("Gameplay")]
        [DisplayName("Super Emeralds")]
        [Description("The number of super emeralds the player has obtained.")]
        [SavestateVariable(0x12429)]
        public byte SuperEmeralds { get; set; }

        [Category("Gameplay")]
        [DisplayName("Camera X")]
        [Description("The X position of the camera.")]
        [SavestateVariable(0x112F0)]
        public new Int16 CameraX { get; set; }

        [Category("Gameplay")]
        [DisplayName("Camera Y")]
        [Description("The Y position of the camera.")]
        [SavestateVariable(0x112F4)]
        public new Int16 CameraY { get; set; }

        [Category("System")]
        [DisplayName("Master Trigger")]
        [Description("Indicates the mode in which the game is running.")]
        [SavestateVariable(0x11A78)]
        public new Sonic3MasterTrigger MasterTrigger { get; set; }
    }
}
