using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_RepositoryPattern_Repository
{
    //Repository Pattern
    //CRUD
        //Create
        //Read
        //Update
        //Delete
    public class StreamingContentRepository
    {
        //Field

        //Access modifier
        private readonly List<StreamingContent> _contentDirectory = new List<StreamingContent>();

        //Create
        public bool AddContentToDirectory(StreamingContent content)
        {
            int startingCount = _contentDirectory.Count;

            _contentDirectory.Add(content);

            bool wasAdded = (_contentDirectory.Count > startingCount) ? true : false;
            return wasAdded;
        }
    }
}
