﻿using Final.Application.Common.Exceptions;
using Final.Application.Common.Interfaces;
using Final.Domain.Entities;
using MediatR;

namespace Final.Application.TodoLists.Commands.UpdateTodoList;

public record UpdateTodoListCommand : IRequest
{
    public int Id { get; init; }

    public string? Title { get; init; }
}

public class UpdateTodoListCommandHandler : IRequestHandler<UpdateTodoListCommand>
{
    private readonly IApplicationDbContext _context;

    public UpdateTodoListCommandHandler(IApplicationDbContext context)
    {
        _context = context;
    }

    public async Task Handle(UpdateTodoListCommand request, CancellationToken cancellationToken)
    {
        var entity = await _context.TodoLists
            .FindAsync(new object[] { request.Id }, cancellationToken);

        if (entity == null)
        {
            throw new NotFoundException(nameof(TodoList), request.Id);
        }

        entity.Title = request.Title;

        await _context.SaveChangesAsync(cancellationToken);

    }
}
