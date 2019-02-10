using MessagePack;

namespace BreakTime.Share.Responses.Battle
{
    [MessagePackObject]
    public class BattleJoinResponse
    {
        [Key(0)]
        public int OwnId { get; set; }
        [Key(1)]
        public string[] Members { get; set; }
    }
}
