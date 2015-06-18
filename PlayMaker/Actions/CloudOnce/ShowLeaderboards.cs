using UnityEngine;
using Trollpants.CloudOnce;
namespace HutongGames.PlayMaker.Actions
{
	[ActionCategory("CloudOnce")]
	[Tooltip("Shows Leaderboards")]
	public class ShowLeaderboards : FsmStateAction
	{
		
		public override void Reset()
		{
			
		}
		
		public override void OnEnter()
		{
			if (Cloud.Provider.IsSignedIn)
				Cloud.Provider.Leaderboards.ShowOverlay();
			Finish();
		}
		
	}
}