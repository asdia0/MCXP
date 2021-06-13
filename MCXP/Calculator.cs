namespace MCXP
{
    using System;

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

        public static long LevelsAndPointsToXP(int levels, int points)
        {
            if (levels < 0)
            {
                throw new Exception("Levels must be non-negative.");
            }

            if (levels <= 16)
            {
                return (levels * levels) + (6 * levels) + points;
            }

            if (levels <= 31)
            {
                return (int)((2.5 * levels * levels) - (40.5 * levels) + 360 + points);
            }

            return (int)((4.5 * levels * levels) - (162.5 * levels) + 2220 + points);
        }
    }
}
