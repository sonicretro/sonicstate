using System;
using System.Collections.Generic;
using System.Text;

namespace SonicState
{
    public enum Sonic1Zone : byte
    {
        GreenHill  = 0,
        Labyrinth  = 0x01,
        Marble     = 0x02,
        StarLight  = 0x03,
        SpringYard = 0x04,
        ScrapBrain = 0x05
    }

    public enum Sonic2Zone : byte
    {
        EmeraldHill    = 0,
        Wood           = 0x02,
        Metropolis     = 0x04,
        MetropolisAct3 = 0x05,
        WingFortress   = 0x06,
        HillTop        = 0x07,
        HiddenPalace   = 0x08,
        OilOcean       = 0x0A,
        MysticCave     = 0x0B,
        CasinoNight    = 0x0C,
        ChemicalPlant  = 0x0D,
        DeathEgg       = 0x0E,
        AquaticRuin    = 0x0F,
        SkyChase       = 0x10
    }

    public enum Sonic3Zone : byte
    {
        AngelIsland       = 0,
        Hydrocity         = 0x01,
        MarbleGarden      = 0x02,
        CarnivalNight     = 0x03,
        FlyingBattery     = 0x04,
        IceCap            = 0x05,
        LaunchBase        = 0x06,
        MushroomHill      = 0x07,
        Sandopolis        = 0x08,
        LavaReef          = 0x09,
        SkySanctuary      = 0x0A,
        DeathEgg          = 0x0B,
        Doomsday          = 0x0C,
        AzureLake         = 0x0E,
        BalloonPark       = 0x0F,
        ChromeGadget      = 0x10,
        DesertPalace      = 0x11,
        EndlessMine       = 0x12,
        GumballBonusStage = 0x13,
        PinballBonusStage = 0x14,
        SlotBonusStage    = 0x15,
        LavaReefAct4      = 0x16,
        DoomsdayAct2      = 0x17
    }

    public enum Sonic1MasterTrigger : byte
    {
        SegaLogo       = 0,
        TitleScreen    = 0x04,
        Demo           = 0x08,
        Level          = 0x0C,
        SpecialStage   = 0x10,
        ContinueScreen = 0x14,
        EndGame        = 0x18,
        Credits        = 0x1C
    }

    public enum Sonic2MasterTrigger : byte
    {
        SegaLogo                   = 0,
        TitleScreen                = 0x04,
        Demo                       = 0x08,
        Level                      = 0x0C,
        SpecialStage               = 0x10,
        ContinueScreen             = 0x14,
        TwoPlayerResultScreen      = 0x18,
        TwoPlayerLevelSelectScreen = 0x1C,
        EndGame                    = 0x20,
        OptionsScreen              = 0x24,
        LevelSelectScreen          = 0x28
    }

    public enum Sonic3MasterTrigger : byte
    {
        SegaLogo1                     = 0,
        SegaLogo2                     = 0x04,
        SegaLogo3                     = 0x08,
        Level                         = 0x0C,
        SegaLogo4                     = 0x10,
        ContinueScreen                = 0x14,
        SegaLogo5                     = 0x18,
        TwoPlayerLevelSelectScreen    = 0x1C,
        Credits                       = 0x20,
        OptionsScreen                 = 0x24,
        LevelSelectScreen             = 0x28,
        SpecialStage1                 = 0x2C,
        SpecialStage2                 = 0x30,
        SpecialStage3                 = 0x34,
        CompetitionScreen             = 0x38,
        CompetitionGrandPrixCharacter = 0x3C,
        CompetitionCharacter          = 0x40,
        CompetitionResultsScreen      = 0x44,
        SpecialStageResultsScreen     = 0x48,
        SaveSlotScreen                = 0x4C,
        TimeAttackResultsScreen       = 0x50
    }

    public enum Sonic2PlayerInGame : short
    {
        SonicAndTails = 0,
        Sonic         = 0x0001,
        Tails         = 0x0002
    }

    public enum Sonic3PlayerInGame : short
    {
        SonicAndTails = 0,
        Sonic         = 0x0001,
        Tails         = 0x0002,
        Knuckles      = 0x0003
    }
}
