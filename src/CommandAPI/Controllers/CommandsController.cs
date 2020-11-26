using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using CommandAPI.Data;
using CommandAPI.Models;

namespace CommandAPI.Controllers
{
    [Route ("api/[controller]")]
    [ApiController]
    public class CommandsController : ControllerBase
    {
        //add the following code to our class

        private readonly ICommandAPIRepo _repository;

        public CommandsController (ICommandAPIRepo repository)
        {
            _repository = repository;
        }

        //Get endpoint
        [HttpGet]
        public ActionResult<IEnumerable<Command>> GetAllCommands()
        {
            var commandItems = _repository.GetAllCommands();
            return Ok(commandItems);
        }

        [HttpGet("{id}")]
        public ActionResult<Command> GetCommandById(int Id)
        {
            var commandItem = _repository.GetCommandById(Id);
            if (commandItem == null)
            {
                return NotFound();
            }
            return Ok(commandItem);
        }

        /*[HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return new string[] {"this", "is", "hard", "coded"};
        }*/
    }
}