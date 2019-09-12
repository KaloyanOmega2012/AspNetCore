using System;
using System.Collections.Generic;
using LambdaForums.Models.Reply;

namespace LambdaForums.Models.Post
{
    public class PostIndexModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string AuthorId { get; set; }
        public string AuthorName { get; set; }
        public string AuthorImageUrl { get; set; }
        public int AuthorRating { get; set; }
        public DateTime Created { get; set; }
        public string PostContent { get; set; }

        //This are our replies to the post and they are stored in separate object PostreplyModel
        public IEnumerable<PostReplyModel> Replies { get; set; }

    }
}
