﻿using Gifter.Models;
using Gifter.Utils;
using System.Collections.Generic;
using System.Linq;

namespace Gifter.Repositories
{
    public interface IPostRepository
    {
        void Add(Post post);
        void Delete(int id);
        List<Post> GetAll();
        List<Post> GetAllWithComments();
        Post GetById(int id);
        void Update(Post post);
    }
}