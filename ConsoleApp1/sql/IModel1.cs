using System.Data.Entity;

namespace ConsoleApp1.sql
{
    interface IModel1
    {
        IDbSet<city> city { get; set; }
    }
}