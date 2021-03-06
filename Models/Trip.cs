using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Vacation.Interfaces;

namespace Vacation.Models
{
    public class Trip : Virtual<int>
    {
        public int Id { get; set; }

        public string Name { get; set; }
    }

    public class Virtual<T> : IRepoItem<T>
    {
        public new T Id { get; set; }

        public new DateTime CreatedAt { get; set; }

        public new DateTime UpdatedAt { get; set; }
    }
}