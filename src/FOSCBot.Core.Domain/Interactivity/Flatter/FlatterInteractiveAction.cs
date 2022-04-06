using FOSCBot.Common.Helper;
using Navigator.Context;
using Navigator.Providers.Telegram.Actions.Messages;

namespace FOSCBot.Core.Domain.Interactivity.Flatter;

public class FlatterInteractiveAction : MessageAction
{
    public override bool CanHandleCurrentContext()
    {
        return ctx.IsBotQuotedOrMentioned() && ctx.IsBotFlattered();
    }
}