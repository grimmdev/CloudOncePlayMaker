using UnityEngine;
using Trollpants.CloudOnce;
namespace HutongGames.PlayMaker.Actions
{
	[ActionCategory("CloudOnce")]
	[Tooltip("Submit Score")]
	public class SubmitScore : FsmStateAction
	{
		[Tooltip("Leaderboard to submit to.")]
		public FsmString LeaderboardID;
		[Tooltip("Score to Submit.")]
		public FsmInt Score;
		
		public override void Reset()
		{
			LeaderboardID = "LeaderboardID";
			Score = 1;
		}
		
		public override void OnEnter()
		{
			Cloud.Provider.Leaderboards.SubmitScore(LeaderboardID.Value, Score.Value);
			Finish();
		}
		
	}
}