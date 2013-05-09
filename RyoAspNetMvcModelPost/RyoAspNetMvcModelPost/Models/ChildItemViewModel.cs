namespace RyoAspNetMvcModelPost.Models
{
    public class ChildItemViewModel
    {
        public ChildItemViewModel(string someIdentifier, string title, ChildState state)
        {
            SomeIdentifier = someIdentifier;
            State = state;
            Title = title;
        }

        public ChildItemViewModel()
        {
        }

        public string SomeIdentifier { get; set; }
        public string Title { get; set; }
        public ChildState State { get; set; }
    }
}