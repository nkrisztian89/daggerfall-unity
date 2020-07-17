// Project:         Daggerfall Tools For Unity
// Copyright:       Copyright (C) 2009-2020 Daggerfall Workshop
// Web Site:        http://www.dfworkshop.net
// License:         MIT License (http://www.opensource.org/licenses/mit-license.php)
// Source Code:     https://github.com/Interkarma/daggerfall-unity
// Original Author: Gavin Clayton (interkarma@dfworkshop.net)
// Contributors:
//
// Notes:
//

using System;

namespace DaggerfallWorkshop.Game.UserInterfaceWindows
{
    /// <summary>
    /// These strings are hard-coded into FALL.EXE.
    /// They are replicated here temporarily during development.
    /// This will eventually be moved to an improved text handler so strings are never hard-coded.
    /// </summary>
    public class HardStrings
    {
        // TODO: Note that buildingNames string key array temple names are not consistent with 4055-4062!
        // This note has been preserved from prior to localization

        public static readonly string[] extraSpellPtsTimes = { "during Winter", "during Spring", "during Summer", "during Fall", "during Full Moon", "during Half Moon", "during New Moon", "near undead", "near daedra", "near humanoids", "near animals" };
        public static readonly string[] regensHealthTimes = { "all the time", "in sunlight", "in darkness" };
        public static readonly string[] vampiricEffectRanges = { "at range", "when strikes" };
        public static readonly string[] increasedWeightAllowances = { "25% additional", "50% additional" };
        public static readonly string[] improvedTalents = { "hearing", "athleticism", "adrenaline rush" };
        public static readonly string[] itemDeteriorateLocations = { "all the time", "in sunlight", "in holy places" };
        public static readonly string[] userTakesDamageLocations = { "in sunlight", "in holy places" };
        public static readonly string[] enemyGroupNames =  { "undead", "Daedra", "humanoids", "animals" };
        public static readonly string[] healthLeechStopConditions = { "whenever used", "unless used daily", "unless used weekly" };
        public static readonly string[] badReactionFromEnemyGroups = { "humanoids", "animals", "Daedra" };
        public static readonly string[] repWithGroups = { "Commoners", "Merchants", "Scholars", "Nobility", "Underworld", "All" };

        public const string youReceiveGoldPieces = "You receive %s gold pieces.";     // Custom message for "get item" gold assignment

        public const string bankPurchasePrice = "Price : %s gold";

        public const string youHaveRentedRoom = "You have a room at %s for %d hours.";
        public const string haveNotRentedRoom = "You have not rented a room here.";
        public const string expiredRentedRoom = "Your time for this room has expired.";
        public const string tavernAle = "Ale (1 gold)";
        public const string tavernBeer = "Beer (1 gold)";
        public const string tavernMead = "Mead (2 gold)";
        public const string tavernWine = "Wine (3 gold)";
        public const string tavernBread = "Bread (1 gold)";
        public const string tavernBroth = "Broth (1 gold)";
        public const string tavernCheese = "Cheese (2 gold)";
        public const string tavernFowl = "Fowl (3 gold)";
        public const string tavernGruel = "Gruel (2 gold)";
        public const string tavernPie = "Pie (2 gold)";
        public const string tavernStew = "Stew (3 gold)";


        public const string pressButtonToFireSpell = "Press button to fire spell.";

        public const string climbingMode = "Climbing mode.";
        public const string rappelMode = "Rappel mode.";
        public const string hangingMode = "Hanging Mode";

