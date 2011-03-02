using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace SonicState
{
    public class Sonic1Savestate : Savestate
    {
        public Sonic1Savestate()
        {
            this.Level = Sonic1Zone.GreenHill;
            this.Act = 0;
            this.Lives = 0;
            this.Continues = 0;
            this.Rings = 0;
            this.Minutes = 0;
            this.Seconds = 0;
            this.Milliseconds = 0;
            this.Score = 0;
            this.Emeralds = 0;
            this.CameraX = 0;
            this.CameraY = 0;
            this.LampPostsHit = 0;
            this.Shield = false;
            this.Invincibility = false;
            this.SpeedShoes = false;

            this.WaterLevel = 0;
            this.WaterSpeed = 0;
            this.MaximumSpeed = 0;
            this.Acceleration = 0;
            this.Deceleration = 0;

            this.MasterTrigger = Sonic1MasterTrigger.Level;
            this.DemoMode = false;
            this.DebugMode = false;
            this.RestartLevel = false;
            this.ScreenLocked = false;
            this.ControlsLocked = false;
        }
        
        [Category("Gameplay")]
        [Description("The game's current zone.")]
        [SavestateVariable(0x12288)]
        public Sonic1Zone Level { get; set; }

        [Category("Gameplay")]
        [Description("The game's current act. Note that this value is zero-based.")]
        [SavestateVariable(0x12289)]
        public byte Act { get; set; }

        [Category("Gameplay")]
        [Description("The player's lives.")]
        [SavestateVariable(0x1228A)]
        public byte Lives { get; set; }

        [Category("Gameplay")]
        [Description("The player's continues.")]
        [SavestateVariable(0x12290)]
        public byte Continues { get; set; }

        [Category("Gameplay")]
        [Description("The player's rings.")]
        [SavestateVariable(0x12298)]
        public Int16 Rings { get; set; }

        [Category("Gameplay")]
        [Description("The amount of minutes on the clock.")]
        [SavestateVariable(0x1229B)]
        public byte Minutes { get; set; }

        [Category("Gameplay")]
        [Description("The amount of seconds on the clock.")]
        [SavestateVariable(0x1229C)]
        public byte Seconds { get; set; }

        [Category("Gameplay")]
        [Description("The amount of milliseconds on the clock.")]
        [SavestateVariable(0x1229D)]
        public byte Milliseconds { get; set; }

        [Category("Gameplay")]
        [Description("The player's score. Note that the in-game score will be multiplied by 10.")]
        [SavestateVariable(0x1229E)]
        public uint Score { get; set; }

        [Category("Gameplay")]
        [Description("The number of emeralds the player has obtained.")]
        [SavestateVariable(0x12428)]
        public byte Emeralds { get; set; }

        [Category("Gameplay")]
        [DisplayName("Camera X")]
        [Description("The X position of the camera.")]
        [SavestateVariable(0x11B78)]
        public Int16 CameraX { get; set; }

        [Category("Gameplay")]
        [DisplayName("Camera Y")]
        [Description("The Y position of the camera.")]
        [SavestateVariable(0x11B7C)]
        public Int16 CameraY { get; set; }

        [Category("Gameplay")]
        [DisplayName("Lamp Posts Hit")]
        [Description("The number of lamp posts the player has hit.")]
        [SavestateVariable(0x122A8)]
        public byte LampPostsHit { get; set; }

        [Category("Gameplay")]
        [Description("Indicates whether the player can take a hit before losing rings.")]
        [SavestateVariable(0x122A4)]
        public bool Shield { get; set; }

        [Category("Gameplay")]
        [Description("Indicates whether the player has invincibility.")]
        [SavestateVariable(0x122A5)]
        public bool Invincibility { get; set; }

        [Category("Gameplay")]
        [DisplayName("Speed Shoes")]
        [Description("Indicates whether the player has speed shoes.")]
        [SavestateVariable(0x122A6)]
        public bool SpeedShoes { get; set; }

        [Category("Environment")]
        [DisplayName("Water Level")]
        [Description("The Y position of the level's water.")]
        [SavestateVariable(0x11AC0)]
        public Int16 WaterLevel { get; set; }

        [Category("Environment")]
        [DisplayName("Water Speed")]
        [Description("The speed at which water moves.")]
        [SavestateVariable(0x11AC4)]
        public byte WaterSpeed { get; set; }

        [Category("Environment")]
        [DisplayName("Maximum Speed")]
        [Description("The maximum speed at which the player can run.")]
        [SavestateVariable(0x11BD8)]
        public Int16 MaximumSpeed { get; set; }

        [Category("Environment")]
        [Description("The speed at which the player accelerates.")]
        [SavestateVariable(0x11BDA)]
        public Int16 Acceleration { get; set; }

        [Category("Environment")]
        [Description("The speed at which the player decelerates.")]
        [SavestateVariable(0x11BDC)]
        public Int16 Deceleration { get; set; }

        [Category("System")]
        [DisplayName("Master Trigger")]
        [Description("Indicates the mode in which the game is running.")]
        [SavestateVariable(0x11A78)]
        public Sonic1MasterTrigger MasterTrigger { get; set; }

        [Category("System")]
        [DisplayName("Demo Mode")]
        [Description("Indicates whether the game is in demo mode.")]
        [SavestateVariable(0x12468)]
        public bool DemoMode { get; set; }

        [Category("System")]
        [DisplayName("Debug Mode")]
        [Description("Indicates whether the game is in debug mode.")]
        [SavestateVariable(0x12472)]
        public bool DebugMode { get; set; }

        [Category("System")]
        [DisplayName("Restart Level")]
        [Description("Indicates whether the level should be restarted.")]
        [SavestateVariable(0x1227A)]
        public bool RestartLevel { get; set; }

        [Category("System")]
        [DisplayName("Screen Locked")]
        [Description("Indicates whether the screen is locked.")]
        [SavestateVariable(0x11C22)]
        public bool ScreenLocked { get; set; }

        [Category("System")]
        [DisplayName("Controls Locked")]
        [Description("Indicates whether the controls are locked.")]
        [SavestateVariable(0x11C40)]
        public bool ControlsLocked { get; set; }
    }
}
