using System;
using System.Collections.Generic;

namespace ExercicioComConjuntos_I.Entities
{
    class AccessLog
    {
        public string Name { get; set; }
        public DateTime Instant { get; set; }
        public HashSet<AccessLog> Set { get; set; }

        public AccessLog(string name, DateTime instant)
        {
            Name = name;
            Instant = instant;
        }
        
        public override int GetHashCode()
        {
            return Name.GetHashCode();
        }

        public override bool Equals(object obj)
        {
            if(!(obj is AccessLog))
            {
                return false;
            }
            AccessLog other = obj as AccessLog;
            return Name.Equals(other.Name);
        }
    }
}
