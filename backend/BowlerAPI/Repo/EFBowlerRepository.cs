using BowlerAPI.Context;
using BowlerAPI.Migrations;
using SQLitePCL;

namespace BowlerAPI.Repo;

public class EFBowlerRepository : IBowlerRepository
{
    private BowlerContext _context;

    public EFBowlerRepository(BowlerContext temp)
    {
        _context = temp;
    }

    public IEnumerable<Bowler> Bowlers => _context.Bowlers;
    public IEnumerable<Team> Teams => _context.Teams;
}