using System.Diagnostics.CodeAnalysis;
using BowlerAPI.Migrations;
using BowlerAPI.Repo;
using Microsoft.AspNetCore.Mvc;

namespace BowlerAPI.Controllers;

[ApiController]
[Route("api/[controller]")]
public class BowlerController : Controller
{
    private IBowlerRepository _repo;

    public BowlerController(IBowlerRepository temp)
    {
        _repo = temp;
    }

    [HttpGet]
    public IEnumerable<BowlerWithTeam> Get()
    {
        //perform the join
        var joinedData = from bowler in _repo.Bowlers
            join team in _repo.Teams
                on bowler.TeamId equals team.TeamId
            where team.TeamName is "Marlins" or "Sharks"
            select new BowlerWithTeam
            {
                BowlerId = bowler.BowlerId,
                BowlerFirstName = bowler.BowlerFirstName,
                BowlerLastName = bowler.BowlerLastName,
                BowlerMiddleInit = bowler.BowlerMiddleInit,
                BowlerAddress = bowler.BowlerAddress,
                BowlerCity = bowler.BowlerCity,
                BowlerState = bowler.BowlerState,
                BowlerZip = bowler.BowlerZip,
                BowlerPhoneNumber = bowler.BowlerPhoneNumber,
                TeamName = team.TeamName,
            };
        
        var bowlerData = joinedData.ToArray();

        return bowlerData;
    }
}