using FOSCBot.Common.Helper;
using Navigator.Context;
using Navigator.Providers.Telegram.Actions.Messages;

namespace FOSCBot.Core.Domain.Miscellaneous.Based;

public class BasedMiscellaneousAction : MessageAction
{
    public override bool CanHandleCurrentContext()
    {
        return RandomProvider.GetThreadRandom().NextDouble() <= 0.2d &&
               (ctx.GetMessageOrDefault()?.Text?.ToLower().Equals("based") ?? false)
               || (ctx.GetMessageOrDefault()?.Text?.Equals("BASED") ?? false);
    }
}