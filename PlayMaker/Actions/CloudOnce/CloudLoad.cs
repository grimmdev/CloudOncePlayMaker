using UnityEngine;
using Trollpants.CloudOnce;
namespace HutongGames.PlayMaker.Actions
{
	[ActionCategory("CloudOnce")]
	[Tooltip("Loads your Cloud Data.")]
	public class CloudLoad : FsmStateAction
	{
		
		public override void Reset()
		{
			
		}
		
		public override void OnEnter()
		{
			if (Cloud.Provider.IsSignedIn)
				Cloud.Provider.Storage.Load();
			Finish();
		}
		
	}
}