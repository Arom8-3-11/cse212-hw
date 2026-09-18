/*
 * CSE 212 Lesson 6C 
 * 
 * This code will analyze the NBA basketball data and create a table showing
 * the players with the top 10 career points.
 * 
 * Note about columns:
 * - Player ID is in column 0
 * - Points is in column 8
 * 
 * Each row represents the player's stats for a single season with a single team.
 */

using Microsoft.VisualBasic.FileIO;

public class Basketball
{
    public static void Run()
    {
        // Store each player's running career total by player ID.
        var players = new Dictionary<string, int>();

        using var reader = new TextFieldParser(Path.Combine(AppContext.BaseDirectory, "basketball.csv"));
        reader.TextFieldType = FieldType.Delimited;
        reader.SetDelimiters(",");
        reader.ReadFields(); // ignore header row
        while (!reader.EndOfData) {
            var fields = reader.ReadFields()!;
            var playerId = fields[0];
            var points = int.Parse(fields[8]);

            // Add to the existing total, or create the player's first total.
            if (players.ContainsKey(playerId))
                players[playerId] += points;
            else
                players[playerId] = points;
        }

        // Convert the map to an array and sort from highest to lowest score.
        var topPlayers = players.ToArray();
        Array.Sort(topPlayers, (first, second) => second.Value - first.Value);

        Console.WriteLine();
        for (var i = 0; i < 10; ++i)
            Console.WriteLine(topPlayers[i]);
    }
}