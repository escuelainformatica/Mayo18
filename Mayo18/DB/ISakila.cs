using System.Data.Entity;

namespace Mayo18.DB
{
    public interface ISakila
    {
        IDbSet<city> city { get; set; }
    }
}