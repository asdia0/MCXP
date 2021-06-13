namespace MCXP
{
    public static class Calculator
    {        
        public static (int levels, int points) GetLevelsAndPoints(int currentXP)
        {
            for (int i = 0; i <= 15; i++)
            {
                int requiredXP = (2 * i) + 7;

                if (currentXP >= requiredXP)
                {
                    currentXP -= requiredXP;
                }
                else
                {
                    return (i, currentXP);
                }
            }

            for (int i = 16; i <= 30; i++)
            {
                int requiredXP = (5 * i) - 38;

                if (currentXP >= requiredXP)
                {
                    currentXP -= requiredXP;
                }
                else
                {
                    return (i, currentXP);
                }
            }

            int lvl = 31;

            while (true)
            {
                int requiredXP = (9 * lvl) - 158;

                if (currentXP >= requiredXP)
                {
                    currentXP -= requiredXP;
                    lvl++;
                }
                else
                {
                    return (lvl, currentXP);
                }
            }
        }

        public static (int levels, int points) AddXP(int currrentXP, int diff)
        {
            return GetLevelsAndPoints(currrentXP + diff);
        }

        public static (int levels, int points) SubtractXP(int currentXP, int diff)
        {
            return GetLevelsAndPoints(currentXP - diff);
        }
    }
}
