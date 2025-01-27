using System;

static class QuestLogic
{
    public static bool CanFastAttack(bool knightIsAwake)
    {
        return !knightIsAwake;
    }

    public static bool CanSpy(bool knightIsAwake, bool archerIsAwake, bool prisonerIsAwake)
    {
        return knightIsAwake || archerIsAwake || prisonerIsAwake;
    }

    public static bool CanSignalPrisoner(bool archerIsAwake, bool prisonerIsAwake)
    {
        if (!archerIsAwake && prisonerIsAwake)
        {
            return true;
        }
        return false;
    }

    public static bool CanFreePrisoner(bool knightIsAwake, bool archerIsAwake, bool prisonerIsAwake, bool petDogIsPresent)
    {
        if (petDogIsPresent)
        {
            if (!knightIsAwake &&  !archerIsAwake && !prisonerIsAwake)
            {
                return true;
            }
            if (!knightIsAwake && !archerIsAwake && prisonerIsAwake)
            {
                return true;
            }
            if (knightIsAwake && !archerIsAwake && !prisonerIsAwake)
            {
                return true;
            }
            if (knightIsAwake && !archerIsAwake && prisonerIsAwake)
            {
                return true;
            }
        }
        if (!petDogIsPresent)
        {
            if(!knightIsAwake && !archerIsAwake && prisonerIsAwake)
            {
                return true;
            }
        }
        return false;

    }
}
