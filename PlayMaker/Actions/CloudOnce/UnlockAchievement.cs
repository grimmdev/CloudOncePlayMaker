using UnityEngine;
using Trollpants.CloudOnce;
namespace HutongGames.PlayMaker.Actions
{
	[ActionCategory("CloudOnce")]
	[Tooltip("Unlocks Achievement")]
	public class UnlockAchievement : FsmStateAction
	{
		[Tooltip("Achievement to Unlock.")]
		public FsmString AchievementID;
		
		public override void Reset()
		{
			AchievementID = "AchievementID";
		}
		
		public override void OnEnter()
		{
			Cloud.Provider.Achievements.UnlockAchievement (AchievementID.Value);
			Finish();
		}
		
	}
}