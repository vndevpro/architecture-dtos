using System;

namespace GdNet.Layers.Dtos
{
    public abstract class EntityDto
    {
        public Guid Id { get; set; }

        public DateTime CreatedAt { get; set; }

        public string CreatedBy { get; set; }

        public string Note { get; set; }
    }
}
