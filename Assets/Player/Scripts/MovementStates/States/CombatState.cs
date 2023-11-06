using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CombatState : MovementBaseState
{
    bool sheathWeapon;
    bool attack;    
    
    public override void EnterState(Movement movement)
    {
        sheathWeapon = false; 
        attack = false;            
        
    }

    public override void UpdateState(Movement movement)
    {
        if (Input.GetKeyUp(KeyCode.R))
        {
            sheathWeapon = true;
        }

        if (Input.GetKey(KeyCode.Q))
        {
            attack = true;
        }

        if (attack)
        {
            movement.SwitchState(movement.Attack);
        }
           
        
        if (sheathWeapon)
        {
            movement.anim.SetTrigger("sheath");
            movement.SwitchState(movement.Idle);
            
        }  

                           
        
    }
}
