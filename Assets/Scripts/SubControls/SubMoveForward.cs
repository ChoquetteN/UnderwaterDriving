using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SubMoveForward : SubSteeringCommand
{
        public SubMoveForward(Submarine sub) : base(sub)
        {

        }

        public override void Execute()
        {
            sub.SubMoveForward();
        }
}
