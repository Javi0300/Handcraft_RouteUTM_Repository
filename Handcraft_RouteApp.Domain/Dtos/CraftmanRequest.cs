//cSpell:disable
using System;

namespace Handcraft_RouteApp.Domain.Dtos
{
    public record CraftmanRequest(DateTime Birthday, char? Gender, string City);   
}