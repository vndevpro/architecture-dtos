using System;

namespace GdNet.Layers.Dtos
{
    public abstract class EntityDtoT<TId> where TId : new()
    {
        public TId Id { get; set; }

        public DateTime CreatedAt { get; set; }

        public string CreatedBy { get; set; }

        public string Note { get; set; }
    }
}