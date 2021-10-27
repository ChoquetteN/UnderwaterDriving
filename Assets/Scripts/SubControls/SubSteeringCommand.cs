using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class SubSteeringCommand : iCommand
{

    protected Submarine sub { private set; get; }

    protected SubSteeringCommand(Submarine Submarine)
    {
        sub = Submarine;
    }

    public abstract void Execute();

}
