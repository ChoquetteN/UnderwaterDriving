using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

        [SerializeField]
        Submarine SubmarinePlayer;

        Dictionary<KeyCode, iCommand> _controllerMaping;

        //Todo, once all commands are in and I am happy with control feel, factor out to a mapping class. 
        private void Start()
        {
        _controllerMaping = new Dictionary<KeyCode, iCommand>();
        _controllerMaping.Add(KeyCode.W, new SubMoveForward(SubmarinePlayer));
        _controllerMaping.Add(KeyCode.S, new SubMoveBackward(SubmarinePlayer));
        _controllerMaping.Add(KeyCode.A, new SubMoveLeft(SubmarinePlayer));
        _controllerMaping.Add(KeyCode.D, new SubMoveRight(SubmarinePlayer));
        _controllerMaping.Add(KeyCode.RightArrow, new TurnSubRight(SubmarinePlayer));
        _controllerMaping.Add(KeyCode.LeftArrow, new TurnSubLeft(SubmarinePlayer));
        _controllerMaping.Add(KeyCode.UpArrow, new SubMoveUp(SubmarinePlayer));
        _controllerMaping.Add(KeyCode.DownArrow, new SubMoveDown(SubmarinePlayer));
        _controllerMaping.Add(KeyCode.Escape, new QuitGame());
        } 

        private void Update() 
        {

            foreach (KeyValuePair<KeyCode, iCommand> keyValuePair in _controllerMaping)
            {
                 if (Input.GetKey(keyValuePair.Key))
                 keyValuePair.Value.Execute();
            }
            new NoInput(SubmarinePlayer).Execute();   
        }

}

