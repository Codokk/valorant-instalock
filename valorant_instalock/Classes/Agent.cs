using System.Collections.Generic;
using System.Linq;
using valorant_instalock.Models;

namespace valorant_instalock.Classes
{
    public static class Agent
    {
        public static Coordinate SelectedAgent { get; set; }

        public static Dictionary<string, Coordinate> agentCoordinates = new Dictionary<string, Coordinate>
        {
            { "astra", new Coordinate(585, 930) },
            { "breach", new Coordinate(668, 930) },
            { "brimstone", new Coordinate(751, 930) },
            { "chamber", new Coordinate(834, 930) },
            { "cypher", new Coordinate(917, 930) },
            { "fade", new Coordinate(1000, 930) },
            { "harbor", new Coordinate(1083, 930) },
            { "jett", new Coordinate(1166, 930) },
            { "killjoy", new Coordinate(1249, 930) },
            { "neon", new Coordinate(585, 930) },
            { "omen", new Coordinate(668, 1010) },
            { "phoenix", new Coordinate(751, 1010) },
            { "raze", new Coordinate(834, 1010) },
            { "reyna", new Coordinate(917, 1010) },
            { "sage", new Coordinate(1000, 1010) },
            { "sova", new Coordinate(1083, 1010) },
            { "viper", new Coordinate(1166, 1010) },
            { "yoru", new Coordinate(1249, 1010) },
        };

        public static Coordinate GetAgentCoordinatesByName(string agentName)
        => agentCoordinates.Where(c => c.Key == agentName).Select(c => c.Value).FirstOrDefault();

        public static string GetAgentNameByCoordinates(int X, int Y)
        => agentCoordinates.Where(c => c.Value.X == X && c.Value.Y == Y).Select(c => c.Key).FirstOrDefault();

        public static string[] getAgents()
        => agentCoordinates.Keys.ToArray();
    }
}