namespace Visitor;

public interface IElement
{
    void Visit(IVisitor visitor);
}