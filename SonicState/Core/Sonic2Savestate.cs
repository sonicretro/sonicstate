using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace SonicState
{
    public class Sonic2Savestate : Sonic1Savestate
    {
        public Sonic2Savestate()
        {
            this.Level = Sonic2Zone.EmeraldHill;
            this.CameraX = 0;
            this.CameraY = 0;
            this.SuperSonicMode = false;
            this.TailsMaxSpeed = 0;
            this.TailsAcceleration = 0;
            this.TailsDeceleration = 0;
            this.PlayerInGame = Sonic2PlayerInGame.SonicAndTails;

            this.SetWaterLevel = 0;
            this.WaterEnabled = false;

            this.MasterTrigger = Sonic2MasterTrigger.Level;
            this.LevelSelectEnabled = false;
        }

        [Category("Gameplay")]
        [Description("The game's current zone.")]
        [SavestateVariable(0x12288)]
        public new Sonic2Zone Level { get; set; }

        [Category("Gameplay")]
        [DisplayName("Camera X")]
        [Description("The X position of the camera.")]
        [SavestateVariable(0x11278)]
        public new Int16 CameraX { get; set; }

        [Category("Gameplay")]
        [DisplayName("Camera Y")]
        [Description("The Y position of the camera.")]
        [SavestateVariable(0x1127C)]
        public new Int16 CameraY { get; set; }

        [Category("Gameplay")]
        [DisplayName("Super Sonic Mode")]
        [Description("Indicates whether Sonic is currently Super.")]
        [SavestateVariable(0x12291)]
        public bool SuperSonicMode { get; set; }

        [Category("Gameplay")]
        [DisplayName("Tails' Maximum Speed")]
        [Description("The maximum speed at which Tails can run.")]
        [SavestateVariable(0x12338)]
        public Int16 TailsMaxSpeed { get; set; }

        [Category("Gameplay")]
        [DisplayName("Tails' Acceleration")]
        [Description("The speed at which Tails accelerates.")]
        [SavestateVariable(0x1233A)]
        public Int16 TailsAcceleration { get; set; }

        [Category("Gameplay")]
        [DisplayName("Tails' Deceleration")]
        [Description("The speed at which Tails decelerates.")]
        [SavestateVariable(0x1233C)]
        public Int16 TailsDeceleration { get; set; }

        [Category("Gameplay")]
        [DisplayName("Player In Game")]
        [Description("The character(s) being played in the game.")]
        [SavestateVariable(0x123E8)]
        public Sonic2PlayerInGame PlayerInGame { get; set; }

        [Category("Environment")]
        [DisplayName("Set Water Level")]
        [Description("The Y position that the water will move to.")]
        [SavestateVariable(0x11AC2)]
        public Int16 SetWaterLevel { get; set; }

        [Category("Environment")]
        [DisplayName("Water Enabled")]
        [Description("Indicates whether water is enabled.")]
        [SavestateVariable(0x11BA8)]
        public bool WaterEnabled { get; set; }

        [Category("System")]
        [DisplayName("Master Trigger")]
        [Description("Indicates the mode in which the game is running.")]
        [SavestateVariable(0x11A78)]
        public new Sonic2MasterTrigger MasterTrigger { get; set; }

        [Category("System")]
        [DisplayName("Level Select Enabled")]
        [Description("Indicates whether level select is enabled.")]
        [SavestateVariable(0x12448)]
        public bool LevelSelectEnabled { get; set; }
    }
}
