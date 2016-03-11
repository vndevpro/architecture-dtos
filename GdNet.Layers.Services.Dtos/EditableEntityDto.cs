using System;

namespace GdNet.Layers.Dtos
{
    public abstract class EditableEntityDto : EntityDto
    {
        public string LastModifiedBy { get; set; }

        public DateTime? LastModifiedAt { get; set; }

        public bool IsAvailable { get; set; }

        public string State { get; set; }

        public DateTime? StateLastChangedAt { get; set; }
    }
}
