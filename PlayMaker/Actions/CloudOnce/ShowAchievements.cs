using UnityEngine;
using Trollpants.CloudOnce;
namespace HutongGames.PlayMaker.Actions
{
	[ActionCategory("CloudOnce")]
	[Tooltip("Shows Achievements")]
	public class ShowAchievements : FsmStateAction
	{
		
		public override void Reset()
		{

		}
		
		public override void OnEnter()
		{
			if (Cloud.Provider.IsSignedIn)
				Cloud.Provider.Achievements.ShowOverlay();
			Finish();
		}
		
	}
}