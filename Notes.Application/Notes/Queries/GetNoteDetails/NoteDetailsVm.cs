using Notes.Application.Common.Mappings;
using Notes.Domain;
using AutoMapper;

namespace Notes.Application.Notes.Queries.GetNoteDetails
{
    public class NoteDetailsVm : IMapWith<Note>
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set;}

        public void Mapping(Profile profile)
        {
            profile.CreateMap<Note, NoteDetailsVm>()
                .ForMember(noteVm => noteVm.Title,
                opt => opt.MapFrom(note => note.Title))
                .ForMember(noteVm => noteVm.Description,
                opt => opt.MapFrom(note => note.Description))
                .ForMember(noteVm => noteVm.Id,
                opt => opt.MapFrom(note => note.Id))
                .ForMember(noteVm => noteVm.CreatedAt,
                opt => opt.MapFrom(note => note.CreatedAt))
                .ForMember(noteVm => noteVm.UpdatedAt,
                opt => opt.MapFrom(note => note.UpdatedAt));
        }
    }
}
