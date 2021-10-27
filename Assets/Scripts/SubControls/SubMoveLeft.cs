using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SubMoveLeft : SubSteeringCommand
{
    public SubMoveLeft(Submarine sub) : base(sub)
    {

    }

    public override void Execute()
    {
        sub.SubMoveLeft();
    }
}
