/*--------------------------------------------------------------|
|    Author : Iohannes Mbooumba                                 |
|    Date of creation : XX/XX/20XX                              |
|---------------------------------------------------------------*/

using UnityEngine;
using WoolySheep.Entity.Commands;
using WoolySheep.Entity.Interfaces;

namespace WoolySheep.Entity
{
    public class Entity : MonoBehaviour
    {
        //--------------------------- Public variables ---------------------------//
        /// <summary/> The previous positions of the entity
        [SerializeField] public float m_xB, m_yB;
        
        /// <summary/> The number of click we do on the button to check the movement
        [SerializeField] public float m_nBtnClicked;
        
        //--------------------------- Hidden variables ---------------------------//
        
        /// <summary/> Command for the movement
        [SerializeField] private ICommand m_moveCommand;
        
        //--------------------------- Methods ---------------------------//

        private void Awake()
        {
            // Implementation of the command
            m_moveCommand = new MoveCommand(this);
        }
        
        // Method to use the buttons of the canvas. Might not be useful in the future
        public void DoMove()
        {
            m_moveCommand.Do();
            
            // This mess if only to debug for undoing multiple moves. It can be improved I suppose
            
            //--------------------------------------------------//
            
            m_nBtnClicked++;
            
            //--------------------------------------------------//
        }
        
        // Method to use the buttons of the canvas. Might not be useful in the future
        public void UndoMove()
        {
            m_moveCommand.Undo();
            
            // This mess if only to debug for undoing multiple moves. It can be improved I suppose
            
            //--------------------------------------------------//
            if (m_nBtnClicked != m_xB && m_xB>0)
            {
                m_nBtnClicked--;
                m_xB--;

                if (m_xB == 0)
                    m_nBtnClicked = 0;
            }
            
            //--------------------------------------------------//
        }
        
        // Make the entity move according to positions we give
        public void Move(float p_x, float p_y)
        {
            Vector3 p_position = new Vector3(p_x, p_y, 0);
            transform.SetPositionAndRotation(p_position, Quaternion.identity);
        }
    }
}