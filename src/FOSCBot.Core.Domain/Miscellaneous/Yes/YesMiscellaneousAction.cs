﻿using FOSCBot.Common.Helper;
using Navigator.Context;
using Navigator.Providers.Telegram.Actions.Messages;

namespace FOSCBot.Core.Domain.Miscellaneous.Yes;

public class YesMiscellaneousAction : MessageAction
{
    public override bool CanHandleCurrentContext()
    {
        if (RandomProvider.GetThreadRandom().NextDouble() < 0.5d )
        {
            return false;
        }

        return (ctx.Update.Message.Text?.Equals("YES") ?? false) ||
               (ctx.Update.Message.Text?.Equals("SI") ?? false);
    }
}