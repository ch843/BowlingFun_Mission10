using BowlerAPI.Migrations;

namespace BowlerAPI.Repo;

public interface IBowlerRepository
{
    IEnumerable<Bowler> Bowlers { get; }
    IEnumerable<Team> Teams { get; }
}