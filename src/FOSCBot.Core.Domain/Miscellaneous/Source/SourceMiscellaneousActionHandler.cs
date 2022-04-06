using FOSCBot.Common.Helper;
using FOSCBot.Core.Domain.Resources;
using MediatR;
using Navigator.Actions;
using Navigator.Context;
using Navigator.Providers.Telegram;
using Telegram.Bot;

namespace FOSCBot.Core.Domain.Miscellaneous.Source;

public class SourceMiscellaneousActionHandler : ActionHandler<SourceMiscellaneousAction>
{
    public SourceMiscellaneousActionHandler(INavigatorContextAccessor navigatorContextAccessor) : base(navigatorContextAccessor)
    {
    }

    public override async Task<Status> Handle(SourceMiscellaneousAction request, CancellationToken cancellationToken)
    {
        if (RandomProvider.GetThreadRandom().NextDouble() <= 0.5d)
            await NavigatorContext.GetTelegramClient().SendPhotoAsync(NavigatorContext.GetTelegramChat()!, CoreLinks.Source, cancellationToken: cancellationToken, replyToMessageId: request.MessageId);
        else 
            await NavigatorContext.GetTelegramClient().SendPhotoAsync(NavigatorContext.GetTelegramChat()!, CoreLinks.SourceChad, cancellationToken: cancellationToken, replyToMessageId: request.MessageId);

        return Success();
    }
}