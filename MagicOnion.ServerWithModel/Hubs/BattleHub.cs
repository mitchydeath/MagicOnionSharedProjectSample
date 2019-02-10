using BreakTime.Share.Hubs;
using BreakTime.Share.Responses.Battle;
using MagicOnion.Server.Hubs;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MagicOnion.ServerWithModel.Hubs
{
    public class BattleHub : StreamingHubBase<IBattleHub, IBattleHubReceiver>, IBattleHub
    {
        public Task<BattleJoinResponse> JoinAsync(string userName)
        {
            throw new NotImplementedException();
        }
    }
}
