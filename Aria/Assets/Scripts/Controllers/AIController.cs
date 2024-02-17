using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "AIContoller", menuName = "InputController/AIContoller")]
public class AIController : InputController
    {
        public override bool RetrieveJumpInput()
        {
            return true;
        }

        public override float RetrieveMoveInput()
        {
            return 1f;
        }

        public override bool RetrieveJumpHoldInput()
        {
            return false;
        }
    }
