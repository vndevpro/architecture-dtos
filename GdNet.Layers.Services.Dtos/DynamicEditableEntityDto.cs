using System.Collections.Generic;

namespace GdNet.Layers.Dtos
{
    public abstract class DynamicEditableEntityDto : EditableEntityDto
    {
        public IList<EntityAttributeDto> Attributes { get; private set; }

        protected DynamicEditableEntityDto()
        {
            Attributes = new List<EntityAttributeDto>();
        }
    }
}
