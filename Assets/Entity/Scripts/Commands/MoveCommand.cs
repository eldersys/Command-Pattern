using WoolySheep.Entity.Interfaces;

namespace WoolySheep.Entity.Commands
{
    public class MoveCommand : ICommand
    {
        private Entity m_entity;
        public MoveCommand(Entity p_entity) { m_entity = p_entity;}
        
        public void Do()
        {
            // Remember the previous positions of the entity
            m_entity.m_xB = m_entity.transform.position.x;
            m_entity.m_yB = m_entity.transform.position.y;
            
            // Move toward a new position
            m_entity.Move(1+m_entity.m_nBtnClicked, 0);
        }

        public void Undo()
        {
            // Move toward the previous positions of the entity
            m_entity.Move(m_entity.m_xB, m_entity.m_yB);
        }
    }
}