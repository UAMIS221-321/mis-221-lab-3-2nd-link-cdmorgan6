
 
        string enjoymentLevel = GetEnjoymentLevel();
        string recommendedStadium = GetStadiumRecommendation(enjoymentLevel);
        string recommendedGame = GetGameRecommendation(recommendedStadium);
        
        DisplayStadiumDetails(recommendedStadium, recommendedGame);
   

    static string GetEnjoymentLevel()
    {
        Console.WriteLine("Welcome to the College Football Intro! Please Choose your preferred enjoyment level: Boring, Average, Fun, Epic");
        string enjoymentLevel = Console.ReadLine()?.ToLower();
        return enjoymentLevel;
    }

    static string GetStadiumRecommendation(string enjoymentLevel)
    {
        string recommendedStadium = "";

        if (enjoymentLevel == "boring")
        {
            return "Neyland Stadium";
        }
        else if (enjoymentLevel == "average")
        {
            return "Jordan-Hare Stadium";
        }
        else if (enjoymentLevel == "fun")
        {
            return "Tiger Stadium";
        }
        else if (enjoymentLevel == "epic")
        {
            return "Saban Field at Bryant-Denny Stadium";
        }
       
         return recommendedStadium;
    }

    static string GetGameRecommendation(string stadium)
    {
        string recommendedGame = "";
        if (stadium == "Neyland Stadium")
        {
            return "Kent State";
        }
        else if (stadium == "Jordan-Hare Stadium")
        {
            return "Kentucky";
        }
        else if (stadium == "Tiger Stadium")
        {
            return "Alabama";
        }
        else if (stadium == "Saban Field at Bryant-Denny Stadium")
        {
            return "Auburn";
        }
       
        return recommendedGame;
    }

    static void DisplayStadiumDetails(string stadium, string game)
    {
        Console.WriteLine($" Based on your enjoyment level, Your first game you've been recommended for is the " + game + " game at the " + stadium + ".");
    }


