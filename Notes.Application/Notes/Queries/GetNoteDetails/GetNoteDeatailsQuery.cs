using MediatR;

namespace Notes.Application.Notes.Queries.GetNoteDetails
{
    public class GetNoteDeatailsQuery : IRequest<NoteDetailsVm>
    {
        public Guid UserId { get; set; }
        public Guid Id { get; set; }
    }
}
