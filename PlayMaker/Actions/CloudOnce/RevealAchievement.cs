using UnityEngine;
using Trollpants.CloudOnce;
namespace HutongGames.PlayMaker.Actions
{
	[ActionCategory("CloudOnce")]
	[Tooltip("Reveals Achievement")]
	public class RevealAchievement : FsmStateAction
	{
		[Tooltip("Achievement to Reveal.")]
		public FsmString AchievementID;
		
		public override void Reset()
		{
			AchievementID = "AchievementID";
		}
		
		public override void OnEnter()
		{
			if (Cloud.Provider.IsSignedIn)
				Cloud.Provider.Achievements.RevealAchievement (AchievementID.Value);
			Finish();
		}
		
	}
}