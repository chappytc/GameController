namespace GameController.Fighters
{
    public class ClassicFighter : Fighter
    {
        public ClassicFighter()
        {
            Energy = 100;
            Location = 0;
            InflictedDamage = 0;
            EnergyBonus = 10;
            EnergyBonusAcheivedAtDamageInflicted = 10;
            JumpEnergyDrain = 5;
            DodgeEnergyDrain = 2;
            MoveEnergyDrain = 1;
            PunchEnergyDrain = 2;
            KickEnergyDrain = 3;
            PunchInflictedDamage = 5;
            KickInflictedDamage = 7;
        }
    }
}
