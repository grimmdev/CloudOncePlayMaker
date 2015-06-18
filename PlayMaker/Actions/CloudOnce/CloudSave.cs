using UnityEngine;
using Trollpants.CloudOnce;
namespace HutongGames.PlayMaker.Actions
{
	[ActionCategory("CloudOnce")]
	[Tooltip("Saves your Cloud Data.")]
	public class CloudSave : FsmStateAction
	{
		
		public override void Reset()
		{

		}
		
		public override void OnEnter()
		{
			if (Cloud.Provider.IsSignedIn)
				Cloud.Provider.Storage.Save();
			Finish();
		}
		
	}
}