using BreakTime.Share.Responses.Battle;
using MagicOnion;
using System;
using System.Text;
using System.Threading.Tasks;

namespace BreakTime.Share.Hubs
{
    public interface IBattleHubReceiver
    {
        void OnJoin(int id, string name);
    }


    public interface IBattleHub : IStreamingHub<IBattleHub, IBattleHubReceiver>
    {
        /// <summary>
        /// 参加することをサーバに伝える
        /// </summary>
        /// <param name="userName">参加者の名前</param>
        /// <returns>自分のId</returns>
        Task<BattleJoinResponse> JoinAsync(string userName);
    }
}
