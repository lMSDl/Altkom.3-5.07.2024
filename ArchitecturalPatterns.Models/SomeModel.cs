using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArchitecturalPatterns.Models
{
    public partial class SomeModel : ObservableObject
    {
        [ObservableProperty]
        protected string value;
    }
}
