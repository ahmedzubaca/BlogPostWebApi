﻿namespace BackendEngineerAssignment.Models.Domain
{
    public class Tag
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<PostTag> PostTags { get; set; }
    }
}