        public const string acuteHearing = "Acute Hearing";
        public const string adrenalineRush = "Adrenaline Rush";
        public const string athleticism = "Athleticism";
        public const string bonusToHit = "Bonus to hit";
        public const string expertiseIn = "Expertise in";
        public const string immunity = "Immunity";
        public const string increasedMagery = "Increased Magery";
        public const string rapidHealing = "Rapid Healing";
        public const string regenerateHealth = "Regenerate Health";
        public const string resistance = "Resistance";
        public const string spellAbsorption = "Spell Absorption";
        public const string animals = "Animals";
        public const string daedra = "Daedra";
        public const string humanoid = "Humanoid";
        public const string undead = "Undead";
        public const string axe = "Axe";
        public const string bluntWeapon = "Blunt Weapon";
        public const string handToHand = "Hand_To_Hand";
        public const string longBlade = "Long Blade";
        public const string missileWeapon = "Missile Weapon";
        public const string shortBlade = "Short Blade";
        public const string toDisease = "To Disease";
        public const string toFire = "To Fire";
        public const string toFrost = "To Frost";
        public const string toMagic = "To Magic";
        public const string toParalysis = "To Paralysis";
        public const string toPoison = "To Poison";
        public const string toShock = "To Shock";
        public const string intInSpellPoints15 = "1.5X INT In Spell Points";
        public const string intInSpellPoints175 = "1.75X INT In Spell Points";
        public const string intInSpellPoints2 = "2X INT In Spell Points";
        public const string intInSpellPoints3 = "3X INT In Spell Points";
        public const string intInSpellPoints = "INT In Spell Points";
        public const string general = "General";
        public const string inDarkness = "In Darkness";
        public const string inLight = "In Light";
        public const string whileImmersed = "While Immersed In Water";

        public const string criticalWeakness = "Critical Weakness";
        public const string damage = "Damage";
        public const string darknessPoweredMagery = "Darkness_Powered Magery";
        public const string forbiddenArmorType = "Forbidden Armor Type";
        public const string forbiddenMaterial = "Forbidden Material";
        public const string forbiddenShieldTypes = "Forbidden Shield Types";
        public const string forbiddenWeaponry = "Forbidden Weaponry";
        public const string inabilityToRegen = "Inability To Regen Spell Points";
        public const string lightPoweredMagery = "Light_Powered Magery";
        public const string lowTolerance = "Low Tolerance";
        public const string phobia = "Phobia";
        public const string fromHolyPlaces = "From Holy Places";
        public const string fromSunlight = "From Sunlight";
        public const string lowerMagicAbilityDaylight = "Lower Magic Ability In Daylight";
        public const string unableToUseMagicInDaylight = "Unable To Use Magic In Daylight";
        public const string chain = "Chain";
        public const string leather = "Leather";
        public const string plate = "Plate";
        public const string adamantium = "Adamantium";
        public const string daedric = "Daedric";
        public const string dwarven = "Dwarven";
        public const string ebony = "Ebony";
        public const string elven = "Elven";
        public const string iron = "Iron";
        public const string mithril = "Mithril";
        public const string orcish = "Orcish";
        public const string silver = "Silver";
        public const string steel = "Steel";
        public const string buckler = "Buckler";
        public const string kiteShield = "Kite Shield";
        public const string roundShield = "Round Shield";
        public const string towerShield = "Tower Shield";
        public const string lowerMagicAbilityDarkness = "Lower Magic Ability In Darkness";
        public const string unableToUseMagicInDarkness = "Unable To Use Magic In Darkness";
        public const string helpAttributes = "Attributes";
        public const string helpClassName = "Class Name";
        public const string helpGeneral = "General";
        public const string helpReputations = "Reputations";
        public const string helpSkillAdvancement = "Skill Advancement";
        public const string helpSkills = "Skills";
        public const string helpSpecialAdvantages = "Special Advantages";
        public const string helpSpecialDisadvantages = "Special Disadvantages";
        public const string lower = "Lower";
        public const string higher = "Higher";
        public const string unchanged = "Unchanged";
        public const string elsweyr = "Elsweyr";
        public const string blackMarsh = "Black Marsh";
        public const string hammerfell = "Hammerfell";
        public const string highRock = "High Rock";
        public const string morrowind = "Morrowind";
        public const string skyrim = "Skyrim";
        public const string sumurset = "Sumurset";
        public const string valenwood = "Valenwood";
        public const string rollingHills = "rolling hills";
        public const string desertLand = "desertland";
        public const string mountains = "mountains";
        public const string swamps = "swamps";
        public const string forests = "forests";
        public const string shores = "shores";
    }
}
