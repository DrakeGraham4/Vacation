using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Vacation.Models;
using Vacation.Services;

namespace Vacation.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TripsController : ControllerBase
    {
        private readonly TripsService _ts;

        public TripsController(TripsService ts)
        {
            _ts = ts;
        }

        // Get All Trips
        [HttpGet]
        public ActionResult<List<Trip>> GetAll()
        {
            try
            {
                List<Trip> trips = _ts.GetAll();
                return Ok(trips);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        //Get By Id

        [HttpGet("{id}")]
        public ActionResult<Trip> GetById(int id)
        {
            try
            {
                Trip trip = _ts.GetById(id);
                return Ok(trip);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        //Create
        [HttpPost]
        public ActionResult<Trip> Create([FromBody] Trip tripData)
        {
            try
            {
                Trip trip = _ts.Create(tripData);
                return Created($"api/trips/{trip.Id}", trip);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpDelete("{id}")]
        public ActionResult<Trip> Remove(int id)
        {
            try
            {
                _ts.Remove(id);
                return Ok("Deleted Trip");
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }
    }
}