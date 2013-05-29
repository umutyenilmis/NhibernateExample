

namespace Nhibernate.Core.Domain.Mappings
{
    public class ScoreMap :  EntityBaseMap<Score>
    {
        public ScoreMap()
        {
            Map(x => x.Points);
            References(x => x.DomainUser).Column("DomainUser");
        }
    }
}