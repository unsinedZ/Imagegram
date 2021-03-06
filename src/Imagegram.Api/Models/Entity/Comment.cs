using System;
using Dapper.Contrib.Extensions;

namespace Imagegram.Api.Models.Entity
{
    [Table("Comments")]
    public class Comment : ICursoredModel
    {
        [ExplicitKey]
        public Guid Id { get; set; }

        public string Content { get; set; }

        public Guid PostId { get; set; }

        public Guid CreatorId { get; set; }

        public DateTime CreatedAt { get; set; }

        [Write(false)]
        public long ItemCursor { get; set; }
    }
}