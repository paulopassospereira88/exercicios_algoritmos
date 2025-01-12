Console.WriteLine("Exercicio da plataforma Exercism - annalyns infiltration");

bool result1 = QuestLogic.CanFastAttack(true);
Console.WriteLine(result1);

bool result2 = QuestLogic.CanSpy(false, true, false);
Console.WriteLine(result2);

bool result3 = QuestLogic.CanSignalPrisoner(false, true);
Console.WriteLine(result3);

bool result4 = QuestLogic.CanFreePrisoner(false, true, false,  false);
Console.WriteLine(result4);

static class QuestLogic
{
    public static bool CanFastAttack(bool knightIsAwake)
    {
        if(knightIsAwake == true)
        {
            return false;
        }
        return true;
    }

    public static bool CanSpy(bool knightIsAwake, bool archerIsAwake, bool prisonerIsAwake)
    {
        if(knightIsAwake == true || archerIsAwake == true || prisonerIsAwake == true)
        {
            return true;
        }
        return false;
    }

    public static bool CanSignalPrisoner(bool archerIsAwake, bool prisonerIsAwake)
    {
        if (archerIsAwake == false && prisonerIsAwake == true)
        {
            return true;
        }
        return false;
    }

    public static bool CanFreePrisoner(bool knightIsAwake, bool archerIsAwake, bool prisonerIsAwake, bool petDogIsPresent)
    {
        if(archerIsAwake == false && petDogIsPresent == true)
        {
            return true;
        }else if(knightIsAwake == false && archerIsAwake == false && prisonerIsAwake == true)
        {
            return true;
        }
        return false;
    }
}

