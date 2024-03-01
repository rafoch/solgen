namespace Solgen.Shared.Abstractions.Tokens;

public abstract class Token
{
   public abstract string Value { get; }
   public abstract bool HasIdentifier { get; }
   
   public abstract string Type { get; } 
}

public class IdentifierToken : Token
{
   public IdentifierToken(string value)
   {
      Value = value;
   }
   public override string Value { get; }
   public override bool HasIdentifier => false;
   public override string Type => nameof(IdentifierToken);
}

public abstract class TokenWithoutIdentifier : Token
{
   public override bool HasIdentifier => false;
}

public abstract class TokenWithIdentifier : Token
{
   public override bool HasIdentifier => true;
}