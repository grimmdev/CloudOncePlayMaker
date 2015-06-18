using UnityEngine;
using Trollpants.CloudOnce;
namespace HutongGames.PlayMaker.Actions
{
	[ActionCategory("CloudOnce")]
	[Tooltip("Check the login state, if logged in then continue.")]
	public class CheckLogin : FsmStateAction
	{
		
		[Tooltip("Event to send if the variable changes.")]
		public FsmEvent changedEvent;
		
		bool previousValue;
		
		public override void Reset()
		{
			changedEvent = null;
		}
		
		public override void OnEnter()
		{

		}
		
		public override void OnUpdate()
		{
			if (Cloud.Provider.IsSignedIn)
				Fsm.Event (changedEvent);
		}
	}
}

