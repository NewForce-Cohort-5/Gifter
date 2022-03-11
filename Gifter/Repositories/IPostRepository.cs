using Gifter.Models;
using Gifter.Utils;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Gifter.Repositories
{
    public interface IPostRepository
    {
        void Add(Post post);
        void Delete(int id);
        List<Post> Search(string criterion, bool sortDescending);
        List<Post> GetAll();
        List<Post> GetAllWithComments();
        List<Post> GetPostsByDate(DateTime dates);
        Post GetById(int id);
        void Update(Post post);
    }
}