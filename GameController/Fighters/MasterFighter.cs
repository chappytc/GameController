namespace GameController.Fighters
{
    public class MasterFighter : Fighter
    {
        public MasterFighter()
        {
            Energy = 100;
            Location = 0;
            InflictedDamage = 0;
            EnergyBonus = 10;
            EnergyBonusAcheivedAtDamageInflicted = 10;
            JumpEnergyDrain = 5;
            DodgeEnergyDrain = 2;
            MoveEnergyDrain = 1;
            PunchEnergyDrain = 3;
            KickEnergyDrain = 4;
            PunchInflictedDamage = 10;
            KickInflictedDamage = 14;
        }
    }
}
