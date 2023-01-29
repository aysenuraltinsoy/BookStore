using System.ComponentModel.Design;
using FluentValidation;

namespace WebApi.Application.GenreOperations.DeleteGenre
{
    public class DeleteGenreCommandValidator : AbstractValidator<DeleteGenreCommand>
    {
        public DeleteGenreCommandValidator()
        {
            RuleFor(command => command.GenreID).GreaterThan(0);

        }
    }

}