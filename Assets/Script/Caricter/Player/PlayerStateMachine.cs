using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStateMachine : StateMachine 
{
    public Player Player { get; }

    //States 
    public PlayerIdleState IdleState { get; }

    //
    public Vector2 MovementInput { get; set; }
    public float MovementSpeed { get; private set; }
    public float MoveSpeed {  get; private set; }
    public float RotationDamping { get; set; } = 1f;


    public float JumpForce { get; set; }

    public Transform MainCameraTransform { get; set; }


    public PlayerStateMachine(Player player)
    {
        this.Player = player;

        IdleState = new PlayerIdleState(this);

        MainCameraTransform = Camera.main.transform;

        MovementSpeed = player.Data.GroundedData.BaseSpeed;
        RotationDamping = player.Data.GroundedData.BaseRotationDamping;
    }

    internal void ChangeState(object walkState)
    {
        throw new NotImplementedException();
    }
}
