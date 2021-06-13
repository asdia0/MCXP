namespace MCXP
{
    using System;

    public static class Calculator
    {
        /// <summary>
        /// Converts the number of XP to levels and points.
        /// </summary>
        /// <param name="currentXP">The amount of XP.</param>
        /// <returns>The levels and points equivalent to the XP given.</returns>
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

        /// <summary>
        /// Adds a certain amount of XP and then converts the total XP to levels and points.
        /// </summary>
        /// <param name="currrentXP">Initial amount of XP.</param>
        /// <param name="diff">Amount of XP to add.</param>
        /// <returns>The levels and points equivalent to the total XP.</returns>
        public static (int levels, int points) AddXP(int currrentXP, int diff)
        {
            return GetLevelsAndPoints(currrentXP + diff);
        }

        /// <summary>
        /// Subtracts a certain amount of XP and then converts the total XP to levels and points.
        /// </summary>
        /// <param name="currrentXP">Initial amount of XP.</param>
        /// <param name="diff">Amount of XP to subtract.</param>
        /// <returns>The levels and points equivalent to the total XP.</returns>
        public static (int levels, int points) SubtractXP(int currentXP, int diff)
        {
            return GetLevelsAndPoints(currentXP - diff);
        }

        /// <summary>
        /// Converts levels and points to the number of XP.
        /// </summary>
        /// <param name="currentXP">The levels and points.</param>
        /// <returns>The number of XP equivalent to the levels and points given.</returns>
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

        /// <summary>
        /// Calculates the XP difference between two different levels and points.
        /// </summary>
        /// <param name="currentXP">Initial levels and points.</param>
        /// <param name="diff">New levels and points.</param>
        /// <returns>Difference in XP.</returns>
        public static long XPDiff((int levels, int points) currentXP, (int levels, int points) diff)
        {
            return LevelsAndPointsToXP(diff.levels, diff.points) - LevelsAndPointsToXP(currentXP.levels, currentXP.points);
        }
    }
}
