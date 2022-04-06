using Navigator.Context;
using Navigator.Providers.Telegram.Actions.Messages;

namespace FOSCBot.Core.Domain.Miscellaneous.Ligma;

public class LigmaMiscellaneousAction : MessageAction
{
    public override bool CanHandleCurrentContext()
    {
        return (ctx.Update.Message.Text?.ToLower().Contains("so sad") ?? false) ||
               (ctx.Update.Message.Text?.ToLower().Contains("ligma") ?? false) ||
               (ctx.Update.Message.Text?.ToLower().Contains("p4cock") ?? false);
    }
}