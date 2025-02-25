using DecoratorApp.Common;

namespace DecoratorApp.HappyBirthday;

abstract class PastelDecorator : IPastel
{
    public virtual string Nombre => Target.Nombre!;
    private IPastel Target { get; }

    protected PastelDecorator(IPastel pastel)
    {
        Target = pastel;
    }

    public virtual Size GetDimensions(Size propaganda) => Target.GetDimensions(propaganda);            
}
