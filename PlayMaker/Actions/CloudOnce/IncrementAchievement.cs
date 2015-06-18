using UnityEngine;
using Trollpants.CloudOnce;
namespace HutongGames.PlayMaker.Actions
{
	[ActionCategory("CloudOnce")]
	[Tooltip("Increments Achievement")]
	public class IncrementAchievement : FsmStateAction
	{
		[Tooltip("Achievement to Increment.")]
		public FsmString AchievementID;
		[Tooltip("Current Score.")]
		public FsmInt CurrentScore;
		[Tooltip("Goal to Reach.")]
		public FsmInt Goal;
		
		public override void Reset()
		{
			AchievementID = "AchievementID";
			CurrentScore = 0;
			Goal = 100;
		}
		
		public override void OnEnter()
		{
			if (Cloud.Provider.IsSignedIn)
				Cloud.Provider.Achievements.IncrementAchievement (AchievementID.Value, CurrentScore.Value, Goal.Value);
			Finish();
		}
		
	}
}