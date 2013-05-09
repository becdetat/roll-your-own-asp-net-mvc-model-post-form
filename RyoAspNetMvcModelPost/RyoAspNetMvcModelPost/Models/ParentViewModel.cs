using System;
using System.Collections.Generic;
using System.Linq;

namespace RyoAspNetMvcModelPost.Models
{
    public class ParentViewModel
    {
        public ParentViewModel(string title, IEnumerable<ChildItemViewModel> children)
        {
            Title = title;
            Children = children;
        }

        // needed for magic view model reconstruction
        public ParentViewModel()
        {
        }

        public string Title { get; set; }
        public IEnumerable<ChildItemViewModel> Children { get; set; }
    }
}