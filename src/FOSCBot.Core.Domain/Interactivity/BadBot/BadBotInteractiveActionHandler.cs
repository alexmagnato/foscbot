using FOSCBot.Common.Helper;
using MediatR;
using Navigator.Actions;
using Navigator.Context;

namespace FOSCBot.Core.Domain.Interactivity.BadBot;

public class BadBotInteractiveActionHandler : ActionHandler<BadBotInteractiveAction>
{
    public BadBotInteractiveActionHandler(INavigatorContext ctx) : base(ctx)
    {
    }

    public override async Task<Unit> Handle(BadBotInteractiveAction request, CancellationToken cancellationToken)
    {
        var reactions = new List<string>
        {
            "Sowwry uwu",
            "Perdoooooooon",
            "... :(",
            "Habla con mis dueños para que me arreglen òwó",
            "Acho que no es mi culpa, me programaron así"
        };

        var response = reactions.GetRandomFromList();
            
        await Ctx.Client.SendTextMessageAsync(Ctx.GetTelegramChat(), response, cancellationToken: cancellationToken);
            
        return Unit.Value;
    }
}