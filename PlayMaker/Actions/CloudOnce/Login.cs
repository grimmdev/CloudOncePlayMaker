using UnityEngine;
using Trollpants.CloudOnce;
namespace HutongGames.PlayMaker.Actions
{
	[ActionCategory("CloudOnce")]
	[Tooltip("Login to CloudOnce.")]
	public class Login : FsmStateAction
	{
		
		public override void Reset()
		{

		}
		
		public override void OnEnter()
		{
			if (!Cloud.Provider.IsSignedIn)
				Cloud.Provider.Initialize();
			Finish();
		}
		
	}
}