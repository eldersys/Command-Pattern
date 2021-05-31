namespace WoolySheep.Entity.Interfaces
{
    public interface ICommand
    {
        ///<summary/> Execute a command
        void Do();
        
        ///<summary/> Un-execute a command
        void Undo();
    }
}