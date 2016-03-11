using System;
using System.Collections.Generic;

namespace GdNet.Layers.Dtos.Args
{
    public abstract class AddAssociationsEventArgsBase<T> : EventArgs where T : EntityDto
    {
        public Guid ParentId { get; private set; }

        public IEnumerable<T> EntitiesDto { get; private set; }

        protected AddAssociationsEventArgsBase(Guid parentId, IEnumerable<T> entities)
        {
            ParentId = parentId;
            EntitiesDto = entities;
        }
    }
}
