/*--------------------------------------------------------------|
|    Author : Iohannes Mbooumba                                 |
|    Date of creation : 03/04/2021                              |
|---------------------------------------------------------------*/

using UnityEngine;
using WoolySheep.Entity.Interfaces;

namespace WoolySheep.Entity
{
    [CreateAssetMenu(fileName = "Entity Behaviour", menuName = "WoolySheep/Entity/Behaviour")]
    public class EntityBehaviour : ScriptableObject
    {
        private float m_xB;
        private float m_yB;
        
        public void MoveTo(Transform p_entity)
        {
            Transform p_transform;
            p_transform = p_entity;
            
            //Before move
            m_xB = p_entity.position.x;
            m_yB = p_entity.position.y;
            
            
            
        }
    }
}
