namespace GameController.Fighters
{
    class StudentFighter : Fighter
    {
        public StudentFighter()
        {
            Energy = 100;
            Location = 0;
            InflictedDamage = 0;
            EnergyBonus = 10;
            EnergyBonusAcheivedAtDamageInflicted = 20;
            JumpEnergyDrain = 7;
            DodgeEnergyDrain = 4;
            MoveEnergyDrain = 1;
            PunchEnergyDrain = 2;
            KickEnergyDrain = 3;
            PunchInflictedDamage = 3;
            KickInflictedDamage = 5;
        }
    }
}
