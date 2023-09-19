using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Final.Application.Common.Interfaces;
using Final.Domain.Entities;
using MediatR;

namespace Final.Application.NguoiDungs.Commands.CreateNguoiDung;
public record CreateNguoiDungCommand : IRequest<int>
{
    public string? HoTen { get; init; }
    public int Tuoi { get; init; }
    public int GioiTinh { get; init; }
    public string? Email { get; init; }
    public int SoDienThoai { get; init; }
}

public class CreateNguoiDungCommandHandler : IRequestHandler<CreateNguoiDungCommand, int>
{
    private readonly IApplicationDbContext _context;

    public CreateNguoiDungCommandHandler(IApplicationDbContext context)
    {
        _context = context;
    }

    public async Task<int> Handle(CreateNguoiDungCommand request, CancellationToken cancellationToken)
    {
        var entity = new NguoiDung
        {
            HoTen = request.HoTen,
            Tuoi = request.Tuoi,
            GioiTinh = request.GioiTinh,
            Email = request.Email,
            SoDienThoai = request.SoDienThoai
        };

        _context.NguoiDungs.Add(entity);

        await _context.SaveChangesAsync(cancellationToken);

        return entity.Id;
    }
}

