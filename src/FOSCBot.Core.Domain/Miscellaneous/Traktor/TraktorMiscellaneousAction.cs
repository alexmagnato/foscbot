using System.Text.RegularExpressions;
using FOSCBot.Common.Helper;
using Navigator.Context;
using Navigator.Providers.Telegram.Actions.Messages;

namespace FOSCBot.Core.Domain.Miscellaneous.Traktor;

public class TraktorMiscellaneousAction : MessageAction
{
    public override bool CanHandle(INavigatorContext ctx)
    {
        return (RandomProvider.GetThreadRandom().NextDouble() <= 0.2d &&
                (ctx.GetMessageOrDefault()?.Text?.ToLower().Equals("blyat") ?? false))
               || (ctx.GetMessageOrDefault()?.Text?.ToLower().Equals("traktor") ?? false)
               || (ctx.GetMessageOrDefault()?.Text?.ToLower().Equals("блядь") ?? false)
               || (ctx.GetMessageOrDefault()?.Text?.ToLower().Equals("трактор") ?? false)
               || Regex.IsMatch(ctx.GetMessageOrDefault()?.Text ?? string.Empty, @"[Bb][Ll][Yy][Aa]+[Tt]+")
               || Regex.IsMatch(ctx.GetMessageOrDefault()?.Text ?? string.Empty, @"[Tt][Rr][Aa]+[KkCc][Tt][Oo]+[Rr]+");
    }
}