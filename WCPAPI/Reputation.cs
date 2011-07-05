﻿using System.Runtime.Serialization;

namespace WCPAPI
{
    public enum RepStanding
    {
        Hated = 0,
        Hostile = 1,
        Unfriendly = 2,
        Neutral = 3,
        Friendly = 4,
        Honored = 5,
        Revered = 6,
        Exalted = 7,
    }

    [DataContract]
    public class Reputation
    {
        [DataMember(Name = "id")]
        public int Id;
        [DataMember(Name = "name")]
        public string Name;
        [DataMember(Name = "standing")]
        public RepStanding Standing;
        [DataMember(Name = "value")]
        public int Value;
        [DataMember(Name = "max")]
        public int Max;
    }
}