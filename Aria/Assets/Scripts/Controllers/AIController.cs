using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "AIContoller", menuName = "InputController/AIContoller")]
public class AIContoller : InputController
{
    public override bool RetrieveJumpInput()
	{
		return true;
	}
	
	public override float RetrieveMoveInput()
	{
		return 1f;
	}
}
