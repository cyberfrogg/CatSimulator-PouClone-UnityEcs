using System.Collections.Generic;

namespace Db.Cat
{
    public interface ICatInteractionParametersBase
    {
        List<CatInteractionVo> Interactions { get; }
    }
}