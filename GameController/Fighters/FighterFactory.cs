namespace GameController.Fighters
{
    public class FighterFactory
    {
        public Fighter CreateFighter(string fighterType)
        {
            Fighter newFighter;
            switch (fighterType.ToUpper())
            {
                case "CLASSIC FIGHTER":
                    newFighter = new ClassicFighter();
                    break;

                case "MASTER FIGHTER":
                    newFighter = new MasterFighter();
                    break;

                case "STUDENT FIGHTER":
                    newFighter = new StudentFighter();
                    break;

                default:
                    newFighter = new ClassicFighter();
                    break;
            }

            return newFighter;
        }
    }
}
