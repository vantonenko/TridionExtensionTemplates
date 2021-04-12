using System.Collections.Generic;
using Tridion.ContentManager;
using Tridion.ContentManager.Publishing;
using Tridion.ContentManager.Publishing.Resolving;

namespace ResolverExtension
{
    public class ResolverExtension
    {
        #region IResolver Members
        // This Resolve method executes after the default resolver has done its job and produced a set of resolved items.
        public void Resolve(IdentifiableObject item, ResolveInstruction instruction, PublishContext context, ISet<ResolvedItem> resolvedItems)
        {
            //resolvedItems.Add(...);
        }
        #endregion
    }
}
