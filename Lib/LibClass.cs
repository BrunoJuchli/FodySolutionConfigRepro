using PropertyChanged;

namespace Lib
{
    [AddINotifyPropertyChangedInterface]
    public class LibClass
    {
        public string Foo { get; set; }
    }
}
