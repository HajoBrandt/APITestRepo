using System.Collections.Generic;
using CommandAPI.Models;

namespace CommandAPI.Data
{
    public interface ICommandAPIRepo
    {
        public bool SaveChanges();
        public IEnumberable<Command> GetAllCommands();
        public Command GetCommandById(int id);
        public void CreateCommand(Command cmd);
        public void UpdateCommand(Command cmd);
        public void DeleteCommand(Command cmd);
    }
}